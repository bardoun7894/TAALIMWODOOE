Public Class Form30

    Dim a As WodoeSteps = New WodoeSteps

    Private Sub Form30_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Text = "أولا :" + a.step1
        CheckBox2.Text = "ثانيا :" + a.step2
        CheckBox3.Text = "ثالثا :" + a.step3
        CheckBox4.Text = "رابعا :" + a.step4
        CheckBox5.Text = "خامسا :" + a.step5
        CheckBox6.Text = "سادسا :" + a.step6
        CheckBox7.Text = "سابعا :" + a.step7
        CheckBox8.Text = "ثامنا :" + a.step8
        CheckBox9.Text = "" + a.step9


        Timer1.Start()
        Me.Text = "تعلم الوضوء"
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("تقول بسم الله و اغسل كفيك ثلاث مرات")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("تمضمض ثلاث مرات عن طريق وضع الماء في فمك ثم إخراجة")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("استنشق ثلاث مرات عن طريق جذب الماء إلى الأنف عن طريق النفس ثم اخرجه")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("اغسل وجهك كاملاً ثلاث مرات ")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("اغسل يديك إلى المرافق وهو الكوع ثلاث مرات باليمين أولاُ   ")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("امسح رأسك مرة واحدة مبدئاً من الأمام للخلف ثم عد للاماء")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("امسح اذنيك ببقايا الماء الذي مسحت به رأسك")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("اغسل رجليك إلى الكعبين ثلاث مرات مع تخليل المياه بين الأصابع")
        End If
        ProgressBar1.Value += 10
    End Sub
    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            MsgBox("أَشْهدُ أَنْ لا إِله إِلاَّ اللَّه وحْدَه لا شَريكَ لهُ، وأَشْهدُ أَنَّ مُحمَّدًا عبْدُهُ وَرسُولُه اللَّهُمَّ اجْعلْني من التَّوَّابِينَ واجْعلْني مِنَ المُتَطَهِّرِينَ")
        End If
        ProgressBar1.Value += 20
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Label4.Text = "مكتمل"
        End If
        Label3.Text = ProgressBar1.Value & ("%")
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
