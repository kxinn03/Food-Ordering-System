<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_profile))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblSidePanel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rBtnProfile = New FoodOrderingSystem.RoundButton()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.rBtnMenu = New FoodOrderingSystem.RoundButton()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoundButton1 = New FoodOrderingSystem.RoundButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rBtnLogout = New FoodOrderingSystem.RoundButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rBtnRedeem = New FoodOrderingSystem.RoundButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rBtnPoints = New FoodOrderingSystem.RoundButton()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(431, 547)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Phone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(431, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 20)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Email"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(431, 387)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 20)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Username"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(432, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 20)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Name"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(568, 901)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(148, 50)
        Me.btnSave.TabIndex = 99
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(388, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(820, 767)
        Me.Label7.TabIndex = 98
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(195, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 981)
        Me.Label11.TabIndex = 93
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(436, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 3)
        Me.Label12.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(428, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 40)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Edit Profile"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(388, 901)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(148, 50)
        Me.btnCancel.TabIndex = 110
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(434, 342)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(360, 30)
        Me.txtName.TabIndex = 111
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(434, 416)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(360, 30)
        Me.txtUsername.TabIndex = 112
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(434, 496)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(360, 30)
        Me.txtEmail.TabIndex = 113
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(434, 576)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(360, 30)
        Me.txtPhoneNumber.TabIndex = 114
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.BackColor = System.Drawing.SystemColors.Control
        Me.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPhoto.Image = Global.FoodOrderingSystem.My.Resources.Resources.upload_big_arrow__1_
        Me.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadPhoto.Location = New System.Drawing.Point(597, 240)
        Me.btnUploadPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(96, 29)
        Me.btnUploadPhoto.TabIndex = 124
        Me.btnUploadPhoto.Text = "Upload"
        Me.btnUploadPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUploadPhoto.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.Image = Global.FoodOrderingSystem.My.Resources.Resources.user__1_
        Me.picProfile.Location = New System.Drawing.Point(439, 125)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(151, 144)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 123
        Me.picProfile.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(823, 387)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 20)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Birth Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(823, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 20)
        Me.Label10.TabIndex = 127
        Me.Label10.Text = "Gender"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(827, 342)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(360, 33)
        Me.cboGender.TabIndex = 131
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(827, 415)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 30)
        Me.DateTimePicker1.TabIndex = 132
        Me.DateTimePicker1.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        '
        'lblSidePanel
        '
        Me.lblSidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSidePanel.ForeColor = System.Drawing.Color.White
        Me.lblSidePanel.Location = New System.Drawing.Point(0, 0)
        Me.lblSidePanel.Name = "lblSidePanel"
        Me.lblSidePanel.Size = New System.Drawing.Size(196, 977)
        Me.lblSidePanel.TabIndex = 133
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 134
        Me.PictureBox1.TabStop = False
        '
        'rBtnProfile
        '
        Me.rBtnProfile.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.profileIcon
        Me.rBtnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rBtnProfile.Image = Global.FoodOrderingSystem.My.Resources.Resources.profileIcon
        Me.rBtnProfile.Location = New System.Drawing.Point(56, 170)
        Me.rBtnProfile.Name = "rBtnProfile"
        Me.rBtnProfile.Size = New System.Drawing.Size(67, 62)
        Me.rBtnProfile.TabIndex = 135
        Me.rBtnProfile.UseVisualStyleBackColor = True
        '
        'lblProfile
        '
        Me.lblProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblProfile.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.Location = New System.Drawing.Point(40, 235)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(127, 34)
        Me.lblProfile.TabIndex = 136
        Me.lblProfile.Text = "Profile"
        '
        'rBtnMenu
        '
        Me.rBtnMenu.BackColor = System.Drawing.Color.White
        Me.rBtnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rBtnMenu.Image = Global.FoodOrderingSystem.My.Resources.Resources.menuIcon
        Me.rBtnMenu.Location = New System.Drawing.Point(56, 310)
        Me.rBtnMenu.Name = "rBtnMenu"
        Me.rBtnMenu.Size = New System.Drawing.Size(67, 62)
        Me.rBtnMenu.TabIndex = 137
        Me.rBtnMenu.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblMenu.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(50, 375)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(109, 34)
        Me.lblMenu.TabIndex = 138
        Me.lblMenu.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 789)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 34)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Feedback"
        '
        'RoundButton1
        '
        Me.RoundButton1.BackColor = System.Drawing.Color.White
        Me.RoundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RoundButton1.Image = Global.FoodOrderingSystem.My.Resources.Resources.feedback__1_
        Me.RoundButton1.Location = New System.Drawing.Point(56, 724)
        Me.RoundButton1.Name = "RoundButton1"
        Me.RoundButton1.Size = New System.Drawing.Size(67, 62)
        Me.RoundButton1.TabIndex = 151
        Me.RoundButton1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 934)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 34)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Logout"
        '
        'rBtnLogout
        '
        Me.rBtnLogout.BackColor = System.Drawing.Color.White
        Me.rBtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rBtnLogout.Image = Global.FoodOrderingSystem.My.Resources.Resources.logoutIcon
        Me.rBtnLogout.Location = New System.Drawing.Point(56, 869)
        Me.rBtnLogout.Name = "rBtnLogout"
        Me.rBtnLogout.Size = New System.Drawing.Size(67, 62)
        Me.rBtnLogout.TabIndex = 149
        Me.rBtnLogout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 646)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 34)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Redeem"
        '
        'rBtnRedeem
        '
        Me.rBtnRedeem.BackColor = System.Drawing.Color.White
        Me.rBtnRedeem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rBtnRedeem.Image = Global.FoodOrderingSystem.My.Resources.Resources.box__3_
        Me.rBtnRedeem.Location = New System.Drawing.Point(56, 581)
        Me.rBtnRedeem.Name = "rBtnRedeem"
        Me.rBtnRedeem.Size = New System.Drawing.Size(67, 62)
        Me.rBtnRedeem.TabIndex = 147
        Me.rBtnRedeem.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 510)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 34)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Points"
        '
        'rBtnPoints
        '
        Me.rBtnPoints.BackColor = System.Drawing.Color.White
        Me.rBtnPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rBtnPoints.Image = Global.FoodOrderingSystem.My.Resources.Resources.reward__1_
        Me.rBtnPoints.Location = New System.Drawing.Point(56, 445)
        Me.rBtnPoints.Name = "rBtnPoints"
        Me.rBtnPoints.Size = New System.Drawing.Size(67, 62)
        Me.rBtnPoints.TabIndex = 145
        Me.rBtnPoints.UseVisualStyleBackColor = False
        '
        'edit_profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1276, 977)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RoundButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rBtnLogout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rBtnRedeem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rBtnPoints)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.rBtnMenu)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.rBtnProfile)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSidePanel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnUploadPhoto)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Name = "edit_profile"
        Me.Text = "edit_profile"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblSidePanel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents rBtnProfile As RoundButton
    Friend WithEvents lblProfile As Label
    Friend WithEvents rBtnMenu As RoundButton
    Friend WithEvents lblMenu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RoundButton1 As RoundButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rBtnLogout As RoundButton
    Friend WithEvents Label3 As Label
    Friend WithEvents rBtnRedeem As RoundButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rBtnPoints As RoundButton
End Class
