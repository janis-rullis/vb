Public Class ChildForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If checkInput() = True Then
            TextBox3.Text = matClass.matFunc(TextBox1.Text, TextBox2.Text, "plus")
        End If
    End Sub

    Function checkInput() As Boolean
        If TextBox1.Text.Length > 0 Then
            If TextBox2.Text.Length > 0 Then
                If IsNumeric(TextBox1.Text) Then
                    If IsNumeric(TextBox2.Text) Then
                        Return True
                    Else : MessageBox.Show("Nepareizi aizpildits B")
                    End If
                Else : MessageBox.Show("Nepareizi aizpildits A")
                End If
            Else : MessageBox.Show("Aizpildiet B")
            End If
        Else : MessageBox.Show("Aizpildiet A")
        End If
    End Function

    Public Class matClass

        Shared Function matFunc(ByVal a As String, ByVal b As String, ByVal operatr As String) As String
            Dim aInt As Integer
            Dim bInt As Integer
            Dim c As String
            aInt = Convert.ToInt32(a)
            bInt = Convert.ToInt32(b)

            If operatr = "plus" Then
                aInt = aInt + bInt
            ElseIf operatr = "minus" Then
                aInt = aInt - bInt
            ElseIf operatr = "times" Then
                aInt = aInt * bInt
            ElseIf operatr = "split" Then
                aInt = aInt / bInt
            End If

            c = Convert.ToString(aInt)
            Return c
        End Function
    End Class



End Class
