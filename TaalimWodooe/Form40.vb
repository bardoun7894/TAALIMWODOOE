Public Class Form40

    Dim student As Student = New Student
    Dim play As PlayClass = New PlayClass
    Property name As String
    Property studentId As String

    Sub g()
        Label2.Text = "هيا يـ " & " " & "(" & name & ")" & " " & "لننطلق للعب "
    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox3.Visible = False

        g()
        Me.Text = "تعلم الوضوء"
        RadioButton1.AutoCheck = False

        RadioButton1.AutoCheck = True

        RadioButton3.Text = play.step1
        RadioButton2.Text = play.step8
        RadioButton1.Text = play.step4

    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = play.nu
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Checked = True Then
            play.nu += 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            play.nu += 1
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            MsgBox("... أحسنت يا بطل اضغط على التالي")
            PictureBox3.Visible = True
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim obj As Form41 = New Form41
        obj.name = name
        obj.studentId = studentId
        obj.nu = play.nu
        obj.Show()
        Me.Hide()
    End Sub
End Class
