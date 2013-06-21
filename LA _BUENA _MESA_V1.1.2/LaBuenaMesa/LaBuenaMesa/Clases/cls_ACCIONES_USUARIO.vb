 Imports System.Data.SqlClient 
 
Public Class cls_ACCIONES_USUARIO
 
 
Private date_FECHA_HORA_ACCION as Date 
Private str_DESCRIPCION as String
Private date_BITACORA_ID as Date 
Private int_USUARIO_ID as Integer
 
 
Public Property FECHA_HORA_ACCION() as Date
Get
Return date_FECHA_HORA_ACCION
End Get
Set(ByVal Value as Date)
date_FECHA_HORA_ACCION = Value
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
Public Property BITACORA_ID() as Date
Get
Return date_BITACORA_ID
End Get
Set(ByVal Value as Date)
date_BITACORA_ID = Value
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
MConexion.EjecutarProcedimiento("Proc_tbl_ACCIONES_USUARIOGUARDAR "+" ' "+FECHA_HORA_ACCION.ToString+" ' "+","+"["+DESCRIPCION+"]" +","+" ' "+BITACORA_ID.ToString+" ' "+","+USUARIO_ID.ToString )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_ACCIONES_USUARIOMODIFICAR "+" ' "+FECHA_HORA_ACCION.ToString+" ' "+","+"["+DESCRIPCION+"]" +","+" ' "+BITACORA_ID.ToString+" ' "+","+USUARIO_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_ACCIONES_USUARIOELIMINAR "+" ' "+FECHA_HORA_ACCION.ToString+" ' ")
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_ACCIONES_USUARIOLISTAR "+" ' "+FECHA_HORA_ACCION.ToString+" ' ")
 Lector.Read() 
      FECHA_HORA_ACCION = Cdate(Lector.Item( "FECHA_HORA_ACCION"))
      DESCRIPCION = Lector.Item( "DESCRIPCION")
      BITACORA_ID = Cdate(Lector.Item( "BITACORA_ID"))
      USUARIO_ID = Cint(Lector.Item( "USUARIO_ID"))
Lector.Close
End Sub
 
 
End Class
