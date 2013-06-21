<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_registrosPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_registrosPrincipal))
        Me.bt_caja = New System.Windows.Forms.Button
        Me.bt_producto = New System.Windows.Forms.Button
        Me.bt_cliente = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_privilegio = New System.Windows.Forms.Button
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_caja
        '
        Me.bt_caja.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_caja.ForeColor = System.Drawing.Color.Black
        Me.bt_caja.Image = CType(resources.GetObject("bt_caja.Image"), System.Drawing.Image)
        Me.bt_caja.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_caja.Location = New System.Drawing.Point(260, 48)
        Me.bt_caja.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.bt_caja.Name = "bt_caja"
        Me.bt_caja.Size = New System.Drawing.Size(84, 75)
        Me.bt_caja.TabIndex = 204
        Me.bt_caja.Text = "CAJA"
        Me.bt_caja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_caja.UseVisualStyleBackColor = False
        '
        'bt_producto
        '
        Me.bt_producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_producto.ForeColor = System.Drawing.Color.Black
        Me.bt_producto.Image = CType(resources.GetObject("bt_producto.Image"), System.Drawing.Image)
        Me.bt_producto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_producto.Location = New System.Drawing.Point(147, 48)
        Me.bt_producto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.bt_producto.Name = "bt_producto"
        Me.bt_producto.Size = New System.Drawing.Size(84, 75)
        Me.bt_producto.TabIndex = 200
        Me.bt_producto.Text = "PRODUCTO"
        Me.bt_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_producto.UseVisualStyleBackColor = False
        '
        'bt_cliente
        '
        Me.bt_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cliente.ForeColor = System.Drawing.Color.Black
        Me.bt_cliente.Image = CType(resources.GetObject("bt_cliente.Image"), System.Drawing.Image)
        Me.bt_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_cliente.Location = New System.Drawing.Point(36, 48)
        Me.bt_cliente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.bt_cliente.Name = "bt_cliente"
        Me.bt_cliente.Size = New System.Drawing.Size(84, 75)
        Me.bt_cliente.TabIndex = 199
        Me.bt_cliente.Text = "PERSONAS"
        Me.bt_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_cliente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(239, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(619, 56)
        Me.Label1.TabIndex = 256
        Me.Label1.Text = "REGISTRO  Y  GESTION"
        '
        'bt_privilegio
        '
        Me.bt_privilegio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_privilegio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_privilegio.ForeColor = System.Drawing.Color.Black
        Me.bt_privilegio.Image = CType(resources.GetObject("bt_privilegio.Image"), System.Drawing.Image)
        Me.bt_privilegio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_privilegio.Location = New System.Drawing.Point(374, 48)
        Me.bt_privilegio.Name = "bt_privilegio"
        Me.bt_privilegio.Size = New System.Drawing.Size(90, 75)
        Me.bt_privilegio.TabIndex = 257
        Me.bt_privilegio.Text = "PRIVILEGIO"
        Me.bt_privilegio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_privilegio.UseVisualStyleBackColor = False
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(338, 155)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(50, 40)
        Me.bt_logout.TabIndex = 374
        Me.bt_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_logout.UseVisualStyleBackColor = False
        '
        'tf_salir
        '
        Me.tf_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tf_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_salir.Image = CType(resources.GetObject("tf_salir.Image"), System.Drawing.Image)
        Me.tf_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tf_salir.Location = New System.Drawing.Point(394, 155)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(50, 40)
        Me.tf_salir.TabIndex = 373
        Me.tf_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tf_salir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(282, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 372
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(498, 48)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 75)
        Me.Button2.TabIndex = 375
        Me.Button2.Text = "MESA"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.bt_privilegio)
        Me.GroupBox1.Controls.Add(Me.bt_cliente)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.bt_producto)
        Me.GroupBox1.Controls.Add(Me.bt_logout)
        Me.GroupBox1.Controls.Add(Me.bt_caja)
        Me.GroupBox1.Controls.Add(Me.tf_salir)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox1.Location = New System.Drawing.Point(179, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(733, 235)
        Me.GroupBox1.TabIndex = 376
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESGISTROS.-"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(605, 48)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 75)
        Me.Button3.TabIndex = 376
        Me.Button3.Text = "RESERVAS"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_registrosPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(943, 530)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frm_registrosPrincipal"
        Me.Text = "frm_registrosPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_caja As System.Windows.Forms.Button
    Friend WithEvents bt_producto As System.Windows.Forms.Button
    Friend WithEvents bt_cliente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_privilegio As System.Windows.Forms.Button
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
