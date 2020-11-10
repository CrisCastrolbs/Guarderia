Imports Domain.Models

Public Class FormIngredientePlato

    Dim ingredientePlatoModel As New IngredientePlatoModel()


    Private Sub loadIngredientePlatoData()
        IngredientePlatoGridView.DataSource = ingredientePlatoModel.getAllIngredientePlato()
        IngredientePlatoGridView.RowTemplate.Height = 100 'establecer una altura considerable para visualizar las fotos de perfil del usuario.
    End Sub

    Private Sub FormIngredientePlato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
        loadIngredientePlatoData()
        cargarComboPlato()
    End Sub
    Public Sub cargarComboPlato()
        Dim ingredientePlatoModel As String = "Sp_ListarPlato"
        cmbNombreIngrediente.ValueMember = "IdPlato"
        cmbNombreIngrediente.DisplayMember = "NombrePlato"
        'cmbNombreIngrediente.DataSource = ingredientePlatoModel
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        reset()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        IngredientePlatoModel.IdPlato = cmbNombrePlato.Text
        IngredientePlatoModel.IdIngrediente = cmbNombreIngrediente.Text

        Dim valid = New DataValidation(IngredientePlatoModel).validate() 'validar datos(vacios, correo, longitud minino, solo letras, etc)
        If valid = True Then
            Dim result = IngredientePlatoModel.saveChanges() ' guardios cambios (estado)
            loadIngredientePlatoData()
            MessageBox.Show(result)
            reset()
        End If
    End Sub

    Private Sub reset()
        'cmbNombrePlato.SelectedIndex = 0
        'cmbNombreIngrediente.SelectedIndex = 0
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            IngredientePlatoGridView.DataSource = IngredientePlatoModel.getAIngredientePlatoByValue(txtBuscar.Text)
        End If
    End Sub

End Class