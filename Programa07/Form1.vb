Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valora, valorb, valorc, valorr, valors, valord As Double

        valora = TextBox1.Text
        valorb = TextBox2.Text
        valorc = TextBox3.Text
        valorr = (valora + valorb) * 2
        valors = (valorb + valorc) * valora
        valord = (valorr + valors) / 4
        TextBox4.Text = valorr
        TextBox5.Text = valors
        TextBox6.Text = valord

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
