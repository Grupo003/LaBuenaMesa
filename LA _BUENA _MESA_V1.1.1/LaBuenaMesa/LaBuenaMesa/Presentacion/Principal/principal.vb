Imports System.Data.SqlClient
Public Class frm_Principal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'VERIFICA SI ES CAJERO, MESERO = RECEPCIONISTA PARA ENTRAR A LOS PAQUETES, PARA BLOQUEARLOS
        Dim Lector As SqlDataReader
        Dim a As Integer

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ObtenerCodGrupo")
        Lector.Read()
        a = Lector(0)
        MConexion.Desconectar()

        ''NOTA.- NO PREGUNTA SE ES SE GRUPO = 1 POR QUE ADMINISTRADOR ENTRA A TODOS LADOS
        ''       LUEGO LOS PRIVILEGIOS GUARDAR, MODIFICAR, ETC SE EJECUTAN EN CADA FORMULARIO QUE SE ABRE

        If (a = 2) Then  'PREGUNA SI ES CAJERO ENTONCES BLOQUEA BITACORA, REPORTES
            bt_gestionarBitacora.Enabled = False
            bt_gestionarReportes.Enabled = False
        End If

        If (a = 3) Then  'PREGUNA SI ES MESERO ENTONCES BLOQUEA VENTAS, BITACORA, REPORTES
            bt_gestionarVenta.Enabled = False
            bt_gestionarBitacora.Enabled = False
            bt_gestionarReportes.Enabled = False
        End If

        If (a = 4) Then  'PREGUNA SI ES MESERO ENTONCES BLOQUEA VENTAS, BITACORA, REPORTES
            bt_gestionarVenta.Enabled = False
            bt_gestionarBitacora.Enabled = False
            bt_gestionarReportes.Enabled = False
        End If

    End Sub
    Private Sub GestionarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarClienteToolStripMenuItem.Click
        Dim f As New frm_Cliente
        f.MdiParent = MDForm
        f.Show()
    End Sub

    Private Sub GestionarMeseroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarMeseroToolStripMenuItem.Click
        Dim m As New frm_mesero
        m.MdiParent = MDForm
        m.Show()
    End Sub

    Private Sub GestionarAdministradorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarAdministradorToolStripMenuItem.Click
        Dim p As New frm_administrador
        p.MdiParent = MDForm
        p.Show()
    End Sub

    Private Sub GestionarCajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarCajeroToolStripMenuItem.Click
        Dim c As New frm_cajero
        c.MdiParent = MDForm
        c.Show()
    End Sub
    Private Sub GestionarTipoAdmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarTipoAdmToolStripMenuItem.Click
        Dim a As New frm_grupo
        a.MdiParent = MDForm
        a.Show()
    End Sub
    Private Sub GestionarProductoSiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarProductoSiToolStripMenuItem.Click
        Dim p As New frm_producto
        p.MdiParent = MDForm
        p.Show()
    End Sub

    Private Sub GestionarCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionarCajaToolStripMenuItem.Click
        Dim c As New frm_caja
        c.MdiParent = MDForm
        c.Show()
    End Sub

    Private Sub MontoSiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MontoSiToolStripMenuItem.Click
        Dim m As New frm_monto
        m.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem1.Click
        Dim c As New frm_Almacen
        c.ShowDialog()
    End Sub

    Private Sub DetallePedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetallePedidoToolStripMenuItem.Click
        Dim d As New frm_detallePedido
        d.ShowDialog()
    End Sub

    Private Sub ProductoCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoCompraToolStripMenuItem.Click
        Dim p As New frm_productoAlmacen
        p.ShowDialog()
    End Sub


    Private Sub CajaCajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaCajeroToolStripMenuItem.Click
        Dim c As New frm_cajaCajero
        c.MdiParent = MDForm
        c.Show()
    End Sub
    Private Sub PagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagoToolStripMenuItem.Click
        Dim p As New frm_pago
        p.MdiParent = MDForm
        p.Show()
    End Sub



    Private Sub RealizarPedidoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealizarPedidoToolStripMenuItem1.Click
        Dim p As New frm_pedido
        p.MdiParent = MDForm
        p.Show()
    End Sub




    '' MENÚ PRINCIPAL DE LOS BOTONES CON PAQUETES



    Private Sub bt_gestionarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_gestionarPedido.Click
     
    End Sub
    Private Sub bt_gestionarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_gestionarRegistro.Click
 
    End Sub

    Private Sub bt_gestionarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_gestionarVenta.Click
     
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_gestionarReportes.Click
     
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim r As New frm_caja
        r.MdiParent = MDForm
        r.Show()
    End Sub

    Private Sub bt_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_salir.Click
        Dim diag As DialogResult
        diag = MsgBox("¿SEGURO DESEA SALIR DEL SISTEMA?", MsgBoxStyle.OkCancel)
        If (diag = Windows.Forms.DialogResult.OK) Then
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

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub bt_gestionarBitacora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_gestionarBitacora.Click
        Dim r As New frm_bitacora
        r.MdiParent = MDForm
        r.Show()
    End Sub

End Class
