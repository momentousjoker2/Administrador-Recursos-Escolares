Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.IO
Module Conexion
    Public conn As String = "datasource=mysql-sistemamediosav.alwaysdata.net;port=3306;username=230400_db;password=W*eH0EBY%7oH;database=sistemamediosav_db;"
    Public rutaAyuda As String = "C:\ACAD\proyectotecc\ayuda\help.chm"
    Public rutaReportes As String = "C:\ACAD\proyectotecc\Reporte\"




    Public Sub bitacora(Formulario As String, ex As Exception)
        MsgBox("Error en " & Formulario & " Revise bitacora")

        Dim conexion As MySqlConnection
        Dim comando As MySqlCommand
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R = "insert into bitacora (form,error, descripcion,fechahora) VALUES ( '" & Formulario & "' ,'" & ex.Source.ToString & "','" & ex.Message.Replace("'", " ").ToString & "','" & Now.Date.ToString & "')"
        comando.CommandText = R
        comando.ExecuteNonQuery()
        conexion.Close()
    End Sub

End Module
