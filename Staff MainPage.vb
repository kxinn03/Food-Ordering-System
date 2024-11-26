Public Class Staff_MainPage

    Private Sub btnViewProfile_Click(sender As Object, e As EventArgs) Handles btnViewProfile.Click
        ' Retrieve the StaffID from Staff_Login
        Dim staffID As String = Staff_Login.EnteredStaffID
        ' Open Staff_Update form and set the selected ID
        Dim sv As New Staff_View()
        sv.strSelectedId = staffID
        sv.ShowDialog()
        Me.Hide() ' Hiding the form again (seems redundant)

    End Sub


    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        ' Retrieve the StaffID from Staff_Login
        Dim staffID As String = Staff_Login.EnteredStaffID
        ' Open Staff_Update form and set the selected ID
        Dim su As New Staff_Update()
        su.strSelectedId = staffID
        su.ShowDialog()
        Me.Hide() ' Hiding the form again (seems redundant)
    End Sub

    Private Sub picLogOut_Click_1(sender As Object, e As EventArgs) Handles picLogOut.Click
        ' Close the current form (acting as a logout action)
        Me.Close()
    End Sub

    Private Sub Staff_MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnManageMember_Click(sender As Object, e As EventArgs) Handles btnManageMember.Click
        manage2.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnManageRedeem_Click(sender As Object, e As EventArgs) Handles btnManageRedeem.Click
        manage_redeem.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PaymentReport.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        paymentMethod.Show()
    End Sub
End Class
