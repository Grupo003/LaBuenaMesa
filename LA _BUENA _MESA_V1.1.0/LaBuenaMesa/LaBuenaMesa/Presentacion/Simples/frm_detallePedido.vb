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
       
    End Function
    Public Sub buscar(ByVal pe As String, ByVal pr As String)
      
    End Sub
    Public Sub LimpiarTextList()
        tf_producto.Text = ""
        tf_pedido.Text = ""
        tf_cantidad.Text = ""
        tf_precioUnitario.Text = ""
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES

    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
      
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
      
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        

    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
      
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub frm_detallePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub tf_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto.SelectedIndexChanged
       
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextList()
    End Sub

    Private Sub bt_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_salir.Click
      
    End Sub
End Class