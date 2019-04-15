Imports MetroFramework
Public Class ucConnection

    Public Login As ucLogin

    Private Sub LinkBack_Click(sender As Object, e As EventArgs) Handles LinkBack.Click
        Me.Login.txtUserpassword.Enabled = True
        Me.Login.txtUsername.Enabled = True
        Me.Login.chbRemember.Enabled = True
        Me.Login.EnableButton()
        Me.Login.panelSetting.Controls.Remove(Me)
    End Sub
    Private Sub btnTestCon_Click(sender As Object, e As EventArgs) Handles btnTestCon.Click
        Dim TestStr As String = "server=" & txtServer.Text & ";port=" & txtPort.Text _
                                               & ";database=" & txtDatabaseName.Text & ";user=" & txtUsername.Text _
                                               & ";password=" & txtPassword.Text
        If TestConnection(TestStr) = True Then
            Dim question As New frmQuestion
            question.lblMsg.Text = "You have successfully established a connection. Do you want save the connection?"
            If question.ShowDialog() = DialogResult.Yes Then
                My.Settings.ServerIP = txtServer.Text
                My.Settings.PortNo = txtPort.Text
                My.Settings.DatabaseName = txtDatabaseName.Text
                My.Settings.Username = txtUsername.Text
                My.Settings.Password = txtPassword.Text
                My.Settings.Save()
            End If
        Else
            Dim err As New frmError
            err.lblMsg.Text = "Unable to connect to specified server. " + vbCrLf + "Please review connection fields."
            err.ShowDialog()
        End If
    End Sub
    Private Sub txtServer_TextChanged(sender As Object, e As EventArgs) Handles txtServer.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-.", txtServer)
    End Sub
    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged
        AllowedOnly(NumberOnly, txtPort)
    End Sub
    Private Sub txtDatabaseName_TextChanged(sender As Object, e As EventArgs) Handles txtDatabaseName.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-._", txtDatabaseName)
    End Sub
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtPassword)
    End Sub
End Class
