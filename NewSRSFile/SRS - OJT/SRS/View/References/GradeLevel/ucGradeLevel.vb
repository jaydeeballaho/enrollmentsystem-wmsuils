Public Class ucGradeLevel

    Private gl As New GradeLevel

    Private Sub ucGradeLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gl.ViewGradeLevel(gvGL)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New frmAddGradeLevel
        obj.ShowDialog()
        gl.ViewGradeLevel(gvGL)
    End Sub

    Private Sub gvGL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvGL.CellContentClick
        gl.SetGradeLevelDetailsWID(gvGL.SelectedRows(0).Cells(0).Value)
        If e.ColumnIndex = 2 Then
            Dim obj As New frmEditGradeLevel
            obj.gl = Me.gl
            obj.ShowDialog()
            gl.ViewGradeLevel(gvGL)
        ElseIf e.ColumnIndex = 3 Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to delete the Grade Level " + gl.GradeLevelNo + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                If gl.DeleteGradeLevel() = True Then
                    gl.ViewGradeLevel(gvGL)
                Else
                    Dim info As New frmWarning
                    info.lblMsg.Text = "Grade Level " + gl.GradeLevelNo + " can no longer be deleted."
                    info.ShowDialog()
                End If

            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(AlphaNumber, txtSearch)
        SentenceCase(txtSearch)
        gl.SearchGradeLevel(txtSearch.Text, gvGL)
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        Dim obj As New frmSection
        obj.ShowDialog()
    End Sub
End Class
