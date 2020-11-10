Imports Domain.ValueObjects
Imports Infrastructure.DataAccess

Public Class IngredientePlatoModel
    'Atributos
    Private _IdIngredientePlato As Integer
    Private _IdPlato As Integer
    Private _IdIngrediente As Integer
    Private _state As EntityState
    Private _editIngredientePlato As Boolean = False
    Private IngredientePlatoRepository As IIngredientePlatoRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property IdIngredientePlato As Integer
        Get
            Return _IdIngredientePlato
        End Get
        Set(value As Integer)
            _IdIngredientePlato = value
        End Set
    End Property

    Public Property IdPlato As Integer
        Get
            Return _IdPlato
        End Get
        Set(value As Integer)
            _IdPlato = value
        End Set
    End Property


    Public Property IdIngrediente As Integer
        Get
            Return _IdIngrediente
        End Get
        Set(value As Integer)
            _IdIngrediente = value
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


    Public Property EditIngredientePlato As Boolean
        Private Get
            Return _editIngredientePlato
        End Get
        Set(value As Boolean)
            _editIngredientePlato = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        IngredientePlatoRepository = New IngredientePlatoRepository()
    End Sub

    'Metodos , comportamientos


    Private Function ingredienteplatoEntity() As IngredientePlato 'crear objeto ->entidad usuario
        Dim ingredienteplatoObject = New IngredientePlato
        ingredienteplatoObject.IdIngredientePlato = IdIngredientePlato
        ingredienteplatoObject.IdPlato = IdPlato
        ingredienteplatoObject.IdIngrediente = IdIngrediente
        Return ingredienteplatoObject
    End Function

    Public Function getAllIngredientePlato() As List(Of IngredientePlatoModel)
        Dim result = IngredientePlatoRepository.obtenerTodo()
        Dim IngredientePlatoModelList As New List(Of IngredientePlatoModel)

        For Each item As IngredientePlato In result
            IngredientePlatoModelList.Add(New IngredientePlatoModel With {
                         .IdIngredientePlato = item.IdIngredientePlato,
                         .IdPlato = item.IdPlato,
                         .IdIngrediente = item.IdIngrediente})
        Next
        Return IngredientePlatoModelList
    End Function

    Public Function getAIngredientePlatoByValue(value As String) As List(Of IngredientePlatoModel)
        Dim result = IngredientePlatoRepository.obtenerPorValor(value)
        Dim IngredientePlatoModelList As New List(Of IngredientePlatoModel)

        For Each item As IngredientePlato In result
            IngredientePlatoModelList.Add(New IngredientePlatoModel With {
                         .IdIngredientePlato = item.IdIngredientePlato,
                         .IdPlato = item.IdPlato,
                         .IdIngrediente = item.IdIngrediente})
        Next
        Return IngredientePlatoModelList
    End Function

    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.
                    IngredientePlatoRepository.añadir(ingredienteplatoEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    IngredientePlatoRepository.editar(ingredienteplatoEntity())
                    result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    menuRepository.eliminar(IdMenu)
                    '    result = "Eliminado con éxito"
            End Select

        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = ex
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "El Ingrediente del plato ya está registrado, pruebe con otro, ¡por favor!"
            Else
                result = ex.ToString()
            End If
        End Try
        Return result

End Class