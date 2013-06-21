 Imports System.Data.SqlClient 
 
Public Class cls_MESERO
 
 
Private int_MESERO_ID as Integer
 
 
Public Property MESERO_ID() as Integer
Get
Return int_MESERO_ID
End Get
Set(ByVal Value as Integer)
int_MESERO_ID = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_MESEROGUARDAR "+MESERO_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_MESEROMODIFICAR "+MESERO_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_MESEROELIMINAR "+MESERO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_MESEROLISTAR "+MESERO_ID.ToString )
 Lector.Read() 
      MESERO_ID = Cint(Lector.Item( "MESERO_ID"))
Lector.Close
End Sub
 
 
End Class
