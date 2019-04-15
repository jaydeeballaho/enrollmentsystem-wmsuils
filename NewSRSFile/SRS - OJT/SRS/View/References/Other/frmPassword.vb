Imports System.Windows.Forms

Public Class frmPassword

    Private user As New User

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If user.IsPasswordForAdministrator(frmHome.UserID, txtPassword.Text) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Invalid Administrator Password. Please try again."
            warn.ShowDialog()
        End If
    End Sub
    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtPassword.Focus()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtPassword)
        If txtPassword.Text.Length > 0 Then
            btnOK.Enabled = True
        Else
            btnOK.Enabled = False
        End If
    End Sub
End Class
