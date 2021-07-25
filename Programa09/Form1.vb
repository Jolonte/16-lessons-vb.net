Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nmr As Double
        nmr = TextBox1.Text()

        Label33.Text = (nmr & " x 1 = " & nmr * 1)
        Label32.Text = (nmr & " x 2 = " & nmr * 2)
        Label31.Text = (nmr & " x 3 = " & nmr * 3)
        Label30.Text = (nmr & " x 4 = " & nmr * 4)
        Label29.Text = (nmr & " x 5 = " & nmr * 5)
        Label28.Text = (nmr & " x 6 = " & nmr * 6)
        Label27.Text = (nmr & " x 7 = " & nmr * 7)
        Label26.Text = (nmr & " x 8 = " & nmr * 8)
        Label25.Text = (nmr & " x 9 = " & nmr * 9)
        Label24.Text = (nmr & " x 10 = " & nmr * 10)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Label33.Text = (" ")
        Label32.Text = (" ")
        Label31.Text = (" ")
        Label30.Text = (" ")
        Label29.Text = (" ")
        Label28.Text = (" ")
        Label27.Text = (" ")
        Label26.Text = (" ")
        Label25.Text = (" ")
        Label24.Text = (" ")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
