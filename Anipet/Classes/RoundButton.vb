Imports System.Drawing.Drawing2D
Public Class RoundButton
    Inherits Button
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        
        Dim grPath As GraphicsPath = New GraphicsPath(FillMode.Winding)
        grPath.AddEllipse(2, 2, ClientSize.Width - 5, ClientSize.Height - 5)


        grPath.CloseFigure()
        Me.Region = New Region(grPath)

    End Sub
End Class