Imports System.ComponentModel
Imports System.Globalization
Public Class manage2
    Private currentPage As Integer = 1
    Private currentYearIndex As Integer = 0

    Private columnSortDirections As New Dictionary(Of DataGridViewColumn, SortOrder)
    Public Class MemberData
        Public Property Id As String
        Public Property Name As String
        Public Property Username As String
        Public Property Password As String
        Public Property Email As String
        Public Property PhoneNumber As String
        Public Property JoinDate As Date
    End Class
    Public Sub BindData()
        Dim searchVariable As String = cboSearchVariable.Text
        Dim searchString As String = txtSearchValue.Text ' Change here to use txtSearchValue.Text
        currentYearIndex = 0


        Using db As New DBDataContext()
            Dim members As IQueryable(Of MemberData)

            ' Use the Switch statement to determine which property to search based on the selected variable
            Select Case searchVariable
                Case "Id"
                    txtSearchValue.Enabled = True
                    dtpJoinDate.Visible = False
                    members = From member In db.Members
                              Where member.Id.ToString().Contains(searchString)
                              Select New MemberData With {
                                  .Id = member.Id.ToString(),
                                  .Name = member.Name,
                                  .Username = member.Username,
                                  .Password = member.Password,
                                  .Email = member.Email,
                                  .PhoneNumber = member.PhoneNumber,
                                  .JoinDate = member.JoinDate
                              }
                Case "Name"
                    txtSearchValue.Enabled = True
                    dtpJoinDate.Visible = False
                    members = From member In db.Members
                              Where member.Name.Contains(searchString)
                              Select New MemberData With {
                                  .Id = member.Id.ToString(),
                                  .Name = member.Name,
                                  .Username = member.Username,
                                  .Password = member.Password,
                                  .Email = member.Email,
                                  .PhoneNumber = member.PhoneNumber,
                                  .JoinDate = member.JoinDate
                              }
                Case "Username"
                    txtSearchValue.Enabled = True
                    dtpJoinDate.Visible = False
                    members = From member In db.Members
                              Where member.Username.Contains(searchString)
                              Select New MemberData With {
                                  .Id = member.Id.ToString(),
                                  .Name = member.Name,
                                  .Username = member.Username,
                                  .Password = member.Password,
                                  .Email = member.Email,
                                  .PhoneNumber = member.PhoneNumber,
                                  .JoinDate = member.JoinDate
                              }
                Case "Password"
                    txtSearchValue.Enabled = True
                    dtpJoinDate.Visible = False
                    members = From member In db.Members
                              Where member.Password.Contains(searchString)
                              Select New MemberData With {
                                  .Id = member.Id.ToString(),
                                  .Name = member.Name,
                                  .Username = member.Username,
                                  .Password = member.Password,
                                  .Email = member.Email,
                                  .PhoneNumber = member.PhoneNumber,
                                  .JoinDate = member.JoinDate
                              }
                Case "Email"
                    txtSearchValue.Enabled = True
                    dtpJoinDate.Visible = False
                    members = From member In db.Members
                              Where member.Email.Contains(searchString)
                              Select New MemberData With {
                                  .Id = member.Id.ToString(),
                                  .Name = member.Name,
                                  .Username = member.Username,
                                  .Password = member.Password,
                                  .Email = member.Email,
                                  .PhoneNumber = member.PhoneNumber,
                                  .JoinDate = member.JoinDate
                              }
                Case "PhoneNumber"
                    txtSearchValue.Enabled = True
                    txtSearchValue.Visible = True
                    dtpJoinDate.Visible = False
                    members = From member In db.Members
                              Where member.PhoneNumber.Contains(searchString)
                              Select New MemberData With {
                                  .Id = member.Id.ToString(),
                                  .Name = member.Name,
                                  .Username = member.Username,
                                  .Password = member.Password,
                                  .Email = member.Email,
                                  .PhoneNumber = member.PhoneNumber,
                                  .JoinDate = member.JoinDate
                              }

                Case "JoinDate"

                    txtSearchValue.Visible = False
                    dtpJoinDate.Visible = True
                    dtpJoinDate.Enabled = True

                    ' Set the format of the DateTimePicker to match the expected format
                    dtpJoinDate.Format = DateTimePickerFormat.Custom
                    dtpJoinDate.CustomFormat = "dd/MM/yyyy"

                    ' Use the selected date for searching
                    Dim selectedDate As Date = dtpJoinDate.Value.Date
                    members = From member In db.Members
                              Where member.JoinDate.Date = selectedDate.Date
                              Select New MemberData With {
                      .Id = member.Id.ToString(),
                      .Name = member.Name,
                      .Username = member.Username,
                      .Password = member.Password,
                      .Email = member.Email,
                      .PhoneNumber = member.PhoneNumber,
                      .JoinDate = member.JoinDate
                  }

                Case Else
                    txtSearchValue.Enabled = False
                    txtSearchValue.Text = ""
                    dtpJoinDate.Enabled = False
                    dtpJoinDate.Visible = False
                    ' Show all data when no specific search variable is selected
                    members = From member In db.Members
                              Select New MemberData With {
                                  .Id = member.Id.ToString(),
                                  .Name = member.Name,
                                  .Username = member.Username,
                                  .Password = member.Password,
                                  .Email = member.Email,
                                  .PhoneNumber = member.PhoneNumber,
                                  .JoinDate = member.JoinDate
                              }
            End Select

            Dim memberList As New BindingList(Of MemberData)(members.ToList())

            dgvMember.DataSource = memberList
            lblCount.Text = memberList.Count.ToString("0 record(s)")
        End Using
    End Sub

    Private Sub cboSearchVariable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSearchVariable.SelectedIndexChanged
        ' Rebind data when the selected variable changes
        txtSearchValue.Enabled = True
        txtSearchValue.Visible = True
        BindData()
    End Sub

    Private Sub txtSearchValue_TextChanged(sender As Object, e As EventArgs) Handles txtSearchValue.TextChanged
        ' Rebind data when the search value changes

        BindData()
    End Sub
    Private Sub manage2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        BindData()
        cboSearchVariable.SelectedIndex = 0
    End Sub

    Private Sub txtSearchName_TextChanged(sender As Object, e As EventArgs)
        BindData()
    End Sub

    Private Sub dgvMember_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMember.CellDoubleClick
        Dim intNo As Integer = e.RowIndex
        If intNo > -1 Then
            Dim strId As String = CStr(dgvMember.Rows(intNo).Cells(0).Value)
            FrmAction.strSelectedId = strId
            FrmAction.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        FrmAddMember.ShowDialog()
        BindData()
    End Sub


    Private Sub dgvMember_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMember.ColumnHeaderMouseClick
        Dim columnIndex = e.ColumnIndex
        Dim clickedColumn = dgvMember.Columns(columnIndex)

        If clickedColumn.SortMode <> DataGridViewColumnSortMode.NotSortable Then
            Dim propertyName = clickedColumn.DataPropertyName

            If Not columnSortDirections.ContainsKey(clickedColumn) Then
                ' If the column is not in the dictionary, initialize with Ascending order
                columnSortDirections(clickedColumn) = SortOrder.Ascending
            Else
                ' Toggle the sort order for the clicked column
                columnSortDirections(clickedColumn) = If(columnSortDirections(clickedColumn) = SortOrder.Ascending, SortOrder.Descending, SortOrder.Ascending)
            End If

            ' Update the sort direction in the column header
            clickedColumn.HeaderCell.SortGlyphDirection = columnSortDirections(clickedColumn)

            Dim memberList = CType(dgvMember.DataSource, BindingList(Of MemberData))
            Dim direction = columnSortDirections(clickedColumn)
            Dim sortedList = If(direction = SortOrder.Ascending,
                        memberList.OrderBy(Function(x) x.GetType().GetProperty(propertyName).GetValue(x)),
                        memberList.OrderByDescending(Function(x) x.GetType().GetProperty(propertyName).GetValue(x))
                    ).ToList()

            memberList.RaiseListChangedEvents = False
            memberList.Clear()

            For Each item In sortedList
                memberList.Add(item)
            Next

            memberList.RaiseListChangedEvents = True
            memberList.ResetBindings()
        End If
    End Sub

    Private Sub dtpJoinDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpJoinDate.ValueChanged
        BindData()
    End Sub

    Private Sub docMemberReport_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles docMemberReport.BeginPrint
        ' Declare and set DefaultPageSettings for landscape orientation
        Dim pageSettings As New Printing.PageSettings()
        pageSettings.Landscape = True

        ' Set the DefaultPageSettings property of PrintDocument
        docMemberReport.DefaultPageSettings = pageSettings
    End Sub

    Private Sub docMemberReport_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles docMemberReport.PrintPage
        Dim fntPrint As New Font("Arial", 10)
        Dim fntHeading As New Font("Arial", 10, FontStyle.Bold)
        Dim fntBitHeading As New Font("Arial", 16, FontStyle.Bold)
        Dim sngLineHeight As Single = fntPrint.GetHeight + 10
        Dim sngXLocation As Single = e.MarginBounds.Left
        Dim sngYLocation As Single = e.MarginBounds.Top
        Dim pageFooter As String = $"Generated on {DateTime.Now:dd-MMM-yyyy HH:mm:ss} | © 2023 Minimoo Restaurant. All rights reserved."
        Dim pageFooterFont As New Font("Arial", 8)
        Dim pageFooterSize As SizeF = e.Graphics.MeasureString(pageFooter, pageFooterFont)
        Dim pageFooterX As Single = 0
        Dim pageFooterY As Single = e.PageBounds.Bottom - pageFooterSize.Height - 110 ' Adjust this value as needed

        ' Ensure that the footer is not placed outside the printable area
        If pageFooterY < e.MarginBounds.Top Then
            pageFooterY = e.MarginBounds.Top
        End If

        e.Graphics.DrawString(pageFooter, pageFooterFont, Brushes.Black, pageFooterX, pageFooterY)
        Dim lineY As Single = pageFooterY - 5 ' Adjust this value as needed
        e.Graphics.DrawLine(Pens.Black, 0, lineY, 950, lineY)


        ' Increment the current page number for the next page
        currentPage += 1

        ' Header and Logo
        e.Graphics.DrawImage(My.Resources.logo, 0, 0, 200, 100)
        Dim strHeader As String = "Member Joining Report"
        Dim strSubHeader As String = String.Format("Print Date  : {0:dd-MMM-yyyy}", DateTime.Now)
        Dim strSubHeader1 As String = String.Format("Print Time : {0:hh:mm tt}", DateTime.Now)
        Dim strSubHeader2 As String = String.Format("MINIMOO RESTAURANT" & vbCrLf & vbCrLf & "Ground Floor, Bangunan Tan Sri Khaw Kai Boh (Block A)," & vbCrLf & "Jalan Genting Kelang, Setapak," & vbCrLf & "53300 Kuala Lumpur, Federal Territory of Kuala Lumpur")
        e.Graphics.DrawString(strHeader, fntBitHeading, Brushes.Black, 320, 120)
        sngYLocation += sngLineHeight
        sngYLocation += sngLineHeight
        e.Graphics.DrawString(strSubHeader, fntHeading, Brushes.Black, 755, 10)
        e.Graphics.DrawString(strSubHeader1, fntHeading, Brushes.Black, 755, 30)
        e.Graphics.DrawString(strSubHeader2, fntHeading, Brushes.Black, 250, 10)



        sngYLocation += sngLineHeight

        Using db As New DBDataContext()
            Dim members = From member In db.Members
            Dim groupedMembers = members.GroupBy(Function(m) New With {m.JoinDate.Year, m.JoinDate.Month}).OrderBy(Function(group) group.Key.Year).ThenBy(Function(group) group.Key.Month).ToList()

            ' Ensure there are more pages to print
            If currentYearIndex < groupedMembers.Count Then
                Dim yearMonthGroup = groupedMembers(currentYearIndex)

                ' Display year and month header
                e.Graphics.DrawString($"--------- {yearMonthGroup.Key.Year} - {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(yearMonthGroup.Key.Month)} ---------", fntBitHeading, Brushes.Black, 300, sngYLocation)
                sngYLocation += sngLineHeight

                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fntHeading, Brushes.Black, 0, sngYLocation)
                e.Graphics.DrawString("  ID", fntHeading, Brushes.Black, 5, sngYLocation + 15)
                e.Graphics.DrawString("NAME", fntHeading, Brushes.Black, 100, sngYLocation + 15)
                e.Graphics.DrawString("USERNAME", fntHeading, Brushes.Black, 200, sngYLocation + 15)
                e.Graphics.DrawString("PASSWORD", fntHeading, Brushes.Black, 315, sngYLocation + 15)
                e.Graphics.DrawString("EMAIL", fntHeading, Brushes.Black, 530, sngYLocation + 15) ' Adjusted X-coordinate and increased width
                e.Graphics.DrawString("PHONE NUMBER", fntHeading, Brushes.Black, 700, sngYLocation + 15)
                e.Graphics.DrawString("JOIN DATE", fntHeading, Brushes.Black, 830, sngYLocation + 15)
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fntHeading, Brushes.Black, 0, sngYLocation + 35)

                sngYLocation += sngLineHeight + 30 ' Adjusted spacing

                ' Display member data for the month
                For Each member In yearMonthGroup
                    e.Graphics.DrawString(member.Id.ToString(), fntHeading, Brushes.Black, 10, sngYLocation)
                    e.Graphics.DrawString(member.Name, fntHeading, Brushes.Black, 75, sngYLocation)
                    e.Graphics.DrawString(member.Username, fntHeading, Brushes.Black, 205, sngYLocation)
                    e.Graphics.DrawString(member.Password, fntHeading, Brushes.Black, 320, sngYLocation)
                    e.Graphics.DrawString(member.Email, fntHeading, Brushes.Black, 455, sngYLocation) ' Adjusted X-coordinate and increased width
                    e.Graphics.DrawString(member.PhoneNumber, fntHeading, Brushes.Black, 705, sngYLocation)
                    e.Graphics.DrawString(member.JoinDate.ToString("dd/MM/yyyy"), fntHeading, Brushes.Black, 835, sngYLocation)
                    sngYLocation += sngLineHeight
                Next

                ' Display total for the month
                Dim totalRecords As String = $"Total Record(s) : {yearMonthGroup.Count()}"
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fntHeading, Brushes.Black, 0, sngYLocation)
                sngYLocation += 15
                e.Graphics.DrawString(totalRecords, fntPrint, Brushes.Black, 5, sngYLocation)
                sngYLocation += 10
                e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------", fntHeading, Brushes.Black, 0, sngYLocation)
                sngYLocation += sngLineHeight

                ' Move to the next year for the next page
                currentYearIndex += 1

                ' Check if there are more pages to print
                If currentYearIndex < groupedMembers.Count Then
                    e.HasMorePages = True
                Else
                    ' No more pages to print
                    e.HasMorePages = False
                End If
            Else
                ' No more pages to print
                e.HasMorePages = False
            End If
        End Using
    End Sub
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        dlgPreviewMemberReport.Document = docMemberReport
        dlgPreviewMemberReport.ShowDialog(Me)
    End Sub
End Class