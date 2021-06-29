Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Computadoras
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0

    Private Sub Computadoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "SELECT * FROM RECURSOS WHERE RECURSOS.idRecursos NOT IN (SELECT COMPUTADORAS.IdRecurso FROM COMPUTADORAS) AND RECURSOS.idCategoria = 2"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreRecursos.Items.Add(lector(1))
        End While
        lector.Close()


        txtId.Enabled = False
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtEstado.Enabled = False
        txtHdd.Enabled = False
        txtMemoria.Enabled = False
        txtNoSerie.Enabled = False
        txtProcesador.Enabled = False
        dtpFechaAdqui.Enabled = False
        dtpFechaUltMan.Enabled = False
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
        dgwComputadora.Rows.Clear()

        actualizar()
        colocar(0)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If cboNombreRecursos.Items.Count = 0 Then
            MsgBox("Usted no tiene nuevos recusos que registar en esta categoría")
        Else
            cboNombreRecursos.Enabled = True
            txtInvcapece.Enabled = True
            txtMarca.Enabled = True
            txtModelo.Enabled = True
            txtHdd.Enabled = True
            txtMemoria.Enabled = True
            txtNoSerie.Enabled = True
            txtProcesador.Enabled = True
            dtpFechaAdqui.Enabled = True
            dtpFechaUltMan.Enabled = True
            btnRegistrar.Enabled = True
            btnNuevo.Enabled = False
            gb1.Enabled = False
            txtEstado.Text = "Disponible"


            filas = dgwComputadora.RowCount
            filas -= 1
            colocar(filas)
            txtId.Enabled = False
        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            Dim FechaA As Date
            Dim FechaM As Date

            FechaA = dtpFechaAdqui.Value
            FechaM = dtpFechaUltMan.Value

            comando.CommandText = "insert into COMPUTADORAS (IdRecurso,INVCAPECE,FechaAdq,FechaUltMantto,Modelo,Marca,NoSerie,Procesador,Memoria,HDD,Estado) values( '" & txtId.Text & "' ,'" & txtInvcapece.Text & "' , '" & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' , '" & FechaM.Year & "-" & FechaM.Month & "-" & FechaM.Day & "' ,   '" & txtModelo.Text & "' , '" & txtMarca.Text & "' , '" & txtNoSerie.Text & "' , '" & txtProcesador.Text & "', '" & txtMemoria.Text & "',  '" & txtHdd.Text & "','" & txtEstado.Text & "')"

            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos " & ex.Message)
        End Try
        actualizar()
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtHdd.Enabled = False
        txtMemoria.Enabled = False
        txtNoSerie.Enabled = False
        txtProcesador.Enabled = False
        dtpFechaAdqui.Enabled = False
        dtpFechaUltMan.Enabled = False
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
        cboNombreRecursos.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub actualizar()
        dgwComputadora.Rows.Clear()
        comando.CommandText = "Select r.idRecursos, r.descripcion, c.INVCAPECE, c.FechaAdq, c.FechaUltMantto, c.Modelo, c.Marca, c.NoSerie, c.Procesador, c.Memoria, c.HDD, c.Estado from COMPUTADORAS as c INNER JOIN RECURSOS as r on c.IdRecurso = r.idRecursos"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwComputadora.Rows.Add(lector(0), lector(1), lector(2), String.Format(lector(3)), String.Format(lector(4)), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11))
        End While
        lector.Close()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fila As Integer
        fila = dgwComputadora.CurrentRow.Index
        fila += 1
        Dim filas As Integer
        filas = dgwComputadora.RowCount
        If fila < filas - 1 Then
            colocar(fila)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim fila As Integer
        fila = dgwComputadora.CurrentRow.Index
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
        filas = dgwComputadora.RowCount
        filas -= 2
        If filas < 1 Then
            filas = 0
        End If
        colocar(filas)
    End Sub

    Private Sub colocar(fila As Integer)
        dgwComputadora.CurrentCell = dgwComputadora(0, fila)
        If (IsNothing(dgwComputadora.Item(1, fila).Value)) Then
            cboNombreRecursos.SelectedIndex = 0
        Else
            cboNombreRecursos.Text = dgwComputadora.Item(1, fila).Value
        End If

        comando.CommandText = "Select * from RECURSOS where descripcion =   '" & cboNombreRecursos.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtId.Text = lector(0)
        lector.Close()


        txtInvcapece.Text = dgwComputadora.Item(2, fila).Value
        dtpFechaAdqui.Text = dgwComputadora.Item(3, fila).Value
        dtpFechaUltMan.Text = dgwComputadora.Item(4, fila).Value
        txtModelo.Text = dgwComputadora.Item(5, fila).Value
        txtMarca.Text = dgwComputadora.Item(6, fila).Value
        txtNoSerie.Text = dgwComputadora.Item(7, fila).Value
        txtProcesador.Text = dgwComputadora.Item(8, fila).Value
        txtMemoria.Text = dgwComputadora.Item(9, fila).Value
        txtHdd.Text = dgwComputadora.Item(10, fila).Value


        txtEstado.Text = dgwComputadora.Item(11, fila).Value
        If txtEstado.Text.Length.Equals(0) Then
            txtEstado.Text = "Disponible"
        End If

    End Sub

    Private Sub cboNombreRecursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreRecursos.SelectedIndexChanged
        comando.CommandText = "Select * from RECURSOS where descripcion =   '" & cboNombreRecursos.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtId.Text = lector(0)
        lector.Close()
    End Sub
End Class