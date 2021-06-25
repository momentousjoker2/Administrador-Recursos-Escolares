Imports MySql.Data.MySqlClient

Public Class ApartadoLugar
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Private Sub ApartadoLugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String

        R = "SELECT * FROM LUGAR"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVLugar.Rows.Add(lector(0), lector(1))
        End While
        lector.Close()

        comando.CommandText = "SELECT COUNT(IdApartado) FROM `APARTADOS-LUGAR`"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdApartado.Text = CInt(lector(0)) + 1

        lector.Close()

        conexion.Close()
    End Sub
    Private Sub DGVLugar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLugar.CellClick
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String
        Dim FechaA As Date = dtpFecha.Value
        Dim A1 = Val(DGVLugar.SelectedCells.Item(0).Value)
        R = "SELECT HoraInicial, HoraFinal FROM `APARTADOS-LUGAR` WHERE Fecha = " & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & " AND IdLugar = " & A1
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVLugar.Rows.Add(lector(0), lector(1))
        End While
        lector.Close()
    End Sub
End Class