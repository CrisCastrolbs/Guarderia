Imports System.Runtime.InteropServices
Imports Domain.Models
Imports Infrastructure.Common

Public Class FormLogin
#Region "Customize Controls - Personalizar Controles"
    Private Sub CustomizeComponents()
        'txtUser
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 30)
        'txtPass
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 30)
        txtPass.UseSystemPasswordChar = True
    End Sub
    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttonPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttonPath)
    End Sub
#End Region
#Region "Close and Minimize Form - Cerrar y Minimizar Formulario"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region
#Region "Drag Form - Arrastrar/ mover Formulario"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    Private Sub titleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub FormLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub




#End Region

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeComponents()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim userModel As New UserModel()
        Dim validLogin = userModel.logIn(txtUser.Text, txtPass.Text)

        If validLogin = True Then
            Me.Hide()
            Dim welcome As New FormWelcome()
            welcome.ShowDialog()
            Dim frm As New FormPrincipal()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
        Else
            MessageBox.Show("Incorrect username or password entered." + vbNewLine + "Please try again.")
            txtPass.Clear()
            txtPass.Focus()
        End If

    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        'reiniciar formulario login
        txtUser.Clear()
        txtPass.Clear()
        'limpiar cache de usuario
        ActiveUser.c_id = 0
        ActiveUser.c_userName = Nothing
        ActiveUser.c_password = Nothing
        ActiveUser.c_firstName = Nothing
        ActiveUser.c_lastName = Nothing
        ActiveUser.c_position = Nothing
        ActiveUser.c_email = Nothing
        ActiveUser.c_profile = Nothing
        'mostrar formulario
        Me.Show()
        txtUser.Focus()
    End Sub

    Private Sub lblrecoverPassword_Click(sender As Object, e As EventArgs) Handles lblrecoverPassword.Click
        Me.Opacity = 0.7
        Dim frmRecoverPassword As New FormRecoverPassword()
        frmRecoverPassword.ShowDialog()
        Me.Opacity = 0.95
    End Sub

End Class
