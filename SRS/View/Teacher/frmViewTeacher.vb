Public Class frmViewTeacher


    Public tsched As frmTeacherForm

    Public RBrowse As Boolean = False
    Public SBrowse As Boolean = False
    Public teacher As Teacher
    Dim str As String = " abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-."

    Private Sub SearchTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        teacher.viewTeacher(gvView)
    End Sub
    Public Sub AllowedOnly(s As String, tb As TextBox)
        Try
            Dim theText As String = tb.Text
            Dim Letter As String
            Dim SelectionIndex As Integer = tb.SelectionStart
            Dim Change As Integer
            For x As Integer = 0 To tb.Text.Length - 1
                Letter = tb.Text.Substring(x, 1)
                If s.Contains(Letter) = False Then
                    theText = theText.Replace(Letter, String.Empty)
                    Change = 1
                End If
            Next
            tb.Text = theText
            tb.Select(SelectionIndex - Change, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch2.TextChanged
        AllowedOnly(str, txtSearch2)
        If txtSearch2.Text.Count > 0 Then
            teacher.searchTeacher2(gvView, ContextMenuStrip1, txtSearch2.Text)
            If gvView.Rows.Count > 0 Then
                lblNoResult.Hide()
            Else
                lblNoResult.Show()
            End If
        Else
            lblNoResult.Hide()
            teacher.searchTeacher2(gvView, ContextMenuStrip1, txtSearch2.Text)
        End If
    End Sub


    Private Sub gvView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvView.CellDoubleClick
        teacher.setTeacherDetails(gvView.SelectedRows(0).Cells(0).Value)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
    '    Try
    '        Dim dt As New DataTable
    '        Dim frm As New ReportForm
    '        Dim rpt As New TeacherList
    '        With dt.Columns
    '            .Add("Name")
    '            .Add("TeacherNo")
    '            .Add("TeacherType")
    '            .Add("Gender")
    '            .Add("Birthday")
    '            .Add("Age")
    '            .Add("Address")

    '        End With
    '        For Each row As DataGridViewRow In gvView.Rows
    '            dt.Rows.Add(row.Cells(1).Value.ToString, row.Cells(2).Value.ToString, row.Cells(3).Value.ToString, row.Cells(4).Value.ToString, row.Cells(5).Value.ToString)
    '        Next
    '        With rpt
    '            .SetDataSource(dt)
    '        End With
    '        With frm
    '            .CrystalReportViewer1.Refresh()
    '            .CrystalReportViewer1.ReportSource = rpt
    '            .ShowDialog()
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try


            Dim rpt As New TeacherRec
            Dim dt As New DataTable
            Dim frm As New frmPrintReport

            With dt.Columns
                .Add("No")
                .Add("TeacherName")
                .Add("TeacherNo")
                .Add("TeacherType")
                .Add("Gender")
                .Add("DOB")
                .Add("Age")
                .Add("Address")
            End With

            For Each item As DataGridViewRow In gvView.Rows
                dt.Rows.Add(item.Cells(1).Value.ToString, item.Cells(2).Value.ToString, item.Cells(3).Value.ToString, item.Cells(4).Value.ToString, item.Cells(5).Value.ToString, item.Cells(6).Value.ToString, item.Cells(7).Value.ToString, item.Cells(8).Value.ToString)
            Next

            With rpt
                .SetDataSource(dt)

            End With

            With frm
                .crv.Refresh()
                .crv.ReportSource = rpt
                .ShowDialog()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class