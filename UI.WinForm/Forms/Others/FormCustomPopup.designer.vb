<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCustomPopup
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
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtPass.Location = New System.Drawing.Point(44, 41)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(427, 19)
        Me.txtPass.TabIndex = 7
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnAccept.FlatAppearance.BorderSize = 0
        Me.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccept.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(44, 100)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(427, 45)
        Me.btnAccept.TabIndex = 8
        Me.btnAccept.Text = "Aceptar"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(128, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese su contraseña actual"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.Tomato
        Me.lblResult.Location = New System.Drawing.Point(40, 63)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(60, 19)
        Me.lblResult.TabIndex = 10
        Me.lblResult.Text = "Mensaje"
        '
        'FormCustomPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 168)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormCustomPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modal form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnAccept As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
End Class
