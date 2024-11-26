<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class testaddcart
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
        Me.lblMushroom = New System.Windows.Forms.LinkLabel()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.numQuantity2 = New System.Windows.Forms.NumericUpDown()
        Me.lblTomato = New System.Windows.Forms.LinkLabel()
        Me.PriceTomato = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        CType(Me.numQuantity2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMushroom
        '
        Me.lblMushroom.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblMushroom.AutoSize = True
        Me.lblMushroom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMushroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMushroom.LinkColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblMushroom.Location = New System.Drawing.Point(184, 173)
        Me.lblMushroom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMushroom.Name = "lblMushroom"
        Me.lblMushroom.Size = New System.Drawing.Size(120, 18)
        Me.lblMushroom.TabIndex = 61
        Me.lblMushroom.TabStop = True
        Me.lblMushroom.Text = "Mushroom Soup"
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(466, 176)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(75, 20)
        Me.lblPrice.TabIndex = 62
        Me.lblPrice.Text = "RM 6.90"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(396, 174)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(396, 262)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'numQuantity2
        '
        Me.numQuantity2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.numQuantity2.Location = New System.Drawing.Point(327, 267)
        Me.numQuantity2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 27)
        Me.numQuantity2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numQuantity2.Name = "numQuantity2"
        Me.numQuantity2.Size = New System.Drawing.Size(52, 20)
        Me.numQuantity2.TabIndex = 64
        Me.numQuantity2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numQuantity2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTomato
        '
        Me.lblTomato.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblTomato.AutoSize = True
        Me.lblTomato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTomato.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTomato.LinkColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblTomato.Location = New System.Drawing.Point(184, 262)
        Me.lblTomato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTomato.Name = "lblTomato"
        Me.lblTomato.Size = New System.Drawing.Size(99, 18)
        Me.lblTomato.TabIndex = 66
        Me.lblTomato.TabStop = True
        Me.lblTomato.Text = "Tomato Soup"
        '
        'PriceTomato
        '
        Me.PriceTomato.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTomato.Location = New System.Drawing.Point(466, 265)
        Me.PriceTomato.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PriceTomato.Name = "PriceTomato"
        Me.PriceTomato.Size = New System.Drawing.Size(75, 20)
        Me.PriceTomato.TabIndex = 67
        Me.PriceTomato.Text = "RM 10"
        '
        'PictureBox1
        '

        Me.PictureBox1.Location = New System.Drawing.Point(84, 235)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '

        Me.PictureBox4.Location = New System.Drawing.Point(84, 146)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 74)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 60
        Me.PictureBox4.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(485, 123)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 19)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(333, 174)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(0, 13)
        Me.lblQuantity.TabIndex = 70
        '
        'testaddcart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.numQuantity2)
        Me.Controls.Add(Me.lblTomato)
        Me.Controls.Add(Me.PriceTomato)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblMushroom)
        Me.Controls.Add(Me.lblPrice)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "testaddcart"
        Me.Text = "testaddcart"
        CType(Me.numQuantity2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblMushroom As LinkLabel
    Friend WithEvents lblPrice As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents numQuantity2 As NumericUpDown
    Friend WithEvents lblTomato As LinkLabel
    Friend WithEvents PriceTomato As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblQuantity As Label
End Class
