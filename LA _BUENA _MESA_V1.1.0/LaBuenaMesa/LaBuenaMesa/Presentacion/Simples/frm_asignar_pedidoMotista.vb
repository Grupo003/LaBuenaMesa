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

    End Function
    Public Function existePedidoDomicilio(ByVal pe As String) As Boolean
 
    End Function
    Public Function esPedidoPagado(ByVal Cad As String) As Boolean

    End Function
    Public Function existeMotista(ByVal m As String) As Boolean
       
    End Function
    Public Sub generarPedido(ByVal p As String)

    End Sub

    Public Sub buscar(ByVal b As String)
    
    End Sub

    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES

    Private Sub bt_asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_asignar.Click
    
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click

    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        
    End Sub
    Private Sub bt_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
     
    End Sub
    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click

    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub tf_pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_pedido.SelectedIndexChanged


    End Sub

    Private Sub frm_asignar_pedidoMotista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
    End Sub

    Private Sub tf_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub tf_clienteP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_clienteP.TextChanged
       
    End Sub

    Private Sub tf_motista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_motista.SelectedIndexChanged
      
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click

    End Sub

    '' CHECKBOX EVENTOS DE CLIK EN LOS CHECKBOX
    Private Sub ch_pendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pendiente.CheckedChanged
     
    End Sub
    Private Sub ch_pagado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pagado.CheckedChanged
      
    End Sub
    Private Sub ch_encurso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_encurso.CheckedChanged
        
    End Sub

   

    
End Class