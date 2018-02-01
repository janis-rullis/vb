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
        Me.genderBox = New System.Windows.Forms.ComboBox
        Me.nameBox = New System.Windows.Forms.ComboBox
        Me.paraditBtn = New System.Windows.Forms.Button
        Me.nameLab = New System.Windows.Forms.Label
        Me.profLab = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.statusLab = New System.Windows.Forms.Label
        Me.ageLabStr = New System.Windows.Forms.Label
        Me.ageLab = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'genderBox
        '
        Me.genderBox.FormattingEnabled = True
        Me.genderBox.Location = New System.Drawing.Point(14, 12)
        Me.genderBox.Name = "genderBox"
        Me.genderBox.Size = New System.Drawing.Size(65, 21)
        Me.genderBox.TabIndex = 0
        '
        'nameBox
        '
        Me.nameBox.FormattingEnabled = True
        Me.nameBox.Location = New System.Drawing.Point(97, 12)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(112, 21)
        Me.nameBox.TabIndex = 1
        '
        'paraditBtn
        '
        Me.paraditBtn.Location = New System.Drawing.Point(134, 131)
        Me.paraditBtn.Name = "paraditBtn"
        Me.paraditBtn.Size = New System.Drawing.Size(75, 23)
        Me.paraditBtn.TabIndex = 2
        Me.paraditBtn.Text = "Parâdît"
        Me.paraditBtn.UseVisualStyleBackColor = True
        '
        'nameLab
        '
        Me.nameLab.AutoSize = True
        Me.nameLab.Location = New System.Drawing.Point(94, 46)
        Me.nameLab.Name = "nameLab"
        Me.nameLab.Size = New System.Drawing.Size(0, 13)
        Me.nameLab.TabIndex = 3
        '
        'profLab
        '
        Me.profLab.AutoSize = True
        Me.profLab.Location = New System.Drawing.Point(94, 64)
        Me.profLab.Name = "profLab"
        Me.profLab.Size = New System.Drawing.Size(0, 13)
        Me.profLab.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Profesija"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vârds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Statuss"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Mainît statusu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'statusLab
        '
        Me.statusLab.AutoSize = True
        Me.statusLab.Location = New System.Drawing.Point(94, 85)
        Me.statusLab.Name = "statusLab"
        Me.statusLab.Size = New System.Drawing.Size(0, 13)
        Me.statusLab.TabIndex = 4
        '
        'ageLabStr
        '
        Me.ageLabStr.AutoSize = True
        Me.ageLabStr.Location = New System.Drawing.Point(94, 108)
        Me.ageLabStr.Name = "ageLabStr"
        Me.ageLabStr.Size = New System.Drawing.Size(0, 13)
        Me.ageLabStr.TabIndex = 4
        '
        'ageLab
        '
        Me.ageLab.AutoSize = True
        Me.ageLab.Location = New System.Drawing.Point(11, 108)
        Me.ageLab.Name = "ageLab"
        Me.ageLab.Size = New System.Drawing.Size(0, 13)
        Me.ageLab.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(233, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 89)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 176)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statusLab)
        Me.Controls.Add(Me.ageLab)
        Me.Controls.Add(Me.ageLabStr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.profLab)
        Me.Controls.Add(Me.nameLab)
        Me.Controls.Add(Me.paraditBtn)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.genderBox)
        Me.Name = "Form1"
        Me.Text = "Pieteikums"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents genderBox As System.Windows.Forms.ComboBox
    Friend WithEvents nameBox As System.Windows.Forms.ComboBox
    Friend WithEvents paraditBtn As System.Windows.Forms.Button
    Friend WithEvents nameLab As System.Windows.Forms.Label
    Friend WithEvents profLab As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents statusLab As System.Windows.Forms.Label
    Friend WithEvents ageLabStr As System.Windows.Forms.Label
    Friend WithEvents ageLab As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
