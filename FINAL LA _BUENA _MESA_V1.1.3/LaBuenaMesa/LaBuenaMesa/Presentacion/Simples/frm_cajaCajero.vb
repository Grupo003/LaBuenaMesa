Imports System.Data.SqlClient
Public Class frm_cajaCajero
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_cajero.Text <> "") And (tf_caja.Text <> "") And (tf_monto.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal cjr As String, ByVal cj As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCajaCajero " + (cjr) + "," + (cj))
        If (Lector.HasRows() = True) Then
            Lector.Read()
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Sub buscar(ByVal cjr As String, ByVal cj As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCajaCajero " + (cjr) + "," + (cj))
        If (Lector.HasRows() = True) Then
            Lector.Read()
            tf_fecha.Text = Lector(0)
            tf_monto.Text = Lector(1)
        Else
            MsgBox("NO EXISTE LA CAJA-CAJERO")
        End If
        MConexion.Desconectar()
    End Sub
    Public Sub eliminar(ByVal cjr As String, ByVal cj As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_tbl_CAJA_CAJEROELIMINAR " + (cjr) + "," + (cj))
        MConexion.Desconectar()
    End Sub
    Public Sub LimpiarTextList()
        tf_caja.Text = ""
        tf_cajero.Text = ""
        tf_fecha.Text = ""
        tf_monto.Text = ""
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES







    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim p As New cls_CAJA_CAJERO
        If ((tieneDatos() = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_cajero.Text) = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe((tf_cajero.Text), (tf_caja.Text)) = False) Then
                p.CAJERO_ID = CInt(tf_cajero.Text)
                p.CAJA_ID = CInt(tf_caja.Text)
                p.FECHA = Date.Parse(tf_fecha.Text)
                p.MONTO = CDbl(tf_monto.Text)

                MConexion.Conectar()
                p.Guardar()
                MConexion.Desconectar()
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL CAJA-CAJERO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CAJA, CAJERO Y MONTO DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        If ((tf_cajero.Text <> "") And (tf_caja.Text <> "")) Then
            If (EsNumero(tf_caja.Text) And EsNumero(tf_cajero.Text)) Then
                buscar(CInt(tf_cajero.Text), CInt(tf_caja.Text))
            Else
                MsgBox("INGRESE ID DE CAJA, CAJERO DE TIPO NUMERICO")
            End If
        Else
            MsgBox("INGRESE ID DE CAJA, CAJERO A BUSCAR")
        End If
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_cajero.Text) = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe((tf_cajero.Text), (tf_caja.Text)) = True) Then
                Dim p As New cls_CAJA_CAJERO

                p.CAJERO_ID = CInt(tf_cajero.Text)
                p.CAJA_ID = CInt(tf_caja.Text)
                p.FECHA = tf_fecha.Text
                p.MONTO = tf_monto.Text

                MConexion.Conectar()
                p.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL CAJA-CAJERO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CAJA, CAJERO Y MONTO DE TIPO NUMERICO")
        End If

    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_cajero.Text) = True) And (EsNumero(tf_monto.Text) = True)) Then
            If (existe((tf_cajero.Text), (tf_caja.Text)) = True) Then
                eliminar(tf_cajero.Text, tf_caja.Text)
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL CAJA-CAJERO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CAJA, CAJERO Y MONTO DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarCajaCajero", "tbl_CAJA_CAJERO")
        MConexion.Desconectar()
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub frm_cajaCajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_caja, "Proc_ListarCaja")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_cajero, "Proc_ListarCajero")
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

    Private Sub tf_caja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_caja.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCaja '    " + (tf_caja.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_monto.Text = Lector(1)
        Else
            MsgBox("::::::::NO EXISTE EL MONTO:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextList()
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

    Private Sub tf_cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_cajero.SelectedIndexChanged
        Dim Lector As SqlDataReader

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_TBuscarCajero '    " + (tf_cajero.Text) + " '")
        Lector.Read()

        tf_nombre.Text = Lector(0)

        MConexion.Desconectar()
    End Sub
End Class