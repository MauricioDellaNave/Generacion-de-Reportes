<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblContraseņa As System.Windows.Forms.Label
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblContraseņa = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.MensajeError = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Mensaje = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.CNetHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.CultureManager1 = New Core.Localization.CultureManager(Me.components)
        Me.TableAdapterManager1 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.TableAdapterManager2 = New Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        resources.ApplyResources(Me.LblUsuario, "LblUsuario")
        Me.CNetHelpProvider.SetHelpKeyword(Me.LblUsuario, resources.GetString("LblUsuario.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.LblUsuario, CType(resources.GetObject("LblUsuario.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.LblUsuario, resources.GetString("LblUsuario.HelpString"))
        Me.LblUsuario.Name = "LblUsuario"
        Me.CNetHelpProvider.SetShowHelp(Me.LblUsuario, CType(resources.GetObject("LblUsuario.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.LblUsuario, resources.GetString("LblUsuario.ToolTip"))
        '
        'LblContraseņa
        '
        resources.ApplyResources(Me.LblContraseņa, "LblContraseņa")
        Me.CNetHelpProvider.SetHelpKeyword(Me.LblContraseņa, resources.GetString("LblContraseņa.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.LblContraseņa, CType(resources.GetObject("LblContraseņa.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.LblContraseņa, resources.GetString("LblContraseņa.HelpString"))
        Me.LblContraseņa.Name = "LblContraseņa"
        Me.CNetHelpProvider.SetShowHelp(Me.LblContraseņa, CType(resources.GetObject("LblContraseņa.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.LblContraseņa, resources.GetString("LblContraseņa.ToolTip"))
        '
        'TxtUsuario
        '
        resources.ApplyResources(Me.TxtUsuario, "TxtUsuario")
        Me.TxtUsuario.BackColor = System.Drawing.Color.Snow
        Me.CNetHelpProvider.SetHelpKeyword(Me.TxtUsuario, resources.GetString("TxtUsuario.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.TxtUsuario, CType(resources.GetObject("TxtUsuario.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.TxtUsuario, resources.GetString("TxtUsuario.HelpString"))
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.CNetHelpProvider.SetShowHelp(Me.TxtUsuario, CType(resources.GetObject("TxtUsuario.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.TxtUsuario, resources.GetString("TxtUsuario.ToolTip"))
        '
        'TxtClave
        '
        resources.ApplyResources(Me.TxtClave, "TxtClave")
        Me.TxtClave.BackColor = System.Drawing.Color.Snow
        Me.CNetHelpProvider.SetHelpKeyword(Me.TxtClave, resources.GetString("TxtClave.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.TxtClave, CType(resources.GetObject("TxtClave.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.TxtClave, resources.GetString("TxtClave.HelpString"))
        Me.TxtClave.Name = "TxtClave"
        Me.CNetHelpProvider.SetShowHelp(Me.TxtClave, CType(resources.GetObject("TxtClave.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.TxtClave, resources.GetString("TxtClave.ToolTip"))
        '
        'BtnAceptar
        '
        resources.ApplyResources(Me.BtnAceptar, "BtnAceptar")
        Me.BtnAceptar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CNetHelpProvider.SetHelpKeyword(Me.BtnAceptar, resources.GetString("BtnAceptar.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.BtnAceptar, CType(resources.GetObject("BtnAceptar.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.BtnAceptar, resources.GetString("BtnAceptar.HelpString"))
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.CNetHelpProvider.SetShowHelp(Me.BtnAceptar, CType(resources.GetObject("BtnAceptar.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.BtnAceptar, resources.GetString("BtnAceptar.ToolTip"))
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CNetHelpProvider.SetHelpKeyword(Me.BtnCancelar, resources.GetString("BtnCancelar.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.BtnCancelar, CType(resources.GetObject("BtnCancelar.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.BtnCancelar, resources.GetString("BtnCancelar.HelpString"))
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.CNetHelpProvider.SetShowHelp(Me.BtnCancelar, CType(resources.GetObject("BtnCancelar.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.BtnCancelar, resources.GetString("BtnCancelar.ToolTip"))
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'MensajeError
        '
        resources.ApplyResources(Me.MensajeError, "MensajeError")
        Me.MensajeError.ForeColor = System.Drawing.Color.Red
        Me.CNetHelpProvider.SetHelpKeyword(Me.MensajeError, resources.GetString("MensajeError.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.MensajeError, CType(resources.GetObject("MensajeError.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.MensajeError, resources.GetString("MensajeError.HelpString"))
        Me.MensajeError.Name = "MensajeError"
        Me.CNetHelpProvider.SetShowHelp(Me.MensajeError, CType(resources.GetObject("MensajeError.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.MensajeError, resources.GetString("MensajeError.ToolTip"))
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Controls.Add(Me.TxtClave)
        Me.GroupBox1.Controls.Add(Me.LblContraseņa)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Controls.Add(Me.LblUsuario)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CNetHelpProvider.SetHelpKeyword(Me.GroupBox1, resources.GetString("GroupBox1.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.GroupBox1, CType(resources.GetObject("GroupBox1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.GroupBox1, resources.GetString("GroupBox1.HelpString"))
        Me.GroupBox1.Name = "GroupBox1"
        Me.CNetHelpProvider.SetShowHelp(Me.GroupBox1, CType(resources.GetObject("GroupBox1.ShowHelp"), Boolean))
        Me.GroupBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        '
        'Mensaje
        '
        resources.ApplyResources(Me.Mensaje, "Mensaje")
        Me.CNetHelpProvider.SetHelpKeyword(Me.Mensaje, resources.GetString("Mensaje.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.Mensaje, CType(resources.GetObject("Mensaje.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.Mensaje, resources.GetString("Mensaje.HelpString"))
        Me.Mensaje.Name = "Mensaje"
        Me.CNetHelpProvider.SetShowHelp(Me.Mensaje, CType(resources.GetObject("Mensaje.ShowHelp"), Boolean))
        Me.ToolTip1.SetToolTip(Me.Mensaje, resources.GetString("Mensaje.ToolTip"))
        '
        'LogoPictureBox
        '
        resources.ApplyResources(Me.LogoPictureBox, "LogoPictureBox")
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CNetHelpProvider.SetHelpKeyword(Me.LogoPictureBox, resources.GetString("LogoPictureBox.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me.LogoPictureBox, CType(resources.GetObject("LogoPictureBox.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me.LogoPictureBox, resources.GetString("LogoPictureBox.HelpString"))
        Me.LogoPictureBox.Image = Global.Sistema_de_Gestion_Tecnica.My.Resources.Resources.Login
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.CNetHelpProvider.SetShowHelp(Me.LogoPictureBox, CType(resources.GetObject("LogoPictureBox.ShowHelp"), Boolean))
        Me.LogoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LogoPictureBox, resources.GetString("LogoPictureBox.ToolTip"))
        '
        'CNetHelpProvider
        '
        resources.ApplyResources(Me.CNetHelpProvider, "CNetHelpProvider")
        '
        'CultureManager1
        '
        Me.CultureManager1.ManagedControl = Me
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
        'Login
        '
        Me.AcceptButton = Me.BtnAceptar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.CancelButton = Me.BtnCancelar
        Me.CausesValidation = False
        Me.ControlBox = False
        Me.Controls.Add(Me.Mensaje)
        Me.Controls.Add(Me.MensajeError)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.CNetHelpProvider.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.CNetHelpProvider.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.CNetHelpProvider.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.CNetHelpProvider.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MensajeError As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Mensaje As System.Windows.Forms.Label
    Public WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CNetHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents CultureManager1 As Core.Localization.CultureManager
    Friend WithEvents TableAdapterManager1 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager2 As Sistema_de_Gestion_Tecnica.DsIngresoTableAdapters.TableAdapterManager

End Class
