<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaApartadoRecurso
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DGVApartado = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Docente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edificio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CboCantidadDev = New System.Windows.Forms.ComboBox()
        Me.TxtCantidadPrest = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.IdRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadPrest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGVApartado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 98)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Panel2.Size = New System.Drawing.Size(1099, 87)
        Me.Panel2.TabIndex = 44
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(7, 6)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(877, 75)
        Me.Panel5.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(425, 37)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Consulta: Apartado Recurso"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(899, 41)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(184, 26)
        Me.dtpFecha.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(895, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Selecciona una fecha:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DGVApartado)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 185)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(1099, 246)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Apartado"
        '
        'DGVApartado
        '
        Me.DGVApartado.AllowUserToAddRows = False
        Me.DGVApartado.AllowUserToDeleteRows = False
        Me.DGVApartado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVApartado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVApartado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Docente, Me.Alumno, Me.NC, Me.Edificio, Me.Aula})
        Me.DGVApartado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVApartado.Location = New System.Drawing.Point(4, 23)
        Me.DGVApartado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVApartado.Name = "DGVApartado"
        Me.DGVApartado.ReadOnly = True
        Me.DGVApartado.RowHeadersWidth = 51
        Me.DGVApartado.RowTemplate.Height = 24
        Me.DGVApartado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVApartado.Size = New System.Drawing.Size(1091, 219)
        Me.DGVApartado.TabIndex = 13
        '
        'Id
        '
        Me.Id.HeaderText = "Id Apartado"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Docente
        '
        Me.Docente.HeaderText = "Docente"
        Me.Docente.MinimumWidth = 6
        Me.Docente.Name = "Docente"
        Me.Docente.ReadOnly = True
        '
        'Alumno
        '
        Me.Alumno.HeaderText = "Alumno"
        Me.Alumno.MinimumWidth = 6
        Me.Alumno.Name = "Alumno"
        Me.Alumno.ReadOnly = True
        '
        'NC
        '
        Me.NC.HeaderText = "NC"
        Me.NC.MinimumWidth = 6
        Me.NC.Name = "NC"
        Me.NC.ReadOnly = True
        '
        'Edificio
        '
        Me.Edificio.HeaderText = "Edificio"
        Me.Edificio.MinimumWidth = 6
        Me.Edificio.Name = "Edificio"
        Me.Edificio.ReadOnly = True
        '
        'Aula
        '
        Me.Aula.HeaderText = "Aula"
        Me.Aula.MinimumWidth = 6
        Me.Aula.Name = "Aula"
        Me.Aula.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CboCantidadDev)
        Me.Panel1.Controls.Add(Me.TxtCantidadPrest)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 630)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Panel1.Size = New System.Drawing.Size(1099, 60)
        Me.Panel1.TabIndex = 46
        '
        'CboCantidadDev
        '
        Me.CboCantidadDev.FormattingEnabled = True
        Me.CboCantidadDev.Location = New System.Drawing.Point(171, 26)
        Me.CboCantidadDev.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboCantidadDev.Name = "CboCantidadDev"
        Me.CboCantidadDev.Size = New System.Drawing.Size(141, 24)
        Me.CboCantidadDev.TabIndex = 38
        '
        'TxtCantidadPrest
        '
        Me.TxtCantidadPrest.Location = New System.Drawing.Point(19, 26)
        Me.TxtCantidadPrest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCantidadPrest.Multiline = True
        Me.TxtCantidadPrest.Name = "TxtCantidadPrest"
        Me.TxtCantidadPrest.ReadOnly = True
        Me.TxtCantidadPrest.Size = New System.Drawing.Size(143, 25)
        Me.TxtCantidadPrest.TabIndex = 37
        Me.TxtCantidadPrest.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Cantidad Devuelta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Cantidad Apartada:"
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(911, 6)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 48)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(320, 6)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(333, 48)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Devolver Recurso Seleccionado"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.proyectotecc.My.Resources.Resources.logoitcg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1099, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVDetalle)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 431)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1099, 185)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'DGVDetalle
        '
        Me.DGVDetalle.AllowUserToAddRows = False
        Me.DGVDetalle.AllowUserToDeleteRows = False
        Me.DGVDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRecurso, Me.NombreRec, Me.CantidadPrest, Me.CantidadDev, Me.FechaDev})
        Me.DGVDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVDetalle.Location = New System.Drawing.Point(4, 23)
        Me.DGVDetalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.ReadOnly = True
        Me.DGVDetalle.RowHeadersWidth = 51
        Me.DGVDetalle.RowTemplate.Height = 24
        Me.DGVDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDetalle.Size = New System.Drawing.Size(1091, 158)
        Me.DGVDetalle.TabIndex = 13
        '
        'IdRecurso
        '
        Me.IdRecurso.HeaderText = "Id Recurso"
        Me.IdRecurso.MinimumWidth = 6
        Me.IdRecurso.Name = "IdRecurso"
        Me.IdRecurso.ReadOnly = True
        '
        'NombreRec
        '
        Me.NombreRec.HeaderText = "Descripcion "
        Me.NombreRec.MinimumWidth = 6
        Me.NombreRec.Name = "NombreRec"
        Me.NombreRec.ReadOnly = True
        '
        'CantidadPrest
        '
        Me.CantidadPrest.HeaderText = "Cantidad Prestada"
        Me.CantidadPrest.MinimumWidth = 6
        Me.CantidadPrest.Name = "CantidadPrest"
        Me.CantidadPrest.ReadOnly = True
        '
        'CantidadDev
        '
        Me.CantidadDev.HeaderText = "Cantidad Devuelta"
        Me.CantidadDev.MinimumWidth = 6
        Me.CantidadDev.Name = "CantidadDev"
        Me.CantidadDev.ReadOnly = True
        '
        'FechaDev
        '
        Me.FechaDev.HeaderText = "Fecha de Devolución"
        Me.FechaDev.MinimumWidth = 6
        Me.FechaDev.Name = "FechaDev"
        Me.FechaDev.ReadOnly = True
        '
        'ConsultaApartadoRecurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 690)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ConsultaApartadoRecurso"
        Me.Text = "ConsultaApartadoRecurso"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DGVApartado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DGVApartado As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCantidadPrest As TextBox
    Friend WithEvents CboCantidadDev As ComboBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Docente As DataGridViewTextBoxColumn
    Friend WithEvents Alumno As DataGridViewTextBoxColumn
    Friend WithEvents NC As DataGridViewTextBoxColumn
    Friend WithEvents Edificio As DataGridViewTextBoxColumn
    Friend WithEvents Aula As DataGridViewTextBoxColumn
    Friend WithEvents IdRecurso As DataGridViewTextBoxColumn
    Friend WithEvents NombreRec As DataGridViewTextBoxColumn
    Friend WithEvents CantidadPrest As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDev As DataGridViewTextBoxColumn
    Friend WithEvents FechaDev As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
End Class
