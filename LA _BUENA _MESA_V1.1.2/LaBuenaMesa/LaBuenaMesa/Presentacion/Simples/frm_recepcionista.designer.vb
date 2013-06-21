<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recepcionista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recepcionista))
        Me.tf_login = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.tf_grupo = New System.Windows.Forms.ComboBox
        Me.bt_logout = New System.Windows.Forms.Button
        Me.tf_salir = New System.Windows.Forms.Button
        Me.bt_limpiar = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.tf_fn = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.dg_mostrar = New System.Windows.Forms.DataGridView
        Me.bt_mostrar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.bt_modificar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.bt_guardar = New System.Windows.Forms.Button
        Me.tf_contraseña = New System.Windows.Forms.TextBox
        Me.cb_sexo = New System.Windows.Forms.ComboBox
        Me.tf_estado = New System.Windows.Forms.TextBox
        Me.tf_cel = New System.Windows.Forms.TextBox
        Me.tf_telf = New System.Windows.Forms.TextBox
        Me.tf_dir = New System.Windows.Forms.TextBox
        Me.tf_am = New System.Windows.Forms.TextBox
        Me.tf_ap = New System.Windows.Forms.TextBox
        Me.tf_nombre = New System.Windows.Forms.TextBox
        Me.tf_ci = New System.Windows.Forms.ComboBox
        Me.txt_razon = New System.Windows.Forms.Label
        Me.txt_nit = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ch_deshabilitado = New System.Windows.Forms.CheckBox
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tf_login
        '
        Me.tf_login.Location = New System.Drawing.Point(163, 438)
        Me.tf_login.Name = "tf_login"
        Me.tf_login.Size = New System.Drawing.Size(138, 20)
        Me.tf_login.TabIndex = 432
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label13.Location = New System.Drawing.Point(108, 522)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 431
        Me.Label13.Text = "Grupo"
        '
        'tf_grupo
        '
        Me.tf_grupo.FormattingEnabled = True
        Me.tf_grupo.Location = New System.Drawing.Point(163, 517)
        Me.tf_grupo.Name = "tf_grupo"
        Me.tf_grupo.Size = New System.Drawing.Size(138, 21)
        Me.tf_grupo.TabIndex = 430
        '
        'bt_logout
        '
        Me.bt_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_logout.Image = CType(resources.GetObject("bt_logout.Image"), System.Drawing.Image)
        Me.bt_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_logout.Location = New System.Drawing.Point(736, 103)
        Me.bt_logout.Name = "bt_logout"
        Me.bt_logout.Size = New System.Drawing.Size(84, 75)
        Me.bt_logout.TabIndex = 429
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
        Me.tf_salir.Location = New System.Drawing.Point(826, 103)
        Me.tf_salir.Name = "tf_salir"
        Me.tf_salir.Size = New System.Drawing.Size(84, 75)
        Me.tf_salir.TabIndex = 428
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
        Me.bt_limpiar.Location = New System.Drawing.Point(196, 102)
        Me.bt_limpiar.Name = "bt_limpiar"
        Me.bt_limpiar.Size = New System.Drawing.Size(84, 75)
        Me.bt_limpiar.TabIndex = 427
        Me.bt_limpiar.Text = "LIMPIAR"
        Me.bt_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_limpiar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Georgia", 30.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label11.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label11.Location = New System.Drawing.Point(249, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(381, 46)
        Me.Label11.TabIndex = 426
        Me.Label11.Text = "RECEPCIONISTA"
        '
        'tf_fn
        '
        Me.tf_fn.Location = New System.Drawing.Point(85, 334)
        Me.tf_fn.Name = "tf_fn"
        Me.tf_fn.Size = New System.Drawing.Size(216, 20)
        Me.tf_fn.TabIndex = 425
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(646, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 75)
        Me.Button1.TabIndex = 424
        Me.Button1.Text = "ATRAS"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dg_mostrar
        '
        Me.dg_mostrar.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mostrar.GridColor = System.Drawing.SystemColors.Control
        Me.dg_mostrar.Location = New System.Drawing.Point(307, 211)
        Me.dg_mostrar.Name = "dg_mostrar"
        Me.dg_mostrar.Size = New System.Drawing.Size(603, 319)
        Me.dg_mostrar.TabIndex = 423
        '
        'bt_mostrar
        '
        Me.bt_mostrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bt_mostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_mostrar.Image = CType(resources.GetObject("bt_mostrar.Image"), System.Drawing.Image)
        Me.bt_mostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_mostrar.Location = New System.Drawing.Point(556, 102)
        Me.bt_mostrar.Name = "bt_mostrar"
        Me.bt_mostrar.Size = New System.Drawing.Size(84, 75)
        Me.bt_mostrar.TabIndex = 422
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
        Me.bt_eliminar.Location = New System.Drawing.Point(466, 102)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(84, 75)
        Me.bt_eliminar.TabIndex = 421
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
        Me.bt_modificar.Location = New System.Drawing.Point(376, 102)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(84, 75)
        Me.bt_modificar.TabIndex = 420
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
        Me.bt_buscar.Location = New System.Drawing.Point(286, 103)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(84, 75)
        Me.bt_buscar.TabIndex = 419
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
        Me.bt_guardar.Location = New System.Drawing.Point(106, 102)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(84, 75)
        Me.bt_guardar.TabIndex = 418
        Me.bt_guardar.Text = "GUARDAR"
        Me.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_guardar.UseVisualStyleBackColor = False
        '
        'tf_contraseña
        '
        Me.tf_contraseña.Location = New System.Drawing.Point(163, 464)
        Me.tf_contraseña.Name = "tf_contraseña"
        Me.tf_contraseña.Size = New System.Drawing.Size(138, 20)
        Me.tf_contraseña.TabIndex = 417
        '
        'cb_sexo
        '
        Me.cb_sexo.FormattingEnabled = True
        Me.cb_sexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cb_sexo.Location = New System.Drawing.Point(163, 411)
        Me.cb_sexo.Name = "cb_sexo"
        Me.cb_sexo.Size = New System.Drawing.Size(138, 21)
        Me.cb_sexo.TabIndex = 416
        '
        'tf_estado
        '
        Me.tf_estado.Location = New System.Drawing.Point(163, 491)
        Me.tf_estado.Name = "tf_estado"
        Me.tf_estado.Size = New System.Drawing.Size(138, 20)
        Me.tf_estado.TabIndex = 415
        '
        'tf_cel
        '
        Me.tf_cel.Location = New System.Drawing.Point(163, 385)
        Me.tf_cel.Name = "tf_cel"
        Me.tf_cel.Size = New System.Drawing.Size(138, 20)
        Me.tf_cel.TabIndex = 414
        '
        'tf_telf
        '
        Me.tf_telf.Location = New System.Drawing.Point(163, 359)
        Me.tf_telf.Name = "tf_telf"
        Me.tf_telf.Size = New System.Drawing.Size(138, 20)
        Me.tf_telf.TabIndex = 413
        '
        'tf_dir
        '
        Me.tf_dir.Location = New System.Drawing.Point(163, 307)
        Me.tf_dir.Name = "tf_dir"
        Me.tf_dir.Size = New System.Drawing.Size(138, 20)
        Me.tf_dir.TabIndex = 412
        '
        'tf_am
        '
        Me.tf_am.Location = New System.Drawing.Point(163, 283)
        Me.tf_am.Name = "tf_am"
        Me.tf_am.Size = New System.Drawing.Size(138, 20)
        Me.tf_am.TabIndex = 411
        '
        'tf_ap
        '
        Me.tf_ap.Location = New System.Drawing.Point(163, 255)
        Me.tf_ap.Name = "tf_ap"
        Me.tf_ap.Size = New System.Drawing.Size(138, 20)
        Me.tf_ap.TabIndex = 410
        '
        'tf_nombre
        '
        Me.tf_nombre.Location = New System.Drawing.Point(163, 229)
        Me.tf_nombre.Name = "tf_nombre"
        Me.tf_nombre.Size = New System.Drawing.Size(138, 20)
        Me.tf_nombre.TabIndex = 409
        '
        'tf_ci
        '
        Me.tf_ci.FormattingEnabled = True
        Me.tf_ci.Location = New System.Drawing.Point(163, 202)
        Me.tf_ci.Name = "tf_ci"
        Me.tf_ci.Size = New System.Drawing.Size(138, 21)
        Me.tf_ci.TabIndex = 408
        '
        'txt_razon
        '
        Me.txt_razon.AutoSize = True
        Me.txt_razon.BackColor = System.Drawing.Color.Black
        Me.txt_razon.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_razon.ForeColor = System.Drawing.Color.Chartreuse
        Me.txt_razon.Location = New System.Drawing.Point(68, 468)
        Me.txt_razon.Name = "txt_razon"
        Me.txt_razon.Size = New System.Drawing.Size(88, 16)
        Me.txt_razon.TabIndex = 407
        Me.txt_razon.Text = "Contraseña"
        '
        'txt_nit
        '
        Me.txt_nit.AutoSize = True
        Me.txt_nit.BackColor = System.Drawing.Color.Black
        Me.txt_nit.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nit.ForeColor = System.Drawing.Color.Chartreuse
        Me.txt_nit.Location = New System.Drawing.Point(109, 442)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(48, 16)
        Me.txt_nit.TabIndex = 406
        Me.txt_nit.Text = "Login"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label10.Location = New System.Drawing.Point(101, 495)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 405
        Me.Label10.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label9.Location = New System.Drawing.Point(117, 416)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 404
        Me.Label9.Text = "Sexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label8.Location = New System.Drawing.Point(93, 389)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 403
        Me.Label8.Text = "Celular"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(85, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 402
        Me.Label7.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label6.Location = New System.Drawing.Point(42, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 401
        Me.Label6.Text = "Nac."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label5.Location = New System.Drawing.Point(77, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 400
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label4.Location = New System.Drawing.Point(37, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 399
        Me.Label4.Text = "Apell. Materno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label3.Location = New System.Drawing.Point(37, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 398
        Me.Label3.Text = "Apell. Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label2.Location = New System.Drawing.Point(101, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 397
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(68, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 396
        Me.Label1.Text = "Usuario Id"
        '
        'ch_deshabilitado
        '
        Me.ch_deshabilitado.AutoSize = True
        Me.ch_deshabilitado.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_deshabilitado.ForeColor = System.Drawing.Color.Yellow
        Me.ch_deshabilitado.Location = New System.Drawing.Point(560, 177)
        Me.ch_deshabilitado.Name = "ch_deshabilitado"
        Me.ch_deshabilitado.Size = New System.Drawing.Size(182, 35)
        Me.ch_deshabilitado.TabIndex = 433
        Me.ch_deshabilitado.Text = "Deshabilitado"
        Me.ch_deshabilitado.UseVisualStyleBackColor = True
        '
        'frm_recepcionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(949, 617)
        Me.Controls.Add(Me.ch_deshabilitado)
        Me.Controls.Add(Me.tf_login)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tf_grupo)
        Me.Controls.Add(Me.bt_logout)
        Me.Controls.Add(Me.tf_salir)
        Me.Controls.Add(Me.bt_limpiar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tf_fn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dg_mostrar)
        Me.Controls.Add(Me.bt_mostrar)
        Me.Controls.Add(Me.bt_eliminar)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.bt_buscar)
        Me.Controls.Add(Me.bt_guardar)
        Me.Controls.Add(Me.tf_contraseña)
        Me.Controls.Add(Me.cb_sexo)
        Me.Controls.Add(Me.tf_estado)
        Me.Controls.Add(Me.tf_cel)
        Me.Controls.Add(Me.tf_telf)
        Me.Controls.Add(Me.tf_dir)
        Me.Controls.Add(Me.tf_am)
        Me.Controls.Add(Me.tf_ap)
        Me.Controls.Add(Me.tf_nombre)
        Me.Controls.Add(Me.tf_ci)
        Me.Controls.Add(Me.txt_razon)
        Me.Controls.Add(Me.txt_nit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_recepcionista"
        Me.Text = "frm_recepcionista"
        CType(Me.dg_mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tf_login As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tf_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents bt_logout As System.Windows.Forms.Button
    Friend WithEvents tf_salir As System.Windows.Forms.Button
    Friend WithEvents bt_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tf_fn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dg_mostrar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_mostrar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents tf_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents cb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents tf_estado As System.Windows.Forms.TextBox
    Friend WithEvents tf_cel As System.Windows.Forms.TextBox
    Friend WithEvents tf_telf As System.Windows.Forms.TextBox
    Friend WithEvents tf_dir As System.Windows.Forms.TextBox
    Friend WithEvents tf_am As System.Windows.Forms.TextBox
    Friend WithEvents tf_ap As System.Windows.Forms.TextBox
    Friend WithEvents tf_nombre As System.Windows.Forms.TextBox
    Friend WithEvents tf_ci As System.Windows.Forms.ComboBox
    Friend WithEvents txt_razon As System.Windows.Forms.Label
    Friend WithEvents txt_nit As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ch_deshabilitado As System.Windows.Forms.CheckBox
End Class
