Public Class Form1

    Private Sub showForm2Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showForm2Btn.Click
        Form2.Show()
    End Sub

    Private Sub exitBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class