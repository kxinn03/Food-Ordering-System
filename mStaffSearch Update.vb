Imports System.IO
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Text
Public Class mStaffSearch_Update
    Private mstrCurrentID As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Dim MySqlCommand As New SqlCommand
    Private currentRow As Integer = 0

    Private Sub mStaffSearch_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub SetBlank()
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
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If OpenConnection() = True Then
            Dim sqlcmd As New SqlCommand("select * from Staff where StaffID = @StaffID", conn)

            sqlcmd.Parameters.AddWithValue("@StaffID"， txtFindStaffID.Text)

            Dim SearchStaff As New SqlDataAdapter(sqlcmd)
            Dim SStaff As New DataTable()

            SearchStaff.Fill(SStaff)

            If SStaff.Rows.Count <> 0 Then
                With SStaff
                    lblStaffID.Text = .Rows(0).Item(0).ToString()
                    txtFirstName.Text = .Rows(0).Item(2).ToString()
                    txtMiddleName.Text = .Rows(0).Item(3).ToString()
                    txtLastName.Text = .Rows(0).Item(4).ToString()
                    txtAddress.Text = .Rows(0).Item(5).ToString()
                    txtPostalCode.Text = .Rows(0).Item(6).ToString()
                    txtCIty.Text = .Rows(0).Item(7).ToString()
                    cboGender.Text = .Rows(0).Item(8).ToString()
                    dptBirthday.Text = .Rows(0).Item(9).ToString()
                    txtPlaceOfBirth.Text = .Rows(0).Item(10).ToString()
                    mskPhoneNum.Text = .Rows(0).Item(11).ToString()
                    txtICNum.Text = .Rows(0).Item(12).ToString()
                    txtAge.Text = .Rows(0).Item(13).ToString()
                    cboStatus.Text = .Rows(0).Item(14).ToString()
                    txtEmail.Text = .Rows(0).Item(15).ToString()
                    mskPhoneNumEmergency.Text = .Rows(0).Item(16).ToString()
                    cboPosition.Text = .Rows(0).Item(17).ToString()
                    dtpDateHired.Text = .Rows(0).Item(18).ToString()
                    lblDailyRate.Text = .Rows(0).Item(19).ToString()
                    cboJobTitle.Text = .Rows(0).Item(20).ToString()
                    cboJobType.Text = .Rows(0).Item(21).ToString()
                    cboPayMethod.Text = .Rows(0).Item(22).ToString()
                    cboJobStatus.Text = .Rows(0).Item(23).ToString()
                    Enable(False)



                    If Not IsDBNull(.Rows(0).Item(24)) AndAlso TypeOf .Rows(0).Item(24) Is Byte() Then
                        Dim img() As Byte = CType(.Rows(0).Item(24), Byte())
                        ' Your code to handle the image byte array here
                        ' For instance, convert it to an image and display it
                        Dim ms As New MemoryStream(img)
                        picStaff.Image = Image.FromStream(ms)
                    Else
                        ' If the value is NULL or not a byte array, set a default image or take appropriate action
                        picStaff.Image = GetPerson()
                    End If
                End With

            Else
                MessageBox.Show("The Staff ID is not found, please reenter a correct Staff ID. ", "Record not Found")
                txtFindStaffID.Text = ""
                txtFindStaffID.Select()
                SetBlank()
            End If
            CloseConnection()
        Else
            MessageBox.Show("Can't Connect To Database")
        End If





    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If cboJobStatus.SelectedIndex <> -1 Then
                If OpenConnection() Then
                    Dim query As String = "UPDATE Staff SET JobStatus = @JobStatus WHERE StaffID = @StaffID"

                    Using command As New SqlCommand(query, conn)
                        command.Parameters.AddWithValue("@JobStatus", cboJobStatus.SelectedItem)
                        command.Parameters.AddWithValue("@StaffID", txtFindStaffID.Text)

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


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        SetBlank()
        txtFindStaffID.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        currentRow = 0
        ShowRecord()
    End Sub
    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        currentRow = ds.Tables("Staff").Rows.Count - 1
        ShowRecord()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentRow = ds.Tables("Staff").Rows.Count - 1 Then
            currentRow = 0
        Else
            currentRow += 1
        End If
        ShowRecord()

    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentRow = 0 Then
            currentRow = ds.Tables("Staff").Rows.Count - 1
        Else
            currentRow -= 1
        End If
        ShowRecord()
    End Sub
    Private Sub ShowRecord()

        Try
            lblStaffID.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(0))
            txtFirstName.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(2))
            txtMiddleName.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(3))
            txtLastName.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(4))
            txtAddress.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(5))
            txtPostalCode.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(6))
            txtCIty.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(7))
            cboGender.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(8))
            dptBirthday.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(9))
            txtPlaceOfBirth.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(10))
            mskPhoneNum.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(11))
            txtICNum.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(12))
            txtAge.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(13))
            cboStatus.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(14))
            txtEmail.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(15))
            mskPhoneNumEmergency.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(16))
            cboPosition.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(17))
            dtpDateHired.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(18))
            lblDailyRate.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(19))
            cboJobTitle.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(20))
            cboJobType.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(21))
            cboPayMethod.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(22))
            cboJobStatus.Text = CStr(ds.Tables("Staff").Rows(currentRow).Item(23))



            Dim img() As Byte
            img = CType(ds.Tables("Staff").Rows(currentRow).Item(24), Byte())
            Dim ms As New MemoryStream(img)
            picStaff.Image = Image.FromStream(ms)
        Catch ex As Exception
            MessageBox.Show("Have Null Record", "Empty Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Manager_HomePage.Show()
        Me.Close()
    End Sub
End Class