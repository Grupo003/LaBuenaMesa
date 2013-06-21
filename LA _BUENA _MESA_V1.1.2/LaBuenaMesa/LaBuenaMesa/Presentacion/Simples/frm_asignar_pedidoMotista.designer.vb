<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_asignar_pedidoMotista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_asignar_pedidoMotista))
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.bt_asignar = New System.Windows.Forms.Button
        Me.bt_atras = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tf_direccion = New System.Windows.Forms.TextBox
        Me.tf_nombreC = New System.Windows.Forms.TextBox
        Me.tf_pedido = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.tf_producto2 = New System.Windows.Forms.ListBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tf_montoTotal = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tf_nombreM = New System.Windows.Forms.TextBox
        Me.tf_motista = New System.Windows.Forms.ComboBox
        Me.tf_telf = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tf_prodTipo = New System.Windows.Forms.ComboBox
        Me.tf_ProdStock = New System.Windows.Forms.ComboBox
        Me.tf_nombre = New System.Windows.Forms.ComboBox
        Me.tf_producto = New System.Windows.Forms.ComboBox
        Me.tf_apell_p = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tf_clienteP = New System.Windows.Forms.TextBox
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.Label16 = New System.Windows.Forms.Label
        Me.ch_encurso = New System.Windows.Forms.CheckBox
        Me.ch_pendiente = New System.Windows.Forms.CheckBox
        Me.ch_pagado = New System.Windows.Forms.CheckBox
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.tf_estado = New System.Windows.Forms.TextBox
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_limpiar
        '
        Me.bt_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_limpiar.Image = CType(resources.GetObject("bt_limpiar.Image"), System.Drawing.Image)
        Me.bt_limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_limpiar.Location = New System.Drawing.Point(236, 77)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 342
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(135, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(687, 46)
        Me.Label14.TabIndex = 341
        Me.Label14.Text = "ASIGNAR  PEDIDO  A  MOTISTA"
        '
        'bt_mostrar
        '
        Me.bt_mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_mostrar.Image = CType(resources.GetObject("bt_mostrar.Image"), System.Drawing.Image)
        Me.bt_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_mostrar.Location = New System.Drawing.Point(596, 77)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(84, 75)
        Me.bt_mostrar.TabIndex = 339
        Me.bt_mostrar.Text = "MOSTRAR"
        Me.bt_mostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_mostrar.UseVisualStyleBackColor = False
        '
        'bt_modificar
        '
        Me.bt_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modificar.Image = CType(resources.GetObject("bt_modificar.Image"), System.Drawing.Image)
        Me.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_modificar.Location = New System.Drawing.Point(416, 77)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(84, 75)
        Me.bt_modificar.TabIndex = 337
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
        Me.bt_buscar.Location = New System.Drawing.Point(326, 77)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 336
        Me.bt_buscar.Text = "BUSCAR"
        Me.bt_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_buscar.UseVisualStyleBackColor = False
        '
        'bt_asignar
        '
        Me.bt_asignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_asignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_asignar.Image = CType(resources.GetObject("bt_asignar.Image"), System.Drawing.Image)
        Me.bt_asignar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_asignar.Location = New System.Drawing.Point(146, 77)
        Me.bt_asignar.Name = "bt_asignar"
        Me.bt_asignar.Size = New System.Drawing.Size(84, 75)
        Me.bt_asignar.TabIndex = 335
        Me.bt_asignar.Text = "ASIGNAR"
        Me.bt_asignar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_asignar.UseVisualStyleBackColor = False
        '
        'bt_atras
        '
        Me.bt_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atras.Image = CType(resources.GetObject("bt_atras.Image"), System.Drawing.Image)
        Me.bt_atras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_atras.Location = New System.Drawing.Point(686, 77)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(84, 75)
        Me.bt_atras.TabIndex = 334
        Me.bt_atras.Text = "ATRAS"
        Me.bt_atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_atras.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(497, 517)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 333
        Me.Label4.Text = "Direccion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(521, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 332
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(513, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 331
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(202, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 330
        Me.Label1.Text = "Pedido"
        '
        'tf_direccion
        '
        Me.tf_direccion.Enabled = False
        Me.tf_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_direccion.Location = New System.Drawing.Point(583, 513)
        Me.tf_direccion.Name = "tf_direccion"
        Me.tf_direccion.Size = New System.Drawing.Size(170, 20)
        Me.tf_direccion.TabIndex = 329
        '
        'tf_nombreC
        '
        Me.tf_nombreC.Enabled = False
        Me.tf_nombreC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombreC.Location = New System.Drawing.Point(583, 461)
        Me.tf_nombreC.Name = "tf_nombreC"
        Me.tf_nombreC.Size = New System.Drawing.Size(170, 20)
        Me.tf_nombreC.TabIndex = 328
        '
        'tf_pedido
        '
        Me.tf_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_pedido.FormattingEnabled = True
        Me.tf_pedido.Location = New System.Drawing.Point(264, 347)
        Me.tf_pedido.Name = "tf_pedido"
        Me.tf_pedido.Size = New System.Drawing.Size(90, 24)
        Me.tf_pedido.TabIndex = 326
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label12.Location = New System.Drawing.Point(275, 391)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 427
        Me.Label12.Text = "Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label15.Location = New System.Drawing.Point(75, 390)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 16)
        Me.Label15.TabIndex = 426
        Me.Label15.Text = "ID"
        '
        'tf_producto2
        '
        Me.tf_producto2.Enabled = False
        Me.tf_producto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_producto2.FormattingEnabled = True
        Me.tf_producto2.ItemHeight = 16
        Me.tf_producto2.Location = New System.Drawing.Point(69, 409)
        Me.tf_producto2.Name = "tf_producto2"
        Me.tf_producto2.Size = New System.Drawing.Size(285, 148)
        Me.tf_producto2.TabIndex = 425
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label9.Location = New System.Drawing.Point(106, 391)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 424
        Me.Label9.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label8.Location = New System.Drawing.Point(234, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 423
        Me.Label8.Text = "Nro."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label10.Location = New System.Drawing.Point(161, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 422
        Me.Label10.Text = "Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label5.Location = New System.Drawing.Point(353, 559)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 421
        Me.Label5.Text = "Monto Total"
        '
        'tf_montoTotal
        '
        Me.tf_montoTotal.Enabled = False
        Me.tf_montoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_montoTotal.Location = New System.Drawing.Point(360, 513)
        Me.tf_montoTotal.Name = "tf_montoTotal"
        Me.tf_montoTotal.Size = New System.Drawing.Size(81, 44)
        Me.tf_montoTotal.TabIndex = 420
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(521, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 431
        Me.Label6.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(513, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 430
        Me.Label7.Text = "Motista"
        '
        'tf_nombreM
        '
        Me.tf_nombreM.Enabled = False
        Me.tf_nombreM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombreM.Location = New System.Drawing.Point(583, 370)
        Me.tf_nombreM.Name = "tf_nombreM"
        Me.tf_nombreM.Size = New System.Drawing.Size(170, 20)
        Me.tf_nombreM.TabIndex = 429
        '
        'tf_motista
        '
        Me.tf_motista.FormattingEnabled = True
        Me.tf_motista.Location = New System.Drawing.Point(583, 343)
        Me.tf_motista.Name = "tf_motista"
        Me.tf_motista.Size = New System.Drawing.Size(80, 21)
        Me.tf_motista.TabIndex = 428
        '
        'tf_telf
        '
        Me.tf_telf.Enabled = False
        Me.tf_telf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_telf.Location = New System.Drawing.Point(583, 539)
        Me.tf_telf.Name = "tf_telf"
        Me.tf_telf.Size = New System.Drawing.Size(170, 20)
        Me.tf_telf.TabIndex = 432
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(505, 543)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 433
        Me.Label11.Text = "telefono"
        '
        'tf_prodTipo
        '
        Me.tf_prodTipo.FormattingEnabled = True
        Me.tf_prodTipo.Location = New System.Drawing.Point(138, 12)
        Me.tf_prodTipo.Name = "tf_prodTipo"
        Me.tf_prodTipo.Size = New System.Drawing.Size(35, 21)
        Me.tf_prodTipo.TabIndex = 437
        Me.tf_prodTipo.Visible = False
        '
        'tf_ProdStock
        '
        Me.tf_ProdStock.FormattingEnabled = True
        Me.tf_ProdStock.Location = New System.Drawing.Point(97, 12)
        Me.tf_ProdStock.Name = "tf_ProdStock"
        Me.tf_ProdStock.Size = New System.Drawing.Size(35, 21)
        Me.tf_ProdStock.TabIndex = 436
        Me.tf_ProdStock.Visible = False
        '
        'tf_nombre
        '
        Me.tf_nombre.FormattingEnabled = True
        Me.tf_nombre.Location = New System.Drawing.Point(50, 12)
        Me.tf_nombre.Name = "tf_nombre"
        Me.tf_nombre.Size = New System.Drawing.Size(40, 21)
        Me.tf_nombre.TabIndex = 435
        Me.tf_nombre.Visible = False
        '
        'tf_producto
        '
        Me.tf_producto.FormattingEnabled = True
        Me.tf_producto.Location = New System.Drawing.Point(12, 12)
        Me.tf_producto.Name = "tf_producto"
        Me.tf_producto.Size = New System.Drawing.Size(31, 21)
        Me.tf_producto.TabIndex = 434
        Me.tf_producto.Visible = False
        '
        'tf_apell_p
        '
        Me.tf_apell_p.Enabled = False
        Me.tf_apell_p.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_apell_p.Location = New System.Drawing.Point(583, 487)
        Me.tf_apell_p.Name = "tf_apell_p"
        Me.tf_apell_p.Size = New System.Drawing.Size(170, 20)
        Me.tf_apell_p.TabIndex = 438
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(497, 491)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 439
        Me.Label13.Text = "Apell Pat"
        '
        'tf_clienteP
        '
        Me.tf_clienteP.Enabled = False
        Me.tf_clienteP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_clienteP.Location = New System.Drawing.Point(583, 435)
        Me.tf_clienteP.Name = "tf_clienteP"
        Me.tf_clienteP.Size = New System.Drawing.Size(170, 20)
        Me.tf_clienteP.TabIndex = 440
        '
        'dg_mostrar
        '
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.Location = New System.Drawing.Point(155, 175)
        Me.dg_mostrar.Name = "dg_mostrar"
        Me.dg_mostrar.Size = New System.Drawing.Size(354, 129)
        Me.dg_mostrar.TabIndex = 441
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label16.Location = New System.Drawing.Point(605, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 29)
        Me.Label16.TabIndex = 445
        Me.Label16.Text = "Estado"
        '
        'ch_encurso
        '
        Me.ch_encurso.AutoSize = True
        Me.ch_encurso.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_encurso.ForeColor = System.Drawing.Color.Yellow
        Me.ch_encurso.Location = New System.Drawing.Point(596, 238)
        Me.ch_encurso.Name = "ch_encurso"
        Me.ch_encurso.Size = New System.Drawing.Size(110, 31)
        Me.ch_encurso.TabIndex = 444
        Me.ch_encurso.Text = "Encurso"
        Me.ch_encurso.UseVisualStyleBackColor = True
        '
        'ch_pendiente
        '
        Me.ch_pendiente.AutoSize = True
        Me.ch_pendiente.Checked = True
        Me.ch_pendiente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ch_pendiente.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_pendiente.ForeColor = System.Drawing.Color.Yellow
        Me.ch_pendiente.Location = New System.Drawing.Point(596, 201)
        Me.ch_pendiente.Name = "ch_pendiente"
        Me.ch_pendiente.Size = New System.Drawing.Size(130, 31)
        Me.ch_pendiente.TabIndex = 443
        Me.ch_pendiente.Text = "Pendiente"
        Me.ch_pendiente.UseVisualStyleBackColor = True
        '
        'ch_pagado
        '
        Me.ch_pagado.AutoSize = True
        Me.ch_pagado.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_pagado.ForeColor = System.Drawing.Color.Yellow
        Me.ch_pagado.Location = New System.Drawing.Point(596, 275)
        Me.ch_pagado.Name = "ch_pagado"
        Me.ch_pagado.Size = New System.Drawing.Size(101, 31)
        Me.ch_pagado.TabIndex = 442
        Me.ch_pagado.Text = "Pagado"
        Me.ch_pagado.UseVisualStyleBackColor = True
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_eliminar.Image = CType(resources.GetObject("bt_eliminar.Image"), System.Drawing.Image)
        Me.bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_eliminar.Location = New System.Drawing.Point(506, 77)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 75)
        Me.bt_eliminar.TabIndex = 446
        Me.bt_eliminar.Text = "ELIMINAR"
        Me.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_eliminar.UseVisualStyleBackColor = False
        '
        'tf_estado
        '
        Me.tf_estado.Enabled = False
        Me.tf_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_estado.Location = New System.Drawing.Point(179, 12)
        Me.tf_estado.Name = "tf_estado"
        Me.tf_estado.Size = New System.Drawing.Size(141, 20)
        Me.tf_estado.TabIndex = 447
        Me.tf_estado.Visible = False
        '
        'frm_asignar_pedidoMotista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(842, 615)
        Me.Controls.Add(Me.tf_estado)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ch_encurso)
        Me.Controls.Add(Me.ch_pendiente)
        Me.Controls.Add(Me.ch_pagado)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.tf_clienteP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tf_apell_p)
        Me.Controls.Add(Me.tf_prodTipo)
        Me.Controls.Add(Me.tf_ProdStock)
        Me.Controls.Add(Me.tf_nombre)
        Me.Controls.Add(Me.tf_producto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tf_telf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tf_nombreM)
        Me.Controls.Add(Me.tf_motista)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tf_producto2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tf_montoTotal)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bt_mostrar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_asignar)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tf_direccion)
        Me.Controls.Add(Me.tf_nombreC)
        Me.Controls.Add(Me.tf_pedido)
        Me.Name = "frm_asignar_pedidoMotista"
        Me.Text = "frm_asignar_pedidoMotista"
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents bt_asignar As System.Windows.Forms.Button
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tf_direccion As System.Windows.Forms.TextBox
    Friend WithEvents tf_nombreC As System.Windows.Forms.TextBox
    Friend WithEvents tf_pedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tf_producto2 As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tf_montoTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tf_nombreM As System.Windows.Forms.TextBox
    Friend WithEvents tf_motista As System.Windows.Forms.ComboBox
    Friend WithEvents tf_telf As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tf_prodTipo As System.Windows.Forms.ComboBox
    Friend WithEvents tf_ProdStock As System.Windows.Forms.ComboBox
    Friend WithEvents tf_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents tf_producto As System.Windows.Forms.ComboBox
    Friend WithEvents tf_apell_p As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tf_clienteP As System.Windows.Forms.TextBox
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ch_encurso As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pendiente As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pagado As System.Windows.Forms.CheckBox
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents tf_estado As System.Windows.Forms.TextBox
End Class
