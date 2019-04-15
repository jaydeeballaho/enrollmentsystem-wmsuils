'Author: Jaydee C. Ballaho
'Date: 5/1/2016

Imports MetroFramework.Controls
Imports MySql.Data.MySqlClient

Public Class User

#Region "Declaration"
    Private _UserID As Integer
    Private _FirstName As String
    Private _LastName As String
    Private _Username As String
    Private _Password As String
    Private _UserType As String
    Private _UserStatus As String = "Active"
    Private _LoginStatus As Integer = 0
    Private _FirstTime As Integer = 1
#End Region
#Region "Setter/Getter"
    Public Property UserID As Integer
        Set(value As Integer)
            _UserID = value
        End Set
        Get
            Return _UserID
        End Get
    End Property
    Public Property FirstName As String
        Set(value As String)
            _FirstName = value
        End Set
        Get
            Return _FirstName
        End Get
    End Property
    Public Property LastName As String
        Set(value As String)
            _LastName = value
        End Set
        Get
            Return _LastName
        End Get
    End Property
    Public Property Username As String
        Set(value As String)
            _Username = value
        End Set
        Get
            Return _Username
        End Get
    End Property
    Public Property Password As String
        Set(value As String)
            _Password = value
        End Set
        Get
            Return _Password
        End Get
    End Property
    Public Property Usertype As String
        Set(value As String)
            _UserType = value
        End Set
        Get
            Return _UserType
        End Get
    End Property
    Public Property UserStatus As String
        Set(value As String)
            _UserStatus = value
        End Set
        Get
            Return _UserStatus
        End Get
    End Property
    Public Property LoginStatus As Integer
        Set(value As Integer)
            _LoginStatus = value
        End Set
        Get
            Return _LoginStatus
        End Get
    End Property
    Public Property FirstTime As Integer
        Set(value As Integer)
            _FirstTime = value
        End Set
        Get
            Return _FirstTime
        End Get
    End Property
#End Region

#Region "User Defined Methods"

    Public Sub SetUserID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        UserID = CInt(cmd.ExecuteScalar())
    End Sub
    Public Sub ViewUser(gv As DataGridView)
        Try
            Dim sql As String = "SELECT * FROM user where usertype <> 'Administrator' ORDER BY firstname,lastname ASC;"
            gv.Rows.Clear()
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    With gv
                        If reader("userstatus") = "Active" Then
                            .Rows.Add(reader("userid"), reader("firstname") + " " + reader("lastname"), _
                                  reader("username"), reader("usertype"), "Deactivate", "Edit", "Delete")
                        Else
                            .Rows.Add(reader("userid"), reader("firstname") + " " + reader("lastname"), _
                                  reader("username"), reader("usertype"), "Activate", "Edit", "Delete")
                        End If
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function SetUserDetails(id As Integer) As Boolean
        Dim reader As MySql.Data.MySqlClient.MySqlDataReader
        Dim bool As Boolean = False
        Try
            Dim sql As String = "SELECT * FROM user WHERE userid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                reader = cmd.ExecuteReader()
                While reader.Read()
                    UserID = reader("userid")
                    FirstName = reader("firstname")
                    LastName = reader("lastname")
                    Username = reader("username")
                    Password = reader("password")
                    Usertype = reader("usertype")
                    UserStatus = reader("userstatus")
                    LoginStatus = reader("login")
                    FirstTime = reader("firsttime")
                End While
                bool = True
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub SearchUser(kw As String, gv As DataGridView)
        Try
            Dim sql As String = "SELECT * FROM user where (username LIKE '" & kw & "%' or " _
                                & "concat(firstname,' ',lastname) LIKE '" & kw & "%' or lastname LIKE '" & kw & "%') and usertype <> 'Administrator' ORDER BY firstname,lastname ASC;"
            gv.Rows.Clear()
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    With gv
                        If reader("userstatus") = "Active" Then
                            .Rows.Add(reader("userid"), reader("firstname") + " " + reader("lastname"), _
                                  reader("username"), reader("usertype"), "Deactivate", "Edit", "Delete")
                        Else
                            .Rows.Add(reader("userid"), reader("firstname") + " " + reader("lastname"), _
                                  reader("username"), reader("usertype"), "Activate", "Edit", "Delete")
                        End If
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function IsUserAdded() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = "INSERT INTO user (firstname,lastname,username,password,usertype," _
                                & "firsttime,login,userstatus) VALUES (@0,@1,@2,@3,@4,@5,@6,@7);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, FirstName, LastName, Username, Password, Usertype, FirstTime, LoginStatus, UserStatus)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function IsUserUpdated() As Boolean
        Dim bool As Boolean = False
        Try
            If IsConnected() = True Then
                Dim sql As String = "UPDATE USER SET " _
                    & "firstname=@0,lastname=@1,username=@2,password=@3,usertype=@4,userstatus=@5 WHERE userid = @6;"
                ServerExecuteSQL(sql, FirstName, LastName, Username, Password, Usertype, UserStatus, UserID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function IsUserDeleted() As Boolean
        Dim bool As Boolean = False
        Try
            If IsConnected() = True Then
                Dim sql As String = "DELETE FROM user WHERE userid = @0;"
                ServerExecuteSQL(sql, UserID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function GenerateUsername() As String
        Dim un As String = ""
        Dim rdm As New Random()
        Dim allowChrs() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        For i As Integer = 0 To 5
            un += allowChrs(rdm.Next(0, allowChrs.Length))
        Next
        If IsExist(un) = True Then
            GenerateUsername()
        End If
        Return un
    End Function
    Public Function IsExist(str As String) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sqllogin As String = "SELECT * FROM user WHERE BINARY username = '" & str & "' LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sqllogin, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    bool = True
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IsAccessGranted(user As String, pass As String) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sqllogin As String = "SELECT * FROM user WHERE BINARY username = '" & user & "' and " _
                                     & "BINARY password = '" & pass & "' LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sqllogin, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    UserID = reader("userid")
                    bool = True
                End While
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IsActive(id As Integer) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sqllogin As String = "SELECT * FROM user WHERE userid = " & id & " AND userstatus = 'Active';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sqllogin, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    bool = True
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IsLogout(id As Integer) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sqllogin As String = "SELECT * FROM user WHERE userid = " & id & " AND login = 0;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sqllogin, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    UserID = reader("userid")
                    FirstName = reader("firstname")
                    LastName = reader("lastname")
                    Username = reader("username")
                    Password = reader("password")
                    Usertype = reader("usertype")
                    UserStatus = reader("userstatus")
                    LoginStatus = reader("login")
                    FirstTime = reader("firsttime")
                    bool = True
                End While
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IsFirstTime(id As Integer) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sqllogin As String = "SELECT * FROM user WHERE userid = " & id & " AND firsttime = 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sqllogin, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    bool = True
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function IsUpdatedLogInStatus(id As Integer, status As Integer) As Boolean
        Dim bool As Boolean = False
        Try
            Dim sqlUpdate As String
            If status = 0 Then
                sqlUpdate = "UPDATE user SET " _
                    & "login=@0 WHERE userid = @1;"
            Else
                sqlUpdate = "UPDATE user SET " _
                    & "login=@0 WHERE userid = @1;"
            End If
            If Usertype = "Administrator" Then
                status = 0
            End If
            If IsConnected() = True Then
                ServerExecuteSQL(sqlUpdate, status, id)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function IsUpdatedFirstTime(id As Integer, ft As Integer) As Boolean
        Dim bool As Boolean = False
        Try
            If IsConnected() = True Then
                Dim sqlUpdate As String = "UPDATE user SET " _
                    & "firsttime=@0 WHERE userid = @1;"
                ServerExecuteSQL(sqlUpdate, ft, id)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function IsUpdatedUsernameAndPassword() As Boolean
        Dim bool As Boolean = False
        Try
            If IsConnected() = True Then
                Dim sql As String = "UPDATE USER SET " _
                                           & "username = @0," _
                                           & "password = @1 " _
                                           & "WHERE userid = @2;"
                ServerExecuteSQL(sql, Username, Password, UserID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function IsPasswordForAdministrator(id As Integer, pw As String) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sqllogin As String = "SELECT * FROM user WHERE BINARY password = '" & pw & "' and userid = " & id & " LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sqllogin, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    bool = True
                End If
                reader.Close()
            End If
            Return bool
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
