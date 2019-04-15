Public Class ucSubject

    Private gl As New GradeLevel
    Private subj As New Subject

    Private Sub ucGradeLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gl.LoadGradeLevelToCBO(cboGl)
        Try
            cboGl.SelectedIndex = 0
            subj.GradelevelID = gl.GradeLevelID
            subj.ViewSubject(gvSubject)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboGl.SelectedItem = vbNullString Then
            Dim que As New frmInfo
            que.lblMsg.Text = "Kindly select Grade Level first."
        Else
            Dim obj As New frmAddSubject
            obj.gl = Me.gl
            obj.subj = Me.subj
            subj.GradelevelID = gl.GradeLevelID
            obj.ShowDialog()
            subj.ViewSubject(gvSubject)
        End If
    End Sub

    Private Sub gvGL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSubject.CellContentClick
        subj.SetSubjectDetailsWID(gvSubject.SelectedRows(0).Cells(0).Value)
        If e.ColumnIndex = 4 Then
            Dim obj As New frmEditSubject
            obj.gl = Me.gl
            obj.subj = Me.subj
            subj.GradelevelID = gl.GradeLevelID
            obj.ShowDialog()
            subj.ViewSubject(gvSubject)
        ElseIf e.ColumnIndex = 5 Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to delete the Subject " + subj.SubjectName + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                If subj.DeleteSubject() = True Then
                    subj.ViewSubject(gvSubject)
                Else
                    Dim info As New frmWarning
                    info.lblMsg.Text = "Subeject " + subj.SubjectName + " can no longer be deleted."
                    info.ShowDialog()
                End If

            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(AlphaNumber, txtSearch)
        SentenceCase(txtSearch)
        subj.SearchSubject(txtSearch.Text, gvSubject)
    End Sub

    Private Sub cboGl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGl.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGl.Text)
        subj.GradelevelID = gl.GradeLevelID
        subj.ViewSubject(gvSubject)
    End Sub
End Class
