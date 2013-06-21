Imports System.Data.SqlClient
Public Class frm_pedido
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If (ch_llevar.Visible = True) Then
            If ((tf_pedido.Text <> "") And (tf_mesa.Text <> "") And (tf_cliente.Text <> "") And (tf_mesero.Text <> "") And ((ch_llevar.Checked = True) Or (ch_mesa.Checked = True)) And (tf_montoTotal.Text <> "")) Then
                Return True
            Else
                Return False
            End If
        Else
            If ((tf_pedido.Text <> "") And (tf_cliente.Text <> "") And (tf_recepcionista.Text <> "") And (tf_motista.Text <> "") And (tf_montoTotal.Text <> "")) Then
                Return True
            Else
                Return False
            End If
        End If

    End Function
    Public Function existe(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarPedido'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
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
    Public Sub eliminarDetallePedido(ByVal pe As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_tbl_DETALLE_PEDIDOELIMINAR " + (pe))
        MConexion.Desconectar()
    End Sub

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
    End Sub

    Public Sub buscar(ByVal p As String)
        If ((EsNumero(p) = True) And p <> "") Then
            Dim Lector As SqlDataReader
            If (ch_llevar.Visible = True) Then 'si checbok llevar esta visiblee es pedido para mesa o llevar
                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_BuscarPedido '    " + (p) + " '")

                If (Lector.HasRows()) Then
                    Lector.Read()
                    If (Lector(4) = "MESA" Or Lector(4) = "LLEVAR") Then
                        tf_cliente.Text = Lector(0)
                        tf_mesero.Text = Lector(1)
                        tf_tipo.Text = Lector(4)
                        If (tf_tipo.Text = "LLEVAR") Then
                            ch_llevar.Checked = True
                        Else
                            ch_mesa.Checked = True
                        End If
                        tf_estado.Text = Lector(7)
                        tf_fecha.Text = Lector(5)
                        tf_montoTotal.Text = Lector(6)
                        tf_mesa.Text = Lector(8)
                        generarPedido(p)
                    Else
                        MsgBox("EXISTE EL PEDIDO, NO ES DE MESA O LLEVAR")
                    End If
                Else
                    MsgBox("NO EXISTE EL PEDIDO MESA-LLEVAR")
                End If
                Lector.Close()
            Else   'caso controrio es para domicilio
                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_BuscarPedido '    " + (p) + " '")

                If (Lector.HasRows()) Then
                    Lector.Read()
                    If (Lector(4) = "DOMICILIO") Then
                        tf_cliente.Text = Lector(0)
                        tf_recepcionista.Text = Lector(2)
                        tf_motista.Text = Lector(3)
                        tf_tipo.Text = Lector(4)
                        tf_estado.Text = Lector(7)
                        tf_fecha.Text = Lector(5)
                        tf_montoTotal.Text = Lector(6)
                        generarPedido(p)
                    Else
                        MsgBox("EXISTE EL PEDIDO, NO ES A DOMICILIO")
                    End If
                Else
                    MsgBox(" NO EXISTE EL PEDIDO A DOMICILIO")
                End If
                Lector.Close()
            End If
        Else
            MsgBox("RELLENAR PEDIDO DE TIPO NUMERICO")
        End If
    End Sub

    Public Sub LimpiarTextBox()
        'si el pedido es para llevar o para mesa
        If (ch_llevar.Visible = True) Then
            tf_pedido.Text = ""
            tf_cliente.Text = ""
            tf_mesero.Text = ""
            tf_nombreCliente.Text = ""
            tf_nombremotista.Text = ""
            tf_nombreMR.Text = ""
            ch_llevar.Checked = False
            ch_mesa.Checked = False
            tf_montoTotal.Text = ""
            tf_mesa.Text = ""
            tf_suma.Text = ""
            tf_producto2.Text = ""
            tf_producto2.Items.Clear()
        Else
            'caso contrario es para domicilio
            tf_pedido.Text = ""
            tf_cliente.Text = ""
            tf_recepcionista.Text = ""
            tf_motista.Text = ""
            tf_montoTotal.Text = ""
            tf_suma.Text = ""
            tf_producto2.Text = ""
            tf_producto2.Items.Clear()
        End If
    End Sub
    Public Sub acomodarId(ByVal c As String)
        If (c.Length = 1) Then
            c = c + "  "
        End If
        If (c.Length = 2) Then
            c = c + " "
        End If
    End Sub

    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES






    Private Sub bt_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim c As New cls_PEDIDO
        ''GUARDAR PEDIDO 

        If ((tieneDatos() = True) And (EsNumero(tf_pedido.Text) = True) And (tf_producto2.Items.Count > 0)) Then
            If (existe(tf_pedido.Text) = False) Then
                If (ch_llevar.Visible = True) Then  'pregunta si es pedido para llevar o mesa
                    c.PEDIDO_ID = CInt(tf_pedido.Text)
                    c.CLIENTE_ID = CInt(tf_cliente.Text)
                    c.MESERO_ID = CInt(tf_mesero.Text)
                    c.RECEPCIONISTA_ID = CInt(tf_recepcionista.Text)
                    c.MOTISTA_ID = CInt(tf_motista.Text)
                    If (ch_llevar.Checked = True) Then
                        c.TIPO_PEDIDO = "LLEVAR"
                    Else
                        If (ch_mesa.Checked = True) Then
                            c.TIPO_PEDIDO = "MESA"
                        End If
                    End If
                    c.ESTADO = "PENDIENTE"
                    c.FECHA = Date.Parse(tf_fecha.Text)
                    c.MONTO_TOTAL = CDbl(tf_montoTotal.Text)
                    c.MESA_ID = CInt(tf_mesa.Text)
                    MConexion.Conectar()
                    c.Guardar()
                    MConexion.Desconectar()
                Else    ' caso contrario es pedido a domicilio
                    c.PEDIDO_ID = CInt(tf_pedido.Text)
                    c.CLIENTE_ID = CInt(tf_cliente.Text)
                    c.MESERO_ID = CInt(tf_mesero.Text)
                    c.RECEPCIONISTA_ID = CInt(tf_recepcionista.Text)
                    c.MOTISTA_ID = CInt(tf_motista.Text)
                    c.TIPO_PEDIDO = tf_tipo.Text
                    c.ESTADO = tf_estado.Text
                    c.FECHA = Date.Parse(tf_fecha.Text)
                    c.MONTO_TOTAL = CDbl(tf_montoTotal.Text)
                    c.MESA_ID = "0"
                    MConexion.Conectar()
                    c.Guardar()
                    MConexion.Desconectar()
                End If

                ''GUARDAR DETALLE_PEDIDO
                Dim d As New cls_DETALLE_PEDIDO, i As Integer, p
                For i = 0 To tf_producto2.Items.Count - 1
                    d.PEDIDO_ID = CInt(tf_pedido.Text)
                    p = Split(tf_producto2.Items(i), " - ")

                    d.PRODUCTO_ID = CInt(p(0))
                    d.PRECIO_INITARIO = CInt(p(1))
                    p = Split(CStr(p(3)), " = ")
                    d.CANTIDAD = CInt(p(0))

                    MConexion.Conectar()
                    d.Guardar()
                    MConexion.Desconectar()
                Next

                'LIMPIA EL EDIT CI (refresh)
                tf_pedido.Items.Clear()
                MConexion.Conectar()

                'LIMPIA EL TF_MESA 
                tf_mesa.Items.Clear()
                'CARGA DE NUEVO EL TF_MESA CON MESAS K NO STEN OCUPADAS
                MConexion.Conectar()
                M_Generico.CargarCombo(tf_mesa, "Proc_ListarMesaLibre")
                MConexion.Desconectar()


                If (tf_tipo.Visible = True) Then
                    'LISTA ACTUALIZADA DE PEDIDO DOMICILIO EN EDIT TF_PEDIDO
                    MConexion.Conectar()
                    M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoDomicilio")
                    MConexion.Desconectar()
                Else
                    'LISTA ACTUALIZADA DE PEDIDO MESA O LLEVAR EN EDIT TF_PEDIDO
                    MConexion.Conectar()
                    M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoMLL")
                    MConexion.Desconectar()
                End If
                MsgBox("SE GUARDO SATIFACTORIAMENTE EL PEDIDO")
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL PEDIDO")
            End If
        Else
            MsgBox("LLENAR DATOS CORRESPONDIENTES, NUMERICOS Y LETRAS")
        End If

    End Sub


    Private Sub bt_buscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        buscar(tf_pedido.Text)
    End Sub

    Private Sub bt_modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim c As New cls_PEDIDO

        c.PEDIDO_ID = CInt(tf_pedido.Text)
        c.CLIENTE_ID = CInt(tf_cliente.Text)
        c.MESERO_ID = CInt(tf_mesero.Text)
        'c.DESCRIPCION = tf_descripcion.Text
        c.FECHA = tf_fecha.Text
        c.MONTO_TOTAL = CDbl(tf_montoTotal.Text)

        MConexion.Conectar()
        c.Modificar()
        MConexion.Desconectar()
    End Sub

    Private Sub bt_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tf_pedido.Text <> "") And (EsNumero(tf_pedido.Text) = True)) Then
            If (existe(tf_pedido.Text) = True) Then
                If (esPedidoPagado(tf_pedido.Text) = True) Then
                    MsgBox("NO SE PUEDE ELIMINAR EL PEDIDO ESTA PAGADO")
                Else
                    eliminarDetallePedido(tf_pedido.Text) ' elimina el detalle pedido

                    Dim c As New cls_PEDIDO     'eliminar el pedido 
                    c.PEDIDO_ID = CInt(tf_pedido.Text)
                    MConexion.Conectar()
                    c.Eliminar()
                    MConexion.Desconectar()

                    MsgBox("PEDIDO ELIMINADO DE LA BASE DE DATOS")
                End If
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL PEDIDO")
            End If
        Else
            MsgBox("LLENAR DATOS CORRESPONDIENTES, NUMERICOS Y LETRAS")
        End If
    End Sub

    Private Sub bt_mostrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        If (tf_tipo.Visible = True) Then     'si es pedido a domicilio 
            If (ch_pendiente.Checked = False And ch_pagado.Checked = False And ch_encurso.Checked = False) Then  'si no esta tiqueado ningun chekbox muestra todos los pedidos a domicilio
                MConexion.Conectar()
                M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoDomicilio", "tbl_PEDIDO")
                MConexion.Desconectar()
            End If
            If (ch_pendiente.Checked = True) Then  'si esta tiqueado en checkbox muestra los pedido a domicilio pendiente
                MConexion.Conectar()
                M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoDomicilioPendiente", "tbl_PEDIDO")
                MConexion.Desconectar()
            End If
            If (ch_encurso.Checked = True) Then    'si esta tiqueado en checkbox muestra los pedido a domicilio encurso
                MConexion.Conectar()
                M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoDomicilioEncurso", "tbl_PEDIDO")
                MConexion.Desconectar()
            End If
            If (ch_pagado.Checked = True) Then    'si esta tiqueado en checkbox muestra los pedido a domicilio pagados
                MConexion.Conectar()
                M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoDomicilioPagado", "tbl_PEDIDO")
                MConexion.Desconectar()
            End If
        Else        ' CASO CONTRARIO ES PEDIDO PARA LLEVAR O PARA MESA
            If (ch_llevar.Checked = False And ch_mesa.Checked = False) Then  'si los check mesa y llevar no estan tiqueados
                If (ch_pendiente.Checked = False And ch_pagado.Checked = False) Then 'si no los check pendiente y pagado no estan tiqueados muestra todo
                    MConexion.Conectar()
                    M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoML", "tbl_PEDIDO")
                    MConexion.Desconectar()
                End If
                If (ch_pendiente.Checked = True) Then  ' muestra solo los pendiente para llevar-mesa-PENDIENTE
                    MConexion.Conectar()
                    M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoMLpendiente", "tbl_PEDIDO")
                    MConexion.Desconectar()
                End If

                If (ch_pagado.Checked = True) Then  ' muestra solo los pagados para llevar-mesa-PAGADOS
                    MConexion.Conectar()
                    M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoMLpagado", "tbl_PEDIDO")
                    MConexion.Desconectar()
                End If
            Else
                If (ch_llevar.Checked = True) Then    'si esta check llevar tiqueado 
                    If (ch_pendiente.Checked = True) Then    ' solo muestra los pedido llevar-pendiente
                        MConexion.Conectar()
                        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoLlPendiente", "tbl_PEDIDO")
                        MConexion.Desconectar()
                    End If
                    If (ch_pagado.Checked = True) Then    ' solo muestra los pedido llevar-pagados
                        MConexion.Conectar()
                        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoLlPagado", "tbl_PEDIDO")
                        MConexion.Desconectar()
                    End If
                    If (ch_pendiente.Checked = False And ch_pagado.Checked = False) Then    ' solo muestra todos los pedido llevar-PAGADO-PENDIENTE
                        MConexion.Conectar()
                        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoLlPendientePagado", "tbl_PEDIDO")
                        MConexion.Desconectar()
                    End If
                End If
                If (ch_mesa.Checked = True) Then      'si esta check mesa tiqueado 
                    If (ch_pendiente.Checked = True) Then    ' solo muestra los pedido mesa-pendiente
                        MConexion.Conectar()
                        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoMPendiente", "tbl_PEDIDO")
                        MConexion.Desconectar()
                    End If
                    If (ch_pagado.Checked = True) Then    ' solo muestra los pedido mesa-pagados
                        MConexion.Conectar()
                        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoMPagado", "tbl_PEDIDO")
                        MConexion.Desconectar()
                    End If
                    If (ch_pendiente.Checked = False And ch_pagado.Checked = False) Then    ' solo muestra todos los pedido mesa
                        MConexion.Conectar()
                        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoMPendientePagado", "tbl_PEDIDO")
                        MConexion.Desconectar()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bt_atras_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        '''''''''''''''''''''''''' eliminar la tupla de cod_mesero, TABLA AUXILIAR DE LA BDS 
        Dim c As New cls_COD_MESERO
        c.COD = CInt(tf_cantidad.Text)
        MConexion.Conectar()
        c.Eliminar()
        MConexion.Desconectar()
        tf_cantidad.Text = ""

        Close()
    End Sub

    Private Sub tf_pedido_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pedido.SelectedIndexChanged
        buscar(tf_pedido.Text)
    End Sub


    Private Sub frm_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'METODO PARA ACTUALIZAR EL ESTADO DE LA MESA CUANDO CUMPLA EL TIEMPO DE LA RESERVA
        actualizarEstadoMesa()

        '''''''''''''''''' poner el id del mesero del frm_meserohacePedido al  frm_pedido
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarCodMesero '    " + (tf_cantidad.Text) + " '")
        Lector.Read()
        tf_mesero.Text = Lector(0)
        MConexion.Desconectar()

        'Pregunta si el ci es de mesero o de recepcionista para poner invisibles algunas cosas
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarRecepcionista '    " + (tf_mesero.Text) + " '")
        If (Lector.HasRows()) Then    ' si es recepcionista
            tf_recepcionista.Text = CInt(tf_mesero.Text)     'asigna el ci al edit recepcionista
            tf_mesero.Text = "0"       'pone un 0 para que no exista error en la BDS
            tf_mesero.Visible = False    'invisible el edit de mesero
            Label3.Visible = False    'invisible el label del mesero
            Label11.Visible = False    'invisible el label del pedido
            tf_tipo.Text = "DOMICILIO"   'pone domicilio al tipo de pedido
            ch_mesa.Visible = False      'hace invisible los check
            ch_llevar.Visible = False      'hace invisible los check
            tf_mesa.Visible = False
            lb_mesa.Visible = False
            tf_nombremotista.Visible = True

        Else        ' caso contrario es mesero
            tf_recepcionista.Visible = False     'invisible el edit del recepcionista
            tf_recepcionista.Text = "0"     'pone un 0 para que no exista error en la BDS
            tf_motista.Text = "0"     'pone un 0 para que no exista error en la BDS
            tf_motista.Visible = False    'invisible el edit del motista
            Label16.Visible = False   'invisible el label del recepcionista
            Label17.Visible = False   'invisible el label del motista
            Label18.Visible = False   'invisible el label del pedido domicilio
            tf_tipo.Visible = False      'hace invisible los tipo de pedido
            bt_asignar.Visible = False   'hace invisible el boton asignar pedido a motistaç
            ch_encurso.Visible = False  'hace invisible el checkbox encurso 
            lb_tipo.Visible = False
            tf_nombremotista.Visible = False

            
        End If
        ''''''''''''''''''HASTA AQUI ASIGNA EL CI DEL RECEPCIONISTA O MESERO DEL FRM_MESEROHACEPEDIDO


        '''''''''''''''''' siguiente pedido
        If (existe(1)) Then
            MConexion.Conectar()
            M_Generico.CargarText(tf_montoTotal, "Proc_SiguientePedido")
            tf_pedido.Text = CInt(tf_montoTotal.Text)
            tf_montoTotal.Text = ""
            MConexion.Desconectar()
        Else
            tf_pedido.Text = 1
        End If

        'PROCEDIMIENTOS ALMACENADOS DE LISTAR LOS LIST BOX

        ''SI ES PEDIDO MESA O LLEVAR
        If (tf_tipo.Visible = True) Then
            ''SI ES PEDIDO DOMICILIO
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoDomicilio")
            MConexion.Desconectar()
        Else
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedidoMLL")
            MConexion.Desconectar()
        End If


        MConexion.Conectar()
        M_Generico.CargarCombo(tf_motista, "Proc_ListarMotista")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_mesa, "Proc_ListarMesaLibre")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_recepcionista, "Proc_ListarRecepcionista")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_cliente, "Proc_ListarCliente")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_mesero, "Proc_ListarMesero")
        MConexion.Desconectar()

        ''DESDE AQUI CARGA LOS LISTBOX PARA EL TAB CONTROL
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

        'tf_Producto1.Items.Clear()
        For i As Integer = 0 To tf_producto.Items.Count - 1
            'tf_Producto1.Items.Add(tf_producto.Items(i) & " | " & tf_ProdStock.Items(i) & " | " & tf_nombre.Items(i))
            ' tf_Producto1.Items.Add(tf_ProdStock.Items(i) & "  -  " & tf_producto.Items(i) & "  -  " & tf_nombre.Items(i))
        Next

        For i As Integer = 0 To tf_prodTipo.Items.Count - 1
            If (tf_prodTipo.Items(i) = "POLLO") Then
                lb_pollo.Items.Add(tf_ProdStock.Items(i) & "  -  " & tf_producto.Items(i) & "  -  " & tf_nombre.Items(i))
            End If
            If (tf_prodTipo.Items(i) = "RES") Then
                lb_res.Items.Add(tf_ProdStock.Items(i) & "  -  " & tf_producto.Items(i) & "  -  " & tf_nombre.Items(i))
            End If
            If (tf_prodTipo.Items(i) = "BEBIDA") Then
                lb_bebidas.Items.Add(tf_ProdStock.Items(i) & "  -  " & tf_producto.Items(i) & "  -  " & tf_nombre.Items(i))
            End If
            If (tf_prodTipo.Items(i) = "PORCION") Then
                lb_porcion.Items.Add(tf_ProdStock.Items(i) & "  -  " & tf_producto.Items(i) & "  -  " & tf_nombre.Items(i))
            End If
        Next

        ''HASTA AQUI CARGA LOS LISTBOX PARA EL TABCONTROL


        'CARGA LOS PRIVILEGIOS DE LA BDS
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


        If (tf_mesero.Text <> "0") Then
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_TBuscarMesero '    " + (tf_mesero.Text) + " '")
            Lector.Read()
            tf_nombreMR.Text = Lector(0)
            MConexion.Desconectar()
        End If

        If (tf_recepcionista.Text <> "0") Then
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_TBuscarRecepcionista '    " + (tf_recepcionista.Text) + " '")
            Lector.Read()
            tf_nombreMR.Text = Lector(0)
            MConexion.Desconectar()
        End If

        If (tf_motista.Text <> "0") Then
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_TBuscarMotista '    " + (tf_motista.Text) + " '")
            Lector.Read()
            tf_nombremotista.Text = Lector(0)
            MConexion.Desconectar()
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim d As New frm_detallePedido
        d.ShowDialog()
    End Sub

    'Private Sub tf_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim Lector As SqlDataReader
    '   MConexion.Conectar()
    '  Lector = MConexion.EjecutarConsulta("Proc_BuscarProducto '    " + (tf_producto.Text) + " '")
    '
    '       If (Lector.HasRows()) Then
    '          Lector.Read()
    '         tf_nombre.Text = Lector(0)
    '        tf_descripcion.Text = Lector(0)
    '       tf_precioUnitario.Text = Lector(1)
    ' Else
    '      MsgBox("::::::::NO EXISTE EL PRODUCTO:::::::::::")
    'End If
    'MConexion.Desconectar()
    'End Sub

    Private Sub bt_mostrarPedidoPorFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_MostrarPedidoPorFecha '    " + (tf_fecha.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()

            'MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPedidoPorFecha", "tbl_PEDIDO")
            'MConexion.Desconectar()

        Else
            MsgBox("::::::::NO EXISTE EL PEDIDO POR FECHA:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Function MontoTotal() As Double
        Dim a, b#
        b = 0.0
        For i As Integer = 0 To tf_producto2.Items.Count - 1
            a = Split(tf_producto2.Items(i), " = ")
            b = b + CDbl(a(1))
        Next
        MontoTotal = b
    End Function

    Function PrecioUnitario(ByVal Id$)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProducto '    " + Id + " '")
        Lector.Read()
        PrecioUnitario = Lector(1)
        MConexion.Desconectar()
    End Function

    Private Sub tf_producto2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto2.SelectedIndexChanged

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

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextBox()
    End Sub
    Private Sub ch_mesa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_mesa.CheckedChanged
        If (ch_mesa.Checked = True) Then
            ch_llevar.Checked = False
            tf_mesa.Visible = True
            'tf_mesa.Text = ""
            lb_mesa.Visible = True
        End If
    End Sub

    Private Sub ch_llevar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_llevar.CheckedChanged
        If (ch_llevar.Checked = True) Then
            ch_mesa.Checked = False
            tf_mesa.Visible = False
            tf_mesa.Text = "0"
            lb_mesa.Visible = False
        End If
    End Sub

    Private Sub tf_Producto1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tf_producto2.Items.Clear()
    End Sub

    Private Sub bt_lis_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_lis_eliminar.Click
        If (Not (tf_producto2.SelectedIndex())) Then
            tf_producto2.Items.RemoveAt(tf_producto2.SelectedIndex)
            tf_montoTotal.Text = MontoTotal()
        Else
            MsgBox("SELECCIONAR PRODUCTO A ELIMINAR")
        End If
    End Sub

    Private Sub bt_lis_disminuir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_lis_disminuir.Click
        If (Not (tf_producto2.SelectedIndex())) Then
            Dim a, b, n%
            n = tf_producto2.SelectedIndex
            If n < 0 Then Exit Sub
            a = Split(tf_producto2.Items(n), " - ")
            b = Split(CStr(a(3)), " = ")
            If (b(0) - 1) = 0 Then
                tf_producto2.Items.RemoveAt(tf_producto2.SelectedIndex)
            Else
                tf_producto2.Items(n) = a(0) & " - " & a(1) & " - " & a(2) & " - " & (b(0) - 1) & " = " & (CDbl(a(1)) * CDbl(b(0) - 1))
            End If
            tf_montoTotal.Text = MontoTotal()
        Else
            MsgBox("SELECCIONAR PRODUCTO A DISMINUIR")
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If (Not (tf_producto2.SelectedIndex())) Then
            If (tf_suma.Text <> "") Then
                If (EsNumero(tf_suma.Text) = True) Then
                    Dim a, b, n%, c%
                    c = CInt(tf_suma.Text)
                    n = tf_producto2.SelectedIndex
                    a = Split(tf_producto2.Items(n), " - ")
                    b = Split(CStr(a(3)), " = ")
                    If (c) = 0 Then
                        tf_producto2.Items.RemoveAt(tf_producto2.SelectedIndex)
                    Else
                        tf_producto2.Items(n) = a(0) & " - " & a(1) & " - " & a(2) & " - " & c & " = " & (CDbl(a(1)) * CDbl(c))
                    End If
                    tf_montoTotal.Text = MontoTotal()
                Else
                    MsgBox("INTRODUCIR CANTIDAD DE TIPO NUMERICO")
                End If
            Else
                MsgBox("INTRUDICIR CANTIDAD A SUMAR")
            End If
        Else
            MsgBox("SELECCIONAR PRODUCTO A AUMENTAR")
        End If
    End Sub
    ''EVENTO DE DOBLE CLIK DEL TAB_POLLO AL LISTA DE PRODUCTO A PEDIR
    Private Sub lb_pollo_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_pollo.MouseDoubleClick
        Dim a, b, b1
        a = Split(lb_pollo.Items(lb_pollo.SelectedIndex), " - ")
        For i As Integer = 0 To tf_producto2.Items.Count - 1
            b = Split(tf_producto2.Items(i), " - ")
            b1 = Split(b(UBound(b)), " = ")
            If b(2) = a(2) Then
                If CInt(a(0)) < CInt(b1(0)) + 1 Then
                    MsgBox("Stock agotado")
                    Exit Sub
                End If
                tf_producto2.Items(i) = b(0) & " - " & b(1) & " - " & b(2) & " - " & (b1(0) + 1) & " = " & (CDbl(b(1)) * (CDbl(b1(0)) + 1))
                tf_montoTotal.Text = MontoTotal()
                Exit Sub
            End If
        Next
        tf_producto2.Items.Add(a(1) & " - " & PrecioUnitario(CStr(a(1))) & " - " & a(2) & " - 1 = " & PrecioUnitario(CStr(a(1))))
        tf_montoTotal.Text = MontoTotal()
    End Sub

    ''EVENTO DE DOBLE CLIK DEL TAB_RES AL LISTA DE PRODUCTO A PEDIR
    Private Sub lb_res_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_res.MouseDoubleClick
        Dim a, b, b1
        a = Split(lb_res.Items(lb_res.SelectedIndex), " - ")
        For i As Integer = 0 To tf_producto2.Items.Count - 1
            b = Split(tf_producto2.Items(i), " - ")
            b1 = Split(b(UBound(b)), " = ")
            If b(2) = a(2) Then
                If CInt(a(0)) < CInt(b1(0)) + 1 Then
                    MsgBox("Stock agotado")
                    Exit Sub
                End If
                tf_producto2.Items(i) = b(0) & " - " & b(1) & " - " & b(2) & " - " & (b1(0) + 1) & " = " & (CDbl(b(1)) * (CDbl(b1(0)) + 1))
                tf_montoTotal.Text = MontoTotal()
                Exit Sub
            End If
        Next
        tf_producto2.Items.Add(a(1) & " - " & PrecioUnitario(CStr(a(1))) & " - " & a(2) & " - 1 = " & PrecioUnitario(CStr(a(1))))
        tf_montoTotal.Text = MontoTotal()
    End Sub

    ''EVENTO DE DOBLE CLIK DEL TAB_BEBIDAS AL LISTA DE PRODUCTO A PEDIR
    Private Sub lb_bebidas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_bebidas.MouseDoubleClick
        Dim a, b, b1
        a = Split(lb_bebidas.Items(lb_bebidas.SelectedIndex), " - ")
        For i As Integer = 0 To tf_producto2.Items.Count - 1
            b = Split(tf_producto2.Items(i), " - ")
            b1 = Split(b(UBound(b)), " = ")
            If b(2) = a(2) Then
                If CInt(a(0)) < CInt(b1(0)) + 1 Then
                    MsgBox("Stock agotado")
                    Exit Sub
                End If
                tf_producto2.Items(i) = b(0) & " - " & b(1) & " - " & b(2) & " - " & (b1(0) + 1) & " = " & (CDbl(b(1)) * (CDbl(b1(0)) + 1))
                tf_montoTotal.Text = MontoTotal()
                Exit Sub
            End If
        Next
        tf_producto2.Items.Add(a(1) & " - " & PrecioUnitario(CStr(a(1))) & " - " & a(2) & " - 1 = " & PrecioUnitario(CStr(a(1))))
        tf_montoTotal.Text = MontoTotal()
    End Sub

    ''EVENTO DE DOBLE CLIK DEL TAB_PORCIONES AL LISTA DE PRODUCTO A PEDIR
    Private Sub lb_porcion_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lb_porcion.MouseDoubleClick
        Dim a, b, b1
        a = Split(lb_porcion.Items(lb_porcion.SelectedIndex), " - ")
        For i As Integer = 0 To tf_producto2.Items.Count - 1
            b = Split(tf_producto2.Items(i), " - ")
            b1 = Split(b(UBound(b)), " = ")
            If b(2) = a(2) Then
                If CInt(a(0)) < CInt(b1(0)) + 1 Then
                    MsgBox("Stock agotado")
                    Exit Sub
                End If
                tf_producto2.Items(i) = b(0) & " - " & b(1) & " - " & b(2) & " - " & (b1(0) + 1) & " = " & (CDbl(b(1)) * (CDbl(b1(0)) + 1))
                tf_montoTotal.Text = MontoTotal()
                Exit Sub
            End If
        Next
        tf_producto2.Items.Add(a(1) & " - " & PrecioUnitario(CStr(a(1))) & " - " & a(2) & " - 1 = " & PrecioUnitario(CStr(a(1))))
        tf_montoTotal.Text = MontoTotal()
    End Sub
   
    Private Sub bt_asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_asignar.Click
        Dim d As New frm_asignar_pedidoMotista
        d.ShowDialog()
    End Sub


    '' CHECKBOX EVENTOS DE CLIK EN LOS CHECKBOX
    Private Sub ch_pendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pendiente.CheckedChanged
        If (ch_pendiente.Checked = True) Then
            ch_encurso.Checked = False
            ch_pagado.Checked = False
        End If
    End Sub
    Private Sub ch_pagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pagado.CheckedChanged
        If (ch_pagado.Checked = True) Then
            ch_encurso.Checked = False
            ch_pendiente.Checked = False
        End If
    End Sub
    Private Sub ch_encurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_encurso.CheckedChanged
        If (ch_encurso.Checked = True) Then
            ch_pagado.Checked = False
            ch_pendiente.Checked = False
        End If
    End Sub

    Private Sub bt_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cliente.Click
        Dim p As New frm_Cliente
        p.MdiParent = MDForm
        p.Show()
    End Sub

    

    Private Sub tf_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tf_cliente.KeyPress
        If (tf_cliente.Text = "0") Then
            tf_nombreCliente.Text = "S / N"
        End If
    End Sub

    Private Sub tf_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_cliente.SelectedIndexChanged
        If (tf_mesa.Visible = True) Then
            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_BuscarMesaClienteReserva'    " + (tf_cliente.Text) + " '")
            Lector.Read()
            If (Lector.HasRows()) Then
                tf_mesa.Text = Lector(0)
            End If
            MConexion.Desconectar()

            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_TBuscarCliente '    " + (tf_cliente.Text) + " '")
            Lector.Read()
            tf_nombreCliente.Text = Lector(0)
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub tf_recepcionista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_recepcionista.SelectedIndexChanged
        Dim lector As SqlDataReader

        MConexion.Conectar()
        lector = MConexion.EjecutarConsulta("Proc_TBuscarRecepcionista '    " + (tf_recepcionista.Text) + " '")
        Lector.Read()
        tf_nombreMR.Text = lector(0)
        MConexion.Desconectar()
    End Sub

    Private Sub tf_mesero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_mesero.SelectedIndexChanged
        Dim lector As SqlDataReader

        MConexion.Conectar()
        lector = MConexion.EjecutarConsulta("Proc_TBuscarMesero '    " + (tf_mesero.Text) + " '")
        lector.Read()
        tf_nombreMR.Text = lector(0)
        MConexion.Desconectar()
    End Sub

    Private Sub tf_motista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_motista.SelectedIndexChanged
        Dim lector As SqlDataReader

        MConexion.Conectar()
        lector = MConexion.EjecutarConsulta("Proc_TBuscarMotista '    " + (tf_motista.Text) + " '")
        lector.Read()
        tf_nombremotista.Text = lector(0)
        MConexion.Desconectar()
    End Sub
End Class