Imports System.Runtime.InteropServices
Public Class RoundCorner
    Inherits Label

    Public Sub New()
        Me.SetStyle(ControlStyles.UserPaint, True)
    End Sub
    Protected Overrides Sub onPaint(prevent As PaintEventArgs)
        MyBase.OnPaint(prevent)
        Dim lbl1 As Label = New Label()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 2, 188, 280, 12, 12))
    End Sub

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal iLeft As Integer, ByVal iTop As Integer, ByVal iRight As Integer, ByVal iBottom As Integer, ByVal iWidth As Integer, ByVal iHeight As Integer) As IntPtr
    End Function
End Class
