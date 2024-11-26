Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Public Class memberRegister
    Private intCount As Integer = 0
    Private Sub memberRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lblLoginNow_MouseHover(sender As Object, e As EventArgs) Handles lblLoginNow.MouseHover
        lblLoginNow.ForeColor = Color.FromArgb(227, 100, 20)
    End Sub

    Private Sub lblLoginNow_MouseLeave(sender As Object, e As EventArgs) Handles lblLoginNow.MouseLeave
        lblLoginNow.ForeColor = Color.FromArgb(247, 147, 39)
    End Sub



    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        If txtPassword.Text <> txtConfirmPassword.Text Then
            lblError.Visible = True
        Else
            lblError.Visible = False
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If Not txtEmail.Text.Contains("@") Then
            lblError2.Visible = True
        Else
            lblError2.Visible = False
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing

        Dim strName As String = txtName.Text.Trim()
        Dim strUsername As String = txtUsername.Text.Trim()
        Dim strPassword As String = txtPassword.Text.Trim()
        Dim strCpassword As String = txtConfirmPassword.Text.Trim()
        Dim strEmail As String = txtEmail.Text.Trim()
        Dim strPhoneNo As String = mskPhoneNo.Text.Trim()
        Dim strJoinDate As DateTime = DateTime.Now
        Dim strId As String = Module_Member.GetNextId()
        If IsUsernameDuplicated(strUsername) Then
            err.AppendLine("- Username is already taken. Please choose another username.")
            ctr = If(ctr, txtUsername)
        End If

        If strName = "" Then
            err.AppendLine("- Please enter your name")
            ctr = If(ctr, txtName)
        End If

        If strUsername = "" Then
            err.AppendLine("- Please enter your username")
            ctr = If(ctr, txtName)
        End If

        If strPassword = "" Then
            err.AppendLine("- Please enter your password")
            ctr = If(ctr, txtPassword)
        End If

        If strCpassword = "" Then
            err.AppendLine("- Please enter the confirm password")
            ctr = If(ctr, txtConfirmPassword)
        Else
            If strCpassword <> strPassword Then
                err.AppendLine("- Passwords does not match")
                lblError.Visible = True
                ctr = If(ctr, txtConfirmPassword)
            Else
                lblError.Visible = False
            End If
        End If

        If strEmail = "" Then
            err.AppendLine("- Please enter your email")
            ctr = If(ctr, txtEmail)
        Else
            If Not strEmail.Contains("@") Then
                err.AppendLine("- Please check your email")
                lblError2.Visible = True
                ctr = If(ctr, txtEmail)
            Else
                lblError2.Visible = False
            End If
        End If

        If strPhoneNo = "(   )    -" Then
            err.AppendLine("- Please enter your phone number")
            ctr = If(ctr, mskPhoneNo)
        Else
            If Not mskPhoneNo.MaskCompleted Then
                err.AppendLine("- Please check your phone number")
                lblError3.Visible = True
                ctr = If(ctr, mskPhoneNo)
            Else
                lblError3.Visible = False
            End If
        End If

        ' (5) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            MessageBox.Show("You have successfully registered as a member, you can now log in.", "Congratulations", MessageBoxButtons.OK)
            member_login.Show()
        End If
        intCount = intCount + 1

        OpenConnection()
        strSql = "Insert Into Member(Id,Name,Username,Password,Email,PhoneNumber,JoinDate)Values(@Id,@Name,@Username,@Password,@Email,@PhoneNumber,@JoinDate)"
        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Id", strId)
        MySqlCommand.Parameters.AddWithValue("@Name", txtName.Text)
        MySqlCommand.Parameters.AddWithValue("@Username", txtUsername.Text)
        MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
        MySqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text)


        'MySqlCommand.Parameters.AddWithValue("@PhoneNumber", mskPhoneNo.Text.Trim())
        ' Trim the phone number and remove formatting characters
        strPhoneNo = New String(mskPhoneNo.Text.Where(AddressOf Char.IsDigit).ToArray())
        MySqlCommand.Parameters.AddWithValue("@PhoneNumber", strPhoneNo)
        MySqlCommand.Parameters.AddWithValue("@JoinDate", strJoinDate)
        MySqlCommand.ExecuteNonQuery()
        CloseConnection()
    End Sub

    Private Sub lblLoginNow_Click(sender As Object, e As EventArgs) Handles lblLoginNow.Click
        member_login.Show()
        Me.Hide()
    End Sub

    Private Function IsUsernameDuplicated(username As String) As Boolean
        Using db As New DBDataContext()
            Return db.Members.Any(Function(member) member.Username = username)
        End Using
    End Function

    Private Sub chkShow1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow1.CheckedChanged
        If chkShow1.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub chkShow2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow2.CheckedChanged
        If chkShow2.Checked = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub memberRegister_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub


End Class