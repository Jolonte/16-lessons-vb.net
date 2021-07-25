Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nome As String

        nome = TextBox1.Text
        TextBox2.Text = nome

        Dim salario As Double

        salario = TextBox3.Text
        TextBox6.Text = salario

        Dim vendas, comissao, comissao2, mes As Double

        vendas = TextBox4.Text

        comissao = vendas / 100
        comissao2 = comissao * 20

        mes = salario + comissao2

        TextBox8.Text = mes

    End Sub
End Class
