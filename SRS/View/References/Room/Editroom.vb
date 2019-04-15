
Public Class EditRoom

    Public room As Room
    Dim msg As String = ""
    Dim str As String = " abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-."
    Dim noOnly As String = "1234567890"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If ValidateRoom() = True And ValidateBldg() = True And ValidateCapacity() = True Then
                With room
                    .RoomNo = txtRoomNo.Text
                    .RoomBldg = txtBldgName.Text
                    .Capacity = txtCapacity.Text
                    If .EditRoom = True Then
                        MessageBox.Show("Room has been successfully updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        'Dim err As ErrorMessage
                        'err = New ErrorMessage
                        'err.lblMsg.Text = "Something went wrong when trying to edit room. Please try again."
                        'err.ShowDialog()

                    End If
                End With
            Else
                'Dim err As ErrorMessage
                'err = New ErrorMessage
                'err.lblMsg.Text = msg
                'err.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function ValidateRoom() As Boolean
        If txtRoomNo.Text = room.RoomNo Then
            msg = ""
            Return True
        ElseIf txtRoomNo.Text.Trim = "" Then
            MessageBox.Show("Please check required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf room.IsRoomNoExist(txtRoomNo.Text) = True Then
            msg = "This Room Number is already in used."
            Return False
        Else
            msg = ""
            Return True
        End If
    End Function
    Private Function ValidateBldg() As Boolean
        If txtBldgName.Text.Trim = "" Then
            MessageBox.Show("Please check required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            msg = ""
            Return True
        End If
    End Function
    Private Function ValidateCapacity() As Boolean
        If txtCapacity.Text.Trim = "" Then
            MessageBox.Show("Please check required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Integer.Parse(txtCapacity.Text) < 1 Then
            MessageBox.Show("Invalid Capacity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            msg = ""
            Return True
        End If
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub AllowedOnly(s As String, tb As TextBox)
        Try
            Dim theText As String = tb.Text
            Dim Letter As String
            Dim SelectionIndex As Integer = tb.SelectionStart
            Dim Change As Integer
            For x As Integer = 0 To tb.Text.Length - 1
                Letter = tb.Text.Substring(x, 1)
                If s.Contains(Letter) = False Then
                    theText = theText.Replace(Letter, String.Empty)
                    Change = 1
                End If
            Next
            tb.Text = theText
            tb.Select(SelectionIndex - Change, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtRoomNo_TextChanged(sender As Object, e As EventArgs) Handles txtRoomNo.TextChanged
        AllowedOnly(str, txtRoomNo)
    End Sub
    Private Sub txtBldgName_TextChanged(sender As Object, e As EventArgs) Handles txtBldgName.TextChanged
        AllowedOnly(str, txtBldgName)
    End Sub

    Private Sub txtCapacity_TextChanged(sender As Object, e As EventArgs) Handles txtCapacity.TextChanged
        AllowedOnly(noOnly, txtCapacity)
    End Sub

    Private Sub EditRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRoomNo.Text = room.RoomNo
        txtBldgName.Text = room.RoomBldg
        txtCapacity.Text = room.Capacity
    End Sub
End Class
