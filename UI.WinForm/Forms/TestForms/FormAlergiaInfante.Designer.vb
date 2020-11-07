<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAlergiaInfante
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
        Me.PanelAlergiaInfante = New System.Windows.Forms.Panel()
        Me.cmbTipoAlergia = New System.Windows.Forms.ComboBox()
        Me.cmbCedulaNinyo = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAnyadir = New System.Windows.Forms.Button()
        Me.AlergiaInfanteGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAlergiaInfante.SuspendLayout()
        CType(Me.AlergiaInfanteGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAlergiaInfante
        '
        Me.PanelAlergiaInfante.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelAlergiaInfante.Controls.Add(Me.cmbTipoAlergia)
        Me.PanelAlergiaInfante.Controls.Add(Me.cmbCedulaNinyo)
        Me.PanelAlergiaInfante.Controls.Add(Me.btnCancel)
        Me.PanelAlergiaInfante.Controls.Add(Me.btnSave)
        Me.PanelAlergiaInfante.Controls.Add(Me.Label9)
        Me.PanelAlergiaInfante.Controls.Add(Me.Label11)
        Me.PanelAlergiaInfante.Controls.Add(Me.Label10)
        Me.PanelAlergiaInfante.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelAlergiaInfante.Location = New System.Drawing.Point(910, 0)
        Me.PanelAlergiaInfante.Name = "PanelAlergiaInfante"
        Me.PanelAlergiaInfante.Size = New System.Drawing.Size(335, 642)
        Me.PanelAlergiaInfante.TabIndex = 86
        '
        'cmbTipoAlergia
        '
        Me.cmbTipoAlergia.FormattingEnabled = True
        Me.cmbTipoAlergia.Location = New System.Drawing.Point(26, 219)
        Me.cmbTipoAlergia.Name = "cmbTipoAlergia"
        Me.cmbTipoAlergia.Size = New System.Drawing.Size(269, 24)
        Me.cmbTipoAlergia.TabIndex = 45
        '
        'cmbCedulaNinyo
        '
        Me.cmbCedulaNinyo.FormattingEnabled = True
        Me.cmbCedulaNinyo.Location = New System.Drawing.Point(26, 309)
        Me.cmbCedulaNinyo.Name = "cmbCedulaNinyo"
        Me.cmbCedulaNinyo.Size = New System.Drawing.Size(270, 24)
        Me.cmbCedulaNinyo.TabIndex = 44
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(28, 435)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 49)
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
        Me.btnSave.Location = New System.Drawing.Point(175, 435)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 49)
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
        Me.Label9.Size = New System.Drawing.Size(127, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Cédula de Niño(a):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(19, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(240, 39)
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
        Me.Label10.Size = New System.Drawing.Size(108, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Tipo de Alergia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(466, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Buscar"
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(551, 49)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(287, 22)
        Me.TextBuscar.TabIndex = 84
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(1, 13)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(47, 43)
        Me.btnCerrar.TabIndex = 83
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
        Me.btnEditar.Location = New System.Drawing.Point(571, 591)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 38)
        Me.btnEditar.TabIndex = 82
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.IndianRed
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(709, 591)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 38)
        Me.btnEliminar.TabIndex = 81
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnAnyadir.Location = New System.Drawing.Point(433, 591)
        Me.btnAnyadir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnyadir.Name = "btnAnyadir"
        Me.btnAnyadir.Size = New System.Drawing.Size(130, 38)
        Me.btnAnyadir.TabIndex = 80
        Me.btnAnyadir.Text = "Añadir"
        Me.btnAnyadir.UseVisualStyleBackColor = False
        '
        'AlergiaInfanteGridView
        '
        Me.AlergiaInfanteGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AlergiaInfanteGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.AlergiaInfanteGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AlergiaInfanteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlergiaInfanteGridView.Location = New System.Drawing.Point(35, 92)
        Me.AlergiaInfanteGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.AlergiaInfanteGridView.Name = "AlergiaInfanteGridView"
        Me.AlergiaInfanteGridView.RowHeadersWidth = 51
        Me.AlergiaInfanteGridView.Size = New System.Drawing.Size(803, 454)
        Me.AlergiaInfanteGridView.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 29)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Registro de Alergia al Ingrediente"
        '
        'FormAlergiaInfante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 642)
        Me.Controls.Add(Me.PanelAlergiaInfante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAnyadir)
        Me.Controls.Add(Me.AlergiaInfanteGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAlergiaInfante"
        Me.Text = "FormAlergiaInfante"
        Me.PanelAlergiaInfante.ResumeLayout(False)
        Me.PanelAlergiaInfante.PerformLayout()
        CType(Me.AlergiaInfanteGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelAlergiaInfante As Panel
    Friend WithEvents cmbTipoAlergia As ComboBox
    Friend WithEvents cmbCedulaNinyo As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAnyadir As Button
    Friend WithEvents AlergiaInfanteGridView As DataGridView
    Friend WithEvents Label1 As Label
End Class
