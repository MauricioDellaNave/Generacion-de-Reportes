<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Sesion_Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarClaveDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarGenerarJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarListar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CNetHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.TableAdapterManager1 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager2 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager3 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager4 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager5 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager6 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager7 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager8 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager9 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AllowMerge = False
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ToolStripMenuItem1, Me.ToolsMenu, Me.ToolStripMenuItem2, Me.ViewMenu, Me.ToolStripMenuItem4, Me.ToolStripMenuItem3})
        Me.MenuStrip.Name = "MenuStrip"
        Me.CNetHelpProvider.SetShowHelp(Me.MenuStrip, CType(resources.GetObject("MenuStrip.ShowHelp"), Boolean))
        '
        'FileMenu
        '
        Me.FileMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.Sesion_Login, Me.ToolStripSeparator5, Me.Salir})
        resources.ApplyResources(Me.FileMenu, "FileMenu")
        Me.FileMenu.Name = "FileMenu"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'Sesion_Login
        '
        resources.ApplyResources(Me.Sesion_Login, "Sesion_Login")
        Me.Sesion_Login.Name = "Sesion_Login"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        resources.ApplyResources(Me.ToolStripSeparator5, "ToolStripSeparator5")
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        resources.ApplyResources(Me.Salir, "Salir")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'ToolsMenu
        '
        resources.ApplyResources(Me.ToolsMenu, "ToolsMenu")
        Me.ToolsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarUsuarios, Me.CambiarClaveDeUsuarioToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        '
        'ToolBarUsuarios
        '
        Me.ToolBarUsuarios.Name = "ToolBarUsuarios"
        resources.ApplyResources(Me.ToolBarUsuarios, "ToolBarUsuarios")
        '
        'CambiarClaveDeUsuarioToolStripMenuItem
        '
        Me.CambiarClaveDeUsuarioToolStripMenuItem.Name = "CambiarClaveDeUsuarioToolStripMenuItem"
        resources.ApplyResources(Me.CambiarClaveDeUsuarioToolStripMenuItem, "CambiarClaveDeUsuarioToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarGenerarJob, Me.ToolBarProductos})
        resources.ApplyResources(Me.ViewMenu, "ViewMenu")
        Me.ViewMenu.Name = "ViewMenu"
        '
        'ToolBarGenerarJob
        '
        Me.ToolBarGenerarJob.Name = "ToolBarGenerarJob"
        resources.ApplyResources(Me.ToolBarGenerarJob, "ToolBarGenerarJob")
        '
        'ToolBarProductos
        '
        Me.ToolBarProductos.Name = "ToolBarProductos"
        resources.ApplyResources(Me.ToolBarProductos, "ToolBarProductos")
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarImprimir, Me.ToolBarListar})
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        resources.ApplyResources(Me.ToolBarImprimir, "ToolBarImprimir")
        '
        'ToolBarListar
        '
        Me.ToolBarListar.Name = "ToolBarListar"
        resources.ApplyResources(Me.ToolBarListar, "ToolBarListar")
        '
        'StatusStrip
        '
        Me.CNetHelpProvider.SetHelpKeyword(Me.StatusStrip, resources.GetString("StatusStrip.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.StatusStrip, CType(resources.GetObject("StatusStrip.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usuario})
        resources.ApplyResources(Me.StatusStrip, "StatusStrip")
        Me.StatusStrip.Name = "StatusStrip"
        Me.CNetHelpProvider.SetShowHelp(Me.StatusStrip, CType(resources.GetObject("StatusStrip.ShowHelp"), Boolean))
        '
        'Usuario
        '
        Me.Usuario.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Usuario, "Usuario")
        Me.Usuario.ForeColor = System.Drawing.Color.MediumBlue
        Me.Usuario.Name = "Usuario"
        '
        'CNetHelpProvider
        '
        resources.ApplyResources(Me.CNetHelpProvider, "CNetHelpProvider")
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.Connection = Nothing
        Me.TableAdapterManager4.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.Connection = Nothing
        Me.TableAdapterManager5.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.Connection = Nothing
        Me.TableAdapterManager6.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager7
        '
        Me.TableAdapterManager7.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager7.Connection = Nothing
        Me.TableAdapterManager7.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager8
        '
        Me.TableAdapterManager8.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager8.Connection = Nothing
        Me.TableAdapterManager8.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager9
        '
        Me.TableAdapterManager9.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager9.Connection = Nothing
        Me.TableAdapterManager9.UpdateOrder = Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Sistema_de_Gestion_Tecnica.My.Resources.Resources.Logo_Correo_chico
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.CNetHelpProvider.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipal"
        Me.CNetHelpProvider.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Sesion_Login As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarGenerarJob As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarListar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents CNetHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents TableAdapterManager1 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager2 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Private WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents TableAdapterManager3 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager4 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager5 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager6 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents TableAdapterManager7 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager8 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents Usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolBarProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarClaveDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableAdapterManager9 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager

End Class
