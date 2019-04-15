<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditUser))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtGradeLevel = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtLN = New MetroFramework.Controls.MetroTextBox()
        Me.txtFN = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.cboType = New MetroFramework.Controls.MetroComboBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(33, 268)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(125, 40)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(295, 268)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 40)
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(164, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 40)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 296)
        Me.Panel14.TabIndex = 241
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(451, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 296)
        Me.Panel15.TabIndex = 240
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 40)
        Me.Panel2.TabIndex = 239
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(171, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "EDIT ACCOUNT"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 336)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(452, 40)
        Me.Panel12.TabIndex = 238
        '
        'txtGradeLevel
        '
        '
        '
        '
        Me.txtGradeLevel.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtGradeLevel.CustomButton.Location = New System.Drawing.Point(97, 2)
        Me.txtGradeLevel.CustomButton.Name = ""
        Me.txtGradeLevel.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtGradeLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGradeLevel.CustomButton.TabIndex = 1
        Me.txtGradeLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGradeLevel.CustomButton.UseSelectable = True
        Me.txtGradeLevel.CustomButton.Visible = False
        Me.txtGradeLevel.DisplayIcon = True
        Me.txtGradeLevel.Enabled = False
        Me.txtGradeLevel.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtGradeLevel.Lines = New String() {"User Type"}
        Me.txtGradeLevel.Location = New System.Drawing.Point(33, 214)
        Me.txtGradeLevel.MaxLength = 8
        Me.txtGradeLevel.Name = "txtGradeLevel"
        Me.txtGradeLevel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGradeLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGradeLevel.SelectedText = ""
        Me.txtGradeLevel.SelectionLength = 0
        Me.txtGradeLevel.SelectionStart = 0
        Me.txtGradeLevel.Size = New System.Drawing.Size(125, 30)
        Me.txtGradeLevel.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtGradeLevel.TabIndex = 242
        Me.txtGradeLevel.Text = "User Type"
        Me.txtGradeLevel.UseSelectable = True
        Me.txtGradeLevel.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGradeLevel.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(97, 2)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.DisplayIcon = True
        Me.MetroTextBox1.Enabled = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String() {"First Name"}
        Me.MetroTextBox1.Location = New System.Drawing.Point(33, 70)
        Me.MetroTextBox1.MaxLength = 8
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(125, 30)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 243
        Me.MetroTextBox1.Text = "First Name"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(97, 2)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.DisplayIcon = True
        Me.MetroTextBox2.Enabled = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox2.Lines = New String() {"Last Name"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(33, 106)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(125, 30)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 244
        Me.MetroTextBox2.Text = "Last Name"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtLN
        '
        '
        '
        '
        Me.txtLN.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.txtLN.CustomButton.Location = New System.Drawing.Point(228, 2)
        Me.txtLN.CustomButton.Name = ""
        Me.txtLN.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtLN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLN.CustomButton.TabIndex = 1
        Me.txtLN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLN.CustomButton.UseSelectable = True
        Me.txtLN.CustomButton.Visible = False
        Me.txtLN.DisplayIcon = True
        Me.txtLN.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtLN.Lines = New String(-1) {}
        Me.txtLN.Location = New System.Drawing.Point(164, 106)
        Me.txtLN.MaxLength = 30
        Me.txtLN.Name = "txtLN"
        Me.txtLN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLN.SelectedText = ""
        Me.txtLN.SelectionLength = 0
        Me.txtLN.SelectionStart = 0
        Me.txtLN.Size = New System.Drawing.Size(256, 30)
        Me.txtLN.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtLN.TabIndex = 2
        Me.txtLN.UseSelectable = True
        Me.txtLN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtFN
        '
        '
        '
        '
        Me.txtFN.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.txtFN.CustomButton.Location = New System.Drawing.Point(228, 2)
        Me.txtFN.CustomButton.Name = ""
        Me.txtFN.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtFN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFN.CustomButton.TabIndex = 1
        Me.txtFN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFN.CustomButton.UseSelectable = True
        Me.txtFN.CustomButton.Visible = False
        Me.txtFN.DisplayIcon = True
        Me.txtFN.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFN.Lines = New String(-1) {}
        Me.txtFN.Location = New System.Drawing.Point(164, 70)
        Me.txtFN.MaxLength = 30
        Me.txtFN.Name = "txtFN"
        Me.txtFN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFN.SelectedText = ""
        Me.txtFN.SelectionLength = 0
        Me.txtFN.SelectionStart = 0
        Me.txtFN.Size = New System.Drawing.Size(256, 30)
        Me.txtFN.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtFN.TabIndex = 1
        Me.txtFN.UseSelectable = True
        Me.txtFN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(228, 2)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.DisplayIcon = True
        Me.txtPassword.Enabled = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(164, 178)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(256, 30)
        Me.txtPassword.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtPassword.TabIndex = 246
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(228, 2)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.DisplayIcon = True
        Me.txtUsername.Enabled = False
        Me.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(164, 142)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(256, 30)
        Me.txtUsername.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtUsername.TabIndex = 245
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(97, 2)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.DisplayIcon = True
        Me.MetroTextBox5.Enabled = False
        Me.MetroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox5.Lines = New String() {"Password"}
        Me.MetroTextBox5.Location = New System.Drawing.Point(33, 178)
        Me.MetroTextBox5.MaxLength = 8
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.Size = New System.Drawing.Size(125, 30)
        Me.MetroTextBox5.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox5.TabIndex = 248
        Me.MetroTextBox5.Text = "Password"
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox6
        '
        '
        '
        '
        Me.MetroTextBox6.CustomButton.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        Me.MetroTextBox6.CustomButton.Location = New System.Drawing.Point(97, 2)
        Me.MetroTextBox6.CustomButton.Name = ""
        Me.MetroTextBox6.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox6.CustomButton.TabIndex = 1
        Me.MetroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox6.CustomButton.UseSelectable = True
        Me.MetroTextBox6.CustomButton.Visible = False
        Me.MetroTextBox6.DisplayIcon = True
        Me.MetroTextBox6.Enabled = False
        Me.MetroTextBox6.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox6.Lines = New String() {"Username"}
        Me.MetroTextBox6.Location = New System.Drawing.Point(33, 142)
        Me.MetroTextBox6.MaxLength = 8
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox6.SelectedText = ""
        Me.MetroTextBox6.SelectionLength = 0
        Me.MetroTextBox6.SelectionStart = 0
        Me.MetroTextBox6.Size = New System.Drawing.Size(125, 30)
        Me.MetroTextBox6.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox6.TabIndex = 247
        Me.MetroTextBox6.Text = "Username"
        Me.MetroTextBox6.UseSelectable = True
        Me.MetroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox6.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.ItemHeight = 23
        Me.cboType.Items.AddRange(New Object() {"Adviser", "Assessor", "Cashier"})
        Me.cboType.Location = New System.Drawing.Point(164, 215)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(256, 29)
        Me.cboType.TabIndex = 250
        Me.cboType.UseSelectable = True
        '
        'frmEditUser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(452, 376)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.MetroTextBox6)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.txtGradeLevel)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditUser"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents txtGradeLevel As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboType As MetroFramework.Controls.MetroComboBox

End Class
