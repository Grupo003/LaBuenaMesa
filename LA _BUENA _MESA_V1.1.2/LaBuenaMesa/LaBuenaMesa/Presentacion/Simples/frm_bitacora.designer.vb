<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_bitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_bitacora))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tf_nombre = New System.Windows.Forms.TextBox
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.bt_atras = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.tf_usuario = New System.Windows.Forms.Label
        Me.ch_acciones_usuario = New System.Windows.Forms.CheckBox
        Me.ch_bitacora = New System.Windows.Forms.CheckBox
        Me.fc_Inicio = New System.Windows.Forms.DateTimePicker
        Me.fc_Final = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tf_accionesUsuario = New System.Windows.Forms.CheckBox
        Me.ch_fcEntre = New System.Windows.Forms.CheckBox
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tf_nombre
        '
        Me.tf_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_nombre.Location = New System.Drawing.Point(144, 257)
        Me.tf_nombre.Name = "tf_nombre"
        Me.tf_nombre.Size = New System.Drawing.Size(172, 38)
        Me.tf_nombre.TabIndex = 396
        Me.tf_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tf_nombre.Visible = False
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(441, 572)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(84, 75)
        Me.bt_logout.TabIndex = 395
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
        Me.tf_salir.Location = New System.Drawing.Point(531, 572)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(84, 75)
        Me.tf_salir.TabIndex = 394
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
        Me.bt_limpiar.Location = New System.Drawing.Point(21, 226)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 393
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        Me.bt_limpiar.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(58, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(879, 46)
        Me.Label14.TabIndex = 392
        Me.Label14.Text = "BITACORA  Y  ACCIONES  DEL  USUARIO"
        '
        'dg_mostrar
        '
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.Location = New System.Drawing.Point(157, 318)
        Me.dg_mostrar.Name = "dg_mostrar"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_mostrar.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_mostrar.Size = New System.Drawing.Size(676, 220)
        Me.dg_mostrar.TabIndex = 391
        '
        'bt_atras
        '
        Me.bt_atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_atras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_atras.Image = CType(resources.GetObject("bt_atras.Image"), System.Drawing.Image)
        Me.bt_atras.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_atras.Location = New System.Drawing.Point(351, 572)
        Me.bt_atras.Name = "bt_atras"
        Me.bt_atras.Size = New System.Drawing.Size(84, 75)
        Me.bt_atras.TabIndex = 390
        Me.bt_atras.Text = "ATRAS"
        Me.bt_atras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_atras.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(353, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 75)
        Me.Button1.TabIndex = 389
        Me.Button1.Text = "MOSTRAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bt_buscar
        '
        Me.bt_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_buscar.Image = CType(resources.GetObject("bt_buscar.Image"), System.Drawing.Image)
        Me.bt_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_buscar.Location = New System.Drawing.Point(21, 145)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 386
        Me.bt_buscar.Text = "BUSCAR"
        Me.bt_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_buscar.UseVisualStyleBackColor = False
        Me.bt_buscar.Visible = False
        '
        'tf_usuario
        '
        Me.tf_usuario.AutoSize = True
        Me.tf_usuario.BackColor = System.Drawing.Color.Red
        Me.tf_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_usuario.ForeColor = System.Drawing.Color.Chartreuse
        Me.tf_usuario.Location = New System.Drawing.Point(175, 298)
        Me.tf_usuario.Name = "tf_usuario"
        Me.tf_usuario.Size = New System.Drawing.Size(103, 29)
        Me.tf_usuario.TabIndex = 383
        Me.tf_usuario.Text = "Usuario"
        Me.tf_usuario.Visible = False
        '
        'ch_acciones_usuario
        '
        Me.ch_acciones_usuario.AutoSize = True
        Me.ch_acciones_usuario.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_acciones_usuario.ForeColor = System.Drawing.Color.Yellow
        Me.ch_acciones_usuario.Location = New System.Drawing.Point(443, 216)
        Me.ch_acciones_usuario.Name = "ch_acciones_usuario"
        Me.ch_acciones_usuario.Size = New System.Drawing.Size(262, 35)
        Me.ch_acciones_usuario.TabIndex = 398
        Me.ch_acciones_usuario.Text = "Acciones del Usuario"
        Me.ch_acciones_usuario.UseVisualStyleBackColor = True
        '
        'ch_bitacora
        '
        Me.ch_bitacora.AutoSize = True
        Me.ch_bitacora.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_bitacora.ForeColor = System.Drawing.Color.Yellow
        Me.ch_bitacora.Location = New System.Drawing.Point(443, 172)
        Me.ch_bitacora.Name = "ch_bitacora"
        Me.ch_bitacora.Size = New System.Drawing.Size(123, 35)
        Me.ch_bitacora.TabIndex = 397
        Me.ch_bitacora.Text = "Bitacora"
        Me.ch_bitacora.UseVisualStyleBackColor = True
        '
        'fc_Inicio
        '
        Me.fc_Inicio.Location = New System.Drawing.Point(747, 160)
        Me.fc_Inicio.Name = "fc_Inicio"
        Me.fc_Inicio.Size = New System.Drawing.Size(199, 20)
        Me.fc_Inicio.TabIndex = 399
        Me.fc_Inicio.Visible = False
        '
        'fc_Final
        '
        Me.fc_Final.Location = New System.Drawing.Point(747, 238)
        Me.fc_Final.Name = "fc_Final"
        Me.fc_Final.Size = New System.Drawing.Size(199, 20)
        Me.fc_Final.TabIndex = 400
        Me.fc_Final.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label4.Location = New System.Drawing.Point(768, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 29)
        Me.Label4.TabIndex = 402
        Me.Label4.Text = "Fecha Inicio"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(768, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 29)
        Me.Label3.TabIndex = 403
        Me.Label3.Text = "Fecha Final"
        Me.Label3.Visible = False
        '
        'tf_accionesUsuario
        '
        Me.tf_accionesUsuario.AutoSize = True
        Me.tf_accionesUsuario.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_accionesUsuario.ForeColor = System.Drawing.Color.Yellow
        Me.tf_accionesUsuario.Location = New System.Drawing.Point(111, 185)
        Me.tf_accionesUsuario.Name = "tf_accionesUsuario"
        Me.tf_accionesUsuario.Size = New System.Drawing.Size(262, 35)
        Me.tf_accionesUsuario.TabIndex = 405
        Me.tf_accionesUsuario.Text = "Acciones del Usuario"
        Me.tf_accionesUsuario.UseVisualStyleBackColor = True
        Me.tf_accionesUsuario.Visible = False
        '
        'ch_fcEntre
        '
        Me.ch_fcEntre.AutoSize = True
        Me.ch_fcEntre.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_fcEntre.ForeColor = System.Drawing.Color.Yellow
        Me.ch_fcEntre.Location = New System.Drawing.Point(111, 145)
        Me.ch_fcEntre.Name = "ch_fcEntre"
        Me.ch_fcEntre.Size = New System.Drawing.Size(215, 35)
        Me.ch_fcEntre.TabIndex = 404
        Me.ch_fcEntre.Text = "Entres las fechas"
        Me.ch_fcEntre.UseVisualStyleBackColor = True
        Me.ch_fcEntre.Visible = False
        '
        'frm_bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(975, 673)
        Me.Controls.Add(Me.tf_accionesUsuario)
        Me.Controls.Add(Me.ch_fcEntre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fc_Final)
        Me.Controls.Add(Me.fc_Inicio)
        Me.Controls.Add(Me.ch_acciones_usuario)
        Me.Controls.Add(Me.ch_bitacora)
        Me.Controls.Add(Me.tf_nombre)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.tf_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.bt_atras)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.tf_usuario)
        Me.Name = "frm_bitacora"
        Me.Text = "frm_bitacora"
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tf_nombre As System.Windows.Forms.TextBox
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_atras As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents tf_usuario As System.Windows.Forms.Label
    Friend WithEvents ch_acciones_usuario As System.Windows.Forms.CheckBox
    Friend WithEvents ch_bitacora As System.Windows.Forms.CheckBox
    Friend WithEvents fc_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fc_Final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tf_accionesUsuario As System.Windows.Forms.CheckBox
    Friend WithEvents ch_fcEntre As System.Windows.Forms.CheckBox
End Class
