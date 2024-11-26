Imports System.Data.SqlClient
Imports System.IO

Public Class testaddcart
    Friend strfoodName As String
    Friend intQuantity As Integer
    Friend decPrice As Decimal



    Private Sub AddToCart()
        Dim MySqlCommand As New SqlCommand
        Dim strSql As String

        OpenConnection()


        strSql = "INSERT INTO Food (foodID, foodName, foodQuantity, foodPrice, foodFlavour)Values(@foodID, @foodName, @foodQuantity, @foodPrice, @foodFlavour)"
        MySqlCommand = New SqlCommand(strSql, conn)
        With MySqlCommand

            .Parameters.AddWithValue("@foodID", "F002")
            .Parameters.AddWithValue("@foodName", lblTomato.Text)
            .Parameters.AddWithValue("@foodQuantity", numQuantity2.Value)
            .Parameters.AddWithValue("@foodPrice", PriceTomato.Text)
            .Parameters.AddWithValue("@foodFlavour", DBNull.Value)

        End With

        strSql = "INSERT INTO Cart (foodName, quantity, price, flavour)Values(@foodName, @quantity, @price, @flavour)"
        MySqlCommand = New SqlCommand(strSql, conn)
        With MySqlCommand

            .Parameters.AddWithValue("@foodName", lblTomato.Text)
            .Parameters.AddWithValue("@quantity", numQuantity2.Value)
            .Parameters.AddWithValue("@price", lblPrice.Text)
            .Parameters.AddWithValue("@flavour", DBNull.Value)

        End With
        MySqlCommand.ExecuteNonQuery()
        CloseConnection()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddToCart()
    End Sub

    Private Sub testaddcart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMushroom.Text = frmMenu.strFoodName
        lblQuantity.Text = frmMenu.decFoodPrice
        lblPrice.Text = frmMenu.intFoodQuantity
        PictureBox4.Image = frmMenu.foodPic
    End Sub
    Private Sub RetrieveFromDatabase(cartID As Integer)
        Try
            If ModuleDatabase.OpenConnection() Then
                ' Construct your SQL query to retrieve data based on the cartID
                Dim query As String = "SELECT TOP 1 food_name, food_price, food_quantity, food_image FROM Cart ORDER BY cartID ASC"

                Using command As New SqlCommand(query, ModuleDatabase.conn)
                    ' Set the parameter for the cartID
                    command.Parameters.AddWithValue("@cartID", cartID)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Read data from the database
                            Dim retrievedFoodName As String = reader.GetString(0)
                            Dim retrievedFoodPrice As Decimal = reader.GetDecimal(1)
                            Dim retrievedFoodQuantity As Integer = reader.GetInt32(2)
                            Dim retrievedFoodImageBytes As Byte() = CType(reader("food_image"), Byte())

                            ' Display retrieved data in respective labels
                            lblMushroom.Text = "Retrieved Food Name: " & retrievedFoodName
                            lblPrice.Text = "Retrieved Food Price: RM" & retrievedFoodPrice.ToString("0.00")
                            lblQuantity.Text = "Retrieved Food Quantity: " & retrievedFoodQuantity.ToString()

                            ' Convert the retrieved image bytes back to an Image
                            Dim retrievedFoodImage As Image = BytesToImage(retrievedFoodImageBytes)
                            PictureBox4.Image = retrievedFoodImage
                        Else
                            MessageBox.Show("No data found for the specified cartID.")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Error opening database connection.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving data from the database: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub




    Private Function BytesToImage(imageBytes As Byte()) As Image
        Using ms As New MemoryStream(imageBytes)
            Return Image.FromStream(ms)
        End Using
    End Function



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()

    End Sub

    Private Sub lblMushroom_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMushroom.LinkClicked

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class