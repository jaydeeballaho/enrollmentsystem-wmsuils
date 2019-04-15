Imports MySql.Data.MySqlClient

Public Class Room

    Private _roomid As Integer = 0
    Public Property RoomID As Integer
        Set(value As Integer)
            _roomid = value
        End Set
        Get
            Return _roomid
        End Get
    End Property
    Private _roomNo As String = ""
    Public Property RoomNo As String
        Set(value As String)
            _roomNo = value
        End Set
        Get
            Return _roomNo
        End Get
    End Property
    Private _roomBldg As String = ""
    Public Property RoomBldg As String
        Set(value As String)
            _roomBldg = value
        End Set
        Get
            Return _roomBldg
        End Get
    End Property
    Private _capacity As Double = 0
    Public Property Capacity As Double
        Set(value As Double)
            _capacity = value
        End Set
        Get
            Return _capacity
        End Get
    End Property

    Public Function AddRoom() As Boolean
        Try
            Dim sql As String = "INSERT INTO room (roomnumber,building,capacity) VALUES (@0,@1,@2);"
            IsConnected()
            ServerExecuteSQL(sql, RoomNo, RoomBldg, Capacity)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function EditRoom() As Boolean
        Try
            Dim sql As String = "UPDATE room SET roomnumber=@0,building=@1,capacity=@2 WHERE roomid=@3;"
            IsConnected()
            ServerExecuteSQL(sql, RoomNo, RoomBldg, Capacity, RoomID)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function DeleteRoom() As Boolean
        Try
            Dim sql As String = "DELETE FROM room where roomid = @0;"
            IsConnected()
            ServerExecuteSQL(sql, RoomID)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function IsRoomNoExist(str As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String = "SELECT * FROM room WHERE roomnumber = '" & str & "';"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader = cmd.ExecuteReader()
            If reader.HasRows Then
                bool = True
            Else
                bool = False
            End If
            Return bool
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Sub viewRoom(gv As DataGridView)
        Try
            Dim sql As String
            Dim i As Integer = 1
            sql = "SELECT * FROM room ORDER BY roomnumber ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("roomid"), reader("roomnumber"), reader("building"), reader("capacity"), "Edit", "Delete")
                End With
                i = i + 1
            End While
            gv.ClearSelection()
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub setRoomDetails(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM room WHERE roomid = " & i & ";"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                RoomID = reader("roomid")
                RoomNo = reader("roomnumber")
                RoomBldg = reader("building")
                Capacity = reader("capacity")
            End While
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub setRoomDetails2(s As String)
        Try

            Dim sql As String
            sql = "SELECT * FROM room WHERE roomnumber = '" & s & "';"
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                RoomID = reader("roomid")
                RoomNo = reader("roomnumber")
                RoomBldg = reader("building")
                Capacity = reader("capacity")
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
    Public Sub searchRoom(gv As DataGridView, keyword As String)
        Try
            Dim sql As String
            Dim i As Integer = 1
            sql = "SELECT * FROM room WHERE roomnumber LIKE '" & keyword & "%' ORDER BY roomnumber ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("roomid"), reader("roomnumber"), reader("building"), reader("capacity"), "Edit", "Delete")
                End With
                i = i + 1
            End While
            gv.ClearSelection()
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub loadRoomToCBO(cbo As ComboBox)
        Try
            Dim sql As String
            sql = "SELECT * FROM room ORDER BY roomnumber ASC;"
            IsConnected()
            cbo.Items.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With cbo
                    .Items.Add(reader("roomnumber"))
                End With

            End While
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class
