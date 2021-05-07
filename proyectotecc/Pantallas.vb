Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Pantallas
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0
    Dim opcion As Integer = 0
    Private Sub Pantallas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand


        comando.CommandText = "Select * from RECURSOS where idCategoria = 3"
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdRecurso.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "Select * from PANTALLAS "
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdRecurso.Items.Remove(lector(0))
        End While
        lector.Close()





        cboIdRecurso.Enabled = False
        txtTipo.Enabled = False
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtDimension.Enabled = False
        txtEstado.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
        dgwPantalla.Rows.Clear()

        actualizar()
        colocar(0)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtTipo.Enabled = True
        txtInvcapece.Enabled = True
        txtMarca.Enabled = True
        txtModelo.Enabled = True
        txtDimension.Enabled = True
        txtEstado.Enabled = True
        btnModificar.Enabled = False
        btnRegistrar.Enabled = True
        btnNuevo.Enabled = False
        gb1.Enabled = False

        opcion = 1

        filas = dgwPantalla.RowCount
        filas -= 1
        colocar(filas)
        cboIdRecurso.Enabled = True

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            '					

            If opcion = 2 Then
                comando.CommandText = "UPDATE PANTALLAS set Tipo = '" & txtTipo.Text & "' , INVCAPECE  = '" & txtInvcapece.Text & "' , Marca  = '" & txtTipo.Text & "' , Modelo  = '" & txtModelo.Text & "' ,  Dimension  = '" & txtDimension.Text & "' , Estado = '" & txtEstado.Text & "'   Where idLugar =" & cboIdRecurso.SelectedIndex.ToString
            ElseIf opcion = 1 Then
                comando.CommandText = "insert into PANTALLAS(IdRecurso,Tipo,INVCAPECE,Marca,Modelo,Dimension,Estado) values('" & cboIdRecurso.SelectedItem.ToString & "','" & txtTipo.Text & "','" & txtInvcapece.Text & "','" & txtMarca.Text & "','" & txtModelo.Text & "','" & txtDimension.Text & "','" & txtEstado.Text & "')"
            End If
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos " & ex.Message)
        End Try
        actualizar()
        txtTipo.Enabled = False
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtDimension.Enabled = False
        txtEstado.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        opcion = 2

        txtTipo.Enabled = True
        txtInvcapece.Enabled = True
        txtMarca.Enabled = True
        txtModelo.Enabled = True
        txtDimension.Enabled = True
        txtEstado.Enabled = True
        btnModificar.Enabled = False
        btnRegistrar.Enabled = True
        btnNuevo.Enabled = False
        gb1.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
    Private Sub actualizar()
        dgwPantalla.Rows.Clear()
        comando.CommandText = "Select * from PANTALLAS"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwPantalla.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
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
        cboIdRecurso.Text = dgwPantalla.Item(0, fila).Value
        txtTipo.Text = dgwPantalla.Item(1, fila).Value
        txtInvcapece.Text = dgwPantalla.Item(2, fila).Value
        txtMarca.Text = dgwPantalla.Item(3, fila).Value
        txtModelo.Text = dgwPantalla.Item(4, fila).Value
        txtDimension.Text = dgwPantalla.Item(5, fila).Value
        txtEstado.Text = dgwPantalla.Item(6, fila).Value

    End Sub


End Class