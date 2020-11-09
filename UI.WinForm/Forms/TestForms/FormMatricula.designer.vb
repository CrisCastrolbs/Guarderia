<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatricula
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
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAnyadir = New System.Windows.Forms.Button()
        Me.MatriculaGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMatricula = New System.Windows.Forms.Panel()
        Me.dateIngreso = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.DateBaja = New System.Windows.Forms.DateTimePicker()
        Me.cmbNinyo = New System.Windows.Forms.ComboBox()
        Me.cmbRespPago = New System.Windows.Forms.ComboBox()
        CType(Me.MatriculaGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMatricula.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(0, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(47, 43)
        Me.btnCerrar.TabIndex = 11
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
        Me.btnEditar.Location = New System.Drawing.Point(570, 577)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 38)
        Me.btnEditar.TabIndex = 10
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
        Me.btnEliminar.Location = New System.Drawing.Point(708, 577)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 38)
        Me.btnEliminar.TabIndex = 9
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
        Me.btnAnyadir.Location = New System.Drawing.Point(432, 577)
        Me.btnAnyadir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnyadir.Name = "btnAnyadir"
        Me.btnAnyadir.Size = New System.Drawing.Size(130, 38)
        Me.btnAnyadir.TabIndex = 8
        Me.btnAnyadir.Text = "Añadir"
        Me.btnAnyadir.UseVisualStyleBackColor = False
        '
        'MatriculaGridView
        '
        Me.MatriculaGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MatriculaGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.MatriculaGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MatriculaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MatriculaGridView.Location = New System.Drawing.Point(47, 92)
        Me.MatriculaGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MatriculaGridView.Name = "MatriculaGridView"
        Me.MatriculaGridView.RowHeadersWidth = 51
        Me.MatriculaGridView.Size = New System.Drawing.Size(803, 454)
        Me.MatriculaGridView.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Registro de Matrícula"
        '
        'PanelMatricula
        '
        Me.PanelMatricula.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelMatricula.Controls.Add(Me.cmbRespPago)
        Me.PanelMatricula.Controls.Add(Me.cmbNinyo)
        Me.PanelMatricula.Controls.Add(Me.DateBaja)
        Me.PanelMatricula.Controls.Add(Me.dateIngreso)
        Me.PanelMatricula.Controls.Add(Me.btnCancel)
        Me.PanelMatricula.Controls.Add(Me.btnSave)
        Me.PanelMatricula.Controls.Add(Me.Label9)
        Me.PanelMatricula.Controls.Add(Me.Label11)
        Me.PanelMatricula.Controls.Add(Me.lbl2)
        Me.PanelMatricula.Controls.Add(Me.Label13)
        Me.PanelMatricula.Controls.Add(Me.Label14)
        Me.PanelMatricula.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelMatricula.Location = New System.Drawing.Point(876, 0)
        Me.PanelMatricula.Name = "PanelMatricula"
        Me.PanelMatricula.Size = New System.Drawing.Size(369, 642)
        Me.PanelMatricula.TabIndex = 47
        '
        'dateIngreso
        '
        Me.dateIngreso.Location = New System.Drawing.Point(39, 189)
        Me.dateIngreso.Name = "dateIngreso"
        Me.dateIngreso.Size = New System.Drawing.Size(270, 22)
        Me.dateIngreso.TabIndex = 45
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(39, 415)
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
        Me.btnSave.Location = New System.Drawing.Point(179, 415)
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
        Me.Label9.Location = New System.Drawing.Point(36, 311)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Cédula Responsable del Pago:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(33, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(240, 39)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Mantenimiento"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(37, 230)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(103, 17)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Fecha de Baja:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(37, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Fecha de Ingreso:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(36, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Cédula Niño:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(478, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Buscar"
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(563, 39)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(287, 22)
        Me.TextBuscar.TabIndex = 49
        '
        'DateBaja
        '
        Me.DateBaja.Location = New System.Drawing.Point(40, 265)
        Me.DateBaja.Name = "DateBaja"
        Me.DateBaja.Size = New System.Drawing.Size(269, 22)
        Me.DateBaja.TabIndex = 46
        '
        'cmbNinyo
        '
        Me.cmbNinyo.FormattingEnabled = True
        Me.cmbNinyo.Location = New System.Drawing.Point(40, 121)
        Me.cmbNinyo.Name = "cmbNinyo"
        Me.cmbNinyo.Size = New System.Drawing.Size(269, 24)
        Me.cmbNinyo.TabIndex = 47
        '
        'cmbRespPago
        '
        Me.cmbRespPago.FormattingEnabled = True
        Me.cmbRespPago.Location = New System.Drawing.Point(39, 346)
        Me.cmbRespPago.Name = "cmbRespPago"
        Me.cmbRespPago.Size = New System.Drawing.Size(270, 24)
        Me.cmbRespPago.TabIndex = 48
        '
        'FormMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 642)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.PanelMatricula)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAnyadir)
        Me.Controls.Add(Me.MatriculaGridView)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormMatricula"
        Me.Text = "FormCreateMatricula"
        CType(Me.MatriculaGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMatricula.ResumeLayout(False)
        Me.PanelMatricula.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAnyadir As Button
    Friend WithEvents MatriculaGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMatricula As Panel
    Friend WithEvents dateIngreso As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents DateBaja As DateTimePicker
    Friend WithEvents cmbRespPago As ComboBox
    Friend WithEvents cmbNinyo As ComboBox
End Class
