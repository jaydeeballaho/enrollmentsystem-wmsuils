<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLogin
    Inherits MetroFramework.Controls.MetroUserControl

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucLogin))
        Me.panelSetting = New System.Windows.Forms.Panel()
        Me.LinkMinimize = New MetroFramework.Controls.MetroLink()
        Me.LinkClose = New MetroFramework.Controls.MetroLink()
        Me.LinkHelp = New MetroFramework.Controls.MetroLink()
        Me.LinkSetting = New MetroFramework.Controls.MetroLink()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.txtUserpassword = New MetroFramework.Controls.MetroTextBox()
        Me.LoginToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAllRights = New MetroFramework.Controls.MetroLabel()
        Me.chbRemember = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnSignin = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelSetting.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSetting
        '
        Me.panelSetting.Controls.Add(Me.LinkMinimize)
        Me.panelSetting.Controls.Add(Me.LinkClose)
        Me.panelSetting.Controls.Add(Me.LinkHelp)
        Me.panelSetting.Controls.Add(Me.LinkSetting)
        Me.panelSetting.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelSetting.Location = New System.Drawing.Point(1016, 0)
        Me.panelSetting.Name = "panelSetting"
        Me.panelSetting.Size = New System.Drawing.Size(350, 728)
        Me.panelSetting.TabIndex = 225
        '
        'LinkMinimize
        '
        Me.LinkMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkMinimize.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkMinimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.LinkMinimize.ImageSize = 13
        Me.LinkMinimize.Location = New System.Drawing.Point(305, 3)
        Me.LinkMinimize.Name = "LinkMinimize"
        Me.LinkMinimize.Size = New System.Drawing.Size(17, 17)
        Me.LinkMinimize.TabIndex = 4
        Me.LinkMinimize.TabStop = False
        Me.LinkMinimize.Text = "__"
        Me.LinkMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoginToolTip.SetToolTip(Me.LinkMinimize, "Minimize")
        Me.LinkMinimize.UseCustomForeColor = True
        Me.LinkMinimize.UseSelectable = True
        '
        'LinkClose
        '
        Me.LinkClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkClose.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.LinkClose.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkClose.Image = CType(resources.GetObject("LinkClose.Image"), System.Drawing.Image)
        Me.LinkClose.ImageSize = 11
        Me.LinkClose.Location = New System.Drawing.Point(328, 3)
        Me.LinkClose.Name = "LinkClose"
        Me.LinkClose.Size = New System.Drawing.Size(17, 17)
        Me.LinkClose.TabIndex = 216
        Me.LinkClose.TabStop = False
        Me.LoginToolTip.SetToolTip(Me.LinkClose, "Exit")
        Me.LinkClose.UseSelectable = True
        '
        'LinkHelp
        '
        Me.LinkHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkHelp.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.LinkHelp.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkHelp.Image = CType(resources.GetObject("LinkHelp.Image"), System.Drawing.Image)
        Me.LinkHelp.Location = New System.Drawing.Point(259, 3)
        Me.LinkHelp.Name = "LinkHelp"
        Me.LinkHelp.Size = New System.Drawing.Size(17, 17)
        Me.LinkHelp.TabIndex = 2
        Me.LinkHelp.TabStop = False
        Me.LoginToolTip.SetToolTip(Me.LinkHelp, "About")
        Me.LinkHelp.UseSelectable = True
        '
        'LinkSetting
        '
        Me.LinkSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkSetting.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.LinkSetting.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkSetting.Image = CType(resources.GetObject("LinkSetting.Image"), System.Drawing.Image)
        Me.LinkSetting.Location = New System.Drawing.Point(282, 3)
        Me.LinkSetting.Name = "LinkSetting"
        Me.LinkSetting.Size = New System.Drawing.Size(17, 17)
        Me.LinkSetting.TabIndex = 3
        Me.LinkSetting.TabStop = False
        Me.LoginToolTip.SetToolTip(Me.LinkSetting, "Connection")
        Me.LinkSetting.UseSelectable = True
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(279, 2)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.DisplayIcon = True
        Me.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUsername.Icon = CType(resources.GetObject("txtUsername.Icon"), System.Drawing.Image)
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(530, 451)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(307, 30)
        Me.txtUsername.Style = MetroFramework.MetroColorStyle.Red
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "Username"
        Me.txtUsername.WaterMarkColor = System.Drawing.SystemColors.GrayText
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtUserpassword
        '
        Me.txtUserpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        '
        '
        '
        Me.txtUserpassword.CustomButton.Image = Nothing
        Me.txtUserpassword.CustomButton.Location = New System.Drawing.Point(279, 2)
        Me.txtUserpassword.CustomButton.Name = ""
        Me.txtUserpassword.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.txtUserpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Red
        Me.txtUserpassword.CustomButton.TabIndex = 1
        Me.txtUserpassword.CustomButton.TabStop = False
        Me.txtUserpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUserpassword.CustomButton.UseSelectable = True
        Me.txtUserpassword.CustomButton.Visible = False
        Me.txtUserpassword.DisplayIcon = True
        Me.txtUserpassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUserpassword.Icon = CType(resources.GetObject("txtUserpassword.Icon"), System.Drawing.Image)
        Me.txtUserpassword.Lines = New String(-1) {}
        Me.txtUserpassword.Location = New System.Drawing.Point(530, 487)
        Me.txtUserpassword.MaxLength = 30
        Me.txtUserpassword.Name = "txtUserpassword"
        Me.txtUserpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtUserpassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUserpassword.SelectedText = ""
        Me.txtUserpassword.SelectionLength = 0
        Me.txtUserpassword.SelectionStart = 0
        Me.txtUserpassword.Size = New System.Drawing.Size(307, 30)
        Me.txtUserpassword.Style = MetroFramework.MetroColorStyle.Red
        Me.txtUserpassword.TabIndex = 2
        Me.txtUserpassword.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUserpassword.UseSelectable = True
        Me.txtUserpassword.WaterMark = "Password"
        Me.txtUserpassword.WaterMarkColor = System.Drawing.SystemColors.GrayText
        Me.txtUserpassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblAllRights
        '
        Me.lblAllRights.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAllRights.AutoSize = True
        Me.lblAllRights.Location = New System.Drawing.Point(598, 683)
        Me.lblAllRights.Name = "lblAllRights"
        Me.lblAllRights.Size = New System.Drawing.Size(170, 19)
        Me.lblAllRights.TabIndex = 220
        Me.lblAllRights.Text = "All Rights Reserved. © 2017"
        '
        'chbRemember
        '
        Me.chbRemember.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chbRemember.AutoSize = True
        Me.chbRemember.Location = New System.Drawing.Point(530, 561)
        Me.chbRemember.Name = "chbRemember"
        Me.chbRemember.Size = New System.Drawing.Size(101, 15)
        Me.chbRemember.Style = MetroFramework.MetroColorStyle.Red
        Me.chbRemember.TabIndex = 4
        Me.chbRemember.TabStop = False
        Me.chbRemember.Text = "Remember me"
        Me.chbRemember.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(520, 417)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(327, 25)
        Me.MetroLabel2.TabIndex = 217
        Me.MetroLabel2.Text = "ELEMENTARY ENROLLMENT SYSTEM"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSignin
        '
        Me.btnSignin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSignin.Enabled = False
        Me.btnSignin.Location = New System.Drawing.Point(530, 523)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(307, 32)
        Me.btnSignin.TabIndex = 3
        Me.btnSignin.Text = "Log-in"
        Me.btnSignin.UseCustomBackColor = True
        Me.btnSignin.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(508, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 350)
        Me.PictureBox1.TabIndex = 218
        Me.PictureBox1.TabStop = False
        '
        'ucLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.panelSetting)
        Me.Controls.Add(Me.txtUserpassword)
        Me.Controls.Add(Me.lblAllRights)
        Me.Controls.Add(Me.chbRemember)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "ucLogin"
        Me.Size = New System.Drawing.Size(1366, 728)
        Me.panelSetting.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelSetting As System.Windows.Forms.Panel
    Friend WithEvents LinkMinimize As MetroFramework.Controls.MetroLink
    Friend WithEvents LoginToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents LinkClose As MetroFramework.Controls.MetroLink
    Friend WithEvents LinkHelp As MetroFramework.Controls.MetroLink
    Friend WithEvents LinkSetting As MetroFramework.Controls.MetroLink
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUserpassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblAllRights As MetroFramework.Controls.MetroLabel
    Friend WithEvents chbRemember As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSignin As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
