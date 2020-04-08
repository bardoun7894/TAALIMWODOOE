Public Class Form4
    Property name As String = ""

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = " تنال محبة الله عز وجل  بالطهارة  يا " & name & ""

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form9.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MainClass.Show()
        Me.Hide()
    End Sub

    Private Sub fadlBtn_Click(sender As Object, e As EventArgs) Handles fadlBtn.Click
        Form9.Show()
        Me.Hide()

    End Sub

    Private Sub sifatBtn_Click(sender As Object, e As EventArgs) Handles sifatBtn.Click
        Form10.Show()
        Me.Hide()

    End Sub
End Class