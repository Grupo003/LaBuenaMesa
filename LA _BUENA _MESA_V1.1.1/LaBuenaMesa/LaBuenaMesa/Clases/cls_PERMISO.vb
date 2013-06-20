 Imports System.Data.SqlClient 
 
Public Class cls_PERMISO
 
 
Private int_PERMISO_ID as Integer
Private str_DESCRIPCION as String
 
 
Public Property PERMISO_ID() as Integer
Get
Return int_PERMISO_ID
End Get
Set(ByVal Value as Integer)
int_PERMISO_ID = Value
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
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_PERMISOGUARDAR "+PERMISO_ID.ToString +","+"["+DESCRIPCION+"]" )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_PERMISOMODIFICAR "+PERMISO_ID.ToString +","+"["+DESCRIPCION+"]" )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_PERMISOELIMINAR "+PERMISO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_PERMISOLISTAR "+PERMISO_ID.ToString )
 Lector.Read() 
      PERMISO_ID = Cint(Lector.Item( "PERMISO_ID"))
      DESCRIPCION = Lector.Item( "DESCRIPCION")
Lector.Close
End Sub
 
 
End Class
