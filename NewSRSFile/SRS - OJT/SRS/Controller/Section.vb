Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls

Public Class Section

    Private _sectionid As Integer
    Public Property SectionID As Integer
        Set(value As Integer)
            _sectionid = value
        End Set
        Get
            Return _sectionid
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
    Private _sectionno As String
    Public Property SectionNo As String
        Set(value As String)
            _sectionno = value
        End Set
        Get
            Return _sectionno
        End Get
    End Property

    Public Sub SetSectionDetails(str As String)
        Try
            Dim sql As String
            sql = "SELECT * FROM section WHERE sectionno = '" & str & "' and gradelevelid = " & GradelevelID & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SectionID = reader(0)
                    GradelevelID = reader(1)
                    SectionNo = reader(2)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub SetSectionDetailsWID(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM section WHERE sectionid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    SectionID = reader(0)
                    GradelevelID = reader(1)
                    SectionNo = reader(2)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function AddSection() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO section (gradelevelid,sectionno) VALUES (@0,@1);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GradelevelID, SectionNo)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function EditSection() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE section SET sectionno=@0 WHERE sectionid = @1;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, SectionNo, SectionID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteSection() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "DELETE FROM section WHERE sectionid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, SectionID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub LoadSectionToCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT sectionno FROM section where gradelevelid = " & GradelevelID & " ORDER BY sectionno ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader("sectionno"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub LoadSectionToCBO2(cbo As MetroComboBox)
        Try
            Dim sql As String
            sql = "SELECT DISTINCT sectionno FROM section where gradelevelid = " & GradelevelID & " ORDER BY sectionno ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                cbo.Items.Clear()
                While reader.Read()
                    cbo.Items.Add(reader("sectionno"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function IsSectionExist(str As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT sectionno FROM section where gradelevelid = " & GradelevelID & " and sectionno = '" & str & "';"
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

    Public Sub ViewSection(gv As DataGridView, cm As ContextMenuStrip)
        Try
            Dim sql As String
            sql = "SELECT * FROM section where gradelevelid = " & GradelevelID & " ORDER BY sectionno ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader(0), reader(2))
                    End With
                End While
                reader.Close()
                AddMenu(gv, cm)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
