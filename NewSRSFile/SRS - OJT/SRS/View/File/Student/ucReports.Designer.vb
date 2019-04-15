<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucReports))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelWork = New System.Windows.Forms.Panel()
        Me.cboSection = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.cboGl = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.cboSY = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox15 = New MetroFramework.Controls.MetroTextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.gvReports = New System.Windows.Forms.DataGridView()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STUDENTRECORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASSESSMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STUDENTPAYMENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REFERENCESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCHOOLYEARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FEESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ENROLLMENTSTATUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENROLLEESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASSESSEDSTUDENTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLLECTIONREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROMISORIESREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAINTENANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTIVITYLOGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RUNDATABASEBACKUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHANGEPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelWork.SuspendLayout()
        CType(Me.gvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.msMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelWork
        '
        Me.panelWork.Controls.Add(Me.cboSection)
        Me.panelWork.Controls.Add(Me.MetroTextBox2)
        Me.panelWork.Controls.Add(Me.cboGl)
        Me.panelWork.Controls.Add(Me.MetroTextBox1)
        Me.panelWork.Controls.Add(Me.cboSY)
        Me.panelWork.Controls.Add(Me.MetroTextBox15)
        Me.panelWork.Controls.Add(Me.Panel15)
        Me.panelWork.Controls.Add(Me.Panel14)
        Me.panelWork.Controls.Add(Me.Panel13)
        Me.panelWork.Controls.Add(Me.gvReports)
        Me.panelWork.Controls.Add(Me.MetroLabel7)
        Me.panelWork.Controls.Add(Me.Panel12)
        Me.panelWork.Controls.Add(Me.msMain)
        Me.panelWork.Location = New System.Drawing.Point(0, 0)
        Me.panelWork.Name = "panelWork"
        Me.panelWork.Size = New System.Drawing.Size(776, 560)
        Me.panelWork.TabIndex = 228
        '
        'cboSection
        '
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.ItemHeight = 23
        Me.cboSection.Location = New System.Drawing.Point(623, 78)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(130, 29)
        Me.cboSection.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboSection.TabIndex = 299
        Me.cboSection.UseSelectable = True
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(77, 1)
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
        Me.MetroTextBox2.Location = New System.Drawing.Point(512, 78)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(105, 29)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 298
        Me.MetroTextBox2.Text = "Section"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboGl
        '
        Me.cboGl.FormattingEnabled = True
        Me.cboGl.ItemHeight = 23
        Me.cboGl.Location = New System.Drawing.Point(376, 78)
        Me.cboGl.Name = "cboGl"
        Me.cboGl.Size = New System.Drawing.Size(130, 29)
        Me.cboGl.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboGl.TabIndex = 297
        Me.cboGl.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(77, 1)
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
        Me.MetroTextBox1.Location = New System.Drawing.Point(265, 78)
        Me.MetroTextBox1.MaxLength = 8
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(105, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox1.TabIndex = 296
        Me.MetroTextBox1.Text = "Grade Level"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cboSY
        '
        Me.cboSY.FormattingEnabled = True
        Me.cboSY.ItemHeight = 23
        Me.cboSY.Location = New System.Drawing.Point(129, 78)
        Me.cboSY.Name = "cboSY"
        Me.cboSY.Size = New System.Drawing.Size(130, 29)
        Me.cboSY.Style = MetroFramework.MetroColorStyle.Silver
        Me.cboSY.TabIndex = 295
        Me.cboSY.UseSelectable = True
        '
        'MetroTextBox15
        '
        '
        '
        '
        Me.MetroTextBox15.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.MetroTextBox15.CustomButton.Location = New System.Drawing.Point(77, 1)
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
        Me.MetroTextBox15.Location = New System.Drawing.Point(18, 78)
        Me.MetroTextBox15.MaxLength = 8
        Me.MetroTextBox15.Name = "MetroTextBox15"
        Me.MetroTextBox15.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox15.SelectedText = ""
        Me.MetroTextBox15.SelectionLength = 0
        Me.MetroTextBox15.SelectionStart = 0
        Me.MetroTextBox15.Size = New System.Drawing.Size(105, 29)
        Me.MetroTextBox15.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox15.TabIndex = 294
        Me.MetroTextBox15.Text = "School Year"
        Me.MetroTextBox15.UseSelectable = True
        Me.MetroTextBox15.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox15.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'gvReports
        '
        Me.gvReports.AllowUserToAddRows = False
        Me.gvReports.AllowUserToDeleteRows = False
        Me.gvReports.AllowUserToResizeColumns = False
        Me.gvReports.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gvReports.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvReports.BackgroundColor = System.Drawing.Color.White
        Me.gvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gvReports.ColumnHeadersHeight = 30
        Me.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvReports.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.No, Me.StudName, Me.Column1})
        Me.gvReports.Enabled = False
        Me.gvReports.EnableHeadersVisualStyles = False
        Me.gvReports.Location = New System.Drawing.Point(18, 118)
        Me.gvReports.Name = "gvReports"
        Me.gvReports.ReadOnly = True
        Me.gvReports.RowHeadersVisible = False
        Me.gvReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvReports.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gvReports.RowTemplate.Height = 30
        Me.gvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvReports.Size = New System.Drawing.Size(741, 424)
        Me.gvReports.TabIndex = 225
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(13, 50)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel7.TabIndex = 223
        Me.MetroLabel7.Text = "Class List Report"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Controls.Add(Me.MetroLabel6)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(776, 40)
        Me.Panel12.TabIndex = 6
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
        Me.MetroLabel6.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel6.TabIndex = 222
        Me.MetroLabel6.Text = "Class List"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'msMain
        '
        Me.msMain.BackColor = System.Drawing.Color.Transparent
        Me.msMain.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.TRANSACTIONToolStripMenuItem, Me.REFERENCESToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.USERToolStripMenuItem, Me.MAINTENANCEToolStripMenuItem, Me.HELPToolStripMenuItem, Me.QUITToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(776, 28)
        Me.msMain.TabIndex = 3
        Me.msMain.Text = "MenuStrip1"
        Me.msMain.Visible = False
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTRECORDToolStripMenuItem, Me.ASSESSMENTToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FILEToolStripMenuItem.Text = "File"
        '
        'STUDENTRECORDToolStripMenuItem
        '
        Me.STUDENTRECORDToolStripMenuItem.Name = "STUDENTRECORDToolStripMenuItem"
        Me.STUDENTRECORDToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.STUDENTRECORDToolStripMenuItem.Text = "Student Record"
        '
        'ASSESSMENTToolStripMenuItem
        '
        Me.ASSESSMENTToolStripMenuItem.Name = "ASSESSMENTToolStripMenuItem"
        Me.ASSESSMENTToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ASSESSMENTToolStripMenuItem.Text = "Assessment"
        '
        'TRANSACTIONToolStripMenuItem
        '
        Me.TRANSACTIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTPAYMENTSToolStripMenuItem})
        Me.TRANSACTIONToolStripMenuItem.Name = "TRANSACTIONToolStripMenuItem"
        Me.TRANSACTIONToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.TRANSACTIONToolStripMenuItem.Text = "Transaction"
        '
        'STUDENTPAYMENTSToolStripMenuItem
        '
        Me.STUDENTPAYMENTSToolStripMenuItem.Name = "STUDENTPAYMENTSToolStripMenuItem"
        Me.STUDENTPAYMENTSToolStripMenuItem.Size = New System.Drawing.Size(196, 24)
        Me.STUDENTPAYMENTSToolStripMenuItem.Text = "Student Payments"
        '
        'REFERENCESToolStripMenuItem
        '
        Me.REFERENCESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradeLevelToolStripMenuItem, Me.SCHOOLYEARToolStripMenuItem1, Me.FEESToolStripMenuItem, Me.ToolStripMenuItem2, Me.ENROLLMENTSTATUSToolStripMenuItem})
        Me.REFERENCESToolStripMenuItem.Name = "REFERENCESToolStripMenuItem"
        Me.REFERENCESToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.REFERENCESToolStripMenuItem.Text = "References"
        '
        'GradeLevelToolStripMenuItem
        '
        Me.GradeLevelToolStripMenuItem.Name = "GradeLevelToolStripMenuItem"
        Me.GradeLevelToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.GradeLevelToolStripMenuItem.Text = "Grade Level"
        '
        'SCHOOLYEARToolStripMenuItem1
        '
        Me.SCHOOLYEARToolStripMenuItem1.Name = "SCHOOLYEARToolStripMenuItem1"
        Me.SCHOOLYEARToolStripMenuItem1.Size = New System.Drawing.Size(194, 24)
        Me.SCHOOLYEARToolStripMenuItem1.Text = "School Year"
        '
        'FEESToolStripMenuItem
        '
        Me.FEESToolStripMenuItem.Name = "FEESToolStripMenuItem"
        Me.FEESToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.FEESToolStripMenuItem.Text = "School Fees"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(191, 6)
        '
        'ENROLLMENTSTATUSToolStripMenuItem
        '
        Me.ENROLLMENTSTATUSToolStripMenuItem.Name = "ENROLLMENTSTATUSToolStripMenuItem"
        Me.ENROLLMENTSTATUSToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ENROLLMENTSTATUSToolStripMenuItem.Text = "Enrollment Status"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENROLLEESToolStripMenuItem, Me.ASSESSEDSTUDENTSToolStripMenuItem, Me.COLLECTIONREPORTToolStripMenuItem, Me.PROMISORIESREPORTToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ENROLLEESToolStripMenuItem
        '
        Me.ENROLLEESToolStripMenuItem.Name = "ENROLLEESToolStripMenuItem"
        Me.ENROLLEESToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.ENROLLEESToolStripMenuItem.Text = "Enrollees"
        '
        'ASSESSEDSTUDENTSToolStripMenuItem
        '
        Me.ASSESSEDSTUDENTSToolStripMenuItem.Name = "ASSESSEDSTUDENTSToolStripMenuItem"
        Me.ASSESSEDSTUDENTSToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.ASSESSEDSTUDENTSToolStripMenuItem.Text = "Assessed Students"
        '
        'COLLECTIONREPORTToolStripMenuItem
        '
        Me.COLLECTIONREPORTToolStripMenuItem.Name = "COLLECTIONREPORTToolStripMenuItem"
        Me.COLLECTIONREPORTToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.COLLECTIONREPORTToolStripMenuItem.Text = "Collection Report"
        '
        'PROMISORIESREPORTToolStripMenuItem
        '
        Me.PROMISORIESREPORTToolStripMenuItem.Name = "PROMISORIESREPORTToolStripMenuItem"
        Me.PROMISORIESREPORTToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.PROMISORIESREPORTToolStripMenuItem.Text = "Promisories Report"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERACCOUNTSToolStripMenuItem})
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.USERToolStripMenuItem.Text = "Users/Groups"
        '
        'USERACCOUNTSToolStripMenuItem
        '
        Me.USERACCOUNTSToolStripMenuItem.Name = "USERACCOUNTSToolStripMenuItem"
        Me.USERACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.USERACCOUNTSToolStripMenuItem.Text = "User Accounts"
        '
        'MAINTENANCEToolStripMenuItem
        '
        Me.MAINTENANCEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACTIVITYLOGSToolStripMenuItem, Me.RUNDATABASEBACKUPToolStripMenuItem})
        Me.MAINTENANCEToolStripMenuItem.Name = "MAINTENANCEToolStripMenuItem"
        Me.MAINTENANCEToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.MAINTENANCEToolStripMenuItem.Text = "Maintenance"
        '
        'ACTIVITYLOGSToolStripMenuItem
        '
        Me.ACTIVITYLOGSToolStripMenuItem.Name = "ACTIVITYLOGSToolStripMenuItem"
        Me.ACTIVITYLOGSToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.ACTIVITYLOGSToolStripMenuItem.Text = "Activity Logs"
        '
        'RUNDATABASEBACKUPToolStripMenuItem
        '
        Me.RUNDATABASEBACKUPToolStripMenuItem.Name = "RUNDATABASEBACKUPToolStripMenuItem"
        Me.RUNDATABASEBACKUPToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.RUNDATABASEBACKUPToolStripMenuItem.Text = "Run Database Back-up"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HELPToolStripMenuItem.Text = "Help"
        '
        'QUITToolStripMenuItem
        '
        Me.QUITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHANGEPASSWORDToolStripMenuItem, Me.ToolStripMenuItem1, Me.LOGOUTToolStripMenuItem})
        Me.QUITToolStripMenuItem.Name = "QUITToolStripMenuItem"
        Me.QUITToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.QUITToolStripMenuItem.Text = "Account"
        '
        'CHANGEPASSWORDToolStripMenuItem
        '
        Me.CHANGEPASSWORDToolStripMenuItem.Name = "CHANGEPASSWORDToolStripMenuItem"
        Me.CHANGEPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.CHANGEPASSWORDToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 6)
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.LOGOUTToolStripMenuItem.Text = "Log-out"
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'StudName
        '
        Me.StudName.HeaderText = "Name"
        Me.StudName.Name = "StudName"
        Me.StudName.ReadOnly = True
        Me.StudName.Width = 545
        '
        'Column1
        '
        Me.Column1.HeaderText = "Sex"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 90
        '
        'ucReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelWork)
        Me.Name = "ucReports"
        Me.panelWork.ResumeLayout(False)
        Me.panelWork.PerformLayout()
        CType(Me.gvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelWork As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents gvReports As System.Windows.Forms.DataGridView
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STUDENTRECORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASSESSMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRANSACTIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STUDENTPAYMENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REFERENCESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradeLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SCHOOLYEARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FEESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ENROLLMENTSTATUSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ENROLLEESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASSESSEDSTUDENTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COLLECTIONREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROMISORIESREPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents USERACCOUNTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAINTENANCEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACTIVITYLOGSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RUNDATABASEBACKUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHANGEPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboSection As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboGl As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboSY As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox15 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
