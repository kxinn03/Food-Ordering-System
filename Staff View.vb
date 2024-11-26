Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Text
Public Class Staff_View
    ' Variable to hold the selected staff ID
    Public strSelectedId As String

    ' Dataset and DataAdapter for data manipulation
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter

    ' SqlCommand object
    Dim MySqlCommand As New SqlCommand

    Private Sub SomeMethodInStaffUpdate()
        ' Access the EnteredStaffID from Staff_Login
        Dim staffID As String = Staff_Login.EnteredStaffID

        ' Use the staffID value as needed in Staff_Update form
        ' For example, display the StaffID in a label
        lblStaffID.Text = staffID
    End Sub

    ' Method to enable/disable various labels and image
    Private Sub Enable(ByVal blnTF As Boolean)
        ' Enabling or disabling individual labels and image based on the provide boolean value
        lblStaffID.Enabled = blnTF
        lblFirstName.Enabled = blnTF
        lblMiddleName.Enabled = blnTF
        lblLastName.Enabled = blnTF
        lblAdress.Enabled = blnTF
        lblPostalCode.Enabled = blnTF
        lblCIty.Enabled = blnTF
        lblGender.Enabled = blnTF
        lblBirthday.Enabled = blnTF
        lblPlaceOfBirth.Enabled = blnTF
        lblPhoneNum.Enabled = blnTF
        lblICNum.Enabled = blnTF
        lblAge.Enabled = blnTF
        lblStatus.Enabled = blnTF
        lblEmail.Enabled = blnTF
        lblPhoneNumEmergency.Enabled = blnTF
        lblPosition.Enabled = blnTF
        lblJobTitle.Enabled = blnTF
        lblDateHired.Enabled = blnTF
        lblJobType.Enabled = blnTF
        lblDailyRate.Enabled = blnTF
        lblPayMethod.Enabled = blnTF
        lblJobStatus.Enabled = blnTF
        picStaff.Enabled = blnTF
    End Sub

    Private Shared Function GetPerson() As Bitmap
        ' Replace with your resource image
        Return FoodOrderingSystem.My.Resources.add
    End Function

    ' Method to retrieve the staff details based on the selected ID
    Private Sub RetrieveStaffDetails(strSelectedId As String)
        Try
            ' Check if the database connection can be opened
            If OpenConnection() Then
                ' SQL query to retrieve details of a specific staff member based on StaffID
                Dim sqlQuery As String = "SELECT * FROM Staff WHERE StaffID = @StaffID"

                ' Append additional conditions to the query if selectedId is provided
                If Not String.IsNullOrEmpty(strSelectedId) Then
                    sqlQuery &= " AND StaffID = @StaffID"
                End If

                ' Using SqlCommand to execute the SQL query
                Using command As New SqlCommand(sqlQuery, conn)
                    command.Parameters.AddWithValue("@StaffID", strSelectedId)

                    ' Execute the query and read the results using SqlDataReader
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Retrieve staff details from the database and populate the form fields
                            lblStaffID.Text = reader("StaffID").ToString()
                            lblFirstName.Text = reader("StaffFirstName").ToString()
                            lblMiddleName.Text = reader("StaffMiddleName").ToString()
                            lblLastName.Text = reader("StaffLastName").ToString()
                            lblAdress.Text = reader("Address").ToString()
                            lblPostalCode.Text = reader("PostalCode").ToString()
                            lblCIty.Text = reader("City").ToString()
                            lblGender.Text = reader("Gender").ToString()
                            lblBirthday.Text = reader("Birthday").ToString()
                            lblPlaceOfBirth.Text = reader("PlaceOfBirth").ToString()
                            lblPhoneNum.Text = reader("PhoneNum").ToString()
                            lblICNum.Text = reader("ICNum").ToString()
                            lblAge.Text = reader("Age").ToString()
                            lblStatus.Text = reader("Status").ToString()
                            lblEmail.Text = reader("Email").ToString()
                            lblPhoneNumEmergency.Text = reader("PhoneNumEmergency").ToString()
                            lblPosition.Text = reader("JobPosition").ToString()
                            lblJobTitle.Text = reader("JobTitle").ToString()
                            lblDateHired.Text = reader("DateHired").ToString()
                            lblJobType.Text = reader("JobType").ToString()
                            lblDailyRate.Text = reader("DailyRate").ToString()
                            lblPayMethod.Text = reader("PayMethod").ToString()
                            lblJobStatus.Text = reader("JobStatus").ToString()

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


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub Staff_View_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Retrieve and display staff details when the form is shown
        RetrieveStaffDetails(strSelectedId)
    End Sub

    Private Sub Staff_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable labels and image on form load
        Enable(False)

        ' Fetch all staff data into a DataSet (not used in the current context)
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and open the Staff_MainPage form
        Dim staffMainPage As New Staff_MainPage()
        staffMainPage.ShowDialog()
        Me.Close()
    End Sub


    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        ' Hide the current form, show the Staff_MainPage, and dispose the form instance after use
        Me.Hide()
        Dim sm As New Staff_MainPage()
        sm.ShowDialog()
        sm.Dispose()
        Me.Show()
    End Sub

End Class