Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class categoría
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0
    Dim opcion As Integer = 0
    Private Sub categoría_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand
        btnModificar.Enabled = True
        txtIdCategoria.Enabled = False
        txtConcepto.Enabled = False
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
        dgwCategoria.Rows.Clear()
        actualizar()
        colocar(0)
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdCategoria.Enabled = False
        txtConcepto.Enabled = True
        btnModificar.Enabled = False
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
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            If opcion = 2 Then
                comando.CommandText = "UPDATE CATEGORIA set Concepto = '" & txtConcepto.Text & "' Where idCategoria =" & txtIdCategoria.Text
            ElseIf opcion = 1 Then
                comando.CommandText = "insert into CATEGORIA(Concepto) values('" & txtConcepto.Text & "')"
            End If
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos")
        End Try
        actualizar()
        txtIdCategoria.Enabled = False
        txtConcepto.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        opcion = 2
        txtIdCategoria.Enabled = False
        txtConcepto.Enabled = True
        btnModificar.Enabled = False
        btnRegistrar.Enabled = True
        btnNuevo.Enabled = False
        gb1.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub actualizar()
        dgwCategoria.Rows.Clear()
        comando.CommandText = "Select * from CATEGORIA"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwCategoria.Rows.Add(lector(0), lector(1))
        End While
        lector.Close()
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
End Class