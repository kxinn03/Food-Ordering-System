<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRedeemtion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRedeemtion))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PicProduct = New System.Windows.Forms.PictureBox()
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(294, 244)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(176, 27)
        Me.lblName.TabIndex = 131
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDetails
        '
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(142, 290)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(472, 81)
        Me.lblDetails.TabIndex = 132
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoints
        '
        Me.lblPoints.BackColor = System.Drawing.Color.White
        Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblPoints.Location = New System.Drawing.Point(380, 202)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(100, 23)
        Me.lblPoints.TabIndex = 133
        Me.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtQuantity.Location = New System.Drawing.Point(343, 391)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(56, 32)
        Me.txtQuantity.TabIndex = 134
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.ForeColor = System.Drawing.Color.White
        Me.btnMinus.Location = New System.Drawing.Point(285, 388)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(45, 41)
        Me.btnMinus.TabIndex = 136
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.Color.White
        Me.btnPlus.Location = New System.Drawing.Point(411, 388)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(45, 41)
        Me.btnPlus.TabIndex = 139
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.White
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Image = Global.FoodOrderingSystem.My.Resources.Resources.check
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(207, 464)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(123, 49)
        Me.btnConfirm.TabIndex = 140
        Me.btnConfirm.Text = "Redeem"
        Me.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(430, 464)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 49)
        Me.btnCancel.TabIndex = 141
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PicProduct
        '
        Me.PicProduct.Location = New System.Drawing.Point(274, 33)
        Me.PicProduct.Name = "PicProduct"
        Me.PicProduct.Size = New System.Drawing.Size(206, 192)
        Me.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProduct.TabIndex = 0
        Me.PicProduct.TabStop = False
        '
        'FrmRedeemtion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 556)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PicProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmRedeemtion"
        Me.Text = "FrmRedeemtion"
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicProduct As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
End Class
