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
        Me.GroupBoxConcepto = New System.Windows.Forms.GroupBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.txtAutoriza = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnDeshacer = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVRecursos = New System.Windows.Forms.DataGridView()
        Me.idRecursos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVCAPECE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelFiltro = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdBaja = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboFiltroCategoria = New System.Windows.Forms.ComboBox()
        Me.TxtFiltroCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxConcepto.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFiltro.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.GroupBoxConcepto)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PanelFiltro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 568)
        Me.Panel1.TabIndex = 13
        '
        'GroupBoxConcepto
        '
        Me.GroupBoxConcepto.Controls.Add(Me.txtConcepto)
        Me.GroupBoxConcepto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBoxConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxConcepto.Location = New System.Drawing.Point(0, 381)
        Me.GroupBoxConcepto.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxConcepto.Name = "GroupBoxConcepto"
        Me.GroupBoxConcepto.Padding = New System.Windows.Forms.Padding(12)
        Me.GroupBoxConcepto.Size = New System.Drawing.Size(824, 127)
        Me.GroupBoxConcepto.TabIndex = 24
        Me.GroupBoxConcepto.TabStop = False
        Me.GroupBoxConcepto.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConcepto.Location = New System.Drawing.Point(12, 28)
        Me.txtConcepto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(800, 87)
        Me.txtConcepto.TabIndex = 23
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.BtnGuardar)
        Me.Panel6.Controls.Add(Me.txtAutoriza)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 508)
        Me.Panel6.MinimumSize = New System.Drawing.Size(0, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel6.Size = New System.Drawing.Size(824, 60)
        Me.Panel6.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 5)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Autorizado por:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(572, 12)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Padding = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Size = New System.Drawing.Size(240, 36)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'txtAutoriza
        '
        Me.txtAutoriza.Location = New System.Drawing.Point(21, 24)
        Me.txtAutoriza.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAutoriza.Multiline = True
        Me.txtAutoriza.Name = "txtAutoriza"
        Me.txtAutoriza.Size = New System.Drawing.Size(384, 21)
        Me.txtAutoriza.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnDeshacer)
        Me.Panel4.Controls.Add(Me.BtnSeleccionar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 298)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel4.Size = New System.Drawing.Size(824, 64)
        Me.Panel4.TabIndex = 20
        '
        'BtnDeshacer
        '
        Me.BtnDeshacer.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnDeshacer.Enabled = False
        Me.BtnDeshacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeshacer.Location = New System.Drawing.Point(412, 12)
        Me.BtnDeshacer.Name = "BtnDeshacer"
        Me.BtnDeshacer.Size = New System.Drawing.Size(400, 40)
        Me.BtnDeshacer.TabIndex = 20
        Me.BtnDeshacer.Text = "Deshacer Selección"
        Me.BtnDeshacer.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.Location = New System.Drawing.Point(12, 12)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(400, 40)
        Me.BtnSeleccionar.TabIndex = 19
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGVRecursos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 140)
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
        Me.DGVRecursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRecursos, Me.Concepto, Me.descripcion, Me.INVCAPECE, Me.Estado})
        Me.DGVRecursos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVRecursos.Location = New System.Drawing.Point(12, 12)
        Me.DGVRecursos.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVRecursos.Name = "DGVRecursos"
        Me.DGVRecursos.ReadOnly = True
        Me.DGVRecursos.RowHeadersWidth = 51
        Me.DGVRecursos.RowTemplate.Height = 24
        Me.DGVRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVRecursos.Size = New System.Drawing.Size(800, 134)
        Me.DGVRecursos.TabIndex = 13
        '
        'idRecursos
        '
        Me.idRecursos.HeaderText = "ID"
        Me.idRecursos.MinimumWidth = 6
        Me.idRecursos.Name = "idRecursos"
        Me.idRecursos.ReadOnly = True
        '
        'Concepto
        '
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'INVCAPECE
        '
        Me.INVCAPECE.HeaderText = "INVCAPECE"
        Me.INVCAPECE.Name = "INVCAPECE"
        Me.INVCAPECE.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'PanelFiltro
        '
        Me.PanelFiltro.Controls.Add(Me.Panel5)
        Me.PanelFiltro.Controls.Add(Me.Panel2)
        Me.PanelFiltro.Controls.Add(Me.GroupBox3)
        Me.PanelFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltro.Location = New System.Drawing.Point(0, 0)
        Me.PanelFiltro.Name = "PanelFiltro"
        Me.PanelFiltro.Size = New System.Drawing.Size(824, 140)
        Me.PanelFiltro.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtIdBaja)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(528, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel2.Size = New System.Drawing.Size(296, 62)
        Me.Panel2.TabIndex = 40
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(24, 37)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(113, 20)
        Me.dtpFecha.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "IdBaja:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Fecha:"
        '
        'TxtIdBaja
        '
        Me.TxtIdBaja.Location = New System.Drawing.Point(141, 36)
        Me.TxtIdBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdBaja.Multiline = True
        Me.TxtIdBaja.Name = "TxtIdBaja"
        Me.TxtIdBaja.ReadOnly = True
        Me.TxtIdBaja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtIdBaja.Size = New System.Drawing.Size(141, 21)
        Me.TxtIdBaja.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.CboFiltroCategoria)
        Me.GroupBox3.Controls.Add(Me.TxtFiltroCategoria)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(824, 78)
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(528, 62)
        Me.Panel5.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 30)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Consulta: Bajas"
        '
        'Bajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 633)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(840, 580)
        Me.Name = "Bajas"
        Me.Text = "Bajas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxConcepto.ResumeLayout(False)
        Me.GroupBoxConcepto.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGVRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFiltro.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGVRecursos As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnGuardar As Button
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
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAutoriza As TextBox
    Friend WithEvents idRecursos As DataGridViewTextBoxColumn
    Friend WithEvents Concepto As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents INVCAPECE As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBoxConcepto As GroupBox
    Friend WithEvents txtConcepto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdBaja As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
End Class
