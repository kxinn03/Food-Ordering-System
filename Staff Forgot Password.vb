Imports System.Net
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Staff_Forgot_Password

    Dim randomCode As String
    Public Shared toStaffID As String
    Public ReadOnly Property EnteredEmail As String
        Get
            Return txtEmail.Text
        End Get
    End Property
    Public Shared toUser As String

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Staff_Login.Show()
        Me.Close()
    End Sub

    Private Function IsMemberRegistered(email As String) As Boolean
        Dim strEmailPattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim intCheck As Integer = 0

        If OpenConnection() Then
            Dim sqlcmd As New SqlCommand("SELECT * FROM Staff", conn)
            Dim Dadapter As New SqlDataAdapter(sqlcmd)
            Dim table As New DataTable

            Dadapter.Fill(table)

            For intCount As Integer = 0 To table.Rows.Count - 1
                If email = table.Rows(intCount).Item(15) Then
                    intCheck = 1
                End If
            Next
            CloseConnection()
        End If

        If email = "" Then
            MsgBox("Please Enter the Email.", MessageBoxIcon.Error, "Error")
            Return False
        ElseIf Not Regex.IsMatch(email, strEmailPattern) Then
            MessageBox.Show("Please Enter the email in correct Format like abc@gmail.com", "Invalid Email")
            Return False
        ElseIf intCheck = 0 Then
            MessageBox.Show("Your email is not the member, please register first", "Invalid Account")
            txtEmail.Text = ""
            txtCode.Text = ""
            Return False
        End If

        Return True
    End Function

    Private Sub SendVerificationCode()
        Dim from As String = "kirtheneshv-pm20@student.tarc.edu.my"
        Dim pass As String = "020115070550"
        Dim messageBody As String = "Your Verification code is " + randomCode

        Dim message As New MailMessage()
        message.To.Add(toStaffID)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "Forgot Password Verification code"
        message.IsBodyHtml = False

        ' SMTP Configuration
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New NetworkCredential("kirtheneshv-pm20@student.tarc.edu.my", "020115070550")

        Try
            smtp.Send(message)
            MessageBox.Show("Email sent successfully.")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim strEmail As String = txtEmail.Text.Trim()

        If IsMemberRegistered(strEmail) Then
            Dim rand As New Random()
            randomCode = rand.Next(999999).ToString()
            toStaffID = strEmail
            SendVerificationCode()
        End If
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtCode.Text.Equals(randomCode) Then
            toStaffID = txtEmail.Text
            Dim showPassword As New Staff_Password_Reset
            showPassword.Show()
            txtEmail.Clear()
            txtCode.Clear()
            Me.Hide()
        End If
    End Sub

    'Public Shared Function GetEmail() As String
    '    Return Email
    'End Function

    Private Sub Staff_Forgot_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
