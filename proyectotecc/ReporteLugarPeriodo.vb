Imports MySql.Data.MySqlClient

Imports Microsoft.Reporting.WinForms
Public Class ReporteLugarPeriodo
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Dim fechaInicial As String
    Dim fechaFin As String
    Dim lugar As String

    Private Sub ReporteLugarPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String

        R = "SELECT * FROM LUGAR"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            ComboBoxLugar.Items.Add(lector(1))
        End While
        lector.Close()
        conexion.Close()
        fechaInicial = DTPFechaInicial.Text
        fechaFin = DTPFechaFinal.Text

    End Sub

    Private Sub BtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtnGenerarReporte.Click
        conexion.Open()
        Dim FechaInicio As Date = DTPFechaInicial.Value
        Dim FechaFinal As Date = DTPFechaFinal.Value
        fechaInicial = FechaInicio.Year & "-" & FechaInicio.Month & "-" & FechaInicio.Day
        fechaFin = FechaFinal.Year & "-" & FechaFinal.Month & "-" & FechaFinal.Day

        Dim Q As String = "SELECT idLugar FROM LUGAR WHERE Concepto = '" & ComboBoxLugar.Text & "'"
        comando.CommandText = Q
        lector = comando.ExecuteReader
        lugar = lector.Read()
        lector.Close()

        Dim R As String = "SELECT IdApartado, LUGAR.Concepto, Docente, HoraInicial, HoraFinal, Estado FROM `APARTADOS-LUGAR` AS ap INNER JOIN LUGAR ON LUGAR.idLugar = ap.idLugar WHERE ap.idLugar =" & lugar & " AND Fecha BETWEEN '" & fechaInicial & "' AND '" & fechaFin & "'"

        Dim Data As New DataSet("Data1")

        Dim command As New MySqlCommand(R, conexion)
        Dim Adaptador As New MySqlDataAdapter(command)
        Adaptador.Fill(Data)

        Dim DataSource As New ReportDataSource("DataSet1", Data.Tables(0))
        DataSource.Name = "DataSet1"
        DataSource.Value = Data.Tables(0)

        Dim p1 As New ReportParameter("fechaIni", fechaInicial)
        Dim p2 As New ReportParameter("fechaFinal", fechaFin)
        Dim p3 As New ReportParameter("lugar", ComboBoxLugar.Text)
        Dim p4 As New ReportParameter("fecha", DateAndTime.Now.ToString)

        FormReport.ReportViewer1.LocalReport.ReportPath = rutaReportes & "ReporteLugarPeriodo.rdlc"

        FormReport.ReportViewer1.LocalReport.DataSources.Clear()
        FormReport.ReportViewer1.LocalReport.DataSources.Add(DataSource)
        FormReport.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p2, p1, p3, p4})
        FormReport.ReportViewer1.RefreshReport()
        FormReport.WindowState = FormWindowState.Maximized

        FormReport.Show()
        conexion.Close()

        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Me.Dispose()
    End Sub
End Class