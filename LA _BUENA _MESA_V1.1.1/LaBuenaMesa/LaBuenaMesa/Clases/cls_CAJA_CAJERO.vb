 Imports System.Data.SqlClient 
 
Public Class cls_CAJA_CAJERO
 
 
Private int_CAJERO_ID as Integer
Private int_CAJA_ID as Integer
Private date_FECHA as Date 
Private dbl_MONTO as Double 
 
 
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
Public Property FECHA() as Date
Get
Return date_FECHA
End Get
Set(ByVal Value as Date)
date_FECHA = Value
End Set
End Property
Public Property MONTO() as Double
Get
Return dbl_MONTO
End Get
Set(ByVal Value as Double)
dbl_MONTO = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJA_CAJEROGUARDAR "+CAJERO_ID.ToString +","+CAJA_ID.ToString +","+" ' "+FECHA.ToString+" ' "+","+MONTO.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJA_CAJEROMODIFICAR "+CAJERO_ID.ToString +","+CAJA_ID.ToString +","+" ' "+FECHA.ToString+" ' "+","+MONTO.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJA_CAJEROELIMINAR "+CAJERO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_CAJA_CAJEROLISTAR "+CAJERO_ID.ToString )
 Lector.Read() 
      CAJERO_ID = Cint(Lector.Item( "CAJERO_ID"))
      CAJA_ID = Cint(Lector.Item( "CAJA_ID"))
      FECHA = Cdate(Lector.Item( "FECHA"))
      MONTO = CDbl(Lector.Item( "MONTO"))
Lector.Close
End Sub
 
 
End Class
