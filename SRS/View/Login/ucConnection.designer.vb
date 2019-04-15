<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucConnection
    Inherits System.Windows.Forms.UserControl

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucConnection))
        Me.SettingsPanel = New MetroFramework.Controls.MetroPanel()
        Me.LinkBack = New MetroFramework.Controls.MetroLink()
        Me.lblSettings = New MetroFramework.Controls.MetroLabel()
        Me.ConnectionTab = New MetroFramework.Controls.MetroTabControl()
        Me.SettingsTab = New MetroFramework.Controls.MetroTabPage()
        Me.btnTestCon = New MetroFramework.Controls.MetroButton()
        Me.lblPassword = New MetroFramework.Controls.MetroLabel()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.txtUsername = New MetroFramework.Controls.MetroTextBox()
        Me.lblDatabaseName = New MetroFramework.Controls.MetroLabel()
        Me.txtDatabaseName = New MetroFramework.Controls.MetroTextBox()
        Me.lblPortNo = New MetroFramework.Controls.MetroLabel()
        Me.txtPort = New MetroFramework.Controls.MetroTextBox()
        Me.lblServerIP = New MetroFramework.Controls.MetroLabel()
        Me.txtServer = New MetroFramework.Controls.MetroTextBox()
        Me.BorderPanel = New System.Windows.Forms.Panel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SettingsPanel.SuspendLayout()
        Me.ConnectionTab.SuspendLayout()
        Me.SettingsTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsPanel
        '
        Me.SettingsPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsPanel.Controls.Add(Me.LinkBack)
        Me.SettingsPanel.Controls.Add(Me.lblSettings)
        Me.SettingsPanel.Controls.Add(Me.ConnectionTab)
        Me.SettingsPanel.Controls.Add(Me.BorderPanel)
        Me.SettingsPanel.HorizontalScrollbarBarColor = True
        Me.SettingsPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.SettingsPanel.HorizontalScrollbarSize = 10
        Me.SettingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.SettingsPanel.Size = New System.Drawing.Size(350, 728)
        Me.SettingsPanel.TabIndex = 4
        Me.SettingsPanel.VerticalScrollbarBarColor = True
        Me.SettingsPanel.VerticalScrollbarHighlightOnWheel = False
        Me.SettingsPanel.VerticalScrollbarSize = 10
        '
        'LinkBack
        '
        Me.LinkBack.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.LinkBack.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.LinkBack.Image = CType(resources.GetObject("LinkBack.Image"), System.Drawing.Image)
        Me.LinkBack.ImageSize = 28
        Me.LinkBack.Location = New System.Drawing.Point(14, 39)
        Me.LinkBack.Name = "LinkBack"
        Me.LinkBack.Size = New System.Drawing.Size(30, 30)
        Me.LinkBack.TabIndex = 2
        Me.LinkBack.TabStop = False
        Me.ToolTip.SetToolTip(Me.LinkBack, "Back to Log-in")
        Me.LinkBack.UseSelectable = True
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblSettings.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblSettings.ForeColor = System.Drawing.Color.Black
        Me.lblSettings.Location = New System.Drawing.Point(41, 43)
        Me.lblSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(76, 25)
        Me.lblSettings.TabIndex = 382
        Me.lblSettings.Text = "Settings"
        Me.lblSettings.UseCustomBackColor = True
        Me.lblSettings.UseCustomForeColor = True
        '
        'ConnectionTab
        '
        Me.ConnectionTab.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectionTab.Controls.Add(Me.SettingsTab)
        Me.ConnectionTab.Location = New System.Drawing.Point(10, 86)
        Me.ConnectionTab.Name = "ConnectionTab"
        Me.ConnectionTab.SelectedIndex = 0
        Me.ConnectionTab.Size = New System.Drawing.Size(330, 365)
        Me.ConnectionTab.Style = MetroFramework.MetroColorStyle.Red
        Me.ConnectionTab.TabIndex = 3
        Me.ConnectionTab.TabStop = False
        Me.ConnectionTab.UseSelectable = True
        '
        'SettingsTab
        '
        Me.SettingsTab.BackColor = System.Drawing.Color.White
        Me.SettingsTab.Controls.Add(Me.btnTestCon)
        Me.SettingsTab.Controls.Add(Me.lblPassword)
        Me.SettingsTab.Controls.Add(Me.txtPassword)
        Me.SettingsTab.Controls.Add(Me.lblUsername)
        Me.SettingsTab.Controls.Add(Me.txtUsername)
        Me.SettingsTab.Controls.Add(Me.lblDatabaseName)
        Me.SettingsTab.Controls.Add(Me.txtDatabaseName)
        Me.SettingsTab.Controls.Add(Me.lblPortNo)
        Me.SettingsTab.Controls.Add(Me.txtPort)
        Me.SettingsTab.Controls.Add(Me.lblServerIP)
        Me.SettingsTab.Controls.Add(Me.txtServer)
        Me.SettingsTab.HorizontalScrollbarBarColor = True
        Me.SettingsTab.HorizontalScrollbarHighlightOnWheel = False
        Me.SettingsTab.HorizontalScrollbarSize = 10
        Me.SettingsTab.Location = New System.Drawing.Point(4, 38)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Size = New System.Drawing.Size(322, 323)
        Me.SettingsTab.TabIndex = 0
        Me.SettingsTab.Text = "Connection"
        Me.SettingsTab.VerticalScrollbarBarColor = True
        Me.SettingsTab.VerticalScrollbarHighlightOnWheel = False
        Me.SettingsTab.VerticalScrollbarSize = 10
        '
        'btnTestCon
        '
        Me.btnTestCon.BackColor = System.Drawing.Color.White
        Me.btnTestCon.ForeColor = System.Drawing.Color.Black
        Me.btnTestCon.Location = New System.Drawing.Point(12, 277)
        Me.btnTestCon.Name = "btnTestCon"
        Me.btnTestCon.Size = New System.Drawing.Size(300, 30)
        Me.btnTestCon.TabIndex = 6
        Me.btnTestCon.Text = "Test Connection"
        Me.btnTestCon.UseCustomBackColor = True
        Me.btnTestCon.UseSelectable = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(10, 224)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(66, 19)
        Me.lblPassword.TabIndex = 192
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPassword.WrapToLine = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(276, 1)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(12, 246)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(300, 25)
        Me.txtPassword.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMark = "Password"
        Me.txtPassword.WaterMarkColor = System.Drawing.SystemColors.GrayText
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.White
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(10, 174)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(71, 19)
        Me.lblUsername.TabIndex = 190
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername.WrapToLine = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUsername.CustomButton.Image = Nothing
        Me.txtUsername.CustomButton.Location = New System.Drawing.Point(276, 1)
        Me.txtUsername.CustomButton.Name = ""
        Me.txtUsername.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsername.CustomButton.TabIndex = 1
        Me.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.CustomButton.UseSelectable = True
        Me.txtUsername.CustomButton.Visible = False
        Me.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtUsername.Lines = New String(-1) {}
        Me.txtUsername.Location = New System.Drawing.Point(12, 196)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(300, 25)
        Me.txtUsername.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsername.UseSelectable = True
        Me.txtUsername.WaterMark = "Username"
        Me.txtUsername.WaterMarkColor = System.Drawing.SystemColors.GrayText
        Me.txtUsername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.BackColor = System.Drawing.Color.White
        Me.lblDatabaseName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDatabaseName.Location = New System.Drawing.Point(10, 124)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(106, 19)
        Me.lblDatabaseName.TabIndex = 188
        Me.lblDatabaseName.Text = "Database Name:"
        Me.lblDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDatabaseName.WrapToLine = True
        '
        'txtDatabaseName
        '
        Me.txtDatabaseName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDatabaseName.CustomButton.Image = Nothing
        Me.txtDatabaseName.CustomButton.Location = New System.Drawing.Point(276, 1)
        Me.txtDatabaseName.CustomButton.Name = ""
        Me.txtDatabaseName.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtDatabaseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDatabaseName.CustomButton.TabIndex = 1
        Me.txtDatabaseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDatabaseName.CustomButton.UseSelectable = True
        Me.txtDatabaseName.CustomButton.Visible = False
        Me.txtDatabaseName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtDatabaseName.Lines = New String(-1) {}
        Me.txtDatabaseName.Location = New System.Drawing.Point(12, 146)
        Me.txtDatabaseName.MaxLength = 30
        Me.txtDatabaseName.Name = "txtDatabaseName"
        Me.txtDatabaseName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatabaseName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDatabaseName.SelectedText = ""
        Me.txtDatabaseName.SelectionLength = 0
        Me.txtDatabaseName.SelectionStart = 0
        Me.txtDatabaseName.Size = New System.Drawing.Size(300, 25)
        Me.txtDatabaseName.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtDatabaseName.TabIndex = 3
        Me.txtDatabaseName.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDatabaseName.UseSelectable = True
        Me.txtDatabaseName.WaterMark = "Database Name"
        Me.txtDatabaseName.WaterMarkColor = System.Drawing.SystemColors.GrayText
        Me.txtDatabaseName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblPortNo
        '
        Me.lblPortNo.AutoSize = True
        Me.lblPortNo.BackColor = System.Drawing.Color.White
        Me.lblPortNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPortNo.Location = New System.Drawing.Point(10, 74)
        Me.lblPortNo.Name = "lblPortNo"
        Me.lblPortNo.Size = New System.Drawing.Size(91, 19)
        Me.lblPortNo.TabIndex = 186
        Me.lblPortNo.Text = "Port Number:"
        Me.lblPortNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPortNo.WrapToLine = True
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPort.CustomButton.Image = Nothing
        Me.txtPort.CustomButton.Location = New System.Drawing.Point(276, 1)
        Me.txtPort.CustomButton.Name = ""
        Me.txtPort.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPort.CustomButton.TabIndex = 1
        Me.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPort.CustomButton.UseSelectable = True
        Me.txtPort.CustomButton.Visible = False
        Me.txtPort.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPort.Lines = New String(-1) {}
        Me.txtPort.Location = New System.Drawing.Point(12, 96)
        Me.txtPort.MaxLength = 20
        Me.txtPort.Name = "txtPort"
        Me.txtPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPort.SelectedText = ""
        Me.txtPort.SelectionLength = 0
        Me.txtPort.SelectionStart = 0
        Me.txtPort.Size = New System.Drawing.Size(300, 25)
        Me.txtPort.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtPort.TabIndex = 2
        Me.txtPort.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPort.UseSelectable = True
        Me.txtPort.WaterMark = "Port Number"
        Me.txtPort.WaterMarkColor = System.Drawing.SystemColors.GrayText
        Me.txtPort.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblServerIP
        '
        Me.lblServerIP.AutoSize = True
        Me.lblServerIP.BackColor = System.Drawing.Color.White
        Me.lblServerIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblServerIP.Location = New System.Drawing.Point(11, 24)
        Me.lblServerIP.Name = "lblServerIP"
        Me.lblServerIP.Size = New System.Drawing.Size(65, 19)
        Me.lblServerIP.TabIndex = 184
        Me.lblServerIP.Text = "Server IP:"
        Me.lblServerIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblServerIP.WrapToLine = True
        '
        'txtServer
        '
        Me.txtServer.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtServer.CustomButton.Image = Nothing
        Me.txtServer.CustomButton.Location = New System.Drawing.Point(276, 1)
        Me.txtServer.CustomButton.Name = ""
        Me.txtServer.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtServer.CustomButton.TabIndex = 1
        Me.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtServer.CustomButton.UseSelectable = True
        Me.txtServer.CustomButton.Visible = False
        Me.txtServer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtServer.Lines = New String(-1) {}
        Me.txtServer.Location = New System.Drawing.Point(11, 46)
        Me.txtServer.MaxLength = 20
        Me.txtServer.Name = "txtServer"
        Me.txtServer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtServer.SelectedText = ""
        Me.txtServer.SelectionLength = 0
        Me.txtServer.SelectionStart = 0
        Me.txtServer.Size = New System.Drawing.Size(300, 25)
        Me.txtServer.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtServer.TabIndex = 1
        Me.txtServer.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtServer.UseSelectable = True
        Me.txtServer.WaterMark = "IP Address (e.g. 192.168.10.150)"
        Me.txtServer.WaterMarkColor = System.Drawing.SystemColors.GrayText
        Me.txtServer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BorderPanel
        '
        Me.BorderPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BorderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BorderPanel.Location = New System.Drawing.Point(2, 39)
        Me.BorderPanel.Name = "BorderPanel"
        Me.BorderPanel.Size = New System.Drawing.Size(1, 650)
        Me.BorderPanel.TabIndex = 0
        '
        'ConnectionForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SettingsPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "ConnectionForm"
        Me.Size = New System.Drawing.Size(350, 728)
        Me.SettingsPanel.ResumeLayout(False)
        Me.SettingsPanel.PerformLayout()
        Me.ConnectionTab.ResumeLayout(False)
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SettingsPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents ConnectionTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents SettingsTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnTestCon As MetroFramework.Controls.MetroButton
    Friend WithEvents lblPassword As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUsername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblDatabaseName As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDatabaseName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPortNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtPort As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblServerIP As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtServer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LinkBack As MetroFramework.Controls.MetroLink
    Friend WithEvents BorderPanel As System.Windows.Forms.Panel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblSettings As MetroFramework.Controls.MetroLabel

End Class
