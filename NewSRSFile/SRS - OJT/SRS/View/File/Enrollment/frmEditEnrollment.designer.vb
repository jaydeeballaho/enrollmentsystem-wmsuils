<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditEnrollment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditEnrollment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cboGradeLvl = New MetroFramework.Controls.MetroComboBox()
        Me.txtSY = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox15 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox16 = New MetroFramework.Controls.MetroTextBox()
        Me.txtBalance = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox12 = New MetroFramework.Controls.MetroTextBox()
        Me.txtSurname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboSection = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.gvSubject = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subjectname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvClass1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboRoom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2.SuspendLayout()
        CType(Me.gvSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvClass1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 478)
        Me.Panel1.TabIndex = 294
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 518)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(849, 40)
        Me.Panel12.TabIndex = 291
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(849, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 518)
        Me.Panel15.TabIndex = 293
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(850, 40)
        Me.Panel2.TabIndex = 292
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(338, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(174, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "EDIT STUDENT ADVISING"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'cboGradeLvl
        '
        Me.cboGradeLvl.FormattingEnabled = True
        Me.cboGradeLvl.ItemHeight = 23
        Me.cboGradeLvl.Location = New System.Drawing.Point(166, 137)
        Me.cboGradeLvl.Name = "cboGradeLvl"
        Me.cboGradeLvl.PromptText = "-Select Grade Level-"
        Me.cboGradeLvl.Size = New System.Drawing.Size(256, 29)
        Me.cboGradeLvl.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboGradeLvl.TabIndex = 302
        Me.cboGradeLvl.UseSelectable = True
        '
        'txtSY
        '
        '
        '
        '
        Me.txtSY.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtSY.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtSY.CustomButton.Name = ""
        Me.txtSY.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtSY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSY.CustomButton.TabIndex = 1
        Me.txtSY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSY.CustomButton.UseSelectable = True
        Me.txtSY.CustomButton.Visible = False
        Me.txtSY.DisplayIcon = True
        Me.txtSY.Enabled = False
        Me.txtSY.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSY.Lines = New String(-1) {}
        Me.txtSY.Location = New System.Drawing.Point(564, 102)
        Me.txtSY.MaxLength = 30
        Me.txtSY.Name = "txtSY"
        Me.txtSY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSY.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSY.SelectedText = ""
        Me.txtSY.SelectionLength = 0
        Me.txtSY.SelectionStart = 0
        Me.txtSY.Size = New System.Drawing.Size(256, 29)
        Me.txtSY.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSY.TabIndex = 299
        Me.txtSY.UseSelectable = True
        Me.txtSY.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSY.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox15
        '
        '
        '
        '
        Me.MetroTextBox15.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
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
        Me.MetroTextBox15.Location = New System.Drawing.Point(30, 137)
        Me.MetroTextBox15.MaxLength = 8
        Me.MetroTextBox15.Name = "MetroTextBox15"
        Me.MetroTextBox15.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox15.SelectedText = ""
        Me.MetroTextBox15.SelectionLength = 0
        Me.MetroTextBox15.SelectionStart = 0
        Me.MetroTextBox15.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox15.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox15.TabIndex = 301
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
        Me.MetroTextBox16.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
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
        Me.MetroTextBox16.Location = New System.Drawing.Point(428, 102)
        Me.MetroTextBox16.MaxLength = 8
        Me.MetroTextBox16.Name = "MetroTextBox16"
        Me.MetroTextBox16.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox16.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox16.SelectedText = ""
        Me.MetroTextBox16.SelectionLength = 0
        Me.MetroTextBox16.SelectionStart = 0
        Me.MetroTextBox16.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox16.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox16.TabIndex = 300
        Me.MetroTextBox16.Text = "School Year"
        Me.MetroTextBox16.UseSelectable = True
        Me.MetroTextBox16.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox16.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtBalance.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.txtBalance.CustomButton.Location = New System.Drawing.Point(228, 1)
        Me.txtBalance.CustomButton.Name = ""
        Me.txtBalance.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBalance.CustomButton.TabIndex = 1
        Me.txtBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBalance.CustomButton.UseSelectable = True
        Me.txtBalance.CustomButton.Visible = False
        Me.txtBalance.DisplayIcon = True
        Me.txtBalance.Enabled = False
        Me.txtBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBalance.Lines = New String(-1) {}
        Me.txtBalance.Location = New System.Drawing.Point(166, 102)
        Me.txtBalance.MaxLength = 30
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBalance.SelectedText = ""
        Me.txtBalance.SelectionLength = 0
        Me.txtBalance.SelectionStart = 0
        Me.txtBalance.Size = New System.Drawing.Size(256, 29)
        Me.txtBalance.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtBalance.TabIndex = 297
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBalance.UseCustomBackColor = True
        Me.txtBalance.UseSelectable = True
        Me.txtBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox12
        '
        '
        '
        '
        Me.MetroTextBox12.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.MetroTextBox12.CustomButton.Location = New System.Drawing.Point(102, 1)
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
        Me.MetroTextBox12.Location = New System.Drawing.Point(30, 102)
        Me.MetroTextBox12.MaxLength = 8
        Me.MetroTextBox12.Name = "MetroTextBox12"
        Me.MetroTextBox12.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox12.SelectedText = ""
        Me.MetroTextBox12.SelectionLength = 0
        Me.MetroTextBox12.SelectionStart = 0
        Me.MetroTextBox12.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox12.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox12.TabIndex = 298
        Me.MetroTextBox12.Text = "Balance"
        Me.MetroTextBox12.UseSelectable = True
        Me.MetroTextBox12.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox12.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSurname
        '
        '
        '
        '
        Me.txtSurname.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.txtSurname.CustomButton.Location = New System.Drawing.Point(626, 1)
        Me.txtSurname.CustomButton.Name = ""
        Me.txtSurname.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSurname.CustomButton.TabIndex = 1
        Me.txtSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSurname.CustomButton.UseSelectable = True
        Me.txtSurname.CustomButton.Visible = False
        Me.txtSurname.DisplayIcon = True
        Me.txtSurname.Enabled = False
        Me.txtSurname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSurname.Lines = New String(-1) {}
        Me.txtSurname.Location = New System.Drawing.Point(166, 67)
        Me.txtSurname.MaxLength = 30
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.SelectionLength = 0
        Me.txtSurname.SelectionStart = 0
        Me.txtSurname.Size = New System.Drawing.Size(654, 29)
        Me.txtSurname.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSurname.TabIndex = 295
        Me.txtSurname.UseSelectable = True
        Me.txtSurname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSurname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.MetroTextBox1.Location = New System.Drawing.Point(30, 67)
        Me.MetroTextBox1.MaxLength = 8
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 296
        Me.MetroTextBox1.Text = "Student Name"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(564, 456)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 40)
        Me.btnSave.TabIndex = 303
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(695, 456)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 40)
        Me.btnClose.TabIndex = 304
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(428, 456)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 40)
        Me.btnUpdate.TabIndex = 305
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'cboSection
        '
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.ItemHeight = 23
        Me.cboSection.Location = New System.Drawing.Point(564, 137)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.PromptText = "-Select Section-"
        Me.cboSection.Size = New System.Drawing.Size(256, 29)
        Me.cboSection.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboSection.TabIndex = 313
        Me.cboSection.UseSelectable = True
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(102, 1)
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
        Me.MetroTextBox2.Lines = New String() {"Section"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(428, 137)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(130, 29)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 312
        Me.MetroTextBox2.Text = "Section"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'gvSubject
        '
        Me.gvSubject.AllowUserToAddRows = False
        Me.gvSubject.AllowUserToDeleteRows = False
        Me.gvSubject.AllowUserToResizeColumns = False
        Me.gvSubject.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvSubject.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvSubject.BackgroundColor = System.Drawing.Color.White
        Me.gvSubject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvSubject.ColumnHeadersHeight = 30
        Me.gvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvSubject.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.subjectname})
        Me.gvSubject.EnableHeadersVisualStyles = False
        Me.gvSubject.Location = New System.Drawing.Point(428, 440)
        Me.gvSubject.MultiSelect = False
        Me.gvSubject.Name = "gvSubject"
        Me.gvSubject.ReadOnly = True
        Me.gvSubject.RowHeadersVisible = False
        Me.gvSubject.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvSubject.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gvSubject.RowTemplate.Height = 30
        Me.gvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvSubject.Size = New System.Drawing.Size(392, 33)
        Me.gvSubject.TabIndex = 314
        Me.gvSubject.Visible = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'subjectname
        '
        Me.subjectname.HeaderText = "Subject Name"
        Me.subjectname.Name = "subjectname"
        Me.subjectname.ReadOnly = True
        Me.subjectname.Width = 335
        '
        'gvClass1
        '
        Me.gvClass1.AllowUserToAddRows = False
        Me.gvClass1.AllowUserToDeleteRows = False
        Me.gvClass1.AllowUserToResizeColumns = False
        Me.gvClass1.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro
        Me.gvClass1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gvClass1.BackgroundColor = System.Drawing.Color.White
        Me.gvClass1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvClass1.ColumnHeadersHeight = 30
        Me.gvClass1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvClass1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.gvcboSubject, Me.gvcboDay, Me.gvcboStart, Me.gvcboEnd, Me.gvcboRoom})
        Me.gvClass1.Enabled = False
        Me.gvClass1.EnableHeadersVisualStyles = False
        Me.gvClass1.GridColor = System.Drawing.Color.White
        Me.gvClass1.Location = New System.Drawing.Point(30, 200)
        Me.gvClass1.MultiSelect = False
        Me.gvClass1.Name = "gvClass1"
        Me.gvClass1.ReadOnly = True
        Me.gvClass1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvClass1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gvClass1.RowHeadersVisible = False
        Me.gvClass1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.gvClass1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gvClass1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvClass1.Size = New System.Drawing.Size(790, 250)
        Me.gvClass1.TabIndex = 316
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = ""
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 20
        '
        'gvcboSubject
        '
        Me.gvcboSubject.HeaderText = "Subject"
        Me.gvcboSubject.Name = "gvcboSubject"
        Me.gvcboSubject.ReadOnly = True
        Me.gvcboSubject.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcboSubject.Width = 185
        '
        'gvcboDay
        '
        Me.gvcboDay.HeaderText = "Day"
        Me.gvcboDay.Name = "gvcboDay"
        Me.gvcboDay.ReadOnly = True
        Me.gvcboDay.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcboDay.Width = 150
        '
        'gvcboStart
        '
        Me.gvcboStart.HeaderText = "Start Time"
        Me.gvcboStart.Name = "gvcboStart"
        Me.gvcboStart.ReadOnly = True
        Me.gvcboStart.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcboStart.Width = 150
        '
        'gvcboEnd
        '
        Me.gvcboEnd.HeaderText = "End Time"
        Me.gvcboEnd.Name = "gvcboEnd"
        Me.gvcboEnd.ReadOnly = True
        Me.gvcboEnd.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcboEnd.Width = 150
        '
        'gvcboRoom
        '
        Me.gvcboRoom.HeaderText = "Room"
        Me.gvcboRoom.Name = "gvcboRoom"
        Me.gvcboRoom.ReadOnly = True
        Me.gvcboRoom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcboRoom.Width = 150
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel2.Location = New System.Drawing.Point(30, 173)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(124, 19)
        Me.MetroLabel2.TabIndex = 315
        Me.MetroLabel2.Text = "CLASS SCHEDULE"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'frmEditEnrollment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 558)
        Me.Controls.Add(Me.gvClass1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.gvSubject)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.cboGradeLvl)
        Me.Controls.Add(Me.txtSY)
        Me.Controls.Add(Me.MetroTextBox15)
        Me.Controls.Add(Me.MetroTextBox16)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.MetroTextBox12)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditEnrollment"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.gvSubject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvClass1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboGradeLvl As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSY As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox15 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox16 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox12 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSurname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cboSection As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gvSubject As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subjectname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvClass1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboRoom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel

End Class
