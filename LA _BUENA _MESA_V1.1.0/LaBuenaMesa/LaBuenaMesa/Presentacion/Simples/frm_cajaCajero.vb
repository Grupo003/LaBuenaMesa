Imports System.Data.SqlClient
Public Class frm_cajaCajero
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_cajero.Text <> "") And (tf_caja.Text <> "") And (tf_monto.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal cjr As String, ByVal cj As String) As Boolean
       
    End Function
    Public Sub buscar(ByVal cjr As String, ByVal cj As String)
       
    End Sub
    Public Sub eliminar(ByVal cjr As String, ByVal cj As String)
      
    End Sub
    Public Sub LimpiarTextList()
        tf_caja.Text = ""
        tf_cajero.Text = ""
        tf_fecha.Text = ""
        tf_monto.Text = ""
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

    Private Sub frm_cajaCajero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        'ACA TERMINA CARGA LOS PRIVILEGIOS DE LA BDS
    End Sub

    Private Sub tf_caja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_caja.SelectedIndexChanged
    
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextList()
    End Sub

    Private Sub bt_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_salir.Click
        
    End Sub

    
    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
        
    End Sub

    Private Sub tf_cajero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_cajero.SelectedIndexChanged
      
    End Sub
End Class