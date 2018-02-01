<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.dSourceTxtBox = New System.Windows.Forms.TextBox
        Me.initCatTxtBox = New System.Windows.Forms.TextBox
        Me.userTxtBox = New System.Windows.Forms.TextBox
        Me.pwTxtBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.integrSecComboBox = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dSourceTxtBox
        '
        Me.dSourceTxtBox.Location = New System.Drawing.Point(152, 25)
        Me.dSourceTxtBox.Name = "dSourceTxtBox"
        Me.dSourceTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.dSourceTxtBox.TabIndex = 0
        '
        'initCatTxtBox
        '
        Me.initCatTxtBox.Location = New System.Drawing.Point(152, 51)
        Me.initCatTxtBox.Name = "initCatTxtBox"
        Me.initCatTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.initCatTxtBox.TabIndex = 0
        '
        'userTxtBox
        '
        Me.userTxtBox.Location = New System.Drawing.Point(152, 103)
        Me.userTxtBox.Name = "userTxtBox"
        Me.userTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.userTxtBox.TabIndex = 0
        '
        'pwTxtBox
        '
        Me.pwTxtBox.Location = New System.Drawing.Point(152, 129)
        Me.pwTxtBox.Name = "pwTxtBox"
        Me.pwTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.pwTxtBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data source"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Initial catalog"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Integrated security"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password"
        '
        'integrSecComboBox
        '
        Me.integrSecComboBox.FormattingEnabled = True
        Me.integrSecComboBox.Items.AddRange(New Object() {"True", "False"})
        Me.integrSecComboBox.Location = New System.Drawing.Point(152, 77)
        Me.integrSecComboBox.Name = "integrSecComboBox"
        Me.integrSecComboBox.Size = New System.Drawing.Size(91, 21)
        Me.integrSecComboBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.integrSecComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pwTxtBox)
        Me.Controls.Add(Me.userTxtBox)
        Me.Controls.Add(Me.initCatTxtBox)
        Me.Controls.Add(Me.dSourceTxtBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dSourceTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents initCatTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents userTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents pwTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents integrSecComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
