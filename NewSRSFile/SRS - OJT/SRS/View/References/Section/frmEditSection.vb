Imports System.Windows.Forms

Public Class frmEditSection

    Public gl As GradeLevel
    Public sec As Section

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty2(txtGl) = True Then
            MessageBox.Show("Empty section is not valid.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtGl.Focus()
        ElseIf sec.SectionNo <> txtGl.Text And sec.IsSectionExist(txtGl.Text) = True Then
            MessageBox.Show("Section already exist.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            sec.GradelevelID = gl.GradeLevelID
            sec.SectionNo = txtGl.Text
            If sec.EditSection = True Then
                MessageBox.Show("Saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Save Failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtGl.Focus()
            End If
        End If
    End Sub

    Private Sub txtGl_TextChanged(sender As Object, e As EventArgs) Handles txtGl.TextChanged
        AllowedOnly2(AlphaNumber, txtGl)
    End Sub
    
    Private Sub frmEditSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGl.Text = sec.SectionNo
    End Sub
End Class
