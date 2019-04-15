Imports MySql.Data.MySqlClient

Public Class SchoolYear

    Private _schoolyearid As Integer
    Public Property SchoolYearID As Integer
        Set(value As Integer)
            _schoolyearid = value
        End Set
        Get
            Return _schoolyearid
        End Get
    End Property
    Private _schoolyearint As Integer
    Public Property SchoolYearInt As Integer
        Set(value As Integer)
            _schoolyearint = value
        End Set
        Get
            Return _schoolyearint
        End Get
    End Property
    Private _schoolyearno As String
    Public Property SchoolYearNo As String
        Set(value As String)
            _schoolyearno = value
        End Set
        Get
            Return _schoolyearno
        End Get
    End Property
    Private _status As String
    Public Property Status As String
        Set(value As String)
            _status = value
        End Set
        Get
            Return _status
        End Get
    End Property
    Private _flag As Integer = 0
    Public Property Flag As Integer
        Set(value As Integer)
            _flag = value
        End Set
        Get
            Return _flag
        End Get
    End Property

    Public Sub SetSchoolYearDetails(str As String)
        Try
            Dim sql As String
            sql = "SELECT * FROM schoolyear WHERE schoolyearno = '" & str & "';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SchoolYearID = reader("schoolyearid")
                    SchoolYearInt = reader("schoolyearint")
                    SchoolYearNo = reader("schoolyearno")
                    Status = reader("status")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SetSchoolYearID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        SchoolYearID = CInt(cmd.ExecuteScalar())
    End Sub
    Public Sub SetSchoolYearDetailsWID(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM schoolyear WHERE schoolyearid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SchoolYearID = reader("schoolyearid")
                    SchoolYearInt = reader("schoolyearint")
                    SchoolYearNo = reader("schoolyearno")
                    Status = reader("status")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddSchoolYear() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO schoolyear (schoolyearint,schoolyearno,status,flag) VALUES (@0,@1,@2,@3);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, SchoolYearInt, SchoolYearNo, Status, Flag)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditSchoolYear() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE schoolyear SET schoolyearint=@0,schoolyearno=@1,status=@2 WHERE schoolyearid = @3;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, SchoolYearInt, SchoolYearNo, Status, SchoolYearID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteSchoolYear() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM schoolyear WHERE schoolyearid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, SchoolYearID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function OpenSchoolYear(id As Integer) As Boolean
        Try
            Dim sy As New SchoolYear
            sy.GetActiveSchoolYear()
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE schoolyear SET flag=0 WHERE schoolyearid <> " & sy.SchoolYearID & ";" _
                                & "UPDATE schoolyear SET flag=1 WHERE schoolyearid = " & sy.SchoolYearID & ";" _
                                & "UPDATE schoolyear SET status='CLOSE' WHERE schoolyearid <> " & id & ";" _
                                & "UPDATE schoolyear SET status='OPEN' WHERE schoolyearid = " & id & ";"
            If IsConnected() = True Then
                ServerExecuteSQL(sql)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub GetPreviousSchoolYear()
        Try
            Dim sql As String
            sql = "SELECT * FROM schoolyear WHERE flag = 1 LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SchoolYearID = reader("schoolyearid")
                    SchoolYearInt = reader("schoolyearint")
                    SchoolYearNo = reader("schoolyearno")
                    Status = reader("status")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub GetActiveSchoolYear()
        Try
            Dim sql As String
            sql = "SELECT * FROM schoolyear WHERE status = 'OPEN' LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SchoolYearID = reader("schoolyearid")
                    SchoolYearInt = reader("schoolyearint")
                    SchoolYearNo = reader("schoolyearno")
                    Status = reader("status")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadSchoolYearToCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT schoolyearno FROM schoolyear ORDER BY schoolyearno DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader("schoolyearno"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadPreviousSchoolYearToCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT schoolyearno FROM schoolyear WHERE status = 'CLOSE' ORDER BY schoolyearno DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader("schoolyearno"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SearchSchoolYear(kw As String, gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM schoolyear WHERE schoolyearno LIKE '" & kw & "%' and status = 'CLOSE' ORDER BY schoolyearno DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        If reader("status") = "OPEN" Then
                            .Rows.Add(reader("schoolyearid"), reader("schoolyearno"), reader("status"), "", "", "")
                        Else
                            .Rows.Add(reader("schoolyearid"), reader("schoolyearno"), reader("status"), "Open", "Edit", "Delete")
                        End If
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewSchoolYear(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM schoolyear WHERE status = 'CLOSE' ORDER BY schoolyearno DESC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        If reader("status") = "OPEN" Then
                            .Rows.Add(reader("schoolyearid"), reader("schoolyearno"), reader("status"), "", "", "")
                        Else
                            .Rows.Add(reader("schoolyearid"), reader("schoolyearno"), reader("status"), "Open", "Edit", "Delete")
                        End If
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub GetActiveSY()
        Throw New NotImplementedException
    End Sub

End Class
