Imports System.Windows.Forms
Imports System.Globalization

Public Class frmPayment

    Private sy As New SchoolYear
    Private enroll As New frmPrint
    Private assess As New Assessment
    Private student As New Student
    Private pay As New Payments
    Private prom As New Promisories
  
    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        AllowedOnly(LetterWSpecial, txtSearch)
        student.SearchStudent(txtSearch.Text, gvStudent)
        gvStudent.ClearSelection()
    End Sub

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        student.SearchStudent(txtSearch.Text, gvStudent)
        gvStudent.ClearSelection()
    End Sub

    Private Sub gvStudent_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvStudent.CellContentClick
        If gvStudent.RowCount < 1 Or gvStudent.SelectedRows.Count < 1 Then
            Exit Sub
        End If
        student.SetStudentDetails(gvStudent.SelectedRows(0).Cells(0).Value)
        enroll.StudentID = student.StudentID
        sy.GetActiveSchoolYear()
        enroll.SchoolYearID = sy.SchoolYearID
        enroll.EnrollmentID = 0
        enroll.SetAssessmentDetails()
        txtName.Text = student.Surname + ", " + student.GivenName + " " + student.MiddleName + " " + student.MiddleInitial
        txtAddress.Text = student.Street + " " + student.Barangay + ", " + student.City + " " + student.Province
        txtSY.Text = sy.SchoolYearNo
        txtGL.Text = enroll.SetLatestGradeLevelNo()
        gvFees.Rows.Clear()
        '   gvPayment.Rows.Clear()
        assess.EnrollmentID = enroll.EnrollmentID
        assess.ViewSchoolFeesForPayment(gvFees, gvStudent, btnPay)
        pay.StudentID = student.StudentID
        ' pay.ViewPayments(gvPayment)
        If enroll.IsPaid = "Yes" And enroll.Status = "Enrolled" Then
            btnPay.Text = "Pay Balance"
        Else
            btnPay.Text = "Pay Assessment"
        End If
        btnShow.Enabled = True
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If btnPay.Text = "Pay Balance" Then
            Dim obj As New AddPayment
            obj.sy = Me.sy
            obj.enroll = Me.enroll
            obj.assess = Me.assess
            obj.student = Me.student
            obj.pay = Me.pay
            obj.txtBalance.Text = gvFees.Rows(gvFees.RowCount - 1).Cells(7).Value
            If obj.ShowDialog() = Windows.Forms.DialogResult.OK Then
                gvFees.Rows.Clear()
                pay.StudentID = student.StudentID
                '  pay.ViewPayments(gvPayment)
                assess.ViewSchoolFeesForPayment(gvFees, gvStudent, btnPay)
            End If
        Else
            Dim obj As New PayAssessment
            obj.sy = Me.sy
            obj.enroll = Me.enroll
            obj.assess = Me.assess
            obj.student = Me.student
            obj.pay = Me.pay
            obj.txtAssessed.Text = enroll.Down
            If obj.ShowDialog() = Windows.Forms.DialogResult.OK Then
                gvFees.Rows.Clear()
                pay.StudentID = student.StudentID
                '  pay.ViewPayments(gvPayment)
                btnPay.Text = "Pay Balance"
                assess.ViewSchoolFeesForPayment(gvFees, gvStudent, btnPay)
            End If
            
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim obj As New frmShowAccounts
        obj.pay = Me.pay
        obj.ShowDialog()
    End Sub
End Class
