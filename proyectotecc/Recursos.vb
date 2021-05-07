Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Recursos
    Dim conexion As MySqlConnection

    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0
    Dim opcion As Integer = 0

    Private Sub Recursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand


        comando.CommandText = "Select * from CATEGORIA"
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdCategoria.Items.Add(lector(0))
        End While
        lector.Close()

        txtIdRecursos.Enabled = False
        cboIdCategoria.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        gb1.Enabled = True

        dgwRecurso.Rows.Clear()

        actualizar()
        colocar(0)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        opcion = 2

        txtDescripcion.Enabled = True
        cboIdCategoria.Enabled = False
        btnRegistrar.Enabled = True

        gb1.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnRegistrar.Text = "Guardar"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDescripcion.Enabled = True
        cboIdCategoria.Enabled = True
        btnRegistrar.Enabled = True
        gb1.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False

        opcion = 1
        filas = dgwRecurso.RowCount
        filas -= 1
        colocar(filas)
        comando.CommandText = "SELECT count(idRecursos	) FROM RECURSOS"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdRecursos.Text = CInt(lector(0)) + 1
        lector.Close()

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            If opcion = 2 Then
                comando.CommandText = "UPDATE RECURSOS set  descripcion  = '" & txtDescripcion.Text & "'  Where idRecursos =" & txtIdRecursos.Text
            ElseIf opcion = 1 Then
                comando.CommandText = "insert into RECURSOS (idRecursos,descripcion,idCategoria) values( '" & txtIdRecursos.Text & "' , '" & txtDescripcion.Text & "', '" & cboIdCategoria.Text & "')"
            End If
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos " & ex.Message)
        End Try
        actualizar()
        opcion = 0
        cboIdCategoria.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        gb1.Enabled = True
        btnNuevo.Enabled = True
        txtDescripcion.Enabled = False
        btnRegistrar.Text = "Regristar"


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub actualizar()
        dgwRecurso.Rows.Clear()
        comando.CommandText = "Select * from RECURSOS"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwRecurso.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()

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
        dgwRecurso.CurrentCell = dgwRecurso(0, fila)
        If dgwRecurso.Columns.Count >= 0 Then


            txtIdRecursos.Text = dgwRecurso.Item(0, fila).Value
            txtDescripcion.Text = dgwRecurso.Item(1, fila).Value
            Dim aux = (dgwRecurso.Item(2, fila).Value)
            If Not IsNothing(aux) Then
                cboIdCategoria.SelectedItem = Integer.Parse(aux)
            Else
                cboIdCategoria.SelectedItem = 1
            End If


        End If


    End Sub

    Private Sub cboIdCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdCategoria.SelectedIndexChanged
        comando.CommandText = "Select * from CATEGORIA where idCategoria = " & cboIdCategoria.Text
        lector = comando.ExecuteReader

        lector.Read()
        txtConcepto.Text = lector(1)
        lector.Close()
    End Sub


End Class
