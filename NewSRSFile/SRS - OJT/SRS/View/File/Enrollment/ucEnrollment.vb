

Public Class ucEnrollment

    Private stud As New Student
    Private def As New Defaults
    Private sy As New SchoolYear
    Private gl As New GradeLevel
    Private enroll As New Enrollment
    Private sec As New Section

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        def.GetEnrollmentStatus()
        If def.Status = "CLOSE" Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "You cannot add new student to enrollment since the enrollment is close. " _
                & "Kindly contact your system Administrator to re-open enrollment."
            warn.ShowDialog()
        Else
            Dim obj As New frmAddStudent
            If obj.ShowDialog() = DialogResult.OK Then
                enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
            End If
        End If
    End Sub

    Private Sub ucEnrollment_Load(sender As Object, e As EventArgs) Handles Me.Load
        sy.GetActiveSchoolYear()
        gl.LoadGradeLevelToCBO(cboGl)
        cboGl.Items.Add("All")
        cboGl.SelectedIndex = cboGl.FindString("All")
        cboStatus.SelectedIndex = cboStatus.FindString("All")
        lblSY.Text = sy.SchoolYearNo
        sy.LoadSchoolYearToCBO(cboSY)
        gl.LoadGradeLevelToCBO(cboGl2)
        cboSY.SelectedIndex = cboSY.FindString(sy.SchoolYearNo)
    End Sub

    Private Sub cboGl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGl.SelectedIndexChanged
        enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(LetterWSpecial, txtSearch)
        If txtSearch.Text.Length = 0 Then
            enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
        Else
            enroll.SearchEnrollee(sy.SchoolYearNo, txtSearch.Text, gvEnrolled)
            If gvEnrolled.RowCount > 0 Then

            Else
                enroll.SearchStudent(txtSearch.Text, gvEnrolled)
            End If
        End If
    End Sub

    Private Sub gvEnrolled_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvEnrolled.CellContentClick
        If e.ColumnIndex = 5 And gvEnrolled.SelectedRows(0).Cells(5).Value = "Advise" Then
            stud.SetStudentDetails(gvEnrolled.SelectedRows(0).Cells(0).Value)
            def.GetEnrollmentStatus()
            If def.Status = "CLOSE" Then
                Dim warn As New frmWarning
                warn.lblMsg.Text = "You cannot add new student to enrollment since the enrollment is close. " _
                    & "Kindly contact your system Administrator to re-open enrollment."
                warn.ShowDialog()
            Else
                Dim obj As New frmAddEnrollment
                obj.stud = Me.stud
                If obj.ShowDialog = DialogResult.OK Then
                    enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
                End If
            End If
        ElseIf e.ColumnIndex = 5 And gvEnrolled.SelectedRows(0).Cells(5).Value = "Edit" Then
            enroll.SetAssessmentDetails2(gvEnrolled.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditEnrollment
            obj.enroll = Me.enroll
            If obj.ShowDialog = DialogResult.OK Then
                enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
            End If
        ElseIf e.ColumnIndex = 5 And gvEnrolled.SelectedRows(0).Cells(5).Value = "Re-advise" Then
            enroll.SetAssessmentDetails2(gvEnrolled.SelectedRows(0).Cells(0).Value)
            Dim obj As New frmEditEnrollment
            obj.enroll = Me.enroll
            If obj.ShowDialog = DialogResult.OK Then
                enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
            End If
        ElseIf e.ColumnIndex = 5 And gvEnrolled.SelectedRows(0).Cells(5).Value = "Drop" Then
            enroll.SetAssessmentDetails2(gvEnrolled.SelectedRows(0).Cells(0).Value)
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to drop " + gvEnrolled.SelectedRows(0).Cells(1).Value + " from enrollment?"
            If que.ShowDialog() = DialogResult.Yes Then
                If enroll.DropStudent() = False Then
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Unable to drop " + gvEnrolled.SelectedRows(0).Cells(1).Value + " from enrollment."
                    warn.ShowDialog()
                Else
                    enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
                End If
            End If
        ElseIf e.ColumnIndex = 5 And gvEnrolled.SelectedRows(0).Cells(5).Value = "Re-enroll" Then
            enroll.SetAssessmentDetails2(gvEnrolled.SelectedRows(0).Cells(0).Value)
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to re-enroll " + gvEnrolled.SelectedRows(0).Cells(1).Value + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                If enroll.ReEnroll() = False Then
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Unable to re-enroll " + gvEnrolled.SelectedRows(0).Cells(1).Value + "."
                    warn.ShowDialog()
                Else
                    enroll.ViewEnrollee(sy.SchoolYearNo, cboGl.Text, "All", "All", cboStatus.Text, 2, gvEnrolled)
                End If
            End If
        End If
    End Sub
    Private Sub cboGl2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGl2.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGl2.Text)
        sec.GradelevelID = gl.GradeLevelID
        sec.LoadSectionToCBO2(cboSection)
        ViewClass()
    End Sub

    Private Sub ViewClass()
        If cboSY.SelectedItem <> vbNullString And cboGl2.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString Then
            enroll.SchoolYearID = sy.SchoolYearID
            enroll.GradeLevelID = gl.GradeLevelID
            enroll.SectionID = sec.SectionID
            enroll.ViewClass(gvReports)
            gvReports.ClearSelection()
        End If
    End Sub

    Private Sub cboSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSY.SelectedIndexChanged
        sy.SetSchoolYearDetails(cboSY.Text)
        ViewClass()
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        sec.GradelevelID = gl.GradeLevelID
        sec.SetSectionDetails(cboSection.Text)
        ViewClass()
    End Sub
    Private Sub LinkPrint_Click(sender As Object, e As EventArgs) Handles LinkPrint.Click
        Try
            If cboSY.SelectedItem <> vbNullString And cboGl2.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString Then

                Dim frm As New frmPrintReport
                Dim rpt As New rptClassList
                Dim dt As New DataTable

                With dt.Columns
                    .Add("No")
                    .Add("Name")
                    .Add("Sex")
                End With

                For Each r As DataGridViewRow In gvReports.Rows
                    dt.Rows.Add(r.Cells(1).Value.ToString, r.Cells(2).Value.ToString, r.Cells(3).Value.ToString)
                Next

                rpt.SetDataSource(dt)

                rpt.SetParameterValue("Grade", cboGl2.Text + "-" + cboSection.Text)
                rpt.SetParameterValue("SchoolYear", cboSY.Text)

                With frm
                    .crv.ReportSource = rpt
                    .crv.Refresh()
                    .ShowDialog()
                End With
            Else
                MsgBox("Please select school year, grade level and section")
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
