Imports Infrastructure.DataAccess
Imports Infrastructure.Common
Imports Infrastructure.MailServices
Imports Domain.ValueObjects
Imports System.ComponentModel.DataAnnotations

Public Class UserModel
    'Atributos
    Private _id As Integer
    Private _userName As String
    Private _password As String
    Private _firstName As String
    Private _lastName As String
    Private _position As String
    Private _email As String
    Private _profile As Byte() 'Foto de perfil
    Private _state As EntityState
    Private _editMyUserProfile As Boolean = False
    Private userRepository As IUserRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    <Required(ErrorMessage:="Se requiere la contraseña del nombre de usuario")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre de usuario debe contener un mínimo de 3 caracteres.")>
    Public Property UserName As String
        Get
            Return _userName
        End Get
        Set(value As String)
            _userName = value
        End Set
    End Property

    <Required(ErrorMessage:="Se requiere el campo contraseña")>
    <StringLength(100, MinimumLength:=5, ErrorMessage:="La contraseña debe contener un mínimo de 5 caracteres.")>
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    <Required(ErrorMessage:="Se requiere el campo nombre")>
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre, solo debe contener letras")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El campo nombre debe contener un mínimo de 3 caracteres.")>
    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    <Required>
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El apellido, solo debe contener letras")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El apellido debe contener un mínimo de 3 caracteres.")>
    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property Position As String
        Get
            Return _position
        End Get
        Set(value As String)
            _position = value
        End Set
    End Property

    <Required>
    <EmailAddress>
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Profile As Byte()
        Get
            Return _profile
        End Get
        Set(value As Byte())
            _profile = value
        End Set
    End Property

    Public Property State As EntityState
        Private Get
            Return _state
        End Get
        Set(value As EntityState)
            _state = value
        End Set
    End Property

    Public Property editMyUserProfile As Boolean
        Private Get
            Return _editMyUserProfile
        End Get
        Set(value As Boolean)
            _editMyUserProfile = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        userRepository = New UserRepository()
    End Sub

    'RECOMENDACIÓN 
    '1) Si notas que los campos(atributos-propiedades) de los modelos de dominio (userModel,etc) llegan a limitarse
    'para mostrar los datos directamente en la interfaz gráfica, crea el componente MODELOS DE VISTA,
    'en ella agrega clases con los campos(atributos del objeto) necesarios para mostrar en la interfaz gráfica.
    'Ver: https://youtu.be/SGXR0pDCP38?t=2878
    '2) Si un modelo de dominio (entidad comercial) tiene mas de 2 clases, agrupa las clases en una sola entidad (Carpeta),
    'Ejemplo: Carpeta([OrderSales]->{orderModel.cs, orderReport.cs, salesListing.cs, NetSalesByPeriod.cs,etc })
    'Ver: https://youtu.be/lAKJL3Crvso?t=2792

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    userRepository.add(userEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    userRepository.edit(userEntity())
                    If editMyUserProfile = True Then 'si el usuario es quien edita sus datos, volvemos a iniciar sesion con los nuevos datos para actualizar los datos del cache y asi actualizar tambien en la interfaz grafica
                        logIn(UserName, Password)
                    End If
                    result = "Editado con éxito"
                Case EntityState.Removed
                    userRepository.remove(Id)
                    result = "Eliminado con éxito"
            End Select

        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = ex
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "el nombre de usuario ya está registrado, pruebe con otro, ¡por favor!"
            Else
                result = ex.ToString()
            End If
        End Try
        Return result
    End Function

    Private Function userEntity() As User 'crear objeto ->entidad usuario
        Dim userObject = New User
        userObject.id = Id
        userObject.userName = UserName
        userObject.password = Password
        userObject.firstName = FirstName
        userObject.lastName = LastName
        userObject.position = Position
        userObject.email = Email
        userObject.profile = Profile
        Return userObject
    End Function

    Public Function logIn(user, pass) As Boolean 'iniciar sesion
        Dim result As Boolean
        'Try
        result = userRepository.login(user, pass)
        'Catch ex As Exception
        '    Throw New System.ArgumentException("An error as ocurred" & vbNewLine & ex.ToString())
        'End Try
        Return result
    End Function

    Public Function recoverPassword(requestingUser As String) As String 'recuperar contraseña por correo
        Dim user = userRepository.getByValue(requestingUser) 'buscar usuario por correo electronico
        If user.Count > 0 Then
            For Each item As User In user
                FirstName = item.firstName & ", " & item.lastName
                Email = item.email
                Password = item.password
            Next

            Dim mailServices = New SystemSupportMail()
            mailServices.sendMail( '/enviar correo al usuario
                        subject:="SYSTEM: Solicitud de recuperación de contraseña",
                        body:="Hola " & FirstName & vbLf & "Usted, solicitó recuperar su contraseña." & vbLf &
                        "Su contraseña actual es: " & Password & vbLf &
                        "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema",
                        receiverMail:=New List(Of String) From {Email})

            Return "Hola " & FirstName & vbLf & " usted, solicitó recuperar su contraseña." & vbLf &
                        "Por Favor, revise su email brindado: " & Email & vbLf &
                        "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema"
        Else
            Return "Lo sentimos, no tienes una cuenta con ese correo electrónico o nombre de usuario."
        End If
    End Function

    Public Function getAllUsers() As List(Of UserModel)
        Dim result = userRepository.getAll()
        Dim userModelList As New List(Of UserModel)

        For Each item As User In result
            userModelList.Add(New UserModel With {
                         .Id = item.id,
                         .UserName = item.userName,
                         .Password = item.password,
                         .FirstName = item.firstName,
                         .LastName = item.lastName,
                         .Position = item.position,
                         .Email = item.email,
                         .Profile = item.profile})
        Next
        Return userModelList
    End Function

    Public Function getAUserByValue(value As String) As List(Of UserModel)
        Dim result = userRepository.getByValue(value)
        Dim userModelList As New List(Of UserModel)

        For Each item As User In result
            userModelList.Add(New UserModel With {
                         .Id = item.id,
                         .UserName = item.userName,
                         .Password = item.password,
                         .FirstName = item.firstName,
                         .LastName = item.lastName,
                         .Position = item.position,
                         .Email = item.email,
                         .Profile = item.profile})
        Next
        Return userModelList
    End Function

End Class
