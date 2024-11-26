Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class frmMenuReport
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private currentPage As Integer = 1
    Dim strSelectedCuisineInCbo As String
    Private Sub frmMenuReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        pnlReport.AutoScroll = True
        Me.AutoScroll = True
        PopulateYearComboBox()
        PopulateCuisineComboBox()
    End Sub
    Private Sub PopulateYearComboBox()
        Dim localTime As DateTime = DateTime.Now
        Dim currentYear As Integer = localTime.Year
        Dim startYear As Integer = currentYear - 5
        Dim endYear As Integer = currentYear
        cboSelectYear.Items.Clear()
        For year As Integer = startYear To endYear
            cboSelectYear.Items.Add(year.ToString())
        Next
        cboSelectYear.SelectedItem = currentYear.ToString()
        LoadAddMenuReportData(cboSelectYear.SelectedItem)
    End Sub
    Private Sub cboSelectYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectYear.SelectedIndexChanged
        LoadAddMenuReportData(cboSelectYear.SelectedItem)
    End Sub
    Private Sub LoadAddMenuReportData(selectedYear As String)
        If OpenConnection() = True Then
            Dim strSql As String = "SELECT Id, Name, Date FROM Menu WHERE YEAR(Date) = @SelectedYear"
            da = New SqlDataAdapter(strSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@SelectedYear", selectedYear)
            ds.Clear()
            da.Fill(ds, "Menu")
            With dgvMenuAddHistory
                .DataSource = Nothing
                .Columns.Clear()
                .DataSource = ds.Tables("Menu")
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to the database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub docAddMenuReport_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docAddMenuReport.PrintPage
        Dim fntHeader As New Font("Microsoft Tai Le", 22, FontStyle.Bold)
        Dim fntHeaderName As New Font("Microsoft Tai Le", 18, FontStyle.Bold)
        Dim fntSubHeader As New Font("MV Boli", 13, FontStyle.Bold)
        Dim fntSubHeaderDate As New Font("MV Boli", 12)
        Dim fntBody As New Font("Consolas", 14, FontStyle.Bold)
        Dim strHeader As String = "Menu Report - Add History"
        Dim strSubHeader As String = "MINIMOO"
        Dim strSubHeader2 As String = "Ground Floor, Bangunan Tan Sri Khaw Kai Boh (Block A), "
        Dim strSubHeader3 As String = "Jalan Genting Kelang, Setapak, 53300 Kuala Lumpur,  "
        Dim strSubHeader4 As String = "Federal Territory of Kuala Lumpur  "
        Dim strSubHeader5 As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim body As New StringBuilder()
        body.AppendLine("NO.  Cuisine ID   Cuisine Name                 Add Time")
        body.AppendLine("---  ----------   ------------                 -------------------")

        Dim rowsPerPage As Integer = CInt(Math.Floor(e.MarginBounds.Height / fntBody.GetHeight(e.Graphics)))
        For rowIndex As Integer = (currentPage - 1) * rowsPerPage To dgvMenuAddHistory.Rows.Count - 1
            If rowIndex >= currentPage * rowsPerPage Then
                e.HasMorePages = True
                currentPage += 1
                Return
            End If
            Dim row As DataGridViewRow = dgvMenuAddHistory.Rows(rowIndex)
            Dim strCuisineId As String = row.Cells("Id").Value.ToString()
            Dim strCuisineName As String = row.Cells("Name").Value.ToString()
            Dim strAddTime As String = row.Cells("Date").Value.ToString()
            ' Add data to the body
            body.AppendFormat("{0,-4} {1,-13} {2,-28} {3, -25}" & vbNewLine, rowIndex + 1, strCuisineId, strCuisineName, strAddTime)
        Next

        Dim logoWidth As Integer = 220
        Dim centerX As Integer = CInt((e.MarginBounds.Width - logoWidth) / 2)
        Dim rightX As Integer = e.MarginBounds.Right - 310
        With e.Graphics
            .DrawImage(My.Resources.restaurantlogo, centerX + 80, 40, logoWidth, 165)
            .DrawString(strHeader, fntHeader, Brushes.DarkRed, centerX, 220)
            .DrawString(strSubHeader, fntHeaderName, Brushes.Black, centerX + 125, 265)
            .DrawString(strSubHeader2, fntSubHeader, Brushes.Black, centerX - 80, 295)
            .DrawString(strSubHeader3, fntSubHeader, Brushes.Black, centerX - 75, 315)
            .DrawString(strSubHeader4, fntSubHeader, Brushes.Black, centerX + 20, 335)
            .DrawString(strSubHeader5, fntSubHeaderDate, Brushes.Black, rightX, 370)
            .DrawString(body.ToString(), fntBody, Brushes.Chocolate, 55, 440)
        End With
    End Sub
    Private Sub btnAddMenuPrint_Click(sender As Object, e As EventArgs) Handles btnAddMenuPrint.Click
        dialogPreviewAddMenuReport.Document = docAddMenuReport
        dialogPreviewAddMenuReport.ShowDialog(Me)
    End Sub

    ' ------------    PART FOR EDIT REPORT    ------------
    Private Sub PopulateCuisineComboBox()
        cboSelectCuisine.Items.Clear()
        If OpenConnection() Then
            Try
                Dim strSql As String = "SELECT Id, Name FROM Menu"
                Using command As New SqlCommand(strSql, conn)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim cuisineId As String = reader("Id").ToString()
                            Dim cuisineName As String = reader("Name").ToString()
                            Dim displayText As String = $"{cuisineId} - {cuisineName}"
                            cboSelectCuisine.Items.Add(displayText)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching menu data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try
        Else
            MessageBox.Show("Error connecting to the database server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub cboSelectCuisine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectCuisine.SelectedIndexChanged
        If cboSelectCuisine.SelectedIndex <> -1 Then
            strSelectedCuisineInCbo = cboSelectCuisine.SelectedItem.ToString()
            Dim strSelectedId As String = strSelectedCuisineInCbo.Split("-"c)(0).Trim()
            LoadEditMenuReportData(strSelectedId)
        End If
    End Sub

    Private Sub LoadEditMenuReportData(strSelectedId As String)
        If OpenConnection() Then
            Try
                Dim strSql As String = "SELECT CuisineId, CuisineName, EditTime, EditPrice, EditGroup FROM MenuReport WHERE CuisineId = @SelectedId"
                da = New SqlDataAdapter(strSql, conn)
                da.SelectCommand.Parameters.AddWithValue("@SelectedId", strSelectedId)
                ds.Clear()
                da.Fill(ds, "MenuReport")

                With dgvMenuEditHistory
                    .DataSource = Nothing
                    .Columns.Clear()
                    .DataSource = ds.Tables("MenuReport")
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End With
            Catch ex As Exception
                MessageBox.Show("Error loading menu edit history data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try
        Else
            MessageBox.Show("Error connecting to the database server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub docEditMenuReport_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docEditMenuReport.PrintPage
        Dim fntHeader As New Font("Microsoft Tai Le", 22, FontStyle.Bold)
        Dim fntHeaderName As New Font("Microsoft Tai Le", 18, FontStyle.Bold)
        Dim fntSubHeader As New Font("MV Boli", 13, FontStyle.Bold)
        Dim fntSubHeaderDate As New Font("MV Boli", 12)
        Dim fntBody As New Font("Consolas", 14, FontStyle.Bold)
        Dim strHeader As String = "Menu Report - Edit History"
        Dim strSubHeader As String = "MINIMOO"
        Dim strSubHeader2 As String = "Ground Floor, Bangunan Tan Sri Khaw Kai Boh (Block A), "
        Dim strSubHeader3 As String = "Jalan Genting Kelang, Setapak, 53300 Kuala Lumpur,  "
        Dim strSubHeader4 As String = "Federal Territory of Kuala Lumpur  "
        Dim strSubHeader5 As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}", DateTime.Now)
        Dim strSubHeader6 As String = "Edit History For Cuisine :  " + strSelectedCuisineInCbo
        Dim body As New StringBuilder()
        body.AppendLine("Cuisine Name            Edit Time                 Price      Group")
        body.AppendLine("------------            -------------------       ------     -----")

        Dim rowsPerPage As Integer = CInt(Math.Floor(e.MarginBounds.Height / fntBody.GetHeight(e.Graphics)))
        For intRowIndex As Integer = (currentPage - 1) * rowsPerPage To dgvMenuEditHistory.Rows.Count - 1
            If intRowIndex >= currentPage * rowsPerPage Then
                e.HasMorePages = True
                currentPage += 1
                Return
            End If
            Dim row As DataGridViewRow = dgvMenuEditHistory.Rows(intRowIndex)
            Dim strCuisineName As String = row.Cells("CuisineName").Value.ToString()
            Dim editTime As String = row.Cells("EditTime").Value.ToString()
            Dim editPrice As String = row.Cells("EditPrice").Value.ToString()
            Dim editGroup As String = row.Cells("EditGroup").Value.ToString()
            ' Add data to the body
            body.AppendFormat("{0,-24} {1,-25} {2,-8} {3,-10}" & vbNewLine, strCuisineName, editTime, editPrice, editGroup)
        Next

        Dim logoWidth As Integer = 220
        Dim intCenterX As Integer = CInt((e.MarginBounds.Width - logoWidth) / 2)
        Dim intRightX As Integer = e.MarginBounds.Right - 310
        With e.Graphics
            .DrawImage(My.Resources.restaurantlogo, intCenterX + 80, 40, logoWidth, 165)
            .DrawString(strHeader, fntHeader, Brushes.DarkRed, intCenterX, 220)
            .DrawString(strSubHeader, fntHeaderName, Brushes.Black, intCenterX + 125, 265)
            .DrawString(strSubHeader2, fntSubHeader, Brushes.Black, intCenterX - 80, 295)
            .DrawString(strSubHeader3, fntSubHeader, Brushes.Black, intCenterX - 75, 315)
            .DrawString(strSubHeader4, fntSubHeader, Brushes.Black, intCenterX + 20, 335)
            .DrawString(strSubHeader5, fntSubHeaderDate, Brushes.Black, intRightX, 370)
            .DrawString(strSubHeader6, fntSubHeaderDate, Brushes.Black, 55, 400)
            .DrawString(body.ToString(), fntBody, Brushes.Chocolate, 10, 440)
        End With
    End Sub

    Private Sub btnEditMenuPrint_Click(sender As Object, e As EventArgs) Handles btnEditMenuPrint.Click
        dialogPreviewEditMenuReport.Document = docEditMenuReport
        dialogPreviewEditMenuReport.ShowDialog(Me)
    End Sub
End Class