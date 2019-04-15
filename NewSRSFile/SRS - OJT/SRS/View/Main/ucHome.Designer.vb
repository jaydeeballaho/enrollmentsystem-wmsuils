<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucHome
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
        Me.panelWork = New System.Windows.Forms.Panel()
        Me.LinkName = New MetroFramework.Controls.MetroLink()
        Me.lblName = New MetroFramework.Controls.MetroLabel()
        Me.lblAllRights = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.panelWork.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelWork
        '
        Me.panelWork.Controls.Add(Me.LinkName)
        Me.panelWork.Controls.Add(Me.lblName)
        Me.panelWork.Controls.Add(Me.lblAllRights)
        Me.panelWork.Controls.Add(Me.MetroLabel1)
        Me.panelWork.Controls.Add(Me.Panel15)
        Me.panelWork.Controls.Add(Me.Panel14)
        Me.panelWork.Controls.Add(Me.Panel13)
        Me.panelWork.Controls.Add(Me.Panel12)
        Me.panelWork.Location = New System.Drawing.Point(0, 0)
        Me.panelWork.Name = "panelWork"
        Me.panelWork.Size = New System.Drawing.Size(776, 560)
        Me.panelWork.TabIndex = 229
        '
        'LinkName
        '
        Me.LinkName.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.LinkName.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.LinkName.Location = New System.Drawing.Point(23, 519)
        Me.LinkName.Margin = New System.Windows.Forms.Padding(0)
        Me.LinkName.Name = "LinkName"
        Me.LinkName.Size = New System.Drawing.Size(102, 19)
        Me.LinkName.TabIndex = 231
        Me.LinkName.Text = "Prinicipal Name"
        Me.LinkName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkName.UseSelectable = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(131, 519)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(102, 19)
        Me.lblName.TabIndex = 230
        Me.lblName.Text = "Prinicipal Name"
        '
        'lblAllRights
        '
        Me.lblAllRights.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAllRights.AutoSize = True
        Me.lblAllRights.Location = New System.Drawing.Point(581, 519)
        Me.lblAllRights.Name = "lblAllRights"
        Me.lblAllRights.Size = New System.Drawing.Size(170, 19)
        Me.lblAllRights.TabIndex = 229
        Me.lblAllRights.Text = "All Rights Reserved. © 2017"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 519)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel1.TabIndex = 228
        Me.MetroLabel1.Text = "Prinicipal Name"
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
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(776, 40)
        Me.Panel12.TabIndex = 6
        '
        'ucHome
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.panelWork)
        Me.Name = "ucHome"
        Me.panelWork.ResumeLayout(False)
        Me.panelWork.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelWork As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAllRights As MetroFramework.Controls.MetroLabel
    Friend WithEvents LinkName As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel

End Class
