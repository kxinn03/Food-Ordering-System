Imports System.Data.SqlClient
Imports System.Data
Imports System.ComponentModel
Imports System.Text

Public Class Staff_Password_Reset
    Dim userEmail As String

    Private Sub RetrieveEnteredEmailFromForgotPasswordForm()
        ' Check if the Staff_Forgot_Password form is open
        If Application.OpenForms().OfType(Of Staff_Forgot_Password).Any() Then
            ' Retrieve the instance of the Staff_Forgot_Password form
            Dim forgotPasswordForm As Staff_Forgot_Password = Application.OpenForms().OfType(Of Staff_Forgot_Password).First()

            ' Access the EnteredEmail property from Staff_Forgot_Password form
            userEmail = forgotPasswordForm.EnteredEmail

            ' Use userEmail in your reset password logic
            MessageBox.Show("Entered email from Staff_Forgot_Password form: " & userEmail)
        Else
            MessageBox.Show("Staff_Forgot_Password form is not open.")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If String.IsNullOrWhiteSpace(txtVerifyPassword.Text) Then
            MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the email is retrieved from the previous form
        If String.IsNullOrWhiteSpace(userEmail) Then
            MessageBox.Show("No email retrieved for password reset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If OpenConnection() Then
            Dim sqlQuery As String = "UPDATE Staff SET Password = @Password WHERE Email = @Email"
            Dim sqlCmd As New SqlCommand(sqlQuery, conn)

            ' Set the parameters for the SQL command
            sqlCmd.Parameters.AddWithValue("@Password", txtVerifyPassword.Text)
            sqlCmd.Parameters.AddWithValue("@Email", userEmail)

            Dim rowsAffected As Integer = sqlCmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Clear the password field after successful reset if needed
                txtVerifyPassword.Text = ""

                Me.Hide()

                ' Show the Staff_Login form
                Dim staffLogin As New Staff_Login()
                staffLogin.Show()
            Else
                MessageBox.Show("No staff found for the entered email.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            CloseConnection()
        Else
            MessageBox.Show("Error connecting to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Staff_Password_Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveEnteredEmailFromForgotPasswordForm()
    End Sub

    'Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
    '    Staff_Login.Show()
    '    Me.Hide()
    'End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtVerifyPassword.TextChanged
        If txtNewPassword.Text <> "" AndAlso txtNewPassword.Text = txtVerifyPassword.Text Then
            ErrorProvider.SetError(txtVerifyPassword, "")
        Else
            ErrorProvider.SetError(txtVerifyPassword, "Password and Confirm password does not match")
        End If
    End Sub

    Private Sub chkShowPassword1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowPassword.CheckedChanged
        If ChkShowPassword.Checked = False Then
            txtNewPassword.PasswordChar = "*"
            txtVerifyPassword.PasswordChar = "*"
        Else
            txtNewPassword.PasswordChar = ""
            txtVerifyPassword.PasswordChar = ""
        End If
    End Sub

    Private Function IsPasswordValid(password As String) As Boolean
        ' Password should be at least 12 characters long (14 or more is recommended)
        If password.Length < 12 Then
            Return False
        End If

        ' Check for a combination of uppercase letters, lowercase letters, numbers, and symbols
        Dim hasUpperCase = password.Any(Function(c) Char.IsUpper(c))
        Dim hasLowerCase = password.Any(Function(c) Char.IsLower(c))
        Dim hasDigit = password.Any(Function(c) Char.IsDigit(c))
        Dim hasSymbol = password.Any(Function(c) Not Char.IsLetterOrDigit(c))

        Return hasUpperCase AndAlso hasLowerCase AndAlso hasDigit AndAlso hasSymbol
    End Function
End Class

