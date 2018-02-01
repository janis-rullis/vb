<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inheritChildForm
    Inherits _6md_vb_jr07023_01.ChildForm

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
        Me.minus = New System.Windows.Forms.Button
        Me.times = New System.Windows.Forms.Button
        Me.split = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'minus
        '
        Me.minus.Location = New System.Drawing.Point(164, 81)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(75, 23)
        Me.minus.TabIndex = 5
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'times
        '
        Me.times.Location = New System.Drawing.Point(257, 52)
        Me.times.Name = "times"
        Me.times.Size = New System.Drawing.Size(75, 23)
        Me.times.TabIndex = 6
        Me.times.Text = "*"
        Me.times.UseVisualStyleBackColor = True
        '
        'split
        '
        Me.split.Location = New System.Drawing.Point(257, 81)
        Me.split.Name = "split"
        Me.split.Size = New System.Drawing.Size(75, 23)
        Me.split.TabIndex = 7
        Me.split.Text = "/"
        Me.split.UseVisualStyleBackColor = True
        '
        'inheritChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 160)
        Me.Controls.Add(Me.split)
        Me.Controls.Add(Me.times)
        Me.Controls.Add(Me.minus)
        Me.Name = "inheritChildForm"
        Me.Text = "inheritChildForm"
        Me.Controls.SetChildIndex(Me.minus, 0)
        Me.Controls.SetChildIndex(Me.times, 0)
        Me.Controls.SetChildIndex(Me.split, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents minus As System.Windows.Forms.Button
    Friend WithEvents times As System.Windows.Forms.Button
    Friend WithEvents split As System.Windows.Forms.Button
End Class
