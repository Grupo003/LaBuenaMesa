Imports System.Data.SqlClient
Imports ProyectoSI.Metodos

Public Class frm_reserva
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_reserva.Text <> "") And (tf_descripcionReserva.Text <> "") And (tf_sector.Text <> "") And (tf_mesa.Text <> "") And (tf_cliente.Text <> "") And (tf_horaIncio.Text <> "") And (tf_minutoInicio.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function sonNumeros() As Boolean
        If (EsNumero(tf_reserva.Text) And EsNumero(tf_mesa.Text) And EsNumero(tf_cliente.Text) And EsNumero(tf_horaIncio.Text) And EsNumero(tf_minutoInicio.Text)) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarReserva '    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function horaValida() As Boolean
        If (tf_horaIncio.Text >= 0 And tf_horaIncio.Text <= 23) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function minutoValido() As Boolean
        If (tf_horaIncio.Text >= 0 And tf_horaIncio.Text <= 59) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existeReserva(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarReserva'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub LimpiarTextList()
        tf_reserva.Text() = ""
        tf_descripcionReserva.Text() = ""
        tf_descripcionMesa.Text() = ""
        tf_horaIncio.Text() = ""
        tf_minutoInicio.Text() = ""
        tf_mesa.Text() = ""
        tf_cliente.Text() = ""
        tf_estado.Text() = ""
        tf_sector.Text() = ""
        tf_nombreCliente.Text() = ""
    End Sub
    Public Sub buscar(ByVal b As String)
        If ((tf_reserva.Text <> "") And (EsNumero(tf_reserva.Text) = True)) Then
            If (existe(tf_reserva.Text) = False) Then
                MsgBox("NO EXISTE LA RESERVA A BUSCAR")
                Return
            End If

            Dim Lector As SqlDataReader
            MConexion.Conectar()
            Lector = MConexion.EjecutarConsulta("Proc_BuscarReserva'    " + (tf_reserva.Text) + " '")

            Lector.Read()
            tf_descripcionReserva.Text = (Lector(0))
            tf_fechaInicio.Text = Lector(1)
            tf_fechaFin.Text = Lector(2)
            tf_mesa.Text = Lector(4)
            tf_cliente.Text = Lector(5)
            tf_horaIncio.Text = Lector(6)
            tf_minutoInicio.Text = Lector(7)
            MConexion.Desconectar()
        Else
            MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
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

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub frm_reserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'METODO PARA ACTUALIZAR EL ESTADO DE LA MESA CUANDO CUMPLA EL TIEMPO DE LA RESERVA
        actualizarEstadoMesa()


        'SIGUIENTE RESERVA QUE TOCA AUTOMATICAMENTE
        If (existe(1)) Then
            MConexion.Conectar()
            M_Generico.CargarText((tf_auxiliar), "Proc_SiguienteReserva")
            MConexion.Desconectar()
            tf_reserva.Text = (CInt(tf_auxiliar.Text))
            tf_auxiliar.Text = ""
        Else
            tf_reserva.Text = 1
        End If


        'LISTA LAS MESA QUE TIENE EL ESTADO LIBRE
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_mesa, "Proc_ListarMesaLibre")
        MConexion.Desconectar()

        'LISTA LOS CLIENTE
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_cliente, "Proc_ListarCliente")
        MConexion.Desconectar()

        'LISTA LAS MESA QUE TIENE EL ESTADO LIBRE
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_reserva, "Proc_ListarReserva")
        MConexion.Desconectar()
    End Sub

    Private Sub tf_mesa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_mesa.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarMesa '    " + (tf_mesa.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_descripcionMesa.Text = Lector(0)
            tf_estado.Text = Lector(1)
            tf_sector.Text = Lector(2)
        Else
            MsgBox(" NO EXISTE EL MESA A BUSCAR")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_cliente.SelectedIndexChanged
        Dim Lector As SqlDataReader

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_TBuscarCliente '    " + (tf_cliente.Text) + " '")
        Lector.Read()

        tf_nombreCliente.Text = Lector(0)

        MConexion.Desconectar()
    End Sub

    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        If ((tieneDatos() = True) And (sonNumeros() = True)) Then
            If (horaValida() = True And minutoValido() = True) Then
                If (existeReserva(tf_reserva.Text) = True) Then
                    MsgBox("NO SE PUEDE GUARDAR RESERVA CON EL MISMO ID")
                    Return
                End If
                Dim c As New cls_RESERVA

                c.RESERVA_ID = CInt(tf_reserva.Text)
                c.DESCRIPCION = tf_descripcionReserva.Text
                c.FECHA_INICIO = Date.Parse(tf_fechaInicio.Text)
                c.FECHA_FIN = Date.Parse(tf_fechaFin.Text)
                c.SECTOR = tf_sector.Text
                c.MESA_ID = CInt(tf_mesa.Text)
                c.CLIENTE_ID = CInt(tf_cliente.Text)
                c.HORA = CInt(tf_horaIncio.Text)
                c.MINUTO = CInt(tf_minutoInicio.Text)

                MConexion.Conectar()
                c.Guardar()
                MConexion.Desconectar()

                MsgBox("SE GUARDAR EXITOSAMENTE LA RESERVA")

                'LIMPIA EL EDIT (refresh)
                tf_reserva.Items.Clear()

                'LISTA ACTUALIZADA DE reservas  EN EDIT TF_RESERVAS
                MConexion.Conectar()
                M_Generico.CargarCombo(tf_reserva, "Proc_ListarReserva")
                MConexion.Desconectar()

                'LIMPIA EL EDIT MESA (refresh)
                tf_mesa.Items.Clear()

                'LISTA ACTUALIZADA DE PRODUCTOS HABILITADO EN EDIT TF_PRODUCTO
                MConexion.Conectar()
                M_Generico.CargarCombo(tf_mesa, "Proc_ListarMesaLibre")
                MConexion.Desconectar()

            Else
                MsgBox("HORA-MINUTO FUERA DE RANGO")
            End If
        Else
            MsgBox("VERIFICAR DATOS DE TIPO NUMERO")
        End If
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarTextList()
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        If (ch_vigente.Checked = True) Then
            MConexion.Conectar()
            M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarReservaVigente", "tbl_RESERVA")
            MConexion.Desconectar()
        Else
            If (ch_vencida.Checked = True) Then
                MConexion.Conectar()
                M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarReservaVencida", "tbl_RESERVA")
                MConexion.Desconectar()
            Else
                If (ch_realizada.Checked = True) Then
                    MConexion.Conectar()
                    M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarReservaRealizada", "tbl_RESERVA")
                    MConexion.Desconectar()
                Else
                    MConexion.Conectar()
                    M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarReserva", "tbl_RESERVA")
                    MConexion.Desconectar()
                End If
            End If
        End If
        
    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        buscar(tf_reserva.Text)
    End Sub

    Private Sub tf_reserva_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_reserva.SelectedIndexChanged
        buscar(tf_reserva.Text)
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tieneDatos() = True) And (sonNumeros() = True)) Then
            If (horaValida() = True And minutoValido() = True) Then
                Dim c As New cls_RESERVA

                c.RESERVA_ID = CInt(tf_reserva.Text)
                c.DESCRIPCION = tf_descripcionReserva.Text
                c.FECHA_INICIO = Date.Parse(tf_fechaInicio.Text)
                c.FECHA_FIN = Date.Parse(tf_fechaFin.Text)
                c.SECTOR = tf_sector.Text
                c.MESA_ID = CInt(tf_mesa.Text)
                c.CLIENTE_ID = CInt(tf_cliente.Text)
                c.HORA = CInt(tf_horaIncio.Text)
                c.MINUTO = CInt(tf_minutoInicio.Text)

                MConexion.Conectar()
                c.Modificar()
                MConexion.Desconectar()

                MsgBox("SE MODIFICO EXITOSAMENTE LA RESERVA")
            Else
                MsgBox("HORA-MINUTO FUERA DE RANGO")
            End If
        Else
            MsgBox("VERIFICAR DATOS DE TIPO NUMERO")
        End If
    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        Dim a As New cls_RESERVA
        If (tf_reserva.Text <> "" And (EsNumero(tf_reserva.Text) = True)) Then
            If (existe(tf_reserva.Text) = True) Then
                a.RESERVA_ID = CInt(tf_reserva.Text)
                MConexion.Conectar()
                a.Eliminar()
                MConexion.Desconectar()
                MsgBox("RESERVA ELIMINADA DE LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE ELIMINAR LA RESERVA, NO EXISTE")
            End If
        Else
            MsgBox("RELLENAR RESERVA_ID DE TIPO NUMERICO")
        End If
    End Sub

    Private Sub ch_vigente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_vigente.CheckedChanged
        If (ch_vigente.Checked = True) Then
            ch_vencida.Checked = False
            ch_realizada.Checked = False
        End If
    End Sub

    Private Sub ch_vencida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_vencida.CheckedChanged
        If (ch_vencida.Checked = True) Then
            ch_vigente.Checked = False
            ch_realizada.Checked = False
        End If
    End Sub

    Private Sub ch_realizada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ch_realizada.CheckedChanged
        If (ch_realizada.Checked = True) Then
            ch_vencida.Checked = False
            ch_vigente.Checked = False
        End If
    End Sub

    
End Class