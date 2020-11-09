Imports Infrastructure.DataAccess

Imports Domain.ValueObjects
Imports System.ComponentModel.DataAnnotations

Public Class InfanteModel
    'Atributos
    Private _CedulaInfante As Integer
    Private _Nombre As String
    Private _Apellido1 As String
    Private _Apellido2 As String
    Private _FechaNac As Date
    Private _Sexo As String
    Private _state As EntityState
    Private _editInfante As Boolean = False
    Private infanteRepository As IInfanteRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property CedulaInfante As Integer
        Get
            Return _CedulaInfante
        End Get
        Set(value As Integer)
            _CedulaInfante = value
        End Set
    End Property
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre, solo debe contener letras")>
    <Required(ErrorMessage:="Se requiere el campo Nombre del Infante")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre del infnate debe contener un mínimo de 3 caracteres.")>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    <Required(ErrorMessage:="Se requiere el campo Apellido1")>
    <StringLength(100, MinimumLength:=2, ErrorMessage:="El campo primer apellido debe contener un mínimo de 2 caracteres.")>
    Public Property Apellido1 As String
        Get
            Return _Apellido1
        End Get
        Set(value As String)
            _Apellido1 = value
        End Set
    End Property

    '<Required(ErrorMessage:="Se requiere el campo nombre")>

    <StringLength(100, MinimumLength:=2, ErrorMessage:="El campo segundo apellido debe contener un mínimo de 2 caracteres.")>
    Public Property Apellido2 As String
        Get
            Return _Apellido2
        End Get
        Set(value As String)
            _Apellido2 = value
        End Set
    End Property

    Public Property FechaNac As Date
        Get
            Return _FechaNac
        End Get
        Set(value As Date)
            _FechaNac = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _Sexo
        End Get
        Set(value As String)
            _Sexo = value
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

    Public Property EditInfante As Boolean
        Private Get
            Return _editInfante
        End Get
        Set(value As Boolean)
            _editInfante = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        infanteRepository = New InfanteRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    infanteRepository.añadir(infanteEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    infanteRepository.editar(infanteEntity())
                    result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    infanteRepository.eliminar(CedulaInfante)
                    '    result = "Eliminado con éxito"
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

    Private Function infanteEntity() As Infante 'crear objeto ->entidad usuario
        Dim infanteObject = New Infante
        infanteObject.CedulaInfante = CedulaInfante
        infanteObject.Nombre = Nombre
        infanteObject.Apellido1 = Apellido1
        infanteObject.Apellido2 = Apellido2
        infanteObject.FechaNac = FechaNac
        infanteObject.Sexo = Sexo
        Return infanteObject
    End Function

    Public Function getAllInfantes() As List(Of InfanteModel)
        Dim result = infanteRepository.obtenerTodo()
        Dim infanteModelList As New List(Of InfanteModel)

        For Each item As Infante In result
            infanteModelList.Add(New InfanteModel With {
                         .CedulaInfante = item.CedulaInfante,
                         .Nombre = item.Nombre,
                         .Apellido1 = item.Apellido1,
                         .Apellido2 = item.Apellido2,
                         .FechaNac = item.FechaNac,
                         .Sexo = item.Sexo})
        Next
        Return infanteModelList
    End Function

    Public Function getAInfanteByValue(value As String) As List(Of InfanteModel)
        Dim result = infanteRepository.obtenerPorValor(value)
        Dim infanteModelList As New List(Of InfanteModel)

        For Each item As Infante In result
            infanteModelList.Add(New InfanteModel With {
                         .CedulaInfante = item.CedulaInfante,
                         .Nombre = item.Nombre,
                         .Apellido1 = item.Apellido1,
                         .Apellido2 = item.Apellido2,
                         .FechaNac = item.FechaNac,
                         .Sexo = item.Sexo})
        Next
        Return infanteModelList
    End Function

    Public Function getAInfanteByValue2(value As String) As List(Of InfanteModel)
        Dim result = infanteRepository.obtenerPorValorInt(value)
        Dim infanteModelList As New List(Of InfanteModel)

        For Each item As Infante In result
            infanteModelList.Add(New InfanteModel With {
                         .CedulaInfante = item.CedulaInfante,
                         .Nombre = item.Nombre,
                         .Apellido1 = item.Apellido1,
                         .Apellido2 = item.Apellido2,
                         .FechaNac = item.FechaNac,
                         .Sexo = item.Sexo})
        Next
        Return infanteModelList
    End Function
End Class
