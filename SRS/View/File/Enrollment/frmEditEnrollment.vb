Imports System.Windows.Forms
Imports System.Globalization

Public Class frmEditEnrollment

    Private asd As New Assessment
    Private stud As New Student
    Private sy As New SchoolYear
    Private gl As New GradeLevel
    Public enroll As frmPrint
    Private sec As New Section
    Private sched As New ClassSched

    Dim flag As Integer = 0

    Private Sub ViewClass()
        If cboGradeLvl.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString Then
            sched.SchoolYear = sy.SchoolYearID
            sched.LVLid = gl.GradeLevelID
            sched.Sectionid = sec.SectionID
            sched.ViewClassesForAdvising(gvClass1)
        End If
    End Sub

    Private Sub frmAddEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        asd.EnrollmentID = enroll.EnrollmentID
        sy.SetSchoolYearDetailsWID(enroll.SchoolYearID)
        stud.SetStudentDetails(enroll.StudentID)
        txtSurname.Text = stud.GivenName + " " + stud.MiddleName + " " + stud.Surname
        txtSY.Text = sy.SchoolYearNo
        gl.SetGradeLevelDetailsWID(enroll.GradeLevelID)
        gl.LoadGradeLevelToCBO(cboGradeLvl)
        cboGradeLvl.SelectedIndex = cboGradeLvl.FindString(gl.GradeLevelNo)
        Dim pd As New Payments
        pd.StudentID = enroll.StudentID
        txtBalance.Text = (enroll.GetBalance2() - pd.GetPayments()).ToString("N", CultureInfo.InvariantCulture)
        sec.SetSectionDetailsWID(enroll.SectionID)
        cboSection.SelectedIndex = cboSection.FindString(sec.SectionNo)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If flag = 1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Me.Close()
    End Sub

    Private Sub cboGradeLvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGradeLvl.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGradeLvl.Text)
        sec.GradelevelID = gl.GradeLevelID
        sec.LoadSectionToCBO2(cboSection)
        ViewClass()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnUpdate.Visible = False
        cboGradeLvl.Enabled = True
        cboSection.Enabled = True
        btnClose.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboGradeLvl.SelectedItem = vbNullString Or cboSection.SelectedItem = vbNullString Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Please select Grade Level and Section."
            warn.ShowDialog()
        ElseIf enroll.GradeLevelID = gl.GradeLevelID And enroll.SectionID = sec.SectionID And enroll.Status = "Advised" Then
            Dim info As New frmInfo
            info.lblMsg.Text = "No changes in Student Advising."
            info.ShowDialog()
            btnUpdate.Visible = True
            cboGradeLvl.Enabled = False
            cboSection.Enabled = False
            btnClose.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        ElseIf enroll.GradeLevelID = gl.GradeLevelID And enroll.SectionID <> sec.SectionID And enroll.Status = "Advised" Then
            enroll.SectionID = sec.SectionID
            If enroll.EditStudent() = True Then
                Dim info As New frmInfo
                info.lblMsg.Text = "Updates in Student Advising has been saved."
                info.ShowDialog()
                btnUpdate.Visible = True
                cboGradeLvl.Enabled = False
                cboSection.Enabled = False
                btnClose.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                flag = 1
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Unable to save updates in Student Advising."
                warn.ShowDialog()
            End If
        ElseIf enroll.GradeLevelID <> gl.GradeLevelID And enroll.SectionID <> sec.SectionID And enroll.Status = "Advised" Then
            enroll.GradeLevelID = gl.GradeLevelID
            enroll.SectionID = sec.SectionID
            If enroll.EditStudent() = True Then
                'Dim g As New Grades
                'g.EnrollmentID = enroll.EnrollmentID
                'g.DeleteGrade()
                'For Each r As DataGridViewRow In gvSubject.Rows
                '    g.EnrollmentID = enroll.EnrollmentID
                '    g.Subject = r.Cells(0).Value
                '    g.AddGrade()
                'Next
                Dim info As New frmInfo
                info.lblMsg.Text = "Updates in Student Advising has been saved."
                info.ShowDialog()
                btnUpdate.Visible = True
                cboGradeLvl.Enabled = False
                cboSection.Enabled = False
                btnClose.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                flag = 1
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Unable to save updates in Student Advising."
                warn.ShowDialog()
            End If
        ElseIf enroll.GradeLevelID <> gl.GradeLevelID And enroll.SectionID <> sec.SectionID And enroll.Status = "Assessed" Then
            enroll.GradeLevelID = gl.GradeLevelID
            enroll.SectionID = sec.SectionID
            enroll.Status = "Advised"
            If enroll.EditStudent() = True Then
                'Dim g As New Grades
                'g.EnrollmentID = enroll.EnrollmentID
                'g.DeleteGrade()
                'For Each r As DataGridViewRow In gvSubject.Rows
                '    g.EnrollmentID = enroll.EnrollmentID
                '    g.Subject = r.Cells(0).Value
                '    g.AddGrade()
                'Next
                Dim info As New frmWarning
                info.lblMsg.Text = "Updates in Student Advising has been saved. Student needs to be re-assess."
                asd.EnrollmentID = enroll.EnrollmentID
                asd.DeleteAssessedFees()
                info.ShowDialog()
                btnUpdate.Visible = True
                cboGradeLvl.Enabled = False
                cboSection.Enabled = False
                btnClose.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                flag = 1
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Unable to save updates in Student Advising."
                warn.ShowDialog()
            End If
        ElseIf enroll.GradeLevelID = gl.GradeLevelID And enroll.SectionID = sec.SectionID And enroll.Status = "Assessed" Then
            Dim info As New frmInfo
            info.lblMsg.Text = "No changes in Student Advising."
            info.ShowDialog()
            btnUpdate.Visible = True
            cboGradeLvl.Enabled = False
            cboSection.Enabled = False
            btnClose.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        ElseIf enroll.GradeLevelID = gl.GradeLevelID And enroll.SectionID <> sec.SectionID And enroll.Status = "Assessed" Then
            enroll.SectionID = sec.SectionID
            If enroll.EditStudent() = True Then
                Dim info As New frmWarning
                info.lblMsg.Text = "Updates in Student Advising has been saved."
                info.ShowDialog()
                btnUpdate.Visible = True
                cboGradeLvl.Enabled = False
                cboSection.Enabled = False
                btnClose.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                flag = 1
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Unable to save updates in Student Advising."
                warn.ShowDialog()
            End If
        ElseIf enroll.GradeLevelID <> gl.GradeLevelID And enroll.SectionID <> sec.SectionID And enroll.Status = "Enrolled" Then
            enroll.GradeLevelID = gl.GradeLevelID
            enroll.SectionID = sec.SectionID
            enroll.Status = "Advised"
            If enroll.EditStudent() = True Then
                'Dim g As New Grades
                'g.EnrollmentID = enroll.EnrollmentID
                'g.DeleteGrade()
                'For Each r As DataGridViewRow In gvSubject.Rows
                '    g.EnrollmentID = enroll.EnrollmentID
                '    g.Subject = r.Cells(0).Value
                '    g.AddGrade()
                'Next
                Dim info As New frmWarning
                info.lblMsg.Text = "Updates in Student Advising has been saved. Student needs to be re-assess."
                asd.EnrollmentID = enroll.EnrollmentID
                asd.DeleteAssessedFees()
                info.ShowDialog()
                btnUpdate.Visible = True
                cboGradeLvl.Enabled = False
                cboSection.Enabled = False
                btnClose.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                flag = 1
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Unable to save updates in Student Advising."
                warn.ShowDialog()
            End If
        ElseIf enroll.GradeLevelID = gl.GradeLevelID And enroll.SectionID = sec.SectionID And enroll.Status = "Enrolled" Then
            Dim info As New frmInfo
            info.lblMsg.Text = "No changes in Student Advising."
            info.ShowDialog()
            btnUpdate.Visible = True
            cboGradeLvl.Enabled = False
            cboSection.Enabled = False
            btnClose.Enabled = True
            btnSave.Enabled = False
            btnUpdate.Enabled = True
        ElseIf enroll.GradeLevelID = gl.GradeLevelID And enroll.SectionID <> sec.SectionID And enroll.Status = "Enrolled" Then
            enroll.SectionID = sec.SectionID
            If enroll.EditStudent() = True Then
                Dim info As New frmWarning
                info.lblMsg.Text = "Updates in Student Advising has been saved."
                info.ShowDialog()
                btnUpdate.Visible = True
                cboGradeLvl.Enabled = False
                cboSection.Enabled = False
                btnClose.Enabled = True
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                flag = 1
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Unable to save updates in Student Advising."
                warn.ShowDialog()
            End If
        End If
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        sec.GradelevelID = gl.GradeLevelID
        sec.SetSectionDetails(cboSection.Text)
        ViewClass()
    End Sub
End Class
