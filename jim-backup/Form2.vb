Imports System.IO
Public Class Form2

    Dim app_startup_path As String = Application.StartupPath
    Public dest_path As String
    Dim dest_mid As String

    'e-pasta bekapa ceïa masîvs
    Private email_array(5) As String

    'dok bekapa ceïa masîvs
    Private doc_array(10) As String

    'e-pasta masiva counter
    Dim email_counter As Integer = -1

    'dok masiva counter
    Dim doc_counter As Integer = -1

    'skripta rindu masivs
    Private script_row_array(28) As String

    'dok masiva counter
    Dim script_row_counter As Integer = 0

    'form load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'nobloíç mapju atraðanâs vietas laukus, lai piespiestu izmantot Browse
        txtBox_source.ReadOnly = True
        txtBox_dest_begin.ReadOnly = True
        txtBox_dest_mid_file.ReadOnly = True
        txtBox_path_of_script.ReadOnly = True
        txtBox_path_of_script.Text = app_startup_path
    End Sub

    'btn_source_Click(
    Private Sub btn_source_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_source.Click
        'izsauc folder browseri un iekope textboxa izveleto celu
        txtBox_source.ReadOnly = False
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowDialog()
        txtBox_source.Text = FolderBrowserDialog1.SelectedPath
        txtBox_source.ReadOnly = True
    End Sub

    'btn_dest_begin_Click
    Private Sub btn_dest_begin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_dest_begin.Click
        'izsauc folder browseri un iekope textboxa izveleto celu
        txtBox_dest_begin.ReadOnly = False
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowDialog()
        txtBox_dest_begin.Text = FolderBrowserDialog1.SelectedPath
        txtBox_dest_begin.ReadOnly = True
    End Sub

    'btn_read_mid_Click
    Private Sub btn_read_mid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_read_mid.Click
        If chkBox_read_mid.Checked Then
            txtBox_dest_mid_file.ReadOnly = False
            OpenFileDialog1.InitialDirectory = Environment.SpecialFolder.MyComputer
            OpenFileDialog1.ShowDialog()
            txtBox_dest_mid_file.Text = OpenFileDialog1.FileName
            txtBox_dest_mid_file.ReadOnly = True
        Else : Exit Sub
        End If
    End Sub

    'btn_add_email_Click ievieto email_array masiva emaila bekapa instr rindu
    Private Sub btn_add_email_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_add_email.Click

        If email_counter = 5 Then
            MessageBox.Show("Nevar ievietot vairâk par 5 email")
            Exit Sub
        Else
            email_counter = email_counter + 1
            email_array(email_counter) = """" + txtBox_source.Text + """" + " " + """" + txtBox_dest_begin.Text

            If chkBox_read_mid.Checked Then
                'ielasa faila esoso nosaukumu

                dest_mid = read_txt_file()

                email_array(email_counter) = email_array(email_counter) + dest_mid + "\" + My.Computer.Name + "\" + SystemInformation.UserName + "\" + txtBox_folder_name.Text + """"
            Else
                dest_path = txtBox_dest_begin.Text + My.Computer.Name + "\" + SystemInformation.UserName
                email_array(email_counter) = email_array(email_counter) + My.Computer.Name + "\" + SystemInformation.UserName + "\" + txtBox_folder_name.Text + """"
            End If
            If email_counter > 0 Then
                rTxtBox_email.AppendText(Environment.NewLine)
            End If
            rTxtBox_email.Text = rTxtBox_email.Text + email_array(email_counter)
        End If
    End Sub

    'btn_add_doc_Click ievieto oc_array masiva dok bekapa instr rindu
    Private Sub btn_add_doc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_add_doc.Click
        If doc_counter = 10 Then
            MessageBox.Show("Nevar ievietot vairâk par 10 dok")
            Exit Sub
        Else
            doc_counter = doc_counter + 1

            doc_array(doc_counter) = """" + txtBox_source.Text + """" + " " + """" + txtBox_dest_begin.Text

            If chkBox_read_mid.Checked Then
                'ielasa faila esoso nosaukumu
                Dim dest_mid As String
                dest_mid = read_txt_file()
                doc_array(doc_counter) = doc_array(doc_counter) + dest_mid + "\" + My.Computer.Name + "\" + SystemInformation.UserName + "\" + txtBox_folder_name.Text + """"
            Else
                doc_array(doc_counter) = doc_array(doc_counter) + My.Computer.Name + "\" + SystemInformation.UserName + "\" + txtBox_folder_name.Text + """"
            End If
            If doc_counter > 0 Then
                rTxtBox_doc.AppendText(Environment.NewLine)
            End If
            rTxtBox_doc.Text = rTxtBox_doc.Text + doc_array(doc_counter)
        End If
    End Sub

    'btn_browse_script_Click() norada scripta mapi
    Private Sub btn_browse_script_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_browse_script.Click
        txtBox_path_of_script.ReadOnly = False
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.ShowDialog()
        txtBox_path_of_script.Text = FolderBrowserDialog1.SelectedPath
        txtBox_path_of_script.ReadOnly = True
    End Sub

    'btn_reset_Click() uzstada defaulto scripta ceïu
    Private Sub btn_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        txtBox_path_of_script.Text = app_startup_path
    End Sub

    'read_txt_file() funkc. nolasa txt failu
    Private Function read_txt_file() As String
        Dim fileReader As System.IO.StreamReader
        ' ja fails neeksiste tad iziet no if
        fileReader = My.Computer.FileSystem.OpenTextFileReader(txtBox_dest_mid_file.Text)
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        Return stringReader
    End Function

    'btn_write_Click, proced., kas papildina izveido nepiecieðamo skriptu
    Private Sub btn_write_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_write.Click

        If chkBox_read_mid.Checked Then
            dest_path = txtBox_dest_begin.Text + dest_mid + "\" + My.Computer.Name + "\" + SystemInformation.UserName
        Else
            dest_path = txtBox_dest_begin.Text + My.Computer.Name + "\" + SystemInformation.UserName
        End If

        'izsauc proced., kas aizpilda skripta rindu masivu ar skripta rindam
        fill_script_row_array()

        rTxtBox_all.Clear()
        'izsauc proced., kas aizpilda rezultâta rich text box
        fill_result_rtb()

        'izsauc txt failaa rakstis proced.
        write_txt_file()

    End Sub

    'fill_result_rtb() proced., kas aizpilda rezultâta rich text box
    Private Sub fill_result_rtb()
        Dim counter As Integer = 0
        Do Until counter = script_row_counter
            rTxtBox_all.Text = rTxtBox_all.Text + script_row_array(counter)
            rTxtBox_all.AppendText(Environment.NewLine)
            counter = counter + 1
        Loop
    End Sub

    'fill_script_row_array() proced., kas aizpilda skripta rindu masivu    '
    Private Sub fill_script_row_array()
        'outlook aizveross skripts

        script_row_array(script_row_counter) = "echo off"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = ":LoopStart"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "taskkill /im " + """" + "outlook.exe" + """" + " 2> " + """" + app_startup_path + "\outlook_status.txt" + """"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "find c:\outlook_status.txt " + """" + "not found" + """" + ">nul"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "goto :%errorlevel%"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = ":1"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "echo " + """" + "OL ir ON" + """"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "goto:Loopstart"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = ":0"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "echo " + """" + "OL ir OFF" + """"
        script_row_counter = script_row_counter + 1

        'cikls, kas pievieno e-maila instrukcijam papildus komandas
        Dim counter As Integer = 0
        Do Until counter = email_counter + 1
            script_row_array(script_row_counter) = """" + Application.StartupPath() + "\robocopy" + """" + " " + email_array(counter) + " /ZB /V /TBD /E /FP /NP /LOG+:" + dest_path + "\jim_backup_log.txt"
            script_row_counter = script_row_counter + 1
            counter = counter + 1
        Loop

        'rinda, kas paziòo, ka outlook ir aizvçrts
        script_row_array(script_row_counter) = "echo ol_done"
        script_row_counter = script_row_counter + 1

        'cikls, kas pievieno dok instrukcijam papildus komandas
        counter = 0
        Do Until counter = doc_counter + 1
            script_row_array(script_row_counter) = """" + Application.StartupPath() + "\robocopy" + """" + " " + doc_array(counter) + " /ZB /V /TBD /E /FP /NP /LOG+:" + dest_path + "\jim_backup_log.txt"
            script_row_counter = script_row_counter + 1
            counter = counter + 1
        Loop

        script_row_array(script_row_counter) = "echo backup_done"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "del " + """" + app_startup_path + "\outlook_status.txt" + """" + " /f /q"
        script_row_counter = script_row_counter + 1
        script_row_array(script_row_counter) = "goto:eof"
        script_row_counter = script_row_counter + 1
    End Sub

    'write_txt_file() proced. raksta scripta failu
    Private Sub write_txt_file()

        Dim counter As Integer
        Using writer As StreamWriter = New StreamWriter(txtBox_path_of_script.Text + "\jim_backup_script.bat")
            Do Until counter = script_row_counter
                writer.WriteLine(script_row_array(counter))
                counter = counter + 1
            Loop
        End Using
        script_row_counter = 0
    End Sub

    'link_robo_txt_Click links uz robocopy.txt
    Private Sub link_robo_txt_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim str As String
        str = Application.StartupPath() + "\robocopy.txt"
        If File.Exists(str) Then
            System.Diagnostics.Process.Start(str)
        Else
            MessageBox.Show("File not found.")
        End If
    End Sub

    'link_online_Click() links uz robocopy www
    Private Sub link_online_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start("http://technet.microsoft.com/en-us/library/cc733145%28WS.10%29.aspx")
    End Sub

    ' btn_show_script_folder_Click() proced., kas atver skripta mapi
    Private Sub btn_show_script_folder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show_script_folder.Click
        Process.Start("explorer.exe", txtBox_path_of_script.Text)
    End Sub

    'btn_clear_doc_Click notîra email rich text bex
    Private Sub btn_clear_email_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_clear_email.Click
        email_counter = -1
        rTxtBox_email.Clear()
    End Sub

    'btn_clear_doc_Click notîra doc rich text bex
    Private Sub btn_clear_doc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_clear_doc.Click
        doc_counter = -1
        rTxtBox_doc.Clear()
    End Sub

End Class
