Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmGrades

    Private sy As New SchoolYear
    Private gl As New GradeLevel
    Private sec As New Section
    Private subj As New Subject
    Private stud As New Student
    Private enr As New Enrollment

    Dim i As Integer = 0
   
    Private Sub frmGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.LoadSchoolYearToCBO(cboSY)
        sy.GetActiveSchoolYear()
        cboSY.SelectedIndex = cboSY.FindString(sy.SchoolYearNo)
        gl.LoadGradeLevelToCBO(cboGL)
    End Sub

    Private Sub cboGL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGL.SelectedIndexChanged
        gl.SetGradeLevelDetails(cboGL.Text)
        sec.GradelevelID = gl.GradeLevelID
        sec.LoadSectionToCBO(cboSection)
        subj.GradelevelID = gl.GradeLevelID
        subj.LoadSubjectToCBO(cboSubject)
        LoadGrades()
    End Sub
    Private Sub LoadGrades()
        If cboSY.SelectedItem <> vbNullString And cboGL.SelectedItem <> vbNullString And cboSection.SelectedItem <> vbNullString _
            And cboSubject.SelectedItem <> vbNullString Then
            enr.SchoolYearID = sy.SchoolYearID
            enr.GradeLevelID = gl.GradeLevelID
            enr.SectionID = sec.SectionID
            enr.ViewEnrollee2(gvStudent, subj.SubjectID)
            For Each r As DataGridViewRow In gvStudent.Rows
                Dim g As New Grades
                g.EnrollmentID = r.Cells(0).Value
                g.Subject = r.Cells(1).Value
                g.ViewGrade(gvStudent, r.Index)
            Next
            For Each r As DataGridViewRow In gvStudent.Rows
                If r.Cells(12).Value.ToString = "Failed" Then
                    r.DefaultCellStyle.ForeColor = Color.Crimson
                End If
            Next
            gvStudent.ClearSelection()
            If gvStudent.RowCount < 1 Then
                MsgBox("No Grade is to be displayed.")
            End If
        End If
    End Sub
    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        subj.GradelevelID = gl.GradeLevelID
        sec.SetSectionDetails(cboSection.Text)
        LoadGrades()
    End Sub

    Private Sub cboSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubject.SelectedIndexChanged
        subj.GradelevelID = gl.GradeLevelID
        subj.SetSubjectDetails(cboSubject.Text)
        LoadGrades()
    End Sub

    Private Sub cboSY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSY.SelectedIndexChanged
        sy.SetSchoolYearDetails(cboSY.Text)
        LoadGrades()
    End Sub

    Private Sub gvStudent_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gvStudent.CellValueChanged
        CalculateGrade(gvStudent, i)
    End Sub
    Private Sub gvStudent_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles gvStudent.EditingControlShowing
        Try
            If gvStudent.CurrentCell.ColumnIndex = 7 Then

                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
                '   AddHandler CType(e.Control, TextBox).TextChanged, AddressOf TextBox_TextChanged
                i = gvStudent.CurrentCell.RowIndex

            ElseIf gvStudent.CurrentCell.ColumnIndex = 8 Then

                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
                '   AddHandler CType(e.Control, TextBox).TextChanged, AddressOf TextBox_TextChanged
                i = gvStudent.CurrentCell.RowIndex
            ElseIf gvStudent.CurrentCell.ColumnIndex = 9 Then

                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
                '   AddHandler CType(e.Control, TextBox).TextChanged, AddressOf TextBox_TextChanged
                i = gvStudent.CurrentCell.RowIndex
            ElseIf gvStudent.CurrentCell.ColumnIndex = 10 Then
                AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
                '  AddHandler CType(e.Control, TextBox).TextChanged, AddressOf TextBox_TextChanged
                i = gvStudent.CurrentCell.RowIndex
            End If
            'For Each r As DataGridViewRow In gvStudent.Rows
            '    If r.Cells(7).Value.ToString <> "" And r.Cells(8).Value.ToString <> "" And r.Cells(9).Value.ToString <> "" And _
            '        r.Cells(10).Value.ToString <> "" Then
            '        r.Cells(11).Value = (Decimal.Parse(r.Cells(7).Value) + Decimal.Parse(r.Cells(8).Value) + Decimal.Parse(r.Cells(9).Value) + Decimal.Parse(r.Cells(10).Value)) / 4
            '        If Decimal.Parse(r.Cells(11).Value) > 74 Then
            '            r.Cells(12).Value = "Passed"
            '        Else
            '            r.Cells(12).Value = "Failed"
            '        End If
            '    Else
            '        r.Cells(11).Value = ""
            '        r.Cells(12).Value = ""
            '    End If

            'Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        '   If Char.IsDigit(CChar(CStr(e.KeyChar))) = False Then e.Handled = True
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If

    End Sub
    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            CalculateGrade(gvStudent, i)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CalculateGrade(gv As DataGridView, i As Integer)
        Try
            If gv.Rows(i).Cells(7).Value.ToString <> "" And gv.Rows(i).Cells(8).Value.ToString <> "" And gv.Rows(i).Cells(9).Value.ToString <> "" And _
                   gv.Rows(i).Cells(10).Value.ToString <> "" Then
                gv.Rows(i).Cells(11).Value = (Decimal.Parse(gv.Rows(i).Cells(7).Value) + Decimal.Parse(gv.Rows(i).Cells(8).Value) + Decimal.Parse(gv.Rows(i).Cells(9).Value) + Decimal.Parse(gv.Rows(i).Cells(10).Value)) / 4
                If Decimal.Parse(gv.Rows(i).Cells(11).Value) >= 75 Then
                    gv.Rows(i).Cells(12).Value = "Passed"
                Else
                    gv.Rows(i).Cells(12).Value = "Failed"
                End If
                For Each r As DataGridViewRow In gvStudent.Rows
                    If r.Cells(12).Value.ToString = "Failed" Then
                        r.DefaultCellStyle.ForeColor = Color.Crimson
                    Else
                        r.DefaultCellStyle.ForeColor = Color.Black
                    End If
                Next
            Else
                gv.Rows(i).Cells(11).Value = ""
                gv.Rows(i).Cells(12).Value = ""
            End If
            gvStudent.ClearSelection()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TextBox_keyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs)

        '  If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ".") Then e.Handled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "UPLOAD GRADES" Then
            btnSave.Text = "SAVE"
            gvStudent.Enabled = True
            Exit Sub
        End If
        If gvStudent.RowCount > 0 Then
            For Each r As DataGridViewRow In gvStudent.Rows
                Dim g As New Grades
                g.EnrollmentID = r.Cells(0).Value
                g.Subject = r.Cells(1).Value
                If Not r.Cells(7).Value Is Nothing Then
                    g.Grade1 = r.Cells(7).Value
                End If
                If Not r.Cells(8).Value Is Nothing Then
                    g.Grade2 = r.Cells(8).Value
                End If
                If Not r.Cells(9).Value Is Nothing Then
                    g.Grade3 = r.Cells(9).Value.ToString
                End If
                If Not r.Cells(10).Value Is Nothing Then
                    g.Grade4 = r.Cells(10).Value.ToString
                End If
                If Not r.Cells(11).Value Is Nothing Then
                    g.Final = r.Cells(11).Value.ToString
                End If
                If Not r.Cells(12).Value Is Nothing Then
                    g.Remarks = r.Cells(12).Value.ToString
                End If
                g.EditGrade()
            Next
            MsgBox("Saved")
            LoadGrades()
            btnSave.Text = "UPLOAD GRADES"
            gvStudent.Enabled = False
        Else
            MsgBox("No Student with corresponding grades is to be saved.")
        End If
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub btnRank_Click(sender As Object, e As EventArgs) Handles btnRank.Click
        Dim obj As New frmGradeRankings
        obj.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmPrintReport
            Dim rpt As New Grade
            Dim dt As New DataTable

            With dt.Columns
                .Add("No")
                .Add("Name")
                .Add("Grade")
            End With
            Dim i As Integer = 1
            For Each r As DataGridViewRow In gvStudent.Rows
                dt.Rows.Add(i, r.Cells(2).Value.ToString, r.Cells(11).Value.ToString)
                i = i + 1
            Next

            rpt.SetDataSource(dt)

            rpt.SetParameterValue("Grade", cboGL.Text + " - " + cboSection.Text)
            rpt.SetParameterValue("Subject", cboSubject.Text)
            rpt.SetParameterValue("SchoolYear", cboSY.Text)

            With frm
                .crv.ReportSource = rpt
                .crv.Refresh()
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class
