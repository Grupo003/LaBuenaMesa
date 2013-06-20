 Imports System.Data.SqlClient 
 
Public Class cls_USUARIO
 
    Dim b As New cls_ACCIONES_USUARIO

Private int_USUARIO_ID as Integer
Private str_NOMBRE as String
Private str_APELL_P as String
Private str_APELL_M as String
Private str_DIRECCION as String
Private date_FECHA_NAC as Date 
Private str_TELEFONO as String
Private str_CELULAR as String
Private str_SEXO as String
Private str_LOGIN as String
Private str_CONTRASEÑA as String
Private str_ESTADO as String
Private int_GRUPO_ID as Integer
 
 
Public Property USUARIO_ID() as Integer
Get
Return int_USUARIO_ID
End Get
Set(ByVal Value as Integer)
int_USUARIO_ID = Value
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
Public Property CELULAR() as String
Get
Return Str_CELULAR
End Get
Set(ByVal Value as String)
Str_CELULAR = Value
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
Public Property LOGIN() as String
Get
Return Str_LOGIN
End Get
Set(ByVal Value as String)
Str_LOGIN = Value
End Set
End Property
Public Property CONTRASEÑA() as String
Get
Return Str_CONTRASEÑA
End Get
Set(ByVal Value as String)
Str_CONTRASEÑA = Value
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
Public Property GRUPO_ID() as Integer
Get
Return int_GRUPO_ID
End Get
Set(ByVal Value as Integer)
int_GRUPO_ID = Value
End Set
End Property
 
 
    Public Sub Guardar()
        MConexion.EjecutarProcedimiento("Proc_tbl_USUARIOGUARDAR " + USUARIO_ID.ToString + "," + "[" + NOMBRE + "]" + "," + "[" + APELL_P + "]" + "," + "[" + APELL_M + "]" + "," + "[" + DIRECCION + "]" + "," + " ' " + FECHA_NAC.ToString + " ' " + "," + "[" + TELEFONO + "]" + "," + "[" + CELULAR + "]" + "," + "[" + SEXO + "]" + "," + "[" + LOGIN + "]" + "," + "[" + CONTRASEÑA + "]" + "," + "[" + ESTADO + "]" + "," + GRUPO_ID.ToString) '+ "," + " ' " + b.BITACORA_ID.ToString + " ' " + "," + b.USUARIO_ID.ToString)
    End Sub
    'ByVal FechaHoraSesion As DateTime, ByVal Cod_U As Integer
    'cmd.Parameters.Add("@FechaHoraSesion", SqlDbType.DateTime, 8).Value = FechaHoraSesion
    'cmd.Parameters.Add("@Cod_User", SqlDbType.Int, 4).Value = Cod_U
 
 
Public Sub Modificar()
MConexion.EjecutarProcedimiento("Proc_tbl_USUARIOMODIFICAR "+USUARIO_ID.ToString +","+"["+NOMBRE+"]" +","+"["+APELL_P+"]" +","+"["+APELL_M+"]" +","+"["+DIRECCION+"]" +","+" ' "+FECHA_NAC.ToString+" ' "+","+"["+TELEFONO+"]" +","+"["+CELULAR+"]" +","+"["+SEXO+"]" +","+"["+LOGIN+"]" +","+"["+CONTRASEÑA+"]" +","+"["+ESTADO+"]" +","+GRUPO_ID.ToString )
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_USUARIOELIMINAR "+USUARIO_ID.ToString )
End Sub
 
 
 Public sub CargarDatos() 
 dim Lector as sqldatareader 
 Lector = MConexion.EjecutarConsulta("Proc_tbl_USUARIOLISTAR "+USUARIO_ID.ToString )
 Lector.Read() 
      USUARIO_ID = Cint(Lector.Item( "USUARIO_ID"))
      NOMBRE = Lector.Item( "NOMBRE")
      APELL_P = Lector.Item( "APELL_P")
      APELL_M = Lector.Item( "APELL_M")
      DIRECCION = Lector.Item( "DIRECCION")
      FECHA_NAC = Cdate(Lector.Item( "FECHA_NAC"))
      TELEFONO = Lector.Item( "TELEFONO")
      CELULAR = Lector.Item( "CELULAR")
      SEXO = Lector.Item( "SEXO")
      LOGIN = Lector.Item( "LOGIN")
      CONTRASEÑA = Lector.Item( "CONTRASEÑA")
      ESTADO = Lector.Item( "ESTADO")
      GRUPO_ID = Cint(Lector.Item( "GRUPO_ID"))
Lector.Close
End Sub
 
 
End Class
