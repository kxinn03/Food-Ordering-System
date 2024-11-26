<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblSidePanel = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblMenuDesc = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rBtnHome = New FoodOrderingSystem.RoundButton()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rBtnMenu = New FoodOrderingSystem.RoundButton()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rBtnOrder = New FoodOrderingSystem.RoundButton()
        Me.lblChefRecomm = New System.Windows.Forms.Label()
        Me.btnRoundCornerSoup = New System.Windows.Forms.Button()
        Me.btnRoundCornerPizza = New System.Windows.Forms.Button()
        Me.btnRoundCornerSalad = New System.Windows.Forms.Button()
        Me.btnRoundCornerPasta = New System.Windows.Forms.Button()
        Me.btnRoundCornerBBQ = New System.Windows.Forms.Button()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.lblAddEdit = New System.Windows.Forms.Label()
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.rBtnMenuReport = New FoodOrderingSystem.RoundButton()
        Me.rBtnDelete = New FoodOrderingSystem.RoundButton()
        Me.rBtnAddEdit = New FoodOrderingSystem.RoundButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnScrollToTop = New System.Windows.Forms.Button()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblMenuReport = New System.Windows.Forms.Label()
        Me.rBtnChefRecomm = New FoodOrderingSystem.RoundButton()
        Me.rBtnProfile = New FoodOrderingSystem.RoundButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSidePanel
        '
        Me.lblSidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSidePanel.ForeColor = System.Drawing.Color.White
        Me.lblSidePanel.Location = New System.Drawing.Point(0, 0)
        Me.lblSidePanel.Name = "lblSidePanel"
        Me.lblSidePanel.Size = New System.Drawing.Size(180, 1055)
        Me.lblSidePanel.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Mistral", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(213, 17)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(245, 52)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome, Menu"
        '
        'lblMenuDesc
        '
        Me.lblMenuDesc.AutoSize = True
        Me.lblMenuDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblMenuDesc.Font = New System.Drawing.Font("MV Boli", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuDesc.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMenuDesc.Location = New System.Drawing.Point(217, 61)
        Me.lblMenuDesc.Name = "lblMenuDesc"
        Me.lblMenuDesc.Size = New System.Drawing.Size(560, 25)
        Me.lblMenuDesc.TabIndex = 29
        Me.lblMenuDesc.Text = "Anything you need is here : ---  MINIMOO restaurant"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "To"
        '
        'rBtnHome
        '
        Me.rBtnHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnHome.FlatAppearance.BorderSize = 0
        Me.rBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnHome.Image = CType(resources.GetObject("rBtnHome.Image"), System.Drawing.Image)
        Me.rBtnHome.Location = New System.Drawing.Point(57, 278)
        Me.rBtnHome.Name = "rBtnHome"
        Me.rBtnHome.Size = New System.Drawing.Size(59, 57)
        Me.rBtnHome.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.rBtnHome, "Home")
        Me.rBtnHome.UseVisualStyleBackColor = False
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "To"
        '
        'rBtnMenu
        '
        Me.rBtnMenu.FlatAppearance.BorderSize = 0
        Me.rBtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnMenu.Image = CType(resources.GetObject("rBtnMenu.Image"), System.Drawing.Image)
        Me.rBtnMenu.Location = New System.Drawing.Point(57, 399)
        Me.rBtnMenu.Name = "rBtnMenu"
        Me.rBtnMenu.Size = New System.Drawing.Size(59, 54)
        Me.rBtnMenu.TabIndex = 10
        Me.ToolTip2.SetToolTip(Me.rBtnMenu, "Menu")
        Me.rBtnMenu.UseVisualStyleBackColor = True
        '
        'ToolTip3
        '
        Me.ToolTip3.ToolTipTitle = "To"
        '
        'rBtnOrder
        '
        Me.rBtnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnOrder.FlatAppearance.BorderSize = 0
        Me.rBtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnOrder.Image = CType(resources.GetObject("rBtnOrder.Image"), System.Drawing.Image)
        Me.rBtnOrder.Location = New System.Drawing.Point(57, 528)
        Me.rBtnOrder.Name = "rBtnOrder"
        Me.rBtnOrder.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.rBtnOrder.Size = New System.Drawing.Size(59, 54)
        Me.rBtnOrder.TabIndex = 8
        Me.ToolTip3.SetToolTip(Me.rBtnOrder, "Orders")
        Me.rBtnOrder.UseVisualStyleBackColor = False
        '
        'lblChefRecomm
        '
        Me.lblChefRecomm.AutoSize = True
        Me.lblChefRecomm.BackColor = System.Drawing.Color.Transparent
        Me.lblChefRecomm.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChefRecomm.ForeColor = System.Drawing.Color.White
        Me.lblChefRecomm.Location = New System.Drawing.Point(1471, 37)
        Me.lblChefRecomm.Name = "lblChefRecomm"
        Me.lblChefRecomm.Size = New System.Drawing.Size(178, 24)
        Me.lblChefRecomm.TabIndex = 73
        Me.lblChefRecomm.Text = "Chef's FAVOURITE !"
        '
        'btnRoundCornerSoup
        '
        Me.btnRoundCornerSoup.BackColor = System.Drawing.Color.Coral
        Me.btnRoundCornerSoup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoundCornerSoup.Image = CType(resources.GetObject("btnRoundCornerSoup.Image"), System.Drawing.Image)
        Me.btnRoundCornerSoup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoundCornerSoup.Location = New System.Drawing.Point(1435, 107)
        Me.btnRoundCornerSoup.Name = "btnRoundCornerSoup"
        Me.btnRoundCornerSoup.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRoundCornerSoup.Size = New System.Drawing.Size(214, 38)
        Me.btnRoundCornerSoup.TabIndex = 82
        Me.btnRoundCornerSoup.Text = "   Soup N Stew"
        Me.btnRoundCornerSoup.UseVisualStyleBackColor = False
        '
        'btnRoundCornerPizza
        '
        Me.btnRoundCornerPizza.BackColor = System.Drawing.Color.Coral
        Me.btnRoundCornerPizza.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoundCornerPizza.Image = CType(resources.GetObject("btnRoundCornerPizza.Image"), System.Drawing.Image)
        Me.btnRoundCornerPizza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoundCornerPizza.Location = New System.Drawing.Point(896, 107)
        Me.btnRoundCornerPizza.Name = "btnRoundCornerPizza"
        Me.btnRoundCornerPizza.Padding = New System.Windows.Forms.Padding(10, 4, 0, 4)
        Me.btnRoundCornerPizza.Size = New System.Drawing.Size(206, 38)
        Me.btnRoundCornerPizza.TabIndex = 80
        Me.btnRoundCornerPizza.Text = "Pizza"
        Me.btnRoundCornerPizza.UseVisualStyleBackColor = False
        '
        'btnRoundCornerSalad
        '
        Me.btnRoundCornerSalad.BackColor = System.Drawing.Color.Coral
        Me.btnRoundCornerSalad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoundCornerSalad.Image = CType(resources.GetObject("btnRoundCornerSalad.Image"), System.Drawing.Image)
        Me.btnRoundCornerSalad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoundCornerSalad.Location = New System.Drawing.Point(1171, 107)
        Me.btnRoundCornerSalad.Name = "btnRoundCornerSalad"
        Me.btnRoundCornerSalad.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRoundCornerSalad.Size = New System.Drawing.Size(200, 38)
        Me.btnRoundCornerSalad.TabIndex = 81
        Me.btnRoundCornerSalad.Text = "Salad"
        Me.btnRoundCornerSalad.UseVisualStyleBackColor = False
        '
        'btnRoundCornerPasta
        '
        Me.btnRoundCornerPasta.BackColor = System.Drawing.Color.Coral
        Me.btnRoundCornerPasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoundCornerPasta.Image = CType(resources.GetObject("btnRoundCornerPasta.Image"), System.Drawing.Image)
        Me.btnRoundCornerPasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoundCornerPasta.Location = New System.Drawing.Point(619, 107)
        Me.btnRoundCornerPasta.Name = "btnRoundCornerPasta"
        Me.btnRoundCornerPasta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRoundCornerPasta.Size = New System.Drawing.Size(204, 38)
        Me.btnRoundCornerPasta.TabIndex = 79
        Me.btnRoundCornerPasta.Text = "Pasta"
        Me.btnRoundCornerPasta.UseVisualStyleBackColor = False
        '
        'btnRoundCornerBBQ
        '
        Me.btnRoundCornerBBQ.BackColor = System.Drawing.Color.Coral
        Me.btnRoundCornerBBQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoundCornerBBQ.Image = CType(resources.GetObject("btnRoundCornerBBQ.Image"), System.Drawing.Image)
        Me.btnRoundCornerBBQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoundCornerBBQ.Location = New System.Drawing.Point(325, 107)
        Me.btnRoundCornerBBQ.Name = "btnRoundCornerBBQ"
        Me.btnRoundCornerBBQ.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnRoundCornerBBQ.Size = New System.Drawing.Size(219, 38)
        Me.btnRoundCornerBBQ.TabIndex = 74
        Me.btnRoundCornerBBQ.Text = "BBQ N Grill"
        Me.btnRoundCornerBBQ.UseVisualStyleBackColor = False
        '
        'lblHome
        '
        Me.lblHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblHome.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(43, 338)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(108, 36)
        Me.lblHome.TabIndex = 84
        Me.lblHome.Text = "Home"
        '
        'lblMenu
        '
        Me.lblMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblMenu.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(43, 456)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(116, 45)
        Me.lblMenu.TabIndex = 85
        Me.lblMenu.Text = "Menu"
        '
        'lblOrder
        '
        Me.lblOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblOrder.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(43, 585)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(116, 45)
        Me.lblOrder.TabIndex = 87
        Me.lblOrder.Text = "Order"
        '
        'lblProfile
        '
        Me.lblProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblProfile.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.Location = New System.Drawing.Point(43, 219)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(127, 34)
        Me.lblProfile.TabIndex = 88
        Me.lblProfile.Text = "Profile"
        '
        'lblAddEdit
        '
        Me.lblAddEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblAddEdit.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEdit.Location = New System.Drawing.Point(18, 708)
        Me.lblAddEdit.Name = "lblAddEdit"
        Me.lblAddEdit.Size = New System.Drawing.Size(162, 45)
        Me.lblAddEdit.TabIndex = 90
        Me.lblAddEdit.Text = "Add N Edit"
        '
        'rBtnMenuReport
        '
        Me.rBtnMenuReport.BackColor = System.Drawing.Color.White
        Me.rBtnMenuReport.BackgroundImage = Global.FoodOrderingSystem.My.Resources.Resources.menuReportIcon
        Me.rBtnMenuReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rBtnMenuReport.FlatAppearance.BorderSize = 0
        Me.rBtnMenuReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnMenuReport.Location = New System.Drawing.Point(57, 905)
        Me.rBtnMenuReport.Name = "rBtnMenuReport"
        Me.rBtnMenuReport.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.rBtnMenuReport.Size = New System.Drawing.Size(59, 54)
        Me.rBtnMenuReport.TabIndex = 94
        Me.ToolTip4.SetToolTip(Me.rBtnMenuReport, "Add And Edit")
        Me.rBtnMenuReport.UseVisualStyleBackColor = False
        '
        'rBtnDelete
        '
        Me.rBtnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnDelete.BackgroundImage = CType(resources.GetObject("rBtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.rBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rBtnDelete.FlatAppearance.BorderSize = 0
        Me.rBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnDelete.Image = CType(resources.GetObject("rBtnDelete.Image"), System.Drawing.Image)
        Me.rBtnDelete.Location = New System.Drawing.Point(57, 775)
        Me.rBtnDelete.Name = "rBtnDelete"
        Me.rBtnDelete.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.rBtnDelete.Size = New System.Drawing.Size(59, 54)
        Me.rBtnDelete.TabIndex = 92
        Me.ToolTip4.SetToolTip(Me.rBtnDelete, "Add And Edit")
        Me.rBtnDelete.UseVisualStyleBackColor = False
        '
        'rBtnAddEdit
        '
        Me.rBtnAddEdit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnAddEdit.FlatAppearance.BorderSize = 0
        Me.rBtnAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnAddEdit.Image = CType(resources.GetObject("rBtnAddEdit.Image"), System.Drawing.Image)
        Me.rBtnAddEdit.Location = New System.Drawing.Point(57, 651)
        Me.rBtnAddEdit.Name = "rBtnAddEdit"
        Me.rBtnAddEdit.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.rBtnAddEdit.Size = New System.Drawing.Size(59, 54)
        Me.rBtnAddEdit.TabIndex = 89
        Me.ToolTip4.SetToolTip(Me.rBtnAddEdit, "Add And Edit")
        Me.rBtnAddEdit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'btnScrollToTop
        '
        Me.btnScrollToTop.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnScrollToTop.Font = New System.Drawing.Font("MV Boli", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScrollToTop.Location = New System.Drawing.Point(180, 1012)
        Me.btnScrollToTop.Name = "btnScrollToTop"
        Me.btnScrollToTop.Size = New System.Drawing.Size(1744, 43)
        Me.btnScrollToTop.TabIndex = 91
        Me.btnScrollToTop.Text = "Press To Go Top"
        Me.btnScrollToTop.UseVisualStyleBackColor = True
        '
        'lblDelete
        '
        Me.lblDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblDelete.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.Location = New System.Drawing.Point(38, 832)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(112, 45)
        Me.lblDelete.TabIndex = 93
        Me.lblDelete.Text = "Delete"
        '
        'lblMenuReport
        '
        Me.lblMenuReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.lblMenuReport.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuReport.Location = New System.Drawing.Point(13, 962)
        Me.lblMenuReport.Name = "lblMenuReport"
        Me.lblMenuReport.Size = New System.Drawing.Size(162, 45)
        Me.lblMenuReport.TabIndex = 95
        Me.lblMenuReport.Text = "Menu Report"
        '
        'rBtnChefRecomm
        '
        Me.rBtnChefRecomm.BackColor = System.Drawing.Color.Transparent
        Me.rBtnChefRecomm.FlatAppearance.BorderSize = 0
        Me.rBtnChefRecomm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnChefRecomm.Image = CType(resources.GetObject("rBtnChefRecomm.Image"), System.Drawing.Image)
        Me.rBtnChefRecomm.Location = New System.Drawing.Point(1404, 22)
        Me.rBtnChefRecomm.Name = "rBtnChefRecomm"
        Me.rBtnChefRecomm.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.rBtnChefRecomm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rBtnChefRecomm.Size = New System.Drawing.Size(55, 48)
        Me.rBtnChefRecomm.TabIndex = 72
        Me.rBtnChefRecomm.UseVisualStyleBackColor = False
        '
        'rBtnProfile
        '
        Me.rBtnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rBtnProfile.FlatAppearance.BorderSize = 0
        Me.rBtnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnProfile.Image = CType(resources.GetObject("rBtnProfile.Image"), System.Drawing.Image)
        Me.rBtnProfile.Location = New System.Drawing.Point(57, 154)
        Me.rBtnProfile.Name = "rBtnProfile"
        Me.rBtnProfile.Padding = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.rBtnProfile.Size = New System.Drawing.Size(67, 62)
        Me.rBtnProfile.TabIndex = 11
        Me.rBtnProfile.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.lblMenuReport)
        Me.Controls.Add(Me.rBtnMenuReport)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.rBtnDelete)
        Me.Controls.Add(Me.btnScrollToTop)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAddEdit)
        Me.Controls.Add(Me.rBtnAddEdit)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.btnRoundCornerSoup)
        Me.Controls.Add(Me.btnRoundCornerSalad)
        Me.Controls.Add(Me.btnRoundCornerPizza)
        Me.Controls.Add(Me.btnRoundCornerPasta)
        Me.Controls.Add(Me.btnRoundCornerBBQ)
        Me.Controls.Add(Me.lblChefRecomm)
        Me.Controls.Add(Me.rBtnChefRecomm)
        Me.Controls.Add(Me.lblMenuDesc)
        Me.Controls.Add(Me.rBtnProfile)
        Me.Controls.Add(Me.rBtnMenu)
        Me.Controls.Add(Me.rBtnOrder)
        Me.Controls.Add(Me.rBtnHome)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblSidePanel)
        Me.Name = "frmMenu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "frmMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSidePanel As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents rBtnHome As RoundButton
    Friend WithEvents rBtnOrder As RoundButton
    Friend WithEvents rBtnMenu As RoundButton
    Friend WithEvents rBtnProfile As RoundButton
    Friend WithEvents lblMenuDesc As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents rBtnChefRecomm As RoundButton
    Friend WithEvents lblChefRecomm As Label
    Friend WithEvents btnRoundCornerBBQ As Button
    Friend WithEvents btnRoundCornerPasta As Button
    Friend WithEvents btnRoundCornerPizza As Button
    Friend WithEvents btnRoundCornerSalad As Button
    Friend WithEvents btnRoundCornerSoup As Button
    Friend WithEvents lblHome As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents rBtnAddEdit As RoundButton
    Friend WithEvents lblAddEdit As Label
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnScrollToTop As Button
    Friend WithEvents rBtnDelete As RoundButton
    Friend WithEvents lblDelete As Label
    Friend WithEvents rBtnMenuReport As RoundButton
    Friend WithEvents lblMenuReport As Label
End Class
