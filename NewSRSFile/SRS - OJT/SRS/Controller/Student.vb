Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

Public Class Student

    Inherits Family

    Private _studentid As Integer = 0
    Public Property StudentID As Integer
        Set(value As Integer)
            _studentid = value
        End Set
        Get
            Return _studentid
        End Get
    End Property
    Private _givenname As String = ""
    Public Property GivenName As String
        Set(value As String)
            _givenname = value
        End Set
        Get
            Return _givenname
        End Get
    End Property
    Private _middlename As String = ""
    Public Property MiddleName As String
        Set(value As String)
            _middlename = value
        End Set
        Get
            Return _middlename
        End Get
    End Property
    Private _surname As String = ""
    Public Property Surname As String
        Set(value As String)
            _surname = value
        End Set
        Get
            Return _surname
        End Get
    End Property
    Private _middleinitial As String = ""
    Public Property MiddleInitial As String
        Set(value As String)
            _middleinitial = value
        End Set
        Get
            Return _middleinitial
        End Get
    End Property
    Private _nameext As String = ""
    Public Property NameExt As String
        Set(value As String)
            _nameext = value
        End Set
        Get
            Return _nameext
        End Get
    End Property
    Private _studentstatus As String = "NEW"
    Public Property StudentStatus As String
        Set(value As String)
            _studentstatus = value
        End Set
        Get
            Return _studentstatus
        End Get
    End Property
    Private _studenttype As String = "REGULAR"
    Public Property StudentType As String
        Set(value As String)
            _studenttype = value
        End Set
        Get
            Return _studenttype
        End Get
    End Property
    Private _gradelevel As String = ""
    Public Property GradeLevel As String
        Set(value As String)
            _gradelevel = value
        End Set
        Get
            Return _gradelevel
        End Get
    End Property
    Private _schoolyear As String = ""
    Public Property SchoolYear As String
        Set(value As String)
            _schoolyear = value
        End Set
        Get
            Return _schoolyear
        End Get
    End Property
    Private _pupilno As String = 0
    Public Property PupilNo As String
        Set(value As String)
            _pupilno = value
        End Set
        Get
            Return _pupilno
        End Get
    End Property
    Private _sex As String = "MALE"
    Public Property Sex As String
        Set(value As String)
            _sex = value
        End Set
        Get
            Return _sex
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
    Private _age As Integer = 0
    Public Property Age As Integer
        Set(value As Integer)
            _age = value
        End Set
        Get
            Return _age
        End Get
    End Property
    Private _birthplace As String = ""
    Public Property BirthPlace As String
        Set(value As String)
            _birthplace = value
        End Set
        Get
            Return _birthplace
        End Get
    End Property
    Private _religion As String = ""
    Public Property Religion As String
        Set(value As String)
            _religion = value
        End Set
        Get
            Return _religion
        End Get
    End Property
    Private _street As String = ""
    Public Property Street As String
        Set(value As String)
            _street = value
        End Set
        Get
            Return _street
        End Get
    End Property
    Private _barangay As String
    Public Property Barangay As String
        Set(value As String)
            _barangay = value
        End Set
        Get
            Return _barangay
        End Get
    End Property
    Private _city As String
    Public Property City As String
        Set(value As String)
            _city = value
        End Set
        Get
            Return _city
        End Get
    End Property
    Private _province As String
    Public Property Province As String
        Set(value As String)
            _province = value
        End Set
        Get
            Return _province
        End Get
    End Property
    Private _photostring As String
    Public Property PhotoString As String
        Set(value As String)
            _photostring = value
        End Set
        Get
            Return _photostring
        End Get
    End Property
    Private _photo As Byte()
    Public Property Photo As Byte()
        Set(value As Byte())
            _photo = value
        End Set
        Get
            Return _photo
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
    Public Function ConvertImageTo64(img As Image) As String
        Try
            Dim ms As New System.IO.MemoryStream()
            img.Save(ms, ImageFormat.Bmp)
            Photo = ms.ToArray()
            ms.Dispose()
            Dim base64 As String = Convert.ToBase64String(Photo)
            Return base64
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Base64ToImage(str As String) As Image
        Try
            Dim mybyte() As Byte = Convert.FromBase64String(str)
            Dim ms As New System.IO.MemoryStream(mybyte)
            Dim img As Image
            img = Image.FromStream(ms)
            Return img
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub SetStudentID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        StudentID = CInt(cmd.ExecuteScalar())
    End Sub

    Public Function AddStudent() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "INSERT INTO student (givenname,middlename,surname,middleinitial,nameext,studentstatus,studenttype,gradelevel," _
                & "schoolyear,pupilno,sex,age,dob,birthplace,religion,street,barangay,city,province,photo) VALUES " _
                & "(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12,@13,@14,@15,@16,@17,@18,@19);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GivenName, MiddleName, Surname, MiddleInitial, NameExt, StudentStatus, StudentType, GradeLevel, _
                            SchoolYear, PupilNo, Sex, Age, DOB, BirthPlace, Religion, Street, Barangay, City, Province, PhotoString)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function EditStudent() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE student SET givenname=@0,middlename=@1,surname=@2,middleinitial=@3,nameext=@4,studentstatus=@5,studenttype=@6,gradelevel=@7," _
                & "schoolyear=@8,pupilno=@9,sex=@10,age=@11,dob=@12,birthplace=@13,religion=@14,street=@15,barangay=@16,city=@17,province=@18,photo=@19 WHERE studentid=@20"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GivenName, MiddleName, Surname, MiddleInitial, NameExt, StudentStatus, StudentType, GradeLevel, _
                            SchoolYear, PupilNo, Sex, Age, DOB, BirthPlace, Religion, Street, Barangay, City, Province, PhotoString, StudentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function UpdateStudent() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE student SET gradelevel=@0,schoolyear=@1,dor=current_timestamp WHERE studentid=@2"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GradeLevel, SchoolYear, StudentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Sub SetStudentDetails(i As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM student WHERE studentid = " & i & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    StudentID = reader("studentid")
                    GivenName = reader("givenname")
                    MiddleName = reader("middlename")
                    Surname = reader("surname")
                    MiddleInitial = reader("middleinitial")
                    NameExt = reader("nameext")
                    StudentStatus = reader("studentstatus")
                    StudentType = reader("studenttype")
                    GradeLevel = reader("gradelevel")
                    SchoolYear = reader("schoolyear")
                    PupilNo = reader("pupilno")
                    Sex = reader("sex")
                    Age = reader("age")
                    DOB = reader("dob")
                    BirthPlace = reader("birthplace")
                    Religion = reader("religion")
                    Street = reader("street")
                    Barangay = reader("barangay")
                    City = reader("city")
                    Province = reader("province")
                    PhotoString = reader("photo")
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewStudentList(gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM student ORDER BY surname, givenname, middlename, nameext ASC LIMIT 1000;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    gv.Rows.Add(reader("studentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function IsStudentExist(s As String, g As String, m As String) As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT * FROM student WHERE (surname = '" & s & "' and givenname = '" & g & "'" _
                & " and middlename = '" & m & "');"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
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
    Public Sub SearchStudentInAssessment(ky As String, gv As DataGridView, sy As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM student inner join enrollment on student.studentid = enrollment.studentid  WHERE schoolyearid = " & sy & "" _
                & " AND (concat(surname, ', ', givenname, ' ', middlename) LIKE '" & ky & "%' or surname LIKE '" & ky & "%' or givenname" _
                & " LIKE '" & ky & "%' or middlename LIKE '" & ky & "%')" _
                & " ORDER BY surname, givenname, middlename, nameext ASC LIMIT 10;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), "LOAD")
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SearchStudent(ky As String, gv As DataGridView)
        Try
            Dim sql As String
            sql = "SELECT * FROM student WHERE (concat(surname, ', ', givenname, ' ', middlename) LIKE '" & ky & "%' or surname " _
                & "LIKE '" & ky & "%' or givenname LIKE '" & ky & "%' or middlename LIKE '" & ky & "%') " _
                & "ORDER BY surname, givenname, middlename, nameext ASC LIMIT 20;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    gv.Rows.Add(reader("studentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"))
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Public Function SearchStudent(ky As String) As DataSet
    '    Dim ds As New DataSet
    '    Try
    '        Dim sql As String
    '        sql = "SELECT studentid, CONCAT(surname, ', ', givenname, ' ', middlename) FROM student WHERE (concat(surname, ', ', givenname, ' ', middlename) LIKE '" & ky & "%') " _
    '                & "ORDER BY surname, givenname, middlename, nameext ASC LIMIT 10;"
    '        Dim da As New MySqlDataAdapter(sql, getServerConnection())
    '        da.Fill(ds, "student")
    '        Return ds
    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
End Class
