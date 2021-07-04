<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteBajas
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
        Me.DTPFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnGenerarReporte = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DTPFechaFinal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.DTPFechaInicial)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(534, 110)
        Me.Panel2.TabIndex = 22
        '
        'DTPFechaFinal
        '
        Me.DTPFechaFinal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaFinal.Location = New System.Drawing.Point(377, 13)
        Me.DTPFechaFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFechaFinal.Name = "DTPFechaFinal"
        Me.DTPFechaFinal.Size = New System.Drawing.Size(140, 27)
        Me.DTPFechaFinal.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(271, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DTPFechaInicial
        '
        Me.DTPFechaInicial.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.DTPFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaInicial.Location = New System.Drawing.Point(127, 13)
        Me.DTPFechaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.DTPFechaInicial.Name = "DTPFechaInicial"
        Me.DTPFechaInicial.Size = New System.Drawing.Size(140, 27)
        Me.DTPFechaInicial.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(11, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Inicial:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 65)
        Me.Panel1.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(328, 30)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Reporte: Bajas por periodo"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnGenerarReporte)
        Me.Panel6.Controls.Add(Me.BtnGuardar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 181)
        Me.Panel6.MinimumSize = New System.Drawing.Size(0, 60)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(12)
        Me.Panel6.Size = New System.Drawing.Size(534, 60)
        Me.Panel6.TabIndex = 26
        '
        'BtnGenerarReporte
        '
        Me.BtnGenerarReporte.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.BtnGenerarReporte.Location = New System.Drawing.Point(129, 15)
        Me.BtnGenerarReporte.Name = "BtnGenerarReporte"
        Me.BtnGenerarReporte.Size = New System.Drawing.Size(388, 35)
        Me.BtnGenerarReporte.TabIndex = 22
        Me.BtnGenerarReporte.Text = "Generar Reporte"
        Me.BtnGenerarReporte.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.BtnGuardar.Location = New System.Drawing.Point(9, 15)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(114, 35)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Salir"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'ReporteBajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 241)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReporteBajas"
        Me.Text = "ReporteBajas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents DTPFechaFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DTPFechaInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnGenerarReporte As Button
    Friend WithEvents BtnGuardar As Button
End Class
