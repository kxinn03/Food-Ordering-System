Imports System.Data.SqlClient
Imports System.IO
Public Class frmMenu
    Private strLoginID As String
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private intNumberRow As Decimal
    Public Const int_COLUMNS As Integer = 5I
    Private lastScrollPosition As Integer = 0  ' this is use to shoot to top when user click
    Private overlayPanel As Panel
    Private displayedForm As Form

    Friend strFoodName As String
    Friend decFoodPrice As Decimal
    Friend intFoodQuantity As Integer
    Friend foodPic As Image
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        AddHandler Me.Scroll, AddressOf YourForm_Scroll
        Try
            OpenConnection()

            ' Retrieve member ID based on the username
            Dim memberCommand As New SqlCommand
            Dim memberSql As String = "SELECT Id FROM Member WHERE Username = @Username"

            memberCommand = New SqlCommand(memberSql, conn)
            memberCommand.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)

            ' Execute the query and retrieve member details
            Dim memberReader As SqlDataReader = memberCommand.ExecuteReader()

            If memberReader.Read() Then
                strLoginID = memberReader("Id").ToString()

                ' Close the memberReader before executing the LINQ query
                memberReader.Close()
            End If


        Catch ex As Exception
            ' Handle any exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Dim groupBoxIndex As Integer = 0
        Dim strSql As String
        Dim charFirstCharacterOfId As Char = strLoginID(0).ToString.ToUpper
        rBtnHome.Image = My.Resources.homeIcon.GetThumbnailImage(46, 46, Nothing, IntPtr.Zero)
        rBtnMenu.Image = My.Resources.menuIcon.GetThumbnailImage(46, 46, Nothing, IntPtr.Zero)
        rBtnOrder.Image = My.Resources.orderIcon.GetThumbnailImage(44, 43, Nothing, IntPtr.Zero)
        rBtnProfile.Image = My.Resources.profileIcon.GetThumbnailImage(56, 56, Nothing, IntPtr.Zero)
        rBtnAddEdit.Image = My.Resources.addEditMenuIcon.GetThumbnailImage(43, 43, Nothing, IntPtr.Zero)
        rBtnDelete.Image = My.Resources.deleteIcon.GetThumbnailImage(42, 43, Nothing, IntPtr.Zero)
        rBtnChefRecomm.Image = My.Resources.chefRecommended2Icon.GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)
        If OpenConnection() = True Then
            strSql = "Select * From Menu Where Archive = 'Unarchive'"
            da = New SqlDataAdapter(strSql, conn)
            ds.Clear()
            da.Fill(ds, "Menu")
            If ds.Tables("Menu").Rows.Count > 0 Then
                intNumberRow = ds.Tables("Menu").Rows.Count
                ShowMenu()
            End If
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If

        If charFirstCharacterOfId = "M" Then
            rBtnAddEdit.Visible = False
            rBtnMenuReport.Visible = False
            rBtnDelete.Visible = False
            lblMenuReport.Visible = False
            lblAddEdit.Visible = False
            lblDelete.Visible = False
        Else
            rBtnAddEdit.Visible = True
            rBtnMenuReport.Visible = True
            rBtnDelete.Visible = True
            lblMenuReport.Visible = True
            lblAddEdit.Visible = True
            lblDelete.Visible = True
        End If
    End Sub
    Private Sub ShowMenu()
        Static intCountRow As Integer = 0I
        Dim roundedUp As Integer = Convert.ToInt32(Math.Ceiling(intNumberRow))
        For row = 0 To roundedUp - 1
            For col = 0 To int_COLUMNS - 1
                If intCountRow < intNumberRow Then ' Check if there are more rows to display
                    Dim roundedGroupBox As New RoundedGroupBox()
                    Dim strGroup As String = ds.Tables("Menu").Rows(intCountRow).Item(5)
                    Dim arrImage() As Byte
                    arrImage = ds.Tables("Menu").Rows(intCountRow).Item(6)
                    Dim mstream As New System.IO.MemoryStream(arrImage)
                    With roundedGroupBox
                        .Location = New Point(200 + col * (180 + 60), 180 + row * (300 + 25)) 'coordinate (left), column And spacing , coordinate(Top) , row And spacing
                        .Size = New Size(190, 290)
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
                        intCountRow += 1
                    End With
                    Me.Controls.Add(roundedGroupBox)
                End If
            Next
        Next
    End Sub

    Private Sub btnRoundCornerBBQ_Click(sender As Object, e As EventArgs) _
        Handles btnRoundCornerBBQ.Click, btnRoundCornerPasta.Click, btnRoundCornerPizza.Click, btnRoundCornerSalad.Click, btnRoundCornerSoup.Click
        Dim clickedButton As Button = DirectCast(sender, Button)
        'Create blur background
        overlayPanel = New Panel()
        With overlayPanel
            .BackColor = Color.FromArgb(150, Color.White) ' Adjust value for transparency
            .Size = Me.ClientSize
            .Location = New Point(0, 0)
        End With
        Me.Controls.Add(overlayPanel)
        ' Handle the Scroll event to disable scrolling on frmMenu
        Me.AutoScroll = False

        Select Case clickedButton.Name
            Case "btnRoundCornerBBQ"
                displayedForm = New frmBBQNGrill()
            Case "btnRoundCornerPasta"
                displayedForm = New frmPasta()
            Case "btnRoundCornerPizza"
                displayedForm = New frmPizza()
            Case "btnRoundCornerSalad"
                displayedForm = New frmSalad()
            Case "btnRoundCornerSoup"
                displayedForm = New frmSoupNStew()
        End Select

        displayedForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        displayedForm.ShowDialog()
        ' Restore the original state when pop out form is closed
        Me.Controls.Remove(overlayPanel)
        Me.AutoScroll = True
        displayedForm.Dispose()
        displayedForm = Nothing
        overlayPanel.Dispose()
        overlayPanel = Nothing
    End Sub
    Private Sub rBtnAddEdit_Click(sender As Object, e As EventArgs) Handles rBtnAddEdit.Click
        Dim addEditForm As New frmAddMenu()
        addEditForm.ShowDialog()
    End Sub
    Private Sub rBtnDeletet_Click(sender As Object, e As EventArgs) Handles rBtnDelete.Click
        frmDeleteMenu.ShowDialog()
    End Sub
    Private Sub rBtnMenuReport_Click(sender As Object, e As EventArgs) Handles rBtnMenuReport.Click
        frmMenuReport.ShowDialog()
    End Sub
    Private Sub YourForm_Scroll(sender As Object, e As ScrollEventArgs)
        ' Check if the user has scrolled to the bottom
        If Me.VerticalScroll.Value + Me.Height = Me.VerticalScroll.Maximum Then
            ' User has scrolled to the bottom, store the scroll position
            lastScrollPosition = Me.VerticalScroll.Value
        End If
    End Sub
    Private Sub btnScrollToTop_Click(sender As Object, e As EventArgs) Handles btnScrollToTop.Click
        ' Scroll the form's content back to the top
        Me.VerticalScroll.Value = 0
        ' Optionally, restore the scroll position if needed
        ' Me.VerticalScroll.Value = lastScrollPosition
    End Sub

    Private Sub rBtnProfile_Click(sender As Object, e As EventArgs) Handles rBtnProfile.Click
        member_profile.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnOrder_Click(sender As Object, e As EventArgs) Handles rBtnOrder.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class