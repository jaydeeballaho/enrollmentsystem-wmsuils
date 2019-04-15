Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmTeacherForm

    Private gr As New GradeLevel
    Private section As New Section

    Private teacher As New Teacher
    Private add As Boolean = False
    Private edit As Boolean = False
    Private msg As String = ""
    Private AllowedStr As String = " ,.abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-@"
    Private LetterOnly As String = " .abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-"
    Private NoOnly As String = "1234567890"
    Private NoOnly2 As String = "1234567890-"

    Private Sub doAdd()


        Try
            If ValidateTeacherNo() And ValidateRequired() = True Then

                With teacher
                    .TeacherNo = txtTeacherNo.Text
                    .type = .type
                    .FirstName = txtFN.Text
                    .MiddleName = txtMN.Text
                    .LastName = txtLN.Text
                    .ExtName = txtEN.Text
                    .DOB = dtpDOB.Value
                    .Gender = .Gender
                    .Age = .GetCurrentAge(.DOB, frmHome.dtServer)
                    .Contact = txtCN.Text
                    .Address = txtAddress.Text
                    .Email = txtEmail.Text
                    .GradeLevel = cboLvl.Text
                    .Section = cboSection.Text
                    Dim sql As String = ""
                    If .AddTeacher(sql) Then
                        MessageBox.Show("New teacher has been successfully saved", "Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        OnDone()
                        btnEdit.Enabled = True
                        btnEdit.BackColor = Color.White
                    Else
                        'Dim err As ErrorMessage
                        'err = New ErrorMessage
                        'err.lblMsg.Text = "Failed saving new teacher."
                        'err.ShowDialog()

                    End If
                End With
            Else


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ValidateRequired() As Boolean
        If txtTeacherNo.Text = "" Or txtFN.Text = "" Or txtLN.Text = "" Or txtAddress.Text = "" Or txtCN.Text = "" Then
            MessageBox.Show("Fields with asterisk symbol is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            msg = ""
            Return True
        End If
    End Function
    Private Function ValidateTeacherNo() As Boolean
        If teacher.TeacherNo = txtTeacherNo.Text Then
            Return True
        End If
        If teacher.IsTeacherNoExist(txtTeacherNo.Text) = True Then
            MessageBox.Show("Teacher Number already in used.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            msg = ""
            Return True
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If add = True Then
            doAdd()
        ElseIf edit = True Then
            doEdit()
            cboLvl.Enabled = False
            cboSection.Enabled = False
        End If
    End Sub
    Private Sub doEdit()
        If ValidateRequired() = True Then

            With teacher
                .Type = .Type
                .FirstName = txtFN.Text
                .MiddleName = txtMN.Text
                .LastName = txtLN.Text
                .ExtName = txtEN.Text
                .Gender = .Gender
                .DOB = dtpDOB.Value
                .Age = .GetCurrentAge(.DOB, frmHome.dtServer)
                .Contact = txtCN.Text
                .Address = txtAddress.Text
                .Email = txtEmail.Text
                .GradeLevel = cboLvl.Text
                .Section = cboSection.Text
                Dim sql As String = ""
                If .EditTeacher(sql) Then
                    MessageBox.Show("Teacher has been successfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    OnDone()
                    btnEdit.Enabled = True
                    btnEdit.BackColor = Color.White
                Else

                End If
            End With
        Else
            'Dim err As ErrorMessage
            'err = New ErrorMessage
            'err.lblMsg.Text = "Please provide valid email format"
            'err.ShowDialog()

        End If

    End Sub

    Private Sub AllowedOnly(s As String, tb As TextBox)
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
    Private Sub ClearInput(root As Control)
        For Each ctrl As Control In root.Controls
            ClearInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next

    End Sub
    Private Sub EnableInput(root As Control)
        For Each ctrl As Control In root.Controls
            EnableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = True
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = True
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = True
            End If
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Enabled = True
            End If
        Next ctrl

        txtAge.Enabled = False

    End Sub

    Private Sub DisableInput(root As Control)
        For Each ctrl As Control In root.Controls
            DisableInput(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Enabled = False
            End If
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Enabled = False
            End If
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Enabled = False
            End If
        Next ctrl
    End Sub
    Private Sub OnActionButton()
        btnSearch.Enabled = False
        btnSearch.BackColor = SystemColors.Control
        btnNew.Enabled = False
        btnNew.BackColor = SystemColors.Control
        btnEdit.Enabled = False
        btnEdit.BackColor = SystemColors.Control
        btnSave.Enabled = True
        btnSave.BackColor = Color.White
        btnCancel.Enabled = True
        btnCancel.BackColor = Color.White
        btnAll.Enabled = False
        btnAll.BackColor = SystemColors.Control
        btnClose.Enabled = False
        btnClose.BackColor = SystemColors.Control
    End Sub
    Private Sub ResetButton()
        btnSearch.Enabled = True
        btnSearch.BackColor = Color.White
        btnNew.Enabled = True
        btnNew.BackColor = Color.White
        btnEdit.Enabled = False
        btnEdit.BackColor = SystemColors.Control
        btnSave.Enabled = False
        btnSave.BackColor = SystemColors.Control
        btnCancel.Enabled = False
        btnCancel.BackColor = SystemColors.Control
        btnAll.Enabled = True
        btnAll.BackColor = Color.White
        btnClose.Enabled = True
        btnClose.BackColor = Color.White

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearInput(Me)
        EnableInput(Me)
        OnActionButton()
        add = True
        edit = False
        txtTeacherNo.Focus()
        cboLvl.Enabled = True
        cboSection.Enabled = True

    End Sub

    Private Sub OnDone()
        ResetButton()
        DisableInput(Me)
        add = False
        edit = False
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        OnDone()
        cboLvl.Enabled = False
        cboSection.Enabled = False
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = teacher.GetCurrentAge(dtpDOB.Value, frmHome.dtServer)
    End Sub

    Private Sub rbReg_CheckedChanged(sender As Object, e As EventArgs) Handles rbReg.CheckedChanged
        teacher.type = "Regular"
    End Sub

    Private Sub rbSub_CheckedChanged(sender As Object, e As EventArgs) Handles rbSub.CheckedChanged
        teacher.type = "Sub-Teacher"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim obj As New frmSearchTeacher
        obj.teacher = Me.teacher
        If obj.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try

                With teacher
                    txtTeacherNo.Text = .TeacherNo
                    txtFN.Text = .FirstName
                    txtMN.Text = .MiddleName
                    txtLN.Text = .LastName
                    txtEN.Text = .ExtName
                    If .Gender = "Male" Then
                        rdbMale.Checked = True
                    Else
                        rdbFemale.Checked = True
                    End If
                    If .Type = "Regular" Then
                        rbReg.Checked = True
                    Else
                        rbSub.Checked = False
                    End If
                    dtpDOB.Value = .DOB
                    txtCN.Text = .Contact
                    txtAddress.Text = .Address
                    txtEmail.Text = .Email
                    cboLvl.Text = .GradeLevel
                    cboSection.Text = .Section

                End With
                btnEdit.Enabled = True
                btnEdit.BackColor = Color.White
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Dim obj As New frmViewTeacher
        obj.teacher = Me.teacher
        If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try

                With teacher
                    txtTeacherNo.Text = .TeacherNo
                    txtFN.Text = .FirstName
                    txtMN.Text = .MiddleName
                    txtLN.Text = .LastName
                    txtEN.Text = .ExtName
                    If .Gender = "Male" Then
                        rdbMale.Checked = True
                    Else
                        rdbFemale.Checked = True
                    End If
                    If .type = "Regular" Then
                        rbReg.Checked = True
                    Else
                        rbSub.Checked = False
                    End If
                    dtpDOB.Value = .DOB
                    txtCN.Text = .Contact
                    txtAddress.Text = .Address
                    txtEmail.Text = .Email
                    cboLvl.Text = .GradeLevel
                    cboSection.Text = .Section

                End With
                btnEdit.Enabled = True
                btnEdit.BackColor = Color.White
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub rdbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFemale.CheckedChanged
        teacher.Gender = "Female"
    End Sub

    Private Sub rdbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMale.CheckedChanged
        teacher.Gender = "Male"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EnableInput(Me)
        OnActionButton()
        add = False
        edit = True
        cboLvl.Enabled = True
        cboSection.Enabled = True
        txtTeacherNo.Enabled = False
        '   gvExpert.Enabled = True
        '  dtpDOB.MaxDate = DateAdd(DateInterval.Year, -15, MainForm.dtServer)
        txtFN.Focus()
    End Sub

    Private Sub txtTeacherNo_TextChanged(sender As Object, e As EventArgs) Handles txtTeacherNo.TextChanged
        Allowedonly("abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ-", txtTeacherNo)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtTeacherNo.SelectionStart
        selectionLength = txtTeacherNo.SelectionLength

        ' make the necessary changes
        If txtTeacherNo.TextLength > 1 Then
            txtTeacherNo.Text = txtTeacherNo.Text.Substring(0, 1).ToUpper() + txtTeacherNo.Text.Substring(1)
        ElseIf txtTeacherNo.TextLength = 1 Then
            txtTeacherNo.Text = txtTeacherNo.Text.ToUpper()
        End If

        ' restore the cursor position and text selection
        txtTeacherNo.SelectionStart = startPos
        txtTeacherNo.SelectionLength = selectionLength
    End Sub

    Private Sub txtFN_TextChanged(sender As Object, e As EventArgs) Handles txtFN.TextChanged
        AllowedOnly(LetterOnly, txtFN)
        AllowedOnly(LetterOnly, txtFN)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtFN.SelectionStart
        selectionLength = txtFN.SelectionLength

        txtFN.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFN.Text)


        ' restore the cursor position and text selection
        txtFN.SelectionStart = startPos
        txtFN.SelectionLength = selectionLength
    End Sub

    Private Sub txtMN_TextChanged(sender As Object, e As EventArgs) Handles txtMN.TextChanged
        AllowedOnly(LetterOnly, txtMN)
        AllowedOnly(AllowedStr, txtMN)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtMN.SelectionStart
        selectionLength = txtMN.SelectionLength

        ' make the necessary changes
        txtMN.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMN.Text)

        ' restore the cursor position and text selection
        txtMN.SelectionStart = startPos
        txtMN.SelectionLength = selectionLength
    End Sub

    Private Sub txtLN_TextChanged(sender As Object, e As EventArgs) Handles txtLN.TextChanged
        AllowedOnly(LetterOnly, txtLN)
        AllowedOnly(LetterOnly, txtLN)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtLN.SelectionStart
        selectionLength = txtLN.SelectionLength

        ' make the necessary changes
        txtLN.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLN.Text)
        ' restore the cursor position and text selection
        txtLN.SelectionStart = startPos
        txtLN.SelectionLength = selectionLength
    End Sub

    Private Sub txtEN_TextChanged(sender As Object, e As EventArgs) Handles txtEN.TextChanged
        AllowedOnly(LetterOnly, txtEN)
        AllowedOnly(LetterOnly, txtEN)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtEN.SelectionStart
        selectionLength = txtEN.SelectionLength

        ' make the necessary changes
        If txtEN.TextLength > 1 Then
            txtEN.Text = txtEN.Text.Substring(0, 1).ToUpper() + txtEN.Text.Substring(1).ToUpper()
        ElseIf txtEN.TextLength = 1 Then
            txtEN.Text = txtEN.Text.ToUpper()
        End If

        ' restore the cursor position and text selection
        txtEN.SelectionStart = startPos
        txtEN.SelectionLength = selectionLength
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        AllowedOnly(NoOnly2, txtCN)
        Try
            If txtCN.Text.Length >= 5 Then
                Dim s As String = txtCN.Text.Replace("-", "")
                For x As Integer = 4 To s.Length Step 4
                    s = s.Insert(x + ((x \ 4) - 1), "-")
                Next
                s = s.TrimEnd("-"c)
                txtCN.Text = s
                txtCN.SelectionStart = s.Length
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        AllowedOnly(AllowedStr, txtEmail)
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        AllowedOnly(AllowedStr, txtAddress)
        Dim startPos As Integer
        Dim selectionLength As Integer

        ' store the cursor position and selection length prior to changing the text
        startPos = txtAddress.SelectionStart
        selectionLength = txtAddress.SelectionLength
        txtAddress.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAddress.Text)

        txtAddress.SelectionStart = startPos
        txtAddress.SelectionLength = selectionLength
    End Sub

    Private Sub TeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gr.LoadGradeLevelToCBO(cboLvl)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub linkClose_Click(sender As Object, e As EventArgs) Handles linkClose.Click
        Me.Close()
    End Sub

    Private Sub cboLvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLvl.SelectedIndexChanged
        gr.SetGradeLevelDetails(cboLvl.Text)
        section.GradelevelID = gr.GradeLevelID
        section.LoadSectionToCBO(cboSection)
        'Subject.GradelevelID = gr.GradeLevelID
        'Subject.LoadSubjectToCBO(cboSub)
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        section.GradelevelID = gr.GradeLevelID
        section.SetSectionDetails(cboSection.Text)
    End Sub
End Class