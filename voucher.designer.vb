<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class voucher
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
        Me.txtVoucherCode = New System.Windows.Forms.RichTextBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.voucherPanel = New System.Windows.Forms.Panel()
        Me.pnlVoucherEatMore = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pivVoucherEatMore = New System.Windows.Forms.PictureBox()
        Me.pnlVoucherMember = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.picVoucherMember = New System.Windows.Forms.PictureBox()
        Me.pnlVoucherSide = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.picVoucherSide = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.voucherPanel.SuspendLayout()
        Me.pnlVoucherEatMore.SuspendLayout()
        CType(Me.pivVoucherEatMore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVoucherMember.SuspendLayout()
        CType(Me.picVoucherMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVoucherSide.SuspendLayout()
        CType(Me.picVoucherSide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Script MT Bold", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(292, -7)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(425, 115)
        Me.lbl1.TabIndex = 16
        Me.lbl1.Text = "Vouchers && Offers"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVoucherCode
        '
        Me.txtVoucherCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVoucherCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherCode.ForeColor = System.Drawing.Color.DarkGray
        Me.txtVoucherCode.Location = New System.Drawing.Point(137, 112)
        Me.txtVoucherCode.Name = "txtVoucherCode"
        Me.txtVoucherCode.Size = New System.Drawing.Size(571, 41)
        Me.txtVoucherCode.TabIndex = 60
        Me.txtVoucherCode.Text = "  Enter the voucher code"
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnApply.Location = New System.Drawing.Point(760, 111)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(0)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(151, 42)
        Me.btnApply.TabIndex = 61
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(44, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(290, 35)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Select a voucher"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(-2, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(977, 2)
        Me.Label1.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.voucherPanel)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 252)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(943, 640)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'voucherPanel
        '
        Me.voucherPanel.Controls.Add(Me.pnlVoucherEatMore)
        Me.voucherPanel.Controls.Add(Me.pnlVoucherMember)
        Me.voucherPanel.Controls.Add(Me.pnlVoucherSide)
        Me.voucherPanel.Location = New System.Drawing.Point(6, 21)
        Me.voucherPanel.Name = "voucherPanel"
        Me.voucherPanel.Size = New System.Drawing.Size(931, 596)
        Me.voucherPanel.TabIndex = 69
        '
        'pnlVoucherEatMore
        '
        Me.pnlVoucherEatMore.Controls.Add(Me.Label14)
        Me.pnlVoucherEatMore.Controls.Add(Me.Label7)
        Me.pnlVoucherEatMore.Controls.Add(Me.Label5)
        Me.pnlVoucherEatMore.Controls.Add(Me.LinkLabel4)
        Me.pnlVoucherEatMore.Controls.Add(Me.Label6)
        Me.pnlVoucherEatMore.Controls.Add(Me.pivVoucherEatMore)
        Me.pnlVoucherEatMore.Location = New System.Drawing.Point(71, 427)
        Me.pnlVoucherEatMore.Name = "pnlVoucherEatMore"
        Me.pnlVoucherEatMore.Size = New System.Drawing.Size(830, 231)
        Me.pnlVoucherEatMore.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(580, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(187, 21)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "code: moremore7"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(39, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(276, 44)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "  Min. spend RM 35.00"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(134, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 44)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "RM 7.00"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LinkLabel4.Location = New System.Drawing.Point(656, 118)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(92, 36)
        Me.LinkLabel4.TabIndex = 65
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Apply"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(134, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(393, 44)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "EAT MORE, SAVE MORE!"
        '
        'pivVoucherEatMore
        '
        Me.pivVoucherEatMore.Image = Global.FoodOrderingSystem.My.Resources.Resources.fp3
        Me.pivVoucherEatMore.Location = New System.Drawing.Point(5, 3)
        Me.pivVoucherEatMore.Name = "pivVoucherEatMore"
        Me.pivVoucherEatMore.Size = New System.Drawing.Size(786, 185)
        Me.pivVoucherEatMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pivVoucherEatMore.TabIndex = 71
        Me.pivVoucherEatMore.TabStop = False
        '
        'pnlVoucherMember
        '
        Me.pnlVoucherMember.Controls.Add(Me.Label8)
        Me.pnlVoucherMember.Controls.Add(Me.Label9)
        Me.pnlVoucherMember.Controls.Add(Me.LinkLabel3)
        Me.pnlVoucherMember.Controls.Add(Me.Label11)
        Me.pnlVoucherMember.Controls.Add(Me.Label12)
        Me.pnlVoucherMember.Controls.Add(Me.picVoucherMember)
        Me.pnlVoucherMember.Location = New System.Drawing.Point(71, 3)
        Me.pnlVoucherMember.Name = "pnlVoucherMember"
        Me.pnlVoucherMember.Size = New System.Drawing.Size(830, 206)
        Me.pnlVoucherMember.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(554, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 21)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "code: firstorder10"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(39, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(276, 44)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "  Min. spend RM 0.00"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(656, 123)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(92, 36)
        Me.LinkLabel3.TabIndex = 78
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Apply"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(134, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 44)
        Me.Label11.TabIndex = 80
        Me.Label11.Text = "RM 10.00"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(134, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(252, 44)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "FIRST ORDER!"
        '
        'picVoucherMember
        '
        Me.picVoucherMember.Image = Global.FoodOrderingSystem.My.Resources.Resources.fp3
        Me.picVoucherMember.Location = New System.Drawing.Point(5, 3)
        Me.picVoucherMember.Name = "picVoucherMember"
        Me.picVoucherMember.Size = New System.Drawing.Size(786, 185)
        Me.picVoucherMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVoucherMember.TabIndex = 81
        Me.picVoucherMember.TabStop = False
        '
        'pnlVoucherSide
        '
        Me.pnlVoucherSide.Controls.Add(Me.Label13)
        Me.pnlVoucherSide.Controls.Add(Me.Label3)
        Me.pnlVoucherSide.Controls.Add(Me.LinkLabel2)
        Me.pnlVoucherSide.Controls.Add(Me.Label2)
        Me.pnlVoucherSide.Controls.Add(Me.Label19)
        Me.pnlVoucherSide.Controls.Add(Me.picVoucherSide)
        Me.pnlVoucherSide.Location = New System.Drawing.Point(71, 215)
        Me.pnlVoucherSide.Name = "pnlVoucherSide"
        Me.pnlVoucherSide.Size = New System.Drawing.Size(830, 206)
        Me.pnlVoucherSide.TabIndex = 71
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(520, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(247, 21)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "code: goodday20"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(39, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 44)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "  Min. spend RM 15.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(656, 123)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(92, 36)
        Me.LinkLabel2.TabIndex = 78
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Apply"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(134, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 44)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "20% off"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(134, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(193, 44)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "GOOD DAY !"
        '
        'picVoucherSide
        '
        Me.picVoucherSide.Image = Global.FoodOrderingSystem.My.Resources.Resources.fp3
        Me.picVoucherSide.Location = New System.Drawing.Point(5, 3)
        Me.picVoucherSide.Name = "picVoucherSide"
        Me.picVoucherSide.Size = New System.Drawing.Size(786, 185)
        Me.picVoucherSide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVoucherSide.TabIndex = 81
        Me.picVoucherSide.TabStop = False
        '
        'voucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 1013)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.txtVoucherCode)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "voucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "voucher"
        Me.GroupBox1.ResumeLayout(False)
        Me.voucherPanel.ResumeLayout(False)
        Me.pnlVoucherEatMore.ResumeLayout(False)
        Me.pnlVoucherEatMore.PerformLayout()
        CType(Me.pivVoucherEatMore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVoucherMember.ResumeLayout(False)
        Me.pnlVoucherMember.PerformLayout()
        CType(Me.picVoucherMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVoucherSide.ResumeLayout(False)
        Me.pnlVoucherSide.PerformLayout()
        CType(Me.picVoucherSide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtVoucherCode As RichTextBox
    Friend WithEvents btnApply As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents voucherPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents pivVoucherEatMore As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlVoucherEatMore As Panel
    Friend WithEvents pnlVoucherMember As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents picVoucherMember As PictureBox
    Friend WithEvents pnlVoucherSide As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents picVoucherSide As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
End Class
