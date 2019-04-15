Imports MySql.Data.MySqlClient
Public Class frmSchedule

    Private gr As New GradeLevel
    Private section As New Section
    Private room As New Room
    Private subject As New Subject
    Private classsched As New ClassSched
    Private sy As New SchoolYear

    Private Sub cboSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSub.SelectedIndexChanged
        subject.GradelevelID = gr.GradeLevelID
        subject.SetSubjectDetails(cboSub.Text)
    End Sub

    Private Sub cboRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoom.SelectedIndexChanged
        room.setRoomDetails2(cboRoom.Text)
    End Sub

    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        room.loadRoomToCBO(cboRoom)
        gr.LoadGradeLevelToCBO(cboLvl)
        sy.GetActiveSchoolYear()
        txtSchoolYr.Text = sy.SchoolYearNo
        classsched.SchoolYear = sy.SchoolYearID
        classsched.viewClassSched(gvClass, ContextMenuStrip1)
    End Sub

    Private Sub cboLvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLvl.SelectedIndexChanged
        gr.SetGradeLevelDetails(cboLvl.Text)
        section.GradelevelID = gr.GradeLevelID
        section.LoadSectionToCBO(cboSection)
        subject.GradelevelID = gr.GradeLevelID
        subject.LoadSubjectToCBO(cboSub)
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        section.GradelevelID = gr.GradeLevelID
        section.SetSectionDetails(cboSection.Text)
    End Sub
    Function ValidateSubject() As Boolean
        Dim bool As Boolean = False
        Dim x As Integer = 0
        For Each r As DataGridViewRow In gvClass.Rows
            If r.Cells(1).Value = cboLvl.Text And r.Cells(2).Value = cboSection.Text _
                And r.Cells(3).Value = cboSub.Text And r.Cells(4).Value = cboDay.Text Then
                x = x + 1
            ElseIf r.Cells(1).Value = cboLvl.Text And r.Cells(2).Value = cboSection.Text _
            And r.Cells(3).Value = cboSub.Text And cboDay.Text = "Everyday" Then
                x = x + 1
            End If
        Next
        If x = 0 Then
            bool = True
        End If
        Return bool
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            '6
            Dim i As Integer = 0
            For Each r As DataGridViewRow In gvClass.Rows
                If DateTime.Parse(cboStart.Text) < DateTime.Parse(r.Cells(6).Value.ToString) And _
                    DateTime.Parse(cboStart.Text) >= DateTime.Parse(r.Cells(5).Value.ToString) Then
                    If cboDay.Text = "Everyday" Then
                        If cboRoom.Text = r.Cells(7).Value.ToString Then
                            r.DefaultCellStyle.ForeColor = Color.Crimson
                            i = i + 1
                        Else
                            r.DefaultCellStyle.ForeColor = Color.Black
                        End If
                    ElseIf r.Cells(4).Value.ToString() = "Everyday" Then
                        If cboRoom.Text = r.Cells(7).Value.ToString Then
                            r.DefaultCellStyle.ForeColor = Color.Crimson
                            i = i + 1
                        Else
                            r.DefaultCellStyle.ForeColor = Color.Black
                        End If
                    ElseIf cboDay.Text = r.Cells(4).Value.ToString() Then
                        r.DefaultCellStyle.ForeColor = Color.Crimson
                        i = i + 1
                    Else
                        r.DefaultCellStyle.ForeColor = Color.Black
                    End If
                ElseIf DateTime.Parse(r.Cells(5).Value.ToString) < DateTime.Parse(txtEndTime.Text) And _
                DateTime.Parse(r.Cells(5).Value.ToString) >= DateTime.Parse(cboStart.Text) Then
                    If cboDay.Text = "Everyday" Then
                        If cboRoom.Text = r.Cells(7).Value.ToString Then
                            r.DefaultCellStyle.ForeColor = Color.Crimson
                            i = i + 1
                        Else
                            r.DefaultCellStyle.ForeColor = Color.Black
                        End If
                    ElseIf r.Cells(4).Value.ToString() = "Everyday" Then
                        If cboRoom.Text = r.Cells(7).Value.ToString Then
                            r.DefaultCellStyle.ForeColor = Color.Crimson
                            i = i + 1
                        Else
                            r.DefaultCellStyle.ForeColor = Color.Black
                        End If
                    ElseIf cboDay.Text = r.Cells(4).Value.ToString() Then
                        r.DefaultCellStyle.ForeColor = Color.Crimson
                        i = i + 1
                    Else
                        r.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Else
                    r.DefaultCellStyle.ForeColor = Color.Black
                End If
            Next
            If i > 0 Then
                lblMsg.Text = "Conflict in Time/Day/Room"
                lblMsg.Show()
                gvClass.ClearSelection()
                Exit Sub
            Else
                lblMsg.Hide()
                For Each r As DataGridViewRow In gvClass.Rows
                    r.DefaultCellStyle.ForeColor = Color.Black
                Next
            End If

            If btnSave.Text = "SAVE" Then
                With classsched
                    .LVLid = gr.GradeLevelID
                    .Sectionid = section.SectionID
                    .Subjectid = subject.SubjectID
                    .StartTime = cboStart.Text
                    .EndTime = txtEndTime.Text
                    .Day = cboDay.Text
                    .Roomid = room.RoomID
                    .SchoolYear = sy.SchoolYearID
                    If .AddClass() = True Then
                        MessageBox.Show("New class has been successfully saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '  cboLvl.SelectedIndex = -1
                        ' cboSection.SelectedIndex = -1
                        cboSub.SelectedIndex = -1
                        cboStart.SelectedIndex = -1
                        txtEndTime.Clear()
                        cboDay.SelectedIndex = -1
                        'cboRoom.SelectedIndex = -1

                    Else
                        'Dim err As ErrorMessage
                        'err = New ErrorMessage
                        'err.lblMsg.Text = "Something went wrong when tryin g to add new room. Please try again."
                        'err.ShowDialog()

                    End If

                End With
            ElseIf btnSave.Text = "UPDATE" Then
                btnSave.Text = "SAVE"
                With classsched
                    .LVLid = gr.GradeLevelID
                    .Sectionid = section.SectionID
                    .Subjectid = subject.SubjectID
                    .StartTime = cboStart.Text
                    .EndTime = txtEndTime.Text
                    .Day = cboDay.Text
                    .Roomid = room.RoomID
                    .SchoolYear = sy.SchoolYearID
                    If .EditClass() = True Then
                        MessageBox.Show("New class has been successfully updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '   cboLvl.SelectedIndex = -1
                        '   cboSection.SelectedIndex = -1
                        cboSub.SelectedIndex = -1
                        cboStart.SelectedIndex = -1
                        txtEndTime.Clear()
                        cboDay.SelectedIndex = -1
                        'cboRoom.SelectedIndex = -1

                    Else
                        'Dim err As ErrorMessage
                        'err = New ErrorMessage
                        'err.lblMsg.Text = "Something went wrong when tryin g to add new room. Please try again."
                        'err.ShowDialog()

                    End If

                End With
            End If
        Catch ex As Exception

        End Try
        classsched.viewClassSched(gvClass, ContextMenuStrip1)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        btnSave.Text = "UPDATE"
        classsched.setClassDetails(gvClass.SelectedRows(0).Cells(0).Value)
        cboLvl.SelectedIndex = cboLvl.FindString(gvClass.SelectedRows(0).Cells(1).Value)
        cboSection.SelectedIndex = cboSection.FindString(gvClass.SelectedRows(0).Cells(2).Value)
        cboSub.SelectedIndex = cboSub.FindString(gvClass.SelectedRows(0).Cells(3).Value)
        cboDay.SelectedIndex = cboDay.FindString(gvClass.SelectedRows(0).Cells(4).Value)
        cboStart.SelectedIndex = cboStart.FindString(gvClass.SelectedRows(0).Cells(5).Value)
        txtEndTime.Text = gvClass.SelectedRows(0).Cells(6).Value.ToString

        cboRoom.SelectedIndex = cboRoom.FindString(gvClass.SelectedRows(0).Cells(7).Value)
        gvClass.Rows.RemoveAt(gvClass.SelectedRows(0).Index)

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        classsched.setClassDetails(gvClass.SelectedRows(0).Cells(0).Value)
        If MessageBox.Show("Do you want to delete the selected schedule?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            classsched.DeleteClass()
            classsched.viewClassSched(gvClass, ContextMenuStrip1)

        End If
    End Sub

    Private Sub cboStart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStart.SelectedIndexChanged
        txtEndTime.Text = DateAdd(DateInterval.Minute, subject.SubjectTime, Date.Parse(cboStart.Text)).ToString("hh:mm tt")
    End Sub

    Private Function TimeConflict(d As Date, int As Integer) As Boolean
        MsgBox(DateDiff(DateInterval.Minute, Date.Parse(cboStart.Text), d))
        If DateDiff(DateInterval.Minute, Date.Parse(cboStart.Text), d) >= int Then
            Return True
        Else
            Return False
        End If
        Return True
    End Function
    Private Function TimeConflict2(d As Date, int As Integer) As Boolean
        If DateDiff(DateInterval.Minute, d, Date.Parse(cboStart.Text)) >= int Then
            Return True
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        classsched.viewClassSched(gvClass, ContextMenuStrip1)
        cboLvl.SelectedIndex = -1
        cboSub.SelectedIndex = -1
        cboSection.SelectedIndex = -1
        cboDay.SelectedIndex = -1
        cboStart.SelectedIndex = -1
        cboRoom.SelectedIndex = -1
    End Sub

    Private Sub gvClass_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvClass.CellContentClick

    End Sub

    Private Sub gvClass_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gvClass.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right And e.RowIndex <> -1 Then
            Dim hit As DataGridView.HitTestInfo = gvClass.HitTest(e.X, e.Y)
            gvClass.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub btnAssignment_Click(sender As Object, e As EventArgs) Handles btnAssignment.Click
        Dim obj As New frmAssignSched
        obj.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs)
        Dim obj As New frmViewSchedule
        obj.ShowDialog()
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub btnView_Click_1(sender As Object, e As EventArgs) Handles btnView.Click
        Dim obj As New frmViewSchedule
        obj.ShowDialog()
    End Sub
End Class