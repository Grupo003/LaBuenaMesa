 Imports System.Data.SqlClient 
 
Public Class cls_RESERVA
    Private int_RESERVA_ID As Integer
    Private str_DESCRIPCION As String
    Private str_FECHA_INICIO As String
    Private str_FECHA_FIN As String
    Private str_SECTOR As String
    Private int_CLIENTE_ID As Integer
    Private int_MESA_ID As Integer
    Private int_HORA As Integer
    Private int_MINUTO As Integer


    Public Property RESERVA_ID() As Integer
        Get
            Return int_RESERVA_ID
        End Get
        Set(ByVal Value As Integer)
            int_RESERVA_ID = Value
        End Set
    End Property
    Public Property DESCRIPCION() As String
        Get
            Return Str_DESCRIPCION
        End Get
        Set(ByVal Value As String)
            Str_DESCRIPCION = Value
        End Set
    End Property
    Public Property FECHA_INICIO() As String
        Get
            Return Str_FECHA_INICIO
        End Get
        Set(ByVal Value As String)
            Str_FECHA_INICIO = Value
        End Set
    End Property
    Public Property FECHA_FIN() As String
        Get
            Return Str_FECHA_FIN
        End Get
        Set(ByVal Value As String)
            Str_FECHA_FIN = Value
        End Set
    End Property
    Public Property SECTOR() As String
        Get
            Return Str_SECTOR
        End Get
        Set(ByVal Value As String)
            Str_SECTOR = Value
        End Set
    End Property
    Public Property CLIENTE_ID() As Integer
        Get
            Return int_CLIENTE_ID
        End Get
        Set(ByVal Value As Integer)
            int_CLIENTE_ID = Value
        End Set
    End Property
    Public Property MESA_ID() As Integer
        Get
            Return int_MESA_ID
        End Get
        Set(ByVal Value As Integer)
            int_MESA_ID = Value
        End Set
    End Property
    Public Property HORA() As Integer
        Get
            Return int_HORA
        End Get
        Set(ByVal Value As Integer)
            int_HORA = Value
        End Set
    End Property
    Public Property MINUTO() As Integer
        Get
            Return int_MINUTO
        End Get
        Set(ByVal Value As Integer)
            int_MINUTO = Value
        End Set
    End Property


    Public Sub Guardar()
        MConexion.EjecutarProcedimiento("Proc_tbl_RESERVAGUARDAR " + RESERVA_ID.ToString + "," + "[" + DESCRIPCION + "]" + "," + "[" + FECHA_INICIO + "]" + "," + "[" + FECHA_FIN + "]" + "," + "[" + SECTOR + "]" + "," + CLIENTE_ID.ToString + "," + MESA_ID.ToString + "," + HORA.ToString + "," + MINUTO.ToString)
    End Sub


    Public Sub Modificar()
        MConexion.EjecutarProcedimiento("Proc_tbl_RESERVAMODIFICAR " + RESERVA_ID.ToString + "," + "[" + DESCRIPCION + "]" + "," + "[" + FECHA_INICIO + "]" + "," + "[" + FECHA_FIN + "]" + "," + "[" + SECTOR + "]" + "," + CLIENTE_ID.ToString + "," + MESA_ID.ToString + "," + HORA.ToString + "," + MINUTO.ToString)
    End Sub


    Public Sub Eliminar()
        MConexion.EjecutarProcedimiento("Proc_tbl_RESERVAELIMINAR " + RESERVA_ID.ToString)
    End Sub


    Public Sub CargarDatos()
        Dim Lector As sqldatareader
        Lector = MConexion.EjecutarConsulta("Proc_tbl_RESERVALISTAR " + RESERVA_ID.ToString)
        Lector.Read()
        RESERVA_ID = CInt(Lector.Item("RESERVA_ID"))
        DESCRIPCION = Lector.Item("DESCRIPCION")
        FECHA_INICIO = Lector.Item("FECHA_INICIO")
        FECHA_FIN = Lector.Item("FECHA_FIN")
        SECTOR = Lector.Item("SECTOR")
        CLIENTE_ID = CInt(Lector.Item("CLIENTE_ID"))
        MESA_ID = CInt(Lector.Item("MESA_ID"))
        HORA = CInt(Lector.Item("HORA"))
        MINUTO = CInt(Lector.Item("MINUTO"))
        Lector.Close()
    End Sub
End Class
