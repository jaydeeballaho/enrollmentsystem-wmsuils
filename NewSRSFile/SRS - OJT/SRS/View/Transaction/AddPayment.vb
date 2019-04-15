Imports System.Windows.Forms
Imports System.Globalization

Public Class AddPayment

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
        Try
            AllowedOnly(NumberWComma, txtReceived)
            CheckforDoubleDot(txtReceived)
            NumberFormat(txtReceived)
            If txtReceived.Text.Count > 0 And txtAmount.Text.Count > 0 Then
                txtChange.Text = Decimal.Parse(Decimal.Parse(txtReceived.Text) -
                                               Decimal.Parse(txtAmount.Text)).ToString("N", CultureInfo.InvariantCulture)
            Else
                txtChange.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        Try
            AllowedOnly(NumberWComma, txtAmount)
            CheckforDoubleDot(txtAmount)
            NumberFormat(txtAmount)
            If txtReceived.Text.Count > 0 And txtAmount.Text.Count > 0 Then
                txtChange.Text = Decimal.Parse(Decimal.Parse(txtReceived.Text) -
                                               Decimal.Parse(txtAmount.Text)).ToString("N", CultureInfo.InvariantCulture)
            Else
                txtChange.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtChange_Click(sender As Object, e As EventArgs) Handles txtChange.TextChanged
        Try
            If txtChange.Text.Count > 0 Then
                If Decimal.Parse(txtChange.Text) >= 0 And Decimal.Parse(txtAmount.Text) > 0 Then
                    btnPay.Enabled = True
                Else
                    btnPay.Enabled = False
                End If
            Else
                btnPay.Enabled = False
            End If
            If Decimal.Parse(txtChange.Text) <= 0 Then
                txtView.Text = Decimal.Parse("0.00").ToString("N", CultureInfo.InvariantCulture)
            Else
                txtView.Text = Decimal.Parse(txtChange.Text).ToString("N", CultureInfo.InvariantCulture)
            End If

        Catch ex As Exception
            btnPay.Enabled = False
        End Try
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim que As New frmQuestion
        que.lblMsg.Text = "Are you sure you want to pay the amuount of " +
            Decimal.Parse(txtAmount.Text).ToString("N", CultureInfo.InvariantCulture)
        If que.ShowDialog() = Windows.Forms.DialogResult.Yes Then
            pay.EnrollmentID = enroll.EnrollmentID
            pay.StudentID = student.StudentID
            pay.Amount = txtAmount.Text
            pay.CollectedBy = frmHome.fullname
            If pay.AddPayment() = True Then
                Dim info As New frmInfo
                info.lblMsg.Text = "Amuount of " + Decimal.Parse(txtAmount.Text).ToString("N", CultureInfo.InvariantCulture) _
                    + " has been paid."
                info.ShowDialog()
                Try
                    Dim frm As New frmPrintReport
                    Dim rpt As New Payment
                    
                    rpt.SetParameterValue("Name", student.Surname + ", " + student.GivenName + " " + student.MiddleName)
                    rpt.SetParameterValue("Amount", pay.Amount)
                    rpt.SetParameterValue("CollectedBy", frmHome.fullname)

                    With frm
                        .crv.ReportSource = rpt
                        .crv.Refresh()
                        .ShowDialog()
                    End With
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Dim info As New frmWarning
                info.lblMsg.Text = "Failed while trying to pay student balances. Please try again."
                info.ShowDialog()
            End If
        End If
    End Sub

    Private Sub txtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged

    End Sub
End Class
