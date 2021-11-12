Imports System.Data.SqlClient
Imports System.Configuration
Imports System.ComponentModel

Public Class FrmRespaldo_Restaurar
    Dim conexion = New SqlConnection(connectionStringRestaurar)
    Dim comando As New SqlCommand 'Ejecuta comandos SQL
    Private Sub FrmRespaldo_Restaurar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "
            SET NOCOUNT ON
            DECLARE @DBName varchar(50)
            DECLARE @spidstr varchar(8000)
            DECLARE @ConnKilled smallint
            SET @ConnKilled=0
            SET @spidstr = ''
            Set @DBName = 'FERRETERIA'
            IF db_id(@DBName) < 4
            BEGIN
            PRINT 'Connections to system databases cannot be killed'
            RETURN
            END
            SELECT @spidstr=coalesce(@spidstr,',' )+'kill '+convert(varchar, spid)+ '; '
            FROM master..sysprocesses WHERE dbid=db_id(@DBName)
            IF LEN(@spidstr) > 0
            BEGIN
            EXEC(@spidstr)
            SELECT @ConnKilled = COUNT(1)
            FROM master..sysprocesses WHERE dbid=db_id(@DBName)
            END"
        comando.ExecuteNonQuery()


    End Sub

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click

        Try
            OpenFileDialog1.InitialDirectory = "C:\\"
            OpenFileDialog1.Filter = "Archivos de texto (*.bak)|*.bak"

            Dim str_RutaArchivo As String
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                str_RutaArchivo = OpenFileDialog1.FileName
                txtRuta1.Text = str_RutaArchivo
                'comando.CommandText = "DROP DATABASE FERRETERIA"
                'comando.ExecuteNonQuery()
                comando.CommandText = "RESTORE DATABASE FERRETERIA FROM DISK = '" & str_RutaArchivo & "' WITH Replace"
                comando.ExecuteNonQuery()
            End If
            MsgBox("La restauración fue un exito")
        Catch ex As Exception
            MsgBox("A ocurrido un error con la restauracion" & ex.ToString)
        End Try
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            SaveFileDialog1.InitialDirectory = "C:\\"
            SaveFileDialog1.Filter = "Archivos de texto (*.bak)|*.bak"

            Dim str_RutaArchivo As String
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                str_RutaArchivo = SaveFileDialog1.FileName
                txtRuta2.Text = str_RutaArchivo
                comando.CommandText = "BACKUP DATABASE [FERRETERIA] TO DISK = N'" & str_RutaArchivo & "'"
                comando.ExecuteNonQuery()
            End If
            conexion.Close()
            MsgBox("El respaldo fue un exito")
        Catch
            MsgBox("A ocurrido un error con la restauracion")
        End Try
    End Sub

    Private Sub FrmRespaldo_Restaurar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conexion.Close()
    End Sub
End Class