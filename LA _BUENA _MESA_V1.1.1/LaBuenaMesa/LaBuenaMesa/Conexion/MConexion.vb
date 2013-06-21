Imports System.Data.SqlClient

Module MConexion

#Region "Atributos"

    Private Cnx As SqlConnection
    Private StrCnx As String
    Private Comando As SqlCommand
    Private strServidor As String
    Private strBaseDatos As String

#End Region

#Region "Conección"

    Public Sub Conectar()
        'workstation id=SUANNY;packet size=4096;integrated security=SSPI;persist security info=False;initial catalog=BD_Transporte

        'StrCnx = "workstation id= " + strServidor + " ;packet size=4096;integrated security=SSPI;persist security info=False; initial catalog= " + strBaseDatos
        StrCnx = "workstation id=IMZS-1F70A8C5D8;packet size=4096;integrated security=SSPI;initial catalog=PANCHOPOLLO;persist security info=False"
        Try
            Cnx = New SqlConnection(StrCnx)
            Cnx.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Desconectar()
        Cnx.Dispose()
        Cnx.Close()
    End Sub
    Public Sub Parametrizar(ByVal servidor As String, ByVal BaseDatos As String)
        strServidor = servidor
        strBaseDatos = BaseDatos
    End Sub
    Public Function DevolverConexion() As SqlConnection
        Return Cnx
    End Function

#End Region

#Region "Ejecución de procesos"

    Public Sub EjecutarProcedimiento(ByVal cadena As String)
        Comando = New SqlCommand(cadena, Cnx)
        Comando.ExecuteNonQuery()
        Comando.Dispose()
    End Sub
    Public Function EjecutarConsulta(ByVal Cadena As String) As SqlDataReader
        Comando = New SqlCommand(Cadena, Cnx)
        Return Comando.ExecuteReader
    End Function
    

#End Region

End Module
