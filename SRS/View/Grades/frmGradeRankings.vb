Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmGradeRankings

    Private sy As New SchoolYear
    Private gl As New GradeLevel
    Private sec As New Section
    Private subj As New Subject
    Private stud As New Student
    Private enr As New frmPrint

    Dim i As Integer = 0

    Private Sub frmGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.LoadSchoolYearToCBO(cboSY)
        sy.GetActiveSchoolYear()
        cboSY.SelectedIndex = cboSY.FindString(sy.SchoolYearNo)
        gl.LoadGradeLevelToCBO(cboGL)
    End Sub

    Private Sub cboGL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGL.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGL.Text)
        sec.GradelevelID = gl.GradeLevelID
        sec.LoadSectionToCBO(cboSection)
        subj.GradelevelID = gl.GradeLevelID
        LoadRank()
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        subj.GradelevelID = gl.GradeLevelID
        sec.SetSectionDetails(cboSection.Text)
        LoadRank()
    End Sub

    Private Sub cboSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSY.SelectedIndexChanged
        sy.SetSchoolYearDetails(cboSY.Text)
        LoadRank()
    End Sub
    Private Sub LoadRank()
        If cboSY.SelectedItem <> vbNullString And cboGL.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString _
           And cboRate.SelectedItem <> vbNullString Then
            enr.SchoolYearID = sy.SchoolYearID
            enr.GradeLevelID = gl.GradeLevelID
            enr.SectionID = sec.SectionID
            enr.ViewEnrollee3(gvStudent)
            For Each r As DataGridViewRow In gvStudent.Rows
                Dim y As New frmPrint
                r.Cells(5).Value = y.GetRank1(r.Cells(0).Value, rank)
            Next
            gvStudent.Sort(final, System.ComponentModel.ListSortDirection.Descending)
            'For Each r As DataGridViewRow In gvStudent.Rows
            '    If r.Cells(12).Value.ToString = "Failed" Then
            '        r.DefaultCellStyle.ForeColor = Color.Crimson
            '    End If
            'Next
            gvStudent.ClearSelection()
        End If
    End Sub
    Dim rank As Integer = 0
    Private Sub cboRate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRate.SelectedIndexChanged
        rank = cboRate.SelectedIndex
        LoadRank()
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub btbPrint_Click(sender As Object, e As EventArgs) Handles btbPrint.Click
        'Try
        '    Dim frm As New frmPrintReport
        '    Dim rpt As New TeacherSchedule
        '    Dim dt As New DataTable

        '    With dt.Columns
        '        .Add("No")
        '        .Add("Name")
        '        .Add("Grade")
        '    End With

        '    For Each r As DataGridViewRow In gvStudent.Rows
        '        dt.Rows.Add(r.Cells(1).Value.ToString, r.Cells(5).Value.ToString)
        '    Next

        '    rpt.SetDataSource(dt)

        '    rpt.SetParameterValue("Grade", "")
        '    rpt.SetParameterValue("Subject", "")
        '    rpt.SetParameterValue("SchoolYear", sy.SchoolYearNo)

        '    With frm
        '        .crv.ReportSource = rpt
        '        .crv.Refresh()
        '        .ShowDialog()
        '    End With
        'Catch ex As Exception

        'End Try
        MsgBox("Wala pa!")
    End Sub
End Class
