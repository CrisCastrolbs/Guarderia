Imports System.ComponentModel.DataAnnotations
Imports Domain.ValueObjects
Imports Infrastructure.DataAccess

Public Class PlatoMenuModel

    'Atributos
    Private _IdPlatoMenu As Integer
    Private _IdPlato As Integer
    Private _IdMenu As Integer
    Private _state As EntityState
    Private _editPlatoMenu As Boolean = False
    Private PlatoMenuRepository As IPlatoMenuRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property IdPlatoMenu As Integer
        Get
            Return _IdPlatoMenu
        End Get
        Set(value As Integer)
            _IdPlatoMenu = value
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


    Public Property IdMenu As Integer
        Get
            Return _IdMenu
        End Get
        Set(value As Integer)
            _IdMenu = value
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


    Public Property EditPlatoMenu As Boolean
        Private Get
            Return _editPlatoMenu
        End Get
        Set(value As Boolean)
            _editPlatoMenu = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        PlatoMenuRepository = New PlatoMenuRepository()
    End Sub

    'Metodos , comportamientos
    Public Function saveChanges() As String 'insertar, editar o eliminar
        Dim result As String = Nothing
        Try
            Select Case State
                Case EntityState.Added
                    PlatoMenuRepository.añadir(platomenuEntity())
                    result = "Grabado con éxito"
                Case EntityState.Edited
                    PlatoMenuRepository.editar(platomenuEntity())
                    result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    menuRepository.eliminar(IdMenu)
                    '    result = "Eliminado con éxito"
            End Select

        Catch ex As Exception
            Dim sqlEx As System.Data.SqlClient.SqlException = ex
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "El Plato ya está registrado, pruebe con otro, ¡por favor!"
            Else
                result = ex.ToString()
            End If
        End Try
        Return result
    End Function

    Private Function platomenuEntity() As PlatoMenu 'crear objeto ->entidad usuario
        Dim platomenuObject = New PlatoMenu
        platomenuObject.IdPlatoMenu = IdPlatoMenu
        platomenuObject.IdPlato = IdPlato
        platomenuObject.IdMenu = IdMenu
        Return platomenuObject
    End Function

    Public Function getAllPlatoMenu() As List(Of PlatoMenuModel)
        Dim result = PlatoMenuRepository.obtenerTodo()
        Dim PlatoMenuModelList As New List(Of PlatoMenuModel)

        For Each item As PlatoMenu In result
            PlatoMenuModelList.Add(New PlatoMenuModel With {
                         .IdPlatoMenu = item.IdPlatoMenu,
                         .IdPlato = item.IdPlato,
                         .IdMenu = item.IdMenu})
        Next
        Return PlatoMenuModelList
    End Function

    Public Function getAPlatoMenuByValue(value As String) As List(Of PlatoMenuModel)
        Dim result = PlatoMenuRepository.obtenerPorValor(value)
        Dim PlatoMenuModelList As New List(Of PlatoMenuModel)

        For Each item As PlatoMenu In result
            PlatoMenuModelList.Add(New PlatoMenuModel With {
                         .IdPlatoMenu = item.IdPlatoMenu,
                         .IdPlato = item.IdPlato,
                         .IdMenu = item.IdMenu})
        Next
        Return PlatoMenuModelList
    End Function

End Class