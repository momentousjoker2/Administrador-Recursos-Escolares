<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecursosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PantallasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputadorasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CañonesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecursosToolStripMenuItem1, Me.PantallasToolStripMenuItem, Me.LugarToolStripMenuItem1, Me.ComputadorasToolStripMenuItem1, Me.CategoriaToolStripMenuItem, Me.CañonesToolStripMenuItem1})
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.HolaToolStripMenuItem.Text = "Catalogos"
        '
        'RecursosToolStripMenuItem1
        '
        Me.RecursosToolStripMenuItem1.Name = "RecursosToolStripMenuItem1"
        Me.RecursosToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.RecursosToolStripMenuItem1.Text = "Recursos"
        '
        'PantallasToolStripMenuItem
        '
        Me.PantallasToolStripMenuItem.Name = "PantallasToolStripMenuItem"
        Me.PantallasToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PantallasToolStripMenuItem.Text = "Pantallas"
        '
        'LugarToolStripMenuItem1
        '
        Me.LugarToolStripMenuItem1.Name = "LugarToolStripMenuItem1"
        Me.LugarToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.LugarToolStripMenuItem1.Text = "Lugar"
        '
        'ComputadorasToolStripMenuItem1
        '
        Me.ComputadorasToolStripMenuItem1.Name = "ComputadorasToolStripMenuItem1"
        Me.ComputadorasToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ComputadorasToolStripMenuItem1.Text = "Computadoras"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'CañonesToolStripMenuItem1
        '
        Me.CañonesToolStripMenuItem1.Name = "CañonesToolStripMenuItem1"
        Me.CañonesToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.CañonesToolStripMenuItem1.Text = "Cañones"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecursosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PantallasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LugarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComputadorasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CañonesToolStripMenuItem1 As ToolStripMenuItem
End Class
