 Imports System.Data.SqlClient 
 
Public Class cls_PAGO
 
 
Private int_PAGO_ID as Integer
Private int_CAJERO_ID as Integer
Private int_CAJA_ID as Integer
Private int_PEDIDO_ID as Integer
Private dbl_MONTO_TOTAL as Double 
Private date_FECHA_HORA as Date 
 
 
Public Property PAGO_ID() as Integer
Get
Return int_PAGO_ID
End Get
Set(ByVal Value as Integer)
int_PAGO_ID = Value
End Set
End Property
Public Property CAJERO_ID() as Integer
Get
Return int_CAJERO_ID
End Get
Set(ByVal Value as Integer)
int_CAJERO_ID = Value
End Set
End Property
Public Property CAJA_ID() as Integer
Get
Return int_CAJA_ID
End Get
Set(ByVal Value as Integer)
int_CAJA_ID = Value
End Set
End Property
Public Property PEDIDO_ID() as Integer
Get
Return int_PEDIDO_ID
End Get
Set(ByVal Value as Integer)
int_PEDIDO_ID = Value
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
Public Property FECHA_HORA() as Date
Get
Return date_FECHA_HORA
End Get
Set(ByVal Value as Date)
date_FECHA_HORA = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_PAGOGUARDAR "+PAGO_ID.ToString +","+CAJERO_ID.ToString +","+CAJA_ID.ToString +","+PEDIDO_ID.ToString +","+MONTO_TOTAL.ToString +","+" ' "+FECHA_HORA.ToString+" ' ")
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_PAGOMODIFICAR "+PAGO_ID.ToString +","+CAJERO_ID.ToString +","+CAJA_ID.ToString +","+PEDIDO_ID.ToString +","+MONTO_TOTAL.ToString +","+" ' "+FECHA_HORA.ToString+" ' ")
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_PAGOELIMINAR "+PAGO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_PAGOLISTAR "+PAGO_ID.ToString )
 Lector.Read() 
      PAGO_ID = Cint(Lector.Item( "PAGO_ID"))
      CAJERO_ID = Cint(Lector.Item( "CAJERO_ID"))
      CAJA_ID = Cint(Lector.Item( "CAJA_ID"))
      PEDIDO_ID = Cint(Lector.Item( "PEDIDO_ID"))
      MONTO_TOTAL = CDbl(Lector.Item( "MONTO_TOTAL"))
      FECHA_HORA = Cdate(Lector.Item( "FECHA_HORA"))
Lector.Close
End Sub
 
 
End Class
