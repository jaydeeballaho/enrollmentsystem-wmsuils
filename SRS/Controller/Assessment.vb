Imports MySql.Data.MySqlClient
Imports MetroFramework.Controls
Imports System.Globalization

Public Class Assessment

    Private _assessedfeesid As Integer = 0
    Public Property AssessedID As Integer
        Set(value As Integer)
            _assessedfeesid = value
        End Set
        Get
            Return _assessedfeesid
        End Get
    End Property
    Private _enrollmentid As Integer = 0
    Public Property EnrollmentID As Integer
        Set(value As Integer)
            _enrollmentid = value
        End Set
        Get
            Return _enrollmentid
        End Get
    End Property
    Private _feessyid As Integer = 0
    Public Property FeesSYID As Integer
        Set(value As Integer)
            _feessyid = value
        End Set
        Get
            Return _feessyid
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
    Private _amount As Decimal = 0
    Public Property Amount As Decimal
        Set(value As Decimal)
            _amount = value
        End Set
        Get
            Return _amount
        End Get
    End Property
    Private _discounts As Decimal = 0
    Public Property Discounts As Decimal
        Set(value As Decimal)
            _discounts = value
        End Set
        Get
            Return _discounts
        End Get
    End Property
    Private _balance As Decimal = 0
    Public Property Balance As Decimal
        Set(value As Decimal)
            _balance = value
        End Set
        Get
            Return _balance
        End Get
    End Property
    Public Function AddAssessedFees() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "INSERT INTO assessedfees (enrollmentid,feessyid,astatus,amount,discounts,balance) VALUES (@0,@1,@2,@3,@4,@5);"
            If IsConnected() = True Then
                ServerExecuteSQL(sql, EnrollmentID, FeesSYID, Status, Amount, Discounts, Balance)
                Commit()
                bool = True
            End If
            Return bool
        Catch ex As Exception
            Rollback()
            Return False
        End Try
    End Function
    Public Function DeleteAssessedFees() As Boolean
        Try
            Dim bool As Boolean = False
            Dim sql As String = ""
            sql = "DELETE FROM assessedfees WHERE enrollmentid = @0;"
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

    Public Sub ViewLocalFees(gv As DataGridView, tb As MetroTextBox)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                    & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                    & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                    & " inner join assessedfees on feesschoolyear.feessyid = assessedfees.feessyid" _
                    & " inner join enrollment on assessedfees.enrollmentid = enrollment.enrollmentid" _
                    & " where enrollment.enrollmentid = " & EnrollmentID & " and feestype = 'LOCAL FEES' ORDER BY feesname;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0
                While reader.Read()
                    If reader("required") = "Optional" Then
                        If reader("astatus") = "Yes" Then
                            gv.Rows.Add(reader("feessyid"), True, reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                            tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                        Else
                            gv.Rows.Add(reader("feessyid"), False, reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                            tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                        End If
                        gv.Rows(gv.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue
                    Else
                        gv.Rows.Add(reader("feessyid"), True, reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If
                End While
                reader.Close()
                gv.ClearSelection()
                tb.Text = 0
                For Each row As DataGridViewRow In gv.Rows
                    If row.Cells(1).Value = True Then
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(row.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ViewUniversityFees(gv As DataGridView, tb As MetroTextBox)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                     & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                     & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                     & " inner join assessedfees on feesschoolyear.feessyid = assessedfees.feessyid" _
                     & " inner join enrollment on assessedfees.enrollmentid = enrollment.enrollmentid" _
                     & " where enrollment.enrollmentid = " & EnrollmentID & " and feestype = 'UNIVERSITY FEES' ORDER BY feesname;"
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                gv.Rows.Clear()
                tb.Text = 0
                While reader.Read()
                    If reader("required") = "Optional" Then
                        gv.Rows.Add(reader("feessyid"), reader("feesname") + " (Optional)", _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), _
                                Decimal.Parse(reader("discounts")).ToString("N", CultureInfo.InvariantCulture), _
                                Decimal.Parse(reader("balance")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        gv.Rows.Add(reader("feessyid"), reader("feesname"), _
                                Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture), _
                                Decimal.Parse(reader("discounts")).ToString("N", CultureInfo.InvariantCulture), _
                                Decimal.Parse(reader("balance")).ToString("N", CultureInfo.InvariantCulture))
                        tb.Text = (Decimal.Parse(tb.Text) + Decimal.Parse(reader("amount"))).ToString("N", CultureInfo.InvariantCulture)
                    End If

                End While
                reader.Close()
                gv.ClearSelection()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewSchoolFeesForPayment(gv As DataGridView, gvid As DataGridView, btn1 As Button)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                    & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                    & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                    & " inner join assessedfees on feesschoolyear.feessyid = assessedfees.feessyid" _
                    & " inner join enrollment on assessedfees.enrollmentid = enrollment.enrollmentid" _
                    & " where enrollment.enrollmentid = " & EnrollmentID & " and astatus = 'Yes'  ORDER BY feestype,feesname ASC;"
            If IsConnected() = True Then
                gv.Rows.Clear()
                Dim py As New Payments
                Dim e As New frmPrint
                Dim sy As New SchoolYear
                e.StudentID = gvid.SelectedRows(0).Cells(0).Value
                py.StudentID = e.StudentID
                ' e.SetAssessmentDetails()
                sy.GetActiveSchoolYear()
                e.SchoolYearID = sy.SchoolYearID

                gv.Rows.Add(0, "Prev. Balance", "School Fees", _
                        Decimal.Parse(e.GetAmount()).ToString("N", CultureInfo.InvariantCulture),
                        Decimal.Parse(e.GetDiscount()).ToString("N", CultureInfo.InvariantCulture),
                        Decimal.Parse(e.GetAmount() - e.GetDiscount()).ToString("N", CultureInfo.InvariantCulture),
                        (Decimal.Parse(e.GetAmount() - e.GetDiscount()) - Decimal.Parse(e.GetBalance())).ToString("N", CultureInfo.InvariantCulture),
                        (Decimal.Parse(e.GetBalance()).ToString("N", CultureInfo.InvariantCulture) - Decimal.Parse(py.GetPayments()).ToString("N", CultureInfo.InvariantCulture)))
                Dim pd As Decimal = 0
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ' pd = Decimal.Parse(reader("amount")) - Decimal.Parse(reader("balance")).ToString("N", CultureInfo.InvariantCulture)
                    gv.Rows.Add(reader("assessedfeesid"), reader("feesname"), reader("feestype"), _
                        Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture),
                        Decimal.Parse(reader("discounts")).ToString("N", CultureInfo.InvariantCulture),
                        Decimal.Parse(reader("balance")).ToString("N", CultureInfo.InvariantCulture),
                        pd.ToString("N", CultureInfo.InvariantCulture),
                        pd.ToString("N", CultureInfo.InvariantCulture))
                End While
                reader.Close()
                gv.ClearSelection()

                Dim Paymenttrack As Decimal = py.GetPayments()
                Dim paidtrack As Decimal = 0
                Dim balancetrack As Decimal = 0
                '5 = total
                '6 = Payment
                '7 = Balance
                Dim org As Decimal = 0
                For Each r As DataGridViewRow In gv.Rows
                    '  While Paymenttrack > 0
                    org = r.Cells(5).Value
                    If Paymenttrack >= org Then
                        paidtrack = org
                        r.Cells(6).Value = paidtrack.ToString("N", CultureInfo.InvariantCulture)
                        r.Cells(7).Value = Decimal.Parse(org - paidtrack).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        paidtrack = Paymenttrack
                        r.Cells(6).Value = paidtrack.ToString("N", CultureInfo.InvariantCulture)
                        r.Cells(7).Value = Decimal.Parse(org - paidtrack).ToString("N", CultureInfo.InvariantCulture)
                    End If
                    Paymenttrack = Paymenttrack - paidtrack
                    ' End While
                    If Paymenttrack <= 0 Then
                        Exit For
                    End If
                Next
                For Each r As DataGridViewRow In gv.Rows
                    r.Cells(7).Value = Decimal.Parse(r.Cells(5).Value - r.Cells(6).Value).ToString("N", CultureInfo.InvariantCulture)
                Next
                For Each r As DataGridViewRow In gv.Rows
                    If Decimal.Parse(r.Cells(5).Value) = Decimal.Parse(r.Cells(6).Value) Then
                        r.DefaultCellStyle.ForeColor = Color.Black
                    ElseIf Decimal.Parse(r.Cells(7).Value) >= 0 Then
                        r.DefaultCellStyle.ForeColor = Color.Crimson
                    ElseIf Decimal.Parse(r.Cells(5).Value) <> Decimal.Parse(r.Cells(6).Value) Then
                        r.DefaultCellStyle.ForeColor = Color.Blue
                    End If
                Next

                Dim a As Decimal = 0
                Dim d As Decimal = 0
                Dim t As Decimal = 0
                Dim p As Decimal = 0
                Dim b As Decimal = 0
                For Each r As DataGridViewRow In gv.Rows
                    a = a + r.Cells(3).Value
                    d = d + r.Cells(4).Value
                    t = t + r.Cells(5).Value
                    p = p + r.Cells(6).Value
                    b = b + r.Cells(7).Value
                Next

                gv.Rows.Add(0, "", "Total", _
                      Decimal.Parse(a).ToString("N", CultureInfo.InvariantCulture),
                      Decimal.Parse(d).ToString("N", CultureInfo.InvariantCulture),
                      Decimal.Parse(t).ToString("N", CultureInfo.InvariantCulture),
                      (Decimal.Parse(p)).ToString("N", CultureInfo.InvariantCulture),
                      Decimal.Parse(b).ToString("N", CultureInfo.InvariantCulture))
                gv.Rows(gv.RowCount - 1).DefaultCellStyle.BackColor = Color.LightPink
                If b <> 0 Then
                    btn1.Enabled = True
                Else
                    btn1.Enabled = False
                End If
                gv.FirstDisplayedScrollingRowIndex = gv.RowCount - 1
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ViewSchoolFeesToPay(gv As DataGridView, stud As Integer)
        Try
            Dim sql As String
            sql = "select * from feesschoolyear inner join fees on feesschoolyear.feesid = fees.feesid" _
                    & " inner join schoolyear on feesschoolyear.schoolyearid = schoolyear.schoolyearid" _
                    & " inner join gradelevel on feesschoolyear.gradelevelid = gradelevel.gradelevelid" _
                    & " inner join assessedfees on feesschoolyear.feessyid = assessedfees.feessyid" _
                    & " inner join enrollment on assessedfees.enrollmentid = enrollment.enrollmentid" _
                    & " inner join student on enrollment.studentid = student.studentid where student.studentid = " & stud & " and astatus = 'Yes' and enrollment.status = 'Enrolled' ORDER BY feestype,feesname ASC;"
            If IsConnected() = True Then
                gv.Rows.Clear()
                Dim py As New Payments
                Dim e As New frmPrint
                Dim sy As New SchoolYear
                e.StudentID = stud
                ' e.SetAssessmentDetails()
                sy.GetActiveSchoolYear()
                e.SchoolYearID = sy.SchoolYearID
                py.StudentID = e.StudentID

                Dim cmd = New MySqlCommand(sql, getServerConnection)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    gv.Rows.Add(reader("assessedfeesid"), reader("feesname"), reader("feestype"), _
                        Decimal.Parse(reader("amount")).ToString("N", CultureInfo.InvariantCulture),
                        Decimal.Parse(reader("discounts")).ToString("N", CultureInfo.InvariantCulture),
                        Decimal.Parse(reader("balance")).ToString("N", CultureInfo.InvariantCulture),
                        "0.00",
                        "0.00")
                End While
                reader.Close()
                gv.ClearSelection()


                Dim Paymenttrack As Decimal = py.GetPayments()
                Dim paidtrack As Decimal = 0
                Dim balancetrack As Decimal = 0
                '5 = total
                '6 = Payment
                '7 = Balance

                For Each r As DataGridViewRow In gv.Rows
                    '  While Paymenttrack > 0
                    If Paymenttrack >= r.Cells(5).Value Then
                        paidtrack = r.Cells(5).Value
                        r.Cells(6).Value = paidtrack.ToString("N", CultureInfo.InvariantCulture)
                        r.Cells(7).Value = Decimal.Parse(r.Cells(5).Value - paidtrack).ToString("N", CultureInfo.InvariantCulture)
                    Else
                        paidtrack = Paymenttrack
                        r.Cells(6).Value = paidtrack.ToString("N", CultureInfo.InvariantCulture)
                        r.Cells(7).Value = Decimal.Parse(r.Cells(5).Value - paidtrack).ToString("N", CultureInfo.InvariantCulture)
                    End If
                    Paymenttrack = Paymenttrack - paidtrack
                    ' End While
                    If Paymenttrack <= 0 Then
                        Exit For
                    End If
                Next

                For Each r As DataGridViewRow In gv.Rows
                    r.Cells(7).Value = Decimal.Parse(r.Cells(5).Value - r.Cells(6).Value).ToString("N", CultureInfo.InvariantCulture)
                Next

                'For Each r As DataGridViewRow In gv.Rows
                '    If Decimal.Parse(r.Cells(5).Value) = Decimal.Parse(r.Cells(6).Value) Then
                '        r.DefaultCellStyle.ForeColor = Color.Crimson
                '    ElseIf Decimal.Parse(r.Cells(6).Value) <> 0 Then
                '        r.DefaultCellStyle.ForeColor = Color.Blue
                '    End If
                'Next
                For Each r As DataGridViewRow In gv.Rows
                    If Decimal.Parse(r.Cells(5).Value) = Decimal.Parse(r.Cells(6).Value) Then
                        r.DefaultCellStyle.ForeColor = Color.Black
                    ElseIf Decimal.Parse(r.Cells(7).Value) >= 0 Then
                        r.DefaultCellStyle.ForeColor = Color.Crimson
                    ElseIf Decimal.Parse(r.Cells(5).Value) <> Decimal.Parse(r.Cells(6).Value) Then
                        r.DefaultCellStyle.ForeColor = Color.Blue
                    End If
                Next


                Dim a As Decimal = 0
                Dim d As Decimal = 0
                Dim t As Decimal = 0
                Dim p As Decimal = 0
                Dim b As Decimal = 0
                For Each r As DataGridViewRow In gv.Rows
                    a = a + r.Cells(3).Value
                    d = d + r.Cells(4).Value
                    t = t + r.Cells(5).Value
                    p = p + r.Cells(6).Value
                    b = b + r.Cells(7).Value
                Next

                gv.Rows.Add(0, "", "Total", _
                      Decimal.Parse(a).ToString("N", CultureInfo.InvariantCulture),
                      Decimal.Parse(d).ToString("N", CultureInfo.InvariantCulture),
                      Decimal.Parse(t).ToString("N", CultureInfo.InvariantCulture),
                      (Decimal.Parse(p)).ToString("N", CultureInfo.InvariantCulture),
                      Decimal.Parse(b).ToString("N", CultureInfo.InvariantCulture))

                gv.Rows(gv.RowCount - 1).DefaultCellStyle.BackColor = Color.LightPink
                gv.FirstDisplayedScrollingRowIndex = gv.RowCount - 1
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
