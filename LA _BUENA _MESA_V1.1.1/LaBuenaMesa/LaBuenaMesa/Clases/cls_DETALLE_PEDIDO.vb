 Imports System.Data.SqlClient 
 
Public Class cls_DETALLE_PEDIDO
 
 
Private int_PEDIDO_ID as Integer
Private int_PRODUCTO_ID as Integer
Private int_CANTIDAD as Integer
Private dbl_PRECIO_INITARIO as Double 
 
 
Public Property PEDIDO_ID() as Integer
Get
Return int_PEDIDO_ID
End Get
Set(ByVal Value as Integer)
int_PEDIDO_ID = Value
End Set
End Property
Public Property PRODUCTO_ID() as Integer
Get
Return int_PRODUCTO_ID
End Get
Set(ByVal Value as Integer)
int_PRODUCTO_ID = Value
End Set
End Property
Public Property CANTIDAD() as Integer
Get
Return int_CANTIDAD
End Get
Set(ByVal Value as Integer)
int_CANTIDAD = Value
End Set
End Property
Public Property PRECIO_INITARIO() as Double
Get
Return dbl_PRECIO_INITARIO
End Get
Set(ByVal Value as Double)
dbl_PRECIO_INITARIO = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_DETALLE_PEDIDOGUARDAR "+PEDIDO_ID.ToString +","+PRODUCTO_ID.ToString +","+CANTIDAD.ToString +","+PRECIO_INITARIO.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_DETALLE_PEDIDOMODIFICAR "+PEDIDO_ID.ToString +","+PRODUCTO_ID.ToString +","+CANTIDAD.ToString +","+PRECIO_INITARIO.ToString )
End Sub
 
 
Public Sub Eliminar()
        MConexion.EjecutarProcedimiento("Proc_tbl_DETALLE_PEDIDOELIMINAR " + PEDIDO_ID.ToString + "," + PRODUCTO_ID.ToString)
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
        Lector = MConexion.EjecutarConsulta("Proc_tbl_DETALLE_PEDIDOLISTAR " + PEDIDO_ID.ToString)
        Lector.Read()
      PEDIDO_ID = Cint(Lector.Item( "PEDIDO_ID"))
      PRODUCTO_ID = Cint(Lector.Item( "PRODUCTO_ID"))
      CANTIDAD = Cint(Lector.Item( "CANTIDAD"))
      PRECIO_INITARIO = CDbl(Lector.Item( "PRECIO_INITARIO"))
Lector.Close
End Sub
 
 
End Class
