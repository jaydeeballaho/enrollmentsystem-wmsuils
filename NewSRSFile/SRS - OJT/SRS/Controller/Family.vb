Imports MySql.Data.MySqlClient

Public Class Family

    Private _studentidid As Integer = 0
    Public Property StudentIDID As Integer
        Set(value As Integer)
            _studentidid = value
        End Set
        Get
            Return _studentidid
        End Get
    End Property
    Private _fatherid As Integer = 0
    Public Property FatherID As Integer
        Set(value As Integer)
            _fatherid = value
        End Set
        Get
            Return _fatherid
        End Get
    End Property
    Private _motherid As Integer = 0
    Public Property MotherID As Integer
        Set(value As Integer)
            _motherid = value
        End Set
        Get
            Return _motherid
        End Get
    End Property
    Private _guardianid As Integer = 0
    Public Property GuardianID As Integer
        Set(value As Integer)
            _guardianid = value
        End Set
        Get
            Return _guardianid
        End Get
    End Property
    Private _contactid As Integer = 0
    Public Property ContactID As Integer
        Set(value As Integer)
            _contactid = value
        End Set
        Get
            Return _contactid
        End Get
    End Property

    Private _name As String = ""
    Public Property Name As String
        Set(value As String)
            _name = value
        End Set
        Get
            Return _name
        End Get
    End Property
    Private _office As String = ""
    Public Property Office As String
        Set(value As String)
            _office = value
        End Set
        Get
            Return _office
        End Get
    End Property
    Private _contact As String = ""
    Public Property Contact As String
        Set(value As String)
            _contact = value
        End Set
        Get
            Return _contact
        End Get
    End Property
    Private _address As String = ""
    Public Property Address As String
        Set(value As String)
            _address = value
        End Set
        Get
            Return _address
        End Get
    End Property
    Private _type As String = "FATHER"
    Public Property Type As String
        Set(value As String)
            _type = value
        End Set
        Get
            Return _type
        End Get
    End Property
    Private _occupation As String = ""
    Public Property Occupation As String
        Set(value As String)
            _occupation = value
        End Set
        Get
            Return _occupation
        End Get
    End Property
    Public Sub SetFatherID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        FatherID = CInt(cmd.ExecuteScalar())
    End Sub
    Public Sub SetMotherID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        MotherID = CInt(cmd.ExecuteScalar())
    End Sub
    Public Sub SetGuardianID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        GuardianID = CInt(cmd.ExecuteScalar())
    End Sub
    Public Sub SetContactID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        ContactID = CInt(cmd.ExecuteScalar())
    End Sub
    Public Function AddFamily() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "INSERT INTO family (studentid,name,office,contact,address,type,occupation) VALUES " _
                & "(@0,@1,@2,@3,@4,@5,@6);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, StudentIDID, Name, Office, Contact, Address, Type, Occupation)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function EditFamily(id) As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE family SET studentid=@0,name=@1,office=@2,contact=@3,address=@4,type=@5,occupation=@6 WHERE familyid = @7;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, StudentIDID, Name, Office, Contact, Address, Type, Occupation, id)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub SetFatherDetails(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM family WHERE studentid = " & i & " AND type = 'FATHER';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    FatherID = reader("familyid")
                    Name = reader("name")
                    Office = reader("office")
                    Contact = reader("contact")
                    Address = reader("address")
                    Type = reader("type")
                    Occupation = reader("occupation")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SetMotherDetails(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM family WHERE studentid = " & i & " AND type = 'MOTHER';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    MotherID = reader("familyid")
                    Name = reader("name")
                    Office = reader("office")
                    Contact = reader("contact")
                    Address = reader("address")
                    Type = reader("type")
                    Occupation = reader("occupation")
                End While
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub SetGuardianDetails(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM family WHERE studentid = " & i & " AND type = 'GUARDIAN';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    GuardianID = reader("familyid")
                    Name = reader("name")
                    Office = reader("office")
                    Contact = reader("contact")
                    Address = reader("address")
                    Type = reader("type")
                    Occupation = reader("occupation")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SetContactDetails(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM family WHERE studentid = " & i & " AND type = 'CONTACT';"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ContactID = reader("familyid")
                    Name = reader("name")
                    Office = reader("office")
                    Contact = reader("contact")
                    Address = reader("address")
                    Type = reader("type")
                    Occupation = reader("occupation")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
