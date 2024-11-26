Public Class MainPage
    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        member_login.Show()

        Me.Hide()

    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Staff_Login.Show()
    End Sub


End Class