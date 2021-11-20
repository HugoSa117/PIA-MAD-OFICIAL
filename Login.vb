Imports System.Runtime.InteropServices

Public Class Login
#Region "Form Behaviors"

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click 'BOTON CERRAR
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click 'BOTON MINIMIZAR
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub


    Private Sub TittleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TittleBar.MouseMove 'Mover la pantalla 
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


#End Region

#Region "Customize Controls"
    Private Sub CustomizeComponents()
        'Texto del username
        txtUser.AutoSize = False
        txtUser.Size = New Size(350, 35)

        'texto de password
        txtPass.AutoSize = False
        txtPass.Size = New Size(350, 35)
        txtPass.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Paint(sender As Object, e As PaintEventArgs) Handles Button1.Paint 'ESQUINAS REDONDAS DE BOTON LOGIN
        Dim buttonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = Button1.ClientRectangle
        myRectangle.Inflate(0, 40)
        buttonPath.AddEllipse(myRectangle)
        Button1.Region = New Region(buttonPath)
    End Sub

#End Region

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CustomizeComponents()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub


End Class
