Imports System.Data.SqlClient

Public Class TipoAlergiaRepository
    Inherits MasterRepository
    Implements ITipoAlergiaRepository


    'agregar tipo alergia
    Public Function añadir(entity As TipoAlergia) As Integer Implements ICrudTipoAlergiaRepository(Of TipoAlergia).añadir
        'Crear parametros y agregar valor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Descripcion", entity.Descripcion))

        Return ExecuteNonQuery("SP_InsertarTipoAlergia", parameters)
        'return ExecuteNonQuery("insert into Users values(@userName, @password, @firstName, @lastName, @position, @email, @profile)", parameters)
    End Function



    'editar Tipo Alergia
    Public Function editar(entity As TipoAlergia) As Integer Implements ICrudTipoAlergiaRepository(Of TipoAlergia).editar
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@Nombre", entity.Nombre))
        parameters.Add(New SqlParameter("@Apellido1", entity.Descripcion))
        Return ExecuteNonQuery("SP_ActualizarTipoAlergia", parameters)
    End Function

    '//obtener todos los datos de tipo alergia
    Public Function obtenerTodo() As IEnumerable(Of TipoAlergia) Implements ICrudTipoAlergiaRepository(Of TipoAlergia).obtenerTodo
        Dim result = ExecuteReader("SP_SelectAllTipoAlergia")
        Dim listTipoAlergia = New List(Of TipoAlergia)
        For Each item As DataRow In result.Rows
            Dim tipoAlergiaEntity = New TipoAlergia 'crear objeto usuario
            tipoAlergiaEntity.IdTipoAlergia = Convert.ToInt32(item(0))
            tipoAlergiaEntity.Nombre = item(1).ToString
            tipoAlergiaEntity.Descripcion = item(2).ToString
            'agregar entidad infante a la lista
            listTipoAlergia.Add(TipoAlergiaEntity)
        Next
        Return listTipoAlergia
    End Function

    '//buscar por valor (buscar por nombre Tipo alergia)
    Public Function obtenerPorValor(value As String) As IEnumerable(Of TipoAlergia) Implements ICrudTipoAlergiaRepository(Of TipoAlergia).obtenerPorValor
        Dim parameters As New List(Of SqlParameter)
        parameters.Add(New SqlParameter("@findValue", value))
        Dim result = ExecuteReader("SP_selectTipoAlergia", parameters)
        Dim listTipoAlergia = New List(Of TipoAlergia)
        For Each item As DataRow In result.Rows
            Dim tipoAlergiaEntity = New TipoAlergia 'crear objeto TipoAlergia
            tipoAlergiaEntity.IdTipoAlergia = Convert.ToInt32(item(0))
            tipoAlergiaEntity.Nombre = item(1).ToString
            tipoAlergiaEntity.Descripcion = item(2).ToString
            'agregar entidad tipo alergia a la lista
            listTipoAlergia.Add(tipoAlergiaEntity)
        Next
        Return listTipoAlergia
    End Function


    'Public Function eliminar(cedulaInfante As Integer) As Integer Implements ICrudRepository(Of Infante).eliminar
    '    Dim parameters As New List(Of SqlParameter)
    '    parameters.Add(New SqlParameter("@cedulaInfante", cedulaInfante))
    '    Return ExecuteNonQuery("EliminarInfante", parameters)
    'End Function

End Class
