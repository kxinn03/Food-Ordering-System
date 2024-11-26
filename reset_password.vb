Imports System.Data.SqlClient
Imports System.Data
Imports System.Text
Public Class reset_password
    Dim email As String = forgot_password.toUser
    Private Sub reset_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        Dim MySqlCommand As New SqlCommand
        Dim newPassword As String = txtPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        ' Perform basic validation
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If newPassword = "" Then
            err.AppendLine("- Please enter a new password")
            ctr = If(ctr, txtPassword)
        End If

        If confirmPassword = "" Then
            err.AppendLine("- Please confirm the new password")
            ctr = If(ctr, txtConfirmPassword)
        End If

        If newPassword <> confirmPassword Then
            err.AppendLine("- Passwords do not match")
            ctr = If(ctr, txtConfirmPassword)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        End If
        ' Update the password in the database
        Dim strSql As String = "UPDATE Member SET Password = @Password WHERE Email = @Email"
        MySqlCommand = New SqlCommand(strSql, conn)
        OpenConnection()
        MySqlCommand.Parameters.AddWithValue("@Password", newPassword)
        MySqlCommand.Parameters.AddWithValue("@Email", forgot_password.toUser)
        MySqlCommand.ExecuteNonQuery()
        MessageBox.Show("password reseted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CloseConnection()
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        member_login.Show()
        Me.Hide()
    End Sub
End Class