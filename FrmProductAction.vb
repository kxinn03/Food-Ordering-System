Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmProductAction
    Public strSelectedProductId As String

    Private Sub ResetForm()
        lblProductId.Text = ""
        txtName.Text = ""
        txtDetails.Text = ""
        txtPoints.Text = ""
        txtQuantity.Text = ""
        cboAvailability.SelectedIndex = -1
        txtName.Focus()
        Err.Clear()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim db As New DBDataContext()
        Dim r As redeem = db.Redeems.FirstOrDefault(Function(o) o.ProductId = strSelectedProductId)
        If r Is Nothing Then
            MessageBox.Show("Product not found", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        '1. Set the customer object’s properties accordingly
        r.Name = txtName.Text.Trim()
        r.Details = txtDetails.Text.Trim()
        r.Points = txtPoints.Text.Trim()
        r.Quantity = txtQuantity.Text.Trim()
        r.Availability = cboAvailability.SelectedItem
        '2. Update the customer record using LINQ
        'Refer Chapter 9(B).ppt, slide 37, or 38 - Complete the code yourself
        db.SubmitChanges()
        '3. Show a message box to indicate updating done
        'Complete the code yourself
        MessageBox.Show("Product [" & strSelectedProductId & "] updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New DBDataContext()
        Dim r As redeem = db.Redeems.FirstOrDefault(Function(o) o.ProductId = strSelectedProductId)
        If r Is Nothing Then
            MessageBox.Show("Product not found", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        '1: Delete the Customer record using LINQ
        db.Redeems.DeleteOnSubmit(r)
        db.SubmitChanges()
        '2: Show a message box to indicate deletion done
        MessageBox.Show("Product [" & strSelectedProductId & "] deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub FrmProductAction_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ResetForm()
        Dim db As New DBDataContext()
        Dim r As redeem = db.Redeems.FirstOrDefault(Function(o) o.ProductId = strSelectedProductId)
        If r Is Nothing Then
            MessageBox.Show("Product not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        ' Product found --> Display details
        lblProductId.Text = r.ProductId
        txtName.Text = r.Name
        txtDetails.Text = r.Details
        txtPoints.Text = r.Points
        txtQuantity.Text = r.Quantity
        cboAvailability.SelectedItem = r.Availability
        LoadProfilePictureFromDatabase()
    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif"
        openFileDialog.Title = "Select Prodcut Picture"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PicProduct.Image = System.Drawing.Image.FromFile(openFileDialog.FileName)

            ' Save the image to the database
            SaveImageToDatabase(openFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveImageToDatabase(imagePath As String)
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        OpenConnection()

        ' Read the image file into a byte array
        Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)

        ' Update the MemberProfiles table with the new image
        strSql = "UPDATE Redeem SET Picture = @Picture WHERE ProductId = @ProductId"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Picture", imageBytes)
        MySqlCommand.Parameters.AddWithValue("@ProductId", strSelectedProductId)

        MySqlCommand.ExecuteNonQuery()


    End Sub

    Private Sub LoadProfilePictureFromDatabase()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        OpenConnection()


        ' Retrieve the image from the database
        strSql = "SELECT Picture FROM Redeem WHERE ProductId = @ProductId"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@ProductId", strSelectedProductId)

        Dim imageData As Byte() = TryCast(MySqlCommand.ExecuteScalar(), Byte())

        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            ' Convert the byte array back to an Image and set it to the PictureBox
            Using stream As New MemoryStream(imageData)
                PicProduct.Image = Image.FromStream(stream)
            End Using
        Else
            ' If the image is null, set PictureBox to Nothing
            PicProduct.Image = Nothing
        End If

    End Sub

    Private Sub FrmProductAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2

        ' Set the form's location
        Me.Location = New Point(x, y)
        LoadProfilePictureFromDatabase()
    End Sub

    Private Sub FrmProductAction_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
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