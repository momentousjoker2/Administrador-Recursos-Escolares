Imports MySql.Data.MySqlClient

Public Class ConsultaApartadoRecurso
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Private Sub FillData()
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String
        Dim FechaA As Date = dtpFecha.Value

        R = "SELECT * FROM `APARTADORECURSO` WHERE Fecha = '" &
                                                                       FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader


        DGVApartado.Rows.Clear()

        While lector.Read()

            DGVApartado.Rows.Add(lector(0), lector(2), lector(3), lector(4), lector(5), lector(6))

        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub ConsultaApartadoRecurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillData()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        FillData()
    End Sub


    Private Sub DGVApartado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVApartado.CellClick
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String
        Dim id = Val(DGVApartado.SelectedCells.Item(0).Value)

        R = "SELECT DAR.IdRecurso, R.descripcion, DAR.CantidadPrest, DAR.CantidadDev, DAR.FechaDev  FROM `DETALLEAPARTADORECURSO` AS DAR INNER JOIN `APARTADORECURSO` AS AR ON DAR.IdApartadoRec = AR.IdApartadoRec 
                                                                                                            INNER JOIN RECURSOS AS R ON DAR.IdRecurso = R.idRecursos WHERE DAR.IdApartadoRec = " & id
        comando.CommandText = R
        lector = comando.ExecuteReader


        DGVDetalle.Rows.Clear()

        While lector.Read()

            DGVDetalle.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))

        End While
        lector.Close()
        conexion.Close()
    End Sub


    Private Sub DGVDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellClick
        Dim cant As Integer = DGVDetalle.SelectedCells.Item(2).Value
        TxtCantidadPrest.Text = cant

        CboCantidadDev.Items.Clear()

        For i = 1 To cant
            CboCantidadDev.Items.Add(i)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String
        Dim id = Val(DGVApartado.SelectedCells.Item(0).Value)
        Dim idRecurso = Val(DGVDetalle.SelectedCells.Item(0).Value)
        Dim FechaA As Date = Date.Today


        R = "UPDATE `DETALLEAPARTADORECURSO` SET CantidadDev = " & CboCantidadDev.Text & ", FechaDev = '" & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day &
                                                                                                "' WHERE IdApartadoRec = " & id & " AND IdRecurso = " & idRecurso
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