Public Class MDForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'frm_Principal.MdiParent = Me
        'frm_Principal.Show()
        frm_login.MdiParent = Me
        frm_login.Show()
    End Sub
End Class