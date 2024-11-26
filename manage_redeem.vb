
Public Class manage_redeem
    Public Class RedeemDisplay
        Public Property ProductId As String
        Public Property Name As String

        Public Property Details As String
        Public Property Points As Integer
        Public Property Quantity As Integer
        Public Property Availability As String

    End Class
    Public Sub BindData()
        Dim strName As String = txtName.Text
        Dim db As New DBDataContext()
        Dim redeemData = From redeem In db.Redeems
                         Where redeem.Name.Contains(strName)
                         Select New RedeemDisplay With {
                                  .ProductId = redeem.ProductId,
                                  .Name = redeem.Name,
                                   .Details = redeem.Details,
                                  .Points = redeem.Points,
                                  .Quantity = redeem.Quantity,
                                  .Availability = redeem.Availability
                              }

        ' Set the DataGridView DataSource
        dgvRedeem.DataSource = redeemData
    End Sub
    Private Sub manage_redeem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        BindData()
    End Sub

    Private Sub dgvRedeem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRedeem.CellDoubleClick
        Dim intNo As Integer = e.RowIndex
        If intNo > -1 Then
            Dim strProductId As String = CStr(dgvRedeem.Rows(intNo).Cells(0).Value)
            FrmProductAction.strSelectedProductId = strProductId
            FrmProductAction.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        FrmAddRedeem.ShowDialog()
        BindData()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        BindData()
    End Sub
End Class