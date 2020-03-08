<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rb_alta_de_jugadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Txt_dni = New System.Windows.Forms.TextBox
        Me.Txt_apellido = New System.Windows.Forms.TextBox
        Me.Txt_nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MTB_fecha = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Rb_inhabilitado = New System.Windows.Forms.RadioButton
        Me.Rb_enrecuperacion = New System.Windows.Forms.RadioButton
        Me.Rb_disponible = New System.Windows.Forms.RadioButton
        Me.Cmb_puesto = New System.Windows.Forms.ComboBox
        Me.Cmb_equipo = New System.Windows.Forms.ComboBox
        Me.Btn_registrar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Sfd = New System.Windows.Forms.SaveFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_dni
        '
        Me.Txt_dni.Location = New System.Drawing.Point(91, 23)
        Me.Txt_dni.Name = "Txt_dni"
        Me.Txt_dni.Size = New System.Drawing.Size(100, 20)
        Me.Txt_dni.TabIndex = 0
        '
        'Txt_apellido
        '
        Me.Txt_apellido.Location = New System.Drawing.Point(91, 49)
        Me.Txt_apellido.Name = "Txt_apellido"
        Me.Txt_apellido.Size = New System.Drawing.Size(100, 20)
        Me.Txt_apellido.TabIndex = 1
        '
        'Txt_nombre
        '
        Me.Txt_nombre.Location = New System.Drawing.Point(91, 75)
        Me.Txt_nombre.Name = "Txt_nombre"
        Me.Txt_nombre.Size = New System.Drawing.Size(100, 20)
        Me.Txt_nombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nro Doc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "nombre"
        '
        'MTB_fecha
        '
        Me.MTB_fecha.Location = New System.Drawing.Point(91, 101)
        Me.MTB_fecha.Mask = "00/00/0000"
        Me.MTB_fecha.Name = "MTB_fecha"
        Me.MTB_fecha.Size = New System.Drawing.Size(100, 20)
        Me.MTB_fecha.TabIndex = 6
        Me.MTB_fecha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.MTB_fecha.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Rb_inhabilitado)
        Me.GroupBox1.Controls.Add(Me.Rb_enrecuperacion)
        Me.GroupBox1.Controls.Add(Me.Rb_disponible)
        Me.GroupBox1.Controls.Add(Me.Cmb_puesto)
        Me.GroupBox1.Controls.Add(Me.Cmb_equipo)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 157)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Situacion Actual"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Puesto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Equipo"
        '
        'Rb_inhabilitado
        '
        Me.Rb_inhabilitado.AutoSize = True
        Me.Rb_inhabilitado.Location = New System.Drawing.Point(251, 128)
        Me.Rb_inhabilitado.Name = "Rb_inhabilitado"
        Me.Rb_inhabilitado.Size = New System.Drawing.Size(79, 17)
        Me.Rb_inhabilitado.TabIndex = 4
        Me.Rb_inhabilitado.TabStop = True
        Me.Rb_inhabilitado.Text = "Inhabilitado"
        Me.Rb_inhabilitado.UseVisualStyleBackColor = True
        '
        'Rb_enrecuperacion
        '
        Me.Rb_enrecuperacion.AllowDrop = True
        Me.Rb_enrecuperacion.AutoSize = True
        Me.Rb_enrecuperacion.Location = New System.Drawing.Point(138, 128)
        Me.Rb_enrecuperacion.Name = "Rb_enrecuperacion"
        Me.Rb_enrecuperacion.Size = New System.Drawing.Size(103, 17)
        Me.Rb_enrecuperacion.TabIndex = 3
        Me.Rb_enrecuperacion.TabStop = True
        Me.Rb_enrecuperacion.Text = "En recuperacion"
        Me.Rb_enrecuperacion.UseVisualStyleBackColor = True
        '
        'Rb_disponible
        '
        Me.Rb_disponible.AutoSize = True
        Me.Rb_disponible.Location = New System.Drawing.Point(28, 128)
        Me.Rb_disponible.Name = "Rb_disponible"
        Me.Rb_disponible.Size = New System.Drawing.Size(74, 17)
        Me.Rb_disponible.TabIndex = 2
        Me.Rb_disponible.TabStop = True
        Me.Rb_disponible.Text = "Disponible"
        Me.Rb_disponible.UseVisualStyleBackColor = True
        '
        'Cmb_puesto
        '
        Me.Cmb_puesto.FormattingEnabled = True
        Me.Cmb_puesto.Location = New System.Drawing.Point(66, 79)
        Me.Cmb_puesto.Name = "Cmb_puesto"
        Me.Cmb_puesto.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_puesto.TabIndex = 1
        '
        'Cmb_equipo
        '
        Me.Cmb_equipo.FormattingEnabled = True
        Me.Cmb_equipo.Location = New System.Drawing.Point(66, 34)
        Me.Cmb_equipo.Name = "Cmb_equipo"
        Me.Cmb_equipo.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_equipo.TabIndex = 0
        '
        'Btn_registrar
        '
        Me.Btn_registrar.Location = New System.Drawing.Point(134, 327)
        Me.Btn_registrar.Name = "Btn_registrar"
        Me.Btn_registrar.Size = New System.Drawing.Size(80, 28)
        Me.Btn_registrar.TabIndex = 8
        Me.Btn_registrar.Text = "Registrar"
        Me.Btn_registrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha Nac"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.parcial.My.Resources.Resources.images1
        Me.PictureBox1.Location = New System.Drawing.Point(297, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 107)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Rb_alta_de_jugadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 367)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_registrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MTB_fecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_nombre)
        Me.Controls.Add(Me.Txt_apellido)
        Me.Controls.Add(Me.Txt_dni)
        Me.Name = "Rb_alta_de_jugadores"
        Me.Text = "alta_de_jugadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents Txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MTB_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_inhabilitado As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_enrecuperacion As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_disponible As System.Windows.Forms.RadioButton
    Friend WithEvents Cmb_puesto As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_equipo As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_registrar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
