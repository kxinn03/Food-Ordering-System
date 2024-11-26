<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Register))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUploadImage = New System.Windows.Forms.Button()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkShowPassword1 = New System.Windows.Forms.CheckBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDailyRate = New System.Windows.Forms.Label()
        Me.cboPayMethod = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboJobType = New System.Windows.Forms.ComboBox()
        Me.cboJobTitle = New System.Windows.Forms.ComboBox()
        Me.dtpDateHired = New System.Windows.Forms.DateTimePicker()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskPhoneNumEmergency = New System.Windows.Forms.MaskedTextBox()
        Me.mskPhoneNum = New System.Windows.Forms.MaskedTextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPlaceOfBirth = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.MaskedTextBox()
        Me.txtICNum = New System.Windows.Forms.MaskedTextBox()
        Me.dptBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StaffTableAdapter = New FoodOrderingSystem.DBDataSetTableAdapters.StaffTableAdapter()
        Me.StaffDataSet = New FoodOrderingSystem.DBDataSet()
        Me.TableAdapterManager = New FoodOrderingSystem.DBDataSetTableAdapters.TableAdapterManager()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnUploadImage)
        Me.Panel1.Controls.Add(Me.picStaff)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(120, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1581, 861)
        Me.Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Coral
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1323, 814)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(197, 42)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FoodOrderingSystem.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Coral
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1323, 766)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(197, 42)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.LightSalmon
        Me.Label21.Font = New System.Drawing.Font("Baskerville Old Face", 32.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label21.Location = New System.Drawing.Point(81, 4)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(406, 62)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Staff Registration"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.DarkOrange
        Me.Label20.Location = New System.Drawing.Point(23, 440)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(1540, 3)
        Me.Label20.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DarkOrange
        Me.Label16.Location = New System.Drawing.Point(25, 658)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1540, 3)
        Me.Label16.TabIndex = 20
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(1323, 721)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(197, 39)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Coral
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(1323, 664)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(197, 42)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUploadImage
        '
        Me.btnUploadImage.BackColor = System.Drawing.Color.Coral
        Me.btnUploadImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadImage.ForeColor = System.Drawing.Color.White
        Me.btnUploadImage.Location = New System.Drawing.Point(1323, 357)
        Me.btnUploadImage.Name = "btnUploadImage"
        Me.btnUploadImage.Size = New System.Drawing.Size(213, 46)
        Me.btnUploadImage.TabIndex = 0
        Me.btnUploadImage.Text = "Upload Image"
        Me.btnUploadImage.UseVisualStyleBackColor = False
        '
        'picStaff
        '
        Me.picStaff.Image = Global.FoodOrderingSystem.My.Resources.Resources.add
        Me.picStaff.Location = New System.Drawing.Point(1323, 124)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(213, 214)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 23
        Me.picStaff.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkShowPassword1)
        Me.GroupBox3.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox3.Controls.Add(Me.txtPassword)
        Me.GroupBox3.Controls.Add(Me.lblStaffID)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox3.Location = New System.Drawing.Point(24, 662)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(831, 183)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Create Staff Account"
        '
        'chkShowPassword1
        '
        Me.chkShowPassword1.AutoSize = True
        Me.chkShowPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkShowPassword1.Location = New System.Drawing.Point(470, 144)
        Me.chkShowPassword1.Name = "chkShowPassword1"
        Me.chkShowPassword1.Size = New System.Drawing.Size(164, 24)
        Me.chkShowPassword1.TabIndex = 3
        Me.chkShowPassword1.Text = "Show Password"
        Me.chkShowPassword1.UseVisualStyleBackColor = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtConfirmPassword.Location = New System.Drawing.Point(238, 141)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(206, 30)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.Location = New System.Drawing.Point(238, 94)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(206, 30)
        Me.txtPassword.TabIndex = 1
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStaffID.ForeColor = System.Drawing.Color.Black
        Me.lblStaffID.Location = New System.Drawing.Point(238, 47)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(206, 26)
        Me.lblStaffID.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(111, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 25)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Staff ID :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(200, 25)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Confirm Password :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(89, 93)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 25)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Password :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDailyRate)
        Me.GroupBox2.Controls.Add(Me.cboPayMethod)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cboJobType)
        Me.GroupBox2.Controls.Add(Me.cboJobTitle)
        Me.GroupBox2.Controls.Add(Me.dtpDateHired)
        Me.GroupBox2.Controls.Add(Me.cboPosition)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox2.Location = New System.Drawing.Point(24, 477)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1428, 152)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Job Details "
        '
        'lblDailyRate
        '
        Me.lblDailyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDailyRate.ForeColor = System.Drawing.Color.Black
        Me.lblDailyRate.Location = New System.Drawing.Point(157, 118)
        Me.lblDailyRate.Name = "lblDailyRate"
        Me.lblDailyRate.Size = New System.Drawing.Size(238, 31)
        Me.lblDailyRate.TabIndex = 4
        '
        'cboPayMethod
        '
        Me.cboPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboPayMethod.FormattingEnabled = True
        Me.cboPayMethod.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.cboPayMethod.Location = New System.Drawing.Point(854, 119)
        Me.cboPayMethod.Name = "cboPayMethod"
        Me.cboPayMethod.Size = New System.Drawing.Size(206, 33)
        Me.cboPayMethod.TabIndex = 5
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(688, 125)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(140, 25)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Pay Method :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(19, 125)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(123, 25)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Daily Rate :"
        '
        'cboJobType
        '
        Me.cboJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJobType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboJobType.FormattingEnabled = True
        Me.cboJobType.Items.AddRange(New Object() {"Part-time", "Full-time"})
        Me.cboJobType.Location = New System.Drawing.Point(854, 76)
        Me.cboJobType.Name = "cboJobType"
        Me.cboJobType.Size = New System.Drawing.Size(206, 33)
        Me.cboJobType.TabIndex = 3
        '
        'cboJobTitle
        '
        Me.cboJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboJobTitle.FormattingEnabled = True
        Me.cboJobTitle.Items.AddRange(New Object() {"Staff ", "Manager"})
        Me.cboJobTitle.Location = New System.Drawing.Point(854, 32)
        Me.cboJobTitle.Name = "cboJobTitle"
        Me.cboJobTitle.Size = New System.Drawing.Size(206, 33)
        Me.cboJobTitle.TabIndex = 1
        '
        'dtpDateHired
        '
        Me.dtpDateHired.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dtpDateHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateHired.Location = New System.Drawing.Point(157, 78)
        Me.dtpDateHired.Name = "dtpDateHired"
        Me.dtpDateHired.Size = New System.Drawing.Size(177, 30)
        Me.dtpDateHired.TabIndex = 2
        Me.dtpDateHired.Value = New Date(2023, 12, 26, 0, 0, 0, 0)
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Kitchen Staff/Cook", "Front Counter/Cashier", "Drive-Thru Attendant", "Dining Area Server", "Management/Supervisory Roles", "Food Preparation/Assembly Line Worker", "Cleaning and Maintenance Crew", "Delivery Driver"})
        Me.cboPosition.Location = New System.Drawing.Point(157, 37)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(516, 33)
        Me.cboPosition.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(40, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 25)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Position :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(712, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 25)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Job Type :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(719, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 25)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Job Title :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(15, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 25)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Date Hired :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mskPhoneNumEmergency)
        Me.GroupBox1.Controls.Add(Me.mskPhoneNum)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtPlaceOfBirth)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtICNum)
        Me.GroupBox1.Controls.Add(Me.dptBirthday)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtPostalCode)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Location = New System.Drawing.Point(24, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1290, 356)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personnel Details "
        '
        'mskPhoneNumEmergency
        '
        Me.mskPhoneNumEmergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mskPhoneNumEmergency.Location = New System.Drawing.Point(1059, 287)
        Me.mskPhoneNumEmergency.Mask = "(999) 000-0000"
        Me.mskPhoneNumEmergency.Name = "mskPhoneNumEmergency"
        Me.mskPhoneNumEmergency.Size = New System.Drawing.Size(196, 30)
        Me.mskPhoneNumEmergency.TabIndex = 14
        '
        'mskPhoneNum
        '
        Me.mskPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.mskPhoneNum.Location = New System.Drawing.Point(1061, 196)
        Me.mskPhoneNum.Mask = "(999) 000-0000"
        Me.mskPhoneNum.Name = "mskPhoneNum"
        Me.mskPhoneNum.Size = New System.Drawing.Size(196, 30)
        Me.mskPhoneNum.TabIndex = 9
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(1061, 147)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 33)
        Me.cboGender.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(655, 292)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(370, 25)
        Me.Label25.TabIndex = 43
        Me.Label25.Text = "Phone Number [case of emergency] :"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cboStatus.Location = New System.Drawing.Point(1060, 242)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 33)
        Me.cboStatus.TabIndex = 12
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(963, 250)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 25)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "Status :"
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(578, 198)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(293, 30)
        Me.txtPlaceOfBirth.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(404, 201)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(158, 25)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Place Of Birth :"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtMiddleName.Location = New System.Drawing.Point(578, 62)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(197, 30)
        Me.txtMiddleName.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(413, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(151, 25)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Middle Name :"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLastName.Location = New System.Drawing.Point(1059, 62)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(197, 30)
        Me.txtLastName.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(916, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 25)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Last Name :"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAge.Location = New System.Drawing.Point(578, 243)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(32, 30)
        Me.txtAge.TabIndex = 11
        '
        'txtICNum
        '
        Me.txtICNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtICNum.Location = New System.Drawing.Point(151, 245)
        Me.txtICNum.Name = "txtICNum"
        Me.txtICNum.Size = New System.Drawing.Size(293, 30)
        Me.txtICNum.TabIndex = 10
        '
        'dptBirthday
        '
        Me.dptBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dptBirthday.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptBirthday.Location = New System.Drawing.Point(151, 199)
        Me.dptBirthday.Name = "dptBirthday"
        Me.dptBirthday.Size = New System.Drawing.Size(177, 30)
        Me.dptBirthday.TabIndex = 7
        Me.dptBirthday.Value = New Date(2023, 12, 26, 0, 0, 0, 0)
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtFirstName.Location = New System.Drawing.Point(151, 64)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(197, 30)
        Me.txtFirstName.TabIndex = 0
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCity.Location = New System.Drawing.Point(578, 150)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(166, 30)
        Me.txtCity.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(501, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "City :"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.Location = New System.Drawing.Point(151, 105)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(1019, 30)
        Me.txtAddress.TabIndex = 3
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPostalCode.Location = New System.Drawing.Point(151, 153)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(197, 30)
        Me.txtPostalCode.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.Location = New System.Drawing.Point(151, 289)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(293, 30)
        Me.txtEmail.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(954, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gender :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(64, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 25)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Email :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 25)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Postal Code :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(39, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Birthday :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(38, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 25)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Address :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(880, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Phone Number :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(500, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Age :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "IC Number :"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffDataSet
        '
        Me.StaffDataSet.DataSetName = "StaffDataSet"
        Me.StaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = FoodOrderingSystem.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.StaffDataSet
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "OpenFileDialog1"
        '
        'Staff_Register
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(1815, 1043)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Staff_Register"
        Me.Text = "Staff_Register"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents dtpDateHired As DateTimePicker
    Friend WithEvents cboJobType As ComboBox
    Friend WithEvents cboJobTitle As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPostalCode As MaskedTextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtICNum As MaskedTextBox
    Friend WithEvents dptBirthday As DateTimePicker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents picStaff As PictureBox
    Friend WithEvents txtAge As MaskedTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPlaceOfBirth As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cboPayMethod As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents chkShowPassword1 As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents StaffTableAdapter As DBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffDataSet As DBDataSet
    Friend WithEvents TableAdapterManager As DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents mskPhoneNum As MaskedTextBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents mskPhoneNumEmergency As MaskedTextBox
    Friend WithEvents lblDailyRate As Label
    Friend WithEvents ofdImage As OpenFileDialog
End Class
