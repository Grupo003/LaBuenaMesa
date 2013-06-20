Imports System.Data.SqlClient

 
Public Class cls_ADMINISTRADOR
 
 
Private int_ADM_ID as Integer
 
 
Public Property ADM_ID() as Integer
Get
Return int_ADM_ID
End Get
Set(ByVal Value as Integer)
int_ADM_ID = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_ADMINISTRADORGUARDAR "+ADM_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_ADMINISTRADORMODIFICAR "+ADM_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_ADMINISTRADORELIMINAR "+ADM_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
        Lector = MConexion.EjecutarConsulta("Proc_tbl_ADMINISTRADORLISTAR " + ADM_ID.ToString)
 Lector.Read() 
      ADM_ID = Cint(Lector.Item( "ADM_ID"))
Lector.Close
End Sub

End Class
