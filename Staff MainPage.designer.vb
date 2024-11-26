<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_MainPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnManageRedeem = New System.Windows.Forms.Button()
        Me.btnManageMember = New System.Windows.Forms.Button()
        Me.picLogOut = New System.Windows.Forms.PictureBox()
        Me.btnUpdateStaff = New System.Windows.Forms.Button()
        Me.btnViewProfile = New System.Windows.Forms.Button()
        Me.lblSidePanel = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnManageRedeem)
        Me.Panel1.Controls.Add(Me.btnManageMember)
        Me.Panel1.Controls.Add(Me.picLogOut)
        Me.Panel1.Controls.Add(Me.btnUpdateStaff)
        Me.Panel1.Controls.Add(Me.btnViewProfile)
        Me.Panel1.Controls.Add(Me.lblSidePanel)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Location = New System.Drawing.Point(117, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1581, 780)
        Me.Panel1.TabIndex = 5
        '
        'btnManageRedeem
        '
        Me.btnManageRedeem.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnManageRedeem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnManageRedeem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageRedeem.ForeColor = System.Drawing.Color.White
        Me.btnManageRedeem.Image = Global.FoodOrderingSystem.My.Resources.Resources.supply_chain
        Me.btnManageRedeem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnManageRedeem.Location = New System.Drawing.Point(0, 419)
        Me.btnManageRedeem.Name = "btnManageRedeem"
        Me.btnManageRedeem.Size = New System.Drawing.Size(186, 107)
        Me.btnManageRedeem.TabIndex = 38
        Me.btnManageRedeem.Text = "Manage Redeem Product"
        Me.btnManageRedeem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageRedeem.UseVisualStyleBackColor = False
        '
        'btnManageMember
        '
        Me.btnManageMember.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnManageMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManageMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnManageMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageMember.ForeColor = System.Drawing.Color.White
        Me.btnManageMember.Image = Global.FoodOrderingSystem.My.Resources.Resources.team
        Me.btnManageMember.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnManageMember.Location = New System.Drawing.Point(0, 308)
        Me.btnManageMember.Name = "btnManageMember"
        Me.btnManageMember.Size = New System.Drawing.Size(186, 89)
        Me.btnManageMember.TabIndex = 37
        Me.btnManageMember.Text = "Manage Member"
        Me.btnManageMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManageMember.UseVisualStyleBackColor = False
        '
        'picLogOut
        '
        Me.picLogOut.Image = Global.FoodOrderingSystem.My.Resources.Resources.logout
        Me.picLogOut.Location = New System.Drawing.Point(51, 21)
        Me.picLogOut.Name = "picLogOut"
        Me.picLogOut.Size = New System.Drawing.Size(88, 74)
        Me.picLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogOut.TabIndex = 36
        Me.picLogOut.TabStop = False
        '
        'btnUpdateStaff
        '
        Me.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateStaff.ForeColor = System.Drawing.Color.White
        Me.btnUpdateStaff.Image = Global.FoodOrderingSystem.My.Resources.Resources.arrow_circle_up
        Me.btnUpdateStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateStaff.Location = New System.Drawing.Point(0, 210)
        Me.btnUpdateStaff.Name = "btnUpdateStaff"
        Me.btnUpdateStaff.Size = New System.Drawing.Size(186, 72)
        Me.btnUpdateStaff.TabIndex = 35
        Me.btnUpdateStaff.Text = "Update Profile"
        Me.btnUpdateStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateStaff.UseVisualStyleBackColor = False
        '
        'btnViewProfile
        '
        Me.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewProfile.ForeColor = System.Drawing.Color.White
        Me.btnViewProfile.Image = CType(resources.GetObject("btnViewProfile.Image"), System.Drawing.Image)
        Me.btnViewProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewProfile.Location = New System.Drawing.Point(3, 127)
        Me.btnViewProfile.Name = "btnViewProfile"
        Me.btnViewProfile.Size = New System.Drawing.Size(183, 62)
        Me.btnViewProfile.TabIndex = 33
        Me.btnViewProfile.Text = "View Profile"
        Me.btnViewProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewProfile.UseVisualStyleBackColor = False
        '
        'lblSidePanel
        '
        Me.lblSidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSidePanel.ForeColor = System.Drawing.Color.White
        Me.lblSidePanel.Location = New System.Drawing.Point(0, 0)
        Me.lblSidePanel.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lblSidePanel.Name = "lblSidePanel"
        Me.lblSidePanel.Size = New System.Drawing.Size(186, 780)
        Me.lblSidePanel.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.LightSalmon
        Me.Label21.Font = New System.Drawing.Font("Baskerville Old Face", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label21.Location = New System.Drawing.Point(0, 2)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(1581, 62)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Staff MainPage"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.FoodOrderingSystem.My.Resources.Resources.team
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(0, 544)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 89)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Manage Member"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(0, 659)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(186, 89)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Manage Member"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Staff_MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1815, 1043)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Staff_MainPage"
        Me.Text = "Staff_MainPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents picLogOut As PictureBox
    Friend WithEvents btnUpdateStaff As Button
    Friend WithEvents btnViewProfile As Button
    Friend WithEvents lblSidePanel As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnManageMember As Button
    Friend WithEvents btnManageRedeem As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
