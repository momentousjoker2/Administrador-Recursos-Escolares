Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class Cañones
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0
    Dim opcion As Integer = 0
    Dim y As Integer
    Private Sub Cañones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "SELECT * FROM RECURSOS WHERE RECURSOS.idRecursos NOT IN (SELECT CAÑONES.IdRecurso FROM CAÑONES) AND RECURSOS.idCategoria = 1"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombreRecursos.Items.Add(lector(1))
        End While
        lector.Close()

        cboNombreRecursos.Enabled = False
        txtid.Enabled = False
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtEstado.Enabled = False
        txtNoSerie.Enabled = False
        txtHorasLampara.Enabled = True
        txtObservaciones.Enabled = False
        dtpFechaAdqui.Enabled = False
        dtpFechaUltiMan.Enabled = False
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        txtHorasLampara.Enabled = False
        gb1.Enabled = True
        dgwCañon.Rows.Clear()



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
            txtEstado.Text = "Disponible"
            txtNoSerie.Enabled = True
            txtHorasLampara.Enabled = True
            txtObservaciones.Enabled = True
            dtpFechaAdqui.Enabled = True
            dtpFechaUltiMan.Enabled = True
            btnRegistrar.Enabled = True
            btnNuevo.Enabled = False
            gb1.Enabled = False
            txtHorasLampara.Enabled = True

            opcion = 1

            filas = dgwCañon.RowCount
            filas -= 1
            colocar(filas)
            comando.CommandText = "Select count(IdRecurso) FROM CAÑONES"
            lector = comando.ExecuteReader
            lector.Read()
            lector.Close()
            txtid.Enabled = True
            btnRegistrar.Text = "Guardar"
        End If

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            Dim FechaA As Date
            Dim FechaM As Date

            FechaA = dtpFechaAdqui.Value
            FechaM = dtpFechaUltiMan.Value

            comando.CommandText = "insert into CAÑONES (IdRecurso,INVCAPECE,FechaAdq,FechaUltMantto,Modelo,Marca,NoSerie,HorasLampara,Observaciones,Estado) values( '" & txtid.Text.ToString & "' ,  '" & txtInvcapece.Text & "' , '" & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' , '" & FechaM.Year & "-" & FechaM.Month & "-" & FechaM.Day & "' ,   '" & txtModelo.Text & "' , '" & txtMarca.Text & "' , '" & txtNoSerie.Text & "' , '" & txtHorasLampara.Text & "', '" & txtObservaciones.Text & "', '" & txtEstado.Text & "')"
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos " & ex.Message)
        End Try
        actualizar()
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtEstado.Enabled = False
        txtNoSerie.Enabled = False
        txtHorasLampara.Enabled = False
        txtObservaciones.Enabled = False
        dtpFechaAdqui.Enabled = False
        dtpFechaUltiMan.Enabled = False
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
        txtHorasLampara.Enabled = False

    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
    Private Sub actualizar()
        dgwCañon.Rows.Clear()
        comando.CommandText = "Select r.idRecursos, r.descripcion,c.INVCAPECE,c.FechaAdq,c.FechaUltMantto,c.Modelo,c.Marca,c.NoSerie,c.HorasLampara,c.Observaciones,c.Estado from CAÑONES as c INNER JOIN RECURSOS as r on c.IdRecurso = r.idRecursos"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwCañon.Rows.Add(lector(0), lector(1), lector(2), String.Format(lector(3)), String.Format(lector(4)), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10))
        End While
        lector.Close()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fila As Integer
        fila = dgwCañon.CurrentRow.Index
        fila += 1
        Dim filas As Integer
        filas = dgwCañon.RowCount
        If fila < filas - 1 Then
            colocar(fila)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim fila As Integer
        fila = dgwCañon.CurrentRow.Index
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
        filas = dgwCañon.RowCount
        filas -= 2
        If filas < 1 Then
            filas = 0
        End If
        colocar(filas)
    End Sub

    Private Sub colocar(fila As Integer)
        dgwCañon.CurrentCell = dgwCañon(0, fila)
        If (IsNothing(dgwCañon.Item(1, fila).Value)) Then
            cboNombreRecursos.SelectedIndex = 0
        Else
            cboNombreRecursos.Text = dgwCañon.Item(1, fila).Value
        End If


        comando.CommandText = "Select * from RECURSOS where descripcion =   '" & cboNombreRecursos.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtid.Text = lector(0)
        lector.Close()

        txtInvcapece.Text = dgwCañon.Item(2, fila).Value
        dtpFechaAdqui.Text = dgwCañon.Item(3, fila).Value
        dtpFechaUltiMan.Text = dgwCañon.Item(4, fila).Value
        txtModelo.Text = dgwCañon.Item(5, fila).Value
        txtMarca.Text = dgwCañon.Item(6, fila).Value
        txtNoSerie.Text = dgwCañon.Item(7, fila).Value
        If IsNothing(dgwCañon.Item(8, fila).Value) Then
            txtHorasLampara.Value = 0
        Else
            txtHorasLampara.Value = Integer.Parse(dgwCañon.Item(8, fila).Value)

        End If
        txtObservaciones.Text = dgwCañon.Item(9, fila).Value
        txtEstado.Text = dgwCañon.Item(10, fila).Value
        If txtEstado.Text.Length.Equals(0) Then
            txtEstado.Text = "Disponible"
        End If

    End Sub

    Private Sub cboNombreRecursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombreRecursos.SelectedIndexChanged
        comando.CommandText = "Select * from RECURSOS where descripcion =   '" & cboNombreRecursos.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtid.Text = lector(0)
        lector.Close()
    End Sub
End Class