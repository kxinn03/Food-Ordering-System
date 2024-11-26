Imports System.Data.SqlClient
Imports System.IO
Public Class member_profile
    Friend strLoggedInMemberName As String
    Friend strLoggedInMemberUsername As String
    Friend strLoggedInMemberEmail As String
    Friend strLoggedInMemberGender As String
    Friend strLoggedInMemberBirthDate As String
    Friend strLoggedInMemberPhoneNo As String
    Public Sub member_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Debug.WriteLine(strLoggedInMemberUsername)
        rBtnProfile.Image = My.Resources.profileIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        rBtnPoints.Image = My.Resources.reward__1_.GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)
        rBtnRedeem.Image = My.Resources.box__3_.GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)
        rBtnLogout.Image = My.Resources.logoutIcon.GetThumbnailImage(85, 85, Nothing, IntPtr.Zero)
        rBtnMenu.Image = My.Resources.menuIcon.GetThumbnailImage(60, 60, Nothing, IntPtr.Zero)
        RoundButton1.Image = My.Resources.feedback__1_.GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)

        ' Load profile data
        LoadProfileData()
        ' Load profile picture
        LoadProfilePictureFromDatabase()
    End Sub
    Public Sub LoadProfileData()
        ' Load profile data from the database
        OpenConnection()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        ' Retrieve the profile data from the database
        strSql = "SELECT Name, Email, PhoneNumber, Gender, BirthDate FROM Member WHERE Username = @Username"
        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Username", strLoggedInMemberUsername)

        Using reader As SqlDataReader = MySqlCommand.ExecuteReader()
            If reader.Read() Then
                strLoggedInMemberName = reader("Name").ToString()
                strLoggedInMemberEmail = reader("Email").ToString()
                strLoggedInMemberPhoneNo = reader("PhoneNumber").ToString()
                If Not reader.IsDBNull(reader.GetOrdinal("Gender")) Then
                    strLoggedInMemberGender = reader("Gender").ToString()
                Else
                    strLoggedInMemberGender = "Unknown"
                End If

                If Not reader.IsDBNull(reader.GetOrdinal("BirthDate")) Then
                    strLoggedInMemberBirthDate = reader("BirthDate").ToShortDateString()
                Else
                    strLoggedInMemberBirthDate = "Unknown"
                End If

                ' Update the UI
                lblName.Text = strLoggedInMemberName
                lblUsername.Text = strLoggedInMemberUsername
                lblEmail.Text = strLoggedInMemberEmail
                lblPhoneNumber.Text = strLoggedInMemberPhoneNo
                lblGender.Text = strLoggedInMemberGender
                lblBirthDate.Text = strLoggedInMemberBirthDate
            End If
            CloseConnection()
        End Using

        ' Load profile picture
        LoadProfilePictureFromDatabase()
    End Sub

    Private Sub LoadProfilePictureFromDatabase()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String
        OpenConnection()


        ' Retrieve the image from the database
        strSql = "SELECT ProfileImage FROM Member WHERE Username = @Username"

        MySqlCommand = New SqlCommand(strSql, conn)
        MySqlCommand.Parameters.AddWithValue("@Username", strLoggedInMemberUsername)

        Dim imageData As Byte() = TryCast(MySqlCommand.ExecuteScalar(), Byte())

        If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
            ' Convert the byte array back to an Image and set it to the PictureBox
            Using stream As New MemoryStream(imageData)
                picProfile.Image = Image.FromStream(stream)
            End Using
        End If
        CloseConnection()

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
        MySqlCommand.Parameters.AddWithValue("@Username", strLoggedInMemberUsername)

        MySqlCommand.ExecuteNonQuery()
        CloseConnection()
    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        edit_profile.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnProfile_Click(sender As Object, e As EventArgs) Handles rBtnProfile.Click
        MessageBox.Show("You Are On This Page", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub rBtnRedeem_Click(sender As Object, e As EventArgs) Handles rBtnRedeem.Click
        redeem_product.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnLogout_Click(sender As Object, e As EventArgs) Handles rBtnLogout.Click
        strLoggedInMemberName = ""
        strLoggedInMemberUsername = ""
        strLoggedInMemberEmail = ""
        strLoggedInMemberGender = ""
        strLoggedInMemberBirthDate = ""
        strLoggedInMemberPhoneNo = ""
        MainPage.Show()
        Me.Close()
    End Sub

    Private Sub rBtnPoints_Click(sender As Object, e As EventArgs) Handles rBtnPoints.Click
        points.Show()
        Me.Hide()
    End Sub

    Private Sub rBtnMenu_Click(sender As Object, e As EventArgs) Handles rBtnMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub

    Private Sub RoundButton1_Click(sender As Object, e As EventArgs) Handles RoundButton1.Click
        feedback.Show()
        Me.Hide()
    End Sub
End Class