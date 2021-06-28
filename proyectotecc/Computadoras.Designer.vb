<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Computadoras
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
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtProcesador = New System.Windows.Forms.TextBox()
        Me.txtMemoria = New System.Windows.Forms.TextBox()
        Me.txtNoSerie = New System.Windows.Forms.TextBox()
        Me.txtHdd = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.dtpFechaUltMan = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaAdqui = New System.Windows.Forms.DateTimePicker()
        Me.txtInvcapece = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgwComputadora = New System.Windows.Forms.DataGridView()
        Me.idRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVCAPECE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAdq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaUltMantto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procesador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Memoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HDD = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgwComputadora, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboNombreRecursos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboIdRecurso)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtEstado)
        Me.GroupBox2.Controls.Add(Me.txtProcesador)
        Me.GroupBox2.Controls.Add(Me.txtMemoria)
        Me.GroupBox2.Controls.Add(Me.txtNoSerie)
        Me.GroupBox2.Controls.Add(Me.txtHdd)
        Me.GroupBox2.Controls.Add(Me.txtMarca)
        Me.GroupBox2.Controls.Add(Me.txtModelo)
        Me.GroupBox2.Controls.Add(Me.dtpFechaUltMan)
        Me.GroupBox2.Controls.Add(Me.dtpFechaAdqui)
        Me.GroupBox2.Controls.Add(Me.txtInvcapece)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 466)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Computadora:"
        '
        'cboNombreRecursos
        '
        Me.cboNombreRecursos.Enabled = False
        Me.cboNombreRecursos.FormattingEnabled = True
        Me.cboNombreRecursos.Location = New System.Drawing.Point(272, 46)
        Me.cboNombreRecursos.Name = "cboNombreRecursos"
        Me.cboNombreRecursos.Size = New System.Drawing.Size(197, 24)
        Me.cboNombreRecursos.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Nombre recursos:"
        '
        'cboIdRecurso
        '
        Me.cboIdRecurso.FormattingEnabled = True
        Me.cboIdRecurso.Location = New System.Drawing.Point(125, 46)
        Me.cboIdRecurso.Name = "cboIdRecurso"
        Me.cboIdRecurso.Size = New System.Drawing.Size(121, 24)
        Me.cboIdRecurso.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Id Recurso:"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(328, 107)
        Me.txtEstado.Multiline = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(230, 28)
        Me.txtEstado.TabIndex = 45
        '
        'txtProcesador
        '
        Me.txtProcesador.Location = New System.Drawing.Point(10, 414)
        Me.txtProcesador.Multiline = True
        Me.txtProcesador.Name = "txtProcesador"
        Me.txtProcesador.Size = New System.Drawing.Size(218, 37)
        Me.txtProcesador.TabIndex = 44
        '
        'txtMemoria
        '
        Me.txtMemoria.Location = New System.Drawing.Point(328, 414)
        Me.txtMemoria.Multiline = True
        Me.txtMemoria.Name = "txtMemoria"
        Me.txtMemoria.Size = New System.Drawing.Size(230, 37)
        Me.txtMemoria.TabIndex = 43
        '
        'txtNoSerie
        '
        Me.txtNoSerie.Location = New System.Drawing.Point(10, 348)
        Me.txtNoSerie.Multiline = True
        Me.txtNoSerie.Name = "txtNoSerie"
        Me.txtNoSerie.Size = New System.Drawing.Size(218, 37)
        Me.txtNoSerie.TabIndex = 42
        '
        'txtHdd
        '
        Me.txtHdd.Location = New System.Drawing.Point(328, 348)
        Me.txtHdd.Multiline = True
        Me.txtHdd.Name = "txtHdd"
        Me.txtHdd.Size = New System.Drawing.Size(230, 37)
        Me.txtHdd.TabIndex = 41
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(328, 285)
        Me.txtMarca.Multiline = True
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(230, 36)
        Me.txtMarca.TabIndex = 40
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(10, 285)
        Me.txtModelo.Multiline = True
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(218, 36)
        Me.txtModelo.TabIndex = 39
        '
        'dtpFechaUltMan
        '
        Me.dtpFechaUltMan.Location = New System.Drawing.Point(149, 222)
        Me.dtpFechaUltMan.Name = "dtpFechaUltMan"
        Me.dtpFechaUltMan.Size = New System.Drawing.Size(264, 22)
        Me.dtpFechaUltMan.TabIndex = 38
        '
        'dtpFechaAdqui
        '
        Me.dtpFechaAdqui.Location = New System.Drawing.Point(149, 164)
        Me.dtpFechaAdqui.Name = "dtpFechaAdqui"
        Me.dtpFechaAdqui.Size = New System.Drawing.Size(264, 22)
        Me.dtpFechaAdqui.TabIndex = 37
        '
        'txtInvcapece
        '
        Me.txtInvcapece.Location = New System.Drawing.Point(7, 107)
        Me.txtInvcapece.Multiline = True
        Me.txtInvcapece.Name = "txtInvcapece"
        Me.txtInvcapece.Size = New System.Drawing.Size(221, 28)
        Me.txtInvcapece.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(325, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Estado:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(323, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 17)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "HDD:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(323, 396)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Memoria:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(162, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(210, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Fecha de Ultimo Mantenimiento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Procesado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Modelo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "INVCAPECE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "No. Serie:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(323, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(203, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fecha de Adquisición:"
        '
        'dgwComputadora
        '
        Me.dgwComputadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwComputadora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRecurso, Me.INVCAPECE, Me.FechaAdq, Me.FechaUltMantto, Me.Modelo, Me.Marca, Me.NoSerie, Me.Procesador, Me.Memoria, Me.HDD, Me.Estado})
        Me.dgwComputadora.Location = New System.Drawing.Point(10, 581)
        Me.dgwComputadora.Name = "dgwComputadora"
        Me.dgwComputadora.ReadOnly = True
        Me.dgwComputadora.RowHeadersWidth = 51
        Me.dgwComputadora.RowTemplate.Height = 24
        Me.dgwComputadora.Size = New System.Drawing.Size(560, 182)
        Me.dgwComputadora.TabIndex = 26
        '
        'idRecurso
        '
        Me.idRecurso.HeaderText = "idRecurso"
        Me.idRecurso.MinimumWidth = 6
        Me.idRecurso.Name = "idRecurso"
        Me.idRecurso.Width = 125
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
        'Procesador
        '
        Me.Procesador.HeaderText = "Procesador"
        Me.Procesador.MinimumWidth = 6
        Me.Procesador.Name = "Procesador"
        Me.Procesador.Width = 125
        '
        'Memoria
        '
        Me.Memoria.HeaderText = "Memoria" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.Memoria.MinimumWidth = 6
        Me.Memoria.Name = "Memoria"
        Me.Memoria.Width = 125
        '
        'HDD
        '
        Me.HDD.HeaderText = "HDD"
        Me.HDD.MinimumWidth = 6
        Me.HDD.Name = "HDD"
        Me.HDD.Width = 125
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
        Me.GroupBox4.Location = New System.Drawing.Point(340, 769)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(230, 110)
        Me.GroupBox4.TabIndex = 28
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
        Me.gb1.Location = New System.Drawing.Point(10, 769)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(230, 109)
        Me.gb1.TabIndex = 27
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
        'Computadoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 910)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gb1)
        Me.Controls.Add(Me.dgwComputadora)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Computadoras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computadoras"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgwComputadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.gb1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtProcesador As TextBox
    Friend WithEvents txtMemoria As TextBox
    Friend WithEvents txtNoSerie As TextBox
    Friend WithEvents txtHdd As TextBox
    Friend WithEvents dtpFechaUltMan As DateTimePicker
    Friend WithEvents dtpFechaAdqui As DateTimePicker
    Friend WithEvents txtInvcapece As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgwComputadora As DataGridView
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents idRecurso As DataGridViewTextBoxColumn
    Friend WithEvents INVCAPECE As DataGridViewTextBoxColumn
    Friend WithEvents FechaAdq As DataGridViewTextBoxColumn
    Friend WithEvents FechaUltMantto As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents NoSerie As DataGridViewTextBoxColumn
    Friend WithEvents Procesador As DataGridViewTextBoxColumn
    Friend WithEvents Memoria As DataGridViewTextBoxColumn
    Friend WithEvents HDD As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents cboIdRecurso As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboNombreRecursos As ComboBox
    Friend WithEvents Label2 As Label
End Class
