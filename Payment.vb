Imports System.Text
Imports System.Data.SqlClient

Public Class Payment
    Friend isCash As Boolean = False

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
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
    End Sub
    Private Sub GetItemsFromCart()
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "SELECT food_name, food_quantity, total_price FROM Cart"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim getFoodName As String = reader.GetString(0)
                            Dim getFoodQuantity As Integer = If(Not reader.IsDBNull(1), reader.GetInt32(1), 0)
                            Dim getTotalPrice As Decimal = If(Not reader.IsDBNull(2), reader.GetDecimal(2), 0D)

                            ' Check if the retrieved values are not empty or 0
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
                        ' Update the quantity label if the item already exists
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

    Private Sub radPayHere_CheckedChanged(sender As Object, e As EventArgs) Handles radPayHere.CheckedChanged
        If radPayHere.Checked Then
            radCard.Visible = True
            radEWallet.Visible = True
            isCash = False
        End If
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

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        radPayHere.Checked = True
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
            ElseIf mskMonth.Text < 1 Or mskMonth.Text >= 12 Then
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
                Dim strPaymentID As String = "P" & DateTime.Now.ToString("yyyyMMddHH") & New Random().Next(1, 99)

                Dim strPaymentMethod As String = ""
                If radCash.Checked Then
                    strPaymentMethod = "Cash"
                ElseIf radCard.Checked Then
                    strPaymentMethod = "Card"
                ElseIf radEWallet.Checked Then
                    strPaymentMethod = "E-Wallet"
                End If

                Dim decTotalPrice As Decimal = Form1.decFinalTotal

                InsertIntoPayment(strPaymentID, strPaymentMethod, decTotalPrice)
                InsertIntoPayedFood(strPaymentID)
                DeleteCartRecords()

                MessageBox.Show("Order placed successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub InsertIntoPayment(strPaymentID As String, strPaymentMethod As String, decTotalPrice As Decimal)
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "INSERT INTO Payment (payment_ID, payment_method, payment_totalPrice) VALUES (@paymentID, @paymentMethod, @totalPrice)"
                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@paymentID", strPaymentID)
                    command.Parameters.AddWithValue("@paymentMethod", strPaymentMethod)
                    command.Parameters.AddWithValue("@totalPrice", decTotalPrice)
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


    Private Sub InsertIntoPayedFood(strPaymentID As String)
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "INSERT INTO payedFood (payedFood_ID, payment_ID, food_name, food_quantity, food_totalPrice, pay_date, pay_time) " &
                                  "SELECT 'PF' + @paymentID + RIGHT('00' + CAST(ROW_NUMBER() OVER(ORDER BY (SELECT NULL)) AS VARCHAR(2)), 2), " &
                                  "@paymentID, food_name, food_quantity, total_price, GETDATE(), GETDATE() " &
                                  "FROM Cart"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@paymentID", strPaymentID)
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
                Dim query As String = "DELETE FROM Cart"
                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.ExecuteNonQuery()
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error removing item from the database: " & ex.Message)
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

End Class