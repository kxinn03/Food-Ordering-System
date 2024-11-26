Imports System.Drawing.Drawing2D
Public Class RoundButton
    Inherits Button
    Protected Overrides Sub onPaint(prevent As PaintEventArgs)
        Dim g As GraphicsPath = New GraphicsPath()
        g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(g)
        MyBase.OnPaint(prevent)
    End Sub
End Class
