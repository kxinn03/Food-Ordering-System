Imports System.Data.SqlClient
Imports System.IO

Public Class PaymentReport
    Private Sub PaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        LoadYearsComboBox()
    End Sub

    Private Sub LoadYearsComboBox()

        Try
            If PModuleDatabase.POpenConnection() Then
                Dim query As String = "SELECT DISTINCT YEAR(pay_date) AS SalesYear FROM payedFood"
                Using cmd As New SqlCommand(query, PModuleDatabase.pconn)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        cboYear.Items.Add(reader("SalesYear").ToString())
                    End While
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            PModuleDatabase.PCloseConnection()
        End Try
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        GenerateSalesReport()
        Label5.Text = "Sales Report on Year " & cboYear.SelectedItem.ToString
    End Sub

    Private Sub GenerateSalesReport()

        dgvSalesReport.Rows.Clear()

        Try
            Dim selectedYear As String = cboYear.SelectedItem?.ToString()
            If Not String.IsNullOrEmpty(selectedYear) AndAlso PModuleDatabase.POpenConnection() Then
                Dim query As String = $"SELECT Id, Name, Price, SUM(food_quantity) AS TotalQuantity, SUM(food_quantity * Price) AS TotalSales
                                    FROM Menu M
                                    LEFT JOIN payedFood PF ON M.Name = PF.food_name
                                    LEFT JOIN Payment P ON PF.payment_ID = P.payment_ID
                                    WHERE YEAR(PF.pay_date) = {selectedYear}
                                    GROUP BY Id, Name, Price"

                Using cmd As New SqlCommand(query, PModuleDatabase.pconn)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim itemId As String = reader("Id").ToString()
                        Dim itemName As String = reader("Name").ToString()
                        Dim itemPrice As Decimal = Convert.ToDecimal(reader("Price"))
                        Dim totalQuantitySold As Integer = If(Not IsDBNull(reader("TotalQuantity")), Convert.ToInt32(reader("TotalQuantity")), 0)
                        Dim totalSales As Decimal = If(Not IsDBNull(reader("TotalSales")), Convert.ToDecimal(reader("TotalSales")), 0)

                        dgvSalesReport.Rows.Add(itemId, itemName, itemPrice, totalQuantitySold, totalSales)
                    End While
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            PModuleDatabase.PCloseConnection()
        End Try
        CalculateBestAndWorstSellers()

    End Sub

    Private Sub CalculateBestAndWorstSellers()
        Try
            Dim selectedYear As String = cboYear.SelectedItem?.ToString()
            If Not String.IsNullOrEmpty(selectedYear) AndAlso PModuleDatabase.POpenConnection() Then
                Dim bestQuery As String = $"SELECT TOP 1 Id, Name, SUM(food_quantity * Price) AS TotalSales
                                    FROM Menu M
                                    LEFT JOIN payedFood PF ON M.Name = PF.food_name
                                    LEFT JOIN Payment P ON PF.payment_ID = P.payment_ID
                                    WHERE YEAR(PF.pay_date) = {selectedYear}
                                    GROUP BY Id, Name
                                    ORDER BY TotalSales DESC"

                Dim worstQuery As String = $"SELECT TOP 1 Id, Name, SUM(food_quantity * Price) AS TotalSales
                                    FROM Menu M
                                    LEFT JOIN payedFood PF ON M.Name = PF.food_name
                                    LEFT JOIN Payment P ON PF.payment_ID = P.payment_ID
                                    WHERE YEAR(PF.pay_date) = {selectedYear}
                                    GROUP BY Id, Name
                                    ORDER BY TotalSales ASC"

                Using cmdBest As New SqlCommand(bestQuery, PModuleDatabase.pconn)
                    Dim readerBest As SqlDataReader = cmdBest.ExecuteReader()

                    If readerBest.Read() Then
                        lblBest.Text = $"{readerBest("Id") & Environment.NewLine }{readerBest("Name")}"
                    Else
                        lblBest.Text = "No data available"
                    End If

                    readerBest.Close()
                End Using

                Using cmdWorst As New SqlCommand(worstQuery, PModuleDatabase.pconn)
                    Dim readerWorst As SqlDataReader = cmdWorst.ExecuteReader()

                    If readerWorst.Read() Then
                        lblWorst.Text = $"{readerWorst("Id") & Environment.NewLine}{readerWorst("Name")}"
                    Else
                        lblWorst.Text = "No data available"
                    End If

                    readerWorst.Close()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            PModuleDatabase.PCloseConnection()
        End Try
    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog()

    End Sub
    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim intCount As Integer = 0
        Dim fntHeader As New Font("Arial", 24, FontStyle.Bold)
        Dim fntSmall As New Font("Arial", 10)
        Dim fntNormal As New Font("Arial", 12)

        Dim xPos As Integer = 50
        Dim yPos As Integer = 50
        Dim columnWidths() As Integer = {50, 120, 120, 120, 120}

        Dim headerText As String = "MINIMOO Restaurant" & vbCrLf
        Dim subHeaderText As String = "Anything you need is here: MINIMOO restaurant" & vbCrLf & vbCrLf &
                                  "Jalan Genting Kelang, Setapak, " & vbCrLf & "53300, Federal Territory of Kuala Lumpur" & vbCrLf & vbCrLf
        Dim reportTitle As String = "Sales Report on Year " & cboYear.SelectedItem.ToString()
        Dim line As String = "-----     -------------     -------------------               ----------------  --------------   ---------------"
        Dim footer As String = "Report generated on " & DateTime.Now.ToString() & vbCrLf & "Copyright @ 2024. All rights reserved."
        Dim line2 As String = "---------------------------------------------------------------------------------------------------"
        Dim gridHeaderText As String = "No       Food ID         Food Name                  Food Price    Total Sold    Total Sales"

        e.Graphics.DrawImage(My.Resources.logo, 0, 0, 150, 150)
        e.Graphics.DrawString(headerText, fntHeader, Brushes.Orange, xPos + 120, yPos - 50)

        e.Graphics.DrawString(subHeaderText, fntSmall, Brushes.Gray, xPos + 120, yPos)
        yPos += fntNormal.Height * 6

        e.Graphics.DrawString(reportTitle, fntHeader, Brushes.Orange, xPos + 100, yPos)
        yPos += fntNormal.Height * 4

        e.Graphics.DrawString(gridHeaderText, fntNormal, Brushes.Black, xPos - 90, yPos)
        yPos += fntNormal.Height * 1
        e.Graphics.DrawString(line, fntNormal, Brushes.Black, xPos - 90, yPos)
        yPos += fntNormal.Height * 2

        For Each row As DataGridViewRow In dgvSalesReport.Rows
            intCount += 1
            Dim rowText As String = $"{intCount,-10} {row.Cells(0).Value,-15} {row.Cells(1).Value,-28} {row.Cells(2).Value,-15} {row.Cells(3).Value,-20} {row.Cells(4).Value,-13}"

            e.Graphics.DrawString(rowText, fntNormal, Brushes.Black, xPos - 90, yPos)
            yPos += fntNormal.Height * 2
        Next

        yPos += fntNormal.Height * 10
        Dim totalRecordText As String = "Total record: " & dgvSalesReport.Rows.Count
        e.Graphics.DrawString(totalRecordText, fntNormal, Brushes.Black, xPos - 80, yPos)
        yPos += fntNormal.Height * 1
        e.Graphics.DrawString(line2, fntNormal, Brushes.Black, xPos - 80, yPos)
        yPos += fntNormal.Height * 1
        e.Graphics.DrawString(footer, fntSmall, Brushes.Gray, xPos - 80, yPos)
    End Sub




End Class