<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayAccounts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtChange = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtReceived = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox8 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAssessed = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtChanged = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtOR = New MetroFramework.Controls.MetroTextBox()
        Me.gvFees = New System.Windows.Forms.DataGridView()
        Me.txtDate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.txtBy = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Balances = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.gvFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 512)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(981, 40)
        Me.Panel12.TabIndex = 260
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(981, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 512)
        Me.Panel15.TabIndex = 262
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 40)
        Me.Panel2.TabIndex = 261
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(428, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "PAY ACCOUNTS"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 472)
        Me.Panel1.TabIndex = 290
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Gray
        Me.btnPay.Enabled = False
        Me.btnPay.FlatAppearance.BorderSize = 0
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(706, 440)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(120, 50)
        Me.btnPay.TabIndex = 3
        Me.btnPay.TabStop = False
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtChange.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtChange.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtChange.CustomButton.Name = ""
        Me.txtChange.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtChange.CustomButton.TabIndex = 1
        Me.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtChange.CustomButton.UseSelectable = True
        Me.txtChange.CustomButton.Visible = False
        Me.txtChange.DisplayIcon = True
        Me.txtChange.Enabled = False
        Me.txtChange.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtChange.Lines = New String() {"0.00"}
        Me.txtChange.Location = New System.Drawing.Point(706, 385)
        Me.txtChange.MaxLength = 10
        Me.txtChange.Name = "txtChange"
        Me.txtChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtChange.SelectedText = ""
        Me.txtChange.SelectionLength = 0
        Me.txtChange.SelectionStart = 0
        Me.txtChange.Size = New System.Drawing.Size(250, 38)
        Me.txtChange.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtChange.TabIndex = 7
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange.UseCustomBackColor = True
        Me.txtChange.UseSelectable = True
        Me.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtChange.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.DisplayIcon = True
        Me.MetroTextBox5.Enabled = False
        Me.MetroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox5.Lines = New String() {"Changed"}
        Me.MetroTextBox5.Location = New System.Drawing.Point(500, 385)
        Me.MetroTextBox5.MaxLength = 8
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox5.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox5.TabIndex = 6
        Me.MetroTextBox5.Text = "Changed"
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(836, 440)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 50)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtReceived
        '
        Me.txtReceived.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtReceived.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.txtReceived.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtReceived.CustomButton.Name = ""
        Me.txtReceived.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtReceived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReceived.CustomButton.TabIndex = 1
        Me.txtReceived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReceived.CustomButton.UseSelectable = True
        Me.txtReceived.CustomButton.Visible = False
        Me.txtReceived.DisplayIcon = True
        Me.txtReceived.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtReceived.Lines = New String() {"0.00"}
        Me.txtReceived.Location = New System.Drawing.Point(706, 341)
        Me.txtReceived.MaxLength = 10
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReceived.SelectedText = ""
        Me.txtReceived.SelectionLength = 0
        Me.txtReceived.SelectionStart = 0
        Me.txtReceived.Size = New System.Drawing.Size(250, 38)
        Me.txtReceived.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtReceived.TabIndex = 2
        Me.txtReceived.Text = "0.00"
        Me.txtReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtReceived.UseCustomBackColor = True
        Me.txtReceived.UseSelectable = True
        Me.txtReceived.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReceived.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox8
        '
        '
        '
        '
        Me.MetroTextBox8.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.MetroTextBox8.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox8.CustomButton.Name = ""
        Me.MetroTextBox8.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox8.CustomButton.TabIndex = 1
        Me.MetroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox8.CustomButton.UseSelectable = True
        Me.MetroTextBox8.CustomButton.Visible = False
        Me.MetroTextBox8.DisplayIcon = True
        Me.MetroTextBox8.Enabled = False
        Me.MetroTextBox8.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox8.Lines = New String() {"Amount Received"}
        Me.MetroTextBox8.Location = New System.Drawing.Point(500, 341)
        Me.MetroTextBox8.MaxLength = 8
        Me.MetroTextBox8.Name = "MetroTextBox8"
        Me.MetroTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox8.SelectedText = ""
        Me.MetroTextBox8.SelectionLength = 0
        Me.MetroTextBox8.SelectionStart = 0
        Me.MetroTextBox8.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox8.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox8.TabIndex = 2
        Me.MetroTextBox8.Text = "Amount Received"
        Me.MetroTextBox8.UseSelectable = True
        Me.MetroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox8.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtAssessed
        '
        Me.txtAssessed.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtAssessed.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.txtAssessed.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtAssessed.CustomButton.Name = ""
        Me.txtAssessed.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtAssessed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAssessed.CustomButton.TabIndex = 1
        Me.txtAssessed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAssessed.CustomButton.UseSelectable = True
        Me.txtAssessed.CustomButton.Visible = False
        Me.txtAssessed.DisplayIcon = True
        Me.txtAssessed.Enabled = False
        Me.txtAssessed.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAssessed.Lines = New String() {"0.00"}
        Me.txtAssessed.Location = New System.Drawing.Point(706, 297)
        Me.txtAssessed.MaxLength = 10
        Me.txtAssessed.Name = "txtAssessed"
        Me.txtAssessed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssessed.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAssessed.SelectedText = ""
        Me.txtAssessed.SelectionLength = 0
        Me.txtAssessed.SelectionStart = 0
        Me.txtAssessed.Size = New System.Drawing.Size(250, 38)
        Me.txtAssessed.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtAssessed.TabIndex = 292
        Me.txtAssessed.Text = "0.00"
        Me.txtAssessed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAssessed.UseCustomBackColor = True
        Me.txtAssessed.UseSelectable = True
        Me.txtAssessed.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAssessed.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.DisplayIcon = True
        Me.MetroTextBox2.Enabled = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox2.Lines = New String() {"Amount To Pay"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(500, 297)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 291
        Me.MetroTextBox2.Text = "Amount To Pay"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtChanged
        '
        Me.txtChanged.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtChanged.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.txtChanged.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtChanged.CustomButton.Name = ""
        Me.txtChanged.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtChanged.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtChanged.CustomButton.TabIndex = 1
        Me.txtChanged.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtChanged.CustomButton.UseSelectable = True
        Me.txtChanged.CustomButton.Visible = False
        Me.txtChanged.DisplayIcon = True
        Me.txtChanged.Enabled = False
        Me.txtChanged.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtChanged.Lines = New String() {"0.00"}
        Me.txtChanged.Location = New System.Drawing.Point(706, 385)
        Me.txtChanged.MaxLength = 10
        Me.txtChanged.Name = "txtChanged"
        Me.txtChanged.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChanged.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtChanged.SelectedText = ""
        Me.txtChanged.SelectionLength = 0
        Me.txtChanged.SelectionStart = 0
        Me.txtChanged.Size = New System.Drawing.Size(250, 38)
        Me.txtChanged.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtChanged.TabIndex = 294
        Me.txtChanged.Text = "0.00"
        Me.txtChanged.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChanged.UseCustomBackColor = True
        Me.txtChanged.UseSelectable = True
        Me.txtChanged.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtChanged.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.DisplayIcon = True
        Me.MetroTextBox1.Enabled = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String() {"OR No."}
        Me.MetroTextBox1.Location = New System.Drawing.Point(500, 253)
        Me.MetroTextBox1.MaxLength = 8
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 295
        Me.MetroTextBox1.Text = "OR No."
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtOR
        '
        Me.txtOR.BackColor = System.Drawing.Color.White
        Me.txtOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtOR.CustomButton.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        Me.txtOR.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtOR.CustomButton.Name = ""
        Me.txtOR.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtOR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOR.CustomButton.TabIndex = 1
        Me.txtOR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOR.CustomButton.UseSelectable = True
        Me.txtOR.CustomButton.Visible = False
        Me.txtOR.DisplayIcon = True
        Me.txtOR.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtOR.Lines = New String(-1) {}
        Me.txtOR.Location = New System.Drawing.Point(706, 253)
        Me.txtOR.MaxLength = 10
        Me.txtOR.Name = "txtOR"
        Me.txtOR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOR.SelectedText = ""
        Me.txtOR.SelectionLength = 0
        Me.txtOR.SelectionStart = 0
        Me.txtOR.Size = New System.Drawing.Size(250, 38)
        Me.txtOR.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtOR.TabIndex = 296
        Me.txtOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOR.UseCustomBackColor = True
        Me.txtOR.UseSelectable = True
        Me.txtOR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOR.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'gvFees
        '
        Me.gvFees.AllowUserToAddRows = False
        Me.gvFees.AllowUserToDeleteRows = False
        Me.gvFees.AllowUserToResizeColumns = False
        Me.gvFees.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvFees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvFees.BackgroundColor = System.Drawing.Color.White
        Me.gvFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvFees.ColumnHeadersHeight = 30
        Me.gvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.StudName, Me.type, Me.amount, Me.discount, Me.total, Me.Payments, Me.Column2, Me.Balances, Me.Column1, Me.Column3})
        Me.gvFees.EnableHeadersVisualStyles = False
        Me.gvFees.Location = New System.Drawing.Point(22, 68)
        Me.gvFees.MultiSelect = False
        Me.gvFees.Name = "gvFees"
        Me.gvFees.RowHeadersVisible = False
        Me.gvFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvFees.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.gvFees.RowTemplate.Height = 30
        Me.gvFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvFees.Size = New System.Drawing.Size(456, 422)
        Me.gvFees.TabIndex = 297
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtDate.CustomButton.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        Me.txtDate.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtDate.CustomButton.Name = ""
        Me.txtDate.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDate.CustomButton.TabIndex = 1
        Me.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDate.CustomButton.UseSelectable = True
        Me.txtDate.CustomButton.Visible = False
        Me.txtDate.DisplayIcon = True
        Me.txtDate.Enabled = False
        Me.txtDate.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDate.Lines = New String() {"0.00"}
        Me.txtDate.Location = New System.Drawing.Point(706, 68)
        Me.txtDate.MaxLength = 10
        Me.txtDate.Name = "txtDate"
        Me.txtDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDate.SelectedText = ""
        Me.txtDate.SelectionLength = 0
        Me.txtDate.SelectionStart = 0
        Me.txtDate.Size = New System.Drawing.Size(250, 38)
        Me.txtDate.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtDate.TabIndex = 299
        Me.txtDate.Text = "0.00"
        Me.txtDate.UseCustomBackColor = True
        Me.txtDate.UseSelectable = True
        Me.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.DisplayIcon = True
        Me.MetroTextBox4.Enabled = False
        Me.MetroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox4.Lines = New String() {"Paid Date"}
        Me.MetroTextBox4.Location = New System.Drawing.Point(500, 68)
        Me.MetroTextBox4.MaxLength = 8
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox4.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox4.TabIndex = 298
        Me.MetroTextBox4.Text = "Paid Date"
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtBy
        '
        Me.txtBy.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtBy.CustomButton.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
        Me.txtBy.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtBy.CustomButton.Name = ""
        Me.txtBy.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBy.CustomButton.TabIndex = 1
        Me.txtBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBy.CustomButton.UseSelectable = True
        Me.txtBy.CustomButton.Visible = False
        Me.txtBy.DisplayIcon = True
        Me.txtBy.Enabled = False
        Me.txtBy.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtBy.Lines = New String() {"0.00"}
        Me.txtBy.Location = New System.Drawing.Point(706, 112)
        Me.txtBy.MaxLength = 10
        Me.txtBy.Name = "txtBy"
        Me.txtBy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBy.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBy.SelectedText = ""
        Me.txtBy.SelectionLength = 0
        Me.txtBy.SelectionStart = 0
        Me.txtBy.Size = New System.Drawing.Size(250, 38)
        Me.txtBy.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtBy.TabIndex = 301
        Me.txtBy.Text = "0.00"
        Me.txtBy.UseCustomBackColor = True
        Me.txtBy.UseSelectable = True
        Me.txtBy.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBy.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox7
        '
        '
        '
        '
        Me.MetroTextBox7.CustomButton.Image = CType(resources.GetObject("resource.Image12"), System.Drawing.Image)
        Me.MetroTextBox7.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox7.CustomButton.Name = ""
        Me.MetroTextBox7.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox7.CustomButton.TabIndex = 1
        Me.MetroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox7.CustomButton.UseSelectable = True
        Me.MetroTextBox7.CustomButton.Visible = False
        Me.MetroTextBox7.DisplayIcon = True
        Me.MetroTextBox7.Enabled = False
        Me.MetroTextBox7.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox7.Lines = New String() {"Collected By"}
        Me.MetroTextBox7.Location = New System.Drawing.Point(500, 112)
        Me.MetroTextBox7.MaxLength = 8
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox7.SelectedText = ""
        Me.MetroTextBox7.SelectionLength = 0
        Me.MetroTextBox7.SelectionStart = 0
        Me.MetroTextBox7.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox7.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox7.TabIndex = 300
        Me.MetroTextBox7.Text = "Collected By"
        Me.MetroTextBox7.UseSelectable = True
        Me.MetroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox7.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(500, 201)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 2)
        Me.Panel3.TabIndex = 302
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'StudName
        '
        Me.StudName.HeaderText = "School Fees"
        Me.StudName.Name = "StudName"
        Me.StudName.ReadOnly = True
        Me.StudName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudName.Width = 180
        '
        'type
        '
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        Me.type.Visible = False
        Me.type.Width = 125
        '
        'amount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.amount.Visible = False
        Me.amount.Width = 90
        '
        'discount
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.discount.DefaultCellStyle = DataGridViewCellStyle3
        Me.discount.HeaderText = "Discount"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.Visible = False
        Me.discount.Width = 90
        '
        'total
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.total.DefaultCellStyle = DataGridViewCellStyle4
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Visible = False
        Me.total.Width = 90
        '
        'Payments
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Payments.DefaultCellStyle = DataGridViewCellStyle5
        Me.Payments.HeaderText = "Payments"
        Me.Payments.Name = "Payments"
        Me.Payments.ReadOnly = True
        Me.Payments.Visible = False
        Me.Payments.Width = 90
        '
        'Column2
        '
        Me.Column2.HeaderText = "School Year"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Balances
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Balances.DefaultCellStyle = DataGridViewCellStyle6
        Me.Balances.HeaderText = "Balance"
        Me.Balances.Name = "Balances"
        Me.Balances.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID2"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'frmPayAccounts
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 552)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtBy)
        Me.Controls.Add(Me.MetroTextBox7)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.MetroTextBox4)
        Me.Controls.Add(Me.gvFees)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.txtOR)
        Me.Controls.Add(Me.txtChanged)
        Me.Controls.Add(Me.txtAssessed)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTextBox8)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.txtReceived)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPayAccounts"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.gvFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents txtReceived As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox8 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtChange As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAssessed As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtChanged As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gvFees As System.Windows.Forms.DataGridView
    Friend WithEvents txtDate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBy As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Balances As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
