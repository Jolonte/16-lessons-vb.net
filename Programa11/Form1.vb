Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menino, menina As Integer

        menino = TextBox1.Text
        menina = TextBox2.Text

        Dim total, divi, pco, pca As Double

        total = menino + menina
        divi = 100 / total

        pco = divi * menino
        pca = divi * menina

        Label4.Text = (pco & "% da sala é composta por meninos.")
        Label6.Text = (pca & "% da sala é composta por meninas.")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label4.Text = (" ")
        Label6.Text = (" ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
