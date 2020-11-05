<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUserProfile
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
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfimPass = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkEditPass = New System.Windows.Forms.LinkLabel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.linkEdit = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.linkChangePictureProfile = New System.Windows.Forms.LinkLabel()
        Me.editedPictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.pictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.editedPictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(39, 99)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(186, 23)
        Me.txtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(39, 283)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(325, 23)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblConfimPass
        '
        Me.lblConfimPass.AutoSize = True
        Me.lblConfimPass.BackColor = System.Drawing.Color.Transparent
        Me.lblConfimPass.ForeColor = System.Drawing.Color.White
        Me.lblConfimPass.Location = New System.Drawing.Point(36, 309)
        Me.lblConfimPass.Name = "lblConfimPass"
        Me.lblConfimPass.Size = New System.Drawing.Size(156, 17)
        Me.lblConfimPass.TabIndex = 5
        Me.lblConfimPass.Text = "Confirm your password:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Location = New System.Drawing.Point(39, 329)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.Size = New System.Drawing.Size(325, 23)
        Me.txtConfirmPass.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "First name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(39, 145)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(186, 23)
        Me.txtFirstName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Last name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(39, 191)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(325, 23)
        Me.txtLastName.TabIndex = 8
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(36, 217)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(46, 17)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(39, 237)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(325, 23)
        Me.txtEmail.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LinkEditPass)
        Me.Panel1.Controls.Add(Me.linkChangePictureProfile)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.editedPictureBoxProfile)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.lbl2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtConfirmPass)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblConfimPass)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(650, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 551)
        Me.Panel1.TabIndex = 14
        Me.Panel1.Visible = False
        '
        'LinkEditPass
        '
        Me.LinkEditPass.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkEditPass.AutoSize = True
        Me.LinkEditPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkEditPass.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.LinkEditPass.Location = New System.Drawing.Point(115, 263)
        Me.LinkEditPass.Name = "LinkEditPass"
        Me.LinkEditPass.Size = New System.Drawing.Size(32, 17)
        Me.LinkEditPass.TabIndex = 25
        Me.LinkEditPass.TabStop = True
        Me.LinkEditPass.Text = "Edit"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(39, 415)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(153, 49)
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
        Me.btnSave.Location = New System.Drawing.Point(211, 415)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(153, 49)
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
        Me.Label11.Size = New System.Drawing.Size(164, 31)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Edit my data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(189, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Username:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(189, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(189, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Last name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(189, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "First name:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUser.Location = New System.Drawing.Point(189, 79)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(36, 17)
        Me.lblUser.TabIndex = 19
        Me.lblUser.Text = "user"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblName.Location = New System.Drawing.Point(189, 123)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(43, 17)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblLastName.Location = New System.Drawing.Point(189, 167)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(67, 17)
        Me.lblLastName.TabIndex = 21
        Me.lblLastName.Text = "lastName"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMail.Location = New System.Drawing.Point(189, 211)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(33, 17)
        Me.lblMail.TabIndex = 22
        Me.lblMail.Text = "mail"
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
        Me.btnCerrar.TabIndex = 23
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'linkEdit
        '
        Me.linkEdit.ActiveLinkColor = System.Drawing.Color.White
        Me.linkEdit.AutoSize = True
        Me.linkEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkEdit.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.linkEdit.Location = New System.Drawing.Point(138, 283)
        Me.linkEdit.Name = "linkEdit"
        Me.linkEdit.Size = New System.Drawing.Size(75, 17)
        Me.linkEdit.TabIndex = 24
        Me.linkEdit.TabStop = True
        Me.linkEdit.Text = "Edit profile"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblPosition.Location = New System.Drawing.Point(189, 255)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(57, 17)
        Me.lblPosition.TabIndex = 26
        Me.lblPosition.Text = "position"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(189, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Position:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 31)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "My Profile"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(223, 146)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 34)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Recommended size" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "90 x100 pixels"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'linkChangePictureProfile
        '
        Me.linkChangePictureProfile.ActiveLinkColor = System.Drawing.Color.White
        Me.linkChangePictureProfile.AutoSize = True
        Me.linkChangePictureProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkChangePictureProfile.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.linkChangePictureProfile.Location = New System.Drawing.Point(335, 82)
        Me.linkChangePictureProfile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkChangePictureProfile.Name = "linkChangePictureProfile"
        Me.linkChangePictureProfile.Size = New System.Drawing.Size(57, 17)
        Me.linkChangePictureProfile.TabIndex = 42
        Me.linkChangePictureProfile.TabStop = True
        Me.linkChangePictureProfile.Text = "Change"
        '
        'editedPictureBoxProfile
        '
        Me.editedPictureBoxProfile.Image = Global.UI.WinForm.My.Resources.Resources.defaultImageProfileUser
        Me.editedPictureBoxProfile.Location = New System.Drawing.Point(232, 47)
        Me.editedPictureBoxProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.editedPictureBoxProfile.Name = "editedPictureBoxProfile"
        Me.editedPictureBoxProfile.Size = New System.Drawing.Size(100, 95)
        Me.editedPictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editedPictureBoxProfile.TabIndex = 43
        Me.editedPictureBoxProfile.TabStop = False
        '
        'pictureBoxProfile
        '
        Me.pictureBoxProfile.Image = Global.UI.WinForm.My.Resources.Resources.defaultImageProfileUser
        Me.pictureBoxProfile.Location = New System.Drawing.Point(65, 61)
        Me.pictureBoxProfile.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBoxProfile.Name = "pictureBoxProfile"
        Me.pictureBoxProfile.Size = New System.Drawing.Size(100, 95)
        Me.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxProfile.TabIndex = 28
        Me.pictureBoxProfile.TabStop = False
        '
        'FormUserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1050, 551)
        Me.Controls.Add(Me.pictureBoxProfile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.linkEdit)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormUserProfile"
        Me.Text = "FormEditUserProfile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.editedPictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblConfimPass As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents linkEdit As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LinkEditPass As LinkLabel
    Friend WithEvents lblPosition As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents linkChangePictureProfile As LinkLabel
    Friend WithEvents editedPictureBoxProfile As PictureBox
    Friend WithEvents pictureBoxProfile As PictureBox
End Class
