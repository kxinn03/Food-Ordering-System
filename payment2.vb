Imports System.Text
Imports System.Data.SqlClient
Imports System.Drawing.Printing


Public Class payment2
    Friend isCash As Boolean = False
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim paymentCounter As Integer = 0

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        paymentCounter = GetHighestPaymentIDFromDatabase() + 1
        radEWallet.Visible = False
        radCard.Visible = False
        mskCardNumber.Visible = False
        mskCVC.Visible = False
        mskHolderName.Visible = False
        mskMonth.Visible = False
        mskYear.Visible = False
        lblMonth.Visible = False
        lblYear.Visible = False
        lblCardNumber.Visible = False
        lblCVC.Visible = False
        lblMonth.Enabled = False
        lblYear.Enabled = False
        lblCardNumber.Enabled = False
        lblCVC.Enabled = False
        picCard.Visible = False
        picWarning.Visible = False
        picWarning2.Visible = False
        picWarning3.Visible = False
        picWarning4.Visible = False
        picWarning5.Visible = False
        lblSubtotal.Text = Form1.lblSubtotal.Text
        lblDiscount.Text = Form1.lblDiscount.Text
        lblServiceCharge.Text = Form1.lblServiceCharge.Text
        lblTax.Text = Form1.lblTax.Text
        lblRoundingAdjustment.Text = Form1.lblRoundingAdjustment.Text
        lblTotal.Text = Form1.lblTotal.Text
        lblPoints.Text = Form1.lblPoints.Text
        GetItemsFromCart()
        RefreshSummary()
        DisplayRoundingAdjustment(Form1.decRoundingAdjustment)
        frmMenu.Close()
    End Sub

    Private Sub GetItemsFromCart()
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim currentUsername As String = member_profile.strLoggedInMemberUsername
                Dim memberId As String = String.Empty
                Dim query2 As String = "SELECT Id FROM Member WHERE Username = @Username"

                Using cmd As New SqlCommand(query2, ModuleDatabase.conn)
                    cmd.Parameters.AddWithValue("@Username", currentUsername)

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        memberId = reader("Id").ToString()
                    End If

                    reader.Close()
                End Using

                Dim query As String = "SELECT food_name, food_quantity, total_price FROM Cart2 WHERE member_ID = @memberId"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@memberId", memberId)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim getFoodName As String = reader.GetString(0)
                            Dim getFoodQuantity As Integer = If(Not reader.IsDBNull(1), reader.GetInt32(1), 0)
                            Dim getTotalPrice As Decimal = If(Not reader.IsDBNull(2), reader.GetDecimal(2), 0D)


                            If Not String.IsNullOrEmpty(getFoodName) AndAlso getFoodQuantity > 0 AndAlso getTotalPrice > 0 Then
                                DisplayOrderSummary(getFoodName, getFoodQuantity, getTotalPrice)
                            Else
                                MessageBox.Show("Retrieved values are empty or 0.")
                            End If
                        End While
                    End Using
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving data from the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub


    Private Sub DisplayOrderSummary(food_name As String, food_quantity As Integer, total_price As Decimal)

        For Each control As Control In Panel2.Controls
            If TypeOf control Is GroupBox Then
                Dim groupBox As GroupBox = DirectCast(control, GroupBox)
                If groupBox.Controls.Count > 0 AndAlso TypeOf groupBox.Controls(1) Is Label Then
                    If DirectCast(groupBox.Controls(1), Label).Text = food_name Then

                        If groupBox.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.StartsWith("quantityLabel")) IsNot Nothing Then
                            Dim currentQuantity As Integer = Integer.Parse(groupBox.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.StartsWith("quantityLabel")).Text.Split(":"c)(1).Trim())
                            CType(groupBox.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.StartsWith("quantityLabel")), Label).Text = "Quantity: " & (currentQuantity + food_quantity)
                        End If
                        Return
                    End If
                End If
            End If
        Next

        Dim pnlItem As New Panel()
        pnlItem.Width = 530
        pnlItem.Height = 38

        Dim lblFoodName As New Label()
        lblFoodName.Text = food_name
        lblFoodName.Font = New Font("Bodoni MT", 14, FontStyle.Bold)
        lblFoodName.Location = New Point(70, 20)
        lblFoodName.Size = New Size(200, 25)

        Dim lblTotalPrice As New Label()
        lblTotalPrice.Text = total_price.ToString("C2")
        lblTotalPrice.Location = New Point(438, 20)
        lblTotalPrice.Font = New Font("Bodoni MT", 14, FontStyle.Bold)
        lblTotalPrice.Size = New Size(80, 25)

        Dim lblQuantity As New Label()
        lblQuantity.Text = food_quantity & "x "
        lblQuantity.Location = New Point(12, 20)
        lblQuantity.Font = New Font("Bodoni MT", 14, FontStyle.Bold)


        pnlItem.Controls.Add(lblFoodName)
        pnlItem.Controls.Add(lblTotalPrice)
        pnlItem.Controls.Add(lblQuantity)

        Dim topOffset As Integer = Panel2.Controls.Count * (pnlItem.Height + 10)
        pnlItem.Location = New Point(10, topOffset)

        Panel2.Controls.Add(pnlItem)

    End Sub
    Private Sub RefreshSummary()
        Panel2.Controls.Clear()
        GetItemsFromCart()
    End Sub

    Private Sub radCard_CheckedChanged(sender As Object, e As EventArgs) Handles radCard.CheckedChanged
        If radCard.Checked Then
            mskCardNumber.Visible = True
            mskCVC.Visible = True
            mskHolderName.Visible = True
            mskMonth.Visible = True
            mskYear.Visible = True
            lblMonth.Visible = True
            lblYear.Visible = True
            lblCardNumber.Visible = True
            lblCVC.Visible = True
            picCard.Visible = True
            mskCardNumber.Mask = ""
            mskCVC.Mask = ""
            mskYear.Mask = ""
            mskMonth.Mask = ""
            isCash = False
        Else
            mskCardNumber.Visible = False
            mskCVC.Visible = False
            mskHolderName.Visible = False
            mskMonth.Visible = False
            mskYear.Visible = False
            lblMonth.Visible = False
            lblYear.Visible = False
            lblCardNumber.Visible = False
            lblCVC.Visible = False
            picCard.Visible = False
            picWarning.Visible = False
            picWarning2.Visible = False
            picWarning3.Visible = False
            picWarning4.Visible = False
            picWarning5.Visible = False
        End If
    End Sub


    Private Sub mskCardNumber_Click(sender As Object, e As EventArgs) Handles mskCardNumber.Click
        lblCardNumber.Visible = False
        mskCardNumber.ForeColor = Color.Black
        mskCardNumber.Text = ""
        mskCardNumber.Mask = " 0000-0000-0000-0000"
        If mskHolderName.Text = "" Then
            picWarning.Visible = True
        Else
            picWarning.Visible = False
        End If
        If mskMonth.Text = "" Or mskMonth.MaskCompleted = False Then
            picWarning3.Visible = True
        Else
            picWarning3.Visible = False
        End If
        If mskYear.Text = "" Or mskYear.MaskCompleted = False Then
            picWarning4.Visible = True
        Else
            picWarning4.Visible = False
        End If
        If mskCVC.Text = "" Or mskCVC.MaskCompleted = False Then
            picWarning5.Visible = True
        Else
            picWarning5.Visible = False
        End If

    End Sub


    Private Sub mskCVC_Click(sender As Object, e As EventArgs) Handles mskCVC.Click
        lblCVC.Visible = False
        mskCVC.Text = ""
        mskCVC.Mask = " 000"
        mskCVC.ForeColor = Color.Black
        If mskHolderName.Text = "" Then
            picWarning.Visible = True
        Else
            picWarning.Visible = False
        End If
        If mskMonth.Text = "" Or mskMonth.MaskCompleted = False Then
            picWarning3.Visible = True
        Else
            picWarning3.Visible = False
        End If
        If mskYear.Text = "" Or mskYear.MaskCompleted = False Then
            picWarning4.Visible = True
        Else
            picWarning4.Visible = False
        End If
        If mskCardNumber.Text = "" Or mskCardNumber.MaskCompleted = False Then
            picWarning2.Visible = True
        Else
            picWarning2.Visible = False
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub radEWallet_Click(sender As Object, e As EventArgs) Handles radEWallet.Click
        If radEWallet.Checked Then
            mskCardNumber.Visible = False
            mskMonth.Visible = False
            mskYear.Visible = False
            mskCVC.Visible = False
            mskHolderName.Visible = False
            lblCardNumber.Visible = False
            lblCVC.Visible = False
            lblMonth.Visible = False
            lblYear.Visible = False
            picCard.Visible = False
        End If
    End Sub

    Private Sub mskHolderName_Click(sender As Object, e As EventArgs) Handles mskHolderName.Click
        mskHolderName.Text = ""
        mskHolderName.ForeColor = Color.Black
        If mskCVC.Text = "" Or mskCVC.MaskCompleted = False Then
            picWarning5.Visible = True
        Else
            picWarning5.Visible = False
        End If
        If mskMonth.Text = "" Or mskMonth.MaskCompleted = False Then
            picWarning3.Visible = True
        Else
            picWarning3.Visible = False
        End If
        If mskYear.Text = "" Or mskYear.MaskCompleted = False Then
            picWarning4.Visible = True
        Else
            picWarning4.Visible = False
        End If
        If mskCardNumber.Text = "" Or mskCardNumber.MaskCompleted = False Then
            picWarning2.Visible = True
        Else
            picWarning2.Visible = False
        End If
    End Sub

    Private Sub mskMonth_Click(sender As Object, e As EventArgs) Handles mskMonth.Click
        lblMonth.Visible = False
        mskMonth.Text = ""
        mskMonth.Mask = " 00"
        mskMonth.ForeColor = Color.Black
        If mskHolderName.Text = "" Then
            picWarning.Visible = True
        Else
            picWarning.Visible = False
        End If
        If mskCVC.Text = "" Or mskCVC.MaskCompleted = False Then
            picWarning5.Visible = True
        Else
            picWarning5.Visible = False
        End If
        If mskYear.Text = "" Or mskYear.MaskCompleted = False Then
            picWarning4.Visible = True
        Else
            picWarning4.Visible = False
        End If
        If mskCardNumber.Text = "" Or mskCardNumber.MaskCompleted = False Then
            picWarning2.Visible = True
        Else
            picWarning2.Visible = False
        End If
    End Sub

    Private Sub mskYear_Click(sender As Object, e As EventArgs) Handles mskYear.Click
        lblYear.Visible = False
        mskYear.Text = ""
        mskYear.Mask = " 00"
        mskYear.ForeColor = Color.Black
        If mskHolderName.Text = "" Then
            picWarning.Visible = True
        Else
            picWarning.Visible = False
        End If
        If mskMonth.Text = "" Or mskMonth.MaskCompleted = False Then
            picWarning3.Visible = True
        Else
            picWarning3.Visible = False
        End If
        If mskCVC.Text = "" Or mskCVC.MaskCompleted = False Then
            picWarning5.Visible = True
        Else
            picWarning5.Visible = False
        End If
        If mskCardNumber.Text = "" Or mskCardNumber.MaskCompleted = False Then
            picWarning2.Visible = True
        Else
            picWarning2.Visible = False
        End If
    End Sub

    Private Sub radEWallet_CheckedChanged(sender As Object, e As EventArgs) Handles radEWallet.CheckedChanged
        If radEWallet.Checked = True Then
            isCash = False

        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim strCardHolderName As String = mskHolderName.Text.Trim()

        NewmemberVoucher()
        If radCard.Checked = True Then


            If strCardHolderName = "" Or strCardHolderName = "Card Holder Name" Then
                err.AppendLine("--> [Card Nolder Name Empty]")
                ctr = If(ctr, mskHolderName)
                mskHolderName.Text = ""
                picWarning.Visible = True
                mskHolderName.ForeColor = Color.Black
            Else
                picWarning.Visible = False
            End If

            If mskCardNumber.Text = "" Or mskCardNumber.Text = "1" Then
                err.AppendLine("--> [Card Number Empty]")
                ctr = If(ctr, mskCardNumber)
                picWarning2.Visible = True
            ElseIf mskCardNumber.MaskCompleted = False Then
                err.AppendLine("--> [Card Number Incomplete]")
                ctr = If(ctr, mskCardNumber)
                picWarning2.Visible = True
            Else
                picWarning2.Visible = False
            End If

            If mskMonth.Text = "" Or mskMonth.Text = "1" Then
                err.AppendLine("--> [Expiry Month Empty]")
                ctr = If(ctr, mskMonth)
                picWarning3.Visible = True
            ElseIf mskMonth.MaskCompleted = False Then
                err.AppendLine("--> [Expiry Month Incomplete]")
                ctr = If(ctr, mskMonth)
                picWarning3.Visible = True
            ElseIf mskMonth.Text < 1 Or mskMonth.Text > 12 Then
                err.AppendLine("--> [Expiry Month must between 1 to 12]")
                ctr = If(ctr, mskMonth)
                picWarning3.Visible = True
            Else
                picWarning3.Visible = False
            End If


            If mskYear.Text = "" Or mskYear.Text = "1" Then
                err.AppendLine("--> [Expiry Year Empty]")
                ctr = If(ctr, mskYear)
                picWarning4.Visible = True
            ElseIf mskYear.MaskCompleted = False Then
                err.AppendLine("--> [Expiry Year Incomplete]")
                ctr = If(ctr, mskYear)
                picWarning4.Visible = True
            Else
                picWarning4.Visible = False
            End If

            If mskCVC.Text = "" Or mskCVC.Text = "1" Then
                err.AppendLine("--> [CVC Empty]")
                ctr = If(ctr, mskCVC)
                picWarning5.Visible = True
            ElseIf mskCVC.MaskCompleted = False Then
                err.AppendLine("--> [CVC Incomplete]")
                ctr = If(ctr, mskCVC)
                picWarning5.Visible = True
            Else
                picWarning5.Visible = False
            End If

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error")
                ctr.Focus()
                Return
            End If
        End If

        If radCash.Checked = False And radEWallet.Checked = False And radCard.Checked = False Then
            MessageBox.Show("Please select a payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show(" Are you sure to place the order? " & Environment.NewLine & " Once confirmed, you won't be able to cancel your order.", "Place Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If result = DialogResult.Yes Then


                Dim strPaymentID As String = "P" & paymentCounter.ToString("00")

                Dim strPaymentMethod As String = ""
                If radCash.Checked Then
                    strPaymentMethod = "Cash"
                ElseIf radCard.Checked Then
                    strPaymentMethod = "Card"
                ElseIf radEWallet.Checked Then
                    strPaymentMethod = "E-Wallet"
                End If

                Dim decTotalPrice As Decimal = Form1.decFinalTotal
                Dim strMemberID As String = GetMemberIdByUsername(member_profile.strLoggedInMemberUsername)
                InsertIntoPayment(strPaymentID, strPaymentMethod, decTotalPrice, strMemberID)
                InsertIntoPayedFood(strPaymentID, strMemberID)
                DeleteCartRecords()

                Dim dlgPreview As New PrintPreviewDialog()


                dlgPreview.ClientSize = New Size(1200, 1200)

                If radCash.Checked Then
                    changelongpaper()
                    PPD.Document = PD
                    PPD.ShowDialog()
                    preparing.ShowDialog()
                ElseIf radCard.Checked Then
                    successful.Show()
                ElseIf radEWallet.Checked Then
                    qr.ShowDialog()
                End If


                Form1.Close()


            End If
        End If


    End Sub


    Private Sub mskHolderName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskHolderName.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub InsertIntoPayment(strPaymentID As String, strPaymentMethod As String, decTotalPrice As Decimal, strMemberID As String)
        Try

            If ModuleDatabase.OpenConnection() Then


                Dim query As String = "INSERT INTO Payment ( payment_ID, payment_method, payment_totalPrice, member_id) VALUES (@paymentID, @paymentMethod, @totalPrice, @memberID)"
                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@paymentID", strPaymentID)
                    command.Parameters.AddWithValue("@paymentMethod", strPaymentMethod)
                    command.Parameters.AddWithValue("@totalPrice", decTotalPrice)
                    command.Parameters.AddWithValue("@memberID", strMemberID)
                    command.ExecuteNonQuery()
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting data into Payment table: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub

    Private Function GetHighestPaymentIDFromDatabase() As Integer
        Dim highestPaymentID As Integer = 0

        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "SELECT MAX(CAST(RIGHT(payment_ID, LEN(payment_ID) - 1) AS INT)) AS MaxPaymentID FROM Payment"

                Using cmd As New SqlCommand(query, ModuleDatabase.conn)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        highestPaymentID = Convert.ToInt32(result)
                    End If
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving highest payment ID: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try

        Return highestPaymentID
    End Function


    Private Sub InsertIntoPayedFood(strPaymentID As String, strMemberID As String)
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "INSERT INTO payedFood (payedFood_ID, payment_ID, food_name, food_quantity, food_totalPrice, pay_date, pay_time) " &
                                  "SELECT 'PF' + @paymentID + RIGHT('00' + CAST(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)) AS VARCHAR(2)), 2), " &
                                  "@paymentID, food_name, food_quantity, total_price, GETDATE(), GETDATE() " &
                                  "FROM Cart2 WHERE member_ID = @currentMemberID"
                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@paymentID", strPaymentID)
                    command.Parameters.AddWithValue("@currentMemberID", strMemberID)
                    command.ExecuteNonQuery()
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting data into payedFood table: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub



    Private Sub DeleteCartRecords()


        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "DELETE FROM Cart2 WHERE member_ID = (SELECT Id FROM Member WHERE Username = @Username)"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)
                    command.ExecuteNonQuery()
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error removing items from the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub

    Private Sub radCash_CheckedChanged(sender As Object, e As EventArgs) Handles radCash.CheckedChanged
        If radCash.Checked = True Then
            isCash = True
            radEWallet.Checked = False
            radCard.Checked = False
            Panel1.Visible = False
        Else
            Panel1.Visible = True

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel2.AutoScroll = True
    End Sub

    Private Sub DisplayRoundingAdjustment(decRoundingAdjustment As Decimal)

        If decRoundingAdjustment > 0 Then
            lblRoundingAdjustment.ForeColor = Color.Green
            lblRoundingAdjustment.Text = "+ " & decRoundingAdjustment.ToString("C2")
        ElseIf decRoundingAdjustment < 0 Then
            lblRoundingAdjustment.ForeColor = Color.Red
            lblRoundingAdjustment.Text = "- " & decRoundingAdjustment.ToString("C2")
        Else
            lblRoundingAdjustment.ForeColor = Color.Black
            lblRoundingAdjustment.Text = Form1.decRoundingAdjustment.ToString("C2")
        End If
    End Sub

    Private Sub radPayHere_CheckedChanged_1(sender As Object, e As EventArgs) Handles radPayHere.CheckedChanged
        If radPayHere.Checked Then
            radCard.Visible = True
            radEWallet.Visible = True
            isCash = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        radPayHere.Checked = True
    End Sub
    Private Function GetMemberIdByUsername(username As String) As String
        Dim memberId As String = ""
        Try
            If ModuleDatabase.OpenConnection() Then

                Dim query As String = "SELECT Id FROM Member WHERE Username = @Username"
                Using cmd As New SqlCommand(query, ModuleDatabase.conn)
                    cmd.Parameters.AddWithValue("@Username", username)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        memberId = reader("Id").ToString()
                    End If
                    reader.Close()
                    Return memberId
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error removing item from the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try

    End Function


    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 650, 780)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f24b As New Font("Calibri", 24, FontStyle.Bold)
        Dim f20b As New Font("Calibri", 20, FontStyle.Bold)
        Dim f16b As New Font("Calibri", 16, FontStyle.Bold)
        Dim fRegular As New Font("Calibri", 12, FontStyle.Regular)
        Dim rightAlign As New StringFormat() With {.Alignment = StringAlignment.Far}

        Dim yPosition As Integer = 20
        Dim receiptImage As Image = Global.FoodOrderingSystem.My.Resources.logo


        Dim imageWidth As Integer = 200
        Dim imageHeight As Integer = 100
        Dim imageX As Integer = (e.PageBounds.Width - imageWidth) / 2
        Dim imageY As Integer = 10


        e.Graphics.DrawImage(receiptImage, New Rectangle(imageX, imageY, imageWidth, imageHeight))
        yPosition += 80

        e.Graphics.DrawString("MINIMOO RESTAURANT", f24b, Brushes.Black, New PointF(150, yPosition))
        yPosition += 40
        e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", fRegular, Brushes.Black, New PointF(500, yPosition))
        yPosition += 20
        e.Graphics.DrawString($"Time: {DateTime.Now.ToShortTimeString()}", fRegular, Brushes.Black, New PointF(500, yPosition))
        yPosition += 40


        e.Graphics.DrawString("CASH RECEIPT", f20b, Brushes.Black, New PointF(230, yPosition))
        yPosition += 40
        e.Graphics.DrawString("************************************", f20b, Brushes.Black, New PointF(60, yPosition))
        yPosition += 40


        e.Graphics.DrawString("Quantity", f16b, Brushes.Black, New RectangleF(80, yPosition, 100, 30))
        e.Graphics.DrawString("Item", f16b, Brushes.Black, New RectangleF(190, yPosition, 200, 30))
        e.Graphics.DrawString("Price", f16b, Brushes.Black, New RectangleF(480, yPosition, 100, 30))
        yPosition += 30


        Dim strPaymentID As String = GetActualPaymentID()
        Dim yPositionItems As Integer = yPosition

        Try
            If ModuleDatabase.OpenConnection() Then

                Dim query As String = "SELECT food_quantity, food_name, food_totalPrice FROM payedFood WHERE payment_ID = @paymentID"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@paymentID", strPaymentID)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim quantity As Integer = reader.GetInt32(0)
                            Dim foodName As String = reader.GetString(1)
                            Dim totalPrice As Decimal = reader.GetDecimal(2)


                            e.Graphics.DrawString(quantity.ToString(), fRegular, Brushes.Black, New RectangleF(100, yPositionItems, 100, 30))
                            e.Graphics.DrawString(foodName, fRegular, Brushes.Black, New RectangleF(190, yPositionItems, 200, 30))
                            e.Graphics.DrawString(totalPrice.ToString("C2"), fRegular, Brushes.Black, New RectangleF(480, yPositionItems, 100, 30))

                            yPositionItems += 30
                        End While
                    End Using
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving data from the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try

        yPosition += 80
        e.Graphics.DrawString("Subtotal", fRegular, Brushes.Black, New RectangleF(190, yPosition, 100, 30))
        e.Graphics.DrawString(lblSubtotal.Text, fRegular, Brushes.Black, New RectangleF(480, yPosition, 200, 30))
        yPosition += 30


        e.Graphics.DrawString("Discount", fRegular, Brushes.Black, New RectangleF(190, yPosition, 100, 30))
        e.Graphics.DrawString(lblDiscount.Text, fRegular, Brushes.Black, New RectangleF(480, yPosition, 200, 30))
        yPosition += 30


        e.Graphics.DrawString("Service Charge (10%)", fRegular, Brushes.Black, New RectangleF(190, yPosition, 100, 70))
        e.Graphics.DrawString(lblServiceCharge.Text, fRegular, Brushes.Black, New RectangleF(480, yPosition, 200, 30))
        yPosition += 50


        e.Graphics.DrawString("Tax (6%)", fRegular, Brushes.Black, New RectangleF(190, yPosition, 100, 30))
        e.Graphics.DrawString(lblTax.Text, fRegular, Brushes.Black, New RectangleF(480, yPosition, 200, 30))
        yPosition += 30


        e.Graphics.DrawString("Rounding Adjustment", fRegular, Brushes.Black, New RectangleF(190, yPosition, 100, 70))
        e.Graphics.DrawString(lblRoundingAdjustment.Text, fRegular, Brushes.Black, New RectangleF(480, yPosition, 200, 30))
        yPosition += 60



        e.Graphics.DrawString("Total", f16b, Brushes.Black, New RectangleF(190, yPosition, 100, 30))
        e.Graphics.DrawString(Form1.decFinalTotal.ToString("C2"), f16b, Brushes.Black, New RectangleF(480, yPosition, 200, 30))

        yPosition += 40


        e.Graphics.DrawString("************************************", f20b, Brushes.Black, New PointF(60, yPosition))
        yPosition += 40
        e.Graphics.DrawString("Please bring this receipt to the counter for payment after you enjoy your food :)", fRegular, Brushes.Black, New PointF(50, yPosition))
        yPosition += 40
        e.Graphics.DrawString("Anything you need is here : --- MINIMOO restaurant", fRegular, Brushes.Black, New PointF(150, yPosition))


    End Sub
    Private Function GetActualPaymentID() As String
        Dim actualPaymentID As String = ""

        Try
            If ModuleDatabase.OpenConnection() Then

                Dim query As String = "SELECT TOP 1 payment_ID FROM Payment ORDER BY payment_ID DESC"

                Using cmd As New SqlCommand(query, ModuleDatabase.conn)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        actualPaymentID = reader("payment_ID").ToString()
                    End If

                    reader.Close()
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving actual payment ID: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try

        Return actualPaymentID
    End Function
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = Panel2.Controls.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    Private Sub NewmemberVoucher()
        Dim userId As String = GetUserIdByUsername(member_login.strUsername)
        Dim voucherId As String = "VOC01"

        Dim query As String = "SELECT COUNT(*) FROM MemberVoucher WHERE Member_id = @userId AND voucher_id = @voucherId"
        Try
            If ModuleDatabase.OpenConnection() Then

                Using cmd As New SqlCommand(query, ModuleDatabase.conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    cmd.Parameters.AddWithValue("@voucherId", voucherId)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then


                    Else

                        Dim insertQuery As String = "INSERT INTO MemberVoucher (Member_id, voucher_id) VALUES (@userId, @voucherId)"

                        Using cmdInsert As New SqlCommand(insertQuery, ModuleDatabase.conn)
                            cmdInsert.Parameters.AddWithValue("@userId", userId)
                            cmdInsert.Parameters.AddWithValue("@voucherId", voucherId)

                            cmdInsert.ExecuteNonQuery()


                        End Using
                    End If
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error retrieving data from the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub

    Private Function GetUserIdByUsername(username As String) As String
        Dim userId As String = ""

        Try
            OpenConnection()
            Dim query As String = "SELECT Id FROM Member WHERE Username = @Username"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    userId = reader("Id").ToString()
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving UserID from the database: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return userId
    End Function


End Class