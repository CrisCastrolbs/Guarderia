Imports System.Net.Mail
Imports System.Net

Public MustInherit Class MasterEmailServer

    Private smtpClient As SmtpClient
    Private senderMail As String

    'Inicializamos las propiedades del cliente SMTP, con los parametros.
    Protected Sub initializeSmtpClient(senderMail As String, password As String, host As String, port As Integer, ssl As Boolean)
        smtpClient = New SmtpClient
        smtpClient.Credentials = New NetworkCredential(senderMail, password)
        smtpClient.Host = host
        smtpClient.Port = port
        smtpClient.EnableSsl = ssl
        Me.senderMail = senderMail
    End Sub

    'Metodo para enviar los mensajes de correo a UNO o VARIOS destinatarios'
    Public Sub sendMail(subject As String, body As String, receiverMail As List(Of String))
        'create mail message// creamos el mensaje de correo'
        Dim mailMessage As MailMessage = New MailMessage
        Try
            mailMessage.From = New MailAddress(senderMail)
            For Each mail As String In receiverMail
                mailMessage.To.Add(mail)
            Next
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.Priority = MailPriority.Normal
            smtpClient.Send(mailMessage) 'Enviar Mensaje'
        Catch ex As Exception

        Finally
            mailMessage.Dispose()
            smtpClient.Dispose()
        End Try
    End Sub

End Class
