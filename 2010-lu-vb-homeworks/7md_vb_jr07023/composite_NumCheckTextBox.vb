Public Class composite_NumCheckTextBox

    Private Sub okBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okBox.Click
        If composTBox.Text.Length > 0 Then
            If IsNumeric(composTBox.Text) Then
                ErrorProvider1.SetError(composTBox, "")
            Else : ErrorProvider1.SetError(composTBox, "Nav skaitlis!")
            End If
        Else : ErrorProvider1.SetError(composTBox, "Tukðs!")
        End If


    End Sub

    Private Sub nodzestBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles nodzestBox.Click
        composTBox.Text = ""
    End Sub
End Class
