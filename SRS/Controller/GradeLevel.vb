Imports MySql.Data.MySqlClient

Public Class GradeLevel

    Private _gradelevelid As Integer
    Public Property GradeLevelID As Integer
        Set(value As Integer)
            _gradelevelid = value
        End Set
        Get
            Return _gradelevelid
        End Get
    End Property
    Private _gradelevelno As String
    Public Property GradeLevelNo As String
        Set(value As String)
            _gradelevelno = value
        End Set
        Get
            Return _gradelevelno
        End Get
    End Property
   
    Public Sub SetGradeLevelDetails(str As String)
        Try
            Dim sql As String
            sql = "SELECT * FROM gradelevel WHERE gradelevelno = '" & str & "';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    GradeLevelID = reader("gradelevelid")
                    GradeLevelNo = reader("gradelevelno")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetGradeLevelDetailsWID(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM gradelevel WHERE gradelevelid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    GradeLevelID = reader("gradelevelid")
                    GradeLevelNo = reader("gradelevelno")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddGradeLevel() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO gradelevel (gradelevelno) VALUES (@0);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GradeLevelNo)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditGradeLevel() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE gradelevel SET gradelevelno=@0 WHERE gradelevelid = @1;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GradeLevelNo, GradeLevelID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteGradeLevel() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM gradelevel WHERE gradelevelid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GradeLevelID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub LoadGradeLevelToCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT gradelevelno FROM gradelevel ORDER BY gradelevelno ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader("gradelevelno"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SearchGradeLevel(kw As String, gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT gradelevelno,gradelevelid FROM gradelevel WHERE gradelevelno LIKE '" & kw & "%' ORDER BY gradelevelno ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader("gradelevelid"), reader("gradelevelno"), "Edit", "Delete")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewGradeLevel(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT gradelevelno,gradelevelid FROM gradelevel ORDER BY gradelevelno ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader("gradelevelid"), reader("gradelevelno"), "Edit", "Delete")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
