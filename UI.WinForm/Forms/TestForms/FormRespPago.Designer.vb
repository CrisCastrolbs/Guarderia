<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRespPago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RespPagoGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAnyadir = New System.Windows.Forms.Button()
        Me.PanelRespPago = New System.Windows.Forms.Panel()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkSi = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRelacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumTel1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbDistrito = New System.Windows.Forms.ComboBox()
        Me.cmbCanton = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscarInt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBuscarVachar = New System.Windows.Forms.TextBox()
        CType(Me.RespPagoGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRespPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'RespPagoGridView
        '
        Me.RespPagoGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RespPagoGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.RespPagoGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RespPagoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RespPagoGridView.Location = New System.Drawing.Point(47, 92)
        Me.RespPagoGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.RespPagoGridView.Name = "RespPagoGridView"
        Me.RespPagoGridView.RowHeadersWidth = 51
        Me.RespPagoGridView.Size = New System.Drawing.Size(803, 454)
        Me.RespPagoGridView.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 29)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Registro Responsable de Pago"
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
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(47, 43)
        Me.btnCerrar.TabIndex = 50
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
        Me.btnEditar.Location = New System.Drawing.Point(698, 591)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 38)
        Me.btnEditar.TabIndex = 55
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
        Me.btnAnyadir.Location = New System.Drawing.Point(560, 591)
        Me.btnAnyadir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnyadir.Name = "btnAnyadir"
        Me.btnAnyadir.Size = New System.Drawing.Size(130, 38)
        Me.btnAnyadir.TabIndex = 53
        Me.btnAnyadir.Text = "Añadir"
        Me.btnAnyadir.UseVisualStyleBackColor = False
        '
        'PanelRespPago
        '
        Me.PanelRespPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelRespPago.Controls.Add(Me.cmbDistrito)
        Me.PanelRespPago.Controls.Add(Me.cmbCanton)
        Me.PanelRespPago.Controls.Add(Me.cmbProvincia)
        Me.PanelRespPago.Controls.Add(Me.chkNo)
        Me.PanelRespPago.Controls.Add(Me.chkSi)
        Me.PanelRespPago.Controls.Add(Me.Label7)
        Me.PanelRespPago.Controls.Add(Me.txtRelacion)
        Me.PanelRespPago.Controls.Add(Me.Label6)
        Me.PanelRespPago.Controls.Add(Me.txtNumTel1)
        Me.PanelRespPago.Controls.Add(Me.Label4)
        Me.PanelRespPago.Controls.Add(Me.Label3)
        Me.PanelRespPago.Controls.Add(Me.Label8)
        Me.PanelRespPago.Controls.Add(Me.txtDireccion)
        Me.PanelRespPago.Controls.Add(Me.btnCancel)
        Me.PanelRespPago.Controls.Add(Me.btnSave)
        Me.PanelRespPago.Controls.Add(Me.Label9)
        Me.PanelRespPago.Controls.Add(Me.Label11)
        Me.PanelRespPago.Controls.Add(Me.Label10)
        Me.PanelRespPago.Controls.Add(Me.txtApellido2)
        Me.PanelRespPago.Controls.Add(Me.lbl2)
        Me.PanelRespPago.Controls.Add(Me.Label12)
        Me.PanelRespPago.Controls.Add(Me.txtApellido1)
        Me.PanelRespPago.Controls.Add(Me.Label13)
        Me.PanelRespPago.Controls.Add(Me.txtNombre)
        Me.PanelRespPago.Controls.Add(Me.txtCedula)
        Me.PanelRespPago.Controls.Add(Me.Label14)
        Me.PanelRespPago.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRespPago.Location = New System.Drawing.Point(886, 0)
        Me.PanelRespPago.Name = "PanelRespPago"
        Me.PanelRespPago.Size = New System.Drawing.Size(359, 642)
        Me.PanelRespPago.TabIndex = 56
        '
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(104, 542)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(48, 21)
        Me.chkNo.TabIndex = 59
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkSi
        '
        Me.chkSi.AutoSize = True
        Me.chkSi.Location = New System.Drawing.Point(32, 542)
        Me.chkSi.Name = "chkSi"
        Me.chkSi.Size = New System.Drawing.Size(42, 21)
        Me.chkSi.TabIndex = 58
        Me.chkSi.Text = "Sí"
        Me.chkSi.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 508)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Autorizado a Retirar:"
        '
        'txtRelacion
        '
        Me.txtRelacion.Location = New System.Drawing.Point(32, 483)
        Me.txtRelacion.Name = "txtRelacion"
        Me.txtRelacion.Size = New System.Drawing.Size(270, 22)
        Me.txtRelacion.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(29, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 17)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Número de Cuenta:"
        '
        'txtNumTel1
        '
        Me.txtNumTel1.Location = New System.Drawing.Point(32, 438)
        Me.txtNumTel1.Name = "txtNumTel1"
        Me.txtNumTel1.Size = New System.Drawing.Size(270, 22)
        Me.txtNumTel1.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Número deTelefono 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Distrito:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(29, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Cantón:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(33, 255)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(269, 22)
        Me.txtDireccion.TabIndex = 45
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(38, 588)
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
        Me.btnSave.Location = New System.Drawing.Point(185, 588)
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
        Me.Label9.Location = New System.Drawing.Point(29, 182)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Segundo Apellido:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(32, 5)
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
        Me.Label10.Location = New System.Drawing.Point(29, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Dirección Exacta:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(32, 209)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(270, 22)
        Me.txtApellido2.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(29, 136)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(107, 17)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Primer Apellido:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(29, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Provincia:"
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(32, 156)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(270, 22)
        Me.txtApellido1.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(29, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(32, 110)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(270, 22)
        Me.txtNombre.TabIndex = 8
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(32, 64)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(270, 22)
        Me.txtCedula.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(29, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Cédula:"
        '
        'cmbDistrito
        '
        Me.cmbDistrito.FormattingEnabled = True
        Me.cmbDistrito.Location = New System.Drawing.Point(33, 390)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(269, 24)
        Me.cmbDistrito.TabIndex = 64
        '
        'cmbCanton
        '
        Me.cmbCanton.FormattingEnabled = True
        Me.cmbCanton.Location = New System.Drawing.Point(32, 348)
        Me.cmbCanton.Name = "cmbCanton"
        Me.cmbCanton.Size = New System.Drawing.Size(270, 24)
        Me.cmbCanton.TabIndex = 63
        '
        'cmbProvincia
        '
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(32, 299)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(270, 24)
        Me.cmbProvincia.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(458, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Buscar por Id:"
        '
        'txtBuscarInt
        '
        Me.txtBuscarInt.Location = New System.Drawing.Point(560, 56)
        Me.txtBuscarInt.Name = "txtBuscarInt"
        Me.txtBuscarInt.Size = New System.Drawing.Size(288, 22)
        Me.txtBuscarInt.TabIndex = 91
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.Window
        Me.Label15.Location = New System.Drawing.Point(458, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 17)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Buscar:"
        '
        'txtBuscarVachar
        '
        Me.txtBuscarVachar.Location = New System.Drawing.Point(560, 20)
        Me.txtBuscarVachar.Name = "txtBuscarVachar"
        Me.txtBuscarVachar.Size = New System.Drawing.Size(287, 22)
        Me.txtBuscarVachar.TabIndex = 89
        '
        'FormRespPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 642)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBuscarInt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBuscarVachar)
        Me.Controls.Add(Me.PanelRespPago)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAnyadir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RespPagoGridView)
        Me.Name = "FormRespPago"
        Me.Text = "FormRespPago"
        CType(Me.RespPagoGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRespPago.ResumeLayout(False)
        Me.PanelRespPago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RespPagoGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAnyadir As Button
    Friend WithEvents PanelRespPago As Panel
    Friend WithEvents chkNo As CheckBox
    Friend WithEvents chkSi As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRelacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumTel1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbDistrito As ComboBox
    Friend WithEvents cmbCanton As ComboBox
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBuscarInt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBuscarVachar As TextBox
End Class
