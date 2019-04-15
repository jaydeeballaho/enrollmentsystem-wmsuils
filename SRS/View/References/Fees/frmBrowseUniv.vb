Imports System.Windows.Forms

Public Class frmBrowseUniv

    Public sy As SchoolYear
    Public gl As GradeLevel
    Private fees As New Fees

    Private Sub frmViewFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fees.ViewUniversityToAdd(gl.GradeLevelID, sy.SchoolYearID, gvUnivFees)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For Each row As DataGridViewRow In gvUnivFees.Rows
            If row.Cells(1).Value = True Then
                fees.SetFeesDetails(row.Cells(0).Value)
                fees.AddFeesToLevel(sy.SchoolYearID, gl.GradeLevelID)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub cbAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbAll.CheckedChanged
        If cbAll.Checked = True Then
            For Each row As DataGridViewRow In gvUnivFees.Rows
                row.Cells(1).Value = True
            Next
        Else
            For Each row As DataGridViewRow In gvUnivFees.Rows
                row.Cells(1).Value = False
            Next
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim obj As New frmAddUnivFee
        obj.ShowDialog()
        fees.ViewUniversityToAdd(gl.GradeLevelID, sy.SchoolYearID, gvUnivFees)
    End Sub
End Class
