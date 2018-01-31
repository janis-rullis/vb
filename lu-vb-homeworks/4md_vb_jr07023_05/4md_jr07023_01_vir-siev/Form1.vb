Imports System.Windows.Forms

Public Class Form1
    Dim spio As New showPersInfoOvrd
    Dim spi As New showPersInfo

    'form1 load
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.genderBox.Text = "v�rietis"
        Me.genderBox.Items.Add("v�rietis")
        Me.genderBox.Items.Add("sieviete")
        'izsauc overrided konstruktoru
        spio.ha()
        spio.nameBoxItems("v�rietis")
    End Sub

    'dzimums box text change 
    Private Sub f1GenderBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles genderBox.TextChanged
        'izsauc overrided proced�ru, kura aizpilda v�rds combox sarakstu atkar�b� no dzimuma  
        If genderBox Is Nothing Then
            Exit Sub
        Else : spio.nameBoxItems(genderBox.Text)
        End If

    End Sub

    'paradit button click
    Private Sub paraditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paraditBtn.Click
        'aizpilda labelus
        'vards
        nameLab.Text = nameBox.Text
        profLab.Text = showPersInfo.profesija(nameBox.Text)
        'vecums
        ageLab.Text = "Vecums"
        ageLabStr.Text = spio.age(nameBox.Text)
        'statuss
        If spio.statuss(nameBox.Text) = False Then
            statusLab.Text = "Noraid�ts"
            'izsauc shared proceduru, kas iekraso tekstu
            showPersInfoOvrd.changeFont("red", Me.statusLab)
        ElseIf spio.statuss(nameBox.Text) = True Then
            statusLab.Text = "Akcept�ts"
            'izsauc shared proceduru, kas iekraso tekstu
            showPersInfoOvrd.changeFont("green", Me.statusLab)
        End If
        showPersInfo.persPic(nameBox.Text)
    End Sub

    'mainit button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'maina statusu
        If statusLab.Text.Length = 0 Then
            Exit Sub
        ElseIf statusLab.Text = "Akcept�ts" Then
            spio.statuss(nameBox.Text) = False
            statusLab.Text = "Noraid�ts"
            showPersInfoOvrd.changeFont("red", Me.statusLab)
        ElseIf statusLab.Text = "Noraid�ts" Then
            statusLab.Text = "Akcept�ts"
            showPersInfoOvrd.changeFont("green", Me.statusLab)
            spio.statuss(nameBox.Text) = True
        End If
    End Sub
    
End Class

Public Class showPersInfo
    Dim andris As Boolean
    Dim guntis As Boolean
    Dim janis As Boolean
    Dim raitis As Boolean
    Dim reinis As Boolean
    Dim aija As Boolean
    Dim anete As Boolean
    Dim linda As Boolean
    Dim mara As Boolean
    Dim ruta As Boolean
    Dim andrisPic As String
    Dim guntisPic As String
    Dim janisPic As String
    Dim raitisPic As String
    Dim reinisPic As String
    Dim aijaPic As String
    Dim anetePic As String
    Dim lindaPic As String
    Dim maraPic As String
    Dim rutaPic As String


    '1.konstruktors, kas izveido norades uz atteliem
    Public Sub New()
        andrisPic = "Andris.jpg"
        guntisPic = "Guntis.jpg"
        janisPic = "J�is.jpg"
        raitisPic = "Raitis.jpg"
        reinisPic = "Reinis.jpg"
        aijaPic = "Aija.jpg"
        anetePic = "Anete.jpg"
        lindaPic = "Linda.jpg"
        maraPic = "M�ra.jpg"
        rutaPic = "Ruta.jpg"
    End Sub

    'shared metode, kas parada personas bildi
    Shared Sub persPic(ByVal persName As String)
        Try
            Form1.PictureBox1.Image = Image.FromFile("\images\" & persName & ".jpg")
        Catch ex As Exception
            'pazi�o par k��du, ja nevar atrast att�la failu
            MessageBox.Show("Probl�mas ar att�lu!")
            Exit Sub
        End Try
    End Sub

    '2.konstruktors, pieskir personam atteikts/noraidits statusu
    Public Overridable Sub ha()
        andris = True
        guntis = True
        janis = True
        raitis = False
        reinis = True
        aija = False
        anete = True
        linda = True
        mara = False
        ruta = False
    End Sub

    'overridable proced�ra, kas aizpilda v�rds combox sarakstu atkar�b� no dzimuma  
    Public Overridable Sub nameBoxItems(ByVal gender As String)
        If gender = "v�rietis" Then
            Form1.nameBox.Items.Clear()
            Form1.nameBox.Items.Add("Andris")
            Form1.nameBox.Items.Add("Guntis")
            Form1.nameBox.Items.Add("J�nis")
            Form1.nameBox.Items.Add("Raitis")
            Form1.nameBox.Items.Add("Reinis")
            Form1.nameBox.Text = "Andris"
        ElseIf gender = "sieviete" Then
            Form1.nameBox.Items.Clear()
            Form1.nameBox.Items.Add("Aija")
            Form1.nameBox.Items.Add("Anete")
            Form1.nameBox.Items.Add("Linda")
            Form1.nameBox.Items.Add("M�ra")
            Form1.nameBox.Items.Add("Ruta")
            Form1.nameBox.Text = "Aija"
        End If
    End Sub

    'read-only property personas profesija 
    Shared ReadOnly Property profesija(ByVal persName As String) As String
        Get
            If persName = "Andris" Then
                Return ("Namsaimnieks")
            ElseIf persName = "Guntis" Then
                Return ("Pedagogs")
            ElseIf persName = "J�nis" Then
                Return ("Students")
            ElseIf persName = "Raitis" Then
                Return ("Projektu vad�t�js")
            ElseIf persName = "Reinis" Then
                Return ("Students")
            ElseIf persName = "Aija" Then
                Return ("Students")
            ElseIf persName = "Anete" Then
                Return ("B�vin�enieris")
            ElseIf persName = "Linda" Then
                Return ("M�kslas darbinieks")
            ElseIf persName = "M�ra" Then
                Return ("Tulks")
            ElseIf persName = "Ruta" Then
                Return ("M�jsaimniece")
            End If
            Return ""
        End Get
    End Property

    'read-write property status
    Public Overridable Property statuss(ByVal persName As String) As Boolean
        Get
            If persName = "Andris" Then
                Return andris
            ElseIf persName = "Guntis" Then
                Return guntis
            ElseIf persName = "J�nis" Then
                Return janis
            ElseIf persName = "Raitis" Then
                Return raitis
            ElseIf persName = "Reinis" Then
                Return reinis
            ElseIf persName = "Aija" Then
                Return aija
            ElseIf persName = "Anete" Then
                Return anete
            ElseIf persName = "Linda" Then
                Return linda
            ElseIf persName = "M�ra" Then
                Return mara
            ElseIf persName = "Ruta" Then
                Return ruta
            End If
            MessageBox.Show("Statusa ielases k��da!")
            Return False
        End Get
        Set(ByVal status As Boolean)
            If persName = "Andris" Then
                andris = status
            ElseIf persName = "Guntis" Then
                guntis = status
            ElseIf persName = "J�nis" Then
                janis = status
            ElseIf persName = "Raitis" Then
                raitis = status
            ElseIf persName = "Reinis" Then
                reinis = status
            ElseIf persName = "Aija" Then
                aija = status
            ElseIf persName = "Anete" Then
                anete = status
            ElseIf persName = "Linda" Then
                linda = status
            ElseIf persName = "M�ra" Then
                mara = status
            ElseIf persName = "Ruta" Then
                ruta = status
            End If
        End Set
    End Property
End Class

Public Class showPersInfoOvrd
    Inherits showPersInfo
    Dim andris As Boolean
    Dim guntis As Boolean
    Dim janis As Boolean
    Dim raitis As Boolean
    Dim reinis As Boolean
    Dim aija As Boolean
    Dim anete As Boolean
    Dim linda As Boolean
    Dim mara As Boolean
    Dim ruta As Boolean
    Dim andrisAge As String
    Dim guntisAge As String
    Dim janisAge As String
    Dim raitisAge As String
    Dim reinisAge As String
    Dim aijaAge As String
    Dim aneteAge As String
    Dim lindaAge As String
    Dim maraAge As String
    Dim rutaAge As String

    'overrided statusa property
    Public Overrides Property statuss(ByVal persName As String) As Boolean
        Get
            If persName = "Andris" Then
                Return andris
            ElseIf persName = "Guntis" Then
                Return guntis
            ElseIf persName = "J�nis" Then
                Return janis
            ElseIf persName = "Raitis" Then
                Return raitis
            ElseIf persName = "Reinis" Then
                Return reinis
            ElseIf persName = "Aija" Then
                Return aija
            ElseIf persName = "Anete" Then
                Return anete
            ElseIf persName = "Linda" Then
                Return linda
            ElseIf persName = "M�ra" Then
                Return mara
            ElseIf persName = "Ruta" Then
                Return ruta
            End If
            MessageBox.Show("Statusa ielases k��da!")
            Return False
        End Get
        Set(ByVal status As Boolean)
            If persName = "Andris" Then
                andris = status
            ElseIf persName = "Guntis" Then
                guntis = status
            ElseIf persName = "J�nis" Then
                janis = status
            ElseIf persName = "Raitis" Then
                raitis = status
            ElseIf persName = "Reinis" Then
                reinis = status
            ElseIf persName = "Aija" Then
                aija = status
            ElseIf persName = "Anete" Then
                anete = status
            ElseIf persName = "Linda" Then
                linda = status
            ElseIf persName = "M�ra" Then
                mara = status
            ElseIf persName = "Ruta" Then
                ruta = status
            End If
        End Set
    End Property

    'overrided konstruktors, kas pie��ir person�m atteikts/noraid�s statusu un vecumu
    Public Overrides Sub ha()
        andris = True
        guntis = True
        janis = True
        raitis = False
        reinis = True
        aija = False
        anete = True
        linda = True
        mara = False
        ruta = False
        'papildinajums, personu vecums
        andrisAge = 37
        guntisAge = 20
        janisAge = 21
        raitisAge = 60
        reinisAge = 44
        aijaAge = 50
        aneteAge = 18
        lindaAge = 43
        maraAge = 23
        rutaAge = 56
      
    End Sub

    'Shared metode, kas izmaina fontu
    Shared Sub changeFont(ByVal value As String, ByVal objName As Label)
        Dim newFont As Font
        If value = "bold" Then
            newFont = New Font("Arial", 8, FontStyle.Bold)
            objName.Font = newFont
        ElseIf value = "red" Then
            objName.ForeColor = Color.Red
        ElseIf value = "green" Then
            objName.ForeColor = Color.Green
        End If

    End Sub

    Public Overrides Sub nameBoxItems(ByVal gender As String)
        If gender = "v�rietis" Then
            Form1.nameBox.Items.Clear()
            Form1.nameBox.Items.Add("Andris")
            Form1.nameBox.Items.Add("Guntis")
            Form1.nameBox.Items.Add("J�nis")
            Form1.nameBox.Items.Add("Raitis")
            Form1.nameBox.Items.Add("Reinis")
            Form1.nameBox.Text = "Andris"
        ElseIf gender = "sieviete" Then
            Form1.nameBox.Items.Clear()
            Form1.nameBox.Items.Add("Aija")
            Form1.nameBox.Items.Add("Anete")
            Form1.nameBox.Items.Add("Linda")
            Form1.nameBox.Items.Add("M�ra")
            Form1.nameBox.Items.Add("Ruta")
            Form1.nameBox.Text = "Aija"
        End If
        'papildus, izsauc fonta mainisanas metodi
        changeFont("bold", Form1.nameLab)
    End Sub

    Public ReadOnly Property age(ByVal persName As String) As String
        Get
            If persName = "Andris" Then
                Return andrisAge
            ElseIf persName = "Guntis" Then
                Return guntisAge
            ElseIf persName = "J�nis" Then
                Return janisAge
            ElseIf persName = "Raitis" Then
                Return raitisAge
            ElseIf persName = "Reinis" Then
                Return reinisAge
            ElseIf persName = "Aija" Then
                Return aijaAge
            ElseIf persName = "Anete" Then
                Return aneteAge
            ElseIf persName = "Linda" Then
                Return lindaAge
            ElseIf persName = "M�ra" Then
                Return maraAge
            ElseIf persName = "Ruta" Then
                Return rutaAge
            End If
            Return ""
        End Get
    End Property

End Class