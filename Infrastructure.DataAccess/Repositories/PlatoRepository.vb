Imports System.Data.SqlClient
Imports Infrastructure.Common

Public Class PlatoRepository
    Inherits MasterRepository
    Implements IPlatoRepository


    'agregar nuevo usuario
    Public Function añadir(entity As Plato) As String Implements ICrudPlatoRepository(Of Plato).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        'parameters.Add(New SqlParameter("@IdPlato", entity.IdPlato))
        parameters.Add(New SqlParameter("@NombrePlato", entity.NombrePlato))
        parameters.Add(New SqlParameter("@Costo", entity.Costo))

        Return ExecuteNonQuery("SP_InsertarPlato", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function


    'editar usuario
    Public Function editar(entity As Plato) As String Implements ICrudPlatoRepository(Of Plato).editar
        Dim parameters As New List(Of SqlParameter)
        'parameters.Add(New SqlParameter("@IdPlato", entity.IdPlato))
        parameters.Add(New SqlParameter("@NombrePlato", entity.NombrePlato))
        parameters.Add(New SqlParameter("@Costo", entity.Costo))

        Return ExecuteNonQuery("SP_ActualizarInfante", parameters)
    End Function


    '//obtener todos los datos de usuarios
    Public Function obtenerTodo() As IEnumerable(Of Plato) Implements ICrudPlatoRepository(Of Plato).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllPlato")
        Dim listPlato = New List(Of Plato)
        For Each item As DataRow In result.Rows
            Dim PlatoEntity = New Plato 'crear objeto usuario
            PlatoEntity.IdPlato = Convert.ToInt32(item(0))
            PlatoEntity.NombrePlato = item(1).ToString
            PlatoEntity.Costo = Convert.ToDouble(item(2))

            'agregar entidad infante a la lista
            listPlato.Add(PlatoEntity)
        Next
        Return listPlato
    End Function

    '//buscar por valor (buscar por nombre o apellidos del infante)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of Plato) Implements ICrudPlatoRepository(Of Plato).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectInfante", parameters)
        Dim listPlato = New List(Of Plato)
        For Each item As DataRow In result.Rows
            Dim PlatoEntity = New Plato 'crear objeto ifante
            PlatoEntity.IdPlato = Convert.ToInt32(item(0))
            PlatoEntity.NombrePlato = item(1).ToString
            PlatoEntity.Costo = Convert.ToDouble(item(2))

            'agregar entidad infante a la lista
            listPlato.Add(PlatoEntity)
        Next
        Return listPlato
    End Function
    '//buscar por valorMoney 
    Public Function obtenerPorValorMoney(value As Double) As IEnumerable(Of Plato) Implements ICrudPlatoRepository(Of Plato).obtenerPorValorMoney
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectPlatoId", parameters)
        Dim listPlato = New List(Of Plato)
        For Each item As DataRow In result.Rows
            Dim PlatoEntity = New Plato 'crear objeto ifante
            PlatoEntity.IdPlato = Convert.ToInt32(item(0))
            PlatoEntity.NombrePlato = item(1).ToString
            PlatoEntity.Costo = Convert.ToDouble(item(2))

            'agregar entidad infante a la lista
            listPlato.Add(PlatoEntity)
        Next
        Return listPlato
    End Function



    '//buscar por valor (buscar por cedula)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of Plato) Implements ICrudPlatoRepository(Of Plato).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectPlatoId", parameters)
        Dim listPlato = New List(Of Plato)
        For Each item As DataRow In result.Rows
            Dim PlatoEntity = New Plato 'crear objeto 
            PlatoEntity.IdPlato = Convert.ToInt32(item(0))
            PlatoEntity.NombrePlato = item(1).ToString
            PlatoEntity.Costo = Convert.ToDouble(item(2))

            'agregar entidad infante a la lista
            listPlato.Add(PlatoEntity)
        Next
        Return listPlato
    End Function


End Class
