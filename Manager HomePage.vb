
Public Class Manager_HomePage

    Private Sub btnViewStaff_Click(sender As Object, e As EventArgs) Handles btnViewStaff.Click
        Me.Hide()
        Dim sfl As New staffFormList()
        sfl.ShowDialog()
        sfl.Dispose() ' Properly dispose the form instance after use
        Me.Show()
    End Sub

    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        Me.Hide()
        Dim su As New mStaffSearch_Update()
        su.ShowDialog()
        su.Dispose() ' Properly dispose the form instance after use
        Me.Show()
    End Sub

    Private Sub btnStaffReport_Click(sender As Object, e As EventArgs) Handles btnStaffReport.Click
        Me.Hide()
        Dim sr As New Staff_Report()
        sr.ShowDialog()
        sr.Dispose() ' Properly dispose the form instance after use
        Me.Show()
    End Sub

    Private Sub picLogOut_Click_1(sender As Object, e As EventArgs) Handles picLogOut.Click
        Me.Hide()
        Me.Close()
        Me.Dispose()
    End Sub

End Class