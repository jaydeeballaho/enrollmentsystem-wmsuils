Imports MySql.Data.MySqlClient
Public Class teacherClass


    Private Property _teacherClassId As Integer
    Public Property TeacherClassId As Integer
        Set(value As Integer)
            _teacherClassId = value
        End Set
        Get
            Return _teacherClassId
        End Get
    End Property

    Private Property _teacherId As Integer
    Public Property TeacherId As Integer
        Set(value As Integer)
            _teacherId = value
        End Set
        Get
            Return _teacherId
        End Get
    End Property

    Private Property _classId As Integer
    Public Property ClassId As Integer
        Set(value As Integer)
            _classId = value
        End Set
        Get
            Return _classId
        End Get
    End Property


    Public Function AddteacherClass() As Boolean
        Try
            Dim sql As String = "INSERT INTO teacherclass (classid,teacherid) VALUES (@0,@1);"
            IsConnected()
            ServerExecuteSQL(sql, ClassId, TeacherId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function EditTeacherClass() As Boolean
        Try
            Dim sql As String = "Update teacherclass set classid=@0,teacherid=@1 WHERE teacherclassid=@2;"
            IsConnected()
            ServerExecuteSQL(sql, ClassId, TeacherId, TeacherClassId)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function DeleteTeacherClass() As Boolean
        Try
            Dim sql As String = "DELETE FROM teacherclass WHERE teacherclassid=@0;"
            IsConnected()
            ServerExecuteSQL(sql, TeacherClassId)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub viewClassSched2(gv As DataGridView, sy As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM teacherclass as p1 inner join teacher as p2 on p1.teacherid = p2.teacherid inner join Class on p1.classid=class.classid INNER JOIN gradelevel ON class.lvlid=gradelevel.gradelevelid INNER JOIN " _
    & "section ON class.sectionid=section.sectionid INNER JOIN subject ON class.subjectid=subject.subjectid " _
    & "INNER join schoolyear on class.schoolyrid=schoolyear.schoolyearid INNER join room on class.roomid=room.roomid WHERE " _
    & "schoolyear.schoolyearid=" & sy & " and p1.teacherid = " & TeacherId & " ORDER BY gradelevelno,sectionno ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("teacherclassid"), reader("schoolyearno"), reader("gradelevelno"), reader("sectionno"), reader("subjectname"), reader("day"), reader("start"), reader("end"), reader("roomnumber"))
                End With
            End While
            reader.Close()
            gv.ClearSelection()
            '  addMenu(gv, cm)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addMenu(gv As DataGridView, cm As ContextMenuStrip)
        For Each row As DataGridViewRow In gv.Rows
            row.ContextMenuStrip = cm
        Next
    End Sub


End Class
