<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssessment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssessment))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnAddToEnrollment = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAssess = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtDOB = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.txtName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtUniv = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox8 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrevBalance = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox12 = New MetroFramework.Controls.MetroTextBox()
        Me.gvLocalFees = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bool = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvUniv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSchoolYear = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox15 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox16 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAssessedDate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox18 = New MetroFramework.Controls.MetroTextBox()
        Me.txtSex = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtLocal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox11 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtEnrolled = New MetroFramework.Controls.MetroTextBox()
        Me.txtDOE = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox9 = New MetroFramework.Controls.MetroTextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.rb25 = New System.Windows.Forms.RadioButton()
        Me.txtDiscounts = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox10 = New MetroFramework.Controls.MetroTextBox()
        Me.rb50 = New System.Windows.Forms.RadioButton()
        Me.rb100 = New System.Windows.Forms.RadioButton()
        Me.rb75 = New System.Windows.Forms.RadioButton()
        Me.txtGL = New MetroFramework.Controls.MetroTextBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox13 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox17 = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.gvLocalFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUniv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(872, 521)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(188, 50)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(872, 465)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(188, 50)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "PRINT ASSESSMENT FORM"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnAddToEnrollment
        '
        Me.btnAddToEnrollment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddToEnrollment.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnAddToEnrollment.Enabled = False
        Me.btnAddToEnrollment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddToEnrollment.FlatAppearance.BorderSize = 0
        Me.btnAddToEnrollment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToEnrollment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToEnrollment.ForeColor = System.Drawing.Color.White
        Me.btnAddToEnrollment.Location = New System.Drawing.Point(872, 353)
        Me.btnAddToEnrollment.Name = "btnAddToEnrollment"
        Me.btnAddToEnrollment.Size = New System.Drawing.Size(188, 50)
        Me.btnAddToEnrollment.TabIndex = 26
        Me.btnAddToEnrollment.Text = "ADD STUDENT TO ENROLLMENT"
        Me.btnAddToEnrollment.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(872, 185)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(188, 50)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "RE-ASSESS"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnAssess
        '
        Me.btnAssess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAssess.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnAssess.Enabled = False
        Me.btnAssess.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAssess.FlatAppearance.BorderSize = 0
        Me.btnAssess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssess.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssess.ForeColor = System.Drawing.Color.White
        Me.btnAssess.Location = New System.Drawing.Point(872, 129)
        Me.btnAssess.Name = "btnAssess"
        Me.btnAssess.Size = New System.Drawing.Size(188, 50)
        Me.btnAssess.TabIndex = 22
        Me.btnAssess.Text = "ASSESS"
        Me.btnAssess.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(872, 73)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(188, 50)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnSave.Enabled = False
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(872, 241)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(188, 50)
        Me.btnSave.TabIndex = 107
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(872, 297)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(188, 50)
        Me.btnCancel.TabIndex = 108
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 605)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1084, 40)
        Me.Panel12.TabIndex = 260
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(1084, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 605)
        Me.Panel15.TabIndex = 262
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Enabled = False
        Me.Panel14.Location = New System.Drawing.Point(30, 142)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(817, 1)
        Me.Panel14.TabIndex = 263
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 40)
        Me.Panel2.TabIndex = 261
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(461, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(163, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "STUDENT ASSESSMENT"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'txtDOB
        '
        '
        '
        '
        Me.txtDOB.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtDOB.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtDOB.CustomButton.Name = ""
        Me.txtDOB.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDOB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDOB.CustomButton.TabIndex = 1
        Me.txtDOB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDOB.CustomButton.UseSelectable = True
        Me.txtDOB.CustomButton.Visible = False
        Me.txtDOB.DisplayIcon = True
        Me.txtDOB.Enabled = False
        Me.txtDOB.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDOB.Lines = New String(-1) {}
        Me.txtDOB.Location = New System.Drawing.Point(717, 100)
        Me.txtDOB.MaxLength = 30
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDOB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDOB.SelectedText = ""
        Me.txtDOB.SelectionLength = 0
        Me.txtDOB.SelectionStart = 0
        Me.txtDOB.Size = New System.Drawing.Size(131, 29)
        Me.txtDOB.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtDOB.TabIndex = 269
        Me.txtDOB.UseSelectable = True
        Me.txtDOB.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDOB.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(397, 1)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.DisplayIcon = True
        Me.txtAddress.Enabled = False
        Me.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAddress.Lines = New String(-1) {}
        Me.txtAddress.Location = New System.Drawing.Point(166, 100)
        Me.txtAddress.MaxLength = 30
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.Size = New System.Drawing.Size(425, 29)
        Me.txtAddress.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtAddress.TabIndex = 268
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(86, 1)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.DisplayIcon = True
        Me.MetroTextBox5.Enabled = False
        Me.MetroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox5.Lines = New String() {"Date of Birth"}
        Me.MetroTextBox5.Location = New System.Drawing.Point(597, 100)
        Me.MetroTextBox5.MaxLength = 8
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.Size = New System.Drawing.Size(114, 29)
        Me.MetroTextBox5.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox5.TabIndex = 271
        Me.MetroTextBox5.Text = "Date of Birth"
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox6
        '
        '
        '
        '
        Me.MetroTextBox6.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.MetroTextBox6.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.MetroTextBox6.CustomButton.Name = ""
        Me.MetroTextBox6.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox6.CustomButton.TabIndex = 1
        Me.MetroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox6.CustomButton.UseSelectable = True
        Me.MetroTextBox6.CustomButton.Visible = False
        Me.MetroTextBox6.DisplayIcon = True
        Me.MetroTextBox6.Enabled = False
        Me.MetroTextBox6.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox6.Lines = New String() {"Address"}
        Me.MetroTextBox6.Location = New System.Drawing.Point(30, 100)
        Me.MetroTextBox6.MaxLength = 8
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox6.SelectedText = ""
        Me.MetroTextBox6.SelectionLength = 0
        Me.MetroTextBox6.SelectionStart = 0
        Me.MetroTextBox6.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox6.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox6.TabIndex = 270
        Me.MetroTextBox6.Text = "Address"
        Me.MetroTextBox6.UseSelectable = True
        Me.MetroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox6.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtName
        '
        '
        '
        '
        Me.txtName.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.txtName.CustomButton.Location = New System.Drawing.Point(397, 1)
        Me.txtName.CustomButton.Name = ""
        Me.txtName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtName.CustomButton.TabIndex = 1
        Me.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtName.CustomButton.UseSelectable = True
        Me.txtName.CustomButton.Visible = False
        Me.txtName.DisplayIcon = True
        Me.txtName.Enabled = False
        Me.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtName.Lines = New String(-1) {}
        Me.txtName.Location = New System.Drawing.Point(166, 65)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.Size = New System.Drawing.Size(425, 29)
        Me.txtName.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtName.TabIndex = 264
        Me.txtName.UseSelectable = True
        Me.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(86, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.DisplayIcon = True
        Me.MetroTextBox2.Enabled = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox2.Lines = New String() {"Sex"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(597, 64)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(114, 29)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 267
        Me.MetroTextBox2.Text = "Sex"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.DisplayIcon = True
        Me.MetroTextBox1.Enabled = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String() {"Student Name"}
        Me.MetroTextBox1.Location = New System.Drawing.Point(30, 65)
        Me.MetroTextBox1.MaxLength = 8
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 266
        Me.MetroTextBox1.Text = "Student Name"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUniv
        '
        Me.txtUniv.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtUniv.CustomButton.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        Me.txtUniv.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtUniv.CustomButton.Name = ""
        Me.txtUniv.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtUniv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUniv.CustomButton.TabIndex = 1
        Me.txtUniv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUniv.CustomButton.UseSelectable = True
        Me.txtUniv.CustomButton.Visible = False
        Me.txtUniv.DisplayIcon = True
        Me.txtUniv.Enabled = False
        Me.txtUniv.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUniv.Lines = New String(-1) {}
        Me.txtUniv.Location = New System.Drawing.Point(166, 516)
        Me.txtUniv.MaxLength = 30
        Me.txtUniv.Name = "txtUniv"
        Me.txtUniv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUniv.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUniv.SelectedText = ""
        Me.txtUniv.SelectionLength = 0
        Me.txtUniv.SelectionStart = 0
        Me.txtUniv.Size = New System.Drawing.Size(130, 29)
        Me.txtUniv.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtUniv.TabIndex = 276
        Me.txtUniv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUniv.UseCustomBackColor = True
        Me.txtUniv.UseSelectable = True
        Me.txtUniv.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUniv.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox8
        '
        '
        '
        '
        Me.MetroTextBox8.CustomButton.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        Me.MetroTextBox8.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.MetroTextBox8.CustomButton.Name = ""
        Me.MetroTextBox8.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox8.CustomButton.TabIndex = 1
        Me.MetroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox8.CustomButton.UseSelectable = True
        Me.MetroTextBox8.CustomButton.Visible = False
        Me.MetroTextBox8.DisplayIcon = True
        Me.MetroTextBox8.Enabled = False
        Me.MetroTextBox8.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox8.Lines = New String() {"University Fees"}
        Me.MetroTextBox8.Location = New System.Drawing.Point(30, 516)
        Me.MetroTextBox8.MaxLength = 8
        Me.MetroTextBox8.Name = "MetroTextBox8"
        Me.MetroTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox8.SelectedText = ""
        Me.MetroTextBox8.SelectionLength = 0
        Me.MetroTextBox8.SelectionStart = 0
        Me.MetroTextBox8.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox8.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox8.TabIndex = 278
        Me.MetroTextBox8.Text = "University Fees"
        Me.MetroTextBox8.UseSelectable = True
        Me.MetroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox8.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtPrevBalance
        '
        Me.txtPrevBalance.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtPrevBalance.CustomButton.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        Me.txtPrevBalance.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtPrevBalance.CustomButton.Name = ""
        Me.txtPrevBalance.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPrevBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrevBalance.CustomButton.TabIndex = 1
        Me.txtPrevBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrevBalance.CustomButton.UseSelectable = True
        Me.txtPrevBalance.CustomButton.Visible = False
        Me.txtPrevBalance.DisplayIcon = True
        Me.txtPrevBalance.Enabled = False
        Me.txtPrevBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrevBalance.Lines = New String(-1) {}
        Me.txtPrevBalance.Location = New System.Drawing.Point(422, 157)
        Me.txtPrevBalance.MaxLength = 30
        Me.txtPrevBalance.Name = "txtPrevBalance"
        Me.txtPrevBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrevBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrevBalance.SelectedText = ""
        Me.txtPrevBalance.SelectionLength = 0
        Me.txtPrevBalance.SelectionStart = 0
        Me.txtPrevBalance.Size = New System.Drawing.Size(168, 29)
        Me.txtPrevBalance.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtPrevBalance.TabIndex = 272
        Me.txtPrevBalance.UseCustomBackColor = True
        Me.txtPrevBalance.UseSelectable = True
        Me.txtPrevBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrevBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox12
        '
        '
        '
        '
        Me.MetroTextBox12.CustomButton.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        Me.MetroTextBox12.CustomButton.Location = New System.Drawing.Point(87, 1)
        Me.MetroTextBox12.CustomButton.Name = ""
        Me.MetroTextBox12.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox12.CustomButton.TabIndex = 1
        Me.MetroTextBox12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox12.CustomButton.UseSelectable = True
        Me.MetroTextBox12.CustomButton.Visible = False
        Me.MetroTextBox12.DisplayIcon = True
        Me.MetroTextBox12.Enabled = False
        Me.MetroTextBox12.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox12.Lines = New String() {"Balance"}
        Me.MetroTextBox12.Location = New System.Drawing.Point(301, 157)
        Me.MetroTextBox12.MaxLength = 8
        Me.MetroTextBox12.Name = "MetroTextBox12"
        Me.MetroTextBox12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox12.SelectedText = ""
        Me.MetroTextBox12.SelectionLength = 0
        Me.MetroTextBox12.SelectionStart = 0
        Me.MetroTextBox12.Size = New System.Drawing.Size(115, 29)
        Me.MetroTextBox12.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox12.TabIndex = 274
        Me.MetroTextBox12.Text = "Balance"
        Me.MetroTextBox12.UseSelectable = True
        Me.MetroTextBox12.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox12.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'gvLocalFees
        '
        Me.gvLocalFees.AllowUserToAddRows = False
        Me.gvLocalFees.AllowUserToDeleteRows = False
        Me.gvLocalFees.AllowUserToResizeColumns = False
        Me.gvLocalFees.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvLocalFees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.gvLocalFees.BackgroundColor = System.Drawing.Color.White
        Me.gvLocalFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvLocalFees.ColumnHeadersHeight = 30
        Me.gvLocalFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvLocalFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.bool, Me.StudName, Me.amount, Me.ID2})
        Me.gvLocalFees.Enabled = False
        Me.gvLocalFees.EnableHeadersVisualStyles = False
        Me.gvLocalFees.Location = New System.Drawing.Point(30, 233)
        Me.gvLocalFees.MultiSelect = False
        Me.gvLocalFees.Name = "gvLocalFees"
        Me.gvLocalFees.RowHeadersVisible = False
        Me.gvLocalFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvLocalFees.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.gvLocalFees.RowTemplate.Height = 30
        Me.gvLocalFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvLocalFees.Size = New System.Drawing.Size(387, 240)
        Me.gvLocalFees.TabIndex = 281
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'bool
        '
        Me.bool.HeaderText = ""
        Me.bool.Name = "bool"
        Me.bool.ReadOnly = True
        Me.bool.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bool.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.bool.Width = 30
        '
        'StudName
        '
        Me.StudName.HeaderText = "Local Fees"
        Me.StudName.Name = "StudName"
        Me.StudName.ReadOnly = True
        Me.StudName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudName.Width = 253
        '
        'amount
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle10
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ID2
        '
        Me.ID2.HeaderText = "ID2"
        Me.ID2.Name = "ID2"
        Me.ID2.Visible = False
        '
        'gvUniv
        '
        Me.gvUniv.AllowUserToAddRows = False
        Me.gvUniv.AllowUserToDeleteRows = False
        Me.gvUniv.AllowUserToResizeColumns = False
        Me.gvUniv.AllowUserToResizeRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvUniv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.gvUniv.BackgroundColor = System.Drawing.Color.White
        Me.gvUniv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvUniv.ColumnHeadersHeight = 30
        Me.gvUniv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvUniv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Discount, Me.Total, Me.ID3})
        Me.gvUniv.Enabled = False
        Me.gvUniv.EnableHeadersVisualStyles = False
        Me.gvUniv.Location = New System.Drawing.Point(423, 233)
        Me.gvUniv.MultiSelect = False
        Me.gvUniv.Name = "gvUniv"
        Me.gvUniv.ReadOnly = True
        Me.gvUniv.RowHeadersVisible = False
        Me.gvUniv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvUniv.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.gvUniv.RowTemplate.Height = 30
        Me.gvUniv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvUniv.Size = New System.Drawing.Size(424, 240)
        Me.gvUniv.TabIndex = 282
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "University Fees"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'Discount
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Discount.DefaultCellStyle = DataGridViewCellStyle14
        Me.Discount.HeaderText = "Discount"
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        Me.Discount.Width = 80
        '
        'Total
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle15
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'ID3
        '
        Me.ID3.HeaderText = "ID3"
        Me.ID3.Name = "ID3"
        Me.ID3.ReadOnly = True
        Me.ID3.Visible = False
        '
        'txtSchoolYear
        '
        '
        '
        '
        Me.txtSchoolYear.CustomButton.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
        Me.txtSchoolYear.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtSchoolYear.CustomButton.Name = ""
        Me.txtSchoolYear.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtSchoolYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSchoolYear.CustomButton.TabIndex = 1
        Me.txtSchoolYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSchoolYear.CustomButton.UseSelectable = True
        Me.txtSchoolYear.CustomButton.Visible = False
        Me.txtSchoolYear.DisplayIcon = True
        Me.txtSchoolYear.Enabled = False
        Me.txtSchoolYear.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSchoolYear.Lines = New String(-1) {}
        Me.txtSchoolYear.Location = New System.Drawing.Point(166, 157)
        Me.txtSchoolYear.MaxLength = 30
        Me.txtSchoolYear.Name = "txtSchoolYear"
        Me.txtSchoolYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSchoolYear.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSchoolYear.SelectedText = ""
        Me.txtSchoolYear.SelectionLength = 0
        Me.txtSchoolYear.SelectionStart = 0
        Me.txtSchoolYear.Size = New System.Drawing.Size(130, 29)
        Me.txtSchoolYear.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSchoolYear.TabIndex = 285
        Me.txtSchoolYear.UseSelectable = True
        Me.txtSchoolYear.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSchoolYear.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox15
        '
        '
        '
        '
        Me.MetroTextBox15.CustomButton.Image = CType(resources.GetObject("resource.Image12"), System.Drawing.Image)
        Me.MetroTextBox15.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.MetroTextBox15.CustomButton.Name = ""
        Me.MetroTextBox15.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox15.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox15.CustomButton.TabIndex = 1
        Me.MetroTextBox15.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox15.CustomButton.UseSelectable = True
        Me.MetroTextBox15.CustomButton.Visible = False
        Me.MetroTextBox15.DisplayIcon = True
        Me.MetroTextBox15.Enabled = False
        Me.MetroTextBox15.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox15.Lines = New String() {"Grade Level"}
        Me.MetroTextBox15.Location = New System.Drawing.Point(30, 192)
        Me.MetroTextBox15.MaxLength = 8
        Me.MetroTextBox15.Name = "MetroTextBox15"
        Me.MetroTextBox15.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox15.SelectedText = ""
        Me.MetroTextBox15.SelectionLength = 0
        Me.MetroTextBox15.SelectionStart = 0
        Me.MetroTextBox15.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox15.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox15.TabIndex = 288
        Me.MetroTextBox15.Text = "Grade Level"
        Me.MetroTextBox15.UseSelectable = True
        Me.MetroTextBox15.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox15.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox16
        '
        '
        '
        '
        Me.MetroTextBox16.CustomButton.Image = CType(resources.GetObject("resource.Image13"), System.Drawing.Image)
        Me.MetroTextBox16.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.MetroTextBox16.CustomButton.Name = ""
        Me.MetroTextBox16.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox16.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox16.CustomButton.TabIndex = 1
        Me.MetroTextBox16.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox16.CustomButton.UseSelectable = True
        Me.MetroTextBox16.CustomButton.Visible = False
        Me.MetroTextBox16.DisplayIcon = True
        Me.MetroTextBox16.Enabled = False
        Me.MetroTextBox16.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox16.Lines = New String() {"School Year"}
        Me.MetroTextBox16.Location = New System.Drawing.Point(30, 157)
        Me.MetroTextBox16.MaxLength = 8
        Me.MetroTextBox16.Name = "MetroTextBox16"
        Me.MetroTextBox16.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox16.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox16.SelectedText = ""
        Me.MetroTextBox16.SelectionLength = 0
        Me.MetroTextBox16.SelectionStart = 0
        Me.MetroTextBox16.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox16.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox16.TabIndex = 287
        Me.MetroTextBox16.Text = "School Year"
        Me.MetroTextBox16.UseSelectable = True
        Me.MetroTextBox16.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox16.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtAssessedDate
        '
        '
        '
        '
        Me.txtAssessedDate.CustomButton.Image = CType(resources.GetObject("resource.Image14"), System.Drawing.Image)
        Me.txtAssessedDate.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtAssessedDate.CustomButton.Name = ""
        Me.txtAssessedDate.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtAssessedDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAssessedDate.CustomButton.TabIndex = 1
        Me.txtAssessedDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAssessedDate.CustomButton.UseSelectable = True
        Me.txtAssessedDate.CustomButton.Visible = False
        Me.txtAssessedDate.DisplayIcon = True
        Me.txtAssessedDate.Enabled = False
        Me.txtAssessedDate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAssessedDate.Lines = New String(-1) {}
        Me.txtAssessedDate.Location = New System.Drawing.Point(717, 157)
        Me.txtAssessedDate.MaxLength = 30
        Me.txtAssessedDate.Name = "txtAssessedDate"
        Me.txtAssessedDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssessedDate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAssessedDate.SelectedText = ""
        Me.txtAssessedDate.SelectionLength = 0
        Me.txtAssessedDate.SelectionStart = 0
        Me.txtAssessedDate.Size = New System.Drawing.Size(130, 29)
        Me.txtAssessedDate.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtAssessedDate.TabIndex = 283
        Me.txtAssessedDate.UseSelectable = True
        Me.txtAssessedDate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAssessedDate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox18
        '
        '
        '
        '
        Me.MetroTextBox18.CustomButton.Image = CType(resources.GetObject("resource.Image15"), System.Drawing.Image)
        Me.MetroTextBox18.CustomButton.Location = New System.Drawing.Point(87, 1)
        Me.MetroTextBox18.CustomButton.Name = ""
        Me.MetroTextBox18.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox18.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox18.CustomButton.TabIndex = 1
        Me.MetroTextBox18.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox18.CustomButton.UseSelectable = True
        Me.MetroTextBox18.CustomButton.Visible = False
        Me.MetroTextBox18.DisplayIcon = True
        Me.MetroTextBox18.Enabled = False
        Me.MetroTextBox18.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox18.Lines = New String() {"Assessed Date"}
        Me.MetroTextBox18.Location = New System.Drawing.Point(596, 157)
        Me.MetroTextBox18.MaxLength = 8
        Me.MetroTextBox18.Name = "MetroTextBox18"
        Me.MetroTextBox18.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox18.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox18.SelectedText = ""
        Me.MetroTextBox18.SelectionLength = 0
        Me.MetroTextBox18.SelectionStart = 0
        Me.MetroTextBox18.Size = New System.Drawing.Size(115, 29)
        Me.MetroTextBox18.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox18.TabIndex = 284
        Me.MetroTextBox18.Text = "Assessed Date"
        Me.MetroTextBox18.UseSelectable = True
        Me.MetroTextBox18.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox18.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSex
        '
        '
        '
        '
        Me.txtSex.CustomButton.Image = CType(resources.GetObject("resource.Image16"), System.Drawing.Image)
        Me.txtSex.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtSex.CustomButton.Name = ""
        Me.txtSex.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtSex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSex.CustomButton.TabIndex = 1
        Me.txtSex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSex.CustomButton.UseSelectable = True
        Me.txtSex.CustomButton.Visible = False
        Me.txtSex.DisplayIcon = True
        Me.txtSex.Enabled = False
        Me.txtSex.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSex.Lines = New String(-1) {}
        Me.txtSex.Location = New System.Drawing.Point(717, 65)
        Me.txtSex.MaxLength = 8
        Me.txtSex.Name = "txtSex"
        Me.txtSex.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSex.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSex.SelectedText = ""
        Me.txtSex.SelectionLength = 0
        Me.txtSex.SelectionStart = 0
        Me.txtSex.Size = New System.Drawing.Size(131, 29)
        Me.txtSex.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSex.TabIndex = 289
        Me.txtSex.UseSelectable = True
        Me.txtSex.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSex.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 565)
        Me.Panel1.TabIndex = 290
        '
        'txtLocal
        '
        Me.txtLocal.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtLocal.CustomButton.Image = CType(resources.GetObject("resource.Image17"), System.Drawing.Image)
        Me.txtLocal.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtLocal.CustomButton.Name = ""
        Me.txtLocal.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtLocal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLocal.CustomButton.TabIndex = 1
        Me.txtLocal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLocal.CustomButton.UseSelectable = True
        Me.txtLocal.CustomButton.Visible = False
        Me.txtLocal.DisplayIcon = True
        Me.txtLocal.Enabled = False
        Me.txtLocal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtLocal.Lines = New String(-1) {}
        Me.txtLocal.Location = New System.Drawing.Point(166, 481)
        Me.txtLocal.MaxLength = 30
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLocal.SelectedText = ""
        Me.txtLocal.SelectionLength = 0
        Me.txtLocal.SelectionStart = 0
        Me.txtLocal.Size = New System.Drawing.Size(130, 29)
        Me.txtLocal.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtLocal.TabIndex = 291
        Me.txtLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLocal.UseCustomBackColor = True
        Me.txtLocal.UseSelectable = True
        Me.txtLocal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLocal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox11
        '
        '
        '
        '
        Me.MetroTextBox11.CustomButton.Image = CType(resources.GetObject("resource.Image18"), System.Drawing.Image)
        Me.MetroTextBox11.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.MetroTextBox11.CustomButton.Name = ""
        Me.MetroTextBox11.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox11.CustomButton.TabIndex = 1
        Me.MetroTextBox11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox11.CustomButton.UseSelectable = True
        Me.MetroTextBox11.CustomButton.Visible = False
        Me.MetroTextBox11.DisplayIcon = True
        Me.MetroTextBox11.Enabled = False
        Me.MetroTextBox11.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox11.Lines = New String() {"Local Fees"}
        Me.MetroTextBox11.Location = New System.Drawing.Point(30, 481)
        Me.MetroTextBox11.MaxLength = 8
        Me.MetroTextBox11.Name = "MetroTextBox11"
        Me.MetroTextBox11.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox11.SelectedText = ""
        Me.MetroTextBox11.SelectionLength = 0
        Me.MetroTextBox11.SelectionStart = 0
        Me.MetroTextBox11.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox11.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox11.TabIndex = 292
        Me.MetroTextBox11.Text = "Local Fees"
        Me.MetroTextBox11.UseSelectable = True
        Me.MetroTextBox11.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox11.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = CType(resources.GetObject("resource.Image19"), System.Drawing.Image)
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(86, 1)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.DisplayIcon = True
        Me.MetroTextBox3.Enabled = False
        Me.MetroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox3.Lines = New String() {"Status"}
        Me.MetroTextBox3.Location = New System.Drawing.Point(301, 192)
        Me.MetroTextBox3.MaxLength = 30
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.Size = New System.Drawing.Size(114, 29)
        Me.MetroTextBox3.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox3.TabIndex = 294
        Me.MetroTextBox3.Text = "Status"
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtEnrolled
        '
        '
        '
        '
        Me.txtEnrolled.CustomButton.Image = CType(resources.GetObject("resource.Image20"), System.Drawing.Image)
        Me.txtEnrolled.CustomButton.Location = New System.Drawing.Point(141, 1)
        Me.txtEnrolled.CustomButton.Name = ""
        Me.txtEnrolled.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtEnrolled.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEnrolled.CustomButton.TabIndex = 1
        Me.txtEnrolled.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEnrolled.CustomButton.UseSelectable = True
        Me.txtEnrolled.CustomButton.Visible = False
        Me.txtEnrolled.DisplayIcon = True
        Me.txtEnrolled.Enabled = False
        Me.txtEnrolled.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtEnrolled.ForeColor = System.Drawing.Color.Red
        Me.txtEnrolled.Lines = New String(-1) {}
        Me.txtEnrolled.Location = New System.Drawing.Point(421, 192)
        Me.txtEnrolled.MaxLength = 30
        Me.txtEnrolled.Name = "txtEnrolled"
        Me.txtEnrolled.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEnrolled.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEnrolled.SelectedText = ""
        Me.txtEnrolled.SelectionLength = 0
        Me.txtEnrolled.SelectionStart = 0
        Me.txtEnrolled.Size = New System.Drawing.Size(169, 29)
        Me.txtEnrolled.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtEnrolled.TabIndex = 295
        Me.txtEnrolled.UseCustomForeColor = True
        Me.txtEnrolled.UseSelectable = True
        Me.txtEnrolled.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEnrolled.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtDOE
        '
        '
        '
        '
        Me.txtDOE.CustomButton.Image = CType(resources.GetObject("resource.Image21"), System.Drawing.Image)
        Me.txtDOE.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtDOE.CustomButton.Name = ""
        Me.txtDOE.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDOE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDOE.CustomButton.TabIndex = 1
        Me.txtDOE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDOE.CustomButton.UseSelectable = True
        Me.txtDOE.CustomButton.Visible = False
        Me.txtDOE.DisplayIcon = True
        Me.txtDOE.Enabled = False
        Me.txtDOE.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDOE.Lines = New String(-1) {}
        Me.txtDOE.Location = New System.Drawing.Point(717, 192)
        Me.txtDOE.MaxLength = 30
        Me.txtDOE.Name = "txtDOE"
        Me.txtDOE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDOE.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDOE.SelectedText = ""
        Me.txtDOE.SelectionLength = 0
        Me.txtDOE.SelectionStart = 0
        Me.txtDOE.Size = New System.Drawing.Size(130, 29)
        Me.txtDOE.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtDOE.TabIndex = 296
        Me.txtDOE.UseSelectable = True
        Me.txtDOE.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDOE.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox9
        '
        '
        '
        '
        Me.MetroTextBox9.CustomButton.Image = CType(resources.GetObject("resource.Image22"), System.Drawing.Image)
        Me.MetroTextBox9.CustomButton.Location = New System.Drawing.Point(87, 1)
        Me.MetroTextBox9.CustomButton.Name = ""
        Me.MetroTextBox9.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox9.CustomButton.TabIndex = 1
        Me.MetroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox9.CustomButton.UseSelectable = True
        Me.MetroTextBox9.CustomButton.Visible = False
        Me.MetroTextBox9.DisplayIcon = True
        Me.MetroTextBox9.Enabled = False
        Me.MetroTextBox9.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox9.Lines = New String() {"Enrolled Date"}
        Me.MetroTextBox9.Location = New System.Drawing.Point(597, 192)
        Me.MetroTextBox9.MaxLength = 8
        Me.MetroTextBox9.Name = "MetroTextBox9"
        Me.MetroTextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox9.SelectedText = ""
        Me.MetroTextBox9.SelectionLength = 0
        Me.MetroTextBox9.SelectionStart = 0
        Me.MetroTextBox9.Size = New System.Drawing.Size(115, 29)
        Me.MetroTextBox9.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox9.TabIndex = 297
        Me.MetroTextBox9.Text = "Enrolled Date"
        Me.MetroTextBox9.UseSelectable = True
        Me.MetroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox9.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnShow
        '
        Me.btnShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnShow.Enabled = False
        Me.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnShow.FlatAppearance.BorderSize = 0
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(872, 409)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(188, 50)
        Me.btnShow.TabIndex = 298
        Me.btnShow.Text = "SHOW ACCOUNTS"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'rb25
        '
        Me.rb25.AutoSize = True
        Me.rb25.Enabled = False
        Me.rb25.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb25.Location = New System.Drawing.Point(349, 518)
        Me.rb25.Margin = New System.Windows.Forms.Padding(0)
        Me.rb25.Name = "rb25"
        Me.rb25.Size = New System.Drawing.Size(55, 24)
        Me.rb25.TabIndex = 300
        Me.rb25.Text = "25%"
        Me.rb25.UseVisualStyleBackColor = True
        '
        'txtDiscounts
        '
        Me.txtDiscounts.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtDiscounts.CustomButton.Image = CType(resources.GetObject("resource.Image23"), System.Drawing.Image)
        Me.txtDiscounts.CustomButton.Location = New System.Drawing.Point(139, 1)
        Me.txtDiscounts.CustomButton.Name = ""
        Me.txtDiscounts.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDiscounts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDiscounts.CustomButton.TabIndex = 1
        Me.txtDiscounts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDiscounts.CustomButton.UseSelectable = True
        Me.txtDiscounts.CustomButton.Visible = False
        Me.txtDiscounts.DisplayIcon = True
        Me.txtDiscounts.Enabled = False
        Me.txtDiscounts.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDiscounts.Lines = New String(-1) {}
        Me.txtDiscounts.Location = New System.Drawing.Point(423, 551)
        Me.txtDiscounts.MaxLength = 30
        Me.txtDiscounts.Name = "txtDiscounts"
        Me.txtDiscounts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiscounts.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDiscounts.SelectedText = ""
        Me.txtDiscounts.SelectionLength = 0
        Me.txtDiscounts.SelectionStart = 0
        Me.txtDiscounts.Size = New System.Drawing.Size(167, 29)
        Me.txtDiscounts.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtDiscounts.TabIndex = 301
        Me.txtDiscounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiscounts.UseCustomBackColor = True
        Me.txtDiscounts.UseSelectable = True
        Me.txtDiscounts.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDiscounts.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox10
        '
        '
        '
        '
        Me.MetroTextBox10.CustomButton.Image = CType(resources.GetObject("resource.Image24"), System.Drawing.Image)
        Me.MetroTextBox10.CustomButton.Location = New System.Drawing.Point(260, 1)
        Me.MetroTextBox10.CustomButton.Name = ""
        Me.MetroTextBox10.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox10.CustomButton.TabIndex = 1
        Me.MetroTextBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox10.CustomButton.UseSelectable = True
        Me.MetroTextBox10.CustomButton.Visible = False
        Me.MetroTextBox10.DisplayIcon = True
        Me.MetroTextBox10.Enabled = False
        Me.MetroTextBox10.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox10.Lines = New String() {"Discounts For University Fees"}
        Me.MetroTextBox10.Location = New System.Drawing.Point(302, 481)
        Me.MetroTextBox10.MaxLength = 8
        Me.MetroTextBox10.Name = "MetroTextBox10"
        Me.MetroTextBox10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox10.SelectedText = ""
        Me.MetroTextBox10.SelectionLength = 0
        Me.MetroTextBox10.SelectionStart = 0
        Me.MetroTextBox10.Size = New System.Drawing.Size(288, 29)
        Me.MetroTextBox10.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox10.TabIndex = 302
        Me.MetroTextBox10.Text = "Discounts For University Fees"
        Me.MetroTextBox10.UseSelectable = True
        Me.MetroTextBox10.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox10.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rb50
        '
        Me.rb50.AutoSize = True
        Me.rb50.Enabled = False
        Me.rb50.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb50.Location = New System.Drawing.Point(404, 518)
        Me.rb50.Margin = New System.Windows.Forms.Padding(0)
        Me.rb50.Name = "rb50"
        Me.rb50.Size = New System.Drawing.Size(55, 24)
        Me.rb50.TabIndex = 303
        Me.rb50.Text = "50%"
        Me.rb50.UseVisualStyleBackColor = True
        '
        'rb100
        '
        Me.rb100.AutoSize = True
        Me.rb100.Enabled = False
        Me.rb100.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb100.Location = New System.Drawing.Point(514, 518)
        Me.rb100.Margin = New System.Windows.Forms.Padding(0)
        Me.rb100.Name = "rb100"
        Me.rb100.Size = New System.Drawing.Size(63, 24)
        Me.rb100.TabIndex = 305
        Me.rb100.Text = "100%"
        Me.rb100.UseVisualStyleBackColor = True
        '
        'rb75
        '
        Me.rb75.AutoSize = True
        Me.rb75.Enabled = False
        Me.rb75.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb75.Location = New System.Drawing.Point(459, 518)
        Me.rb75.Margin = New System.Windows.Forms.Padding(0)
        Me.rb75.Name = "rb75"
        Me.rb75.Size = New System.Drawing.Size(55, 24)
        Me.rb75.TabIndex = 304
        Me.rb75.Text = "75%"
        Me.rb75.UseVisualStyleBackColor = True
        '
        'txtGL
        '
        '
        '
        '
        Me.txtGL.CustomButton.Image = CType(resources.GetObject("resource.Image25"), System.Drawing.Image)
        Me.txtGL.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtGL.CustomButton.Name = ""
        Me.txtGL.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtGL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGL.CustomButton.TabIndex = 1
        Me.txtGL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGL.CustomButton.UseSelectable = True
        Me.txtGL.CustomButton.Visible = False
        Me.txtGL.DisplayIcon = True
        Me.txtGL.Enabled = False
        Me.txtGL.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtGL.Lines = New String(-1) {}
        Me.txtGL.Location = New System.Drawing.Point(166, 192)
        Me.txtGL.MaxLength = 30
        Me.txtGL.Name = "txtGL"
        Me.txtGL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGL.SelectedText = ""
        Me.txtGL.SelectionLength = 0
        Me.txtGL.SelectionStart = 0
        Me.txtGL.Size = New System.Drawing.Size(130, 29)
        Me.txtGL.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtGL.TabIndex = 308
        Me.txtGL.UseSelectable = True
        Me.txtGL.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGL.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Enabled = False
        Me.rbNo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNo.Location = New System.Drawing.Point(302, 518)
        Me.rbNo.Margin = New System.Windows.Forms.Padding(0)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(47, 24)
        Me.rbNo.TabIndex = 309
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtTotal.CustomButton.Image = CType(resources.GetObject("resource.Image26"), System.Drawing.Image)
        Me.txtTotal.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.txtTotal.CustomButton.Name = ""
        Me.txtTotal.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotal.CustomButton.TabIndex = 1
        Me.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotal.CustomButton.UseSelectable = True
        Me.txtTotal.CustomButton.Visible = False
        Me.txtTotal.DisplayIcon = True
        Me.txtTotal.Enabled = False
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTotal.Lines = New String(-1) {}
        Me.txtTotal.Location = New System.Drawing.Point(166, 551)
        Me.txtTotal.MaxLength = 30
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.SelectionLength = 0
        Me.txtTotal.SelectionStart = 0
        Me.txtTotal.Size = New System.Drawing.Size(130, 29)
        Me.txtTotal.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtTotal.TabIndex = 310
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.UseCustomBackColor = True
        Me.txtTotal.UseSelectable = True
        Me.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox13
        '
        '
        '
        '
        Me.MetroTextBox13.CustomButton.Image = CType(resources.GetObject("resource.Image27"), System.Drawing.Image)
        Me.MetroTextBox13.CustomButton.Location = New System.Drawing.Point(102, 1)
        Me.MetroTextBox13.CustomButton.Name = ""
        Me.MetroTextBox13.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox13.CustomButton.TabIndex = 1
        Me.MetroTextBox13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox13.CustomButton.UseSelectable = True
        Me.MetroTextBox13.CustomButton.Visible = False
        Me.MetroTextBox13.DisplayIcon = True
        Me.MetroTextBox13.Enabled = False
        Me.MetroTextBox13.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox13.Lines = New String() {"Total Fees"}
        Me.MetroTextBox13.Location = New System.Drawing.Point(30, 551)
        Me.MetroTextBox13.MaxLength = 8
        Me.MetroTextBox13.Name = "MetroTextBox13"
        Me.MetroTextBox13.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox13.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox13.SelectedText = ""
        Me.MetroTextBox13.SelectionLength = 0
        Me.MetroTextBox13.SelectionStart = 0
        Me.MetroTextBox13.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox13.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox13.TabIndex = 311
        Me.MetroTextBox13.Text = "Total Fees"
        Me.MetroTextBox13.UseSelectable = True
        Me.MetroTextBox13.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox13.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox17
        '
        '
        '
        '
        Me.MetroTextBox17.CustomButton.Image = CType(resources.GetObject("resource.Image28"), System.Drawing.Image)
        Me.MetroTextBox17.CustomButton.Location = New System.Drawing.Point(87, 1)
        Me.MetroTextBox17.CustomButton.Name = ""
        Me.MetroTextBox17.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox17.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox17.CustomButton.TabIndex = 1
        Me.MetroTextBox17.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox17.CustomButton.UseSelectable = True
        Me.MetroTextBox17.CustomButton.Visible = False
        Me.MetroTextBox17.DisplayIcon = True
        Me.MetroTextBox17.Enabled = False
        Me.MetroTextBox17.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox17.Lines = New String() {"Discounts"}
        Me.MetroTextBox17.Location = New System.Drawing.Point(302, 551)
        Me.MetroTextBox17.MaxLength = 8
        Me.MetroTextBox17.Name = "MetroTextBox17"
        Me.MetroTextBox17.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox17.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox17.SelectedText = ""
        Me.MetroTextBox17.SelectionLength = 0
        Me.MetroTextBox17.SelectionStart = 0
        Me.MetroTextBox17.Size = New System.Drawing.Size(115, 29)
        Me.MetroTextBox17.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox17.TabIndex = 312
        Me.MetroTextBox17.Text = "Discounts"
        Me.MetroTextBox17.UseSelectable = True
        Me.MetroTextBox17.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox17.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(596, 510)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(251, 70)
        Me.txtTotalAmount.TabIndex = 313
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(596, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 25)
        Me.Label1.TabIndex = 314
        Me.Label1.Text = "Total Assessed Amount"
        '
        'frmAssessment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1085, 645)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.MetroTextBox12)
        Me.Controls.Add(Me.MetroTextBox17)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.MetroTextBox13)
        Me.Controls.Add(Me.rbNo)
        Me.Controls.Add(Me.txtGL)
        Me.Controls.Add(Me.rb100)
        Me.Controls.Add(Me.rb75)
        Me.Controls.Add(Me.rb50)
        Me.Controls.Add(Me.txtDiscounts)
        Me.Controls.Add(Me.MetroTextBox10)
        Me.Controls.Add(Me.rb25)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtDOE)
        Me.Controls.Add(Me.MetroTextBox9)
        Me.Controls.Add(Me.txtEnrolled)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.MetroTextBox11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtSchoolYear)
        Me.Controls.Add(Me.MetroTextBox15)
        Me.Controls.Add(Me.MetroTextBox16)
        Me.Controls.Add(Me.txtAssessedDate)
        Me.Controls.Add(Me.MetroTextBox18)
        Me.Controls.Add(Me.gvUniv)
        Me.Controls.Add(Me.gvLocalFees)
        Me.Controls.Add(Me.txtUniv)
        Me.Controls.Add(Me.MetroTextBox8)
        Me.Controls.Add(Me.txtPrevBalance)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.MetroTextBox6)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAssess)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnAddToEnrollment)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAssessment"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.gvLocalFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUniv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnAddToEnrollment As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAssess As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDOB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUniv As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox8 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrevBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox12 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gvLocalFees As System.Windows.Forms.DataGridView
    Friend WithEvents gvUniv As System.Windows.Forms.DataGridView
    Friend WithEvents txtSchoolYear As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox15 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox16 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAssessedDate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox18 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSex As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtLocal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox11 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEnrolled As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDOE As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox9 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents rb25 As System.Windows.Forms.RadioButton
    Friend WithEvents txtDiscounts As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox10 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rb50 As System.Windows.Forms.RadioButton
    Friend WithEvents rb100 As System.Windows.Forms.RadioButton
    Friend WithEvents rb75 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtGL As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rbNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox13 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox17 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bool As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StudName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
