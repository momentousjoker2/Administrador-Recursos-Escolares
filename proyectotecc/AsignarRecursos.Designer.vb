<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarRecursos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtIdRecurso = New System.Windows.Forms.TextBox()
        Me.TxtIdCategoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtINVCA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.PanelFiltro = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboFiltroCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtFiltroCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVRecursos = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEdificio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnLimpiarSeleccion = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.idRecursos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelFiltro.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.proyectotecc.My.Resources.Resources.logoitcg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(824, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 300)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 127)
        Me.Panel2.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(262, 127)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de los recursos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(11, 45)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(247, 34)
        Me.TxtDescripcion.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtIdRecurso)
        Me.GroupBox2.Controls.Add(Me.TxtIdCategoria)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtINVCA)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtConcepto)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(262, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(550, 127)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Categorías:"
        '
        'TxtIdRecurso
        '
        Me.TxtIdRecurso.Location = New System.Drawing.Point(367, 24)
        Me.TxtIdRecurso.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdRecurso.Multiline = True
        Me.TxtIdRecurso.Name = "TxtIdRecurso"
        Me.TxtIdRecurso.ReadOnly = True
        Me.TxtIdRecurso.Size = New System.Drawing.Size(144, 18)
        Me.TxtIdRecurso.TabIndex = 12
        '
        'TxtIdCategoria
        '
        Me.TxtIdCategoria.Location = New System.Drawing.Point(89, 24)
        Me.TxtIdCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdCategoria.Multiline = True
        Me.TxtIdCategoria.Name = "TxtIdCategoria"
        Me.TxtIdCategoria.ReadOnly = True
        Me.TxtIdCategoria.Size = New System.Drawing.Size(144, 18)
        Me.TxtIdCategoria.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(298, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "INVCAPECE:"
        '
        'txtINVCA
        '
        Me.txtINVCA.Location = New System.Drawing.Point(301, 75)
        Me.txtINVCA.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINVCA.Multiline = True
        Me.txtINVCA.Name = "txtINVCA"
        Me.txtINVCA.ReadOnly = True
        Me.txtINVCA.Size = New System.Drawing.Size(210, 30)
        Me.txtINVCA.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(298, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Recurso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Id categoría:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 55)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(20, 75)
        Me.txtConcepto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(213, 30)
        Me.txtConcepto.TabIndex = 6
        '
        'PanelFiltro
        '
        Me.PanelFiltro.Controls.Add(Me.GroupBox3)
        Me.PanelFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltro.Location = New System.Drawing.Point(0, 65)
        Me.PanelFiltro.Name = "PanelFiltro"
        Me.PanelFiltro.Size = New System.Drawing.Size(824, 71)
        Me.PanelFiltro.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.CboFiltroCategoria)
        Me.GroupBox3.Controls.Add(Me.TxtFiltroCategoria)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(812, 71)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filtro de búsqueda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Categoría:"
        '
        'CboFiltroCategoria
        '
        Me.CboFiltroCategoria.FormattingEnabled = True
        Me.CboFiltroCategoria.Items.AddRange(New Object() {"0"})
        Me.CboFiltroCategoria.Location = New System.Drawing.Point(9, 31)
        Me.CboFiltroCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.CboFiltroCategoria.Name = "CboFiltroCategoria"
        Me.CboFiltroCategoria.Size = New System.Drawing.Size(75, 21)
        Me.CboFiltroCategoria.TabIndex = 12
        '
        'TxtFiltroCategoria
        '
        Me.TxtFiltroCategoria.Location = New System.Drawing.Point(98, 31)
        Me.TxtFiltroCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFiltroCategoria.Multiline = True
        Me.TxtFiltroCategoria.Name = "TxtFiltroCategoria"
        Me.TxtFiltroCategoria.ReadOnly = True
        Me.TxtFiltroCategoria.Size = New System.Drawing.Size(243, 21)
        Me.TxtFiltroCategoria.TabIndex = 12
        Me.TxtFiltroCategoria.Text = "TODAS LAS CATEGORÍAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Id categoría:"
        '
        'DGVRecursos
        '
        Me.DGVRecursos.AllowUserToAddRows = False
        Me.DGVRecursos.AllowUserToDeleteRows = False
        Me.DGVRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRecursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRecursos, Me.descripcion, Me.idCategoria, Me.Categoria, Me.Estado})
        Me.DGVRecursos.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGVRecursos.Location = New System.Drawing.Point(3, 16)
        Me.DGVRecursos.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVRecursos.Name = "DGVRecursos"
        Me.DGVRecursos.ReadOnly = True
        Me.DGVRecursos.RowHeadersWidth = 51
        Me.DGVRecursos.RowTemplate.Height = 24
        Me.DGVRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRecursos.Size = New System.Drawing.Size(809, 145)
        Me.DGVRecursos.TabIndex = 13
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGVRecursos)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(824, 164)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recursos"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtResponsable)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TxtAula)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.TxtEdificio)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.dtpFecha)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(812, 118)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos de la Asignación"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(657, 37)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(654, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Fecha de Asignación:"
        '
        'TxtEdificio
        '
        Me.TxtEdificio.Location = New System.Drawing.Point(13, 33)
        Me.TxtEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEdificio.Multiline = True
        Me.TxtEdificio.Name = "TxtEdificio"
        Me.TxtEdificio.Size = New System.Drawing.Size(488, 24)
        Me.TxtEdificio.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Edificio:"
        '
        'TxtAula
        '
        Me.TxtAula.Location = New System.Drawing.Point(505, 33)
        Me.TxtAula.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAula.Multiline = True
        Me.TxtAula.Name = "TxtAula"
        Me.TxtAula.Size = New System.Drawing.Size(134, 24)
        Me.TxtAula.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(503, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Aula:"
        '
        'TxtResponsable
        '
        Me.TxtResponsable.Location = New System.Drawing.Point(13, 76)
        Me.TxtResponsable.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtResponsable.Multiline = True
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(760, 24)
        Me.TxtResponsable.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 59)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Responsable:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 427)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 118)
        Me.Panel1.TabIndex = 23
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnLimpiarSeleccion)
        Me.Panel6.Controls.Add(Me.BtnGuardar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 551)
        Me.Panel6.MinimumSize = New System.Drawing.Size(0, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel6.Size = New System.Drawing.Size(824, 60)
        Me.Panel6.TabIndex = 24
        '
        'BtnLimpiarSeleccion
        '
        Me.BtnLimpiarSeleccion.Location = New System.Drawing.Point(413, 15)
        Me.BtnLimpiarSeleccion.Name = "BtnLimpiarSeleccion"
        Me.BtnLimpiarSeleccion.Size = New System.Drawing.Size(398, 35)
        Me.BtnLimpiarSeleccion.TabIndex = 22
        Me.BtnLimpiarSeleccion.Text = "Limpiar Datos"
        Me.BtnLimpiarSeleccion.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(9, 15)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(398, 35)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'idRecursos
        '
        Me.idRecursos.HeaderText = "IdRecursos"
        Me.idRecursos.MinimumWidth = 6
        Me.idRecursos.Name = "idRecursos"
        Me.idRecursos.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'idCategoria
        '
        Me.idCategoria.HeaderText = "IdCategoría"
        Me.idCategoria.MinimumWidth = 6
        Me.idCategoria.Name = "idCategoria"
        Me.idCategoria.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoría"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'AsignarRecursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 611)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PanelFiltro)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(840, 650)
        Me.Name = "AsignarRecursos"
        Me.Text = "AsignarRecursos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelFiltro.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtIdRecurso As TextBox
    Friend WithEvents TxtIdCategoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtINVCA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents PanelFiltro As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CboFiltroCategoria As ComboBox
    Friend WithEvents TxtFiltroCategoria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVRecursos As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtResponsable As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtAula As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEdificio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnLimpiarSeleccion As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents idRecursos As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents idCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
