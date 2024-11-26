Imports System.Data.SqlClient

Public Class feedback
    Private Sub feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Id As String = GetUserIdByUsername(member_login.strUsername)

        staryes1.Visible = False
        staryes2.Visible = False
        staryes3.Visible = False
        staryes4.Visible = False
        staryes5.Visible = False
        CheckUserFeedbackStatus(Id)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles starno1.Click
        starno1.Visible = False
        staryes1.Visible = True
        starno2.Visible = True
        staryes2.Visible = False
        starno3.Visible = True
        staryes3.Visible = False
        starno4.Visible = True
        staryes4.Visible = False
        starno5.Visible = True
        staryes5.Visible = False

    End Sub

    Private Sub nostar2_Click(sender As Object, e As EventArgs) Handles starno2.Click
        starno1.Visible = False
        staryes1.Visible = True
        starno2.Visible = False
        staryes2.Visible = True
        starno3.Visible = True
        staryes3.Visible = False
        starno4.Visible = True
        staryes4.Visible = False
        starno5.Visible = True
        staryes5.Visible = False

    End Sub

    Private Sub staryes1_Click(sender As Object, e As EventArgs) Handles staryes1.Click
        staryes1.Visible = True
        starno1.Visible = False
        staryes2.Visible = False
        starno2.Visible = True
        staryes3.Visible = False
        starno3.Visible = True
        staryes4.Visible = False
        starno4.Visible = True
        staryes5.Visible = False
        starno5.Visible = True


    End Sub

    Private Sub starno3_Click(sender As Object, e As EventArgs) Handles starno3.Click
        starno1.Visible = False
        staryes1.Visible = True
        starno2.Visible = False
        staryes2.Visible = True
        starno3.Visible = False
        staryes3.Visible = True
        starno4.Visible = True
        staryes4.Visible = False
        starno5.Visible = True
        staryes5.Visible = False
    End Sub

    Private Sub starno4_Click(sender As Object, e As EventArgs) Handles starno4.Click
        starno1.Visible = False
        staryes1.Visible = True
        starno2.Visible = False
        staryes2.Visible = True
        starno3.Visible = False
        staryes3.Visible = True
        starno4.Visible = False
        staryes4.Visible = True
        starno5.Visible = True
        staryes5.Visible = False
    End Sub

    Private Sub starno5_Click(sender As Object, e As EventArgs) Handles starno5.Click
        starno1.Visible = False
        staryes1.Visible = True
        starno2.Visible = False
        staryes2.Visible = True
        starno3.Visible = False
        staryes3.Visible = True
        starno4.Visible = False
        staryes4.Visible = True
        starno5.Visible = False
        staryes5.Visible = True
    End Sub

    Private Sub staryes5_Click(sender As Object, e As EventArgs) Handles staryes5.Click
        starno5.Visible = True
        staryes5.Visible = False
    End Sub

    Private Sub staryes2_Click(sender As Object, e As EventArgs) Handles staryes2.Click
        staryes1.Visible = True
        starno1.Visible = False
        staryes2.Visible = True
        starno2.Visible = False
        staryes3.Visible = False
        starno3.Visible = True
        staryes4.Visible = False
        starno4.Visible = True
        staryes5.Visible = False
        starno5.Visible = True
    End Sub

    Private Sub staryes3_Click(sender As Object, e As EventArgs) Handles staryes3.Click
        staryes1.Visible = True
        starno1.Visible = False
        staryes2.Visible = True
        starno2.Visible = False
        staryes3.Visible = True
        starno3.Visible = False
        staryes4.Visible = False
        starno4.Visible = True
        staryes5.Visible = False
        starno5.Visible = True
    End Sub

    Private Sub staryes4_Click(sender As Object, e As EventArgs) Handles staryes4.Click
        staryes1.Visible = True
        starno1.Visible = False
        staryes2.Visible = True
        starno2.Visible = False
        staryes3.Visible = True
        starno3.Visible = False
        staryes4.Visible = True
        starno4.Visible = False
        staryes5.Visible = False
        starno5.Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Id As String = GetUserIdByUsername(member_login.strUsername)
        If txtsuggest.Text = "" Then
            MessageBox.Show("Suggestion Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf staryes1.Visible = False Then
            MessageBox.Show("Please Rate Us", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SubmitFeedback(Id)
        End If

    End Sub
    Private Function HasUserGivenFeedback(Id As String) As Boolean
        Dim hasGivenFeedback As Boolean = False
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim query As String = "SELECT feedback FROM Member WHERE Id = @Id"
                Using cmd As New SqlCommand(query, ModuleDatabase.conn)

                    cmd.Parameters.AddWithValue("@Id", Id)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        hasGivenFeedback = Convert.ToBoolean(result)
                    End If
                End Using

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try

        Return hasGivenFeedback
    End Function

    Private Sub UpdateFeedbackStatus(Id As String)
        Try
            If ModuleDatabase.OpenConnection() Then
                Dim updateQuery As String = "UPDATE Member SET feedback = 1 WHERE Id = @Id"
                Using cmd As New SqlCommand(updateQuery, ModuleDatabase.conn)
                    cmd.Parameters.AddWithValue("@Id", Id) ' Use "@Id" as the parameter name
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ModuleDatabase.CloseConnection()
        End Try
    End Sub



    Private Sub CheckUserFeedbackStatus(Id As String)
        Dim hasGivenFeedback As Boolean = HasUserGivenFeedback(Id)
        If hasGivenFeedback Then
            Panel1.Enabled = False

            MessageBox.Show("You've already given feedback. Thank you!", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Panel1.Enabled = True
        End If
    End Sub


    Private Sub SubmitFeedback(Id As String)

        UpdateFeedbackStatus(Id)
        MessageBox.Show("Thank you! You get a voucher ( code: feedback50 )", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub txtsuggest_TextChanged(sender As Object, e As EventArgs) Handles txtsuggest.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
    Private Function GetUserIdByUsername(username As String) As String
        Dim strId As String = ""

        Try
            OpenConnection()
            Dim query As String = "SELECT Id FROM Member WHERE Username = @Username"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    strId = reader("Id").ToString()
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving UserID from the database: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return strId
    End Function
End Class