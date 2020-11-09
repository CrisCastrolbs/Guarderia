<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNinyo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NinyosGridView = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelNinyo = New System.Windows.Forms.Panel()
        Me.dateNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalNinyas = New System.Windows.Forms.Label()
        Me.lblTotalNinyos = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.txtSearch2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.NinyosGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNinyo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registro de Niño(a)"
        '
        'NinyosGridView
        '
        Me.NinyosGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NinyosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.NinyosGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.NinyosGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.NinyosGridView.ColumnHeadersHeight = 29
        Me.NinyosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.NinyosGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NinyosGridView.Location = New System.Drawing.Point(33, 106)
        Me.NinyosGridView.Name = "NinyosGridView"
        Me.NinyosGridView.RowHeadersWidth = 51
        Me.NinyosGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.NinyosGridView.Size = New System.Drawing.Size(649, 353)
        Me.NinyosGridView.TabIndex = 50
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(860, 91)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(181, 43)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.btnRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRemove.Location = New System.Drawing.Point(860, 192)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(181, 43)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Eliminar"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Ebrima", 10.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(860, 142)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(181, 43)
        Me.btnEdit.TabIndex = 4
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelNinyo
        '
        Me.PanelNinyo.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.PanelNinyo.Controls.Add(Me.dateNacimiento)
        Me.PanelNinyo.Controls.Add(Me.btnCancel)
        Me.PanelNinyo.Controls.Add(Me.cmbSexo)
        Me.PanelNinyo.Controls.Add(Me.btnSave)
        Me.PanelNinyo.Controls.Add(Me.Label9)
        Me.PanelNinyo.Controls.Add(Me.Label11)
        Me.PanelNinyo.Controls.Add(Me.Label10)
        Me.PanelNinyo.Controls.Add(Me.txtApellido2)
        Me.PanelNinyo.Controls.Add(Me.lbl2)
        Me.PanelNinyo.Controls.Add(Me.Label12)
        Me.PanelNinyo.Controls.Add(Me.txtApellido1)
        Me.PanelNinyo.Controls.Add(Me.Label13)
        Me.PanelNinyo.Controls.Add(Me.txtNombre)
        Me.PanelNinyo.Controls.Add(Me.txtCedula)
        Me.PanelNinyo.Controls.Add(Me.Label14)
        Me.PanelNinyo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelNinyo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PanelNinyo.Location = New System.Drawing.Point(702, 0)
        Me.PanelNinyo.Name = "PanelNinyo"
        Me.PanelNinyo.Size = New System.Drawing.Size(348, 551)
        Me.PanelNinyo.TabIndex = 45
        '
        'dateNacimiento
        '
        Me.dateNacimiento.Location = New System.Drawing.Point(39, 305)
        Me.dateNacimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dateNacimiento.Name = "dateNacimiento"
        Me.dateNacimiento.Size = New System.Drawing.Size(271, 23)
        Me.dateNacimiento.TabIndex = 45
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
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cmbSexo.Location = New System.Drawing.Point(40, 352)
        Me.cmbSexo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(269, 24)
        Me.cmbSexo.TabIndex = 44
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(179, 415)
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
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(36, 233)
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
        Me.Label11.Location = New System.Drawing.Point(33, 22)
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
        Me.Label10.Location = New System.Drawing.Point(36, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Fecha de Nacimiento:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(39, 256)
        Me.txtApellido2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(271, 23)
        Me.txtApellido2.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(36, 185)
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
        Me.Label12.Location = New System.Drawing.Point(36, 331)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Sexo:"
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(39, 204)
        Me.txtApellido1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(271, 23)
        Me.txtApellido1.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(36, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(39, 156)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(271, 23)
        Me.txtNombre.TabIndex = 8
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(39, 106)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(271, 23)
        Me.txtCedula.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(36, 86)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 17)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Cédula:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(30, 484)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Total Niñas:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(30, 516)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Total Niños:"
        '
        'lblTotalNinyas
        '
        Me.lblTotalNinyas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalNinyas.AutoSize = True
        Me.lblTotalNinyas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNinyas.ForeColor = System.Drawing.Color.Red
        Me.lblTotalNinyas.Location = New System.Drawing.Point(120, 484)
        Me.lblTotalNinyas.Name = "lblTotalNinyas"
        Me.lblTotalNinyas.Size = New System.Drawing.Size(57, 18)
        Me.lblTotalNinyas.TabIndex = 52
        Me.lblTotalNinyas.Text = "Label5"
        '
        'lblTotalNinyos
        '
        Me.lblTotalNinyos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalNinyos.AutoSize = True
        Me.lblTotalNinyos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblTotalNinyos.ForeColor = System.Drawing.Color.Red
        Me.lblTotalNinyos.Location = New System.Drawing.Point(120, 516)
        Me.lblTotalNinyos.Name = "lblTotalNinyos"
        Me.lblTotalNinyos.Size = New System.Drawing.Size(57, 18)
        Me.lblTotalNinyos.TabIndex = 52
        Me.lblTotalNinyos.Text = "Label5"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(33, 63)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(293, 23)
        Me.txtSearch.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(30, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(259, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Búsqueda por Cédula:  (presione enter)"
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(552, 477)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(130, 38)
        Me.btnEditar.TabIndex = 52
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAñadir
        '
        Me.btnAñadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAñadir.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAñadir.FlatAppearance.BorderSize = 0
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAñadir.ForeColor = System.Drawing.Color.White
        Me.btnAñadir.Location = New System.Drawing.Point(416, 477)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(130, 38)
        Me.btnAñadir.TabIndex = 52
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'txtSearch2
        '
        Me.txtSearch2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch2.Location = New System.Drawing.Point(389, 63)
        Me.txtSearch2.Name = "txtSearch2"
        Me.txtSearch2.Size = New System.Drawing.Size(293, 23)
        Me.txtSearch2.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(386, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 17)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Búsqueda:  (Nombre, Apellidos, Sexo)"
        '
        'FormNinyo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 551)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch2)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblTotalNinyos)
        Me.Controls.Add(Me.lblTotalNinyas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelNinyo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.NinyosGridView)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormNinyo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCreateNinyo"
        CType(Me.NinyosGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNinyo.ResumeLayout(False)
        Me.PanelNinyo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelNinyo As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents cmbSexo As ComboBox
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
    Friend WithEvents dateNacimiento As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalNinyas As Label
    Friend WithEvents lblTotalNinyos As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents NinyosGridView As DataGridView
    Friend WithEvents txtSearch2 As TextBox
    Friend WithEvents Label2 As Label
End Class
