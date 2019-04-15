Imports System.Windows.Forms

Public Class frmSearchTeacher

    Public teacher As Teacher
    Private AllowedStr As String = " ,.abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-"
    Private keyword As String = "Name"
    Private Sub SearchUserForm_Load(sender As Object, e As EventArgs) Handles Me.Shown
        Me.txtSearch.Focus()
    End Sub
    Sub LoadSearch()
        Try
            If gvSearch.SelectedRows.Count > 0 Then
                teacher.setTeacherDetails(gvSearch.SelectedRows(0).Cells(0).Value)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'Click Event
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadSearch()
        'SET OBJECT USING LOAD F(X) IN MEMBER CLASS
    End Sub
    Private Sub gvSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSearch.CellClick
        If gvSearch.SelectedRows.Count > 0 Then
            btnLoad.Enabled = True
        Else
            btnLoad.Enabled = False
        End If
    End Sub
    'Text Changed Event
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(AllowedStr, txtSearch)
        If txtSearch.Text.Length < 3 Then
            gvSearch.Rows.Clear()
            If txtSearch.Text.Length = 1 And rdbName.Checked = True Then
                txtSearch.Text = txtSearch.Text.ToUpper.ToString
                txtSearch.Select(1, 0)
            End If
            lblNoResult.Hide()
        ElseIf txtSearch.Text.Length > 2 Then
            Search(txtSearch)
        End If
    End Sub

    'User Defined Methods
    Private Sub AllowedOnly(s As String, tb As TextBox)
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
    Private Sub Search(tb As TextBox)
        teacher.searchTeacher(keyword, keyword, tb, gvSearch)
        If gvSearch.Rows.Count = 0 Then
            lblNoResult.Show()
        Else
            lblNoResult.Hide()
            btnLoad.Enabled = False
            gvSearch.ClearSelection()
        End If
    End Sub

    'Radio Check Changed Event
    Private Sub rbName_CheckedChanged(sender As Object, e As EventArgs) Handles rdbName.CheckedChanged
        If rdbName.Checked = True Then
            Keyword = "Name"
            txtSearch.CharacterCasing = CharacterCasing.Normal
            txtSearch.Focus()
            If txtSearch.Text.Length < 3 Then
                If txtSearch.Text.Length = 1 And rdbName.Checked = True Then
                    txtSearch.Text = txtSearch.Text.ToUpper.ToString
                    txtSearch.Select(1, 0)
                End If
                lblNoResult.Hide()
            ElseIf txtSearch.Text.Length > 2 Then
                Search(txtSearch)
            End If
        End If
    End Sub
    Private Sub rbEmployeeNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNo.CheckedChanged
        If rdbNo.Checked = True Then
            Keyword = "No"
            txtSearch.CharacterCasing = CharacterCasing.Upper
            txtSearch.Focus()
            If txtSearch.Text.Length < 3 Then
                If txtSearch.Text.Length = 1 And rdbNo.Checked = True Then
                    txtSearch.Text = txtSearch.Text.ToUpper.ToString
                    txtSearch.Select(1, 0)
                End If
                lblNoResult.Hide()
            ElseIf txtSearch.Text.Length > 2 Then
                Search(txtSearch)
            End If
        End If
    End Sub

    Private Sub gvSearch_SelectionChanged(sender As Object, e As EventArgs) Handles gvSearch.SelectionChanged
        If gvSearch.SelectedRows.Count > 0 Then
            btnLoad.Enabled = True
        Else
            btnLoad.Enabled = False
        End If
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub
End Class
