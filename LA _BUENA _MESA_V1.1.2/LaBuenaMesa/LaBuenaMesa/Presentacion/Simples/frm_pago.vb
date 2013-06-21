Imports System.Data.SqlClient
Public Class frm_pago
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_pago.Text <> "") And (tf_caja.Text <> "") And (tf_cajero.Text <> "") And (tf_pedido.Text <> "") And (tf_montoTotal.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existePago(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarPago'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existePedidoPagado(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarPedidoPagado'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function






    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click

        ' guardar los datos de pago
        If ((tieneDatos() = True) And (EsNumero(tf_pago.Text) = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_pedido.Text) = True)) Then
            If (existePago(tf_pago.Text) = False) Then
                If (tf_efectivo.Text <> "") Then
                    If (existePedidoPagado(tf_pedido.Text) = True) Then
                        MsgBox("NO SE PUEDE PAGAR DOS VECES UN MISMO PEDIDO")
                    Else
                        Dim p As New cls_PAGO
                        p.PAGO_ID = CInt(tf_pago.Text)
                        p.CAJERO_ID = CInt(tf_cajero.Text)
                        p.CAJA_ID = CInt(tf_caja.Text)
                        p.PEDIDO_ID = CInt(tf_pedido.Text)
                        p.MONTO_TOTAL = CDbl(tf_montoTotal.Text)
                        p.FECHA_HORA = tf_fechaHora.Text

                        'cambio a devolver 
                        tf_cambio.Text = (CDbl(tf_efectivo.Text)) - (CDbl(tf_montoTotal.Text))

                        MConexion.Conectar()
                        p.Guardar()
                        MConexion.Desconectar()

                        'LIMPIA EL EDIT CI (refresh)
                        tf_pedido.Items.Clear()

                        MConexion.Conectar()
                        M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoPendiente")
                        MConexion.Desconectar()

                        MConexion.Conectar()
                        M_Generico.CargarCombo(tf_pago, "Proc_SiguientePago")
                        MConexion.Desconectar()
                    End If
                Else
                    MsgBox("RELLENAR CASILLA EFECTIVO")
                End If
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL PAGO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, PEDIDO, PAGO, CAJA DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        If ((tf_pedido.Text <> "") And (EsNumero(tf_pago.Text) = True)) Then
            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_BuscarPago '    " + (tf_pago.Text) + " '")

            If (Lector.HasRows()) Then
                Lector.Read()
                tf_cajero.Text = Lector(0)
                tf_caja.Text = Lector(1)
                tf_pedido.Text = Lector(2)
                tf_montoTotal.Text = Lector(3)
                tf_fechaHora.Text = Lector(4)
                MConexion.Desconectar()
            Else
                MsgBox("NO EXISTE EL PAGO")
            End If
        Else
            MsgBox("RELLENAR PEDIDO DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_pago.Text) = True) And (EsNumero(tf_caja.Text) = True) And (EsNumero(tf_pedido.Text) = True)) Then
            If (existePago(tf_pago.Text) = True) Then
                If (tf_efectivo.Text <> "") Then
                    Dim p As New cls_PAGO

                    p.PAGO_ID = CInt(tf_pago.Text)
                    p.CAJERO_ID = tf_cajero.Text
                    p.CAJA_ID = tf_caja.Text
                    p.PEDIDO_ID = tf_pedido.Text
                    p.MONTO_TOTAL = tf_montoTotal.Text
                    p.FECHA_HORA = tf_fechaHora.Text

                    MConexion.Conectar()
                    p.Modificar()
                    MConexion.Desconectar()
                    MsgBox("DATOS MODIFICADOS SATIFACTORIAMENTE")
                Else
                    MsgBox("RELLENAR CASILLA EFECTIVO")
                End If
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL PAGO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, PEDIDO, PAGO, CAJA DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tf_pago.Text <> "") And (EsNumero(tf_pago.Text) = True)) Then
            If ((existePago(tf_pago.Text) = True)) Then
                Dim p As New cls_PAGO

                p.PAGO_ID = CInt(tf_pago.Text)

                MConexion.Conectar()
                p.Eliminar()
                MConexion.Conectar()
                MsgBox("PAGO ELIMINADO DE LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL PAGO")
            End If
        Else
            MsgBox("RELLENAR PAGO DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPago", "tbl_PRODUCTO")
        MConexion.Desconectar()
    End Sub

    Private Sub frm_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'METODO PARA ACTUALIZAR EL ESTADO DE LA MESA CUANDO CUMPLA EL TIEMPO DE LA RESERVA
        actualizarEstadoMesa()

        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCodCajeroCajaPago")
        Lector.Read()
        tf_cajero.Text = Lector(0)
        tf_caja.Text = Lector(1)
        Lector.Close()
        MConexion.Desconectar()

        If (existePago(1)) Then
            MConexion.Conectar()
            M_Generico.CargarText((tf_montoTotal), "Proc_SiguientePago")
            MConexion.Desconectar()
            tf_pago.Text = (CInt(tf_montoTotal.Text))
            tf_montoTotal.Text = ""
        Else
            tf_pago.Text = 1
        End If

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_nombre, "Proc_ListarProductoPorNombre")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_pago, "Proc_ListarPago")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_cajero, "Proc_ListarCajero")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_caja, "Proc_ListarCaja")
        MConexion.Desconectar()
    End Sub

    Private Sub tf_pago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pago.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarPago '    " + (tf_pago.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_cajero.Text = Lector(0)
            tf_caja.Text = Lector(1)
            tf_pedido.Text = Lector(2)
            tf_montoTotal.Text = Lector(3)
            tf_fechaHora.Text = Lector(4)
        Else
            MsgBox(":::::::: NO EXISTE EL PAGO :::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub tf_pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pedido.SelectedIndexChanged
        ''BUSCA EL MONTO DEL PEDIDO SELECCIONADO
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarPedido '    " + (tf_pedido.Text) + " '")
        If (Lector.HasRows()) Then
            Lector.Read()
            tf_montoTotal.Text = Lector(6)
        Else
            MsgBox(":::::::: NO EXISTE EL PEDIDO :::::::::::")
        End If
        MConexion.Desconectar()


        'BUSCA DETALLE DEL PEDIDO SELECCIONADO Y CARGA EL NOMBRE DE LO PRODUCTOS
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarDetallePedido '" + (tf_pedido.Text) + " '")
        tf_producto2.Items.Clear()
        If (Lector.HasRows()) Then
            While Lector.Read()
                For i As Integer = 0 To tf_producto.Items.Count - 1
                    If tf_producto.Items(i) = Lector(0) Then
                        tf_producto2.Items.Add(Lector(0) & " - " & Lector(2) & " - " & tf_nombre.Items(i) & " - " & Lector(1) & " = " & (CDbl(Lector(1)) * CDbl((Lector(2)))))
                    End If
                Next
            End While
        Else
            MsgBox("::::::::NO EXISTE EL PEDIDO:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub bt_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cliente.Click
        Dim c As New frm_Cliente
        c.MdiParent = MDForm
        c.Show()
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

    Private Sub ch_pendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pendiente.CheckedChanged
        If (ch_pendiente.Checked = True) Then
            ch_encurso.Checked = False
            ch_pagado.Checked = False
        End If
        'LIMPIA EL EDIT CI (refresh)
        tf_pedido.Items.Clear()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoPendiente")
        MConexion.Desconectar()
    End Sub
    Private Sub ch_pagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pagado.CheckedChanged
        If (ch_pagado.Checked = True) Then
            ch_encurso.Checked = False
            ch_pendiente.Checked = False
        End If
        'LIMPIA EL EDIT CI (refresh)
        tf_pedido.Items.Clear()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoPagado")
        MConexion.Desconectar()
    End Sub
    Private Sub ch_encurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_encurso.CheckedChanged
        If (ch_encurso.Checked = True) Then
            ch_pagado.Checked = False
            ch_pendiente.Checked = False
        End If
        'LIMPIA EL EDIT CI (refresh)
        tf_pedido.Items.Clear()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoEncurso")
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

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        tf_pago.Text = ""
        tf_caja.Text = ""
        tf_cajero.Text = ""
        tf_nombre.Text = ""
        tf_nombreCajero.Text = ""
        tf_efectivo.Text = ""
        tf_cambio.Text = ""
        tf_montoTotal.Text = ""
        tf_pedido.Text = ""
    End Sub
End Class