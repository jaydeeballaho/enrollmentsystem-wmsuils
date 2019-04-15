Imports System.Windows.Forms

Public Class frmSection

    Private gl As New GradeLevel
    Private sec As New Section

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmGradeLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gl.LoadGradeLevelToCBO(cboGl)
        If cboGl.Items.Count > 0 Then
            cboGl.SelectedIndex = 0
        End If
    End Sub

    Private Sub gvGradeLevel_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvGradeLevel.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right And e.RowIndex <> -1 Then
            Dim hit As DataGridView.HitTestInfo = gvGradeLevel.HitTest(e.X, e.Y)
            gvGradeLevel.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        sec.SetSectionDetailsWID(gvGradeLevel.SelectedRows(0).Cells(0).Value)
        If MessageBox.Show("Are you sure you want to remove the selected section?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
            = Windows.Forms.DialogResult.Yes Then
            sec.DeleteSection()
            sec.ViewSection(gvGradeLevel, cmGL)
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If cboGl.SelectedItem = vbNullString Then
            MessageBox.Show("Please select grade level?", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim obj As New frmAddSection
            obj.gl = Me.gl
            obj.sec = Me.sec
            sec.GradelevelID = gl.GradeLevelID
            obj.ShowDialog()
            sec.ViewSection(gvGradeLevel, cmGL)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        sec.SetSectionDetailsWID(gvGradeLevel.SelectedRows(0).Cells(0).Value)
        Dim obj As New frmEditSection
        obj.gl = Me.gl
        obj.sec = Me.sec
        sec.GradelevelID = gl.GradeLevelID
        obj.ShowDialog()
        sec.ViewSection(gvGradeLevel, cmGL)
    End Sub

    Private Sub cboGl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGl.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGl.Text)
        sec.GradelevelID = gl.GradeLevelID
        sec.ViewSection(gvGradeLevel, cmGL)
    End Sub
End Class
