
Public Class SystemSupportMail
    Inherits MasterEmailServer

    '// Modifique la configuración de conexión al servidor de correo saliente(smtpClient), 
    '// de esta clase con tus datos de correo electrónico remitente (El que se encargará de enviar los emails).
    '// En caso que uses Gmail como email remitente, debes de Permitir el acceso de aplicaciones
    '// poco seguras en el correo para que tu aplicación pueda enviar correos electrónicos.
    '// VER TUTORIAL: https://youtu.be/ER3BD8pG-3k?t=1446
    Public Sub New()
        initializeSmtpClient(senderMail:="helii1596@gmail.com", 'Aquí coloque el correo electrónico que se encargará de enviar los mensajes // Place the email address that will send the messages here
                             password:="peterbil#2015",'Contraseña del correo
                             host:="smtp.gmail.com", 'server smtp
                             port:=587,'puerto
                             ssl:=True) ' cifrado ssl
    End Sub

End Class
