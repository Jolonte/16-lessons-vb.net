Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim preco, parcelas, divi As Double

        preco = TextBox1.Text
        parcelas = TextBox2.Text

        If (parcelas > 5) Then
            TextBox3.Text = ("promoção de só 5x!")
        Else
            divi = preco / parcelas
            TextBox3.Text = ("R$" & preco & " " & "Parcelado em" & " " & parcelas & "x" & " " & "da:" & " " & divi & " " & "por mês.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
