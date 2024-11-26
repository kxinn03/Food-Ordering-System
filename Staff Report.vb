Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class Staff_Report
    Private Sub Staff_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
    End Sub

    Private Sub InitializeForm()
        btnPrintPreview.Enabled = False
        btnSearch.Enabled = False

        ' Adding DataGridView columns
        dgvReport.Columns.AddRange(
            New DataGridViewTextBoxColumn() With {.Name = "StaffID", .HeaderText = "Staff ID"},
            New DataGridViewTextBoxColumn() With {.Name = "StaffFirstName", .HeaderText = "Staff "},
            New DataGridViewTextBoxColumn() With {.Name = "StaffMiddleName", .HeaderText = "Full"},
            New DataGridViewTextBoxColumn() With {.Name = "StaffLastName", .HeaderText = "Name"},
            New DataGridViewTextBoxColumn() With {.Name = "ICNum", .HeaderText = "IC Number"},
            New DataGridViewTextBoxColumn() With {.Name = "PhoneNum", .HeaderText = "Phone Number"},
            New DataGridViewTextBoxColumn() With {.Name = "DateHired", .HeaderText = "Date Hired"},
            New DataGridViewTextBoxColumn() With {.Name = "JobStatus", .HeaderText = "Job Status"}
        )
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        dgvReport.Rows.Clear()
        btnPrintPreview.Enabled = False
        btnSearch.Enabled = False
        cboJobStatus.Enabled = True
        cboJobStatus.SelectedIndex = -1
    End Sub

    Private Sub cboJobStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJobStatus.SelectedIndexChanged

        btnSearch.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If Not ValidateInputs() Then Return

        Dim jobStatus As String = cboJobStatus.SelectedItem.ToString()

        ' Assuming ModuleDatabase has methods OpenConnection, CloseConnection, and conn for database operations.
        If ModuleDatabase.OpenConnection() Then
            Try
                Dim sqlCommandText As String = "SELECT StaffID, StaffFirstName, StaffMiddleName, StaffLastName, ICNum, PhoneNum, DateHired, JobStatus FROM Staff WHERE JobStatus = @JobStatus"
                Using sqlCommand As New SqlCommand(sqlCommandText, ModuleDatabase.conn)
                    sqlCommand.Parameters.AddWithValue("@JobStatus", jobStatus)

                    Using dataAdapter As New SqlDataAdapter(sqlCommand)
                        Dim dataTable As New DataTable()
                        dataAdapter.Fill(dataTable)

                        dgvReport.Rows.Clear()

                        For Each row As DataRow In dataTable.Rows
                            dgvReport.Rows.Add(row("StaffID"), row("StaffFirstName"), row("StaffMiddleName"), row("StaffLastName"), row("ICNum"),
                                       row("PhoneNum"), row("DateHired"), row("JobStatus"))
                        Next

                        If dgvReport.Rows.Count = 0 Then
                            MessageBox.Show("No records found for the selected job status", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            btnPrintPreview.Enabled = True
                            btnSearch.Enabled = False
                            cboJobStatus.Enabled = False
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ModuleDatabase.CloseConnection()
            End Try
        Else
            MessageBox.Show("Error connecting to the database server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If cboJobStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a job status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Manager_HomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog()
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles doc.PrintPage
        Dim fntHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fntSubHeader As New Font("Calibri", 12)
        Dim fntBody As New Font("Consolas", 10)

        Dim strHeader As String = "Staff Date Hired"
        Dim strSubHeader As String = String.Format(
            "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
            "Prepared by Kirtheneshvari", DateTime.Now
        )

        Dim body As New StringBuilder()
        body.AppendLine("StaffID Staff Full Name                    IC Number      JobStatus   Date Hired")
        body.AppendLine("------ ---------------------------------   ---------      ---------  ----------")

        For Each row As DataGridViewRow In dgvReport.Rows
            If Not row.IsNewRow Then
                Dim StaffID As String = If(row.Cells("StaffID").Value IsNot Nothing, row.Cells("StaffID").Value.ToString(), "")
                Dim fullName As String = $"{If(row.Cells("StaffFirstName").Value IsNot Nothing, row.Cells("StaffFirstName").Value.ToString(), "")} " &
                                        $"{If(row.Cells("StaffMiddleName").Value IsNot Nothing, row.Cells("StaffMiddleName").Value.ToString(), "")} " &
                                        $"{If(row.Cells("StaffLastName").Value IsNot Nothing, row.Cells("StaffLastName").Value.ToString(), "")}"
                Dim ICNum As String = If(row.Cells("ICNum").Value IsNot Nothing, row.Cells("ICNum").Value.ToString(), "")
                Dim jobStatus As String = If(row.Cells("JobStatus").Value IsNot Nothing, row.Cells("JobStatus").Value.ToString(), "")
                Dim dateHired As String = If(row.Cells("DateHired").Value IsNot Nothing, row.Cells("DateHired").Value.ToString(), "")

                body.AppendFormat("{0,-6} {1,-35} {2,-9} {3,-9} {4}" & vbNewLine, StaffID, fullName, ICNum, jobStatus, dateHired)
            End If
        Next

        With e.Graphics
            .DrawImage(My.Resources.logo, 0, 0, 80, 100)
            .DrawString(strHeader, fntHeader, Brushes.Purple, 100, 0)
            .DrawString(strSubHeader, fntSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fntBody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class


