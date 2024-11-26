<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_Password_Reset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Password_Reset))
        Me.lblStaffForgotPassword = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChkShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtVerifyPassword = New System.Windows.Forms.TextBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStaffForgotPassword
        '
        Me.lblStaffForgotPassword.BackColor = System.Drawing.Color.DarkOrange
        Me.lblStaffForgotPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStaffForgotPassword.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffForgotPassword.ForeColor = System.Drawing.Color.White
        Me.lblStaffForgotPassword.Location = New System.Drawing.Point(0, 0)
        Me.lblStaffForgotPassword.Name = "lblStaffForgotPassword"
        Me.lblStaffForgotPassword.Size = New System.Drawing.Size(381, 48)
        Me.lblStaffForgotPassword.TabIndex = 0
        Me.lblStaffForgotPassword.Text = "PASSWORD RESET"
        Me.lblStaffForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ChkShowPassword)
        Me.Panel2.Controls.Add(Me.txtVerifyPassword)
        Me.Panel2.Controls.Add(Me.txtNewPassword)
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.lblStaffForgotPassword)
        Me.Panel2.Location = New System.Drawing.Point(600, 200)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(810, 610)
        Me.Panel2.TabIndex = 14
        '
        'ChkShowPassword
        '
        Me.ChkShowPassword.AutoSize = True
        Me.ChkShowPassword.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowPassword.Location = New System.Drawing.Point(216, 272)
        Me.ChkShowPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ChkShowPassword.Name = "ChkShowPassword"
        Me.ChkShowPassword.Size = New System.Drawing.Size(140, 24)
        Me.ChkShowPassword.TabIndex = 98
        Me.ChkShowPassword.Text = "Show Password"
        Me.ChkShowPassword.UseVisualStyleBackColor = True
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifyPassword.Location = New System.Drawing.Point(22, 272)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.Size = New System.Drawing.Size(139, 31)
        Me.txtVerifyPassword.TabIndex = 19
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(22, 130)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(289, 31)
        Me.txtNewPassword.TabIndex = 18
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnReset.Location = New System.Drawing.Point(225, 321)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(86, 37)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Verify Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(19, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "New Password :"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.FoodOrderingSystem.My.Resources.Resources.pic3
        Me.PictureBox4.Location = New System.Drawing.Point(379, -4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(429, 613)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Staff_Password_Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1666, 1043)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Staff_Password_Reset"
        Me.Text = "Staff_Password_Reset"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblStaffForgotPassword As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtVerifyPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ChkShowPassword As CheckBox
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
