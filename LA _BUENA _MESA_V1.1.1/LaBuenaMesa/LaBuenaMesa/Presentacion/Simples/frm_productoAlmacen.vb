Imports System.Data.SqlClient
Public Class frm_productoAlmacen

    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function

    Public Function tieneDatos() As Boolean
        If ((tf_producto.Text <> "") And (tf_almacen.Text <> "") And (tf_nombrePro.Text <> "") And (tf_nombreAlm.Text <> "") And (tf_cantidad.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal p As String, ByVal a As String) As Boolean
        
    End Function
    Public Sub eliminar(ByVal pro As String, ByVal alm As String)
       
    End Sub
    Public Sub buscar(ByVal p As String, ByVal a As String)
       
    End Sub



    Public Sub LimpiarTextBox()
        tf_producto.Text = ""
        tf_almacen.Text = ""
        tf_nombrePro.Text = ""
        tf_nombreAlm.Text = ""
        tf_cantidad.Text = ""
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

    Private Sub frm_productoCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        'ACA TERMINA CARGA LOS PRIVILEGIOS DE LA BDS
    End Sub

    Private Sub tf_nuevaCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_almacen.Click
       
    End Sub

    Private Sub tf_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto.SelectedIndexChanged
      
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextBox()
    End Sub
    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
        
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
       
    End Sub

    Private Sub tf_almacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_almacen.SelectedIndexChanged
        
    End Sub

    '' CHECKBOX EVENTOS DE CLIK EN LOS CHECKBOX
    Private Sub ch_bebida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_bebida.CheckedChanged
       
    End Sub

    Private Sub ch_solido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pollo.CheckedChanged
        
    End Sub

    Private Sub ch_porcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_porcion.CheckedChanged
      
    End Sub
    Private Sub ch_res_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_res.CheckedChanged
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class