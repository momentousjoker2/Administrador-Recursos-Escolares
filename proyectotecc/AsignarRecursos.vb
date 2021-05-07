﻿Imports MySql.Data.MySqlClient

Imports System.ComponentModel
Public Class AsignarRecursos
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Private Sub AsignarRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand
        FillData()
        Dim R As String

        R = "SELECT * FROM CATEGORIA"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            CboFiltroCategoria.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub
    Private Sub FillData()
        conexion = New MySqlConnection(conn)
        conexion.Open()
        comando = conexion.CreateCommand
        Dim R As String

        R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto, CA.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN CAÑONES AS CA ON R.idRecursos = CA.IdRecurso
                            WHERE CA.Estado = 'Disponible'"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

        R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto, Com.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN COMPUTADORAS AS Com ON R.idRecursos = Com.IdRecurso
                            WHERE Com.Estado = 'Disponible'"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()

        R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto, P.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN PANTALLAS AS P ON R.idRecursos = P.IdRecurso
                            WHERE P.Estado = 'Disponible'"

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

            R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto, CA.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN CAÑONES AS CA ON R.idRecursos = CA.IdRecurso
                            WHERE CA.Estado = 'Disponible'"

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        ElseIf CboFiltroCategoria.SelectedItem.ToString = "2" Then
            Dim R As String

            R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto, COM.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN COMPUTADORAS AS COM ON R.idRecursos = COM.IdRecurso
                            WHERE COM.Estado = 'Disponible'"

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        ElseIf CboFiltroCategoria.SelectedItem.ToString = "3" Then
            Dim R As String

            R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto, P.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            INNER JOIN PANTALLAS AS P ON R.idRecursos = P.IdRecurso
                            WHERE P.Estado = 'Disponible'"

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()

        End If
    End Sub
    Private Sub UpdateData()
        TxtIdRecurso.Text = DGVRecursos.SelectedRows(0).Cells(0).Value.ToString
        TxtDescripcion.Text = DGVRecursos.SelectedRows(0).Cells(1).Value.ToString
        TxtIdCategoria.Text = DGVRecursos.SelectedRows(0).Cells(2).Value.ToString
        txtConcepto.Text = DGVRecursos.SelectedRows(0).Cells(3).Value.ToString

        If TxtIdCategoria.Text = "1" Then
            Dim R As String

            R = "SELECT CA.INVCAPECE FROM CAÑONES AS CA 
                WHERE CA.IdRecurso = " & TxtIdRecurso.Text

            comando.CommandText = R
            txtINVCA.Text = comando.ExecuteScalar
            lector.Close()

        ElseIf TxtIdCategoria.Text = "2" Then
            Dim R As String

            R = "SELECT COM.INVCAPECE FROM COMPUTADORAS AS COM 
                WHERE COM.IdRecurso = " & TxtIdRecurso.Text

            comando.CommandText = R
            txtINVCA.Text = comando.ExecuteScalar
            lector.Close()


        ElseIf TxtIdCategoria.Text = "3" Then
            Dim R As String

            R = "SELECT P.INVCAPECE FROM PANTALLAS AS P 
                WHERE P.IdRecurso = " & TxtIdRecurso.Text

            comando.CommandText = R
            txtINVCA.Text = comando.ExecuteScalar
            lector.Close()
        End If

    End Sub

    Private Sub DGVRecursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRecursos.CellClick
        UpdateData()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String

        If TxtIdCategoria.Text = "1" Then
            ''R = "UPDATE CAÑON SET Estado = 'Baja' WHERE IdRecurso = " & DGVSeleccion.Rows.Item(i).Cells(0).Value
        ElseIf TxtIdCategoria.Text = "2" Then
            ''R = "UPDATE COMPUTADORAS SET Estado = 'Baja' WHERE IdRecurso = " & DGVSeleccion.Rows.Item(i).Cells(0).Value
        ElseIf TxtIdCategoria.Text = "3" Then
            'R = "UPDATE PANTALLAS SET Estado = 'Baja' WHERE IdRecurso = " & DGVSeleccion.Rows.Item(i).Cells(0).Value
        End If

        comando.CommandText = R
        comando.ExecuteNonQuery()

        lector.Close()
        DGVRecursos.Rows.Clear()
        BtnGuardar.Enabled = False
        BtnLimpiarSeleccion.Enabled = False
    End Sub

    Private Sub BtnLimpiarSeleccion_Click(sender As Object, e As EventArgs) Handles BtnLimpiarSeleccion.Click
        TxtEdificio.Clear()
        TxtAula.Clear()
        TxtResponsable.Clear()
    End Sub
End Class