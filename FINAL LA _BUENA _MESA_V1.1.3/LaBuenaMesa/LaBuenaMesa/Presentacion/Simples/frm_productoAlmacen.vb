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
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProductoAlmacen1 " + (p) + "," + (a))
        If (Lector.HasRows() = True) Then
            Lector.Read()
            Return True
        Else
            Return False
        End If
        MConexion.Desconectar()
    End Function
    Public Sub eliminar(ByVal pro As String, ByVal alm As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_tbl_PRODUCTO_ALMACENELIMINAR " + (pro) + "," + (alm))
        MConexion.Desconectar()
    End Sub
    Public Sub buscar(ByVal p As String, ByVal a As String)
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProductoAlmacen1 " + (p) + "," + (a))
        If (Lector.HasRows() = True) Then
            Lector.Read()
            tf_nombrePro.Text = Lector(0)
            tf_nombreAlm.Text = Lector(1)
            tf_cantidad.Text = Lector(2)
            tf_fecha.Text = Lector(3)
            MConexion.Desconectar()


            Dim t As New Char
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_BuscarProducto '    " + (tf_producto.Text) + " '")
            Lector.Read()

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
            MConexion.Desconectar()
        Else
            MsgBox("::::::::NO EXISTE EL PRODUCTO-ALMACEN:::::::::::")
        End If
        'MConexion.Desconectar()
    End Sub



    Public Sub LimpiarTextBox()
        tf_producto.Text = ""
        tf_almacen.Text = ""
        tf_nombrePro.Text = ""
        tf_nombreAlm.Text = ""
        tf_cantidad.Text = ""
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES









    Dim P As New cls_PRODUCTO
    Dim A As New cls_ALMACEN
    Dim PA As New cls_PRODUCTO_ALMACEN
    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_producto.Text) = True) And (EsNumero(tf_almacen.Text) = True)) Then
            If (existe((tf_producto.Text), (tf_almacen.Text)) = False) Then
                PA.PRODUCTO_ID = CInt(tf_producto.Text)
                PA.ALMACEN_ID = CInt(tf_almacen.Text)
                PA.FECHA = Date.Parse(tf_fecha.Text)
                PA.CANTIDAD = CInt(tf_cantidad.Text)

                MConexion.Conectar()
                PA.Guardar()
                MConexion.Desconectar()
                MsgBox("SE GUARDO EL PRODUCTO-ALMACEN")
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL PRODUCTO-ALMACEN")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, PRODUCTO, ALMACEN, CANTIDAD DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click

        If ((tf_producto.Text <> "") And (tf_almacen.Text <> "")) Then
            If (EsNumero(tf_producto.Text) And EsNumero(tf_almacen.Text)) Then
                buscar(CInt(tf_producto.Text), CInt(tf_almacen.Text))
            Else
                MsgBox("INGRESE ID DE PRODUCTO,ALMACEN DE TIPO NUMERICO")
            End If
        Else
            MsgBox("INGRESE ID DE PRODUCTO Y ALMACEN A BUSCAR")
        End If
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_almacen.Text) = True) And (EsNumero(tf_producto.Text) = True)) Then
            If (existe((tf_producto.Text), (tf_almacen.Text)) = True) Then
                PA.PRODUCTO_ID = CInt(tf_producto.Text)
                PA.ALMACEN_ID = CInt(tf_almacen.Text)
                PA.FECHA = Date.Parse(tf_fecha.Text)
                PA.CANTIDAD = CInt(tf_cantidad.Text)

                MConexion.Conectar()
                PA.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL PRODUCTO-ALMACEN")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, PRODUCTO, ALMACEN, CANTIDAD DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_almacen.Text) = True) And (EsNumero(tf_producto.Text) = True)) Then
            If (existe((tf_producto.Text), (tf_almacen.Text)) = True) Then
                eliminar(tf_producto.Text, tf_almacen.Text)
                MsgBox("ELIMINACION EXITOSA DEL PRODUCTO-ALMACEN")
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL PRODUCTO-ALMACEN")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, PRODUCTO, ALMACEN, CANTIDAD DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarProductoAlmacen", "tbl_PRODUCTO_ALMACEN")
        MConexion.Desconectar()
    End Sub

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub frm_productoCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_almacen, "Proc_ListarAlmacen")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_nombreAlm, "Proc_ListarAlmacenPorNombre")
        MConexion.Desconectar()

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_nombrePro, "Proc_ListarProductoPorNombre")
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

    Private Sub tf_nuevaCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_almacen.Click
        Dim c As New frm_Almacen
        c.MdiParent = MDForm
        c.Show()
    End Sub

    Private Sub tf_producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_producto.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProductoSoloNombre '    " + (tf_producto.Text) + " '")

        If (Lector.HasRows() = True) Then
            Lector.Read()
            tf_nombrePro.Text = Lector(0)
        Else
            MsgBox("::::::::NO EXISTE EL PRODUCTO:::::::::::")
        End If
        MConexion.Desconectar()
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

    Private Sub tf_almacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_almacen.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarAlmacen '    " + (tf_almacen.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_nombreAlm.Text = Lector(0)
        Else
            MsgBox(" NO EXISTE LA ALMACEN A BUSCAR")
        End If
        MConexion.Desconectar()
    End Sub

    '' CHECKBOX EVENTOS DE CLIK EN LOS CHECKBOX
    Private Sub ch_bebida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_bebida.CheckedChanged
        If (ch_bebida.Checked = True) Then
            ch_pollo.Checked = False
            ch_porcion.Checked = False
            ch_res.Checked = False

            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            'LISTA EN TF_PRODUCTO LOS codigos PRODUCTO DE TIPO BEBIDA
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProductoTipoBebida")
            MConexion.Desconectar()
        Else ''CASO CONTRARIO LISTA TODOS LOS TIPO DE PRODUCTOS
            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub ch_solido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_pollo.CheckedChanged
        If (ch_pollo.Checked = True) Then
            ch_bebida.Checked = False
            ch_porcion.Checked = False
            ch_res.Checked = False

            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            'LISTA EN TF_PRODUCTO LOS codigos PRODUCTO DE TIPO POLLO
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProductoTipoPollo")
            MConexion.Desconectar()
        Else ''CASO CONTRARIO LISTA TODOS LOS TIPO DE PRODUCTOS
            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub ch_porcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_porcion.CheckedChanged
        If (ch_porcion.Checked = True) Then
            ch_bebida.Checked = False
            ch_pollo.Checked = False
            ch_res.Checked = False

            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            'LISTA EN TF_PRODUCTO LOS codigos PRODUCTO DE TIPO PORCION
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProductoTipoPorcion")
            MConexion.Desconectar()
        Else ''CASO CONTRARIO LISTA TODOS LOS TIPO DE PRODUCTOS
            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
            MConexion.Desconectar()
        End If
    End Sub
    Private Sub ch_res_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_res.CheckedChanged
        If (ch_res.Checked = True) Then
            ch_bebida.Checked = False
            ch_pollo.Checked = False
            ch_porcion.Checked = False

            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            'LISTA EN TF_PRODUCTO LOS codigos PRODUCTO DE TIPO RES
            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProductoTipoRes")
            MConexion.Desconectar()
        Else ''CASO CONTRARIO LISTA TODOS LOS TIPO DE PRODUCTOS
            'LIMPIA EL EDIT CI (refresh)
            tf_producto.Items.Clear()

            MConexion.Conectar()
            M_Generico.CargarCombo(tf_producto, "Proc_ListarProducto")
            MConexion.Desconectar()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tf_cantidad.Text = (Date.Parse(tf_fecha.Text))
    End Sub
End Class