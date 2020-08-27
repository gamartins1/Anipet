Imports System.Drawing.Drawing2D
Public Class RoundedButton
    Inherits Button
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim grPath As GraphicsPath = New GraphicsPath(FillMode.Winding)
        grPath.AddArc(0, 0, ClientSize.Height, ClientSize.Height, 90, 180)
        grPath.AddLine(grPath.GetLastPoint, New Point(ClientSize.Width - grPath.GetLastPoint.X * 2, 0))
        grPath.AddArc(New RectangleF(grPath.GetLastPoint, New Size(ClientSize.Height, ClientSize.Height)), 270, 180)
        grPath.CloseFigure()

        Me.Region = New Region(grPath)

        Dim mypen As New Pen(Color.White, 2)
        mypen.Alignment = PenAlignment.Inset
        e.Graphics.DrawPath(mypen, grPath)
    End Sub
End Class