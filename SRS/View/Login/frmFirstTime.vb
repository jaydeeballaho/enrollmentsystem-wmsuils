Imports System.Windows.Forms

Public Class frmFirstTime

    Private user As New User

    Private Sub LinkSkip_Click(sender As Object, e As EventArgs) Handles LinkSkip.Click
        Me.Close()
    End Sub

    Private Sub EnableButton()
        If txtUsername.Text.Count > 5 And txtNewPass.Text.Count > 5 And txtConfirmPass.Text.Count > 5 Then
            btnSignin.Enabled = True
        Else
            btnSignin.Enabled = False
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
        EnableButton()
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
        EnableButton()
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
        EnableButton()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        user.SetUserDetails(frmHome.UserID)
        If txtUsername.Text.ToLower = user.FirstName.ToLower Or txtUsername.Text.ToLower = user.LastName.ToLower Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "First Name or Last Name cannot be used as username."
            warn.ShowDialog()
        ElseIf user.Username = txtUsername.Text Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Sorry, you cannot use your generated username as your new username."
            warn.ShowDialog()
        ElseIf user.IsExist(txtUsername.Text) = True Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Username already exist."
            warn.ShowDialog()
        ElseIf txtNewPass.Text <> txtConfirmPass.Text Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Your new password and confirm password did not match."
            warn.ShowDialog()
        ElseIf txtNewPass.Text = user.Password And txtConfirmPass.Text = user.Password Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Sorry, you cannot use your generated password as your new password."
            warn.ShowDialog()
        Else
            user.Username = txtUsername.Text
            user.Password = txtNewPass.Text
            user.IsUpdatedUsernameAndPassword()
            Me.Close()
        End If
    End Sub
End Class
