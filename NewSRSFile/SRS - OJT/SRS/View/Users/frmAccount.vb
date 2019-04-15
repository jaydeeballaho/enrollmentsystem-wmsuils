
Public Class frmAccount

    Private user As New User

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user.SetUserDetails(frmHome.UserID)
        lblName.Text = user.FirstName.ToUpper + " " + user.LastName.ToUpper
        lblType.Text = user.Usertype.ToUpper
        txtUsername.Text = user.Username
        txtNewPass.Text = user.Password
        txtConfirmPass.Clear()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        If btnSignin.Text = "Update" Then
            txtNewPass.Enabled = True
            txtUsername.Enabled = True
            txtConfirmPass.Visible = True
            btnSignin.Text = "Save"
        ElseIf btnSignin.Text = "Save" Then
            If txtUsername.Text.Count < 6 Or txtNewPass.Text.Count < 6 Then
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Username and password should be atleast 6 characters long."
                warn.ShowDialog()
            ElseIf txtUsername.Text.ToLower = user.FirstName.ToLower Or txtUsername.Text.ToLower = user.LastName.ToLower Then
                Dim warn As New frmWarning
                warn.lblMsg.Text = "First Name or Last Name cannot be used as username."
                warn.ShowDialog()
            ElseIf user.Username <> txtUsername.Text And user.IsExist(txtUsername.Text) = True Then
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Username already exist."
                warn.ShowDialog()
            ElseIf txtNewPass.Text <> txtConfirmPass.Text Then
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Your new password and confirm password did not match."
                warn.ShowDialog()
            Else
                Dim warn As New frmInfo
                warn.lblMsg.Text = "Username and password has been updated."
                warn.ShowDialog()
                txtNewPass.Enabled = False
                txtUsername.Enabled = False
                txtConfirmPass.Visible = False
                btnSignin.Text = "Update"
                user.Username = txtUsername.Text
                user.Password = txtNewPass.Text
                user.IsUpdatedUsernameAndPassword()
            End If
        End If

    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
    End Sub

    Private Sub txtNewPass_TextChanged(sender As Object, e As EventArgs) Handles txtNewPass.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
    End Sub

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub
End Class
