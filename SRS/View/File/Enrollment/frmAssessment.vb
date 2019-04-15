Imports System.Windows.Forms
Imports System.Globalization

Public Class frmAssessment

    Dim addbool As Boolean = False
    Dim editbool As Boolean = False

    Private ass As New Assessment
    Private enroll As New frmPrint
    Private fee As New Fees
    Private gl As New GradeLevel
    Private sy As New SchoolYear
    Private student As New Student

    Dim nsy As New SchoolYear
    Dim gr As New GradeLevel
    Dim ds As Integer = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim obj As New frmSearchStudent
        obj.enroll = Me.enroll
        obj.student = student
        If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtName.Text = student.Surname + ", " + student.GivenName + " " + student.MiddleName + " " + student.MiddleInitial
            txtAddress.Text = student.Street + " " + student.Barangay + ", " + student.City + " " + student.Province
            txtSex.Text = student.Sex
            txtDOB.Text = student.DOB
            'CLEAR
            rbNo.Checked = False
            rb25.Checked = False
            rb50.Checked = False
            rb75.Checked = False
            rb100.Checked = False
            txtSchoolYear.Clear()
            txtGL.Clear()
            txtAssessedDate.Clear()
            txtPrevBalance.Clear()
            txtEnrolled.Clear()
            txtDOE.Clear()
            gvLocalFees.Rows.Clear()
            gvUniv.Rows.Clear()
            txtLocal.Clear()
            txtUniv.Clear()
            txtDiscounts.Clear()
            txtAmount.Clear()
            txtDown.Clear()
            DisAble()
            '
            sy.SetSchoolYearDetailsWID(enroll.SchoolYearID)
            txtSchoolYear.Text = sy.SchoolYearNo
            gl.SetGradeLevelDetailsWID(enroll.GradeLevelID)
            txtGL.Text = gl.GradeLevelNo
            Dim pd As New Payments
            pd.StudentID = enroll.StudentID
            txtPrevBalance.Text = (enroll.GetBalance2() - pd.GetPayments()).ToString("N", CultureInfo.InvariantCulture)
            txtEnrolled.Text = enroll.Status
            If enroll.Status = "Assessed" Then
                txtAssessedDate.Text = enroll.DOA.ToShortDateString
                ass.EnrollmentID = enroll.EnrollmentID
                ass.ViewLocalFees(gvLocalFees, txtLocal)
                ass.ViewUniversityFees(gvUniv, txtUniv)
                txtDown.Text = enroll.Down.ToString()
                If enroll.Percent = 0 Then
                    rbNo.Checked = True
                ElseIf enroll.Percent = 25 Then
                    rb25.Checked = True
                ElseIf enroll.Percent = 50 Then
                    rb50.Checked = True
                ElseIf enroll.Percent = 75 Then
                    rb75.Checked = True
                ElseIf enroll.Percent = 100 Then
                    rb100.Checked = True
                End If
                txtTotal.Text = (Decimal.Parse(txtLocal.Text) + Decimal.Parse(txtUniv.Text)).ToString("N", CultureInfo.InvariantCulture)
                txtAmount.Text = (Decimal.Parse(txtLocal.Text) + (Decimal.Parse(txtUniv.Text) - _
                                                           Decimal.Parse(txtDiscounts.Text))).ToString("N", CultureInfo.InvariantCulture)
                btnEdit.Enabled = True
                btnShow.Enabled = True
                btnPrint.Enabled = True
                '    btnProm.Enabled = True
                btnAddToEnrollment.Enabled = True
            ElseIf enroll.Status = "Enrolled" Then
                txtAssessedDate.Text = enroll.DOA.ToShortDateString()
                txtDOE.Text = enroll.DOE.ToShortDateString()
                ass.EnrollmentID = enroll.EnrollmentID
                ass.ViewLocalFees(gvLocalFees, txtLocal)
                ass.ViewUniversityFees(gvUniv, txtUniv)
                txtDown.Text = enroll.Down.ToString()
                If enroll.Percent = 0 Then
                    rbNo.Checked = True
                ElseIf enroll.Percent = 25 Then
                    rb25.Checked = True
                ElseIf enroll.Percent = 50 Then
                    rb50.Checked = True
                ElseIf enroll.Percent = 75 Then
                    rb75.Checked = True
                ElseIf enroll.Percent = 100 Then
                    rb100.Checked = True
                End If
                txtTotal.Text = (Decimal.Parse(txtLocal.Text) + Decimal.Parse(txtUniv.Text)).ToString("N", CultureInfo.InvariantCulture)
                txtAmount.Text = (Decimal.Parse(txtLocal.Text) + (Decimal.Parse(txtUniv.Text) - _
                                                           Decimal.Parse(txtDiscounts.Text))).ToString("N", CultureInfo.InvariantCulture)
                btnEdit.Enabled = True
                btnShow.Enabled = True
                btnPrint.Enabled = True
                '     btnProm.Enabled = True
            ElseIf enroll.Status = "Advised" Then
                txtLocal.Text = 0
                txtUniv.Text = 0
                txtDown.Text = 0
                txtDiscounts.Text = 0
                fee.ViewLocalFees2(txtSchoolYear.Text, txtGL.Text, gvLocalFees, txtLocal)
                fee.ViewUniversityFees2(txtSchoolYear.Text, txtGL.Text, gvUniv, txtUniv)
                txtLocal.Text = 0
                For Each row As DataGridViewRow In gvLocalFees.Rows
                    If row.Cells(1).Value = True Then
                        txtLocal.Text = (Decimal.Parse(txtLocal.Text) + Decimal.Parse(row.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
                    End If
                Next
                txtTotal.Text = (Decimal.Parse(txtLocal.Text) + Decimal.Parse(txtUniv.Text)).ToString("N", CultureInfo.InvariantCulture)
                txtAmount.Text = (Decimal.Parse(txtLocal.Text) + (Decimal.Parse(txtUniv.Text) - _
                                                           Decimal.Parse(txtDiscounts.Text))).ToString("N", CultureInfo.InvariantCulture)
                btnAssess.Enabled = True
                btnShow.Enabled = True
                rbNo.Checked = True
            End If
        End If
    End Sub

    Private Sub frmAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gl.SetGradeLevelDetailsWID(enroll.GradeLevelID)
    End Sub
    Private Sub DisAble()
        rbPartial.Enabled = False
        rbFull.Enabled = False
        rbNo.Enabled = False
        rb25.Enabled = False
        rb50.Enabled = False
        rb75.Enabled = False
        rb100.Enabled = False
        gvLocalFees.Enabled = False
        btnSearch.Enabled = True
        btnAssess.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAddToEnrollment.Enabled = False
        btnShow.Enabled = False
        btnPrint.Enabled = False
        txtDown.Enabled = False
    End Sub
    Private Sub OnAction()
        rbPartial.Enabled = True
        rbFull.Enabled = True
        rbNo.Enabled = True
        rb25.Enabled = True
        rb50.Enabled = True
        rb75.Enabled = True
        rb100.Enabled = True
        rbNo.Checked = True
        rb25.Checked = False
        rb50.Checked = False
        rb75.Checked = False
        rb100.Checked = False
        rbPartial.Checked = False
        rbFull.Checked = False
        gvLocalFees.Enabled = True
        btnSearch.Enabled = False
        btnAssess.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAddToEnrollment.Enabled = False
        btnShow.Enabled = False
        btnPrint.Enabled = False
        ' btnProm.Enabled = False
        txtDown.Enabled = True
    End Sub
    Private Sub btnAssess_Click(sender As Object, e As EventArgs) Handles btnAssess.Click
        addbool = True
        editbool = False
        OnAction()
        txtDown.Enabled = True
        rbFull.Checked = True
        txtAssessedDate.Text = frmHome.dtServer.ToShortDateString()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        addbool = False
        editbool = True
        OnAction()
        txtDown.Enabled = True
        If enroll.Percent = 0 Then
            rbNo.Checked = True
        ElseIf enroll.Percent = 25 Then
            rb25.Checked = True
        ElseIf enroll.Percent = 50 Then
            rb50.Checked = True
        ElseIf enroll.Percent = 75 Then
            rb75.Checked = True
        ElseIf enroll.Percent = 100 Then
            rb100.Checked = True
        End If
        rbFull.Checked = False
        rbPartial.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtDown.Text = "" Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Invalid down payment."
            warn.ShowDialog()
        ElseIf Decimal.Parse(txtBalance.Text) < 0 Or Decimal.Parse(txtDown.Text) <= 0 Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Invalid down payment."
            warn.ShowDialog()
        Else
            If addbool = True Then
                enroll.AssessedAmount = txtAmount.Text
                enroll.Status = "Assessed"
                enroll.Percent = ds
                enroll.IsPaid = "No"
                enroll.Down = txtDown.Text
                '
                If enroll.Assess() = True Then
                    For Each r As DataGridViewRow In gvLocalFees.Rows
                        ass.EnrollmentID = enroll.EnrollmentID
                        ass.FeesSYID = r.Cells(0).Value
                        If r.Cells(1).Value = True Then
                            ass.Status = "Yes"
                            ass.Amount = r.Cells(3).Value
                            ass.Discounts = 0
                            ass.Balance = r.Cells(3).Value
                        Else
                            ass.Status = "No"
                            ass.Amount = r.Cells(3).Value
                            ass.Discounts = 0
                            ass.Balance = 0
                        End If
                        ass.AddAssessedFees()
                    Next
                    For Each r As DataGridViewRow In gvUniv.Rows
                        ass.EnrollmentID = enroll.EnrollmentID
                        ass.FeesSYID = r.Cells(0).Value
                        ass.Status = "Yes"
                        ass.Amount = r.Cells(2).Value
                        ass.Discounts = r.Cells(3).Value
                        ass.Balance = r.Cells(4).Value
                        ass.AddAssessedFees()
                    Next

                    Dim warn As New frmInfo
                    warn.lblMsg.Text = "Student Assessment has been saved."
                    warn.ShowDialog()
                    addbool = False
                    editbool = False
                    DisAble()
                    btnAddToEnrollment.Enabled = True
                    btnShow.Enabled = True
                    btnPrint.Enabled = True
                    btnEdit.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Failed to save Student Assessment."
                    warn.ShowDialog()
                End If
            ElseIf editbool = True Then
                enroll.AssessedAmount = txtAmount.Text
                enroll.Percent = ds
                enroll.Down = txtDown.Text
                '
                If enroll.EditAssessment() = True Then
                    ass.EnrollmentID = enroll.EnrollmentID
                    ass.DeleteAssessedFees()
                    For Each r As DataGridViewRow In gvLocalFees.Rows
                        ass.EnrollmentID = enroll.EnrollmentID
                        ass.FeesSYID = r.Cells(0).Value
                        If r.Cells(1).Value = True Then
                            ass.Status = "Yes"
                            ass.Amount = r.Cells(3).Value
                            ass.Discounts = 0
                            ass.Balance = r.Cells(3).Value
                        Else
                            ass.Status = "No"
                            ass.Amount = r.Cells(3).Value
                            ass.Discounts = 0
                            ass.Balance = 0
                        End If
                        ass.AddAssessedFees()
                    Next
                   For Each r As DataGridViewRow In gvUniv.Rows
                        ass.EnrollmentID = enroll.EnrollmentID
                        ass.FeesSYID = r.Cells(0).Value
                        ass.Status = "Yes"
                        ass.Amount = r.Cells(2).Value
                        ass.Discounts = r.Cells(3).Value
                        ass.Balance = r.Cells(4).Value
                        ass.AddAssessedFees()
                    Next

                    Dim warn As New frmInfo
                    warn.lblMsg.Text = "Student Re-assessment has been saved."
                    warn.ShowDialog()
                    addbool = False
                    editbool = False
                    DisAble()
                    btnShow.Enabled = True
                    btnPrint.Enabled = True
                    btnEdit.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Failed to save Student Re-assessment."
                    warn.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DisAble()
        addbool = False
        editbool = False
        If frmHome.status = "CLOSE" Then
            btnAssess.Enabled = False
        End If
    End Sub

    Private Sub gvLocalFees_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvLocalFees.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right And e.RowIndex <> -1 Then
            Dim hit As DataGridView.HitTestInfo = gvLocalFees.HitTest(e.X, e.Y)
            gvLocalFees.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnAddToEnrollment_Click(sender As Object, e As EventArgs) Handles btnAddToEnrollment.Click
        Dim que As New frmQuestion
        que.lblMsg.Text = "Are you sure you want enroll " + txtName.Text + "?"
        If que.ShowDialog = Windows.Forms.DialogResult.Yes Then
            enroll.Status = "Enrolled"
            enroll.EnrolledBy = frmHome.fullname
            If enroll.AddToEnrollment() = True Then
                If student.SchoolYear = "" Then
                    student.SchoolYear = sy.SchoolYearNo
                    student.GradeLevel = gl.GradeLevelNo
                    student.UpdateStudent()
                End If
                Dim info As New frmInfo
                info.lblMsg.Text = txtName.Text + " has been enrolled."
                info.ShowDialog()
                DisAble()
                btnPrint.Enabled = True
                btnShow.Enabled = True
                btnEdit.Enabled = True
                txtEnrolled.Text = enroll.Status
                txtDOE.Text = frmHome.dtServer.ToShortDateString
            Else
                Dim info As New frmWarning
                info.lblMsg.Text = "Enrolling " + txtName.Text + " has failed. Please try again."
                info.ShowDialog()
            End If
        End If
    End Sub

    Private Sub rb25_CheckedChanged(sender As Object, e As EventArgs) Handles rb25.CheckedChanged
        Try
            txtDiscounts.Text = (Decimal.Parse(txtUniv.Text) * 0.25).ToString("N", CultureInfo.InvariantCulture)
            ds = 25
            For Each d As DataGridViewRow In gvUniv.Rows
                d.Cells(3).Value = "0.00"
                d.Cells(4).Value = d.Cells(2).Value
            Next
            For Each r As DataGridViewRow In gvUniv.Rows
                r.Cells(3).Value = (Decimal.Parse(r.Cells(2).Value) * 0.25).ToString("N", CultureInfo.InvariantCulture)
                r.Cells(4).Value = (Decimal.Parse(r.Cells(2).Value) - Decimal.Parse(r.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rb50_CheckedChanged(sender As Object, e As EventArgs) Handles rb50.CheckedChanged
        Try
            txtDiscounts.Text = (Decimal.Parse(txtUniv.Text) * 0.5).ToString("N", CultureInfo.InvariantCulture)
            ds = 50
            For Each d As DataGridViewRow In gvUniv.Rows
                d.Cells(3).Value = "0.00"
                d.Cells(4).Value = d.Cells(2).Value
            Next
            For Each r As DataGridViewRow In gvUniv.Rows
                r.Cells(3).Value = (Decimal.Parse(r.Cells(2).Value) * 0.5).ToString("N", CultureInfo.InvariantCulture)
                r.Cells(4).Value = (Decimal.Parse(r.Cells(2).Value) - Decimal.Parse(r.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rb75_CheckedChanged(sender As Object, e As EventArgs) Handles rb75.CheckedChanged
        Try
            txtDiscounts.Text = (Decimal.Parse(txtUniv.Text) * 0.75).ToString("N", CultureInfo.InvariantCulture)
            ds = 75
            For Each d As DataGridViewRow In gvUniv.Rows
                d.Cells(3).Value = "0.00"
                d.Cells(4).Value = d.Cells(2).Value
            Next
            For Each r As DataGridViewRow In gvUniv.Rows
                r.Cells(3).Value = (Decimal.Parse(r.Cells(2).Value) * 0.75).ToString("N", CultureInfo.InvariantCulture)
                r.Cells(4).Value = (Decimal.Parse(r.Cells(2).Value) - Decimal.Parse(r.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rb100_CheckedChanged(sender As Object, e As EventArgs) Handles rb100.CheckedChanged
        Try
            txtDiscounts.Text = (Decimal.Parse(txtUniv.Text) * 1).ToString("N", CultureInfo.InvariantCulture)
            ds = 100
            For Each d As DataGridViewRow In gvUniv.Rows
                d.Cells(3).Value = "0.00"
                d.Cells(4).Value = d.Cells(2).Value
            Next
            For Each r As DataGridViewRow In gvUniv.Rows
                r.Cells(3).Value = (Decimal.Parse(r.Cells(2).Value) * 1).ToString("N", CultureInfo.InvariantCulture)
                r.Cells(4).Value = (Decimal.Parse(r.Cells(2).Value) - Decimal.Parse(r.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDiscounts_TextChanged(sender As Object, e As EventArgs) Handles txtDiscounts.TextChanged
        Try
            txtAmount.Text = (Decimal.Parse(txtLocal.Text) + (Decimal.Parse(txtUniv.Text) - _
                                                        Decimal.Parse(txtDiscounts.Text))).ToString("N", CultureInfo.InvariantCulture)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        Try
            txtDiscounts.Text = (Decimal.Parse(txtUniv.Text) * 0).ToString("N", CultureInfo.InvariantCulture)
            ds = 0
            For Each d As DataGridViewRow In gvUniv.Rows
                d.Cells(3).Value = "0.00"
                d.Cells(4).Value = d.Cells(2).Value
            Next
            For Each r As DataGridViewRow In gvUniv.Rows
                r.Cells(3).Value = (Decimal.Parse(r.Cells(2).Value) * 0).ToString("N", CultureInfo.InvariantCulture)
                r.Cells(4).Value = (Decimal.Parse(r.Cells(2).Value) - Decimal.Parse(r.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        Try
            txtBalance.Text = (Decimal.Parse(txtAmount.Text) - Decimal.Parse(txtDown.Text)).ToString("N", CultureInfo.InvariantCulture)
            txtDown.Text = (Decimal.Parse(txtAmount.Text)).ToString("N", CultureInfo.InvariantCulture)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDown_TextChanged(sender As Object, e As EventArgs) Handles txtDown.TextChanged
        Try
            If txtDown.Text.Count > 0 Then
                AllowedOnly(NumberWComma, txtDown)
                CheckforDoubleDot(txtDown)
                NumberFormat(txtDown)
                txtBalance.Text = (Decimal.Parse(txtAmount.Text) - Decimal.Parse(txtDown.Text)).ToString("N", CultureInfo.InvariantCulture)
            Else
                txtBalance.Text = Decimal.Parse(txtAmount.Text).ToString("N", CultureInfo.InvariantCulture)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rbPartial_CheckedChanged(sender As Object, e As EventArgs) Handles rbPartial.CheckedChanged
        Try
            txtDown.Text = (Decimal.Parse(txtAmount.Text) * 0.5).ToString("N", CultureInfo.InvariantCulture)
            txtDown.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbFull_CheckedChanged(sender As Object, e As EventArgs) Handles rbFull.CheckedChanged
        Try
            txtDown.Text = (Decimal.Parse(txtAmount.Text) * 1).ToString("N", CultureInfo.InvariantCulture)
            txtDown.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvLocalFees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvLocalFees.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim f As New Fees
            f.GetFeesType(gvLocalFees.SelectedRows(0).Cells(0).Value)
            If f.Required = "Optional" Then
                If gvLocalFees.SelectedRows(0).Cells(1).Value = True Then
                    gvLocalFees.SelectedRows(0).Cells(1).Value = False
                Else
                    gvLocalFees.SelectedRows(0).Cells(1).Value = True
                End If
            End If
            txtLocal.Text = 0
            For Each row As DataGridViewRow In gvLocalFees.Rows
                If row.Cells(1).Value = True Then
                    txtLocal.Text = (Decimal.Parse(txtLocal.Text) + Decimal.Parse(row.Cells(3).Value)).ToString("N", CultureInfo.InvariantCulture)
                End If
            Next
            txtTotal.Text = (Decimal.Parse(txtLocal.Text) + Decimal.Parse(txtUniv.Text)).ToString("N", CultureInfo.InvariantCulture)
            txtAmount.Text = (Decimal.Parse(txtLocal.Text) + (Decimal.Parse(txtUniv.Text) - _
                                                              Decimal.Parse(txtDiscounts.Text))).ToString("N", CultureInfo.InvariantCulture)
        End If
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim obj As New frmViewAccounts
        obj.student = Me.student
        obj.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmPrintReport
            Dim rpt As New rptAssess
            Dim dt As New DataTable

            With dt.Columns
                .Add("Description")
                .Add("Amount")
                .Add("Discount")
                .Add("Total")
            End With

            For Each r As DataGridViewRow In gvLocalFees.Rows
                If r.Cells(1).Value = True Then
                    dt.Rows.Add(r.Cells(2).Value.ToString, r.Cells(3).Value.ToString, "0.00", r.Cells(3).Value.ToString)
                End If
            Next
            For Each r As DataGridViewRow In gvUniv.Rows
                dt.Rows.Add(r.Cells(1).Value.ToString, r.Cells(2).Value.ToString, r.Cells(3).Value.ToString, r.Cells(4).Value.ToString)
            Next
            dt.Rows.Add("", "", "Assessed Amount", txtAmount.Text)
            dt.Rows.Add("", "", "First Payment", txtDown.Text)
            rpt.SetDataSource(dt)

            rpt.SetParameterValue("Name", txtName.Text)
            rpt.SetParameterValue("GradeSec", txtGL.Text)
            rpt.SetParameterValue("SchoolYear", txtSchoolYear.Text)

            With frm
                .crv.ReportSource = rpt
                .crv.Refresh()
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
