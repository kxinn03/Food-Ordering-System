Imports System.Data.SqlClient

Public Class paymentMethod
    Private Sub paymentMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        GeneratePaymentMethodReport()
        Label5.Text = "Payment Method Report on Year " & cboYear.SelectedItem.ToString
        If lblLeast.Text = "Card" Then
            picLeast.Image = Global.FoodOrderingSystem.My.Resources._6963703
        ElseIf lblLeast.Text = "Cash" Then
            picLeast.Image = Global.FoodOrderingSystem.My.Resources._438526
        ElseIf lblLeast.Text = "E-Wallet" Then
            picLeast.Image = Global.FoodOrderingSystem.My.Resources._1796819
        Else
            picLeast.Image = Global.FoodOrderingSystem.My.Resources._1159417
        End If
        If lblMost.Text = "Card" Then
            picMost.Image = Global.FoodOrderingSystem.My.Resources._6963703
        ElseIf lblMost.Text = "Cash" Then
            picMost.Image = Global.FoodOrderingSystem.My.Resources._438526
        ElseIf lblMost.Text = "E-Wallet" Then
            picMost.Image = Global.FoodOrderingSystem.My.Resources._1796819
        Else
            picMost.Image = Global.FoodOrderingSystem.My.Resources._1159417
        End If
    End Sub

    Private Sub GeneratePaymentMethodReport()
        dgvPaymentMethod.Rows.Clear()

        Try
            Dim selectedYear As String = cboYear.SelectedItem?.ToString()
            If Not String.IsNullOrEmpty(selectedYear) AndAlso PModuleDatabase.POpenConnection() Then
                Dim query As String = $"SELECT payment_method, SUM(payment_totalPrice) AS TotalPrice, COUNT(*) AS TotalCount
                                    FROM Payment P
                                    JOIN payedFood PF ON P.payment_ID = PF.payment_ID
                                    WHERE YEAR(PF.pay_date) = {selectedYear}
                                    GROUP BY payment_method"

                Using cmd As New SqlCommand(query, PModuleDatabase.pconn)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim paymentMethod As String = reader("payment_method").ToString()
                        Dim totalPrice As Decimal = Convert.ToDecimal(reader("TotalPrice"))
                        Dim totalCount As Integer = Convert.ToInt32(reader("TotalCount"))

                        dgvPaymentMethod.Rows.Add(paymentMethod, totalPrice, totalCount)
                    End While
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            PModuleDatabase.PCloseConnection()
        End Try

        CalculateMostAndLeastUsedPaymentMethods()
    End Sub


    Private Sub CalculateMostAndLeastUsedPaymentMethods()
        Try
            Dim selectedYear As String = cboYear.SelectedItem?.ToString()
            If Not String.IsNullOrEmpty(selectedYear) AndAlso PModuleDatabase.POpenConnection() Then
                Dim mostQuery As String = $"SELECT payment_method, COUNT(*) AS TotalCount
                                        FROM Payment P
                                        JOIN payedFood PF ON P.payment_ID = PF.payment_ID
                                        WHERE YEAR(PF.pay_date) = {selectedYear}
                                        GROUP BY payment_method
                                        ORDER BY TotalCount DESC"

                Dim leastQuery As String = $"SELECT payment_method, COUNT(*) AS TotalCount
                                        FROM Payment P
                                        JOIN payedFood PF ON P.payment_ID = PF.payment_ID
                                        WHERE YEAR(PF.pay_date) = {selectedYear}
                                        GROUP BY payment_method
                                        ORDER BY TotalCount ASC"

                Using cmdMost As New SqlCommand(mostQuery, PModuleDatabase.pconn)
                    Dim readerMost As SqlDataReader = cmdMost.ExecuteReader()

                    Dim mostMethods As New List(Of String)
                    Dim mostCount As Integer = 0

                    While readerMost.Read()
                        Dim count As Integer = Convert.ToInt32(readerMost("TotalCount"))
                        If count >= mostCount Then
                            If count > mostCount Then
                                mostMethods.Clear()
                                mostCount = count
                            End If
                            mostMethods.Add(readerMost("payment_method").ToString())
                        End If
                    End While

                    readerMost.Close()

                    If mostMethods.Count = 1 Then
                        lblMost.Text = $"{mostMethods(0)}"
                        lblMostTime.Text = $"({mostCount} times)"
                    Else
                        lblMost.Text = "No Most Used Payment Method"
                    End If
                End Using

                Using cmdLeast As New SqlCommand(leastQuery, PModuleDatabase.pconn)
                    Dim readerLeast As SqlDataReader = cmdLeast.ExecuteReader()

                    Dim leastMethods As New List(Of String)
                    Dim leastCount As Integer = Integer.MaxValue

                    While readerLeast.Read()
                        Dim count As Integer = Convert.ToInt32(readerLeast("TotalCount"))
                        If count <= leastCount Then
                            If count < leastCount Then
                                leastMethods.Clear()
                                leastCount = count
                            End If
                            leastMethods.Add(readerLeast("payment_method").ToString())
                        End If
                    End While

                    readerLeast.Close()

                    If leastMethods.Count = 1 Then
                        lblLeast.Text = $"{leastMethods(0)}"
                        lblLeastTime.Text = $"({leastCount} times)"
                    Else
                        lblLeast.Text = "No Least Used Payment Method"
                    End If
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

    Private Sub dgvPaymentMethod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaymentMethod.CellContentClick

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
        Dim fntSmall As New Font("Arial", 14)
        Dim fntNormal As New Font("Arial", 16)

        Dim xPos As Integer = 50
        Dim yPos As Integer = 50
        Dim columnWidths() As Integer = {50, 120, 120, 120, 120}

        Dim headerText As String = "MINIMOO Restaurant" & vbCrLf
        Dim subHeaderText As String = "Anything you need is here: MINIMOO restaurant" & vbCrLf & vbCrLf &
                                  "Jalan Genting Kelang, Setapak, " & vbCrLf & "53300, Federal Territory of Kuala Lumpur" & vbCrLf & vbCrLf
        Dim reportTitle As String = "Payment Method Report on Year " & cboYear.SelectedItem.ToString()
        Dim line As String = "----      ------------------------        -------------------------         ------------------"
        Dim footer As String = "Report generated on " & DateTime.Now.ToString() & vbCrLf & "Copyright @ 2024. All rights reserved."
        Dim line2 As String = "---------------------------------------------------------------------------------------------------"
        Dim gridHeaderText As String = "No       Payment Method         Total Transaction            Total Used "

        e.Graphics.DrawImage(My.Resources.logo, 0, 0, 150, 150)
        e.Graphics.DrawString(headerText, fntHeader, Brushes.Orange, xPos + 120, yPos - 50)

        e.Graphics.DrawString(subHeaderText, fntSmall, Brushes.Gray, xPos + 120, yPos)
        yPos += fntNormal.Height * 6

        e.Graphics.DrawString(reportTitle, fntHeader, Brushes.Orange, xPos + 30, yPos)
        yPos += fntNormal.Height * 2

        e.Graphics.DrawString(gridHeaderText, fntNormal, Brushes.Black, xPos - 90, yPos)
        yPos += fntNormal.Height * 1
        e.Graphics.DrawString(line, fntNormal, Brushes.Black, xPos - 90, yPos)
        yPos += fntNormal.Height * 2

        For Each row As DataGridViewRow In dgvPaymentMethod.Rows
            intCount += 1
            Dim rowText As String = $"{intCount,-10} {row.Cells(0).Value,-35} {row.Cells(1).Value,-35} {row.Cells(2).Value,-40} "
            e.Graphics.DrawString(rowText, fntNormal, Brushes.Black, xPos - 90, yPos)
            yPos += fntNormal.Height * 2
        Next

        yPos += fntNormal.Height * 10
        Dim totalRecordText As String = "Total record: " & dgvPaymentMethod.Rows.Count
        e.Graphics.DrawString(totalRecordText, fntNormal, Brushes.Black, xPos - 80, yPos)
        yPos += fntNormal.Height * 1
        e.Graphics.DrawString(line2, fntNormal, Brushes.Black, xPos - 80, yPos)
        yPos += fntNormal.Height * 1
        e.Graphics.DrawString(footer, fntSmall, Brushes.Gray, xPos - 80, yPos)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class