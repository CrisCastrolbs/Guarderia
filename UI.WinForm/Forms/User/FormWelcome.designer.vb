<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWelcome))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.panel1.Controls.Add(Me.pictureBox2)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1100, 100)
        Me.panel1.TabIndex = 7
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(8, 7)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(78, 84)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 5
        Me.pictureBox2.TabStop = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Silver
        Me.label2.Location = New System.Drawing.Point(92, 32)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(262, 31)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Guardería Niño Feliz"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.label3.Location = New System.Drawing.Point(1019, 478)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Version: 1.32"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label1.Location = New System.Drawing.Point(377, 103)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(188, 76)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Hola!"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUser.Location = New System.Drawing.Point(546, 179)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(108, 31)
        Me.lblUser.TabIndex = 9
        Me.lblUser.Text = "Usuario"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(1, 96)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(351, 405)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 11
        Me.pictureBox1.TabStop = False
        '
        'timer1
        '
        Me.timer1.Interval = 30
        '
        'timer2
        '
        Me.timer2.Interval = 30
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.LightGray
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(465, 306)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 25
        Me.CircularProgressBar1.ProgressColor = System.Drawing.SystemColors.HotTrack
        Me.CircularProgressBar1.ProgressWidth = 20
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(170, 170)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = "%"
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = ""
        Me.CircularProgressBar1.TabIndex = 12
        Me.CircularProgressBar1.Text = "0"
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 68
        '
        'FormWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 500)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormWelcome"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label1 As Label
    Private WithEvents lblUser As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents timer1 As Timer
    Private WithEvents timer2 As Timer
    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
End Class
