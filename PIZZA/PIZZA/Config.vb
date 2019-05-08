Imports System.Data.SqlClient
Imports System.Data
Module Config

    Public ConnSql As SqlConnection
    Public IdUsuario
    Public Sub IniciarConexion()
        ConnSql = New SqlConnection("Data Source=LUIS;Initial Catalog=Pizza;Integrated Security=True")
        ConnSql.Open()
    End Sub
End Module
