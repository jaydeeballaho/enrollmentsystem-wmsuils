Imports System.Windows.Forms
Imports System.Globalization

Public Class frmAddEnrollment

    Dim addBool As Boolean = True
    Dim editBool As Boolean = False

    Public stud As Student
    Private sec As New Section
    Private sy As New SchoolYear
    Private gl As New GradeLevel
    Private enroll As New frmPrint
    Private subj As New Subject
    Private sched As New ClassSched

    Dim flag As Integer = 0

    Private Sub frmAddEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.GetActiveSchoolYear()
        txtSurname.Text = stud.GivenName + " " + stud.MiddleName + " " + stud.Surname
        txtSY.Text = sy.SchoolYearNo
        gl.LoadGradeLevelToCBO(cboGradeLvl)
        enroll.StudentID = stud.StudentID
        enroll.SchoolYearID = sy.SchoolYearID
        Dim pd As New Payments
        pd.StudentID = enroll.StudentID
        txtBalance.Text = (enroll.GetBalance2() - pd.GetPayments()).ToString("N", CultureInfo.InvariantCulture)
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
        subj.GradelevelID = gl.GradeLevelID
        '   subj.ViewSubject(gvSubject)
        ViewClass()
    End Sub

    Private Sub ViewClass()
        If cboGradeLvl.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString Then
            sched.SchoolYear = sy.SchoolYearID
            sched.LVLid = gl.GradeLevelID
            sched.Sectionid = sec.SectionID
            sched.ViewClassesForAdvising(gvClass1)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        editBool = True
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
        Else
            If addBool = True Then
                enroll.StudentID = stud.StudentID
                enroll.SchoolYearID = sy.SchoolYearID
                enroll.SectionID = sec.SectionID
                enroll.GradeLevelID = gl.GradeLevelID
                enroll.Status = "Advised"
                If enroll.AddStudent() = True Then
                    enroll.SetEnrollmentID()
                    'For Each r As DataGridViewRow In gvSubject.Rows
                    '    Dim g As New Grades
                    '    g.EnrollmentID = enroll.EnrollmentID
                    '    g.Subject = r.Cells(0).Value
                    '    g.AddGrade()
                    'Next
                    Dim info As New frmInfo
                    info.lblMsg.Text = "Student Advising has been saved."
                    info.ShowDialog()
                    addBool = False
                    editBool = False
                    btnUpdate.Visible = True
                    cboGradeLvl.Enabled = False
                    cboSection.Enabled = False
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                    flag = 1
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Unable to save Student Advising."
                    warn.ShowDialog()
                End If
            ElseIf editBool = True Then
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
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Unable to save updates in Student Advising."
                    warn.ShowDialog()
                End If
            End If

        End If
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        sec.GradelevelID = gl.GradeLevelID
        sec.SetSectionDetails(cboSection.Text)
        ViewClass()
    End Sub
End Class
