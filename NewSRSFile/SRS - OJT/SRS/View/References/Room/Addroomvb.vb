Imports System.Text

Public Class AddRoom

    Private room As New Room
    Dim msg As String = ""
    Dim str As String = " abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-."
    Dim noOnly As String = "1234567890"
    Private LetterOnly As String = " .abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If ValidateRoom() = True And ValidateBldg() = True And ValidateCapacity() = True Then
                With room
                    .RoomNo = txtRoomNo.Text
                    .RoomBldg = txtBldgName.Text
                    .Capacity = txtCapacity.Text
                    If .AddRoom = True Then
                        MessageBox.Show("Room has been successfully saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else

                    End If
                End With
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function ValidateRoom() As Boolean
        If txtRoomNo.Text.Trim = "" Then
            MessageBox.Show("Please check required field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf room.IsRoomNoExist(txtRoomNo.Text) = True Then
            MessageBox.Show("Room number already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

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
            MessageBox.Show("Invalid Capacity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtRoomNo.SelectionStart
        selectionLength = txtRoomNo.SelectionLength

        txtRoomNo.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtRoomNo.Text)


        ' restore the cursor position and text selection
        txtRoomNo.SelectionStart = startPos
        txtRoomNo.SelectionLength = selectionLength
        
    
    End Sub
    Private Sub txtBldgName_TextChanged(sender As Object, e As EventArgs) Handles txtBldgName.TextChanged
        AllowedOnly(str, txtBldgName)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtBldgName.SelectionStart
        selectionLength = txtBldgName.SelectionLength

        txtBldgName.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtBldgName.Text)


        ' restore the cursor position and text selection
        txtBldgName.SelectionStart = startPos
        txtBldgName.SelectionLength = selectionLength

    End Sub

    Private Sub txtCapacity_TextChanged(sender As Object, e As EventArgs) Handles txtCapacity.TextChanged
        AllowedOnly(noOnly, txtCapacity)
    End Sub

    Private Sub AddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
