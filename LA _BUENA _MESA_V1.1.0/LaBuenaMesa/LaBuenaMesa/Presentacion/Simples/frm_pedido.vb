Imports System.Data.SqlClient
Public Class frm_pedido
    ''::::::::::::::::::METODOS Y FUNCIONES
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
      
    End Function
    Public Function esPedidoPagado(ByVal Cad As String) As Boolean
       
    End Function
    Public Sub eliminarDetallePedido(ByVal pe As String)
       
    End Sub

    Public Sub generarPedido(ByVal p As String)
        
    End Sub

    Public Sub buscar(ByVal p As String)
       
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
       

    End Sub


    Private Sub bt_buscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click

    End Sub

    Private Sub bt_modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub bt_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
       
    End Sub

    Private Sub bt_mostrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        
    End Sub

    Private Sub bt_atras_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
      
    End Sub

    Private Sub tf_pedido_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pedido.SelectedIndexChanged

    End Sub


    Private Sub frm_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Function PrecioUnitario(ByVal Id$) As Double

    End Function

    Private Sub tf_producto2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto2.SelectedIndexChanged

    End Sub

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
    
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
       
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
    
    End Sub

    Private Sub tf_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tf_cliente.KeyPress
        If (tf_cliente.Text = "0") Then
            tf_nombreCliente.Text = "S / N"
        End If
    End Sub

    Private Sub tf_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_cliente.SelectedIndexChanged

    End Sub

    Private Sub tf_recepcionista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_recepcionista.SelectedIndexChanged
    
    End Sub

    Private Sub tf_mesero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_mesero.SelectedIndexChanged
  
    End Sub

    Private Sub tf_motista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_motista.SelectedIndexChanged
   
    End Sub
End Class