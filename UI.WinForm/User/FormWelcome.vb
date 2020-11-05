Imports Infrastructure.Common

Public Class FormWelcome

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString()
        If (Me.Opacity < 1) Then Me.Opacity += 0.05
        If (CircularProgressBar1.Value = 100) Then
            timer1.Stop()
            timer2.Start()
        End If
    End Sub

    Private Sub timer2_Tick(sender As Object, e As EventArgs) Handles timer2.Tick
        Me.Opacity -= 0.1
        If (Me.Opacity = 0) Then
            timer2.Stop()
            Me.Close()
        End If

    End Sub

    Private Sub FormWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = ActiveUser.c_firstName + ", " + ActiveUser.c_lastName
        CircularProgressBar1.Value = 0
        CircularProgressBar1.Maximum = 100
        CircularProgressBar1.Minimum = 0
        Me.Opacity = 0.0
        timer1.Start()
    End Sub

End Class