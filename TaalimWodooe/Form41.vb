Public Class Form41
    Dim student As Student = New Student
    Dim play As PlayClass = New PlayClass
    Property name As String
    Property nu As Integer
    Property studentId As String
    Dim madmada As String = play.step2 + " و " + play.step3
    Dim mirfak As String = play.step5
    Dim wajh As String = play.step4
    Dim data As String = ""


    Sub g()
        Label1.Text = "هيا يـ " & " " & "(" & name & ")" & " " & "لننطلق للعبة الثانية  "
    End Sub
    Private Sub Form41_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioButton1.Text = madmada
        RadioButton2.Text = mirfak
        RadioButton3.Text = wajh


        g()
        Me.Text = "تعلم الوضوء"

    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ListBox1.Items.Add(RadioButton1.Text)
            data = data + RadioButton1.Text

        End If

    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ListBox1.Items.Add(RadioButton2.Text)

            data = data + RadioButton2.Text

        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            ListBox1.Items.Add(RadioButton3.Text)
            data = data + RadioButton3.Text
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If data = madmada + wajh + mirfak Then
            MsgBox("اجابة صحيحة")
            If play.checkId(studentId) = "" Then
                MsgBox("the data has added ")
                play.setData(nu, studentId, "اجابة صحيحة")


            End If


        Else
                MsgBox("حاول مرة اخرى")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        data = ""
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class