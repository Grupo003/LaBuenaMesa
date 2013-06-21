Imports System.Data.SqlClient

Public Class frm_asignar_pedidoMotista
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_pedido.Text <> "") And (tf_motista.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existeDetalleDomicilio(ByVal pe As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarDetalleDomicilio '    " + (pe) + " '")
        If (Lector.HasRows() = True) Then
            Lector.Read()
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Function existePedidoDomicilio(ByVal pe As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarPedidoDomicilio '    " + (pe) + " '")
        If (Lector.HasRows() = True) Then
            Lector.Read()
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Function esPedidoPagado(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarPedidoPagados'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existeMotista(ByVal m As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMotista '    " + (m) + " '")
        If (Lector.HasRows() = True) Then
            Lector.Read()
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Sub generarPedido(ByVal p As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarDetallePedido '" + (p) + " '")
        tf_producto2.Items.Clear()
        If (Lector.HasRows()) Then
            While Lector.Read()
                For i As Integer = 0 To tf_producto.Items.Count - 1
                    If tf_producto.Items(i) = Lector(0) Then
                        tf_producto2.Items.Add(Lector(0) & " - " & Lector(2) & " - " & tf_nombre.Items(i) & " - " & Lector(1) & " = " & (CDbl(Lector(1)) * CDbl((Lector(2)))))
                    End If
                Next
            End While
        End If
        MConexion.Desconectar()
    End Sub

    Public Sub buscar(ByVal b As String)
        Dim Lector As SqlDataReader

        If ((EsNumero(tf_pedido.Text)) And (tf_pedido.Text <> "")) Then
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_BuscarPedido '    " + (b) + " '")

            If (Lector.HasRows()) Then
                Lector.Read()
                If (Lector(4) = "DOMICILIO") Then
                    tf_clienteP.Text = Lector(0)
                    tf_motista.Text = Lector(3)
                    tf_montoTotal.Text = Lector(6)
                    If (Lector(7) = "PENDIENTE") Then
                        ch_pendiente.Checked = True
                    End If
                    If (Lector(7) = "PAGADO") Then
                        ch_pagado.Checked = True
                    End If
                    If (Lector(7) = "ENCURSO") Then
                        ch_encurso.Checked = True
                    End If
                    generarPedido(tf_pedido.Text)
                Else
                    MsgBox("EXISTE EL PEDIDO, PERO NO ES A DOMICILIO")
                End If
            Else
                MsgBox("NO EXISTE EL PEDIDO A DOMICILIO")
            End If
        Else
            MsgBox(" RELLENAR PEDIDO DE TIPO NUMERICO")
        End If
    End Sub

    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES










    Private Sub bt_asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_asignar.Click
        Dim dm As New cls_DETALLE_DOMICILIO
        ''GUARDAR ASIGNACION DE PEDIDO a DOMICILIO 

        If ((tieneDatos() = True) And (EsNumero(tf_pedido.Text) = True) And (EsNumero(tf_motista.Text))) Then
            If ((existeDetalleDomicilio(tf_pedido.Text) = False) And (existeMotista(tf_motista.Text) = True) And (existePedidoDomicilio(tf_pedido.Text) = True)) Then
                dm.PEDIDO_DOMICILIO_ID = CInt(tf_pedido.Text)
                dm.MOTISTA_ID = CInt(tf_motista.Text)
                dm.ESTADO = "ENCURSO"

                MConexion.Conectar()
                dm.Guardar()
                MConexion.Desconectar()
                MsgBox("SE ASIGNO SATIFACTORIAMENTE EL PEDIDO")
            Else
                If (existeMotista(tf_motista.Text) = False) Then
                    MsgBox("NO EXISTE EL MOTISTA")
                End If
                If (existePedidoDomicilio(tf_pedido.Text) = False) Then
                    MsgBox("NO EXISTE EL PEDIDO PARA ASIGANAR")
                End If
                If (existeDetalleDomicilio(tf_pedido.Text) = True) Then
                    MsgBox("NO SE PUEDE ASIGNAR EL PEDIDO AL MOTISTA, YA ESTA ASIGNADO")
                End If
            End If
        Else
            MsgBox("LLENAR DATOS CORRESPONDIENTES, NUMERICOS Y LETRAS")
        End If
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        buscar(tf_pedido.Text)
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_pedido.Text) = True) And (EsNumero(tf_motista.Text) = True)) Then
            If ((existePedidoDomicilio(tf_pedido.Text) = True) And (existeMotista(tf_motista.Text) = True)) Then 'existe pedido estado = domicilio y existe el motista
                Dim pd As New cls_DETALLE_DOMICILIO
                Dim Lector As SqlDataReader

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_BuscarPedido '    " + (tf_pedido.Text) + " '")
                Lector.Read()

                If (Lector(7) = "PENDIENTE") Then   'COMPARO SI EL ESTADO DEL PEDIDO ES = PENDIENTE, => P
                    MsgBox("NO SE PUEDE MODIFICAR MOTISTA, EL PEDIDO ESTA PENDIENTE")
                Else
                    pd.PEDIDO_DOMICILIO_ID = CInt(tf_pedido.Text)
                    pd.MOTISTA_ID = CInt(tf_motista.Text)

                    MConexion.Conectar()
                    pd.Modificar()
                    MConexion.Desconectar()
                    MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
                End If
            Else
                If (existePedidoDomicilio(tf_pedido.Text) = False) Then
                    MsgBox("NO EXISTE EL PEDIDO A DOMICILIO")
                End If
                If (existeMotista(tf_motista.Text) = False) Then
                    MsgBox("NO EXISTE EL MOTISTA")
                End If
            End If
        Else
            MsgBox("RELLENAR CASILLA PEDIDO Y MOTISTA DE TIPO NUMERICOS")
        End If
    End Sub
    Private Sub bt_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If (tf_pedido.Text <> "") And (EsNumero(tf_pedido.Text) = True) Then
            If (existePedidoDomicilio(tf_pedido.Text) = True) Then
                If (esPedidoPagado(tf_pedido.Text) = True) Then
                    MsgBox("NO SE PUEDE ELIMINAR EL PEDIDO, ESTA PAGADO")
                Else
                    Dim Lector As SqlDataReader

                    MConexion.Conectar()
                    Lector = MConexion.EjecutarConsulta("Proc_BuscarPedido '    " + (tf_pedido.Text) + " '")
                    Lector.Read()
                    tf_estado.Text = Lector(7)  ' SACO EL ESTADO DEL PEDIDO

                    If (tf_estado.Text = "PENDIENTE") Then
                        MsgBox("NO SE PUEDE ELIMINAR, NO SE ASIGNO EL PEDIDO-MOTISTA")
                    Else
                        Dim dd As New cls_DETALLE_DOMICILIO

                        dd.PEDIDO_DOMICILIO_ID = CInt(tf_pedido.Text)

                        MConexion.Conectar()
                        dd.Eliminar()
                        MConexion.Desconectar()
                        MsgBox("SE DESASIGNO EL MOTISTA DEL PEDIDO")
                    End If
                End If
            Else
                MsgBox("NO EXISTE EL PEDIDO A DOMICILIO")
            End If
        Else
            MsgBox("RELLENAR CASILLA PEDIDO DE TIPO NUMERICOS")
        End If
    End Sub
    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click

        If (ch_pendiente.Checked = False And ch_pagado.Checked = False And ch_encurso.Checked = False) Then   'si no esta tiqueado ningun checkbox
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarDetalleDomicilio", "tbl_DETALLE_DOMICILIO")
            MConexion.Desconectar()
        End If

        If (ch_pendiente.Checked = True) Then  'si esta tiqueado en checkbox muestra los pedido a domicilio pendiente
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarDetalleDomicilioPendiente", "tbl_PEDIDO")
            MConexion.Desconectar()
        End If

        If (ch_encurso.Checked = True) Then    'si esta tiqueado en checkbox muestra los pedido a domicilio encurso
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarDetalleDomicilioEncurso", "tbl_PEDIDO")
            MConexion.Desconectar()
        End If

        If (ch_pagado.Checked = True) Then    'si esta tiqueado en checkbox muestra los pedido a domicilio pagados
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarDetalleDomicilioPagado", "tbl_PEDIDO")
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub tf_pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pedido.SelectedIndexChanged
        buscar(tf_pedido.Text)
    End Sub

    Private Sub frm_asignar_pedidoMotista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_motista, "Proc_ListarMotista")
        MConexion.Desconectar()

        ''DESDE AQUI CARGA LOS LISTBOX PARA EL LIST PRODUCTO CONTROL
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_nombre, "Proc_ListarProductoPorNombre")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_ProdStock, "Proc_ListarProductoStock")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_prodTipo, "Proc_ListarProductoPorTipo")
        MConexion.Desconectar()

    End Sub

    Private Sub tf_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCliente'    " + (tf_clienteP.Text) + " '")

        Lector.Read()
        tf_nombreC.Text = Lector(1)
        tf_apell_p.Text = Lector(2)
        tf_direccion.Text = Lector(4)
        tf_telf.Text = Lector(6)
        MConexion.Desconectar()
    End Sub

    Private Sub tf_clienteP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_clienteP.TextChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCliente'    " + (tf_clienteP.Text) + " '")

        Lector.Read()
        tf_nombreC.Text = Lector(1)
        tf_apell_p.Text = Lector(2)
        tf_direccion.Text = Lector(4)
        tf_telf.Text = Lector(6)
        MConexion.Desconectar()
    End Sub

    Private Sub tf_motista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_motista.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMotista '    " + (tf_motista.Text) + " '")
        Lector.Read()

        tf_nombreM.Text = Lector(0)
        Lector.Close()
        MConexion.Desconectar()
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click

    End Sub

    '' CHECKBOX EVENTOS DE CLIK EN LOS CHECKBOX
    Private Sub ch_pendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pendiente.CheckedChanged
        If (ch_pendiente.Checked = True) Then
            ch_encurso.Checked = False
            ch_pagado.Checked = False


            'LIMPIA EL EDIT CI (refresh)
            tf_pedido.Items.Clear()

            MConexion.Conectar()
            M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoDomicilioPendiente")
            MConexion.Desconectar()
        End If
    End Sub
    Private Sub ch_pagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pagado.CheckedChanged
        If (ch_pagado.Checked = True) Then
            ch_encurso.Checked = False
            ch_pendiente.Checked = False

            'LIMPIA EL EDIT CI (refresh)
            tf_pedido.Items.Clear()

            MConexion.Conectar()
            M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoDomicilioPagado")
            MConexion.Desconectar()
        End If
    End Sub
    Private Sub ch_encurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_encurso.CheckedChanged
        If (ch_encurso.Checked = True) Then
            ch_pagado.Checked = False
            ch_pendiente.Checked = False

            'LIMPIA EL EDIT CI (refresh)
            tf_pedido.Items.Clear()

            MConexion.Conectar()
            M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoDomicilioEncurso")
            MConexion.Desconectar()
        End If
    End Sub




End Class