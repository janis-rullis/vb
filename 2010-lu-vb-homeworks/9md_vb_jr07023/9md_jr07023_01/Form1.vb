Public Class Form1
    Dim errorAgeStr As String
    Dim errorWeightStr As String
    Dim errorHeightStr As String
    Dim smallPortStr As String
    Dim medPortStr As String
    Dim bigPortStr As String

    Public Sub New()
        InitializeComponent()
        'Application.StartupPath - funkcija kas norāda applikacijas mapi
        'norāda helpa atrašanās vietu
        Me.HelpProvider1.HelpNamespace = Application.StartupPath & "\help\index.html"
        Me.HelpButton = True
        'uzstāda tooltipus
        ToolTip1.SetToolTip(langBox, "Izvēlaties valodu!")
        ToolTip1.SetToolTip(nameBox, "Ievadiet Jūsu vārdu!")
        ToolTip1.SetToolTip(surnameBox, "Ievadiet Jūsu uzvārdu!")
        ToolTip1.SetToolTip(surnameBox, "Ievadiet Jūsu vecumu!")
        ToolTip1.SetToolTip(surnameBox, "Ievadiet Jūsu augumu (cm)!")
        ToolTip1.SetToolTip(surnameBox, "Ievadiet Jūsu svaru (kg)!")
        ToolTip1.SetToolTip(btn, "Aprēķināt!")

        'uzstāda valodas items
        langBox.Items.Add("Latviski")
        langBox.Items.Add("English")
        langBox.Items.Add("По русски")
        langBox.Text = "Latviski"
        'uzstada pazinojumu tekstus
        errorAgeStr = "Pārbaudiet vecuma datus"
        errorWeightStr = "Pārbaudiet svara datus"
        errorHeightStr = "Pārbaudiet auguma datus"
        smallPortStr = "Jums pienākas MAZĀ PORCIJA!"
        medPortStr = "Jums pienākas VIDĒJĀ PORCIJA!"
        bigPortStr = "Jums pienākas LIELĀ PORCIJA!"

    End Sub

    'aprēķina porciju atkarībā no auguma, vecuma un garuma
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        If ageBox.Text.Length > 0 And IsNumeric(ageBox.Text) Then
            If heightBox.Text.Length > 0 And IsNumeric(ageBox.Text) Then
                If weightBox.Text.Length > 0 And IsNumeric(ageBox.Text) Then
                    Dim count As Integer
                    ' saskaita vecumu, augumu, svaru un atkariba no rezulta iedala porciju

                    count = Convert.ToInt32(ageBox.Text)
                    count = count + Convert.ToInt32(heightBox.Text)
                    count = count + Convert.ToInt32(weightBox.Text)

                    If count < 250 Then
                        MessageBox.Show(bigPortStr)
                        Exit Sub
                    ElseIf count >= 250 And count < 300 Then
                        MessageBox.Show(medPortStr)
                        Exit Sub
                    ElseIf count > 300 Then
                        MessageBox.Show(smallPortStr)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show(errorWeightStr)
                    Exit Sub
                End If
            Else
                MessageBox.Show(errorHeightStr)
                Exit Sub
            End If
        Else
            MessageBox.Show(errorAgeStr)
            Exit Sub
        End If

    End Sub

    'uzstāda tekstus atkarība no izvēlētās valodas
    Private Sub langBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles langBox.TextChanged
        If langBox.Text = "Latviski" Then
            ToolTip1.SetToolTip(langBox, "Izvēlaties valodu!")
            ToolTip1.SetToolTip(nameBox, "Ievadiet Jūsu vārdu!")
            ToolTip1.SetToolTip(surnameBox, "Ievadiet Jūsu uzvārdu!")
            ToolTip1.SetToolTip(ageBox, "Ievadiet Jūsu vecumu!")
            ToolTip1.SetToolTip(heightBox, "Ievadiet Jūsu augumu (cm)!")
            ToolTip1.SetToolTip(weightBox, "Ievadiet Jūsu svaru (kg)!")
            Me.Text = "Porcijas aprēķinātājs"
            langLab.Text = "Valoda"
            ageLab.Text = "Vecums"
            nameLab.Text = "Vārds"
            surnameLab.Text = "Uzvārds"
            weightLab.Text = "Svars (kg)"
            heightLab.Text = "Augums (cm)"
            btn.Text = "Aprēķināt"
            'uzstada pazinojumu tekstus
            errorAgeStr = "Pārbaudiet vecuma datus"
            errorWeightStr = "Pārbaudiet svara datus"
            errorHeightStr = "Pārbaudiet auguma datus"
            smallPortStr = "Jums pienākas MAZĀ PORCIJA!"
            medPortStr = "Jums pienākas VIDĒJĀ PORCIJA!"
            bigPortStr = "Jums pienākas LIELĀ PORCIJA!"
        End If
        If langBox.Text = "English" Then
            ToolTip1.SetToolTip(langBox, "Chosse language!")
            ToolTip1.SetToolTip(nameBox, "Enter your name!")
            ToolTip1.SetToolTip(surnameBox, "Enter your surname!")
            ToolTip1.SetToolTip(ageBox, "Enter your age!")
            ToolTip1.SetToolTip(heightBox, "Enter your height (cm)!")
            ToolTip1.SetToolTip(weightBox, "Enter your weight (kg)!")
            ToolTip1.SetToolTip(btn, "Calculate")
            Me.Text = "Portion calculator"
            langLab.Text = "Language"
            ageLab.Text = "Age"
            nameLab.Text = "Name"
            surnameLab.Text = "Surname"
            weightLab.Text = "Weight (kg)"
            heightLab.Text = "Height (cm)"
            btn.Text = "Calculate"
            'uzstada pazinojumu tekstus
            errorAgeStr = "Check age data"
            errorWeightStr = "Check weight data"
            errorHeightStr = "Check height data"
            smallPortStr = "You deserve SMALL PORTION"
            medPortStr = "You deserve MEDIUM PORTION"
            bigPortStr = "You deserve LARGE PORTION"

        End If
        If langBox.Text = "По русски" Then
            ToolTip1.SetToolTip(langBox, "выберите язык!")
            ToolTip1.SetToolTip(nameBox, "впишите ваше фамилия!")
            ToolTip1.SetToolTip(surnameBox, "впишите ваше имя!")
            ToolTip1.SetToolTip(ageBox, "впишите ваше возраст!")
            ToolTip1.SetToolTip(heightBox, "впишите ваше высота!")
            ToolTip1.SetToolTip(weightBox, "впишите ваше вес!")
            ToolTip1.SetToolTip(btn, "вычислять")
            Me.Text = "калькулятор порции"
            langLab.Text = "язык"
            ageLab.Text = "возраст"
            nameLab.Text = "имя"
            surnameLab.Text = "фамилия"
            weightLab.Text = "вес (kg)"
            heightLab.Text = "высота (cm)"
            btn.Text = "вычислять"
            'uzstada pazinojumu tekstus
            errorAgeStr = "Проверите даты возрастa"
            errorWeightStr = "Проверите даты весa"
            errorHeightStr = "Проверите даты высота"
            smallPortStr = "вы заслуживайтье маленький порцийу"
            medPortStr = "вы заслуживайтье средний порцийу"
            bigPortStr = "вы заслуживайтье большой порцийу"

        End If
    End Sub
End Class
