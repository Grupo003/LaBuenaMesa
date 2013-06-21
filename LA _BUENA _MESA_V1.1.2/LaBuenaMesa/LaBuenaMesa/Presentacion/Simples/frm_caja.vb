Imports System.Data.SqlClient
Public Class frm_caja
    ''::::::::::::::::::METODOS Y FUNCIONES

    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_caja.Text <> "") And (tf_monto.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCaja '    " + (Cad) + " '")
        'Lector = MConexion.EjecutarConsulta("Proc_BuscarCaja'" + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES





    Private Sub bt_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim c As New cls_CAJA
        If ((tieneDatos() = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_efectivo.Text) = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe(tf_caja.Text) = False) Then
                c.CAJA_ID = CInt(tf_caja.Text)
                c.MONTO_ID = CInt(tf_monto.Text)
                c.MONTO = CInt(tf_efectivo.Text)
                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()
                MsgBox("ok")
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE LA CAJA")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CAJA,MONTO Y EFECTIVO DE TIPO NUMERICO")
        End If

    End Sub
    Private Sub bt_buscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCaja '    " + (tf_caja.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_monto.Text = Lector(0)
            tf_efectivo.Text = Lector(1)
        Else
            MsgBox("::::::::NO EXISTE LA CAJA:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub
    Private Sub bt_modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        Dim c As New cls_CAJA
        If ((tieneDatos() = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_efectivo.Text) = True) And (EsNumero(tf_monto.Text) = True)) Then
            If ((existe(tf_caja.Text) = True) And (tieneDatos() = True)) Then
                c.CAJA_ID = CInt(tf_caja.Text)
                c.MONTO_ID = CInt(tf_monto.Text)
                c.MONTO = CInt(tf_efectivo.Text)
                MConexion.Conectar()
                c.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE LA CAJA")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CAJA,MONTO Y EFECTIVO DE TIPO NUMERICO")
        End If
    End Sub
    Private Sub bt_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        Dim c As New cls_CAJA
        If ((tieneDatos() = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_efectivo.Text) = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe(tf_caja.Text) = True) Then
                c.CAJA_ID = CInt(tf_caja.Text)
                MConexion.Conectar()
                c.Eliminar()
                MConexion.Conectar()
                MsgBox("CAJA ELIMINADO")
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE LA CAJA")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CAJA,MONTO Y EFECTIVO DE TIPO NUMERICO")
        End If
    End Sub
    Private Sub bt_mostrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarCaja", "tbl_CAJA")
        MConexion.Desconectar()
    End Sub
    Private Sub frm_caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (existe(1) = True) Then
            MConexion.Conectar()
            M_Generico.CargarText((tf_efectivo), "Proc_SiguienteCaja")
            MConexion.Desconectar()
            tf_caja.Text = (CInt(tf_efectivo.Text))
            tf_efectivo.Text = ""
        Else
            tf_caja.Text = "1"
        End If


        MConexion.Conectar()
        M_Generico.CargarCombo(tf_caja, "Proc_ListarCaja")
        MConexion.Desconectar()

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

    Private Sub tf_caja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_caja.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCaja '    " + (tf_caja.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_monto.Text = Lector(0)
            tf_efectivo.Text = Lector(1)
        Else
            MsgBox("::::::::NO EXISTE LA CAJA:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextList()
    End Sub

    Public Sub LimpiarTextList()
        tf_caja.Text() = ""
        tf_monto.Text() = ""
        tf_efectivo.Text() = ""
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
End Class