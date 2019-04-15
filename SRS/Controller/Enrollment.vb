Imports MySql.Data.MySqlClient

Public Class frmPrint

    Private _enrollmentid As Integer
    Public Property EnrollmentID As Integer
        Set(value As Integer)
            _enrollmentid = value
        End Set
        Get
            Return _enrollmentid
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
    Private _schoolyearid As Integer
    Public Property SchoolYearID As Integer
        Set(value As Integer)
            _schoolyearid = value
        End Set
        Get
            Return _schoolyearid
        End Get
    End Property
    Private _gradelevelid As Integer
    Public Property GradeLevelID As Integer
        Set(value As Integer)
            _gradelevelid = value
        End Set
        Get
            Return _gradelevelid
        End Get
    End Property
    Private _sectionid As Integer
    Public Property SectionID As Integer
        Set(value As Integer)
            _sectionid = value
        End Set
        Get
            Return _sectionid
        End Get
    End Property
    Private _assessedamount As Decimal = 0
    Public Property AssessedAmount As Decimal
        Set(value As Decimal)
            _assessedamount = value
        End Set
        Get
            Return _assessedamount
        End Get
    End Property
    Private _doa As Date
    Public Property DOA As Date
        Set(value As Date)
            _doa = value
        End Set
        Get
            Return _doa
        End Get
    End Property
    Private _doe As Date
    Public Property DOE As Date
        Set(value As Date)
            _doe = value
        End Set
        Get
            Return _doe
        End Get
    End Property
    Private _status As String = ""
    Public Property Status As String
        Set(value As String)
            _status = value
        End Set
        Get
            Return _status
        End Get
    End Property
    Private _enrolledby As String = ""
    Public Property EnrolledBy As String
        Set(value As String)
            _enrolledby = value
        End Set
        Get
            Return _enrolledby
        End Get
    End Property
    Private _dorr As Date
    Public Property DORR As Date
        Set(value As Date)
            _dorr = value
        End Set
        Get
            Return _dorr
        End Get
    End Property
    Private _percent As Decimal = 0
    Public Property Percent As String
        Set(value As String)
            _percent = value
        End Set
        Get
            Return _percent
        End Get
    End Property
    Private _down As Decimal = 0
    Public Property Down As String
        Set(value As String)
            _down = value
        End Set
        Get
            Return _down
        End Get
    End Property
    Private _ispaid As String = "No"
    Public Property IsPaid As String
        Set(value As String)
            _ispaid = value
        End Set
        Get
            Return _ispaid
        End Get
    End Property
    Public Sub SetEnrollmentID()
        Dim sql As String = "SELECT LAST_INSERT_ID();"
        Dim cmd = New MySqlCommand(sql, getServerConnection)
        EnrollmentID = CInt(cmd.ExecuteScalar())
    End Sub
    Public Function AddStudent() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "INSERT INTO enrollment (studentid,schoolyearid,gradelevelid,dorr,status,sectionid) VALUES " _
                & "(@0,@1,@2,current_timestamp(),@3,@4);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, StudentID, SchoolYearID, GradeLevelID, Status, SectionID)
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
            sql = "UPDATE enrollment SET gradelevelid=@0,status=@1,sectionid=@2 where enrollmentid=@3;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, GradeLevelID, Status, SectionID, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function Assess() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE enrollment SET assessedamount=@0,doa=current_timestamp,status=@1,discountpercent=@2,ispaid=@3,down=@4" _
                & " WHERE enrollmentid = @5;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AssessedAmount, "Assessed", Percent, "No", Down, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function PayAssess() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE enrollment SET ispaid=@0 WHERE enrollmentid = @1;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, "Yes", EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function EditAssessment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE enrollment SET assessedamount=@0,discountpercent=@1,down=@2" _
                & " WHERE enrollmentid = @3;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, AssessedAmount, Percent, Down, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function AddToEnrollment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE enrollment SET doe=current_timestamp(),status='Enrolled' WHERE enrollmentid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function DropStudent() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE enrollment SET status='Dropped' WHERE enrollmentid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function ReEnroll() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "UPDATE enrollment SET status='Enrolled',doe=current_timestamp,enrolledby='" & frmHome.fullname & "' WHERE enrollmentid = @0;"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Function DeleteAssessment() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "DELETE FROM assessedfees WHERE enrollmentid = @0; DELETE FROM enrollment WHERE enrollmentid = @1 and status = 'Assessed';"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID, EnrollmentID)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function

    Public Sub SetAssessmentDetails2(id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM enrollment WHERE enrollmentid = " & id & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    EnrollmentID = reader("enrollmentid")
                    StudentID = reader("studentid")
                    SchoolYearID = reader("schoolyearid")
                    GradeLevelID = reader("gradelevelid")
                    SectionID = reader("sectionid")
                    DORR = reader("dorr")
                    Status = reader("status")
                    If Status = "Assessed" Then
                        AssessedAmount = reader("assessedamount")
                        DOA = reader("doa")
                        Percent = reader("discountpercent")
                        IsPaid = reader("ispaid")
                        Down = reader("down")
                    End If
                    If Status = "Enrolled" Then
                        AssessedAmount = reader("assessedamount")
                        DOA = reader("doa")
                        Percent = reader("discountpercent")
                        IsPaid = reader("ispaid")
                        Down = reader("down")
                        DOE = reader("doe")
                        EnrolledBy = reader("enrolledby")
                    End If
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function SetLatestGradeLevelNo() As String
        Try
            Dim gl As String = ""
            Dim sql As String
            sql = "SELECT * FROM enrollment inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " WHERE studentid = " & StudentID & " ORDER BY enrollmentid DESC LIMIT 1;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    gl = reader("gradelevelno")
                End While
                reader.Close()
            End If
            Return gl
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Sub SetAssessmentDetails()
        Try
            Dim sql As String
            sql = "SELECT * FROM enrollment WHERE studentid = " & StudentID & " and schoolyearid = " & SchoolYearID & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    EnrollmentID = reader("enrollmentid")
                    StudentID = reader("studentid")
                    SchoolYearID = reader("schoolyearid")
                    GradeLevelID = reader("gradelevelid")
                    SectionID = reader("sectionid")
                    DORR = reader("dorr")
                    Status = reader("status")
                    If Status = "Assessed" Then
                        AssessedAmount = reader("assessedamount")
                        DOA = reader("doa")
                        Percent = reader("discountpercent")
                        IsPaid = reader("ispaid")
                        Down = reader("down")
                    End If
                    If Status = "Enrolled" Then
                        AssessedAmount = reader("assessedamount")
                        DOA = reader("doa")
                        Percent = reader("discountpercent")
                        IsPaid = reader("ispaid")
                        Down = reader("down")
                        DOE = reader("doe")
                        EnrolledBy = reader("enrolledby")
                    End If
                End While
                reader.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function GetEnrolled() As String
        Try
            Dim str As String = "Pending"
            Dim sql As String
            sql = "SELECT * FROM enrollment WHERE studentid = " & StudentID & " and schoolyearid = " & SchoolYearID & ";"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    str = reader("status")
                End While
                reader.Close()
            End If
            Return str
        Catch ex As Exception
            Return "Pending"
        End Try
    End Function
    Public Function IsEnrolled() As Boolean
        Try
            Dim bool As Boolean = True
            Dim sql As String
            sql = "SELECT * FROM enrollment WHERE studentid = " & StudentID & " and schoolyearid = " & SchoolYearID & " and DATE(doa) <= DATE(NOW());"
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
            Return False
        End Try
    End Function
    Public Function GetBalance() As Decimal
        Try
            Dim d As Decimal = 0
            Dim sql As String
            sql = "SELECT COALESCE(SUM(balance), 0) FROM enrollment inner join assessedfees on enrollment.enrollmentid = assessedfees.enrollmentid" _
                & " WHERE studentid = " & StudentID & " and status = 'Enrolled' and astatus = 'Yes' and schoolyearid <> " & SchoolYearID & " and DATE(doe) <= DATE(NOW()) ;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    d = reader("COALESCE(SUM(balance), 0)")
                End While
                reader.Close()
            End If
            Return d
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function GetBalance2() As Decimal
        Try
            Dim d As Decimal = 0
            Dim sql As String
            sql = "SELECT COALESCE(SUM(balance), 0) FROM enrollment inner join assessedfees on enrollment.enrollmentid = assessedfees.enrollmentid" _
                & " WHERE studentid = " & StudentID & " and status = 'Enrolled' and astatus = 'Yes' and DATE(doe) <= DATE(NOW()) ;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    d = reader("COALESCE(SUM(balance), 0)")
                End While
                reader.Close()
            End If
            Return d
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function GetAmount() As Decimal
        Try
            Dim d As Decimal = 0
            Dim sql As String
            sql = "SELECT COALESCE(SUM(amount), 0) FROM enrollment inner join assessedfees on enrollment.enrollmentid = assessedfees.enrollmentid" _
                & " WHERE studentid = " & StudentID & " and status = 'Enrolled'  and astatus = 'Yes' and schoolyearid <> " & SchoolYearID & " and DATE(doe) <= DATE(NOW()) ;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    d = reader("COALESCE(SUM(amount), 0)")
                End While
                reader.Close()
            End If
            Return d
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function GetDiscount() As Decimal
        Try
            Dim d As Decimal = 0
            Dim sql As String
            sql = "SELECT COALESCE(SUM(discounts), 0) FROM enrollment inner join assessedfees on enrollment.enrollmentid = assessedfees.enrollmentid" _
                & " WHERE studentid = " & StudentID & " and status = 'Enrolled' and astatus = 'Yes' and schoolyearid <> " & SchoolYearID & " and DATE(doe) <= DATE(NOW()) ;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read
                    d = reader("COALESCE(SUM(discounts), 0)")
                End While
                reader.Close()
            End If
            Return d
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Sub SearchEnrollee(sy As String, kw As String, gv As DataGridView)
        Try
            Dim sql As String

            sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
            & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
            & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
            & " where schoolyearno = '" & sy & "' and (CONCAT(surname,', ', givenname,' ',middlename) LIKE '" & kw & "%'" _
            & " or surname LIKE '" & kw & "%' or givenname LIKE '" & kw & "%' or middlename like '" & kw & "%') ORDER BY surname, givenname, middlename ASC LIMIT 1000;"

            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    If reader("status") = "Enrolled" Then
                        gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                            reader("gradelevelno"), reader("Status"), "Re-advise")
                    ElseIf reader("status") = "Dropped" Then
                        gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                            reader("gradelevelno"), reader("Status"), "Re-enroll")
                    ElseIf reader("status") = "Advised" Then
                        gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                            reader("gradelevelno"), reader("Status"), "Edit")
                    ElseIf reader("status") = "Assessed" Then
                        gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                            reader("gradelevelno"), reader("Status"), "Re-advise")
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewEnrollee(sy As String, gl As String, sex As String, type As String, status As String, i As Integer, gv As DataGridView)
        Try
            Dim sql As String
            If gl = "All" And sex = "All" And type = "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl = "All" And sex = "All" And type = "All" And status <> "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl = "All" And sex = "All" And type <> "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and studenttype = '" & type & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl = "All" And sex = "All" And type <> "All" And status <> "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and studenttype = '" & type & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl = "All" And sex <> "All" And type = "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and sex = '" & sex & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl = "All" And sex <> "All" And type = "All" And status <> "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and sex = '" & sex & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl = "All" And sex <> "All" And type <> "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and sex = '" & sex & "' and studenttype = '" & type & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl = "All" And sex <> "All" And type <> "All" And status <> "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and sex = '" & sex & "' and studenttype = '" & type & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl <> "All" And sex = "All" And type = "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl <> "All" And sex = "All" And type = "All" And status <> "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl <> "All" And sex = "All" And type <> "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "'" _
                & " and studenttype = '" & type & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl <> "All" And sex = "All" And type <> "All" And status <> "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "'" _
                & " and studenttype = '" & type & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl <> "All" And sex <> "All" And type = "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "'" _
                & " and sex = '" & sex & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl <> "All" And sex <> "All" And type = "All" And status <> "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "'" _
                & " and sex = '" & sex & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            ElseIf gl <> "All" And sex <> "All" And type <> "All" And status = "All" Then
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' and sex = '" & sex & "'" _
                & " and studenttype = '" & type & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            Else
                sql = "SELECT * FROM enrollment inner join student on enrollment.studentid = student.studentid" _
                & " inner join schoolyear on enrollment.schoolyearid = schoolyear.schoolyearid" _
                & " inner join gradelevel on enrollment.gradelevelid = gradelevel.gradelevelid" _
                & " where schoolyearno = '" & sy & "' and gradelevelno = '" & gl & "' and sex = '" & sex & "'" _
                & " and studenttype = '" & type & "' and enrollment.status = '" & status & "' ORDER BY surname, givenname, middlename ASC LIMIT 1000;"
            End If
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    If i = 1 Then
                        gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                                reader("studenttype"), reader("gradelevelno"), reader("Status"))
                    Else
                        If reader("status") = "Enrolled" Then
                            gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                                reader("gradelevelno"), reader("Status"), "Re-advise")
                        ElseIf reader("status") = "Dropped" Then
                            gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                                reader("gradelevelno"), reader("Status"), "Re-enroll")
                        ElseIf reader("status") = "Advised" Then
                            gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                                reader("gradelevelno"), reader("Status"), "Edit")
                        ElseIf reader("status") = "Assessed" Then
                            gv.Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                                reader("gradelevelno"), reader("Status"), "Re-advise")
                        End If

                    End If
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SearchStudent(kw As String, gv As DataGridView)
        Try
            Dim sql As String

            sql = "SELECT * FROM student where (CONCAT(surname,', ', givenname,' ',middlename) LIKE '" & kw & "%'" _
            & " or surname LIKE '" & kw & "%' or givenname LIKE '" & kw & "%' or middlename like '" & kw & "%') ORDER BY surname, givenname, middlename ASC LIMIT 10;"

            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    gv.Rows.Add(reader("studentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), reader("sex"),
                    "N/A", "N/A", "Advise")
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewEnrollee2(gv As DataGridView, id As Integer)
        Try
            Dim sql As String
            sql = "SELECT * FROM enrollment inner join student on student.studentid=enrollment.studentid " _
                & "inner join gradelevel on gradelevel.gradelevelid=enrollment.gradelevelid inner join section on " _
                & "enrollment.sectionid=section.sectionid inner join schoolyear on enrollment.schoolyearid=schoolyear.schoolyearid " _
                & "inner join subject on subject.gradelevelid = gradelevel.gradelevelid where schoolyear.schoolyearid = " & SchoolYearID & " and " _
                & "enrollment.gradelevelid = " & GradeLevelID & " and enrollment.sectionid = " & SectionID & " and subject.subjectid = " & id & " and enrollment.status = 'Enrolled' order by surname,givenname,middlename ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader("enrollmentid"), reader("subjectid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), _
                                  reader("schoolyearno"), reader("gradelevelno"), reader("sectionno"), _
                                  reader("subjectname"))
                    End With
                End While
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ViewEnrollee3(gv As DataGridView)
        Try

            Dim sql As String
            sql = "SELECT * FROM enrollment inner join student on student.studentid=enrollment.studentid " _
                & "inner join gradelevel on gradelevel.gradelevelid=enrollment.gradelevelid inner join section on " _
                & "enrollment.sectionid=section.sectionid inner join schoolyear on enrollment.schoolyearid=schoolyear.schoolyearid " _
                & "where schoolyear.schoolyearid = " & SchoolYearID & " and " _
                & "enrollment.gradelevelid = " & GradeLevelID & " and enrollment.sectionid = " & SectionID & " and enrollment.status = 'Enrolled' order by surname,givenname,middlename ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    With gv
                        .Rows.Add(reader("enrollmentid"), reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), _
                                  reader("schoolyearno"), reader("gradelevelno"), reader("sectionno"))
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function GetRank1(id As Integer, r As Integer) As Double
        Try
            Dim rank As Double = 0
            Dim sql As String = ""
            If r = 0 Then
                sql = "SELECT AVG(grade1) FROM grade where enrollmentid = " & id & " and grade1 <> '';"
            ElseIf r = 1 Then
                sql = "SELECT AVG(grade2) FROM grade where enrollmentid = " & id & " and grade2 <> '';"
            ElseIf r = 2 Then
                sql = "SELECT AVG(grade3) FROM grade where enrollmentid = " & id & " and grade3 <> '';"
            ElseIf r = 3 Then
                sql = "SELECT AVG(grade4) FROM grade where enrollmentid = " & id & " and grade4 <> '';"
            ElseIf r = 4 Then

                sql = "SELECT AVG(final) FROM grade where enrollmentid = " & id & " and final <> '';"
            End If
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    If r = 0 Then
                        rank = reader("AVG(grade1)")
                    ElseIf r = 1 Then
                        rank = reader("AVG(grade2)")
                    ElseIf r = 2 Then
                        rank = reader("AVG(grade3)")
                    ElseIf r = 3 Then
                        rank = reader("AVG(grade4)")
                    ElseIf r = 4 Then
                        rank = reader("AVG(final)")
                    End If
                End While
                reader.Close()
            End If
            Return rank
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Sub ViewClass(gv As DataGridView)
        Try
            Dim i As Integer = 0
            Dim sql As String
            sql = "SELECT * FROM enrollment inner join student on student.studentid=enrollment.studentid " _
                & "inner join gradelevel on gradelevel.gradelevelid=enrollment.gradelevelid inner join section on " _
                & "enrollment.sectionid=section.sectionid inner join schoolyear on enrollment.schoolyearid=schoolyear.schoolyearid " _
                & "where schoolyear.schoolyearid = " & SchoolYearID & " and " _
                & "enrollment.gradelevelid = " & GradeLevelID & " and enrollment.sectionid = " & SectionID & " and enrollment.status = 'Enrolled' order by surname,givenname,middlename ASC;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                While reader.Read()
                    i = i + 1
                    With gv
                        .Rows.Add(reader("enrollmentid"), i.ToString, reader("surname") + ", " + reader("givenname") + " " + reader("middlename"), _
                                  reader("sex"))
                    End With
                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
