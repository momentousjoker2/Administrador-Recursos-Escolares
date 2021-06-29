Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Pantallas
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0


    Private Sub Pantallas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand


        comando.CommandText = "SELECT * FROM RECURSOS WHERE RECURSOS.idRecursos NOT IN (SELECT PANTALLAS.IdRecurso FROM PANTALLAS) AND RECURSOS.idCategoria = 3"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreRecursos.Items.Add(lector(1))
        End While
        lector.Close()
        If cboNombreRecursos.Items.Count >= 0 Then
            cboNombreRecursos.SelectedItem = 0
        End If

        txtidRecursos.Enabled = False
        txtTipo.Enabled = False
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtDimension.Enabled = False
        txtEstado.Enabled = False
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
        dgwPantalla.Rows.Clear()

        actualizar()
        colocar(0)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If cboNombreRecursos.Items.Count = 0 Then
            MsgBox("Usted no tiene nuevos recusos que registar en esta categoría")
        Else
            txtTipo.Enabled = True
            txtInvcapece.Enabled = True
            txtMarca.Enabled = True
            txtModelo.Enabled = True
            txtDimension.Enabled = True
            btnRegistrar.Enabled = True
            btnNuevo.Enabled = False
            gb1.Enabled = False
            txtidRecursos.Enabled = False
            filas = dgwPantalla.RowCount
            filas -= 1
            colocar(filas)
            cboNombreRecursos.Enabled = True
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            comando.CommandText = "insert into PANTALLAS(IdRecurso,Tipo,INVCAPECE,Marca,Modelo,Dimension,Estado) values('" & txtidRecursos.Text & "','" & txtTipo.Text & "','" & txtInvcapece.Text & "','" & txtMarca.Text & "','" & txtModelo.Text & "','" & txtDimension.Text & "','" & txtEstado.Text & "')"
            comando.ExecuteNonQuery()
            cboNombreRecursos.Items.Remove(cboNombreRecursos.SelectedItem)
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos " & ex.Message)
        End Try
        actualizar()
        txtTipo.Enabled = False
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtDimension.Enabled = False
        btnRegistrar.Enabled = False
        cboNombreRecursos.Enabled = False
        txtidRecursos.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True

    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
    Private Sub actualizar()
        dgwPantalla.Rows.Clear()
        comando.CommandText = "Select r.idRecursos, r.descripcion,p.Tipo,p.INVCAPECE,p.Marca,p.Modelo,p.Dimension,p.Estado from PANTALLAS as p INNER JOIN RECURSOS as r on p.IdRecurso = r.idRecursos"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwPantalla.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
        End While
        lector.Close()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fila As Integer
        fila = dgwPantalla.CurrentRow.Index
        fila += 1
        Dim filas As Integer
        filas = dgwPantalla.RowCount
        If fila < filas - 1 Then
            colocar(fila)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim fila As Integer
        fila = dgwPantalla.CurrentRow.Index
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
        filas = dgwPantalla.RowCount
        filas -= 2
        If filas < 1 Then
            filas = 0
        End If
        colocar(filas)
    End Sub

    Private Sub colocar(fila As Integer)
        dgwPantalla.CurrentCell = dgwPantalla(0, fila)
        If (IsNothing(dgwPantalla.Item(1, fila).Value)) Then
            cboNombreRecursos.SelectedIndex = 0

        Else
            cboNombreRecursos.Text = dgwPantalla.Item(1, fila).Value
        End If

        comando.CommandText = "Select * from RECURSOS where descripcion =   '" & cboNombreRecursos.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtidRecursos.Text = lector(0)
        lector.Close()

        txtTipo.Text = dgwPantalla.Item(2, fila).Value
        txtInvcapece.Text = dgwPantalla.Item(3, fila).Value
        txtMarca.Text = dgwPantalla.Item(4, fila).Value
        txtModelo.Text = dgwPantalla.Item(5, fila).Value
        txtDimension.Text = dgwPantalla.Item(6, fila).Value

        txtEstado.Text = dgwPantalla.Item(7, fila).Value
        If txtEstado.Text.Length.Equals(0) Then
            txtEstado.Text = "Disponible"
        End If

    End Sub

    Private Sub cboNombreRecursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreRecursos.SelectedIndexChanged
        comando.CommandText = "Select * from RECURSOS where descripcion =   '" & cboNombreRecursos.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtidRecursos.Text = lector(0)
        lector.Close()
    End Sub
End Class