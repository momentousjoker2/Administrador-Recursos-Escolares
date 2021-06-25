Imports MySql.Data.MySqlClient
Public Class DetalleApartadoRecurso
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader



    Private Sub DGVRecursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRecursos.CellClick
        DataGridViewDetalle.Rows.Clear()
        conexion.Open()
        Dim B As String
        comando = conexion.CreateCommand
        Dim id = Val(DGVRecursos.SelectedCells.Item(0).Value.ToString)
        B = "SELECT * FROM DETALLEAPARTADORECURSO where IdApartadoRec=" & Val(id)
        comando.CommandText = B
        lector = comando.ExecuteReader
        While lector.Read
            DataGridViewDetalle.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DGVRecursos.Rows.Clear()
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim A As String
        comando = conexion.CreateCommand
        Dim fechaIni As String = dtpFechaInicio.Value.ToString("yyyy-MM-dd")
        Dim fechaFin As String = dtpFechaFin.Value.ToString("yyyy-MM-dd")
        A = "Select * From APARTADORECURSO where Fecha between'" + fechaIni + "' and '" + fechaFin + "' "
        comando.CommandText = A
        lector = comando.ExecuteReader
        While lector.Read
            DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class