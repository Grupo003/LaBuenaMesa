Imports System.Data.SqlClient
Public Class frm_registrarCajaCajeroPago

    Public Function existeCajeroCaja(ByVal cjr As String, ByVal cj As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCajaCajero " + (cjr) + "," + (cj))
        If (Lector.HasRows() = True) Then
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES








    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_atras.Click
        MConexion.Conectar()
        MConexion.EjecutarConsulta("Proc_EliminarCodMesero")
        MConexion.Desconectar()

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

            MConexion.Conectar()
            MConexion.EjecutarConsulta("Proc_EliminarCodMesero")
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
        Dim diag As DialogResult
        diag = MsgBox("¿SEGURO DESEA SALIR DEL SISTEMA?", MsgBoxStyle.OkCancel)
        If (diag = Windows.Forms.DialogResult.OK) Then
            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_ActualizarBitacoraFechaSalida")
            MConexion.Desconectar()
            Application.Exit()
            MConexion.Conectar()
            MConexion.EjecutarConsulta("Proc_EliminarCodMesero")
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub bt_pago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_pago.Click
        Dim c As New cls_COD_MESERO

        If ((tf_cajero.Text <> "") And (tf_caja.Text <> "")) Then
            If (existeCajeroCaja(tf_cajero.Text, tf_caja.Text)) Then
                c.COD = CInt(tf_cajero.Text)
                c.NRO = CInt(tf_caja.Text)
                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()

                Close()

                Dim l As New frm_pago
                l.MdiParent = MDForm
                l.Show()
            Else
                MsgBox("EL CAJERO NO ESTA ASIGANDO A ESTA CAJA")
            End If
        Else
            If (tf_cajero.Text <> "") Then
                MsgBox("SELECCIONE CAJERO")
            Else
                MsgBox("SELECCIONE CAJA")
            End If
        End If
    End Sub

    Private Sub frm_registrarCajaCajeroPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''elimina la unica tupla de cod_mesero (cajero, caja)
        MConexion.Conectar()
        MConexion.EjecutarConsulta("Proc_EliminarCodMesero")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarList(tf_cajero, "Proc_ListarCajero")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarList(tf_caja, "Proc_ListarCaja")
        MConexion.Desconectar()
    End Sub

    Private Sub tf_cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_cajero.SelectedIndexChanged
        Dim Lector As SqlDataReader

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_TBuscarCajero '    " + (tf_cajero.Text) + " '")
        Lector.Read()

        tf_nombreCajero.Text = Lector(0)

        MConexion.Desconectar()
    End Sub
End Class

