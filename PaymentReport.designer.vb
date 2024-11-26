<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvSalesReport = New System.Windows.Forms.DataGridView()
        Me.itemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalQuantitySold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalSales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBest = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picBest = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblWorst = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picWorst = New System.Windows.Forms.PictureBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvSalesReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picBest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picWorst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(944, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MINIMOO Restaurant"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(866, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(614, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Anything you need is here : --- MINIMOO restaurant"
        '
        'dgvSalesReport
        '
        Me.dgvSalesReport.AllowUserToAddRows = False
        Me.dgvSalesReport.AllowUserToDeleteRows = False
        Me.dgvSalesReport.AllowUserToResizeColumns = False
        Me.dgvSalesReport.AllowUserToResizeRows = False
        Me.dgvSalesReport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.dgvSalesReport.ColumnHeadersHeight = 40
        Me.dgvSalesReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemId, Me.itemName, Me.itemPrice, Me.totalQuantitySold, Me.totalSales})
        Me.dgvSalesReport.Location = New System.Drawing.Point(72, 406)
        Me.dgvSalesReport.Name = "dgvSalesReport"
        Me.dgvSalesReport.ReadOnly = True
        Me.dgvSalesReport.RowHeadersWidth = 100
        Me.dgvSalesReport.RowTemplate.Height = 24
        Me.dgvSalesReport.Size = New System.Drawing.Size(1002, 539)
        Me.dgvSalesReport.TabIndex = 4
        '
        'itemId
        '
        Me.itemId.HeaderText = "Food ID"
        Me.itemId.MinimumWidth = 6
        Me.itemId.Name = "itemId"
        Me.itemId.ReadOnly = True
        Me.itemId.Width = 120
        '
        'itemName
        '
        Me.itemName.HeaderText = "Food Name"
        Me.itemName.MinimumWidth = 6
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        Me.itemName.Width = 200
        '
        'itemPrice
        '
        Me.itemPrice.HeaderText = "Food Price"
        Me.itemPrice.MinimumWidth = 6
        Me.itemPrice.Name = "itemPrice"
        Me.itemPrice.ReadOnly = True
        Me.itemPrice.Width = 125
        '
        'totalQuantitySold
        '
        Me.totalQuantitySold.HeaderText = "Total Sold"
        Me.totalQuantitySold.MinimumWidth = 6
        Me.totalQuantitySold.Name = "totalQuantitySold"
        Me.totalQuantitySold.ReadOnly = True
        Me.totalQuantitySold.Width = 125
        '
        'totalSales
        '
        Me.totalSales.HeaderText = "Total Sales"
        Me.totalSales.MinimumWidth = 6
        Me.totalSales.Name = "totalSales"
        Me.totalSales.ReadOnly = True
        Me.totalSales.Width = 150
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(185, 368)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(212, 24)
        Me.cboYear.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-446, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(614, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Select Year:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(804, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(688, 55)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sales Report on Year"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBest)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.picBest)
        Me.GroupBox1.Location = New System.Drawing.Point(1137, 406)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 449)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'lblBest
        '
        Me.lblBest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBest.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblBest.Location = New System.Drawing.Point(81, 262)
        Me.lblBest.Name = "lblBest"
        Me.lblBest.Size = New System.Drawing.Size(244, 137)
        Me.lblBest.TabIndex = 12
        Me.lblBest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(117, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 55)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Best Seller"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBest
        '
        Me.picBest.Image = CType(resources.GetObject("picBest.Image"), System.Drawing.Image)
        Me.picBest.Location = New System.Drawing.Point(81, 80)
        Me.picBest.Name = "picBest"
        Me.picBest.Size = New System.Drawing.Size(244, 157)
        Me.picBest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBest.TabIndex = 0
        Me.picBest.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblWorst)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.picWorst)
        Me.GroupBox2.Location = New System.Drawing.Point(1562, 408)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 447)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'lblWorst
        '
        Me.lblWorst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWorst.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.lblWorst.Location = New System.Drawing.Point(82, 271)
        Me.lblWorst.Name = "lblWorst"
        Me.lblWorst.Size = New System.Drawing.Size(244, 137)
        Me.lblWorst.TabIndex = 13
        Me.lblWorst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(32, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(329, 55)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Least favourite"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picWorst
        '
        Me.picWorst.Image = CType(resources.GetObject("picWorst.Image"), System.Drawing.Image)
        Me.picWorst.Location = New System.Drawing.Point(82, 87)
        Me.picWorst.Name = "picWorst"
        Me.picWorst.Size = New System.Drawing.Size(244, 157)
        Me.picWorst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWorst.TabIndex = 1
        Me.picWorst.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(1356, 830)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(333, 53)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print Sales Report"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(941, 830)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(333, 53)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FoodOrderingSystem.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(911, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'PaymentReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboYear)
        Me.Controls.Add(Me.dgvSalesReport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "PaymentReport"
        Me.Text = "PaymentReport"
        CType(Me.dgvSalesReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picBest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picWorst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvSalesReport As DataGridView
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents picBest As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents picWorst As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBest As Label
    Friend WithEvents lblWorst As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents itemId As DataGridViewTextBoxColumn
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents itemPrice As DataGridViewTextBoxColumn
    Friend WithEvents totalQuantitySold As DataGridViewTextBoxColumn
    Friend WithEvents totalSales As DataGridViewTextBoxColumn
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
