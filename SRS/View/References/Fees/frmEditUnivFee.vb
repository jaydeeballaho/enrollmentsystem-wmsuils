Imports System.Windows.Forms
Imports System.Globalization

Public Class frmEditUnivFee

    Public fee As Fees
    Dim type As String = ""

    Private Sub frmAddFee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = fee.FeesName
        txtAmount.Text = fee.Amount
    End Sub

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
        If IsTextBoxEmpty(txtAmount, txtName) = True Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "University Fees and Amount are required."
            warn.ShowDialog()
        ElseIf Decimal.Parse(txtAmount.Text) < 1 Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Invalid amount for Local Fees."
            warn.ShowDialog()
        Else
            fee.FeesName = txtName.Text
            fee.Amount = txtAmount.Text
            fee.FeesType = "University Fees"
            fee.Required = "Required"
            If fee.EditFees() = True Then
                Dim info As New frmInfo
                info.lblMsg.Text = "New University Fees has been saved."
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
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        btnUpdate.Visible = False
        EnableTextBox(txtAmount, txtName)
        btnClose.Enabled = True
        btnSave.Enabled = True
    End Sub

End Class
