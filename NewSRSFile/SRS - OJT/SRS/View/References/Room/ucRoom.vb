Public Class ucRoom

    Private room As New Room
   
    Private Sub ucGradeLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            room.viewRoom(gvRoom)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gvRoom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvRoom.CellContentClick
        room.setRoomDetails(gvRoom.SelectedRows(0).Cells(0).Value)
        If e.ColumnIndex = 4 Then
            Dim obj As New EditRoom
            obj.room = Me.room
            If obj.ShowDialog = DialogResult.OK Then
                room.viewRoom(gvRoom)
            End If
        ElseIf e.ColumnIndex = 5 Then
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to delete the Room " + room.RoomNo + "?"
            If que.ShowDialog() = DialogResult.Yes Then
                If room.DeleteRoom() = True Then
                    room.viewRoom(gvRoom)
                Else
                    Dim info As New frmWarning
                    info.lblMsg.Text = "Room " + room.RoomNo + " can no longer be deleted."
                    info.ShowDialog()
                End If

            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(AlphaNumber, txtSearch)
        SentenceCase(txtSearch)
        room.searchRoom(gvRoom, txtSearch.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New AddRoom
        If obj.ShowDialog() = DialogResult.OK Then
            room.viewRoom(gvRoom)
        End If
    End Sub
End Class
