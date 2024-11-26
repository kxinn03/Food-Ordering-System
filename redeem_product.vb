Imports System.Data.SqlClient
Imports System.IO

Public Class redeem_product
    Private columnsAdded As Boolean = False
    Private intPoint As Integer
    Friend intRPoints As Integer
    Friend currentPoints As Integer
    Private strGetId As String = member_profile.strLoggedInMemberUsername
    Public Class RedeemDisplay
        Public Property ProductId As String
        Public Property Name As String
        Public Property Details As String
        Public Property Points As Integer
        Public Property Quantity As Integer
        Public Property Availability As String
        Public Property Picture As Byte()
    End Class

    Private Sub DisplayMemberPoints()
        OpenConnection()
        ' Retrieve member details including ID and current points

        Dim memberSql As String = "SELECT Id, Points FROM Member WHERE Username = @Username"
        Dim memberCommand = New SqlCommand(memberSql, conn)
        memberCommand.Parameters.AddWithValue("@Username", strGetId)

        ' Execute the query and retrieve member details

        Using memberReader As SqlDataReader = memberCommand.ExecuteReader()


                If memberReader.Read() Then
                    Dim memberId As String = memberReader("Id").ToString()
                    currentPoints = memberReader("Points").ToString()

                    ' Close the memberReader before executing the paymentCommand
                    memberReader.Close()

                    ' Check if member's points are already greater than zero
                    If currentPoints = 0 Then
                        ' Retrieve total payment amount for the logged-in member
                        Dim paymentSql As String = "SELECT SUM(payment_totalPrice) FROM payment WHERE member_id = @MemberID"
                        Dim paymentCommand As New SqlCommand(paymentSql, conn)
                        paymentCommand.Parameters.AddWithValue("@MemberID", memberId)

                        Dim paymentResult As Object = paymentCommand.ExecuteScalar()
                        Dim totalPayment As Decimal = If(paymentResult IsNot Nothing AndAlso Not DBNull.Value.Equals(paymentResult), Convert.ToDecimal(paymentResult), 0)

                        currentPoints = CInt(Math.Floor(totalPayment))

                        ' Update Member table with the calculated points
                        Dim updatePointsSql As String = "UPDATE Member SET Points = @Points WHERE Id = @MemberID"
                        Dim updatePointsCommand As New SqlCommand(updatePointsSql, conn)
                        updatePointsCommand.Parameters.AddWithValue("@Points", currentPoints) ' Set pointsEarned directly
                        updatePointsCommand.Parameters.AddWithValue("@MemberID", memberId)

                        ' Execute the update query
                        updatePointsCommand.ExecuteNonQuery()

                        ' Update the member points in the UI
                        lblPoints.Text = currentPoints.ToString
                    Else
                        ' If member's points are already greater than zero, get the points from the Member table
                        lblPoints.Text = currentPoints.ToString()
                    End If
                Else
                    ' Handle the case when member details are not available
                    lblPoints.Text = "N/A"
                End If
            End Using

            CloseConnection()
    End Sub

    Private Sub BindData()
        If Not columnsAdded Then
            Dim imageColumn As New DataGridViewImageColumn()
            imageColumn.DataPropertyName = "Picture"
            imageColumn.HeaderText = "Picture"
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom ' You can adjust the layout mode as needed
            dgvRedeemProduct.Columns.Add(imageColumn)

            ' Create columns for the DataGridView
            dgvRedeemProduct.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "ProductId", .HeaderText = "ProductId", .Visible = False})
            dgvRedeemProduct.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "Name", .HeaderText = "Name"})
            dgvRedeemProduct.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "Details", .HeaderText = "Details"})
            dgvRedeemProduct.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "Points", .HeaderText = "Points"})
            dgvRedeemProduct.Columns.Add(New DataGridViewTextBoxColumn() With {.DataPropertyName = "Quantity", .HeaderText = "Stock"})

            columnsAdded = True
        End If

        Dim db As New DBDataContext()
        Dim redeemData = From redeem In db.Redeems
                         Where redeem.Availability = True AndAlso redeem.Quantity > 0' Filter by availability
                         Select New RedeemDisplay With {
                         .ProductId = redeem.ProductId,
                         .Name = redeem.Name,
                         .Details = redeem.Details,
                         .Points = redeem.Points,
                         .Quantity = redeem.Quantity,
                         .Availability = redeem.Availability,
                         .Picture = If(redeem.Picture IsNot Nothing, redeem.Picture.ToArray(), Nothing)}
        ' Set the DataGridView DataSource
        dgvRedeemProduct.AutoGenerateColumns = False
        dgvRedeemProduct.DataSource = redeemData

        ' Handle the CellFormatting event to display the images
        AddHandler dgvRedeemProduct.CellFormatting, AddressOf dgvRedeemProduct_CellFormatting
    End Sub

    Private Sub dgvRedeemProduct_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRedeemProduct.CellFormatting
        Dim pictureColumnIndex As Integer = 0 ' Index of the picture column

        If e.ColumnIndex = pictureColumnIndex AndAlso e.RowIndex >= 0 Then
            Dim cell As DataGridViewCell = dgvRedeemProduct.Rows(e.RowIndex).Cells(pictureColumnIndex)

            If cell IsNot Nothing Then
                Dim picture As Byte() = TryCast(cell.Value, Byte())

                If picture IsNot Nothing Then
                    If picture.Length > 0 Then
                        e.Value = ByteArrayToImage(picture)
                    Else
                        ' Handle the case when the byte array is empty
                        e.Value = Nothing
                    End If
                Else
                    ' Handle the case when the byte array is null
                    e.Value = Nothing
                End If
            Else
                ' Log or display an error message
                MessageBox.Show("The 'Picture' cell is null.")
            End If
        End If
    End Sub

    ' Convert byte array to Image
    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        Using stream As New MemoryStream(byteArray)
            Return Image.FromStream(stream)
        End Using
    End Function

    Private Sub redeem_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'rBtnProfile.Image = My.Resources.profileIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        'rBtnPoints.Image = My.Resources.reward_focus.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        'rBtnRedeem.Image = My.Resources.box__2_.GetThumbnailImage(58, 58, Nothing, IntPtr.Zero)
        'rBtnLogout.Image = My.Resources.logoutIcon.GetThumbnailImage(85, 85, Nothing, IntPtr.Zero)
        'rBtnMenu.Image = My.Resources.menuIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        DisplayMemberPoints()
        BindData()

    End Sub

    Private Sub dgvRedeemProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRedeemProduct.CellDoubleClick
        Dim intNo As Integer = e.RowIndex
        If intNo > -1 Then
            Dim selectedPoints As Integer = CStr(dgvRedeemProduct.Rows(intNo).Cells(4).Value)
            If Integer.Parse(lblPoints.Text) >= selectedPoints Then
                ' User has enough points, proceed with redemption
                Dim strId As String = CStr(dgvRedeemProduct.Rows(intNo).Cells(1).Value)
                FrmRedeemtion.strSelectedId = strId
                FrmRedeemtion.ShowDialog(Me)
                BindData() ' Refresh data after redemption
                lblPoints.Text = GetUpdatedPointsFromDatabase().ToString()
            Else
                ' User does not have enough points, show a message
                MessageBox.Show("You do not have enough points to redeem this item.", "Insufficient Points", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Public Function GetUpdatedPointsFromDatabase() As Integer
        Dim updatedPoints As Integer = 0
        Try
            OpenConnection()
            Dim MySqlCommand As New SqlCommand
            Dim strSql As String = "SELECT Points FROM Member WHERE Username = @Username"

            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)

            ' Execute the query and retrieve the updated points
            Dim result As Object = MySqlCommand.ExecuteScalar()
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                updatedPoints = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            ' Handle the exception, e.g., show an error message
            MessageBox.Show("Error retrieving updated points: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        Return updatedPoints
    End Function

    Private Sub rBtnLogout_Click(sender As Object, e As EventArgs)
        member_profile.strLoggedInMemberName = ""
        member_profile.strLoggedInMemberUsername = ""
        member_profile.strLoggedInMemberEmail = ""
        member_profile.strLoggedInMemberGender = ""
        member_profile.strLoggedInMemberBirthDate = ""
        member_profile.strLoggedInMemberPhoneNo = ""
        MainPage.Show()
        Me.Close()
    End Sub



    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        member_profile.Show()
        Me.Close()
    End Sub
End Class