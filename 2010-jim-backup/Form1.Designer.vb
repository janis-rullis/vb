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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label_drikst_yn = New System.Windows.Forms.Label
        Me.Label_drikst = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label_pazinjojums = New System.Windows.Forms.Label
        Me.Label_status = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label_aizveriet_visas = New System.Windows.Forms.Label
        Me.Btn_close = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_minimize = New System.Windows.Forms.Button
        Me.My_BgWorker = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label_drikst_yn)
        Me.GroupBox1.Controls.Add(Me.Label_drikst)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 56)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drīkst lietot Outlook"
        '
        'Label_drikst_yn
        '
        Me.Label_drikst_yn.AutoSize = True
        Me.Label_drikst_yn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.Label_drikst_yn.ForeColor = System.Drawing.Color.Red
        Me.Label_drikst_yn.Location = New System.Drawing.Point(11, 25)
        Me.Label_drikst_yn.Name = "Label_drikst_yn"
        Me.Label_drikst_yn.Size = New System.Drawing.Size(0, 13)
        Me.Label_drikst_yn.TabIndex = 9
        '
        'Label_drikst
        '
        Me.Label_drikst.AutoSize = True
        Me.Label_drikst.Location = New System.Drawing.Point(10, 16)
        Me.Label_drikst.Name = "Label_drikst"
        Me.Label_drikst.Size = New System.Drawing.Size(0, 13)
        Me.Label_drikst.TabIndex = 8
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label_pazinjojums)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(241, 49)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Paziņojums"
        '
        'Label_pazinjojums
        '
        Me.Label_pazinjojums.AutoSize = True
        Me.Label_pazinjojums.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_pazinjojums.ForeColor = System.Drawing.Color.Red
        Me.Label_pazinjojums.Location = New System.Drawing.Point(11, 22)
        Me.Label_pazinjojums.Name = "Label_pazinjojums"
        Me.Label_pazinjojums.Size = New System.Drawing.Size(202, 13)
        Me.Label_pazinjojums.TabIndex = 16
        Me.Label_pazinjojums.Text = "Aizveriet Outlook! (e-pasta prog-a)"
        '
        'Label_status
        '
        Me.Label_status.AutoSize = True
        Me.Label_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_status.Location = New System.Drawing.Point(10, 27)
        Me.Label_status.Name = "Label_status"
        Me.Label_status.Size = New System.Drawing.Size(164, 13)
        Me.Label_status.TabIndex = 6
        Me.Label_status.Text = "Datu kopēšana sāksies pēc"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label_status)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(241, 52)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bekapa status"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label_aizveriet_visas)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(241, 70)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ieteikums"
        '
        'Label_aizveriet_visas
        '
        Me.Label_aizveriet_visas.AutoSize = True
        Me.Label_aizveriet_visas.Location = New System.Drawing.Point(10, 26)
        Me.Label_aizveriet_visas.Name = "Label_aizveriet_visas"
        Me.Label_aizveriet_visas.Size = New System.Drawing.Size(217, 26)
        Me.Label_aizveriet_visas.TabIndex = 12
        Me.Label_aizveriet_visas.Text = "Pirms bekapa aizveriet VISAS prog-as, jo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "atvērtu prog-u dēļ var netikt nokopēti " & _
            "visi faili"
        '
        'Btn_close
        '
        Me.Btn_close.Location = New System.Drawing.Point(12, 285)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(75, 23)
        Me.Btn_close.TabIndex = 18
        Me.Btn_close.Text = "Aizvērt"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'Btn_minimize
        '
        Me.Btn_minimize.Location = New System.Drawing.Point(178, 285)
        Me.Btn_minimize.Name = "Btn_minimize"
        Me.Btn_minimize.Size = New System.Drawing.Size(75, 23)
        Me.Btn_minimize.TabIndex = 19
        Me.Btn_minimize.Text = "Paslēpt"
        Me.Btn_minimize.UseVisualStyleBackColor = True
        '
        'My_BgWorker
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 320)
        Me.Controls.Add(Me.Btn_minimize)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Bekaps (datu rezerves kopiju veidošana)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_drikst_yn As System.Windows.Forms.Label
    Friend WithEvents Label_drikst As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_pazinjojums As System.Windows.Forms.Label
    Friend WithEvents Label_status As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_aizveriet_visas As System.Windows.Forms.Label
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_minimize As System.Windows.Forms.Button
    Friend WithEvents My_BgWorker As System.ComponentModel.BackgroundWorker

End Class
