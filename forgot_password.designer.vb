<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot_password
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVerify = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.btnSendCode = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.Location = New System.Drawing.Point(222, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(458, 564)
        Me.Label10.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 32)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Forgot Password"
        '
        'txtVerify
        '
        Me.txtVerify.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerify.Location = New System.Drawing.Point(271, 444)
        Me.txtVerify.Name = "txtVerify"
        Me.txtVerify.Size = New System.Drawing.Size(361, 27)
        Me.txtVerify.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(266, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Verification Code"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(270, 301)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(361, 27)
        Me.txtEmail.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(267, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Email"
        '
        'btnVerify
        '
        Me.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVerify.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerify.ForeColor = System.Drawing.Color.White
        Me.btnVerify.Location = New System.Drawing.Point(450, 492)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(182, 36)
        Me.btnVerify.TabIndex = 29
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = False
        '
        'lblBack
        '
        Me.lblBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(233, 130)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(55, 18)
        Me.lblBack.TabIndex = 30
        Me.lblBack.Text = "< Back"
        '
        'btnSendCode
        '
        Me.btnSendCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSendCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendCode.ForeColor = System.Drawing.Color.White
        Me.btnSendCode.Location = New System.Drawing.Point(450, 343)
        Me.btnSendCode.Name = "btnSendCode"
        Me.btnSendCode.Size = New System.Drawing.Size(182, 36)
        Me.btnSendCode.TabIndex = 31
        Me.btnSendCode.Text = "Send Code"
        Me.btnSendCode.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.FoodOrderingSystem.My.Resources.Resources.appetizing_spaghetti_italian_pasta_with_tomato_sauce
        Me.PictureBox2.Location = New System.Drawing.Point(677, 110)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(434, 564)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
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
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'forgot_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 736)
        Me.Controls.Add(Me.btnSendCode)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.txtVerify)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "forgot_password"
        Me.Text = "forgot_password"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVerify As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVerify As Button
    Friend WithEvents lblBack As Label
    Friend WithEvents btnSendCode As Button
End Class
