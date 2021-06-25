<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cañones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboNombreRecursos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboIdRecurso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHorasLampara = New System.Windows.Forms.NumericUpDown()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtNoSerie = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.dtpFechaUltiMan = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaAdqui = New System.Windows.Forms.DateTimePicker()
        Me.txtInvcapece = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgwCañon = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVCAPECE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAdq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltMantto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorasLampara = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtHorasLampara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwCañon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyectotecc.My.Resources.Resources.logoitcg
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboNombreRecursos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboIdRecurso)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtHorasLampara)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.txtNoSerie)
        Me.GroupBox2.Controls.Add(Me.txtMarca)
        Me.GroupBox2.Controls.Add(Me.txtModelo)
        Me.GroupBox2.Controls.Add(Me.dtpFechaUltiMan)
        Me.GroupBox2.Controls.Add(Me.dtpFechaAdqui)
        Me.GroupBox2.Controls.Add(Me.txtInvcapece)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 485)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cañon:"
        '
        'cboNombreRecursos
        '
        Me.cboNombreRecursos.FormattingEnabled = True
        Me.cboNombreRecursos.Location = New System.Drawing.Point(268, 55)
        Me.cboNombreRecursos.Name = "cboNombreRecursos"
        Me.cboNombreRecursos.Size = New System.Drawing.Size(197, 24)
        Me.cboNombreRecursos.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Nombre recursos:"
        '
        'cboIdRecurso
        '
        Me.cboIdRecurso.FormattingEnabled = True
        Me.cboIdRecurso.Location = New System.Drawing.Point(74, 55)
        Me.cboIdRecurso.Name = "cboIdRecurso"
        Me.cboIdRecurso.Size = New System.Drawing.Size(121, 24)
        Me.cboIdRecurso.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Id Recurso:"
        '
        'txtHorasLampara
        '
        Me.txtHorasLampara.Location = New System.Drawing.Point(268, 354)
        Me.txtHorasLampara.Name = "txtHorasLampara"
        Me.txtHorasLampara.Size = New System.Drawing.Size(174, 22)
        Me.txtHorasLampara.TabIndex = 48
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(268, 103)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(174, 29)
        Me.txtEstado.TabIndex = 45
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(74, 428)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(368, 50)
        Me.txtObservaciones.TabIndex = 44
        '
        'txtNoSerie
        '
        Me.txtNoSerie.Location = New System.Drawing.Point(74, 353)
        Me.txtNoSerie.Multiline = True
        Me.txtNoSerie.Name = "txtNoSerie"
        Me.txtNoSerie.Size = New System.Drawing.Size(174, 37)
        Me.txtNoSerie.TabIndex = 42
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(268, 279)
        Me.txtMarca.Multiline = True
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(174, 37)
        Me.txtMarca.TabIndex = 40
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(74, 279)
        Me.txtModelo.Multiline = True
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(174, 37)
        Me.txtModelo.TabIndex = 39
        '
        'dtpFechaUltiMan
        '
        Me.dtpFechaUltiMan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltiMan.Location = New System.Drawing.Point(130, 229)
        Me.dtpFechaUltiMan.Name = "dtpFechaUltiMan"
        Me.dtpFechaUltiMan.Size = New System.Drawing.Size(264, 22)
        Me.dtpFechaUltiMan.TabIndex = 38
        '
        'dtpFechaAdqui
        '
        Me.dtpFechaAdqui.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAdqui.Location = New System.Drawing.Point(130, 166)
        Me.dtpFechaAdqui.Name = "dtpFechaAdqui"
        Me.dtpFechaAdqui.Size = New System.Drawing.Size(264, 22)
        Me.dtpFechaAdqui.TabIndex = 37
        '
        'txtInvcapece
        '
        Me.txtInvcapece.Location = New System.Drawing.Point(71, 102)
        Me.txtInvcapece.Multiline = True
        Me.txtInvcapece.Name = "txtInvcapece"
        Me.txtInvcapece.Size = New System.Drawing.Size(177, 29)
        Me.txtInvcapece.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(265, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Estado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 17)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Horas de lampara:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(68, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Fecha de Ultimo Mantenimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(71, 404)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Observación:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Modelo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "INVCAPECE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "No. Serie:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(265, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fecha de Adquisición:"
        '
        'dgwCañon
        '
        Me.dgwCañon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwCañon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.INVCAPECE, Me.FechaAdq, Me.FechaUltMantto, Me.Modelo, Me.Marca, Me.NoSerie, Me.HorasLampara, Me.Observaciones, Me.Estado})
        Me.dgwCañon.Location = New System.Drawing.Point(12, 600)
        Me.dgwCañon.Name = "dgwCañon"
        Me.dgwCañon.RowHeadersWidth = 51
        Me.dgwCañon.RowTemplate.Height = 24
        Me.dgwCañon.Size = New System.Drawing.Size(560, 150)
        Me.dgwCañon.TabIndex = 28
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'INVCAPECE
        '
        Me.INVCAPECE.HeaderText = "INVCAPECE"
        Me.INVCAPECE.MinimumWidth = 6
        Me.INVCAPECE.Name = "INVCAPECE"
        Me.INVCAPECE.Width = 125
        '
        'FechaAdq
        '
        Me.FechaAdq.HeaderText = "FechaAdq"
        Me.FechaAdq.MinimumWidth = 6
        Me.FechaAdq.Name = "FechaAdq"
        Me.FechaAdq.Width = 125
        '
        'FechaUltMantto
        '
        Me.FechaUltMantto.HeaderText = "FechaUltMantto"
        Me.FechaUltMantto.MinimumWidth = 6
        Me.FechaUltMantto.Name = "FechaUltMantto"
        Me.FechaUltMantto.Width = 125
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.MinimumWidth = 6
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Width = 125
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.MinimumWidth = 6
        Me.Marca.Name = "Marca"
        Me.Marca.Width = 125
        '
        'NoSerie
        '
        Me.NoSerie.HeaderText = "NoSerie"
        Me.NoSerie.MinimumWidth = 6
        Me.NoSerie.Name = "NoSerie"
        Me.NoSerie.Width = 125
        '
        'HorasLampara
        '
        Me.HorasLampara.HeaderText = "HorasLampara"
        Me.HorasLampara.MinimumWidth = 6
        Me.HorasLampara.Name = "HorasLampara"
        Me.HorasLampara.Width = 125
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.MinimumWidth = 6
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 125
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 125
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnNuevo)
        Me.GroupBox4.Controls.Add(Me.btnRegistrar)
        Me.GroupBox4.Controls.Add(Me.btnSalir)
        Me.GroupBox4.Location = New System.Drawing.Point(342, 756)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 110)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 18)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(100, 36)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(118, 18)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 36)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 60)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(206, 36)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.btnUltimo)
        Me.gb1.Controls.Add(Me.btnInicio)
        Me.gb1.Controls.Add(Me.btnSiguiente)
        Me.gb1.Controls.Add(Me.btnAnterior)
        Me.gb1.Location = New System.Drawing.Point(12, 756)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(230, 109)
        Me.gb1.TabIndex = 29
        Me.gb1.TabStop = False
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(118, 61)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(100, 36)
        Me.btnUltimo.TabIndex = 19
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 19)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(100, 36)
        Me.btnInicio.TabIndex = 16
        Me.btnInicio.Text = "inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(118, 19)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(100, 36)
        Me.btnSiguiente.TabIndex = 14
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(12, 61)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(100, 36)
        Me.btnAnterior.TabIndex = 15
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'Cañones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 932)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.dgwCañon)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Cañones"
        Me.Text = "Cañones"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtHorasLampara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwCañon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.gb1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtNoSerie As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents dtpFechaUltiMan As DateTimePicker
    Friend WithEvents dtpFechaAdqui As DateTimePicker
    Friend WithEvents txtInvcapece As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgwCañon As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents INVCAPECE As DataGridViewTextBoxColumn
    Friend WithEvents FechaAdq As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltMantto As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents NoSerie As DataGridViewTextBoxColumn
    Friend WithEvents HorasLampara As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents txtHorasLampara As NumericUpDown
    Friend WithEvents cboIdRecurso As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboNombreRecursos As ComboBox
    Friend WithEvents Label2 As Label
End Class
