Imports MySql.Data.MySqlClient

Public Class ConsultaApartadoLugar
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Private Sub ConsultaApartadoLugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillData()
    End Sub

    Private Sub FillData()
        Conexion = New MySqlConnection(conn)
        Conexion.Open()
        comando = Conexion.CreateCommand

        Dim R As String
        Dim FechaA As Date = dtpFecha.Value

        R = "SELECT IdApartado, LUGAR.Concepto, Docente, HoraInicial, HoraFinal, Estado FROM `APARTADOS-LUGAR` AS ap INNER JOIN LUGAR ON LUGAR.idLugar = ap.idLugar WHERE Fecha = '" &
                                                                       FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader


        DGVReservaciones.Rows.Clear()

        While lector.Read()

            DGVReservaciones.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            If lector(5).Equals("Cancelado") Then
                DGVReservaciones.Rows(DGVReservaciones.RowCount - 1).DefaultCellStyle.BackColor = Color.Red

            End If
        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        FillData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String
        Dim id = Val(DGVReservaciones.SelectedCells.Item(0).Value)
        R = "UPDATE `APARTADOS-LUGAR` SET Estado = 'Cancelado' WHERE IdApartado = " & id
        comando.CommandText = R
        comando.ExecuteNonQuery()
        lector.Close()
        conexion.Close()

        FillData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Dispose()
    End Sub
End Class