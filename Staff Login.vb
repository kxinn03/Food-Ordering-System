Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Staff_Login
    Public Shared Property EnteredStaffID As String

    Private Sub Staff_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial text for Staff ID and Password fields as placeholders
        txtStaffID.Text = "Staff ID"
        txtStaffPassword.Text = "Password"
    End Sub

    Private Sub txtStaffID_GotFocus(sender As Object, e As EventArgs) Handles txtStaffID.GotFocus
        ' Clear the default "Staff ID" text when the textbox gets focus
        If txtStaffID.Text = "Staff ID" Then
            txtStaffID.Text = ""
        End If
    End Sub

    Private Sub txtStaffID_LostFocus(sender As Object, e As EventArgs) Handles txtStaffID.LostFocus
        ' If textbox loses focus and is empty, set back the "Staff ID" placeholder text
        If txtStaffID.Text = "" Then
            txtStaffID.Text = "Staff ID"
            txtStaffID.ForeColor = Color.Black ' Set text color to default (black)
        End If
    End Sub

    Private Sub txtStaffPassword_GotFocus(sender As Object, e As EventArgs) Handles txtStaffPassword.GotFocus
        ' Clear the default "Password" text and show password characters when textbox gets focus
        If txtStaffPassword.Text = "Password" Then
            txtStaffPassword.Text = ""
            txtStaffPassword.PasswordChar = "•" ' Show password characters
            txtStaffPassword.ForeColor = Color.Black ' Set text color to default (black)
        End If
    End Sub

    Private Sub txtStaffPassword_LostFocus(sender As Object, e As EventArgs) Handles txtStaffPassword.LostFocus
        ' If textbox loses focus and is empty, set back the "Password" placeholder text and hide password characters
        If txtStaffPassword.Text = "" Then
            txtStaffPassword.Text = "Password"
            txtStaffPassword.PasswordChar = "" ' Hide password characters
            txtStaffPassword.ForeColor = Color.Black ' Set text color to default (black)
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        ' Toggle showing/hiding password characters based on checkbox state
        If chkShowPassword.Checked = False Then
            txtStaffPassword.PasswordChar = "*" ' Hide password characters
        Else
            txtStaffPassword.PasswordChar = "" ' Show password characters
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Store entered StaffID for later use
        EnteredStaffID = txtStaffID.Text

        ' Validate the form's child controls
        If Me.ValidateChildren() = False Then
            Return
        End If

        ' Establish database connection and perform login validation
        If OpenConnection() Then
            Dim command As New SqlCommand("SELECT StaffID, Password, JobTitle FROM Staff WHERE StaffID = @StaffID AND Password = @Password", conn)
            command.Parameters.Add("@StaffID", SqlDbType.VarChar).Value = EnteredStaffID
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtStaffPassword.Text

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                ' Determine job title and display appropriate welcome message
                reader.Read()
                Dim jobTitle As String = reader.GetString(2).Trim()
                jobTitle = jobTitle.ToLower()

                If jobTitle = "manager" Then
                    MessageBox.Show("Welcome Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Dim mh As New Manager_HomePage()
                    mh.ShowDialog()
                    Me.Close()
                ElseIf jobTitle = "staff" Then
                    MessageBox.Show("Welcome Staff", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Dim sm As New Staff_MainPage()
                    reader.Close()
                    sm.ShowDialog()
                    Me.Close()
                Else
                    MessageBox.Show("Invalid Password or User", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Else
                ' Display error message for invalid login attempt
                MessageBox.Show("Invalid Password or User", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            reader.Close()
            CloseConnection()
        Else
            ' Show error message for failed database connection
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub lblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegister.LinkClicked
        ' Show Staff Register form when link is clicked
        Staff_Register.Show()
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        ' Show Staff Forgot Password form when link is clicked
        Dim forgotPasswordForm As New Staff_Forgot_Password()
        forgotPasswordForm.Show()
        Me.Hide() ' Hide the current login form
    End Sub

End Class