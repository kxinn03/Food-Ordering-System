Imports System.Data.SqlClient
Imports System.IO
Public Class FrmRedeemtion
    Public strSelectedId As String
    Friend strName As String
    Friend strDetails As String
    Friend intPoints As Integer
    Friend intQuantity As Integer
    Friend strAvailability As String

    Private Sub FrmRedeemtion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2

        ' Set the form's location
        Me.Location = New Point(x, y)
        LoadProductPictureFromDatabase()
        LoadProductData()
    End Sub

    Public Sub LoadProductData()
        ' Load profile data from the database
        OpenConnection()

        Dim MySqlCommand As New SqlCommand
        Dim strSql As String



        ' Retrieve the profile data from the database
        strSql = "SELECT Name, Details, Points, Quantity, Availability FROM Redeem WHERE ProductId = @ProductId"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@ProductId", strSelectedId)

        Using reader As SqlDataReader = MySqlCommand.ExecuteReader()
            If reader.Read() Then
                ' Update the member's data
                strName = reader("Name").ToString()
                strDetails = reader("Details").ToString()
                intPoints = Integer.Parse(reader("Points"))
                intQuantity = reader("Quantity").ToString
                strAvailability = reader("Availability").ToString()
                ' Update the UI
                lblName.Text = strName
                lblDetails.Text = strDetails
                lblPoints.Text = intPoints.ToString() & " Points"
                txtQuantity.Text = "1"
            End If
        End Using

        ' Load profile picture
        LoadProductPictureFromDatabase()
    End Sub

    Private Sub LoadProductPictureFromDatabase()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        OpenConnection()


        ' Retrieve the image from the database
        strSql = "SELECT Picture FROM Redeem WHERE ProductId = @ProductId"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@ProductId", strSelectedId)

        Dim imageData As Byte() = TryCast(MySqlCommand.ExecuteScalar(), Byte())

        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            ' Convert the byte array back to an Image and set it to the PictureBox
            Using stream As New MemoryStream(imageData)
                PicProduct.Image = Image.FromStream(stream)
            End Using
        End If

    End Sub



    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        ' Check if the current quantity is greater than 1
        Dim currentQuantity As Integer = Integer.Parse(txtQuantity.Text)

        If currentQuantity > 1 Then
            ' Decrease the quantity by 1
            currentQuantity -= 1
            txtQuantity.Text = currentQuantity.ToString()
        Else
            ' Display a message indicating that the minimum quantity has been reached
            MessageBox.Show("You have reached the minimum quantity.", "Minimum Quantity Reached", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        redeem_product.intRPoints = Integer.Parse(redeem_product.lblPoints.Text)
        ' Ask the user if they are sure to redeem
        Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to redeem?", "Redeem Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            ' User clicked Yes, perform the redemption logic here
            ' For example, you can call a method to handle the redemption process

            Dim redeemQuantity As Integer = Integer.Parse(txtQuantity.Text)
            FrmRedeemQrCode.RedeemQuantity = txtQuantity.Text
            Dim productPoints As Integer = 0 ' Replace with the actual column name from your database

            ' Retrieve the points for the selected item from the database
            Dim MySqlCommand As New SqlCommand
            Dim strSql As String
            OpenConnection()

            strSql = "SELECT Points FROM Redeem WHERE ProductId = @ProductId"

            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@ProductId", strSelectedId)

            Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

            If reader.Read() Then
                productPoints = Convert.ToInt32(reader("Points"))
            End If

            reader.Close()
            CloseConnection()

            ' Calculate the total points to be deducted
            Dim totalPointsToDeduct As Integer = redeemQuantity * productPoints


            ' Deduct the total points from intPoints
            If totalPointsToDeduct <= redeem_product.intRPoints Then
                redeem_product.intRPoints -= totalPointsToDeduct

                ' Update the intPoints value wherever it's needed in your code
                ' For example, you can update a label displaying the user's points
                lblPoints.Text = intPoints.ToString()


                ' Update the quantity in the database
                OpenConnection()
                strSql = "UPDATE Redeem SET Quantity = Quantity - @RedeemQuantity WHERE ProductId = @ProductId"

                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@ProductId", strSelectedId)
                MySqlCommand.Parameters.AddWithValue("@RedeemQuantity", redeemQuantity)

                MySqlCommand.ExecuteNonQuery()

                ' Update member points in the database
                strSql = "UPDATE Member SET Points = Points - @TotalPointsToDeduct WHERE Username = @Username"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@TotalPointsToDeduct", totalPointsToDeduct)
                MySqlCommand.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)
                MySqlCommand.ExecuteNonQuery()

                ' Close the connection
                CloseConnection()

                Me.Hide()
                redeem_product.Show()
                FrmRedeemQrCode.ShowDialog()

            Else
                ' Display a message indicating that the user does not have enough points to redeem
                MessageBox.Show("You do not have enough points to redeem this quantity of the item.", "Insufficient Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        ' If the user clicks No, you can choose to do nothing or handle it accordingly
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmRedeemtion_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height
        Dim x As Integer = (screenWidth - formWidth) \ 2
        Dim y As Integer = (screenHeight - formHeight) \ 2

        ' Set the form's location
        Me.Location = New Point(x, y)
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        ' Check if the current quantity is less than the maximum quantity available for redemption
        Dim maxQuantity As Integer = 0 ' Set the default value, replace with the actual column name from your database
        Dim currentQuantity As Integer = Integer.Parse(txtQuantity.Text)
        Dim productPoints As Integer = 0 ' Replace with the actual column name from your database

        ' Retrieve the maximum quantity and points for the selected item from the database
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        OpenConnection()

        strSql = "SELECT Quantity, Points FROM Redeem WHERE ProductId = @ProductId"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@ProductId", strSelectedId)

        Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()

        If reader.Read() Then
            maxQuantity = Convert.ToInt32(reader("Quantity"))
            productPoints = Convert.ToInt32(reader("Points"))
        End If

        reader.Close()
        CloseConnection()

        ' Check if adding the product points to the current tostal exceeds the available points
        If (currentQuantity + 1) * productPoints <= redeem_product.intRPoints AndAlso currentQuantity < maxQuantity Then
            ' Increment the quantity by 1
            currentQuantity += 1
            txtQuantity.Text = currentQuantity.ToString()
        Else
            If currentQuantity >= maxQuantity Then
                ' Display a message indicating that the maximum quantity has been reached
                MessageBox.Show("You have reached the maximum quantity available for redemption.", "Maximum Quantity Reached", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Display a message indicating that the user does not have enough points to redeem more of this item
                MessageBox.Show("You do not have enough points to redeem more of this item.", "Insufficient Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
End Class