Imports System.Data.SqlClient
Imports System.Configuration

Public MustInherit Class Repository

    Private ReadOnly connectionString As String

    Public Sub New()
        'Puedes Cambiar esta cadena de conexion en el archivo de congiguracion de la aplicacion(App.Config - Capa UI)
        connectionString = ConfigurationManager.ConnectionStrings("ConnectionToSql").ToString()
        '//o Puedes activar esta linea si deseas tener la cedena de conexion en esta clase
        'connectionString = "Server=(local);DataBase= MyCompanyTest; integrated security= true" 
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class
