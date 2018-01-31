Public Class textBox_fancy

    Public Sub New()

        InitializeComponent()
        Me.TextBox1.BackColor = Color.PowderBlue
        Dim fnt As New Font("Century", 10, FontStyle.Regular, GraphicsUnit.Point)
        Me.TextBox1.Font = fnt

    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        Me.TextBox1.BackColor = Color.Aquamarine
    End Sub


    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Me.TextBox1.BackColor = Color.PowderBlue
    End Sub
End Class
