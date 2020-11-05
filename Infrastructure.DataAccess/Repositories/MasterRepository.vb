Imports System.Data.SqlClient

Public MustInherit Class MasterRepository
    Inherits Repository

    'Ejecutar procedimientos para Insertar, Editar y Eliminar-> POR DEFECTO PARA PROCEDIMIENTO ALMACENADO
    Protected Function ExecuteNonQuery(sqlCommand As String, parameters As List(Of SqlParameter)) As Integer
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = sqlCommand
                command.CommandType = CommandType.StoredProcedure '(M-T)Puedes MODIFICAR a TEXT si deseas ejecutar por defecto solamente Comandos de texto sql (insert into, update...)->command.CommandType = CommandType.Text
                For Each item As SqlParameter In parameters
                    command.Parameters.Add(item)
                Next
                Dim result = command.ExecuteNonQuery()
                parameters.Clear()
                Return result
            End Using
        End Using
    End Function

    'EJECUTAR COMANDOS MIXTO
    'EJECUTAR COMANDOS Insertar, Editar y Eliminar MIXTO (PROCEDIMIENTO, TEXTO O TABLA DIRECTA)
    'EN CASO QUE DESEES ESPECIFICAR EL TIPO DE COMANDO DESDE LOS REPOSITORIO DE ENTIDADES,POR EJEMPLO:
    '->EJECUTAR UN COMANDO DE TEXTO DE SQL
    '-> return ExecuteNonQuery("insert into tabla values (@param1, @param2)", parameters,CommandType.Text);
    'Puedes ver el codigo de implemtacion en el punto (E-C-M) en la clase UserRepository.   
    'ESTE METODO ES OPCIONAL, SI SOLAMENTE UTILIZARÁS PROCEDIMIENTOS ALMACENADOS 
    '(O TEXTO en caso que modifiques el metodo de arriba como indiqué), PUEDES BORRAR ESTE METODO. 
    Protected Function ExecuteNonQuery(sqlCommand As String, parameters As List(Of SqlParameter), cmdType As CommandType) As Integer
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = sqlCommand
                command.CommandType = cmdType 'Tipo de comando especificado desde los repositorios de entidades- Ver punto punto (E-C-M) en la clase UserRepository
                For Each item As SqlParameter In parameters
                    command.Parameters.Add(item)
                Next
                Dim result = command.ExecuteNonQuery()
                parameters.Clear()
                Return result
            End Using
        End Using
    End Function

    'Ejecutar comandos de consultas sin parametros/Seleccionar todo'-> POR DEFECTO PARA PROCEDIMIENTO
    Protected Function ExecuteReader(sqlCommand As String) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = sqlCommand
                command.CommandType = CommandType.StoredProcedure '//Tipo de comando procedimiento almacenado
                Dim reader = command.ExecuteReader()
                Dim table = New DataTable()
                table.Load(reader)
                reader.Dispose()
                Return table
            End Using
        End Using
    End Function

    'Ejecutar comandos de consultas con parametros/Busqueda'-> POR DEFECTO PARA PROCEDIMIENTO
    Protected Function ExecuteReader(sqlCommand As String, parameters As List(Of SqlParameter)) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = sqlCommand
                For Each item As SqlParameter In parameters
                    command.Parameters.Add(item)
                Next
                command.CommandType = CommandType.StoredProcedure '//Tipo de comando procedimiento almacenado
                Dim reader = command.ExecuteReader()
                Dim table = New DataTable()
                table.Load(reader)
                reader.Dispose()
                Return table
            End Using
        End Using
    End Function

End Class

'EJECUTAR COMANDOS MIXTO PARA CONSULTA
'OPCIONAL
'PUEDES SOBRECARGAR ESTOS 2 ULTIMOS METODOS DE LA MISMA MANERA COMO SE HIZO CON EL METODO ExecuteNonQuery() 
'PARA QUE EN CASO DESEES ESPECIFICAR EL TIPO DE COMANDO DESDE LOS REPOSITORIOS DE ENTIDADES
'EJEMPLO- > 
'protected DataTable ExecuteReader(string sqlCommand, List<SqlParameter> parameters,CommandType cmdType)
'protected DataTable ExecuteReader(string sqlCommand, CommandType cmdType)
