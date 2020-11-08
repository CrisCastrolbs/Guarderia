<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagoMensual
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAnyadir = New System.Windows.Forms.Button()
        Me.PagoMensualGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PanelPagoMensual = New System.Windows.Forms.Panel()
        Me.cmbRespPago = New System.Windows.Forms.ComboBox()
        Me.cmbCedulaNinyo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.txtMontoComidas = New System.Windows.Forms.TextBox()
        Me.txtMontoBase = New System.Windows.Forms.TextBox()
        CType(Me.PagoMensualGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPagoMensual.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(478, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(563, 49)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(287, 22)
        Me.txtBuscar.TabIndex = 57
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(13, 13)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(47, 43)
        Me.btnCerrar.TabIndex = 56
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
        Me.btnEditar.Location = New System.Drawing.Point(583, 591)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 38)
        Me.btnEditar.TabIndex = 55
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
        Me.btnEliminar.Location = New System.Drawing.Point(721, 591)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(130, 38)
        Me.btnEliminar.TabIndex = 54
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
        Me.btnAnyadir.Location = New System.Drawing.Point(445, 591)
        Me.btnAnyadir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnyadir.Name = "btnAnyadir"
        Me.btnAnyadir.Size = New System.Drawing.Size(130, 38)
        Me.btnAnyadir.TabIndex = 53
        Me.btnAnyadir.Text = "Añadir"
        Me.btnAnyadir.UseVisualStyleBackColor = False
        '
        'PagoMensualGridView
        '
        Me.PagoMensualGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PagoMensualGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PagoMensualGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PagoMensualGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PagoMensualGridView.Location = New System.Drawing.Point(47, 92)
        Me.PagoMensualGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.PagoMensualGridView.Name = "PagoMensualGridView"
        Me.PagoMensualGridView.RowHeadersWidth = 51
        Me.PagoMensualGridView.Size = New System.Drawing.Size(803, 454)
        Me.PagoMensualGridView.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 29)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Registro de Matrícula"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(15, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Monto Base Mensual:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(16, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Monto de Comidas:"
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
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(186, 535)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(130, 49)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(39, 535)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 49)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PanelPagoMensual
        '
        Me.PanelPagoMensual.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelPagoMensual.Controls.Add(Me.cmbRespPago)
        Me.PanelPagoMensual.Controls.Add(Me.cmbCedulaNinyo)
        Me.PanelPagoMensual.Controls.Add(Me.btnCancel)
        Me.PanelPagoMensual.Controls.Add(Me.btnSave)
        Me.PanelPagoMensual.Controls.Add(Me.Label9)
        Me.PanelPagoMensual.Controls.Add(Me.Label11)
        Me.PanelPagoMensual.Controls.Add(Me.Label10)
        Me.PanelPagoMensual.Controls.Add(Me.lbl2)
        Me.PanelPagoMensual.Controls.Add(Me.txtMontoTotal)
        Me.PanelPagoMensual.Controls.Add(Me.Label13)
        Me.PanelPagoMensual.Controls.Add(Me.txtMontoComidas)
        Me.PanelPagoMensual.Controls.Add(Me.txtMontoBase)
        Me.PanelPagoMensual.Controls.Add(Me.Label14)
        Me.PanelPagoMensual.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelPagoMensual.Location = New System.Drawing.Point(910, 0)
        Me.PanelPagoMensual.Name = "PanelPagoMensual"
        Me.PanelPagoMensual.Size = New System.Drawing.Size(335, 642)
        Me.PanelPagoMensual.TabIndex = 59
        '
        'cmbRespPago
        '
        Me.cmbRespPago.FormattingEnabled = True
        Me.cmbRespPago.Location = New System.Drawing.Point(19, 435)
        Me.cmbRespPago.Name = "cmbRespPago"
        Me.cmbRespPago.Size = New System.Drawing.Size(269, 24)
        Me.cmbRespPago.TabIndex = 45
        '
        'cmbCedulaNinyo
        '
        Me.cmbCedulaNinyo.FormattingEnabled = True
        Me.cmbCedulaNinyo.Location = New System.Drawing.Point(19, 348)
        Me.cmbCedulaNinyo.Name = "cmbCedulaNinyo"
        Me.cmbCedulaNinyo.Size = New System.Drawing.Size(270, 24)
        Me.cmbCedulaNinyo.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 311)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Cédula Niño(a):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 392)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cédula Responsable de Pago:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(16, 233)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(87, 17)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Monto Total:"
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(19, 268)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(270, 22)
        Me.txtMontoTotal.TabIndex = 10
        '
        'txtMontoComidas
        '
        Me.txtMontoComidas.Location = New System.Drawing.Point(19, 189)
        Me.txtMontoComidas.Name = "txtMontoComidas"
        Me.txtMontoComidas.Size = New System.Drawing.Size(270, 22)
        Me.txtMontoComidas.TabIndex = 8
        '
        'txtMontoBase
        '
        Me.txtMontoBase.Location = New System.Drawing.Point(18, 120)
        Me.txtMontoBase.Name = "txtMontoBase"
        Me.txtMontoBase.Size = New System.Drawing.Size(270, 22)
        Me.txtMontoBase.TabIndex = 6
        '
        'FormPagoMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1245, 642)
        Me.Controls.Add(Me.PanelPagoMensual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAnyadir)
        Me.Controls.Add(Me.PagoMensualGridView)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(47, 92)
        Me.Name = "FormPagoMensual"
        Me.Text = "FormPagoMensual"
        CType(Me.PagoMensualGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPagoMensual.ResumeLayout(False)
        Me.PanelPagoMensual.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAnyadir As Button
    Friend WithEvents PagoMensualGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents PanelPagoMensual As Panel
    Friend WithEvents cmbRespPago As ComboBox
    Friend WithEvents cmbCedulaNinyo As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents txtMontoComidas As TextBox
    Friend WithEvents txtMontoBase As TextBox
End Class
