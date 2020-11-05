Imports Infrastructure.Common

Public Class Form1
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        managePermissions()
    End Sub

    Private Sub managePermissions()
        If ActiveUser.c_position = Positions.receptionist Then
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnRemove.Enabled = False
        End If
        'more 
    End Sub
End Class