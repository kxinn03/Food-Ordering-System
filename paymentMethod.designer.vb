<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class paymentMethod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paymentMethod))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLeastTime = New System.Windows.Forms.Label()
        Me.lblLeast = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picLeast = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMostTime = New System.Windows.Forms.Label()
        Me.lblMost = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picMost = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvPaymentMethod = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.paymentMethod2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalMethodUse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picLeast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picMost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPaymentMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLeastTime)
        Me.GroupBox2.Controls.Add(Me.lblLeast)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.picLeast)
        Me.GroupBox2.Location = New System.Drawing.Point(1554, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 433)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'lblLeastTime
        '
        Me.lblLeastTime.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeastTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblLeastTime.Location = New System.Drawing.Point(37, 361)
        Me.lblLeastTime.Name = "lblLeastTime"
        Me.lblLeastTime.Size = New System.Drawing.Size(316, 40)
        Me.lblLeastTime.TabIndex = 24
        Me.lblLeastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeast
        '
        Me.lblLeast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLeast.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeast.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblLeast.Location = New System.Drawing.Point(20, 273)
        Me.lblLeast.Name = "lblLeast"
        Me.lblLeast.Size = New System.Drawing.Size(344, 117)
        Me.lblLeast.TabIndex = 13
        Me.lblLeast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(96, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 55)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Least Used"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLeast
        '
        Me.picLeast.Location = New System.Drawing.Point(82, 91)
        Me.picLeast.Name = "picLeast"
        Me.picLeast.Size = New System.Drawing.Size(244, 157)
        Me.picLeast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeast.TabIndex = 1
        Me.picLeast.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMostTime)
        Me.GroupBox1.Controls.Add(Me.lblMost)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.picMost)
        Me.GroupBox1.Location = New System.Drawing.Point(1131, 360)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 435)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'lblMostTime
        '
        Me.lblMostTime.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblMostTime.Location = New System.Drawing.Point(37, 363)
        Me.lblMostTime.Name = "lblMostTime"
        Me.lblMostTime.Size = New System.Drawing.Size(316, 40)
        Me.lblMostTime.TabIndex = 23
        Me.lblMostTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMost
        '
        Me.lblMost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMost.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMost.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblMost.Location = New System.Drawing.Point(20, 275)
        Me.lblMost.Name = "lblMost"
        Me.lblMost.Size = New System.Drawing.Size(344, 117)
        Me.lblMost.TabIndex = 12
        Me.lblMost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(116, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 55)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Most Used"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picMost
        '
        Me.picMost.Location = New System.Drawing.Point(80, 93)
        Me.picMost.Name = "picMost"
        Me.picMost.Size = New System.Drawing.Size(244, 157)
        Me.picMost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMost.TabIndex = 0
        Me.picMost.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(697, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(688, 55)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Payment Method Report on Year"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-429, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(614, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Select Year:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(236, 316)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(212, 24)
        Me.cboYear.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(843, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(614, 55)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Anything you need is here : --- MINIMOO restaurant"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(941, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 55)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "MINIMOO Restaurant"
        '
        'dgvPaymentMethod
        '
        Me.dgvPaymentMethod.AllowUserToAddRows = False
        Me.dgvPaymentMethod.AllowUserToDeleteRows = False
        Me.dgvPaymentMethod.AllowUserToResizeColumns = False
        Me.dgvPaymentMethod.AllowUserToResizeRows = False
        Me.dgvPaymentMethod.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.dgvPaymentMethod.ColumnHeadersHeight = 40
        Me.dgvPaymentMethod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.paymentMethod2, Me.totalPrice, Me.totalMethodUse})
        Me.dgvPaymentMethod.Location = New System.Drawing.Point(38, 360)
        Me.dgvPaymentMethod.Name = "dgvPaymentMethod"
        Me.dgvPaymentMethod.ReadOnly = True
        Me.dgvPaymentMethod.RowHeadersWidth = 100
        Me.dgvPaymentMethod.RowTemplate.Height = 24
        Me.dgvPaymentMethod.Size = New System.Drawing.Size(1064, 613)
        Me.dgvPaymentMethod.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FoodOrderingSystem.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(908, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(939, 779)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(333, 53)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(1339, 779)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(333, 53)
        Me.btnPrint.TabIndex = 23
        Me.btnPrint.Text = "Print Payment Method Report"
        Me.btnPrint.UseVisualStyleBackColor = False
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
        Me.dlgPreview.Name = "PrintPreviewDialog1"
        Me.dlgPreview.UseAntiAlias = True
        Me.dlgPreview.Visible = False
        '
        'paymentMethod2
        '
        Me.paymentMethod2.HeaderText = "Payment Method"
        Me.paymentMethod2.MinimumWidth = 6
        Me.paymentMethod2.Name = "paymentMethod2"
        Me.paymentMethod2.ReadOnly = True
        Me.paymentMethod2.Width = 250
        '
        'totalPrice
        '
        Me.totalPrice.HeaderText = "Total Transaction "
        Me.totalPrice.MinimumWidth = 6
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        Me.totalPrice.Width = 250
        '
        'totalMethodUse
        '
        Me.totalMethodUse.HeaderText = "Total Used (Payment Method)"
        Me.totalMethodUse.MinimumWidth = 6
        Me.totalMethodUse.Name = "totalMethodUse"
        Me.totalMethodUse.ReadOnly = True
        Me.totalMethodUse.Width = 250
        '
        'paymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvPaymentMethod)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.Label4)
        Me.Name = "paymentMethod"
        Me.Text = "paymentMethod"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picLeast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picMost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPaymentMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents picLeast As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMost As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picMost As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvPaymentMethod As DataGridView
    Friend WithEvents lblLeast As Label
    Friend WithEvents lblMostTime As Label
    Friend WithEvents lblLeastTime As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents paymentMethod2 As DataGridViewTextBoxColumn
    Friend WithEvents totalPrice As DataGridViewTextBoxColumn
    Friend WithEvents totalMethodUse As DataGridViewTextBoxColumn
End Class
