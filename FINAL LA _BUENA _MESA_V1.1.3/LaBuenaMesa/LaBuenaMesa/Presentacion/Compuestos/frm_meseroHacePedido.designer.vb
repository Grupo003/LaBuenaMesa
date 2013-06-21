<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_meseroHacePedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_meseroHacePedido))
        Me.cb_meseros = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.tf_invisible = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lb_mesero = New System.Windows.Forms.Label
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cb_recepcionistas = New System.Windows.Forms.ListBox
        Me.lb_recepcionista = New System.Windows.Forms.Label
        Me.ch_recepcionista = New System.Windows.Forms.CheckBox
        Me.ch_mesero = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tf_nombre = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_meseros
        '
        Me.cb_meseros.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_meseros.FormattingEnabled = True
        Me.cb_meseros.ItemHeight = 19
        Me.cb_meseros.Location = New System.Drawing.Point(104, 147)
        Me.cb_meseros.Name = "cb_meseros"
        Me.cb_meseros.Size = New System.Drawing.Size(141, 137)
        Me.cb_meseros.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(265, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 75)
        Me.Button1.TabIndex = 253
        Me.Button1.Text = "PEDIDO"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tf_invisible
        '
        Me.tf_invisible.Location = New System.Drawing.Point(24, 12)
        Me.tf_invisible.Name = "tf_invisible"
        Me.tf_invisible.Size = New System.Drawing.Size(30, 20)
        Me.tf_invisible.TabIndex = 254
        Me.tf_invisible.Text = "1"
        Me.tf_invisible.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Georgia", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(301, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(346, 38)
        Me.Label14.TabIndex = 255
        Me.Label14.Text = "OBTENER  TICKET"
        '
        'lb_mesero
        '
        Me.lb_mesero.AutoSize = True
        Me.lb_mesero.BackColor = System.Drawing.Color.Black
        Me.lb_mesero.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mesero.ForeColor = System.Drawing.Color.Chartreuse
        Me.lb_mesero.Location = New System.Drawing.Point(103, 117)
        Me.lb_mesero.Name = "lb_mesero"
        Me.lb_mesero.Size = New System.Drawing.Size(121, 23)
        Me.lb_mesero.TabIndex = 256
        Me.lb_mesero.Text = "Codigo Mesero"
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(185, 354)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(50, 40)
        Me.bt_logout.TabIndex = 368
        Me.bt_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_logout.UseVisualStyleBackColor = False
        '
        'tf_salir
        '
        Me.tf_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tf_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_salir.Image = CType(resources.GetObject("tf_salir.Image"), System.Drawing.Image)
        Me.tf_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tf_salir.Location = New System.Drawing.Point(241, 354)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(50, 40)
        Me.tf_salir.TabIndex = 367
        Me.tf_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tf_salir.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(129, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 40)
        Me.Button2.TabIndex = 366
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cb_recepcionistas
        '
        Me.cb_recepcionistas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_recepcionistas.FormattingEnabled = True
        Me.cb_recepcionistas.ItemHeight = 19
        Me.cb_recepcionistas.Location = New System.Drawing.Point(103, 147)
        Me.cb_recepcionistas.Name = "cb_recepcionistas"
        Me.cb_recepcionistas.Size = New System.Drawing.Size(141, 137)
        Me.cb_recepcionistas.TabIndex = 369
        '
        'lb_recepcionista
        '
        Me.lb_recepcionista.AutoSize = True
        Me.lb_recepcionista.BackColor = System.Drawing.Color.Black
        Me.lb_recepcionista.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_recepcionista.ForeColor = System.Drawing.Color.Chartreuse
        Me.lb_recepcionista.Location = New System.Drawing.Point(78, 117)
        Me.lb_recepcionista.Name = "lb_recepcionista"
        Me.lb_recepcionista.Size = New System.Drawing.Size(167, 23)
        Me.lb_recepcionista.TabIndex = 370
        Me.lb_recepcionista.Text = "Codigo Recepcionista"
        '
        'ch_recepcionista
        '
        Me.ch_recepcionista.AutoSize = True
        Me.ch_recepcionista.BackColor = System.Drawing.Color.Black
        Me.ch_recepcionista.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_recepcionista.ForeColor = System.Drawing.Color.Yellow
        Me.ch_recepcionista.Location = New System.Drawing.Point(121, 65)
        Me.ch_recepcionista.Name = "ch_recepcionista"
        Me.ch_recepcionista.Size = New System.Drawing.Size(184, 35)
        Me.ch_recepcionista.TabIndex = 374
        Me.ch_recepcionista.Text = "Recepcionista"
        Me.ch_recepcionista.UseVisualStyleBackColor = False
        '
        'ch_mesero
        '
        Me.ch_mesero.AutoSize = True
        Me.ch_mesero.BackColor = System.Drawing.Color.Black
        Me.ch_mesero.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_mesero.ForeColor = System.Drawing.Color.Yellow
        Me.ch_mesero.Location = New System.Drawing.Point(121, 24)
        Me.ch_mesero.Name = "ch_mesero"
        Me.ch_mesero.Size = New System.Drawing.Size(113, 35)
        Me.ch_mesero.TabIndex = 373
        Me.ch_mesero.Text = "Mesero"
        Me.ch_mesero.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tf_nombre)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.ch_recepcionista)
        Me.GroupBox3.Controls.Add(Me.cb_meseros)
        Me.GroupBox3.Controls.Add(Me.ch_mesero)
        Me.GroupBox3.Controls.Add(Me.lb_mesero)
        Me.GroupBox3.Controls.Add(Me.lb_recepcionista)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.cb_recepcionistas)
        Me.GroupBox3.Controls.Add(Me.tf_salir)
        Me.GroupBox3.Controls.Add(Me.bt_logout)
        Me.GroupBox3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox3.Location = New System.Drawing.Point(273, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 410)
        Me.GroupBox3.TabIndex = 375
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS TICKET.-"
        '
        'tf_nombre
        '
        Me.tf_nombre.Cursor = System.Windows.Forms.Cursors.No
        Me.tf_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombre.Location = New System.Drawing.Point(93, 314)
        Me.tf_nombre.Name = "tf_nombre"
        Me.tf_nombre.Size = New System.Drawing.Size(247, 20)
        Me.tf_nombre.TabIndex = 437
        '
        'frm_meseroHacePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(915, 601)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tf_invisible)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_meseroHacePedido"
        Me.Text = "PANCHO POLLO - TICKET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_meseros As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tf_invisible As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lb_mesero As System.Windows.Forms.Label
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cb_recepcionistas As System.Windows.Forms.ListBox
    Friend WithEvents lb_recepcionista As System.Windows.Forms.Label
    Friend WithEvents ch_recepcionista As System.Windows.Forms.CheckBox
    Friend WithEvents ch_mesero As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tf_nombre As System.Windows.Forms.TextBox
End Class
