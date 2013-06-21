Imports System.Data.SqlClient

Public Class frm_privilegio

    Private Sub frm_privilegio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click


    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarChechBox()
    End Sub

    Public Sub LimpiarChechBox()
        ch_guardar.Checked = False
        ch_eliminar.Checked = False
        ch_modificar.Checked = False
        ch_mostrar.Checked = False
        ch_mostrar.Checked = False
        ch_buscar.Checked = False
        ch_limpiar().Checked = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
        
    End Sub

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

    Private Sub tf_grupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_grupo.SelectedIndexChanged
       
    End Sub

    
End Class