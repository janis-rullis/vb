<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class composite_NumCheckTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.composTBox = New System.Windows.Forms.TextBox
        Me.nodzestBox = New System.Windows.Forms.Button
        Me.okBox = New System.Windows.Forms.Button
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'composTBox
        '
        Me.composTBox.Location = New System.Drawing.Point(3, 3)
        Me.composTBox.Name = "composTBox"
        Me.composTBox.Size = New System.Drawing.Size(103, 20)
        Me.composTBox.TabIndex = 0
        '
        'nodzestBox
        '
        Me.nodzestBox.Location = New System.Drawing.Point(2, 29)
        Me.nodzestBox.Name = "nodzestBox"
        Me.nodzestBox.Size = New System.Drawing.Size(57, 23)
        Me.nodzestBox.TabIndex = 1
        Me.nodzestBox.Text = "Nodzçst"
        Me.nodzestBox.UseVisualStyleBackColor = True
        '
        'okBox
        '
        Me.okBox.Location = New System.Drawing.Point(65, 29)
        Me.okBox.Name = "okBox"
        Me.okBox.Size = New System.Drawing.Size(41, 23)
        Me.okBox.TabIndex = 2
        Me.okBox.Text = "Ok"
        Me.okBox.UseVisualStyleBackColor = True
        '
        'composite_NumCheckTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.okBox)
        Me.Controls.Add(Me.nodzestBox)
        Me.Controls.Add(Me.composTBox)
        Me.Name = "composite_NumCheckTextBox"
        Me.Size = New System.Drawing.Size(121, 55)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents composTBox As System.Windows.Forms.TextBox
    Friend WithEvents nodzestBox As System.Windows.Forms.Button
    Friend WithEvents okBox As System.Windows.Forms.Button

End Class
