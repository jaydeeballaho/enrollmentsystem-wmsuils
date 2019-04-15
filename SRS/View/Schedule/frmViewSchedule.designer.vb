<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewSchedule
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewSchedule))
        Me.gvClass1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboEnd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gvcboRoom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.linkClose = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboLvl = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.gvClass1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvClass1
        '
        Me.gvClass1.AllowUserToAddRows = False
        Me.gvClass1.AllowUserToDeleteRows = False
        Me.gvClass1.AllowUserToResizeColumns = False
        Me.gvClass1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.gvClass1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gvClass1.BackgroundColor = System.Drawing.Color.White
        Me.gvClass1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gvClass1.ColumnHeadersHeight = 30
        Me.gvClass1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gvClass1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.gvcboSubject, Me.gvcboStart, Me.gvcboEnd, Me.gvcboDay, Me.gvcboRoom})
        Me.gvClass1.EnableHeadersVisualStyles = False
        Me.gvClass1.GridColor = System.Drawing.Color.White
        Me.gvClass1.Location = New System.Drawing.Point(12, 117)
        Me.gvClass1.MultiSelect = False
        Me.gvClass1.Name = "gvClass1"
        Me.gvClass1.ReadOnly = True
        Me.gvClass1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gvClass1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gvClass1.RowHeadersVisible = False
        Me.gvClass1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.gvClass1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.gvClass1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvClass1.Size = New System.Drawing.Size(755, 337)
        Me.gvClass1.TabIndex = 15
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
        Me.gvcboSubject.Width = 150
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
        'gvcboDay
        '
        Me.gvcboDay.HeaderText = "Day"
        Me.gvcboDay.Name = "gvcboDay"
        Me.gvcboDay.ReadOnly = True
        Me.gvcboDay.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcboDay.Width = 150
        '
        'gvcboRoom
        '
        Me.gvcboRoom.HeaderText = "Room"
        Me.gvcboRoom.Name = "gvcboRoom"
        Me.gvcboRoom.ReadOnly = True
        Me.gvcboRoom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gvcboRoom.Width = 150
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(778, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 425)
        Me.Panel15.TabIndex = 243
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.linkClose)
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 40)
        Me.Panel2.TabIndex = 242
        '
        'linkClose
        '
        Me.linkClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkClose.ForeColor = System.Drawing.Color.White
        Me.linkClose.Location = New System.Drawing.Point(712, 9)
        Me.linkClose.Name = "linkClose"
        Me.linkClose.Size = New System.Drawing.Size(43, 23)
        Me.linkClose.TabIndex = 228
        Me.linkClose.Text = "Close"
        Me.linkClose.UseCustomBackColor = True
        Me.linkClose.UseCustomForeColor = True
        Me.linkClose.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(331, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "VIEW SCHEDULE"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 465)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(779, 40)
        Me.Panel12.TabIndex = 241
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(314, 75)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(145, 21)
        Me.cboSection.TabIndex = 245
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(311, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 247
        Me.Label5.Text = "Section:"
        '
        'cboLvl
        '
        Me.cboLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLvl.FormattingEnabled = True
        Me.cboLvl.Location = New System.Drawing.Point(163, 75)
        Me.cboLvl.Name = "cboLvl"
        Me.cboLvl.Size = New System.Drawing.Size(145, 21)
        Me.cboLvl.TabIndex = 244
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(163, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 246
        Me.Label3.Text = "Grade Level:"
        '
        'cboSy
        '
        Me.cboSy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSy.FormattingEnabled = True
        Me.cboSy.Location = New System.Drawing.Point(12, 75)
        Me.cboSy.Name = "cboSy"
        Me.cboSy.Size = New System.Drawing.Size(145, 21)
        Me.cboSy.TabIndex = 248
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "School Year"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(465, 71)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 27)
        Me.btnPrint.TabIndex = 250
        Me.btnPrint.Text = "Print Schedule"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmViewSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(779, 505)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cboSy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboLvl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.gvClass1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewSchedule"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.gvClass1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvClass1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents linkClose As MetroFramework.Controls.MetroLink
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboEnd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gvcboRoom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboLvl As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
