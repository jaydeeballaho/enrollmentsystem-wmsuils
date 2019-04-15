<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageFees
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageFees))
        Me.btnAddLocal = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnAddUniversity = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.gvLocalFees = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gvUniversityFees = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtAmount = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.cboGradeLvl = New MetroFramework.Controls.MetroComboBox()
        Me.txtSY = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotalUniversity = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotalLocal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.gvLocalFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUniversityFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddLocal
        '
        Me.btnAddLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnAddLocal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddLocal.FlatAppearance.BorderSize = 0
        Me.btnAddLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLocal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLocal.ForeColor = System.Drawing.Color.White
        Me.btnAddLocal.Location = New System.Drawing.Point(337, 504)
        Me.btnAddLocal.Name = "btnAddLocal"
        Me.btnAddLocal.Size = New System.Drawing.Size(195, 40)
        Me.btnAddLocal.TabIndex = 33
        Me.btnAddLocal.Text = "BROWSE LOCAL FEES"
        Me.btnAddLocal.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(739, 504)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 40)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCopy.FlatAppearance.BorderSize = 0
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.White
        Me.btnCopy.Location = New System.Drawing.Point(21, 504)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(212, 40)
        Me.btnCopy.TabIndex = 30
        Me.btnCopy.Text = "VIEW PREVIOUS S.Y. FEES"
        Me.ToolTip1.SetToolTip(Me.btnCopy, "Copy previous school fees to the current school year fees.")
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'btnAddUniversity
        '
        Me.btnAddUniversity.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnAddUniversity.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddUniversity.FlatAppearance.BorderSize = 0
        Me.btnAddUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUniversity.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUniversity.ForeColor = System.Drawing.Color.White
        Me.btnAddUniversity.Location = New System.Drawing.Point(538, 504)
        Me.btnAddUniversity.Name = "btnAddUniversity"
        Me.btnAddUniversity.Size = New System.Drawing.Size(195, 40)
        Me.btnAddUniversity.TabIndex = 32
        Me.btnAddUniversity.Text = "BROWSE UNIVERSITY FEES"
        Me.btnAddUniversity.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(1, 565)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(908, 40)
        Me.Panel12.TabIndex = 256
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(909, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 565)
        Me.Panel15.TabIndex = 258
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 40)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 565)
        Me.Panel14.TabIndex = 259
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(910, 40)
        Me.Panel2.TabIndex = 257
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(356, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(198, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "MANAGE SCHEDULE OF FEES"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'gvLocalFees
        '
        Me.gvLocalFees.AllowUserToAddRows = False
        Me.gvLocalFees.AllowUserToDeleteRows = False
        Me.gvLocalFees.AllowUserToResizeColumns = False
        Me.gvLocalFees.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvLocalFees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvLocalFees.BackgroundColor = System.Drawing.Color.White
        Me.gvLocalFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvLocalFees.ColumnHeadersHeight = 30
        Me.gvLocalFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvLocalFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.StudName, Me.amount, Me.delete})
        Me.gvLocalFees.EnableHeadersVisualStyles = False
        Me.gvLocalFees.Location = New System.Drawing.Point(19, 101)
        Me.gvLocalFees.MultiSelect = False
        Me.gvLocalFees.Name = "gvLocalFees"
        Me.gvLocalFees.ReadOnly = True
        Me.gvLocalFees.RowHeadersVisible = False
        Me.gvLocalFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvLocalFees.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gvLocalFees.RowTemplate.Height = 30
        Me.gvLocalFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvLocalFees.Size = New System.Drawing.Size(433, 350)
        Me.gvLocalFees.TabIndex = 260
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'StudName
        '
        Me.StudName.HeaderText = "Local Fees"
        Me.StudName.Name = "StudName"
        Me.StudName.ReadOnly = True
        Me.StudName.Width = 230
        '
        'amount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'delete
        '
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.HeaderText = ""
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        '
        'gvUniversityFees
        '
        Me.gvUniversityFees.AllowUserToAddRows = False
        Me.gvUniversityFees.AllowUserToDeleteRows = False
        Me.gvUniversityFees.AllowUserToResizeColumns = False
        Me.gvUniversityFees.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvUniversityFees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvUniversityFees.BackgroundColor = System.Drawing.Color.White
        Me.gvUniversityFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvUniversityFees.ColumnHeadersHeight = 30
        Me.gvUniversityFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvUniversityFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewButtonColumn1})
        Me.gvUniversityFees.EnableHeadersVisualStyles = False
        Me.gvUniversityFees.Location = New System.Drawing.Point(458, 101)
        Me.gvUniversityFees.MultiSelect = False
        Me.gvUniversityFees.Name = "gvUniversityFees"
        Me.gvUniversityFees.ReadOnly = True
        Me.gvUniversityFees.RowHeadersVisible = False
        Me.gvUniversityFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvUniversityFees.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.gvUniversityFees.RowTemplate.Height = 30
        Me.gvUniversityFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvUniversityFees.Size = New System.Drawing.Size(433, 350)
        Me.gvUniversityFees.TabIndex = 261
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "University Fees"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 230
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewButtonColumn1.HeaderText = ""
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        '
        'txtAmount
        '
        '
        '
        '
        Me.txtAmount.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtAmount.CustomButton.Location = New System.Drawing.Point(186, 1)
        Me.txtAmount.CustomButton.Name = ""
        Me.txtAmount.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAmount.CustomButton.TabIndex = 1
        Me.txtAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAmount.CustomButton.UseSelectable = True
        Me.txtAmount.CustomButton.Visible = False
        Me.txtAmount.DisplayIcon = True
        Me.txtAmount.Enabled = False
        Me.txtAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtAmount.Lines = New String() {"Grade Level"}
        Me.txtAmount.Location = New System.Drawing.Point(458, 58)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAmount.SelectedText = ""
        Me.txtAmount.SelectionLength = 0
        Me.txtAmount.SelectionStart = 0
        Me.txtAmount.Size = New System.Drawing.Size(214, 29)
        Me.txtAmount.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtAmount.TabIndex = 262
        Me.txtAmount.Text = "Grade Level"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAmount.UseSelectable = True
        Me.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(186, 1)
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
        Me.MetroTextBox1.Lines = New String() {"Current School Year"}
        Me.MetroTextBox1.Location = New System.Drawing.Point(19, 58)
        Me.MetroTextBox1.MaxLength = 10
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(214, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 263
        Me.MetroTextBox1.Text = "Current School Year"
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboGradeLvl
        '
        Me.cboGradeLvl.FormattingEnabled = True
        Me.cboGradeLvl.ItemHeight = 23
        Me.cboGradeLvl.Location = New System.Drawing.Point(677, 58)
        Me.cboGradeLvl.Name = "cboGradeLvl"
        Me.cboGradeLvl.Size = New System.Drawing.Size(214, 29)
        Me.cboGradeLvl.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboGradeLvl.TabIndex = 265
        Me.cboGradeLvl.UseSelectable = True
        '
        'txtSY
        '
        '
        '
        '
        Me.txtSY.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.txtSY.CustomButton.Location = New System.Drawing.Point(186, 1)
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
        Me.txtSY.Location = New System.Drawing.Point(238, 58)
        Me.txtSY.MaxLength = 10
        Me.txtSY.Name = "txtSY"
        Me.txtSY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSY.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSY.SelectedText = ""
        Me.txtSY.SelectionLength = 0
        Me.txtSY.SelectionStart = 0
        Me.txtSY.Size = New System.Drawing.Size(214, 29)
        Me.txtSY.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSY.TabIndex = 266
        Me.txtSY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSY.UseSelectable = True
        Me.txtSY.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSY.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtTotalUniversity
        '
        '
        '
        '
        Me.txtTotalUniversity.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.txtTotalUniversity.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.txtTotalUniversity.CustomButton.Name = ""
        Me.txtTotalUniversity.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTotalUniversity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalUniversity.CustomButton.TabIndex = 1
        Me.txtTotalUniversity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalUniversity.CustomButton.UseSelectable = True
        Me.txtTotalUniversity.CustomButton.Visible = False
        Me.txtTotalUniversity.DisplayIcon = True
        Me.txtTotalUniversity.Enabled = False
        Me.txtTotalUniversity.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTotalUniversity.Lines = New String(-1) {}
        Me.txtTotalUniversity.Location = New System.Drawing.Point(691, 457)
        Me.txtTotalUniversity.MaxLength = 10
        Me.txtTotalUniversity.Name = "txtTotalUniversity"
        Me.txtTotalUniversity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalUniversity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalUniversity.SelectedText = ""
        Me.txtTotalUniversity.SelectionLength = 0
        Me.txtTotalUniversity.SelectionStart = 0
        Me.txtTotalUniversity.Size = New System.Drawing.Size(200, 29)
        Me.txtTotalUniversity.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtTotalUniversity.TabIndex = 267
        Me.txtTotalUniversity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalUniversity.UseSelectable = True
        Me.txtTotalUniversity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalUniversity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtTotalLocal
        '
        '
        '
        '
        Me.txtTotalLocal.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.txtTotalLocal.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.txtTotalLocal.CustomButton.Name = ""
        Me.txtTotalLocal.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTotalLocal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalLocal.CustomButton.TabIndex = 1
        Me.txtTotalLocal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalLocal.CustomButton.UseSelectable = True
        Me.txtTotalLocal.CustomButton.Visible = False
        Me.txtTotalLocal.DisplayIcon = True
        Me.txtTotalLocal.Enabled = False
        Me.txtTotalLocal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTotalLocal.Lines = New String(-1) {}
        Me.txtTotalLocal.Location = New System.Drawing.Point(252, 457)
        Me.txtTotalLocal.MaxLength = 10
        Me.txtTotalLocal.Name = "txtTotalLocal"
        Me.txtTotalLocal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalLocal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalLocal.SelectedText = ""
        Me.txtTotalLocal.SelectionLength = 0
        Me.txtTotalLocal.SelectionStart = 0
        Me.txtTotalLocal.Size = New System.Drawing.Size(200, 29)
        Me.txtTotalLocal.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtTotalLocal.TabIndex = 268
        Me.txtTotalLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLocal.UseSelectable = True
        Me.txtTotalLocal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalLocal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(200, 1)
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
        Me.MetroTextBox2.Lines = New String() {"Total Local Fees"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(19, 457)
        Me.MetroTextBox2.MaxLength = 10
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(228, 29)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 269
        Me.MetroTextBox2.Text = "Total Local Fees"
        Me.MetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(200, 1)
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
        Me.MetroTextBox3.Lines = New String() {"Total University Fees"}
        Me.MetroTextBox3.Location = New System.Drawing.Point(457, 457)
        Me.MetroTextBox3.MaxLength = 10
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.Size = New System.Drawing.Size(228, 29)
        Me.MetroTextBox3.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox3.TabIndex = 270
        Me.MetroTextBox3.Text = "Total University Fees"
        Me.MetroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmManageFees
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(910, 605)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.txtTotalLocal)
        Me.Controls.Add(Me.txtTotalUniversity)
        Me.Controls.Add(Me.txtSY)
        Me.Controls.Add(Me.cboGradeLvl)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.gvUniversityFees)
        Me.Controls.Add(Me.gvLocalFees)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnAddLocal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddUniversity)
        Me.Controls.Add(Me.btnCopy)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManageFees"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.gvLocalFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUniversityFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnAddUniversity As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnAddLocal As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gvLocalFees As System.Windows.Forms.DataGridView
    Friend WithEvents gvUniversityFees As System.Windows.Forms.DataGridView
    Friend WithEvents txtAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboGradeLvl As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtSY As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotalUniversity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotalLocal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox

End Class
