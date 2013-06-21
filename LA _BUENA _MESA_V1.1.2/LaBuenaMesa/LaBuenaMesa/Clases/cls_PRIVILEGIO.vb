 Imports System.Data.SqlClient 
 
Public Class cls_PRIVILEGIO
 
 
Private int_GRUPO_ID as Integer
Private int_PERMISO_ID as Integer
 
 
Public Property GRUPO_ID() as Integer
Get
Return int_GRUPO_ID
End Get
Set(ByVal Value as Integer)
int_GRUPO_ID = Value
End Set
End Property
Public Property PERMISO_ID() as Integer
Get
Return int_PERMISO_ID
End Get
Set(ByVal Value as Integer)
int_PERMISO_ID = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_PRIVILEGIOGUARDAR "+GRUPO_ID.ToString +","+PERMISO_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_PRIVILEGIOMODIFICAR "+GRUPO_ID.ToString +","+PERMISO_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_PRIVILEGIOELIMINAR "+GRUPO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_PRIVILEGIOLISTAR "+GRUPO_ID.ToString )
 Lector.Read() 
      GRUPO_ID = Cint(Lector.Item( "GRUPO_ID"))
      PERMISO_ID = Cint(Lector.Item( "PERMISO_ID"))
Lector.Close
End Sub
 
 
End Class
