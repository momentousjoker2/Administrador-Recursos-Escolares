Imports MySql.Data.MySqlClient

Imports Microsoft.Reporting.WinForms
Public Class ReporteApartadoRecursos
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Dim fechaInicial As String
    Dim fechaFin As String
    Private Sub ReporteApartadoRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            conexion = New MySqlConnection(conn)


            fechaInicial = DTPFechaInicial.Text
            fechaFin = DTPFechaFinal.Text
        Catch ex As Exception
            bitacora("ReporteApartadoRecursos - Load", ex)

        End Try
    End Sub

    Private Sub BtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtnGenerarReporte.Click
        Try
            conexion.Open()
            comando = conexion.CreateCommand
            Dim FechaInicio As Date = DTPFechaInicial.Value
            Dim FechaFinal As Date = DTPFechaFinal.Value
            fechaInicial = FechaInicio.Year & "-" & FechaInicio.Month & "-" & FechaInicio.Day
            fechaFin = FechaFinal.Year & "-" & FechaFinal.Month & "-" & FechaFinal.Day
            Dim R As String = "SELECT * FROM APARTADORECURSO where Fecha BETWEEN '" & fechaInicial & "' AND '" & fechaFin & "'"
            Dim Data As New DataSet("Data1")

            Dim command As New MySqlCommand(R, conexion)
            Dim Adaptador As New MySqlDataAdapter(command)
            Adaptador.Fill(Data)

            Dim DataSource As New ReportDataSource("DataSet1", Data.Tables(0))
            DataSource.Name = "DataSet1"
            DataSource.Value = Data.Tables(0)

            Dim p1 As New ReportParameter("fechaInicial", fechaInicial)
            Dim p2 As New ReportParameter("fechaFinal", fechaFin)
            Dim p3 As New ReportParameter("fecha", DateAndTime.Now.ToString)

            FormReport.ReportViewer1.LocalReport.ReportPath = rutaReportes & "ReporteApartadoRecursos.rdlc"

            FormReport.ReportViewer1.LocalReport.DataSources.Clear()
            FormReport.ReportViewer1.LocalReport.DataSources.Add(DataSource)
            FormReport.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p2, p1, p3})
            FormReport.ReportViewer1.RefreshReport()
            FormReport.WindowState = FormWindowState.Maximized
            FormReport.Show()
            conexion.Close()

            Me.Dispose()
        Catch ex As Exception
            bitacora("ReporteApartadoRecursos - Click", ex)

        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Dispose()
    End Sub
End Class