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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.saveBtn = New System.Windows.Forms.Button
        Me.sourceBox = New System.Windows.Forms.TextBox
        Me.destBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.switchGroup = New System.Windows.Forms.GroupBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.statusbar = New System.Windows.Forms.StatusStrip
        Me.statusbarText = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.toolbar = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.menu_file = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_exit = New System.Windows.Forms.ToolStripMenuItem
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_copy = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_act_save = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_status = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_switch = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_save = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_toolbar = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.switchGroup.SuspendLayout()
        Me.statusbar.SuspendLayout()
        Me.toolbar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(578, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 55)
        Me.Button1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button1, "Kopçt mapes saturu")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(15, 114)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(617, 164)
        Me.richTextBox1.TabIndex = 2
        Me.richTextBox1.Text = ""
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(187, 19)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox5.TabIndex = 7
        Me.CheckBox5.Text = "/D"
        Me.ToolTip1.SetToolTip(Me.CheckBox5, "Pârrakstît destination failus, ja tas ir vecâlks par source failu")
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(142, 19)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox4.TabIndex = 8
        Me.CheckBox4.Text = "/R"
        Me.ToolTip1.SetToolTip(Me.CheckBox4, "Atïaut pârrakstît read-only failus")
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(98, 19)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "/E"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "Kopçt arî  tukðâs mapes")
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(53, 19)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(39, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "/H"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Kopçt arî  hidden un system failus")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(38, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "/C"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Turpina kopçt pat ja ir kïûda")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Image = CType(resources.GetObject("saveBtn.Image"), System.Drawing.Image)
        Me.saveBtn.Location = New System.Drawing.Point(500, 51)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(63, 56)
        Me.saveBtn.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.saveBtn, "Saglabât rezultâtus teksta failâ")
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'sourceBox
        '
        Me.sourceBox.Location = New System.Drawing.Point(254, 81)
        Me.sourceBox.Name = "sourceBox"
        Me.sourceBox.Size = New System.Drawing.Size(115, 20)
        Me.sourceBox.TabIndex = 4
        '
        'destBox
        '
        Me.destBox.Location = New System.Drawing.Point(375, 81)
        Me.destBox.Name = "destBox"
        Me.destBox.Size = New System.Drawing.Size(119, 20)
        Me.destBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Source"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Destination"
        '
        'switchGroup
        '
        Me.switchGroup.Controls.Add(Me.CheckBox5)
        Me.switchGroup.Controls.Add(Me.CheckBox4)
        Me.switchGroup.Controls.Add(Me.CheckBox3)
        Me.switchGroup.Controls.Add(Me.CheckBox2)
        Me.switchGroup.Controls.Add(Me.CheckBox1)
        Me.switchGroup.Location = New System.Drawing.Point(9, 62)
        Me.switchGroup.Name = "switchGroup"
        Me.switchGroup.Size = New System.Drawing.Size(236, 46)
        Me.switchGroup.TabIndex = 5
        Me.switchGroup.TabStop = False
        Me.switchGroup.Text = "Switch"
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusbarText, Me.ToolStripProgressBar1})
        Me.statusbar.Location = New System.Drawing.Point(0, 292)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(653, 22)
        Me.statusbar.TabIndex = 7
        Me.statusbar.Text = "StatusStrip1"
        '
        'statusbarText
        '
        Me.statusbarText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.statusbarText.Name = "statusbarText"
        Me.statusbarText.Size = New System.Drawing.Size(436, 17)
        Me.statusbarText.Spring = True
        Me.statusbarText.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 16)
        '
        'toolbar
        '
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton8, Me.ToolStripButton7})
        Me.toolbar.Location = New System.Drawing.Point(0, 24)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(653, 25)
        Me.toolbar.TabIndex = 8
        Me.toolbar.Text = "ToolStrip1"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Saglabât rezultâtus teksta failâ"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Kopçt mapes saturu"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_file, Me.ActionToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(653, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_file
        '
        Me.menu_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_exit})
        Me.menu_file.Name = "menu_file"
        Me.menu_file.Size = New System.Drawing.Size(35, 20)
        Me.menu_file.Text = "File"
        '
        'menu_exit
        '
        Me.menu_exit.Name = "menu_exit"
        Me.menu_exit.Size = New System.Drawing.Size(103, 22)
        Me.menu_exit.Text = "Exit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_copy, Me.menu_act_save})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'menu_copy
        '
        Me.menu_copy.Name = "menu_copy"
        Me.menu_copy.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.menu_copy.Size = New System.Drawing.Size(170, 22)
        Me.menu_copy.Text = "Copy"
        '
        'menu_act_save
        '
        Me.menu_act_save.Name = "menu_act_save"
        Me.menu_act_save.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menu_act_save.Size = New System.Drawing.Size(170, 22)
        Me.menu_act_save.Text = "Save"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_status, Me.menu_switch, Me.menu_save, Me.menu_toolbar})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'menu_status
        '
        Me.menu_status.Checked = True
        Me.menu_status.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_status.Name = "menu_status"
        Me.menu_status.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.menu_status.Size = New System.Drawing.Size(166, 22)
        Me.menu_status.Text = "Statusbar"
        '
        'menu_switch
        '
        Me.menu_switch.Checked = True
        Me.menu_switch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_switch.Name = "menu_switch"
        Me.menu_switch.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.menu_switch.Size = New System.Drawing.Size(166, 22)
        Me.menu_switch.Text = "Switch"
        '
        'menu_save
        '
        Me.menu_save.Checked = True
        Me.menu_save.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_save.Name = "menu_save"
        Me.menu_save.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menu_save.Size = New System.Drawing.Size(166, 22)
        Me.menu_save.Text = "Save"
        '
        'menu_toolbar
        '
        Me.menu_toolbar.Checked = True
        Me.menu_toolbar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_toolbar.Name = "menu_toolbar"
        Me.menu_toolbar.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.menu_toolbar.Size = New System.Drawing.Size(166, 22)
        Me.menu_toolbar.Text = "Toolbar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 314)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.switchGroup)
        Me.Controls.Add(Me.destBox)
        Me.Controls.Add(Me.sourceBox)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Xcopy jr07023"
        Me.switchGroup.ResumeLayout(False)
        Me.switchGroup.PerformLayout()
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents sourceBox As System.Windows.Forms.TextBox
    Friend WithEvents destBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents switchGroup As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents statusbarText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menu_file As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_act_save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_status As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_switch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents menu_toolbar As System.Windows.Forms.ToolStripMenuItem

End Class
