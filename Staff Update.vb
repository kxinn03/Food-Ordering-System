Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Text
Public Class Staff_Update
    Public strSelectedId As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Dim MySqlCommand As New SqlCommand
    Private currentRow As Integer = 0
    Private Sub SomeMethodInStaffUpdate()
        ' Access the EnteredStaffID from Staff_Login
        Dim staffID As String = Staff_Login.EnteredStaffID
        lblStaffID.Text = staffID
    End Sub
    Private Sub Staff_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enable(False)

        Dim strSql As String

        If OpenConnection() = True Then
            strSql = "Select * From Staff"
            da = New SqlDataAdapter(strSql, conn)
            ds.Clear()
            da.Fill(ds, "Staff")

            CloseConnection()

        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Enable(ByVal blnTF As Boolean)
        lblStaffID.Enabled = blnTF
        txtFirstName.Enabled = blnTF
        txtMiddleName.Enabled = blnTF
        txtLastName.Enabled = blnTF
        cboGender.Enabled = blnTF
        dptBirthday.Enabled = blnTF
        txtPlaceOfBirth.Enabled = blnTF
        txtICNum.Enabled = blnTF
        cboJobTitle.Enabled = blnTF
        dtpDateHired.Enabled = blnTF
        lblDailyRate.Enabled = blnTF
        picStaff.Enabled = blnTF
        cboJobStatus.Enabled = blnTF
    End Sub

    Private Sub ResetForm()
        ' Clear all form fields
        lblStaffID.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtPostalCode.Text = ""
        txtCIty.Text = ""
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
        cboJobStatus.SelectedIndex = -1
        picStaff.Image = GetPerson()
        Err.Clear()
    End Sub

    Private Shared Function GetPerson() As Bitmap
        ' Replace with your resource image
        Return FoodOrderingSystem.My.Resources.add
    End Function

    Private Sub Staff_Update_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
        RetrieveStaffDetails(strSelectedId)
    End Sub

    Private Sub RetrieveStaffDetails(selectedId As String)
        Try
            If OpenConnection() Then
                Dim sqlQuery As String = "SELECT * FROM Staff WHERE StaffID = @StaffID"

                If Not String.IsNullOrEmpty(strSelectedId) Then
                    sqlQuery &= " AND StaffID = @StaffID"
                End If

                Using command As New SqlCommand(sqlQuery, conn)
                    command.Parameters.AddWithValue("@StaffID", strSelectedId)


                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Retrieve staff details from the database and populate the form fields
                            lblStaffID.Text = reader("StaffID").ToString()
                            txtFirstName.Text = reader("StaffFirstName").ToString()
                            txtMiddleName.Text = reader("StaffMiddleName").ToString()
                            txtLastName.Text = reader("StaffLastName").ToString()
                            txtAddress.Text = reader("Address").ToString()
                            txtPostalCode.Text = reader("PostalCode").ToString()
                            txtCIty.Text = reader("City").ToString()
                            cboGender.SelectedItem = reader("Gender").ToString()
                            dptBirthday.Value = Convert.ToDateTime(reader("Birthday"))
                            txtPlaceOfBirth.Text = reader("PlaceOfBirth").ToString()
                            mskPhoneNum.Text = reader("PhoneNum").ToString()
                            txtICNum.Text = reader("ICNum").ToString()
                            txtAge.Text = reader("Age").ToString()
                            cboStatus.SelectedItem = reader("Status").ToString()
                            txtEmail.Text = reader("Email").ToString()
                            mskPhoneNumEmergency.Text = reader("PhoneNumEmergency").ToString()
                            cboPosition.SelectedItem = reader("JobPosition").ToString()
                            cboJobTitle.SelectedItem = reader("JobTitle").ToString()
                            dtpDateHired.Value = Convert.ToDateTime(reader("DateHired"))
                            cboJobType.SelectedItem = reader("JobType").ToString()
                            lblDailyRate.Text = reader("DailyRate").ToString()
                            cboPayMethod.SelectedItem = reader("PayMethod").ToString()
                            cboJobStatus.SelectedItem = reader("JobStatus").ToString()
                            ' Assuming the staff image is stored as a byte array in the database

                            ' Retrieve job title and populate the cboJobTitle ComboBox

                            If Not IsDBNull(reader("StaffImage")) Then
                                Dim img() As Byte = DirectCast(reader("StaffImage"), Byte())
                                If img IsNot Nothing Then
                                    Using ms As New System.IO.MemoryStream(img)
                                        picStaff.Image = Image.FromStream(ms)
                                    End Using
                                Else
                                    picStaff.Image = GetPerson() ' Default image if no image is found in the database
                                End If
                            Else
                                picStaff.Image = GetPerson() ' Default image if StaffImage is DBNull.Value
                            End If
                        Else
                            MessageBox.Show("Staff not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Error: Unable to establish database connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim err As New StringBuilder()
        Dim ctr As Control = Nothing
        Dim MySqlCommand As New SqlCommand
        Dim ms As New MemoryStream()
        Dim strSql As String
        Dim StaffID As String = lblStaffID.Text
        Dim intValid As Integer = 0
        Dim strResult As String
        Dim strEmail As String
        Dim strPhoneNum As String = mskPhoneNum.Text
        Dim strPhoneNumEmergency As String = mskPhoneNumEmergency.Text
        Dim decDailyRate As Decimal
        picStaff.Image.Save(ms, picStaff.Image.RawFormat)

        ' Validation for Phone number 
        If Not mskPhoneNum.MaskCompleted Then
            err.AppendLine("-Invalid phone number format for phone number")
            ctr = If(ctr, mskPhoneNum)
        End If

        If Not mskPhoneNumEmergency.MaskCompleted Then
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

        If (lblStaffID.Text = "" Or txtAddress.Text = "" _
                Or txtPostalCode.Text = "" Or txtCIty.Text = "" _
                Or txtAge.Text = "" Or txtEmail.Text = "" Or lblDailyRate.Text = "") Then
            MsgBox("Please Enter All Information", CType(MessageBoxIcon.Error, MsgBoxStyle), "Error")
        ElseIf Not Char.IsLetter(CChar(txtAddress.Text)) Then
            MessageBox.Show("Please Enter Letter Only", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAddress.Focus()
        ElseIf txtPostalCode.Text.Length > 6 Then
            MessageBox.Show("PostCode Only 5 Digits Allowed ", "Invalid Post Code", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPostalCode.Focus()
        ElseIf Not Char.IsLetter(CChar(txtCIty.Text)) Then
            MessageBox.Show("Please Enter Letter Only", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCIty.Focus()
        ElseIf Not Char.IsDigit(CChar(txtAge.Text)) Then
            MessageBox.Show("Please Enter Numeric Like 25 ", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAge.Focus()
        ElseIf CInt(txtAge.Text) <= 17 Then
            MessageBox.Show("Age must be 18yrs. and above. ", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAge.Focus()
        ElseIf Not Regex.IsMatch(txtEmail.Text, strEmail) Then
            MessageBox.Show("Please Enter Email With @gmail.com ", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtEmail.Focus()
        Else
            intValid = 1
        End If



        If OpenConnection() = True Then
            If intValid = 1 Then
                strResult = CStr(MessageBox.Show("Confirm to update?", "Confirm", MessageBoxButtons.YesNo))
                If strResult = CStr(DialogResult.Yes) Then
                    strSql = "UPDATE Staff SET Address = @Address, PostalCode = @PostalCode, City = @City, " &
                         "PhoneNum = @PhoneNum, Age = @Age, Status = @Status, Email = @Email, " &
                         "PhoneNumEmergency = @PhoneNumEmergency, JobPosition = @JobPosition, " &
                         "JobType = @JobType, PayMethod = @PayMethod, StaffImage = @StaffImage " &
                         "WHERE StaffID = @StaffID"

                    MySqlCommand = New SqlCommand(strSql, conn)
                    MySqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text)
                    MySqlCommand.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text)
                    MySqlCommand.Parameters.AddWithValue("@City", txtCIty.Text)
                    MySqlCommand.Parameters.AddWithValue("@PhoneNum", mskPhoneNum.Text)
                    MySqlCommand.Parameters.AddWithValue("@Age", txtAge.Text)
                    MySqlCommand.Parameters.AddWithValue("@Status", cboStatus.Text)
                    MySqlCommand.Parameters.AddWithValue("@Email", txtEmail.Text)
                    MySqlCommand.Parameters.AddWithValue("@PhoneNumEmergency", mskPhoneNumEmergency.Text)
                    MySqlCommand.Parameters.AddWithValue("@JobPosition", cboPosition.Text)
                    MySqlCommand.Parameters.AddWithValue("@JobType", cboJobType.Text)
                    MySqlCommand.Parameters.AddWithValue("@PayMethod", cboPayMethod.Text)
                    MySqlCommand.Parameters.AddWithValue("@StaffImage", If(ms.Length > 0, ms.ToArray(), DBNull.Value))
                    MySqlCommand.Parameters.AddWithValue("@StaffID", lblStaffID.Text)


                    MySqlCommand.ExecuteNonQuery()
                    ResetForm()
                    MessageBox.Show("Staff info has been Updated.", "Update Record " & StaffID)
                Else
                    MessageBox.Show("Update Cancel")
                End If
            End If
            CloseConnection()
            Staff_Update_Load(Nothing, Nothing)

        Else

            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If

        ms.Dispose()
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Manager_HomePage.Show()
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        ofdImage.InitialDirectory = "Pictures"
        ofdImage.Filter = "Only Picture With JPG/JPEG/PNG Extension|*.jpg;*.jpeg;*.png"

        If ofdImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            picStaff.Image = Image.FromFile(ofdImage.FileName)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim sm As New Staff_MainPage()
        sm.ShowDialog()
        sm.Dispose() ' Properly dispose the form instance after use
        Me.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim sm As New Staff_MainPage()
        sm.ShowDialog()
        sm.Dispose() ' Properly dispose the form instance after use
        Me.Show()
    End Sub
End Class