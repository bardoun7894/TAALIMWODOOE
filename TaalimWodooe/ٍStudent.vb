Imports System.Data.OleDb

Public Class Student

    Public id As Integer
    Public name As String = ""
    Public age As Integer
    Public studentID As String

    Dim co As Connection = New Connection
    Public cmd As OleDbCommand


    Public Function getStudentName(ByVal myId As String)
        Try
            If co.conn.State = ConnectionState.Closed Then co.conn.Open()
            Dim s = ""
            cmd = New OleDbCommand("select name from Student where studentID ='" & myId & "' ", co.conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim ds As New Data.DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 1 Then
                s = ds.Tables(0).Rows(0)("name")
            End If
            co.conn.Close()
            Return s
        Catch ex As Exception
            If co.conn.State = ConnectionState.Closed Then co.conn.Open()
            MsgBox(ex.ToString)

        End Try

    End Function


End Class
