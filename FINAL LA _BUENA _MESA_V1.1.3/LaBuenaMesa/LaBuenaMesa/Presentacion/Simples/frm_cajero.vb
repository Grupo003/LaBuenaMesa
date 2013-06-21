Imports System.Data.SqlClient
Public Class frm_cajero
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_ci.Text <> "") And (tf_nombre.Text <> "") And (tf_ap.Text <> "") And (tf_am.Text <> "") And (tf_dir.Text <> "") And (tf_telf.Text <> "") And (tf_cel.Text <> "") And (cb_sexo.Text <> "") And (tf_login.Text <> "") And (tf_contraseña.Text <> "") And (tf_estado.Text <> "") And (tf_grupo.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function tieneDatosCi() As Boolean
        If ((tf_ci.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existeHabilitado(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCajero'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existeDeshabilitado(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCajeroDeshabilitado'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub buscar(ByVal b As String)
        If (ch_deshabilitado.Checked = False) Then
            If ((tieneDatosCi() = True) And (EsNumero(tf_ci.Text) = True)) Then
                If (existeHabilitado(tf_ci.Text) = True) Then
                    Dim Lector As SqlDataReader
                    MConexion.Conectar()
                    Lector = MConexion.EjecutarConsulta("Proc_BuscarCajero '    " + (tf_ci.Text) + " '")

                    Lector.Read()
                    cb_sexo.Text = ""
                    tf_nombre.Text = Lector(0)
                    tf_ap.Text = Lector(1)
                    tf_am.Text = Lector(2)
                    tf_dir.Text = Lector(3)
                    tf_fn.Text = Lector(4)
                    tf_telf.Text = Lector(5)
                    tf_cel.Text = Lector(6)
                    If (Lector(7).ToString = "F") Then
                        cb_sexo.SelectedText = "Femenino"
                    Else
                        cb_sexo.SelectedText = "Masculino"
                    End If
                    tf_login.Text = Lector(8)
                    tf_contraseña.Text = Lector(9)
                    tf_estado.Text = Lector(10)
                    tf_grupo.Text = Lector(11)

                    MConexion.Desconectar()
                Else
                    MsgBox(" NO EXISTE EL CAJERO A BUSCAR")
                End If
            Else
                MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
            End If
        Else
            If ((tieneDatosCi() = True) And (EsNumero(tf_ci.Text) = True)) Then
                If (existeDeshabilitado(tf_ci.Text) = True) Then
                    Dim Lector As SqlDataReader
                    MConexion.Conectar()
                    Lector = MConexion.EjecutarConsulta("Proc_BuscarCajeroDeshabilitado '    " + (tf_ci.Text) + " '")

                    Lector.Read()
                    cb_sexo.Text = ""
                    tf_nombre.Text = Lector(0)
                    tf_ap.Text = Lector(1)
                    tf_am.Text = Lector(2)
                    tf_dir.Text = Lector(3)
                    tf_fn.Text = Lector(4)
                    tf_telf.Text = Lector(5)
                    tf_cel.Text = Lector(6)
                    If (Lector(7).ToString = "F") Then
                        cb_sexo.SelectedText = "Femenino"
                    Else
                        cb_sexo.SelectedText = "Masculino"
                    End If
                    tf_login.Text = Lector(8)
                    tf_contraseña.Text = Lector(9)
                    tf_estado.Text = Lector(10)
                    tf_grupo.Text = Lector(11)

                    MConexion.Desconectar()
                Else
                    MsgBox(" NO EXISTE EL CAJERO DESHABILITADO A BUSCAR")
                End If
            Else
                MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
            End If

        End If
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES







    Private Sub bt_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        If (ch_deshabilitado.Checked = False) Then
            If ((tieneDatos() = True) And (EsNumero(tf_ci.Text) = True)) Then
                If (existeHabilitado(tf_ci.Text) = False And existeDeshabilitado(tf_ci.Text) = False) Then
                    Dim u As New cls_USUARIO
                    Dim c As New cls_CAJERO

                    u.USUARIO_ID = CInt(tf_ci.Text)
                    u.NOMBRE = tf_nombre.Text
                    u.APELL_P = tf_ap.Text
                    u.APELL_M = tf_am.Text
                    u.DIRECCION = tf_dir.Text
                    u.FECHA_NAC = Date.Parse(tf_fn.Text)
                    u.TELEFONO = tf_telf.Text
                    u.CELULAR = tf_cel.Text
                    u.SEXO = cb_sexo.Text
                    u.LOGIN = tf_login.Text
                    u.CONTRASEÑA = tf_contraseña.Text
                    u.ESTADO = tf_estado.Text
                    u.GRUPO_ID = CInt(tf_grupo.Text)

                    c.CAJERO_ID = u.USUARIO_ID

                    MConexion.Conectar()
                    u.Guardar()
                    c.Guardar()
                    MConexion.Desconectar()
                    MsgBox("SE GUARDAR EXITOSAMENTE EL CAJERO")

                    'LIMPIA EL EDIT (refresh)
                    tf_ci.Items.Clear()

                    'LISTA ACTUALIZADA DE CAJEROS HABILITADOS EN EDIT TF_CI
                    MConexion.Conectar()
                    M_Generico.CargarCombo(tf_ci, "Proc_ListarCajero")
                    MConexion.Desconectar()
                Else
                    MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL CAJERO")
                End If
            Else
                MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
            End If
        Else
            If ((tf_ci.Text <> "") And (EsNumero(tf_ci.Text) = True)) Then
                If (existeDeshabilitado(tf_ci.Text) = True) Then
                    MConexion.Conectar()
                    MConexion.EjecutarConsulta("Proc_GuardarCajeroDeshabilitado '    " + (tf_ci.Text) + " '")
                    MConexion.Desconectar()
                    MsgBox("SE HABILITO EXITOSAMENTE EL CAJERO")

                    'LIMPIA EL EDIT (refresh)
                    tf_ci.Items.Clear()

                    'LISTA ACTUALIZADA DE CAJEROS DESHABILITADOS EN EDIT TF_CI
                    MConexion.Conectar()
                    M_Generico.CargarCombo(tf_ci, "Proc_ListarCajeroDeshabilitado")
                    MConexion.Desconectar()
                Else
                    MsgBox("NO SE PUEDE HABILITAR, NO EXISTE EL CAJERO")
                End If
            Else
                MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
            End If
        End If

    End Sub

    Private Sub bt_buscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        buscar(tf_ci.Text)
    End Sub

    Private Sub bt_modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tf_ci.Text <> "") And (EsNumero(tf_ci.Text) = True)) Then
            If ((existeHabilitado(tf_ci.Text) = True) And (tieneDatos() = True)) Then
                If (tieneDatos() = True) Then
                    Dim u As New cls_USUARIO
                    Dim c As New cls_CAJERO
                    u.USUARIO_ID = CInt(tf_ci.Text)
                    u.NOMBRE = tf_nombre.Text
                    u.APELL_P = tf_ap.Text
                    u.APELL_M = tf_am.Text
                    u.DIRECCION = tf_dir.Text
                    u.FECHA_NAC = Date.Parse(tf_fn.Text)
                    u.TELEFONO = tf_telf.Text
                    u.CELULAR = tf_cel.Text
                    u.SEXO = cb_sexo.Text
                    u.LOGIN = tf_login.Text
                    u.ESTADO = tf_estado.Text
                    u.CONTRASEÑA = tf_contraseña.Text
                    u.GRUPO_ID = tf_grupo.Text

                    MConexion.Conectar()
                    u.Modificar()
                    c.Modificar()
                    MConexion.Desconectar()
                    MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
                Else
                    MsgBox("RELLENAR DATOS, NO DEBE EXISTIR DATOS VACIOS")
                End If
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL CAJERO")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")

        End If
    End Sub

    Private Sub bt_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tf_ci.Text <> "") And (EsNumero(tf_ci.Text) = True)) Then
            If (existeHabilitado(tf_ci.Text) = True) Then
                Dim Lector As SqlDataReader
                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_EliminarCajero'    " + (tf_ci.Text) + " '")
                MConexion.Desconectar()
                MsgBox("CAJERO ELIMINADO EXITOSAMENTE")

                'LIMPIA EL EDIT (refresh)
                tf_ci.Items.Clear()

                'LISTA ACTUALIZADA DE CAJEROS HABILITADOS EN EDIT TF_CI
                MConexion.Conectar()
                M_Generico.CargarCombo(tf_ci, "Proc_ListarCajero")
                MConexion.Desconectar()
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL CAJERO")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        If (ch_deshabilitado.Checked = True) Then
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarCajeroDeshabilitado", "tbl_ADMINISTRADOR")
            MConexion.Desconectar()
        Else
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarCajero", "tbl_CAJERO")
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub frm_cajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_ci, "Proc_ListarCajero")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_grupo, "Proc_ListarGrupo")
        MConexion.Desconectar()

        'CARGA LOS PRIVILEGIOS DE LA BDS
        Dim Lector As SqlDataReader
        Dim a As Integer

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ObtenerCodGrupo")
        Lector.Read()
        a = Lector(0)
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon1 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_guardar.Enabled = True
        Else
            bt_guardar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon2 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_limpiar.Enabled = True
        Else
            bt_limpiar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon3 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_buscar.Enabled = True
        Else
            bt_buscar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon4 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_modificar.Enabled = True
        Else
            bt_modificar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon5 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_eliminar.Enabled = True
        Else
            bt_eliminar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon6 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_mostrar.Enabled = True
        Else
            bt_mostrar.Enabled = False
        End If
        MConexion.Desconectar()
        'ACA TERMINA CARGA LOS PRIVILEGIOS DE LA BDS

    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        limpiarTextBox()
    End Sub

    Public Sub limpiarTextBox()
        tf_ci.Text() = ""
        tf_nombre.Text() = ""
        tf_am.Text() = ""
        tf_ap.Text() = ""
        tf_dir.Text() = ""
        tf_fn.Text() = ""
        tf_telf.Text() = ""
        tf_cel.Text() = ""
        cb_sexo.Text() = ""
        tf_login.Text() = ""
        tf_contraseña.Text() = ""
        tf_estado.Text() = ""
        tf_grupo.Text() = ""
    End Sub

    Private Sub bt_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_salir.Click
        Dim d As DialogResult
        d = MsgBox("¿SEGURO DESEA SALIR DEL SISTEMA?", MsgBoxStyle.YesNo)
        If (d = Windows.Forms.DialogResult.Yes) Then
            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_ActualizarBitacoraFechaSalida")
            MConexion.Desconectar()

            Application.Exit()
        End If
    End Sub

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
        Dim d As DialogResult
        d = MsgBox("¿SEGURO DESEA CAMBIAR DE USUARIO?", MsgBoxStyle.YesNo)
        If (d = Windows.Forms.DialogResult.Yes) Then
            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_ActualizarBitacoraFechaSalida")
            MConexion.Desconectar()

            Dim l As New frm_login
            l.MdiParent = MDForm
            l.Show()
        End If
    End Sub

    Private Sub tf_ci_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_ci.SelectedIndexChanged
        buscar(tf_ci.Text)
    End Sub

    Private Sub ch_deshabilitado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_deshabilitado.CheckedChanged
        If (ch_deshabilitado.Checked = True) Then
            'BLOQUE LOS BOTONES QUE NO SE NECESITAN CUANDO SE CHECKED = TRUE
            bt_modificar.Enabled = False
            bt_eliminar.Enabled = False
            bt_guardar.Text = "HABILITAR"

            'LIMPIA EL EDIT Y PARA LUEGO ACTUALIZARLO
            tf_ci.Items.Clear()

            'LISTA LOS CAJEROS DESHABILITADOS EN EDIT TF_CI
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_ci, "Proc_ListarCajeroDeshabilitado")
            MConexion.Desconectar()
        Else
            'DESBLOQUE LOS BOTONES QUE NO SE NECESITAN CUANDO SE CHECKED = TRUE
            bt_modificar.Enabled = True
            bt_eliminar.Enabled = True
            bt_guardar.Text = "GUARDAR"

            'LIMPIA EL EDIT Y PARA LUEGO ACTUALIZARLO
            tf_ci.Items.Clear()

            'LISTA LOS CAJEROS HABILITADOS EN EDIT TF_CI
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_ci, "Proc_ListarCajero")
            MConexion.Desconectar()
        End If
    End Sub
End Class