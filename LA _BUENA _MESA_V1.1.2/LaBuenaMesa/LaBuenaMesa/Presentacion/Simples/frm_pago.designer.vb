<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pago))
        Me.Label14 = New System.Windows.Forms.Label
        Me.tf_montoTotal = New System.Windows.Forms.TextBox
        Me.tf_pedido = New System.Windows.Forms.ComboBox
        Me.tf_caja = New System.Windows.Forms.ComboBox
        Me.tf_cajero = New System.Windows.Forms.ComboBox
        Me.tf_pago = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.bt_guardar = New System.Windows.Forms.Button
        Me.bt_atras = New System.Windows.Forms.Button
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.tf_fechaHora = New System.Windows.Forms.DateTimePicker
        Me.tf_efectivo = New System.Windows.Forms.TextBox
        Me.tf_cambio = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.bt_cliente = New System.Windows.Forms.Button
        Me.tf_producto2 = New System.Windows.Forms.ListBox
        Me.tf_producto = New System.Windows.Forms.ComboBox
        Me.tf_nombre = New System.Windows.Forms.ComboBox
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ch_encurso = New System.Windows.Forms.CheckBox
        Me.ch_pendiente = New System.Windows.Forms.CheckBox
        Me.ch_pagado = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tf_nombreCajero = New System.Windows.Forms.TextBox
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(260, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(468, 46)
        Me.Label14.TabIndex = 303
        Me.Label14.Text = "PAGO-PEDIDO MESA"
        '
        'tf_montoTotal
        '
        Me.tf_montoTotal.Enabled = False
        Me.tf_montoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_montoTotal.Location = New System.Drawing.Point(97, 70)
        Me.tf_montoTotal.Name = "tf_montoTotal"
        Me.tf_montoTotal.Size = New System.Drawing.Size(127, 26)
        Me.tf_montoTotal.TabIndex = 334
        '
        'tf_pedido
        '
        Me.tf_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_pedido.FormattingEnabled = True
        Me.tf_pedido.Location = New System.Drawing.Point(97, 32)
        Me.tf_pedido.Name = "tf_pedido"
        Me.tf_pedido.Size = New System.Drawing.Size(127, 28)
        Me.tf_pedido.TabIndex = 333
        '
        'tf_caja
        '
        Me.tf_caja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_caja.FormattingEnabled = True
        Me.tf_caja.Location = New System.Drawing.Point(297, 37)
        Me.tf_caja.Name = "tf_caja"
        Me.tf_caja.Size = New System.Drawing.Size(115, 28)
        Me.tf_caja.TabIndex = 332
        '
        'tf_cajero
        '
        Me.tf_cajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_cajero.FormattingEnabled = True
        Me.tf_cajero.Location = New System.Drawing.Point(81, 72)
        Me.tf_cajero.Name = "tf_cajero"
        Me.tf_cajero.Size = New System.Drawing.Size(101, 28)
        Me.tf_cajero.TabIndex = 331
        '
        'tf_pago
        '
        Me.tf_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_pago.FormattingEnabled = True
        Me.tf_pago.Location = New System.Drawing.Point(81, 37)
        Me.tf_pago.Name = "tf_pago"
        Me.tf_pago.Size = New System.Drawing.Size(101, 28)
        Me.tf_pago.TabIndex = 330
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label5.Location = New System.Drawing.Point(113, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 25)
        Me.Label5.TabIndex = 346
        Me.Label5.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label4.Location = New System.Drawing.Point(21, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 345
        Me.Label4.Text = "Monto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(17, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 344
        Me.Label3.Text = "Pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(236, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 27)
        Me.Label2.TabIndex = 343
        Me.Label2.Text = "Caja"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label8.Location = New System.Drawing.Point(-1, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 27)
        Me.Label8.TabIndex = 342
        Me.Label8.Text = "Cajero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(16, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 341
        Me.Label1.Text = "Pago"
        '
        'bt_mostrar
        '
        Me.bt_mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_mostrar.Image = CType(resources.GetObject("bt_mostrar.Image"), System.Drawing.Image)
        Me.bt_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_mostrar.Location = New System.Drawing.Point(501, 116)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(84, 75)
        Me.bt_mostrar.TabIndex = 351
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
        Me.bt_eliminar.Location = New System.Drawing.Point(411, 116)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 75)
        Me.bt_eliminar.TabIndex = 350
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
        Me.bt_modificar.Location = New System.Drawing.Point(321, 116)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(84, 75)
        Me.bt_modificar.TabIndex = 349
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
        Me.bt_buscar.Location = New System.Drawing.Point(231, 115)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 348
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
        Me.bt_guardar.Location = New System.Drawing.Point(51, 116)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(84, 75)
        Me.bt_guardar.TabIndex = 347
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
        Me.bt_atras.Location = New System.Drawing.Point(591, 116)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(84, 75)
        Me.bt_atras.TabIndex = 352
        Me.bt_atras.Text = "ATRAS"
        Me.bt_atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_atras.UseVisualStyleBackColor = False
        '
        'dg_mostrar
        '
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.Location = New System.Drawing.Point(179, 231)
        Me.dg_mostrar.Name = "dg_mostrar"
        Me.dg_mostrar.Size = New System.Drawing.Size(493, 173)
        Me.dg_mostrar.TabIndex = 356
        '
        'tf_fechaHora
        '
        Me.tf_fechaHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_fechaHora.Location = New System.Drawing.Point(19, 112)
        Me.tf_fechaHora.Name = "tf_fechaHora"
        Me.tf_fechaHora.Size = New System.Drawing.Size(243, 20)
        Me.tf_fechaHora.TabIndex = 357
        '
        'tf_efectivo
        '
        Me.tf_efectivo.BackColor = System.Drawing.SystemColors.Menu
        Me.tf_efectivo.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_efectivo.ForeColor = System.Drawing.Color.Black
        Me.tf_efectivo.Location = New System.Drawing.Point(277, 32)
        Me.tf_efectivo.Name = "tf_efectivo"
        Me.tf_efectivo.Size = New System.Drawing.Size(131, 40)
        Me.tf_efectivo.TabIndex = 358
        Me.tf_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tf_cambio
        '
        Me.tf_cambio.BackColor = System.Drawing.SystemColors.Menu
        Me.tf_cambio.Enabled = False
        Me.tf_cambio.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_cambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tf_cambio.Location = New System.Drawing.Point(277, 104)
        Me.tf_cambio.Name = "tf_cambio"
        Me.tf_cambio.Size = New System.Drawing.Size(130, 40)
        Me.tf_cambio.TabIndex = 359
        Me.tf_cambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label6.Location = New System.Drawing.Point(292, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 22)
        Me.Label6.TabIndex = 360
        Me.Label6.Text = "EFECTIVO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(305, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 22)
        Me.Label7.TabIndex = 361
        Me.Label7.Text = "CAMBIO"
        '
        'bt_cliente
        '
        Me.bt_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cliente.Image = CType(resources.GetObject("bt_cliente.Image"), System.Drawing.Image)
        Me.bt_cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_cliente.Location = New System.Drawing.Point(860, 104)
        Me.bt_cliente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.bt_cliente.Name = "bt_cliente"
        Me.bt_cliente.Size = New System.Drawing.Size(89, 87)
        Me.bt_cliente.TabIndex = 362
        Me.bt_cliente.Text = "REGISTRAR CLIENTE"
        Me.bt_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_cliente.UseVisualStyleBackColor = False
        '
        'tf_producto2
        '
        Me.tf_producto2.BackColor = System.Drawing.SystemColors.Control
        Me.tf_producto2.FormattingEnabled = True
        Me.tf_producto2.Location = New System.Drawing.Point(688, 231)
        Me.tf_producto2.Name = "tf_producto2"
        Me.tf_producto2.Size = New System.Drawing.Size(242, 173)
        Me.tf_producto2.TabIndex = 363
        '
        'tf_producto
        '
        Me.tf_producto.FormattingEnabled = True
        Me.tf_producto.Location = New System.Drawing.Point(24, 26)
        Me.tf_producto.Name = "tf_producto"
        Me.tf_producto.Size = New System.Drawing.Size(32, 21)
        Me.tf_producto.TabIndex = 364
        Me.tf_producto.Visible = False
        '
        'tf_nombre
        '
        Me.tf_nombre.FormattingEnabled = True
        Me.tf_nombre.Location = New System.Drawing.Point(62, 26)
        Me.tf_nombre.Name = "tf_nombre"
        Me.tf_nombre.Size = New System.Drawing.Size(33, 21)
        Me.tf_nombre.TabIndex = 365
        Me.tf_nombre.Visible = False
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(681, 116)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(84, 75)
        Me.bt_logout.TabIndex = 368
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
        Me.tf_salir.Location = New System.Drawing.Point(771, 115)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(84, 75)
        Me.tf_salir.TabIndex = 367
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
        Me.bt_limpiar.Location = New System.Drawing.Point(141, 115)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 366
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label12.Location = New System.Drawing.Point(882, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 391
        Me.Label12.Text = "Total"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label15.Location = New System.Drawing.Point(682, 211)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 16)
        Me.Label15.TabIndex = 390
        Me.Label15.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label9.Location = New System.Drawing.Point(713, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 389
        Me.Label9.Text = "Precio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label10.Location = New System.Drawing.Point(841, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 388
        Me.Label10.Text = "Nro."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label11.Location = New System.Drawing.Point(768, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 387
        Me.Label11.Text = "Producto"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(101, 24)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(33, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 392
        Me.ProgressBar1.Visible = False
        '
        'ch_encurso
        '
        Me.ch_encurso.AutoSize = True
        Me.ch_encurso.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_encurso.ForeColor = System.Drawing.Color.Yellow
        Me.ch_encurso.Location = New System.Drawing.Point(17, 71)
        Me.ch_encurso.Name = "ch_encurso"
        Me.ch_encurso.Size = New System.Drawing.Size(110, 31)
        Me.ch_encurso.TabIndex = 434
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
        Me.ch_pendiente.Location = New System.Drawing.Point(17, 34)
        Me.ch_pendiente.Name = "ch_pendiente"
        Me.ch_pendiente.Size = New System.Drawing.Size(130, 31)
        Me.ch_pendiente.TabIndex = 433
        Me.ch_pendiente.Text = "Pendiente"
        Me.ch_pendiente.UseVisualStyleBackColor = True
        '
        'ch_pagado
        '
        Me.ch_pagado.AutoSize = True
        Me.ch_pagado.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_pagado.ForeColor = System.Drawing.Color.Yellow
        Me.ch_pagado.Location = New System.Drawing.Point(17, 108)
        Me.ch_pagado.Name = "ch_pagado"
        Me.ch_pagado.Size = New System.Drawing.Size(101, 31)
        Me.ch_pagado.TabIndex = 432
        Me.ch_pagado.Text = "Pagado"
        Me.ch_pagado.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ch_pendiente)
        Me.GroupBox1.Controls.Add(Me.ch_encurso)
        Me.GroupBox1.Controls.Add(Me.ch_pagado)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox1.Location = New System.Drawing.Point(12, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 154)
        Me.GroupBox1.TabIndex = 435
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ESTADO .-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tf_nombreCajero)
        Me.GroupBox2.Controls.Add(Me.tf_pago)
        Me.GroupBox2.Controls.Add(Me.tf_cajero)
        Me.GroupBox2.Controls.Add(Me.tf_caja)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox2.Location = New System.Drawing.Point(24, 467)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 132)
        Me.GroupBox2.TabIndex = 436
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS PAGO .-"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tf_cambio)
        Me.GroupBox3.Controls.Add(Me.tf_pedido)
        Me.GroupBox3.Controls.Add(Me.tf_montoTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tf_fechaHora)
        Me.GroupBox3.Controls.Add(Me.tf_efectivo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox3.Location = New System.Drawing.Point(501, 455)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(426, 176)
        Me.GroupBox3.TabIndex = 437
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS PEDIDO .-"
        '
        'tf_nombreCajero
        '
        Me.tf_nombreCajero.Enabled = False
        Me.tf_nombreCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombreCajero.Location = New System.Drawing.Point(188, 74)
        Me.tf_nombreCajero.Name = "tf_nombreCajero"
        Me.tf_nombreCajero.Size = New System.Drawing.Size(258, 26)
        Me.tf_nombreCajero.TabIndex = 362
        '
        'frm_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(976, 672)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.tf_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.tf_nombre)
        Me.Controls.Add(Me.tf_producto)
        Me.Controls.Add(Me.tf_producto2)
        Me.Controls.Add(Me.bt_cliente)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.bt_mostrar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.Label14)
        Me.Name = "frm_pago"
        Me.Text = "frm_pago"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tf_montoTotal As System.Windows.Forms.TextBox
    Friend WithEvents tf_pedido As System.Windows.Forms.ComboBox
    Friend WithEvents tf_caja As System.Windows.Forms.ComboBox
    Friend WithEvents tf_cajero As System.Windows.Forms.ComboBox
    Friend WithEvents tf_pago As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents tf_fechaHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents tf_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents tf_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bt_cliente As System.Windows.Forms.Button
    Friend WithEvents tf_producto As System.Windows.Forms.ComboBox
    Friend WithEvents tf_nombre As System.Windows.Forms.ComboBox
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ch_encurso As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pendiente As System.Windows.Forms.CheckBox
    Friend WithEvents ch_pagado As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tf_producto2 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tf_nombreCajero As System.Windows.Forms.TextBox
End Class
