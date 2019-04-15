Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmManageStud

    Private student As New Student
    Private def As New Defaults

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim obj As New frmAddStudent
        obj.student = Me.student
        obj.ShowDialog()
        student.ViewStudentList(gvSearch)
        If gvSearch.Rows.Count > 0 Then
            panelStudent.Visible = True
            panelFamily.Visible = True
            btnEdit.Visible = True
            SetStudent(student.StudentID)
        Else
            panelStudent.Visible = False
            panelFamily.Visible = False
            btnEdit.Visible = False
        End If
    End Sub

    Private Sub txtStudent_TextChanged(sender As Object, e As EventArgs) Handles txtStudent.TextChanged
        AllowedOnly2(LetterOnly, txtStudent)
        student.SearchStudent(txtStudent.Text, gvSearch)
        If gvSearch.Rows.Count > 0 Then
            lblNoRecordFound.Hide()
        Else
            lblNoRecordFound.Show()
        End If
    End Sub

    Private Sub frmManageStud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studTimer.Start()
        student.ViewStudentList(gvSearch)
        If gvSearch.Rows.Count > 0 Then
            panelStudent.Visible = True
            panelFamily.Visible = True
            btnEdit.Visible = True
            SetStudent(gvSearch.SelectedRows(0).Cells(0).Value)
        Else
            panelStudent.Visible = False
            panelFamily.Visible = False
            btnEdit.Visible = False
        End If
    End Sub

    Private Sub studTimer_Tick(sender As Object, e As EventArgs) Handles studTimer.Tick
        Dim sql As String = "SELECT count(*) FROM student;"
        Dim def As New Defaults
        Try
            If IsConnected() = True Then
                Dim cmd = New MySqlCommand(sql, getServerConnection)
                lblStudentNo.Text = cmd.ExecuteScalar
            End If
        Catch ex As Exception
        End Try
    End Sub
    Dim MyDesiredIndex As Integer = 0
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If gvSearch.SelectedRows.Count > 0 Then
            If gvSearch.Rows.Count > 0 And gvSearch.SelectedRows.Item(0).Index < gvSearch.Rows.Count - 1 Then
                MyDesiredIndex = gvSearch.SelectedRows.Item(0).Index + 1
                gvSearch.Rows(MyDesiredIndex).Selected = True
                SetStudent(gvSearch.SelectedRows(0).Cells(0).Value)
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If gvSearch.SelectedRows.Count > 0 Then
            If gvSearch.Rows.Count > 0 And gvSearch.SelectedRows.Item(0).Index <> 0 Then
                MyDesiredIndex = gvSearch.SelectedRows.Item(0).Index - 1
                gvSearch.Rows(MyDesiredIndex).Selected = True
                SetStudent(gvSearch.SelectedRows(0).Cells(0).Value)
            End If
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If gvSearch.RowCount > 0 Then
            MyDesiredIndex = gvSearch.Rows.Count - 1
            gvSearch.Rows(MyDesiredIndex).Selected = True
            SetStudent(gvSearch.SelectedRows(0).Cells(0).Value)
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If gvSearch.RowCount > 0 Then
            MyDesiredIndex = 0
            gvSearch.Rows(MyDesiredIndex).Selected = True
            SetStudent(gvSearch.SelectedRows(0).Cells(0).Value)
        End If
    End Sub

    Private Sub SetStudent(id As Integer)
        If gvSearch.SelectedRows.Count > 0 Then
            student.SetStudentDetails(id)
            lPupilNo.Text = student.PupilNo
            lSY.Text = student.SchoolYear
            lStudentStatus.Text = student.StudentStatus
            lStudentType.Text = student.StudentType
            lGradeLevel.Text = student.GradeLevel
            lSurname.Text = student.Surname
            lGivenName.Text = student.GivenName
            lMiddleName.Text = student.MiddleName
            lMiddleInitial.Text = student.MiddleInitial
            lNameExt.Text = student.NameExt
            lSex.Text = student.Sex
            lAge.Text = student.Age
            lDOB.Text = student.DOB
            lBP.Text = student.BirthPlace
            lReligion.Text = student.Religion
            lDrive.Text = student.Street
            lBrgy.Text = student.Barangay
            lCity.Text = student.City
            lProvince.Text = student.Province
            picStudent.BackgroundImage = student.Base64ToImage(student.PhotoString)
            student.SetFatherDetails(student.StudentID)
            lFName.Text = student.Name
            lFOccupation.Text = student.Occupation
            lFOffice.Text = student.Office
            lFCN.Text = student.Contact
            student.SetMotherDetails(student.StudentID)
            lMName.Text = student.Name
            lMOccupation.Text = student.Occupation
            lMOffice.Text = student.Office
            lMCN.Text = student.Contact
            student.SetGuardianDetails(student.StudentID)
            lGName.Text = student.Name
            lGOccupation.Text = student.Occupation
            lGOffice.Text = student.Office
            lGCN.Text = student.Contact
            student.SetContactDetails(student.StudentID)
            lCName.Text = student.Name
            lCAddress.Text = student.Address
            lCCN.Text = student.Contact
            Dim enroll As New Enrollment
            Dim sy As New SchoolYear
            sy.GetActiveSchoolYear()
            enroll.SchoolYearID = sy.SchoolYearID
            enroll.StudentID = student.StudentID
            lblEnrolled.Text = enroll.GetEnrolled
        End If
    End Sub

    Private Sub gvSearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvSearch.CellClick
        SetStudent(gvSearch.SelectedRows(0).Cells(0).Value)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim obj As New frmEditStudent
        obj.student = Me.student
        obj.ShowDialog()
        student.ViewStudentList(gvSearch)
        If gvSearch.Rows.Count > 0 Then
            panelStudent.Visible = True
            panelFamily.Visible = True
            btnEdit.Visible = True
            SetStudent(student.StudentID)
        Else
            panelStudent.Visible = False
            panelFamily.Visible = False
            btnEdit.Visible = False
        End If
    End Sub


End Class
