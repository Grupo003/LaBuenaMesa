<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lb_login = New System.Windows.Forms.Label
        Me.tf_usuario = New System.Windows.Forms.TextBox
        Me.tf_login = New System.Windows.Forms.TextBox
        Me.tf_contraseña = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.tf_c = New System.Windows.Forms.TextBox
        Me.tf_l = New System.Windows.Forms.TextBox
        Me.tp_calendario = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.lb_fecha = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tf_ci = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Yellow
        Me.UsernameLabel.Location = New System.Drawing.Point(265, 88)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(177, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Yellow
        Me.PasswordLabel.Location = New System.Drawing.Point(265, 199)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(191, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Book Antiqua", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label14.Location = New System.Drawing.Point(154, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(201, 49)
        Me.Label14.TabIndex = 208
        Me.Label14.Text = "L O G I N"
        '
        'lb_login
        '
        Me.lb_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_login.ForeColor = System.Drawing.Color.Yellow
        Me.lb_login.Location = New System.Drawing.Point(264, 146)
        Me.lb_login.Name = "lb_login"
        Me.lb_login.Size = New System.Drawing.Size(177, 23)
        Me.lb_login.TabIndex = 209
        Me.lb_login.Text = "&Login"
        Me.lb_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tf_usuario
        '
        Me.tf_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_usuario.Location = New System.Drawing.Point(269, 112)
        Me.tf_usuario.Name = "tf_usuario"
        Me.tf_usuario.Size = New System.Drawing.Size(190, 26)
        Me.tf_usuario.TabIndex = 214
        '
        'tf_login
        '
        Me.tf_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_login.Location = New System.Drawing.Point(266, 170)
        Me.tf_login.Name = "tf_login"
        Me.tf_login.Size = New System.Drawing.Size(190, 26)
        Me.tf_login.TabIndex = 218
        '
        'tf_contraseña
        '
        Me.tf_contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf_contraseña.Location = New System.Drawing.Point(266, 223)
        Me.tf_contraseña.Name = "tf_contraseña"
        Me.tf_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tf_contraseña.Size = New System.Drawing.Size(190, 26)
        Me.tf_contraseña.TabIndex = 219
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OK.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.Black
        Me.OK.Location = New System.Drawing.Point(264, 271)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(104, 34)
        Me.OK.TabIndex = 220
        Me.OK.Text = "&ACEPTAR"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.Black
        Me.Cancel.Location = New System.Drawing.Point(399, 271)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(104, 34)
        Me.Cancel.TabIndex = 221
        Me.Cancel.Text = "&SALIR"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'tf_c
        '
        Me.tf_c.Location = New System.Drawing.Point(462, 223)
        Me.tf_c.Name = "tf_c"
        Me.tf_c.Size = New System.Drawing.Size(64, 26)
        Me.tf_c.TabIndex = 223
        Me.tf_c.Visible = False
        Me.tf_c.WordWrap = False
        '
        'tf_l
        '
        Me.tf_l.Location = New System.Drawing.Point(462, 170)
        Me.tf_l.Name = "tf_l"
        Me.tf_l.Size = New System.Drawing.Size(64, 26)
        Me.tf_l.TabIndex = 222
        Me.tf_l.Visible = False
        Me.tf_l.WordWrap = False
        '
        'tp_calendario
        '
        Me.tp_calendario.CalendarMonthBackground = System.Drawing.Color.Red
        Me.tp_calendario.Location = New System.Drawing.Point(77, 48)
        Me.tp_calendario.Name = "tp_calendario"
        Me.tp_calendario.Size = New System.Drawing.Size(200, 20)
        Me.tp_calendario.TabIndex = 225
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(447, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 41)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "Santa Cruz - Bolivia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lb_fecha
        '
        Me.lb_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fecha.ForeColor = System.Drawing.Color.Yellow
        Me.lb_fecha.Location = New System.Drawing.Point(763, 32)
        Me.lb_fecha.Name = "lb_fecha"
        Me.lb_fecha.Size = New System.Drawing.Size(199, 41)
        Me.lb_fecha.TabIndex = 228
        Me.lb_fecha.Text = "fecha"
        Me.lb_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Georgia", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label1.Location = New System.Drawing.Point(177, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(758, 46)
        Me.Label1.TabIndex = 229
        Me.Label1.Text = "RESTAURANTE   LA  BUENA  MESA"
        '
        'tf_ci
        '
        Me.tf_ci.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound
        Me.tf_ci.FormattingEnabled = True
        Me.tf_ci.Items.AddRange(New Object() {"hhhhh", "gggg", "kkkk"})
        Me.tf_ci.Location = New System.Drawing.Point(151, 84)
        Me.tf_ci.Name = "tf_ci"
        Me.tf_ci.Size = New System.Drawing.Size(40, 21)
        Me.tf_ci.TabIndex = 268
        Me.tf_ci.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cancel)
        Me.GroupBox1.Controls.Add(Me.OK)
        Me.GroupBox1.Controls.Add(Me.tf_l)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.tf_contraseña)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.tf_login)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.tf_c)
        Me.GroupBox1.Controls.Add(Me.tf_usuario)
        Me.GroupBox1.Controls.Add(Me.lb_login)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.GroupBox1.Location = New System.Drawing.Point(251, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 361)
        Me.GroupBox1.TabIndex = 269
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS USUARIO .-"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 199)
        Me.PictureBox1.TabIndex = 270
        Me.PictureBox1.TabStop = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(974, 684)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tf_ci)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tp_calendario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lb_login As System.Windows.Forms.Label
    Friend WithEvents tf_usuario As System.Windows.Forms.TextBox
    Friend WithEvents tf_login As System.Windows.Forms.TextBox
    Friend WithEvents tf_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents tf_c As System.Windows.Forms.TextBox
    Friend WithEvents tf_l As System.Windows.Forms.TextBox
    Friend WithEvents tp_calendario As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_fecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tf_ci As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
