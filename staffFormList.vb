Imports System.Data.SqlClient

Public Class staffFormList
    ' Establishing the connection to the database
    Private Sub staffFormList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If OpenConnection() Then
                MessageBox.Show("Connected to the database.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BindData() ' Retrieve and display data when the form loads
            Else
                MessageBox.Show("Error: Unable to establish database connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to retrieve and bind data to the DataGridView
    Private Sub BindData()
        Try
            Dim strFirstName As String = txtName.Text
            Dim strGender As String = cboGender.Text

            Dim query As String = "SELECT StaffID, StaffFirstName, StaffMiddleName, StaffLastName, " &
                                  "Address, PostalCode, City, Gender, Birthday, PlaceOfBirth, PhoneNum, " &
                                  "ICNum, Age, Status, Email, PhoneNumEmergency, JobPosition, JobTitle, " &
                                  "DateHired, JobType, DailyRate, PayMethod, JobStatus " &
                                  "FROM Staff WHERE 1 = 1"

            If Not String.IsNullOrEmpty(strFirstName) Then
                query &= " AND StaffFirstName LIKE @StaffFirstName"
            End If

            If strGender <> "All" Then
                query &= " AND Gender = @Gender"
            End If

            Using command As New SqlCommand(query, conn)
                If Not String.IsNullOrEmpty(strFirstName) Then
                    command.Parameters.AddWithValue("@StaffFirstName", "%" & strFirstName & "%")
                End If

                If strGender <> "All" Then
                    command.Parameters.AddWithValue("@Gender", strGender)
                End If

                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                ' Hiding the "Password" column if it exists in the DataTable
                If dataTable.Columns.Contains("Password") Then
                    dataTable.Columns.Remove("Password")
                End If

                dgv.DataSource = dataTable
                lblCount.Text = "Record Count: " & dataTable.Rows.Count.ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        BindData()
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim intNo As Integer = e.RowIndex
        If intNo > -1 Then
            Dim strId As String = CStr(dgv.Rows(intNo).Cells(0).Value)
            mStaff_Update.strSelectedId = strId
            mStaff_Update.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the current form and open the Staff_MainPage form
        Dim managerHomePage As New Manager_HomePage()
        Manager_HomePage.Show()
        Me.Close()
    End Sub
End Class
