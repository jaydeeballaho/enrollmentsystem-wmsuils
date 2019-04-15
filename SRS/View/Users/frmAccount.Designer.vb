<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccount))
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.linkClose = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblName = New MetroFramework.Controls.MetroLabel()
        Me.lblType = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.txtNewPass = New MetroFramework.Controls.MetroTextBox()
        Me.txtConfirmPass = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSignin = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Gray
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel14.Location = New System.Drawing.Point(0, 40)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 309)
        Me.Panel14.TabIndex = 259
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(373, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 309)
        Me.Panel15.TabIndex = 258
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.linkClose)
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 40)
        Me.Panel2.TabIndex = 257
        '
        'linkClose
        '
        Me.linkClose.ForeColor = System.Drawing.Color.White
        Me.linkClose.Location = New System.Drawing.Point(323, 9)
        Me.linkClose.Name = "linkClose"
        Me.linkClose.Size = New System.Drawing.Size(43, 23)
        Me.linkClose.TabIndex = 224
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
        Me.MetroLabel1.Location = New System.Drawing.Point(136, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "MY ACCOUNT"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 349)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(374, 40)
        Me.Panel12.TabIndex = 256
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(35, 68)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel2.TabIndex = 267
        Me.MetroLabel2.Text = "Name"
        '
        'lblName
        '
        Me.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblName.Location = New System.Drawing.Point(140, 68)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(200, 19)
        Me.lblName.TabIndex = 268
        Me.lblName.Text = "ADMIN ADMIN"
        '
        'lblType
        '
        Me.lblType.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblType.Location = New System.Drawing.Point(140, 90)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(200, 19)
        Me.lblType.TabIndex = 270
        Me.lblType.Text = "ADMINISTRATOR"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(35, 90)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel4.TabIndex = 269
        Me.MetroLabel4.Text = "User Type"
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(277, 2)
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
        Me.txtUsername.Location = New System.Drawing.Point(35, 137)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(305, 30)
        Me.txtUsername.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "New Username"
        Me.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNewPass
        '
        '
        '
        '
        Me.txtNewPass.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.txtNewPass.CustomButton.Location = New System.Drawing.Point(277, 2)
        Me.txtNewPass.CustomButton.Name = ""
        Me.txtNewPass.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNewPass.CustomButton.TabIndex = 1
        Me.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNewPass.CustomButton.UseSelectable = True
        Me.txtNewPass.CustomButton.Visible = False
        Me.txtNewPass.DisplayIcon = True
        Me.txtNewPass.Enabled = False
        Me.txtNewPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNewPass.Lines = New String(-1) {}
        Me.txtNewPass.Location = New System.Drawing.Point(35, 173)
        Me.txtNewPass.MaxLength = 30
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNewPass.SelectedText = ""
        Me.txtNewPass.SelectionLength = 0
        Me.txtNewPass.SelectionStart = 0
        Me.txtNewPass.Size = New System.Drawing.Size(305, 30)
        Me.txtNewPass.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtNewPass.TabIndex = 2
        Me.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNewPass.UseSelectable = True
        Me.txtNewPass.UseSystemPasswordChar = True
        Me.txtNewPass.WaterMark = "New Password"
        Me.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNewPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtConfirmPass
        '
        '
        '
        '
        Me.txtConfirmPass.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.txtConfirmPass.CustomButton.Location = New System.Drawing.Point(277, 2)
        Me.txtConfirmPass.CustomButton.Name = ""
        Me.txtConfirmPass.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConfirmPass.CustomButton.TabIndex = 1
        Me.txtConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConfirmPass.CustomButton.UseSelectable = True
        Me.txtConfirmPass.CustomButton.Visible = False
        Me.txtConfirmPass.DisplayIcon = True
        Me.txtConfirmPass.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtConfirmPass.Lines = New String(-1) {}
        Me.txtConfirmPass.Location = New System.Drawing.Point(35, 209)
        Me.txtConfirmPass.MaxLength = 30
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.SelectionLength = 0
        Me.txtConfirmPass.SelectionStart = 0
        Me.txtConfirmPass.Size = New System.Drawing.Size(305, 30)
        Me.txtConfirmPass.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtConfirmPass.TabIndex = 3
        Me.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtConfirmPass.UseSelectable = True
        Me.txtConfirmPass.UseSystemPasswordChar = True
        Me.txtConfirmPass.Visible = False
        Me.txtConfirmPass.WaterMark = "Confirm Password"
        Me.txtConfirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirmPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(32, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 55)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "Note: Username and Passwords should be atleast 6 characters long and are case sen" & _
    "sitive."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSignin
        '
        Me.btnSignin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSignin.Location = New System.Drawing.Point(35, 245)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(305, 32)
        Me.btnSignin.TabIndex = 4
        Me.btnSignin.Text = "Update"
        Me.btnSignin.UseCustomBackColor = True
        Me.btnSignin.UseSelectable = True
        '
        'frmAccount
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 389)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel12)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccount"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblType As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNewPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtConfirmPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSignin As MetroFramework.Controls.MetroButton
    Friend WithEvents linkClose As MetroFramework.Controls.MetroLink

End Class
