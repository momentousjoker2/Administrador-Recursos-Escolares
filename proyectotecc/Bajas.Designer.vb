<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bajas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnLimpiarSeleccion = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DGVSeleccion = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnDeshacer = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVRecursos = New System.Windows.Forms.DataGridView()
        Me.idRecursos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelFiltro = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboFiltroCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtFiltroCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGVSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltro.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PanelFiltro)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 611)
        Me.Panel1.TabIndex = 13
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
        Me.Panel6.TabIndex = 22
        '
        'BtnLimpiarSeleccion
        '
        Me.BtnLimpiarSeleccion.Enabled = False
        Me.BtnLimpiarSeleccion.Location = New System.Drawing.Point(413, 15)
        Me.BtnLimpiarSeleccion.Name = "BtnLimpiarSeleccion"
        Me.BtnLimpiarSeleccion.Size = New System.Drawing.Size(398, 35)
        Me.BtnLimpiarSeleccion.TabIndex = 22
        Me.BtnLimpiarSeleccion.Text = "Limpiar Selección"
        Me.BtnLimpiarSeleccion.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Location = New System.Drawing.Point(9, 15)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(398, 35)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DGVSeleccion)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 402)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel5.Size = New System.Drawing.Size(824, 148)
        Me.Panel5.TabIndex = 21
        '
        'DGVSeleccion
        '
        Me.DGVSeleccion.AllowUserToAddRows = False
        Me.DGVSeleccion.AllowUserToDeleteRows = False
        Me.DGVSeleccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSeleccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DGVSeleccion.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGVSeleccion.Location = New System.Drawing.Point(12, 12)
        Me.DGVSeleccion.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVSeleccion.Name = "DGVSeleccion"
        Me.DGVSeleccion.ReadOnly = True
        Me.DGVSeleccion.RowHeadersWidth = 51
        Me.DGVSeleccion.RowTemplate.Height = 24
        Me.DGVSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSeleccion.Size = New System.Drawing.Size(797, 124)
        Me.DGVSeleccion.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "idRecursos"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "idCategoria"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnDeshacer)
        Me.Panel4.Controls.Add(Me.BtnSeleccionar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 356)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(824, 46)
        Me.Panel4.TabIndex = 20
        '
        'BtnDeshacer
        '
        Me.BtnDeshacer.Enabled = False
        Me.BtnDeshacer.Location = New System.Drawing.Point(411, 8)
        Me.BtnDeshacer.Name = "BtnDeshacer"
        Me.BtnDeshacer.Size = New System.Drawing.Size(398, 35)
        Me.BtnDeshacer.TabIndex = 20
        Me.BtnDeshacer.Text = "Deshacer Selección"
        Me.BtnDeshacer.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(7, 8)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(398, 35)
        Me.BtnSeleccionar.TabIndex = 19
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGVRecursos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 198)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel3.Size = New System.Drawing.Size(824, 158)
        Me.Panel3.TabIndex = 17
        '
        'DGVRecursos
        '
        Me.DGVRecursos.AllowUserToAddRows = False
        Me.DGVRecursos.AllowUserToDeleteRows = False
        Me.DGVRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRecursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRecursos, Me.descripcion, Me.idCategoria, Me.Categoria, Me.Estado})
        Me.DGVRecursos.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGVRecursos.Location = New System.Drawing.Point(12, 12)
        Me.DGVRecursos.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVRecursos.Name = "DGVRecursos"
        Me.DGVRecursos.ReadOnly = True
        Me.DGVRecursos.RowHeadersWidth = 51
        Me.DGVRecursos.RowTemplate.Height = 24
        Me.DGVRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRecursos.Size = New System.Drawing.Size(797, 134)
        Me.DGVRecursos.TabIndex = 13
        '
        'idRecursos
        '
        Me.idRecursos.HeaderText = "idRecursos"
        Me.idRecursos.MinimumWidth = 6
        Me.idRecursos.Name = "idRecursos"
        Me.idRecursos.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'idCategoria
        '
        Me.idCategoria.HeaderText = "idCategoria"
        Me.idCategoria.MinimumWidth = 6
        Me.idCategoria.Name = "idCategoria"
        Me.idCategoria.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'PanelFiltro
        '
        Me.PanelFiltro.Controls.Add(Me.GroupBox3)
        Me.PanelFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltro.Location = New System.Drawing.Point(0, 127)
        Me.PanelFiltro.Name = "PanelFiltro"
        Me.PanelFiltro.Size = New System.Drawing.Size(824, 71)
        Me.PanelFiltro.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.CboFiltroCategoria)
        Me.GroupBox3.Controls.Add(Me.TxtFiltroCategoria)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(797, 61)
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
        Me.CboFiltroCategoria.Text = "0"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 127)
        Me.Panel2.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(262, 119)
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
        Me.GroupBox2.Location = New System.Drawing.Point(268, 2)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(544, 119)
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
        'Bajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 676)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(840, 715)
        Me.Name = "Bajas"
        Me.Text = "Bajas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DGVSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltro.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents DGVRecursos As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnLimpiarSeleccion As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DGVSeleccion As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnDeshacer As Button
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelFiltro As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CboFiltroCategoria As ComboBox
    Friend WithEvents TxtFiltroCategoria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtINVCA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents TxtIdRecurso As TextBox
    Friend WithEvents TxtIdCategoria As TextBox
    Friend WithEvents idRecursos As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents idCategoria As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
