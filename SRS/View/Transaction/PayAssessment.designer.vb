﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayAssessment))
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtChange = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtReceived = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox8 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAssessed = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtView = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 279)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(504, 40)
        Me.Panel12.TabIndex = 260
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Gray
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(504, 40)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 279)
        Me.Panel15.TabIndex = 262
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(505, 40)
        Me.Panel2.TabIndex = 261
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(189, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "PAY ASSESSMENT"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 239)
        Me.Panel1.TabIndex = 290
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Gray
        Me.btnPay.Enabled = False
        Me.btnPay.FlatAppearance.BorderSize = 0
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(231, 206)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(120, 50)
        Me.btnPay.TabIndex = 3
        Me.btnPay.TabStop = False
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtChange.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtChange.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtChange.CustomButton.Name = ""
        Me.txtChange.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtChange.CustomButton.TabIndex = 1
        Me.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtChange.CustomButton.UseSelectable = True
        Me.txtChange.CustomButton.Visible = False
        Me.txtChange.DisplayIcon = True
        Me.txtChange.Enabled = False
        Me.txtChange.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtChange.Lines = New String() {"0.00"}
        Me.txtChange.Location = New System.Drawing.Point(231, 151)
        Me.txtChange.MaxLength = 10
        Me.txtChange.Name = "txtChange"
        Me.txtChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtChange.SelectedText = ""
        Me.txtChange.SelectionLength = 0
        Me.txtChange.SelectionStart = 0
        Me.txtChange.Size = New System.Drawing.Size(250, 38)
        Me.txtChange.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtChange.TabIndex = 7
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtChange.UseCustomBackColor = True
        Me.txtChange.UseSelectable = True
        Me.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtChange.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.DisplayIcon = True
        Me.MetroTextBox5.Enabled = False
        Me.MetroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox5.Lines = New String() {"Changed"}
        Me.MetroTextBox5.Location = New System.Drawing.Point(25, 151)
        Me.MetroTextBox5.MaxLength = 8
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox5.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox5.TabIndex = 6
        Me.MetroTextBox5.Text = "Changed"
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(361, 206)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 50)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtReceived
        '
        Me.txtReceived.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtReceived.CustomButton.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.txtReceived.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtReceived.CustomButton.Name = ""
        Me.txtReceived.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtReceived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReceived.CustomButton.TabIndex = 1
        Me.txtReceived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReceived.CustomButton.UseSelectable = True
        Me.txtReceived.CustomButton.Visible = False
        Me.txtReceived.DisplayIcon = True
        Me.txtReceived.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtReceived.Lines = New String() {"0.00"}
        Me.txtReceived.Location = New System.Drawing.Point(231, 107)
        Me.txtReceived.MaxLength = 10
        Me.txtReceived.Name = "txtReceived"
        Me.txtReceived.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReceived.SelectedText = ""
        Me.txtReceived.SelectionLength = 0
        Me.txtReceived.SelectionStart = 0
        Me.txtReceived.Size = New System.Drawing.Size(250, 38)
        Me.txtReceived.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtReceived.TabIndex = 2
        Me.txtReceived.Text = "0.00"
        Me.txtReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtReceived.UseCustomBackColor = True
        Me.txtReceived.UseSelectable = True
        Me.txtReceived.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReceived.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox8
        '
        '
        '
        '
        Me.MetroTextBox8.CustomButton.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.MetroTextBox8.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox8.CustomButton.Name = ""
        Me.MetroTextBox8.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox8.CustomButton.TabIndex = 1
        Me.MetroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox8.CustomButton.UseSelectable = True
        Me.MetroTextBox8.CustomButton.Visible = False
        Me.MetroTextBox8.DisplayIcon = True
        Me.MetroTextBox8.Enabled = False
        Me.MetroTextBox8.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox8.Lines = New String() {"Amount Received"}
        Me.MetroTextBox8.Location = New System.Drawing.Point(25, 107)
        Me.MetroTextBox8.MaxLength = 8
        Me.MetroTextBox8.Name = "MetroTextBox8"
        Me.MetroTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox8.SelectedText = ""
        Me.MetroTextBox8.SelectionLength = 0
        Me.MetroTextBox8.SelectionStart = 0
        Me.MetroTextBox8.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox8.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox8.TabIndex = 2
        Me.MetroTextBox8.Text = "Amount Received"
        Me.MetroTextBox8.UseSelectable = True
        Me.MetroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox8.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtAssessed
        '
        Me.txtAssessed.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtAssessed.CustomButton.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.txtAssessed.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtAssessed.CustomButton.Name = ""
        Me.txtAssessed.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtAssessed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAssessed.CustomButton.TabIndex = 1
        Me.txtAssessed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAssessed.CustomButton.UseSelectable = True
        Me.txtAssessed.CustomButton.Visible = False
        Me.txtAssessed.DisplayIcon = True
        Me.txtAssessed.Enabled = False
        Me.txtAssessed.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtAssessed.Lines = New String() {"0.00"}
        Me.txtAssessed.Location = New System.Drawing.Point(231, 63)
        Me.txtAssessed.MaxLength = 10
        Me.txtAssessed.Name = "txtAssessed"
        Me.txtAssessed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssessed.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAssessed.SelectedText = ""
        Me.txtAssessed.SelectionLength = 0
        Me.txtAssessed.SelectionStart = 0
        Me.txtAssessed.Size = New System.Drawing.Size(250, 38)
        Me.txtAssessed.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtAssessed.TabIndex = 292
        Me.txtAssessed.Text = "0.00"
        Me.txtAssessed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAssessed.UseCustomBackColor = True
        Me.txtAssessed.UseSelectable = True
        Me.txtAssessed.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAssessed.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(164, 2)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.DisplayIcon = True
        Me.MetroTextBox2.Enabled = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox2.Lines = New String() {"Assessed Amount"}
        Me.MetroTextBox2.Location = New System.Drawing.Point(25, 63)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(200, 38)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextBox2.TabIndex = 291
        Me.MetroTextBox2.Text = "Assessed Amount"
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtView
        '
        Me.txtView.BackColor = System.Drawing.SystemColors.Info
        '
        '
        '
        Me.txtView.CustomButton.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.txtView.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.txtView.CustomButton.Name = ""
        Me.txtView.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtView.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtView.CustomButton.TabIndex = 1
        Me.txtView.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtView.CustomButton.UseSelectable = True
        Me.txtView.CustomButton.Visible = False
        Me.txtView.DisplayIcon = True
        Me.txtView.Enabled = False
        Me.txtView.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtView.Lines = New String() {"0.00"}
        Me.txtView.Location = New System.Drawing.Point(231, 151)
        Me.txtView.MaxLength = 10
        Me.txtView.Name = "txtView"
        Me.txtView.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtView.SelectedText = ""
        Me.txtView.SelectionLength = 0
        Me.txtView.SelectionStart = 0
        Me.txtView.Size = New System.Drawing.Size(250, 38)
        Me.txtView.Style = MetroFramework.MetroColorStyle.Silver
        Me.txtView.TabIndex = 294
        Me.txtView.Text = "0.00"
        Me.txtView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtView.UseCustomBackColor = True
        Me.txtView.UseSelectable = True
        Me.txtView.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtView.WaterMarkFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PayAssessment
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(505, 319)
        Me.Controls.Add(Me.txtView)
        Me.Controls.Add(Me.txtAssessed)
        Me.Controls.Add(Me.MetroTextBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTextBox8)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.MetroTextBox5)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.txtReceived)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PayAssessment"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents txtReceived As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox8 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtChange As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAssessed As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtView As MetroFramework.Controls.MetroTextBox

End Class
