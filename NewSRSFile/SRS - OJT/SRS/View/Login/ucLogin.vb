Public Class ucLogin

    Private userobj As New User

    Private Sub LinkSetting_Click(sender As Object, e As EventArgs) Handles LinkSetting.Click
        Dim obj As New ucConnection
        obj.Login = Me
        Me.txtUserpassword.Enabled = False
        Me.txtUsername.Enabled = False
        Me.btnSignin.Enabled = False
        Me.chbRemember.Enabled = False
        Me.panelSetting.Controls.Add(obj)
        obj.BringToFront()
    End Sub

    'User Defined Methods
    
    Public Sub EnableButton()
        If txtUserpassword.Text.Count > 0 And txtUsername.Text.LongCount > 0 Then
            btnSignin.Enabled = True
        Else
            btnSignin.Enabled = False
        End If
    End Sub
    Private Sub SetUP()
        If userobj.Usertype = "Administrator" Then
            frmHome.btnEnrollment.Visible = True
            frmHome.btnEnrollment.Location = New Point(20, 63)
            frmHome.btnAssessment.Visible = True
            frmHome.btnAssessment.Location = New Point(20, 103)
            frmHome.btnPayments.Visible = True
            frmHome.btnPayments.Location = New Point(20, 143)
            frmHome.btnStudentRecord.Visible = True
            frmHome.btnStudentRecord.Location = New Point(20, 183)
            frmHome.btnTeacher.Visible = True
            frmHome.btnTeacher.Location = New Point(20, 223)
            frmHome.btnGrading.Visible = True
            frmHome.btnGrading.Location = New Point(20, 263)
            frmHome.btnSched.Visible = True
            frmHome.btnSched.Location = New Point(20, 303)
            frmHome.btnSY.Visible = True
            frmHome.btnSY.Location = New Point(20, 343)
            frmHome.btnGradeLevel.Visible = True
            frmHome.btnGradeLevel.Location = New Point(20, 383)
            frmHome.btnSubject.Visible = True
            frmHome.btnSubject.Location = New Point(20, 423)
            frmHome.btnSchoolFees.Visible = True
            frmHome.btnSchoolFees.Location = New Point(20, 463)
            frmHome.btnRoom.Visible = True
            frmHome.btnRoom.Location = New Point(20, 503)
            frmHome.btnAccount.Visible = True
            frmHome.btnAccount.Location = New Point(20, 543)
            ' frmHome.btnHelp.Visible = False
            frmHome.LinkOpenClose.Visible = True
            frmHome.LinkName.Text = userobj.FirstName.ToUpper()
            frmHome.mainTimer.Start()
        ElseIf userobj.Usertype = "Adviser" Then
            frmHome.btnEnrollment.Visible = True
            frmHome.btnEnrollment.Location = New Point(20, 63)
            frmHome.btnAssessment.Visible = False
            frmHome.btnAssessment.Location = New Point(20, 103)
            frmHome.btnPayments.Visible = False
            frmHome.btnPayments.Location = New Point(20, 143)
            frmHome.btnStudentRecord.Visible = True
            frmHome.btnStudentRecord.Location = New Point(20, 103)
            frmHome.btnTeacher.Visible = False
            frmHome.btnTeacher.Location = New Point(20, 223)
            frmHome.btnGrading.Visible = True
            frmHome.btnGrading.Location = New Point(20, 143)
            frmHome.btnSched.Visible = False
            frmHome.btnSched.Location = New Point(20, 303)
            frmHome.btnSY.Visible = False
            frmHome.btnSY.Location = New Point(20, 343)
            frmHome.btnGradeLevel.Visible = False
            frmHome.btnGradeLevel.Location = New Point(20, 383)
            frmHome.btnSubject.Visible = False
            frmHome.btnSubject.Location = New Point(20, 423)
            frmHome.btnSchoolFees.Visible = False
            frmHome.btnSchoolFees.Location = New Point(20, 463)
            frmHome.btnRoom.Visible = False
            frmHome.btnRoom.Location = New Point(20, 503)
            frmHome.btnAccount.Visible = False
            frmHome.btnAccount.Location = New Point(20, 543)
            ' frmHome.btnHelp.Visible = True
            '  frmHome.btnHelp.Location = New Point(20, 183)
            frmHome.LinkOpenClose.Visible = False
            frmHome.LinkName.Text = userobj.FirstName.ToUpper()
            frmHome.mainTimer.Start()
        ElseIf userobj.Usertype = "Cashier" Then
            frmHome.btnEnrollment.Visible = False
            frmHome.btnEnrollment.Location = New Point(20, 63)
            frmHome.btnAssessment.Visible = False
            frmHome.btnAssessment.Location = New Point(20, 103)
            frmHome.btnPayments.Visible = True
            frmHome.btnPayments.Location = New Point(20, 63)
            frmHome.btnStudentRecord.Visible = False
            frmHome.btnStudentRecord.Location = New Point(20, 183)
            frmHome.btnTeacher.Visible = False
            frmHome.btnTeacher.Location = New Point(20, 223)
            frmHome.btnGrading.Visible = False
            frmHome.btnGrading.Location = New Point(20, 263)
            frmHome.btnSched.Visible = False
            frmHome.btnSched.Location = New Point(20, 303)
            frmHome.btnSY.Visible = False
            frmHome.btnSY.Location = New Point(20, 343)
            frmHome.btnGradeLevel.Visible = False
            frmHome.btnGradeLevel.Location = New Point(20, 383)
            frmHome.btnSubject.Visible = False
            frmHome.btnSubject.Location = New Point(20, 423)
            frmHome.btnSchoolFees.Visible = False
            frmHome.btnSchoolFees.Location = New Point(20, 463)
            frmHome.btnRoom.Visible = False
            frmHome.btnRoom.Location = New Point(20, 503)
            frmHome.btnAccount.Visible = False
            frmHome.btnAccount.Location = New Point(20, 543)
            ' frmHome.btnHelp.Visible = True
            'frmHome.btnHelp.Location = New Point(20, 103)
            frmHome.LinkOpenClose.Visible = False
            frmHome.LinkName.Text = userobj.FirstName.ToUpper()
            frmHome.mainTimer.Start()
        ElseIf userobj.Usertype = "Assessor" Then
            frmHome.btnEnrollment.Visible = False
            frmHome.btnEnrollment.Location = New Point(20, 63)
            frmHome.btnAssessment.Visible = True
            frmHome.btnAssessment.Location = New Point(20, 63)
            frmHome.btnPayments.Visible = False
            frmHome.btnPayments.Location = New Point(20, 63)
            frmHome.btnStudentRecord.Visible = False
            frmHome.btnStudentRecord.Location = New Point(20, 183)
            frmHome.btnTeacher.Visible = False
            frmHome.btnTeacher.Location = New Point(20, 223)
            frmHome.btnGrading.Visible = False
            frmHome.btnGrading.Location = New Point(20, 263)
            frmHome.btnSched.Visible = False
            frmHome.btnSched.Location = New Point(20, 303)
            frmHome.btnSY.Visible = False
            frmHome.btnSY.Location = New Point(20, 343)
            frmHome.btnGradeLevel.Visible = False
            frmHome.btnGradeLevel.Location = New Point(20, 383)
            frmHome.btnSubject.Visible = False
            frmHome.btnSubject.Location = New Point(20, 423)
            frmHome.btnSchoolFees.Visible = False
            frmHome.btnSchoolFees.Location = New Point(20, 463)
            frmHome.btnRoom.Visible = False
            frmHome.btnRoom.Location = New Point(20, 503)
            frmHome.btnAccount.Visible = False
            frmHome.btnAccount.Location = New Point(20, 543)
            '   frmHome.btnHelp.Visible = True
            ' frmHome.btnHelp.Location = New Point(20, 103)
            frmHome.LinkOpenClose.Visible = False
            frmHome.LinkName.Text = userobj.FirstName.ToUpper()
            frmHome.mainTimer.Start()
        End If
    End Sub
    'Text Changed Events
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUsername)
        EnableButton()
    End Sub
    Private Sub txtUserpassword_TextChanged(sender As Object, e As EventArgs) Handles txtUserpassword.TextChanged
        AllowedOnly("ñabcdefghijklmnopqrstuvwxyzÑ1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ_", txtUserpassword)
        EnableButton()
    End Sub

    'Click Events
    Public Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Try
            If UserObj.IsAccessGranted(txtUsername.Text, txtUserpassword.Text) = True Then
                If UserObj.IsActive(UserObj.UserID) = True Then
                    If UserObj.IsLogout(UserObj.UserID) = True Then
                        frmHome.UserID = userobj.UserID
                        userobj.SetUserDetails(frmHome.UserID)
                        frmHome.fullname = userobj.FirstName + " " + userobj.LastName
                        If userobj.IsUpdatedLogInStatus(userobj.UserID, 1) = True Then
                            If chbRemember.Checked = False Then
                                txtUsername.Clear()
                                txtUserpassword.Clear()
                                txtUsername.Focus()
                                My.Settings.IsRemembered = False
                                My.Settings.Loguser = ""
                                My.Settings.Save()
                            Else
                                My.Settings.IsRemembered = True
                                My.Settings.Loguser = txtUsername.Text
                                My.Settings.Save()
                                txtUserpassword.Clear()
                                txtUserpassword.Focus()
                            End If
                            frmHome.LinkName.Text = userobj.FirstName.ToUpper()
                            If userobj.IsFirstTime(userobj.UserID) = True Then
                                Dim ft As New frmFirstTime
                                ft.ShowDialog()
                                userobj.IsUpdatedFirstTime(userobj.UserID, 0)
                                SetUP()
                            Else
                                SetUP()
                            End If
                            frmHome.Controls.Remove(Me)
                            frmHome.btnHome.Enabled = True
                            frmHome.btnHome.PerformClick()
                            '
                        Else
                            Dim warn As New frmWarning
                            warn.lblMsg.Text = "There is a problem occured while trying to log you in. Please try again."
                            warn.ShowDialog()
                        End If
                    Else
                        Dim warn As New frmWarning
                        warn.lblMsg.Text = "Your account is already log-in from another device."
                        warn.ShowDialog()
                        Me.txtUsername.Focus()
                    End If
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Your account is no longer active."
                    warn.ShowDialog()
                    Me.txtUsername.Focus()
                End If
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Invalid username/password. Please try again."
                warn.ShowDialog()
                Me.txtUsername.Focus()
            End If
        Catch ex As Exception
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Log-in Failed."
            warn.ShowDialog()
        End Try

    End Sub

    ' Mouse Down and Mouse Up Events
    Private Sub txtUserpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnSignin.PerformClick()
        End If
    End Sub

    Private Sub LinkClose_Click(sender As Object, e As EventArgs) Handles LinkClose.Click
        frmHome.flag = 1
        frmHome.Close()
    End Sub

    Private Sub LinkMinimize_Click(sender As Object, e As EventArgs) Handles LinkMinimize.Click
        frmHome.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ucLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmHome.mainTimer.Stop()
        If My.Settings.IsRemembered = True Then
            txtUsername.Text = My.Settings.Loguser
            chbRemember.CheckState = CheckState.Checked
            txtUserpassword.Focus()
        Else
            txtUsername.Focus()
        End If
    End Sub
End Class
