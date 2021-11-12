Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReporteCategoria
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select * from CATEGORIA"
        lector = comando.ExecuteReader
        While lector.Read()
            cboCategoria.Items.Add(lector(1))
        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub BtnGenerarReporte_Click(sender As Object, e As EventArgs) Handles BtnGenerarReporte.Click
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand


        Dim R As String = "Select R.idRecursos,R.descripcion from RECURSOS AS R INNER JOIN CATEGORIA as C ON R.idCategoria = C.idCategoria WHERE C.Concepto  = '" & cboCategoria.Text & "'"

        Dim Data As New DataSet("Data1")

        Dim command As New MySqlCommand(R, conexion)
        Dim Adaptador As New MySqlDataAdapter(command)
        Adaptador.Fill(Data)

        Dim DataSource As New ReportDataSource("DataSet1", Data.Tables(0))
        DataSource.Name = "DataSet1"
        DataSource.Value = Data.Tables(0)
        Dim p1 As New ReportParameter("categoria", cboCategoria.Text)
        Dim p2 As New ReportParameter("fecha", DateAndTime.Now.ToString)


        FormReport.ReportViewer1.LocalReport.ReportPath = rutaReportes & "ReporteRecursosCategoria.rdlc"

        FormReport.ReportViewer1.LocalReport.DataSources.Clear()
        FormReport.ReportViewer1.LocalReport.DataSources.Add(DataSource)
        FormReport.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2})
        FormReport.ReportViewer1.RefreshReport()
        FormReport.WindowState = FormWindowState.Maximized

        FormReport.Show()
        conexion.Close()

        Me.Dispose()
    End Sub


End Class