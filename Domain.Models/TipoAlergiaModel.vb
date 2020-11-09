Imports System.ComponentModel.DataAnnotations
Imports Domain.ValueObjects
Imports Infrastructure.DataAccess

Public Class TipoAlergiaModel

    'Atributos
    Private _IdTipoAlergia As Integer
    Private _Nombre As String
    Private _Descripcion As String
    Private _state As EntityState
    Private _editTipoAlergia As Boolean = False
    Private tipoAlergiaRepository As ITipoAlergiaRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property IdTipoAlergia As Integer
        Get
            Return _IdTipoAlergia
        End Get
        Set(value As Integer)
            _IdTipoAlergia = value
        End Set
    End Property
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre, solo debe contener letras")>
    <Required(ErrorMessage:="Se requiere el campo Nombre de Tipo de Alergia")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre del tipo de alergia debe contener un mínimo de 3 caracteres.")>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    <Required(ErrorMessage:="Se requiere el campo Descripcion")>
    <StringLength(100, MinimumLength:=2, ErrorMessage:="El campo Descripcion debe contener un mínimo de 2 caracteres.")>
    Public Property Descripcion As String
        Get
            Return _Descripcion

        End Get
        Set(value As String)
            _Descripcion = value
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
            Return _editTipoAlergia

        End Get
        Set(value As Boolean)
            _editTipoAlergia = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        tipoAlergiaRepository = New TipoAlergiaRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    tipoAlergiaRepository.añadir(tipoAlergiaEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    tipoAlergiaRepository.editar(tipoAlergiaEntity())
                    result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    tipoAlergiaRepository.eliminar(IdTipoAlergia)
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

    Private Function tipoAlergiaEntity() As TipoAlergia 'crear objeto ->entidad usuario
        Dim tipoAlergiaObject = New TipoAlergia
        tipoAlergiaObject.IdTipoAlergia = IdTipoAlergia
        tipoAlergiaObject.Nombre = Nombre
        tipoAlergiaObject.Descripcion = Descripcion
        Return tipoAlergiaObject
    End Function

    Public Function getAllTipoAlergia() As List(Of TipoAlergiaModel)
        Dim result = tipoAlergiaRepository.obtenerTodo()
        Dim tipoAlergiaModelList As New List(Of TipoAlergiaModel)

        For Each item As TipoAlergia In result
            tipoAlergiaModelList.Add(New TipoAlergiaModel With {
                         .IdTipoAlergia = item.IdTipoAlergia,
                         .Nombre = item.Nombre,
                         .Descripcion = item.Descripcion})
        Next
        Return tipoAlergiaModelList
    End Function

    Public Function getATipoAlergiaByValue(value As String) As List(Of TipoAlergiaModel)
        Dim result = tipoAlergiaRepository.obtenerPorValor(value)
        Dim tipoAlergiaModelList As New List(Of TipoAlergiaModel)

        For Each item As TipoAlergia In result
            tipoAlergiaModelList.Add(New TipoAlergiaModel With {
                         .IdTipoAlergia = item.IdTipoAlergia,
                         .Nombre = item.Nombre,
                         .Descripcion = item.Descripcion})
        Next
        Return tipoAlergiaModelList
    End Function
End Class
