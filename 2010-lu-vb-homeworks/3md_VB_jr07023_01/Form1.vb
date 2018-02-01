Public Class Form1
    Dim textBoxArray(2) As TextBox
    Dim TxtBoxTxt As String

    'konstruktors
    Public Sub New()
        InitializeComponent()
        textBoxArray(0) = nameBox1
        textBoxArray(1) = surnameBox1
        textBoxArray(2) = AgeBox1
        AutoRegBox1.Mask = ">LL|-9999"
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If checkWord() = True Then
            MessageBox.Show("Viss pareizi!")
        End If
    End Sub

    'varda pareizibas parbaudes funkcija
    Private Function checkWord() As Boolean
        Dim countErrors As Integer = 0 'kludu skaitiajs
        Dim indexTxtBox As Integer  ' textbox numurs

        For indexTxtBox = 0 To 2
            'izsauc f-ju kas parbauda vai textbox lauki nav tuksi
            If isEmpty(indexTxtBox) = True Then
                'MessageBox.Show("tukss " & indexTxtBox + 1 & ".lauks")
                NotCorrectError.SetError(textBoxArray(indexTxtBox), "Nedrīkst atstāt tukšu!")
                countErrors = countErrors + 1
            Else
                NotCorrectError.SetError(textBoxArray(indexTxtBox), "")
            End If
        Next

        'izsauc f-ju kas parbauda vai ir auto reg lauks nav tukss
        If isAutoRegEmpty() = True Then
            'MessageBox.Show("tukss " & "4.lauks")
            NotCorrectError.SetError(AutoRegBox1, "Nedrīkst atstāt tukšu!")
            countErrors = countErrors + 1
        Else
            NotCorrectError.SetError(AutoRegBox1, "")
        End If

        For indexTxtBox = 0 To 1
            'izsauc f-ju kas parbauda vai ir ievadits burts
            If isChar(indexTxtBox) = True Then
                'MessageBox.Show("Nepareizi aizpildits " & indexTxtBox + 1 & ".lauks")
                NotCorrectError.SetError(textBoxArray(indexTxtBox), "Nepareizi aizpildits!")
                countErrors = countErrors + 1
            End If
        Next

        'izsauc f-ju kas parbauda vai ir ievadits skaitlis
        If isNum(2) = False Then
            'MessageBox.Show("nepareizi aizpildits " & 3 & ".lauks")
            NotCorrectError.SetError(textBoxArray(2), "Nepareizi aizpildits!")
            countErrors = countErrors + 1
        End If

        'atgriez atbili vai viss aizpildits pareizi
        If countErrors = 0 Then
            'cikls ar exit 
            For i = 0 To 5
                If i = 3 Then
                    Exit For
                End If
            Next

            Return True
        Else
            Return False
        End If

    End Function

    'parbauda vai TextBox'i ir tuksi
    Private Function isEmpty(ByRef indexTxtBox As Integer) As Boolean
        TxtBoxTxt = textBoxArray(indexTxtBox).Text 'ievieto formas tekstu mainigaja
        If TxtBoxTxt.Length = 0 Then
            Return True
        End If
    End Function
    'parbauda vai AutoRegBox ir tukss
    Private Function isAutoRegEmpty() As Boolean
        If AutoRegBox1.Text.Length < 7 Then
            Return True
        Else : Return False
        End If
    End Function
    'parbauda vai burts
    Private Function isChar(ByRef indexTxtBox As Integer) As Boolean
        Dim goodCharArray() As Char = {"a", "ā", "b", "c", "č", "d", "e", "ē", "f", "g", "ģ", "h", "i", "ī", "j", "k", "ķ", "l", "ļ", "m", "n", "ņ", "o", "p", "r", "s", "š", "t", "u", "ū", "v", "w", "x", "y", "z", "ž"}

        Dim indexTxtBoxChar As Integer  'txtbox simbola kartas nr
        Dim indexGoodChar As Integer  'atlauto simb. kartas nr
        Dim match As Integer  'nesakritoso simb skaititajs

        TxtBoxTxt = textBoxArray(indexTxtBox).Text 'ievieto formas tekstu mainigaja

        TxtBoxTxt = TxtBoxTxt.ToLower 'parveido visus burtus uz mazajiem

        Dim TxtBoxTxtChars() As Char = TxtBoxTxt.ToCharArray 'sadala vardu pa simbolam. konverte STRING TO CHAR


        For indexTxtBoxChar = 0 To TxtBoxTxt.Length - 1  'parbauda katru burtu lidz varda beigam
            match = 0
            'salidzina burtu ar atlautajiem
            For indexGoodChar = 0 To 35
                If TxtBoxTxtChars(indexTxtBoxChar) <> goodCharArray(indexGoodChar) Then
                    match = match + 1
                End If
            Next
            'ja burts nav sakritis ar nevienu no atlautajiem tad pazino kludu
            If match = 36 Then
                Return True
            End If
        Next
    End Function
    'skaitlu parbaude ar ISNUMERIC
    Private Function isNum(ByVal indexTxtBox As Integer) As Boolean

        'novers bridinajumu ka nav skaitlis ja ir tukss lauks
        If textBoxArray(indexTxtBox).Text.Length = 0 Then
            Return True
        ElseIf IsNumeric(textBoxArray(indexTxtBox).Text) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class




