<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteMenu
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSelectCuisine = New System.Windows.Forms.Label()
        Me.cboSelectCategory = New System.Windows.Forms.ComboBox()
        Me.dgvCuisine = New System.Windows.Forms.DataGridView()
        Me.lblDeleteTitleDesc = New System.Windows.Forms.Label()
        Me.lblDeleteTitle = New System.Windows.Forms.Label()
        Me.lblCountForCuisine = New System.Windows.Forms.Label()
        Me.cboSelectArchiveMode = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        CType(Me.dgvCuisine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectCuisine
        '
        Me.lblSelectCuisine.AutoSize = True
        Me.lblSelectCuisine.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectCuisine.Font = New System.Drawing.Font("MV Boli", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectCuisine.ForeColor = System.Drawing.Color.White
        Me.lblSelectCuisine.Location = New System.Drawing.Point(92, 165)
        Me.lblSelectCuisine.Name = "lblSelectCuisine"
        Me.lblSelectCuisine.Size = New System.Drawing.Size(439, 25)
        Me.lblSelectCuisine.TabIndex = 2
        Me.lblSelectCuisine.Text = "Select <Category> for food to be delete : "
        '
        'cboSelectCategory
        '
        Me.cboSelectCategory.FormattingEnabled = True
        Me.cboSelectCategory.Location = New System.Drawing.Point(559, 165)
        Me.cboSelectCategory.Name = "cboSelectCategory"
        Me.cboSelectCategory.Size = New System.Drawing.Size(217, 24)
        Me.cboSelectCategory.TabIndex = 3
        '
        'dgvCuisine
        '
        Me.dgvCuisine.AllowUserToAddRows = False
        Me.dgvCuisine.AllowUserToResizeColumns = False
        Me.dgvCuisine.AllowUserToResizeRows = False
        Me.dgvCuisine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCuisine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCuisine.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuisine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCuisine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuisine.GridColor = System.Drawing.Color.OrangeRed
        Me.dgvCuisine.Location = New System.Drawing.Point(94, 212)
        Me.dgvCuisine.Name = "dgvCuisine"
        Me.dgvCuisine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuisine.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCuisine.RowHeadersWidth = 100
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvCuisine.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCuisine.RowTemplate.Height = 24
        Me.dgvCuisine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCuisine.Size = New System.Drawing.Size(1248, 590)
        Me.dgvCuisine.TabIndex = 4
        '
        'lblDeleteTitleDesc
        '
        Me.lblDeleteTitleDesc.AutoSize = True
        Me.lblDeleteTitleDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDeleteTitleDesc.Font = New System.Drawing.Font("MV Boli", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteTitleDesc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDeleteTitleDesc.Location = New System.Drawing.Point(91, 120)
        Me.lblDeleteTitleDesc.Name = "lblDeleteTitleDesc"
        Me.lblDeleteTitleDesc.Size = New System.Drawing.Size(520, 22)
        Me.lblDeleteTitleDesc.TabIndex = 31
        Me.lblDeleteTitleDesc.Text = " *  2 choices You Can Make : - Delete or Archive Cuisine"
        '
        'lblDeleteTitle
        '
        Me.lblDeleteTitle.AutoSize = True
        Me.lblDeleteTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDeleteTitle.Font = New System.Drawing.Font("Mistral", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteTitle.ForeColor = System.Drawing.Color.White
        Me.lblDeleteTitle.Location = New System.Drawing.Point(85, 63)
        Me.lblDeleteTitle.Name = "lblDeleteTitle"
        Me.lblDeleteTitle.Size = New System.Drawing.Size(279, 57)
        Me.lblDeleteTitle.TabIndex = 30
        Me.lblDeleteTitle.Text = "Archive Cuisine"
        '
        'lblCountForCuisine
        '
        Me.lblCountForCuisine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCountForCuisine.AutoSize = True
        Me.lblCountForCuisine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountForCuisine.Location = New System.Drawing.Point(92, 843)
        Me.lblCountForCuisine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountForCuisine.Name = "lblCountForCuisine"
        Me.lblCountForCuisine.Size = New System.Drawing.Size(71, 25)
        Me.lblCountForCuisine.TabIndex = 32
        Me.lblCountForCuisine.Text = "Label1"
        '
        'cboSelectArchiveMode
        '
        Me.cboSelectArchiveMode.FormattingEnabled = True
        Me.cboSelectArchiveMode.Location = New System.Drawing.Point(849, 165)
        Me.cboSelectArchiveMode.Name = "cboSelectArchiveMode"
        Me.cboSelectArchiveMode.Size = New System.Drawing.Size(217, 24)
        Me.cboSelectArchiveMode.TabIndex = 33
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(1087, 156)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(96, 41)
        Me.btnDisplay.TabIndex = 34
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmDeleteMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.backgrd
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1445, 916)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.cboSelectArchiveMode)
        Me.Controls.Add(Me.lblCountForCuisine)
        Me.Controls.Add(Me.lblDeleteTitleDesc)
        Me.Controls.Add(Me.lblDeleteTitle)
        Me.Controls.Add(Me.dgvCuisine)
        Me.Controls.Add(Me.cboSelectCategory)
        Me.Controls.Add(Me.lblSelectCuisine)
        Me.Name = "frmDeleteMenu"
        Me.Text = "frmDeleteMenu"
        CType(Me.dgvCuisine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectCuisine As Label
    Friend WithEvents cboSelectCategory As ComboBox
    Friend WithEvents dgvCuisine As DataGridView
    Friend WithEvents lblDeleteTitleDesc As Label
    Friend WithEvents lblDeleteTitle As Label
    Friend WithEvents lblCountForCuisine As Label
    Friend WithEvents cboSelectArchiveMode As ComboBox
    Friend WithEvents btnDisplay As Button
End Class
