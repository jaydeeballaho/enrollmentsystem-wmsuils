<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditSchoolYear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditSchoolYear))
        Me.rbClose = New System.Windows.Forms.RadioButton()
        Me.rbOpen = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtNextSY = New MetroFramework.Controls.MetroTextBox()
        Me.txtSY = New MetroFramework.Controls.MetroTextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbClose
        '
        Me.rbClose.AutoSize = True
        Me.rbClose.Checked = True
        Me.rbClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbClose.Location = New System.Drawing.Point(177, 112)
        Me.rbClose.Name = "rbClose"
        Me.rbClose.Size = New System.Drawing.Size(75, 25)
        Me.rbClose.TabIndex = 4
        Me.rbClose.TabStop = True
        Me.rbClose.Text = "CLOSE"
        Me.rbClose.UseVisualStyleBackColor = True
        '
        'rbOpen
        '
        Me.rbOpen.AutoSize = True
        Me.rbOpen.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbOpen.Location = New System.Drawing.Point(69, 112)
        Me.rbOpen.Name = "rbOpen"
        Me.rbOpen.Size = New System.Drawing.Size(69, 25)
        Me.rbOpen.TabIndex = 3
        Me.rbOpen.Text = "OPEN"
        Me.rbOpen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(160, 159)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 40)
        Me.btnClose.TabIndex = 6
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
        Me.btnSave.Location = New System.Drawing.Point(24, 159)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel3.Location = New System.Drawing.Point(144, 81)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(27, 19)
        Me.MetroLabel3.TabIndex = 237
        Me.MetroLabel3.Text = "TO"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'txtNextSY
        '
        '
        '
        '
        Me.txtNextSY.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtNextSY.CustomButton.Location = New System.Drawing.Point(85, 2)
        Me.txtNextSY.CustomButton.Name = ""
        Me.txtNextSY.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNextSY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNextSY.CustomButton.TabIndex = 1
        Me.txtNextSY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNextSY.CustomButton.UseSelectable = True
        Me.txtNextSY.CustomButton.Visible = False
        Me.txtNextSY.DisplayIcon = True
        Me.txtNextSY.Enabled = False
        Me.txtNextSY.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNextSY.Lines = New String(-1) {}
        Me.txtNextSY.Location = New System.Drawing.Point(177, 76)
        Me.txtNextSY.MaxLength = 8
        Me.txtNextSY.Name = "txtNextSY"
        Me.txtNextSY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNextSY.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNextSY.SelectedText = ""
        Me.txtNextSY.SelectionLength = 0
        Me.txtNextSY.SelectionStart = 0
        Me.txtNextSY.Size = New System.Drawing.Size(113, 30)
        Me.txtNextSY.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtNextSY.TabIndex = 2
        Me.txtNextSY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNextSY.UseSelectable = True
        Me.txtNextSY.WaterMark = "School Year"
        Me.txtNextSY.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNextSY.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSY
        '
        '
        '
        '
        Me.txtSY.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.txtSY.CustomButton.Location = New System.Drawing.Point(86, 2)
        Me.txtSY.CustomButton.Name = ""
        Me.txtSY.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSY.CustomButton.TabIndex = 1
        Me.txtSY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSY.CustomButton.UseSelectable = True
        Me.txtSY.CustomButton.Visible = False
        Me.txtSY.DisplayIcon = True
        Me.txtSY.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSY.Lines = New String(-1) {}
        Me.txtSY.Location = New System.Drawing.Point(24, 76)
        Me.txtSY.MaxLength = 8
        Me.txtSY.Name = "txtSY"
        Me.txtSY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSY.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSY.SelectedText = ""
        Me.txtSY.SelectionLength = 0
        Me.txtSY.SelectionStart = 0
        Me.txtSY.Size = New System.Drawing.Size(114, 30)
        Me.txtSY.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSY.TabIndex = 1
        Me.txtSY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSY.UseSelectable = True
        Me.txtSY.WaterMark = "School Year"
        Me.txtSY.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSY.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 40)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 182)
        Me.Panel14.TabIndex = 241
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(314, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 182)
        Me.Panel15.TabIndex = 240
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 40)
        Me.Panel2.TabIndex = 239
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(88, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(138, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "EDIT SCHOOL YEAR"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 222)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(315, 40)
        Me.Panel12.TabIndex = 238
        '
        'frmEditSchoolYear
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(315, 262)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtNextSY)
        Me.Controls.Add(Me.txtSY)
        Me.Controls.Add(Me.rbClose)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rbOpen)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditSchoolYear"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rbClose As System.Windows.Forms.RadioButton
    Friend WithEvents rbOpen As System.Windows.Forms.RadioButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNextSY As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSY As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel

End Class
