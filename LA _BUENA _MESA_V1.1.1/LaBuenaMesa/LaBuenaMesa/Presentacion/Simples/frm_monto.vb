Imports System.Data.SqlClient
Public Class frm_monto
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_monto.Text <> "") And (tf_efectivo.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMonto'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub LimpiarTextList()
        tf_monto.Text() = ""
        tf_efectivo.Text() = ""
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES







    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe(tf_monto.Text) = False) Then
                Dim c As New cls_MONTO
                c.MONTO_ID = CInt(tf_monto.Text)
                c.MONTO = tf_efectivo.Text
                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL MONTO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMonto '    " + (tf_monto.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_efectivo.Text = Lector(0)
        Else
            MsgBox("::::::::NO EXISTE EL MONTO:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe(tf_monto.Text) = True) Then
                Dim c As New cls_MONTO
                c.MONTO_ID = CInt(tf_monto.Text)
                c.MONTO = tf_monto.Text
                MConexion.Conectar()
                c.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL MONTO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe(tf_monto.Text) = True) Then
                Dim c As New cls_MONTO
                c.MONTO_ID = CInt(tf_monto.Text)
                MConexion.Conectar()
                c.Eliminar()
                MConexion.Desconectar()
                MsgBox("MONTO ELIMINADO")
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL MONTO")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarMonto", "tbl_MONTO")
        MConexion.Desconectar()
    End Sub

    Private Sub tf_monto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_monto.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMonto '    " + (tf_monto.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_efectivo.Text = Lector(0)
        Else
            MsgBox("::::::::NO EXISTE EL MONTO:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub frm_monto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (existe(1)) Then
            MConexion.Conectar()
            M_Generico.CargarText((tf_efectivo), "Proc_SiguienteMonto")
            MConexion.Desconectar()
            tf_monto.Text = (CInt(tf_efectivo.Text))
            tf_efectivo.Text = ""
        Else
            tf_monto.Text = 1
        End If

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_monto, "Proc_ListarMonto")
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

    Private Sub tf_caja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMonto '    " + (tf_monto.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_efectivo.Text = Lector(0)
        Else
            MsgBox("::::::::NO EXISTE EL MONTO:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextList()
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
End Class