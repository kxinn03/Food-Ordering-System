Imports System.Data.SqlClient
Imports System.IO
Imports System.Globalization
Public Class edit_profile
    Private Sub edit_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        rBtnProfile.Image = My.Resources.profileIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        rBtnPoints.Image = My.Resources.reward__1_.GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)
        rBtnRedeem.Image = My.Resources.box__3_.GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)
        rBtnLogout.Image = My.Resources.logoutIcon.GetThumbnailImage(85, 85, Nothing, IntPtr.Zero)
        rBtnMenu.Image = My.Resources.menuIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        RoundButton1.Image = My.Resources.feedback__1_.GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)
        txtName.Text = member_profile.strLoggedInMemberName
        txtUsername.Text = member_profile.strLoggedInMemberUsername
        txtEmail.Text = member_profile.strLoggedInMemberEmail
        txtPhoneNumber.Text = member_profile.strLoggedInMemberPhoneNo
        cboGender.SelectedItem = member_profile.strLoggedInMemberGender
        Dim birthdateString As String = GetBirthdateFromDatabase() ' Replace with your actual method to retrieve birthdate from the database

        If Not String.IsNullOrEmpty(birthdateString) Then
            ' Parse the birthdate string to a DateTime object
            Dim birthdate As DateTime
            If DateTime.TryParseExact(birthdateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, birthdate) Then
                ' Set the DateTimePicker value to the parsed birthdate
                DateTimePicker1.Value = birthdate
            Else
                ' Handle the case when parsing fails
                MessageBox.Show("Error parsing birthdate from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        LoadProfilePictureFromDatabase()
    End Sub

    Private Function GetBirthdateFromDatabase() As String
        Dim birthdate As String = String.Empty

        Try
            OpenConnection()

            Dim MySqlCommand As New SqlCommand
            Dim strSql As String = "SELECT ISNULL(CONVERT(VARCHAR(10), Birthdate, 103), '') FROM Member WHERE Username = @Username"

            MySqlCommand = New SqlCommand(strSql, conn)
            MySqlCommand.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)

            ' Execute the query and retrieve the birthdate
            Dim result As Object = MySqlCommand.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                birthdate = result.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving birthdate from the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        Return birthdate
    End Function

    Private Sub LoadProfilePictureFromDatabase()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        OpenConnection()


        ' Retrieve the image from the database
        strSql = "SELECT ProfileImage FROM Member WHERE Username = @Username"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)

        Dim imageData As Byte() = TryCast(MySqlCommand.ExecuteScalar(), Byte())

        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            ' Convert the byte array back to an Image and set it to the PictureBox
            Using stream As New MemoryStream(imageData)
                picProfile.Image = Image.FromStream(stream)
            End Using
        End If

    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif"
        openFileDialog.Title = "Select Profile Picture"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picProfile.Image = System.Drawing.Image.FromFile(openFileDialog.FileName)

            ' Save the image to the database
            SaveImageToDatabase(openFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveImageToDatabase(imagePath As String)
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        OpenConnection()

        ' Read the image file into a byte array
        Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)

        ' Update the MemberProfiles table with the new image
        strSql = "UPDATE Member SET ProfileImage = @ProfileImage WHERE Username = @Username"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@ProfileImage", imageBytes)
        MySqlCommand.Parameters.AddWithValue("@Username", member_profile.strLoggedInMemberUsername)

        MySqlCommand.ExecuteNonQuery()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newName As String = txtName.Text.Trim()
        Dim newEmail As String = txtEmail.Text.Trim()
        Dim newPhoneNumber As String = txtPhoneNumber.Text.Trim()
        Dim strNewUsername As String = txtUsername.Text.Trim()

        ' Check if a new gender is selected
        Dim strNewGender As String = If(cboGender.SelectedItem IsNot Nothing AndAlso cboGender.SelectedItem.ToString() <> "-1", cboGender.SelectedItem.ToString(), Nothing)

        ' Check if a new birthdate is selected
        Dim strNewBirthDate As String = If(DateTimePicker1.Checked, DateTimePicker1.Value.ToString("yyyy-MM-dd"), "Unknown")

        Try
            OpenConnection()
            Dim sqlCommand As New SqlCommand
            Dim strSql As String = "UPDATE Member SET Name = @Name, Username = @Username, Email = @Email, PhoneNumber = @PhoneNumber, Gender = @Gender, Birthdate = @Birthdate WHERE Username = @LoggedInUsername"

            sqlCommand = New SqlCommand(strSql, conn)
            sqlCommand.Parameters.AddWithValue("@Name", newName)
            sqlCommand.Parameters.AddWithValue("@Username", strNewUsername)
            sqlCommand.Parameters.AddWithValue("@Email", newEmail)
            sqlCommand.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber)

            ' Use a parameter with the correct data type for the gender
            If strNewGender IsNot Nothing Then
                sqlCommand.Parameters.AddWithValue("@Gender", strNewGender)
            Else
                sqlCommand.Parameters.AddWithValue("@Gender", DBNull.Value)
            End If

            ' Use a parameter with the correct data type for the date
            If strNewBirthDate <> "Unknown" Then
                sqlCommand.Parameters.Add("@Birthdate", SqlDbType.Date).Value = DateTime.Parse(strNewBirthDate)
            Else
                sqlCommand.Parameters.AddWithValue("@Birthdate", DBNull.Value)
            End If

            sqlCommand.Parameters.AddWithValue("@LoggedInUsername", member_profile.strLoggedInMemberUsername)

            ' Execute the update command
            sqlCommand.ExecuteNonQuery()

            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error updating profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        member_profile.Show()
        member_profile.LoadProfileData()
        Me.Hide()
    End Sub

    Private Function IsUsernameDuplicated(username As String) As Boolean
        Using db As New DBDataContext()
            Return db.Members.Any(Function(member) member.Username = username)
        End Using
    End Function

    Private Sub rBtnProfile_Click(sender As Object, e As EventArgs) Handles rBtnProfile.Click
        member_profile.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnRedeem_Click(sender As Object, e As EventArgs)
        redeem_product.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnLogout_Click(sender As Object, e As EventArgs)
        MainPage.Show()
        Me.Close()

    End Sub

    Private Sub rBtnPoints_Click(sender As Object, e As EventArgs)
        points.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnMenu_Click(sender As Object, e As EventArgs) Handles rBtnMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnLogout_Click_1(sender As Object, e As EventArgs) Handles rBtnLogout.Click
        feedback.Show()
        Me.Hide()
    End Sub
End Class