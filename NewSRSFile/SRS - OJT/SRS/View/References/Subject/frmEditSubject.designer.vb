<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditSubject))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txts = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtTime = New MetroFramework.Controls.MetroTextBox()
        Me.txtSubjectName = New MetroFramework.Controls.MetroTextBox()
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
        Me.btnUpdate.Location = New System.Drawing.Point(30, 156)
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
        Me.btnClose.Location = New System.Drawing.Point(292, 156)
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
        Me.btnSave.Location = New System.Drawing.Point(161, 156)
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
        Me.Panel14.Size = New System.Drawing.Size(1, 186)
        Me.Panel14.TabIndex = 241
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(445, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 186)
        Me.Panel15.TabIndex = 240
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 40)
        Me.Panel2.TabIndex = 239
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(174, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "EDIT SUBJECT"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 226)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(446, 40)
        Me.Panel12.TabIndex = 238
        '
        'txts
        '
        '
        '
        '
        Me.txts.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txts.CustomButton.Location = New System.Drawing.Point(97, 2)
        Me.txts.CustomButton.Name = ""
        Me.txts.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txts.CustomButton.TabIndex = 1
        Me.txts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txts.CustomButton.UseSelectable = True
        Me.txts.CustomButton.Visible = False
        Me.txts.DisplayIcon = True
        Me.txts.Enabled = False
        Me.txts.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txts.Lines = New String() {"Subject Name"}
        Me.txts.Location = New System.Drawing.Point(30, 70)
        Me.txts.MaxLength = 8
        Me.txts.Name = "txts"
        Me.txts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txts.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txts.SelectedText = ""
        Me.txts.SelectionLength = 0
        Me.txts.SelectionStart = 0
        Me.txts.Size = New System.Drawing.Size(125, 30)
        Me.txts.Style = MetroFramework.MetroColorStyle.Silver
        Me.txts.TabIndex = 243
        Me.txts.Text = "Subject Name"
        Me.txts.UseSelectable = True
        Me.txts.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txts.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
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
        Me.MetroTextBox2.Lines = New String() {"Time (Minutes)"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(30, 106)
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
        Me.MetroTextBox2.Text = "Time (Minutes)"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtTime
        '
        '
        '
        '
        Me.txtTime.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.txtTime.CustomButton.Location = New System.Drawing.Point(228, 2)
        Me.txtTime.CustomButton.Name = ""
        Me.txtTime.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTime.CustomButton.TabIndex = 1
        Me.txtTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTime.CustomButton.UseSelectable = True
        Me.txtTime.CustomButton.Visible = False
        Me.txtTime.DisplayIcon = True
        Me.txtTime.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtTime.Lines = New String(-1) {}
        Me.txtTime.Location = New System.Drawing.Point(161, 106)
        Me.txtTime.MaxLength = 10
        Me.txtTime.Name = "txtTime"
        Me.txtTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTime.SelectedText = ""
        Me.txtTime.SelectionLength = 0
        Me.txtTime.SelectionStart = 0
        Me.txtTime.Size = New System.Drawing.Size(256, 30)
        Me.txtTime.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtTime.TabIndex = 2
        Me.txtTime.UseSelectable = True
        Me.txtTime.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTime.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSubjectName
        '
        '
        '
        '
        Me.txtSubjectName.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.txtSubjectName.CustomButton.Location = New System.Drawing.Point(228, 2)
        Me.txtSubjectName.CustomButton.Name = ""
        Me.txtSubjectName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtSubjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSubjectName.CustomButton.TabIndex = 1
        Me.txtSubjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSubjectName.CustomButton.UseSelectable = True
        Me.txtSubjectName.CustomButton.Visible = False
        Me.txtSubjectName.DisplayIcon = True
        Me.txtSubjectName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtSubjectName.Lines = New String(-1) {}
        Me.txtSubjectName.Location = New System.Drawing.Point(161, 70)
        Me.txtSubjectName.MaxLength = 30
        Me.txtSubjectName.Name = "txtSubjectName"
        Me.txtSubjectName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubjectName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSubjectName.SelectedText = ""
        Me.txtSubjectName.SelectionLength = 0
        Me.txtSubjectName.SelectionStart = 0
        Me.txtSubjectName.Size = New System.Drawing.Size(256, 30)
        Me.txtSubjectName.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtSubjectName.TabIndex = 1
        Me.txtSubjectName.UseSelectable = True
        Me.txtSubjectName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSubjectName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmEditSubject
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(446, 266)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtSubjectName)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.txts)
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
        Me.Name = "frmEditSubject"
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
    Friend WithEvents txts As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTime As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSubjectName As MetroFramework.Controls.MetroTextBox

End Class
