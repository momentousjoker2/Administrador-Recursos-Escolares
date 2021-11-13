Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class categoría
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0
    Dim opcion As Integer = 0
    Private Sub categoría_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            conexion = New MySqlConnection(conn)
            conexion.Open()
            comando = conexion.CreateCommand
            txtIdCategoria.Enabled = False
            txtConcepto.Enabled = False
            btnRegistrar.Enabled = False
            btnNuevo.Enabled = True
            gb1.Enabled = True
            dgwCategoria.Rows.Clear()
            actualizar()
            colocar(0)
            lector.Close()
        Catch ex As Exception
            bitacora("Categoria - Load", ex)

        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            txtIdCategoria.Enabled = False
            txtConcepto.Enabled = True
            btnRegistrar.Enabled = True
            btnNuevo.Enabled = False
            gb1.Enabled = False
            opcion = 1
            filas = dgwCategoria.RowCount
            filas -= 1
            colocar(filas)
            comando.CommandText = "SELECT count(idCategoria	) FROM CATEGORIA"
            lector = comando.ExecuteReader
            lector.Read()
            txtIdCategoria.Text = CInt(lector(0)) + 1
            lector.Close()
        Catch ex As Exception
            bitacora("Categoria - New", ex)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Try
            If opcion = 2 Then
                comando.CommandText = "UPDATE CATEGORIA set Concepto = '" & txtConcepto.Text.ToString & "' Where idCategoria =" & txtIdCategoria.Text.ToString
            ElseIf opcion = 1 Then
                comando.CommandText = "insert into CATEGORIA(Concepto) values('" & txtConcepto.Text.ToString & "')"
            End If
            comando.ExecuteNonQuery()

            actualizar()
            txtIdCategoria.Enabled = False
            txtConcepto.Enabled = False
            btnRegistrar.Enabled = False
            btnNuevo.Enabled = True
            gb1.Enabled = True
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos")
            bitacora("Categoria - registrar", ex)

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub actualizar()
        Try
            dgwCategoria.Rows.Clear()
            comando.CommandText = "Select * from CATEGORIA"
            lector = comando.ExecuteReader
            While lector.Read()
                dgwCategoria.Rows.Add(lector(0), lector(1))
            End While
            lector.Close()


        Catch ex As Exception
            bitacora("Categoria - Update", ex)

        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fila As Integer
        fila = dgwCategoria.CurrentRow.Index
        fila += 1
        Dim filas As Integer
        filas = dgwCategoria.RowCount
        If fila < filas - 1 Then
            colocar(fila)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim fila As Integer
        fila = dgwCategoria.CurrentRow.Index
        fila -= 1
        If fila < 0 Then
            fila = 0
        End If
        colocar(fila)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        colocar(0)
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Dim filas As Integer
        filas = dgwCategoria.RowCount
        filas -= 2
        If filas < 1 Then
            filas = 0
        End If
        colocar(filas)
    End Sub

    Private Sub colocar(fila As Integer)
        dgwCategoria.CurrentCell = dgwCategoria(0, fila)
        txtIdCategoria.Text = dgwCategoria.Item(0, fila).Value
        txtConcepto.Text = dgwCategoria.Item(1, fila).Value
    End Sub

    Private Sub categoría_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda)
        End If
    End Sub
End Class