Public Class Calculadora
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota1, nota2, nota3, divisao, divisao2 As Double

        nota1 = TextBox1.Text
        nota2 = TextBox2.Text
        nota3 = TextBox3.Text
        divisao = nota1 + nota2 + nota3
        divisao2 = divisao / 3
        TextBox4.Text = divisao2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
