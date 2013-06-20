 Imports System.Data.SqlClient 
 
Public Class cls_PEDIDO
 
 
Private int_PEDIDO_ID as Integer
Private int_CLIENTE_ID as Integer
Private int_MESERO_ID as Integer
Private int_RECEPCIONISTA_ID as Integer
Private int_MOTISTA_ID as Integer
    Private str_TIPO_PEDIDO As String
    Private int_MESA_ID As Integer
    Private str_ESTADO As String
Private date_FECHA as Date 
    Private dbl_MONTO_TOTAL As Double

 
 
Public Property PEDIDO_ID() as Integer
Get
Return int_PEDIDO_ID
End Get
Set(ByVal Value as Integer)
int_PEDIDO_ID = Value
End Set
End Property
Public Property CLIENTE_ID() as Integer
Get
Return int_CLIENTE_ID
End Get
Set(ByVal Value as Integer)
int_CLIENTE_ID = Value
End Set
End Property
Public Property MESERO_ID() as Integer
Get
Return int_MESERO_ID
End Get
Set(ByVal Value as Integer)
int_MESERO_ID = Value
End Set
End Property
Public Property RECEPCIONISTA_ID() as Integer
Get
Return int_RECEPCIONISTA_ID
End Get
Set(ByVal Value as Integer)
int_RECEPCIONISTA_ID = Value
End Set
End Property
Public Property MOTISTA_ID() as Integer
Get
Return int_MOTISTA_ID
End Get
Set(ByVal Value as Integer)
int_MOTISTA_ID = Value
End Set
End Property
Public Property TIPO_PEDIDO() as String
Get
Return Str_TIPO_PEDIDO
End Get
Set(ByVal Value as String)
Str_TIPO_PEDIDO = Value
End Set
    End Property
    Public Property ESTADO() As String
        Get
            Return str_ESTADO
        End Get
        Set(ByVal Value As String)
            str_ESTADO = Value
        End Set
    End Property
Public Property FECHA() as Date
Get
Return date_FECHA
End Get
Set(ByVal Value as Date)
date_FECHA = Value
End Set
End Property
Public Property MONTO_TOTAL() as Double
Get
Return dbl_MONTO_TOTAL
End Get
Set(ByVal Value as Double)
dbl_MONTO_TOTAL = Value
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

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' +","+"["+NIT+"]" +","+"["+NOMBRE+"]" +","+"
 
 
Public Sub Guardar()
        MConexion.EjecutarProcedimiento("Proc_tbl_PEDIDOGUARDAR " + PEDIDO_ID.ToString + "," + CLIENTE_ID.ToString + "," + MESERO_ID.ToString + "," + RECEPCIONISTA_ID.ToString + "," + MOTISTA_ID.ToString + "," + "[" + TIPO_PEDIDO + "]" + "," + "[" + ESTADO + "]" + "," + " ' " + FECHA.ToString + " ' " + "," + MONTO_TOTAL.ToString + "," + MESA_ID.ToString)
End Sub
 
 
Public Sub Modificar()
        MConexion.EjecutarProcedimiento("Proc_tbl_PEDIDOMODIFICAR " + PEDIDO_ID.ToString + "," + CLIENTE_ID.ToString + "," + MESERO_ID.ToString + "," + RECEPCIONISTA_ID.ToString + "," + MOTISTA_ID.ToString + "," + "[" + TIPO_PEDIDO + "]" + "," + "[" + ESTADO + "]" + "," + " ' " + FECHA.ToString + " ' " + "," + MONTO_TOTAL.ToString + "," + MESA_ID.ToString)
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_PEDIDOELIMINAR "+PEDIDO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_PEDIDOLISTAR "+PEDIDO_ID.ToString )
 Lector.Read() 
      PEDIDO_ID = Cint(Lector.Item( "PEDIDO_ID"))
      CLIENTE_ID = Cint(Lector.Item( "CLIENTE_ID"))
      MESERO_ID = Cint(Lector.Item( "MESERO_ID"))
      RECEPCIONISTA_ID = Cint(Lector.Item( "RECEPCIONISTA_ID"))
      MOTISTA_ID = Cint(Lector.Item( "MOTISTA_ID"))
        TIPO_PEDIDO = Lector.Item("TIPO_PEDIDO")
        ESTADO = Lector.Item("ESTADO")
        FECHA = CDate(Lector.Item("FECHA"))
        MONTO_TOTAL = CDbl(Lector.Item("MONTO_TOTAL"))
        MESA_ID = CInt(Lector.Item("MESA_ID"))
Lector.Close
End Sub
 
 
End Class
