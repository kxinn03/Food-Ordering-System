Public Class preparing
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmMenu.Show()
        Me.Close()
        payment2.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnPoints.Click
        points.Show()
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub preparing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "☺️ You got " & Form1.intPoint & " points for this order☺️"

    End Sub
End Class