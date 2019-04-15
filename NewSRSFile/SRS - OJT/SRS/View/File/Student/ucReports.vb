Public Class ucReports

    Private sy As New SchoolYear
    Private gl As New GradeLevel
    Private enroll As New Enrollment
    Private sec As New Section

    Private Sub ucReports_Load(sender As Object, e As EventArgs) Handles Me.Load
        sy.LoadSchoolYearToCBO(cboSY)
        gl.LoadGradeLevelToCBO(cboGl)
        sy.GetActiveSchoolYear()
        cboSY.SelectedIndex = cboSY.FindString(sy.SchoolYearNo)
    End Sub

    Private Sub cboGl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGl.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGl.Text)
        sec.GradelevelID = gl.GradeLevelID
        sec.LoadSectionToCBO2(cboSection)
        ViewClass()
    End Sub

    Private Sub ViewClass()
        If cboSY.SelectedItem <> vbNullString And cboGl.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString Then
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
End Class
