 Imports System.Data.SqlClient 
 
Public Class cls_GRUPO
 
 
Private int_GRUPO_ID as Integer
Private str_NOMBRE as String
 
 
Public Property GRUPO_ID() as Integer
Get
Return int_GRUPO_ID
End Get
Set(ByVal Value as Integer)
int_GRUPO_ID = Value
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
MConexion.EjecutarProcedimiento("Proc_tbl_GRUPOGUARDAR "+GRUPO_ID.ToString +","+"["+NOMBRE+"]" )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_GRUPOMODIFICAR "+GRUPO_ID.ToString +","+"["+NOMBRE+"]" )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_GRUPOELIMINAR "+GRUPO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_GRUPOLISTAR "+GRUPO_ID.ToString )
 Lector.Read() 
      GRUPO_ID = Cint(Lector.Item( "GRUPO_ID"))
      NOMBRE = Lector.Item( "NOMBRE")
Lector.Close
End Sub
 
 
End Class
