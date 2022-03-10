Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class MenuPrincipal

#Region "Declaraciones"
    Dim oJobs As New Jobs
#End Region

    Public Shared Sub CloseAllToolStripMenuItem_Click()
        'Close all child forms of the parent.
        For Each ChildForm As Form In MenuPrincipal.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'SETEO MI PROPIA CONFIGURACION REGIONAL

        'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        ' System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"

        'AL COMIENZO DEÑIEGO TODAS LAS PATENTES

        'Administrar
        Me.ToolBarGenerarJob.Enabled = False
        'Seguridad
        Me.ToolBarUsuarios.Enabled = False
        'Impresiones
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarListar.Enabled = False


        Select Case VariablesGlobales.FamiliaUsuarioLogueado
            Case "Operador"
                'Sesion
                Me.Sesion_Login.Enabled = False
                Me.Salir.Enabled = False
                'Administrar
                Me.ToolBarGenerarJob.Enabled = False
                Me.ToolBarProductos.Enabled = False
                'Seguridad
                Me.ToolBarUsuarios.Enabled = False
                'Impresiones
                Me.ToolBarImprimir.Enabled = True
                Me.ToolBarListar.Enabled = False

                'Cargo el formulario Generar Reporte de Salida
                'oJobs.IDEstado = 0
                'oJobs.JobActivo()
                'If oJobs.IDEstado = 1 Then
                '    Me.Enabled = False
                '    ReporteSalida.Show()
                'Else
                '    MsgBox("Actualmente no se encuentra ningun Job activo, un Supervisor debe generar un job nuevo desde el menu Administrar/Generar Jobs", vbInformation, "Informacion del sistema")
                'End If


            Case "Supervisor"
                'Administrar
                Me.ToolBarGenerarJob.Enabled = True
                Me.ToolBarProductos.Enabled = True
                'Seguridad
                Me.ToolBarUsuarios.Enabled = False
                'Impresiones
                Me.ToolBarImprimir.Enabled = True
                Me.ToolBarListar.Enabled = True

                'Cargo el formulario Generar Jobs
                oJobs.IDEstado = 0
                oJobs.JobActivo()
                If oJobs.IDEstado = 1 Then
                    MsgBox("Ya se ha generado un Job, debe imprimir el reporte de salida para poder generar un job nuevo", vbInformation, "Informacion del sistema")
                Else
                    Me.Enabled = False
                    GenerarJobs.Show()
                End If

            Case "Administrador"
                'Administrar
                Me.ToolBarGenerarJob.Enabled = True
                'Seguridad
                Me.ToolBarUsuarios.Enabled = True
                'Impresiones
                Me.ToolBarImprimir.Enabled = True
                Me.ToolBarListar.Enabled = True
        End Select

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        If (MsgBox("¿Esta seguro que desea Salir del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Información del Sistema")) = MsgBoxResult.Yes Then
            Me.Close()
            End
        End If

    End Sub


    Private Sub Sesion_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sesion_Login.Click

        'Antes de Cerrar la sesion del sistema pregunto si el usuario esta seguro en abandonar el sistema
        If (MsgBox("¿Esta seguro que desea Cerrar la Sesión del Sistema?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Información del Sistema")) = MsgBoxResult.Yes Then

            Me.Dispose()

            Login.TxtUsuario.Text = ""
            Login.TxtClave.Text = ""
            Login.Visible = True
            Login.TxtUsuario.Focus()

        End If

    End Sub

    Private Sub ToolBarUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarUsuarios.Click
        'Cargo el formulario de Usuarios
        Me.Enabled = False
        ABMPatentes.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarProductos.Click
        'Cargo el formulario productos
        Me.Enabled = False
        ProductosABM.Show()
    End Sub

    Private Sub ToolBarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarGenerarJob.Click
        'Cargo el formulario Generar Jobs
        oJobs.IDEstado = 0
        oJobs.JobActivo()
        If oJobs.IDEstado = 1 Then
            MsgBox("Ya se ha generado un Job, debe imprimir el reporte de salida para poder generar un job nuevo", vbInformation, "Informacion del sistema")
        Else
            Me.Enabled = False
            GenerarJobs.Show()
        End If
    End Sub

    Private Sub ToolBarOrdeneIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarImprimir.Click
        'Cargo el formulario Generar Reporte de Salida
        oJobs.IDEstado = 0
        oJobs.JobActivo()
        If oJobs.IDEstado = 1 Then
            Me.Enabled = False
            ReporteSalida.Show()
        Else
            MsgBox("Actualmente no se encuentra ningun Job activo, un Supervisor debe generar un job nuevo desde el menu Administrar/Generar Jobs", vbInformation, "Informacion del sistema")
        End If
    End Sub

    Private Sub ToolBarOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarListar.Click
        'Cargo el formulario Listar Reporte de Salida
        Me.Enabled = False
        ListarReporteSalida.Show()
    End Sub


    Private Sub CambiarClaveDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarClaveDeUsuarioToolStripMenuItem.Click
        'Cargo el formulario Cambiar clave de Usuario
        Me.Enabled = False
        CambiarClave.Show()
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub
End Class
