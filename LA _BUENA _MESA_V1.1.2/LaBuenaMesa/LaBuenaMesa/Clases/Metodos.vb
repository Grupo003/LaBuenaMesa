Imports System.Data.SqlClient
Module Metodos

    Public Function CaracterNumero(ByVal car As Char) As Boolean
        Return Char.IsDigit(car)
    End Function
    Public Function EsNumero(ByVal Cad As String) As Boolean
        Dim c As Integer = 0
        Dim car As Char

        If (Cad.Length = 0) Then
            Return False
        End If
        While (c < Cad.Length)
            car = Cad.Chars(c)
            If (CaracterNumero(car) = False) Then
                Return False
            End If
            c = c + 1
        End While
        Return True
    End Function

    Public Sub actualizarEstadoMesa()
        Dim c, m, min As New Integer
        c = 1
        Dim Lector As SqlDataReader

        'SACA LA MAXIMA RESERVA
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_SiguienteReserva")
        Lector.Read()
        If (Lector(0) = 0) Then
            Return
        End If
        m = Lector(0) - 1
        MConexion.Desconectar()
        'SACA LA MAXIMA RESERVA HASTA AQUI

        'SACA LA CANTIDAD DE MINUTOS TRANSCURRIDOS DE LA HORA ACTUAL
        MConexion.Conectar()
        Lector = MConexion.EjecutarConsulta("Proc_darHora")
        Lector.Read()
        min = CInt(Hour(CDate(Lector(0))) * 60 + Minute(CDate(Lector(0))))
        MConexion.Desconectar()
        'SACA LA CANTIDAD DE MINUTOS TRANSCURRIDOS DE LA HORA ACTUAL

        While (c <= m)
            MConexion.Conectar()
            MConexion.EjecutarConsulta("Proc_actualizarEstadoMesa " + c.ToString + "," + min.ToString)
            MConexion.Desconectar()
            c = c + 1
        End While
    End Sub

End Module
