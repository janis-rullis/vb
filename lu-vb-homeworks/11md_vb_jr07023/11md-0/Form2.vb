Imports System.Data.SqlClient

Public Class Form2

    Public Sub New()
        InitializeComponent()
        dSourceTxtBox.Text = "JANIS-XP\SQLEXPRESS"
        initCatTxtBox.Text = "master"
        integrSecComboBox.Text = "True"
        userTxtBox.ReadOnly = True
        pwTxtBox.ReadOnly = True
    End Sub

    Private Sub integrSecComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles integrSecComboBox.TextChanged
        If integrSecComboBox.Text = "True" Then
            userTxtBox.ReadOnly = True
            pwTxtBox.ReadOnly = True
        Else
            userTxtBox.ReadOnly = False
            pwTxtBox.ReadOnly = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub
End Class
