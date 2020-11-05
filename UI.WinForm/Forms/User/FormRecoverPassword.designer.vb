<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecoverPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecoverPassword))
        Me.lblResultMessage = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtRequestingUser = New System.Windows.Forms.TextBox()
        Me.titleBar.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResultMessage
        '
        Me.lblResultMessage.AutoSize = True
        Me.lblResultMessage.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblResultMessage.Location = New System.Drawing.Point(39, 166)
        Me.lblResultMessage.Name = "lblResultMessage"
        Me.lblResultMessage.Size = New System.Drawing.Size(61, 17)
        Me.lblResultMessage.TabIndex = 6
        Me.lblResultMessage.Text = "Mensaje"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.Color.LightGray
        Me.label1.Location = New System.Drawing.Point(39, 60)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(308, 17)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Por favor ingrese su nombre de usuario o email"
        '
        'titleBar
        '
        Me.titleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.titleBar.Controls.Add(Me.Label2)
        Me.titleBar.Controls.Add(Me.btnClose)
        Me.titleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleBar.Location = New System.Drawing.Point(0, 0)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(710, 40)
        Me.titleBar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Recuperar mi contraseña"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(684, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnClose.TabIndex = 11
        Me.btnClose.TabStop = False
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(369, 108)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(199, 40)
        Me.btnSend.TabIndex = 9
        Me.btnSend.Text = "Enviar"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'txtRequestingUser
        '
        Me.txtRequestingUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtRequestingUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRequestingUser.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestingUser.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtRequestingUser.Location = New System.Drawing.Point(42, 80)
        Me.txtRequestingUser.Name = "txtRequestingUser"
        Me.txtRequestingUser.Size = New System.Drawing.Size(526, 22)
        Me.txtRequestingUser.TabIndex = 10
        '
        'FormRecoverPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 254)
        Me.Controls.Add(Me.txtRequestingUser)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.titleBar)
        Me.Controls.Add(Me.lblResultMessage)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRecoverPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormRecoverPassword"
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblResultMessage As Label
    Private WithEvents label1 As Label
    Friend WithEvents titleBar As Panel
    Friend WithEvents btnClose As PictureBox
    Private WithEvents Label2 As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents txtRequestingUser As TextBox
End Class
