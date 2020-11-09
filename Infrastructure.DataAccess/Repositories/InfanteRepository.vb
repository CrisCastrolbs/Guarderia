Imports System.Data.SqlClient
Imports Infrastructure.Common

Public Class InfanteRepository
    Inherits MasterRepository
    Implements IInfanteRepository


    'agregar nuevo usuario
    Public Function añadir(entity As Infante) As Integer Implements ICrudRepository(Of Infante).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CedulaInfante", entity.CedulaInfante))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido1", entity.Apellido1))
        parameters.Add(New SqlParameter("@Apellido2", entity.Apellido2))
        parameters.Add(New SqlParameter("@FechaNac", entity.FechaNac))
        parameters.Add(New SqlParameter("@Sexo", entity.Sexo))

        Return ExecuteNonQuery("SP_InsertarInfante", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function

    'editar usuario
    Public Function editar(entity As Infante) As Integer Implements ICrudRepository(Of Infante).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CedulaInfante", entity.CedulaInfante))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido1", entity.Apellido1))
        parameters.Add(New SqlParameter("@Apellido2", entity.Apellido2))
        parameters.Add(New SqlParameter("@FechaNac", entity.FechaNac))
        parameters.Add(New SqlParameter("@Sexo", entity.Sexo))

        Return ExecuteNonQuery("SP_ActualizarInfante", parameters)
    End Function

    '//obtener todos los datos de usuarios
    Public Function obtenerTodo() As IEnumerable(Of Infante) Implements ICrudRepository(Of Infante).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllInfante")
        Dim listInfante = New List(Of Infante)
        For Each item As DataRow In result.Rows
            Dim infanteEntity = New Infante 'crear objeto usuario
            infanteEntity.CedulaInfante = Convert.ToInt32(item(0))
            infanteEntity.Nombre = item(1).ToString
            infanteEntity.Apellido1 = item(2).ToString
            infanteEntity.Apellido2 = item(3).ToString
            infanteEntity.FechaNac = CDate(item(4).Date.ToString)
            infanteEntity.Sexo = item(5).ToString
            'agregar entidad infante a la lista
            listInfante.Add(infanteEntity)
        Next
        Return listInfante
    End Function

    '//buscar por valor (buscar por nombre o apellidos del infante)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of Infante) Implements ICrudRepository(Of Infante).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectInfante", parameters)
        Dim listInfante = New List(Of Infante)
        For Each item As DataRow In result.Rows
            Dim infanteEntity = New Infante 'crear objeto ifante
            infanteEntity.CedulaInfante = Convert.ToInt32(item(0))
            infanteEntity.Apellido1 = item(1).ToString
            infanteEntity.Apellido2 = item(2).ToString
            infanteEntity.FechaNac = CDate(item(4).Date.ToString)
            infanteEntity.Sexo = item(4).ToString
            'agregar entidad infante a la lista
            listInfante.Add(infanteEntity)
        Next
        Return listInfante
    End Function

    '//buscar por valor (buscar por cedula)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of Infante) Implements ICrudRepository(Of Infante).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectInfanteCedula", parameters)
        Dim listInfante = New List(Of Infante)
        For Each item As DataRow In result.Rows
            Dim infanteEntity = New Infante 'crear objeto ifante
            infanteEntity.CedulaInfante = Convert.ToInt32(item(0))
            infanteEntity.Apellido1 = item(1).ToString
            infanteEntity.Apellido2 = item(2).ToString
            infanteEntity.FechaNac = CDate(item(4).Date.ToString)
            infanteEntity.Sexo = item(4).ToString
            'agregar entidad infante a la lista
            listInfante.Add(infanteEntity)
        Next
        Return listInfante
    End Function
    'Public Function eliminar(cedulaInfante As Integer) As Integer Implements ICrudRepository(Of Infante).eliminar
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@cedulaInfante", cedulaInfante))
    '    Return ExecuteNonQuery("EliminarInfante", parameters)
    'End Function
End Class
