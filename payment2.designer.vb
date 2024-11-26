<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payment2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment2))
        Me.lblCardNumber = New System.Windows.Forms.Label()
        Me.radEWallet = New System.Windows.Forms.RadioButton()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.radCard = New System.Windows.Forms.RadioButton()
        Me.picCard = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lblRoundingAdjustment = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblServiceCharge = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mskCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picWarning5 = New System.Windows.Forms.PictureBox()
        Me.picWarning4 = New System.Windows.Forms.PictureBox()
        Me.picWarning2 = New System.Windows.Forms.PictureBox()
        Me.picWarning3 = New System.Windows.Forms.PictureBox()
        Me.picWarning = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.mskYear = New System.Windows.Forms.MaskedTextBox()
        Me.mskMonth = New System.Windows.Forms.MaskedTextBox()
        Me.mskHolderName = New System.Windows.Forms.MaskedTextBox()
        Me.lblCVC = New System.Windows.Forms.Label()
        Me.mskCVC = New System.Windows.Forms.MaskedTextBox()
        Me.radPayHere = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.grpMethod = New System.Windows.Forms.GroupBox()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSummary.SuspendLayout()
        CType(Me.picWarning5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarning4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarning2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarning3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMethod.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCardNumber
        '
        Me.lblCardNumber.AutoSize = True
        Me.lblCardNumber.BackColor = System.Drawing.Color.White
        Me.lblCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNumber.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblCardNumber.Location = New System.Drawing.Point(45, 127)
        Me.lblCardNumber.Name = "lblCardNumber"
        Me.lblCardNumber.Size = New System.Drawing.Size(120, 20)
        Me.lblCardNumber.TabIndex = 44
        Me.lblCardNumber.Text = "Card Number"
        '
        'radEWallet
        '
        Me.radEWallet.AutoSize = True
        Me.radEWallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEWallet.Location = New System.Drawing.Point(285, 3)
        Me.radEWallet.Name = "radEWallet"
        Me.radEWallet.Size = New System.Drawing.Size(116, 29)
        Me.radEWallet.TabIndex = 37
        Me.radEWallet.TabStop = True
        Me.radEWallet.Text = "E-Wallet"
        Me.radEWallet.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(1751, 177)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(131, 38)
        Me.Label29.TabIndex = 78
        Me.Label29.Text = "Checkout"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(414, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 38)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Menu"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(1107, 177)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(131, 38)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "Cart"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.FoodOrderingSystem.My.Resources.Resources.two_removebg_preview
        Me.PictureBox7.Location = New System.Drawing.Point(1145, 127)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(49, 48)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 74
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.FoodOrderingSystem.My.Resources.Resources.one_removebg_preview
        Me.PictureBox8.Location = New System.Drawing.Point(455, 127)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(49, 48)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 73
        Me.PictureBox8.TabStop = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label23.ForeColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(-2, 141)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(1841, 12)
        Me.Label23.TabIndex = 72
        '
        'radCard
        '
        Me.radCard.AutoSize = True
        Me.radCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCard.Location = New System.Drawing.Point(3, 3)
        Me.radCard.Name = "radCard"
        Me.radCard.Size = New System.Drawing.Size(213, 29)
        Me.radCard.TabIndex = 36
        Me.radCard.TabStop = True
        Me.radCard.Text = "Credit / Debit Card"
        Me.radCard.UseVisualStyleBackColor = True
        '
        'picCard
        '
        Me.picCard.Image = Global.FoodOrderingSystem.My.Resources.Resources.card
        Me.picCard.Location = New System.Drawing.Point(-18, 42)
        Me.picCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(482, 234)
        Me.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard.TabIndex = 40
        Me.picCard.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(316, 28)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Rounding Adjustment"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.FoodOrderingSystem.My.Resources.Resources.three_removebg_preview__1_
        Me.PictureBox3.Location = New System.Drawing.Point(1790, 127)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 67
        Me.PictureBox3.TabStop = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckout.Location = New System.Drawing.Point(1, 888)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(2082, 98)
        Me.btnCheckout.TabIndex = 79
        Me.btnCheckout.Text = "Place Order"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label16.Location = New System.Drawing.Point(128, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(643, 40)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Anything you need is here : --- MINIMOO restaurant"
        '
        'grpSummary
        '
        Me.grpSummary.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grpSummary.Controls.Add(Me.Label7)
        Me.grpSummary.Controls.Add(Me.lblRoundingAdjustment)
        Me.grpSummary.Controls.Add(Me.Label6)
        Me.grpSummary.Controls.Add(Me.lblPoints)
        Me.grpSummary.Controls.Add(Me.Label12)
        Me.grpSummary.Controls.Add(Me.lblTotal)
        Me.grpSummary.Controls.Add(Me.lblTax)
        Me.grpSummary.Controls.Add(Me.Label5)
        Me.grpSummary.Controls.Add(Me.lblServiceCharge)
        Me.grpSummary.Controls.Add(Me.Label18)
        Me.grpSummary.Controls.Add(Me.Label17)
        Me.grpSummary.Controls.Add(Me.lblDiscount)
        Me.grpSummary.Controls.Add(Me.Label14)
        Me.grpSummary.Controls.Add(Me.lblSubtotal)
        Me.grpSummary.Controls.Add(Me.Label9)
        Me.grpSummary.Controls.Add(Me.Panel2)
        Me.grpSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSummary.Location = New System.Drawing.Point(1052, 266)
        Me.grpSummary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpSummary.Size = New System.Drawing.Size(877, 567)
        Me.grpSummary.TabIndex = 69
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Order Summary"
        '
        'lblRoundingAdjustment
        '
        Me.lblRoundingAdjustment.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundingAdjustment.Location = New System.Drawing.Point(673, 436)
        Me.lblRoundingAdjustment.Name = "lblRoundingAdjustment"
        Me.lblRoundingAdjustment.Size = New System.Drawing.Size(173, 25)
        Me.lblRoundingAdjustment.TabIndex = 78
        Me.lblRoundingAdjustment.Text = "RM 0.42"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(86, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(707, 2)
        Me.Label6.TabIndex = 69
        '
        'lblPoints
        '
        Me.lblPoints.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPoints.Location = New System.Drawing.Point(668, 526)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(178, 25)
        Me.lblPoints.TabIndex = 68
        Me.lblPoints.Text = "points "
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(93, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(707, 2)
        Me.Label12.TabIndex = 31
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Bodoni MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(511, 491)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(276, 44)
        Me.lblTotal.TabIndex = 67
        Me.lblTotal.Text = "RM 8.01"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(673, 402)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(154, 25)
        Me.lblTax.TabIndex = 50
        Me.lblTax.Text = "RM 0.42"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 491)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(673, 44)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "TOTAL"
        '
        'lblServiceCharge
        '
        Me.lblServiceCharge.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharge.Location = New System.Drawing.Point(673, 370)
        Me.lblServiceCharge.Name = "lblServiceCharge"
        Me.lblServiceCharge.Size = New System.Drawing.Size(172, 25)
        Me.lblServiceCharge.TabIndex = 49
        Me.lblServiceCharge.Text = "RM 0.69"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(103, 399)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(304, 44)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Tax 6%"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(103, 365)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(304, 44)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Service Charge 10%"
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(673, 338)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(163, 25)
        Me.lblDiscount.TabIndex = 44
        Me.lblDiscount.Text = "RM 0"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(103, 331)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 44)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Discount"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(673, 302)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(163, 36)
        Me.lblSubtotal.TabIndex = 41
        Me.lblSubtotal.Text = "RM 6.90"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 44)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Subtotal"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(78, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 251)
        Me.Panel2.TabIndex = 80
        '
        'mskCardNumber
        '
        Me.mskCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCardNumber.ForeColor = System.Drawing.Color.DarkGray
        Me.mskCardNumber.Location = New System.Drawing.Point(35, 123)
        Me.mskCardNumber.Mask = "  0000-0000-0000-0000"
        Me.mskCardNumber.Name = "mskCardNumber"
        Me.mskCardNumber.Size = New System.Drawing.Size(279, 30)
        Me.mskCardNumber.TabIndex = 43
        Me.mskCardNumber.Text = "1"
        Me.mskCardNumber.ValidatingType = GetType(Date)
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Mistral", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label19.Location = New System.Drawing.Point(117, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(401, 141)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Checkout"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.left_removebg_preview__2_
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.ForeColor = System.Drawing.Color.Transparent
        Me.btnExit.Location = New System.Drawing.Point(31, 20)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 52)
        Me.btnExit.TabIndex = 66
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.LightGray
        Me.Label24.ForeColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(395, 141)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(1671, 12)
        Me.Label24.TabIndex = 76
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 0
        Me.ToolTip1.AutoPopDelay = 1000000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 0
        '
        'picWarning5
        '
        Me.picWarning5.Image = Global.FoodOrderingSystem.My.Resources.Resources.warning
        Me.picWarning5.Location = New System.Drawing.Point(407, 187)
        Me.picWarning5.Name = "picWarning5"
        Me.picWarning5.Size = New System.Drawing.Size(29, 27)
        Me.picWarning5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWarning5.TabIndex = 66
        Me.picWarning5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picWarning5, "Invalid Input")
        '
        'picWarning4
        '
        Me.picWarning4.Image = Global.FoodOrderingSystem.My.Resources.Resources.warning
        Me.picWarning4.Location = New System.Drawing.Point(179, 198)
        Me.picWarning4.Name = "picWarning4"
        Me.picWarning4.Size = New System.Drawing.Size(29, 27)
        Me.picWarning4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWarning4.TabIndex = 54
        Me.picWarning4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picWarning4, "Invalid Input")
        '
        'picWarning2
        '
        Me.picWarning2.Image = Global.FoodOrderingSystem.My.Resources.Resources.warning
        Me.picWarning2.Location = New System.Drawing.Point(284, 123)
        Me.picWarning2.Name = "picWarning2"
        Me.picWarning2.Size = New System.Drawing.Size(29, 27)
        Me.picWarning2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWarning2.TabIndex = 52
        Me.picWarning2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picWarning2, "Invalid Input")
        '
        'picWarning3
        '
        Me.picWarning3.Image = Global.FoodOrderingSystem.My.Resources.Resources.warning
        Me.picWarning3.Location = New System.Drawing.Point(82, 195)
        Me.picWarning3.Name = "picWarning3"
        Me.picWarning3.Size = New System.Drawing.Size(29, 27)
        Me.picWarning3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWarning3.TabIndex = 53
        Me.picWarning3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picWarning3, "Invalid Input")
        '
        'picWarning
        '
        Me.picWarning.Image = Global.FoodOrderingSystem.My.Resources.Resources.warning
        Me.picWarning.Location = New System.Drawing.Point(285, 77)
        Me.picWarning.Name = "picWarning"
        Me.picWarning.Size = New System.Drawing.Size(29, 27)
        Me.picWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWarning.TabIndex = 40
        Me.picWarning.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picWarning, "Invalid Input")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.picWarning5)
        Me.Panel1.Controls.Add(Me.picWarning4)
        Me.Panel1.Controls.Add(Me.picWarning3)
        Me.Panel1.Controls.Add(Me.picWarning2)
        Me.Panel1.Controls.Add(Me.picWarning)
        Me.Panel1.Controls.Add(Me.lblYear)
        Me.Panel1.Controls.Add(Me.lblMonth)
        Me.Panel1.Controls.Add(Me.mskYear)
        Me.Panel1.Controls.Add(Me.mskMonth)
        Me.Panel1.Controls.Add(Me.mskHolderName)
        Me.Panel1.Controls.Add(Me.lblCVC)
        Me.Panel1.Controls.Add(Me.mskCVC)
        Me.Panel1.Controls.Add(Me.lblCardNumber)
        Me.Panel1.Controls.Add(Me.mskCardNumber)
        Me.Panel1.Controls.Add(Me.radEWallet)
        Me.Panel1.Controls.Add(Me.radCard)
        Me.Panel1.Controls.Add(Me.picCard)
        Me.Panel1.Location = New System.Drawing.Point(191, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 285)
        Me.Panel1.TabIndex = 38
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.White
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblYear.Location = New System.Drawing.Point(142, 201)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(31, 20)
        Me.lblYear.TabIndex = 51
        Me.lblYear.Text = "YY"
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.White
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblMonth.Location = New System.Drawing.Point(39, 201)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(58, 20)
        Me.lblMonth.TabIndex = 50
        Me.lblMonth.Text = "MM"
        '
        'mskYear
        '
        Me.mskYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskYear.ForeColor = System.Drawing.Color.DarkGray
        Me.mskYear.Location = New System.Drawing.Point(138, 195)
        Me.mskYear.Mask = "00"
        Me.mskYear.Name = "mskYear"
        Me.mskYear.Size = New System.Drawing.Size(67, 30)
        Me.mskYear.TabIndex = 49
        Me.mskYear.Text = "1"
        Me.mskYear.ValidatingType = GetType(Date)
        '
        'mskMonth
        '
        Me.mskMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskMonth.ForeColor = System.Drawing.Color.DarkGray
        Me.mskMonth.Location = New System.Drawing.Point(35, 195)
        Me.mskMonth.Mask = "00"
        Me.mskMonth.Name = "mskMonth"
        Me.mskMonth.Size = New System.Drawing.Size(66, 30)
        Me.mskMonth.TabIndex = 48
        Me.mskMonth.Text = "1"
        Me.mskMonth.ValidatingType = GetType(Date)
        '
        'mskHolderName
        '
        Me.mskHolderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskHolderName.ForeColor = System.Drawing.Color.DarkGray
        Me.mskHolderName.Location = New System.Drawing.Point(35, 77)
        Me.mskHolderName.Name = "mskHolderName"
        Me.mskHolderName.Size = New System.Drawing.Size(278, 30)
        Me.mskHolderName.TabIndex = 47
        Me.mskHolderName.Text = "  Card Holder Name"
        Me.mskHolderName.ValidatingType = GetType(Date)
        '
        'lblCVC
        '
        Me.lblCVC.AutoSize = True
        Me.lblCVC.BackColor = System.Drawing.Color.White
        Me.lblCVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVC.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblCVC.Location = New System.Drawing.Point(354, 189)
        Me.lblCVC.Name = "lblCVC"
        Me.lblCVC.Size = New System.Drawing.Size(47, 20)
        Me.lblCVC.TabIndex = 46
        Me.lblCVC.Text = "CVC"
        '
        'mskCVC
        '
        Me.mskCVC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCVC.ForeColor = System.Drawing.Color.DarkGray
        Me.mskCVC.Location = New System.Drawing.Point(352, 185)
        Me.mskCVC.Mask = "000"
        Me.mskCVC.Name = "mskCVC"
        Me.mskCVC.Size = New System.Drawing.Size(72, 30)
        Me.mskCVC.TabIndex = 45
        Me.mskCVC.Text = "1"
        Me.mskCVC.ValidatingType = GetType(Date)
        '
        'radPayHere
        '
        Me.radPayHere.AutoSize = True
        Me.radPayHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPayHere.Location = New System.Drawing.Point(173, 175)
        Me.radPayHere.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radPayHere.Name = "radPayHere"
        Me.radPayHere.Size = New System.Drawing.Size(166, 30)
        Me.radPayHere.TabIndex = 31
        Me.radPayHere.TabStop = True
        Me.radPayHere.Text = "Pay at Here "
        Me.radPayHere.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(198, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 30)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cash"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FoodOrderingSystem.My.Resources.Resources.kisspng_arrow_button_clip_art_down_arrow_png_free_download_5a756e1962f122_5847451115176453374053_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(348, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.FoodOrderingSystem.My.Resources.Resources.onlinepay_removebg_preview
        Me.PictureBox5.Location = New System.Drawing.Point(38, 175)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(120, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.FoodOrderingSystem.My.Resources.Resources._2465177_200
        Me.PictureBox4.Location = New System.Drawing.Point(38, 52)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(120, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCash.Location = New System.Drawing.Point(174, 72)
        Me.radCash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(199, 30)
        Me.radCash.TabIndex = 0
        Me.radCash.TabStop = True
        Me.radCash.Text = "Pay at Counter "
        Me.radCash.UseVisualStyleBackColor = True
        '
        'grpMethod
        '
        Me.grpMethod.BackColor = System.Drawing.Color.White
        Me.grpMethod.Controls.Add(Me.PictureBox1)
        Me.grpMethod.Controls.Add(Me.PictureBox5)
        Me.grpMethod.Controls.Add(Me.PictureBox4)
        Me.grpMethod.Controls.Add(Me.radPayHere)
        Me.grpMethod.Controls.Add(Me.Label1)
        Me.grpMethod.Controls.Add(Me.radCash)
        Me.grpMethod.Controls.Add(Me.Panel1)
        Me.grpMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMethod.Location = New System.Drawing.Point(216, 266)
        Me.grpMethod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMethod.Name = "grpMethod"
        Me.grpMethod.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpMethod.Size = New System.Drawing.Size(661, 567)
        Me.grpMethod.TabIndex = 68
        Me.grpMethod.TabStop = False
        Me.grpMethod.Text = "Payment Method"
        '
        'doc
        '
        Me.doc.OriginAtMargins = True
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.UseAntiAlias = True
        Me.dlgPreview.Visible = False
        '
        'payment2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.backgrd
        Me.ClientSize = New System.Drawing.Size(1924, 974)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.grpMethod)
        Me.Name = "payment2"
        Me.Text = "payment2"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSummary.ResumeLayout(False)
        CType(Me.picWarning5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarning4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarning2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarning3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMethod.ResumeLayout(False)
        Me.grpMethod.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCardNumber As Label
    Friend WithEvents radEWallet As RadioButton
    Friend WithEvents Label29 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents radCard As RadioButton
    Friend WithEvents picCard As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents lblRoundingAdjustment As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblServiceCharge As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mskCardNumber As MaskedTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents picWarning5 As PictureBox
    Friend WithEvents picWarning4 As PictureBox
    Friend WithEvents picWarning2 As PictureBox
    Friend WithEvents picWarning3 As PictureBox
    Friend WithEvents picWarning As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents mskYear As MaskedTextBox
    Friend WithEvents mskMonth As MaskedTextBox
    Friend WithEvents mskHolderName As MaskedTextBox
    Friend WithEvents lblCVC As Label
    Friend WithEvents mskCVC As MaskedTextBox
    Friend WithEvents radPayHere As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents radCash As RadioButton
    Friend WithEvents grpMethod As GroupBox
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
