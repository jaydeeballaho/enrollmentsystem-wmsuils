Imports MySql.Data.MySqlClient

Public Class Teacher

    Private _teacherid As Integer = 0
    Public Property TeacherID As Integer
        Set(value As Integer)
            _teacherid = value
        End Set
        Get
            Return _teacherid
        End Get
    End Property

    Private _teacherno As String
    Public Property TeacherNo As String
        Set(value As String)
            _teacherno = value

        End Set
        Get
            Return _teacherno
        End Get
    End Property

    Private Property _type As String = ""
    Public Property type As String
        Set(value As String)
            _type = value
        End Set
        Get
            Return _type
        End Get
    End Property
    Private _firstName As String
    Public Property FirstName As String
        Set(value As String)
            _firstName = value
        End Set
        Get
            Return _firstName
        End Get
    End Property
    Private _middleName As String
    Public Property MiddleName As String
        Set(value As String)
            _middleName = value
        End Set
        Get
            Return _middleName
        End Get
    End Property
    Private _lastName As String
    Public Property LastName As String
        Set(value As String)
            _lastName = value
        End Set
        Get
            Return _lastName
        End Get
    End Property
    Private _extName As String
    Public Property ExtName As String
        Set(value As String)
            _extName = value
        End Set
        Get
            Return _extName
        End Get
    End Property
    Private _gender As String = "Male"
    Public Property Gender As String
        Set(value As String)
            _gender = value
        End Set
        Get
            Return _gender
        End Get
    End Property
    Private _dob As Date
    Public Property DOB As Date
        Set(value As Date)
            _dob = value
        End Set
        Get
            Return _dob
        End Get
    End Property
    Private _address As String
    Public Property Address As String
        Set(value As String)
            _address = value
        End Set
        Get
            Return _address
        End Get
    End Property
    Private _contact As String
    Public Property Contact As String
        Set(value As String)
            _contact = value
        End Set
        Get
            Return _contact
        End Get
    End Property
    Private _email As String
    Public Property Email As String
        Set(value As String)
            _email = value
        End Set
        Get
            Return _email
        End Get
    End Property
    Private _userType As String
    Public Property UserType As String
        Set(value As String)
            _userType = value
        End Set
        Get
            Return _userType
        End Get
    End Property
    Private _age As Integer
    Public Property Age As Integer
        Set(value As Integer)
            _age = value
        End Set
        Get
            Return _age
        End Get
    End Property

    Private _gradelvl As String
    Public Property GradeLevel As String
        Set(value As String)
            _gradelvl = value
        End Set
        Get
            Return _gradelvl
        End Get
    End Property
    Private _section As String
    Public Property Section As String
        Set(value As String)
            _section = value
        End Set
        Get
            Return _section
        End Get
    End Property
    Public Function GetCurrentAge(ByVal DOB As Date, serverDT As Date) As Integer
        Try
            Dim CalculateAge As Integer
            CalculateAge = serverDT.Year - DOB.Year
            If (DOB > serverDT.AddYears(-CalculateAge)) Then CalculateAge -= 1
            Return CalculateAge
        Catch ex As Exception
            Return 0
        End Try
    End Function



    Public Function AddTeacher(str As String) As Boolean
        Try
            Dim sql As String = "INSERT INTO teacher (teacherno,teachertype,firstname,middlename,lastname,extname,gender,dob,age," _
                 & "address, contactno, email,gradelevel,section) VALUES (@0,@1,@2,@3,@4,@5," _
                 & "@6,@7,@8,@9,@10,@11,@12,@13);"

            sql = sql + str
            IsConnected()
            ServerExecuteSQL(sql, TeacherNo, type, FirstName, MiddleName, LastName, ExtName, Gender, DOB, _
                            Age, Address, Contact, Email, GradeLevel, Section)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function EditTeacher(str As String) As Boolean
        Try
            Dim sql As String = "UPDATE teacher SET teacherno=@0,teachertype=@1,firstname=@2,middlename=@3," _
                                & "lastname=@4,extname=@5,gender=@6,dob=@7,age=@8,address=@9,contactno=@10,email=@11,gradelevel=@12,section=@13 WHERE teacherid=@14;"
            sql = sql + str
            IsConnected()
            ServerExecuteSQL(sql, TeacherNo, type, FirstName, MiddleName, LastName, ExtName, Gender, DOB, _
                            Age, Address, Contact, Email, GradeLevel, Section, TeacherID)
        Catch ex As Exception
            MsgBox(ex.Message)
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function DeleteTeacher() As Boolean
        Try
            Dim sql As String = "DELETE FROM user WHERE userid = @0;" _
                & "DELETE FROM teacher WHERE userid=@1;" _
                & "DELETE FROM expertise WHERE teacherno=(SELECT teacherno FROM teacher WHERE userid = @1);"

            IsConnected()
            ServerExecuteSQL(sql, TeacherID)
        Catch ex As Exception
            Rollback()
            Return False
        Finally
            Commit()
        End Try
        Return True
    End Function
    Public Function IsTeacherNoExist(str As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String = "Select teacherno FROM teacher WHERE teacherno = '" & str & "';"
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
    Public Sub searchTeacher(filter As String, kw As String, tb As TextBox, gv As DataGridView)
        Try
            Dim s As String = tb.Text.Trim
            Dim sql As String
            If filter = "Name" Then
                sql = "SELECT * FROM teacher WHERE lastname LIKE '" & s & "%'ORDER by lastname ASC;"
            Else
                sql = "SELECT * FROM teacher WHERE teacherno LIKE '" & s & "%' ORDER BY teacherno ASC;"
            End If
            gv.Rows.Clear()
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("teacherno"), reader("lastname") _
                                  + ", " + reader("firstname") + " " + reader("middlename") + " " + reader("extname"))
                End With
            End While
            gv.ClearSelection()
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub searchTeacher2(gv As DataGridView, cm As ContextMenuStrip, keyword As String)
        Try
            Dim sql As String
            Dim i As Integer = 1
            sql = "SELECT * FROM teacher WHERE lastname LIKE '" & keyword & "%' ORDER BY lastname ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("teacherno"), i, reader("lastname") _
                                 + ", " + reader("firstname") + " " + reader("middlename") + " " + reader("extname"), _
                                 reader("teacherno"), reader("teachertype"), reader("gender"), Date.Parse(reader("dob")).ToShortDateString, _
                                 reader("age"), reader("address"))
                End With
                i = i + 1
            End While
            gv.ClearSelection()
            reader.Close()
            addMenu(gv, cm)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub searchTeacher3(gv As DataGridView, keyword As String)
        Try
            Dim sql As String
            Dim i As Integer = 1
            sql = "SELECT * FROM teacher WHERE lastname LIKE '" & keyword & "%' ORDER BY lastname ASC;"
            IsConnected()
            gv.Rows.Clear()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("teacherno"), reader("lastname") _
                                 + ", " + reader("firstname") + " " + reader("middlename") + " " + reader("extname"), _
                                 reader("teacherno"), reader("teachertype"))
                End With
                i = i + 1
            End While
            gv.ClearSelection()
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub setTeacherDetails(i As String)
        Try
            Dim sql As String
            sql = "SELECT * FROM teacher WHERE teacherno = '" + i + "';"
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                TeacherID = reader("teacherid")
                TeacherNo = reader("teacherno")
                type = reader("teachertype")
                FirstName = reader("firstname")
                MiddleName = reader("middlename")
                LastName = reader("lastname")
                ExtName = reader("extname")
                Gender = reader("gender")
                DOB = reader("dob")
                Age = reader("age")
                Address = reader("address")
                Contact = reader("contactno")
                Email = reader("email")
                GradeLevel = reader("gradelevel")
                Section = reader("section")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub addMenu(gv As DataGridView, cm As ContextMenuStrip)
        For Each row As DataGridViewRow In gv.Rows
            row.ContextMenuStrip = cm
        Next
    End Sub
    Public Sub loadTeachertExpertise(exp As String, gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM expertise WHERE teacherno = '" & exp & "';"
            gv.Rows.Clear()
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                With gv
                    .Rows.Add(reader("expertid"), reader("fieldname"))
                End With
            End While
            reader.Close()
            gv.ClearSelection()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub viewTeacher(gv As DataGridView)
        Try
            Dim i As Integer = 0
            Dim sql As String
            sql = "SELECT * FROM teacher ORDER BY lastname ASC;"
            gv.Rows.Clear()
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                i = i + 1
                With gv
                    .Rows.Add(reader("teacherno"), i, reader("lastname") _
                                  + ", " + reader("firstname") + " " + reader("middlename") + " " + reader("extname"), _
                                  reader("teacherno"), reader("teachertype"), reader("gender"), Date.Parse(reader("dob")).ToShortDateString, _
                                  reader("age"), reader("address"))
                End With
            End While
            gv.ClearSelection()
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub viewTeacher2(gv As DataGridView)
        Try
            Dim i As Integer = 0
            Dim sql As String
            sql = "SELECT * FROM teacher order by lastname;"
            gv.Rows.Clear()
            IsConnected()
            Dim cmd = New MySqlCommand(sql, getServerConnection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                i = i + 1
                With gv
                    .Rows.Add(reader("teacherno"), reader("lastname") _
                                  + ", " + reader("firstname") + " " + reader("middlename") + " " + reader("extname"), _
                                  reader("teacherno"), reader("teachertype"))
                End With
            End While
            gv.ClearSelection()
            reader.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class
