<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btn = New System.Windows.Forms.Button
        Me.nameBox = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.surnameBox = New System.Windows.Forms.TextBox
        Me.ageBox = New System.Windows.Forms.TextBox
        Me.heightBox = New System.Windows.Forms.TextBox
        Me.weightBox = New System.Windows.Forms.TextBox
        Me.langBox = New System.Windows.Forms.ComboBox
        Me.nameLab = New System.Windows.Forms.Label
        Me.surnameLab = New System.Windows.Forms.Label
        Me.ageLab = New System.Windows.Forms.Label
        Me.heightLab = New System.Windows.Forms.Label
        Me.weightLab = New System.Windows.Forms.Label
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.langLab = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(101, 250)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 0
        Me.btn.Text = "Aprçíinât"
        Me.ToolTip1.SetToolTip(Me.btn, "Aprçíinât")
        Me.btn.UseVisualStyleBackColor = True
        '
        'nameBox
        '
        Me.HelpProvider1.SetHelpString(Me.nameBox, "Ievadiet Jûsu vârdu!")
        Me.nameBox.Location = New System.Drawing.Point(91, 75)
        Me.nameBox.Name = "nameBox"
        Me.HelpProvider1.SetShowHelp(Me.nameBox, True)
        Me.nameBox.Size = New System.Drawing.Size(100, 20)
        Me.nameBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.nameBox, "Ievadiet Jûsu vârdu!")
        '
        'surnameBox
        '
        Me.HelpProvider1.SetHelpString(Me.surnameBox, "Ievadiet Jûsu uzvârdu!")
        Me.surnameBox.Location = New System.Drawing.Point(91, 110)
        Me.surnameBox.Name = "surnameBox"
        Me.HelpProvider1.SetShowHelp(Me.surnameBox, True)
        Me.surnameBox.Size = New System.Drawing.Size(100, 20)
        Me.surnameBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.surnameBox, "Ievadiet Jûsu uzvârdu!")
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(91, 143)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(100, 20)
        Me.ageBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ageBox, "Ievadiet Jûsu vecumu!")
        '
        'heightBox
        '
        Me.heightBox.Location = New System.Drawing.Point(91, 176)
        Me.heightBox.Name = "heightBox"
        Me.heightBox.Size = New System.Drawing.Size(100, 20)
        Me.heightBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.heightBox, "Ievadiet Jûsu augumu (cm)!")
        '
        'weightBox
        '
        Me.weightBox.Location = New System.Drawing.Point(91, 209)
        Me.weightBox.Name = "weightBox"
        Me.weightBox.Size = New System.Drawing.Size(100, 20)
        Me.weightBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.weightBox, "Ievadiet Jûsu svaru (kg)!")
        '
        'langBox
        '
        Me.langBox.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.langBox, "")
        Me.langBox.Location = New System.Drawing.Point(91, 22)
        Me.langBox.Name = "langBox"
        Me.HelpProvider1.SetShowHelp(Me.langBox, True)
        Me.langBox.Size = New System.Drawing.Size(100, 21)
        Me.langBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.langBox, "Izvçlaties valodu")
        '
        'nameLab
        '
        Me.nameLab.AutoSize = True
        Me.nameLab.Location = New System.Drawing.Point(13, 75)
        Me.nameLab.Name = "nameLab"
        Me.nameLab.Size = New System.Drawing.Size(34, 13)
        Me.nameLab.TabIndex = 2
        Me.nameLab.Text = "Vârds"
        '
        'surnameLab
        '
        Me.surnameLab.AutoSize = True
        Me.surnameLab.Location = New System.Drawing.Point(13, 110)
        Me.surnameLab.Name = "surnameLab"
        Me.surnameLab.Size = New System.Drawing.Size(46, 13)
        Me.surnameLab.TabIndex = 2
        Me.surnameLab.Text = "Uzvârds"
        '
        'ageLab
        '
        Me.ageLab.AutoSize = True
        Me.ageLab.Location = New System.Drawing.Point(13, 143)
        Me.ageLab.Name = "ageLab"
        Me.ageLab.Size = New System.Drawing.Size(45, 13)
        Me.ageLab.TabIndex = 2
        Me.ageLab.Text = "Vecums"
        '
        'heightLab
        '
        Me.heightLab.AutoSize = True
        Me.heightLab.Location = New System.Drawing.Point(13, 176)
        Me.heightLab.Name = "heightLab"
        Me.heightLab.Size = New System.Drawing.Size(45, 13)
        Me.heightLab.TabIndex = 2
        Me.heightLab.Text = "Augums"
        '
        'weightLab
        '
        Me.weightLab.AutoSize = True
        Me.weightLab.Location = New System.Drawing.Point(14, 209)
        Me.weightLab.Name = "weightLab"
        Me.weightLab.Size = New System.Drawing.Size(34, 13)
        Me.weightLab.TabIndex = 2
        Me.weightLab.Text = "Svars"
        '
        'langLab
        '
        Me.langLab.AutoSize = True
        Me.langLab.Location = New System.Drawing.Point(14, 30)
        Me.langLab.Name = "langLab"
        Me.langLab.Size = New System.Drawing.Size(40, 13)
        Me.langLab.TabIndex = 2
        Me.langLab.Text = "Valoda"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 294)
        Me.Controls.Add(Me.langBox)
        Me.Controls.Add(Me.weightBox)
        Me.Controls.Add(Me.heightBox)
        Me.Controls.Add(Me.ageBox)
        Me.Controls.Add(Me.surnameBox)
        Me.Controls.Add(Me.weightLab)
        Me.Controls.Add(Me.heightLab)
        Me.Controls.Add(Me.ageLab)
        Me.Controls.Add(Me.surnameLab)
        Me.Controls.Add(Me.langLab)
        Me.Controls.Add(Me.nameLab)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.btn)
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Find)
        Me.Name = "Form1"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Porcijas aprçíinâtâjs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents nameBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents nameLab As System.Windows.Forms.Label
    Friend WithEvents surnameBox As System.Windows.Forms.TextBox
    Friend WithEvents surnameLab As System.Windows.Forms.Label
    Friend WithEvents ageLab As System.Windows.Forms.Label
    Friend WithEvents ageBox As System.Windows.Forms.TextBox
    Friend WithEvents heightLab As System.Windows.Forms.Label
    Friend WithEvents heightBox As System.Windows.Forms.TextBox
    Friend WithEvents weightLab As System.Windows.Forms.Label
    Friend WithEvents weightBox As System.Windows.Forms.TextBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents langBox As System.Windows.Forms.ComboBox
    Friend WithEvents langLab As System.Windows.Forms.Label

End Class
