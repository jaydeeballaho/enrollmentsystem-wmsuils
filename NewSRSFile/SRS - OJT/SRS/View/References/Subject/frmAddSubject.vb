Imports System.Windows.Forms

Public Class frmAddSubject

    Public gl As GradeLevel
    Public subj As Subject

    Dim addBool As Boolean = True
    Dim editBool As Boolean = False

    Dim type As String = ""

    Private Sub txtNameFees_TextChanged(sender As Object, e As EventArgs) Handles txtSubjectName.TextChanged
        AllowedOnly(LetterOnly, txtSubjectName)
        SentenceCase(txtSubjectName)
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        AllowedOnly(NumberOnly, txtTime)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtSubjectName, txtTime) = True Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Subject Name and Time are required."
            warn.ShowDialog()
        ElseIf subj.IsSubjectExist(txtSubjectName.Text) = True Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Subject Name already exist in this current Grade level."
            warn.ShowDialog()
            txtSubjectName.Focus()
        ElseIf Decimal.Parse(txtTime.Text) < 15 Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Invalid Time. Time should be atleast in 15 Minutes."
            warn.ShowDialog()
        Else
            If addBool = True Then
                subj.SubjectName = txtSubjectName.Text
                subj.SubjectTime = txtTime.Text
                If subj.AddSubject() = True Then
                    subj.SetSubjectID()
                    Dim info As New frmInfo
                    info.lblMsg.Text = "New Subject has been saved."
                    info.ShowDialog()
                    addBool = False
                    editBool = False
                    btnUpdate.Visible = True
                    DisableTextBox(txtSubjectName, txtTime)
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Save failed."
                    warn.ShowDialog()
                End If
            ElseIf editBool = True Then
                subj.SubjectName = txtSubjectName.Text
                subj.SubjectTime = txtTime.Text
                If subj.EditSubject() = True Then
                    Dim info As New frmInfo
                    info.lblMsg.Text = "Updates in subject has been saved."
                    info.ShowDialog()
                    btnUpdate.Visible = True
                    DisableTextBox(txtSubjectName, txtTime)
                    btnClose.Enabled = True
                    btnSave.Enabled = False
                    btnUpdate.Enabled = True
                Else
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Updates failed."
                    warn.ShowDialog()
                End If
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        editBool = True
        btnUpdate.Visible = False
        EnableTextBox(txtSubjectName, txtTime)
        btnClose.Enabled = True
        btnSave.Enabled = True
    End Sub
End Class
