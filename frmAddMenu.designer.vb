<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddMenu))
        Me.btnSearchImage = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtFoodName = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblFoodName = New System.Windows.Forms.Label()
        Me.lblAddMenuTitle = New System.Windows.Forms.Label()
        Me.picFoodImage = New System.Windows.Forms.PictureBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.radBBQ = New System.Windows.Forms.RadioButton()
        Me.radPasta = New System.Windows.Forms.RadioButton()
        Me.radPizza = New System.Windows.Forms.RadioButton()
        Me.radSalad = New System.Windows.Forms.RadioButton()
        Me.radSoupNStew = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnRemoveImage = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblIDName = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.grpGroup = New System.Windows.Forms.GroupBox()
        Me.cboGroup = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTipID = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDisplayDate = New System.Windows.Forms.Label()
        CType(Me.picFoodImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCategory.SuspendLayout()
        Me.grpGroup.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchImage
        '
        Me.btnSearchImage.BackColor = System.Drawing.Color.Wheat
        Me.btnSearchImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchImage.Location = New System.Drawing.Point(466, 760)
        Me.btnSearchImage.Name = "btnSearchImage"
        Me.btnSearchImage.Size = New System.Drawing.Size(176, 46)
        Me.btnSearchImage.TabIndex = 0
        Me.btnSearchImage.Text = "Browse Image"
        Me.btnSearchImage.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(1113, 422)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(283, 120)
        Me.txtDescription.TabIndex = 3
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(1113, 560)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(134, 22)
        Me.txtPrice.TabIndex = 4
        '
        'txtFoodName
        '
        Me.txtFoodName.Location = New System.Drawing.Point(1048, 385)
        Me.txtFoodName.Name = "txtFoodName"
        Me.txtFoodName.Size = New System.Drawing.Size(279, 22)
        Me.txtFoodName.TabIndex = 2
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(938, 560)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(140, 25)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price :  RM"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(937, 442)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(158, 25)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Description : "
        '
        'lblFoodName
        '
        Me.lblFoodName.AutoSize = True
        Me.lblFoodName.BackColor = System.Drawing.Color.Transparent
        Me.lblFoodName.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodName.Location = New System.Drawing.Point(935, 385)
        Me.lblFoodName.Name = "lblFoodName"
        Me.lblFoodName.Size = New System.Drawing.Size(94, 25)
        Me.lblFoodName.TabIndex = 8
        Me.lblFoodName.Text = "Name : "
        '
        'lblAddMenuTitle
        '
        Me.lblAddMenuTitle.AutoSize = True
        Me.lblAddMenuTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAddMenuTitle.Font = New System.Drawing.Font("Mistral", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddMenuTitle.Location = New System.Drawing.Point(820, 123)
        Me.lblAddMenuTitle.Name = "lblAddMenuTitle"
        Me.lblAddMenuTitle.Size = New System.Drawing.Size(493, 71)
        Me.lblAddMenuTitle.TabIndex = 9
        Me.lblAddMenuTitle.Text = "Add / Modify Cuisine "
        '
        'picFoodImage
        '
        Me.picFoodImage.BackgroundImage = CType(resources.GetObject("picFoodImage.BackgroundImage"), System.Drawing.Image)
        Me.picFoodImage.Location = New System.Drawing.Point(493, 442)
        Me.picFoodImage.Name = "picFoodImage"
        Me.picFoodImage.Size = New System.Drawing.Size(313, 281)
        Me.picFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoodImage.TabIndex = 1
        Me.picFoodImage.TabStop = False
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(8, 18)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(124, 25)
        Me.lblCategory.TabIndex = 10
        Me.lblCategory.Text = "Category : "
        '
        'radBBQ
        '
        Me.radBBQ.AutoSize = True
        Me.radBBQ.BackColor = System.Drawing.Color.Transparent
        Me.radBBQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBBQ.Location = New System.Drawing.Point(1065, 618)
        Me.radBBQ.Name = "radBBQ"
        Me.radBBQ.Size = New System.Drawing.Size(157, 28)
        Me.radBBQ.TabIndex = 11
        Me.radBBQ.TabStop = True
        Me.radBBQ.Text = "BBQ and Grill"
        Me.radBBQ.UseVisualStyleBackColor = False
        '
        'radPasta
        '
        Me.radPasta.AutoSize = True
        Me.radPasta.BackColor = System.Drawing.Color.Transparent
        Me.radPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPasta.Location = New System.Drawing.Point(1065, 652)
        Me.radPasta.Name = "radPasta"
        Me.radPasta.Size = New System.Drawing.Size(81, 28)
        Me.radPasta.TabIndex = 12
        Me.radPasta.TabStop = True
        Me.radPasta.Text = "Pasta"
        Me.radPasta.UseVisualStyleBackColor = False
        '
        'radPizza
        '
        Me.radPizza.AutoSize = True
        Me.radPizza.BackColor = System.Drawing.Color.Transparent
        Me.radPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPizza.Location = New System.Drawing.Point(1065, 686)
        Me.radPizza.Name = "radPizza"
        Me.radPizza.Size = New System.Drawing.Size(80, 28)
        Me.radPizza.TabIndex = 13
        Me.radPizza.TabStop = True
        Me.radPizza.Text = "Pizza"
        Me.radPizza.UseVisualStyleBackColor = False
        '
        'radSalad
        '
        Me.radSalad.AutoSize = True
        Me.radSalad.BackColor = System.Drawing.Color.Transparent
        Me.radSalad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSalad.Location = New System.Drawing.Point(1065, 720)
        Me.radSalad.Name = "radSalad"
        Me.radSalad.Size = New System.Drawing.Size(83, 28)
        Me.radSalad.TabIndex = 14
        Me.radSalad.TabStop = True
        Me.radSalad.Text = "Salad"
        Me.radSalad.UseVisualStyleBackColor = False
        '
        'radSoupNStew
        '
        Me.radSoupNStew.AutoSize = True
        Me.radSoupNStew.BackColor = System.Drawing.Color.Transparent
        Me.radSoupNStew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSoupNStew.Location = New System.Drawing.Point(1065, 754)
        Me.radSoupNStew.Name = "radSoupNStew"
        Me.radSoupNStew.Size = New System.Drawing.Size(175, 28)
        Me.radSoupNStew.TabIndex = 15
        Me.radSoupNStew.TabStop = True
        Me.radSoupNStew.Text = "Soup And Stew"
        Me.radSoupNStew.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1294, 618)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Group : "
        '
        'btnAddSave
        '
        Me.btnAddSave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnAddSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSave.Location = New System.Drawing.Point(1263, 832)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(131, 49)
        Me.btnAddSave.TabIndex = 20
        Me.btnAddSave.Text = "Save"
        Me.btnAddSave.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnRemoveImage
        '
        Me.btnRemoveImage.BackColor = System.Drawing.Color.Wheat
        Me.btnRemoveImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveImage.Location = New System.Drawing.Point(665, 760)
        Me.btnRemoveImage.Name = "btnRemoveImage"
        Me.btnRemoveImage.Size = New System.Drawing.Size(176, 46)
        Me.btnRemoveImage.TabIndex = 21
        Me.btnRemoveImage.Text = "Remove Image"
        Me.btnRemoveImage.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(1353, 380)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(98, 27)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblIDName
        '
        Me.lblIDName.AutoSize = True
        Me.lblIDName.BackColor = System.Drawing.Color.Transparent
        Me.lblIDName.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDName.Location = New System.Drawing.Point(362, 381)
        Me.lblIDName.Name = "lblIDName"
        Me.lblIDName.Size = New System.Drawing.Size(253, 25)
        Me.lblIDName.TabIndex = 24
        Me.lblIDName.Text = "ID For This Cuisine : "
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(633, 380)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(173, 25)
        Me.lblId.TabIndex = 25
        Me.ToolTipID.SetToolTip(Me.lblId, "* ID only show when user select editing *")
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Cornsilk
        Me.btnAdd.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(798, 249)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(261, 40)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add New Cuisine"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Cornsilk
        Me.btnEdit.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1129, 249)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(267, 40)
        Me.btnEdit.TabIndex = 27
        Me.btnEdit.Text = "Edit Available Cuisine"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.BackColor = System.Drawing.Color.Transparent
        Me.lblAction.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(542, 256)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(231, 25)
        Me.lblAction.TabIndex = 28
        Me.lblAction.Text = "Select Your Choice :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'grpCategory
        '
        Me.grpCategory.BackColor = System.Drawing.Color.Transparent
        Me.grpCategory.Controls.Add(Me.lblCategory)
        Me.grpCategory.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpCategory.ForeColor = System.Drawing.Color.Black
        Me.grpCategory.Location = New System.Drawing.Point(927, 601)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(335, 202)
        Me.grpCategory.TabIndex = 29
        Me.grpCategory.TabStop = False
        '
        'grpGroup
        '
        Me.grpGroup.BackColor = System.Drawing.Color.Transparent
        Me.grpGroup.Controls.Add(Me.cboGroup)
        Me.grpGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpGroup.ForeColor = System.Drawing.Color.Black
        Me.grpGroup.Location = New System.Drawing.Point(1287, 601)
        Me.grpGroup.Name = "grpGroup"
        Me.grpGroup.Size = New System.Drawing.Size(335, 202)
        Me.grpGroup.TabIndex = 30
        Me.grpGroup.TabStop = False
        '
        'cboGroup
        '
        Me.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGroup.FormattingEnabled = True
        Me.cboGroup.Items.AddRange(New Object() {"General", "Special", "Chef Favourite"})
        Me.cboGroup.Location = New System.Drawing.Point(113, 18)
        Me.cboGroup.Name = "cboGroup"
        Me.cboGroup.Size = New System.Drawing.Size(160, 28)
        Me.cboGroup.TabIndex = 32
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.AliceBlue
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(1444, 832)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 49)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(937, 339)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(89, 25)
        Me.lblTime.TabIndex = 32
        Me.lblTime.Text = "Time : "
        '
        'lblDisplayDate
        '
        Me.lblDisplayDate.BackColor = System.Drawing.Color.White
        Me.lblDisplayDate.Location = New System.Drawing.Point(1048, 339)
        Me.lblDisplayDate.Name = "lblDisplayDate"
        Me.lblDisplayDate.Size = New System.Drawing.Size(226, 23)
        Me.lblDisplayDate.TabIndex = 33
        '
        'frmAddMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1814, 1013)
        Me.Controls.Add(Me.lblDisplayDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblIDName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnRemoveImage)
        Me.Controls.Add(Me.btnAddSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radSoupNStew)
        Me.Controls.Add(Me.radSalad)
        Me.Controls.Add(Me.radPizza)
        Me.Controls.Add(Me.radPasta)
        Me.Controls.Add(Me.radBBQ)
        Me.Controls.Add(Me.lblAddMenuTitle)
        Me.Controls.Add(Me.lblFoodName)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtFoodName)
        Me.Controls.Add(Me.picFoodImage)
        Me.Controls.Add(Me.btnSearchImage)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.grpGroup)
        Me.Name = "frmAddMenu"
        Me.Text = "frmAddMenu"
        CType(Me.picFoodImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.grpGroup.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearchImage As Button
    Friend WithEvents picFoodImage As PictureBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtFoodName As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblFoodName As Label
    Friend WithEvents lblAddMenuTitle As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents radBBQ As RadioButton
    Friend WithEvents radPasta As RadioButton
    Friend WithEvents radPizza As RadioButton
    Friend WithEvents radSalad As RadioButton
    Friend WithEvents radSoupNStew As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddSave As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnRemoveImage As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents lblIDName As Label
    Friend WithEvents lblId As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblAction As Label
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents grpGroup As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents cboGroup As ComboBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents ToolTipID As ToolTip
    Friend WithEvents lblDisplayDate As Label
    Friend WithEvents lblTime As Label
End Class
