Imports MySql.Data.MySqlClient

Public Class Defaults

    Private _status As String = "CLOSE"

    Public Property Status As String
        Set(value As String)
            _status = value
        End Set
        Get
            Return _status
        End Get
    End Property

    Private _principal As String
    Public Property Principal As String
        Set(value As String)
            _principal = value
        End Set
        Get
            Return _principal
        End Get
    End Property

    Public Sub GetEnrollmentStatus()
        Try
            Dim sql As String
            sql = "SELECT * FROM defaults;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Status = reader("enrollmentstatus")
                    Principal = reader("principalname")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function SetEnrollmentStatus() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE defaults SET enrollmentstatus = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, Status)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function SetPrincipalName() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "UPDATE defaults SET principalname = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, principal)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

  

End Class
