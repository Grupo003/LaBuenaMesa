
Imports System.Data.SqlClient         'PARA QUE FUNCIONES EL METODO BUSCAR

Public Class frm_login


    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Public Function tieneDatosLogin() As Boolean
        If ((tf_usuario.Text <> "") Or (tf_login.Text <> "") Or (tf_contraseña.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim d As DialogResult
        d = MsgBox("¿SEGURO DESEA SALIR DEL SISTEMA?", MsgBoxStyle.YesNo)
        If (d = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Lector As SqlDataReader

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_EliminarCodUsuarioGrupo")
        Lector.Read()
        MConexion.Desconectar()
        lb_fecha.Text = Date.Parse(tp_calendario.Text)
        tp_calendario.Visible = False

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (tieneDatosLogin() = True) Then
            If ((EsNumero(tf_usuario.Text) = False)) Then
                tf_usuario.Text = ""
                MsgBox("POR FAVOR INSERTE DATOS DE TIPO NUMERICO EN USUARIO")
            Else
                Dim Lector As SqlDataReader
                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteUsuario '    " + (tf_usuario.Text) + "'")

                If (Lector.HasRows()) Then
                    Lector.Read()
                    'SACO LOS DATOS DEL USUARIO INGRESADO (LOGIN, CONTRASEÑA) 
                    tf_l.Text = Lector(0)
                    tf_c.Text = Lector(1)
                    MConexion.Desconectar()
                    'COMPARO LOS DATOS SACADOS DE LA BDs SI SON CORRECPTOS
                    If ((tf_l.Text = tf_login.Text) And (tf_c.Text = tf_contraseña.Text)) Then

                        MConexion.Conectar()
                        Dim cd, g As New Integer
                        Lector = MConexion.EjecutarConsulta("Proc_BuscarGrupoUsuario '    " + (tf_usuario.Text) + "'")
                        Lector.Read()
                        'BUSCO EL GRUPO DE USUARIO AL QUE PERTENECE EL ID INGRESADO
                        g = Lector(0)
                        MConexion.Desconectar()

                        'ASIGNO EL USUARIO INGRESADO A UNA A VARIABLE
                        cd = CInt(tf_usuario.Text)

                        'GUARDO LOS DATOS DE USUARIO_ID Y GRUPO EN TABLA FICTICIA
                        Dim c As New cls_COD_USUARIO_GRUPO
                        c.COD = cd
                        c.NRO = g
                        MConexion.Conectar()
                        c.Guardar()
                        MConexion.Desconectar()

                        'GUARDO EN LA BITACORA USUARIO_ID Y HORA DE INGRESO
                        Dim b As New cls_BITACORA
                        b.USUARIO_ID = c.NRO

                        Dim p As New frm_Principal
                        p.MdiParent = MDForm
                        p.Show()

                    Else
                        MsgBox("::::::::NO EXISTE EL LOGIN O CONTRASEÑA:::::::::::")
                    End If
                Else
                    MsgBox("::::::::NO EXISTE EL USUARIO:::::::::::")
                End If
            End If
        Else
            MsgBox("VEFICAR SI NO EXISTEN CASILLA EN BLANCO")
        End If
    End Sub

End Class
