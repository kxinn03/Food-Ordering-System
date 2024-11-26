<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager_HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager_HomePage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picLogOut = New System.Windows.Forms.PictureBox()
        Me.btnUpdateStaff = New System.Windows.Forms.Button()
        Me.btnStaffReport = New System.Windows.Forms.Button()
        Me.btnViewStaff = New System.Windows.Forms.Button()
        Me.lblSidePanel = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.picLogOut)
        Me.Panel1.Controls.Add(Me.btnUpdateStaff)
        Me.Panel1.Controls.Add(Me.btnStaffReport)
        Me.Panel1.Controls.Add(Me.btnViewStaff)
        Me.Panel1.Controls.Add(Me.lblSidePanel)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Location = New System.Drawing.Point(117, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1581, 780)
        Me.Panel1.TabIndex = 4
        '
        'picLogOut
        '
        Me.picLogOut.Image = Global.FoodOrderingSystem.My.Resources.Resources.logout
        Me.picLogOut.Location = New System.Drawing.Point(25, 27)
        Me.picLogOut.Name = "picLogOut"
        Me.picLogOut.Size = New System.Drawing.Size(140, 128)
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
        Me.btnUpdateStaff.Location = New System.Drawing.Point(3, 326)
        Me.btnUpdateStaff.Name = "btnUpdateStaff"
        Me.btnUpdateStaff.Size = New System.Drawing.Size(186, 72)
        Me.btnUpdateStaff.TabIndex = 35
        Me.btnUpdateStaff.Text = "Update Staff"
        Me.btnUpdateStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateStaff.UseVisualStyleBackColor = False
        '
        'btnStaffReport
        '
        Me.btnStaffReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnStaffReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffReport.ForeColor = System.Drawing.Color.White
        Me.btnStaffReport.Image = Global.FoodOrderingSystem.My.Resources.Resources.newspaper
        Me.btnStaffReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStaffReport.Location = New System.Drawing.Point(0, 434)
        Me.btnStaffReport.Name = "btnStaffReport"
        Me.btnStaffReport.Size = New System.Drawing.Size(186, 78)
        Me.btnStaffReport.TabIndex = 34
        Me.btnStaffReport.Text = "Staff Report"
        Me.btnStaffReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStaffReport.UseVisualStyleBackColor = False
        '
        'btnViewStaff
        '
        Me.btnViewStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewStaff.ForeColor = System.Drawing.Color.White
        Me.btnViewStaff.Image = CType(resources.GetObject("btnViewStaff.Image"), System.Drawing.Image)
        Me.btnViewStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewStaff.Location = New System.Drawing.Point(3, 228)
        Me.btnViewStaff.Name = "btnViewStaff"
        Me.btnViewStaff.Size = New System.Drawing.Size(183, 62)
        Me.btnViewStaff.TabIndex = 33
        Me.btnViewStaff.Text = "View Staff"
        Me.btnViewStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewStaff.UseVisualStyleBackColor = False
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
        Me.Label21.Text = "Manager HomePage"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Manager_HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1815, 1043)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Manager_HomePage"
        Me.Text = "Manager_HomePage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents lblSidePanel As Label
    Friend WithEvents btnViewStaff As Button
    Friend WithEvents btnStaffReport As Button
    Friend WithEvents btnUpdateStaff As Button
    Friend WithEvents picLogOut As PictureBox
End Class
