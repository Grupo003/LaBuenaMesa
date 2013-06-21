<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrarCajaCajeroPago
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrarCajaCajeroPago))
        Me.lb_recepcionista = New System.Windows.Forms.Label
        Me.tf_cajero = New System.Windows.Forms.ListBox
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.tb_atras = New System.Windows.Forms.Button
        Me.bt_pago = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tf_caja = New System.Windows.Forms.ListBox
        Me.tf_nombreCajero = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lb_recepcionista
        '
        Me.lb_recepcionista.AutoSize = True
        Me.lb_recepcionista.BackColor = System.Drawing.Color.Black
        Me.lb_recepcionista.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_recepcionista.ForeColor = System.Drawing.Color.Chartreuse
        Me.lb_recepcionista.Location = New System.Drawing.Point(105, 92)
        Me.lb_recepcionista.Name = "lb_recepcionista"
        Me.lb_recepcionista.Size = New System.Drawing.Size(115, 23)
        Me.lb_recepcionista.TabIndex = 383
        Me.lb_recepcionista.Text = "Codigo Cajero"
        '
        'tf_cajero
        '
        Me.tf_cajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_cajero.FormattingEnabled = True
        Me.tf_cajero.ItemHeight = 19
        Me.tf_cajero.Location = New System.Drawing.Point(90, 120)
        Me.tf_cajero.Name = "tf_cajero"
        Me.tf_cajero.Size = New System.Drawing.Size(141, 137)
        Me.tf_cajero.TabIndex = 382
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(217, 330)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(50, 40)
        Me.bt_logout.TabIndex = 381
        Me.bt_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_logout.UseVisualStyleBackColor = False
        '
        'tf_salir
        '
        Me.tf_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tf_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_salir.Image = CType(resources.GetObject("tf_salir.Image"), System.Drawing.Image)
        Me.tf_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tf_salir.Location = New System.Drawing.Point(273, 330)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(50, 40)
        Me.tf_salir.TabIndex = 380
        Me.tf_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tf_salir.UseVisualStyleBackColor = False
        '
        'tb_atras
        '
        Me.tb_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tb_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_atras.Image = CType(resources.GetObject("tb_atras.Image"), System.Drawing.Image)
        Me.tb_atras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tb_atras.Location = New System.Drawing.Point(161, 330)
        Me.tb_atras.Name = "tb_atras"
        Me.tb_atras.Size = New System.Drawing.Size(50, 40)
        Me.tb_atras.TabIndex = 379
        Me.tb_atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tb_atras.UseVisualStyleBackColor = False
        '
        'bt_pago
        '
        Me.bt_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_pago.Image = CType(resources.GetObject("bt_pago.Image"), System.Drawing.Image)
        Me.bt_pago.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_pago.Location = New System.Drawing.Point(415, 120)
        Me.bt_pago.Name = "bt_pago"
        Me.bt_pago.Size = New System.Drawing.Size(84, 75)
        Me.bt_pago.TabIndex = 378
        Me.bt_pago.Text = "P A G O"
        Me.bt_pago.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_pago.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Georgia", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(30, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(469, 38)
        Me.Label14.TabIndex = 377
        Me.Label14.Text = "ASIGNAR  CAJERO - CAJA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(269, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 23)
        Me.Label1.TabIndex = 385
        Me.Label1.Text = "Codigo Caja"
        '
        'tf_caja
        '
        Me.tf_caja.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_caja.FormattingEnabled = True
        Me.tf_caja.ItemHeight = 19
        Me.tf_caja.Location = New System.Drawing.Point(254, 120)
        Me.tf_caja.Name = "tf_caja"
        Me.tf_caja.Size = New System.Drawing.Size(141, 137)
        Me.tf_caja.TabIndex = 384
        '
        'tf_nombreCajero
        '
        Me.tf_nombreCajero.Enabled = False
        Me.tf_nombreCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombreCajero.Location = New System.Drawing.Point(90, 283)
        Me.tf_nombreCajero.Name = "tf_nombreCajero"
        Me.tf_nombreCajero.Size = New System.Drawing.Size(305, 26)
        Me.tf_nombreCajero.TabIndex = 386
        '
        'frm_registrarCajaCajeroPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(511, 400)
        Me.Controls.Add(Me.tf_nombreCajero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tf_caja)
        Me.Controls.Add(Me.lb_recepcionista)
        Me.Controls.Add(Me.tf_cajero)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.tf_salir)
        Me.Controls.Add(Me.tb_atras)
        Me.Controls.Add(Me.bt_pago)
        Me.Controls.Add(Me.Label14)
        Me.Name = "frm_registrarCajaCajeroPago"
        Me.Text = "frm_registrarCajaPago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_recepcionista As System.Windows.Forms.Label
    Friend WithEvents tf_cajero As System.Windows.Forms.ListBox
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents tb_atras As System.Windows.Forms.Button
    Friend WithEvents bt_pago As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tf_caja As System.Windows.Forms.ListBox
    Friend WithEvents tf_nombreCajero As System.Windows.Forms.TextBox
End Class
