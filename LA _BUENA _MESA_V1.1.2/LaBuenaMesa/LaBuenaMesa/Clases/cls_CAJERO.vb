 Imports System.Data.SqlClient 
 
Public Class cls_CAJERO
 
 
Private int_CAJERO_ID as Integer
 
 
Public Property CAJERO_ID() as Integer
Get
Return int_CAJERO_ID
End Get
Set(ByVal Value as Integer)
int_CAJERO_ID = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJEROGUARDAR "+CAJERO_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJEROMODIFICAR "+CAJERO_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_CAJEROELIMINAR "+CAJERO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_CAJEROLISTAR "+CAJERO_ID.ToString )
 Lector.Read() 
      CAJERO_ID = Cint(Lector.Item( "CAJERO_ID"))
Lector.Close
End Sub
 
 
End Class
