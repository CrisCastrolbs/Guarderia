Imports Domain.Models
Imports Domain.ValueObjects

Public Class FormUsers
    Dim userModel As New UserModel()

    Private Sub FormUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
        loadUserData()
    End Sub

    Private Sub loadUserData()
        DataGridView1.DataSource = userModel.getAllUsers()
        DataGridView1.RowTemplate.Height = 100 'establecer una altura considerable para visualizar las fotos de perfil del usuario.
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Panel1.Enabled = True
            userModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            userModel.State = EntityState.Removed ' cambiar estado a eliminar
            Dim result = userModel.saveChanges() ' guardios cambios (estado)
            MessageBox.Show(result)
            loadUserData()
        Else
            MessageBox.Show("Selected a row")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Panel1.Enabled = True
            txtUsername.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtPassword.Text = DataGridView1.CurrentRow.Cells(2).Value
            txtFirstName.Text = DataGridView1.CurrentRow.Cells(3).Value
            txtLastName.Text = DataGridView1.CurrentRow.Cells(4).Value
            cmbPosition.Text = DataGridView1.CurrentRow.Cells(5).Value
            txtEmail.Text = DataGridView1.CurrentRow.Cells(6).Value
            'pasamos imagen de usuario si lo tiviese, caso contrario pictureBox permanecerá con la imagen por defecto
            If (Not (DataGridView1.CurrentRow.Cells(7).Value) Is Nothing) Then
                editedPictureBoxProfile.Image = ConvertItem.binaryToImage(CType(DataGridView1.CurrentRow.Cells(7).Value, Byte()))
            End If

            'Enviar id a editar
            userModel.Id = DataGridView1.CurrentRow.Cells(0).Value
            userModel.State = EntityState.Edited 'cambiar estado a editar
        Else
            MessageBox.Show("Selected a row")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Panel1.Enabled = True
        userModel.State = EntityState.Added ' cambiar estado a agregar
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        userModel.UserName = txtUsername.Text
        userModel.Password = txtPassword.Text
        userModel.FirstName = txtFirstName.Text
        userModel.LastName = txtLastName.Text
        userModel.Position = cmbPosition.Text
        userModel.Email = txtEmail.Text
        userModel.Profile = ConvertItem.imageToBinary(editedPictureBoxProfile.Image)

        Dim valid = New DataValidation(userModel).validate() 'validar datos(vacios, correo, longitud minino, solo letras, etc)
        If valid = True Then
            Dim result = userModel.saveChanges() ' guardios cambios (estado)
            loadUserData()
            MessageBox.Show(result)
            reset()
        End If
    End Sub

    Private Sub reset()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        Panel1.Enabled = False
        cmbPosition.SelectedIndex = 0
        editedPictureBoxProfile.Image = My.Resources.defaultImageProfileUser 'Cargar imagen por defecto desde la carpeta de recursos

    End Sub

    Private Sub btnCancel_Click_1(sender As Object, e As EventArgs) Handles btnCancel.Click
        reset()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridView1.DataSource = userModel.getAUserByValue(txtSearch.Text)
        End If
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