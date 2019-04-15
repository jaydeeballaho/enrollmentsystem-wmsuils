Imports System.Windows.Forms

Public Class frmAddSchoolYear

    Private sy As New SchoolYear
    Dim status As String = "CLOSE"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtSY) = True Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Empty school year is not valid."
            warn.ShowDialog()
            txtSY.Focus()
        Else
            sy.SchoolYearInt = Integer.Parse(txtSY.Text)
            sy.SchoolYearNo = txtSY.Text + "-" + txtNextSY.Text
            sy.Status = Me.status
            If sy.AddSchoolYear() = True Then
                sy.SetSchoolYearID()
                If sy.Status = "OPEN" Then
                    sy.OpenSchoolYear(sy.SchoolYearID)
                End If
                Me.Close()
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "School Year " + sy.SchoolYearNo + " already exist."
                warn.ShowDialog()
                txtSY.Focus()
            End If
        End If
    End Sub

    Private Sub txtSY_TextChanged(sender As Object, e As EventArgs) Handles txtSY.TextChanged
        AllowedOnly(NumberOnly, txtSY)
        If txtSY.Text.Length <> 0 Then
            txtNextSY.Text = Integer.Parse(txtSY.Text + 1)
        Else
            txtNextSY.Clear()
        End If
    End Sub

    Private Sub rbClose_CheckedChanged(sender As Object, e As EventArgs) Handles rbClose.CheckedChanged
        Me.status = "CLOSE"
    End Sub

    Private Sub rbOpen_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpen.CheckedChanged
        Me.status = "OPEN"
    End Sub

    Private Sub frmAddSchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.GetActiveSchoolYear()
        txtSY.Text = sy.SchoolYearInt + 1
    End Sub
End Class
