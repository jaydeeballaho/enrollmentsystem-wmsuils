Public Class frmViewSchedule
    Private cs As New ClassSched
    Private sy As New SchoolYear
    Private gl As New GradeLevel
    Private sec As New Section

    Private Sub ViewSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.GetActiveSchoolYear()
        sy.LoadSchoolYearToCBO(cboSy)
        cboSy.SelectedIndex = cboSy.FindString(sy.SchoolYearNo)
        gl.LoadGradeLevelToCBO(cboLvl)
    End Sub
    Sub LoadView()
        If cboSy.SelectedItem <> vbNullString And cboLvl.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString Then
            cs.SchoolYear = sy.SchoolYearID
            cs.LVLid = gl.GradeLevelID
            cs.Sectionid = sec.SectionID
            cs.viewClassInPrint(gvClass1)
        End If
    End Sub
    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub cboSy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSy.SelectedIndexChanged
        sy.SetSchoolYearDetails(cboSy.Text)
        LoadView()
    End Sub

    Private Sub cboLvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLvl.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboLvl.Text)
        sec.GradelevelID = gl.GradeLevelID
        sec.LoadSectionToCBO(cboSection)
        LoadView()
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        sec.SetSectionDetails(cboSection.Text)
        LoadView()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmPrintReport
            Dim rpt As New ClassSchedule
            Dim dt As New DataTable

            With dt.Columns
                .Add("Subject")
                .Add("Start")
                .Add("End")
                .Add("Day")
                .Add("Room")
            End With

            For Each r As DataGridViewRow In gvClass1.Rows
                dt.Rows.Add(r.Cells(1).Value.ToString, r.Cells(2).Value.ToString, r.Cells(3).Value.ToString, _
                            r.Cells(4).Value.ToString, r.Cells(5).Value.ToString)
            Next

            rpt.SetDataSource(dt)

            rpt.SetParameterValue("Grade", cboLvl.Text + " - " + cboSection.Text)
            rpt.SetParameterValue("SchoolYear", cboSy.Text)

            With frm
                .crv.ReportSource = rpt
                .crv.Refresh()
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class