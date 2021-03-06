Imports System.IO

Public Class Form1

    Dim app_startup_path As String = Application.StartupPath
    ' threads delegati prieks kontrolu izmainisanas
    Delegate Sub SetLabelText_Delegate(ByVal [Label] As Label, ByVal [text] As String, ByVal colr As String)
    Delegate Sub changeBtn_ThreadSafe_Delegate(ByVal [Button] As Button, ByVal colr As String)

    'laika intervala mainigais
    Private countDown_min As Integer

    'aizversanas regulators
    Private close_status As Integer = 0

    'Ctrl + shift + B izsauc settingu fomru     
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.B And e.Control And e.Shift) Then
            Form2.Show()
        End If
    End Sub

    'form load proced.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'aizliedz resize form
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

        'paslēpj minimize, maximize, close joslu
        Me.ControlBox = False

        'atlauj hotkeys
        Me.KeyPreview = True

        'uzstāda statusus un paziņojumus
        Label_drikst_yn.Text = "Nē"
        Label_drikst_yn.ForeColor = Color.Red
        Btn_close.ForeColor = Color.Gray

        MessageBox.Show(Form2.dest_path)
        'parbauda vai eksistē šāda mape
        'If Directory.Exists(Form2.dest_path) = False Then
        'Try
        'Directory.CreateDirectory(Form2.dest_path)
        'Catch ex As Exception
        ' avarijas situacija ja dest mape neeksiste


        '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        'End Try

        'End If

        'palaiž pirmsbekapa taimeri
        countDown_min = 60
        Timer1.Start()

    End Sub

    '1.taimera proced., kas skaita laiku lidz ol aizversanai
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        If countDown_min <> -1 Then
            'label_piespiedu_t.Text = countDown_min
            Label_status.Text = "Datu kopēšana sāksies pēc " & countDown_min & " sek"
            countDown_min = countDown_min - 1
        Else
            Me.Timer1.Stop()
            My_BgWorker.RunWorkerAsync()
        End If
    End Sub

    'procedura kas palaiz batch skriptu
    Private Sub My_BgWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles My_BgWorker.DoWork

        Dim proc As New Process
        Dim cmdStr As String
        With proc.StartInfo
            .FileName = "cmd.exe"
            .WindowStyle = ProcessWindowStyle.Hidden
            .CreateNoWindow = True
            .RedirectStandardInput = True
            .RedirectStandardOutput = True
            .UseShellExecute = False
        End With
        proc.Start()

        Dim reader As StreamReader = proc.StandardOutput
        Dim writer As StreamWriter = proc.StandardInput

        SetLabelText_ThreadSafe(Label_pazinjojums, "Neveriet vaļā Outlook!", "black")
        SetLabelText_ThreadSafe(Label_status, "Kopējas e-pasti", "red")
        'SetLabelText_ThreadSafe(label_piespiedu_t, "", "black")
        'SetLabelText_ThreadSafe(label_piespiedu_laiks_sek, "", "black")

        'palaiž konsolē backup batch skriptu
        cmdStr = """" + app_startup_path + "\jim_backup_script.bat" + """"
        writer.WriteLine(cmdStr)

        Dim counter As Integer = 0
        Dim console_line As String = ""

        'ielasa konsoles rindas
        Do Until counter = 13
            console_line = reader.ReadLine
            counter = counter + 1

            'ja konsoles rinda ir "ol_done"
            If counter = 10 Then
                ol_done()
            End If
            'ja konsoles rinda ir "backup_done"
            If counter = 13 Then
                backup_done()
            End If
        Loop

        'aizver konsoles logu
        writer.WriteLine("exit")
        reader.Close()
        writer.Close()
    End Sub

    'ol_done() proc., kas veic izmaiņas, kad outlook ir nokopērs
    Private Sub ol_done()

        SetLabelText_ThreadSafe(Label_pazinjojums, "Drīkst lietot Outlook!", "green")
        SetLabelText_ThreadSafe(Label_drikst_yn, "Jā", "green")
        SetLabelText_ThreadSafe(Label_status, "Kopējas dokumenti", "red")
    End Sub

    'backup_done() proc., kas veic izmaiņas, kad bekaps ir pabeigts
    Private Sub backup_done()
        'SetLabelText_ThreadSafe(Label_bekapa_statuss2, "Pabeigts", "green")
        SetLabelText_ThreadSafe(Label_status, "Bekaps ir pabeigts!", "green")
        SetLabelText_ThreadSafe(Label_pazinjojums, "Bekaps ir pabeigts!", "green")
        SetLabelText_ThreadSafe(Label_drikst_yn, "Jā", "green")
        Btn_close.ForeColor = Color.Black
        close_status = 1
    End Sub

    'veic label izmainas no thread drošā veidā
    Private Sub SetLabelText_ThreadSafe(ByVal [Label] As Label, ByVal [text] As String, ByVal colr As String)

        If [Label].InvokeRequired Then
            Dim MyDelegate As New SetLabelText_Delegate(AddressOf SetLabelText_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[Label], [text], colr})
        Else
            [Label].Text = [text]
            If colr = "red" Then
                [Label].ForeColor = Color.Red
            End If
            If colr = "green" Then
                [Label].ForeColor = Color.Green
            End If
        End If
    End Sub

    'veic button izmainas no thread drošā veidā
    Private Sub changeBtn_ThreadSafe(ByVal [Button] As Button, ByVal colr As String)

        If [Button].InvokeRequired Then
            Dim MyDelegate As New changeBtn_ThreadSafe_Delegate(AddressOf changeBtn_ThreadSafe)
            Me.Invoke(MyDelegate, New Object() {[Button], colr})
        Else
            If colr = "gray" Then
                [Button].ForeColor = Color.Gray
            End If
            If colr = "black" Then
                [Button].ForeColor = Color.Black
            End If
        End If
    End Sub

    'Btn_minimize_Click()
    Private Sub Btn_minimize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Btn_close_Click close() pogas bloķētājs/atbloķētājs
    Private Sub Btn_close_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        If close_status = 0 Then
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub

    'Btn_close_MouseHover() parvēlkot ar peli pāri  aizvert pogai, parādas padoma balons
    Private Sub Btn_close_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_close.MouseHover
        ToolTip1.SetToolTip(Btn_close, "Aizvērt varēs, tad kad būs nokopēti visi faili")
    End Sub

End Class
