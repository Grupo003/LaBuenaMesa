Imports System.Data.SqlClient
Public Class frm_detallePedido
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_pedido.Text <> "") And (tf_producto.Text <> "") And (tf_cantidad.Text <> "") And (tf_precioUnitario.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal pe As String, ByVal pr As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarDetallePedidoS " + (pe) + "," + (pr))
        If (Lector.HasRows() = True) Then
            Lector.Read()
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Sub buscar(ByVal pe As String, ByVal pr As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarDetallePedidoS " + (pe) + "," + (pr))
        If (Lector.HasRows() = True) Then
            Lector.Read()
            tf_cantidad.Text = Lector(0)
            tf_precioUnitario.Text = Lector(1)
        Else
            MsgBox("NO EXISTE EL DETALLE-PEDIDO")
        End If
        MConexion.Desconectar()
    End Sub
    Public Sub LimpiarTextList()
        tf_producto.Text = ""
        tf_pedido.Text = ""
        tf_cantidad.Text = ""
        tf_precioUnitario.Text = ""
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES







    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim p As New cls_DETALLE_PEDIDO


        If ((tieneDatos() = True) And (EsNumero(tf_pedido.Text) = True) And (EsNumero(tf_producto.Text) = True) And (EsNumero(tf_precioUnitario.Text) = True) And (EsNumero(tf_cantidad.Text) = True)) Then
            If (existe((tf_pedido.Text), (tf_producto.Text)) = False) Then
                p.PEDIDO_ID = CInt(tf_pedido.Text)
                p.PRODUCTO_ID = CInt(tf_producto.Text)
                p.CANTIDAD = CInt(tf_cantidad.Text)
                p.PRECIO_INITARIO = CDbl(tf_precioUnitario.Text)

                MConexion.Conectar()
                p.Guardar()
                MConexion.Desconectar()
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL DETALLE-PEDIDO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, TIPO NUMERICO")
        End If

    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        If ((tf_pedido.Text <> "") And (tf_producto.Text <> "")) Then
            If (EsNumero(tf_pedido.Text) And EsNumero(tf_producto.Text)) Then
                buscar(CInt(tf_pedido.Text), CInt(tf_producto.Text))
            Else
                MsgBox("INGRESE ID DE PEDIDO, PRODUCTO DE TIPO NUMERICO")
            End If
        Else
            MsgBox("INGRESE ID DE PEDIDO, PRODUCTO A BUSCAR")
        End If
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_pedido.Text) = True) And (EsNumero(tf_producto.Text) = True) And (EsNumero(tf_precioUnitario.Text) = True) And (EsNumero(tf_cantidad.Text) = True)) Then
            If (existe((tf_pedido.Text), (tf_producto.Text)) = True) Then
                Dim p As New cls_DETALLE_PEDIDO

                p.PEDIDO_ID = CInt(tf_pedido.Text)
                p.PRODUCTO_ID = CInt(tf_producto.Text)
                p.CANTIDAD = CInt(tf_cantidad.Text)
                p.PRECIO_INITARIO = CDbl(tf_precioUnitario.Text)

                MConexion.Conectar()
                p.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL DETALLE-PEDIDO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, TIPO NUMERICO")
        End If

    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_pedido.Text) = True) And (EsNumero(tf_producto.Text) = True) And (EsNumero(tf_precioUnitario.Text) = True) And (EsNumero(tf_cantidad.Text) = True)) Then
            If (existe((tf_pedido.Text), (tf_producto.Text)) = True) Then
                Dim p As New cls_DETALLE_PEDIDO

                p.PEDIDO_ID = CInt(tf_pedido.Text)
                p.PRODUCTO_ID = CInt(tf_producto.Text)

                MConexion.Conectar()
                p.Eliminar()
                MConexion.Conectar()
                MsgBox("DETALLE-PEDIDO ELIMINADO")
            Else
                MsgBox("NO SE PUEDE ELIMINAT, NO EXISTE EL DETALLE-PEDIDO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarDetallePedido", "tbl_DETALLE_PEDIDO")
        MConexion.Desconectar()
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub frm_detallePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_pedido, "Proc_ListarPedido")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
        MConexion.Desconectar()
    End Sub

    Private Sub tf_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProducto '    " + (tf_producto.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_precioUnitario.Text = Lector(1)
        Else
            MsgBox(":::::::: NO EXISTE EL PRODUCTO :::::::::::")
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
End Class