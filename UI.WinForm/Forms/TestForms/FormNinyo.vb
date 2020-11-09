Imports Domain.Models
Imports Domain.ValueObjects
Imports Infrastructure.Common

Public Class FormNinyo
    'LLAMAR LA CLASE CORRESPONDIENTE
    Dim infanteModel As New InfanteModel()

    'LEER LA INFORMACIÓN AL ABRIR EL FORMULARIO
    Private Sub FormNinyo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
        loadInfanteData()
        managePermissions()
    End Sub
    'CARGAR LOS DATOS EN EL GRIDVIEW
    Private Sub loadInfanteData()
        NinyosGridView.DataSource = infanteModel.getAllInfantes()
        NinyosGridView.RowTemplate.Height = 100 'establecer una altura considerable para visualizar las fotos de perfil del usuario.
    End Sub

    'BOTON CERRAR
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'PERMISOS PARA ABRIR EL FORMULARIO
    Private Sub managePermissions()
        If ActiveUser.c_position = Positions.cocinera Then
            btnAdd.Enabled = False
            btnEdit.Enabled = False
        End If
        'more 
    End Sub

    'BOTON EDITAR
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If NinyosGridView.SelectedRows.Count > 0 Then
            PanelNinyo.Enabled = True

            txtCedula.Text = NinyosGridView.CurrentRow.Cells(0).Value
            txtNombre.Text = NinyosGridView.CurrentRow.Cells(1).Value
            txtApellido1.Text = NinyosGridView.CurrentRow.Cells(2).Value
            txtApellido2.Text = NinyosGridView.CurrentRow.Cells(3).Value
            dateNacimiento.Text = CDate(NinyosGridView.CurrentRow.Cells(4).Value)
            cmbSexo.Text = NinyosGridView.CurrentRow.Cells(5).Value
            'Enviar id a editar
            infanteModel.CedulaInfante = NinyosGridView.CurrentRow.Cells(0).Value
            infanteModel.State = EntityState.Edited 'cambiar estado a editar
        Else
            MessageBox.Show("Selecccione una fila")
        End If
    End Sub

    'BOTON AÑADIR NUEVO
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        PanelNinyo.Enabled = True
        infanteModel.State = EntityState.Added ' cambiar estado a agregar
    End Sub

    'BOTON CANCELAR
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Reset()
    End Sub

    'BOTON GUARDAR
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        infanteModel.CedulaInfante = txtCedula.Text
        infanteModel.Nombre = txtNombre.Text
        infanteModel.Apellido1 = txtApellido1.Text
        infanteModel.Apellido2 = txtApellido2.Text
        infanteModel.FechaNac = dateNacimiento.Value.ToString("dd/MM/yyyy")

        'infanteModel.FechaNacimiento = Convert.ToDateTime(dateNacimiento.("dd/MM/yyyy")).Date
        'Dim FechaNacimiento As DateTime = Convert.ToDateTime(dateNacimiento.ToString("dd/MMM/yy"))
        infanteModel.Sexo = cmbSexo.Text
        Dim valid = New DataValidation(infanteModel).validate() 'validar datos(vacios, correo, longitud minino, solo letras, etc)
        If valid = True Then
            Dim result = infanteModel.saveChanges() ' guardar cambios (estado)
            loadInfanteData()
            MessageBox.Show(result)
            Reset()
        End If
    End Sub
    'MÉTODO PARA LIMPIAR LOS DATOS
    Private Sub Reset()
        txtNombre.Text = ""
        txtApellido1.Text = ""
        txtApellido2.Text = ""
        dateNacimiento.Text = ""
        cmbSexo.SelectedIndex = 0
        PanelNinyo.Enabled = False
    End Sub

    'PARA EL ESPACIO DE BÚSQUEDA
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            NinyosGridView.DataSource = infanteModel.getAInfanteByValue2(txtSearch.Text)
        End If
    End Sub

    Private Sub txtSearch2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch2.KeyDown
        If e.KeyCode = Keys.Enter Then
            NinyosGridView.DataSource = infanteModel.getAInfanteByValue(txtSearch2.Text)
        End If
    End Sub

End Class