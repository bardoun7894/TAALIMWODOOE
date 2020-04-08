Public Class Form9
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.SelectedIndex = 0 Then
            PictureBox2.Image = TaalimWodooe.My.Resources.salat

        End If
        If ListBox1.SelectedIndex = 1 Then
            PictureBox2.Image = TaalimWodooe.My.Resources.tawaf

        End If
        If ListBox1.SelectedIndex = 2 Then
            PictureBox2.Image = TaalimWodooe.My.Resources.qoran

        End If



    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class