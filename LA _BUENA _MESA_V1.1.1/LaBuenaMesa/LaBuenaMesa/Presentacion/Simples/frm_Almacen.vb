Imports System.Data.SqlClient
Public Class frm_Almacen
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_almacen.Text <> "") And (tf_nombre.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarAlmacen '    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES




    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim c As New cls_ALMACEN

        If ((tieneDatos() = True) And (EsNumero(tf_almacen.Text) = True)) Then
            If (existe(tf_almacen.Text) = False) Then
                c.ALMACEN_ID = CInt(tf_almacen.Text)
                c.NOMBRE = tf_nombre.Text

                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()

                'LIMPIA EL EDIT CI (refresh)
                tf_almacen.Items.Clear()

                'LISTA ACTUALIZADA DE PRODUCTOS HABILITADO EN EDIT TF_PRODUCTO
                MConexion.Conectar()
                M_Generico.CargarCombo(tf_almacen, "Proc_ListarAlmacen")
                MConexion.Desconectar()
                MsgBox("SE GUARDO EXITOSAMENTE EL ALMACEN")
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL ALMACEN")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, ALMACEN DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarAlmacen '    " + (tf_almacen.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_nombre.Text = Lector(0)
        Else
            MsgBox(" NO EXISTE EL ALMACEN A BUSCAR")
        End If
        MConexion.Desconectar()

    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        Dim a As New cls_ALMACEN
        If ((tieneDatos() = True) And (EsNumero(tf_almacen.Text) = True)) Then
            If ((existe(tf_almacen.Text) = True) And (tieneDatos() = True)) Then
                a.ALMACEN_ID = CInt(tf_almacen.Text)
                a.NOMBRE = tf_nombre.Text

                MConexion.Conectar()
                a.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL ALMACEN")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If

    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        Dim a As New cls_ALMACEN
        If ((tieneDatos() = True) And (EsNumero(tf_almacen.Text) = True)) Then
            If (existe(tf_almacen.Text) = True) Then
                a.ALMACEN_ID = CInt(tf_almacen.Text)
                MConexion.Conectar()
                a.Eliminar()
                MConexion.Desconectar()
                MsgBox("ALMACEN ELIMINADO")
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL ALMACEN")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarAlmacen", "tbl_ALMACEN")
        MConexion.Desconectar()
    End Sub

    Private Sub frm_Almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (existe(1)) Then
            MConexion.Conectar()
            M_Generico.CargarText((tf_auxiliar), "Proc_SiguienteAlmacen")
            MConexion.Desconectar()
            tf_almacen.Text = (CInt(tf_auxiliar.Text))
            tf_auxiliar.Text = ""
        Else
            tf_almacen.Text = 1
        End If




        MConexion.Conectar()
        M_Generico.CargarCombo(tf_almacen, "Proc_ListarAlmacen")
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

    Public Sub LimpiarTextBox()
        tf_almacen.Text = ""
        tf_nombre.Text = ""
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextBox()
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
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

    Private Sub tf_almacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_almacen.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarAlmacen '    " + (tf_almacen.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_nombre.Text = Lector(0)
        Else
            MsgBox(" NO EXISTE LA ALMACEN A BUSCAR")
        End If
        MConexion.Desconectar()
    End Sub
End Class