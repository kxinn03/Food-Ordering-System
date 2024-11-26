Module Module_Member
    'Public conn As New System.Data.SqlClient.SqlConnection

    'Public Function OpenConnection() As Boolean
    '    Dim strMySQLConnectionString As String

    '    strMySQLConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB.mdf;Integrated Security=True"
    '    Try
    '        conn.ConnectionString = strMySQLConnectionString
    '        conn.Open()
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Public Sub CloseConnection()
    '    conn.Close()
    'End Sub

    Public Function GetNextId() As String
        Dim db As New DBDataContext()

        Dim rs = From m In db.Members

        Return "M" & (rs.Count() + 1).ToString("D3")
    End Function
    Public Function GetNextProductId() As String
        Dim db As New DBDataContext()

        Dim rs = From r In db.Redeems

        Return "R" & (rs.Count() + 1).ToString("D3")
    End Function

End Module
