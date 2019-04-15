﻿Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frmEditStudent

    Private gl As New GradeLevel
    Private sy As New SchoolYear
    Public student As Student
    Private def As New Defaults

    Private doEdit As Boolean = False

    Dim sex As String
    Dim studtype As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Title = "Choose a photo"
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.FilterIndex = 2
            ofd.RestoreDirectory = False
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If ofd.CheckFileExists = False Or ofd.CheckPathExists = False Then
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "File no longer exist."
                    warn.ShowDialog()
                Else
                    Dim PhotoFile As New IO.FileInfo(ofd.FileName)
                    If PhotoFile.Length <= 3500000 Then
                        Dim EmployeePhoto As New Bitmap(ofd.FileName)
                        picStudent.BackgroundImageLayout = ImageLayout.Stretch
                        picStudent.BackgroundImage = ResizeImage(EmployeePhoto)
                    Else
                        Dim warn As New frmWarning
                        warn.lblMsg.Text = "File size too large."
                        warn.ShowDialog()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
        Return New Bitmap(PhotoFile, New Size(picStudent.Width, picStudent.Height))
    End Function

    Private Sub btnDefaults_Click(sender As Object, e As EventArgs) Handles btnDefaults.Click
        picStudent.BackgroundImage = picNoImage.BackgroundImage
    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sy.GetActiveSchoolYear()
        txtGivenName.Text = student.GivenName
        txtSurname.Text = student.Surname
        txtMiddleName.Text = student.MiddleName
        txtMiddleInitial.Text = student.MiddleInitial
        txtNameExt.Text = student.NameExt
        If student.StudentType = "PWD" Then
            rbPWD.Checked = True
        Else
            rbRegular.Checked = True
        End If
        cboStudentStatus.SelectedIndex = cboStudentStatus.FindString(student.StudentStatus)
        txtPupilNo.Text = student.PupilNo
        If student.Sex = "MALE" Then
            rbMale.Checked = True
        Else
            rbFemale.Checked = True
        End If
        txtAge.Text = student.Age
        dtpDOB.Value = student.DOB
        txtBirthPlace.Text = student.BirthPlace
        txtReligion.Text = student.Religion
        txtDrive.Text = student.Street
        cboBrgy.SelectedIndex = cboBrgy.FindString(student.Barangay)
        txtCity.Text = student.City
        txtProvince.Text = student.Province
        picStudent.BackgroundImage = student.Base64ToImage(student.PhotoString)

        student.SetFatherDetails(student.StudentID)
        txtFName.Text = student.Name
        txtFOffice.Text = student.Office
        txtCN.Text = student.Contact
        txtFOccupation.Text = student.Occupation

        student.SetMotherDetails(student.StudentID)
        txtMName.Text = student.Name
        txtMOffice.Text = student.Office
        txtMCN.Text = student.Contact
        txtMOccupation.Text = student.Occupation

        student.SetGuardianDetails(student.StudentID)
        txtGName.Text = student.Name
        txtGOffice.Text = student.Office
        txtGCN.Text = student.Contact
        txtGOccupation.Text = student.Occupation

        student.SetContactDetails(student.StudentID)
        txtCName.Text = student.Name
        txtCCN.Text = student.Contact
        txtCAddress.Text = student.Address

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IsTextBoxEmpty2(txtSurname, txtGivenName, txtCity, txtCName, txtCAddress, txtCCN) = True Or cboBrgy.SelectedItem = vbNullString _
           Or cboStudentStatus.SelectedItem = vbNullString Then
            Dim warn As New frmWarning
            warn.lblMsg.Text = "Labels with asterisk (*) symbol are required. Please Check the family background too."
            warn.ShowDialog()
        Else
            If student.Surname = txtSurname.Text And student.GivenName = txtGivenName.Text And student.MiddleName = txtMiddleName.Text Then
            Else
                If student.IsStudentExist(txtSurname.Text, txtGivenName.Text, txtMiddleName.Text) = True Then
                    Dim warn As New frmWarning
                    warn.lblMsg.Text = "Student with the same name already exist."
                    warn.ShowDialog()
                    Exit Sub
                End If
            End If
            SetStudentDetails()
            If student.EditStudent() = True Then
                Dim warn As New frmInfo
                warn.lblMsg.Text = "Updates in student has been saved."
                warn.ShowDialog()
                SetFatherDetails()
                student.EditFamily(student.FatherID)
                '
                SetMotherDetails()
                student.EditFamily(student.MotherID)
                '
                SetGuardianDetails()
                student.EditFamily(student.GuardianID)
                '
                SetContactDetails()
                student.EditFamily(student.ContactID)

                DisableInput(Me)
                btnUpdate.Visible = True
                btnSave.Enabled = False
                btnClose.Enabled = True
                btnUpdate.Enabled = True
            Else
                Dim warn As New frmWarning
                warn.lblMsg.Text = "Pupil No. already exist."
                warn.ShowDialog()
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        EnableInput(Me)
        btnUpdate.Visible = False
        btnSave.Enabled = True
        btnClose.Enabled = True
        txtAge.Enabled = False
    End Sub

    Private Sub SetStudentDetails()
        student.GivenName = txtGivenName.Text
        student.Surname = txtSurname.Text
        student.MiddleName = txtMiddleName.Text
        student.MiddleInitial = txtMiddleInitial.Text
        student.NameExt = txtNameExt.Text
        student.StudentStatus = cboStudentStatus.Text
        student.StudentType = studtype
        student.PupilNo = txtPupilNo.Text
        student.Sex = sex
        student.Age = txtAge.Text
        student.DOB = dtpDOB.Value.Date
        student.BirthPlace = txtBirthPlace.Text
        student.Religion = txtReligion.Text
        student.Street = txtDrive.Text
        student.Barangay = cboBrgy.Text
        student.City = txtCity.Text
        student.Province = txtProvince.Text
        student.PhotoString = student.ConvertImageTo64(picStudent.BackgroundImage)
    End Sub
    Private Sub SetFatherDetails()
        student.StudentIDID = student.StudentID
        student.Name = txtFName.Text
        student.Office = txtFOffice.Text
        student.Contact = txtCN.Text
        student.Address = ""
        student.Type = "FATHER"
        student.Occupation = txtFOccupation.Text
    End Sub
    Private Sub SetMotherDetails()
        student.StudentIDID = student.StudentID
        student.Name = txtMName.Text
        student.Office = txtMOffice.Text
        student.Contact = txtMCN.Text
        student.Address = ""
        student.Type = "MOTHER"
        student.Occupation = txtMOccupation.Text
    End Sub
    Private Sub SetGuardianDetails()
        student.StudentIDID = student.StudentID
        student.Name = txtGName.Text
        student.Office = txtGOffice.Text
        student.Contact = txtGCN.Text
        student.Address = ""
        student.Type = "GUARDIAN"
        student.Occupation = txtGOccupation.Text
    End Sub
    Private Sub SetContactDetails()
        student.StudentIDID = student.StudentID
        student.Name = txtCName.Text
        student.Office = ""
        student.Contact = txtCCN.Text
        student.Address = txtCAddress.Text
        student.Type = "CONTACT"
        student.Occupation = ""
    End Sub
    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        txtAge.Text = student.GetCurrentAge(dtpDOB.Value, frmHome.dtServer)
    End Sub

    Private Sub rbRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rbRegular.CheckedChanged
        Me.studtype = "REGULAR"
    End Sub

    Private Sub rbPWD_CheckedChanged(sender As Object, e As EventArgs) Handles rbPWD.CheckedChanged
        Me.studtype = "PWD"
    End Sub

    Private Sub rbMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbMale.CheckedChanged
        Me.sex = "MALE"
    End Sub

    Private Sub rbFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbFemale.CheckedChanged
        Me.sex = "FEMALE"
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs)
        Dim obj As New frmPhoto
        If obj.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.picStudent.BackgroundImage = obj.picStudent.BackgroundImage
        End If
    End Sub

    Private Sub txtPupilNo_TextChanged(sender As Object, e As EventArgs) Handles txtPupilNo.TextChanged
        AllowedOnly2(Alpha, txtPupilNo)
    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged
        AllowedOnly2(LetterOnly, txtSurname)
    End Sub

    Private Sub txtGivenName_TextChanged(sender As Object, e As EventArgs) Handles txtGivenName.TextChanged
        AllowedOnly2(LetterOnly, txtGivenName)
    End Sub

    Private Sub txtMiddleName_TextChanged(sender As Object, e As EventArgs) Handles txtMiddleName.TextChanged
        AllowedOnly2(LetterOnly, txtMiddleName)
    End Sub

    Private Sub txtMiddleInitial_TextChanged(sender As Object, e As EventArgs) Handles txtMiddleInitial.TextChanged
        AllowedOnly2(LetterOnly, txtMiddleInitial)
    End Sub

    Private Sub txtNameExt_TextChanged(sender As Object, e As EventArgs) Handles txtNameExt.TextChanged
        AllowedOnly2(LetterOnly, txtNameExt)
    End Sub

    Private Sub txtBirthPlace_TextChanged(sender As Object, e As EventArgs) Handles txtBirthPlace.TextChanged
        AllowedOnly2(Alpha, txtBirthPlace)
    End Sub

    Private Sub txtDrive_TextChanged(sender As Object, e As EventArgs) Handles txtDrive.TextChanged
        AllowedOnly2(Alpha, txtDrive)
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged
        AllowedOnly2(Alpha, txtCity)
    End Sub

    Private Sub txtProvince_TextChanged(sender As Object, e As EventArgs) Handles txtProvince.TextChanged
        AllowedOnly2(Alpha, txtProvince)
    End Sub


  

    Private Sub btnUseFather_Click(sender As Object, e As EventArgs) Handles btnUseFather.Click
        txtGName.Text = txtFName.Text
        txtGOffice.Text = txtFOffice.Text
        txtGCN.Text = txtCN.Text
        txtGOccupation.Text = txtFOccupation.Text
    End Sub

    Private Sub btnUseMother_Click(sender As Object, e As EventArgs) Handles btnUseMother.Click
        txtGName.Text = txtMName.Text
        txtGOffice.Text = txtMOffice.Text
        txtGCN.Text = txtMCN.Text
        txtGOccupation.Text = txtMOccupation.Text
    End Sub

    Private Sub btnUseBoth_Click(sender As Object, e As EventArgs) Handles btnUseBoth.Click
        txtGName.Text = txtFName.Text + " / " + txtMName.Text
        txtGOffice.Text = txtFOffice.Text + " / " + txtMOffice.Text
        txtGCN.Text = txtCN.Text + " / " + txtMCN.Text
        txtGOccupation.Text = txtFOccupation.Text + " / " + txtMOccupation.Text
    End Sub

    Private Sub btnUseFather2_Click(sender As Object, e As EventArgs) Handles btnUseFather2.Click
        txtCName.Text = txtFName.Text
        txtCCN.Text = txtCN.Text
    End Sub

    Private Sub btnUseMother2_Click(sender As Object, e As EventArgs) Handles btnUseMother2.Click
        txtCName.Text = txtMName.Text
        txtCCN.Text = txtMCN.Text
    End Sub

    Private Sub btnUseBoth2_Click(sender As Object, e As EventArgs) Handles btnUseBoth2.Click
        txtCName.Text = txtFName.Text + " / " + txtMName.Text
        txtCCN.Text = txtCN.Text + " / " + txtMCN.Text
    End Sub

    Private Sub bnUseStudAdd_Click(sender As Object, e As EventArgs) Handles bnUseStudAdd.Click
        txtCAddress.Text = txtDrive.Text + " " + cboBrgy.Text + ", " + txtCity.Text + " " + txtProvince.Text
    End Sub

    Private Sub txtFName_TextChanged(sender As Object, e As EventArgs) Handles txtFName.TextChanged
        AllowedOnly2(LetterOnly, txtFName)
    End Sub

    Private Sub txtFOccupation_TextChanged(sender As Object, e As EventArgs) Handles txtFOccupation.TextChanged
        AllowedOnly2(Alpha, txtFOccupation)
    End Sub

    Private Sub txtFOffice_TextChanged(sender As Object, e As EventArgs) Handles txtFOffice.TextChanged
        AllowedOnly2(Alpha, txtFOffice)
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged
        AllowedOnly2(NumberWDash, txtCN)
        'ContactNo(txtCN)
    End Sub

    Private Sub txtMName_TextChanged(sender As Object, e As EventArgs) Handles txtMName.TextChanged
        AllowedOnly2(LetterOnly, txtMName)
    End Sub

    Private Sub txtMOccupation_TextChanged(sender As Object, e As EventArgs) Handles txtMOccupation.TextChanged
        AllowedOnly2(Alpha, txtMOccupation)
    End Sub

    Private Sub txtMOffice_TextChanged(sender As Object, e As EventArgs) Handles txtMOffice.TextChanged
        AllowedOnly2(Alpha, txtMOffice)
    End Sub

    Private Sub txtMCN_TextChanged(sender As Object, e As EventArgs) Handles txtMCN.TextChanged
        AllowedOnly2(NumberWDash, txtMCN)
        '    ContactNo(txtMCN)
    End Sub

    Private Sub txtGName_TextChanged(sender As Object, e As EventArgs) Handles txtGName.TextChanged
        AllowedOnly2(LetterWSpecial, txtGName)
    End Sub

    Private Sub txtGOccupation_TextChanged(sender As Object, e As EventArgs) Handles txtGOccupation.TextChanged
        AllowedOnly2(Alpha, txtGOccupation)
    End Sub

    Private Sub txtGOffice_TextChanged(sender As Object, e As EventArgs) Handles txtGOffice.TextChanged
        AllowedOnly2(Alpha, txtGOffice)
    End Sub

    Private Sub txtGCN_TextChanged(sender As Object, e As EventArgs) Handles txtGCN.TextChanged
        AllowedOnly2(NumberWSlash, txtGCN)
    End Sub

    Private Sub txtCName_TextChanged(sender As Object, e As EventArgs) Handles txtCName.TextChanged
        AllowedOnly2(LetterWSpecial, txtCName)
    End Sub

    Private Sub txtCAddress_TextChanged(sender As Object, e As EventArgs) Handles txtCAddress.TextChanged
        AllowedOnly2(Alpha, txtCAddress)
    End Sub

    Private Sub txtCCN_TextChanged(sender As Object, e As EventArgs) Handles txtCCN.TextChanged
        AllowedOnly2(NumberWSlash, txtCCN)
    End Sub

End Class