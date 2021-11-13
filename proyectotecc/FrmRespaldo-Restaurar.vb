Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FrmRespaldo_Restaurar
    Dim connection As New MySqlConnection(conn)
    Dim command As New MySqlCommand
    Dim lector As MySqlDataReader
    Private Sub FrmRespaldo_Restaurar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()
            command = connection.CreateCommand
        Catch
            MsgBox("¡REVISA LA CONEXIÓN A INTERNET!")
        End Try
    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Try
            Dim abrir As New OpenFileDialog
            Dim cadena As String
            abrir.FileName = " "
            abrir.Filter = "|*.sql"
            abrir.ShowDialog()
            cadena = abrir.FileName
            Dim mb As MySqlBackup = New MySqlBackup(command)
            mb.ImportFromFile(cadena)
            MessageBox.Show("Respaldo Exitoso...")
        Catch ex As Exception
            MsgBox("Recuerda elegir un nombre para restaurar la base de datos")
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            Dim guardar As New SaveFileDialog
            Dim cadena As String
            guardar.FileName = ""
            guardar.ShowDialog()
            cadena = guardar.FileName
            Dim mb As MySqlBackup = New MySqlBackup(command)
            mb.ExportToFile(cadena)
            MessageBox.Show("Respaldo Exitoso...")
        Catch ex As Exception
            MsgBox("Recuerda poner un nombre a tu respaldo")
        End Try
    End Sub

End Class