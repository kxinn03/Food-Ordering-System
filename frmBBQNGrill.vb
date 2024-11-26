Imports System.Data.SqlClient
Public Class frmBBQNGrill
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private intNumberRow As Decimal
    Public Const int_COLUMNS As Integer = 5I

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim groupBoxIndex As Integer = 0
        Dim strSql As String
        Me.Size = New Size(1284, 628)
        Me.Location = New Point(189, 160)
        If OpenConnection() = True Then
            strSql = "Select * From Menu Where Category = 'BBQ and Grill'"
            da = New SqlDataAdapter(strSql, conn)
            ds.Clear()
            da.Fill(ds, "Menu")

            If ds.Tables("Menu").Rows.Count > 0 Then
                intNumberRow = ds.Tables("Menu").Rows.Count
                ShowBBQMenu()
            End If
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ShowBBQMenu()
        Static intCountRow As Integer = 0I
        Dim intRoundedUp As Integer = Convert.ToInt32(Math.Ceiling(intNumberRow))
        Dim closeButton As New Label()
        With closeButton
            .Text = "<-- Back"
            .Font = New Font("Ravie", 15, FontStyle.Bold)
            .ForeColor = Color.White
            .AutoSize = True
            .Cursor = Cursors.Hand
            .BackColor = Color.FromArgb(183, 4, 4)
        End With
        Dim intCenterXforCloseButton As Integer = (Me.ClientSize.Width - closeButton.Width) \ 2  ' must locate at here, since wu will run closeButton
        closeButton.Location = New Point(intCenterXforCloseButton, 0)
        AddHandler closeButton.Click, Sub(sender As Object, e As EventArgs)
                                          Me.Close()
                                      End Sub
        Me.Controls.Add(closeButton)

        For row = 0 To intRoundedUp - 1
            For col = 0 To int_COLUMNS - 1
                If intCountRow < intNumberRow Then ' Check if there are more rows to display
                    Dim roundedGroupBox As New RoundedGroupBox()
                    Dim strGroup As String = ds.Tables("Menu").Rows(intCountRow).Item(5)
                    Dim arrImage() As Byte
                    arrImage = ds.Tables("Menu").Rows(intCountRow).Item(6)
                    Dim mstream As New System.IO.MemoryStream(arrImage)

                    With roundedGroupBox
                        .Location = New Point(65 + col * (180 + 60), 40 + row * (300 + 25)) 'coordinate (left), column And spacing , coordinate(Top) , row And spacing
                        .Size = New Size(190, 280)
                        If strGroup = "General" Then
                            .GroupBoxColor = Color.DarkOrange
                        ElseIf strGroup = "Chef Favourite" Then
                            .GroupBoxColor = Color.OrangeRed
                            Dim chefButton As New RoundButton() ' Create a new instance of chefButton
                            With chefButton
                                .Size = New Size(46, 42)
                                .Location = New Point(roundedGroupBox.Width - 46, roundedGroupBox.Height - 40)
                                .Image = My.Resources.chefRecommended2Icon.GetThumbnailImage(46, 46, Nothing, IntPtr.Zero)
                            End With
                            roundedGroupBox.Controls.Add(chefButton)

                        ElseIf strGroup = "Special" Then
                            .GroupBoxColor = Color.DarkSalmon
                        Else
                            .GroupBoxColor = Color.DarkOrange
                        End If

                        .GroupImage = Image.FromStream(mstream)
                        .Text = ds.Tables("Menu").Rows(intCountRow).Item(1) & Environment.NewLine & Environment.NewLine & ds.Tables("Menu").Rows(intCountRow).Item(2) & Environment.NewLine & Environment.NewLine & "RM " & ds.Tables("Menu").Rows(intCountRow).Item(3)
                        .TextFont = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
                        .TextColor = Color.White
                        .CuisineName = ds.Tables("Menu").Rows(intCountRow).Item(1).ToString()
                        .CuisinePicture = Image.FromStream(mstream)
                        .CuisinePrice = Convert.ToDecimal(ds.Tables("Menu").Rows(intCountRow).Item(3))
                    End With
                    Me.Controls.Add(roundedGroupBox)
                    intCountRow += 1
                End If
            Next
        Next
    End Sub
End Class
