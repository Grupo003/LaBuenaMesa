 Imports System.Data.SqlClient 
 
Public Class cls_ACCION_FORMULARIO
 
 
Private int_COD as Integer
Private int_GRUPO_ID as Integer
 
 
Public Property COD() as Integer
Get
Return int_COD
End Get
Set(ByVal Value as Integer)
int_COD = Value
End Set
End Property
Public Property GRUPO_ID() as Integer
Get
Return int_GRUPO_ID
End Get
Set(ByVal Value as Integer)
int_GRUPO_ID = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_ACCION_FORMULARIOGUARDAR "+COD.ToString +","+GRUPO_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_ACCION_FORMULARIOMODIFICAR "+COD.ToString +","+GRUPO_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_ACCION_FORMULARIOELIMINAR "+COD.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_ACCION_FORMULARIOLISTAR "+COD.ToString )
 Lector.Read() 
      COD = Cint(Lector.Item( "COD"))
      GRUPO_ID = Cint(Lector.Item( "GRUPO_ID"))
Lector.Close
End Sub
 
 
End Class
