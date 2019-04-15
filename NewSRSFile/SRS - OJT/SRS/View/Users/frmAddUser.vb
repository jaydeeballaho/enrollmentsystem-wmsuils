Imports System.Windows.Forms

Public Class frmAddUser

    Private user As New User

    Dim addBool As Boolean = True
    Dim editBool As Boolean = False

    Private Sub txtNameFees_TextChanged(sender As Object, e As EventArgs) Handles txtFN.TextChanged
        AllowedOnly(LetterOnly, txtFN)
        SentenceCase(txtFN)
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLN.TextChanged
        AllowedOnly(LetterOnly, txtLN)
        SentenceCase(txtLN)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtFN, txtLN) = True Or cboType.SelectedItem = vbNullString Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Name and User Type are required."
            warn.ShowDialog()
        Else
            If addBool = True Then
                user.FirstName = txtFN.Text
                user.LastName = txtLN.Text
                user.Username = txtUsername.Text
                user.Password = txtPassword.Text
                user.Usertype = cboType.Text
                If user.IsUserAdded() = True Then
                    user.SetUserID()
                    Dim info As New frmInfo
                    info.lblMsg.Text = "New Account has been saved."
                    info.ShowDialog()
                    addBool = False
                    editBool = False
                    btnUpdate.Visible = True
                    DisableTextBox(txtFN, txtLN)
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Username already exist. Please retry adding."
                    warn.ShowDialog()
                End If
            ElseIf editBool = True Then
                user.FirstName = txtFN.Text
                user.LastName = txtLN.Text
                user.Username = txtUsername.Text
                user.Password = txtPassword.Text
                user.Usertype = cboType.Text
                If user.IsUserUpdated() = True Then
                    Dim info As New frmInfo
                    info.lblMsg.Text = "Updates in account has been saved."
                    info.ShowDialog()
                    btnUpdate.Visible = True
                    DisableTextBox(txtFN, txtLN)
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Username already exist. Please retry adding."
                    warn.ShowDialog()
                End If
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        editBool = True
        btnUpdate.Visible = False
        EnableTextBox(txtFN, txtLN)
        btnClose.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = user.GenerateUsername()
        txtPassword.Text = "123456"
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        AllowedOnly(AlphaNumber, txtUsername)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        AllowedOnly(AlphaNumber, txtPassword)
    End Sub
End Class
