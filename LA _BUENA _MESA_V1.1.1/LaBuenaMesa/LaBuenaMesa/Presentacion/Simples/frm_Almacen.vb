Imports System.Data.SqlClient
Public Class frm_Almacen
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_almacen.Text <> "") And (tf_nombre.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal Cad As String) As Boolean

    End Function
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

    Private Sub frm_Almacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        'ACA TERMINA CARGA LOS PRIVILEGIOS DE LA BDS
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
    
    End Sub

    Public Sub LimpiarTextBox()
        tf_almacen.Text = ""
        tf_nombre.Text = ""
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextBox()
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
    
    End Sub

    Private Sub tf_almacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_almacen.SelectedIndexChanged
      
    End Sub
End Class