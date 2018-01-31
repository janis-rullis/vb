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
        Me.showForm1Btn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox_fancy3 = New _7md_jr07023_022.textBox_fancy
        Me.TextBox_fancy2 = New _7md_jr07023_022.textBox_fancy
        Me.TextBox_fancy1 = New _7md_jr07023_022.textBox_fancy
        Me.SuspendLayout()
        '
        'showForm1Btn
        '
        Me.showForm1Btn.Location = New System.Drawing.Point(132, 237)
        Me.showForm1Btn.Name = "showForm1Btn"
        Me.showForm1Btn.Size = New System.Drawing.Size(65, 23)
        Me.showForm1Btn.TabIndex = 4
        Me.showForm1Btn.Text = "Atpakaï"
        Me.showForm1Btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Uzlabotais TextBox"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "- ""Century"" fonts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "- Izmainîta fona krâsa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Uzlabojumi:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "- Maina fona krâsu atkarîbâ no fokusa"
        '
        'TextBox_fancy3
        '
        Me.TextBox_fancy3.Location = New System.Drawing.Point(40, 195)
        Me.TextBox_fancy3.Name = "TextBox_fancy3"
        Me.TextBox_fancy3.Size = New System.Drawing.Size(102, 22)
        Me.TextBox_fancy3.TabIndex = 2
        '
        'TextBox_fancy2
        '
        Me.TextBox_fancy2.Location = New System.Drawing.Point(40, 167)
        Me.TextBox_fancy2.Name = "TextBox_fancy2"
        Me.TextBox_fancy2.Size = New System.Drawing.Size(102, 22)
        Me.TextBox_fancy2.TabIndex = 1
        '
        'TextBox_fancy1
        '
        Me.TextBox_fancy1.Location = New System.Drawing.Point(40, 139)
        Me.TextBox_fancy1.Name = "TextBox_fancy1"
        Me.TextBox_fancy1.Size = New System.Drawing.Size(102, 22)
        Me.TextBox_fancy1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 272)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.showForm1Btn)
        Me.Controls.Add(Me.TextBox_fancy3)
        Me.Controls.Add(Me.TextBox_fancy2)
        Me.Controls.Add(Me.TextBox_fancy1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_fancy1 As _7md_jr07023_022.textBox_fancy
    Friend WithEvents TextBox_fancy2 As _7md_jr07023_022.textBox_fancy
    Friend WithEvents TextBox_fancy3 As _7md_jr07023_022.textBox_fancy
    Friend WithEvents showForm1Btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
