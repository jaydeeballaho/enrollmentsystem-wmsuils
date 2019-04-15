Imports System.Windows.Forms

Public Class frmManageFees

    Private fees As New Fees
    Private sy As New SchoolYear
    Private gl As New GradeLevel

    Private Sub fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gl.LoadGradeLevelToCBO(cboGradeLvl)
        sy.GetActiveSchoolYear()
        txtSY.Text = sy.SchoolYearNo
        cboGradeLvl.SelectedIndex = 0
    End Sub

    Private Sub cboGradeLvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGradeLvl.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGradeLvl.Text)
        fees.ViewLocalFees(txtSY.Text, cboGradeLvl.Text, gvLocalFees, txtTotalLocal)
        fees.ViewUniversityFees(txtSY.Text, cboGradeLvl.Text, gvUniversityFees, txtTotalUniversity)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddUniversity.Click
        If cboGradeLvl.SelectedItem <> vbNullString Then
            Dim obj As New frmBrowseUniv
            obj.sy = Me.sy
            obj.gl = Me.gl
            obj.ShowDialog()
            fees.ViewLocalFees(txtSY.Text, cboGradeLvl.Text, gvLocalFees, txtTotalLocal)
            fees.ViewUniversityFees(txtSY.Text, cboGradeLvl.Text, gvUniversityFees, txtTotalUniversity)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If cboGradeLvl.SelectedItem <> vbNullString Then
            Dim obj As New frmCopyFees
            obj.sy = Me.sy
            obj.gl = Me.gl
            obj.ShowDialog()
            fees.ViewLocalFees(txtSY.Text, cboGradeLvl.Text, gvLocalFees, txtTotalLocal)
            fees.ViewUniversityFees(txtSY.Text, cboGradeLvl.Text, gvUniversityFees, txtTotalUniversity)
        End If
    End Sub

    Private Sub gvUniversityFees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvUniversityFees.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to remove the " + gvUniversityFees.SelectedRows(0).Cells(1).Value + " from Grade Level " + gl.GradeLevelNo + _
                " of School Year " + sy.SchoolYearNo + "?"
            If que.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                If fees.RemoveFees(gvUniversityFees.SelectedRows(0).Cells(0).Value) = True Then
                    fees.ViewUniversityFees(txtSY.Text, cboGradeLvl.Text, gvUniversityFees, txtTotalUniversity)
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Can not remove " + gvUniversityFees.SelectedRows(0).Cells(1).Value + " from Grade Level " + gl.GradeLevelNo + _
                                        " of School Year " + sy.SchoolYearNo + "?"
                    warn.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub gvLocalFees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvLocalFees.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to remove the " + gvLocalFees.SelectedRows(0).Cells(1).Value + " from Grade Level " + gl.GradeLevelNo + _
                " of School Year " + sy.SchoolYearNo + "?"
            If que.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                If fees.RemoveFees((gvLocalFees.SelectedRows(0).Cells(0).Value)) = True Then
                    fees.ViewLocalFees(txtSY.Text, cboGradeLvl.Text, gvLocalFees, txtTotalLocal)
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Can not remove " + gvLocalFees.SelectedRows(0).Cells(1).Value + " from Grade Level " + gl.GradeLevelNo + _
                                        " of School Year " + sy.SchoolYearNo + "?"
                    warn.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub btnAddLocal_Click(sender As Object, e As EventArgs) Handles btnAddLocal.Click
        If cboGradeLvl.SelectedItem <> vbNullString Then
            Dim obj As New frmBrowseLocal
            obj.sy = Me.sy
            obj.gl = Me.gl
            obj.ShowDialog()
            fees.ViewLocalFees(txtSY.Text, cboGradeLvl.Text, gvLocalFees, txtTotalLocal)
            fees.ViewUniversityFees(txtSY.Text, cboGradeLvl.Text, gvUniversityFees, txtTotalUniversity)
        End If
    End Sub
End Class
