Imports MySql.Data.MySqlClient

Public Class FrmBitacora
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Private Sub FrmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand


        dgvBitacora.Rows.Clear()
        comando.CommandText = "select * from bitacora"

        lector = comando.ExecuteReader()
        While lector.Read
            dgvBitacora.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub FrmBitacora_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        conexion.Close()
    End Sub
End Class