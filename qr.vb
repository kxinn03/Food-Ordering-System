Imports RestSharp
Imports Newtonsoft.Json.Linq
Imports QRCoder

Public Class qr

    Private Sub qr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim transactionInfo As String = $"✔ TRANSACTION SUCCESSFULLY ✔" &
                                     $"RM {Form1.decFinalTotal}" &
                                        $"Receiver:MINIMOO Restaurant" &
                                        $"Sender:{member_profile.strLoggedInMemberName}" &
                                        $"Remark: Food" &
                                        $"Date: {DateTime.Now.ToShortDateString()}{vbCrLf}" &
                                        $"Time: {DateTime.Now.ToShortTimeString()}"

        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(transactionInfo, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(3)

        ' Display the QR code in a PictureBox
        picQR.Image = qrCodeImage
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        successful.ShowDialog()
    End Sub
End Class