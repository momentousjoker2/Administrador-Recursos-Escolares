<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApartadoLugar
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGVLugar = New System.Windows.Forms.DataGridView()
        Me.idLugar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Concepto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HoraFin = New System.Windows.Forms.ComboBox()
        Me.HoraInicio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNC = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtDocente = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtAula = New System.Windows.Forms.ComboBox()
        Me.TxtEdificio = New System.Windows.Forms.ComboBox()
        Me.TxtAlumno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelFiltro = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdApartado = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVReservaciones = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGVLugar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelFiltro.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVReservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.proyectotecc.My.Resources.Resources.logoitcg
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(824, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGVLugar)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 151)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(824, 164)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lugares"
        '
        'DGVLugar
        '
        Me.DGVLugar.AllowUserToAddRows = False
        Me.DGVLugar.AllowUserToDeleteRows = False
        Me.DGVLugar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVLugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLugar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idLugar, Me.descripcion})
        Me.DGVLugar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVLugar.Location = New System.Drawing.Point(3, 19)
        Me.DGVLugar.Name = "DGVLugar"
        Me.DGVLugar.ReadOnly = True
        Me.DGVLugar.RowHeadersWidth = 51
        Me.DGVLugar.RowTemplate.Height = 24
        Me.DGVLugar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVLugar.Size = New System.Drawing.Size(818, 142)
        Me.DGVLugar.TabIndex = 13
        '
        'idLugar
        '
        Me.idLugar.HeaderText = "Id Lugar"
        Me.idLugar.MinimumWidth = 6
        Me.idLugar.Name = "idLugar"
        Me.idLugar.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Concepto)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.HoraFin)
        Me.GroupBox6.Controls.Add(Me.HoraInicio)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.TxtNC)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.TxtDocente)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.TxtAula)
        Me.GroupBox6.Controls.Add(Me.TxtEdificio)
        Me.GroupBox6.Controls.Add(Me.TxtAlumno)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(0, 479)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(824, 160)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del Apartado"
        '
        'Concepto
        '
        Me.Concepto.Location = New System.Drawing.Point(11, 125)
        Me.Concepto.Margin = New System.Windows.Forms.Padding(2)
        Me.Concepto.Multiline = True
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Size = New System.Drawing.Size(799, 24)
        Me.Concepto.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Concepto:"
        '
        'HoraFin
        '
        Me.HoraFin.FormattingEnabled = True
        Me.HoraFin.Items.AddRange(New Object() {"8:00:00", "9:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00", "18:00:00", "19:00:00", "20:00:00"})
        Me.HoraFin.Location = New System.Drawing.Point(710, 76)
        Me.HoraFin.Margin = New System.Windows.Forms.Padding(2)
        Me.HoraFin.Name = "HoraFin"
        Me.HoraFin.Size = New System.Drawing.Size(100, 24)
        Me.HoraFin.TabIndex = 64
        Me.HoraFin.Text = "8:00:00"
        '
        'HoraInicio
        '
        Me.HoraInicio.FormattingEnabled = True
        Me.HoraInicio.Items.AddRange(New Object() {"7:00:00", "8:00:00", "9:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00", "18:00:00", "19:00:00"})
        Me.HoraInicio.Location = New System.Drawing.Point(599, 76)
        Me.HoraInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.HoraInicio.Name = "HoraInicio"
        Me.HoraInicio.Size = New System.Drawing.Size(100, 24)
        Me.HoraInicio.TabIndex = 61
        Me.HoraInicio.Text = "7:00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(707, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Hora Fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(596, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Hora Inicio:"
        '
        'TxtNC
        '
        Me.TxtNC.Location = New System.Drawing.Point(384, 76)
        Me.TxtNC.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNC.Multiline = True
        Me.TxtNC.Name = "TxtNC"
        Me.TxtNC.Size = New System.Drawing.Size(211, 24)
        Me.TxtNC.TabIndex = 59
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(382, 59)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 15)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "NC:"
        '
        'TxtDocente
        '
        Me.TxtDocente.Location = New System.Drawing.Point(11, 33)
        Me.TxtDocente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDocente.Multiline = True
        Me.TxtDocente.Name = "TxtDocente"
        Me.TxtDocente.Size = New System.Drawing.Size(584, 24)
        Me.TxtDocente.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 16)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 15)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Docente:"
        '
        'TxtAula
        '
        Me.TxtAula.FormattingEnabled = True
        Me.TxtAula.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08"})
        Me.TxtAula.Location = New System.Drawing.Point(710, 33)
        Me.TxtAula.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAula.Name = "TxtAula"
        Me.TxtAula.Size = New System.Drawing.Size(100, 24)
        Me.TxtAula.TabIndex = 56
        Me.TxtAula.Text = "01"
        '
        'TxtEdificio
        '
        Me.TxtEdificio.FormattingEnabled = True
        Me.TxtEdificio.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.TxtEdificio.Location = New System.Drawing.Point(599, 33)
        Me.TxtEdificio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEdificio.Name = "TxtEdificio"
        Me.TxtEdificio.Size = New System.Drawing.Size(100, 24)
        Me.TxtEdificio.TabIndex = 13
        Me.TxtEdificio.Text = "A"
        '
        'TxtAlumno
        '
        Me.TxtAlumno.Location = New System.Drawing.Point(11, 76)
        Me.TxtAlumno.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtAlumno.Multiline = True
        Me.TxtAlumno.Name = "TxtAlumno"
        Me.TxtAlumno.Size = New System.Drawing.Size(369, 24)
        Me.TxtAlumno.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 59)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 15)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Alumno:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(707, 16)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 15)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Aula:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(596, 16)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 15)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Edificio:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(457, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 37)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(9, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 37)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(599, 3)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(219, 37)
        Me.BtnGrabar.TabIndex = 30
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnGrabar)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 652)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 49)
        Me.Panel1.TabIndex = 33
        '
        'PanelFiltro
        '
        Me.PanelFiltro.Controls.Add(Me.Panel2)
        Me.PanelFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltro.Location = New System.Drawing.Point(0, 80)
        Me.PanelFiltro.Name = "PanelFiltro"
        Me.PanelFiltro.Size = New System.Drawing.Size(824, 71)
        Me.PanelFiltro.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpFecha)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtIdApartado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(528, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel2.Size = New System.Drawing.Size(296, 71)
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
        Me.Label1.Location = New System.Drawing.Point(217, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Id Apartado:"
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
        'TxtIdApartado
        '
        Me.TxtIdApartado.Location = New System.Drawing.Point(141, 36)
        Me.TxtIdApartado.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdApartado.Multiline = True
        Me.TxtIdApartado.Name = "TxtIdApartado"
        Me.TxtIdApartado.ReadOnly = True
        Me.TxtIdApartado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtIdApartado.Size = New System.Drawing.Size(141, 21)
        Me.TxtIdApartado.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGVReservaciones)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 315)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 164)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horarios Reservados"
        '
        'DGVReservaciones
        '
        Me.DGVReservaciones.AllowUserToAddRows = False
        Me.DGVReservaciones.AllowUserToDeleteRows = False
        Me.DGVReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVReservaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.HoraInicial, Me.HoraFinal})
        Me.DGVReservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVReservaciones.Location = New System.Drawing.Point(3, 19)
        Me.DGVReservaciones.Name = "DGVReservaciones"
        Me.DGVReservaciones.ReadOnly = True
        Me.DGVReservaciones.RowHeadersWidth = 51
        Me.DGVReservaciones.RowTemplate.Height = 24
        Me.DGVReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVReservaciones.Size = New System.Drawing.Size(818, 142)
        Me.DGVReservaciones.TabIndex = 13
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'HoraInicial
        '
        Me.HoraInicial.HeaderText = "Hora Inicial"
        Me.HoraInicial.Name = "HoraInicial"
        Me.HoraInicial.ReadOnly = True
        '
        'HoraFinal
        '
        Me.HoraFinal.HeaderText = "Hora Final"
        Me.HoraFinal.Name = "HoraFinal"
        Me.HoraFinal.ReadOnly = True
        '
        'ApartadoLugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 701)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelFiltro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ApartadoLugar"
        Me.Text = "ApartadoLugar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGVLugar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PanelFiltro.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVReservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGVLugar As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TxtNC As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtDocente As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtAula As ComboBox
    Friend WithEvents TxtEdificio As ComboBox
    Friend WithEvents TxtAlumno As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents idLugar As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PanelFiltro As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIdApartado As TextBox
    Friend WithEvents HoraFin As ComboBox
    Friend WithEvents HoraInicio As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVReservaciones As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicial As DataGridViewTextBoxColumn
    Friend WithEvents HoraFinal As DataGridViewTextBoxColumn
    Friend WithEvents Concepto As TextBox
    Friend WithEvents Label4 As Label
End Class
