Imports System.IO
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmAddMenu
    Private blnAdding As Boolean = False
    Private blnEditing As Boolean = False
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private frmUserDirection As Form
    Private localTime As DateTime = DateTime.Now
    Private radMainMenu As New RadioButton()
    Private radDeleteOrArchive As New RadioButton()
    Private radStay As New RadioButton()

    Private Sub frmAddMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        SetButtonStates(False)
        With lblDisplayDate
            .Text = localTime.ToString("g")
            .Font = New Font("Arial", 10, FontStyle.Bold)
        End With
    End Sub
    Private Sub SetButtonStates(enabled As Boolean)
        ' Enable or disable all buttons based on the provided flag
        btnAdd.Enabled = Not enabled
        btnEdit.Enabled = Not enabled
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = " Search"
        lockButton(search)
        ' Assuming you have a TextBox for the user to enter the search term
        Dim searchTerm As String = txtFoodName.Text.Trim()
        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim foundName As String = SearchCuisine(searchTerm)

            ' Display the information if a match is found
            If Not String.IsNullOrEmpty(foundName) And btnEdit.Enabled = Not Enabled Then
                DisplayCuisineInfo(foundName)
            Else
                MessageBox.Show("No matching cuisine found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter a search term.", "Search Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnSearchImage_Click(sender As Object, e As EventArgs) Handles btnSearchImage.Click
        If Not (blnAdding Or blnEditing) Then
            MessageBox.Show("Please choose an action (Add or Edit) before choosing your image", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                ' Dispose of the current image before loading a new one
                If picFoodImage.Image IsNot Nothing Then
                    picFoodImage.Image.Dispose()
                End If

                ' Load the new image
                Dim newImage As Image = Image.FromFile(OpenFileDialog1.FileName)
                ' Display the image in the PictureBox
                picFoodImage.Image = newImage
                picFoodImage.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As OutOfMemoryException
                MessageBox.Show("Selected image is too large or in an unsupported format.", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error loading the image: " & ex.Message, "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
        picFoodImage.Image = My.Resources.backgrd
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        SetButtonStates(True)
        blnAdding = True
        btnAddSave.Text = "Add"
        btnSearch.Enabled = False
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SetButtonStates(True)
        blnEditing = True
        btnSearch.Enabled = True
        btnAddSave.Text = "Save"
        lblId.Text = ""
    End Sub
    Private Sub SetButtonForEdit()
        btnAddSave.Text = "&Save"
        blnAdding = True
    End Sub
    Private Sub SetButtonAfterEdit()
        btnAddSave.Text = "&Add"
        SetButtonStates(True)
    End Sub
    Private Function lockButton(buttonAction As String)
        If Not (blnAdding Or blnEditing) Then
            MessageBox.Show("Please choose an action (Add or Edit) before clicking" & buttonAction & ".", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
    Private Function ValidateFoodName() As Boolean
        Dim strName As String = txtFoodName.Text.Trim()
        If strName = "" Then
            err.SetError(txtFoodName, "Please enter a valid [Food Name].")
            Return False
        Else
            If blnAdding Then
                If OpenConnection() = True Then
                    Dim strSql As String = "SELECT COUNT(*) FROM Menu WHERE Name = @Name"
                    Dim MySqlCommand As New SqlCommand(strSql, conn)
                    MySqlCommand.Parameters.AddWithValue("@Name", strName) ' Use the entered name, not the 'Name' parameter

                    Try
                        Dim count As Integer = CInt(MySqlCommand.ExecuteScalar())
                        If count > 0 Then
                            MessageBox.Show("This cuisine name already exists. Please choose a different name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                        ' If count is 0, it means the name is unique
                        err.SetError(txtFoodName, Nothing)
                        Return True
                    Catch ex As Exception
                        MessageBox.Show("Error checking for duplicate cuisine name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    Finally
                        ' Close the connection after using it
                        CloseConnection()
                    End Try
                Else
                    ' Connection couldn't be opened
                    Return False
                End If
            Else
                Return True
            End If
            Return False ' Add a return statement for the case where blnAdding is false
        End If

    End Function

    Private Function ValidatePrice() As Boolean
        Dim strPrice As String = txtPrice.Text.Trim()
        ' If the user didn't enter the cents, append ".00"
        If Not Decimal.TryParse(strPrice, Nothing) Then
            err.SetError(txtPrice, "Please enter a valid numeric value for [Price].")
            Return False
        End If
        If Not strPrice.Contains(".") Then
            strPrice &= ".00"
            txtPrice.Text = strPrice
        End If
        Dim priceValue As Decimal = Decimal.Parse(strPrice)
        If priceValue < 0 OrElse priceValue > 1000 Then
            err.SetError(txtPrice, "Price only allows values between 0 and 1000.")
            Return False
        End If
        err.SetError(txtPrice, Nothing) ' Clear the error if validation passes
        Return True
    End Function

    Private Function ValidateDescription() As Boolean
        Dim strDescription As String = txtDescription.Text.Trim()
        If strDescription.Length >= 90 Then
            err.SetError(txtDescription, "The maximum lenght for description is 90 characters.")
            Return False
        End If
        err.SetError(txtDescription, Nothing)
        Return True
    End Function
    Private Function IsCategorySelected() As Boolean
        ' Check if at least one category (RadioButton) is selected
        Return radBBQ.Checked OrElse radPasta.Checked OrElse radPizza.Checked OrElse radSalad.Checked OrElse radSoupNStew.Checked
    End Function
    Private Function IsGroupSelected() As Boolean
        ' Check if a group (Combo Box) is selected
        Return cboGroup.SelectedItem IsNot Nothing
    End Function
    Private Function GetSelectedCategory() As String
        If radBBQ.Checked Then
            Return radBBQ.Text
        ElseIf radPasta.Checked Then
            Return radPasta.Text
        ElseIf radPizza.Checked Then
            Return radPizza.Text
        ElseIf radSalad.Checked Then
            Return radSalad.Text
        ElseIf radSoupNStew.Checked Then
            Return radSoupNStew.Text
        End If
        Return radBBQ.Text
    End Function
    Private Function GetSelectedGroup() As String
        If cboGroup.SelectedItem IsNot Nothing Then
            Return cboGroup.SelectedItem.ToString()
        End If
        ' If nothing is selected, return a default value or handle as needed
        Return "General"
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnAddSave.Click
        Dim save As String = " Save"
        lockButton(save)
        Dim menuSql As New SqlCommand
        Dim menuReportSql As New SqlCommand
        Dim menuQuery As String
        Dim menuReportQuery As String
        Dim strActionMessage As String

        If Not ValidateFoodName() Then
            txtFoodName.Focus()
            Return
        End If
        If Not ValidateDescription() Then
            txtDescription.Focus()
            Return
        End If
        If Not ValidatePrice() Then
            txtPrice.Focus()
            Return
        End If
        If Not IsCategorySelected() Then
            MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not IsGroupSelected() Then
            MessageBox.Show("Please select a group.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If OpenConnection() = True Then
            If blnAdding Then
                menuQuery = "INSERT INTO Menu(Id, Name, Description, Price, Category, [Group], [Food Image],Archive) VALUES(@ID, @Name, @Description, @Price, @Category, @Group, @FoodImage,@Archive)"
                menuSql = New SqlCommand(menuQuery, conn)
                strActionMessage = "Your new cuisine record Added."
                lblId.Text = GetNextId()
                With menuSql.Parameters
                    .AddWithValue("@ID", lblId.Text)
                    .AddWithValue("@Name", txtFoodName.Text)
                    .AddWithValue("@Description", txtDescription.Text)
                    .AddWithValue("@Price", txtPrice.Text)
                    .AddWithValue("@Category", GetSelectedCategory())
                    .AddWithValue("@Group", GetSelectedGroup())
                    .AddWithValue("@Archive", "Unarchive")
                End With
                If picFoodImage.Image Is Nothing Then
                    Dim defaultImage As Image = My.Resources.addMenuBckgrd
                    menuSql.Parameters.AddWithValue("@FoodImage", ImageToByteArray(defaultImage))
                Else
                    menuSql.Parameters.AddWithValue("@FoodImage", ImageToByteArray(picFoodImage.Image))
                End If
                menuSql.ExecuteNonQuery()
                frmAddMenu_Load(Nothing, Nothing)
                CloseConnection()

            ElseIf blnEditing Then
                ' Update the existing record
                menuQuery = "UPDATE Menu SET ID=@ID, Name=@Name, Description=@Description, Price=@Price, Category=@Category, [Group]=@Group, [Food Image]=@FoodImage WHERE Id=@ID"
                menuSql = New SqlCommand(menuQuery, conn)
                With menuSql.Parameters
                    .AddWithValue("@ID", lblId.Text)
                    .AddWithValue("@Name", txtFoodName.Text)
                    .AddWithValue("@Description", txtDescription.Text)
                    .AddWithValue("@Price", txtPrice.Text)
                    .AddWithValue("@Category", GetSelectedCategory())
                    .AddWithValue("@Group", GetSelectedGroup())
                    .AddWithValue("@FoodImage", ImageToByteArray(picFoodImage.Image))
                End With
                menuSql.ExecuteNonQuery()

                'Add record to edit report
                menuReportQuery = "INSERT INTO MenuReport(ReportId, CuisineName, EditTime, CuisineId, EditPrice, EditGroup) VALUES(@ReportId, @Name, @EditTime, @ID, @Price, @EditGroup)"
                menuReportSql = New SqlCommand(menuReportQuery, conn)
                With menuReportSql.Parameters
                    .AddWithValue("@ReportId", GetNextReportId())
                    .AddWithValue("@EditTime", localTime)
                    .AddWithValue("@Name", txtFoodName.Text)
                    .AddWithValue("@ID", lblId.Text)
                    .AddWithValue("@Price", txtPrice.Text)
                    .AddWithValue("@EditGroup", GetSelectedGroup())
                End With

                menuReportSql.ExecuteNonQuery()
                strActionMessage = "Record Updated."
                CloseConnection()
            End If
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK)
        End If

        blnAdding = False
        blnEditing = False
        SetButtonAfterEdit()
        SetButtonStates(False)
        ClearUserInput()
        frmShowUserDirection()
        frmUserDirection.ShowDialog()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearUserInput()
        frmShowUserDirection()
        frmUserDirection.ShowDialog()
        Me.Close()
    End Sub
    Private Sub DisplayCuisineInfo(cuisineName As String)
        Dim strSql As String = "SELECT * FROM Menu WHERE Name = @Name"
        Dim MySqlCommand As New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Name", cuisineName)
        If OpenConnection() Then
            Dim reader As SqlDataReader = MySqlCommand.ExecuteReader()
            If reader.Read() Then
                lblId.Text = reader("Id").ToString()
                txtFoodName.Text = reader("Name").ToString()
                txtDescription.Text = reader("Description").ToString()
                txtPrice.Text = reader("Price").ToString()
                Dim category As String = reader("Category").ToString()
                Dim group As String = reader("Group").ToString()

                Select Case category
                    Case "BBQ"
                        radBBQ.Checked = True
                    Case "Pasta"
                        radPasta.Checked = True
                    Case "Pizza"
                        radPizza.Checked = True
                    Case "Salad"
                        radSalad.Checked = True
                    Case "Soup and Stew"
                        radSoupNStew.Checked = True
                    Case Else
                        radBBQ.Checked = True ' Default category
                End Select

                If Not String.IsNullOrEmpty(group) Then
                    Dim index As Integer = cboGroup.FindStringExact(group)
                    If index <> -1 Then
                        cboGroup.SelectedIndex = index
                    End If
                End If

                Dim imageBytes As Byte() = DirectCast(reader("Food Image"), Byte())
                If reader("Food Image") IsNot DBNull.Value Then
                    imageBytes = DirectCast(reader("Food Image"), Byte())
                    Dim imageStream As New MemoryStream(imageBytes)
                    picFoodImage.Image = Image.FromStream(imageStream)
                    picFoodImage.SizeMode = PictureBoxSizeMode.StretchImage
                Else 'if no picture
                    picFoodImage.Image = My.Resources.backgrd
                    picFoodImage.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
            reader.Close()
            CloseConnection()
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Function GetNextId() As String
        Dim intCount As Integer
        Dim strSql As String
        strSql = "Select * From Menu"
        da = New SqlDataAdapter(strSql, conn)
        ds.Clear()
        da.Fill(ds, "Menu")
        'read on table got how many row,then put the ttl into intcount, to get auto increase
        intCount = ds.Tables("Menu").Rows.Count
        Return (intCount + 1).ToString("C1000")
    End Function
    Public Function GetNextReportId() As String
        Dim intCount As Integer
        Dim strSql As String
        strSql = "Select * From MenuReport"
        da = New SqlDataAdapter(strSql, conn)
        ds.Clear()
        da.Fill(ds, "MenuReport")
        intCount = ds.Tables("MenuReport").Rows.Count
        Return (intCount + 1).ToString("MR1000")
    End Function
    Private Function SearchCuisine(searchTerm As String) As String
        Dim strSql As String = "SELECT Name FROM Menu WHERE Name LIKE @SearchTerm"
        Dim MySqlCommand As New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

        If OpenConnection() Then
            Dim foundId As Object = MySqlCommand.ExecuteScalar()
            CloseConnection()
            Return If(foundId IsNot Nothing, foundId.ToString(), "")
        Else
            MessageBox.Show("Error connecting to database server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End If
    End Function
    Private Function ImageToByteArray(image As Image) As Byte()
        Dim ms As New MemoryStream()
        image.Save(ms, image.RawFormat)
        Return ms.ToArray()
    End Function
    Private Sub ClearUserInput()
        lblId.Text = ""
        txtFoodName.Text = ""
        txtDescription.Text = ""
        txtPrice.Text = ""
        radBBQ.Checked = False
        radPasta.Checked = False
        radPizza.Checked = False
        radSalad.Checked = False
        radSoupNStew.Checked = False
        picFoodImage.Image = My.Resources.backgrd
        txtFoodName.Focus()
    End Sub
    Private Sub frmShowUserDirection()
        Dim lblTitle As Label
        If frmUserDirection Is Nothing Then
            frmUserDirection = New Form()
            With frmUserDirection
                .Size = New Size(550, 320)
                .StartPosition = FormStartPosition.CenterScreen
                .FormBorderStyle = FormBorderStyle.FixedSingle
                .BackgroundImage = My.Resources.addMenuBckgrd
                .BackgroundImageLayout = ImageLayout.Stretch
                .MaximizeBox = False
            End With

            lblTitle = New Label()
            With lblTitle
                .Text = "Please Select Which Module You Wanted To Go "
                .Font = New Font("MV Boli", 10, FontStyle.Bold)
                .AutoSize = True
                .Location = New Point(90, 80)
                .BackColor = Color.Transparent
            End With
            frmUserDirection.Controls.Add(lblTitle)

            With radMainMenu
                .Text = "Main Menu"
                .Location = New Point(90, lblTitle.Bottom + 20)
                .BackColor = Color.Transparent
                .Font = New Font("Arial", 10, FontStyle.Bold)
            End With
            frmUserDirection.Controls.Add(radMainMenu)

            With radDeleteOrArchive
                .Text = "Delete / Archive Cuisine"
                .Location = New Point(220, lblTitle.Bottom + 22)
                .BackColor = Color.Transparent
                .Font = New Font("Arial", 10, FontStyle.Bold)
                .AutoSize = True
            End With
            frmUserDirection.Controls.Add(radDeleteOrArchive)

            With radStay
                .Text = "Stay"
                .Location = New Point(90, lblTitle.Bottom + 70)
                .BackColor = Color.Transparent
                .Font = New Font("Arial", 10, FontStyle.Bold)
                .AutoSize = True
            End With
            frmUserDirection.Controls.Add(radStay)
            AddHandler radMainMenu.CheckedChanged, AddressOf radMainMenu_CheckedChanged
            AddHandler radDeleteOrArchive.CheckedChanged, AddressOf radDeleteOrArchive_CheckedChanged
            AddHandler radStay.CheckedChanged, AddressOf radStay_CheckedChanged
        End If
    End Sub

    Private Sub radMainMenu_CheckedChanged(sender As Object, e As EventArgs)
        If DirectCast(sender, RadioButton).Checked Then
            Dim mainMenuForm As New frmMenu()
            radMainMenu.Checked = False
            radDeleteOrArchive.Checked = False
            radStay.Checked = False
            frmUserDirection.Close()
            Me.Close()
        End If
    End Sub
    Private Sub radDeleteOrArchive_CheckedChanged(sender As Object, e As EventArgs)
        If DirectCast(sender, RadioButton).Checked Then
            Dim deleteMenuForm As New frmDeleteMenu()
            deleteMenuForm.ShowDialog()
            radMainMenu.Checked = False
            radDeleteOrArchive.Checked = False
            radStay.Checked = False
            frmUserDirection.Close()
            Me.Close()
        End If
    End Sub
    Private Sub radStay_CheckedChanged(sender As Object, e As EventArgs)
        If DirectCast(sender, RadioButton).Checked Then
            radMainMenu.Checked = False
            radDeleteOrArchive.Checked = False
            radStay.Checked = False
            frmUserDirection.Close()
        End If
    End Sub
End Class
