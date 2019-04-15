Imports MySql.Data.MySqlClient

Public Class Subject

    Private _subjectid As Integer
    Public Property SubjectID As Integer
        Set(value As Integer)
            _subjectid = value
        End Set
        Get
            Return _subjectid
        End Get
    End Property
    Private _gradelevelid As Integer
    Public Property GradelevelID As Integer
        Set(value As Integer)
            _gradelevelid = value
        End Set
        Get
            Return _gradelevelid
        End Get
    End Property
    Private _subjectname As String
    Public Property SubjectName As String
        Set(value As String)
            _subjectname = value
        End Set
        Get
            Return _subjectname
        End Get
    End Property
    Private _subjecttime As Integer
    Public Property SubjectTime As Integer
        Set(value As Integer)
            _subjecttime = value
        End Set
        Get
            Return _subjecttime
        End Get
    End Property

    Public Sub SetSubjectDetails(str As String)
        Try
            Dim sql As String
            sql = "SELECT * FROM subject WHERE subjectname = '" & str & "' and gradelevelid = " & GradelevelID & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SubjectID = reader(0)
                    GradelevelID = reader(1)
                    SubjectName = reader(2)
                    SubjectTime = reader(3)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetSubjectDetailsWID(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM subject WHERE subjectid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SubjectID = reader(0)
                    GradelevelID = reader(1)
                    SubjectName = reader(2)
                    SubjectTime = reader(3)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddSubject() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO subject (gradelevelid,subjectname,subjecttime) VALUES (@0,@1,@2);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GradelevelID, SubjectName, SubjectTime)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditSubject() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE subject SET subjectname=@0,subjecttime=@1 WHERE subjectid = @2;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, SubjectName, SubjectTime, SubjectID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteSubject() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM subject WHERE subjectid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, SubjectID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub LoadSubjectToCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT * FROM subject where gradelevelid = " & GradelevelID & " ORDER BY subjectname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader("subjectname"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SetSubjectID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        SubjectID = CInt(cmd.ExecuteScalar())
    End Sub

    Public Function IsSubjectExist(str As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT subjectname FROM subject where gradelevelid = " & GradelevelID & " and subjectname = '" & str & "' LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows() Then
                    bool = True
                Else
                    bool = False
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Sub ViewSubject(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM subject as s inner join gradelevel as g ON s.gradelevelid = g.gradelevelid where s.gradelevelid = " & GradelevelID & " ORDER BY subjectname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader("subjectid"), reader("subjectname"), reader("gradelevelno"), reader("subjecttime").ToString & " Min.", _
                                  "Edit", "Delete")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SearchSubject(kw As String, gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM subject as s inner join gradelevel as g ON s.gradelevelid = g.gradelevelid where s.gradelevelid = " & GradelevelID & " and subjectname LIKE '" & kw & "%' ORDER BY subjectname ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader("subjectid"), reader("subjectname"), reader("gradelevelno"), reader("subjecttime") & " Min.", _
                                   "Edit", "Delete")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
