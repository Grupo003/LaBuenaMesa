<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedido))
        Me.Label1 = New System.Windows.Forms.Label
        Me.tf_pedido = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tf_cliente = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tf_mesero = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lb_tipo = New System.Windows.Forms.Label
        Me.tf_montoTotal = New System.Windows.Forms.TextBox
        Me.tf_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.bt_atras = New System.Windows.Forms.Button
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.bt_guardar = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.tf_producto2 = New System.Windows.Forms.ListBox
        Me.tf_cantidad = New System.Windows.Forms.TextBox
        Me.tf_nombre = New System.Windows.Forms.ComboBox
        Me.tf_producto = New System.Windows.Forms.ComboBox
        Me.tf_ProdStock = New System.Windows.Forms.ComboBox
        Me.tf_suma = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.tf_recepcionista = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.tf_motista = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ch_mesa = New System.Windows.Forms.CheckBox
        Me.ch_llevar = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.bt_lis_eliminar = New System.Windows.Forms.Button
        Me.bt_lis_disminuir = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Tab_producto = New System.Windows.Forms.TabControl
        Me.pollo = New System.Windows.Forms.TabPage
        Me.lb_pollo = New System.Windows.Forms.ListBox
        Me.res = New System.Windows.Forms.TabPage
        Me.lb_res = New System.Windows.Forms.ListBox
        Me.bebidas = New System.Windows.Forms.TabPage
        Me.lb_bebidas = New System.Windows.Forms.ListBox
        Me.porciones = New System.Windows.Forms.TabPage
        Me.lb_porcion = New System.Windows.Forms.ListBox
        Me.tf_prodTipo = New System.Windows.Forms.ComboBox
        Me.bt_asignar = New System.Windows.Forms.Button
        Me.tf_estado = New System.Windows.Forms.TextBox
        Me.tf_tipo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ch_encurso = New System.Windows.Forms.CheckBox
        Me.ch_pendiente = New System.Windows.Forms.CheckBox
        Me.ch_pagado = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.bt_cliente = New System.Windows.Forms.Button
        Me.tf_mesa = New System.Windows.Forms.ComboBox
        Me.lb_mesa = New System.Windows.Forms.Label
        Me.tf_nombreCliente = New System.Windows.Forms.TextBox
        Me.tf_nombreMR = New System.Windows.Forms.TextBox
        Me.tf_nombremotista = New System.Windows.Forms.TextBox
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_producto.SuspendLayout()
        Me.pollo.SuspendLayout()
        Me.res.SuspendLayout()
        Me.bebidas.SuspendLayout()
        Me.porciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(451, 342)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 345
        Me.Label1.Text = "Pedido id"
        '
        'tf_pedido
        '
        Me.tf_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_pedido.FormattingEnabled = True
        Me.tf_pedido.Location = New System.Drawing.Point(454, 318)
        Me.tf_pedido.Name = "tf_pedido"
        Me.tf_pedido.Size = New System.Drawing.Size(81, 21)
        Me.tf_pedido.TabIndex = 344
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(42, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 347
        Me.Label2.Text = "Cliente"
        '
        'tf_cliente
        '
        Me.tf_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_cliente.FormattingEnabled = True
        Me.tf_cliente.Location = New System.Drawing.Point(25, 317)
        Me.tf_cliente.Name = "tf_cliente"
        Me.tf_cliente.Size = New System.Drawing.Size(103, 21)
        Me.tf_cliente.TabIndex = 346
        Me.tf_cliente.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(41, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 349
        Me.Label3.Text = "Mesero id"
        '
        'tf_mesero
        '
        Me.tf_mesero.FormattingEnabled = True
        Me.tf_mesero.Location = New System.Drawing.Point(25, 370)
        Me.tf_mesero.Name = "tf_mesero"
        Me.tf_mesero.Size = New System.Drawing.Size(103, 21)
        Me.tf_mesero.TabIndex = 348
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label5.Location = New System.Drawing.Point(738, 656)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 355
        Me.Label5.Text = "Monto Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label4.Location = New System.Drawing.Point(524, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 354
        Me.Label4.Text = "Fecha"
        '
        'lb_tipo
        '
        Me.lb_tipo.AutoSize = True
        Me.lb_tipo.BackColor = System.Drawing.Color.Black
        Me.lb_tipo.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tipo.ForeColor = System.Drawing.Color.Chartreuse
        Me.lb_tipo.Location = New System.Drawing.Point(732, 413)
        Me.lb_tipo.Name = "lb_tipo"
        Me.lb_tipo.Size = New System.Drawing.Size(40, 16)
        Me.lb_tipo.TabIndex = 353
        Me.lb_tipo.Text = "Tipo"
        '
        'tf_montoTotal
        '
        Me.tf_montoTotal.Enabled = False
        Me.tf_montoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_montoTotal.Location = New System.Drawing.Point(656, 636)
        Me.tf_montoTotal.Name = "tf_montoTotal"
        Me.tf_montoTotal.Size = New System.Drawing.Size(81, 44)
        Me.tf_montoTotal.TabIndex = 352
        '
        'tf_fecha
        '
        Me.tf_fecha.Location = New System.Drawing.Point(454, 389)
        Me.tf_fecha.Name = "tf_fecha"
        Me.tf_fecha.Size = New System.Drawing.Size(202, 20)
        Me.tf_fecha.TabIndex = 351
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label9.Location = New System.Drawing.Point(489, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 363
        Me.Label9.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label8.Location = New System.Drawing.Point(617, 468)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 362
        Me.Label8.Text = "Nro."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label10.Location = New System.Drawing.Point(544, 468)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 360
        Me.Label10.Text = "Producto"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(841, 341)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 39)
        Me.Button2.TabIndex = 373
        Me.Button2.Text = "DETALLE  PEDIDO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dg_mostrar
        '
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.Location = New System.Drawing.Point(25, 162)
        Me.dg_mostrar.Name = "dg_mostrar"
        Me.dg_mostrar.Size = New System.Drawing.Size(760, 139)
        Me.dg_mostrar.TabIndex = 371
        '
        'bt_atras
        '
        Me.bt_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atras.Image = CType(resources.GetObject("bt_atras.Image"), System.Drawing.Image)
        Me.bt_atras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_atras.Location = New System.Drawing.Point(472, 72)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(84, 75)
        Me.bt_atras.TabIndex = 370
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
        Me.bt_mostrar.Location = New System.Drawing.Point(382, 72)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(84, 75)
        Me.bt_mostrar.TabIndex = 369
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
        Me.bt_eliminar.Location = New System.Drawing.Point(292, 72)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 75)
        Me.bt_eliminar.TabIndex = 368
        Me.bt_eliminar.Text = "ELIMINAR"
        Me.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'bt_buscar
        '
        Me.bt_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buscar.Image = CType(resources.GetObject("bt_buscar.Image"), System.Drawing.Image)
        Me.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_buscar.Location = New System.Drawing.Point(202, 72)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 366
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
        Me.bt_guardar.Location = New System.Drawing.Point(22, 72)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(84, 75)
        Me.bt_guardar.TabIndex = 365
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label11.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label11.Location = New System.Drawing.Point(264, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(460, 46)
        Me.Label11.TabIndex = 364
        Me.Label11.Text = "PEDIDO PARA MESA"
        '
        'tf_producto2
        '
        Me.tf_producto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_producto2.FormattingEnabled = True
        Me.tf_producto2.ItemHeight = 16
        Me.tf_producto2.Location = New System.Drawing.Point(452, 486)
        Me.tf_producto2.Name = "tf_producto2"
        Me.tf_producto2.Size = New System.Drawing.Size(285, 148)
        Me.tf_producto2.TabIndex = 376
        '
        'tf_cantidad
        '
        Me.tf_cantidad.Location = New System.Drawing.Point(203, 12)
        Me.tf_cantidad.Name = "tf_cantidad"
        Me.tf_cantidad.Size = New System.Drawing.Size(35, 20)
        Me.tf_cantidad.TabIndex = 359
        Me.tf_cantidad.Text = "1"
        Me.tf_cantidad.Visible = False
        '
        'tf_nombre
        '
        Me.tf_nombre.FormattingEnabled = True
        Me.tf_nombre.Location = New System.Drawing.Point(53, 11)
        Me.tf_nombre.Name = "tf_nombre"
        Me.tf_nombre.Size = New System.Drawing.Size(40, 21)
        Me.tf_nombre.TabIndex = 357
        Me.tf_nombre.Visible = False
        '
        'tf_producto
        '
        Me.tf_producto.FormattingEnabled = True
        Me.tf_producto.Location = New System.Drawing.Point(15, 11)
        Me.tf_producto.Name = "tf_producto"
        Me.tf_producto.Size = New System.Drawing.Size(31, 21)
        Me.tf_producto.TabIndex = 356
        Me.tf_producto.Visible = False
        '
        'tf_ProdStock
        '
        Me.tf_ProdStock.FormattingEnabled = True
        Me.tf_ProdStock.Location = New System.Drawing.Point(100, 11)
        Me.tf_ProdStock.Name = "tf_ProdStock"
        Me.tf_ProdStock.Size = New System.Drawing.Size(35, 21)
        Me.tf_ProdStock.TabIndex = 377
        Me.tf_ProdStock.Visible = False
        '
        'tf_suma
        '
        Me.tf_suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_suma.Location = New System.Drawing.Point(872, 562)
        Me.tf_suma.Name = "tf_suma"
        Me.tf_suma.Size = New System.Drawing.Size(50, 29)
        Me.tf_suma.TabIndex = 381
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label15.Location = New System.Drawing.Point(458, 467)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 16)
        Me.Label15.TabIndex = 385
        Me.Label15.Text = "ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label12.Location = New System.Drawing.Point(658, 468)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 386
        Me.Label12.Text = "Total"
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(562, 72)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(84, 75)
        Me.bt_logout.TabIndex = 389
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
        Me.tf_salir.Location = New System.Drawing.Point(652, 72)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(84, 75)
        Me.tf_salir.TabIndex = 388
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
        Me.bt_limpiar.Location = New System.Drawing.Point(112, 72)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 387
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label16.Location = New System.Drawing.Point(22, 394)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 16)
        Me.Label16.TabIndex = 391
        Me.Label16.Text = "Recepcionista"
        '
        'tf_recepcionista
        '
        Me.tf_recepcionista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_recepcionista.FormattingEnabled = True
        Me.tf_recepcionista.Location = New System.Drawing.Point(25, 370)
        Me.tf_recepcionista.Name = "tf_recepcionista"
        Me.tf_recepcionista.Size = New System.Drawing.Size(103, 21)
        Me.tf_recepcionista.TabIndex = 390
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label17.Location = New System.Drawing.Point(45, 450)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 393
        Me.Label17.Text = "Motista"
        '
        'tf_motista
        '
        Me.tf_motista.Enabled = False
        Me.tf_motista.FormattingEnabled = True
        Me.tf_motista.Location = New System.Drawing.Point(25, 423)
        Me.tf_motista.Name = "tf_motista"
        Me.tf_motista.Size = New System.Drawing.Size(103, 21)
        Me.tf_motista.TabIndex = 392
        Me.tf_motista.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Black
        Me.Label18.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label18.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label18.Location = New System.Drawing.Point(250, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(474, 46)
        Me.Label18.TabIndex = 394
        Me.Label18.Text = "PEDIDO   DOMICILIO"
        '
        'ch_mesa
        '
        Me.ch_mesa.AutoSize = True
        Me.ch_mesa.Font = New System.Drawing.Font("Courier New", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_mesa.ForeColor = System.Drawing.Color.Yellow
        Me.ch_mesa.Location = New System.Drawing.Point(708, 376)
        Me.ch_mesa.Name = "ch_mesa"
        Me.ch_mesa.Size = New System.Drawing.Size(73, 26)
        Me.ch_mesa.TabIndex = 395
        Me.ch_mesa.Text = "MESA"
        Me.ch_mesa.UseVisualStyleBackColor = True
        '
        'ch_llevar
        '
        Me.ch_llevar.AutoSize = True
        Me.ch_llevar.Font = New System.Drawing.Font("Courier New", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_llevar.ForeColor = System.Drawing.Color.Yellow
        Me.ch_llevar.Location = New System.Drawing.Point(708, 408)
        Me.ch_llevar.Name = "ch_llevar"
        Me.ch_llevar.Size = New System.Drawing.Size(95, 26)
        Me.ch_llevar.TabIndex = 396
        Me.ch_llevar.Text = "LLEVAR"
        Me.ch_llevar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(452, 640)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 419
        Me.Button3.Text = "LIMPIAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'bt_lis_eliminar
        '
        Me.bt_lis_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_lis_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_lis_eliminar.Image = CType(resources.GetObject("bt_lis_eliminar.Image"), System.Drawing.Image)
        Me.bt_lis_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_lis_eliminar.Location = New System.Drawing.Point(751, 480)
        Me.bt_lis_eliminar.Name = "bt_lis_eliminar"
        Me.bt_lis_eliminar.Size = New System.Drawing.Size(115, 33)
        Me.bt_lis_eliminar.TabIndex = 420
        Me.bt_lis_eliminar.Text = "ELIMINAR"
        Me.bt_lis_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_lis_eliminar.UseVisualStyleBackColor = False
        '
        'bt_lis_disminuir
        '
        Me.bt_lis_disminuir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_lis_disminuir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_lis_disminuir.Image = CType(resources.GetObject("bt_lis_disminuir.Image"), System.Drawing.Image)
        Me.bt_lis_disminuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_lis_disminuir.Location = New System.Drawing.Point(751, 519)
        Me.bt_lis_disminuir.Name = "bt_lis_disminuir"
        Me.bt_lis_disminuir.Size = New System.Drawing.Size(115, 33)
        Me.bt_lis_disminuir.TabIndex = 421
        Me.bt_lis_disminuir.Text = "DISMINUIR"
        Me.bt_lis_disminuir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bt_lis_disminuir.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(751, 558)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 33)
        Me.Button5.TabIndex = 422
        Me.Button5.Text = "CANTIDAD"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Tab_producto
        '
        Me.Tab_producto.Controls.Add(Me.pollo)
        Me.Tab_producto.Controls.Add(Me.res)
        Me.Tab_producto.Controls.Add(Me.bebidas)
        Me.Tab_producto.Controls.Add(Me.porciones)
        Me.Tab_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_producto.Location = New System.Drawing.Point(131, 464)
        Me.Tab_producto.Name = "Tab_producto"
        Me.Tab_producto.SelectedIndex = 0
        Me.Tab_producto.Size = New System.Drawing.Size(272, 201)
        Me.Tab_producto.TabIndex = 423
        '
        'pollo
        '
        Me.pollo.BackColor = System.Drawing.Color.Transparent
        Me.pollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pollo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pollo.Controls.Add(Me.lb_pollo)
        Me.pollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pollo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pollo.Location = New System.Drawing.Point(4, 22)
        Me.pollo.Name = "pollo"
        Me.pollo.Padding = New System.Windows.Forms.Padding(3)
        Me.pollo.Size = New System.Drawing.Size(264, 175)
        Me.pollo.TabIndex = 0
        Me.pollo.Text = "POLLO"
        Me.pollo.UseVisualStyleBackColor = True
        '
        'lb_pollo
        '
        Me.lb_pollo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_pollo.FormattingEnabled = True
        Me.lb_pollo.ItemHeight = 16
        Me.lb_pollo.Items.AddRange(New Object() {"STOCK --- ID ---- NOMBRE", "___________________________"})
        Me.lb_pollo.Location = New System.Drawing.Point(1, 1)
        Me.lb_pollo.Name = "lb_pollo"
        Me.lb_pollo.Size = New System.Drawing.Size(261, 244)
        Me.lb_pollo.TabIndex = 421
        Me.lb_pollo.Tag = "ddd"
        '
        'res
        '
        Me.res.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.res.Controls.Add(Me.lb_res)
        Me.res.Location = New System.Drawing.Point(4, 22)
        Me.res.Name = "res"
        Me.res.Padding = New System.Windows.Forms.Padding(3)
        Me.res.Size = New System.Drawing.Size(264, 175)
        Me.res.TabIndex = 1
        Me.res.Text = "RES"
        Me.res.UseVisualStyleBackColor = True
        '
        'lb_res
        '
        Me.lb_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_res.FormattingEnabled = True
        Me.lb_res.ItemHeight = 16
        Me.lb_res.Items.AddRange(New Object() {"STOCK --- ID ---- NOMBRE", "___________________________"})
        Me.lb_res.Location = New System.Drawing.Point(1, 1)
        Me.lb_res.Name = "lb_res"
        Me.lb_res.Size = New System.Drawing.Size(258, 244)
        Me.lb_res.TabIndex = 431
        Me.lb_res.Tag = "ddd"
        '
        'bebidas
        '
        Me.bebidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.bebidas.Controls.Add(Me.lb_bebidas)
        Me.bebidas.Location = New System.Drawing.Point(4, 22)
        Me.bebidas.Name = "bebidas"
        Me.bebidas.Padding = New System.Windows.Forms.Padding(3)
        Me.bebidas.Size = New System.Drawing.Size(264, 175)
        Me.bebidas.TabIndex = 2
        Me.bebidas.Text = "BEBIDAS"
        Me.bebidas.UseVisualStyleBackColor = True
        '
        'lb_bebidas
        '
        Me.lb_bebidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bebidas.FormattingEnabled = True
        Me.lb_bebidas.ItemHeight = 16
        Me.lb_bebidas.Items.AddRange(New Object() {"STOCK --- ID ---- NOMBRE", "___________________________"})
        Me.lb_bebidas.Location = New System.Drawing.Point(1, 2)
        Me.lb_bebidas.Name = "lb_bebidas"
        Me.lb_bebidas.Size = New System.Drawing.Size(258, 244)
        Me.lb_bebidas.TabIndex = 429
        Me.lb_bebidas.Tag = "ddd"
        '
        'porciones
        '
        Me.porciones.BackColor = System.Drawing.Color.Red
        Me.porciones.Controls.Add(Me.lb_porcion)
        Me.porciones.Location = New System.Drawing.Point(4, 22)
        Me.porciones.Name = "porciones"
        Me.porciones.Padding = New System.Windows.Forms.Padding(3)
        Me.porciones.Size = New System.Drawing.Size(264, 175)
        Me.porciones.TabIndex = 3
        Me.porciones.Text = "PORCIONES"
        Me.porciones.UseVisualStyleBackColor = True
        '
        'lb_porcion
        '
        Me.lb_porcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_porcion.FormattingEnabled = True
        Me.lb_porcion.ItemHeight = 16
        Me.lb_porcion.Items.AddRange(New Object() {"STOCK --- ID ---- NOMBRE", "___________________________"})
        Me.lb_porcion.Location = New System.Drawing.Point(3, 3)
        Me.lb_porcion.Name = "lb_porcion"
        Me.lb_porcion.Size = New System.Drawing.Size(258, 244)
        Me.lb_porcion.TabIndex = 430
        Me.lb_porcion.Tag = "ddd"
        '
        'tf_prodTipo
        '
        Me.tf_prodTipo.FormattingEnabled = True
        Me.tf_prodTipo.Location = New System.Drawing.Point(141, 11)
        Me.tf_prodTipo.Name = "tf_prodTipo"
        Me.tf_prodTipo.Size = New System.Drawing.Size(35, 21)
        Me.tf_prodTipo.TabIndex = 425
        Me.tf_prodTipo.Visible = False
        '
        'bt_asignar
        '
        Me.bt_asignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_asignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_asignar.Image = CType(resources.GetObject("bt_asignar.Image"), System.Drawing.Image)
        Me.bt_asignar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_asignar.Location = New System.Drawing.Point(835, 42)
        Me.bt_asignar.Name = "bt_asignar"
        Me.bt_asignar.Size = New System.Drawing.Size(84, 105)
        Me.bt_asignar.TabIndex = 426
        Me.bt_asignar.Text = "ASIGNAR          PEDIDO"
        Me.bt_asignar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_asignar.UseVisualStyleBackColor = False
        '
        'tf_estado
        '
        Me.tf_estado.Enabled = False
        Me.tf_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_estado.Location = New System.Drawing.Point(686, 318)
        Me.tf_estado.Name = "tf_estado"
        Me.tf_estado.Size = New System.Drawing.Size(110, 20)
        Me.tf_estado.TabIndex = 427
        Me.tf_estado.Text = "PENDIENTE"
        Me.tf_estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tf_tipo
        '
        Me.tf_tipo.Enabled = False
        Me.tf_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_tipo.Location = New System.Drawing.Point(695, 390)
        Me.tf_tipo.Name = "tf_tipo"
        Me.tf_tipo.Size = New System.Drawing.Size(110, 20)
        Me.tf_tipo.TabIndex = 350
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(709, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 428
        Me.Label7.Text = "Estado"
        '
        'ch_encurso
        '
        Me.ch_encurso.AutoSize = True
        Me.ch_encurso.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_encurso.ForeColor = System.Drawing.Color.Yellow
        Me.ch_encurso.Location = New System.Drawing.Point(804, 231)
        Me.ch_encurso.Name = "ch_encurso"
        Me.ch_encurso.Size = New System.Drawing.Size(110, 31)
        Me.ch_encurso.TabIndex = 431
        Me.ch_encurso.Text = "Encurso"
        Me.ch_encurso.UseVisualStyleBackColor = True
        '
        'ch_pendiente
        '
        Me.ch_pendiente.AutoSize = True
        Me.ch_pendiente.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_pendiente.ForeColor = System.Drawing.Color.Yellow
        Me.ch_pendiente.Location = New System.Drawing.Point(804, 194)
        Me.ch_pendiente.Name = "ch_pendiente"
        Me.ch_pendiente.Size = New System.Drawing.Size(130, 31)
        Me.ch_pendiente.TabIndex = 430
        Me.ch_pendiente.Text = "Pendiente"
        Me.ch_pendiente.UseVisualStyleBackColor = True
        '
        'ch_pagado
        '
        Me.ch_pagado.AutoSize = True
        Me.ch_pagado.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_pagado.ForeColor = System.Drawing.Color.Yellow
        Me.ch_pagado.Location = New System.Drawing.Point(804, 268)
        Me.ch_pagado.Name = "ch_pagado"
        Me.ch_pagado.Size = New System.Drawing.Size(101, 31)
        Me.ch_pagado.TabIndex = 429
        Me.ch_pagado.Text = "Pagado"
        Me.ch_pagado.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label13.Location = New System.Drawing.Point(829, 161)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 29)
        Me.Label13.TabIndex = 432
        Me.Label13.Text = "Estado"
        '
        'bt_cliente
        '
        Me.bt_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cliente.Image = CType(resources.GetObject("bt_cliente.Image"), System.Drawing.Image)
        Me.bt_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_cliente.Location = New System.Drawing.Point(741, 60)
        Me.bt_cliente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.bt_cliente.Name = "bt_cliente"
        Me.bt_cliente.Size = New System.Drawing.Size(89, 87)
        Me.bt_cliente.TabIndex = 433
        Me.bt_cliente.Text = "REGISTRAR CLIENTE"
        Me.bt_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_cliente.UseVisualStyleBackColor = False
        '
        'tf_mesa
        '
        Me.tf_mesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_mesa.FormattingEnabled = True
        Me.tf_mesa.Location = New System.Drawing.Point(575, 318)
        Me.tf_mesa.Name = "tf_mesa"
        Me.tf_mesa.Size = New System.Drawing.Size(81, 21)
        Me.tf_mesa.TabIndex = 434
        '
        'lb_mesa
        '
        Me.lb_mesa.AutoSize = True
        Me.lb_mesa.BackColor = System.Drawing.Color.Black
        Me.lb_mesa.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_mesa.ForeColor = System.Drawing.Color.Chartreuse
        Me.lb_mesa.Location = New System.Drawing.Point(596, 342)
        Me.lb_mesa.Name = "lb_mesa"
        Me.lb_mesa.Size = New System.Drawing.Size(40, 16)
        Me.lb_mesa.TabIndex = 435
        Me.lb_mesa.Text = "Mesa"
        '
        'tf_nombreCliente
        '
        Me.tf_nombreCliente.Enabled = False
        Me.tf_nombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombreCliente.Location = New System.Drawing.Point(141, 318)
        Me.tf_nombreCliente.Name = "tf_nombreCliente"
        Me.tf_nombreCliente.Size = New System.Drawing.Size(247, 20)
        Me.tf_nombreCliente.TabIndex = 436
        Me.tf_nombreCliente.Text = "S / N"
        '
        'tf_nombreMR
        '
        Me.tf_nombreMR.Enabled = False
        Me.tf_nombreMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombreMR.Location = New System.Drawing.Point(141, 372)
        Me.tf_nombreMR.Name = "tf_nombreMR"
        Me.tf_nombreMR.Size = New System.Drawing.Size(247, 20)
        Me.tf_nombreMR.TabIndex = 437
        '
        'tf_nombremotista
        '
        Me.tf_nombremotista.Enabled = False
        Me.tf_nombremotista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombremotista.Location = New System.Drawing.Point(141, 424)
        Me.tf_nombremotista.Name = "tf_nombremotista"
        Me.tf_nombremotista.Size = New System.Drawing.Size(247, 20)
        Me.tf_nombremotista.TabIndex = 438
        '
        'frm_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(949, 746)
        Me.Controls.Add(Me.tf_nombremotista)
        Me.Controls.Add(Me.tf_nombreMR)
        Me.Controls.Add(Me.tf_nombreCliente)
        Me.Controls.Add(Me.lb_mesa)
        Me.Controls.Add(Me.tf_mesa)
        Me.Controls.Add(Me.bt_cliente)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ch_encurso)
        Me.Controls.Add(Me.ch_pendiente)
        Me.Controls.Add(Me.ch_pagado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tf_estado)
        Me.Controls.Add(Me.bt_asignar)
        Me.Controls.Add(Me.tf_prodTipo)
        Me.Controls.Add(Me.Tab_producto)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.bt_lis_disminuir)
        Me.Controls.Add(Me.bt_lis_eliminar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ch_mesa)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tf_motista)
        Me.Controls.Add(Me.tf_recepcionista)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.tf_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tf_suma)
        Me.Controls.Add(Me.tf_ProdStock)
        Me.Controls.Add(Me.tf_producto2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.bt_mostrar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tf_cantidad)
        Me.Controls.Add(Me.tf_nombre)
        Me.Controls.Add(Me.tf_producto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lb_tipo)
        Me.Controls.Add(Me.tf_montoTotal)
        Me.Controls.Add(Me.tf_fecha)
        Me.Controls.Add(Me.tf_tipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tf_mesero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tf_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tf_pedido)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ch_llevar)
        Me.Controls.Add(Me.Label16)
        Me.Name = "frm_pedido"
        Me.Text = "frm_pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_producto.ResumeLayout(False)
        Me.pollo.ResumeLayout(False)
        Me.res.ResumeLayout(False)
        Me.bebidas.ResumeLayout(False)
        Me.porciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tf_pedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tf_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tf_mesero As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_tipo As System.Windows.Forms.Label
    Friend WithEvents tf_montoTotal As System.Windows.Forms.TextBox
    Friend WithEvents tf_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tf_producto2 As System.Windows.Forms.ListBox
    Friend WithEvents tf_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents tf_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents tf_producto As System.Windows.Forms.ComboBox
    Friend WithEvents tf_ProdStock As System.Windows.Forms.ComboBox
    Friend WithEvents tf_suma As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tf_recepcionista As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tf_motista As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ch_mesa As System.Windows.Forms.CheckBox
    Friend WithEvents ch_llevar As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents bt_lis_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_lis_disminuir As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Tab_producto As System.Windows.Forms.TabControl
    Friend WithEvents pollo As System.Windows.Forms.TabPage
    Friend WithEvents lb_pollo As System.Windows.Forms.ListBox
    Friend WithEvents res As System.Windows.Forms.TabPage
    Friend WithEvents lb_res As System.Windows.Forms.ListBox
    Friend WithEvents bebidas As System.Windows.Forms.TabPage
    Friend WithEvents lb_bebidas As System.Windows.Forms.ListBox
    Friend WithEvents porciones As System.Windows.Forms.TabPage
    Friend WithEvents lb_porcion As System.Windows.Forms.ListBox
    Friend WithEvents tf_prodTipo As System.Windows.Forms.ComboBox
    Friend WithEvents bt_asignar As System.Windows.Forms.Button
    Friend WithEvents tf_estado As System.Windows.Forms.TextBox
    Friend WithEvents tf_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ch_encurso As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pendiente As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pagado As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bt_cliente As System.Windows.Forms.Button
    Friend WithEvents tf_mesa As System.Windows.Forms.ComboBox
    Friend WithEvents lb_mesa As System.Windows.Forms.Label
    Friend WithEvents tf_nombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents tf_nombreMR As System.Windows.Forms.TextBox
    Friend WithEvents tf_nombremotista As System.Windows.Forms.TextBox
End Class
