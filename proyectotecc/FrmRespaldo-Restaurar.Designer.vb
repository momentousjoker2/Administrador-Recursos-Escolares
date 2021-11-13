<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRespaldo_Restaurar
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtRuta1 = New System.Windows.Forms.TextBox()
        Me.txtRuta2 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(208, 236)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(90, 29)
        Me.btnAbrir.TabIndex = 0
        Me.btnAbrir.Text = "ABRIR ARCHIVO"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(208, 94)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(90, 28)
        Me.btnGrabar.TabIndex = 1
        Me.btnGrabar.Text = "GRABAR ARCHIVO"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'txtRuta1
        '
        Me.txtRuta1.Location = New System.Drawing.Point(38, 195)
        Me.txtRuta1.Name = "txtRuta1"
        Me.txtRuta1.Size = New System.Drawing.Size(430, 22)
        Me.txtRuta1.TabIndex = 2
        '
        'txtRuta2
        '
        Me.txtRuta2.Location = New System.Drawing.Point(38, 52)
        Me.txtRuta2.Name = "txtRuta2"
        Me.txtRuta2.Size = New System.Drawing.Size(430, 22)
        Me.txtRuta2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(177, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "RESPALDAR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(175, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "RESTAURAR:"
        '
        'FrmRespaldo_Restaurar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 291)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRuta2)
        Me.Controls.Add(Me.txtRuta1)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnAbrir)
        Me.Name = "FrmRespaldo_Restaurar"
        Me.Text = "FrmRespaldo_Restaurar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents txtRuta1 As TextBox
    Friend WithEvents txtRuta2 As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
