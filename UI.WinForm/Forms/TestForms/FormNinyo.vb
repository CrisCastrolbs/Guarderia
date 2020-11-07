Imports Domain.Models
Imports Domain.ValueObjects
Imports Infrastructure.Common

Public Class FormNinyo
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        managePermissions()
    End Sub

    Private Sub managePermissions()
        If ActiveUser.c_position = Positions.recepcionista Then
            btnAdd.Enabled = False
            btnEdit.Enabled = False
            btnRemove.Enabled = False
        End If
        'more 
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAnyadir.Click

    End Sub
End Class