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

    End Sub
    Private Sub DGVLugar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLugar.CellClick
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String
        Dim FechaA As Date = dtpFecha.Value
        Dim A1 = Val(DGVLugar.SelectedCells.Item(0).Value)
        Dim Horas As New List(Of Integer)
        Dim HorasF As New List(Of Integer)
        'Dim HoraF As New List(Of Integer)

        R = "SELECT HoraInicial, HoraFinal, TIME_FORMAT(HoraInicial, '%H'), TIME_FORMAT(HoraFinal, '%H'), Estado FROM `APARTADOS-LUGAR` WHERE Fecha = '" &
                                                                        FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' AND IdLugar = " & A1
        comando.CommandText = R
        lector = comando.ExecuteReader


        DGVReservaciones.Rows.Clear()

        While lector.Read()

            If lector(4).Equals("Cancelado") Then
                DGVReservaciones.Rows.Add(DGVLugar.SelectedCells.Item(1).Value, lector(0), lector(1), lector(4))
                DGVReservaciones.Rows(DGVReservaciones.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
                Continue While
            End If
            For i = Val(lector(2)) To Val(lector(3)) - 1
                Horas.Add(i)
                HorasF.Add(i + 1)
            Next

            DGVReservaciones.Rows.Add(DGVLugar.SelectedCells.Item(1).Value, lector(0), lector(1), lector(4))

        End While
        lector.Close()
        HoraInicio.Items.Clear()
        HoraFin.Items.Clear()
        If Horas.Count = 0 Then
            For i = 7 To 20
                HoraInicio.Items.Add(i & ":00:00")
                HoraFin.Items.Add(i & ":00:00")
            Next
            HoraInicio.SelectedIndex = 0
            HoraFin.SelectedIndex = 0
            Exit Sub
        End If

        For i = 7 To 19
            If Horas.Contains(i) Then

                Continue For
            End If

            HoraInicio.Items.Add(i & ":00:00")
        Next

        For i = 8 To 20
            If HorasF.Contains(i) Then

                Continue For
            End If

            HoraFin.Items.Add(i & ":00:00")
        Next
        HoraInicio.SelectedIndex = 0
        HoraFin.SelectedIndex = 0

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Dim R As String
        Dim cat As String
        Dim id As String

        Dim FechaA As Date = dtpFecha.Value
        R = "INSERT INTO `APARTADOS-LUGAR` (IdLugar,Docente,Alumno,Nc,Concepto,Fecha,HoraInicial,HoraFinal, Estado) VALUES (" &
                                                                            Val(DGVLugar.SelectedCells.Item(0).Value) & ",'" &
                                                                            TxtDocente.Text.ToString & "','" &
                                                                            TxtAlumno.Text.ToString & "','" &
                                                                            TxtNC.Text.ToString & "','" &
                                                                            TxtConcepto.Text.ToString & "','" &
                                                                            FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "','" &
                                                                            HoraInicio.Text.ToString & "','" &
                                                                            HoraFin.Text.ToString & "', 'Registrado')"
        comando.CommandText = R
        comando.ExecuteNonQuery()

        DGVReservaciones.Rows.Clear()

        LimpiarDatos()
        MessageBox.Show("El registro se completó exitosamente", "Éxito")
    End Sub

    Private Sub LimpiarDatos()
        TxtDocente.Clear()
        TxtAlumno.Clear()
        TxtNC.Clear()
        TxtConcepto.Clear()
        DGVReservaciones.Rows.Clear()
        HoraInicio.SelectedIndex = 0
        HoraFin.SelectedIndex = 0


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LimpiarDatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ConsultaApartadoLugar.Show()
    End Sub

End Class