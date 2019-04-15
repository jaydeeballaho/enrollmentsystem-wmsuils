Public Class ucManageFees

    Private fees As New Fees

    Private Sub ucManageFees_Load(sender As Object, e As EventArgs) Handles Me.Load
        fees.ViewAllFees(gvFees)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(LetterOnly, txtSearch)
        SentenceCase(txtSearch)
        fees.SearchAllFees(txtSearch.Text, gvFees)
    End Sub

    Private Sub gvFees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvFees.CellContentClick
        If gvFees.SelectedRows.Count < 1 Then
            Exit Sub
        End If
        fees.SetFeesDetails(gvFees.SelectedRows(0).Cells(0).Value)
        If e.ColumnIndex = 4 Then
            If fees.FeesType = "Local Fees" Then
                Dim obj As New frmEditLocalFee
                obj.fee = Me.fees
                obj.ShowDialog()
                fees.ViewAllFees(gvFees)
            Else
                Dim obj As New frmEditUnivFee
                obj.fee = Me.fees
                obj.ShowDialog()
                fees.ViewAllFees(gvFees)
            End If
        ElseIf e.ColumnIndex = 5 Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to delete the " + fees.FeesName + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                If fees.DeleteFees() = True Then
                    fees.ViewAllFees(gvFees)
                Else
                    Dim info As New frmWarning
                    info.lblMsg.Text = "School Fees " + fees.FeesName + " can no longer be deleted."
                    info.ShowDialog()
                End If

            End If
        End If
    End Sub

    Private Sub btnAddLocal_Click(sender As Object, e As EventArgs) Handles btnAddLocal.Click
        Dim obj As New frmAddLocalFee
        obj.ShowDialog()
        fees.ViewAllFees(gvFees)
    End Sub

    Private Sub btnAddUniv_Click(sender As Object, e As EventArgs) Handles btnAddUniv.Click
        Dim obj As New frmAddUnivFee
        obj.ShowDialog()
        fees.ViewAllFees(gvFees)
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        Dim obj As New frmManageFees
        obj.ShowDialog()
        fees.ViewAllFees(gvFees)
    End Sub
End Class
