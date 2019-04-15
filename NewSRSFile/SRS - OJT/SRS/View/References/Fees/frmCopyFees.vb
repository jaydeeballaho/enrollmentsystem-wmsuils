Imports System.Windows.Forms

Public Class frmCopyFees

    Public sy As SchoolYear
    Public gl As GradeLevel
    Private fees As New Fees
    Private psy As New SchoolYear

    Private Sub frmViewFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGradeLvl.Text = gl.GradeLevelNo
        psy.GetPreviousSchoolYear()
        psy.LoadPreviousSchoolYearToCBO(cboSY)
        fees.ViewlocalFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvLocalFees, txtTotalLocal, sy.SchoolYearID)
        fees.ViewUniversityFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvUniversityFees, txtTotalUniversity, sy.SchoolYearID)
        cboSY.SelectedIndex = cboSY.FindString(psy.SchoolYearNo)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim que As New frmQuestion
        que.lblMsg.Text = "Are you sure you want to copy the previous school year schedule of fees to current school year?"
        If que.ShowDialog() = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim local As Integer = 0
        Dim univ As Integer = 0
        For Each row As DataGridViewRow In gvLocalFees.Rows
            fees.SetFeesDetails(row.Cells(0).Value)
            If fees.IsFeesExist(fees.FeesID, gl.GradeLevelID, sy.SchoolYearID) = False Then
                fees.AddFeesToLevel(sy.SchoolYearID, gl.GradeLevelID)
                local = local + 1
            End If
        Next
        For Each row As DataGridViewRow In gvUniversityFees.Rows
            fees.SetFeesDetails(row.Cells(0).Value)
            If fees.IsFeesExist(fees.FeesID, gl.GradeLevelID, sy.SchoolYearID) = False Then
                fees.AddFeesToLevel(sy.SchoolYearID, gl.GradeLevelID)
                univ = univ + 1
            End If
        Next
        If gvLocalFees.RowCount > 0 Or gvUniversityFees.RowCount > 0 Then
            If local > 0 And univ > 0 Then
                Dim info As New frmInfo
                info.lblMsg.Text = local.ToString + " Local Fees and " + _
                     univ.ToString + " University Fees has been copied."
                info.ShowDialog()
            ElseIf local > 0 And univ = 0 Then
                Dim info As New frmInfo
                info.lblMsg.Text = local.ToString + " Local Fees has been copied."
                info.ShowDialog()
            ElseIf univ > 0 And local = 0 Then
                Dim info As New frmInfo
                info.lblMsg.Text = univ.ToString + " University Fees has been copied."
                info.ShowDialog()
            ElseIf local = 0 And univ = 0 Then
                Dim info As New frmInfo
                info.lblMsg.Text = "All " + gvLocalFees.RowCount.ToString + " Local Fees and " + _
                     gvUniversityFees.RowCount.ToString + " University Fees are already copied."
                info.ShowDialog()
            End If
        ElseIf gvLocalFees.RowCount = 0 Or gvUniversityFees.RowCount = 0 Then
            Dim info As New frmInfo
            info.lblMsg.Text = "No School Fees to be copied."
            info.ShowDialog()
        End If
        fees.ViewlocalFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvLocalFees, txtTotalLocal, sy.SchoolYearID)
        fees.ViewUniversityFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvUniversityFees, txtTotalUniversity, sy.SchoolYearID)
    End Sub

    Private Sub cboSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSY.SelectedIndexChanged
        psy.SetSchoolYearDetails(cboSY.Text)
        fees.ViewlocalFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvLocalFees, txtTotalLocal, sy.SchoolYearID)
        fees.ViewUniversityFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvUniversityFees, txtTotalUniversity, sy.SchoolYearID)
    End Sub

    Private Sub btnCopyLocal_Click(sender As Object, e As EventArgs) Handles btnCopyLocal.Click
        Dim que As New frmQuestion
        que.lblMsg.Text = "Are you sure you want to copy the previous school year local fees to current school year local fees?"
        If que.ShowDialog() = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim local As Integer = 0
        For Each row As DataGridViewRow In gvLocalFees.Rows
            fees.SetFeesDetails(row.Cells(0).Value)
            If fees.IsFeesExist(fees.FeesID, gl.GradeLevelID, sy.SchoolYearID) = False Then
                fees.AddFeesToLevel(sy.SchoolYearID, gl.GradeLevelID)
                local = local + 1
            End If
        Next
        If gvLocalFees.RowCount > 0 Then
            If local > 0 Then
                Dim info As New frmInfo
                info.lblMsg.Text = local.ToString + " Local Fees has been copied."
                info.ShowDialog()
            Else
                Dim info As New frmInfo
                info.lblMsg.Text = "All " + gvLocalFees.RowCount.ToString + " Local Fees is already copied."
                info.ShowDialog()
            End If
        Else
            Dim info As New frmInfo
            info.lblMsg.Text = "No Local Fees to be copied."
            info.ShowDialog()
        End If
        fees.ViewlocalFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvLocalFees, txtTotalLocal, sy.SchoolYearID)
        fees.ViewUniversityFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvUniversityFees, txtTotalUniversity, sy.SchoolYearID)
    End Sub

    Private Sub btnCopyUniversity_Click(sender As Object, e As EventArgs) Handles btnCopyUniversity.Click
        Dim que As New frmQuestion
        que.lblMsg.Text = "Are you sure you want to copy the previous school year university fees to current school year university fees?"
        If que.ShowDialog() = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Dim univ As Integer = 0
        For Each row As DataGridViewRow In gvUniversityFees.Rows
            fees.SetFeesDetails(row.Cells(0).Value)
            If fees.IsFeesExist(fees.FeesID, gl.GradeLevelID, sy.SchoolYearID) = False Then
                fees.AddFeesToLevel(sy.SchoolYearID, gl.GradeLevelID)
                univ = univ + 1
            End If
        Next
        If gvUniversityFees.RowCount > 0 Then
            If univ > 0 Then
                Dim info As New frmInfo
                info.lblMsg.Text = univ.ToString + " University Fees has been copied."
                info.ShowDialog()
            Else
                Dim info As New frmInfo
                info.lblMsg.Text = "All " + gvUniversityFees.RowCount.ToString + " University Fees is already copied."
                info.ShowDialog()
            End If
        Else
            Dim info As New frmInfo
            info.lblMsg.Text = "No University Fees to be copied."
            info.ShowDialog()
        End If
        fees.ViewlocalFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvLocalFees, txtTotalLocal, sy.SchoolYearID)
        fees.ViewUniversityFeesFromPSY(gl.GradeLevelID, psy.SchoolYearID, gvUniversityFees, txtTotalUniversity, sy.SchoolYearID)
    End Sub
End Class
