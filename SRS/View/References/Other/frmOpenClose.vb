Imports System.Windows.Forms

Public Class frmOpenClose

    Private def As New Defaults
    Dim status As String = ""

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        def.Status = Me.status
        If def.SetEnrollmentStatus() = True Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        def.GetEnrollmentStatus()
        If def.Status = "OPEN" Then
            Me.rbOpen.Checked = True
        Else
            Me.rbClose.Checked = True
        End If
    End Sub

    Private Sub rbOpen_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpen.CheckedChanged
        Me.status = "OPEN"
    End Sub

    Private Sub rbClose_CheckedChanged(sender As Object, e As EventArgs) Handles rbClose.CheckedChanged
        Me.status = "CLOSE"
    End Sub
End Class
