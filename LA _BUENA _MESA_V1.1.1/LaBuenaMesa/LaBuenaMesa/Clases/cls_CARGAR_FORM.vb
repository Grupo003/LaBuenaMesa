 Imports System.Data.SqlClient 
 
Public Class cls_CARGAR_FORM
 
 
Private int_FORM_ID as Integer
Private str_NOMBRE as String
 
 
Public Property FORM_ID() as Integer
Get
Return int_FORM_ID
End Get
Set(ByVal Value as Integer)
int_FORM_ID = Value
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
MConexion.EjecutarProcedimiento("Proc_tbl_CARGAR_FORMGUARDAR "+FORM_ID.ToString +","+"["+NOMBRE+"]" )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_CARGAR_FORMMODIFICAR "+FORM_ID.ToString +","+"["+NOMBRE+"]" )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_CARGAR_FORMELIMINAR "+FORM_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_CARGAR_FORMLISTAR "+FORM_ID.ToString )
 Lector.Read() 
      FORM_ID = Cint(Lector.Item( "FORM_ID"))
      NOMBRE = Lector.Item( "NOMBRE")
Lector.Close
End Sub
 
 
End Class
