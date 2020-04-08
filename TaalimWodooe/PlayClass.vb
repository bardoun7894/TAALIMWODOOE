Imports System.Data.OleDb

Public Class PlayClass : Inherits WodoeSteps
    Public id As Integer
    Public nu As Integer
    Public answer1 As String
    Public StudentID As String
    Public answer2 As String

    Dim co As Connection = New Connection
    Public cmd As OleDbCommand

    Public Function checkId(ByVal myId As String)
        Try
            If co.conn.State = ConnectionState.Closed Then co.conn.Open()
            Dim s = ""
            cmd = New OleDbCommand("select answer2 from Play where studentID ='" & myId & "' ", co.conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim ds As New Data.DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 1 Then
                s = ds.Tables(0).Rows(0)("answer2")
            End If
            co.conn.Close()
            Return s
        Catch ex As Exception
            If co.conn.State = ConnectionState.Closed Then co.conn.Open()
            MsgBox(ex.ToString)

        End Try

    End Function
    Public Function setData(ByVal nu As Integer, ByVal studentID As String, ByVal answer2 As String)
        Try
            If co.conn.State = ConnectionState.Closed Then co.conn.Open()

            cmd = New OleDbCommand("insert into Play (nu,studentID,answer2) values (@nu,@studentID,@answer) ", co.conn)
            cmd.Parameters.Add(New OleDbParameter("@nu", OleDbType.Integer)).Value = nu
            cmd.Parameters.Add(New OleDbParameter("@studentId", OleDbType.VarChar)).Value = studentID
            cmd.Parameters.Add(New OleDbParameter("@answer2", OleDbType.VarChar)).Value = answer2

            cmd.ExecuteNonQuery()
            MsgBox("تمت الاضافة بنجاح")
            co.conn.Close()

        Catch ex As Exception
            If co.conn.State = ConnectionState.Closed Then co.conn.Open()
            MsgBox(ex.ToString)

        End Try

    End Function


End Class
