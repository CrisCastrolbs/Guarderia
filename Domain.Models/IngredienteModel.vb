Imports System.ComponentModel.DataAnnotations
Imports Domain.ValueObjects
Imports Infrastructure.DataAccess

Public Class IngredienteModel
    'Atributos
    Private _IdIngrediente As Integer
    Private _Nombre As String

    Private _state As EntityState
    Private _editIngrediente As Boolean = False
    Private ingredienteRepository As IIngredienteRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property IdIngrediente As Integer
        Get
            Return _IdIngrediente
        End Get
        Set(value As Integer)
            _IdIngrediente = value
        End Set
    End Property
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El nombre, solo debe contener letras")>
    <Required(ErrorMessage:="Se requiere el campo Nombre del Ingrediente")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El nombre del Ingrediente debe contener un mínimo de 3 caracteres.")>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
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

    Public Property EdiIngrediente As Boolean
        Private Get
            Return _editIngrediente
        End Get
        Set(value As Boolean)
            _editIngrediente = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        ingredienteRepository = New IngredienteRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    ingredienteRepository.añadir(ingredienteEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    ingredienteRepository.editar(ingredienteEntity())
                    result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    infanteRepository.eliminar(CedulaInfante)
                    '    result = "Eliminado con éxito"
            End Select

        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = ex
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "el nombre de Ingrediente ya está registrado, pruebe con otro, ¡por favor!"
            Else
                result = ex.ToString()
            End If
        End Try
        Return result
    End Function

    Private Function ingredienteEntity() As Ingrediente 'crear objeto ->entidad usuario
        Dim ingredienteObject = New Ingrediente
        ingredienteObject.IdIngrediente = IdIngrediente
        ingredienteObject.Nombre = Nombre

        Return ingredienteObject
    End Function

    Public Function getAllIngrediente() As List(Of IngredienteModel)
        Dim result = ingredienteRepository.obtenerTodo()
        Dim ingredienteModelList As New List(Of IngredienteModel)

        For Each item As Ingrediente In result
            ingredienteModelList.Add(New IngredienteModel With {
                         .IdIngrediente = item.IdIngrediente,
                         .Nombre = item.Nombre})
        Next
        Return ingredienteModelList
    End Function

    Public Function getAIngredienteByValue(value As String) As List(Of IngredienteModel)
        Dim result = ingredienteRepository.obtenerPorValor(value)
        Dim ingredienteModelList As New List(Of IngredienteModel)

        For Each item As Ingrediente In result
            ingredienteModelList.Add(New IngredienteModel With {
                         .IdIngrediente = item.IdIngrediente,
                         .Nombre = item.Nombre})
        Next
        Return ingredienteModelList
    End Function

End Class
