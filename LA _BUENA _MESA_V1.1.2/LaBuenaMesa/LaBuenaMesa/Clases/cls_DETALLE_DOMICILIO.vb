Imports System.Data.SqlClient
Public Class cls_DETALLE_DOMICILIO

    Private int_PEDIDO_DOMICILIO_ID As Integer
    Private int_MOTISTA_ID As Integer
    Private str_ESTADO As String

    Public Property PEDIDO_DOMICILIO_ID() As Integer
        Get
            Return int_PEDIDO_DOMICILIO_ID
        End Get
        Set(ByVal Value As Integer)
            int_PEDIDO_DOMICILIO_ID = Value
        End Set
    End Property

    Public Property MOTISTA_ID() As Integer
        Get
            Return int_MOTISTA_ID
        End Get
        Set(ByVal Value As Integer)
            int_MOTISTA_ID = Value
        End Set
    End Property

    Public Property ESTADO() As String
        Get
            Return Str_ESTADO
        End Get
        Set(ByVal Value As String)
            Str_ESTADO = Value
        End Set
    End Property

    Public Sub Guardar()
        MConexion.EjecutarProcedimiento("Proc_tbl_DETALLE_DOMICILIOGUARDAR " + PEDIDO_DOMICILIO_ID.ToString + "," + MOTISTA_ID.ToString + "," + "[" + ESTADO + "]")
    End Sub


    Public Sub Modificar()
        MConexion.EjecutarProcedimiento("Proc_tbl_DETALLE_DOMICILIOMODIFICAR " + PEDIDO_DOMICILIO_ID.ToString + "," + MOTISTA_ID.ToString)
    End Sub


    Public Sub Eliminar()
        MConexion.EjecutarProcedimiento("Proc_tbl_DETALLE_DOMICILIOELIMINAR " + PEDIDO_DOMICILIO_ID.ToString)
    End Sub


    Public Sub CargarDatos()
        Dim Lector As sqldatareader
        Lector = MConexion.EjecutarConsulta("Proc_tbl_DETALLE_PEDIDOLISTAR " + PEDIDO_DOMICILIO_ID.ToString)
        Lector.Read()
        PEDIDO_DOMICILIO_ID = CInt(Lector.Item("PEDIDO_DOMICILIO_ID"))
        MOTISTA_ID = CInt(Lector.Item("MOTISTA_ID"))
        ESTADO = Lector.Item("ESTADO")
        Lector.Close()
    End Sub

End Class

