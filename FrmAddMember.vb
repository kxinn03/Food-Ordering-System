Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Public Class FrmAddMember

    Private Sub ResetForm()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        mskPhoneNo.Text = ""
        txtUsername.Text = ""
        txtName.Focus()
        err.Clear()
    End Sub
    Private Sub FrmAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = Module_Member.GetNextId()
        lblJoinDate.Text = DateTime.Now.ToShortDateString()
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2

        ' Set the form's location
        Me.Location = New Point(x, y)


    End Sub

    Private Sub FrmAddMember_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2
        ' Reset the form's location to the specified point
        Me.Location = New Point(x, y)
    End Sub

    Private Sub FrmAddMember_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub


    Private Sub txtName_Validating(sender As Object, e As CancelEventArgs) Handles txtName.Validating
        Dim strName As String = txtName.Text.Trim()

        If strName = "" Then
            err.SetError(txtName, "Please enter [Name]")
        Else
            err.SetError(txtName, Nothing)
        End If

        e.Cancel = False
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        Dim strEmail As String = txtEmail.Text.Trim()

        If strEmail = "" Then
            err.SetError(txtEmail, "Please enter [Email]")
        ElseIf Not txtEmail.Text.Contains("@") Then
            err.SetError(txtEmail, "Email must contain @")
        Else
            err.SetError(txtEmail, Nothing)
        End If


        e.Cancel = False
    End Sub

    Private Sub txtUsername_Validating(sender As Object, e As CancelEventArgs) Handles txtUsername.Validating
        Dim strUsername As String = txtUsername.Text.Trim()

        If strUsername = "" Then
            err.SetError(txtUsername, "Please enter [Username]")
        Else
            err.SetError(txtUsername, Nothing)
        End If

        e.Cancel = False
    End Sub

    Private Sub txtPassword_Validating(sender As Object, e As CancelEventArgs) Handles txtPassword.Validating
        Dim strPassword As String = txtPassword.Text.Trim()

        If strPassword = "" Then
            err.SetError(txtPassword, "Please enter [Password]")
        Else
            err.SetError(txtPassword, Nothing)
        End If

        e.Cancel = False
    End Sub

    Private Sub mskPhoneNo_Validating(sender As Object, e As CancelEventArgs) Handles mskPhoneNo.Validating
        Dim strPhoneNo As String = mskPhoneNo.Text.Trim()

        If strPhoneNo = "" Then
            err.SetError(mskPhoneNo, "Please enter [Phone Number]")
        ElseIf Not mskPhoneNo.MaskCompleted Then
            err.SetError(mskPhoneNo, "Please enter valid [Phone Number]")
        Else
            err.SetError(mskPhoneNo, Nothing)
        End If


        e.Cancel = False
    End Sub



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Me.ValidateChildren() = False Then ' If validation result is FALSE, means there are input errors
            Return ' Stop immediately
        End If


        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        '1.Capture 3 inputs - Complete the code yourself
        Dim strId As String = lblId.Text
        Dim strName As String = txtName.Text.Trim()
        Dim strUsername As String = txtUsername.Text.Trim()
        Dim strPassword As String = txtPassword.Text.Trim()
        Dim strEmail As String = txtEmail.Text.Trim()
        Dim strPhoneNo As String = mskPhoneNo.Text
        Dim strJoinDate As DateTime = DateTime.Now

        If IsUsernameDuplicated(strUsername) Then
            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If strName = "" Then
            err.AppendLine("- Please enter the member name")
            ctr = If(ctr, txtName)
        End If

        If strUsername = "" Then
            err.AppendLine("- Please enter the member login username")
            ctr = If(ctr, txtName)
        End If

        If strPassword = "" Then
            err.AppendLine("- Please enter the member login password")
            ctr = If(ctr, txtPassword)
        End If

        If strEmail = "" Then
            err.AppendLine("- Please enter the member email")
            ctr = If(ctr, txtEmail)
        Else
            If Not txtEmail.Text.Contains("@") Then
                err.AppendLine("- Email must contain @")
                ctr = If(ctr, mskPhoneNo)
            End If
        End If

        If strPhoneNo = "(   )    -" Then
            err.AppendLine("- Please enter your phone number")
            ctr = If(ctr, mskPhoneNo)
        Else
            If Not mskPhoneNo.MaskCompleted Then
                err.AppendLine("- Please check your phone number")
                ctr = If(ctr, mskPhoneNo)
            End If
        End If



        ' (5) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            OpenConnection()
            strSql = "Insert Into Member(Id,Name,Username,Password,Email,PhoneNumber,JoinDate)Values(@Id,@Name,@Username,@Password,@Email,@PhoneNumber,@JoinDate)"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@Id", strId)
            MySqlCommand.Parameters.AddWithValue("@Name", txtName.Text)
            MySqlCommand.Parameters.AddWithValue("@Username", txtUsername.Text)
            MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
            MySqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text)
            strPhoneNo = New String(mskPhoneNo.Text.Where(AddressOf Char.IsDigit).ToArray())
            MySqlCommand.Parameters.AddWithValue("@PhoneNumber", strPhoneNo)
            MySqlCommand.Parameters.AddWithValue("@JoinDate", strJoinDate)
            MySqlCommand.ExecuteNonQuery()
            CloseConnection()
            'Show a message box to indicate insertion done
            MessageBox.Show("Member [" & strId & "] inserted", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ResetForm()
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        manage2.BindData()
    End Sub
    Private Function IsUsernameDuplicated(username As String) As Boolean
        ' Check if the username already exists in the database
        OpenConnection()

        Dim strSql As String = "SELECT COUNT(*) FROM Member WHERE Username = @Username"
        Dim MySqlCommand As New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Username", username)
        Dim count As Integer = Convert.ToInt32(MySqlCommand.ExecuteScalar())
        CloseConnection()
        Return count > 0
    End Function

End Class