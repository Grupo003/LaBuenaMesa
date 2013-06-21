Imports System.Data.SqlClient
Public Class frm_mesa
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_mesa.Text <> "") And (tf_decripcion.Text <> "") And (tf_estado.Text <> "") And (tf_sector.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMesa '    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub LimpiarTextBox()
        tf_mesa.Text = ""
        tf_decripcion.Text = ""
        tf_estado.Text = ""
        tf_sector.Text = ""
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES








    Private Sub frm_mesa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'METODO PARA ACTUALIZAR EL ESTADO DE LA MESA CUANDO CUMPLA EL TIEMPO DE LA RESERVA
        actualizarEstadoMesa()

        tf_estado.Text = "LIBRE"

        If (existe(1)) Then
            MConexion.Conectar()
            M_Generico.CargarText((tf_auxiliar), "Proc_SiguienteMesa")
            MConexion.Desconectar()
            tf_mesa.Text = (CInt(tf_auxiliar.Text))
            tf_auxiliar.Text = ""
        Else
            tf_mesa.Text = 1
        End If

        MConexion.Conectar()
        M_Generico.CargarCombo(tf_mesa, "Proc_ListarMesa")
        MConexion.Desconectar()
    End Sub

    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim c As New cls_MESA

        If ((tieneDatos() = True) And (EsNumero(tf_mesa.Text) = True)) Then
            If (existe(tf_mesa.Text) = False) Then
                c.MESA_ID = CInt(tf_mesa.Text)
                c.ESTADO = tf_estado.Text
                c.SECTOR = tf_sector.Text
                c.DESCRIPCION = tf_decripcion.Text

                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()

                'LIMPIA EL EDIT CI (refresh)
                tf_mesa.Items.Clear()

                'LISTA ACTUALIZADA DE PRODUCTOS HABILITADO EN EDIT TF_PRODUCTO
                MConexion.Conectar()
                M_Generico.CargarCombo(tf_mesa, "Proc_ListarMesa")
                MConexion.Desconectar()
                MsgBox("SE GUARDO EXITOSAMENTE EL MESA")
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL MESA")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, MESA DE TIPO NUMERICO")
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

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarMesa", "tbl_MESA")
        MConexion.Desconectar()
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextBox()

    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        If (tf_mesa.Text = "") Then
            MsgBox("RELLENAR MESA A BUSCAR")
            Return
        End If

        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMesa '    " + (tf_mesa.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_decripcion.Text = Lector(0)
            tf_estado.Text = Lector(1)
            tf_sector.Text = Lector(2)
        Else
            MsgBox(" NO EXISTE EL MESA A BUSCAR")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub tf_mesa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_mesa.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMesa '    " + (tf_mesa.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_decripcion.Text = Lector(0)
            tf_estado.Text = Lector(1)
            tf_sector.Text = Lector(2)
        Else
            MsgBox(" NO EXISTE EL MESA A BUSCAR")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        Dim a As New cls_MESA
        If ((tieneDatos() = True) And (EsNumero(tf_mesa.Text) = True)) Then
            If ((existe(tf_mesa.Text) = True) And (tieneDatos() = True)) Then
                a.MESA_ID = CInt(tf_mesa.Text)
                a.DESCRIPCION = tf_decripcion.Text
                a.SECTOR = tf_sector.Text
                a.ESTADO = tf_estado.Text

                MConexion.Conectar()
                a.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE LA MESA")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If
    End Sub


End Class