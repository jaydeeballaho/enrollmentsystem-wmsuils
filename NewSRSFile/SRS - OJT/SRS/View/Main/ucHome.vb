Public Class ucHome

    Private user As New User
    Private def As New Defaults

    Private Sub ucHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        def.GetEnrollmentStatus()
        lblName.Text = def.Principal
        user.SetUserDetails(frmHome.UserID)
        If user.Usertype = "Administrator" Then
            LinkName.Visible = True
        Else
            LinkName.Visible = False
        End If
    End Sub

End Class
