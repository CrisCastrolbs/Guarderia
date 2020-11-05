<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsers
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.linkChangePictureProfile = New System.Windows.Forms.LinkLabel()
        Me.editedPictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editedPictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(36, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Position"
        '
        'cmbPosition
        '
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"Accounting", "Administrator", "Receptionist"})
        Me.cmbPosition.Location = New System.Drawing.Point(40, 248)
        Me.cmbPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(269, 24)
        Me.cmbPosition.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.label8)
        Me.Panel1.Controls.Add(Me.linkChangePictureProfile)
        Me.Panel1.Controls.Add(Me.editedPictureBoxProfile)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.cmbPosition)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lbl2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(702, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 551)
        Me.Panel1.TabIndex = 45
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
        Me.btnCancel.Text = "Cancel"
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
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(33, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 31)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Maintenance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(39, 296)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(270, 23)
        Me.txtUsername.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(39, 342)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(270, 23)
        Me.txtPassword.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(36, 178)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(46, 17)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(39, 198)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 23)
        Me.txtEmail.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Last name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(39, 152)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(130, 23)
        Me.txtLastName.TabIndex = 8
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(39, 106)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(130, 23)
        Me.txtFirstName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "First name:"
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
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 46
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Users"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(33, 63)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(649, 23)
        Me.txtSearch.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(30, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Search:  (press enter)"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(33, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(649, 353)
        Me.DataGridView1.TabIndex = 50
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(280, 478)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 38)
        Me.btnAdd.TabIndex = 51
        Me.btnAdd.Text = "Add new"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.IndianRed
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(552, 477)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(130, 38)
        Me.btnRemove.TabIndex = 52
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(416, 477)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(130, 38)
        Me.btnEdit.TabIndex = 53
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.ForeColor = System.Drawing.Color.Gray
        Me.label8.Location = New System.Drawing.Point(178, 156)
        Me.label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(132, 34)
        Me.label8.TabIndex = 66
        Me.label8.Text = "Recommended size" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "90 x100 pixels"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'linkChangePictureProfile
        '
        Me.linkChangePictureProfile.ActiveLinkColor = System.Drawing.Color.White
        Me.linkChangePictureProfile.AutoSize = True
        Me.linkChangePictureProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkChangePictureProfile.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.linkChangePictureProfile.Location = New System.Drawing.Point(281, 92)
        Me.linkChangePictureProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkChangePictureProfile.Name = "linkChangePictureProfile"
        Me.linkChangePictureProfile.Size = New System.Drawing.Size(57, 17)
        Me.linkChangePictureProfile.TabIndex = 67
        Me.linkChangePictureProfile.TabStop = True
        Me.linkChangePictureProfile.Text = "Change"
        '
        'editedPictureBoxProfile
        '
        Me.editedPictureBoxProfile.Image = Global.UI.WinForm.My.Resources.Resources.defaultImageProfileUser
        Me.editedPictureBoxProfile.Location = New System.Drawing.Point(178, 57)
        Me.editedPictureBoxProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.editedPictureBoxProfile.Name = "editedPictureBoxProfile"
        Me.editedPictureBoxProfile.Size = New System.Drawing.Size(100, 95)
        Me.editedPictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editedPictureBoxProfile.TabIndex = 68
        Me.editedPictureBoxProfile.TabStop = False
        '
        'FormUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 551)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCreateUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editedPictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents label8 As Label
    Friend WithEvents linkChangePictureProfile As LinkLabel
    Friend WithEvents editedPictureBoxProfile As PictureBox
End Class
