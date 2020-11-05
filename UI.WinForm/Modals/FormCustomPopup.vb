Imports Infrastructure.Common

Public Class FormCustomPopup
    Public correct As Boolean = False

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If (txtPass.Text = ActiveUser.c_password) Then
            correct = True
            Me.Close()
        Else
            correct = False
            lblResult.Visible = True
            lblResult.Text = "Your current password you entered is incorrect, try again." & vbNewLine &
                "Su contraseña actual que ingresó es incorrecta, intente nuevamente."
        End If
    End Sub

    Private Sub FormCustomPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResult.Visible = False
    End Sub
End Class