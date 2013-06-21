 Imports System.Data.SqlClient 
 
Public Class cls_MESA
 
 
Private int_MESA_ID as Integer
Private str_DESCRIPCION as String
Private str_ESTADO as String
Private str_SECTOR as String
 
 
Public Property MESA_ID() as Integer
Get
Return int_MESA_ID
End Get
Set(ByVal Value as Integer)
int_MESA_ID = Value
End Set
End Property
Public Property DESCRIPCION() as String
Get
Return Str_DESCRIPCION
End Get
Set(ByVal Value as String)
Str_DESCRIPCION = Value
End Set
End Property
Public Property ESTADO() as String
Get
Return Str_ESTADO
End Get
Set(ByVal Value as String)
Str_ESTADO = Value
End Set
End Property
Public Property SECTOR() as String
Get
Return Str_SECTOR
End Get
Set(ByVal Value as String)
Str_SECTOR = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_MESAGUARDAR "+MESA_ID.ToString +","+"["+DESCRIPCION+"]" +","+"["+ESTADO+"]" +","+"["+SECTOR+"]" )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_MESAMODIFICAR "+MESA_ID.ToString +","+"["+DESCRIPCION+"]" +","+"["+ESTADO+"]" +","+"["+SECTOR+"]" )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_MESAELIMINAR "+MESA_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_MESALISTAR "+MESA_ID.ToString )
 Lector.Read() 
      MESA_ID = Cint(Lector.Item( "MESA_ID"))
      DESCRIPCION = Lector.Item( "DESCRIPCION")
      ESTADO = Lector.Item( "ESTADO")
      SECTOR = Lector.Item( "SECTOR")
Lector.Close
End Sub
 
 
End Class
