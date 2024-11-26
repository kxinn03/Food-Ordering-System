<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddRedeem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddRedeem))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblProductId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAvailability = New System.Windows.Forms.ComboBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.PicProduct = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, -31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 38)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Add New Member"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(232, 257)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(335, 32)
        Me.txtQuantity.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 219)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Points :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Name :"
        '
        'txtPoints
        '
        Me.txtPoints.Location = New System.Drawing.Point(232, 216)
        Me.txtPoints.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.Size = New System.Drawing.Size(335, 32)
        Me.txtPoints.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(232, 81)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(335, 32)
        Me.txtName.TabIndex = 0
        '
        'lblProductId
        '
        Me.lblProductId.Location = New System.Drawing.Point(232, 41)
        Me.lblProductId.Margin = New System.Windows.Forms.Padding(4)
        Me.lblProductId.Name = "lblProductId"
        Me.lblProductId.ReadOnly = True
        Me.lblProductId.Size = New System.Drawing.Size(335, 32)
        Me.lblProductId.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 41)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Product ID :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboAvailability)
        Me.GroupBox1.Controls.Add(Me.txtDetails)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnUploadPhoto)
        Me.GroupBox1.Controls.Add(Me.PicProduct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPoints)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblProductId)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(705, 493)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'cboAvailability
        '
        Me.cboAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAvailability.FormattingEnabled = True
        Me.cboAvailability.Items.AddRange(New Object() {"True", "False"})
        Me.cboAvailability.Location = New System.Drawing.Point(232, 300)
        Me.cboAvailability.Name = "cboAvailability"
        Me.cboAvailability.Size = New System.Drawing.Size(335, 33)
        Me.cboAvailability.TabIndex = 131
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(232, 125)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(335, 84)
        Me.txtDetails.TabIndex = 127
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 125)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 25)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Product Details :"
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.BackColor = System.Drawing.Color.White
        Me.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPhoto.Image = Global.FoodOrderingSystem.My.Resources.Resources.upload_big_arrow__1_
        Me.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadPhoto.Location = New System.Drawing.Point(387, 444)
        Me.btnUploadPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(96, 29)
        Me.btnUploadPhoto.TabIndex = 125
        Me.btnUploadPhoto.Text = "Upload"
        Me.btnUploadPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUploadPhoto.UseVisualStyleBackColor = False
        '
        'PicProduct
        '
        Me.PicProduct.Image = Global.FoodOrderingSystem.My.Resources.Resources.no_image
        Me.PicProduct.Location = New System.Drawing.Point(232, 340)
        Me.PicProduct.Name = "PicProduct"
        Me.PicProduct.Size = New System.Drawing.Size(148, 133)
        Me.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProduct.TabIndex = 15
        Me.PicProduct.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 340)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Image : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Availability :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 260)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Quantity :"
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReset.Location = New System.Drawing.Point(45, 543)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 49)
        Me.btnReset.TabIndex = 137
        Me.btnReset.Text = "Reset"
        Me.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.FoodOrderingSystem.My.Resources.Resources.mcancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(643, 543)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 49)
        Me.btnCancel.TabIndex = 135
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(328, 543)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(123, 49)
        Me.btnNew.TabIndex = 134
        Me.btnNew.Text = "Add"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'FrmAddRedeem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 623)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddRedeem"
        Me.Text = "FrmAddRedeem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblProductId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents PicProduct As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents cboAvailability As ComboBox
End Class
