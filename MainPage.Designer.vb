<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.btnMember = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblMenuDesc = New System.Windows.Forms.Label()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMember
        '
        Me.btnMember.BackColor = System.Drawing.Color.White
        Me.btnMember.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.member_card
        Me.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMember.Location = New System.Drawing.Point(694, 569)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(302, 267)
        Me.btnMember.TabIndex = 0
        Me.btnMember.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FoodOrderingSystem.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(949, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Mistral", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(861, 331)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(371, 52)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "MINIMOO RESTAURANT"
        '
        'lblMenuDesc
        '
        Me.lblMenuDesc.AutoSize = True
        Me.lblMenuDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblMenuDesc.Font = New System.Drawing.Font("MV Boli", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuDesc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMenuDesc.Location = New System.Drawing.Point(689, 438)
        Me.lblMenuDesc.Name = "lblMenuDesc"
        Me.lblMenuDesc.Size = New System.Drawing.Size(248, 31)
        Me.lblMenuDesc.TabIndex = 30
        Me.lblMenuDesc.Text = "Select User Type :"
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.White
        Me.btnStaff.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.settings
        Me.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStaff.Location = New System.Drawing.Point(1077, 569)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(302, 267)
        Me.btnStaff.TabIndex = 31
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(799, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 40)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "USER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(1155, 523)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 40)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "ADMIN"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1905, 1055)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.lblMenuDesc)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMember)
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMember As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblMenuDesc As Label
    Friend WithEvents btnStaff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
