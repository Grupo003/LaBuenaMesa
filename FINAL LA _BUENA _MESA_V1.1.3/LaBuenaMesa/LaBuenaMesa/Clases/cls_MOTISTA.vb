 Imports System.Data.SqlClient 
 
Public Class cls_MOTISTA
 
 
Private int_MOTISTA_ID as Integer
Private str_NOMBRE as String
Private str_APELL_P as String
Private str_APELL_M as String
Private str_DIRECCION as String
Private date_FECHA_NAC as Date 
Private str_TELEFONO as String
Private str_SEXO as String
Private str_ESTADO as String
 
 
Public Property MOTISTA_ID() as Integer
Get
Return int_MOTISTA_ID
End Get
Set(ByVal Value as Integer)
int_MOTISTA_ID = Value
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
Public Property APELL_P() as String
Get
Return Str_APELL_P
End Get
Set(ByVal Value as String)
Str_APELL_P = Value
End Set
End Property
Public Property APELL_M() as String
Get
Return Str_APELL_M
End Get
Set(ByVal Value as String)
Str_APELL_M = Value
End Set
End Property
Public Property DIRECCION() as String
Get
Return Str_DIRECCION
End Get
Set(ByVal Value as String)
Str_DIRECCION = Value
End Set
End Property
Public Property FECHA_NAC() as Date
Get
Return date_FECHA_NAC
End Get
Set(ByVal Value as Date)
date_FECHA_NAC = Value
End Set
End Property
Public Property TELEFONO() as String
Get
Return Str_TELEFONO
End Get
Set(ByVal Value as String)
Str_TELEFONO = Value
End Set
End Property
Public Property SEXO() as String
Get
Return Str_SEXO
End Get
Set(ByVal Value as String)
Str_SEXO = Value
End Set
End Property
Public Property ESTADO() as String
Get
Return Str_ESTADO
End Get
Set(ByVal Value as String)
Str_ESTADO = Value
End Set
End Property
 
 
Public Sub Guardar()
MConexion.EjecutarProcedimiento("Proc_tbl_MOTISTAGUARDAR "+MOTISTA_ID.ToString +","+"["+NOMBRE+"]" +","+"["+APELL_P+"]" +","+"["+APELL_M+"]" +","+"["+DIRECCION+"]" +","+" ' "+FECHA_NAC.ToString+" ' "+","+"["+TELEFONO+"]" +","+"["+SEXO+"]" +","+"["+ESTADO+"]" )
End Sub
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_MOTISTAMODIFICAR "+MOTISTA_ID.ToString +","+"["+NOMBRE+"]" +","+"["+APELL_P+"]" +","+"["+APELL_M+"]" +","+"["+DIRECCION+"]" +","+" ' "+FECHA_NAC.ToString+" ' "+","+"["+TELEFONO+"]" +","+"["+SEXO+"]" +","+"["+ESTADO+"]" )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_MOTISTAELIMINAR "+MOTISTA_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_MOTISTALISTAR "+MOTISTA_ID.ToString )
 Lector.Read() 
      MOTISTA_ID = Cint(Lector.Item( "MOTISTA_ID"))
      NOMBRE = Lector.Item( "NOMBRE")
      APELL_P = Lector.Item( "APELL_P")
      APELL_M = Lector.Item( "APELL_M")
      DIRECCION = Lector.Item( "DIRECCION")
      FECHA_NAC = Cdate(Lector.Item( "FECHA_NAC"))
      TELEFONO = Lector.Item( "TELEFONO")
      SEXO = Lector.Item( "SEXO")
      ESTADO = Lector.Item( "ESTADO")
Lector.Close
End Sub
 
 
End Class
