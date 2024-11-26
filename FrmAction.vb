Imports System.ComponentModel

Public Class FrmAction
    Public strSelectedId As String

    Private Sub ResetForm()
        lblId.Text = ""
        txtName.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtEmail.Text = ""
        txtPhoneNo.Text = ""
        Err.Clear()
    End Sub


    Private Sub FrmAction_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
        Dim db As New DBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Id = strSelectedId)
        If m Is Nothing Then
            MessageBox.Show("Member not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        ' Member found --> Display details
        lblId.Text = m.Id
        txtName.Text = m.Name
        txtUsername.Text = m.Username
        txtPassword.Text = m.Password
        txtEmail.Text = m.Email
        txtPhoneNo.Text = m.PhoneNumber
        lblJoinDate.Text = m.JoinDate

    End Sub

    Private Sub txtName_Validating(sender As Object, e As CancelEventArgs) Handles txtName.Validating
        Dim strName As String = txtName.Text.Trim()

        If strName = "" Then
            Err.SetError(txtName, "Please enter [Name]")
            e.Cancel = True
        Else
            Err.SetError(txtName, Nothing)
        End If
    End Sub

    Private Sub txtUsername_Validating(sender As Object, e As CancelEventArgs) Handles txtUsername.Validating
        Dim strUsername As String = txtUsername.Text.Trim()

        If strUsername = "" Then
            err.SetError(txtUsername, "Please enter [Username]")
            e.Cancel = True
        Else
            err.SetError(txtUsername, Nothing)
        End If
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As CancelEventArgs) Handles txtPassword.Validating
        Dim strPassword As String = txtPassword.Text.Trim()

        If strPassword = "" Then
            err.SetError(txtPassword, "Please enter [Password]")
            e.Cancel = True
        Else
            err.SetError(txtPassword, Nothing)
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        Dim strEmail As String = txtEmail.Text.Trim()

        If strEmail = "" Then
            err.SetError(txtEmail, "Please enter [Email]")
            e.Cancel = True
        Else
            err.SetError(txtEmail, Nothing)
        End If
    End Sub

    Private Sub txtPhoneNo_Validating(sender As Object, e As CancelEventArgs) Handles txtPhoneNo.Validating
        Dim strPhoneNo As String = txtPhoneNo.Text.Trim()

        If strPhoneNo = "" Then
            err.SetError(txtPhoneNo, "Please enter [Phone Number]")
            e.Cancel = True
        Else
            err.SetError(txtPhoneNo, Nothing)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If
        Dim db As New DBDataContext()
        Dim m As Member = db.Members.FirstOrDefault(Function(o) o.Id = strSelectedId)
        If m Is Nothing Then
            MessageBox.Show("Member not found", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        '1. Set the customer object’s properties accordingly
        m.Name = txtName.Text.Trim()
        m.Username = txtUsername.Text.Trim()
        m.Password = txtPassword.Text.Trim()
        m.Email = txtEmail.Text.Trim()
        m.PhoneNumber = txtPhoneNo.Text.Trim()
        '2. Update the customer record using LINQ
        'Refer Chapter 9(B).ppt, slide 37, or 38 - Complete the code yourself
        db.SubmitChanges()
        '3. Show a message box to indicate updating done
        'Complete the code yourself
        MessageBox.Show("Member [" & strSelectedId & "] updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New DBDataContext()
        Dim c As Member = db.Members.FirstOrDefault(Function(o) o.Id = strSelectedId)
        If c Is Nothing Then
            MessageBox.Show("Member not found", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        '1: Delete the Customer record using LINQ
        db.Members.DeleteOnSubmit(c)
        db.SubmitChanges()
        '2: Show a message box to indicate deletion done
        MessageBox.Show("Member [" & strSelectedId & "] deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub FrmAction_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub FrmAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2

        ' Set the form's location
        Me.Location = New Point(x, y)
    End Sub

    Private Sub FrmAction_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2

        ' Set the form's location
        Me.Location = New Point(x, y)
    End Sub
End Class