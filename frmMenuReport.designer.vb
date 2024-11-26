<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuReport))
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEditHistory = New System.Windows.Forms.Label()
        Me.dgvMenuAddHistory = New System.Windows.Forms.DataGridView()
        Me.lblAddMenuTitle = New System.Windows.Forms.Label()
        Me.lblModuleName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvMenuEditHistory = New System.Windows.Forms.DataGridView()
        Me.cboSelectYear = New System.Windows.Forms.ComboBox()
        Me.lblCboMenuAdd = New System.Windows.Forms.Label()
        Me.btnAddMenuPrint = New System.Windows.Forms.Button()
        Me.dialogPreviewAddMenuReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.docAddMenuReport = New System.Drawing.Printing.PrintDocument()
        Me.picRestaurantLogo = New System.Windows.Forms.PictureBox()
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.btnEditMenuPrint = New System.Windows.Forms.Button()
        Me.btnExit = New FoodOrderingSystem.RoundButton()
        Me.cboSelectCuisine = New System.Windows.Forms.ComboBox()
        Me.lblCboMenuEdit = New System.Windows.Forms.Label()
        Me.dialogPreviewEditMenuReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.docEditMenuReport = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvMenuAddHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenuEditHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRestaurantLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Tai Le", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(287, 289)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(576, 113)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "TARUMT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ground Floor, Bangunan Tan Sri Khaw Kai Boh (Block A), " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jalan Genting Ke" &
    "lang, Setapak, 53300 Kuala Lumpur, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Federal Territory of Kuala Lumpur"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEditHistory
        '
        Me.lblEditHistory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEditHistory.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditHistory.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblEditHistory.Location = New System.Drawing.Point(118, 797)
        Me.lblEditHistory.Name = "lblEditHistory"
        Me.lblEditHistory.Size = New System.Drawing.Size(226, 42)
        Me.lblEditHistory.TabIndex = 6
        Me.lblEditHistory.Text = "Menu Edit History"
        Me.lblEditHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMenuAddHistory
        '
        Me.dgvMenuAddHistory.AllowUserToAddRows = False
        Me.dgvMenuAddHistory.AllowUserToDeleteRows = False
        Me.dgvMenuAddHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMenuAddHistory.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.dgvMenuAddHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuAddHistory.GridColor = System.Drawing.Color.Salmon
        Me.dgvMenuAddHistory.Location = New System.Drawing.Point(123, 472)
        Me.dgvMenuAddHistory.Name = "dgvMenuAddHistory"
        Me.dgvMenuAddHistory.ReadOnly = True
        Me.dgvMenuAddHistory.RowHeadersWidth = 51
        Me.dgvMenuAddHistory.RowTemplate.Height = 24
        Me.dgvMenuAddHistory.Size = New System.Drawing.Size(920, 226)
        Me.dgvMenuAddHistory.TabIndex = 5
        '
        'lblAddMenuTitle
        '
        Me.lblAddMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAddMenuTitle.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddMenuTitle.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblAddMenuTitle.Location = New System.Drawing.Point(118, 427)
        Me.lblAddMenuTitle.Name = "lblAddMenuTitle"
        Me.lblAddMenuTitle.Size = New System.Drawing.Size(222, 42)
        Me.lblAddMenuTitle.TabIndex = 4
        Me.lblAddMenuTitle.Text = "Menu Add History"
        Me.lblAddMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblModuleName
        '
        Me.lblModuleName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblModuleName.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModuleName.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblModuleName.Location = New System.Drawing.Point(371, 257)
        Me.lblModuleName.Name = "lblModuleName"
        Me.lblModuleName.Size = New System.Drawing.Size(439, 42)
        Me.lblModuleName.TabIndex = 2
        Me.lblModuleName.Text = "------- Menu Module Report ------- "
        Me.lblModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(429, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(326, 210)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvMenuEditHistory
        '
        Me.dgvMenuEditHistory.AllowUserToAddRows = False
        Me.dgvMenuEditHistory.AllowUserToDeleteRows = False
        Me.dgvMenuEditHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMenuEditHistory.BackgroundColor = System.Drawing.Color.DarkOrange
        Me.dgvMenuEditHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuEditHistory.Location = New System.Drawing.Point(123, 842)
        Me.dgvMenuEditHistory.Name = "dgvMenuEditHistory"
        Me.dgvMenuEditHistory.ReadOnly = True
        Me.dgvMenuEditHistory.RowHeadersWidth = 51
        Me.dgvMenuEditHistory.RowTemplate.Height = 24
        Me.dgvMenuEditHistory.Size = New System.Drawing.Size(932, 211)
        Me.dgvMenuEditHistory.TabIndex = 7
        '
        'cboSelectYear
        '
        Me.cboSelectYear.FormattingEnabled = True
        Me.cboSelectYear.Location = New System.Drawing.Point(890, 440)
        Me.cboSelectYear.Name = "cboSelectYear"
        Me.cboSelectYear.Size = New System.Drawing.Size(153, 24)
        Me.cboSelectYear.TabIndex = 36
        '
        'lblCboMenuAdd
        '
        Me.lblCboMenuAdd.AutoSize = True
        Me.lblCboMenuAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCboMenuAdd.Location = New System.Drawing.Point(720, 441)
        Me.lblCboMenuAdd.Name = "lblCboMenuAdd"
        Me.lblCboMenuAdd.Size = New System.Drawing.Size(151, 18)
        Me.lblCboMenuAdd.TabIndex = 35
        Me.lblCboMenuAdd.Text = "Select Which Year:"
        '
        'btnAddMenuPrint
        '
        Me.btnAddMenuPrint.Font = New System.Drawing.Font("Colonna MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMenuPrint.Location = New System.Drawing.Point(743, 704)
        Me.btnAddMenuPrint.Name = "btnAddMenuPrint"
        Me.btnAddMenuPrint.Size = New System.Drawing.Size(300, 40)
        Me.btnAddMenuPrint.TabIndex = 8
        Me.btnAddMenuPrint.Text = "Print Add Menu History"
        Me.btnAddMenuPrint.UseVisualStyleBackColor = True
        '
        'dialogPreviewAddMenuReport
        '
        Me.dialogPreviewAddMenuReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dialogPreviewAddMenuReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dialogPreviewAddMenuReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dialogPreviewAddMenuReport.Enabled = True
        Me.dialogPreviewAddMenuReport.Icon = CType(resources.GetObject("dialogPreviewAddMenuReport.Icon"), System.Drawing.Icon)
        Me.dialogPreviewAddMenuReport.Name = "dialogPreviewMenuReport"
        Me.dialogPreviewAddMenuReport.Visible = False
        '
        'docAddMenuReport
        '
        '
        'picRestaurantLogo
        '
        Me.picRestaurantLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picRestaurantLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRestaurantLogo.Image = Global.FoodOrderingSystem.My.Resources.Resources.restaurantlogo
        Me.picRestaurantLogo.Location = New System.Drawing.Point(420, 28)
        Me.picRestaurantLogo.Name = "picRestaurantLogo"
        Me.picRestaurantLogo.Size = New System.Drawing.Size(323, 212)
        Me.picRestaurantLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRestaurantLogo.TabIndex = 0
        Me.picRestaurantLogo.TabStop = False
        '
        'pnlReport
        '
        Me.pnlReport.AutoScroll = True
        Me.pnlReport.Controls.Add(Me.btnEditMenuPrint)
        Me.pnlReport.Controls.Add(Me.btnExit)
        Me.pnlReport.Controls.Add(Me.cboSelectCuisine)
        Me.pnlReport.Controls.Add(Me.lblCboMenuEdit)
        Me.pnlReport.Controls.Add(Me.cboSelectYear)
        Me.pnlReport.Controls.Add(Me.lblCboMenuAdd)
        Me.pnlReport.Controls.Add(Me.btnAddMenuPrint)
        Me.pnlReport.Controls.Add(Me.dgvMenuEditHistory)
        Me.pnlReport.Controls.Add(Me.picRestaurantLogo)
        Me.pnlReport.Controls.Add(Me.lblEditHistory)
        Me.pnlReport.Controls.Add(Me.Button1)
        Me.pnlReport.Controls.Add(Me.dgvMenuAddHistory)
        Me.pnlReport.Controls.Add(Me.lblAddress)
        Me.pnlReport.Controls.Add(Me.lblAddMenuTitle)
        Me.pnlReport.Controls.Add(Me.lblModuleName)
        Me.pnlReport.Location = New System.Drawing.Point(355, 171)
        Me.pnlReport.Name = "pnlReport"
        Me.pnlReport.Size = New System.Drawing.Size(1099, 1188)
        Me.pnlReport.TabIndex = 3
        '
        'btnEditMenuPrint
        '
        Me.btnEditMenuPrint.Font = New System.Drawing.Font("Colonna MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditMenuPrint.Location = New System.Drawing.Point(755, 1054)
        Me.btnEditMenuPrint.Name = "btnEditMenuPrint"
        Me.btnEditMenuPrint.Size = New System.Drawing.Size(300, 31)
        Me.btnEditMenuPrint.TabIndex = 41
        Me.btnEditMenuPrint.Text = "Print Edit Menu History"
        Me.btnEditMenuPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Tai Le", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(941, 1127)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 58)
        Me.btnExit.TabIndex = 40
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cboSelectCuisine
        '
        Me.cboSelectCuisine.FormattingEnabled = True
        Me.cboSelectCuisine.Location = New System.Drawing.Point(849, 805)
        Me.cboSelectCuisine.Name = "cboSelectCuisine"
        Me.cboSelectCuisine.Size = New System.Drawing.Size(206, 24)
        Me.cboSelectCuisine.TabIndex = 39
        '
        'lblCboMenuEdit
        '
        Me.lblCboMenuEdit.AutoSize = True
        Me.lblCboMenuEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCboMenuEdit.Location = New System.Drawing.Point(643, 811)
        Me.lblCboMenuEdit.Name = "lblCboMenuEdit"
        Me.lblCboMenuEdit.Size = New System.Drawing.Size(178, 18)
        Me.lblCboMenuEdit.TabIndex = 38
        Me.lblCboMenuEdit.Text = "Select Which Cuisine :"
        '
        'dialogPreviewEditMenuReport
        '
        Me.dialogPreviewEditMenuReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dialogPreviewEditMenuReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dialogPreviewEditMenuReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dialogPreviewEditMenuReport.Enabled = True
        Me.dialogPreviewEditMenuReport.Icon = CType(resources.GetObject("dialogPreviewEditMenuReport.Icon"), System.Drawing.Icon)
        Me.dialogPreviewEditMenuReport.Name = "PrintPreviewEditMenuReport"
        Me.dialogPreviewEditMenuReport.Visible = False
        '
        'docEditMenuReport
        '
        '
        'frmMenuReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1710, 1055)
        Me.Controls.Add(Me.pnlReport)
        Me.Name = "frmMenuReport"
        Me.Text = "frmMenuReport"
        CType(Me.dgvMenuAddHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenuEditHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRestaurantLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReport.ResumeLayout(False)
        Me.pnlReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picRestaurantLogo As PictureBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblModuleName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblEditHistory As Label
    Friend WithEvents dgvMenuAddHistory As DataGridView
    Friend WithEvents lblAddMenuTitle As Label
    Friend WithEvents dgvMenuEditHistory As DataGridView
    Friend WithEvents btnAddMenuPrint As Button
    Friend WithEvents lblCboMenuAdd As Label
    Friend WithEvents cboSelectYear As ComboBox
    Friend WithEvents dialogPreviewAddMenuReport As PrintPreviewDialog
    Friend WithEvents docAddMenuReport As Printing.PrintDocument
    Friend WithEvents pnlReport As Panel
    Friend WithEvents cboSelectCuisine As ComboBox
    Friend WithEvents lblCboMenuEdit As Label
    Friend WithEvents btnEditMenuPrint As Button
    Friend WithEvents btnExit As RoundButton
    Friend WithEvents dialogPreviewEditMenuReport As PrintPreviewDialog
    Friend WithEvents docEditMenuReport As Printing.PrintDocument
End Class
