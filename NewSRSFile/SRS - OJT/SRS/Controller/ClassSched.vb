Imports MySql.Data.MySqlClient
Public Class ClassSched


    Private Property _id As Integer
    Public Property ID As Integer
        Set(value As Integer)
            _id = value
        End Set
        Get
            Return _id
        End Get
    End Property

    Private Property _lvlid As Integer
    Public Property LVLid As Integer
        Set(value As Integer)
            _lvlid = value
        End Set
        Get
            Return _lvlid
        End Get
    End Property

    Private Property _sectionid As Integer
    Public Property Sectionid As Integer
        Set(value As Integer)
            _sectionid = value
        End Set
        Get
            Return _sectionid
        End Get
    End Property

    Private Property _subjectid As Integer
    Public Property Subjectid As Integer
        Set(value As Integer)
            _subjectid = value
        End Set
        Get
            Return _subjectid
        End Get
    End Property

    Private Property _startTime As String
    Public Property StartTime As String
        Set(value As String)
            _startTime = value
        End Set
        Get
            Return _startTime
        End Get
    End Property

    Private Property _endTime As String
    Public Property EndTime As String
        Set(value As String)
            _endTime = value
        End Set
        Get
            Return _endTime
        End Get
    End Property

    Private Property _day As String
    Public Property Day As String
        Set(value As String)
            _day = value
        End Set
        Get
            Return _day
        End Get
    End Property

    Private Property _roomid As Integer
    Public Property Roomid As Integer
        Set(value As Integer)
            _roomid = value
        End Set
        Get
            Return _roomid
        End Get
    End Property

    Private Property _schoolyear As Integer
    Public Property SchoolYear As Integer
        Set(value As Integer)
            _schoolyear = value
        End Set
        Get
            Return _schoolyear
        End Get
    End Property

    Public Function AddClass() As Boolean
        Try
            Dim sql As String = "INSERT INTO class (lvlid,sectionid,subjectid,start,end,day,roomid,schoolyrid) VALUES (@0,@1,@2,@3,@4,@5,@6,@7);"
            IsConnected()
            ServerExecuteSQL(sql, LVLid, Sectionid, Subjectid, StartTime, EndTime, Day, Roomid, SchoolYear)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Function EditClass() As Boolean
        Try
            Dim sql As String = "UPDATE class set lvlid=@0,sectionid=@1,subjectid=@2,start=@3,end=@4,day=@5,roomid=@6 WHERE classid=@7;"
            IsConnected()
            ServerExecuteSQL(sql, LVLid, Sectionid, Subjectid, StartTime, EndTime, Day, Roomid, ID)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function DeleteClass() As Boolean
        Try
            Dim sql As String = "DELETE FROM class WHERE classid=@0;"
            IsConnected()
            ServerExecuteSQL(sql, ID)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function

    Public Sub viewClassSched(gv As DataGridView, cm As ContextMenuStrip)
        Try
            Dim sql As String
            sql = "SELECT * FROM Class INNER JOIN gradelevel ON class.lvlid=gradelevel.gradelevelid INNER JOIN " _
& "section ON class.sectionid=section.sectionid INNER JOIN subject ON class.subjectid=subject.subjectid " _
& "INNER join schoolyear on class.schoolyrid=schoolyear.schoolyearid INNER join room on class.roomid=room.roomid WHERE " _
& "schoolyear.schoolyearid=" & SchoolYear & "  ORDER BY gradelevelno,sectionno ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("classid"), reader("gradelevelno"), reader("sectionno"), reader("subjectname"), reader("day"), reader("start"), reader("end"), reader("roomnumber"))
                End With
            End While
            reader.Close()
            addMenu(gv, cm)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub viewClass(gv As DataGridView)
        Try

            Dim i As Integer = 0
            Dim sql As String
            sql = "SELECT * FROM Class INNER JOIN gradelevel ON class.lvlid=gradelevel.gradelevelid INNER JOIN " _
& "section ON class.sectionid=section.sectionid INNER JOIN subject ON class.subjectid=subject.subjectid " _
& "INNER join schoolyear on class.schoolyrid=schoolyear.schoolyearid INNER join room on class.roomid=room.roomid WHERE " _
& "schoolyear.schoolyearid=" & SchoolYear & "  ORDER BY gradelevelno,sectionno ASC;"

            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()

                With gv
                    .Rows.Add(reader("classid"), reader("gradelevelno"), reader("sectionno"), reader("subjectname"), reader("day"), reader("start"), reader("end"), reader("roomnumber"))
                End With
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub setClassDetails(i As Integer)
        Try

            Dim sql As String
            sql = "SELECT * FROM class WHERE classid = " & i & ";"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ID = reader("classid")
                LVLid = reader("lvlid")
                Sectionid = reader("sectionid")
                Subjectid = reader("subjectid")
                StartTime = reader("start")
                EndTime = reader("end")
                Day = reader("day")
                Roomid = reader("roomid")
                SchoolYear = reader("schoolyrid")
            End While
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub addMenu(gv As DataGridView, cm As ContextMenuStrip)
        For Each row As DataGridViewRow In gv.Rows
            row.ContextMenuStrip = cm
        Next
    End Sub
    Public Sub viewClassSched2(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM Class INNER JOIN gradelevel ON class.lvlid=gradelevel.gradelevelid INNER JOIN " _
& "section ON class.sectionid=section.sectionid INNER JOIN subject ON class.subjectid=subject.subjectid " _
& "INNER join schoolyear on class.schoolyrid=schoolyear.schoolyearid INNER join room on class.roomid=room.roomid WHERE " _
& "schoolyear.schoolyearid=" & SchoolYear & " and not exists(select * from teacherclass where class.classid = teacherclass.classid) ORDER BY gradelevelno,sectionno ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("classid"), reader("schoolyearno"), reader("gradelevelno"), reader("sectionno"), reader("subjectname"), reader("day"), reader("start"), reader("end"), reader("roomnumber"))
                End With
            End While
            reader.Close()
            gv.ClearSelection()
            '  addMenu(gv, cm)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ViewClassesForAdvising(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM Class INNER JOIN gradelevel ON class.lvlid=gradelevel.gradelevelid INNER JOIN " _
& "section ON class.sectionid=section.sectionid INNER JOIN subject ON class.subjectid=subject.subjectid " _
& "INNER join schoolyear on class.schoolyrid=schoolyear.schoolyearid INNER join room on class.roomid=room.roomid WHERE " _
& "schoolyear.schoolyearid=" & SchoolYear & " and gradelevel.gradelevelid = " & LVLid & " and section.sectionid = " & Sectionid & " ORDER BY subjectname ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("classid"), reader("subjectname"), reader("day"), reader("start"), reader("end"), reader("roomnumber"))
                End With
            End While
            reader.Close()
            gv.ClearSelection()
            '  addMenu(gv, cm)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub viewClassInPrint(gv As DataGridView)
        Try

            Dim i As Integer = 0
            Dim sql As String
            sql = "SELECT * FROM Class INNER JOIN gradelevel ON class.lvlid=gradelevel.gradelevelid INNER JOIN " _
& "section ON class.sectionid=section.sectionid INNER JOIN subject ON class.subjectid=subject.subjectid " _
& "INNER join schoolyear on class.schoolyrid=schoolyear.schoolyearid INNER join room on class.roomid=room.roomid WHERE " _
& "schoolyear.schoolyearid=" & SchoolYear & " and gradelevel.gradelevelid = " & LVLid & " and section.sectionid = " & Sectionid & " ORDER BY subjectname ASC;"

            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()

                With gv
                    .Rows.Add(reader("classid"), reader("subjectname"), reader("start"), reader("end"), reader("day"), reader("roomnumber"))
                End With
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class


