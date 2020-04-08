Imports System.Windows.Forms

Public Class Form12
    Dim ch1, ch2, ch3, ch4 As String
    Property name As String
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = " تنال محبة الله عز وجل  بالطهارة  يا " & name & ""
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ch1 = "إِنَّ اللَّهَ يُحِبُّ التَّوَّابِينَ وَيُحِبُّ الْمُتَطَهِّرِينَ"
        If CheckBox1.Checked Then
            ListBox1.Items.Add(ch1)
        Else
            ListBox1.Items.Remove(ch1)
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ch2 = "عن عثمانَ بن عفانَ  قَالَ: قَالَ رسولُ اللَّهِ ﷺ "
        ch3 = " منْ تَوَضَّأَ فَأَحْسَنَ الوضوءَ، خَرَجَت خَطَايَاهُ"
        ch4 = "مِنْ جسَدِهِ حتَّى تَخْرُجَ مِنْ تحتِ أَظفارِهِ رواه مسلم"
        If CheckBox2.Checked Then
            ListBox1.Items.Add(ch2)
            ListBox1.Items.Add(ch3)
            ListBox1.Items.Add(ch4)
        Else
            ListBox1.Items.Remove(ch2)
            ListBox1.Items.Remove(ch3)
            ListBox1.Items.Remove(ch4)

        End If

    End Sub
End Class