<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Forgot_Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Forgot_Password))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblStaffForgotPassword = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnReturn)
        Me.Panel2.Controls.Add(Me.txtCode)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.btnVerify)
        Me.Panel2.Controls.Add(Me.btnSend)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.lblStaffForgotPassword)
        Me.Panel2.Location = New System.Drawing.Point(600, 200)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(810, 610)
        Me.Panel2.TabIndex = 13
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnReturn.Location = New System.Drawing.Point(220, 366)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(106, 33)
        Me.btnReturn.TabIndex = 20
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(22, 272)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(139, 31)
        Me.txtCode.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(22, 130)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(289, 31)
        Me.txtEmail.TabIndex = 18
        '
        'btnVerify
        '
        Me.btnVerify.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnVerify.Location = New System.Drawing.Point(227, 312)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(99, 33)
        Me.btnVerify.TabIndex = 17
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnSend.Location = New System.Drawing.Point(236, 179)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 35)
        Me.btnSend.TabIndex = 16
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Enter Code :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(19, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Enter Email :"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.FoodOrderingSystem.My.Resources.Resources.pic2
        Me.PictureBox4.Location = New System.Drawing.Point(379, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(429, 608)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
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
        Me.lblStaffForgotPassword.Text = "FORGOT PASSWORD"
        Me.lblStaffForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Staff_Forgot_Password
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1666, 1043)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Staff_Forgot_Password"
        Me.Text = "Staff_Forgot_Password"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblStaffForgotPassword As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnVerify As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturn As Button
End Class
