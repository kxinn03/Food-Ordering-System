Imports System.Net
Imports System.Net.Mail
Public Class forgot_password
    Dim randomCode As String
    Public Shared toUser As String
    Private Sub forgot_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Function IsEmailRegistered(email As String) As Boolean
        Using db As New DBDataContext()
            Return db.Members.Any(Function(member) member.Email = email)
        End Using
    End Function

    Private Sub btnSendCode_Click(sender As Object, e As EventArgs) Handles btnSendCode.Click
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        If IsEmailRegistered(txtEmail.Text) Then
            randomCode = (rand.Next(999999)).ToString()
            Dim message As MailMessage = New MailMessage()
            toUser = txtEmail.Text
            from = "wongxy-wm21@student.tarc.edu.my"
            pass = "020627100186"
            messageBody = "Dear Member," & vbCrLf & "Your password reset code is : " + randomCode & vbCrLf & "Please enter this code to reset your password." & vbCrLf & "Thank You !"
            message.To.Add(toUser)
            message.From = New MailAddress(from)
            message.Body = messageBody
            message.Subject = "Email Verification Code"
            Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.DeliveryMethod = smtp.DeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(from, pass)
            Try
                smtp.Send(message)
                MessageBox.Show("please check your email and enter the code")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Email not registered. Please check your email or register a new account.")
        End If
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If (txtVerify.Text.Equals(randomCode)) Then
            toUser = txtEmail.Text
            Dim Reset As reset_password = New reset_password()
            reset_password.Show()
            Dim fp As forgot_password = New forgot_password()
            fp.Hide()
        Else
            MessageBox.Show("wrong code")
        End If
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        member_login.Show()
        Me.Hide()
    End Sub

    Private Sub lblBack_MouseHover(sender As Object, e As EventArgs) Handles lblBack.MouseHover
        lblBack.ForeColor = Color.Black
    End Sub

    Private Sub lblBack_MouseLeave(sender As Object, e As EventArgs) Handles lblBack.MouseLeave
        lblBack.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub


End Class
