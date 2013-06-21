 Imports System.Data.SqlClient 
 
Public Class cls_PRODUCTO
 
 
Private int_PRODUCTO_ID as Integer
Private str_NOMBRE as String
Private dbl_PRECIO as Double 
    Private int_STOCK As Integer
    Private str_TIPO As String
    Private str_ESTADO As String
 
 
Public Property PRODUCTO_ID() as Integer
Get
Return int_PRODUCTO_ID
End Get
Set(ByVal Value as Integer)
int_PRODUCTO_ID = Value
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
Public Property PRECIO() as Double
Get
Return dbl_PRECIO
End Get
Set(ByVal Value as Double)
dbl_PRECIO = Value
End Set
End Property
Public Property STOCK() as Integer
Get
Return int_STOCK
End Get
Set(ByVal Value as Integer)
int_STOCK = Value
End Set
    End Property
    Public Property TIPO() As String
        Get
            Return Str_TIPO
        End Get
        Set(ByVal Value As String)
            Str_TIPO = Value
        End Set
    End Property
    Public Property ESTADO() As String
        Get
            Return str_ESTADO
        End Get
        Set(ByVal Value As String)
            str_ESTADO = Value
        End Set
    End Property
 
 
Public Sub Guardar()
        MConexion.EjecutarProcedimiento("Proc_tbl_PRODUCTOGUARDAR " + PRODUCTO_ID.ToString + "," + "[" + NOMBRE + "]" + "," + PRECIO.ToString + "," + STOCK.ToString + "," + "[" + TIPO + "]" + "," + "[" + ESTADO + "]")
End Sub
 
 
Public Sub Modificar()
        MConexion.EjecutarProcedimiento("Proc_tbl_PRODUCTOMODIFICAR " + PRODUCTO_ID.ToString + "," + "[" + NOMBRE + "]" + "," + PRECIO.ToString + "," + STOCK.ToString + "," + "[" + TIPO + "]")
End Sub
 
 
Public Sub Eliminar()
MConexion.EjecutarProcedimiento("Proc_tbl_PRODUCTOELIMINAR "+PRODUCTO_ID.ToString )
End Sub
 
 
    Public Sub CargarDatos()
        Dim Lector As SqlDataReader
        Lector = MConexion.EjecutarConsulta("Proc_BuscarProducto " + PRODUCTO_ID.ToString)
        Lector.Read()
        PRODUCTO_ID = CInt(Lector.Item("PRODUCTO_ID"))
        NOMBRE = Lector.Item("NOMBRE")
        PRECIO = CDbl(Lector.Item("PRECIO"))
        STOCK = CInt(Lector.Item("STOCK"))
        TIPO = Lector.Item("TIPO")
        ESTADO = Lector.Item("ESTADO")
        Lector.Close()
    End Sub
 
 
End Class
