Public Class inheritChildForm
    Inherits ChildForm
    Private Sub minus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles minus.Click
        If checkInput() = True Then
            TextBox3.Text = matClass.matFunc(TextBox1.Text, TextBox2.Text, "minus")
        End If
    End Sub

    Private Sub split_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles split.Click
        If checkInput() = True Then
            TextBox3.Text = matClass.matFunc(TextBox1.Text, TextBox2.Text, "split")
        End If
    End Sub

    Private Sub times_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles times.Click
        If checkInput() = True Then
            TextBox3.Text = matClass.matFunc(TextBox1.Text, TextBox2.Text, "times")
        End If
    End Sub
End Class