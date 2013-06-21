 Imports System.Data.SqlClient 
 
Public Class cls_CAJA
 
 
Private int_CAJA_ID as Integer
Private int_MONTO_ID as Integer
Private dbl_MONTO as Double 
 
 
Public Property CAJA_ID() as Integer
Get
Return int_CAJA_ID
End Get
Set(ByVal Value as Integer)
int_CAJA_ID = Value
End Set
End Property
Public Property MONTO_ID() as Integer
Get
Return int_MONTO_ID
End Get
Set(ByVal Value as Integer)
int_MONTO_ID = Value
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
MConexion.EjecutarProcedimiento("Proc_tbl_CAJAGUARDAR "+CAJA_ID.ToString +","+MONTO_ID.ToString +","+MONTO.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJAMODIFICAR "+CAJA_ID.ToString +","+MONTO_ID.ToString +","+MONTO.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJAELIMINAR "+CAJA_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_CAJALISTAR "+CAJA_ID.ToString )
 Lector.Read() 
      CAJA_ID = Cint(Lector.Item( "CAJA_ID"))
      MONTO_ID = Cint(Lector.Item( "MONTO_ID"))
      MONTO = CDbl(Lector.Item( "MONTO"))
Lector.Close
End Sub
 
 
End Class
