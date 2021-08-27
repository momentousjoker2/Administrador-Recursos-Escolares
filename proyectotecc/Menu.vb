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

    Private Sub AsignarRecursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarRecursosToolStripMenuItem.Click
        AsignarRecursos.Show()
    End Sub

    Private Sub ApartarRecursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartarRecursosToolStripMenuItem.Click
        ApartarRecurso.Show()
    End Sub

    Private Sub ApartarLugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartarLugarToolStripMenuItem.Click
        ApartadoLugar.Show()
    End Sub

    Private Sub ConsultaBajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaBajasToolStripMenuItem.Click
        ConsultaBajas.Show()
    End Sub

    Private Sub LugarPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LugarPeriodoToolStripMenuItem.Click
        ReporteLugarPeriodo.Show()
    End Sub

    Private Sub BajasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BajasToolStripMenuItem1.Click
        ReporteBajas.Show()
    End Sub

    Private Sub Menu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda)
        End If
    End Sub
End Class