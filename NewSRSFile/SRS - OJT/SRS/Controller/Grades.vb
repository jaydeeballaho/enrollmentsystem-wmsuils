Imports MySql.Data.MySqlClient

Public Class Grades

    Private _gradeid As Integer
    Public Property GradeID As Integer
        Set(value As Integer)
            _gradeid = value
        End Set
        Get
            Return _gradeid
        End Get
    End Property

    Private _enrollmentid As Integer
    Public Property EnrollmentID As Integer
        Set(value As Integer)
            _enrollmentid = value
        End Set
        Get
            Return _enrollmentid
        End Get
    End Property
    Private _subjectid As Integer
    Public Property Subject As Integer
        Set(value As Integer)
            _subjectid = value
        End Set
        Get
            Return _subjectid
        End Get
    End Property
    Private _grade1 As String = ""
    Public Property Grade1 As String
        Set(value As String)
            _grade1 = value
        End Set
        Get
            Return _grade1
        End Get
    End Property
    Private _grade2 As String = ""
    Public Property Grade2 As String
        Set(value As String)
            _grade2 = value
        End Set
        Get
            Return _grade2
        End Get
    End Property
    Private _grade3 As String = ""
    Public Property Grade3 As String
        Set(value As String)
            _grade3 = value
        End Set
        Get
            Return _grade3
        End Get
    End Property
    Private _grade4 As String = ""
    Public Property Grade4 As String
        Set(value As String)
            _grade4 = value
        End Set
        Get
            Return _grade4
        End Get
    End Property
    Private _final As String = ""
    Public Property Final As String
        Set(value As String)
            _final = value
        End Set
        Get
            Return _final
        End Get
    End Property
    Private _remarks As String = ""
    Public Property Remarks As String
        Set(value As String)
            _remarks = value
        End Set
        Get
            Return _remarks
        End Get
    End Property

    Public Sub SetGradeID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        GradeID = CInt(cmd.ExecuteScalar())
    End Sub

    Public Sub SetGradeWID(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM grade WHERE gradeid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    GradeID = reader(0)
                    EnrollmentID = reader(1)
                    Subject = reader(2)
                    Grade1 = reader(3)
                    Grade2 = reader(4)
                    Grade3 = reader(5)
                    Grade4 = reader(6)
                    Final = reader(7)
                    Remarks = reader(8)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddGrade() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO grade (enrollmentid,subjectid,grade1,grade2,grade3,grade4,final,remarks) VALUES (@0,@1,@2,@3,@4,@5,@6,@7);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID, Subject, Grade1, Grade2, Grade3, Grade4, Final, Remarks)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditGrade() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE grade SET grade1=@0,grade2=@1,grade3=@2,grade4=@3,final=@4,remarks=@5 where enrollmentid =@6 and subjectid=@7;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, Grade1, Grade2, Grade3, Grade4, Final, Remarks, EnrollmentID, Subject)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        End Try
    End Function


    Public Function DeleteGrade() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE from grade where enrollmentid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function


    Public Sub ViewGrade(gv As DataGridView, i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM grade WHERE enrollmentid = '" & EnrollmentID & "' and subjectid='" & Subject & "';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    gv.Rows(i).Cells(7).Value = reader("grade1")
                    gv.Rows(i).Cells(8).Value = reader("grade2")
                    gv.Rows(i).Cells(9).Value = reader("grade3")
                    gv.Rows(i).Cells(10).Value = reader("grade4")
                    gv.Rows(i).Cells(11).Value = reader("final")
                    gv.Rows(i).Cells(12).Value = reader("remarks")
                End While
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ViewGrade(sy As String, gl As String, sec As String, g As String, gv As DataGridView)
        Try
            Dim sql As String
            sql = ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                End While
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
