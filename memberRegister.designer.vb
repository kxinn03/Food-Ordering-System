<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class memberRegister
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLoginNow = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mskPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblError2 = New System.Windows.Forms.Label()
        Me.lblError3 = New System.Windows.Forms.Label()
        Me.chkShow2 = New System.Windows.Forms.CheckBox()
        Me.chkShow1 = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Register As Member"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(267, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(267, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(267, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(266, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(266, 525)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Phone Number"
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(393, 593)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(106, 36)
        Me.btnRegister.TabIndex = 16
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(323, 632)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Already have an account?"
        '
        'lblLoginNow
        '
        Me.lblLoginNow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLoginNow.AutoSize = True
        Me.lblLoginNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginNow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblLoginNow.Location = New System.Drawing.Point(502, 632)
        Me.lblLoginNow.Name = "lblLoginNow"
        Me.lblLoginNow.Size = New System.Drawing.Size(79, 18)
        Me.lblLoginNow.TabIndex = 17
        Me.lblLoginNow.Text = "Login Now"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(267, 385)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Confirm Password"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Location = New System.Drawing.Point(222, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(458, 564)
        Me.Label10.TabIndex = 20
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(270, 229)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(361, 27)
        Me.txtName.TabIndex = 6
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(270, 408)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(361, 27)
        Me.txtConfirmPassword.TabIndex = 12
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(270, 345)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(361, 27)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(270, 286)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(361, 27)
        Me.txtUsername.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(271, 478)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(361, 27)
        Me.txtEmail.TabIndex = 14
        '
        'mskPhoneNo
        '
        Me.mskPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mskPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskPhoneNo.Location = New System.Drawing.Point(270, 548)
        Me.mskPhoneNo.Mask = "(000) 000-00009"
        Me.mskPhoneNo.Name = "mskPhoneNo"
        Me.mskPhoneNo.Size = New System.Drawing.Size(361, 27)
        Me.mskPhoneNo.TabIndex = 15
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.FoodOrderingSystem.My.Resources.Resources.meat_burger_bread_bun_cut_into_two_pieces
        Me.PictureBox2.Location = New System.Drawing.Point(677, 110)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(434, 564)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.FoodOrderingSystem.My.Resources.Resources._463
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1276, 736)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblError
        '
        Me.lblError.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(268, 438)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(177, 17)
        Me.lblError.TabIndex = 22
        Me.lblError.Text = "Passwords does not match"
        Me.lblError.Visible = False
        '
        'lblError2
        '
        Me.lblError2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblError2.AutoSize = True
        Me.lblError2.ForeColor = System.Drawing.Color.Red
        Me.lblError2.Location = New System.Drawing.Point(268, 508)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(154, 17)
        Me.lblError2.TabIndex = 23
        Me.lblError2.Text = "Email must contain ""@"""
        Me.lblError2.Visible = False
        '
        'lblError3
        '
        Me.lblError3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblError3.AutoSize = True
        Me.lblError3.ForeColor = System.Drawing.Color.Red
        Me.lblError3.Location = New System.Drawing.Point(267, 577)
        Me.lblError3.Name = "lblError3"
        Me.lblError3.Size = New System.Drawing.Size(188, 17)
        Me.lblError3.TabIndex = 24
        Me.lblError3.Text = "Invalid phone number format"
        Me.lblError3.Visible = False
        '
        'chkShow2
        '
        Me.chkShow2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkShow2.AutoSize = True
        Me.chkShow2.Location = New System.Drawing.Point(505, 441)
        Me.chkShow2.Name = "chkShow2"
        Me.chkShow2.Size = New System.Drawing.Size(129, 21)
        Me.chkShow2.TabIndex = 25
        Me.chkShow2.Text = "&Show Password"
        Me.chkShow2.UseVisualStyleBackColor = True
        '
        'chkShow1
        '
        Me.chkShow1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkShow1.AutoSize = True
        Me.chkShow1.Location = New System.Drawing.Point(505, 378)
        Me.chkShow1.Name = "chkShow1"
        Me.chkShow1.Size = New System.Drawing.Size(129, 21)
        Me.chkShow1.TabIndex = 26
        Me.chkShow1.Text = "&Show Password"
        Me.chkShow1.UseVisualStyleBackColor = True
        '
        'memberRegister
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 736)
        Me.Controls.Add(Me.chkShow1)
        Me.Controls.Add(Me.chkShow2)
        Me.Controls.Add(Me.lblError3)
        Me.Controls.Add(Me.lblError2)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.mskPhoneNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLoginNow)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "memberRegister"
        Me.Text = "memberRegister"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblLoginNow As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mskPhoneNo As MaskedTextBox
    Friend WithEvents lblError As Label
    Friend WithEvents lblError2 As Label
    Friend WithEvents lblError3 As Label
    Friend WithEvents chkShow2 As CheckBox
    Friend WithEvents chkShow1 As CheckBox
End Class
