﻿Imports System.Runtime.InteropServices
Imports Domain.Models

Public Class FormRecoverPassword

#Region "DRAG/MOVE FORM"
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
#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FormRecoverPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResultMessage.Text = ""
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim userModel As New UserModel()
        Dim result = userModel.recoverPassword(txtRequestingUser.Text)
        lblResultMessage.Text = result
    End Sub

End Class