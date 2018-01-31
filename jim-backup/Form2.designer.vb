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
        Me.btn_source = New System.Windows.Forms.Button
        Me.txtBox_source = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_dest_begin = New System.Windows.Forms.Button
        Me.txtBox_dest_begin = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_add_doc = New System.Windows.Forms.Button
        Me.Btn_read_mid = New System.Windows.Forms.Button
        Me.btn_add_email = New System.Windows.Forms.Button
        Me.txtBox_folder_name = New System.Windows.Forms.TextBox
        Me.txtBox_dest_mid_file = New System.Windows.Forms.TextBox
        Me.chkBox_read_mid = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_clear_doc = New System.Windows.Forms.Button
        Me.btn_clear_email = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rTxtBox_doc = New System.Windows.Forms.RichTextBox
        Me.rTxtBox_email = New System.Windows.Forms.RichTextBox
        Me.btn_write = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.rTxtBox_all = New System.Windows.Forms.RichTextBox
        Me.btn_browse_script = New System.Windows.Forms.Button
        Me.txtBox_path_of_script = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_show_script_folder = New System.Windows.Forms.Button
        Me.btn_reset = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_source
        '
        Me.btn_source.Location = New System.Drawing.Point(194, 16)
        Me.btn_source.Name = "btn_source"
        Me.btn_source.Size = New System.Drawing.Size(75, 23)
        Me.btn_source.TabIndex = 1
        Me.btn_source.Text = "Browse"
        Me.btn_source.UseVisualStyleBackColor = True
        '
        'txtBox_source
        '
        Me.txtBox_source.Location = New System.Drawing.Point(13, 19)
        Me.txtBox_source.Name = "txtBox_source"
        Me.txtBox_source.Size = New System.Drawing.Size(175, 20)
        Me.txtBox_source.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Begining"
        '
        'btn_dest_begin
        '
        Me.btn_dest_begin.Location = New System.Drawing.Point(194, 29)
        Me.btn_dest_begin.Name = "btn_dest_begin"
        Me.btn_dest_begin.Size = New System.Drawing.Size(75, 23)
        Me.btn_dest_begin.TabIndex = 4
        Me.btn_dest_begin.Text = "Browse"
        Me.btn_dest_begin.UseVisualStyleBackColor = True
        '
        'txtBox_dest_begin
        '
        Me.txtBox_dest_begin.Location = New System.Drawing.Point(13, 32)
        Me.txtBox_dest_begin.Name = "txtBox_dest_begin"
        Me.txtBox_dest_begin.Size = New System.Drawing.Size(175, 20)
        Me.txtBox_dest_begin.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_source)
        Me.GroupBox1.Controls.Add(Me.txtBox_source)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 53)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_add_doc)
        Me.GroupBox2.Controls.Add(Me.Btn_read_mid)
        Me.GroupBox2.Controls.Add(Me.btn_add_email)
        Me.GroupBox2.Controls.Add(Me.txtBox_folder_name)
        Me.GroupBox2.Controls.Add(Me.txtBox_dest_mid_file)
        Me.GroupBox2.Controls.Add(Me.chkBox_read_mid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btn_dest_begin)
        Me.GroupBox2.Controls.Add(Me.txtBox_dest_begin)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 169)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Destination"
        '
        'btn_add_doc
        '
        Me.btn_add_doc.Location = New System.Drawing.Point(216, 137)
        Me.btn_add_doc.Name = "btn_add_doc"
        Me.btn_add_doc.Size = New System.Drawing.Size(25, 23)
        Me.btn_add_doc.TabIndex = 9
        Me.btn_add_doc.Text = "d"
        Me.btn_add_doc.UseVisualStyleBackColor = True
        '
        'Btn_read_mid
        '
        Me.Btn_read_mid.Location = New System.Drawing.Point(194, 79)
        Me.Btn_read_mid.Name = "Btn_read_mid"
        Me.Btn_read_mid.Size = New System.Drawing.Size(75, 23)
        Me.Btn_read_mid.TabIndex = 10
        Me.Btn_read_mid.Text = "Browse"
        Me.Btn_read_mid.UseVisualStyleBackColor = True
        '
        'btn_add_email
        '
        Me.btn_add_email.Location = New System.Drawing.Point(217, 108)
        Me.btn_add_email.Name = "btn_add_email"
        Me.btn_add_email.Size = New System.Drawing.Size(24, 23)
        Me.btn_add_email.TabIndex = 8
        Me.btn_add_email.Text = "e"
        Me.btn_add_email.UseVisualStyleBackColor = True
        '
        'txtBox_folder_name
        '
        Me.txtBox_folder_name.Location = New System.Drawing.Point(13, 125)
        Me.txtBox_folder_name.Name = "txtBox_folder_name"
        Me.txtBox_folder_name.Size = New System.Drawing.Size(175, 20)
        Me.txtBox_folder_name.TabIndex = 10
        '
        'txtBox_dest_mid_file
        '
        Me.txtBox_dest_mid_file.Location = New System.Drawing.Point(13, 82)
        Me.txtBox_dest_mid_file.Name = "txtBox_dest_mid_file"
        Me.txtBox_dest_mid_file.Size = New System.Drawing.Size(175, 20)
        Me.txtBox_dest_mid_file.TabIndex = 9
        '
        'chkBox_read_mid
        '
        Me.chkBox_read_mid.AutoSize = True
        Me.chkBox_read_mid.Location = New System.Drawing.Point(13, 59)
        Me.chkBox_read_mid.Name = "chkBox_read_mid"
        Me.chkBox_read_mid.Size = New System.Drawing.Size(124, 17)
        Me.chkBox_read_mid.TabIndex = 6
        Me.chkBox_read_mid.Text = "Read middle from file"
        Me.chkBox_read_mid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Folder name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_clear_doc)
        Me.GroupBox3.Controls.Add(Me.btn_clear_email)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.rTxtBox_doc)
        Me.GroupBox3.Controls.Add(Me.rTxtBox_email)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 228)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Backups"
        '
        'btn_clear_doc
        '
        Me.btn_clear_doc.Location = New System.Drawing.Point(288, 180)
        Me.btn_clear_doc.Name = "btn_clear_doc"
        Me.btn_clear_doc.Size = New System.Drawing.Size(16, 23)
        Me.btn_clear_doc.TabIndex = 5
        Me.btn_clear_doc.Text = "x"
        Me.btn_clear_doc.UseVisualStyleBackColor = True
        '
        'btn_clear_email
        '
        Me.btn_clear_email.Location = New System.Drawing.Point(288, 74)
        Me.btn_clear_email.Name = "btn_clear_email"
        Me.btn_clear_email.Size = New System.Drawing.Size(17, 23)
        Me.btn_clear_email.TabIndex = 4
        Me.btn_clear_email.Text = "x"
        Me.btn_clear_email.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Documents"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "E-mail"
        '
        'rTxtBox_doc
        '
        Me.rTxtBox_doc.Location = New System.Drawing.Point(17, 124)
        Me.rTxtBox_doc.Name = "rTxtBox_doc"
        Me.rTxtBox_doc.Size = New System.Drawing.Size(265, 86)
        Me.rTxtBox_doc.TabIndex = 1
        Me.rTxtBox_doc.Text = ""
        '
        'rTxtBox_email
        '
        Me.rTxtBox_email.Location = New System.Drawing.Point(17, 31)
        Me.rTxtBox_email.Name = "rTxtBox_email"
        Me.rTxtBox_email.Size = New System.Drawing.Size(265, 69)
        Me.rTxtBox_email.TabIndex = 0
        Me.rTxtBox_email.Text = ""
        '
        'btn_write
        '
        Me.btn_write.Location = New System.Drawing.Point(535, 272)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(75, 23)
        Me.btn_write.TabIndex = 10
        Me.btn_write.Text = "Write"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'rTxtBox_all
        '
        Me.rTxtBox_all.Location = New System.Drawing.Point(12, 302)
        Me.rTxtBox_all.Name = "rTxtBox_all"
        Me.rTxtBox_all.Size = New System.Drawing.Size(598, 173)
        Me.rTxtBox_all.TabIndex = 11
        Me.rTxtBox_all.Text = ""
        '
        'btn_browse_script
        '
        Me.btn_browse_script.Location = New System.Drawing.Point(241, 273)
        Me.btn_browse_script.Name = "btn_browse_script"
        Me.btn_browse_script.Size = New System.Drawing.Size(75, 23)
        Me.btn_browse_script.TabIndex = 15
        Me.btn_browse_script.Text = "Browse"
        Me.btn_browse_script.UseVisualStyleBackColor = True
        '
        'txtBox_path_of_script
        '
        Me.txtBox_path_of_script.Location = New System.Drawing.Point(11, 274)
        Me.txtBox_path_of_script.Name = "txtBox_path_of_script"
        Me.txtBox_path_of_script.Size = New System.Drawing.Size(224, 20)
        Me.txtBox_path_of_script.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Path of the script file"
        '
        'btn_show_script_folder
        '
        Me.btn_show_script_folder.Location = New System.Drawing.Point(374, 273)
        Me.btn_show_script_folder.Name = "btn_show_script_folder"
        Me.btn_show_script_folder.Size = New System.Drawing.Size(54, 23)
        Me.btn_show_script_folder.TabIndex = 17
        Me.btn_show_script_folder.Text = "Show"
        Me.btn_show_script_folder.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(322, 273)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(46, 23)
        Me.btn_reset.TabIndex = 18
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 487)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_show_script_folder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_browse_script)
        Me.Controls.Add(Me.txtBox_path_of_script)
        Me.Controls.Add(Me.rTxtBox_all)
        Me.Controls.Add(Me.btn_write)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Script"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_source As System.Windows.Forms.Button
    Friend WithEvents txtBox_source As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_dest_begin As System.Windows.Forms.Button
    Friend WithEvents txtBox_dest_begin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_read_mid As System.Windows.Forms.Button
    Friend WithEvents btn_add_email As System.Windows.Forms.Button
    Friend WithEvents txtBox_folder_name As System.Windows.Forms.TextBox
    Friend WithEvents txtBox_dest_mid_file As System.Windows.Forms.TextBox
    Friend WithEvents chkBox_read_mid As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_add_doc As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rTxtBox_doc As System.Windows.Forms.RichTextBox
    Friend WithEvents rTxtBox_email As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_write As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents rTxtBox_all As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_browse_script As System.Windows.Forms.Button
    Friend WithEvents txtBox_path_of_script As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_show_script_folder As System.Windows.Forms.Button
    Friend WithEvents btn_clear_doc As System.Windows.Forms.Button
    Friend WithEvents btn_clear_email As System.Windows.Forms.Button
    Friend WithEvents btn_reset As System.Windows.Forms.Button

End Class
