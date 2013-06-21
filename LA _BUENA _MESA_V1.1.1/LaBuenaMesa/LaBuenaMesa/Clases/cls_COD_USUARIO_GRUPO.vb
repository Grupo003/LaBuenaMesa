Imports System.Data.SqlClient
Public Class cls_COD_USUARIO_GRUPO

    Private int_COD As Integer
    Private int_NRO As Integer


    Public Property COD() As Integer
        Get
            Return int_COD
        End Get
        Set(ByVal Value As Integer)
            int_COD = Value
        End Set
    End Property
    Public Property NRO() As Integer
        Get
            Return int_NRO
        End Get
        Set(ByVal Value As Integer)
            int_NRO = Value
        End Set
    End Property


    Public Sub Guardar()
        MConexion.EjecutarProcedimiento("Proc_tbl_COD_USUARIO_GRUPOGUARDAR " + COD.ToString + "," + NRO.ToString)
    End Sub


    Public Sub Modificar()
        MConexion.EjecutarProcedimiento("Proc_tbl_COD_USUARIO_GRUPOMODIFICAR " + COD.ToString + "," + NRO.ToString)
    End Sub


    Public Sub Eliminar()
        MConexion.EjecutarProcedimiento("Proc_tbl_COD_USUARIO_GRUPOELIMINAR " + COD.ToString)
    End Sub


    Public Sub CargarDatos()
        Dim Lector As sqldatareader
        Lector = MConexion.EjecutarConsulta("Proc_tbl_COD_USUARIO_GRUPOLISTAR " + COD.ToString)
        Lector.Read()
        COD = CInt(Lector.Item("COD"))
        NRO = CInt(Lector.Item("NRO"))
        Lector.Close()
    End Sub

End Class
