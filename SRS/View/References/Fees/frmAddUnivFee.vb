﻿Imports System.Windows.Forms

Public Class frmAddUnivFee

    Private def As New Defaults
    Private fee As New Fees

    Dim addBool As Boolean = True
    Dim editBool As Boolean = False

    Dim type As String = ""

    Private Sub txtNameFees_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        AllowedOnly(LetterOnly, txtName)
        SentenceCase(txtName)
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        AllowedOnly(NumberWComma, txtAmount)
        CheckforDoubleDot(txtAmount)
        NumberFormat(txtAmount)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtName, txtAmount) = True Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "University Fees and Amount are required."
            warn.ShowDialog()
        ElseIf Decimal.Parse(txtAmount.Text) < 1 Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Invalid amount for University Fees."
            warn.ShowDialog()
        Else
            If addBool = True Then
                fee.FeesName = txtName.Text
                fee.Amount = txtAmount.Text
                fee.FeesType = "University Fees"
                fee.Required = "Required"
                If fee.AddFees() = True Then
                    fee.SetFeesID()
                    Dim info As New frmInfo
                    info.lblMsg.Text = "New University Fees has been saved."
                    info.ShowDialog()
                    addBool = False
                    editBool = False
                    btnUpdate.Visible = True
                    DisableTextBox(txtName, txtAmount)
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "School Fees already exist."
                    warn.ShowDialog()
                End If
            ElseIf editBool = True Then
                fee.FeesName = txtName.Text
                fee.Amount = txtAmount.Text
                fee.FeesType = "University FEES"
                fee.Required = "Required"
                If fee.EditFees() = True Then
                    Dim info As New frmInfo
                    info.lblMsg.Text = "Updates in University Fees has been saved."
                    info.ShowDialog()
                    btnUpdate.Visible = True
                    DisableTextBox(txtName, txtAmount)
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "School Fees already exist."
                    warn.ShowDialog()
                End If
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        editBool = True
        btnUpdate.Visible = False
        EnableTextBox(txtName, txtAmount)
        btnClose.Enabled = True
        btnSave.Enabled = True
    End Sub
End Class
