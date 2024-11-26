<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuBar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSidePanel = New System.Windows.Forms.Label()
        Me.txtBtnOrder = New System.Windows.Forms.TextBox()
        Me.txtBtnMenu = New System.Windows.Forms.TextBox()
        Me.txtBtnHome = New System.Windows.Forms.TextBox()
        Me.txtBtnProfile = New System.Windows.Forms.TextBox()
        Me.ToolTipHome = New System.Windows.Forms.ToolTip(Me.components)
        Me.rBtnHome = New FoodOrderingSystem.RoundButton()
        Me.rBtnProfile = New FoodOrderingSystem.RoundButton()
        Me.rBtnMenu = New FoodOrderingSystem.RoundButton()
        Me.rBtnOrder = New FoodOrderingSystem.RoundButton()
        Me.SuspendLayout()
        '
        'lblSidePanel
        '
        Me.lblSidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSidePanel.ForeColor = System.Drawing.Color.White
        Me.lblSidePanel.Location = New System.Drawing.Point(0, 0)
        Me.lblSidePanel.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblSidePanel.Name = "lblSidePanel"
        Me.lblSidePanel.Size = New System.Drawing.Size(94, 3271)
        Me.lblSidePanel.TabIndex = 11
        '
        'txtBtnOrder
        '
        Me.txtBtnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtBtnOrder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBtnOrder.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtnOrder.ForeColor = System.Drawing.Color.White
        Me.txtBtnOrder.Location = New System.Drawing.Point(-6, 2355)
        Me.txtBtnOrder.Name = "txtBtnOrder"
        Me.txtBtnOrder.Size = New System.Drawing.Size(100, 24)
        Me.txtBtnOrder.TabIndex = 16
        Me.txtBtnOrder.Text = "Order"
        Me.txtBtnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBtnMenu
        '
        Me.txtBtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtBtnMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBtnMenu.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtnMenu.ForeColor = System.Drawing.Color.White
        Me.txtBtnMenu.Location = New System.Drawing.Point(-6, 2214)
        Me.txtBtnMenu.Name = "txtBtnMenu"
        Me.txtBtnMenu.Size = New System.Drawing.Size(100, 24)
        Me.txtBtnMenu.TabIndex = 17
        Me.txtBtnMenu.Text = " Menu"
        Me.txtBtnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBtnHome
        '
        Me.txtBtnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtBtnHome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBtnHome.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtnHome.ForeColor = System.Drawing.Color.White
        Me.txtBtnHome.Location = New System.Drawing.Point(-6, 2080)
        Me.txtBtnHome.Name = "txtBtnHome"
        Me.txtBtnHome.Size = New System.Drawing.Size(100, 24)
        Me.txtBtnHome.TabIndex = 18
        Me.txtBtnHome.Text = " Home"
        Me.txtBtnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBtnProfile
        '
        Me.txtBtnProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtBtnProfile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBtnProfile.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtnProfile.ForeColor = System.Drawing.Color.White
        Me.txtBtnProfile.Location = New System.Drawing.Point(-6, 3247)
        Me.txtBtnProfile.Name = "txtBtnProfile"
        Me.txtBtnProfile.Size = New System.Drawing.Size(100, 24)
        Me.txtBtnProfile.TabIndex = 19
        Me.txtBtnProfile.Text = "Profile"
        Me.txtBtnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolTipHome
        '
        Me.ToolTipHome.ToolTipTitle = "To"
        '
        'rBtnHome
        '
        Me.rBtnHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnHome.FlatAppearance.BorderSize = 0
        Me.rBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnHome.Image = Global.FoodOrderingSystem.My.Resources.Resources.homeIcon
        Me.rBtnHome.Location = New System.Drawing.Point(12, 2017)
        Me.rBtnHome.Name = "rBtnHome"
        Me.rBtnHome.Size = New System.Drawing.Size(59, 57)
        Me.rBtnHome.TabIndex = 12
        Me.ToolTipHome.SetToolTip(Me.rBtnHome, "Home")
        Me.rBtnHome.UseVisualStyleBackColor = False
        '
        'rBtnProfile
        '
        Me.rBtnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnProfile.FlatAppearance.BorderSize = 0
        Me.rBtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnProfile.Image = Global.FoodOrderingSystem.My.Resources.Resources.profileIcon
        Me.rBtnProfile.Location = New System.Drawing.Point(12, 3182)
        Me.rBtnProfile.Name = "rBtnProfile"
        Me.rBtnProfile.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.rBtnProfile.Size = New System.Drawing.Size(59, 55)
        Me.rBtnProfile.TabIndex = 15
        Me.rBtnProfile.UseVisualStyleBackColor = False
        '
        'rBtnMenu
        '
        Me.rBtnMenu.FlatAppearance.BorderSize = 0
        Me.rBtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnMenu.Image = Global.FoodOrderingSystem.My.Resources.Resources.menuIcon
        Me.rBtnMenu.Location = New System.Drawing.Point(12, 2154)
        Me.rBtnMenu.Name = "rBtnMenu"
        Me.rBtnMenu.Size = New System.Drawing.Size(59, 54)
        Me.rBtnMenu.TabIndex = 14
        Me.rBtnMenu.UseVisualStyleBackColor = True
        '
        'rBtnOrder
        '
        Me.rBtnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnOrder.FlatAppearance.BorderSize = 0
        Me.rBtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnOrder.Image = Global.FoodOrderingSystem.My.Resources.Resources.orderIcon
        Me.rBtnOrder.Location = New System.Drawing.Point(12, 2295)
        Me.rBtnOrder.Name = "rBtnOrder"
        Me.rBtnOrder.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.rBtnOrder.Size = New System.Drawing.Size(59, 54)
        Me.rBtnOrder.TabIndex = 13
        Me.rBtnOrder.UseVisualStyleBackColor = False
        '
        'frmMenuBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1375, 709)
        Me.Controls.Add(Me.txtBtnProfile)
        Me.Controls.Add(Me.txtBtnHome)
        Me.Controls.Add(Me.txtBtnMenu)
        Me.Controls.Add(Me.txtBtnOrder)
        Me.Controls.Add(Me.rBtnProfile)
        Me.Controls.Add(Me.rBtnMenu)
        Me.Controls.Add(Me.rBtnOrder)
        Me.Controls.Add(Me.rBtnHome)
        Me.Controls.Add(Me.lblSidePanel)
        Me.Name = "frmMenuBar"
        Me.Text = "frmMenuBar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rBtnMenu As RoundButton
    Friend WithEvents rBtnOrder As RoundButton
    Friend WithEvents rBtnHome As RoundButton
    Friend WithEvents lblSidePanel As Label
    Friend WithEvents rBtnProfile As RoundButton
    Friend WithEvents txtBtnOrder As TextBox
    Friend WithEvents txtBtnMenu As TextBox
    Friend WithEvents txtBtnHome As TextBox
    Friend WithEvents txtBtnProfile As TextBox
    Friend WithEvents ToolTipHome As ToolTip
End Class
