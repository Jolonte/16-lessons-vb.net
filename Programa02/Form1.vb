Public Class Calculadora
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1, valor2, valor3, divisao, divisao2 As Double

        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        valor3 = TextBox3.Text
        divisao = valor1 + valor2 + valor3
        divisao2 = divisao / 2
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
