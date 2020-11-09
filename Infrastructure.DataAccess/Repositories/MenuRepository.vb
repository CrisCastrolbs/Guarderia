Imports System.Data.SqlClient

Public Class MenuRepository
    Inherits MasterRepository
    Implements IMenuRepository


    'agregar nuevo Menu
    Public Function añadir(entity As Menu) As Integer Implements ICrudRepository(Of Menu).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdMenu", entity.IdMenu))
        parameters.Add(New SqlParameter("@Dia", entity.Dia))


        Return ExecuteNonQuery("SP_InsertarMenu", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function

    'editar Menu
    Public Function editar(entity As Menu) As Integer Implements ICrudRepository(Of Menu).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Dia", entity.Dia))
        parameters.Add(New SqlParameter("@IdMenu", entity.IdMenu))
        Return ExecuteNonQuery("SP_ActualizarMenu", parameters)
    End Function

    '//obtener todos los datos de Menu
    Public Function obtenerTodo() As IEnumerable(Of Menu) Implements ICrudRepository(Of Menu).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllMenu")
        Dim listMenu = New List(Of Menu)
        For Each item As DataRow In result.Rows
            Dim menuEntity = New Menu 'crear objeto usuario
            menuEntity.IdMenu = Convert.ToInt32(item(0))
            menuEntity.Dia = item(1).ToString

            'agregar entidad menu a la lista
            listMenu.Add(menuEntity)
        Next
        Return listMenu
    End Function

    '//buscar por valor (buscar por nombre de Menu)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of Menu) Implements ICrudRepository(Of Menu).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectMenu", parameters)
        Dim listMenu = New List(Of Menu)
        For Each item As DataRow In result.Rows
            Dim menuEntity = New Menu 'crear objeto ifante
            menuEntity.IdMenu = Convert.ToInt32(item(0))
            menuEntity.Dia = item(1).ToString
            'agregar entidad infante a la lista
            listMenu.Add(menuEntity)
        Next
        Return listMenu
    End Function

    '//buscar por valor (buscar por Id)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of Menu) Implements ICrudRepository(Of Menu).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectMenuId", parameters)
        Dim listMenu = New List(Of Menu)
        For Each item As DataRow In result.Rows
            Dim menuEntity = New Menu 'crear objeto ifante
            menuEntity.IdMenu = Convert.ToInt32(item(0))
            menuEntity.Dia = item(1).ToString
            'agregar entidad menu a la lista
            listMenu.Add(menuEntity)
        Next
        Return listMenu
    End Function
    'Public Function eliminar(IdMenu As Integer) As Integer Implements ICrudRepository(Of Menu).eliminar
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@idmenu", IdMenu))
    '    Return ExecuteNonQuery("EliminarMenu", parameters)
    'End Function
End Class
