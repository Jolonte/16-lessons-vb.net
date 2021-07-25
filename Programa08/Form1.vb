Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nota1, nota2, nota3, media1, aluno1 As Double
        nota1 = TextBox1.Text
        nota2 = TextBox2.Text
        nota3 = TextBox3.Text
        media1 = nota1 + nota2 + nota3
        aluno1 = media1 / 3
        TextBox4.Text = aluno1

        Dim nota4, nota5, nota6, media2, aluno2 As Double
        nota4 = TextBox8.Text
        nota5 = TextBox7.Text
        nota6 = TextBox6.Text
        media2 = nota4 + nota5 + nota6
        aluno2 = media2 / 3
        TextBox5.Text = aluno2

        Dim nota7, nota8, nota9, media3, aluno3 As Double
        nota7 = TextBox12.Text
        nota8 = TextBox11.Text
        nota9 = TextBox10.Text
        media3 = nota7 + nota8 + nota9
        aluno3 = media1 / 3
        TextBox9.Text = aluno3

        Dim nota10, nota11, nota12, media4, aluno4 As Double
        nota10 = TextBox20.Text
        nota11 = TextBox19.Text
        nota12 = TextBox18.Text
        media4 = nota10 + nota11 + nota12
        aluno4 = media4 / 3
        TextBox17.Text = aluno4

        Dim nota13, nota14, nota15, media5, aluno5 As Double
        nota13 = TextBox16.Text
        nota14 = TextBox15.Text
        nota15 = TextBox14.Text
        media5 = nota13 + nota14 + nota15
        aluno5 = media5 / 3
        TextBox13.Text = aluno5

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

End Class
