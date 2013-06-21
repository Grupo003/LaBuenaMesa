Imports System.Data.SqlClient

Public Class frm_registroPersona

    Private Sub bt_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cliente.Click
        Dim c As New frm_Cliente
        c.MdiParent = MDForm
        c.Show()
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mesero.Click
        Dim m As New frm_mesero
        m.MdiParent = MDForm
        m.Show()
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cajero.Click
        Dim c As New frm_cajero
        c.MdiParent = MDForm
        c.Show()
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_administrador.Click
        Dim a As New frm_administrador
        a.MdiParent = MDForm
        a.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_grupos.Click
        Dim t As New frm_grupo
        t.MdiParent = MDForm
        t.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub frm_registroPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BLOQUE LOS BOTONES DE SOLO ACCESO A ADMINISTRADOR 
        Dim Lector As SqlDataReader
        Dim a As Integer

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ObtenerCodGrupo")
        Lector.Read()
        a = Lector(0)
        MConexion.Desconectar()
        If (a >= 2) Then
            bt_mesero.Enabled = False
            bt_cajero.Enabled = False
            bt_administrador.Enabled = False
            bt_recepcionista.Enabled = False
            bt_motista.Enabled = False
            bt_grupos.Enabled = False
        End If
    End Sub

    Private Sub bt_recepcionista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_recepcionista.Click
        Dim c As New frm_recepcionista
        c.MdiParent = MDForm
        c.Show()
    End Sub

    Private Sub bt_motista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_motista.Click
        Dim c As New frm_motista
        c.MdiParent = MDForm
        c.Show()
    End Sub
End Class