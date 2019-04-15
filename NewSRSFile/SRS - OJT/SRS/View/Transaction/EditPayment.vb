Imports System.Windows.Forms
Imports System.Globalization

Public Class EditPayment

    Public pay As Payments

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        AllowedOnly(NumberWComma, txtAmount)
        CheckforDoubleDot(txtAmount)
        NumberFormat(txtAmount)
        If txtAmount.Text.Count > 0 Then
            btnPay.Enabled = True
        Else
            btnPay.Enabled = False
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        pay.Amount = txtAmount.Text
        pay.CollectedBy = frmHome.fullname
        pay.EditPayment()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub EditPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmount.Text = pay.Amount.ToString("N", CultureInfo.InvariantCulture)
    End Sub
End Class
