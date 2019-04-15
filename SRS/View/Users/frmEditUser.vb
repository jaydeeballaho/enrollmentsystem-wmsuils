Imports System.Windows.Forms

Public Class frmEditUser

    Public user As User

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
            user.FirstName = txtFN.Text
            user.LastName = txtLN.Text
            user.Username = txtUsername.Text
            user.Password = txtPassword.Text
            user.Usertype = cboType.Text
            If user.IsUserUpdated() = True Then
                Dim info As New frmInfo
                info.lblMsg.Text = "Updates in Account has been saved."
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
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnUpdate.Visible = False
        EnableTextBox(txtFN, txtLN)
        btnClose.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = user.Username
        txtPassword.Text = user.Password
        txtFN.Text = user.FirstName
        txtLN.Text = user.LastName
        cboType.SelectedIndex = cboType.FindString(user.Usertype)
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        AllowedOnly(AlphaNumber, txtUsername)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        AllowedOnly(AlphaNumber, txtPassword)
    End Sub
End Class
