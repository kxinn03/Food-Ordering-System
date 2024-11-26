Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class RoundedGroupBox
    Inherits GroupBox
    Private _backgroundColor As Color = SystemColors.Control
    Private _groupImage As Image
    Private _textFont As Font = SystemFonts.DefaultFont
    Private _textColor As Color = SystemColors.ControlText
    Private _descriptionFont As Font = SystemFonts.DefaultFont
    Private popOutForm As Form
    Private lblCuisineName As Label
    Private picCuisine As PictureBox
    Private lblCuisinePrice As Label
    Public Property CuisineName As String
    Public Property CuisinePicture As Image
    Public Property CuisinePrice As Decimal

    Public Property GroupBoxColor As Color
        Get
            Return _backgroundColor
        End Get
        Set(value As Color)
            _backgroundColor = value
            Me.Invalidate() ' Force a repaint when the color changes
        End Set
    End Property

    Public Property GroupImage As Image
        Get
            Return _groupImage
        End Get
        Set(value As Image)
            _groupImage = value
            Me.Invalidate() ' Force a repaint when the image changes
        End Set
    End Property

    Public Property TextFont As Font
        Get
            Return _textFont
        End Get
        Set(value As Font)
            _textFont = value
            Me.Invalidate() ' Force a repaint when the font changes
        End Set
    End Property

    Public Property TextColor As Color
        Get
            Return _textColor
        End Get
        Set(value As Color)
            _textColor = value
            Me.Invalidate() ' Force a repaint when the color changes
        End Set
    End Property

    Public Property DescriptionFont As Font
        Get
            Return _descriptionFont
        End Get
        Set(value As Font)
            _descriptionFont = value
            Me.Invalidate() ' Force a repaint when the font changes
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim path As New Drawing2D.GraphicsPath()

        ' Create a rounded rectangle path
        Dim rectangle As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim intRadius As Integer = 20 ' You can adjust the radius as needed
        With path
            .AddArc(rectangle.X, rectangle.Y, intRadius, intRadius, 180, 90)
            .AddArc(rectangle.X + rectangle.Width - intRadius, rectangle.Y, intRadius, intRadius, 270, 90)
            .AddArc(rectangle.X + rectangle.Width - intRadius, rectangle.Y + rectangle.Height - intRadius, intRadius, intRadius, 0, 90)
            .AddArc(rectangle.X, rectangle.Y + rectangle.Height - intRadius, intRadius, intRadius, 90, 90)
            .CloseAllFigures()
        End With
        g.FillPath(New SolidBrush(_backgroundColor), path)

        If _groupImage IsNot Nothing Then
            Dim imageWidth As Integer = 154
            Dim imageHeight As Integer = 120
            Dim imageRectangle As New Rectangle((Me.Width - imageWidth) \ 2, 12, imageWidth, imageHeight) 'first is centre, top padding, next 2 is the picture size)
            Dim textY As Integer = imageRectangle.Bottom ' Adjust the gap between image and text
            g.DrawImage(_groupImage, imageRectangle)

            Using textBrush As New SolidBrush(_textColor)
                Dim sf As New StringFormat()
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Center
                g.DrawString(Me.Text, _textFont, textBrush, New RectangleF(10, textY, Me.Width - 20, Me.Height - textY), sf)
            End Using
        End If

        ' Draw the text and border (you can customize these as needed
        Dim borderColor As Color = SystemColors.ControlDark
        g.DrawPath(New Pen(borderColor), path)
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
        ' Show the pop-out form when the group box is clicked
        ShowPopOutForm()
    End Sub

    Private Sub ShowPopOutForm()
        If popOutForm Is Nothing Then
            ' Create and configure the pop-out form
            popOutForm = New Form()
            popOutForm.Size = New Size(500, 400)
            popOutForm.StartPosition = FormStartPosition.CenterScreen ' Center the form on the screen

            ' Add controls or content to the pop-out form as needed
            popOutForm.FormBorderStyle = FormBorderStyle.FixedSingle
            popOutForm.MaximizeBox = False

            ' 放title
            Dim strTitle As New Label()
            With strTitle
                .Text = " * Add Your Desired Food To Cart *" ' Set the desired name
                .ForeColor = Color.DarkOrange
                .Font = New Font("Arial", 12, FontStyle.Bold)
                .AutoSize = True
                .Location = New Point(120, 10) ' Adjust the location as needed
            End With
            popOutForm.Controls.Add(strTitle)


            frmMenu.strFoodName = CuisineName
            ' 那些资料
            lblCuisineName = New Label()
            With lblCuisineName
                .Text = "Cuisine Name: " & CuisineName
                .AutoSize = True
                .Location = New Point(180, strTitle.Bottom + 10)
            End With
            popOutForm.Controls.Add(lblCuisineName)

            frmMenu.foodPic = CuisinePicture
            picCuisine = New PictureBox()
            With picCuisine
                .Image = CuisinePicture
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Size = New Size(150, 150)
                .Location = New Point(180, lblCuisineName.Bottom + 10)
            End With
            popOutForm.Controls.Add(picCuisine)

            frmMenu.decFoodPrice = CuisinePrice
            lblCuisinePrice = New Label()
            With lblCuisinePrice
                .Text = "Price: RM" & CuisinePrice.ToString("0.00")
                .AutoSize = True
                .Location = New Point(180, picCuisine.Bottom + 10)
            End With
            popOutForm.Controls.Add(lblCuisinePrice)

            ' Add QUANTITY button
            Dim quantityTextBox As New TextBox()
            Dim quantityValue As Integer = 1 ' Variable to store the actual value
            Dim minusButton As New Button()
            Dim plusButton As New Button()
            frmMenu.intFoodQuantity = 1
            '跟ahting讲加这个

            With quantityTextBox
                .ReadOnly = True
                .BorderStyle = BorderStyle.FixedSingle
                .BackColor = SystemColors.Window
                .Text = "1"
                .TextAlign = HorizontalAlignment.Center
                .Font = New Font("Arial", 10)
                .Location = New Point(223, lblCuisinePrice.Bottom + 15)
                .Size = New Size(55, 22)
            End With
            popOutForm.Controls.Add(quantityTextBox)

            With minusButton
                .Text = "-"
                .Font = New Font("Modern No.20", 9)
                .Size = New Size(30, 25)
                .Location = New Point(quantityTextBox.Left - 50, quantityTextBox.Top)
                AddHandler .Click, Sub(sender As Object, e As EventArgs)
                                       If quantityValue > 1 Then
                                           quantityValue -= 1
                                           quantityTextBox.Text = quantityValue.ToString()
                                       End If

                                       ' Move the assignment inside the click event handler
                                       frmMenu.intFoodQuantity = CInt(quantityTextBox.Text)
                                   End Sub
            End With

            popOutForm.Controls.Add(minusButton)


            With plusButton
                .Text = "+"
                .Font = New Font("Modern No.20", 9)
                .Size = New Size(30, 25)
                .Location = New Point(quantityTextBox.Right + 20, quantityTextBox.Top - 1)
                AddHandler .Click, Sub(sender As Object, e As EventArgs)
                                       quantityValue += 1
                                       quantityTextBox.Text = quantityValue.ToString()

                                       ' Move the assignment inside the click event handler
                                       frmMenu.intFoodQuantity = CInt(quantityTextBox.Text)
                                   End Sub
            End With

            popOutForm.Controls.Add(plusButton)



            Dim submitButton As New Button()
            With submitButton
                .Text = "Submit"
                .Font = New Font("Mistral", 12, FontStyle.Bold)
                .Size = New Size(80, 30)
                .Location = New Point(submitButton.Width + 95, submitButton.Height + 270)
                .Visible = True

                ' Handle the Click event to save the information to the database
                AddHandler .Click, Sub(sender As Object, e As EventArgs)
                                       SaveToDatabase()
                                   End Sub
            End With
            popOutForm.Controls.Add(submitButton)

        End If

        ' Show the pop-out form
        popOutForm.Show()
    End Sub

    Private Sub PopOutForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        ' Clean up and set the reference to null when the pop-out form is closed
        popOutForm.Dispose()
        popOutForm = Nothing
        testaddcart.ShowDialog()
    End Sub

    Private Sub SaveToDatabase()
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim cartId As String = Guid.NewGuid().ToString("N").Substring(0, 10) ' Change the length of the ID as needed
                Dim memberId As String = GetMemberIdByUsername(member_profile.strLoggedInMemberUsername)


                Dim query As String = "
    IF EXISTS (SELECT 1 FROM Cart2 WHERE food_name = @food_name AND member_ID = @member_ID)
    BEGIN
        UPDATE Cart2
        SET food_quantity = food_quantity + @new_quantity,
            total_price = total_price + (@new_quantity * food_price)
        WHERE food_name = @food_name AND member_ID = @member_ID
    END
    ELSE
    BEGIN
        INSERT INTO Cart2 (cart_ID, food_name, food_quantity, food_price, food_image, total_price, member_ID)
        VALUES (@cart_ID, @food_name, @new_quantity, @food_price, @food_image, @food_price * @new_quantity, @member_ID)
    END
"
                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@cart_ID", cartId)
                    command.Parameters.AddWithValue("@food_name", frmMenu.strFoodName)
                    command.Parameters.AddWithValue("@new_quantity", frmMenu.intFoodQuantity)
                    command.Parameters.AddWithValue("@food_price", frmMenu.decFoodPrice)
                    command.Parameters.AddWithValue("@member_ID", memberId)
                    ' Convert the image to bytes and set the parameter
                    Dim imageBytes As Byte() = ImageToBytes(frmMenu.foodPic)
                    command.Parameters.AddWithValue("@food_image", imageBytes)
                    ' Add @food_price * @new_quantity to calculate total_price
                    command.ExecuteNonQuery()
                End Using


                ' Display success message
                MessageBox.Show("Add to cart successfully.")
            Else
                ' Display error message if the connection couldn't be opened
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            ' Display error message if an exception occurs
            MessageBox.Show("Error saving data to the database: " & ex.Message)
        Finally
            ' Ensure that the connection is closed even if an exception occurs
            ModuleDatabase.CloseConnection()
        End Try
    End Sub

    Private Function GetMemberIdByUsername(username As String) As String
        Dim memberId As String = ""
        ' Query the Member table to retrieve the memberID based on the username
        Dim query As String = "SELECT Id FROM Member WHERE Username = @Username"
        Using cmd As New SqlCommand(query, ModuleDatabase.conn)
            cmd.Parameters.AddWithValue("@Username", username)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                memberId = reader("Id").ToString()
            End If
            reader.Close()
        End Using
        Return memberId
    End Function

    ' Helper method to convert Image to byte array
    Private Function ImageToBytes(image As Image) As Byte()
        Using ms As New IO.MemoryStream()
            image.Save(ms, image.RawFormat) ' Change ImageFormat based on your image type
            Return ms.ToArray()
        End Using
    End Function
End Class