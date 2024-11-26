Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Public Class member_login
    Friend strUsername As String
    Private Sub member_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
    End Sub





    Private Sub lblRegisterNow_Click(sender As Object, e As EventArgs) Handles lblRegisterNow.Click
        memberRegister.Show()
        Me.Hide()
    End Sub

    Private Sub lblForgotPassword_MouseHover(sender As Object, e As EventArgs) Handles lblForgotPassword.MouseHover
        lblForgotPassword.ForeColor = Color.Black
    End Sub

    Private Sub lblForgotPassword_MouseLeave(sender As Object, e As EventArgs) Handles lblForgotPassword.MouseLeave
        lblForgotPassword.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub lblForgetPassword_Click(sender As Object, e As EventArgs) Handles lblForgotPassword.Click
        forgot_password.Show()
        Me.Hide()
    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim MySqlCommand As New SqlCommand
        Dim strPassword As String = txtPassword.Text.Trim()
        Dim strSql As String

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        If txtUsername.Text = "" Then
            err.AppendLine("- Please enter your username")
            ctr = If(ctr, txtUsername)
        End If

        If txtPassword.Text = "" Then
            err.AppendLine("- Please enter your password")
            ctr = If(ctr, txtPassword)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        End If

        OpenConnection()
        strSql = "SELECT * FROM Member WHERE Username = @Username AND Password = @Password"
        MySqlCommand = New SqlCommand(strSql, conn)
        strUsername = txtUsername.Text.Trim()
        MySqlCommand.Parameters.AddWithValue("@Username", strUsername)
        MySqlCommand.Parameters.AddWithValue("@Password", strPassword)

        Using reader As SqlDataReader = MySqlCommand.ExecuteReader()
            ' Check if a matching record was found
            If reader.Read() Then
                member_profile.strLoggedInMemberName = reader("Name").ToString()
                member_profile.strLoggedInMemberUsername = reader("Username").ToString()
                member_profile.strLoggedInMemberEmail = reader("Email").ToString()
                member_profile.strLoggedInMemberPhoneNo = reader("PhoneNumber").ToString()


                reader.Close()
                txtUsername.Text = ""
                txtPassword.Text = ""
                txtUsername.Focus()
                frmMenu.Show()
                Me.Hide()
            Else
                ' Authentication failed
                MessageBox.Show("Invalid username or password. Please try again.")
            End If
        End Using
        CloseConnection()

    End Sub

    Private Sub lblRegisterNow_MouseHover(sender As Object, e As EventArgs) Handles lblRegisterNow.MouseHover
        lblRegisterNow.ForeColor = Color.FromArgb(227, 100, 20)
    End Sub

    Private Sub lblRegisterNow_MouseLeave(sender As Object, e As EventArgs) Handles lblRegisterNow.MouseLeave
        lblRegisterNow.ForeColor = Color.FromArgb(247, 147, 39)
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub member_login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

End Class