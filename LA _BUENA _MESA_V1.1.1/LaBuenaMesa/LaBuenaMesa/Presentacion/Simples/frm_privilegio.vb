Imports System.Data.SqlClient

Public Class frm_privilegio

    Private Sub frm_privilegio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_grupo, "Proc_ListarGrupo")
        MConexion.Desconectar()

        'SELECIONA LOS FORMULARIO QUE EXISTE DE LA TABLA FORMULARIO DE LA BDS 
        MConexion.Conectar()
        M_Generico.CargarCombo(tf_form_bandera, "Proc_ListarFormularioPorNombre")
        MConexion.Desconectar()

        'MUSTRA EN EL LISTBOX1 LOS FORMULARIO DE LA TABLA FORM DE LA BDS
        'lb_formulario.Items.Clear()
        'For i As Integer = 0 To tf_form_bandera.Items.Count - 1
        'lb_formulario.Items.Add(tf_form_bandera.Items(i))
        'Next

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

    Private Sub bt_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoEnPrivilegio '    " + (tf_grupo.Text) + " '")

        If (tf_grupo.Text <> "") Then
            If (Lector.HasRows()) Then
                MsgBox("YA EXISTE EL PRIVILEGIO DEL GRUPO EN LA BDs")
            Else
                Dim p As New cls_PRIVILEGIO
                MConexion.Conectar()
                If (ch_guardar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (1)
                    p.Guardar()
                End If
                If (ch_limpiar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (2)
                    p.Guardar()
                End If
                If (ch_buscar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (3)
                    p.Guardar()
                End If
                If (ch_modificar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (4)
                    p.Guardar()
                End If
                If (ch_eliminar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (5)
                    p.Guardar()
                End If
                If (ch_mostrar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (6)
                    p.Guardar()
                End If
                MConexion.Desconectar()
            End If
        Else
            MsgBox("SELECCIONAR  GRUPO")
        End If
        MConexion.Desconectar()

    End Sub

    Private Sub bt_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_buscar.Click
        ''PONE AL LIST BOX NOMBRE EL ADECUADO DE LA TABLA GRUPO
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


        'HACE LAS COMBINACIONES DE PARA BUSCAR EN LOS CHECK 
        'Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoEnPrivilegio '    " + (tf_grupo.Text) + " '")

        If (tf_grupo.Text <> "") Then
            If (Lector.HasRows()) Then
                MConexion.Desconectar()

                LimpiarChechBox()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon1 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_guardar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon2 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_limpiar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon3 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_buscar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon4 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_modificar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon5 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_eliminar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon6 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_mostrar.Checked = True
                End If
                MConexion.Desconectar()
            Else
                MsgBox(":::::: NO EXISTE EL GRUPO QUE SELECIONO")
            End If
        Else
            MsgBox("::::::  SELECCIONAR  GRUPO A BUSCAR  :::::")
        End If

    End Sub

    Private Sub bt_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_modificar.Click
        Dim p As New cls_PRIVILEGIO
        Dim pr As New cls_PRIVILEGIO
        Dim Lector As SqlDataReader

        MConexion.Conectar()

        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoEnPrivilegio '    " + (tf_grupo.Text) + " '")

        If (tf_grupo.Text <> "") Then
            If (Lector.HasRows()) Then
                Lector.Read()

                pr.GRUPO_ID = CInt(tf_grupo.Text)
                MConexion.Conectar()
                pr.Eliminar()
                MConexion.Desconectar()

                MConexion.Conectar()

                If (ch_guardar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (1)
                    p.Guardar()
                End If
                If (ch_limpiar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (2)
                    p.Guardar()
                End If
                If (ch_buscar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (3)
                    p.Guardar()
                End If
                If (ch_modificar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (4)
                    p.Guardar()
                End If
                If (ch_eliminar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (5)
                    p.Guardar()
                End If
                If (ch_mostrar.Checked = True) Then
                    p.GRUPO_ID = CInt(tf_grupo.Text)
                    p.PERMISO_ID = (6)
                    p.Guardar()
                End If
                MConexion.Desconectar()
                MsgBox("::::::  DATOS MODIFICADOS EXITOSAMENTE  :::::")
            Else
                MsgBox("::::::  NO EXISTE GRUPO PARA MODIFICAR  :::::")
            End If
        Else
            MsgBox("::::::  SELECCIONAR  GRUPO A MODIFICAR  :::::")
        End If
    End Sub
    Private Sub bt_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_eliminar.Click
        Dim pr As New cls_PRIVILEGIO
        Dim Lector As SqlDataReader

        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoEnPrivilegio '     " + (tf_grupo.Text) + "  '")

        If (tf_grupo.Text <> "") Then
            If (Lector.HasRows()) Then
                Lector.Read()
                pr.GRUPO_ID = CInt(tf_grupo.Text)
                MConexion.Conectar()
                pr.Eliminar()
                MConexion.Desconectar()
                MsgBox(":::::: ELIMINADO SATIFACTORIAMENTE EL GRUPO :::::::")
            Else
                MsgBox(":::::: NO EXISTE EL GRUPO A SELECIONADO :::::::")
            End If
        Else
            MsgBox(":::::: SELECIONE GRUPO A ELIMINAR :::::::")
        End If

    End Sub

    Private Sub bt_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mostrar.Click
        MConexion.Conectar()
        M_Generico.CargarGrid(dg_mostrar, "Proc_MostrarPrivilegio", "tbl_PRIVILEGIO")
        MConexion.Desconectar()
    End Sub

    Private Sub tf_grupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tf_grupo.SelectedIndexChanged
        ''PONE AL LIST BOX NOMBRE EL ADECUADO DE LA TABLA GRUPO
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


        'HACE LAS COMBINACIONES DE PARA BUSCAR EN LOS CHECK 
        'Dim Lector As SqlDataReader
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoEnPrivilegio '    " + (tf_grupo.Text) + " '")

        If (tf_grupo.Text <> "") Then
            If (Lector.HasRows()) Then
                MConexion.Desconectar()

                LimpiarChechBox()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon1 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_guardar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon2 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_limpiar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon3 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_buscar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon4 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_modificar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon5 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_eliminar.Checked = True
                End If
                MConexion.Desconectar()

                MConexion.Conectar()
                Lector = MConexion.EjecutarConsulta("Proc_ExisteGrupoCon6 '    " + (tf_grupo.Text) + " '")
                If (Lector.HasRows()) Then
                    ch_mostrar.Checked = True
                End If
                MConexion.Desconectar()
            Else
                MsgBox(":::::: NO EXISTE EL GRUPO QUE SELECIONO")
            End If
        Else
            MsgBox("::::::  SELECCIONAR  GRUPO A BUSCAR  :::::")
        End If
    End Sub

    
End Class