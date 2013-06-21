Imports System.Data.SqlClient
Public Class frm_meseroHacePedido

    Private Sub frm_meseroHacePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cb_recepcionistas.Visible = False
        lb_recepcionista.Visible = False
        cb_meseros.Visible = False
        lb_mesero.Visible = False

        MConexion.Conectar()
        M_Generico.CargarList(cb_meseros, "Proc_ListarMesero")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarList(cb_recepcionistas, "Proc_ListarRecepcionista")
        MConexion.Desconectar()

        '''''''''''''''''''''''''' eliminar la tupla de cod_mesero, TABLA AUXILIAR DE LA BDS 
        MConexion.Conectar()
        MConexion.EjecutarConsulta("Proc_EliminarCodMesero")
        MConexion.Desconectar()


        'VERIFICAR A QUE USUARIO ENTRA AL SISTEMA PARA BLOQUER LOS LIST BOX MESERO Y RECEPCIONISTA
        Dim Lector As SqlDataReader
        Dim a As Integer

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ObtenerCodGrupo")
        Lector.Read()
        a = Lector(0)
        MConexion.Desconectar()


        If (a = 3) Then
            cb_recepcionistas.Visible = False 'combo box recepcionista invisible
            cb_meseros.Visible = True   ''combo box mesero visible
            lb_mesero.Visible = True    'label mesero visible
            lb_recepcionista.Visible = False    'label recepcionista invisible
            ch_mesero.Visible = False     'chek invisible por que es un mesero
            ch_recepcionista.Visible = False    'chek invisible por que es un mesero
        End If

        If (a = 4) Then
            cb_meseros.Visible = False  'combo box mesero invisible
            cb_recepcionistas.Visible = True  'combo box recepcionista
            lb_recepcionista.Visible = True    'label recepceonista visible
            lb_mesero.Visible = False   'label mesero invisible
            ch_mesero.Visible = False    'chek invisible por que es un recepcionista
            ch_recepcionista.Visible = False    'chek invisible por que es un recepcionista
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As New cls_COD_MESERO

        If (cb_meseros.Visible = True) Then
            If (cb_meseros.Text <> "") Then
                c.COD = CInt(tf_invisible.Text)
                c.NRO = CInt(cb_meseros.Text)
                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()
                Dim a As New frm_pedido
                a.MdiParent = MDForm
                a.Show()
            Else
                MsgBox("SELECIONAR CODIGO DE MESERO")
            End If
        End If

        If (cb_recepcionistas.Visible = True) Then
            If (cb_recepcionistas.Text <> "") Then
                c.COD = CInt(tf_invisible.Text)
                c.NRO = CInt(cb_recepcionistas.Text)
                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()
                Dim a As New frm_pedido
                a.MdiParent = MDForm
                a.Show()
            Else
                MsgBox("SELECIONAR CODIGO DE RECEPCIONISTA")
            End If
        End If
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

    Private Sub ch_mesero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_mesero.CheckedChanged
        If (ch_mesero.Checked = True) Then
            cb_meseros.Visible = True
            lb_mesero.Visible = True
            ch_recepcionista.Checked = False
        End If
        If (ch_mesero.Checked = False) Then
            cb_meseros.Visible = False
            lb_mesero.Visible = False
        End If
    End Sub

    Private Sub ch_recepcionista_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_recepcionista.CheckedChanged
        If (ch_recepcionista.Checked = True) Then
            cb_recepcionistas.Visible = True
            lb_recepcionista.Visible = True
            ch_mesero.Checked = False
        End If
        If (ch_recepcionista.Checked = False) Then
            cb_recepcionistas.Visible = False
            lb_recepcionista.Visible = False
        End If
    End Sub

    Private Sub cb_meseros_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_meseros.SelectedIndexChanged
        Dim lector As SqlDataReader

        MConexion.Conectar()
        lector = MConexion.EjecutarConsulta("Proc_TBuscarMesero '    " + (cb_meseros.Text) + " '")
        lector.Read()
        tf_nombre.Text = lector(0)
        MConexion.Desconectar()
    End Sub

    Private Sub cb_recepcionistas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_recepcionistas.SelectedIndexChanged
        Dim lector As SqlDataReader

        MConexion.Conectar()
        lector = MConexion.EjecutarConsulta("Proc_TBuscarRecepcionista '    " + (cb_recepcionistas.Text) + " '")
        lector.Read()
        tf_nombre.Text = lector(0)
        MConexion.Desconectar()
    End Sub
End Class