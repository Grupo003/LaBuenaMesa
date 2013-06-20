Imports System.Data.SqlClient
Public Class frm_administrador
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_ci.Text <> "") And (tf_nombre.Text <> "") And (tf_ap.Text <> "") And (tf_am.Text <> "") And (tf_dir.Text <> "") And (tf_telf.Text <> "") And (tf_cel.Text <> "") And (cb_sexo.Text <> "") And (tf_login.Text <> "") And (tf_contraseña.Text <> "") And (tf_estado.Text <> "") And (tf_grupo.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function tieneDatosCi() As Boolean
        If ((tf_ci.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existeHabilitado(ByVal Cad As String) As Boolean
   
    End Function
    Public Function existeDeshabilitado(ByVal Cad As String) As Boolean
 
    End Function
    Public Sub LimpiarTextList()
        tf_ci.Text() = ""
        tf_nombre.Text() = ""
        tf_am.Text() = ""
        tf_ap.Text() = ""
        tf_dir.Text() = ""
        tf_fn.Text() = ""
        tf_telf.Text() = ""
        tf_cel.Text() = ""
        cb_sexo.Text() = ""
        tf_login.Text() = ""
        tf_contraseña.Text() = ""
        tf_grupo.Text() = ""
    End Sub
    Public Sub buscar(ByVal b As String)
       
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES



    Private Sub bt_guardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
       
    End Sub

    Private Sub bt_buscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click

    End Sub

    Private Sub bt_modificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click

       
    End Sub

    Private Sub bt_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
       
    End Sub

    'MUESTRA TODO LAS TUPLAS DE LA TABLA DE LA BASE DE DATOS AL DATAGRID
    Private Sub bt_mostrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click  

    End Sub
    

    'LISTA LOS COMBOBOX ADMINISTRADOR Y TIPO DE ADM
    Private Sub frm_administrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    'BUSCA Y CARGA DEL COMBOBOX CI LOS DATOS DE ESE CARNET
    Private Sub tf_ci_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_ci.SelectedIndexChanged

    End Sub

    'CIERRA EL FORMULARIO ACTUAL PARA IRSE AL ANTERIOR
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    'BOTON QUE LLAMA AL METODO LIMPIAR TEXTBOX Y LISTBOX
    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextList()
    End Sub


    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
      
    End Sub

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
       
    End Sub

    Private Sub ch_deshabilitado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_deshabilitado.CheckedChanged
        
    End Sub
End Class


