Imports System.Windows.Forms
Imports System.Globalization

Public Class frmShowAccounts

    Public pay As Payments

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pay.ViewPayments(gvFees)
    End Sub
   
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub gvFees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvFees.CellContentClick
        If e.ColumnIndex = 5 Then
            pay.SetPaymentDetails(gvFees.SelectedRows(0).Cells(0).Value)
            Dim obj As New EditPayment
            obj.pay = Me.pay
            If obj.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pay.ViewPayments(gvFees)
            End If
        End If
    End Sub

    Private Sub linkClose_Click_1(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

End Class
