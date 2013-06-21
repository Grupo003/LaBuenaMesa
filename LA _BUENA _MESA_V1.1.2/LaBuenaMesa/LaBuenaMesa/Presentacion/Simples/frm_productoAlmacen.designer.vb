<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productoAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_productoAlmacen))
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.bt_almacen = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tf_nombrePro = New System.Windows.Forms.ComboBox
        Me.tf_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.Label14 = New System.Windows.Forms.Label
        Me.bt_atras = New System.Windows.Forms.Button
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.bt_guardar = New System.Windows.Forms.Button
        Me.tf_cantidad = New System.Windows.Forms.TextBox
        Me.tf_almacen = New System.Windows.Forms.ComboBox
        Me.tf_producto = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tf_nombreAlm = New System.Windows.Forms.ComboBox
        Me.ch_res = New System.Windows.Forms.CheckBox
        Me.ch_porcion = New System.Windows.Forms.CheckBox
        Me.ch_pollo = New System.Windows.Forms.CheckBox
        Me.ch_bebida = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(773, 174)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(84, 75)
        Me.bt_logout.TabIndex = 411
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
        Me.tf_salir.Location = New System.Drawing.Point(773, 255)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(84, 75)
        Me.tf_salir.TabIndex = 410
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
        Me.bt_limpiar.Location = New System.Drawing.Point(166, 83)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 409
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        '
        'bt_almacen
        '
        Me.bt_almacen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_almacen.Image = CType(resources.GetObject("bt_almacen.Image"), System.Drawing.Image)
        Me.bt_almacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_almacen.Location = New System.Drawing.Point(706, 84)
        Me.bt_almacen.Name = "bt_almacen"
        Me.bt_almacen.Size = New System.Drawing.Size(151, 75)
        Me.bt_almacen.TabIndex = 408
        Me.bt_almacen.Text = "             REGISTRAR                      NUEVO              ALMACEN        "
        Me.bt_almacen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_almacen.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label6.Location = New System.Drawing.Point(401, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 407
        Me.Label6.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label5.Location = New System.Drawing.Point(221, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 23)
        Me.Label5.TabIndex = 406
        Me.Label5.Text = "Nombre"
        '
        'tf_nombrePro
        '
        Me.tf_nombrePro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombrePro.FormattingEnabled = True
        Me.tf_nombrePro.Location = New System.Drawing.Point(154, 25)
        Me.tf_nombrePro.Name = "tf_nombrePro"
        Me.tf_nombrePro.Size = New System.Drawing.Size(211, 33)
        Me.tf_nombrePro.TabIndex = 405
        '
        'tf_fecha
        '
        Me.tf_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_fecha.Location = New System.Drawing.Point(417, 40)
        Me.tf_fecha.Name = "tf_fecha"
        Me.tf_fecha.Size = New System.Drawing.Size(303, 29)
        Me.tf_fecha.TabIndex = 404
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(518, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 403
        Me.Label7.Text = "Fecha"
        '
        'dg_mostrar
        '
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.Location = New System.Drawing.Point(284, 174)
        Me.dg_mostrar.Name = "dg_mostrar"
        Me.dg_mostrar.Size = New System.Drawing.Size(464, 188)
        Me.dg_mostrar.TabIndex = 402
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(51, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(837, 46)
        Me.Label14.TabIndex = 401
        Me.Label14.Text = "REGISTRAR PRODUCTO EN ALMACEN"
        '
        'bt_atras
        '
        Me.bt_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atras.Image = CType(resources.GetObject("bt_atras.Image"), System.Drawing.Image)
        Me.bt_atras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_atras.Location = New System.Drawing.Point(616, 84)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(84, 75)
        Me.bt_atras.TabIndex = 400
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
        Me.bt_mostrar.Location = New System.Drawing.Point(526, 84)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(84, 75)
        Me.bt_mostrar.TabIndex = 399
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
        Me.bt_eliminar.Location = New System.Drawing.Point(436, 84)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 75)
        Me.bt_eliminar.TabIndex = 398
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
        Me.bt_modificar.Location = New System.Drawing.Point(346, 84)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(84, 75)
        Me.bt_modificar.TabIndex = 397
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
        Me.bt_buscar.Location = New System.Drawing.Point(256, 83)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 396
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
        Me.bt_guardar.Location = New System.Drawing.Point(76, 83)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(84, 75)
        Me.bt_guardar.TabIndex = 395
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'tf_cantidad
        '
        Me.tf_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_cantidad.Location = New System.Drawing.Point(407, 25)
        Me.tf_cantidad.Name = "tf_cantidad"
        Me.tf_cantidad.Size = New System.Drawing.Size(88, 31)
        Me.tf_cantidad.TabIndex = 394
        '
        'tf_almacen
        '
        Me.tf_almacen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_almacen.FormattingEnabled = True
        Me.tf_almacen.Location = New System.Drawing.Point(50, 38)
        Me.tf_almacen.Name = "tf_almacen"
        Me.tf_almacen.Size = New System.Drawing.Size(77, 33)
        Me.tf_almacen.TabIndex = 393
        '
        'tf_producto
        '
        Me.tf_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_producto.FormattingEnabled = True
        Me.tf_producto.Location = New System.Drawing.Point(28, 25)
        Me.tf_producto.Name = "tf_producto"
        Me.tf_producto.Size = New System.Drawing.Size(77, 33)
        Me.tf_producto.TabIndex = 392
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(28, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 391
        Me.Label2.Text = "Almacen id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(8, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 390
        Me.Label1.Text = "Producto id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(237, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 413
        Me.Label3.Text = "Nombre"
        '
        'tf_nombreAlm
        '
        Me.tf_nombreAlm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombreAlm.FormattingEnabled = True
        Me.tf_nombreAlm.Location = New System.Drawing.Point(176, 38)
        Me.tf_nombreAlm.Name = "tf_nombreAlm"
        Me.tf_nombreAlm.Size = New System.Drawing.Size(211, 33)
        Me.tf_nombreAlm.TabIndex = 412
        '
        'ch_res
        '
        Me.ch_res.AutoSize = True
        Me.ch_res.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_res.ForeColor = System.Drawing.Color.Yellow
        Me.ch_res.Location = New System.Drawing.Point(24, 66)
        Me.ch_res.Name = "ch_res"
        Me.ch_res.Size = New System.Drawing.Size(72, 35)
        Me.ch_res.TabIndex = 418
        Me.ch_res.Text = "Res"
        Me.ch_res.UseVisualStyleBackColor = True
        '
        'ch_porcion
        '
        Me.ch_porcion.AutoSize = True
        Me.ch_porcion.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_porcion.ForeColor = System.Drawing.Color.Yellow
        Me.ch_porcion.Location = New System.Drawing.Point(24, 148)
        Me.ch_porcion.Name = "ch_porcion"
        Me.ch_porcion.Size = New System.Drawing.Size(117, 35)
        Me.ch_porcion.TabIndex = 416
        Me.ch_porcion.Text = "Porción"
        Me.ch_porcion.UseVisualStyleBackColor = True
        '
        'ch_pollo
        '
        Me.ch_pollo.AutoSize = True
        Me.ch_pollo.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_pollo.ForeColor = System.Drawing.Color.Yellow
        Me.ch_pollo.Location = New System.Drawing.Point(24, 25)
        Me.ch_pollo.Name = "ch_pollo"
        Me.ch_pollo.Size = New System.Drawing.Size(88, 35)
        Me.ch_pollo.TabIndex = 415
        Me.ch_pollo.Text = "Pollo"
        Me.ch_pollo.UseVisualStyleBackColor = True
        '
        'ch_bebida
        '
        Me.ch_bebida.AutoSize = True
        Me.ch_bebida.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_bebida.ForeColor = System.Drawing.Color.Yellow
        Me.ch_bebida.Location = New System.Drawing.Point(24, 107)
        Me.ch_bebida.Name = "ch_bebida"
        Me.ch_bebida.Size = New System.Drawing.Size(107, 35)
        Me.ch_bebida.TabIndex = 414
        Me.ch_bebida.Text = "Bebida"
        Me.ch_bebida.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(872, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 419
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ch_pollo)
        Me.GroupBox1.Controls.Add(Me.ch_bebida)
        Me.GroupBox1.Controls.Add(Me.ch_res)
        Me.GroupBox1.Controls.Add(Me.ch_porcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox1.Location = New System.Drawing.Point(86, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 199)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO .-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tf_fecha)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tf_almacen)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tf_nombreAlm)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox2.Location = New System.Drawing.Point(109, 498)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 120)
        Me.GroupBox2.TabIndex = 421
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS ALMACEN .-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tf_cantidad)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tf_producto)
        Me.GroupBox3.Controls.Add(Me.tf_nombrePro)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox3.Location = New System.Drawing.Point(288, 383)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(541, 109)
        Me.GroupBox3.TabIndex = 422
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS PRODUCTO .-"
        '
        'frm_productoAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(944, 630)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.tf_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.bt_almacen)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.bt_mostrar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Name = "frm_productoAlmacen"
        Me.Text = "frm_productoAlmacen"
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents bt_almacen As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tf_nombrePro As System.Windows.Forms.ComboBox
    Friend WithEvents tf_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents tf_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents tf_almacen As System.Windows.Forms.ComboBox
    Friend WithEvents tf_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tf_nombreAlm As System.Windows.Forms.ComboBox
    Friend WithEvents ch_res As System.Windows.Forms.CheckBox
    Friend WithEvents ch_porcion As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pollo As System.Windows.Forms.CheckBox
    Friend WithEvents ch_bebida As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
