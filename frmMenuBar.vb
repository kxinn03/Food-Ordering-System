Public Class frmMenuBar
    Private Sub frmMenuBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rBtnHome.Image = My.Resources.homeIcon.GetThumbnailImage(46, 46, Nothing, IntPtr.Zero)
        rBtnMenu.Image = My.Resources.menuIcon.GetThumbnailImage(46, 46, Nothing, IntPtr.Zero)
        rBtnOrder.Image = My.Resources.orderIcon.GetThumbnailImage(44, 43, Nothing, IntPtr.Zero)
        rBtnProfile.Image = My.Resources.profileIcon.GetThumbnailImage(56, 56, Nothing, IntPtr.Zero)
    End Sub

End Class