<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngredientePlato
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelIngredienteMenu = New System.Windows.Forms.Panel()
        Me.cmbNombrePlato = New System.Windows.Forms.ComboBox()
        Me.cmbNombreIngrediente = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAnyadir = New System.Windows.Forms.Button()
        Me.IngredientePlatoGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelIngredienteMenu.SuspendLayout()
        CType(Me.IngredientePlatoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelIngredienteMenu
        '
        Me.PanelIngredienteMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelIngredienteMenu.Controls.Add(Me.cmbNombrePlato)
        Me.PanelIngredienteMenu.Controls.Add(Me.cmbNombreIngrediente)
        Me.PanelIngredienteMenu.Controls.Add(Me.btnCancel)
        Me.PanelIngredienteMenu.Controls.Add(Me.btnSave)
        Me.PanelIngredienteMenu.Controls.Add(Me.Label9)
        Me.PanelIngredienteMenu.Controls.Add(Me.Label11)
        Me.PanelIngredienteMenu.Controls.Add(Me.Label10)
        Me.PanelIngredienteMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelIngredienteMenu.Location = New System.Drawing.Point(702, 0)
        Me.PanelIngredienteMenu.Name = "PanelIngredienteMenu"
        Me.PanelIngredienteMenu.Size = New System.Drawing.Size(348, 551)
        Me.PanelIngredienteMenu.TabIndex = 45
        '
        'cmbNombrePlato
        '
        Me.cmbNombrePlato.FormattingEnabled = True
        Me.cmbNombrePlato.Location = New System.Drawing.Point(27, 219)
        Me.cmbNombrePlato.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNombrePlato.Name = "cmbNombrePlato"
        Me.cmbNombrePlato.Size = New System.Drawing.Size(269, 24)
        Me.cmbNombrePlato.TabIndex = 45
        '
        'cmbNombreIngrediente
        '
        Me.cmbNombreIngrediente.FormattingEnabled = True
        Me.cmbNombreIngrediente.Location = New System.Drawing.Point(27, 309)
        Me.cmbNombreIngrediente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNombreIngrediente.Name = "cmbNombreIngrediente"
        Me.cmbNombreIngrediente.Size = New System.Drawing.Size(271, 24)
        Me.cmbNombreIngrediente.TabIndex = 44
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(39, 415)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(131, 49)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(176, 415)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 49)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 272)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Nombre Ingrediente:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(21, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 31)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Mantenimiento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(23, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nombre del Plato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(30, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(33, 63)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(649, 23)
        Me.txtBuscar.TabIndex = 48
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(3, 14)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(47, 43)
        Me.btnCerrar.TabIndex = 74
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEditar.Location = New System.Drawing.Point(493, 591)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(131, 38)
        Me.btnEditar.TabIndex = 73
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAnyadir
        '
        Me.btnAnyadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnyadir.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAnyadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAnyadir.FlatAppearance.BorderSize = 0
        Me.btnAnyadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnyadir.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.btnAnyadir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAnyadir.Location = New System.Drawing.Point(354, 591)
        Me.btnAnyadir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnyadir.Name = "btnAnyadir"
        Me.btnAnyadir.Size = New System.Drawing.Size(131, 38)
        Me.btnAnyadir.TabIndex = 71
        Me.btnAnyadir.Text = "Añadir"
        Me.btnAnyadir.UseVisualStyleBackColor = False
        '
        'IngredientePlatoGridView
        '
        Me.IngredientePlatoGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IngredientePlatoGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.IngredientePlatoGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.IngredientePlatoGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.IngredientePlatoGridView.ColumnHeadersHeight = 29
        Me.IngredientePlatoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.IngredientePlatoGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IngredientePlatoGridView.Location = New System.Drawing.Point(33, 106)
        Me.IngredientePlatoGridView.Name = "IngredientePlatoGridView"
        Me.IngredientePlatoGridView.RowHeadersWidth = 51
        Me.IngredientePlatoGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.IngredientePlatoGridView.Size = New System.Drawing.Size(649, 353)
        Me.IngredientePlatoGridView.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Ingrediente del Plato"
        '
        'FormIngredientePlato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 551)
        Me.Controls.Add(Me.PanelIngredienteMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAnyadir)
        Me.Controls.Add(Me.IngredientePlatoGridView)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormIngredientePlato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormIngredientePlato"
        Me.PanelIngredienteMenu.ResumeLayout(False)
        Me.PanelIngredienteMenu.PerformLayout()
        CType(Me.IngredientePlatoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelIngredienteMenu As Panel
    Friend WithEvents cmbNombrePlato As ComboBox
    Friend WithEvents cmbNombreIngrediente As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAnyadir As Button
    Friend WithEvents IngredientePlatoGridView As DataGridView
    Friend WithEvents Label1 As Label
End Class
