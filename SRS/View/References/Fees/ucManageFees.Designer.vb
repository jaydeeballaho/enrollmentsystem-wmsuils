<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucManageFees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucManageFees))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelWork = New System.Windows.Forms.Panel()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.btnAddUniv = New System.Windows.Forms.Button()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddLocal = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.gvFees = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.panelWork.SuspendLayout()
        CType(Me.gvFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelWork
        '
        Me.panelWork.Controls.Add(Me.btnManage)
        Me.panelWork.Controls.Add(Me.btnAddUniv)
        Me.panelWork.Controls.Add(Me.MetroLabel7)
        Me.panelWork.Controls.Add(Me.txtSearch)
        Me.panelWork.Controls.Add(Me.btnAddLocal)
        Me.panelWork.Controls.Add(Me.Panel15)
        Me.panelWork.Controls.Add(Me.Panel14)
        Me.panelWork.Controls.Add(Me.Panel13)
        Me.panelWork.Controls.Add(Me.gvFees)
        Me.panelWork.Controls.Add(Me.Panel12)
        Me.panelWork.Location = New System.Drawing.Point(0, 0)
        Me.panelWork.Name = "panelWork"
        Me.panelWork.Size = New System.Drawing.Size(776, 560)
        Me.panelWork.TabIndex = 230
        '
        'btnManage
        '
        Me.btnManage.BackColor = System.Drawing.Color.Gray
        Me.btnManage.FlatAppearance.BorderSize = 0
        Me.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManage.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManage.ForeColor = System.Drawing.Color.White
        Me.btnManage.Location = New System.Drawing.Point(586, 74)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(173, 30)
        Me.btnManage.TabIndex = 232
        Me.btnManage.TabStop = False
        Me.btnManage.Text = "Manage Schedule of Fees"
        Me.btnManage.UseVisualStyleBackColor = False
        '
        'btnAddUniv
        '
        Me.btnAddUniv.BackColor = System.Drawing.Color.Gray
        Me.btnAddUniv.FlatAppearance.BorderSize = 0
        Me.btnAddUniv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUniv.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUniv.ForeColor = System.Drawing.Color.White
        Me.btnAddUniv.Location = New System.Drawing.Point(440, 74)
        Me.btnAddUniv.Name = "btnAddUniv"
        Me.btnAddUniv.Size = New System.Drawing.Size(140, 30)
        Me.btnAddUniv.TabIndex = 231
        Me.btnAddUniv.TabStop = False
        Me.btnAddUniv.Text = "New University Fees"
        Me.btnAddUniv.UseVisualStyleBackColor = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(13, 50)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(189, 19)
        Me.MetroLabel7.TabIndex = 229
        Me.MetroLabel7.Text = "School Fees or Designation"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'txtSearch
        '
        '
        '
        '
        Me.txtSearch.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtSearch.CustomButton.Location = New System.Drawing.Point(272, 2)
        Me.txtSearch.CustomButton.Name = ""
        Me.txtSearch.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch.CustomButton.TabIndex = 1
        Me.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch.CustomButton.UseSelectable = True
        Me.txtSearch.DisplayIcon = True
        Me.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSearch.Lines = New String(-1) {}
        Me.txtSearch.Location = New System.Drawing.Point(18, 74)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.SelectionLength = 0
        Me.txtSearch.SelectionStart = 0
        Me.txtSearch.ShowButton = True
        Me.txtSearch.Size = New System.Drawing.Size(300, 30)
        Me.txtSearch.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSearch.TabIndex = 228
        Me.txtSearch.UseSelectable = True
        Me.txtSearch.WaterMark = "Search Here"
        Me.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddLocal
        '
        Me.btnAddLocal.BackColor = System.Drawing.Color.Gray
        Me.btnAddLocal.FlatAppearance.BorderSize = 0
        Me.btnAddLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLocal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLocal.ForeColor = System.Drawing.Color.White
        Me.btnAddLocal.Location = New System.Drawing.Point(324, 74)
        Me.btnAddLocal.Name = "btnAddLocal"
        Me.btnAddLocal.Size = New System.Drawing.Size(110, 30)
        Me.btnAddLocal.TabIndex = 224
        Me.btnAddLocal.TabStop = False
        Me.btnAddLocal.Text = "New Local Fees"
        Me.btnAddLocal.UseVisualStyleBackColor = False
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
        Me.gvFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.StudName, Me.amount, Me.Type, Me.edit, Me.delete})
        Me.gvFees.EnableHeadersVisualStyles = False
        Me.gvFees.Location = New System.Drawing.Point(18, 118)
        Me.gvFees.MultiSelect = False
        Me.gvFees.Name = "gvFees"
        Me.gvFees.ReadOnly = True
        Me.gvFees.RowHeadersVisible = False
        Me.gvFees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.gvFees.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gvFees.RowTemplate.Height = 30
        Me.gvFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvFees.Size = New System.Drawing.Size(741, 424)
        Me.gvFees.TabIndex = 225
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
        Me.StudName.HeaderText = "School Fees"
        Me.StudName.Name = "StudName"
        Me.StudName.ReadOnly = True
        Me.StudName.Width = 265
        '
        'amount
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.amount.HeaderText = "Amount"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 120
        '
        'Type
        '
        Me.Type.HeaderText = "Designation"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 150
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        '
        'delete
        '
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.HeaderText = ""
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
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
        Me.MetroLabel6.Size = New System.Drawing.Size(145, 19)
        Me.MetroLabel6.TabIndex = 222
        Me.MetroLabel6.Text = "Manage School Fees"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'ucManageFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelWork)
        Me.Name = "ucManageFees"
        Me.panelWork.ResumeLayout(False)
        Me.panelWork.PerformLayout()
        CType(Me.gvFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelWork As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents gvFees As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddLocal As System.Windows.Forms.Button
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnManage As System.Windows.Forms.Button
    Friend WithEvents btnAddUniv As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents delete As System.Windows.Forms.DataGridViewButtonColumn

End Class
