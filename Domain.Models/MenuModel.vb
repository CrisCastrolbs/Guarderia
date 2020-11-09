Imports System.ComponentModel.DataAnnotations
Imports Domain.ValueObjects
Imports Infrastructure.DataAccess

Public Class MenuModel
    'Atributos
    Private _IdMenu As Integer
    Private _Dia As String
    Private _state As EntityState
    Private _editMenu As Boolean = False
    Private MenuRepository As IMenuRepository 'Interfaz - abstraccion

    'Propiedades - GET, SET y Validaciones de datos

    Public Property IdMenu As Integer
        Get
            Return _IdMenu
        End Get
        Set(value As Integer)
            _IdMenu = value
        End Set
    End Property
    <RegularExpression("^[a-zA-Z ]+$", ErrorMessage:="El Día, solo debe contener letras")>
    <Required(ErrorMessage:="Se requiere el campo Dia")>
    <StringLength(100, MinimumLength:=3, ErrorMessage:="El día debe contener un mínimo de 3 caracteres.")>
    Public Property Dia As String
        Get
            Return _Dia
        End Get
        Set(value As String)
            _Dia = value
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


Public Property EditMenu As Boolean
    Private Get
        Return _editMenu
    End Get
    Set(value As Boolean)
        _editMenu = value
    End Set
End Property

'Constructores
Public Sub New()
    MenuRepository = New MenuRepository()
End Sub

'Metodos , comportamientos
Public Function saveChanges() As String 'insertar, editar o eliminar
    Dim result As String = Nothing
    Try
        Select Case State
            Case EntityState.Added
                MenuRepository.añadir(menuEntity())
                result = "Grabado con éxito"
            Case EntityState.Edited
                MenuRepository.editar(menuEntity())
                result = "Editado con éxito"
                    'Case EntityState.Removed
                    '    menuRepository.eliminar(IdMenu)
                    '    result = "Eliminado con éxito"
            End Select

    Catch ex As Exception
        Dim sqlEx As System.Data.SqlClient.SqlException = ex
        If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                result = "[ : ( ] UPS¡ Registro duplicado" &
                    vbNewLine & "El día ya está registrado, pruebe con otro, ¡por favor!"
            Else
            result = ex.ToString()
        End If
    End Try
    Return result
End Function

    Private Function menuEntity() As Menu 'crear objeto ->entidad usuario
        Dim menuObject = New Menu
        menuObject.IdMenu = IdMenu
        menuObject.Dia = Dia
        Return menuObject
    End Function

    Public Function getAllMenu() As List(Of MenuModel)
        Dim result = MenuRepository.obtenerTodo()
        Dim MenuModelList As New List(Of MenuModel)

        For Each item As Menu In result
            MenuModelList.Add(New MenuModel With {
                         .IdMenu = item.IdMenu,
                         .Dia = item.Dia})
        Next
        Return MenuModelList
    End Function

    Public Function getAMenuByValue(value As String) As List(Of MenuModel)
        Dim result = MenuRepository.obtenerPorValor(value)
        Dim MenuModelList As New List(Of MenuModel)

        For Each item As Menu In result
            MenuModelList.Add(New MenuModel With {
                         .IdMenu = item.IdMenu,
                         .Dia = item.Dia})
        Next
        Return MenuModelList
    End Function

End Class
