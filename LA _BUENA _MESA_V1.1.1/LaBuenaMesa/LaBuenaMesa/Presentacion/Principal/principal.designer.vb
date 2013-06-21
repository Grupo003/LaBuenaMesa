<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarMeseroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarAdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarCajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarTipoAdmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ObjetosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RealizarPedidoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DetallePedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RealizarPedidoPasoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetallePedidoPasoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PruebaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MontoSiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CajaCajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestionarProductoSiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductoCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.bt_gestionarRegistro = New System.Windows.Forms.Button
        Me.bt_logout = New System.Windows.Forms.Button
        Me.bt_gestionarPedido = New System.Windows.Forms.Button
        Me.bt_gestionarVenta = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.bt_gestionarReportes = New System.Windows.Forms.Button
        Me.bt_salir = New System.Windows.Forms.Button
        Me.bt_gestionarBitacora = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.ObjetosToolStripMenuItem, Me.CajaToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarClienteToolStripMenuItem, Me.GestionarMeseroToolStripMenuItem, Me.GestionarAdministradorToolStripMenuItem, Me.GestionarCajeroToolStripMenuItem, Me.GestionarTipoAdmToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.UsuarioToolStripMenuItem.Text = "Gestionar Peson"
        '
        'GestionarClienteToolStripMenuItem
        '
        Me.GestionarClienteToolStripMenuItem.Name = "GestionarClienteToolStripMenuItem"
        Me.GestionarClienteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionarClienteToolStripMenuItem.Text = "Gestionar Cliente"
        '
        'GestionarMeseroToolStripMenuItem
        '
        Me.GestionarMeseroToolStripMenuItem.Name = "GestionarMeseroToolStripMenuItem"
        Me.GestionarMeseroToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionarMeseroToolStripMenuItem.Text = "Gestionar Mesero"
        '
        'GestionarAdministradorToolStripMenuItem
        '
        Me.GestionarAdministradorToolStripMenuItem.Name = "GestionarAdministradorToolStripMenuItem"
        Me.GestionarAdministradorToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionarAdministradorToolStripMenuItem.Text = "Gestionar AMD"
        '
        'GestionarCajeroToolStripMenuItem
        '
        Me.GestionarCajeroToolStripMenuItem.Name = "GestionarCajeroToolStripMenuItem"
        Me.GestionarCajeroToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionarCajeroToolStripMenuItem.Text = "Gestionar Cajero"
        '
        'GestionarTipoAdmToolStripMenuItem
        '
        Me.GestionarTipoAdmToolStripMenuItem.Name = "GestionarTipoAdmToolStripMenuItem"
        Me.GestionarTipoAdmToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionarTipoAdmToolStripMenuItem.Text = "Gestionar Tipo  Adm"
        '
        'ObjetosToolStripMenuItem
        '
        Me.ObjetosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarPedidoToolStripMenuItem1, Me.DetallePedidoToolStripMenuItem, Me.RealizarPedidoPasoToolStripMenuItem, Me.DetallePedidoPasoToolStripMenuItem, Me.PagoToolStripMenuItem, Me.PruebaToolStripMenuItem})
        Me.ObjetosToolStripMenuItem.Name = "ObjetosToolStripMenuItem"
        Me.ObjetosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ObjetosToolStripMenuItem.Text = "Pedido"
        '
        'RealizarPedidoToolStripMenuItem1
        '
        Me.RealizarPedidoToolStripMenuItem1.Name = "RealizarPedidoToolStripMenuItem1"
        Me.RealizarPedidoToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.RealizarPedidoToolStripMenuItem1.Text = "Realizar Pedido"
        '
        'DetallePedidoToolStripMenuItem
        '
        Me.DetallePedidoToolStripMenuItem.Name = "DetallePedidoToolStripMenuItem"
        Me.DetallePedidoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DetallePedidoToolStripMenuItem.Text = "Detalle Pedido"
        '
        'RealizarPedidoPasoToolStripMenuItem
        '
        Me.RealizarPedidoPasoToolStripMenuItem.Name = "RealizarPedidoPasoToolStripMenuItem"
        Me.RealizarPedidoPasoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RealizarPedidoPasoToolStripMenuItem.Text = "Realizar Pedido paso"
        '
        'DetallePedidoPasoToolStripMenuItem
        '
        Me.DetallePedidoPasoToolStripMenuItem.Name = "DetallePedidoPasoToolStripMenuItem"
        Me.DetallePedidoPasoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DetallePedidoPasoToolStripMenuItem.Text = "Detalle Pedido Paso"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PagoToolStripMenuItem.Text = "Pago"
        '
        'PruebaToolStripMenuItem
        '
        Me.PruebaToolStripMenuItem.Name = "PruebaToolStripMenuItem"
        Me.PruebaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PruebaToolStripMenuItem.Text = "Prueba"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarCajaToolStripMenuItem, Me.MontoSiToolStripMenuItem, Me.CajaCajeroToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'GestionarCajaToolStripMenuItem
        '
        Me.GestionarCajaToolStripMenuItem.Name = "GestionarCajaToolStripMenuItem"
        Me.GestionarCajaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GestionarCajaToolStripMenuItem.Text = "Gestionar Caja"
        '
        'MontoSiToolStripMenuItem
        '
        Me.MontoSiToolStripMenuItem.Name = "MontoSiToolStripMenuItem"
        Me.MontoSiToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.MontoSiToolStripMenuItem.Text = "Monto"
        '
        'CajaCajeroToolStripMenuItem
        '
        Me.CajaCajeroToolStripMenuItem.Name = "CajaCajeroToolStripMenuItem"
        Me.CajaCajeroToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CajaCajeroToolStripMenuItem.Text = "Caja Cajero"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarProductoSiToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'GestionarProductoSiToolStripMenuItem
        '
        Me.GestionarProductoSiToolStripMenuItem.Name = "GestionarProductoSiToolStripMenuItem"
        Me.GestionarProductoSiToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GestionarProductoSiToolStripMenuItem.Text = "Gestionar Producto"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem1, Me.ProductoCompraToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'ProductoCompraToolStripMenuItem
        '
        Me.ProductoCompraToolStripMenuItem.Name = "ProductoCompraToolStripMenuItem"
        Me.ProductoCompraToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ProductoCompraToolStripMenuItem.Text = "Producto Compra"
        '
        'bt_gestionarRegistro
        '
        Me.bt_gestionarRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_gestionarRegistro.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_gestionarRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gestionarRegistro.ForeColor = System.Drawing.Color.Black
        Me.bt_gestionarRegistro.Image = CType(resources.GetObject("bt_gestionarRegistro.Image"), System.Drawing.Image)
        Me.bt_gestionarRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_gestionarRegistro.Location = New System.Drawing.Point(165, 40)
        Me.bt_gestionarRegistro.Name = "bt_gestionarRegistro"
        Me.bt_gestionarRegistro.Size = New System.Drawing.Size(84, 75)
        Me.bt_gestionarRegistro.TabIndex = 203
        Me.bt_gestionarRegistro.Text = "REGISTRO"
        Me.bt_gestionarRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_gestionarRegistro.UseVisualStyleBackColor = False
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.ForeColor = System.Drawing.Color.Black
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(226, 148)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(84, 75)
        Me.bt_logout.TabIndex = 204
        Me.bt_logout.Text = "LOGOUT"
        Me.bt_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_logout.UseVisualStyleBackColor = False
        '
        'bt_gestionarPedido
        '
        Me.bt_gestionarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_gestionarPedido.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_gestionarPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gestionarPedido.ForeColor = System.Drawing.Color.Black
        Me.bt_gestionarPedido.Image = CType(resources.GetObject("bt_gestionarPedido.Image"), System.Drawing.Image)
        Me.bt_gestionarPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_gestionarPedido.Location = New System.Drawing.Point(41, 40)
        Me.bt_gestionarPedido.Name = "bt_gestionarPedido"
        Me.bt_gestionarPedido.Size = New System.Drawing.Size(84, 75)
        Me.bt_gestionarPedido.TabIndex = 205
        Me.bt_gestionarPedido.Text = "PEDIDO"
        Me.bt_gestionarPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_gestionarPedido.UseVisualStyleBackColor = False
        '
        'bt_gestionarVenta
        '
        Me.bt_gestionarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_gestionarVenta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_gestionarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gestionarVenta.ForeColor = System.Drawing.Color.Black
        Me.bt_gestionarVenta.Image = CType(resources.GetObject("bt_gestionarVenta.Image"), System.Drawing.Image)
        Me.bt_gestionarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_gestionarVenta.Location = New System.Drawing.Point(288, 40)
        Me.bt_gestionarVenta.Name = "bt_gestionarVenta"
        Me.bt_gestionarVenta.Size = New System.Drawing.Size(84, 75)
        Me.bt_gestionarVenta.TabIndex = 206
        Me.bt_gestionarVenta.Text = "VENTAS"
        Me.bt_gestionarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_gestionarVenta.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(357, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(255, 46)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "PAQUETES"
        '
        'bt_gestionarReportes
        '
        Me.bt_gestionarReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_gestionarReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gestionarReportes.ForeColor = System.Drawing.Color.Black
        Me.bt_gestionarReportes.Image = CType(resources.GetObject("bt_gestionarReportes.Image"), System.Drawing.Image)
        Me.bt_gestionarReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_gestionarReportes.Location = New System.Drawing.Point(536, 40)
        Me.bt_gestionarReportes.Name = "bt_gestionarReportes"
        Me.bt_gestionarReportes.Size = New System.Drawing.Size(84, 75)
        Me.bt_gestionarReportes.TabIndex = 208
        Me.bt_gestionarReportes.Text = "REPORTES"
        Me.bt_gestionarReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_gestionarReportes.UseVisualStyleBackColor = False
        '
        'bt_salir
        '
        Me.bt_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_salir.ForeColor = System.Drawing.Color.Black
        Me.bt_salir.Image = CType(resources.GetObject("bt_salir.Image"), System.Drawing.Image)
        Me.bt_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_salir.Location = New System.Drawing.Point(332, 148)
        Me.bt_salir.Name = "bt_salir"
        Me.bt_salir.Size = New System.Drawing.Size(84, 75)
        Me.bt_salir.TabIndex = 209
        Me.bt_salir.Text = "SALIR"
        Me.bt_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_salir.UseVisualStyleBackColor = False
        '
        'bt_gestionarBitacora
        '
        Me.bt_gestionarBitacora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_gestionarBitacora.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_gestionarBitacora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_gestionarBitacora.ForeColor = System.Drawing.Color.Black
        Me.bt_gestionarBitacora.Image = CType(resources.GetObject("bt_gestionarBitacora.Image"), System.Drawing.Image)
        Me.bt_gestionarBitacora.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_gestionarBitacora.Location = New System.Drawing.Point(408, 40)
        Me.bt_gestionarBitacora.Name = "bt_gestionarBitacora"
        Me.bt_gestionarBitacora.Size = New System.Drawing.Size(84, 75)
        Me.bt_gestionarBitacora.TabIndex = 210
        Me.bt_gestionarBitacora.Text = "BITACORA"
        Me.bt_gestionarBitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_gestionarBitacora.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bt_gestionarVenta)
        Me.GroupBox1.Controls.Add(Me.bt_gestionarBitacora)
        Me.GroupBox1.Controls.Add(Me.bt_gestionarRegistro)
        Me.GroupBox1.Controls.Add(Me.bt_salir)
        Me.GroupBox1.Controls.Add(Me.bt_logout)
        Me.GroupBox1.Controls.Add(Me.bt_gestionarReportes)
        Me.GroupBox1.Controls.Add(Me.bt_gestionarPedido)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox1.Location = New System.Drawing.Point(174, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 265)
        Me.GroupBox1.TabIndex = 370
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GESTION DE PAQUETES"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(947, 643)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_Principal"
        Me.Text = "PRINCIPAL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarMeseroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarAdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarCajeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarTipoAdmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObjetosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarPedidoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetallePedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarProductoSiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionarCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MontoSiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarPedidoPasoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetallePedidoPasoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaCajeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PruebaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bt_gestionarRegistro As System.Windows.Forms.Button
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents bt_gestionarPedido As System.Windows.Forms.Button
    Friend WithEvents bt_gestionarVenta As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bt_gestionarReportes As System.Windows.Forms.Button
    Friend WithEvents bt_salir As System.Windows.Forms.Button
    Friend WithEvents bt_gestionarBitacora As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
