<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_View
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.picStaff = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.lblJobStatus = New System.Windows.Forms.Label()
        Me.lblDateHired = New System.Windows.Forms.Label()
        Me.lblJobType = New System.Windows.Forms.Label()
        Me.lblDailyRate = New System.Windows.Forms.Label()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAdress = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblCIty = New System.Windows.Forms.Label()
        Me.lblPlaceOfBirth = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblPhoneNum = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblPhoneNumEmergency = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblICNum = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.TableAdapterManager = New FoodOrderingSystem.DBDataSetTableAdapters.TableAdapterManager()
        Me.StaffDataSet = New FoodOrderingSystem.DBDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.lblStaffID)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.picBack)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.picStaff)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(117, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1581, 780)
        Me.Panel1.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Coral
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1325, 692)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(211, 42)
        Me.btnExit.TabIndex = 126
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStaffID.Location = New System.Drawing.Point(1323, 186)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(213, 23)
        Me.lblStaffID.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(1320, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 25)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Staff ID :"
        '
        'picBack
        '
        Me.picBack.Image = Global.FoodOrderingSystem.My.Resources.Resources.back
        Me.picBack.Location = New System.Drawing.Point(7, 5)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(52, 46)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 30
        Me.picBack.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Coral
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(1325, 641)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(211, 42)
        Me.btnBack.TabIndex = 29
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
        Me.Label21.Size = New System.Drawing.Size(537, 62)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "View Staff Information"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.DarkOrange
        Me.Label20.Location = New System.Drawing.Point(23, 538)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(1540, 3)
        Me.Label20.TabIndex = 27
        '
        'picStaff
        '
        Me.picStaff.Image = Global.FoodOrderingSystem.My.Resources.Resources.add
        Me.picStaff.Location = New System.Drawing.Point(1323, 222)
        Me.picStaff.Name = "picStaff"
        Me.picStaff.Size = New System.Drawing.Size(213, 214)
        Me.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaff.TabIndex = 23
        Me.picStaff.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPosition)
        Me.GroupBox2.Controls.Add(Me.lblJobTitle)
        Me.GroupBox2.Controls.Add(Me.lblJobStatus)
        Me.GroupBox2.Controls.Add(Me.lblDateHired)
        Me.GroupBox2.Controls.Add(Me.lblJobType)
        Me.GroupBox2.Controls.Add(Me.lblDailyRate)
        Me.GroupBox2.Controls.Add(Me.lblPayMethod)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkOrange
        Me.GroupBox2.Location = New System.Drawing.Point(24, 575)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1269, 170)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Job Details "
        '
        'lblPosition
        '
        Me.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.Location = New System.Drawing.Point(160, 39)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(286, 27)
        Me.lblPosition.TabIndex = 18
        '
        'lblJobTitle
        '
        Me.lblJobTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJobTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblJobTitle.ForeColor = System.Drawing.Color.Black
        Me.lblJobTitle.Location = New System.Drawing.Point(685, 40)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(234, 27)
        Me.lblJobTitle.TabIndex = 19
        '
        'lblJobStatus
        '
        Me.lblJobStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJobStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblJobStatus.ForeColor = System.Drawing.Color.Black
        Me.lblJobStatus.Location = New System.Drawing.Point(1086, 35)
        Me.lblJobStatus.Name = "lblJobStatus"
        Me.lblJobStatus.Size = New System.Drawing.Size(177, 27)
        Me.lblJobStatus.TabIndex = 20
        '
        'lblDateHired
        '
        Me.lblDateHired.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateHired.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateHired.ForeColor = System.Drawing.Color.Black
        Me.lblDateHired.Location = New System.Drawing.Point(160, 79)
        Me.lblDateHired.Name = "lblDateHired"
        Me.lblDateHired.Size = New System.Drawing.Size(210, 27)
        Me.lblDateHired.TabIndex = 21
        '
        'lblJobType
        '
        Me.lblJobType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJobType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblJobType.ForeColor = System.Drawing.Color.Black
        Me.lblJobType.Location = New System.Drawing.Point(685, 81)
        Me.lblJobType.Name = "lblJobType"
        Me.lblJobType.Size = New System.Drawing.Size(234, 27)
        Me.lblJobType.TabIndex = 22
        '
        'lblDailyRate
        '
        Me.lblDailyRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDailyRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDailyRate.ForeColor = System.Drawing.Color.Black
        Me.lblDailyRate.Location = New System.Drawing.Point(160, 125)
        Me.lblDailyRate.Name = "lblDailyRate"
        Me.lblDailyRate.Size = New System.Drawing.Size(210, 27)
        Me.lblDailyRate.TabIndex = 23
        '
        'lblPayMethod
        '
        Me.lblPayMethod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPayMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPayMethod.ForeColor = System.Drawing.Color.Black
        Me.lblPayMethod.Location = New System.Drawing.Point(685, 123)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(234, 27)
        Me.lblPayMethod.TabIndex = 24
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(951, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(129, 25)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "Job Status :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(536, 125)
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
        Me.Label15.Location = New System.Drawing.Point(560, 81)
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
        Me.Label14.Location = New System.Drawing.Point(567, 39)
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
        Me.GroupBox1.Controls.Add(Me.lblAdress)
        Me.GroupBox1.Controls.Add(Me.lblPostalCode)
        Me.GroupBox1.Controls.Add(Me.lblBirthday)
        Me.GroupBox1.Controls.Add(Me.lblMiddleName)
        Me.GroupBox1.Controls.Add(Me.lblCIty)
        Me.GroupBox1.Controls.Add(Me.lblPlaceOfBirth)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblPhoneNum)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.lblPhoneNumEmergency)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblICNum)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
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
        Me.GroupBox1.Location = New System.Drawing.Point(24, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1290, 356)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personnel Details "
        '
        'lblAdress
        '
        Me.lblAdress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdress.ForeColor = System.Drawing.Color.Black
        Me.lblAdress.Location = New System.Drawing.Point(160, 108)
        Me.lblAdress.Name = "lblAdress"
        Me.lblAdress.Size = New System.Drawing.Size(1017, 27)
        Me.lblAdress.TabIndex = 3
        '
        'lblPostalCode
        '
        Me.lblPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPostalCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPostalCode.ForeColor = System.Drawing.Color.Black
        Me.lblPostalCode.Location = New System.Drawing.Point(160, 156)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(210, 27)
        Me.lblPostalCode.TabIndex = 4
        '
        'lblBirthday
        '
        Me.lblBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBirthday.ForeColor = System.Drawing.Color.Black
        Me.lblBirthday.Location = New System.Drawing.Point(160, 201)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(210, 27)
        Me.lblBirthday.TabIndex = 5
        '
        'lblMiddleName
        '
        Me.lblMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblMiddleName.ForeColor = System.Drawing.Color.Black
        Me.lblMiddleName.Location = New System.Drawing.Point(572, 63)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(210, 27)
        Me.lblMiddleName.TabIndex = 6
        '
        'lblCIty
        '
        Me.lblCIty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCIty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCIty.ForeColor = System.Drawing.Color.Black
        Me.lblCIty.Location = New System.Drawing.Point(572, 153)
        Me.lblCIty.Name = "lblCIty"
        Me.lblCIty.Size = New System.Drawing.Size(210, 27)
        Me.lblCIty.TabIndex = 7
        '
        'lblPlaceOfBirth
        '
        Me.lblPlaceOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlaceOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlaceOfBirth.ForeColor = System.Drawing.Color.Black
        Me.lblPlaceOfBirth.Location = New System.Drawing.Point(572, 199)
        Me.lblPlaceOfBirth.Name = "lblPlaceOfBirth"
        Me.lblPlaceOfBirth.Size = New System.Drawing.Size(210, 27)
        Me.lblPlaceOfBirth.TabIndex = 8
        '
        'lblFirstName
        '
        Me.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(160, 66)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(210, 27)
        Me.lblFirstName.TabIndex = 9
        '
        'lblLastName
        '
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(1053, 67)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(210, 27)
        Me.lblLastName.TabIndex = 10
        '
        'lblGender
        '
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(1053, 153)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(210, 27)
        Me.lblGender.TabIndex = 11
        '
        'lblPhoneNum
        '
        Me.lblPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhoneNum.ForeColor = System.Drawing.Color.Black
        Me.lblPhoneNum.Location = New System.Drawing.Point(1053, 199)
        Me.lblPhoneNum.Name = "lblPhoneNum"
        Me.lblPhoneNum.Size = New System.Drawing.Size(210, 27)
        Me.lblPhoneNum.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(1053, 248)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(210, 27)
        Me.lblStatus.TabIndex = 13
        '
        'lblPhoneNumEmergency
        '
        Me.lblPhoneNumEmergency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneNumEmergency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhoneNumEmergency.ForeColor = System.Drawing.Color.Black
        Me.lblPhoneNumEmergency.Location = New System.Drawing.Point(1053, 292)
        Me.lblPhoneNumEmergency.Name = "lblPhoneNumEmergency"
        Me.lblPhoneNumEmergency.Size = New System.Drawing.Size(210, 27)
        Me.lblPhoneNumEmergency.TabIndex = 14
        '
        'lblAge
        '
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(572, 250)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(91, 27)
        Me.lblAge.TabIndex = 15
        '
        'lblICNum
        '
        Me.lblICNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblICNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblICNum.ForeColor = System.Drawing.Color.Black
        Me.lblICNum.Location = New System.Drawing.Point(160, 248)
        Me.lblICNum.Name = "lblICNum"
        Me.lblICNum.Size = New System.Drawing.Size(210, 27)
        Me.lblICNum.TabIndex = 16
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(160, 289)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(210, 27)
        Me.lblEmail.TabIndex = 17
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = FoodOrderingSystem.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffDataSet
        '
        Me.StaffDataSet.DataSetName = "StaffDataSet"
        Me.StaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.StaffDataSet
        '
        'Staff_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(1815, 1043)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Staff_View"
        Me.Text = "Staff_View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblStaffID As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents picBack As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents picStaff As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPayMethod As Label
    Friend WithEvents lblAdress As Label
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblCIty As Label
    Friend WithEvents lblPlaceOfBirth As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblPhoneNumEmergency As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblICNum As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblJobTitle As Label
    Friend WithEvents lblJobStatus As Label
    Friend WithEvents lblDateHired As Label
    Friend WithEvents lblJobType As Label
    Friend WithEvents lblDailyRate As Label
    Friend WithEvents StaffTableAdapter As DBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffDataSet As DBDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents btnExit As Button
End Class
