Imports Infrastructure.Common

Public Class Form3
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        managePermissions()
    End Sub
    Private Sub managePermissions()

        If (ActiveUser.c_position = Positions.accounting) Then
            btnRemove.Enabled = False
        End If
    End Sub
End Class