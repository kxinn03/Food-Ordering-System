
Imports System
Imports QRCoder

Public Class FrmRedeemQrCode
    Public RedeemQuantity As String
    Private Sub FrmRedeemQrCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Call a method to update the UI with the redeemed data
        GenerateQrCode()
    End Sub



    Private Sub GenerateQrCode()
        Dim RedeemName As String = FrmRedeemtion.strName
        Dim RedeemDetails As String = FrmRedeemtion.strDetails
        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode($"Name: {RedeemName}{Environment.NewLine}Details: {RedeemDetails}{Environment.NewLine}Quantity: {RedeemQuantity}", QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        PicQrCode.Image = code.GetGraphic(6)
    End Sub

    Private Sub FrmRedeemQrCode_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        redeem_product.Show()
    End Sub


End Class