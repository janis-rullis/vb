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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.tabComboBox = New System.Windows.Forms.ComboBox
        Me.createDbSetBtn = New System.Windows.Forms.Button
        Me.saveBtn = New System.Windows.Forms.Button
        Me.showDbBtn = New System.Windows.Forms.Button
        Me.sortBtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.sortBox = New System.Windows.Forms.ComboBox
        Me.filterBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.insertBtn = New System.Windows.Forms.Button
        Me.updateBtn = New System.Windows.Forms.Button
        Me.updateBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.colLab = New System.Windows.Forms.Label
        Me.UpdColComboBox = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.delBtn = New System.Windows.Forms.Button
        Me.dSetSourceBox = New System.Windows.Forms.ComboBox
        Me.whereColBox = New System.Windows.Forms.ComboBox
        Me.delWhereBox = New System.Windows.Forms.TextBox
        Me.whereBox = New System.Windows.Forms.TextBox
        Me.delWhereLab = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.readBtn = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.readBox = New System.Windows.Forms.ComboBox
        Me.saveBox = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.insertCol3Lab = New System.Windows.Forms.Label
        Me.insertCol2Lab = New System.Windows.Forms.Label
        Me.insertCol1Lab = New System.Windows.Forms.Label
        Me.insertCol0Lab = New System.Windows.Forms.Label
        Me.insertCol3Box = New System.Windows.Forms.TextBox
        Me.insertCol2Box = New System.Windows.Forms.TextBox
        Me.insertCol1Box = New System.Windows.Forms.TextBox
        Me.insertCol0Box = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(680, 308)
        Me.DataGridView1.TabIndex = 100
        '
        'tabComboBox
        '
        Me.tabComboBox.FormattingEnabled = True
        Me.tabComboBox.Items.AddRange(New Object() {"teacher", "student", "course"})
        Me.tabComboBox.Location = New System.Drawing.Point(562, 31)
        Me.tabComboBox.Name = "tabComboBox"
        Me.tabComboBox.Size = New System.Drawing.Size(121, 21)
        Me.tabComboBox.TabIndex = 1
        Me.tabComboBox.Text = "teacher"
        '
        'createDbSetBtn
        '
        Me.createDbSetBtn.Location = New System.Drawing.Point(515, 58)
        Me.createDbSetBtn.Name = "createDbSetBtn"
        Me.createDbSetBtn.Size = New System.Drawing.Size(75, 23)
        Me.createDbSetBtn.TabIndex = 2
        Me.createDbSetBtn.Text = "Izveidot"
        Me.createDbSetBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(188, 58)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 8
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'showDbBtn
        '
        Me.showDbBtn.Location = New System.Drawing.Point(596, 58)
        Me.showDbBtn.Name = "showDbBtn"
        Me.showDbBtn.Size = New System.Drawing.Size(84, 23)
        Me.showDbBtn.TabIndex = 3
        Me.showDbBtn.Text = "Parâdît"
        Me.showDbBtn.UseVisualStyleBackColor = True
        '
        'sortBtn
        '
        Me.sortBtn.Location = New System.Drawing.Point(711, 262)
        Me.sortBtn.Name = "sortBtn"
        Me.sortBtn.Size = New System.Drawing.Size(72, 23)
        Me.sortBtn.TabIndex = 6
        Me.sortBtn.Text = "Sort"
        Me.sortBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(708, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Filter by first letter"
        '
        'sortBox
        '
        Me.sortBox.FormattingEnabled = True
        Me.sortBox.Location = New System.Drawing.Point(708, 193)
        Me.sortBox.Name = "sortBox"
        Me.sortBox.Size = New System.Drawing.Size(72, 21)
        Me.sortBox.TabIndex = 4
        '
        'filterBox
        '
        Me.filterBox.Location = New System.Drawing.Point(711, 236)
        Me.filterBox.Name = "filterBox"
        Me.filterBox.Size = New System.Drawing.Size(68, 20)
        Me.filterBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(708, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Sort By Col"
        '
        'insertBtn
        '
        Me.insertBtn.Location = New System.Drawing.Point(629, 153)
        Me.insertBtn.Name = "insertBtn"
        Me.insertBtn.Size = New System.Drawing.Size(75, 23)
        Me.insertBtn.TabIndex = 20
        Me.insertBtn.Text = "Insert"
        Me.insertBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(629, 112)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(75, 23)
        Me.updateBtn.TabIndex = 15
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'updateBox
        '
        Me.updateBox.Location = New System.Drawing.Point(212, 116)
        Me.updateBox.Name = "updateBox"
        Me.updateBox.Size = New System.Drawing.Size(75, 20)
        Me.updateBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(209, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Text"
        '
        'colLab
        '
        Me.colLab.AutoSize = True
        Me.colLab.Location = New System.Drawing.Point(520, 121)
        Me.colLab.Name = "colLab"
        Me.colLab.Size = New System.Drawing.Size(13, 13)
        Me.colLab.TabIndex = 100
        Me.colLab.Text = "="
        '
        'UpdColComboBox
        '
        Me.UpdColComboBox.FormattingEnabled = True
        Me.UpdColComboBox.Location = New System.Drawing.Point(307, 115)
        Me.UpdColComboBox.Name = "UpdColComboBox"
        Me.UpdColComboBox.Size = New System.Drawing.Size(81, 21)
        Me.UpdColComboBox.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.delBtn)
        Me.GroupBox5.Controls.Add(Me.dSetSourceBox)
        Me.GroupBox5.Controls.Add(Me.whereColBox)
        Me.GroupBox5.Controls.Add(Me.insertBtn)
        Me.GroupBox5.Controls.Add(Me.delWhereBox)
        Me.GroupBox5.Controls.Add(Me.whereBox)
        Me.GroupBox5.Controls.Add(Me.delWhereLab)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.readBtn)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.readBox)
        Me.GroupBox5.Controls.Add(Me.updateBtn)
        Me.GroupBox5.Controls.Add(Me.UpdColComboBox)
        Me.GroupBox5.Controls.Add(Me.saveBox)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.insertCol3Lab)
        Me.GroupBox5.Controls.Add(Me.insertCol2Lab)
        Me.GroupBox5.Controls.Add(Me.insertCol1Lab)
        Me.GroupBox5.Controls.Add(Me.insertCol0Lab)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.tabComboBox)
        Me.GroupBox5.Controls.Add(Me.insertCol3Box)
        Me.GroupBox5.Controls.Add(Me.insertCol2Box)
        Me.GroupBox5.Controls.Add(Me.insertCol1Box)
        Me.GroupBox5.Controls.Add(Me.insertCol0Box)
        Me.GroupBox5.Controls.Add(Me.updateBox)
        Me.GroupBox5.Controls.Add(Me.showDbBtn)
        Me.GroupBox5.Controls.Add(Me.colLab)
        Me.GroupBox5.Controls.Add(Me.saveBtn)
        Me.GroupBox5.Controls.Add(Me.createDbSetBtn)
        Me.GroupBox5.Location = New System.Drawing.Point(26, 326)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(753, 222)
        Me.GroupBox5.TabIndex = 100
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data set kontroïi"
        '
        'delBtn
        '
        Me.delBtn.Location = New System.Drawing.Point(629, 191)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(75, 23)
        Me.delBtn.TabIndex = 22
        Me.delBtn.Text = "Delete"
        Me.delBtn.UseVisualStyleBackColor = True
        '
        'dSetSourceBox
        '
        Me.dSetSourceBox.FormattingEnabled = True
        Me.dSetSourceBox.Items.AddRange(New Object() {"datu bâze", "typed data set"})
        Me.dSetSourceBox.Location = New System.Drawing.Point(432, 31)
        Me.dSetSourceBox.Name = "dSetSourceBox"
        Me.dSetSourceBox.Size = New System.Drawing.Size(121, 21)
        Me.dSetSourceBox.TabIndex = 0
        Me.dSetSourceBox.Text = "datu bâze"
        '
        'whereColBox
        '
        Me.whereColBox.FormattingEnabled = True
        Me.whereColBox.Location = New System.Drawing.Point(433, 114)
        Me.whereColBox.Name = "whereColBox"
        Me.whereColBox.Size = New System.Drawing.Size(81, 21)
        Me.whereColBox.TabIndex = 13
        '
        'delWhereBox
        '
        Me.delWhereBox.Location = New System.Drawing.Point(548, 194)
        Me.delWhereBox.Name = "delWhereBox"
        Me.delWhereBox.Size = New System.Drawing.Size(75, 20)
        Me.delWhereBox.TabIndex = 21
        '
        'whereBox
        '
        Me.whereBox.Location = New System.Drawing.Point(539, 115)
        Me.whereBox.Name = "whereBox"
        Me.whereBox.Size = New System.Drawing.Size(75, 20)
        Me.whereBox.TabIndex = 14
        '
        'delWhereLab
        '
        Me.delWhereLab.AutoSize = True
        Me.delWhereLab.Location = New System.Drawing.Point(480, 202)
        Me.delWhereLab.Name = "delWhereLab"
        Me.delWhereLab.Size = New System.Drawing.Size(62, 13)
        Me.delWhereLab.TabIndex = 100
        Me.delWhereLab.Text = "where ID = "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "where"
        '
        'readBtn
        '
        Me.readBtn.Location = New System.Drawing.Point(307, 58)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(99, 23)
        Me.readBtn.TabIndex = 10
        Me.readBtn.Text = "ielasît no XML"
        Me.readBtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(284, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Veids"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Veids"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-82, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Veids"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(559, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Tabuka"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(430, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Avots"
        '
        'readBox
        '
        Me.readBox.FormattingEnabled = True
        Me.readBox.Items.AddRange(New Object() {"data", "shema"})
        Me.readBox.Location = New System.Drawing.Point(285, 31)
        Me.readBox.Name = "readBox"
        Me.readBox.Size = New System.Drawing.Size(121, 21)
        Me.readBox.TabIndex = 9
        Me.readBox.Text = "data"
        '
        'saveBox
        '
        Me.saveBox.FormattingEnabled = True
        Me.saveBox.Items.AddRange(New Object() {"data", "shema", "diff"})
        Me.saveBox.Location = New System.Drawing.Point(142, 31)
        Me.saveBox.Name = "saveBox"
        Me.saveBox.Size = New System.Drawing.Size(121, 21)
        Me.saveBox.TabIndex = 7
        Me.saveBox.Text = "data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(430, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Col"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Col"
        '
        'insertCol3Lab
        '
        Me.insertCol3Lab.AutoSize = True
        Me.insertCol3Lab.Location = New System.Drawing.Point(536, 142)
        Me.insertCol3Lab.Name = "insertCol3Lab"
        Me.insertCol3Lab.Size = New System.Drawing.Size(28, 13)
        Me.insertCol3Lab.TabIndex = 100
        Me.insertCol3Lab.Text = "Col4"
        '
        'insertCol2Lab
        '
        Me.insertCol2Lab.AutoSize = True
        Me.insertCol2Lab.Location = New System.Drawing.Point(455, 142)
        Me.insertCol2Lab.Name = "insertCol2Lab"
        Me.insertCol2Lab.Size = New System.Drawing.Size(28, 13)
        Me.insertCol2Lab.TabIndex = 100
        Me.insertCol2Lab.Text = "Col3"
        '
        'insertCol1Lab
        '
        Me.insertCol1Lab.AutoSize = True
        Me.insertCol1Lab.Location = New System.Drawing.Point(371, 142)
        Me.insertCol1Lab.Name = "insertCol1Lab"
        Me.insertCol1Lab.Size = New System.Drawing.Size(28, 13)
        Me.insertCol1Lab.TabIndex = 100
        Me.insertCol1Lab.Text = "Col2"
        '
        'insertCol0Lab
        '
        Me.insertCol0Lab.AutoSize = True
        Me.insertCol0Lab.Location = New System.Drawing.Point(284, 142)
        Me.insertCol0Lab.Name = "insertCol0Lab"
        Me.insertCol0Lab.Size = New System.Drawing.Size(28, 13)
        Me.insertCol0Lab.TabIndex = 100
        Me.insertCol0Lab.Text = "Col1"
        '
        'insertCol3Box
        '
        Me.insertCol3Box.Location = New System.Drawing.Point(539, 156)
        Me.insertCol3Box.Name = "insertCol3Box"
        Me.insertCol3Box.Size = New System.Drawing.Size(75, 20)
        Me.insertCol3Box.TabIndex = 19
        '
        'insertCol2Box
        '
        Me.insertCol2Box.Location = New System.Drawing.Point(458, 156)
        Me.insertCol2Box.Name = "insertCol2Box"
        Me.insertCol2Box.Size = New System.Drawing.Size(75, 20)
        Me.insertCol2Box.TabIndex = 18
        '
        'insertCol1Box
        '
        Me.insertCol1Box.Location = New System.Drawing.Point(374, 156)
        Me.insertCol1Box.Name = "insertCol1Box"
        Me.insertCol1Box.Size = New System.Drawing.Size(75, 20)
        Me.insertCol1Box.TabIndex = 17
        '
        'insertCol0Box
        '
        Me.insertCol0Box.Location = New System.Drawing.Point(287, 156)
        Me.insertCol0Box.Name = "insertCol0Box"
        Me.insertCol0Box.Size = New System.Drawing.Size(75, 20)
        Me.insertCol0Box.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 550)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.sortBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.filterBox)
        Me.Controls.Add(Me.sortBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tabComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents createDbSetBtn As System.Windows.Forms.Button
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents showDbBtn As System.Windows.Forms.Button
    Friend WithEvents sortBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sortBox As System.Windows.Forms.ComboBox
    Friend WithEvents filterBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents insertBtn As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents updateBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colLab As System.Windows.Forms.Label
    Friend WithEvents UpdColComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents saveBox As System.Windows.Forms.ComboBox
    Friend WithEvents readBtn As System.Windows.Forms.Button
    Friend WithEvents readBox As System.Windows.Forms.ComboBox
    Friend WithEvents whereBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents whereColBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dSetSourceBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents insertCol3Lab As System.Windows.Forms.Label
    Friend WithEvents insertCol2Lab As System.Windows.Forms.Label
    Friend WithEvents insertCol1Lab As System.Windows.Forms.Label
    Friend WithEvents insertCol0Lab As System.Windows.Forms.Label
    Friend WithEvents insertCol3Box As System.Windows.Forms.TextBox
    Friend WithEvents insertCol2Box As System.Windows.Forms.TextBox
    Friend WithEvents insertCol1Box As System.Windows.Forms.TextBox
    Friend WithEvents insertCol0Box As System.Windows.Forms.TextBox
    Friend WithEvents delWhereBox As System.Windows.Forms.TextBox
    Friend WithEvents delWhereLab As System.Windows.Forms.Label
    Friend WithEvents delBtn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
