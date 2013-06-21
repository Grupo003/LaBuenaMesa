 Imports System.Data.SqlClient 
 
Public Class cls_BITACORA
 
 
Private date_FECHA_ENTRADA as Date 
Private date_FECHA_SALIDA as Date 
Private int_USUARIO_ID as Integer
 
 
Public Property FECHA_ENTRADA() as Date
Get
Return date_FECHA_ENTRADA
End Get
Set(ByVal Value as Date)
date_FECHA_ENTRADA = Value
End Set
End Property
Public Property FECHA_SALIDA() as Date
Get
Return date_FECHA_SALIDA
End Get
Set(ByVal Value as Date)
date_FECHA_SALIDA = Value
End Set
End Property
Public Property USUARIO_ID() as Integer
Get
Return int_USUARIO_ID
End Get
Set(ByVal Value as Integer)
int_USUARIO_ID = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_BITACORAGUARDAR "+" ' "+FECHA_ENTRADA.ToString+" ' "+","+" ' "+FECHA_SALIDA.ToString+" ' "+","+USUARIO_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_BITACORAMODIFICAR "+" ' "+FECHA_ENTRADA.ToString+" ' "+","+" ' "+FECHA_SALIDA.ToString+" ' "+","+USUARIO_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_BITACORAELIMINAR "+" ' "+FECHA_ENTRADA.ToString+" ' ")
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_BITACORALISTAR "+" ' "+FECHA_ENTRADA.ToString+" ' ")
 Lector.Read() 
      FECHA_ENTRADA = Cdate(Lector.Item( "FECHA_ENTRADA"))
      FECHA_SALIDA = Cdate(Lector.Item( "FECHA_SALIDA"))
      USUARIO_ID = Cint(Lector.Item( "USUARIO_ID"))
Lector.Close
End Sub
 
 
End Class
