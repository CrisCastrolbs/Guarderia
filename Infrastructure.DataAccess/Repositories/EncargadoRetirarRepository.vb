Imports System.Data.SqlClient
Imports Infrastructure.Common

Public Class EncargadoRetirarRepository
    Inherits MasterRepository
    Implements IEncargadoRetirarRepository

    'agregar nuevo usuario
    Public Function añadir(entity As EncargadoRetirar) As Integer Implements ICrudEncargadoRetirar(Of EncargadoRetirar).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CedulaEncargado", entity.CedulaEncargado))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido1", entity.Apellido1))
        parameters.Add(New SqlParameter("@Apellido2", entity.Apellido2))
        parameters.Add(New SqlParameter("@Direccion", entity.Direccion))
        parameters.Add(New SqlParameter("@Distrito", entity.Canton))
        parameters.Add(New SqlParameter("@Canton", entity.Canton))
        parameters.Add(New SqlParameter("@Provincia", entity.Provincia))
        parameters.Add(New SqlParameter("@NumTelefono1", entity.NumTelefono1))
        parameters.Add(New SqlParameter("@NumTelefono2", entity.NumTelefono2))

        Return ExecuteNonQuery("SP_InsertarEncargadoRetirar", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function


    'editar usuario
    Public Function editar(entity As EncargadoRetirar) As Integer Implements ICrudEncargadoRetirar(Of EncargadoRetirar).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CedulaEncargado", entity.CedulaEncargado))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido1", entity.Apellido1))
        parameters.Add(New SqlParameter("@Apellido2", entity.Apellido2))
        parameters.Add(New SqlParameter("@Direccion", entity.Direccion))
        parameters.Add(New SqlParameter("@Distrito", entity.Distrito))
        parameters.Add(New SqlParameter("@Canton", entity.Canton))
        parameters.Add(New SqlParameter("@Provincia", entity.Provincia))
        parameters.Add(New SqlParameter("@NumTelefono1", entity.NumTelefono1))
        parameters.Add(New SqlParameter("@NumTelefono2", entity.NumTelefono2))
        Return ExecuteNonQuery("SP_ActualizarEncargadoRetirar", parameters)

    End Function

    '//obtener todos los datos de usuarios
    Public Function obtenerTodo() As IEnumerable(Of EncargadoRetirar) Implements ICrudEncargadoRetirar(Of EncargadoRetirar).obtenerTodo
        Dim result = ExecuteReader("PS_selectAllEncargadoRetirar")
        Dim listEncargadoRetirar = New List(Of EncargadoRetirar)
        For Each item As DataRow In result.Rows
            Dim encargadoRetirarEntity = New EncargadoRetirar 'crear objeto usuario
            encargadoRetirarEntity.CedulaEncargado = Convert.ToInt32(item(0))
            encargadoRetirarEntity.Apellido1 = item(1).ToString
            encargadoRetirarEntity.Apellido2 = item(2).ToString
            encargadoRetirarEntity.Direccion = item(3).ToString
            encargadoRetirarEntity.Distrito = item(4).ToString
            encargadoRetirarEntity.Canton = item(5).ToString
            encargadoRetirarEntity.Provincia = item(6).ToString
            encargadoRetirarEntity.NumTelefono1 = item(7).ToString
            encargadoRetirarEntity.NumTelefono2 = item(8).ToString
            'agregar entidad infante a la lista
            listEncargadoRetirar.Add(encargadoRetirarEntity)
        Next
        Return listEncargadoRetirar
    End Function

    '//buscar por valor (buscar por nombre o apellidos del infante)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of EncargadoRetirar) Implements ICrudEncargadoRetirar(Of EncargadoRetirar).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectEncargadoRetirarInt", parameters)
        Dim listEncargadoRetirar = New List(Of EncargadoRetirar)
        For Each item As DataRow In result.Rows
            Dim encargadoRetirarEntity = New EncargadoRetirar 'crear objeto ifante
            encargadoRetirarEntity.CedulaEncargado = Convert.ToInt32(item(0))
            encargadoRetirarEntity.Apellido1 = item(1).ToString
            encargadoRetirarEntity.Apellido2 = item(2).ToString
            encargadoRetirarEntity.Direccion = item(3).ToString
            encargadoRetirarEntity.Distrito = item(4).ToString
            encargadoRetirarEntity.Canton = item(5).ToString
            encargadoRetirarEntity.Provincia = item(6).ToString
            encargadoRetirarEntity.NumTelefono1 = item(7).ToString
            encargadoRetirarEntity.NumTelefono2 = item(8).ToString
            'agregar entidad infante a la lista
            listEncargadoRetirar.Add(encargadoRetirarEntity)
        Next
        Return listEncargadoRetirar
    End Function

    '//buscar por valor (buscar por cedula)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of EncargadoRetirar) Implements ICrudEncargadoRetirar(Of EncargadoRetirar).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectEncargadoRetirarInt", parameters)
        Dim listInfante = New List(Of Infante)
        For Each item As DataRow In result.Rows
            Dim infanteEntity = New Infante 'crear objeto ifante
            infanteEntity.CedulaInfante = Convert.ToInt32(item(0))
            infanteEntity.Apellido1 = item(1).ToString
            infanteEntity.Apellido2 = item(2).ToString
            infanteEntity.FechaNacimiento = Convert.ToDateTime(item(3))
            infanteEntity.Sexo = item(4).ToString
            'agregar entidad infante a la lista
            listInfante.Add(infanteEntity)
        Next
        Return listInfante
    End Function


End Class
