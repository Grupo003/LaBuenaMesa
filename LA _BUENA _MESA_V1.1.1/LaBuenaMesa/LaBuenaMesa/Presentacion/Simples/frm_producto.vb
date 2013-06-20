Imports System.Data.SqlClient
Public Class frm_producto
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function

    Public Function tieneDatos() As Boolean
        If ((tf_producto.Text <> "") And (tf_nombre.Text <> "") And (tf_precio.Text <> "") And (tf_stock.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function tieneDatosPro() As Boolean
        If ((tf_producto.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function tieneDatoTipo() As Boolean
        If ((ch_pollo.Checked = True) Or (ch_porcion.Checked = True) Or (ch_bebida.Checked = True) Or (ch_res.Checked = True)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existeHabilitado(ByVal Cad As String) As Boolean
   
    End Function
    Public Function existeDeshabilitado(ByVal Cad As String) As Boolean

    End Function
    Public Sub buscarPorNombre(ByVal b As String)
       
    End Sub
    Public Sub LimpiarTextBox()
        tf_producto.Text = ""
        tf_nombre.Text = ""
        tf_precio.Text = ""
        tf_stock.Text = ""
        ch_pollo.Checked = False
        ch_res.Checked = False
        ch_porcion.Checked = False
        ch_bebida.Checked = False
    End Sub
    Public Sub buscar(ByVal b As String)
       

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

    Private Sub tf_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto.SelectedIndexChanged

    End Sub

    Private Sub frm_producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        'ACA TERMINA CARGA LOS PRIVILEGIOS DE LA BDS
    End Sub
    
    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextBox()
    End Sub
    

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
      
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
       
    End Sub

    Private Sub tf_nombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_nombre.SelectedIndexChanged

    End Sub


    '' CHECKBOX EVENTOS DE CLIK EN LOS CHECKBOX
    Private Sub ch_bebida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_bebida.CheckedChanged
       
    End Sub
    Private Sub ch_pollo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pollo.CheckedChanged
        If (ch_pollo.Checked = True) Then
            ch_bebida.Checked = False
            ch_porcion.Checked = False
            ch_res.Checked = False
        End If
    End Sub
    Private Sub ch_porcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_porcion.CheckedChanged
        If (ch_porcion.Checked = True) Then
            ch_bebida.Checked = False
            ch_pollo.Checked = False
            ch_res.Checked = False
        End If
    End Sub
    Private Sub ch_res_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_res.CheckedChanged
        If (ch_res.Checked = True) Then
            ch_bebida.Checked = False
            ch_pollo.Checked = False
            ch_porcion.Checked = False
        End If
    End Sub


    Private Sub ch_deshabilitado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_deshabilitado.CheckedChanged
       
    End Sub


End Class