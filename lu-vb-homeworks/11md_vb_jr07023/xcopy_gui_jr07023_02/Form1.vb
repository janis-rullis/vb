Imports system.io
Public Class Form1
    'Shared checkBoxArr(5) As CheckBox
    Dim checkBoxArr(5) As CheckBox

    'konsturktors
    Public Sub New()

        InitializeComponent()

        'norada source un destination default ceïus
        '  sourceBox.Text = "C:\x1"
        ' destBox.Text = "C:\x2\"

        'ievieto checkboxu masîvâ
        checkBoxArr(0) = CheckBox1
        checkBoxArr(1) = CheckBox2
        checkBoxArr(2) = CheckBox3
        checkBoxArr(3) = CheckBox4
        checkBoxArr(4) = CheckBox5

        'statusbar teksts
        statusbarText.Text = ""


    End Sub

    'copy click
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'izsauc kopçðanas metodi
        xcopy_gui.copy(checkBoxArr)
    End Sub

    'menu copy click
    Private Sub menu_copy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_copy.Click
        xcopy_gui.copy(checkBoxArr)
    End Sub

    'sourcebox click
    Private Sub sourceBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sourceBox.Click

        'izsauc folder browseri un iekopç textboxî izvçlçto ceïu
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowDialog()
        sourceBox.Text = FolderBrowserDialog1.SelectedPath

    End Sub

    'destbox click
    Private Sub destBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles destBox.Click

        'izsauc folder browseri un iekopç textboxî izvçlçto ceïu
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowDialog()
        destBox.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    'saveBtn click
    Private Sub saveBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveBtn.Click

        'izsauc metodi, kas saglaba richTextBox1 saturu teksta failâ
        xcopy_gui.save()
    End Sub

    'menu save click
    Private Sub menu_act_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_act_save.Click
        'izsauc metodi, kas saglaba richTextBox1 saturu teksta failâ
        xcopy_gui.save()
    End Sub


    'statusbar izmainas parvelkot ar peli pari save un copy pogam

    'copy btn hover
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        'statusbar teksts
        statusbarText.Text = "Copy"
    End Sub
    'copy btn leave
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        'statusbar teksts
        statusbarText.Text = ""
    End Sub

    'save btn leave
    Private Sub saveBtn_Mouseleave(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveBtn.MouseLeave
        'statusbar teksts
        statusbarText.Text = ""
    End Sub
    'save btn hover
    Private Sub saveBtn_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveBtn.MouseHover
        'statusbar teksts
        statusbarText.Text = "Save"
    End Sub

    'save check-uncheck
    Private Sub menu_save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_save.Click
        If menu_save.Checked = True Then
            menu_save.Checked = False
            saveBtn.Visible = False
        Else
            menu_save.Checked = True
            saveBtn.Visible = True
        End If
    End Sub

    'statusbar check-uncheck
    Private Sub menu_status_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_status.Click
        If menu_status.Checked = True Then
            menu_status.Checked = False
            statusbar.Visible = False
        Else
            menu_status.Checked = True
            statusbar.Visible = True
        End If
    End Sub

    'switch check-uncheck
    Private Sub menu_switch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_switch.Click
        If menu_switch.Checked = True Then
            menu_switch.Checked = False
            switchGroup.Visible = False
        Else
            menu_switch.Checked = True
            switchGroup.Visible = True
        End If
    End Sub

    'toolbar check-uncheck
    Private Sub menu_toolbar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_toolbar.Click
        If menu_toolbar.Checked = True Then
            menu_toolbar.Checked = False
            toolbar.Visible = False
        Else
            menu_toolbar.Checked = True
            toolbar.Visible = True
        End If
    End Sub

    'exit btn click 
    Private Sub menu_exit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_exit.Click
        Me.Close()
    End Sub
    
End Class

Class xcopy_gui
    'kopçðanas metode
    Shared Sub copy(ByVal checkBoxArr As CheckBox())

        'izveido jaunu procesu
        Dim proc As New Process

        'norâda, kas par procesu un redierektç in out
        With proc.StartInfo
            'command prompt process
            .FileName = "cmd.exe"
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .UseShellExecute = False
        End With



        Dim cmdStr As String
        'cmd Str - cmd komandas
        cmdStr = "xcopy "

        'parbauda vai ir noraditi ceïi
        If Form1.sourceBox.Text.Length > 0 And Form1.destBox.Text.Length > 0 Then
            Try

                'ja celi ir noradtit tad tos ievieto komandâ
                cmdStr = cmdStr + """" + Form1.sourceBox.Text + """ """ + Form1.destBox.Text + """ "
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Norâdiet source un destination!")
            Exit Sub
        End If


        'parbauda un pievieno ieíekðeto switch'us
        Dim i As Integer
        For i = 0 To 4
            Try
                If checkBoxArr(i).Checked Then
                    cmdStr = cmdStr + checkBoxArr(i).Text + " "
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try

        Next

        'pievieno nejautasanas switchu
        cmdStr = cmdStr + "/y"

        'palaiþ procesu
        proc.Start()
        Dim reader As StreamReader = proc.StandardOutput
        Dim writer As StreamWriter = proc.StandardInput

        Form1.ToolStripProgressBar1.Value = 30

        'statusbar teksts
        Form1.statusbarText.Text = "Kopçðana sâkusies"
        'progressbar status
        Form1.ToolStripProgressBar1.Value = 60

        Form1.statusbarText.Text = cmdStr

        'uzraksta komadnu cmd'â
        writer.WriteLine(cmdStr)
        Form1.statusbarText.Text = "Copying..."
        'iziet no cmd
        writer.WriteLine("exit")

        'statusbar teksts
        Form1.statusbarText.Text = "command prompt exit"
        Form1.ToolStripProgressBar1.Value = 90
        'statusbar teksts
        Form1.statusbarText.Text = ""

        'lauj ierakstit rTextBoxâ
        Form1.richTextBox1.ReadOnly = False

        'rTextBoxâ ieraksta consoles tekstu
        Form1.richTextBox1.Text = reader.ReadToEnd

        'nelauj ierakstit rTextBoxâ
        Form1.richTextBox1.ReadOnly = True

        Form1.ToolStripProgressBar1.Value = 100

        'aizver lasitaju un rakstituaju
        writer.Close()
        reader.Close()
        Form1.ToolStripProgressBar1.Value = 0
    End Sub

    'metode, kas saglaba richTextBox1 saturu teksta failâ
    Shared Sub save()
        'izveido rakstitaju
        Dim textFile As StreamWriter

        'statusbar teksts
        Form1.statusbarText.Text = "Saglabâðana sâkusies"

        'progressbar status
        Form1.ToolStripProgressBar1.Value = 30

        Try
            'izdzes ieprieksejo teksta failu
            If File.Exists("results.txt") Then
                File.Delete("results.txt")
            End If

            textFile = New StreamWriter("results.txt", True)

            'progressbar status
            Form1.ToolStripProgressBar1.Value = 60
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try

        'raksta faila
        Try
            textFile.Write(Form1.richTextBox1.Text)

            'ja rtb ir jauna rinda tad faila ari ieraksta jaunu rindu
            For Each Line As String In Form1.richTextBox1.Lines
                textFile.WriteLine(Line)
            Next

            'progressbar status
            Form1.ToolStripProgressBar1.Value = 100
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        'statusbar teksts
        Form1.statusbarText.Text = "Text saved to results.txt"

        'aizver rakstitaju
        textFile.Close()

        Form1.ToolStripProgressBar1.Value = 0


    End Sub

End Class