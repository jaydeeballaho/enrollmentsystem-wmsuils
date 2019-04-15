Public Class frmAssignSched

    Private sy As New SchoolYear
    Private c As New ClassSched
    Private tc As New teacherClass
    Private teacher As New Teacher
    Dim str As String = " abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-."


    Private Sub AssignSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.GetActiveSchoolYear()
        teacher.viewTeacher2(gvTeacher)
        c.SchoolYear = sy.SchoolYearID
        c.viewClassSched2(gvNoClass)
    End Sub

    Private Sub gvTeacher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvTeacher.CellClick
        If gvTeacher.SelectedRows.Count > 0 Then
            teacher.setTeacherDetails(gvTeacher.SelectedRows(0).Cells(0).Value)
            tc.TeacherId = teacher.TeacherID
            tc.viewClassSched2(gvClass, sy.SchoolYearID)
        End If
    End Sub

    Private Sub gvNoClass_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvNoClass.CellClick
        If gvNoClass.SelectedRows.Count > 0 Then
            c.setClassDetails(gvNoClass.SelectedRows(0).Cells(0).Value)
        End If

    End Sub

    Private Sub gvNoClass_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvNoClass.CellDoubleClick
        If gvTeacher.SelectedRows.Count <> 1 Then
            MessageBox.Show("Please select teacher before assingning schedule.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            tc.ClassId = c.ID
            tc.TeacherId = teacher.TeacherID
            tc.AddteacherClass()
            c.viewClassSched2(gvNoClass)
            tc.viewClassSched2(gvClass, sy.SchoolYearID)
        End If

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
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTeacher.TextChanged
        AllowedOnly(str, txtSearchTeacher)
        If txtSearchTeacher.Text.Count > 0 Then
            teacher.searchTeacher3(gvTeacher, txtSearchTeacher.Text)
            If gvTeacher.Rows.Count > 0 Then
                lblNoResult.Hide()
            Else
                lblNoResult.Show()
            End If
        Else
            lblNoResult.Hide()
            gvClass.Rows.Clear()
            teacher.searchTeacher3(gvTeacher, txtSearchTeacher.Text)
        End If
    End Sub

    Private Sub gvClass_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvClass.CellDoubleClick
        If gvClass.SelectedRows.Count > 0 Then
            tc.TeacherClassId = gvClass.SelectedRows(0).Cells(0).Value
            tc.TeacherId = teacher.TeacherID
            tc.DeleteTeacherClass()
            c.viewClassSched2(gvNoClass)
            tc.viewClassSched2(gvClass, sy.SchoolYearID)
        End If
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmPrintReport
            Dim rpt As New TeacherSchedule
            Dim dt As New DataTable

            With dt.Columns
                .Add("Gradelevel")
                .Add("Section")
                .Add("Subject")
                .Add("Start")
                .Add("End")
                .Add("Day")
                .Add("Room")
            End With

            For Each r As DataGridViewRow In gvClass.Rows
                dt.Rows.Add(r.Cells(2).Value.ToString, r.Cells(3).Value.ToString, r.Cells(4).Value.ToString, _
                            r.Cells(6).Value.ToString, r.Cells(7).Value.ToString, r.Cells(5).Value.ToString, r.Cells(8).Value.ToString)
            Next

            rpt.SetDataSource(dt)

            rpt.SetParameterValue("Name", teacher.FirstName + " " + teacher.MiddleName + " " + teacher.LastName)
            rpt.SetParameterValue("SchoolYear", sy.SchoolYearNo)

            With frm
                .crv.ReportSource = rpt
                .crv.Refresh()
                .ShowDialog()
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class