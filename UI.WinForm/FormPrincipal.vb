Imports System.Runtime.InteropServices
Imports Infrastructure.Common
Imports Domain.Models


Public Class FormPrincipal
#Region "FUNCIONALIDADES DEL FORMULARIO// FUNCTIONALITIES OF THE FORM"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO//RESIZE OF THE FORM- CHANGE SIZE
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL/// DRAW RECTANGLE / EXCLUDE CORNER PANEL
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR/ESQUINA//COLOR AND GRIP OF LOWER RECTANGLE/CORNER
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(67, 81, 120))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'ARRASTRAR/ MOVER EL FORMULARIO///DRAG / MOVE THE FORM
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    'MINIMIZAR, MAXIMIZAR, RESTAURAR EL FORMULARIO
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim lx, ly As Integer
    Dim sw, sh As Integer



    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click

        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)

        btnMaximizar.Visible = True
        btnRestaurar.Visible = False
    End Sub

#End Region
#Region "LOGOUT/ APPLICATION EXIT"
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("¿Está seguro de cerrar sesión?", "Advertencia",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Advertencia",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
#End Region
#Region "OPEN FORM METHODS"
    'METODO DE ABRIR FORMULARIO EN EL PANEL CONTENEDOR//METHOD OF OPENING FORM IN THE CONTAINER PANEL
    Private Sub openFormOnPanel(Of Miform As {Form, New})()

        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado
        If Formulario Is Nothing Then
            'Cerrar formulario anterior , exepto form principal y form login/ Si desea que permita abrir varios formulario en el panel, simplemente elimine el codigo
            My.Application.OpenForms.Cast(Of Form)().Except({Me, FormLogin}).ToList().ForEach(Sub(form) form.Close())
            '-----------------------------------------------
            'Abrir formulario en el panel
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.closedForm
            Formulario.BringToFront()
            Formulario.Show()

        Else 'Si Form Existe, traerlo al frente
            Formulario.BringToFront()
        End If
    End Sub
    'METODO/EVENTO AL CERRAR FORMS//METHOD / EVENT WHEN CLOSING FORMS
    Private Sub closedForm(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("FormUserProfile") Is Nothing) Then
            Timer1.Stop() 'We stop the timer once the user finishes editing his profile And closes the form
            'Detenemos el temporizador una vez que el usuario termine de editar su perfil y cierre el formulario
            'More Codes
        End If
    End Sub

    Private Sub activatedButton(currentButton As Button)

        For Each previousButton As Control In PanelMenu.Controls
            If (previousButton.GetType = GetType(Button)) Then
                previousButton.BackColor = Color.FromArgb(46, 59, 104)
            End If
        Next
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.FromArgb(55, 70, 125)
        End If
    End Sub
#End Region

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUser()
        managePermissions()
    End Sub

    Private Sub loadUser()
        lblUsername.Text = ActiveUser.c_userName
        lblEmail.Text = ActiveUser.c_email
        lblPosition.Text = ActiveUser.c_position
        If (Not (ActiveUser.c_profile) Is Nothing) Then
            pictureProfile.Image = ConvertItem.binaryToImage(ActiveUser.c_profile)
        End If
    End Sub
    'MANEJAR ROLES
    Private Sub managePermissions()
        If ActiveUser.c_position = Positions.recepcionista Then
            btnChart.Enabled = False
            btnSetting.Enabled = False
            btnUsers.Enabled = False
        End If
        If ActiveUser.c_position = Positions.cocinera Then
            btnInfante.Enabled = False
            btnMatricula.Enabled = False
            btnMenu.Enabled = True
            btnUsers.Enabled = False
        End If
        If ActiveUser.c_position = Positions.administrador Then
            '
        End If
        'more...
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadUser() 'update the user's data in the menu (in this form), every 1 second at the time of the edition.
        'actualizar los datos del usuario en el menu (en este formulario), cada 3 segundos al momento de la edicion.
    End Sub

    'BUTTONS TO OPEN FORMS "
    Private Sub btnInfante_Click(sender As Object, e As EventArgs) Handles btnInfante.Click
        openFormOnPanel(Of FormNinyo)()
        activatedButton(btnInfante)
    End Sub

    Private Sub btnClinicalHistory_Click(sender As Object, e As EventArgs) Handles btnMatricula.Click
        openFormOnPanel(Of FormMatricula)()
        activatedButton(btnMatricula)
    End Sub

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        openFormOnPanel(Of FormEncargado)()
        activatedButton(btnMenu)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        openFormOnPanel(Of FormUsers)()
        activatedButton(btnUsers)
    End Sub

    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles pictureProfile.Click 'USER IMAGE 
        openFormOnPanel(Of FormUserProfile)()
        activatedButton(Nothing)
        Timer1.Start()
    End Sub
    Private Sub lblProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblProfile.LinkClicked 'LABEL
        openFormOnPanel(Of FormUserProfile)()
        activatedButton(Nothing)
        Timer1.Start()
    End Sub

End Class
