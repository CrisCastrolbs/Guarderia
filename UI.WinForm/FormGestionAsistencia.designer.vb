<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestionAsistencia
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGestionAsistencia))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProfile = New System.Windows.Forms.LinkLabel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.pictureProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnMatricula = New System.Windows.Forms.Button()
        Me.btnInfante = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1300, 590)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PanelFormularios.Controls.Add(Me.Label1)
        Me.PanelFormularios.Controls.Add(Me.LOGO)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(250, 39)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1050, 551)
        Me.PanelFormularios.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(361, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Guardería Niño Feliz"
        '
        'LOGO
        '
        Me.LOGO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LOGO.Image = CType(resources.GetObject("LOGO.Image"), System.Drawing.Image)
        Me.LOGO.Location = New System.Drawing.Point(185, 90)
        Me.LOGO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(733, 386)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 0
        Me.LOGO.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.btnUsers)
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnChart)
        Me.PanelMenu.Controls.Add(Me.btnSetting)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.btnMatricula)
        Me.PanelMenu.Controls.Add(Me.btnInfante)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 39)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 551)
        Me.PanelMenu.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 375)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Matrícula"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.FlatAppearance.BorderSize = 0
        Me.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(0, 151)
        Me.btnUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(250, 40)
        Me.btnUsers.TabIndex = 7
        Me.btnUsers.Text = "Infantes"
        Me.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 509)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(250, 40)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnChart
        '
        Me.btnChart.FlatAppearance.BorderSize = 0
        Me.btnChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChart.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChart.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnChart.Image = CType(resources.GetObject("btnChart.Image"), System.Drawing.Image)
        Me.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChart.Location = New System.Drawing.Point(0, 419)
        Me.btnChart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(250, 40)
        Me.btnChart.TabIndex = 5
        Me.btnChart.Text = "Chart"
        Me.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'btnSetting
        '
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), System.Drawing.Image)
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(0, 327)
        Me.btnSetting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(250, 40)
        Me.btnSetting.TabIndex = 4
        Me.btnSetting.Text = "Alergia de los Infantes"
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetting.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblProfile)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.pictureProfile)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 123)
        Me.Panel1.TabIndex = 3
        '
        'lblProfile
        '
        Me.lblProfile.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.lblProfile.AutoSize = True
        Me.lblProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProfile.LinkColor = System.Drawing.Color.SteelBlue
        Me.lblProfile.Location = New System.Drawing.Point(9, 90)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(58, 17)
        Me.lblProfile.TabIndex = 9
        Me.lblProfile.TabStop = True
        Me.lblProfile.Text = "Mi Perfil"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.DarkGray
        Me.lblEmail.Location = New System.Drawing.Point(74, 64)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 17)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.LightGray
        Me.lblUsername.Location = New System.Drawing.Point(74, 30)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(106, 17)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Nombre Usuario"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPosition.Location = New System.Drawing.Point(74, 47)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(27, 17)
        Me.lblPosition.TabIndex = 5
        Me.lblPosition.Text = "Rol"
        '
        'pictureProfile
        '
        Me.pictureProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureProfile.Image = Global.UI.WinForm.My.Resources.Resources.defaultImageProfileUser
        Me.pictureProfile.Location = New System.Drawing.Point(6, 23)
        Me.pictureProfile.Name = "pictureProfile"
        Me.pictureProfile.Size = New System.Drawing.Size(64, 64)
        Me.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureProfile.TabIndex = 6
        Me.pictureProfile.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(213, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.Location = New System.Drawing.Point(0, 283)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(250, 40)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Alergia - Platos"
        Me.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnMatricula
        '
        Me.btnMatricula.FlatAppearance.BorderSize = 0
        Me.btnMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatricula.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatricula.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMatricula.Image = CType(resources.GetObject("btnMatricula.Image"), System.Drawing.Image)
        Me.btnMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatricula.Location = New System.Drawing.Point(0, 239)
        Me.btnMatricula.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMatricula.Name = "btnMatricula"
        Me.btnMatricula.Size = New System.Drawing.Size(250, 40)
        Me.btnMatricula.TabIndex = 1
        Me.btnMatricula.Text = "Tipos de Alergia"
        Me.btnMatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMatricula.UseVisualStyleBackColor = True
        '
        'btnInfante
        '
        Me.btnInfante.FlatAppearance.BorderSize = 0
        Me.btnInfante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnInfante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfante.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfante.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInfante.Image = CType(resources.GetObject("btnInfante.Image"), System.Drawing.Image)
        Me.btnInfante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInfante.Location = New System.Drawing.Point(0, 195)
        Me.btnInfante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInfante.Name = "btnInfante"
        Me.btnInfante.Size = New System.Drawing.Size(250, 40)
        Me.btnInfante.TabIndex = 0
        Me.btnInfante.Text = "Asistencia"
        Me.btnInfante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInfante.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label2)
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1300, 39)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(57, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gestión de Asistencia"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(1237, 12)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(16, 16)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1199, 12)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1237, 12)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(16, 16)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1273, 12)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'FormGestionAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 590)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormGestionAsistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnMatricula As Button
    Friend WithEvents btnInfante As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSetting As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents pictureProfile As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnChart As Button
    Friend WithEvents lblProfile As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnUsers As Button
    Friend WithEvents Button1 As Button
End Class
