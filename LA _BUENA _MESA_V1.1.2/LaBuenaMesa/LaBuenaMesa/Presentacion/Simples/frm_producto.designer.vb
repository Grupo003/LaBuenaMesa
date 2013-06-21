<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_producto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_producto))
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.bt_atras = New System.Windows.Forms.Button
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.bt_guardar = New System.Windows.Forms.Button
        Me.tf_precio = New System.Windows.Forms.TextBox
        Me.tf_nombre = New System.Windows.Forms.ComboBox
        Me.tf_producto = New System.Windows.Forms.ComboBox
        Me.tf_auxiliar = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tf_stock = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.tf_estado = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ch_bebida = New System.Windows.Forms.CheckBox
        Me.ch_pollo = New System.Windows.Forms.CheckBox
        Me.ch_porcion = New System.Windows.Forms.CheckBox
        Me.ch_deshabilitado = New System.Windows.Forms.CheckBox
        Me.ch_res = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label6.Location = New System.Drawing.Point(493, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 25)
        Me.Label6.TabIndex = 336
        Me.Label6.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(245, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 25)
        Me.Label2.TabIndex = 333
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(10, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 332
        Me.Label1.Text = "Producto id"
        '
        'dg_mostrar
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_mostrar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.Location = New System.Drawing.Point(425, 225)
        Me.dg_mostrar.Name = "dg_mostrar"
        Me.dg_mostrar.Size = New System.Drawing.Size(455, 188)
        Me.dg_mostrar.TabIndex = 331
        '
        'bt_atras
        '
        Me.bt_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atras.Image = CType(resources.GetObject("bt_atras.Image"), System.Drawing.Image)
        Me.bt_atras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_atras.Location = New System.Drawing.Point(647, 107)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(84, 75)
        Me.bt_atras.TabIndex = 330
        Me.bt_atras.Text = "ATRAS"
        Me.bt_atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_atras.UseVisualStyleBackColor = False
        '
        'bt_mostrar
        '
        Me.bt_mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_mostrar.Image = CType(resources.GetObject("bt_mostrar.Image"), System.Drawing.Image)
        Me.bt_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_mostrar.Location = New System.Drawing.Point(557, 107)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(84, 75)
        Me.bt_mostrar.TabIndex = 329
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
        Me.bt_eliminar.Location = New System.Drawing.Point(467, 107)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 75)
        Me.bt_eliminar.TabIndex = 328
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
        Me.bt_modificar.Location = New System.Drawing.Point(377, 107)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(84, 75)
        Me.bt_modificar.TabIndex = 327
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
        Me.bt_buscar.Location = New System.Drawing.Point(287, 107)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 326
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
        Me.bt_guardar.Location = New System.Drawing.Point(107, 107)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(84, 75)
        Me.bt_guardar.TabIndex = 325
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'tf_precio
        '
        Me.tf_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_precio.Location = New System.Drawing.Point(472, 43)
        Me.tf_precio.Name = "tf_precio"
        Me.tf_precio.Size = New System.Drawing.Size(125, 31)
        Me.tf_precio.TabIndex = 323
        Me.tf_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tf_nombre
        '
        Me.tf_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombre.FormattingEnabled = True
        Me.tf_nombre.Location = New System.Drawing.Point(163, 43)
        Me.tf_nombre.Name = "tf_nombre"
        Me.tf_nombre.Size = New System.Drawing.Size(281, 33)
        Me.tf_nombre.TabIndex = 320
        '
        'tf_producto
        '
        Me.tf_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_producto.FormattingEnabled = True
        Me.tf_producto.Location = New System.Drawing.Point(29, 43)
        Me.tf_producto.Name = "tf_producto"
        Me.tf_producto.Size = New System.Drawing.Size(94, 33)
        Me.tf_producto.TabIndex = 319
        '
        'tf_auxiliar
        '
        Me.tf_auxiliar.Location = New System.Drawing.Point(39, 12)
        Me.tf_auxiliar.Name = "tf_auxiliar"
        Me.tf_auxiliar.Size = New System.Drawing.Size(50, 20)
        Me.tf_auxiliar.TabIndex = 338
        Me.tf_auxiliar.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Red
        Me.Label11.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label11.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label11.Location = New System.Drawing.Point(322, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(338, 46)
        Me.Label11.TabIndex = 358
        Me.Label11.Text = "P R O D U C T O"
        '
        'tf_stock
        '
        Me.tf_stock.Enabled = False
        Me.tf_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_stock.Location = New System.Drawing.Point(621, 44)
        Me.tf_stock.Name = "tf_stock"
        Me.tf_stock.Size = New System.Drawing.Size(68, 31)
        Me.tf_stock.TabIndex = 359
        Me.tf_stock.Text = "0"
        Me.tf_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(622, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 360
        Me.Label3.Text = "Stock"
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(738, 107)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(84, 75)
        Me.bt_logout.TabIndex = 364
        Me.bt_logout.Text = "LOGOUT"
        Me.bt_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_logout.UseVisualStyleBackColor = False
        '
        'tf_salir
        '
        Me.tf_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tf_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_salir.Image = CType(resources.GetObject("tf_salir.Image"), System.Drawing.Image)
        Me.tf_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tf_salir.Location = New System.Drawing.Point(828, 107)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(84, 75)
        Me.tf_salir.TabIndex = 363
        Me.tf_salir.Text = "SALIR"
        Me.tf_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tf_salir.UseVisualStyleBackColor = False
        '
        'bt_limpiar
        '
        Me.bt_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_limpiar.Image = CType(resources.GetObject("bt_limpiar.Image"), System.Drawing.Image)
        Me.bt_limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_limpiar.Location = New System.Drawing.Point(197, 107)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 362
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        '
        'tf_estado
        '
        Me.tf_estado.Enabled = False
        Me.tf_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_estado.Location = New System.Drawing.Point(712, 45)
        Me.tf_estado.Name = "tf_estado"
        Me.tf_estado.Size = New System.Drawing.Size(192, 31)
        Me.tf_estado.TabIndex = 365
        Me.tf_estado.Text = "HABILITADO"
        Me.tf_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label4.Location = New System.Drawing.Point(774, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Estado"
        '
        'ch_bebida
        '
        Me.ch_bebida.AutoSize = True
        Me.ch_bebida.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_bebida.ForeColor = System.Drawing.Color.Yellow
        Me.ch_bebida.Location = New System.Drawing.Point(31, 107)
        Me.ch_bebida.Name = "ch_bebida"
        Me.ch_bebida.Size = New System.Drawing.Size(107, 35)
        Me.ch_bebida.TabIndex = 397
        Me.ch_bebida.Text = "Bebida"
        Me.ch_bebida.UseVisualStyleBackColor = True
        '
        'ch_pollo
        '
        Me.ch_pollo.AutoSize = True
        Me.ch_pollo.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_pollo.ForeColor = System.Drawing.Color.Yellow
        Me.ch_pollo.Location = New System.Drawing.Point(31, 25)
        Me.ch_pollo.Name = "ch_pollo"
        Me.ch_pollo.Size = New System.Drawing.Size(88, 35)
        Me.ch_pollo.TabIndex = 398
        Me.ch_pollo.Text = "Pollo"
        Me.ch_pollo.UseVisualStyleBackColor = True
        '
        'ch_porcion
        '
        Me.ch_porcion.AutoSize = True
        Me.ch_porcion.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_porcion.ForeColor = System.Drawing.Color.Yellow
        Me.ch_porcion.Location = New System.Drawing.Point(31, 148)
        Me.ch_porcion.Name = "ch_porcion"
        Me.ch_porcion.Size = New System.Drawing.Size(117, 35)
        Me.ch_porcion.TabIndex = 399
        Me.ch_porcion.Text = "Porción"
        Me.ch_porcion.UseVisualStyleBackColor = True
        '
        'ch_deshabilitado
        '
        Me.ch_deshabilitado.AutoSize = True
        Me.ch_deshabilitado.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_deshabilitado.ForeColor = System.Drawing.Color.Yellow
        Me.ch_deshabilitado.Location = New System.Drawing.Point(557, 188)
        Me.ch_deshabilitado.Name = "ch_deshabilitado"
        Me.ch_deshabilitado.Size = New System.Drawing.Size(182, 35)
        Me.ch_deshabilitado.TabIndex = 401
        Me.ch_deshabilitado.Text = "Deshabilitado"
        Me.ch_deshabilitado.UseVisualStyleBackColor = True
        '
        'ch_res
        '
        Me.ch_res.AutoSize = True
        Me.ch_res.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_res.ForeColor = System.Drawing.Color.Yellow
        Me.ch_res.Location = New System.Drawing.Point(31, 66)
        Me.ch_res.Name = "ch_res"
        Me.ch_res.Size = New System.Drawing.Size(72, 35)
        Me.ch_res.TabIndex = 402
        Me.ch_res.Text = "Res"
        Me.ch_res.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ch_pollo)
        Me.GroupBox1.Controls.Add(Me.ch_res)
        Me.GroupBox1.Controls.Add(Me.ch_bebida)
        Me.GroupBox1.Controls.Add(Me.ch_porcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox1.Location = New System.Drawing.Point(126, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 205)
        Me.GroupBox1.TabIndex = 403
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO PRODUCTO .-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tf_estado)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tf_stock)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tf_producto)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tf_nombre)
        Me.GroupBox2.Controls.Add(Me.tf_precio)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox2.Location = New System.Drawing.Point(54, 439)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(924, 140)
        Me.GroupBox2.TabIndex = 403
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS USUARIO .-"
        '
        'frm_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1004, 635)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ch_deshabilitado)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.tf_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tf_auxiliar)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.bt_mostrar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Name = "frm_producto"
        Me.Text = "frm_producto"
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents tf_precio As System.Windows.Forms.TextBox
    Friend WithEvents tf_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents tf_producto As System.Windows.Forms.ComboBox
    Friend WithEvents tf_auxiliar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tf_stock As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents tf_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ch_bebida As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pollo As System.Windows.Forms.CheckBox
    Friend WithEvents ch_porcion As System.Windows.Forms.CheckBox
    Friend WithEvents ch_deshabilitado As System.Windows.Forms.CheckBox
    Friend WithEvents ch_res As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
