Imports System.Data.SqlClient

Public Class voucher

    Friend voucherName As String
    Private Sub txtVoucherCode_Click(sender As Object, e As EventArgs) Handles txtVoucherCode.Click

        txtVoucherCode.Text = ""
        txtVoucherCode.ForeColor = Color.Black
    End Sub



    Private Sub voucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtVoucherCode.ScrollBars = txtVoucherCode.ScrollBars.None
        RoundCornerButton(btnApply)
        RoundCornerLabel(Label3)
        Me.ActiveControl = btnApply
    End Sub

    Private Sub txtVoucherCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVoucherCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Suppress the Enter key press
        End If
    End Sub
    Private Sub RoundCornerButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.FromArgb(219, 0, 120)
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, btn.Width - 20, 0)
        rad.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(btnApply.Width, 20, btn.Width, btn.Height - 10)
        rad.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        rad.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        rad.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        btnApply.Region = New Region(rad)

    End Sub
    Private Sub RoundCornerLabel(lbl As Label)
        lbl.FlatStyle = FlatStyle.Flat
        lbl.BackColor = Color.WhiteSmoke
        lbl.ForeColor = Color.Gray
        lbl.Cursor = Cursors.Hand
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, lbl.Width - 20, 0)
        rad.AddArc(New Rectangle(lbl.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(Label3.Width, 20, lbl.Width, lbl.Height - 10)
        rad.AddArc(New Rectangle(lbl.Width - 25, lbl.Height - 25, 25, 25), 0, 90)
        rad.AddLine(lbl.Width - 10, lbl.Width, 20, lbl.Height)
        rad.AddArc(New Rectangle(0, lbl.Height - 20, 20, 20), 90, 90)
        Label3.Region = New Region(rad)
    End Sub

    Private Sub pnlAllVoucher_Paint(sender As Object, e As PaintEventArgs) Handles voucherPanel.Paint
        voucherPanel.AutoScroll = True

    End Sub




    Private Sub pnlVoucherMember_Click(sender As Object, e As PaintEventArgs) Handles pnlVoucherMember.Click


    End Sub

    Private Sub picVoucherMember_Click(sender As Object, e As EventArgs) Handles picVoucherMember.Click
        voucherDetails.Show()
        voucherDetails.lblVoucherName.Text = "FIRST ORDER!"
        voucherDetails.lblDetails.Text = "• Capped at RM 10.00 with no minimum spend" & Environment.NewLine & "• For first order only." & Environment.NewLine & "• Limited to 1 redemption per member."
    End Sub


    Private Sub picVoucherSide_Click(sender As Object, e As EventArgs) Handles picVoucherSide.Click
        voucherDetails.Show()
        voucherDetails.lblVoucherName.Text = "GOOD DAY !"
        voucherDetails.lblDetails.Text = "• 20% Discount with RM 15.00 minimum spend" & Environment.NewLine & "• For new && existing member." & Environment.NewLine & "• No limited redemption."
    End Sub

    Private Sub pivVoucherEatMore_Click(sender As Object, e As EventArgs) Handles pivVoucherEatMore.Click
        voucherDetails.Show()
        voucherDetails.lblVoucherName.Text = "EAT MORE, SAVE MORE!"
        voucherDetails.lblDetails.Text = "• Capped at RM 7.00 with RM 35.00 minimum spend" & Environment.NewLine & "• For new && existing member." & Environment.NewLine & "• No limited redemption."
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        RedeemVoucher.Show()

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        picVoucherMember_Click(Nothing, Nothing)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        picVoucherMember_Click(Nothing, Nothing)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        picVoucherMember_Click(Nothing, Nothing)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        picVoucherMember_Click(Nothing, Nothing)
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        picVoucherSide_Click(Nothing, Nothing)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        picVoucherSide_Click(Nothing, Nothing)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        picVoucherSide_Click(Nothing, Nothing)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        picVoucherSide_Click(Nothing, Nothing)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        picVoucherSide_Click(Nothing, Nothing)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        pivVoucherEatMore_Click(Nothing, Nothing)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        pivVoucherEatMore_Click(Nothing, Nothing)
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        pivVoucherEatMore_Click(Nothing, Nothing)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        pivVoucherEatMore_Click(Nothing, Nothing)
    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        pivVoucherEatMore_Click(Nothing, Nothing)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        voucherName = "New Member"

        Dim strId As String = GetUserIdByUsername(member_login.strUsername)
        Dim strVoucherId As String = "VOC01"

        Dim query As String = "SELECT COUNT(*) FROM MemberVoucher WHERE Member_id = @userId AND voucher_id = @voucherId"
        Try
            If ModuleDatabase.OpenConnection() Then

                Using cmd As New SqlCommand(query, ModuleDatabase.conn)
                    cmd.Parameters.AddWithValue("@userId", strId)
                    cmd.Parameters.AddWithValue("@voucherId", strVoucherId)

                    Dim intCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If intCount > 0 Then
                        MessageBox.Show("You have already used this voucher.")
                        pnlVoucherMember.Enabled = False
                    Else
                        Form1.decDiscount = 10D
                        MessageBox.Show("Voucher applied successfully!", "Apply Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()

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
        Dim strId As String = ""

        Try
            OpenConnection()
            Dim query As String = "SELECT Id FROM Member WHERE Username = @Username"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    strId = reader("Id").ToString()
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving UserID from the database: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return strId
    End Function
    Private Sub pnlVoucherMember_Paint(sender As Object, e As PaintEventArgs) Handles pnlVoucherMember.Paint

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.minimumSpendCriteria = 15D
        If Form1.decSubTotal <= 15D Then
            MessageBox.Show("Minspend RM15.00 to appy this voucher", "Apply Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Form1.decDiscount = Form1.decSubTotal * 0.2D
            MessageBox.Show("Voucher applied successfully!", "Apply Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()




        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        Form1.minimumSpendCriteria = 35D
        If Form1.decSubTotal <= 35D Then
            MessageBox.Show("Minspend RM35.00 to appy this voucher", "Apply Unseccessful", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Form1.decDiscount = 7D
            MessageBox.Show("Voucher applied successfully!", "Apply Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub txtVoucherCode_TextChanged(sender As Object, e As EventArgs) Handles txtVoucherCode.TextChanged

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim userId As String = GetUserIdByUsername(member_login.strUsername)
        Dim voucherId As String = "VOC05"

        If txtVoucherCode.Text = "shhh888" Then
            Form1.decDiscount = 8.88D
            MessageBox.Show("Voucher applied successfully!", "Apply Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf txtVoucherCode.Text = "newmember10" Then
            LinkLabel3_LinkClicked(Nothing, Nothing)

            Me.Close()
        ElseIf txtVoucherCode.Text = "goodday20" Then
            LinkLabel2_LinkClicked(Nothing, Nothing)

            Me.Close()

        ElseIf txtVoucherCode.Text = "moremore7" Then
            LinkLabel4_LinkClicked(Nothing, Nothing)

            Me.Close()

        ElseIf txtVoucherCode.Text = "" Then
            MessageBox.Show("Voucher Code Empty", "Apply Unseccessful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtVoucherCode.Text = "feedback50" Then
            Dim eligibleForVoucher As Boolean = CheckVoucherEligibility(userId, voucherId)
            If eligibleForVoucher Then
                Form1.decDiscount = Form1.decSubTotal * 0.5D
                MessageBox.Show("Voucher applied successfully!", "Apply Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Voucher cannot be applied. Check eligibility criteria.", "Apply Unseccessful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub


    Private Function CheckVoucherEligibility(userId As String, voucherId As String) As Boolean
        Dim voucherAppliedCount As Integer = GetAppliedVoucherCount(userId, voucherId)

        Dim hasSubmittedFeedback As Boolean = CheckFeedbackSubmission(userId)


        If voucherAppliedCount = 0 AndAlso hasSubmittedFeedback Then
            Return True
        End If

        Return False
    End Function

    Private Function GetAppliedVoucherCount(userId As String, voucherId As String) As Integer
        Dim query As String = "SELECT COUNT(*) FROM MemberVoucher WHERE Member_id = @userId AND voucher_id = @voucherId"
        Try
            If ModuleDatabase.OpenConnection() Then
                Using cmd As New SqlCommand(query, ModuleDatabase.conn)
                    cmd.Parameters.AddWithValue("@userId", userId)
                    cmd.Parameters.AddWithValue("@voucherId", voucherId)

                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving applied voucher count: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try

        Return 0
    End Function

    Private Function CheckFeedbackSubmission(userId As String) As Boolean
        Dim feedbackSubmitted As Boolean = False

        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "SELECT feedback FROM Member WHERE Id = @userId"
                Using cmd As New SqlCommand(query, ModuleDatabase.conn)
                    cmd.Parameters.AddWithValue("@userId", userId)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        feedbackSubmitted = Convert.ToBoolean(result)
                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking feedback submission: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try

        Return feedbackSubmitted
    End Function

    Private Sub LinkLabel4_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

    End Sub
End Class