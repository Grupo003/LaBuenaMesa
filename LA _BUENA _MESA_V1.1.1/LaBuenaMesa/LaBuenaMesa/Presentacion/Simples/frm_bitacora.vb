Imports System.Data.SqlClient
Public Class frm_bitacora


    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ch_bitacora.Checked = True Or ch_acciones_usuario.Checked = True) Then
            If (ch_bitacora.Checked = True) Then
                MConexion.Conectar()
                M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarBitacora", "tbl_BITACORA")
                MConexion.Desconectar()
            Else
                MConexion.Conectar()
                M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarAccionesUsuario", "tbl_BITACORA")
                MConexion.Desconectar()
            End If
        Else
            MsgBox("SELECCIONAR QUE DESEA MOSTRAR BITACORA O ACCIONES DE TODOD LOS USUARIOS")
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

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub



    Private Sub ch_bitacora_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_bitacora.CheckedChanged
        If (ch_bitacora.Checked = True) Then
            ch_acciones_usuario.Checked = False
        End If
    End Sub

    Private Sub ch_acciones_usuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_acciones_usuario.CheckedChanged
        If (ch_acciones_usuario.Checked = True) Then
            ch_bitacora.Checked = False
        End If
    End Sub


    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click

    End Sub

    Private Sub frm_bitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class