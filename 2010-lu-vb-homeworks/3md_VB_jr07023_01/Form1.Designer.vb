<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.nameBox1 = New System.Windows.Forms.TextBox
        Me.surnameBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.AgeBox1 = New System.Windows.Forms.TextBox
        Me.AutoRegBox1 = New System.Windows.Forms.MaskedTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.emptyError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.NotCorrectError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.emptyError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotCorrectError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameBox1
        '
        Me.nameBox1.Location = New System.Drawing.Point(96, 28)
        Me.nameBox1.Name = "nameBox1"
        Me.nameBox1.Size = New System.Drawing.Size(100, 20)
        Me.nameBox1.TabIndex = 0
        '
        'surnameBox1
        '
        Me.surnameBox1.Location = New System.Drawing.Point(96, 57)
        Me.surnameBox1.Name = "surnameBox1"
        Me.surnameBox1.Size = New System.Drawing.Size(100, 20)
        Me.surnameBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1. Vārds"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "2. Uzvārds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3. Vecums"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "4. Auto reģ.nr."
        '
        'AgeBox1
        '
        Me.AgeBox1.Location = New System.Drawing.Point(96, 86)
        Me.AgeBox1.Name = "AgeBox1"
        Me.AgeBox1.Size = New System.Drawing.Size(100, 20)
        Me.AgeBox1.TabIndex = 2
        '
        'AutoRegBox1
        '
        Me.AutoRegBox1.Location = New System.Drawing.Point(96, 116)
        Me.AutoRegBox1.Name = "AutoRegBox1"
        Me.AutoRegBox1.Size = New System.Drawing.Size(100, 20)
        Me.AutoRegBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'emptyError
        '
        Me.emptyError.ContainerControl = Me
        '
        'NotCorrectError
        '
        Me.NotCorrectError.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 187)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AutoRegBox1)
        Me.Controls.Add(Me.AgeBox1)
        Me.Controls.Add(Me.surnameBox1)
        Me.Controls.Add(Me.nameBox1)
        Me.Name = "Form1"
        Me.Text = "Auto_registracija"
        CType(Me.emptyError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotCorrectError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameBox1 As System.Windows.Forms.TextBox
    Friend WithEvents surnameBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AgeBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AutoRegBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents emptyError As System.Windows.Forms.ErrorProvider
    Friend WithEvents NotCorrectError As System.Windows.Forms.ErrorProvider

End Class
