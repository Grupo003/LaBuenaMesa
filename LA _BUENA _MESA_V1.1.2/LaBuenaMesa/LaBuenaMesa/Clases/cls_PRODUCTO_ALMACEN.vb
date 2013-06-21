 Imports System.Data.SqlClient 
 
Public Class cls_PRODUCTO_ALMACEN
 
 
Private int_PRODUCTO_ID as Integer
Private int_ALMACEN_ID as Integer
Private date_FECHA as Date 
Private int_CANTIDAD as Integer
 
 
Public Property PRODUCTO_ID() as Integer
Get
Return int_PRODUCTO_ID
End Get
Set(ByVal Value as Integer)
int_PRODUCTO_ID = Value
End Set
End Property
Public Property ALMACEN_ID() as Integer
Get
Return int_ALMACEN_ID
End Get
Set(ByVal Value as Integer)
int_ALMACEN_ID = Value
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
Public Property CANTIDAD() as Integer
Get
Return int_CANTIDAD
End Get
Set(ByVal Value as Integer)
int_CANTIDAD = Value
End Set
End Property
 
 
Public Sub Guardar()
        MConexion.EjecutarProcedimiento("Proc_tbl_PRODUCTO_ALMACENGUARDAR " + PRODUCTO_ID.ToString + "," + ALMACEN_ID.ToString + "," + " ' " + FECHA.ToString + " ' " + "," + CANTIDAD.ToString)
    End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_PRODUCTO_ALMACENMODIFICAR "+PRODUCTO_ID.ToString +","+ALMACEN_ID.ToString +","+" ' "+FECHA.ToString+" ' "+","+CANTIDAD.ToString )
End Sub
 
 
Public Sub Eliminar()
        MConexion.EjecutarProcedimiento("Proc_tbl_PRODUCTO_ALMACENELIMINAR " + PRODUCTO_ID.ToString + "," + ALMACEN_ID.ToString)
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_PRODUCTO_ALMACENLISTAR "+PRODUCTO_ID.ToString )
 Lector.Read() 
      PRODUCTO_ID = Cint(Lector.Item( "PRODUCTO_ID"))
      ALMACEN_ID = Cint(Lector.Item( "ALMACEN_ID"))
      FECHA = Cdate(Lector.Item( "FECHA"))
      CANTIDAD = Cint(Lector.Item( "CANTIDAD"))
Lector.Close
End Sub
 
 
End Class
