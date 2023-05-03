Public Class Form1
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim sisi, luas, keliling As Integer

        sisi = Val(txtsisi.Text)

        luas = sisi * sisi
        keliling = 4 * sisi

        txtluas.Text = Str(luas)
        txtkeliling.Text = Str(keliling)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
