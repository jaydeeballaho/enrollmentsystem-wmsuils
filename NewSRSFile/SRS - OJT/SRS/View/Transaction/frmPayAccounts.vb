Imports System.Windows.Forms
Imports System.Globalization

Public Class frmPayAccounts

    Public sy As SchoolYear
    Public enroll As Enrollment
    Public assess As Assessment
    Public student As Student
    Public pay As Payments

    Private remain As Decimal = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtReceived_TextChanged(sender As Object, e As EventArgs) Handles txtReceived.TextChanged
        AllowedOnly(NumberWComma, txtReceived)
        CheckforDoubleDot(txtReceived)
        NumberFormat(txtReceived)
        If txtReceived.Text.Count > 0 And txtAssessed.Text.Count > 0 Then
            txtChange.Text = Decimal.Parse(Decimal.Parse(txtReceived.Text) -
                                           Decimal.Parse(txtAssessed.Text)).ToString("N", CultureInfo.InvariantCulture)
        Else
            txtChanged.Text = Decimal.Parse("0.00").ToString("N", CultureInfo.InvariantCulture)
        End If
    End Sub
    Private Sub txtChange_Click(sender As Object, e As EventArgs) Handles txtChange.TextChanged
        Try
            If txtChange.Text.Count > 0 Then
                If Decimal.Parse(txtChange.Text) >= 0 And Decimal.Parse(txtReceived.Text) > 0 Then
                    btnPay.Enabled = True
                Else
                    btnPay.Enabled = False
                End If
            Else
                btnPay.Enabled = False
            End If
            If Decimal.Parse(txtChange.Text) <= 0 Then
                txtChanged.Text = Decimal.Parse("0.00").ToString("N", CultureInfo.InvariantCulture)
            Else
                txtChanged.Text = Decimal.Parse(txtChange.Text).ToString("N", CultureInfo.InvariantCulture)
            End If
        Catch ex As Exception
            btnPay.Enabled = False
        End Try
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If IsTextBoxEmpty(txtOR) = True Then
            Dim info As New frmWarning
            info.lblMsg.Text = "OR Number is required. Please try again."
            info.ShowDialog()
        Else
            Dim que As New frmQuestion
            que.lblMsg.Text = "Are you sure you want to pay the amuount of " +
                Decimal.Parse(txtAssessed.Text).ToString("N", CultureInfo.InvariantCulture)
            If que.ShowDialog() = Windows.Forms.DialogResult.Yes Then

                For Each r As DataGridViewRow In gvFees.Rows
                    If r.Cells(9).Value = True Then
                        pay.EnrollmentID = r.Cells(10).Value
                        pay.StudentID = student.StudentID
                        pay.Amount = r.Cells(8).Value
                        pay.CollectedBy = frmHome.fullname
                        pay.AssessID = r.Cells(0).Value
                        pay.ORNo = txtOR.Text
                        pay.AddPayment()
                    End If
                Next
                enroll.PayAssess()
                enroll.ReEnroll()
                Dim info As New frmInfo
                info.lblMsg.Text = "Amuount of " + Decimal.Parse(txtAssessed.Text).ToString("N", CultureInfo.InvariantCulture) _
                    + " has been paid."
                info.ShowDialog()

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
        
    End Sub

    Private Sub txtAssessed_Click(sender As Object, e As EventArgs) Handles txtAssessed.TextChanged
        AllowedOnly(NumberWComma, txtAssessed)
        CheckforDoubleDot(txtAssessed)
        NumberFormat(txtAssessed)
    End Sub

    Private Sub txtOR_Click(sender As Object, e As EventArgs) Handles txtOR.TextChanged
        AllowedOnly(Alpha, txtOR)
    End Sub

    Private Sub frmPayAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = frmHome.dtServer.ToShortDateString()
        txtBy.Text = frmHome.fullname

        assess.ViewSchoolFeesForPayment2(gvFees, student.StudentID)
        txtReceived.Text = "0.00"
    End Sub

    Private Sub gvFees_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvFees.CellContentClick
        If e.ColumnIndex = 9 Then
            If gvFees.SelectedRows(0).Cells(9).Value = False Then
                gvFees.SelectedRows(0).Cells(9).Value = True
            Else
                gvFees.SelectedRows(0).Cells(9).Value = False
            End If
            Compute()
        End If
    End Sub


    Sub Compute()
        Dim d As Decimal = 0
        For Each r As DataGridViewRow In gvFees.Rows
            If r.Cells(9).Value = True Then
                d = d + Decimal.Parse(r.Cells(8).Value)
            End If
        Next
        txtAssessed.Text = d.ToString("N", CultureInfo.InvariantCulture)
        txtReceived.Text = d.ToString("N", CultureInfo.InvariantCulture)
        If d = 0 Then
            btnPay.Enabled = False
        Else
            btnPay.Enabled = True
        End If
    End Sub
End Class
