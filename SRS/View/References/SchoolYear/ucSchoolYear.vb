Public Class ucSchoolYear

    Private sy As New SchoolYear
    Private Sub ucSchoolYear_Load(sender As Object, e As EventArgs) Handles Me.Load
        sy.ViewSchoolYear(gvSY)
    End Sub
    Private Sub txtSY_TextChanged(sender As Object, e As EventArgs) Handles txtSY.TextChanged
        AllowedOnly(NumberOnly, txtSY)
        sy.SearchSchoolYear(txtSY.Text, gvSY)
    End Sub

    Private Sub gvSY_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSY.CellContentClick
        sy.SetSchoolYearDetailsWID(gvSY.SelectedRows(0).Cells(0).Value)
        If e.ColumnIndex = 3 And gvSY.SelectedRows(0).Cells(3).Value.ToString = "Open" Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to activate the School Year " + sy.SchoolYearNo + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                sy.OpenSchoolYear(sy.SchoolYearID)
                sy.ViewSchoolYear(gvSY)
            End If
        ElseIf e.ColumnIndex = 4 And gvSY.SelectedRows(0).Cells(4).Value.ToString = "Edit" Then
            Dim obj As New frmEditSchoolYear
            obj.sy = Me.sy
            obj.ShowDialog()
            sy.ViewSchoolYear(gvSY)
        ElseIf e.ColumnIndex = 5 And gvSY.SelectedRows(0).Cells(5).Value.ToString = "Delete" Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to delete the School Year " + sy.SchoolYearNo + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                If sy.DeleteSchoolYear() = True Then
                    sy.ViewSchoolYear(gvSY)
                Else
                    Dim info As New frmWarning
                    info.lblMsg.Text = "School Year " + sy.SchoolYearNo + " can no longer be deleted."
                    info.ShowDialog()
                End If

            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New frmAddSchoolYear
        obj.ShowDialog()
        sy.ViewSchoolYear(gvSY)
    End Sub
End Class
