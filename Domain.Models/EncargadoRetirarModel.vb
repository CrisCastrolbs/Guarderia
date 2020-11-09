Imports Infrastructure.DataAccess
Imports Infrastructure.Common
Imports Domain.ValueObjects
Imports System.ComponentModel.DataAnnotations
Public Class EncargadoRetirarModel
    'Atributos
    Private _CedulaEncargado As Integer
    Private _Nombre As String
    Private _Apellido1 As String
    Private _Apellido2 As String
    Private _Direccion As String
    Private _Distrito As String
    Private _Canton As String
    Private _Provincia As String
    Private _NumTelefono1 As Integer
    Private _NumTelefono2 As Integer
    Private _state As EntityState
    Private _editEncargadoRetirar As Boolean = False
    Private encargadoRetirarRepository As IEncargadoRetirarRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property CedulaEncargado As Integer
        Get
            Return _CedulaEncargado
        End Get
        Set(value As Integer)
            _CedulaEncargado = value
        End Set
    End Property
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre, solo debe contener letras")>
    <Required(ErrorMessage:="Se requiere el campo Nombre del Encargado")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre del encargado debe contener un mínimo de 3 caracteres.")>
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


    Public Property State As EntityState
        Private Get
            Return _state
        End Get
        Set(value As EntityState)
            _state = value
        End Set
    End Property

    Public Property EditEncargadoRetirar As Boolean
        Private Get
            Return _editEncargadoRetirar
        End Get
        Set(value As Boolean)
            _editEncargadoRetirar = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        encargadoRetirarRepository = New EncargadoRetirarRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    encargadoRetirarRepository.añadir(encargadoRetirarEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    encargadoRetirarRepository.editar(encargadoRetirarEntity())
                    result = "Editado con éxito"

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

    Private Function encargadoRetirarEntity() As EncargadoRetirar 'crear objeto ->entidad usuario
        Dim encargadoRetirarObject = New EncargadoRetirar
        encargadoRetirarObject.CedulaEncargado = CedulaEncargado
        encargadoRetirarObject.Nombre = Nombre
        encargadoRetirarObject.Apellido1 = Apellido1
        encargadoRetirarObject.Apellido2 = Apellido2
        encargadoRetirarObject.Direccion = Direccion
        encargadoRetirarObject.Distrito = Distrito
        encargadoRetirarObject.Canton = Canton
        encargadoRetirarObject.Provincia = Apellido1
        encargadoRetirarObject.NumTelefono1 = Apellido2
        encargadoRetirarObject.NumTelefono2 = Direccion
        Return encargadoRetirarObject
    End Function

    Public Function getAllEncargadosRetirar() As List(Of EncargadoRetirarModel)
        Dim result = encargadoRetirarRepository.obtenerTodo()
        Dim encargadoRetirarModelList As New List(Of EncargadoRetirarModel)

        For Each item As EncargadoRetirar In result
            encargadoRetirarModelList.Add(New EncargadoRetirarModel With {
                         .CedulaEncargado = item.CedulaEncargado,
                         .Nombre = item.Nombre,
                         .Apellido1 = item.Apellido1,
                         .Apellido2 = item.Apellido2,
                         .Direccion = item.Direccion,
                         .Distrito = item.Distrito,
                         .Provincia = item.NumTelefono1,
                         ._NumTelefono2 = _NumTelefono2})
        Next
        Return encargadoRetirarModelList
    End Function

    Public Function getAInfanteByValue(value As String) As List(Of EncargadoRetirarModel)
        Dim result = encargadoRetirarRepository.obtenerPorValor(value)
        Dim encargadoRetirarModelList As New List(Of EncargadoRetirarModel)

        For Each item As EncargadoRetirar In result
            encargadoRetirarModelList.Add(New EncargadoRetirarModel With {
                        .CedulaEncargado = item.CedulaEncargado,
                         .Nombre = item.Nombre,
                         .Apellido1 = item.Apellido1,
                         .Apellido2 = item.Apellido2,
                         .Direccion = item.Direccion,
                         .Distrito = item.Distrito,
                         .Provincia = item.NumTelefono1,
                         ._NumTelefono2 = _NumTelefono2})
        Next
        Return encargadoRetirarModelList
    End Function
End Class
