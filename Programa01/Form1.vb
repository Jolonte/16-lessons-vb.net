Public Class Soma_de_Inteiros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1, valor2 As Integer

        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        TextBox4.Text = valor1 + valor2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

End Class