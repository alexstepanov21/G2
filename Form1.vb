Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, x1, x2, d As Integer
        a = InputBox("a=")
        b = InputBox("b=")
        c = InputBox("c=")
        d = b ^ 2 - 4 * a * c
        MsgBox(d)
        If d > 0 Then
            x1 = (-b + d ^ 0.5) / 2 * a
            x2 = (-b - d ^ 0.5) / 2 * a
            MsgBox(x1)
            MsgBox(x2)
        ElseIf d = 0 Then
            x1 = -b / 2 * a
            MsgBox(x1)
        Else
            MsgBox("<0")
        End If
    End Sub
End Class
