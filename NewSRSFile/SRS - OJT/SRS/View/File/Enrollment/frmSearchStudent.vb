Imports System.Windows.Forms

Public Class frmSearchStudent

    Private sy As New SchoolYear
    Public student As Student
    Public enroll As Enrollment

    Private Sub frmSearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()
        sy.GetActiveSchoolYear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(LetterWSpecial, txtSearch)
        If txtSearch.Text.Length > 1 Then
            student.SearchStudentInAssessment(txtSearch.Text, gvStudent, sy.SchoolYearID)
        Else
            gvStudent.Rows.Clear()
        End If
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub gvStudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStudent.CellContentClick
        If e.ColumnIndex = 2 Then
            enroll.SetAssessmentDetails2(gvStudent.SelectedRows(0).Cells(0).Value)
            student.SetStudentDetails(enroll.StudentID)
            student.SetFatherDetails(student.StudentID)
            student.SetMotherDetails(student.StudentID)
            student.SetGuardianDetails(student.StudentID)
            student.SetContactDetails(student.StudentID)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class
