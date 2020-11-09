Imports Infrastructure.DataAccess
Imports Infrastructure.Common
Imports Domain.ValueObjects
Imports System.ComponentModel.DataAnnotations

Public Class ResponsablePagoModel
    'Atributos
    Private _CedulaRespPago As Integer
    Private _Nombre As String
    Private _Apellido1 As String
    Private _Apellido2 As String
    Private _Direccion As String
    Private _Distrito As String
    Private _Canton As String
    Private _Provincia As String
    Private _Telefono As Integer
    Private _NumCuenta As String
    Private _AutorizadoRetirar As Boolean

    Private _state As EntityState
    Private _editResponsablePago As Boolean = False
    Private responsablePagoRepository As IResponsablePagoRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property CedulaRespPago As Integer
        Get
            Return _CedulaRespPago
        End Get
        Set(value As Integer)
            _CedulaRespPago = value
        End Set
    End Property
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre, solo debe contener letras")>
    <Required(ErrorMessage:="Se requiere el campo Nombre del Responsable Pago")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre del responsable pago debe contener un mínimo de 3 caracteres.")>
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

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Distrito As String
        Get
            Return _Distrito
        End Get
        Set(value As String)
            _Distrito = value
        End Set
    End Property

    Public Property Canton As String
        Get
            Return _Canton
        End Get
        Set(value As String)
            _Canton = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _Provincia
        End Get
        Set(value As String)
            _Provincia = value
        End Set
    End Property

    Public Property Telefono As Integer
        Get
            Return _Telefono
        End Get
        Set(value As Integer)
            _Telefono = value
        End Set
    End Property

    Public Property NumCuenta As String
        Get
            Return _NumCuenta
        End Get
        Set(value As String)
            _NumCuenta = value
        End Set
    End Property

    Public Property AutorizadoRetirar As Boolean
        Get
            Return _AutorizadoRetirar
        End Get
        Set(value As Boolean)
            _AutorizadoRetirar = value
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

    Public Property EditResponsablePago As Boolean
        Private Get
            Return _editResponsablePago
        End Get
        Set(value As Boolean)
            _editResponsablePago = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        responsablePagoRepository = New ResponsablePagoRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    responsablePagoRepository.añadir(responsablePagoEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    responsablePagoRepository.editar(responsablePagoEntity())
                    result = "Editado con éxito"

            End Select

        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = ex
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "el nombre de responsable pago ya está registrado, pruebe con otro, ¡por favor!"
            Else
                result = ex.ToString()
            End If
        End Try
        Return result
    End Function

    Private Function responsablePagoEntity() As ResponsablePago 'crear objeto ->entidad usuario
        Dim responsablePagoObject = New ResponsablePago
        responsablePagoObject.CedulaRespPago = CedulaRespPago
        responsablePagoObject.Nombre = Nombre
        responsablePagoObject.Apellido1 = Apellido1
        responsablePagoObject.Apellido2 = Apellido2
        responsablePagoObject.Direccion = Direccion
        responsablePagoObject.Distrito = Distrito
        responsablePagoObject.Canton = Canton
        responsablePagoObject.Provincia = Provincia
        responsablePagoObject.Telefono = Telefono
        responsablePagoObject.NumCuenta = NumCuenta
        responsablePagoObject.AutorizadoRetirar = AutorizadoRetirar
        Return responsablePagoObject
    End Function

    Public Function getAllInfantes() As List(Of ResponsablePagoModel)
        Dim result = responsablePagoRepository.obtenerTodo()
        Dim responsablePagoModelList As New List(Of ResponsablePagoModel)

        For Each item As ResponsablePago In result
            responsablePagoModelList.Add(New ResponsablePagoModel With {
                         .CedulaRespPago = item.CedulaRespPago,
                         .Nombre = item.Nombre,
                         .Apellido1 = item.Apellido1,
                         .Apellido2 = item.Apellido2,
                         .Direccion = item.Direccion,
                         .Distrito = item.Distrito,
                         .Canton = item.Canton,
                         .Provincia = item.Provincia,
                         .Telefono = item.Telefono,
                         .NumCuenta = item.NumCuenta,
                         .AutorizadoRetirar = item.AutorizadoRetirar})
        Next
        Return responsablePagoModelList
    End Function

    Public Function getAResponsablePagoByValue(value As String) As List(Of ResponsablePagoModel)
        Dim result = responsablePagoRepository.obtenerPorValor(value)
        Dim responsablePagoModelList As New List(Of ResponsablePagoModel)

        For Each item As ResponsablePago In result
            responsablePagoModelList.Add(New ResponsablePagoModel With {
                         .CedulaRespPago = item.CedulaRespPago,
                         .Nombre = item.Nombre,
                         .Apellido1 = item.Apellido1,
                         .Apellido2 = item.Apellido2,
                         .Direccion = item.Direccion,
                         .Distrito = item.Distrito,
                         .Canton = item.Canton,
                         .Provincia = item.Provincia,
                         .Telefono = item.Telefono,
                         .NumCuenta = item.NumCuenta,
                         .AutorizadoRetirar = item.AutorizadoRetirar})
        Next
        Return responsablePagoModelList
    End Function

End Class
