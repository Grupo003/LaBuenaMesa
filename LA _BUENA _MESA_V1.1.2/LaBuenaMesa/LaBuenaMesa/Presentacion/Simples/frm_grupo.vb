Imports System.Data.SqlClient
Public Class frm_grupo
    ''::::::::::::::::::METODOS Y FUNCIONES
    Public Function EsNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function tieneDatos() As Boolean
        If ((tf_grupo.Text <> "") And (tf_nombre.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function existe(ByVal Cad As String) As Boolean
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarGrupo'    " + (Cad) + " '")
        If (Lector.HasRows()) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub LimpiarListBox()
        tf_grupo.Text = ""
        tf_nombre.Text = ""
    End Sub
    ''::::::::::::::::::HASTA AQUI METODOS Y FUNCIONES






    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        If ((tieneDatos() = True) And (EsNumero(tf_grupo.Text) = True)) Then
            If (existe(tf_grupo.Text) = False) Then
                Dim g As New cls_GRUPO
                g.GRUPO_ID = CInt(tf_grupo.Text)
                g.NOMBRE = tf_nombre.Text
                MConexion.Conectar()
                g.Guardar()
                MConexion.Desconectar()
            Else
                MsgBox("NO SE PUEDE GUARDAR, YA EXISTE EL GRUPO")
            End If
        Else
            MsgBox("RELLENAR CASILLAS, CI DE TIPO NUMERICO")
        End If

    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarGrupo'    " + (tf_grupo.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_nombre.Text = Lector(0)
        Else
            MsgBox("::::::::NO EXISTE EL GRUPO:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        If ((tf_grupo.Text <> "") And (EsNumero(tf_grupo.Text) = True)) Then
            If ((existe(tf_grupo.Text) = True) And (tieneDatos() = True)) Then
                Dim g As New cls_GRUPO
                g.GRUPO_ID = CInt(tf_grupo.Text)
                g.NOMBRE = tf_nombre.Text
                MConexion.Conectar()
                g.Modificar()
                MConexion.Desconectar()
                MsgBox("MODIFICACION ACTUALIZADA EN LA BASE DE DATOS")
            Else
                MsgBox("NO SE PUEDE MODIFICAR, NO EXISTE EL GRUPO")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If

    End Sub

    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        If ((tf_grupo.Text <> "") And (EsNumero(tf_grupo.Text) = True)) Then
            If ((existe(tf_grupo.Text) = True) And (tieneDatos() = True)) Then
                Dim g As New cls_GRUPO
                g.GRUPO_ID = CInt(tf_grupo.Text)
                MConexion.Conectar()
                g.Eliminar()
                MConexion.Desconectar()
                MsgBox("USUARIO ELIMINADO")
            Else
                MsgBox("NO SE PUEDE ELIMINAR, NO EXISTE EL GRUPO")
            End If
        Else
            MsgBox("RELLENAR CI, TIPO NUMERICO")
        End If
    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarGrupo", "tbl_GRUPO")
        MConexion.Desconectar()
    End Sub

    Private Sub tf_tipoAdm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_grupo.SelectedIndexChanged
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_BuscarGrupo '    " + (tf_grupo.Text) + " '")

        If (Lector.HasRows()) Then
            Lector.Read()
            tf_nombre.Text = Lector(0)
        Else
            MsgBox("::::::::NO EXISTE EL GRUPO:::::::::::")
        End If
        MConexion.Desconectar()
    End Sub

    Private Sub frm_tipoAdm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_grupo, "Proc_ListarGrupo")
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

    Private Sub bt_atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_atras.Click
        Close()
    End Sub

    Private Sub bt_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_limpiar.Click
        LimpiarListBox()
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

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
End Class