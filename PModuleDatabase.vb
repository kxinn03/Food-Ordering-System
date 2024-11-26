Module PModuleDatabase
    Public pconn As New System.Data.SqlClient.SqlConnection

    Public Function POpenConnection() As Boolean
        Try
            If pconn.State <> ConnectionState.Open Then
                Dim strMySQLConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True"
                pconn.ConnectionString = strMySQLConnectionString
                pconn.Open()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub PCloseConnection()
        pconn.Close()
    End Sub
End Module
