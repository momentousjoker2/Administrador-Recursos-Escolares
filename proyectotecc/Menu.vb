Public Class Menu
    Private Sub RecursosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecursosToolStripMenuItem1.Click
        Recursos.ShowDialog()
    End Sub

    Private Sub PantallasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PantallasToolStripMenuItem.Click
        Pantallas.ShowDialog()
    End Sub

    Private Sub LugarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LugarToolStripMenuItem1.Click
        Lugar.ShowDialog()
    End Sub

    Private Sub ComputadorasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComputadorasToolStripMenuItem1.Click
        Computadoras.ShowDialog()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        categoría.ShowDialog()
    End Sub

    Private Sub CañonesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CañonesToolStripMenuItem1.Click
        Cañones.ShowDialog()
    End Sub

    Private Sub BajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajasToolStripMenuItem.Click
        Bajas.ShowDialog()
    End Sub
End Class