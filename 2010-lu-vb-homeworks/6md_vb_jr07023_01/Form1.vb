Public Class Form1
    Dim cForm1 As ChildForm
    Dim icForm1 As inheritChildForm
    Public Sub New()

        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized

    End Sub
    ' new child form
    Private Sub ChildFormToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChildFormToolStripMenuItem.Click
        If cForm1 Is Nothing OrElse Not cForm1.Created Then '....... Form2.Load()
            cForm1 = New ChildForm
            Me.IsMdiContainer = True
            cForm1.MdiParent = Me
            cForm1.Show()
            cForm1.Activate()
            cForm1.Focus()
        Else
            If Dialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                cForm1.Close()
            End If
        End If
    End Sub
    'new inherit child form
    Private Sub InheritedChildFormToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles InheritedChildFormToolStripMenuItem.Click
        If icForm1 Is Nothing OrElse Not icForm1.Created Then '....... Form2.Load()
            icForm1 = New inheritChildForm
            Me.IsMdiContainer = True
            icForm1.MdiParent = Me
            icForm1.Show()
            icForm1.Activate()
            icForm1.Focus()
        Else
            If Dialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
                icForm1.Close()
            End If
        End If
    End Sub
    ' call child form
    Private Sub CallChildFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CallChildFormToolStripMenuItem.Click
        If cForm1 Is Nothing Then
            Exit Sub
        Else
            cForm1.Show()
            cForm1.Activate()
            cForm1.Focus()
        End If
    End Sub
    ' call inherit child form
    Private Sub CToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        If icForm1 Is Nothing Then
            Exit Sub
        Else
            icForm1.Show()
            icForm1.Activate()
            icForm1.Focus()
        End If
    End Sub
    'aizver programmu
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
