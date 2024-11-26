Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class FrmAddRedeem
    Private uploadedImagePath As Byte()
    Private Sub ResetForm()
        txtDetails.Text = ""
        txtName.Text = ""
        txtPoints.Text = ""
        txtQuantity.Text = ""
        cboAvailability.SelectedIndex = -1
        PicProduct.Image = Global.FoodOrderingSystem.My.Resources.Resources.no_image
        txtName.Focus()
        err.Clear()
    End Sub
    Private Sub FrmAddRedeem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProductId.Text = Module_Member.GetNextProductId()
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2

        ' Set the form's location
        Me.Location = New Point(x, y)
    End Sub

    Private Sub FrmAddRedeem_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
    End Sub

    Private Sub txtName_Validating(sender As Object, e As CancelEventArgs) Handles txtName.Validating
        Dim strName As String = txtName.Text.Trim()

        If strName = "" Then
            Err.SetError(txtName, "Please enter [Product Name]")
            e.Cancel = True
        Else
            Err.SetError(txtName, Nothing)
        End If
        e.Cancel = False
    End Sub

    Private Sub txtDetails_Validating(sender As Object, e As CancelEventArgs) Handles txtDetails.Validating
        Dim strDetails As String = txtDetails.Text.Trim()

        If strDetails = "" Then
            Err.SetError(txtDetails, "Please enter [Product Details]")
            e.Cancel = True
        Else
            Err.SetError(txtDetails, Nothing)
        End If
        e.Cancel = False
    End Sub

    Private Sub txtPoints_Validating(sender As Object, e As CancelEventArgs) Handles txtPoints.Validating
        Dim strPoints As String = txtPoints.Text.Trim()

        If strPoints = "" Then
            Err.SetError(txtPoints, "Please enter [Product Points]")
            e.Cancel = True
        Else
            Err.SetError(txtPoints, Nothing)
        End If
        e.Cancel = False
    End Sub

    Private Sub txtPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoints.KeyPress
        ' Check if the pressed key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            err.SetError(txtPoints, "Please enter numeric characters only")
            e.Handled = True
        Else
            err.SetError(txtPoints, Nothing)
        End If

    End Sub

    Private Sub txtQuantity_Validating(sender As Object, e As CancelEventArgs) Handles txtQuantity.Validating
        Dim strQuantity As String = txtQuantity.Text.Trim()

        If strQuantity = "" Then
            Err.SetError(txtQuantity, "Please enter [Product Quantity]")
            e.Cancel = True
        Else
            Err.SetError(txtQuantity, Nothing)
        End If
        e.Cancel = False
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            Err.SetError(txtQuantity, "Please enter numeric characters only")
            e.Handled = True
        Else
            Err.SetError(txtQuantity, Nothing)
        End If

    End Sub
    Private Sub cboAvailability_Validating(sender As Object, e As CancelEventArgs) Handles cboAvailability.Validating
        If cboAvailability.SelectedIndex = -1 Then
            ' No item selected, show an error message
            err.SetError(cboAvailability, "Please select an availability option")
            e.Cancel = True
        Else
            ' Valid selection, clear the error message
            err.SetError(cboAvailability, "")
        End If
        e.Cancel = False
    End Sub


    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif"
        openFileDialog.Title = "Select Product Picture"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PicProduct.Image = System.Drawing.Image.FromFile(openFileDialog.FileName)

            ' Save the image to the database
            SaveImageToDatabase(openFileDialog.FileName)
        End If

        uploadedImagePath = File.ReadAllBytes(openFileDialog.FileName)
    End Sub

    Private Sub SaveImageToDatabase(imagePath As String)
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strProductId As String = lblProductId.Text
        OpenConnection()

        ' Read the image file into a byte array
        Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)

        ' Update the MemberProfiles table with the new image
        strSql = "UPDATE Redeem SET Picture = @Picture WHERE ProductId = @ProductId"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Picture", imageBytes)
        MySqlCommand.Parameters.AddWithValue("@ProductId", strProductId)

        MySqlCommand.ExecuteNonQuery()


    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Me.ValidateChildren() = False Then ' If validation result is FALSE, means there are input errors
            Return ' Stop immediately
        End If

        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        Dim strProductId As String = lblProductId.Text
        Dim strName As String = txtName.Text.Trim()
        Dim strPoints As String = txtPoints.Text.Trim()
        Dim strQuantity As String = txtQuantity.Text.Trim()
        Dim strAvailability As String = cboAvailability.SelectedItem
        Dim strDetails As String = txtDetails.Text.Trim()

        If strName = "" Then
            err.AppendLine("- Please enter the product name")
            ctr = If(ctr, txtName)
        End If

        If PicProduct.Image Is Nothing Then
            err.AppendLine("- Please upload the product picture")
            ctr = If(ctr, txtName)
        End If


        If strPoints = "" Then
            err.AppendLine("- Please enter the product points")
            ctr = If(txtPoints, txtName)
        End If

        If strQuantity = "" Then
            err.AppendLine("- Please enter the product quantity")
            ctr = If(ctr, txtQuantity)
        End If

        If cboAvailability.SelectedIndex = -1 Then
            err.AppendLine("- Please select the product availability")
            ctr = If(ctr, txtName)
        End If

        If strDetails = "" Then
            err.AppendLine("- Please enter the product details")
            ctr = If(ctr, txtDetails)
        End If



        ' (5) Check if there is input error
        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ctr.Focus()
            Return
        Else
            OpenConnection()
            strSql = "Insert Into Redeem(ProductId,Name,Details,Points,Quantity,Availability,Picture)Values(@ProductId,@Name,@Details,@Points,@Quantity,@Availability,@Picture)"
            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@ProductId", strProductId)
            MySqlCommand.Parameters.AddWithValue("@Name", strName)
            MySqlCommand.Parameters.AddWithValue("@Details", strDetails)
            MySqlCommand.Parameters.AddWithValue("@Points", Integer.Parse(strPoints))
            MySqlCommand.Parameters.AddWithValue("@Quantity", Integer.Parse(strQuantity))
            MySqlCommand.Parameters.AddWithValue("@Availability", strAvailability)
            MySqlCommand.Parameters.AddWithValue("@Picture", uploadedImagePath)


            MySqlCommand.ExecuteNonQuery()
            CloseConnection()
            'Show a message box to indicate insertion done
            MessageBox.Show("Member [" & strProductId & "] inserted", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ResetForm()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        manage_redeem.BindData()
    End Sub

    Private Sub FrmAddRedeem_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged
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