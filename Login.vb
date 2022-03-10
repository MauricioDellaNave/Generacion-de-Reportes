Imports CapaNegocio.Usuario
Imports System.Globalization
Imports System.Resources
Imports System.Threading

Public Class Login

#Region "Declaraciones"

    Dim veces As Integer = 0
    Dim NumeroIntentos As Integer
    Dim oUsuario As New Usuario
    Dim oUsuarios As New Usuarios

#End Region

#Region "Metodos"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        'Utilizo Regular Expresion para realizar la validacion de los textbox Usuario y Clave
        'Valida solo caracteres Alfanuméricos
        Dim mregexValidacion As New System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]+$")
        Dim mcolUsuario As System.Text.RegularExpressions.MatchCollection
        Dim mcolClave As System.Text.RegularExpressions.MatchCollection
        mcolUsuario = mregexValidacion.Matches(TxtUsuario.Text)
        mcolClave = mregexValidacion.Matches(TxtClave.Text)

        If mcolUsuario.Count And mcolClave.Count > 0 Then

            'Instancio a la clase usuario y le cargo el usuario y clave logueado.
            oUsuario.Usuario = TxtUsuario.Text
            oUsuarios.Usuario = TxtUsuario.Text
            oUsuario.Clave = TxtClave.Text

            'Llamo a la funcion para saber cual es el cargo del usuario logueado
            'y asi saber que permisos de acceso lo asigno.
            oUsuarios.CargarFamilia()
            oUsuarios.MostrarApellidoNombre()
            VariablesGlobales.FamiliaUsuarioLogueado = oUsuarios.Cargo
            VariablesGlobales.UsuarioLogueado = oUsuarios.Nombre & " " & oUsuarios.Apellido
            VariablesGlobales.IDUsuario = oUsuarios.ID

            'Valido que tenga conexion con la base de datos
            oUsuario.ValidarConexion()
            If oUsuario.ValidarConexion = True Then
                'Al presionar Aceptar valida al usuario a travez del metodo ValidarLogin en la capa de negocio
                If oUsuario.ValidarLogin() Then

                    ' Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Visible = False
                    MenuPrincipal.Show()
                    MenuPrincipal.Enabled = True
                Else
                    'Permito varios intentos de ingreso de clave erronea
                    veces = veces + 1
                    NumeroIntentos = 3
                    If veces < NumeroIntentos Then

                        'Al ingresar la clave erroneamente limpio los cuadros de texto 
                        TxtUsuario.Text = ""
                        TxtClave.Text = ""
                        TxtUsuario.Focus()
                        MsgBox("El usuario y la clave son incorrectas, por favor verifiquelos e intentelo nuevamente ", vbInformation, "Información del Sistema")
                    Else
                        'Si ingreso 3 veces la clave incorrecta se cierra el sistema
                        Me.Dispose()
                        Me.Close()
                        End

                    End If
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                Sin_Conexion.Show(Me)
            End If

        Else
            MsgBox("Por Favor verifique que el usuario y la clave posean solo caracteres Alfanumericos", vbInformation, "Información del Sistema")
        End If

    End Sub

    Private Sub Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TxtUsuario.Focus()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtUsuario.Select()
    End Sub

#End Region

End Class
