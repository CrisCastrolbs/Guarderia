Imports System.Data.SqlClient
Imports Infrastructure.Common

Public Class ResponsablePagoRepository
    Inherits MasterRepository
    Implements IResponsablePagoRepository


    'agregar nuevo responsablePago
    Public Function añadir(entity As ResponsablePago) As Integer Implements ICrudRepository(Of ResponsablePago).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CedulaRespPago", entity.CedulaRespPago))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido1", entity.Apellido1))
        parameters.Add(New SqlParameter("@Apellido2", entity.Apellido2))
        parameters.Add(New SqlParameter("@Direccion", entity.Direccion))
        parameters.Add(New SqlParameter("@Distrito", entity.Distrito))
        parameters.Add(New SqlParameter("@Canton", entity.Canton))
        parameters.Add(New SqlParameter("@Provincia", entity.Provincia))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@NumCuenta", entity.NumCuenta))
        parameters.Add(New SqlParameter("@AutorizadoRetirar", entity.AutorizadoRetirar))

        Return ExecuteNonQuery("SP_InsertarResponsablePago", parameters)

    End Function


    'editar reponsablePago
    Public Function editar(entity As ResponsablePago) As Integer Implements ICrudRepository(Of ResponsablePago).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@CedulaRespPago", entity.CedulaRespPago))
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido1", entity.Apellido1))
        parameters.Add(New SqlParameter("@Apellido2", entity.Apellido2))
        parameters.Add(New SqlParameter("@Direccion", entity.Direccion))
        parameters.Add(New SqlParameter("@Distrito", entity.Distrito))
        parameters.Add(New SqlParameter("@Canton", entity.Canton))
        parameters.Add(New SqlParameter("@Provincia", entity.Provincia))
        parameters.Add(New SqlParameter("@Telefono", entity.Telefono))
        parameters.Add(New SqlParameter("@NumCuenta", entity.NumCuenta))
        parameters.Add(New SqlParameter("@AutorizadoRetirar", entity.AutorizadoRetirar))
        Return ExecuteNonQuery("SP_ActualizarResponsablePago", parameters)
    End Function


    '//obtener todos los datos de usuarios
    Public Function obtenerTodo() As IEnumerable(Of ResponsablePago) Implements ICrudRepository(Of ResponsablePago).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllResponsablePago")
        Dim listResponsablePago = New List(Of ResponsablePago)
        For Each item As DataRow In result.Rows
            Dim ResponsablePagoEntity = New ResponsablePago 'crear objeto responsablePago
            ResponsablePagoEntity.CedulaRespPago = Convert.ToInt32(item(0))
            ResponsablePagoEntity.Nombre = item(1).ToString
            ResponsablePagoEntity.Apellido1 = item(2).ToString
            ResponsablePagoEntity.Apellido2 = item(3).ToString
            ResponsablePagoEntity.Direccion = item(4).ToString
            ResponsablePagoEntity.Distrito = item(5).ToString
            ResponsablePagoEntity.Canton = item(6).ToString
            ResponsablePagoEntity.Provincia = item(7).ToString
            ResponsablePagoEntity.Telefono = Convert.ToInt32(item(8))
            ResponsablePagoEntity.NumCuenta = item(9).ToString
            ResponsablePagoEntity.AutorizadoRetirar = Convert.ToBoolean(item(10))

            'agregar entidad responsablePago a la lista
            listResponsablePago.Add(ResponsablePagoEntity)
        Next
        Return listResponsablePago
    End Function

    '//buscar por valor (buscar por nombre o apellidos del infante)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of ResponsablePago) Implements ICrudRepository(Of ResponsablePago).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectResponsablePago", parameters)
        Dim listResponsablePago = New List(Of ResponsablePago)
        For Each item As DataRow In result.Rows
            Dim ResponsablePagoEntity = New ResponsablePago 'crear objeto ifante
            ResponsablePagoEntity.CedulaRespPago = Convert.ToInt32(item(0))
            ResponsablePagoEntity.Nombre = item(1).ToString
            ResponsablePagoEntity.Apellido1 = item(2).ToString
            ResponsablePagoEntity.Apellido2 = item(3).ToString
            ResponsablePagoEntity.Distrito = item(4).ToString
            ResponsablePagoEntity.Canton = item(5).ToString
            ResponsablePagoEntity.Provincia = item(6).ToString

            'agregar entidad responsablePago a la lista
            listResponsablePago.Add(ResponsablePagoEntity)
        Next
        Return listResponsablePago
    End Function

    '//buscar por valor (buscar por cedula)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of ResponsablePago) Implements ICrudRepository(Of ResponsablePago).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectResponsablePagoCedula", parameters)
        Dim listResponsablePago = New List(Of ResponsablePago)
        For Each item As DataRow In result.Rows
            Dim ResponsablePagoEntity = New ResponsablePago 'crear objeto ifante
            ResponsablePagoEntity.CedulaRespPago = Convert.ToInt32(item(0))
            ResponsablePagoEntity.Nombre = item(1).ToString
            ResponsablePagoEntity.Apellido1 = item(2).ToString
            ResponsablePagoEntity.Apellido2 = item(3).ToString
            ResponsablePagoEntity.Distrito = item(4).ToString
            ResponsablePagoEntity.Canton = item(5).ToString
            ResponsablePagoEntity.Provincia = item(6).ToString
            'agregar entidad responsablepago a la lista
            listResponsablePago.Add(ResponsablePagoEntity)
        Next
        Return listResponsablePago
    End Function

End Class
