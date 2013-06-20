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
     
    End Function
    Public Function existePedidoPagado(ByVal Cad As String) As Boolean
       
    End Function


    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        
      
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
     
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
       
    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
       
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        
    End Sub

    Private Sub frm_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub tf_pago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pago.SelectedIndexChanged
       
    End Sub

    Private Sub tf_pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pedido.SelectedIndexChanged
       
    End Sub

    Private Sub bt_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cliente.Click
      
    End Sub

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
       
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
        
    End Sub

    Private Sub ch_pendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pendiente.CheckedChanged
        
    End Sub
    Private Sub ch_pagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pagado.CheckedChanged
     
    End Sub
    Private Sub ch_encurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_encurso.CheckedChanged
      
    End Sub

    Private Sub tf_cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_cajero.SelectedIndexChanged
       
        
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