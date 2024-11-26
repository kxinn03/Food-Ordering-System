Imports System.Data.SqlClient
Public Class frmDeleteMenu
    Private ds As DataSet = New DataSet()
    Private da As SqlDataAdapter
    Private frmPopOut As Form
    Private WithEvents btnArchive As Button
    Private strSelectedCuisine As String
    Private intRowIndex As Integer
    Private strButtonText As String
    Private buttonColumn As New DataGridViewButtonColumn()
    Private Sub frmDeleteMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim strSql As String

        If OpenConnection() = True Then
            strSql = "SELECT DISTINCT Category FROM Menu "
            da = New SqlDataAdapter(strSql, conn)
            ds.Clear()
            da.Fill(ds, "Menu")
            If ds.Tables("Menu").Rows.Count > 0 Then
                PopulateComboBox()
            End If
            CloseConnection()
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub PopulateComboBox()
        cboSelectCategory.Items.Clear()
        cboSelectArchiveMode.Items.Clear()
        For Each row As DataRow In ds.Tables("Menu").Rows
            ' Assuming "Category" is the column name, adjust accordingly
            Dim strCategoryValue As String = row("Category").ToString()
            cboSelectCategory.Items.Add(strCategoryValue)
        Next
        cboSelectArchiveMode.Items.Add("Is Archive")
        cboSelectArchiveMode.Items.Add("Not Archive")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim selectedCategory As String = cboSelectCategory.SelectedItem?.ToString()
        Dim selectedArchiveMode As String = cboSelectArchiveMode.SelectedItem?.ToString()

        ' Check if both combo boxes have a selected value
        If Not String.IsNullOrEmpty(selectedCategory) AndAlso Not String.IsNullOrEmpty(selectedArchiveMode) Then
            ' Clear existing data in the DataGridView
            dgvCuisine.DataSource = Nothing
            dgvCuisine.Columns.Clear()

            LoadCuisineData(selectedCategory, selectedArchiveMode)
        Else
            ' If either of the combo boxes doesn't have a selected value, you can display a message or take appropriate action.
            MessageBox.Show("Please select values from both combo boxes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'LOAD CUISINE DATA AT DATA GRID VIEW'
    Private Sub LoadCuisineData(category As String, strArchiveMode As String)
        If OpenConnection() = True Then
            strArchiveMode = If(strArchiveMode = "Is Archive", "Archived", "Unarchive")
            Dim strSql As String = "SELECT Id,Name,Description,Price,Category,[Group] FROM Menu WHERE Category = @Category And Archive = @Archive"
            da = New SqlDataAdapter(strSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@Category", category)
            da.SelectCommand.Parameters.AddWithValue("@Archive", strArchiveMode)
            ds.Clear()
            da.Fill(ds, "CuisineData")
            dgvCuisine.DataSource = ds.Tables("CuisineData")
            dgvCuisine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            buttonColumn.HeaderText = "Action"
            If strArchiveMode = "Archived" Then
                buttonColumn.Text = "Unarchive"
            Else
                buttonColumn.Text = "Archived"
            End If
            strButtonText = buttonColumn.Text
            buttonColumn.Name = "btnColumn"
            buttonColumn.UseColumnTextForButtonValue = True ' Makes the button display text in the header
            dgvCuisine.Columns.Add(buttonColumn)
            CloseConnection()
            lblCountForCuisine.Text = ds.Tables("CuisineData").Rows.Count.ToString("0 record(s)")
        Else
            MessageBox.Show("Error in connecting to database server", "Error", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub ShowPopOutForm(id As String, cuisineName As String, cuisineDescription As String, cuisinePrice As Decimal)
        Dim strTitle As New Label()
        Dim lblCuisineName As New Label()
        Dim lblCuisinePrice As New Label()
        Dim closeButton As New Label()
        Dim btnDelete As New Button()
        Dim btnArchive As New Button()

        frmPopOut = New Form()
        With frmPopOut
            .Size = New Size(550, 300)
            .StartPosition = FormStartPosition.CenterScreen
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .BackgroundImage = My.Resources.addMenuBckgrd
            .BackgroundImageLayout = ImageLayout.Stretch
            .MaximizeBox = False
        End With

        With strTitle
            .Text = " * Select Your Choice (Archive / Unarchive) *"
            .ForeColor = Color.FromArgb(183, 4, 4)
            .Font = New Font("Arial", 14, FontStyle.Bold)
            .AutoSize = True
            .Location = New Point(80, 55)
            .BackColor = Color.Transparent
        End With
        frmPopOut.Controls.Add(strTitle)

        With lblCuisineName
            .Text = "Cuisine Name: " & cuisineName
            .Font = New Font("MV Boli", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Point(120, strTitle.Bottom + 50) ' Adjust the location as needed
            .BackColor = Color.Transparent
        End With
        frmPopOut.Controls.Add(lblCuisineName)

        With lblCuisinePrice
            .Text = "Price: RM" & cuisinePrice.ToString("0.00")
            .Font = New Font("MV Boli", 10, FontStyle.Bold)
            .AutoSize = True
            .Location = New Point(120, lblCuisineName.Bottom + 10) ' Adjust the location as needed
            .BackColor = Color.Transparent
        End With
        frmPopOut.Controls.Add(lblCuisinePrice)

        With closeButton
            .Text = "X"
            .Font = New Font("Ravie", 13, FontStyle.Bold)
            .ForeColor = Color.FromArgb(183, 4, 4)
            .AutoSize = True
            .Location = New Point(frmPopOut.Width - 25, 0)
            .Cursor = Cursors.Hand
            .BackColor = Color.Gold
        End With
        AddHandler closeButton.Click, Sub(sender As Object, e As EventArgs)
                                          frmPopOut.Close()
                                      End Sub
        frmPopOut.Controls.Add(closeButton)

        With btnArchive
            .Text = If(buttonColumn.Text = "Archived", "Unarchive", "Archive")
            '.Text = "Archive"
            .Font = New Font("Mistral", 13, FontStyle.Bold)
            .Size = New Size(95, 35)
            .Location = New Point(btnArchive.Width + 200, btnArchive.Height + 190)
            .Visible = True
        End With
        frmPopOut.Controls.Add(btnArchive)
        AddHandler btnArchive.Click, AddressOf btnArchive_Click
        frmPopOut.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmPopOut.ShowDialog()
    End Sub
    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        Dim strArchive As String = strButtonText
        Dim MySqlCommand As New SqlCommand
        Dim cuisineId As String = CStr(dgvCuisine.Rows(intRowIndex).Cells("Id").Value)

        If MessageBox.Show("Are you sure you want to [" & strArchive & "] this cuisine?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If OpenConnection() Then
                Dim strSql As String = "UPDATE Menu SET Archive = @Archieve WHERE Id = @Id"
                MySqlCommand = New SqlCommand(strSql, conn)
                MySqlCommand.Parameters.AddWithValue("@Id", cuisineId)
                MySqlCommand.Parameters.AddWithValue("@Archieve", strArchive)
                MySqlCommand.ExecuteNonQuery()
                MessageBox.Show("Cuisine:  [" & cuisineId & "] " & strButtonText & " successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConnection()
                frmPopOut.Close()
            Else
                MessageBox.Show("Error in connecting to the database server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            RefreshData()
        End If
    End Sub
    Private Sub ShowPopOutForm_FormClosed(sender As Object, e As FormClosedEventArgs)
        frmPopOut.Hide()
    End Sub
    Private Sub dgvCuisine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuisine.CellContentClick
        If e.ColumnIndex = dgvCuisine.Columns("btnColumn").Index AndAlso e.RowIndex >= 0 Then
            intRowIndex = e.RowIndex
            Dim strId As String = CStr(dgvCuisine.Rows(intRowIndex).Cells(0).Value) 'cell = column
            Dim strCuisineName As String = CStr(dgvCuisine.Rows(intRowIndex).Cells("Name").Value)
            Dim strCuisineDescription As String = CStr(dgvCuisine.Rows(intRowIndex).Cells("Description").Value)
            Dim decCuisinePrice As Decimal = CDec(dgvCuisine.Rows(intRowIndex).Cells("Price").Value)
            ShowPopOutForm(strId, strCuisineName, strCuisineDescription, decCuisinePrice)
        End If
    End Sub
    Private Sub RefreshData()
        dgvCuisine.DataSource = Nothing
        dgvCuisine.Columns.Clear()
        cboSelectCategory.SelectedIndex = -1
        cboSelectArchiveMode.SelectedIndex = -1
    End Sub
End Class