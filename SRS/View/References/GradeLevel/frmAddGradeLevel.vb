Imports System.Windows.Forms

Public Class frmAddGradeLevel

    Private gl As New GradeLevel

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty(txtGradeLevel) = True Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Empty Grade Level is not valid."
            warn.ShowDialog()
            txtGradeLevel.Focus()
        Else
            gl.GradeLevelNo = txtGradeLevel.Text
            If gl.AddGradeLevel() = True Then
                Me.Close()
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Grade Level " + gl.GradeLevelNo + " already exist."
                warn.ShowDialog()
                txtGradeLevel.Focus()
            End If
        End If
    End Sub

    Private Sub txtGl_TextChanged(sender As Object, e As EventArgs) Handles txtGradeLevel.TextChanged
        AllowedOnly(AlphaNumber, txtGradeLevel)
        SentenceCase(txtGradeLevel)
    End Sub

    
    Private Sub frmAddGradeLevel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtGradeLevel.Focus()
    End Sub
End Class
