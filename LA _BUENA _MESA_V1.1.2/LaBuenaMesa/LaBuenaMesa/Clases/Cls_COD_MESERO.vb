 Imports System.Data.SqlClient 
 
Public Class cls_COD_MESERO
 
 
Private int_COD as Integer
Private int_NRO as Integer
 
 
Public Property COD() as Integer
Get
Return int_COD
End Get
Set(ByVal Value as Integer)
int_COD = Value
End Set
End Property
Public Property NRO() as Integer
Get
Return int_NRO
End Get
Set(ByVal Value as Integer)
int_NRO = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_COD_MESEROGUARDAR "+COD.ToString +","+NRO.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_COD_MESEROMODIFICAR "+COD.ToString +","+NRO.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_COD_MESEROELIMINAR "+COD.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_COD_MESEROLISTAR "+COD.ToString )
 Lector.Read() 
      COD = Cint(Lector.Item( "COD"))
      NRO = Cint(Lector.Item( "NRO"))
Lector.Close
End Sub
 
 
End Class
