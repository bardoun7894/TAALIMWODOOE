Public Class Form1


    Dim student As Student = New Student
    Property myName As String = ""
    Public Property myId As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub fadlBtn_Click(sender As Object, e As EventArgs) Handles fadlBtn.Click
        If TextBox1.Text = "" Then
            MsgBox("المرجو ادخال الID")
        Else
            Dim obj As Form12 = New Form12
            obj.name = myName
            obj.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub hokmBtn_Click(sender As Object, e As EventArgs) Handles hokmBtn.Click
        If TextBox1.Text = "" Then
            MsgBox("المرجو ادخال الID")
        Else
            Dim obj As Form4 = New Form4
            obj.name = myName
            obj.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub sifatBtn_Click(sender As Object, e As EventArgs) Handles sifatBtn.Click

        If TextBox1.Text = "" Then
            MsgBox("المرجو ادخال الID")
        Else
            Form2.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles playBtn.Click

        If TextBox1.Text = "" Then
            MsgBox("المرجو ادخال الID")
        Else
            Dim obj As Form40 = New Form40
            obj.name = myName
            obj.studentId = myId
            obj.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        myId = TextBox1.Text
        myName = student.getStudentName(myId)
        If myName = "" Then
            MsgBox(" لا يوجد هذا الطالب")
        Else
            MsgBox("مرحبا بك " & myName & " ")


        End If

    End Sub
End Class
