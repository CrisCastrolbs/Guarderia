Imports System.Data.SqlClient

Public Class IngredientePlatoRepository
    Inherits MasterRepository
    Implements IIngredientePlatoRepository

    'agregar nuevo IngredientePlato
    Public Function añadir(entity As IngredientePlato) As Integer Implements ICrudRepository(Of IngredientePlato).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdIngredientePlato", entity.IdIngredientePlato))
        parameters.Add(New SqlParameter("@IdPlato", entity.IdPlato))
        parameters.Add(New SqlParameter("@IdIngrediente", entity.IdIngrediente))


        Return ExecuteNonQuery("SP_InsertarIngredientePlato", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function

    'editar IngredientePlato
    Public Function editar(entity As IngredientePlato) As Integer Implements ICrudRepository(Of IngredientePlato).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdIngrediente", entity.IdIngrediente))
        parameters.Add(New SqlParameter("@IdPlato", entity.IdPlato))
        parameters.Add(New SqlParameter("@IdIngredientePlato", entity.IdIngredientePlato))
        Return ExecuteNonQuery("SP_ActualizarIngredientePlato", parameters)
    End Function

    '//obtener todos los datos de IngredientePlato
    Public Function obtenerTodo() As IEnumerable(Of IngredientePlato) Implements ICrudRepository(Of IngredientePlato).obtenerTodo
        Dim result = ExecuteReader("SP_SelectIngredientePlatoAll")
        Dim listIngredientePlato = New List(Of IngredientePlato)
        For Each item As DataRow In result.Rows
            Dim ingredienteplatoEntity = New IngredientePlato 'crear objeto usuario
            ingredienteplatoEntity.IdIngredientePlato = Convert.ToInt32(item(0))
            ingredienteplatoEntity.IdPlato = Convert.ToInt32(item(1))
            ingredienteplatoEntity.IdIngrediente = Convert.ToInt32(item(2))

            'agregar entidad menu a la lista
            listIngredientePlato.Add(ingredienteplatoEntity)
        Next
        Return listIngredientePlato
    End Function

    '//buscar por valor (buscar por nombre de IngredientePlato)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of IngredientePlato) Implements ICrudRepository(Of IngredientePlato).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectIngredientePlato", parameters)
        Dim listIngredientePlato = New List(Of IngredientePlato)
        For Each item As DataRow In result.Rows
            Dim ingredienteplatoEntity = New IngredientePlato 'crear objeto ifante
            ingredienteplatoEntity.IdIngredientePlato = Convert.ToInt32(item(0))
            ingredienteplatoEntity.IdPlato = Convert.ToInt32(item(1))
            ingredienteplatoEntity.IdIngrediente = Convert.ToInt32(item(2))
            'agregar entidad infante a la lista
            listIngredientePlato.Add(ingredienteplatoEntity)
        Next
        Return listIngredientePlato
    End Function

    '//buscar por valor (buscar por Id)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of IngredientePlato) Implements ICrudRepository(Of IngredientePlato).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectIngredientePlatoId", parameters)
        Dim listIngredientePlato = New List(Of IngredientePlato)
        For Each item As DataRow In result.Rows
            Dim ingredienteplatoEntity = New IngredientePlato 'crear objeto ifante
            ingredienteplatoEntity.IdIngredientePlato = Convert.ToInt32(item(0))
            ingredienteplatoEntity.IdPlato = Convert.ToInt32(item(1))
            ingredienteplatoEntity.IdIngrediente = Convert.ToInt32(item(2))
            'agregar entidad menu a la lista
            listIngredientePlato.Add(ingredienteplatoEntity)
        Next
        Return listIngredientePlato
    End Function
    'Public Function eliminar(IdIngredientePlato As Integer) As Integer Implements ICrudRepository(Of IngredientePlato).eliminar
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@idmenu", IdIngredientePlato))
    '    Return ExecuteNonQuery("EliminarIngredientePlato", parameters)
    'End Function
End Class
