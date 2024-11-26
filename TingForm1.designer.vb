<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TingForm1
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
        Me.lblSidePanel = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.RoundCorner2 = New FoodOrderingSystem.RoundCorner()
        Me.RoundCorner1 = New FoodOrderingSystem.RoundCorner()
        Me.rBtnHome = New FoodOrderingSystem.RoundButton()
        Me.SuspendLayout()
        '
        'lblSidePanel
        '
        Me.lblSidePanel.BackColor = System.Drawing.Color.Orange
        Me.lblSidePanel.ForeColor = System.Drawing.Color.White
        Me.lblSidePanel.Location = New System.Drawing.Point(-16, -15)
        Me.lblSidePanel.Name = "lblSidePanel"
        Me.lblSidePanel.Size = New System.Drawing.Size(84, 600)
        Me.lblSidePanel.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Mistral", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(74, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(164, 34)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, Menu"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(151, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(151, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Image = Global.FoodOrderingSystem.My.Resources.Resources.homeIcon
        Me.btnHome.Location = New System.Drawing.Point(175, 107)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(38, 35)
        Me.btnHome.TabIndex = 2
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'RoundCorner2
        '
        Me.RoundCorner2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RoundCorner2.Location = New System.Drawing.Point(449, 176)
        Me.RoundCorner2.Name = "RoundCorner2"
        Me.RoundCorner2.Size = New System.Drawing.Size(121, 61)
        Me.RoundCorner2.TabIndex = 7
        Me.RoundCorner2.Text = "RoundCorner2"
        '
        'RoundCorner1
        '
        Me.RoundCorner1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RoundCorner1.Location = New System.Drawing.Point(449, 122)
        Me.RoundCorner1.Name = "RoundCorner1"
        Me.RoundCorner1.Size = New System.Drawing.Size(274, 41)
        Me.RoundCorner1.TabIndex = 6
        Me.RoundCorner1.Text = "RoundCorner1"
        '
        'rBtnHome
        '
        Me.rBtnHome.FlatAppearance.BorderSize = 0
        Me.rBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rBtnHome.Image = Global.FoodOrderingSystem.My.Resources.Resources.homeIcon
        Me.rBtnHome.Location = New System.Drawing.Point(12, 122)
        Me.rBtnHome.Name = "rBtnHome"
        Me.rBtnHome.Size = New System.Drawing.Size(43, 41)
        Me.rBtnHome.TabIndex = 5
        Me.rBtnHome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 521)
        Me.Controls.Add(Me.RoundCorner2)
        Me.Controls.Add(Me.RoundCorner1)
        Me.Controls.Add(Me.rBtnHome)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblSidePanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSidePanel As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents rBtnHome As RoundButton
    Friend WithEvents RoundCorner1 As RoundCorner
    Friend WithEvents RoundCorner2 As RoundCorner
End Class
