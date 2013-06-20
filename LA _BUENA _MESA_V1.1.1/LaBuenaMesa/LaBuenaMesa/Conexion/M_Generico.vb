Imports System.Data.SqlClient

Module M_Generico

    Public Sub CargarGrid(ByVal Grid As DataGridView, ByVal consulta As String, ByVal tabla As String)
        Dim datosTabla As DataSet = New DataSet
        Dim adaptador As SqlDataAdapter
        Try
            adaptador = New SqlDataAdapter(consulta, MConexion.DevolverConexion)
            adaptador.Fill(datosTabla, tabla)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        'hasta aqui se ha llenado un contenedor con datos

        Grid.DataSource = datosTabla.Tables(tabla).DefaultView
        'con esto se trae todo lo del contenedor para llenar el grid
        adaptador.Dispose()
    End Sub
    Public Sub CargarCombo(ByVal combo As ComboBox, ByVal Consulta As String)
        Dim Lector As SqlDataReader
        Lector = MConexion.EjecutarConsulta(Consulta)
        While Lector.Read
            combo.Items.Add(Lector(0))
        End While
        Lector.Close()
    End Sub
    Public Sub CargarList(ByVal lista As ListBox, ByVal consulta As String)
        Dim Lector As SqlDataReader
        Lector = MConexion.EjecutarConsulta(consulta)
        While Lector.Read
            lista.Items.Add(Trim(Lector.Item(0)))
        End While
        Lector.Close()
    End Sub
    Public Sub CargarText(ByVal text As TextBox, ByVal consulta As String)
        Dim Lector As SqlDataReader
        Lector = MConexion.EjecutarConsulta(consulta)
        Lector.Read()
        text.Text = CStr(Lector(0))
        Lector.Close()
    End Sub

    Public Sub CargarLabel(ByVal text As Label, ByVal consulta As String)
        Dim Lector As SqlDataReader
        Lector = MConexion.EjecutarConsulta(consulta)
        Lector.Read()
        If (Lector.HasRows) Then
            text.Text = CStr(Lector(0))
        Else

            text.Text = ""
        End If
        Lector.Close()
    End Sub

End Module
