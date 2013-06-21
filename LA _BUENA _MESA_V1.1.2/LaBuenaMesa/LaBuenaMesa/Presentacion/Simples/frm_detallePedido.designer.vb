<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_detallePedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_detallePedido))
        Me.tf_pedido = New System.Windows.Forms.ComboBox
        Me.tf_producto = New System.Windows.Forms.ComboBox
        Me.tf_cantidad = New System.Windows.Forms.TextBox
        Me.tf_precioUnitario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.bt_guardar = New System.Windows.Forms.Button
        Me.bt_atras = New System.Windows.Forms.Button
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.bt_salir = New System.Windows.Forms.Button
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tf_pedido
        '
        Me.tf_pedido.FormattingEnabled = True
        Me.tf_pedido.Location = New System.Drawing.Point(270, 435)
        Me.tf_pedido.Name = "tf_pedido"
        Me.tf_pedido.Size = New System.Drawing.Size(80, 21)
        Me.tf_pedido.TabIndex = 277
        '
        'tf_producto
        '
        Me.tf_producto.FormattingEnabled = True
        Me.tf_producto.Location = New System.Drawing.Point(373, 435)
        Me.tf_producto.Name = "tf_producto"
        Me.tf_producto.Size = New System.Drawing.Size(80, 21)
        Me.tf_producto.TabIndex = 278
        '
        'tf_cantidad
        '
        Me.tf_cantidad.Location = New System.Drawing.Point(482, 435)
        Me.tf_cantidad.Name = "tf_cantidad"
        Me.tf_cantidad.Size = New System.Drawing.Size(80, 20)
        Me.tf_cantidad.TabIndex = 279
        '
        'tf_precioUnitario
        '
        Me.tf_precioUnitario.Location = New System.Drawing.Point(585, 435)
        Me.tf_precioUnitario.Name = "tf_precioUnitario"
        Me.tf_precioUnitario.Size = New System.Drawing.Size(80, 20)
        Me.tf_precioUnitario.TabIndex = 280
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(270, 459)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 281
        Me.Label1.Text = "Pedido id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(367, 459)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 282
        Me.Label2.Text = "Producto id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(489, 459)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 283
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(576, 459)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 284
        Me.Label4.Text = "Precio Unit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(266, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(416, 46)
        Me.Label14.TabIndex = 292
        Me.Label14.Text = "DETALLE  PEDIDO"
        '
        'dg_mostrar
        '
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.Location = New System.Drawing.Point(268, 194)
        Me.dg_mostrar.Name = "dg_mostrar"
        Me.dg_mostrar.Size = New System.Drawing.Size(414, 189)
        Me.dg_mostrar.TabIndex = 291
        '
        'bt_mostrar
        '
        Me.bt_mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_mostrar.Image = CType(resources.GetObject("bt_mostrar.Image"), System.Drawing.Image)
        Me.bt_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_mostrar.Location = New System.Drawing.Point(555, 102)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(84, 75)
        Me.bt_mostrar.TabIndex = 290
        Me.bt_mostrar.Text = "MOSTRAR"
        Me.bt_mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_mostrar.UseVisualStyleBackColor = False
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Image = CType(resources.GetObject("bt_eliminar.Image"), System.Drawing.Image)
        Me.bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_eliminar.Location = New System.Drawing.Point(465, 102)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 75)
        Me.bt_eliminar.TabIndex = 289
        Me.bt_eliminar.Text = "ELIMINAR"
        Me.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'bt_modificar
        '
        Me.bt_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modificar.Image = CType(resources.GetObject("bt_modificar.Image"), System.Drawing.Image)
        Me.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_modificar.Location = New System.Drawing.Point(375, 102)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(84, 75)
        Me.bt_modificar.TabIndex = 288
        Me.bt_modificar.Text = "MODIFICAR"
        Me.bt_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_modificar.UseVisualStyleBackColor = False
        '
        'bt_buscar
        '
        Me.bt_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buscar.Image = CType(resources.GetObject("bt_buscar.Image"), System.Drawing.Image)
        Me.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_buscar.Location = New System.Drawing.Point(285, 102)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 287
        Me.bt_buscar.Text = "BUSCAR"
        Me.bt_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_buscar.UseVisualStyleBackColor = False
        '
        'bt_guardar
        '
        Me.bt_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_guardar.Image = CType(resources.GetObject("bt_guardar.Image"), System.Drawing.Image)
        Me.bt_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_guardar.Location = New System.Drawing.Point(105, 102)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(84, 75)
        Me.bt_guardar.TabIndex = 286
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'bt_atras
        '
        Me.bt_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atras.Image = CType(resources.GetObject("bt_atras.Image"), System.Drawing.Image)
        Me.bt_atras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_atras.Location = New System.Drawing.Point(645, 102)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(84, 75)
        Me.bt_atras.TabIndex = 285
        Me.bt_atras.Text = "ATRAS"
        Me.bt_atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_atras.UseVisualStyleBackColor = False
        '
        'bt_limpiar
        '
        Me.bt_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_limpiar.Image = CType(resources.GetObject("bt_limpiar.Image"), System.Drawing.Image)
        Me.bt_limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_limpiar.Location = New System.Drawing.Point(195, 102)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 323
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        '
        'bt_salir
        '
        Me.bt_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_salir.Image = CType(resources.GetObject("bt_salir.Image"), System.Drawing.Image)
        Me.bt_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_salir.Location = New System.Drawing.Point(735, 102)
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Size = New System.Drawing.Size(84, 75)
        Me.bt_salir.TabIndex = 325
        Me.bt_salir.Text = "SALIR"
        Me.bt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_salir.UseVisualStyleBackColor = False
        '
        'frm_detallePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(875, 530)
        Me.Controls.Add(Me.bt_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.bt_mostrar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tf_precioUnitario)
        Me.Controls.Add(Me.tf_cantidad)
        Me.Controls.Add(Me.tf_producto)
        Me.Controls.Add(Me.tf_pedido)
        Me.Name = "frm_detallePedido"
        Me.Text = "frm_detallePedido"
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tf_pedido As System.Windows.Forms.ComboBox
    Friend WithEvents tf_producto As System.Windows.Forms.ComboBox
    Friend WithEvents tf_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents tf_precioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents bt_salir As System.Windows.Forms.Button
End Class
