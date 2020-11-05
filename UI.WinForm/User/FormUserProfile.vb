Imports Infrastructure.Common
Imports Domain.Models
Imports Domain.ValueObjects

Public Class FormUserProfile

    Private Sub FormEditUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeControlsPass()
        loadUserData()
    End Sub

    Private Sub loadUserData() 'Cargamos los datos a las etiquetas y textoxs// We Load the data to the labels And textxs
        'Normal
        lblLastName.Text = ActiveUser.c_lastName
        lblMail.Text = ActiveUser.c_email
        lblUser.Text = ActiveUser.c_userName
        lblName.Text = ActiveUser.c_firstName
        lblPosition.Text = ActiveUser.c_position
        If (Not (ActiveUser.c_profile) Is Nothing) Then
            pictureBoxProfile.Image = ConvertItem.binaryToImage(ActiveUser.c_profile)
        End If
        'Edit
        txtEmail.Text = ActiveUser.c_email
        txtFirstName.Text = ActiveUser.c_firstName
        txtLastName.Text = ActiveUser.c_lastName
        txtPassword.Text = ActiveUser.c_password
        txtConfirmPass.Text = ActiveUser.c_password
        txtUsername.Text = ActiveUser.c_userName
        If (Not (ActiveUser.c_profile) Is Nothing) Then
            editedPictureBoxProfile.Image = ConvertItem.binaryToImage(ActiveUser.c_profile)
        End If
    End Sub

    Private Sub initializeControlsPass()
        LinkEditPass.Text = "Edit"
        lblConfimPass.Visible = False
        txtPassword.UseSystemPasswordChar = True
        txtPassword.Enabled = False
        txtConfirmPass.UseSystemPasswordChar = True
        txtConfirmPass.Visible = False
    End Sub

    Private Sub reset() 'reiniciamos todo // all reset
        Panel1.Visible = False
        initializeControlsPass() 'we again invoke the methods to update the data on the screen (in the form), with the new user data, or the existing data, if not updated.
        loadUserData() 'volvemos a invocar los metodo para actualizar los datos en la pantalla (en el formulario), con los nuevos datos del usuario, o los datos existentes, si no actualizó.
    End Sub

    Private Sub linkEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkEdit.LinkClicked

        Panel1.Width = 10
        Panel1.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Width += 20
        If Panel1.Width >= 400 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub LinkEditPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEditPass.LinkClicked
        If LinkEditPass.Text = "Edit" Then
            LinkEditPass.Text = "Cancel"
            lblConfimPass.Visible = True
            txtPassword.Enabled = True
            txtPassword.Text = ""
            txtConfirmPass.Text = ""
            txtConfirmPass.Visible = True
        ElseIf LinkEditPass.Text = "Cancel" Then
            'reiniciamos solo en editar contraseña // We restart only in edit password
            initializeControlsPass()
            txtPassword.Text = ActiveUser.c_password
            txtConfirmPass.Text = ActiveUser.c_password
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtConfirmPass.Text Then 'Validar que las contraseñas coincidan
            Dim userModel As New UserModel() 'Crear el objeto usuario
            userModel.Id = ActiveUser.c_id
            userModel.UserName = txtUsername.Text
            userModel.Password = txtPassword.Text
            userModel.FirstName = txtFirstName.Text
            userModel.LastName = txtLastName.Text
            userModel.Position = ActiveUser.c_position
            userModel.Email = txtEmail.Text
            userModel.Profile = ConvertItem.imageToBinary(editedPictureBoxProfile.Image)

            userModel.State = EntityState.Edited 'cambiamos el estado a editar
            userModel.editMyUserProfile = True 'indicamos que si el usuario logueado es quien edita su perfil

            Dim validateData = New DataValidation(userModel).validate() 'Validar todos los campos
            If validateData = True Then
                Dim formValidpass = New FormCustomPopup() 'validar contraseña actual
                formValidpass.ShowDialog()
                If formValidpass.correct = True Then
                    Dim result = userModel.saveChanges()
                    MessageBox.Show(result)
                    reset() 'reiniciamos todo // all reset
                End If
            End If
        Else
            MessageBox.Show("the passwords do not match, do you want to try again?" & vbNewLine &
                             "Las contraseñas no coinciden, ¿quieres intentarlo de nuevo?")
            txtPassword.Focus()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        reset()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub linkChangePictureProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkChangePictureProfile.LinkClicked
        Dim openFile As OpenFileDialog = New OpenFileDialog
        openFile.Filter = "Images(.jpg,.png)|*.png;*.jpg"
        'filtrar archivos  solo de tipo imagenes
        If (openFile.ShowDialog = DialogResult.OK) Then
            editedPictureBoxProfile.Image = New Bitmap(openFile.FileName)
        End If
    End Sub
End Class