Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class Cañones
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0
    Dim opcion As Integer = 0

    Private Sub Cañones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        txtIDCanon.Enabled = False
        txtInvcapece.Enabled = False
        txtMarca.Enabled = False
        txtModelo.Enabled = False
        txtEstado.Enabled = False
        txtNoSerie.Enabled = False
        txtHorasLampara.Enabled = True
        txtObservaciones.Enabled = False
        dtpFechaAdqui.Enabled = False
        dtpFechaUltiMan.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        txtHorasLampara.Enabled = False
        gb1.Enabled = False
        dgwCañon.Rows.Clear()

        actualizar()
        colocar(0)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtInvcapece.Enabled = True
        txtMarca.Enabled = True
        txtModelo.Enabled = True
        txtEstado.Enabled = True
        txtNoSerie.Enabled = True
        txtHorasLampara.Enabled = True
        txtObservaciones.Enabled = True
        dtpFechaAdqui.Enabled = True
        dtpFechaUltiMan.Enabled = True
        btnModificar.Enabled = False
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
        txtIDCanon.Text = CInt(lector(0)) + 1
        lector.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            Dim FechaA As Date
            Dim FechaM As Date

            FechaA = dtpFechaAdqui.Value
            FechaM = dtpFechaUltiMan.Value
            If opcion = 2 Then
                comando.CommandText = "UPDATE CAÑONES Set  INVCAPECE  = '" & txtInvcapece.Text & "' , FechaAdq  = '" & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' , FechaUltMantto  = '" & FechaM.Year & "-" & FechaM.Month & "-" & FechaM.Day & "' ,  Modelo  = '" & txtModelo.Text & "' , Marca = '" & txtMarca.Text & "' , NoSerie = '" & txtNoSerie.Text & "' , HorasLampara = '" & txtHorasLampara.Text & "', Observaciones = '" & txtObservaciones.Text & "', Estado = '" & txtEstado.Text & "'   Where IdRecurso =" & txtIDCanon.Text
            ElseIf opcion = 1 Then
                comando.CommandText = "insert into CAÑONES (INVCAPECE,FechaAdq,FechaUltMantto,Modelo,Marca,NoSerie,HorasLampara,Observaciones,Estado) values( '" & txtInvcapece.Text & "' , '" & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' , '" & FechaM.Year & "-" & FechaM.Month & "-" & FechaM.Day & "' ,   '" & txtModelo.Text & "' , '" & txtMarca.Text & "' , '" & txtNoSerie.Text & "' , '" & txtHorasLampara.Text & "', '" & txtObservaciones.Text & "', '" & txtEstado.Text & "')"
            End If
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
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        btnNuevo.Enabled = True
        gb1.Enabled = True
        txtHorasLampara.Enabled = False

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        opcion = 2

        txtInvcapece.Enabled = True
        txtMarca.Enabled = True
        txtModelo.Enabled = True
        txtEstado.Enabled = True
        txtNoSerie.Enabled = True
        txtHorasLampara.Enabled = True
        txtObservaciones.Enabled = True
        dtpFechaAdqui.Enabled = True
        dtpFechaUltiMan.Enabled = True
        btnModificar.Enabled = False
        btnRegistrar.Enabled = True
        btnNuevo.Enabled = False
        gb1.Enabled = False
        txtHorasLampara.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
    Private Sub actualizar()
        dgwCañon.Rows.Clear()
        comando.CommandText = "Select * from CAÑONES"
        lector = comando.ExecuteReader
        While lector.Read()
            dgwCañon.Rows.Add(lector(0), lector(1), String.Format(lector(2)), String.Format(lector(3)), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9))
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
        txtIDCanon.Text = dgwCañon.Item(0, fila).Value
        txtInvcapece.Text = dgwCañon.Item(1, fila).Value
        dtpFechaAdqui.Text = dgwCañon.Item(2, fila).Value
        dtpFechaUltiMan.Text = dgwCañon.Item(3, fila).Value
        txtModelo.Text = dgwCañon.Item(4, fila).Value
        txtMarca.Text = dgwCañon.Item(5, fila).Value
        txtNoSerie.Text = dgwCañon.Item(6, fila).Value
        If IsNothing(dgwCañon.Item(7, fila).Value) Then
            txtHorasLampara.Value = 0
        Else
            txtHorasLampara.Value = Integer.Parse(dgwCañon.Item(7, fila).Value)

        End If


        txtObservaciones.Text = dgwCañon.Item(8, fila).Value
        txtEstado.Text = dgwCañon.Item(9, fila).Value

    End Sub

End Class