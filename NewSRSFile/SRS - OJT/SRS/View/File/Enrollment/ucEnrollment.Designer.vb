<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucEnrollment
    Inherits ucBase

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucEnrollment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblSY = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.panelWork = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboStatus = New MetroFramework.Controls.MetroComboBox()
        Me.cboGl = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.gvEnrolled = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.open = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkPrint = New MetroFramework.Controls.MetroLink()
        Me.cboSection = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.cboGl2 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.cboSY = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox15 = New MetroFramework.Controls.MetroTextBox()
        Me.gvReports = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel12.SuspendLayout()
        Me.panelWork.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gvEnrolled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.gvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.ForeColor = System.Drawing.Color.White
        Me.MetroLabel6.Location = New System.Drawing.Point(13, 11)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel6.TabIndex = 222
        Me.MetroLabel6.Text = "Enrollment"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Gray
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(588, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(160, 29)
        Me.btnAdd.TabIndex = 224
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "Register New Student"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(6, 8)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel7.TabIndex = 223
        Me.MetroLabel7.Text = "Student Name"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.txtSearch.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(276, 2)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(6, 31)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShowButton = True
        Me.txtSearch.Size = New System.Drawing.Size(304, 30)
        Me.txtSearch.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSearch.TabIndex = 7
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search Here"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Controls.Add(Me.lblSY)
        Me.Panel12.Controls.Add(Me.MetroLabel12)
        Me.Panel12.Controls.Add(Me.MetroLabel6)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(776, 40)
        Me.Panel12.TabIndex = 6
        '
        'lblSY
        '
        Me.lblSY.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSY.AutoSize = True
        Me.lblSY.BackColor = System.Drawing.Color.Transparent
        Me.lblSY.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblSY.ForeColor = System.Drawing.Color.White
        Me.lblSY.Location = New System.Drawing.Point(117, 11)
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(79, 19)
        Me.lblSY.TabIndex = 225
        Me.lblSY.Text = "2016-2017"
        Me.lblSY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSY.UseCustomBackColor = True
        Me.lblSY.UseCustomForeColor = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel12.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel12.ForeColor = System.Drawing.Color.White
        Me.MetroLabel12.Location = New System.Drawing.Point(98, 8)
        Me.MetroLabel12.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(18, 23)
        Me.MetroLabel12.TabIndex = 224
        Me.MetroLabel12.Text = "l"
        Me.MetroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel12.UseCustomBackColor = True
        Me.MetroLabel12.UseCustomForeColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(775, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 519)
        Me.Panel15.TabIndex = 227
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 40)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 519)
        Me.Panel14.TabIndex = 227
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.Gray
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(0, 559)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(776, 1)
        Me.Panel13.TabIndex = 226
        '
        'panelWork
        '
        Me.panelWork.Controls.Add(Me.TabControl1)
        Me.panelWork.Controls.Add(Me.Panel15)
        Me.panelWork.Controls.Add(Me.Panel14)
        Me.panelWork.Controls.Add(Me.Panel13)
        Me.panelWork.Controls.Add(Me.Panel12)
        Me.panelWork.Location = New System.Drawing.Point(0, 0)
        Me.panelWork.Name = "panelWork"
        Me.panelWork.Size = New System.Drawing.Size(776, 560)
        Me.panelWork.TabIndex = 230
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 47)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 509)
        Me.TabControl1.TabIndex = 306
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MetroLabel7)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.cboGl)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.MetroLabel1)
        Me.TabPage1.Controls.Add(Me.gvEnrolled)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(755, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Enrollment"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.ItemHeight = 23
        Me.cboStatus.Items.AddRange(New Object() {"All", "Advised", "Assessed", "Enrolled"})
        Me.cboStatus.Location = New System.Drawing.Point(452, 32)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.PromptText = "Status"
        Me.cboStatus.Size = New System.Drawing.Size(130, 29)
        Me.cboStatus.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboStatus.TabIndex = 305
        Me.cboStatus.UseSelectable = True
        '
        'cboGl
        '
        Me.cboGl.FormattingEnabled = True
        Me.cboGl.ItemHeight = 23
        Me.cboGl.Location = New System.Drawing.Point(316, 32)
        Me.cboGl.Name = "cboGl"
        Me.cboGl.PromptText = "Grade Level"
        Me.cboGl.Size = New System.Drawing.Size(130, 29)
        Me.cboGl.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboGl.TabIndex = 304
        Me.cboGl.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(313, 8)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel1.TabIndex = 303
        Me.MetroLabel1.Text = "Categories"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'gvEnrolled
        '
        Me.gvEnrolled.AllowUserToAddRows = False
        Me.gvEnrolled.AllowUserToDeleteRows = False
        Me.gvEnrolled.AllowUserToResizeColumns = False
        Me.gvEnrolled.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvEnrolled.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvEnrolled.BackgroundColor = System.Drawing.Color.White
        Me.gvEnrolled.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvEnrolled.ColumnHeadersHeight = 30
        Me.gvEnrolled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvEnrolled.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.StudName, Me.gender, Me.Column1, Me.open, Me.delete})
        Me.gvEnrolled.EnableHeadersVisualStyles = False
        Me.gvEnrolled.Location = New System.Drawing.Point(7, 71)
        Me.gvEnrolled.MultiSelect = False
        Me.gvEnrolled.Name = "gvEnrolled"
        Me.gvEnrolled.ReadOnly = True
        Me.gvEnrolled.RowHeadersVisible = False
        Me.gvEnrolled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvEnrolled.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gvEnrolled.RowTemplate.Height = 30
        Me.gvEnrolled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvEnrolled.Size = New System.Drawing.Size(741, 398)
        Me.gvEnrolled.TabIndex = 225
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
        Me.StudName.HeaderText = "Name"
        Me.StudName.Name = "StudName"
        Me.StudName.ReadOnly = True
        Me.StudName.Width = 335
        '
        'gender
        '
        Me.gender.HeaderText = "Sex"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Grade Level"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'open
        '
        Me.open.HeaderText = "Status"
        Me.open.Name = "open"
        Me.open.ReadOnly = True
        Me.open.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'delete
        '
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.HeaderText = ""
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LinkPrint)
        Me.TabPage2.Controls.Add(Me.cboSection)
        Me.TabPage2.Controls.Add(Me.MetroTextBox2)
        Me.TabPage2.Controls.Add(Me.cboGl2)
        Me.TabPage2.Controls.Add(Me.MetroTextBox1)
        Me.TabPage2.Controls.Add(Me.cboSY)
        Me.TabPage2.Controls.Add(Me.MetroTextBox15)
        Me.TabPage2.Controls.Add(Me.gvReports)
        Me.TabPage2.Controls.Add(Me.MetroLabel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(755, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Class List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LinkPrint
        '
        Me.LinkPrint.Image = CType(resources.GetObject("LinkPrint.Image"), System.Drawing.Image)
        Me.LinkPrint.Location = New System.Drawing.Point(716, 31)
        Me.LinkPrint.Name = "LinkPrint"
        Me.LinkPrint.Size = New System.Drawing.Size(32, 29)
        Me.LinkPrint.TabIndex = 308
        Me.LinkPrint.UseSelectable = True
        '
        'cboSection
        '
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.ItemHeight = 23
        Me.cboSection.Location = New System.Drawing.Point(586, 31)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(125, 29)
        Me.cboSection.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboSection.TabIndex = 307
        Me.cboSection.UseSelectable = True
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(72, 1)
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
        Me.MetroTextBox2.Location = New System.Drawing.Point(480, 31)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(100, 29)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 306
        Me.MetroTextBox2.Text = "Section"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboGl2
        '
        Me.cboGl2.FormattingEnabled = True
        Me.cboGl2.ItemHeight = 23
        Me.cboGl2.Location = New System.Drawing.Point(349, 31)
        Me.cboGl2.Name = "cboGl2"
        Me.cboGl2.Size = New System.Drawing.Size(125, 29)
        Me.cboGl2.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboGl2.TabIndex = 305
        Me.cboGl2.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(72, 1)
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
        Me.MetroTextBox1.Lines = New String() {"Grade Level"}
        Me.MetroTextBox1.Location = New System.Drawing.Point(243, 31)
        Me.MetroTextBox1.MaxLength = 8
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(100, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 304
        Me.MetroTextBox1.Text = "Grade Level"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboSY
        '
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.ItemHeight = 23
        Me.cboSY.Location = New System.Drawing.Point(112, 31)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(125, 29)
        Me.cboSY.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboSY.TabIndex = 303
        Me.cboSY.UseSelectable = True
        '
        'MetroTextBox15
        '
        '
        '
        '
        Me.MetroTextBox15.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.MetroTextBox15.CustomButton.Location = New System.Drawing.Point(72, 1)
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
        Me.MetroTextBox15.Lines = New String() {"School Year"}
        Me.MetroTextBox15.Location = New System.Drawing.Point(6, 31)
        Me.MetroTextBox15.MaxLength = 8
        Me.MetroTextBox15.Name = "MetroTextBox15"
        Me.MetroTextBox15.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox15.SelectedText = ""
        Me.MetroTextBox15.SelectionLength = 0
        Me.MetroTextBox15.SelectionStart = 0
        Me.MetroTextBox15.Size = New System.Drawing.Size(100, 29)
        Me.MetroTextBox15.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox15.TabIndex = 302
        Me.MetroTextBox15.Text = "School Year"
        Me.MetroTextBox15.UseSelectable = True
        Me.MetroTextBox15.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox15.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'gvReports
        '
        Me.gvReports.AllowUserToAddRows = False
        Me.gvReports.AllowUserToDeleteRows = False
        Me.gvReports.AllowUserToResizeColumns = False
        Me.gvReports.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvReports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gvReports.BackgroundColor = System.Drawing.Color.White
        Me.gvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvReports.ColumnHeadersHeight = 30
        Me.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.No, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.gvReports.Enabled = False
        Me.gvReports.EnableHeadersVisualStyles = False
        Me.gvReports.Location = New System.Drawing.Point(7, 71)
        Me.gvReports.Name = "gvReports"
        Me.gvReports.ReadOnly = True
        Me.gvReports.RowHeadersVisible = False
        Me.gvReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvReports.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gvReports.RowTemplate.Height = 30
        Me.gvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvReports.Size = New System.Drawing.Size(741, 398)
        Me.gvReports.TabIndex = 301
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 545
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 8)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel2.TabIndex = 300
        Me.MetroLabel2.Text = "Class List Report"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ucEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelWork)
        Me.Name = "ucEnrollment"
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.panelWork.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.gvEnrolled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.gvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents panelWork As System.Windows.Forms.Panel
    Friend WithEvents gvEnrolled As System.Windows.Forms.DataGridView
    Friend WithEvents cboStatus As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboGl As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents open As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents lblSY As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cboSection As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboGl2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboSY As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox15 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents gvReports As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LinkPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog

End Class
