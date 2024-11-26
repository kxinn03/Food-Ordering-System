<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProductAction
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductAction))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblProductId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.PicProduct = New System.Windows.Forms.PictureBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cboAvailability = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(45, 44)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(705, 492)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(232, 121)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(335, 84)
        Me.txtDetails.TabIndex = 129
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 25)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Product Details :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 336)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Image : "
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(232, 253)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(335, 32)
        Me.txtQuantity.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 296)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Availability :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 256)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Quantity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 215)
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
        Me.txtPoints.Location = New System.Drawing.Point(232, 212)
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
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.BackColor = System.Drawing.Color.White
        Me.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPhoto.Image = Global.FoodOrderingSystem.My.Resources.Resources.upload_big_arrow__1_
        Me.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadPhoto.Location = New System.Drawing.Point(387, 440)
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
        Me.PicProduct.Location = New System.Drawing.Point(232, 336)
        Me.PicProduct.Name = "PicProduct"
        Me.PicProduct.Size = New System.Drawing.Size(148, 133)
        Me.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProduct.TabIndex = 15
        Me.PicProduct.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(220, 561)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(123, 49)
        Me.btnUpdate.TabIndex = 124
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(414, 561)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(123, 49)
        Me.btnDelete.TabIndex = 125
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboAvailability
        '
        Me.cboAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAvailability.FormattingEnabled = True
        Me.cboAvailability.Items.AddRange(New Object() {"True", "False"})
        Me.cboAvailability.Location = New System.Drawing.Point(232, 292)
        Me.cboAvailability.Name = "cboAvailability"
        Me.cboAvailability.Size = New System.Drawing.Size(335, 33)
        Me.cboAvailability.TabIndex = 132
        '
        'FrmProductAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 651)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Name = "FrmProductAction"
        Me.Text = "FrmProductAction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblProductId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PicProduct As PictureBox
    Friend WithEvents btnUploadPhoto As Button
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents cboAvailability As ComboBox
End Class
