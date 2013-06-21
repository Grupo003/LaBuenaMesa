Imports System.Data.SqlClient

Public Class frm_registrosPrincipal

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub bt_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cliente.Click
        Dim f As New frm_registroPersona
        f.MdiParent = MDForm
        f.Show()
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_producto.Click
        Dim p As New frm_registroProductos
        p.MdiParent = MDForm
        p.Show()
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_caja.Click
        Dim j As New frm_registroCaja
        j.MdiParent = MDForm
        j.Show()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
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

    Private Sub frm_registrosPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BLOQUE LOS BOTONES DE SOLO ACCESO A ADMINISTRADOR
        Dim Lector As SqlDataReader
        Dim a As Integer

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ObtenerCodGrupo")
        Lector.Read()
        a = Lector(0)
        MConexion.Desconectar()
        If (a >= 2) Then
            bt_producto.Enabled = False
            bt_caja.Enabled = False
            bt_privilegio.Enabled = False
        End If

    End Sub

    Private Sub bt_privilegio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_privilegio.Click
        Dim p As New frm_privilegio
        p.MdiParent = MDForm
        p.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim p As New frm_mesa
        p.MdiParent = MDForm
        p.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim p As New frm_reserva
        p.MdiParent = MDForm
        p.Show()
    End Sub
End Class