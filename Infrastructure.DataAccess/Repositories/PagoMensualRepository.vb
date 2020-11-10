Imports System.Data.SqlClient
Imports Infrastructure.Common

Public Class PagoMensualRepository

    Inherits MasterRepository
    Implements IPagoMensualRepository


    'agregar nuevo usuario
    Public Function añadir(entity As PagoMensual) As Integer Implements ICrudRepositoryPagoMensual(Of PagoMensual).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdPagoMensual", entity.IdPagoMensual))
        parameters.Add(New SqlParameter("@MontoBaseMensual", entity.MontoBaseMensual))
        parameters.Add(New SqlParameter("@MontoComidas", entity.MontoComidas))
        parameters.Add(New SqlParameter("@MontoTotal", entity.MontoTotal))
        parameters.Add(New SqlParameter("@CedulaInfante", entity.CedulaInfante))
        parameters.Add(New SqlParameter("@CedulaRespPago", entity.CedulaRespPago))

        Return ExecuteNonQuery("SP_InsertarPagoMensual", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function


    'editar usuario
    Public Function editar(entity As PagoMensual) As Integer Implements ICrudRepositoryPagoMensual(Of PagoMensual).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@IdPagoMensual", entity.IdPagoMensual))
        parameters.Add(New SqlParameter("@MontoBaseMensual", entity.MontoBaseMensual))
        parameters.Add(New SqlParameter("@MontoComidas", entity.MontoComidas))
        parameters.Add(New SqlParameter("@MontoTotal", entity.MontoTotal))
        parameters.Add(New SqlParameter("@CedulaInfante", entity.CedulaInfante))
        parameters.Add(New SqlParameter("@CedulaRespPago", entity.CedulaRespPago))

        Return ExecuteNonQuery("SP_ActualizarPagoMensual", parameters)
    End Function


    '//obtener todos los datos de usuarios
    Public Function obtenerTodo() As IEnumerable(Of PagoMensual) Implements ICrudRepositoryPagoMensual(Of PagoMensual).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllPagoMensual")
        Dim listPagoMensual = New List(Of PagoMensual)
        For Each item As DataRow In result.Rows
            Dim pagoMensualEntity = New PagoMensual 'crear objeto usuario
            pagoMensualEntity.IdPagoMensual = Convert.ToInt32(item(0))
            pagoMensualEntity.MontoBaseMensual = item(1).ToDouble
            pagoMensualEntity.MontoComidas = item(2).ToDouble
            pagoMensualEntity.MontoTotal = item(3).ToDouble
            pagoMensualEntity.CedulaInfante = Convert.ToInt32(item(4))
            pagoMensualEntity.CedulaRespPago = Convert.ToInt32(item(5))

            'agregar entidad infante a la lista
            listPagoMensual.Add(pagoMensualEntity)
        Next
        Return listPagoMensual
    End Function

    ''//buscar por valor (buscar por nombre o apellidos del infante)
    'Public Function obtenerPorValor(value As String) As IEnumerable(Of PagoMensual) Implements ICrudRepository(Of PagoMensual).obtenerPorValor
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@findValue", value))
    '    Dim result = ExecuteReader("SP_selectInfante", parameters)
    '    Dim listInfante = New List(Of Infante)
    '    For Each item As DataRow In result.Rows
    '        Dim infanteEntity = New Infante 'crear objeto ifante
    '        infanteEntity.CedulaInfante = Convert.ToInt32(item(0))
    '        infanteEntity.Apellido1 = item(1).ToString
    '        infanteEntity.Apellido2 = item(2).ToString
    '        infanteEntity.FechaNac = CDate(item(4).Date.ToString)
    '        infanteEntity.Sexo = item(4).ToString
    '        'agregar entidad infante a la lista
    '        listInfante.Add(infanteEntity)
    '    Next
    '    Return listInfante
    'End Function

    '//buscar por valor (buscar por cedula)
    Public Function obtenerPorValorInt(value As Integer) As IEnumerable(Of PagoMensual) Implements ICrudRepositoryPagoMensual(Of PagoMensual).obtenerPorValorInt
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectPagoMensualInt", parameters)
        Dim listPagoMensual = New List(Of PagoMensual)
        For Each item As DataRow In result.Rows
            Dim pagoMensualEntity = New PagoMensual 'crear objeto ifante
            pagoMensualEntity.IdPagoMensual = Convert.ToInt32(item(0))
            pagoMensualEntity.MontoBaseMensual = item(1).ToDouble
            pagoMensualEntity.MontoComidas = item(2).ToDouble
            pagoMensualEntity.MontoTotal = item(3).ToDouble
            pagoMensualEntity.CedulaInfante = Convert.ToInt32(item(4))
            pagoMensualEntity.CedulaRespPago = Convert.ToInt32(item(5))

            'agregar entidad infante a la lista
            listPagoMensual.Add(pagoMensualEntity)
        Next
        Return listPagoMensual
    End Function

    'Public Function eliminar(cedulaInfante As Integer)
    'As Integer Implements ICrudRepository(Of Infante).eliminar
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@cedulaInfante", cedulaInfante))
    '    Return ExecuteNonQuery("EliminarInfante", parameters)
    'End Function

End Class
