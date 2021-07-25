Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vle, pcl, tj, pagar As Double

        vle = TextBox1.Text
        pcl = TextBox2.Text
        tj = TextBox3.Text

        pagar = vle / pcl

        Dim pct, pctII, total As Double

        pct = tj / 100
        pctII = pct * pagar
        total = pctII + pagar

        Label4.Text = ("Empréstimo solicitado de: R$" & vle & " com juros de: " & tj & "%")
        Label6.Text = ("Parcelas: R$" & pagar)
        Label8.Text = ("Parcelas + juros: R$" & total)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label4.Text = (" ")
        Label6.Text = (" ")
        Label8.Text = (" ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
