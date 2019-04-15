Imports System.Windows.Forms
Imports System.Globalization

Public Class frmViewAccounts

    Private assessed As New Assessment
    Public student As Student

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmShowAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        assessed.ViewSchoolFeesToPay(gvFees, student.StudentID)
    End Sub
End Class
