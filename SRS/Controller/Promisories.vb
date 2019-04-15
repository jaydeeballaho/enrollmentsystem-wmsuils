Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Promisories

    Private _promisedid As Integer
    Public Property PromisedID As Integer
        Set(value As Integer)
            _promisedid = value
        End Set
        Get
            Return _promisedid
        End Get
    End Property
    Private _studentid As Integer
    Public Property StudentID As Integer
        Set(value As Integer)
            _studentid = value
        End Set
        Get
            Return _studentid
        End Get
    End Property
    Private _promiseddate As Date
    Public Property PromisedDate As Date
        Set(value As Date)
            _promiseddate = value
        End Set
        Get
            Return _promiseddate
        End Get
    End Property
    Private _note As String = ""
    Public Property Note As String
        Set(value As String)
            _note = value
        End Set
        Get
            Return _note
        End Get
    End Property
    
    Public Function AddPromisory() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "INSERT INTO promisories (studentid,promiseddate,note) VALUES (@0,@1,@2);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, StudentID, PromisedDate, Note)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function EditPromisory() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE promisories SET promiseddate=@0,note=@1 where promisoriesid=@2;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, PromisedDate, Note, PromisedID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function DeletePromisory() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "DELETE FROM promisories WHERE promisoriesid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, PromisedID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub SetPromisoriesDetails(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM promisories WHERE promisoriesid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    PromisedID = reader(0)
                    StudentID = reader(1)
                    PromisedDate = reader(2)
                    Note = reader(3)
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewPromisories(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM promisories WHERE studentid " & StudentID & " ORDER BY promiseddate;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader(0), reader(2), reader(3), "EDIT", "DELETE")
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
