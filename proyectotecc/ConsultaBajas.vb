Imports MySql.Data.MySqlClient

Public Class ConsultaBajas
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Private Sub FillData()
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String
        Dim FechaA As Date = dtpFecha.Value

        R = "SELECT B.IdBaja, B.IdRecurso, R.descripcion, B.Concepto, B.Autoriza FROM `BAJAS` AS B  INNER JOIN RECURSOS AS R ON B.IdRecurso = R.idRecursos WHERE Fecha = '" &
                                                                       FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader


        DGVBajas.Rows.Clear()

        While lector.Read()

            DGVBajas.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))

        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        FillData()
    End Sub

    Private Sub ConsultaBajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub ConsultaBajas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda)
        End If
    End Sub
End Class