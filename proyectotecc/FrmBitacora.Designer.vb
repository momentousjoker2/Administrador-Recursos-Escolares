<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBitacora
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
        Me.dgvBitacora = New System.Windows.Forms.DataGridView()
        Me.idBitacora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaHo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formulario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBitacora
        '
        Me.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idBitacora, Me.fechaHo, Me.formulario, Me.numError, Me.Descripcion})
        Me.dgvBitacora.Location = New System.Drawing.Point(53, 175)
        Me.dgvBitacora.Name = "dgvBitacora"
        Me.dgvBitacora.RowHeadersWidth = 51
        Me.dgvBitacora.RowTemplate.Height = 24
        Me.dgvBitacora.Size = New System.Drawing.Size(680, 194)
        Me.dgvBitacora.TabIndex = 0
        '
        'idBitacora
        '
        Me.idBitacora.HeaderText = "No.Bitácora"
        Me.idBitacora.MinimumWidth = 6
        Me.idBitacora.Name = "idBitacora"
        '
        'fechaHo
        '
        Me.fechaHo.HeaderText = "Fecha y hora"
        Me.fechaHo.MinimumWidth = 6
        Me.fechaHo.Name = "fechaHo"
        '
        'formulario
        '
        Me.formulario.HeaderText = "formulario"
        Me.formulario.MinimumWidth = 6
        Me.formulario.Name = "formulario"
        '
        'numError
        '
        Me.numError.HeaderText = "no. error"
        Me.numError.MinimumWidth = 6
        Me.numError.Name = "numError"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 13.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(153, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 28)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Consulta Bitácora"
        '
        'FrmBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 417)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBitacora)
        Me.Name = "FrmBitacora"
        Me.Text = "Bitácora"
        CType(Me.dgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBitacora As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents idBitacora As DataGridViewTextBoxColumn
    Friend WithEvents fechaHo As DataGridViewTextBoxColumn
    Friend WithEvents formulario As DataGridViewTextBoxColumn
    Friend WithEvents numError As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
End Class
