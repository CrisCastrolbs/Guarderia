Imports System.Data.SqlClient

Public Class PlatoMenuRepository
    Inherits MasterRepository
    Implements IPlatoMenuRepository


    'agregar nuevo PlatoMenu
    Public Function añadir(entity As PlatoMenu) As Integer Implements ICrudRepository(Of PlatoMenu).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdPlatoMenu", entity.IdPlatoMenu))
        parameters.Add(New SqlParameter("@IdPlato", entity.IdPlato))
        parameters.Add(New SqlParameter("@IdMenu", entity.IdMenu))


        Return ExecuteNonQuery("SP_InsertarPlatoMenu", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function

    'editar PlatoMenu
    Public Function editar(entity As PlatoMenu) As Integer Implements ICrudRepository(Of PlatoMenu).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdMenu", entity.IdMenu))
        parameters.Add(New SqlParameter("@IdPlato", entity.IdPlato))
        parameters.Add(New SqlParameter("@IdPlatoMenu", entity.IdPlatoMenu))
        Return ExecuteNonQuery("SP_ActualizarPlatoMenu", parameters)
    End Function

    '//obtener todos los datos de PlatoMenu
    Public Function obtenerTodo() As IEnumerable(Of PlatoMenu) Implements ICrudRepository(Of PlatoMenu).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllPlatoMenu")
        Dim listPlatoMenu = New List(Of PlatoMenu)
        For Each item As DataRow In result.Rows
            Dim platomenuEntity = New PlatoMenu 'crear objeto usuario
            platomenuEntity.IdPlatoMenu = Convert.ToInt32(item(0))
            platomenuEntity.IdPlato = Convert.ToInt32(item(0))
            platomenuEntity.IdMenu = Convert.ToInt32(item(0))

            'agregar entidad menu a la lista
            listPlatoMenu.Add(platomenuEntity)
        Next
        Return listPlatoMenu
    End Function

    '//buscar por valor (buscar por nombre de PlatoMenu)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of PlatoMenu) Implements ICrudRepository(Of PlatoMenu).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectPlatoMenu", parameters)
        Dim listPlatoMenu = New List(Of PlatoMenu)
        For Each item As DataRow In result.Rows
            Dim platomenuEntity = New PlatoMenu 'crear objeto ifante
            platomenuEntity.IdPlatoMenu = Convert.ToInt32(item(0))
            platomenuEntity.IdPlato = Convert.ToInt32(item(0))
            platomenuEntity.IdMenu = Convert.ToInt32(item(0))
            'agregar entidad infante a la lista
            listPlatoMenu.Add(platomenuEntity)
        Next
        Return listPlatoMenu
    End Function

    '//buscar por valor (buscar por Id)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of PlatoMenu) Implements ICrudRepository(Of PlatoMenu).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectPlatoMenuId", parameters)
        Dim listPlatoMenu = New List(Of PlatoMenu)
        For Each item As DataRow In result.Rows
            Dim platomenuEntity = New PlatoMenu 'crear objeto ifante
            platomenuEntity.IdPlatoMenu = Convert.ToInt32(item(0))
            platomenuEntity.IdPlato = Convert.ToInt32(item(0))
            platomenuEntity.IdMenu = Convert.ToInt32(item(0))
            'agregar entidad menu a la lista
            listPlatoMenu.Add(platomenuEntity)
        Next
        Return listPlatoMenu
    End Function
    'Public Function eliminar(IdPlatoMenu As Integer) As Integer Implements ICrudRepository(Of PlatoMenu).eliminar
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@idmenu", IdPlatoMenu))
    '    Return ExecuteNonQuery("EliminarPlatoMenu", parameters)
    'End Function
End Class
