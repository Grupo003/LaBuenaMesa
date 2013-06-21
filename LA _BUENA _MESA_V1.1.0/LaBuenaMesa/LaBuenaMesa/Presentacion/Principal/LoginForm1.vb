
Imports System.Data.SqlClient         'PARA QUE FUNCIONES EL METODO BUSCAR

Public Class frm_login


    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Public Function tieneDatosLogin() As Boolean
        If ((tf_usuario.Text <> "") Or (tf_login.Text <> "") Or (tf_contraseña.Text <> "")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim d As DialogResult
        d = MsgBox("¿SEGURO DESEA SALIR DEL SISTEMA?", MsgBoxStyle.YesNo)
        If (d = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (tieneDatosLogin() = True) Then
           
        Else
            MsgBox("VEFICAR SI NO EXISTEN CASILLA EN BLANCO")
        End If
    End Sub
End Class
