Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class mStaff_Update
    Public strSelectedId As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Dim MySqlCommand As New SqlCommand
    Private currentRow As Integer = 0

    Private Sub mStaff_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtAddress.Enabled = blnTF
        txtPostalCode.Enabled = blnTF
        txtCIty.Enabled = blnTF
        cboGender.Enabled = blnTF
        dptBirthday.Enabled = blnTF
        txtPlaceOfBirth.Enabled = blnTF
        mskPhoneNum.Enabled = blnTF
        txtICNum.Enabled = blnTF
        txtAge.Enabled = blnTF
        cboStatus.Enabled = blnTF
        txtEmail.Enabled = blnTF
        mskPhoneNumEmergency.Enabled = blnTF
        cboPosition.Enabled = blnTF
        cboJobTitle.Enabled = blnTF
        dtpDateHired.Enabled = blnTF
        cboJobType.Enabled = blnTF
        lblDailyRate.Enabled = blnTF
        cboPayMethod.Enabled = blnTF
        picStaff.Enabled = blnTF
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
        err.Clear()
    End Sub

    Private Shared Function GetPerson() As Bitmap
        ' Replace with your resource image
        Return FoodOrderingSystem.My.Resources.add
    End Function

    Private Sub mStaff_Update_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
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
        Try
            If cboJobStatus.SelectedIndex <> -1 Then
                If OpenConnection() Then
                    Dim query As String = "UPDATE Staff SET JobStatus = @JobStatus WHERE StaffID = @StaffID"

                    Using command As New SqlCommand(query, conn)
                        command.Parameters.AddWithValue("@JobStatus", cboJobStatus.SelectedItem)
                        command.Parameters.AddWithValue("@StaffID", strSelectedId)

                        Dim affectedRows As Integer = command.ExecuteNonQuery()

                        If affectedRows > 0 Then
                            MessageBox.Show("Job status updated successfully.", "Update Job Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Update failed. Staff not found or no changes made.", "Update Job Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Else
                    MessageBox.Show("Error: Unable to establish database connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please select a job status to update.", "Update Job Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Manager_HomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Manager_HomePage.Show()
        Me.Close()
    End Sub

End Class
