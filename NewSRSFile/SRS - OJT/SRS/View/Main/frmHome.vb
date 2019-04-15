Imports MySql.Data.MySqlClient

Public Class frmHome

    Public Shared UserID As Integer = 0
    Public Shared fullname As String = ""
    Public Shared dtServer As Date = DateTime.Now
    Public Shared flag As Integer = 0
    Public Shared status = "CLOSE"

    Private def As New Defaults
    Private sy As New SchoolYear

    Delegate Sub dlgTimerEnable(ByRef tmr As Timer, ByVal enable As Boolean)
    Private Sub TimerEnable(ByRef tmr As Timer, ByVal enable As Boolean)
        tmr.Enabled = enable
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' mainTimer.Start()
        Me.Invoke(New dlgTimerEnable(AddressOf TimerEnable), New Object() {mainTimer, True})
        Dim obj As New ucLogin
        Me.Controls.Add(obj)
        obj.BringToFront()
        obj.txtUsername.Focus()
    End Sub

    Private Sub mainTimer_Tick(sender As Object, e As EventArgs) Handles mainTimer.Tick
        Dim sql As String = "SELECT now();"
        def.GetEnrollmentStatus()
        sy.GetActiveSchoolYear()
        Try
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                dtServer = cmd.ExecuteScalar
                lblDate.Text = MonthName(dtServer.Month) + " " + dtServer.Day.ToString() + ", " + dtServer.Year.ToString()
                lblTime.Text = dtServer.ToString("hh:mm:ss tt")
                lblEnrollmentStatus.Text = def.Status
                status = def.Status
                lblSY.Text = sy.SchoolYearNo
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (flag = 0) Then
            e.Cancel = True
        Else
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to exit?"
            If que.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
                flag = 0
            End If
        End If
    End Sub

    Private Sub LinkLogout_Click(sender As Object, e As EventArgs) Handles LinkLogout.Click
        Dim que As New frmQuestion
        que.lblMsg.Text = "Are you sure you want to log-out?"
        If que.ShowDialog() = Windows.Forms.DialogResult.Yes Then
            Dim obj As New ucLogin
            Me.Controls.Add(obj)
            obj.BringToFront()
            If My.Settings.IsRemembered = True Then
                obj.txtUsername.Text = My.Settings.Loguser
                obj.chbRemember.CheckState = CheckState.Checked
                obj.txtUserpassword.Focus()
            Else
                obj.txtUsername.Focus()
            End If
            Dim user As New User
            user.IsUpdatedLogInStatus(frmHome.UserID, 0)
        End If
    End Sub

    Private Sub btnSY_Click(sender As Object, e As EventArgs) Handles btnSY.Click
        Dim uc As New ucSchoolYear
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnSY)
    End Sub

    Private Sub btnGradeLevel_Click(sender As Object, e As EventArgs) Handles btnGradeLevel.Click
        Dim uc As New ucGradeLevel
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnGradeLevel)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim uc As New ucHome
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnHome)
    End Sub

    Private Sub btnStudentRecord_Click(sender As Object, e As EventArgs) Handles btnStudentRecord.Click
        Dim obj As New frmManageStud
        obj.ShowDialog()
    End Sub

    Sub ResetButton(btn As Button)
        btnHome.Enabled = True
        btnEnrollment.Enabled = True
        btnAssessment.Enabled = True
        btnPayments.Enabled = True
        btnTeacher.Enabled = True
        btnGrading.Enabled = True
        btnSched.Enabled = True
        btnStudentRecord.Enabled = True
        btnSY.Enabled = True
        btnGradeLevel.Enabled = True
        btnSubject.Enabled = True
        btnSchoolFees.Enabled = True
        btnAccount.Enabled = True
        btnRoom.Enabled = True
        btn.Enabled = False
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim uc As New ucAccount
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnAccount)
    End Sub
    Private Sub btnSchoolFees_Click(sender As Object, e As EventArgs) Handles btnSchoolFees.Click
        Dim uc As New ucManageFees
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnSchoolFees)
    End Sub

    Private Sub btnAssessment_Click(sender As Object, e As EventArgs) Handles btnEnrollment.Click
        Dim uc As New ucEnrollment
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnEnrollment)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnAssessment.Click
        Dim obj As New frmAssessment
        obj.ShowDialog()
    End Sub

    Private Sub LinkName_Click(sender As Object, e As EventArgs) Handles LinkName.Click
        Dim obj As New frmAccount
        obj.ShowDialog()
    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim obj As New frmPayment
        obj.ShowDialog()
    End Sub

    Private Sub LinkOpenClose_Click(sender As Object, e As EventArgs) Handles LinkOpenClose.Click
        Dim obj As New frmPassword
        If obj.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim enroll As New frmOpenClose
            enroll.ShowDialog()
        End If
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        Dim uc As New ucSubject
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnSubject)
    End Sub

    Private Sub btnGrading_Click(sender As Object, e As EventArgs) Handles btnGrading.Click
        Dim obj As New frmGrades
        obj.ShowDialog()
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Dim obj As New frmTeacherForm
        obj.ShowDialog()
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        Dim uc As New ucRoom
        Me.panelWork.Controls.Clear()
        Me.panelWork.Controls.Add(uc)
        uc.BringToFront()
        ResetButton(btnRoom)
    End Sub

    Private Sub btnSched_Click(sender As Object, e As EventArgs) Handles btnSched.Click
        Dim obj As New frmSchedule
        obj.ShowDialog()
    End Sub
End Class