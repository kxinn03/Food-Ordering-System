Imports System.Data.SqlClient
Public Class points
    Private strGetId2 As String = member_profile.strLoggedInMemberUsername
    Private Sub points_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'rBtnProfile.Image = My.Resources.profileIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        'rBtnPoints.Image = My.Resources.reward_focus.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        'rBtnRedeem.Image = My.Resources.box__2_.GetThumbnailImage(58, 58, Nothing, IntPtr.Zero)
        'rBtnLogout.Image = My.Resources.logoutIcon.GetThumbnailImage(85, 85, Nothing, IntPtr.Zero)
        'rBtnMenu.Image = My.Resources.menuIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        lblPoints.Text = redeem_product.currentPoints
        DisplayMemberPoints()
        BindData()
    End Sub
    Private Sub BindData()
        Try
            OpenConnection()
            Dim memberCommand As New SqlCommand
            Dim memberSql As String = "SELECT Id, Points FROM Member WHERE Username = @Username"
            memberCommand = New SqlCommand(memberSql, conn)
            memberCommand.Parameters.AddWithValue("@Username", strGetId2)

            ' Execute the query and retrieve member details
            Dim memberReader As SqlDataReader = memberCommand.ExecuteReader()
            If memberReader.Read() Then
                Dim memberId As String = memberReader("Id").ToString()
                memberReader.Close()

                ' LINQ query to retrieve payment data and corresponding payedFood data
                Dim db As New DBDataContext()
                Dim query = (From Payment In db.Payments
                             Join payedFood In db.payedFoods On Payment.payment_ID Equals payedFood.payment_ID
                             Where Payment.member_id = memberId
                             Select New With
                                {
                                    Payment.payment_ID,
                                    Payment.payment_totalPrice,
                                    payedFood.pay_date
                            }).Distinct()

                ' Convert the LINQ query result to a list
                Dim resultList = query.ToList()
                ' Bind the list to the DataGridView
                dgvHistory.DataSource = resultList
            End If
        Catch ex As Exception
            ' Handle any exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    'Private Sub DisplayMemberPoints()
    '    OpenConnection()
    '    Retrieve Member details including ID And current points
    '    Dim memberCommand As New SqlCommand
    '    Dim memberSql As String = "SELECT Id, Points FROM Member WHERE Username = @Username"
    '    memberCommand = New SqlCommand(memberSql, conn)
    '    memberCommand.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)

    '    Execute the query And retrieve member details
    '    Dim memberReader As SqlDataReader = memberCommand.ExecuteReader()

    '    If memberReader.Read() Then
    '        Dim memberId As String = memberReader("Id").ToString()
    '        Dim currentPoints As Integer = memberReader("Points").ToString()

    '        Close the memberReader before executing the paymentCommand
    '        memberReader.Close()

    '        Check If member's points are already greater than zero
    '        If currentPoints = 0 Then
    '            Retrieve total payment amount for the logged-in member
    '            Dim paymentSql As String = "SELECT SUM(payment_totalPrice) FROM payment WHERE member_id = @MemberID"
    '            Dim paymentCommand As New SqlCommand(paymentSql, conn)
    '            paymentCommand.Parameters.AddWithValue("@MemberID", memberId)

    '            Dim paymentResult As Object = paymentCommand.ExecuteScalar()
    '            Dim totalPayment As Decimal = If(paymentResult IsNot Nothing AndAlso Not DBNull.Value.Equals(paymentResult), Convert.ToDecimal(paymentResult), 0)

    '            Dim pointsEarned As Integer = CInt(Math.Floor(totalPayment))

    '            Update Member table with the calculated points
    '            Dim updatePointsSql As String = "UPDATE Member SET Points = @Points WHERE Id = @MemberID"
    '            Dim updatePointsCommand As New SqlCommand(updatePointsSql, conn)
    '            updatePointsCommand.Parameters.AddWithValue("@Points", pointsEarned) ' Set pointsEarned directly
    '            updatePointsCommand.Parameters.AddWithValue("@MemberID", memberId)

    '            Execute the update query
    '            updatePointsCommand.ExecuteNonQuery()

    '            Update the member points in the UI
    '            lblPoints.Text = pointsEarned.ToString
    '        Else
    '            If Member Then 's points are already greater than zero, get the points from the Member table
    '                lblPoints.Text = currentPoints.ToString()
    '            End If
    '            Else
    '            Handle the case when member details are Not available
    '        lblPoints.Text = "N/A"
    '        End If

    '        CloseConnection()
    'End Sub

    Private Sub DisplayMemberPoints()
        OpenConnection()
        Dim memberCommand As New SqlCommand
        Dim memberSql As String = "SELECT Id, Points FROM Member WHERE Username = @Username"
        memberCommand = New SqlCommand(memberSql, conn)
        memberCommand.Parameters.Add("@Username", SqlDbType.NVarChar, 4000).Value = member_profile.strLoggedInMemberUsername

        ' Execute the query and retrieve member details
        Dim memberReader As SqlDataReader = memberCommand.ExecuteReader()

        If memberReader.Read() Then
            Dim memberId As String = memberReader("Id").ToString()
            Dim currentPoints As Integer = memberReader("Points").ToString()
            lblPoints.Text = currentPoints.ToString
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

                Dim pointsEarned As Integer = CInt(Math.Floor(totalPayment))

                ' Update Member table with the calculated points
                Dim updatePointsSql As String = "UPDATE Member SET Points = @Points WHERE Id = @MemberID"
                Dim updatePointsCommand As New SqlCommand(updatePointsSql, conn)
                updatePointsCommand.Parameters.AddWithValue("@Points", pointsEarned) ' Set pointsEarned directly
                updatePointsCommand.Parameters.AddWithValue("@MemberID", memberId)

                ' Execute the update query
                updatePointsCommand.ExecuteNonQuery()

                ' Update the member points in the UI
                lblPoints.Text = pointsEarned.ToString
            Else
                ' If member's points are already greater than zero, get the points from the Member table
                lblPoints.Text = currentPoints.ToString()
            End If
        Else
            ' Handle the case when member details are not available
            lblPoints.Text = "N/A"
        End If

        CloseConnection()
    End Sub

    Public Function GetUpdatedPointsFromDatabase() As Integer
        Dim updatedPoints As Integer = 0
        Try
            OpenConnection()
            Dim MySqlCommand As New SqlCommand
            Dim strSql As String = "SELECT Points FROM Member WHERE Username = @Username"

            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@Username", strGetId2)

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
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        member_profile.Show()
        Me.Close()
    End Sub

    Private Sub btnRedeem_Click(sender As Object, e As EventArgs) Handles btnRedeem.Click
        redeem_product.Show()
        Me.Close()
    End Sub
End Class