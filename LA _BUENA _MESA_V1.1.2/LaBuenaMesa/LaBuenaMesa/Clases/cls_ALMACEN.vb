 Imports System.Data.SqlClient 
 
Public Class cls_ALMACEN
 
 
Private int_ALMACEN_ID as Integer
Private str_NOMBRE as String
 
 
Public Property ALMACEN_ID() as Integer
Get
Return int_ALMACEN_ID
End Get
Set(ByVal Value as Integer)
int_ALMACEN_ID = Value
End Set
End Property
Public Property NOMBRE() as String
Get
Return Str_NOMBRE
End Get
Set(ByVal Value as String)
Str_NOMBRE = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_ALMACENGUARDAR "+ALMACEN_ID.ToString +","+"["+NOMBRE+"]" )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_ALMACENMODIFICAR "+ALMACEN_ID.ToString +","+"["+NOMBRE+"]" )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_ALMACENELIMINAR "+ALMACEN_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_ALMACENLISTAR "+ALMACEN_ID.ToString )
 Lector.Read() 
      ALMACEN_ID = Cint(Lector.Item( "ALMACEN_ID"))
      NOMBRE = Lector.Item( "NOMBRE")
Lector.Close
End Sub
 
 
End Class
