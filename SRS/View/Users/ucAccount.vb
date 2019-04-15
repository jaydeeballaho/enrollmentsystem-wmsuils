Public Class ucAccount

    Private user As New User

    Private Sub ucAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        user.ViewUser(gvUser)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(AlphaNumber, txtSearch)
        SentenceCase(txtSearch)
        user.SearchUser(txtSearch.Text, gvUser)
    End Sub

    Private Sub gvUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvUser.CellContentClick
        user.SetUserDetails(gvUser.SelectedRows(0).Cells(0).Value)
        If e.ColumnIndex = 4 Then
            Dim que As New frmQuestion
            If user.UserStatus = "Active" Then
                user.UserStatus = "Inactive"
                que.lblMsg.Text = "Are you sure you want to deactivate " + user.Username + "?"
            Else
                user.UserStatus = "Active"
                que.lblMsg.Text = "Are you sure you want to activate " + user.Username + "?"
            End If
            If que.ShowDialog() = DialogResult.Yes Then
                user.IsUserUpdated()
                user.ViewUser(gvUser)
            End If
        ElseIf e.ColumnIndex = 5 Then
            Dim obj As New frmEditUser
            obj.user = Me.user
            obj.ShowDialog()
            user.ViewUser(gvUser)
        ElseIf e.ColumnIndex = 6 Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to delete " + user.Username + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                If user.IsUserDeleted() = True Then
                    user.ViewUser(gvUser)
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = user.Username + " can no be deleted."
                    warn.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New frmAddUser
        obj.ShowDialog()
        user.ViewUser(gvUser)
    End Sub
End Class
