Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Recursos
    Dim conexion As MySqlConnection

    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0

    Private Sub Recursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            conexion = New MySqlConnection(conn)
            conexion.Open()
            comando = conexion.CreateCommand


            comando.CommandText = "Select * from CATEGORIA"
            lector = comando.ExecuteReader
            While lector.Read()
                cboIdCategoria.Items.Add(lector(1))
            End While
            lector.Close()

            txtIdRecursos.Enabled = False
            cboIdCategoria.Enabled = False
            btnRegistrar.Enabled = False
            gb1.Enabled = True

            dgwRecurso.Rows.Clear()

            actualizar()
            colocar(0)
        Catch ex As Exception
            bitacora("Recursos - Load", ex)
        End Try
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            txtDescripcion.Enabled = True
            cboIdCategoria.Enabled = True
            btnRegistrar.Enabled = True
            gb1.Enabled = False
            btnNuevo.Enabled = False

            filas = dgwRecurso.RowCount
            filas -= 1
            colocar(filas)
            comando.CommandText = "SELECT count(idRecursos	) FROM RECURSOS"
            lector = comando.ExecuteReader
            lector.Read()
            txtIdRecursos.Text = CInt(lector(0)) + 1
            lector.Close()
        Catch ex As Exception
            bitacora("Recursos - Nuevo", ex)

        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            comando.CommandText = "insert into RECURSOS (idRecursos,descripcion,idCategoria) values( '" & txtIdRecursos.Text & "' , '" & txtDescripcion.Text & "', '" & txtConcepto.Text & "')"
            comando.ExecuteNonQuery()

            actualizar()
            cboIdCategoria.Enabled = False
            btnRegistrar.Enabled = False
            gb1.Enabled = True
            btnNuevo.Enabled = True
            txtDescripcion.Enabled = False
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos " & ex.Message)
            bitacora("Recursos - Regristar", ex)

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub actualizar()
        Try
            dgwRecurso.Rows.Clear()
            comando.CommandText = "Select * from RECURSOS"
            lector = comando.ExecuteReader
            While lector.Read()
                dgwRecurso.Rows.Add(lector(0), lector(1), lector(2))
            End While
            lector.Close()
        Catch ex As Exception
            bitacora("Recursos - Actualizar", ex)
        End Try
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fila As Integer
        fila = dgwRecurso.CurrentRow.Index
        fila += 1
        Dim filas As Integer
        filas = dgwRecurso.RowCount
        If fila < filas - 1 Then
            colocar(fila)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim fila As Integer
        fila = dgwRecurso.CurrentRow.Index
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
        filas = dgwRecurso.RowCount
        filas -= 2
        If filas < 1 Then
            filas = 0
        End If
        colocar(filas)
    End Sub
    Private Sub colocar(fila As Integer)
        Try
            dgwRecurso.CurrentCell = dgwRecurso(0, fila)
            If dgwRecurso.Columns.Count >= 0 Then


                txtIdRecursos.Text = dgwRecurso.Item(0, fila).Value
                txtDescripcion.Text = dgwRecurso.Item(1, fila).Value
                Dim aux = (dgwRecurso.Item(2, fila).Value)
                If Not IsNothing(aux) Then

                    comando.CommandText = "Select * from CATEGORIA where idCategoria = " & aux
                    lector = comando.ExecuteReader

                    lector.Read()
                    Dim aux2 = lector(1)
                    lector.Close()
                    cboIdCategoria.SelectedItem = aux2

                Else
                    cboIdCategoria.SelectedItem = 1
                End If


            End If
        Catch ex As Exception
            bitacora("Recursos - Colocar", ex)
        End Try

    End Sub

    Private Sub cboIdCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdCategoria.SelectedIndexChanged
        Try
            comando.CommandText = "Select * from CATEGORIA where Concepto = '" & cboIdCategoria.Text & "'"
            lector = comando.ExecuteReader

            lector.Read()
            txtConcepto.Text = lector(0)
            lector.Close()
        Catch ex As Exception
            bitacora("Recursos - CBOID", ex)
        End Try
    End Sub

    Private Sub Recursos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda)
        End If
    End Sub
End Class
