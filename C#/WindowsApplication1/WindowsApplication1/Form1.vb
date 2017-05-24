Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim abc As String = StrConv(TextBox1.Text, VbStrConv.Katakana, LocaleID:=1)
        TextBox2.Text = abc
    End Sub
End Class
