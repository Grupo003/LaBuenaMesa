 Imports System.Data.SqlClient 
 
Public Class cls_RECEPCIONISTA
 
 
Private int_RECEPCIONISTA_ID as Integer
 
 
Public Property RECEPCIONISTA_ID() as Integer
Get
Return int_RECEPCIONISTA_ID
End Get
Set(ByVal Value as Integer)
int_RECEPCIONISTA_ID = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_RECEPCIONISTAGUARDAR "+RECEPCIONISTA_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_RECEPCIONISTAMODIFICAR "+RECEPCIONISTA_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_RECEPCIONISTAELIMINAR "+RECEPCIONISTA_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_RECEPCIONISTALISTAR "+RECEPCIONISTA_ID.ToString )
 Lector.Read() 
      RECEPCIONISTA_ID = Cint(Lector.Item( "RECEPCIONISTA_ID"))
Lector.Close
End Sub
 
 
End Class
