Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Bajas
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader
    Dim id, cat, desc, inv As String
    Private Sub Bajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String

        R = "SELECT * FROM CATEGORIA"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            CboFiltroCategoria.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "SELECT count(IdBaja) FROM BAJAS"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdBaja.Text = CInt(lector(0)) + 1

        lector.Close()
    End Sub

    Private Sub FillData()
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String

        R = "SELECT R.idRecursos,C.Concepto,R.descripcion, CA.INVCAPECE, CA.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN CAÑONES AS CA ON R.idRecursos = CA.IdRecurso"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

        R = "SELECT R.idRecursos,C.Concepto,R.descripcion, Com.INVCAPECE, Com.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN COMPUTADORAS AS Com ON R.idRecursos = Com.IdRecurso"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

        R = "SELECT R.idRecursos,C.Concepto,R.descripcion, P.INVCAPECE, P.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN PANTALLAS AS P ON R.idRecursos = P.IdRecurso"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub

    Private Sub CboFiltroCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFiltroCategoria.SelectedIndexChanged
        DGVRecursos.Rows.Clear()

        If CboFiltroCategoria.SelectedItem.ToString = "0" Then
            TxtFiltroCategoria.Text = "TODAS LAS CATEGORÍAS"
            FillData()
        ElseIf CboFiltroCategoria.SelectedItem.ToString = "1" Then
            Dim R As String

            R = "SELECT R.idRecursos,C.Concepto,R.descripcion, CA.INVCAPECE, CA.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN CAÑONES AS CA ON R.idRecursos = CA.IdRecurso"

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        ElseIf CboFiltroCategoria.SelectedItem.ToString = "2" Then
            Dim R As String

            R = "SELECT R.idRecursos,C.Concepto,R.descripcion, COM.INVCAPECE, COM.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN COMPUTADORAS AS COM ON R.idRecursos = COM.IdRecurso"

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        ElseIf CboFiltroCategoria.SelectedItem.ToString = "3" Then
            Dim R As String

            R = "SELECT R.idRecursos,C.Concepto,R.descripcion, P.INVCAPECE, P.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN PANTALLAS AS P ON R.idRecursos = P.IdRecurso"

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        End If

    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        id = DGVRecursos.SelectedRows(0).Cells(0).Value.ToString
        cat = DGVRecursos.SelectedRows(0).Cells(1).Value.ToString
        desc = DGVRecursos.SelectedRows(0).Cells(2).Value.ToString
        inv = DGVRecursos.SelectedRows(0).Cells(3).Value.ToString

        DGVRecursos.Enabled = False
        BtnDeshacer.Enabled = True
        BtnSeleccionar.Enabled = False

        If DataFilled() Then
            BtnGuardar.Enabled = True
        Else
            BtnGuardar.Enabled = False
        End If
    End Sub

    Private Sub txtConcepto_TextChanged(sender As Object, e As EventArgs) Handles txtConcepto.TextChanged
        If DataFilled() Then
            BtnGuardar.Enabled = True
        Else
            BtnGuardar.Enabled = False
        End If
    End Sub

    Private Sub BtnDeshacer_Click(sender As Object, e As EventArgs) Handles BtnDeshacer.Click
        DGVRecursos.Enabled = True
        BtnSeleccionar.Enabled = True
        If DataFilled() Then
            BtnGuardar.Enabled = True
        Else
            BtnGuardar.Enabled = False
        End If

    End Sub

    Private Sub txtAutoriza_TextChanged(sender As Object, e As EventArgs) Handles txtAutoriza.TextChanged
        If DataFilled() Then
            BtnGuardar.Enabled = True
        Else
            BtnGuardar.Enabled = False
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim R As String = ""

        If cat = "CAÑON" Then
            R = "UPDATE CAÑONES SET Estado = 'Baja' WHERE IdRecurso = " & id
        ElseIf cat = "COMPUTADORAS" Then
            R = "UPDATE COMPUTADORAS SET Estado = 'Baja' WHERE IdRecurso = " & id
        ElseIf cat = "PANTALLAS" Then
            R = "UPDATE PANTALLAS SET Estado = 'Baja' WHERE IdRecurso = " & id
        End If
        comando.CommandText = R
        comando.ExecuteNonQuery()
        Dim FechaA As Date = dtpFecha.Value
        R = "INSERT INTO BAJAS (IdRecurso,Fecha,Concepto,Autoriza) VALUES (" & id & ",'" &
                                                                            FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "' , '" &
                                                                            txtConcepto.Text.ToString & "','" &
                                                                            txtAutoriza.Text.ToString & "')"
        comando.CommandText = R
        comando.ExecuteNonQuery()
        lector.Close()
        DGVRecursos.Rows.Clear()
        DGVRecursos.Enabled = True
        BtnGuardar.Enabled = False
        BtnDeshacer.Enabled = False
        txtConcepto.Clear()
        txtAutoriza.Clear()

    End Sub

    Private Sub Bajas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conexion.Close()
    End Sub

    Private Function DataFilled() As Boolean
        If BtnSeleccionar.Enabled = False And txtConcepto.Text.Length > 0 And txtAutoriza.Text.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Bajas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start(rutaAyuda)
        End If
    End Sub


End Class