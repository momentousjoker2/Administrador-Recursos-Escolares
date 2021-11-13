Imports MySql.Data.MySqlClient

Imports Microsoft.Reporting.WinForms
Public Class ReporteRecursosAulaEdificio
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Dim fechaInicial As String
    Dim fechaFin As String
    Dim lugar As String
    Private Sub ReporteRecursosAulaEdificio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion = New MySqlConnection(conn)
            conexion.Open()
            comando = conexion.CreateCommand

            Dim R As String

            R = "SELECT CONCAT(Edificio,' - ',Aula) As Lugar FROM `APARTADORECURSO` GROUP BY Lugar; "

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                ComboBox1.Items.Add(lector(0))
            End While
            lector.Close()
            conexion.Close()
        Catch ex As Exception
            bitacora("ReporteAulaEdifico - Load", ex)
        End Try
    End Sub

    Private Sub BtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtnGenerarReporte.Click
        Try
            conexion.Open()
            Dim arrayPalabras() As String
            arrayPalabras = Strings.Split(ComboBox1.Text, "-")

            Dim Edificio = arrayPalabras(0).Replace(" ", String.Empty)
            Dim Aula = arrayPalabras(1).Replace(" ", String.Empty)

            Dim R As String = "SELECT RA.IdRecursoAsignado,RA.IdRecurso,R.descripcion as Recurso,RA.Fecha,RA.Responsable,RA.Estado FROM RECURSOSASIGNADOS as RA INNER JOIN RECURSOS as R on RA.IdRecurso= R.idRecursos WHERE RA.Edificio = '" & Edificio & "' AND RA.Aula = '" & Aula & "';"

            Dim Data As New DataSet("Data1")

            Dim command As New MySqlCommand(R, conexion)
            Dim Adaptador As New MySqlDataAdapter(command)
            Adaptador.Fill(Data)

            Dim DataSource As New ReportDataSource("DataSet1", Data.Tables(0))
            DataSource.Name = "DataSet1"
            DataSource.Value = Data.Tables(0)

            Dim p1 As New ReportParameter("edificio", Edificio)
            Dim p2 As New ReportParameter("aula", Aula)
            Dim p3 As New ReportParameter("fecha", DateAndTime.Now.ToString)

            FormReport.ReportViewer1.LocalReport.ReportPath = rutaReportes & "RecursosAulaEdificio.rdlc"
            FormReport.ReportViewer1.LocalReport.DataSources.Clear()
            FormReport.ReportViewer1.LocalReport.DataSources.Add(DataSource)
            FormReport.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p2, p1, p3})
            FormReport.ReportViewer1.RefreshReport()
            FormReport.WindowState = FormWindowState.Maximized

            FormReport.Show()
            conexion.Close()
        Catch ex As Exception
            bitacora("ReporteAulaEdifico - Click", ex)
        End Try
    End Sub
End Class