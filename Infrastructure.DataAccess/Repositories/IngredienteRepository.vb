Imports System.Data.SqlClient
Imports Infrastructure.Common
Public Class IngredienteRepository

    Inherits MasterRepository
    Implements IIngredienteRepository


    'agregar nuevo usuario
    Public Function añadir(entity As Ingrediente) As String Implements ICrudRepositoryString(Of Ingrediente).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdIngrediente", entity.IdIngrediente))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))


        Return ExecuteNonQuery("SP_InsertarIngrediente", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function



    'editar usuario
    Public Function editar(entity As Ingrediente) As String Implements ICrudRepositoryString(Of Ingrediente).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@IdIngrediente", entity.IdIngrediente))

        Return ExecuteNonQuery("SP_ActualizarIngrediente", parameters)
    End Function



    '//obtener todos los datos de usuarios
    Public Function obtenerTodo() As IEnumerable(Of Ingrediente) Implements ICrudRepositoryString(Of Ingrediente).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllIngrediente")
        Dim listIngrediente = New List(Of Ingrediente)
        For Each item As DataRow In result.Rows
            Dim ingredienteEntity = New Ingrediente 'crear objeto usuario
            ingredienteEntity.IdIngrediente = Convert.ToInt32(item(0))

            'agregar entidad infante a la lista
            listIngrediente.Add(ingredienteEntity)
        Next
        Return listIngrediente
    End Function

    '//buscar por valor (buscar por nombre o apellidos del infante)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of Ingrediente) Implements ICrudRepositoryString(Of Ingrediente).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectIngrediente", parameters)
        Dim listIngrediente = New List(Of Ingrediente)
        For Each item As DataRow In result.Rows
            Dim ingredienteEntity = New Ingrediente 'crear objeto ifante
            ingredienteEntity.IdIngrediente = Convert.ToInt32(item(0))
            'agregar entidad infante a la lista
            listIngrediente.Add(ingredienteEntity)
        Next
        Return listIngrediente
    End Function

    '//buscar por valor (buscar por cedula)
    Public Function obtenerPorValorInt(value As String) As IEnumerable(Of Ingrediente) Implements ICrudRepositoryString(Of Ingrediente).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectIdIngrediente", parameters)
        Dim listIngrediente = New List(Of Ingrediente)
        For Each item As DataRow In result.Rows
            Dim ingredienteEntity = New Ingrediente 'crear objeto ifante
            ingredienteEntity.IdIngrediente = Convert.ToInt32(item(0))

            'agregar entidad infante a la lista
            listIngrediente.Add(ingredienteEntity)
        Next
        Return listIngrediente
    End Function




    'Public Function eliminar(cedulaInfante As Integer) As Integer Implements ICrudRepository(Of Infante).eliminar
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@cedulaInfante", cedulaInfante))
    '    Return ExecuteNonQuery("EliminarInfante", parameters)
    'End Function

End Class
