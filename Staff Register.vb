Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Text

Public Class Staff_Register
    ' Declaration of variables, adapters, and dataset
    Private strCurrentStaffID As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Dim MySqlCommand As New SqlCommand

    ' Triggered when the Staff_Register form is loaded
    Private Sub Staff_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Data loading and initialization processes
        Me.StaffTableAdapter.Fill(Me.StaffDataSet.Staff)

        Dim strSql As String
        Dim staffTable As DBDataSet.StaffDataTable
        Dim strLastStaffID As String

        If OpenConnection() = True Then
            strSql = "Select * From Staff"
            da = New SqlDataAdapter(strSql, conn)
            ds.Clear()
            da.Fill(ds, "Staff")

            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If

        staffTable = StaffTableAdapter.GetData()

        If staffTable.Count <> 0 Then
            strLastStaffID = CStr(staffTable.Rows(staffTable.Count - 1).Item(0))
        Else
            strLastStaffID = "S0000"
        End If
        strCurrentStaffID = lblStaffID.Text
        lblStaffID.Text = "S" & (Integer.Parse(strLastStaffID.Substring(1)) + 1).ToString("D4")

    End Sub

    ' Function to clear all input fields
    Private Sub SetBlank()

        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAddress.Multiline = True
        txtAddress.AcceptsReturn = True
        txtPostalCode.Text = ""
        txtCity.Text = ""
        cboGender.SelectedIndex = -1
        dptBirthday.Text = ""
        txtPlaceOfBirth.Text = ""
        mskPhoneNum.Text = ""
        txtICNum.Text = ""
        txtAge.Text = ""
        cboStatus.SelectedIndex = -1
        txtEmail.Text = ""
        mskPhoneNumEmergency.Text = ""
        cboPosition.SelectedIndex = -1
        cboJobTitle.SelectedIndex = -1
        dtpDateHired.Text = ""
        cboJobType.SelectedIndex = -1
        lblDailyRate.Text = ""
        cboPayMethod.SelectedIndex = -1
        txtPassword.Text = ""
        txtConfirmPassword.Text = ""
        picStaff.Image = GetPerson()
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        ofdImage.InitialDirectory = "Pictures"
        ofdImage.Filter = "Only Picture With JPG/JPEG/PNG Extension|*.jpg;*.jpeg;*.png"

        If ofdImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            picStaff.Image = Image.FromFile(ofdImage.FileName)
        End If
    End Sub

    Private Shared Function GetPerson() As Bitmap
        Return FoodOrderingSystem.My.Resources.add
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        txtPassword.PasswordChar = "•"
    End Sub

    Private Sub txtConfirmPassword_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.GotFocus
        txtConfirmPassword.PasswordChar = "•"
    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged
        If txtPassword.Text <> "" And txtPassword.Text = txtConfirmPassword.Text Then
            err.SetError(txtConfirmPassword, "")
        Else err.SetError(txtConfirmPassword, "Password and Confirm password does not match")
        End If
    End Sub

    Private Sub chkShowPassword1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword1.CheckedChanged
        If chkShowPassword1.Checked = False Then
            txtPassword.PasswordChar = "*"
            txtConfirmPassword.PasswordChar = "*"
        Else
            txtPassword.PasswordChar = ""
            txtConfirmPassword.PasswordChar = ""
        End If
    End Sub

    Private Function IsPasswordValid(password As String) As Boolean
        ' Password should be at least 12 characters long (14 or more is recommended)
        If password.Length < 12 Then
            Return False
        End If

        ' Check for a combination of uppercase letters, lowercase letters, numbers, and symbols
        Dim hasUpperCase = password.Any(Function(c) Char.IsUpper(c))
        Dim hasLowerCase = password.Any(Function(c) Char.IsLower(c))
        Dim hasDigit = password.Any(Function(c) Char.IsDigit(c))
        Dim hasSymbol = password.Any(Function(c) Not Char.IsLetterOrDigit(c))

        Return hasUpperCase AndAlso hasLowerCase AndAlso hasDigit AndAlso hasSymbol
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim MySqlCommand As New SqlCommand
        Dim ms As New MemoryStream
        Dim strSql As String
        Dim StaffID As String = lblStaffID.Text
        Dim intValid As Integer = 0
        Dim strResult As String
        Dim strEmail, strIC As String
        Dim strPhoneNum As String = mskPhoneNum.Text
        Dim strPhoneNumEmergency As String = mskPhoneNumEmergency.Text
        Dim decDailyRate As Decimal
        picStaff.Image.Save(ms, picStaff.Image.RawFormat)

        If Not IsPasswordValid(txtPassword.Text) Then
            MessageBox.Show("Password should be at least 12 characters long and include a combination of uppercase letters, lowercase letters, numbers, and symbols.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        ' Validation for Phone number 
        If String.IsNullOrWhiteSpace(strPhoneNum) OrElse Not mskPhoneNum.MaskCompleted Then
            err.AppendLine("-Invalid phone number format for emergency phone number")
            ctr = If(ctr, mskPhoneNum)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr?.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(strPhoneNumEmergency) OrElse Not mskPhoneNumEmergency.MaskCompleted Then
            err.AppendLine("-Invalid phone number format for emergency phone number")
            ctr = If(ctr, mskPhoneNumEmergency)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error")
            ctr?.Focus()
            Return
        End If

        If cboPosition.SelectedIndex = 0 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 0 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If
        ElseIf cboPosition.SelectedIndex = 1 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 1 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If
        ElseIf cboPosition.SelectedIndex = 2 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 2 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If
        ElseIf cboPosition.SelectedIndex = 3 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 3 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If
        ElseIf cboPosition.SelectedIndex = 4 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 4 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If
        ElseIf cboPosition.SelectedIndex = 5 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 5 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If
        ElseIf cboPosition.SelectedIndex = 6 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 6 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If
        ElseIf cboPosition.SelectedIndex = 7 Then
            If cboJobType.SelectedIndex = 0 Then
                decDailyRate = 8.0
            End If
        ElseIf cboPosition.SelectedIndex = 7 Then
            If cboJobType.SelectedIndex = 1 Then
                decDailyRate = 9.0
            End If

        End If

        lblDailyRate.Text = decDailyRate.ToString("C")

        strEmail = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        strIC = "\d{6}-\d{2}-\d{4}"

        If (lblStaffID.Text = "" Or txtFirstName.Text = "" Or txtMiddleName.Text = "" Or txtLastName.Text = "" Or txtAddress.Text = "" _
                Or txtPostalCode.Text = "" Or txtCity.Text = "" Or dptBirthday.Text = "" Or txtPlaceOfBirth.Text = "" _
                Or txtICNum.Text = "" Or txtAge.Text = "" Or txtEmail.Text = "" Or dtpDateHired.Text = "" Or lblDailyRate.Text = "") Then
            MsgBox("Please Enter All Information", CType(MessageBoxIcon.Error, MsgBoxStyle), "Error")
        ElseIf Not Char.IsLetter(CChar(txtFirstName.Text)) Then
            MessageBox.Show("Please Enter Letter Only", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFirstName.Focus()
        ElseIf Not Char.IsLetter(CChar(txtMiddleName.Text)) Then
            MessageBox.Show("Please Enter Letter Only", "Invalid Middle Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtMiddleName.Focus()
        ElseIf Not Char.IsLetter(CChar(txtLastName.Text)) Then
            MessageBox.Show("Please Enter Letter Only", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLastName.Focus()
        ElseIf Not Char.IsLetter(CChar(txtAddress.Text)) Then
            MessageBox.Show("Please Enter Correctly", "Invalid Address", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAddress.Focus()
        ElseIf txtPostalCode.Text.Length > 6 Then
            MessageBox.Show("PostCode Only 5 Digits Allowed ", "Invalid Post Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPostalCode.Focus()
        ElseIf Not Char.IsLetter(CChar(txtCity.Text)) Then
            MessageBox.Show("Please Enter Letter Only", "Invalid City", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCity.Focus()
        ElseIf Format(dptBirthday.Value, "dd/MM/yyyy") = DateTime.Now.ToString("dd/MM/yyyy") Then
            MessageBox.Show("Birthday Can't Same With Today", "Invalid Brithday", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dptBirthday.Focus()
        ElseIf Not Char.IsLetter(CChar(txtPlaceOfBirth.Text)) Then
            MessageBox.Show("Please Enter Letter Only", "Invalid Place Of Birthday", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPlaceOfBirth.Focus()
        ElseIf txtICNum.Text.Length > 15 Then
            MessageBox.Show("IC Number Only 12 Digits Allowed ", "Invalid IC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtICNum.Focus()
        ElseIf Not Regex.IsMatch(txtICNum.Text, strIC) Then
            MessageBox.Show("Please Enter IC Number Like 010101-01-0010 ", "Invalid IC", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtICNum.Focus()
        ElseIf Not Char.IsDigit(CChar(txtAge.Text)) Then
            MessageBox.Show("Please Enter Numeric Like 25 ", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAge.Focus()
        ElseIf CInt(txtAge.Text) <= 17 Then
            MessageBox.Show("Age must be 18yrs. and above. ", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAge.Focus()
        ElseIf Not Regex.IsMatch(txtEmail.Text, strEmail) Then
            MessageBox.Show("Please Enter Email With @gmail.com ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmail.Focus()
        ElseIf Format(dtpDateHired.Value, "dd/MM/yyyy") = DateTime.Now.ToString("dd/MM/yyyy") Then
            MessageBox.Show("Please Choose Correctly", "Invalid Date Hired", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpDateHired.Focus()
        Else
            intValid = 1
        End If

        If OpenConnection() = True Then
            If intValid = 1 Then
                strResult = CStr(MessageBox.Show("Confirm Register?", "Confirm", MessageBoxButtons.YesNo))
                If strResult = CStr(DialogResult.Yes) Then
                    strSql = "Insert Into Staff (StaffID, Password, StaffFirstName, StaffMiddleName, StaffLastName, Address, PostalCode, 
                              City, Gender, Birthday, PlaceOfBirth, PhoneNum, ICNum, Age, Status, Email, PhoneNumEmergency, 
                              JobPosition, DateHired, DailyRate, JobTitle, JobType, PayMethod, StaffImage) 
                              VALUES (@StaffID, @Password, @StaffFirstName, @StaffMiddleName, @StaffLastName, @Address, @PostalCode, 
                              @City, @Gender, @Birthday, @PlaceOfBirth, @PhoneNum, @ICNum, @Age, @Status, @Email, @PhoneNumEmergency, 
                              @JobPosition, @DateHired, @DailyRate, @JobTitle, @JobType, @PayMethod, @StaffImage)"
                    MySqlCommand = New SqlCommand(strSql, conn)
                    MySqlCommand.Parameters.AddWithValue("@StaffID", lblStaffID.Text)
                    MySqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text)
                    MySqlCommand.Parameters.AddWithValue("@StaffFirstName", txtFirstName.Text)
                    MySqlCommand.Parameters.AddWithValue("@StaffMiddleName", txtMiddleName.Text)
                    MySqlCommand.Parameters.AddWithValue("@StaffLastName", txtLastName.Text)
                    MySqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text)

                    MySqlCommand.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text)
                    MySqlCommand.Parameters.AddWithValue("@City", txtCity.Text)
                    MySqlCommand.Parameters.AddWithValue("@Gender", cboGender.Text)
                    MySqlCommand.Parameters.AddWithValue("@Birthday", dptBirthday.Text)
                    MySqlCommand.Parameters.AddWithValue("@PlaceOfBirth", txtPlaceOfBirth.Text)
                    MySqlCommand.Parameters.AddWithValue("@PhoneNum", mskPhoneNum.Text)

                    MySqlCommand.Parameters.AddWithValue("@ICNum", txtICNum.Text)
                    MySqlCommand.Parameters.AddWithValue("@Age", txtAge.Text)
                    MySqlCommand.Parameters.AddWithValue("@Status", cboStatus.Text)
                    MySqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text)
                    MySqlCommand.Parameters.AddWithValue("@PhoneNumEmergency", mskPhoneNumEmergency.Text)

                    MySqlCommand.Parameters.AddWithValue("@JobPosition", cboPosition.Text)
                    MySqlCommand.Parameters.AddWithValue("@DateHired", dtpDateHired.Text)
                    MySqlCommand.Parameters.AddWithValue("@DailyRate", lblDailyRate.Text)
                    MySqlCommand.Parameters.AddWithValue("@JobTitle", cboJobTitle.Text)
                    MySqlCommand.Parameters.AddWithValue("@JobType", cboJobType.Text)
                    MySqlCommand.Parameters.AddWithValue("@PayMethod", cboPayMethod.Text)
                    MySqlCommand.Parameters.AddWithValue("@StaffImage", SqlDbType.Image).Value = ms.ToArray()

                    MySqlCommand.ExecuteNonQuery()
                    SetBlank()
                    MessageBox.Show("Staff info has been Register.", "Add Record " & StaffID)
                    Staff_Login.Show()
                Else
                    MessageBox.Show("Register Cancel")
                End If
            End If
            CloseConnection()
            Staff_Register_Load(Nothing, Nothing)
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtPostalCode.Text = ""
        txtCity.Text = ""
        cboGender.SelectedIndex = -1
        dptBirthday.Text = ""
        txtPlaceOfBirth.Text = ""
        mskPhoneNum.Text = ""
        txtICNum.Text = ""
        txtAge.Text = ""
        cboStatus.SelectedIndex = -1
        txtEmail.Text = ""
        mskPhoneNumEmergency.Text = ""
        cboPosition.SelectedIndex = -1
        cboJobTitle.SelectedIndex = -1
        dtpDateHired.Text = ""
        cboJobType.SelectedIndex = -1
        lblDailyRate.Text = ""
        cboPayMethod.SelectedIndex = -1
        txtPassword.Text = ""
        picStaff.Image = GetPerson()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Staff_Login.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Staff_Login.Show()
        Me.Close()
    End Sub

End Class
