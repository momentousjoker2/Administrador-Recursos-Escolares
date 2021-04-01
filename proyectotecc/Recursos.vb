Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Recursos
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim filas As Integer = 0
    Dim opcion As Integer = 0
    Private Sub Recursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection("datasource=mysql-sistemamediosav.alwaysdata.net;port=3306;username=230400_db;password=W*eH0EBY%7oH;database=sistemamediosav_db;")
        conexion.Open()
        comando = conexion.CreateCommand

        comando.CommandText = "Select IdRecurso from CAÑONES"
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdRecurso.Items.Add(lector(0) & " CAÑON")

        End While
        lector.Close()

        comando.CommandText = "Select IdRecurso from COMPUTADORAS"
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdRecurso.Items.Add(lector(0) & " COMPUTADORAS")

        End While
        lector.Close()

        comando.CommandText = "Select IdRecurso from PANTALLAS"
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdRecurso.Items.Add(lector(0) & " PANTALLAS")

        End While
        lector.Close()

        comando.CommandText = "Select * from CATEGORIA"
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdCategoria.Items.Add(lector(0))

        End While
        lector.Close()

        cboIdRecurso.Enabled = False
        cboIdCategoria.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        gb1.Enabled = True

        comando.CommandText = "Select * from RECURSOS"
        lector = comando.ExecuteReader
        While lector.Read()
            For i As Integer = 0 To cboIdRecurso.Items.Count - 1
                If (lector(0) + " PANTALLAS").Equals(cboIdRecurso.Items(i)) Or (lector(0) + " CAÑON").Equals(cboIdRecurso.Items(i)) Or (lector(0) + " COMPUTADORAS").Equals(cboIdRecurso.Items(i)) Then
                    cboIdRecurso.Items.Remove(i)
                End If
            Next
        End While
        lector.Close()

        dgwRecurso.Rows.Clear()

        actualizar()
        colocar(0)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        opcion = 2

        txtDescripcion.Enabled = True
        cboIdCategoria.Enabled = True
        cboIdRecurso.Enabled = True
        btnRegistrar.Enabled = True

        gb1.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDescripcion.Enabled = True
        cboIdRecurso.Enabled = True
        cboIdCategoria.Enabled = True
        btnRegistrar.Enabled = True
        cboIdRecurso.Enabled = True
        gb1.Enabled = False
        btnNuevo.Enabled = False
        btnModificar.Enabled = False


        opcion = 1

        filas = dgwRecurso.RowCount
        filas -= 1
        colocar(filas)
        comando.CommandText = "SELECT count(idRecurso) FROM COMPUTADORAS"
        lector = comando.ExecuteReader
        lector.Read()
        txtID.Text = CInt(lector(0)) + 1
        lector.Close()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try

            If opcion = 2 Then
                ''  comando.CommandText = "UPDATE COMPUTADORAS set  INVCAPECE  = '" & txtInvcapece.Text & "' , FechaAdq  = '" & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' , FechaUltMantto  = '" & FechaM.Year & "-" & FechaM.Month & "-" & FechaM.Day & "' ,  Modelo  = '" & txtModelo.Text & "' , Marca = '" & txtMarca.Text & "' , NoSerie = '" & txtNoSerie.Text & "' , Procesador = '" & txtProcesador.Text & "', Memoria = '" & txtMemoria.Text & "',  HDD	 = '" & txtHdd.Text & "', Estado = '" & txtEstado.Text & "'   Where IdRecurso =" & txtidRecursos.Text
            ElseIf opcion = 1 Then
                ''  comando.CommandText = "insert into COMPUTADORAS (INVCAPECE,FechaAdq,FechaUltMantto,Modelo,Marca,NoSerie,Procesador,Memoria,HDD,Estado) values( '" & txtInvcapece.Text & "' , '" & FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' , '" & FechaM.Year & "-" & FechaM.Month & "-" & FechaM.Day & "' ,   '" & txtModelo.Text & "' , '" & txtMarca.Text & "' , '" & txtNoSerie.Text & "' , '" & txtProcesador.Text & "', '" & txtMemoria.Text & "',  '" & txtHdd.Text & "','" & txtEstado.Text & "')"
            End If
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al intentar grabar compruebe los datos " & ex.Message)
        End Try
        actualizar()

        cboIdRecurso.Enabled = False
        cboIdCategoria.Enabled = False
        btnModificar.Enabled = True
        btnRegistrar.Enabled = False
        gb1.Enabled = True
        btnNuevo.Enabled = True

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
        cboIdRecurso.Text = dgwRecurso.Item(0, fila).Value
        txtConcepto.Text = dgwRecurso.Item(1, fila).Value
        txtConcepto.Text = dgwRecurso.Item(2, fila).Value

    End Sub

    Private Sub cboIdCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdCategoria.SelectedIndexChanged
        comando.CommandText = "Select * from CATEGORIA where idCategoria = " & cboIdCategoria.Text
        lector = comando.ExecuteReader

        lector.Read()
        txtConcepto.Text = lector(1)
        lector.Close()
    End Sub

    Private Sub cboIdRecurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdRecurso.SelectedIndexChanged
        Dim id As String
        Dim Tipo As String

        id = cboIdRecurso.Text.Substring(0, cboIdRecurso.Text.IndexOf(" "))
        Tipo = cboIdRecurso.Text.Substring(cboIdRecurso.Text.IndexOf(" "), cboIdRecurso.Text.Length - 1)

        If Tipo = " COMPUTADORAS" Then
            comando.CommandText = "Select * from COMPUTADORAS  where IdRecurso=" & id
        ElseIf Tipo = " PANTALLAS" Then
            comando.CommandText = "Select * from PANTALLAS where IdRecurso=" & id
        Else
            comando.CommandText = "Select * from CAÑONES where IdRecurso=" & id
        End If


        lector = comando.ExecuteReader

        lector.Read()
        txtINVCA.Text = lector(1)
        lector.Close()
    End Sub
End Class
