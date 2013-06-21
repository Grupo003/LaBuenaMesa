Imports System.Data.SqlClient
Public Class frm_producto
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
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProducto '    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Function existeDeshabilitado(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProductoDeshabilitado '    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Sub buscarPorNombre(ByVal b As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProductoPorNombre '    " + (b) + " '")

        If (Lector.HasRows() = True) Then
            Lector.Read()
            tf_producto.Text = Lector(0)
            tf_precio.Text = Lector(1)
            tf_stock.Text = Lector(2)
        Else
            MsgBox("::::::::NO EXISTE EL PRODUCTO:::::::::::")
        End If
        MConexion.Desconectar()
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
        If (ch_deshabilitado.Checked = False) Then
            If ((tf_producto.Text <> "") And (EsNumero(tf_producto.Text) = True)) Then
                If (existeHabilitado(tf_producto.Text) = True) Then
                    Dim Lector As SqlDataReader
                    Dim t As New Char
                    MConexion.Conectar()
                    Lector = MConexion.EjecutarConsulta("Proc_BuscarProducto '    " + (tf_producto.Text) + " '")
                    Lector.Read()

                    tf_nombre.Text = Lector(0)
                    tf_precio.Text = Lector(1)
                    tf_stock.Text = Lector(2)

                    If (Lector(3) = "RES") Then
                        ch_res.Checked = True
                    End If
                    If (Lector(3) = "POLLO") Then
                        ch_pollo.Checked = True
                    End If
                    If (Lector(3) = "BEBIDA") Then
                        ch_bebida.Checked = True
                    End If
                    If (Lector(3) = "PORCION") Then
                        ch_porcion.Checked = True
                    End If
                    tf_estado.Text = Lector(4)
                    MConexion.Desconectar()
                Else
                    MsgBox("NO EXISTE EL ADMINISTRADOR A BUSCAR")
                End If
            Else
                MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
            End If
        Else
            If ((tf_producto.Text <> "") And (EsNumero(tf_producto.Text) = True)) Then
                If (existeDeshabilitado(tf_producto.Text) = True) Then
                    Dim Lector As SqlDataReader
                    Dim t As New Char
                    MConexion.Conectar()
                    Lector = MConexion.EjecutarConsulta("Proc_BuscarProductoDeshabilitado '    " + (tf_producto.Text) + " '")
                    Lector.Read()

                    tf_nombre.Text = Lector(0)
                    tf_precio.Text = Lector(1)
                    tf_stock.Text = Lector(2)
                    t = Lector(3)
                    If (t = "RES") Then
                        ch_res.Checked = True
                    End If
                    If (t = "POLLO") Then
                        ch_pollo.Checked = True
                    End If
                    If (t = "BEBIDA") Then
                        ch_bebida.Checked = True
                    End If
                    If (t = "PORCION") Then
                        ch_porcion.Checked = True
                    End If
                    tf_estado.Text = Lector(4)
                    MConexion.Desconectar()
                Else
                    MsgBox("NO EXISTE EL PRODUCTO DESHABILITADO A BUSCAR")
                End If
            Else
                MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
            End If
        End If

    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES







    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click

        If (ch_deshabilitado.Checked = False) Then
            If ((tieneDatos() = True) And (tieneDatoTipo() = True) And (EsNumero(tf_producto.Text) = True)) Then
                If (existeHabilitado(tf_producto.Text) = False And existeDeshabilitado(tf_producto.Text) = False) Then
                    Dim c As New cls_PRODUCTO

                    c.PRODUCTO_ID = CInt(tf_producto.Text)
                    c.NOMBRE = tf_nombre.Text
                    c.PRECIO = Val(tf_precio.Text)
                    If (ch_pollo.Checked = True) Then
                        c.TIPO = "POLLO"
                    End If
                    If (ch_res.Checked = True) Then
                        c.TIPO = "RES"
                    End If
                    If (ch_bebida.Checked = True) Then
                        c.TIPO = "BEBIDA"
                    End If
                    If (ch_porcion.Checked = True) Then
                        c.TIPO = "PORCION"
                    End If
                    c.ESTADO = tf_estado.Text

                    MConexion.Conectar()
                    c.Guardar()
                    MConexion.Desconectar()
                    MsgBox("SE GUARDAR EXITOSAMENTE EL PRODUCTO")

                    'LIMPIA EL EDIT CI (refresh)
                    tf_producto.Items.Clear()

                    'LISTA ACTUALIZADA DE PRODUCTOS HABILITADO EN EDIT TF_PRODUCTO
                    MConexion.Conectar()
                    M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
                    MConexion.Desconectar()
                Else
                    MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL PRODUCTO")
                End If
            Else
                If (tieneDatoTipo() = False) Then
                    MsgBox("SELECCIONAR EL TIPO DE PRODUCTO")
                Else
                    MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
                End If
            End If

        Else
            If ((tf_producto.Text <> "") And (EsNumero(tf_producto.Text) = True)) Then
                If (existeDeshabilitado(tf_producto.Text) = True) Then
                    MConexion.Conectar()
                    MConexion.EjecutarConsulta("Proc_GuardarProductoDeshabilitado '    " + (tf_producto.Text) + " '")
                    MConexion.Desconectar()
                    MsgBox("SE HABILITO EXISTOSAMENTE EL PRODUCTO")

                    'LIMPIA EL EDIT CI (refresh)
                    tf_producto.Items.Clear()

                    'LISTA ACTUALIZADA DE PRODUCTO DESHABILITADOS EN EDIT TF_PRODUCTO
                    MConexion.Conectar()
                    M_Generico.CargarCombo(tf_producto, "Proc_ListarProductoDeshabilitado")
                    MConexion.Desconectar()
                Else
                    MsgBox("NO SE PUEDE HABILITAR, NO EXISTE EL PRODUCTO")
                End If
            Else
                MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
            End If
        End If


    End Sub
    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        buscar(tf_producto.Text)
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click

        If ((tieneDatos() = True) And (EsNumero(tf_precio.Text) = True) And (EsNumero(tf_nombre.Text) = False)) Then
            If ((existeHabilitado(tf_producto.Text) = True) And (tieneDatoTipo() = True)) Then
                Dim c As New cls_PRODUCTO

                c.PRODUCTO_ID = CInt(tf_producto.Text)
                c.NOMBRE = tf_nombre.Text
                c.PRECIO = CDbl(tf_precio.Text)
                If (ch_res.Checked = True) Then
                    c.TIPO = "RES"
                End If
                If (ch_pollo.Checked = True) Then
                    c.TIPO = "POLLO"
                End If
                If (ch_bebida.Checked = True) Then
                    c.TIPO = "BEBIDA"
                End If
                If (ch_porcion.Checked = True) Then
                    c.TIPO = "PORCION"
                End If

                MConexion.Conectar()
                c.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                If (tieneDatoTipo() = False) Then
                    MsgBox("SELECCIONAR EL TIPO DE PRODUCTO PARA MODIFICAR")
                Else
                    MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL PRODUCTO")
                End If

            End If
        Else
            MsgBox("RELLENAR CASILLAS, PRODUCTO,PRECIO DE TIPO NUMERICO Y NOMBRE DE CARACTER")
        End If
    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tf_producto.Text <> "") And (EsNumero(tf_producto.Text) = True)) Then
            If (existeHabilitado(tf_producto.Text) = True) Then
                Dim Lector As SqlDataReader
                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_EliminarProducto'    " + (tf_producto.Text) + " '")
                MConexion.Desconectar()
                MsgBox("PRODUCTO ELIMINADO EXITOSAMENTE")

                'LIMPIA EL EDIT CI (refresh)
                tf_producto.Items.Clear()

                'LISTA ACTUALIZADA DE PRODUCTOS HABILITADO EN EDIT TF_CI
                MConexion.Conectar()
                M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
                MConexion.Desconectar()
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL PRODUCTO")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        If (ch_deshabilitado.Checked = True) Then
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarProductoDeshabilitado", "tbl_PRODUCTO")
            MConexion.Desconectar()
        Else
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarProducto", "tbl_PRODUCTO")
            MConexion.Desconectar()
        End If

    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub tf_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto.SelectedIndexChanged
        buscar(tf_producto.Text)
    End Sub

    Private Sub frm_producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''''''''''siguiente pedido''''''''''''''
        If (existeHabilitado(1) Or existeDeshabilitado(1)) Then
            MConexion.Conectar()
            M_Generico.CargarText((tf_auxiliar), "Proc_SiguienteProducto")
            MConexion.Desconectar()
            tf_producto.Text = (CInt(tf_auxiliar.Text))
            tf_auxiliar.Text = ""
        Else
            tf_producto.Text = 1
        End If


        MConexion.Conectar()
        M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_nombre, "Proc_ListarProductoPorNombre")
        MConexion.Desconectar()



        'CARGA LOS PRIVILEGIOS DE LA BDS
        Dim Lector As SqlDataReader
        Dim a As Integer

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ObtenerCodGrupo")
        Lector.Read()
        a = Lector(0)
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon1 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_guardar.Enabled = True
        Else
            bt_guardar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon2 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_limpiar.Enabled = True
        Else
            bt_limpiar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon3 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_buscar.Enabled = True
        Else
            bt_buscar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon4 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_modificar.Enabled = True
        Else
            bt_modificar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon5 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_eliminar.Enabled = True
        Else
            bt_eliminar.Enabled = False
        End If
        MConexion.Desconectar()

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon6 '    " + CStr(a) + " '")
        If (Lector.HasRows()) Then
            bt_mostrar.Enabled = True
        Else
            bt_mostrar.Enabled = False
        End If
        MConexion.Desconectar()
        'ACA TERMINA CARGA LOS PRIVILEGIOS DE LA BDS
    End Sub
    
    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextBox()
    End Sub
    

    Private Sub bt_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_logout.Click
        Dim d As DialogResult
        d = MsgBox("¿SEGURO DESEA CAMBIAR DE USUARIO?", MsgBoxStyle.YesNo)
        If (d = Windows.Forms.DialogResult.Yes) Then
            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_ActualizarBitacoraFechaSalida")
            MConexion.Desconectar()

            Dim l As New frm_login
            l.MdiParent = MDForm
            l.Show()
        End If
    End Sub

    Private Sub tf_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_salir.Click
        Dim d As DialogResult
        d = MsgBox("¿SEGURO DESEA SALIR DEL SISTEMA?", MsgBoxStyle.YesNo)
        If (d = Windows.Forms.DialogResult.Yes) Then
            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_ActualizarBitacoraFechaSalida")
            MConexion.Desconectar()

            Application.Exit()
        End If
    End Sub

    Private Sub tf_nombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_nombre.SelectedIndexChanged
        'buscarPorNombre(tf_nombre.Text)
    End Sub


    '' CHECKBOX EVENTOS DE CLIK EN LOS CHECKBOX
    Private Sub ch_bebida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_bebida.CheckedChanged
        If (ch_bebida.Checked = True) Then
            ch_pollo.Checked = False
            ch_porcion.Checked = False
            ch_res.Checked = False
        End If
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
        If (ch_deshabilitado.Checked = True) Then
            'BLOQUE LOS BOTONES QUE NO SE NECESITAN CUANDO SE CHECKED = TRUE
            bt_modificar.Enabled = False
            bt_eliminar.Enabled = False
            bt_guardar.Text = "HABILITAR"

            'LIMPIA EL EDIT Y PARA LUEGO ACTUALIZARLO
            tf_producto.Items.Clear()
            tf_nombre.Items.Clear()

            'LISTA LOS ADMINISTRADORES DESHABILITADOS EN EDIT TF_CI
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProductoDeshabilitado")
            MConexion.Desconectar()

            'LISTAR LOS PRODUCTOS DESHABILITADO POR NOMBRE EN EL EDIT TF_NOMBRE
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_nombre, "Proc_ListarProductoPorNombreDeshabilitado")
            MConexion.Desconectar()

        Else
            'DESBLOQUE LOS BOTONES QUE NO SE NECESITAN CUANDO SE CHECKED = TRUE
            bt_modificar.Enabled = True
            bt_eliminar.Enabled = True
            bt_guardar.Text = "GUARDAR"

            'LIMPIA EL EDIT Y PARA LUEGO ACTUALIZARLO
            tf_producto.Items.Clear()
            tf_nombre.Items.Clear()

            'LISTA LOS ADMINISTRADORES HABILITADOS EN EDIT TF_CI
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
            MConexion.Desconectar()

            'LISTAR LOS PRODUCTOS HABILITADO POR NOMBRE EN EL EDIT TF_NOMBRE
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_nombre, "Proc_ListarProductoPorNombre")
            MConexion.Desconectar()
        End If
    End Sub
End Class