Imports System.Data.SqlClient
Imports System.IO

Public Class Form1
    Friend decSubTotal As Decimal = 0D
    Friend decDiscount As Decimal = 0D
    Friend decNetTotal As Decimal = 0D
    Friend decTotal As Decimal = 0D
    Friend decFinalTotal As Decimal = 0D
    Friend decServiceCharged As Decimal = 0D
    Friend decTaxCharged As Decimal = 0D
    Friend decRoundingAdjustment As Decimal = 0D
    Friend intPoint As Integer = 0
    Friend Const decSERVICE_CHARGE As Decimal = 0.1D
    Friend Const decTAX As Decimal = 0.06D
    Friend minimumSpendCriteria As Decimal = 0D

    Private Sub CalculatePrice()

        decNetTotal = decSubTotal - decDiscount
        decServiceCharged = decNetTotal * decSERVICE_CHARGE
        decTaxCharged = decNetTotal * decTAX
        decTotal = decNetTotal + decServiceCharged + decTaxCharged
        decRoundingAdjustment = CalculateRoundingAdjustment(decTotal)
        decTotal += decRoundingAdjustment
        decFinalTotal = decTotal
        If decNetTotal < 0 Then
            decNetTotal = 0
            decTotal = decServiceCharged + decTaxCharged
        End If
        intPoint = CInt(Math.Floor(decFinalTotal))
        DisplayRoundingAdjustment(decRoundingAdjustment)
        UpdateDisplayedValues()
        RecheckMinimumSpend()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        RoundCornerButton(btnExit)
        RoundCornerLabel(Label8)
        GetItemsFromCart()
        RefreshCartItems()
        CalculatePrice()
        UpdateDisplayedValues()
        picDone.Visible = False
        EmptyCartVisibility()
        RecheckMinimumSpend()
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

                Dim query As String = "SELECT food_name, food_price, food_quantity, food_image, total_price FROM Cart2 WHERE member_ID = @memberId"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@memberId", memberId)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim cartItems As New Dictionary(Of String, Tuple(Of Decimal, Integer, Byte()))()
                        decSubTotal = 0D

                        While reader.Read()
                            Dim food_name As String = reader.GetString(0)
                            Dim food_price As Decimal = If(Not reader.IsDBNull(1), reader.GetDecimal(1), 0D)
                            Dim food_quantity As Integer = If(Not reader.IsDBNull(2), reader.GetInt32(2), 0)
                            Dim foodImageBytes As Byte() = CType(reader("food_image"), Byte())

                            cartItems.Add(food_name, New Tuple(Of Decimal, Integer, Byte())(food_price, food_quantity, foodImageBytes))
                            decSubTotal += food_price * food_quantity

                        End While


                        Panel1.Controls.Clear()

                        For Each cartItem In cartItems
                            DisplayCartItem(cartItem.Key, cartItem.Value.Item1, cartItem.Value.Item2, cartItem.Value.Item3)
                        Next
                    End Using
                End Using


                CalculatePrice()
                UpdateDisplayedValues()
                EmptyCartVisibility()

            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving data from the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub

    Private Sub DisplayCartItem(food_name As String, total_price As Decimal, food_quantity As Integer, foodImageBytes As Byte())

        For Each control As Control In Panel1.Controls
            If TypeOf control Is GroupBox Then
                Dim groupBox As GroupBox = DirectCast(control, GroupBox)
                If groupBox.Controls.Count > 0 AndAlso TypeOf groupBox.Controls(1) Is Label Then
                    Dim labelControl As Label = DirectCast(groupBox.Controls(1), Label)
                    If labelControl.Text = food_name Then

                        Dim quantityLabel = groupBox.Controls.OfType(Of Label)().FirstOrDefault(Function(lbl) lbl.Name.StartsWith("quantityLabel"))
                        If quantityLabel IsNot Nothing Then
                            Dim currentQuantity As Integer = Integer.Parse(quantityLabel.Text.Split(":"c)(1).Trim())
                            quantityLabel.Text = "Quantity: " & (currentQuantity + food_quantity)
                        End If
                        Return
                    End If
                End If
            End If
        Next


        Dim grpItem As New GroupBox()
        grpItem.Width = 500
        grpItem.Height = 120


        Dim picBox As New PictureBox()
        picBox.Image = BytesToImage(foodImageBytes)
        picBox.SizeMode = PictureBoxSizeMode.Zoom
        picBox.Width = 90
        picBox.Height = 90
        picBox.Location = New Point(40, 20)


        Dim lblName As New Label()
        lblName.Text = food_name
        lblName.Location = New Point(150, 60)

        Dim lblTotalPrice As New Label()
        lblTotalPrice.Text = (total_price * food_quantity).ToString("C2")
        lblTotalPrice.Location = New Point(400, 60)
        lblTotalPrice.Font = New Font(lblTotalPrice.Font, FontStyle.Bold)
        lblTotalPrice.Size = New Size(80, 25)

        Dim txtQuantity As New TextBox()
        txtQuantity.Name = "quantityTextBox" & food_name
        txtQuantity.TextAlign = HorizontalAlignment.Center
        txtQuantity.Enabled = False
        txtQuantity.Text = food_quantity.ToString()
        txtQuantity.Location = New Point(285, 58)
        txtQuantity.Size = New Size(50, 20)
        txtQuantity.ReadOnly = True


        Dim btnPlus As New Button()
        btnPlus.Text = "+"
        btnPlus.Size = New Size(30, 22)
        btnPlus.Font = New Font(btnPlus.Font, FontStyle.Bold)
        btnPlus.Location = New Point(340, 57)

        AddHandler btnPlus.Click, Sub(sender As Object, e As EventArgs)
                                      Dim currentQuantity As Integer = Integer.Parse(txtQuantity.Text)
                                      currentQuantity += 1
                                      txtQuantity.Text = currentQuantity.ToString()
                                      UpdateQuantityInDatabase(food_name, currentQuantity)
                                      RefreshCartItems()
                                      CalculatePrice()
                                      UpdateDisplayedValues()
                                      lblTotalPrice.Text = (total_price * currentQuantity).ToString("C2")
                                  End Sub

        Dim btnMinus As New Button()
        With btnMinus
            .Text = "-"
            .Size = New Size(30, 22)
            .Location = New Point(250, 57)
            .Font = New Font(btnMinus.Font, FontStyle.Bold)
            AddHandler .Click, Sub(sender As Object, e As EventArgs)
                                   Dim currentQuantity As Integer = Integer.Parse(txtQuantity.Text)
                                   If currentQuantity > 1 Then
                                       currentQuantity -= 1
                                       txtQuantity.Text = currentQuantity.ToString()
                                       lblTotalPrice.Text = (total_price * currentQuantity).ToString("C2")
                                       UpdateQuantityInDatabase(food_name, currentQuantity)
                                       RefreshCartItems()
                                       CalculatePrice()
                                       UpdateDisplayedValues()
                                   ElseIf currentQuantity = 1 Then
                                       Dim groupBox As GroupBox = CType(btnMinus.Parent, GroupBox)
                                       Dim result As DialogResult = MessageBox.Show("Are you confirm to remove " & food_name & "?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                       If result = DialogResult.Yes Then
                                           Panel1.Controls.Remove(groupBox)
                                           RemoveItemFromDatabase(food_name)
                                           EmptyCartVisibility()
                                           CalculatePrice()
                                           UpdateDisplayedValues()
                                           RefreshCartItems()
                                           RecheckMinimumSpend()
                                       End If
                                   End If

                               End Sub
        End With
        Dim btnDelete As New Button()
        With btnDelete
            .Width = 28
            .Height = 29
            .Location = New Point(10, 52)
            .Text = "X"
            .Visible = False
            .ForeColor = Color.Red
            .Font = New Font("Arial", 12, FontStyle.Bold)
            .BackgroundImage = Global.FoodOrderingSystem.My.Resources._5974627
            AddHandler .Click, Sub(sender As Object, e As EventArgs)
                                   Dim groupBox As GroupBox = CType(btnDelete.Parent, GroupBox)
                                   Dim result As DialogResult = MessageBox.Show("Confirm to delete " & food_name & " from your cart?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                   If result = DialogResult.Yes Then
                                       Panel1.Controls.Remove(groupBox)
                                       RemoveItemFromDatabase(food_name)
                                       EmptyCartVisibility()
                                       CalculatePrice()
                                       UpdateDisplayedValues()
                                       RefreshCartItems()
                                       RecheckMinimumSpend()
                                   Else

                                   End If


                               End Sub
        End With
        AddHandler picDelete.Click, Sub(sender As Object, e As EventArgs)
                                        btnDelete.Visible = True

                                        If btnDelete.Visible = True Then
                                            lblName.Enabled = False
                                            lblTotalPrice.Enabled = False
                                            txtQuantity.Enabled = False
                                            btnPlus.Enabled = False
                                            btnMinus.Enabled = False
                                            picDone.Visible = True
                                            picDelete.Visible = False
                                            Label9.Text = "Done"
                                            Label9.ForeColor = Color.Green
                                            LinkLabel2.Enabled = False
                                            Label11.Enabled = False
                                            picDone.Enabled = True
                                            picClear.Enabled = False

                                        End If

                                    End Sub
        AddHandler picDone.Click, Sub(sender As Object, e As EventArgs)

                                      btnDelete.Visible = False
                                      If btnDelete.Visible = False Then
                                          lblName.Enabled = True
                                          lblTotalPrice.Enabled = True
                                          txtQuantity.Enabled = True
                                          btnPlus.Enabled = True
                                          btnMinus.Enabled = True
                                          picDone.Visible = False
                                          picDelete.Visible = True
                                          Label9.Text = "Remove"
                                          Label9.ForeColor = Color.Red
                                          LinkLabel2.Enabled = True
                                          Label11.Enabled = True
                                          picDone.Enabled = False
                                          picClear.Enabled = True
                                      End If
                                  End Sub

        grpItem.Controls.Add(picBox)
        grpItem.Controls.Add(lblName)
        grpItem.Controls.Add(lblTotalPrice)
        grpItem.Controls.Add(txtQuantity)
        grpItem.Controls.Add(btnPlus)
        grpItem.Controls.Add(btnMinus)
        grpItem.Controls.Add(btnDelete)

        Dim topOffset As Integer = Panel1.Controls.Count * (grpItem.Height + 10)
        grpItem.Location = New Point(10, topOffset)

        Panel1.Controls.Add(grpItem)
        EmptyCartVisibility()
    End Sub
    Private Sub UpdateQuantityInDatabase(food_name As String, newQuantity As Integer)
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim currentUsername As String = member_profile.strLoggedInMemberUsername
                Dim memberId As String = String.Empty


                Dim queryGetMemberId As String = "SELECT Id FROM Member WHERE Username = @Username"

                Using cmdGetMemberId As New SqlCommand(queryGetMemberId, ModuleDatabase.conn)
                    cmdGetMemberId.Parameters.AddWithValue("@Username", currentUsername)
                    Dim reader As SqlDataReader = cmdGetMemberId.ExecuteReader()

                    If reader.Read() Then
                        memberId = reader("Id").ToString()
                    End If

                    reader.Close()
                End Using


                Dim query As String = "UPDATE Cart2 SET food_quantity = @newQuantity, total_price = food_price * @newQuantity WHERE member_ID = @memberId AND food_name = @foodName"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@newQuantity", newQuantity)
                    command.Parameters.AddWithValue("@memberId", memberId)
                    command.Parameters.AddWithValue("@foodName", food_name)
                    command.ExecuteNonQuery()
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating quantity in the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub


    Private Sub RemoveItemFromDatabase(food_name As String)
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim currentUsername As String = member_profile.strLoggedInMemberUsername
                Dim memberId As String = String.Empty


                Dim queryGetMemberId As String = "SELECT Id FROM Member WHERE Username = @Username"

                Using cmdGetMemberId As New SqlCommand(queryGetMemberId, ModuleDatabase.conn)
                    cmdGetMemberId.Parameters.AddWithValue("@Username", currentUsername)
                    Dim reader As SqlDataReader = cmdGetMemberId.ExecuteReader()

                    If reader.Read() Then
                        memberId = reader("Id").ToString()
                    End If

                    reader.Close()
                End Using


                Dim query As String = "DELETE FROM Cart2 WHERE member_ID = @memberId AND food_name = @foodName"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    command.Parameters.AddWithValue("@memberId", memberId)
                    command.Parameters.AddWithValue("@foodName", food_name)
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


    Private Sub RefreshCartItems()

        Panel1.Controls.Clear()
        GetItemsFromCart()
        picDelete.Visible = True
        picDone.Visible = False
        Label9.Text = "Remove"
        Label9.ForeColor = Color.Red
        LinkLabel2.Enabled = True
        Label11.Enabled = True
        picDone.Enabled = False
        picClear.Enabled = True
    End Sub

    Private Function BytesToImage(imageBytes As Byte()) As Image
        Using ms As New MemoryStream(imageBytes)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMenu.Show()

    End Sub

    Private Sub RoundCornerButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.White
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(btnExit.Width, 20, btn.Width, btn.Height - 10)
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        btnExit.Region = New Region(rad)
    End Sub

    Private Sub RoundCornerLabel(lbl As Label)
        lbl.FlatStyle = FlatStyle.Flat
        lbl.BackColor = Color.White
        lbl.ForeColor = Color.White
        lbl.Cursor = Cursors.Hand
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, lbl.Width - 20, 0)
        rad.AddArc(New Rectangle(lbl.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(Label8.Width, 20, lbl.Width, lbl.Height - 10)
        rad.AddLine(Label15.Width, 20, lbl.Width, lbl.Height - 10)
        rad.AddLine(Label12.Width, 20, lbl.Width, lbl.Height - 10)
        rad.AddLine(Label28.Width, 20, lbl.Width, lbl.Height - 10)
        rad.AddArc(New Rectangle(lbl.Width - 25, lbl.Height - 25, 25, 25), 0, 90)
        rad.AddLine(lbl.Width - 10, lbl.Width, 20, lbl.Height)
        rad.AddArc(New Rectangle(0, lbl.Height - 20, 20, 20), 90, 90)
        Label8.Region = New Region(rad)
        Label15.Region = New Region(rad)
        Label12.Region = New Region(rad)
        Label28.Region = New Region(rad)
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Panel1.AutoScroll = True
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        payment2.Show()
        Me.Hide()

    End Sub

    Private Sub btnVoucher_Click(sender As Object, e As EventArgs) Handles btnVoucher.Click
        voucher.Show()

    End Sub


    Private Sub picClear_Click(sender As Object, e As EventArgs) Handles picClear.Click

        If Panel1.Controls.Count = 0 Then
            MessageBox.Show("Your cart is already empty.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim result As DialogResult = MessageBox.Show("Confirm to clear the cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Panel1.Controls.Clear()
                ClearCart()
                decSubTotal = 0D
                decDiscount = 0D
                EmptyCartVisibility()
                CalculatePrice()
                UpdateDisplayedValues()
                RecheckMinimumSpend()
            End If
        End If

    End Sub

    Private Sub ClearCart()
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

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim().ToLower()
        Dim visibleItemCount As Integer = 0


        For Each control As Control In Panel1.Controls
            If TypeOf control Is GroupBox Then
                Dim groupBox As GroupBox = DirectCast(control, GroupBox)
                If groupBox.Controls.Count > 0 AndAlso TypeOf groupBox.Controls(1) Is Label Then
                    Dim lblName As Label = DirectCast(groupBox.Controls(1), Label)
                    Dim strItemName As String = lblName.Text.ToLower()


                    If strItemName.Contains(searchText) Then
                        groupBox.Visible = True
                        groupBox.Location = New Point(10, visibleItemCount * (groupBox.Height + 10))
                        visibleItemCount += 1
                    Else
                        groupBox.Visible = False
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub EmptyCartVisibility()
        lblEmptyCart.Visible = (Panel1.Controls.Count = 0)
        If Panel1.Controls.Count = 0 Then
            btnCheckout.Enabled = False
            btnVoucher.Enabled = False
        Else
            btnCheckout.Enabled = True
            btnVoucher.Enabled = True
        End If
    End Sub

    Private Sub UpdateDisplayedValues()
        lblSubtotal.Text = decSubTotal.ToString("C2")
        lblNetTotal.Text = decNetTotal.ToString("C2")
        lblServiceCharge.Text = decServiceCharged.ToString("C2")
        lblTax.Text = decTaxCharged.ToString("C2")
        lblTotal.Text = decFinalTotal.ToString("C2")
        lblPoints.Text = "+ " & intPoint.ToString() & " points"
        lblDiscount.Text = decDiscount.ToString("C2")
    End Sub
    Private Function CalculateRoundingAdjustment(decTotalAmount As Decimal) As Decimal
        Dim decRoundedTotal As Decimal = Math.Round(decTotalAmount, 2, MidpointRounding.AwayFromZero)

        Dim intLastDigit As Integer = CInt((decRoundedTotal * 100) Mod 10)
        Dim decRoundingAdjustment As Decimal = 0D

        Select Case intLastDigit
            Case 1
                decRoundingAdjustment = -0.01D
            Case 2
                decRoundingAdjustment = -0.02D
            Case 3
                decRoundingAdjustment = +0.02D
            Case 4
                decRoundingAdjustment = +0.01D
            Case 6
                decRoundingAdjustment = -0.01D
            Case 7
                decRoundingAdjustment = -0.02D
            Case 8
                decRoundingAdjustment = +0.02D
            Case 9
                decRoundingAdjustment = +0.01D
        End Select

        Return decRoundingAdjustment

    End Function

    Private Sub DisplayRoundingAdjustment(decRoundingAdjustment As Decimal)

        If decRoundingAdjustment > 0 Then
            lblRoundingAdjustment.ForeColor = Color.Green
            lblRoundingAdjustment.Text = "+ " & decRoundingAdjustment.ToString("C2")
        ElseIf decRoundingAdjustment < 0 Then
            lblRoundingAdjustment.ForeColor = Color.Red
            lblRoundingAdjustment.Text = "- " & decRoundingAdjustment.ToString("C2")
        Else
            lblRoundingAdjustment.ForeColor = Color.Black
            lblRoundingAdjustment.Text = decRoundingAdjustment.ToString("C2")
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        decDiscount = 0D
        lblDiscount.Text = ""
    End Sub

    Private Sub RecheckMinimumSpend()

        If decSubTotal < minimumSpendCriteria AndAlso decDiscount > 0 Then

            decDiscount = 0
            MessageBox.Show("Your subtotal is below the minimum spend. Voucher discount removed.")

            CalculatePrice()
        End If
    End Sub

End Class