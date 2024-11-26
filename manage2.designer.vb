<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage2
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage2))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMember = New System.Windows.Forms.DataGridView()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.cboSearchVariable = New System.Windows.Forms.ComboBox()
        Me.txtSearchValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpJoinDate = New System.Windows.Forms.DateTimePicker()
        Me.docMemberReport = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreviewMemberReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(83, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 38)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Manage Members"
        '
        'dgvMember
        '
        Me.dgvMember.AllowUserToAddRows = False
        Me.dgvMember.AllowUserToDeleteRows = False
        Me.dgvMember.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMember.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(39, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMember.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvMember.GridColor = System.Drawing.Color.Black
        Me.dgvMember.Location = New System.Drawing.Point(89, 192)
        Me.dgvMember.Name = "dgvMember"
        Me.dgvMember.ReadOnly = True
        Me.dgvMember.RowHeadersWidth = 51
        Me.dgvMember.RowTemplate.Height = 24
        Me.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMember.Size = New System.Drawing.Size(1115, 501)
        Me.dgvMember.TabIndex = 0
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(84, 707)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(105, 20)
        Me.lblCount.TabIndex = 58
        Me.lblCount.Text = "X record(s)"
        '
        'cboSearchVariable
        '
        Me.cboSearchVariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchVariable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboSearchVariable.FormattingEnabled = True
        Me.cboSearchVariable.Items.AddRange(New Object() {"All", "Id", "Name", "Username", "Password", "Email", "PhoneNumber", "JoinDate"})
        Me.cboSearchVariable.Location = New System.Drawing.Point(89, 133)
        Me.cboSearchVariable.Name = "cboSearchVariable"
        Me.cboSearchVariable.Size = New System.Drawing.Size(181, 33)
        Me.cboSearchVariable.TabIndex = 118
        '
        'txtSearchValue
        '
        Me.txtSearchValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchValue.Location = New System.Drawing.Point(276, 133)
        Me.txtSearchValue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchValue.MaxLength = 30
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.Size = New System.Drawing.Size(245, 30)
        Me.txtSearchValue.TabIndex = 119
        Me.txtSearchValue.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(84, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Search By :"
        '
        'dtpJoinDate
        '
        Me.dtpJoinDate.Enabled = False
        Me.dtpJoinDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpJoinDate.Location = New System.Drawing.Point(276, 133)
        Me.dtpJoinDate.Name = "dtpJoinDate"
        Me.dtpJoinDate.Size = New System.Drawing.Size(245, 30)
        Me.dtpJoinDate.TabIndex = 121
        Me.dtpJoinDate.Value = New Date(2023, 12, 29, 18, 34, 54, 0)
        Me.dtpJoinDate.Visible = False
        '
        'docMemberReport
        '
        Me.docMemberReport.OriginAtMargins = True
        '
        'dlgPreviewMemberReport
        '
        Me.dlgPreviewMemberReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewMemberReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewMemberReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewMemberReport.Enabled = True
        Me.dlgPreviewMemberReport.Icon = CType(resources.GetObject("dlgPreviewMemberReport.Icon"), System.Drawing.Icon)
        Me.dlgPreviewMemberReport.Name = "dlgPreviewMemberReport"
        Me.dlgPreviewMemberReport.UseAntiAlias = True
        Me.dlgPreviewMemberReport.Visible = False
        '
        'btnReport
        '
        Me.btnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Image = Global.FoodOrderingSystem.My.Resources.Resources.file
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(922, 67)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(282, 49)
        Me.btnReport.TabIndex = 122
        Me.btnReport.Text = "Member Joining Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(962, 124)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(242, 49)
        Me.btnNew.TabIndex = 117
        Me.btnNew.Text = "Add New Member"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'manage2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 736)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.dtpJoinDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchValue)
        Me.Controls.Add(Me.cboSearchVariable)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvMember)
        Me.Controls.Add(Me.Label3)
        Me.Name = "manage2"
        Me.Text = "manage2"
        CType(Me.dgvMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMember As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents cboSearchVariable As ComboBox
    Friend WithEvents txtSearchValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpJoinDate As DateTimePicker
    Friend WithEvents docMemberReport As Printing.PrintDocument
    Friend WithEvents dlgPreviewMemberReport As PrintPreviewDialog
    Friend WithEvents btnReport As Button
End Class
