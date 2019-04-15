<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCopyFees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCopyFees))
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmFee = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotalLocal = New MetroFramework.Controls.MetroTextBox()
        Me.txtTotalUniversity = New MetroFramework.Controls.MetroTextBox()
        Me.txtGradeLvl = New MetroFramework.Controls.MetroTextBox()
        Me.cboSY = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAmount = New MetroFramework.Controls.MetroTextBox()
        Me.gvUniversityFees = New System.Windows.Forms.DataGridView()
        Me.gvLocalFees = New System.Windows.Forms.DataGridView()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCopyUniversity = New System.Windows.Forms.Button()
        Me.btnCopyLocal = New System.Windows.Forms.Button()
        Me.cmFee.SuspendLayout()
        CType(Me.gvUniversityFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLocalFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(761, 504)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 40)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(19, 504)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(255, 40)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "COPY PREVIOUS SCHOOL YEAR FEES"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmFee
        '
        Me.cmFee.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmFee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.cmFee.Name = "cmFee"
        Me.cmFee.Size = New System.Drawing.Size(114, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RemoveToolStripMenuItem.Text = "Delete"
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
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
        Me.MetroTextBox3.Location = New System.Drawing.Point(458, 457)
        Me.MetroTextBox3.MaxLength = 10
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.Size = New System.Drawing.Size(228, 29)
        Me.MetroTextBox3.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox3.TabIndex = 280
        Me.MetroTextBox3.Text = "Total University Fees"
        Me.MetroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
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
        Me.MetroTextBox2.TabIndex = 279
        Me.MetroTextBox2.Text = "Total Local Fees"
        Me.MetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtTotalLocal
        '
        '
        '
        '
        Me.txtTotalLocal.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
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
        Me.txtTotalLocal.Location = New System.Drawing.Point(691, 457)
        Me.txtTotalLocal.MaxLength = 10
        Me.txtTotalLocal.Name = "txtTotalLocal"
        Me.txtTotalLocal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalLocal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalLocal.SelectedText = ""
        Me.txtTotalLocal.SelectionLength = 0
        Me.txtTotalLocal.SelectionStart = 0
        Me.txtTotalLocal.Size = New System.Drawing.Size(200, 29)
        Me.txtTotalLocal.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtTotalLocal.TabIndex = 278
        Me.txtTotalLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalLocal.UseSelectable = True
        Me.txtTotalLocal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalLocal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtTotalUniversity
        '
        '
        '
        '
        Me.txtTotalUniversity.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.txtTotalUniversity.CustomButton.Location = New System.Drawing.Point(171, 1)
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
        Me.txtTotalUniversity.Location = New System.Drawing.Point(253, 457)
        Me.txtTotalUniversity.MaxLength = 10
        Me.txtTotalUniversity.Name = "txtTotalUniversity"
        Me.txtTotalUniversity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalUniversity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalUniversity.SelectedText = ""
        Me.txtTotalUniversity.SelectionLength = 0
        Me.txtTotalUniversity.SelectionStart = 0
        Me.txtTotalUniversity.Size = New System.Drawing.Size(199, 29)
        Me.txtTotalUniversity.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtTotalUniversity.TabIndex = 277
        Me.txtTotalUniversity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTotalUniversity.UseSelectable = True
        Me.txtTotalUniversity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalUniversity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtGradeLvl
        '
        '
        '
        '
        Me.txtGradeLvl.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.txtGradeLvl.CustomButton.Location = New System.Drawing.Point(186, 1)
        Me.txtGradeLvl.CustomButton.Name = ""
        Me.txtGradeLvl.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtGradeLvl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGradeLvl.CustomButton.TabIndex = 1
        Me.txtGradeLvl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGradeLvl.CustomButton.UseSelectable = True
        Me.txtGradeLvl.CustomButton.Visible = False
        Me.txtGradeLvl.DisplayIcon = True
        Me.txtGradeLvl.Enabled = False
        Me.txtGradeLvl.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtGradeLvl.Lines = New String(-1) {}
        Me.txtGradeLvl.Location = New System.Drawing.Point(677, 58)
        Me.txtGradeLvl.MaxLength = 10
        Me.txtGradeLvl.Name = "txtGradeLvl"
        Me.txtGradeLvl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGradeLvl.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGradeLvl.SelectedText = ""
        Me.txtGradeLvl.SelectionLength = 0
        Me.txtGradeLvl.SelectionStart = 0
        Me.txtGradeLvl.Size = New System.Drawing.Size(214, 29)
        Me.txtGradeLvl.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtGradeLvl.TabIndex = 276
        Me.txtGradeLvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGradeLvl.UseSelectable = True
        Me.txtGradeLvl.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGradeLvl.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboSY
        '
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.ItemHeight = 23
        Me.cboSY.Location = New System.Drawing.Point(238, 58)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(214, 29)
        Me.cboSY.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboSY.TabIndex = 275
        Me.cboSY.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
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
        Me.MetroTextBox1.Lines = New String() {"Previous School Year"}
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
        Me.MetroTextBox1.TabIndex = 274
        Me.MetroTextBox1.Text = "Previous School Year"
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtAmount
        '
        '
        '
        '
        Me.txtAmount.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
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
        Me.txtAmount.TabIndex = 273
        Me.txtAmount.Text = "Grade Level"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAmount.UseSelectable = True
        Me.txtAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'gvUniversityFees
        '
        Me.gvUniversityFees.AllowUserToAddRows = False
        Me.gvUniversityFees.AllowUserToDeleteRows = False
        Me.gvUniversityFees.AllowUserToResizeColumns = False
        Me.gvUniversityFees.AllowUserToResizeRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvUniversityFees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.gvUniversityFees.BackgroundColor = System.Drawing.Color.White
        Me.gvUniversityFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvUniversityFees.ColumnHeadersHeight = 30
        Me.gvUniversityFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvUniversityFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.gvUniversityFees.Enabled = False
        Me.gvUniversityFees.EnableHeadersVisualStyles = False
        Me.gvUniversityFees.Location = New System.Drawing.Point(458, 101)
        Me.gvUniversityFees.MultiSelect = False
        Me.gvUniversityFees.Name = "gvUniversityFees"
        Me.gvUniversityFees.ReadOnly = True
        Me.gvUniversityFees.RowHeadersVisible = False
        Me.gvUniversityFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvUniversityFees.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.gvUniversityFees.RowTemplate.Height = 30
        Me.gvUniversityFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvUniversityFees.Size = New System.Drawing.Size(433, 350)
        Me.gvUniversityFees.TabIndex = 272
        '
        'gvLocalFees
        '
        Me.gvLocalFees.AllowUserToAddRows = False
        Me.gvLocalFees.AllowUserToDeleteRows = False
        Me.gvLocalFees.AllowUserToResizeColumns = False
        Me.gvLocalFees.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvLocalFees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.gvLocalFees.BackgroundColor = System.Drawing.Color.White
        Me.gvLocalFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvLocalFees.ColumnHeadersHeight = 30
        Me.gvLocalFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvLocalFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.StudName, Me.amount})
        Me.gvLocalFees.Enabled = False
        Me.gvLocalFees.EnableHeadersVisualStyles = False
        Me.gvLocalFees.Location = New System.Drawing.Point(19, 101)
        Me.gvLocalFees.MultiSelect = False
        Me.gvLocalFees.Name = "gvLocalFees"
        Me.gvLocalFees.ReadOnly = True
        Me.gvLocalFees.RowHeadersVisible = False
        Me.gvLocalFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvLocalFees.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.gvLocalFees.RowTemplate.Height = 30
        Me.gvLocalFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvLocalFees.Size = New System.Drawing.Size(433, 350)
        Me.gvLocalFees.TabIndex = 271
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(1, 565)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(908, 40)
        Me.Panel12.TabIndex = 281
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(909, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 565)
        Me.Panel15.TabIndex = 283
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 40)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 565)
        Me.Panel14.TabIndex = 284
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(910, 40)
        Me.Panel2.TabIndex = 282
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(303, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(304, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "PREVIOUS SCHOOL YEAR SCHEDULE OF FEES"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'ID
        '
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'StudName
        '
        Me.StudName.Frozen = True
        Me.StudName.HeaderText = "Local Fees"
        Me.StudName.Name = "StudName"
        Me.StudName.ReadOnly = True
        Me.StudName.Width = 230
        '
        'amount
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle23
        Me.amount.Frozen = True
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "University Fees"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 230
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'btnCopyUniversity
        '
        Me.btnCopyUniversity.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCopyUniversity.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCopyUniversity.FlatAppearance.BorderSize = 0
        Me.btnCopyUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyUniversity.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyUniversity.ForeColor = System.Drawing.Color.White
        Me.btnCopyUniversity.Location = New System.Drawing.Point(545, 504)
        Me.btnCopyUniversity.Name = "btnCopyUniversity"
        Me.btnCopyUniversity.Size = New System.Drawing.Size(210, 40)
        Me.btnCopyUniversity.TabIndex = 285
        Me.btnCopyUniversity.Text = "COPY UNIVERSITY FEES ONLY"
        Me.btnCopyUniversity.UseVisualStyleBackColor = False
        '
        'btnCopyLocal
        '
        Me.btnCopyLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.btnCopyLocal.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCopyLocal.FlatAppearance.BorderSize = 0
        Me.btnCopyLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyLocal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyLocal.ForeColor = System.Drawing.Color.White
        Me.btnCopyLocal.Location = New System.Drawing.Point(329, 504)
        Me.btnCopyLocal.Name = "btnCopyLocal"
        Me.btnCopyLocal.Size = New System.Drawing.Size(210, 40)
        Me.btnCopyLocal.TabIndex = 286
        Me.btnCopyLocal.Text = "COPY LOCAL FEES ONLY"
        Me.btnCopyLocal.UseVisualStyleBackColor = False
        '
        'frmCopyFees
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(910, 605)
        Me.Controls.Add(Me.btnCopyLocal)
        Me.Controls.Add(Me.btnCopyUniversity)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.MetroTextBox3)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.txtTotalLocal)
        Me.Controls.Add(Me.txtTotalUniversity)
        Me.Controls.Add(Me.txtGradeLvl)
        Me.Controls.Add(Me.cboSY)
        Me.Controls.Add(Me.MetroTextBox1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.gvUniversityFees)
        Me.Controls.Add(Me.gvLocalFees)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCopyFees"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.cmFee.ResumeLayout(False)
        CType(Me.gvUniversityFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLocalFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cmFee As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotalLocal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotalUniversity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGradeLvl As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboSY As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gvUniversityFees As System.Windows.Forms.DataGridView
    Friend WithEvents gvLocalFees As System.Windows.Forms.DataGridView
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCopyUniversity As System.Windows.Forms.Button
    Friend WithEvents btnCopyLocal As System.Windows.Forms.Button

End Class
