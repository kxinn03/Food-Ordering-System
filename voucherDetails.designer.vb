<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class voucherDetails
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblVoucherName = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Script MT Bold", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(-30, -8)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(399, 105)
        Me.lbl1.TabIndex = 17
        Me.lbl1.Text = "Vouchers Details"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(29, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 2)
        Me.Label1.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FoodOrderingSystem.My.Resources.Resources.fp2
        Me.PictureBox1.Location = New System.Drawing.Point(29, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'lblVoucherName
        '
        Me.lblVoucherName.BackColor = System.Drawing.Color.White
        Me.lblVoucherName.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoucherName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblVoucherName.Location = New System.Drawing.Point(116, 101)
        Me.lblVoucherName.Name = "lblVoucherName"
        Me.lblVoucherName.Size = New System.Drawing.Size(476, 44)
        Me.lblVoucherName.TabIndex = 80
        '
        'lblDetails
        '
        Me.lblDetails.BackColor = System.Drawing.Color.White
        Me.lblDetails.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.Color.Gray
        Me.lblDetails.Location = New System.Drawing.Point(116, 149)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(549, 108)
        Me.lblDetails.TabIndex = 83
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'voucherDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(677, 309)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblVoucherName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "voucherDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "voucherDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblVoucherName As Label
    Friend WithEvents lblDetails As Label
End Class
