Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class Bajas
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader

    Private Sub Bajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection("datasource=mysql-sistemamediosav.alwaysdata.net;port=3306;username=230400_db;password=W*eH0EBY%7oH;database=sistemamediosav_db;")
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


    End Sub

    Private Sub FillData()
        conexion = New MySqlConnection("datasource=mysql-sistemamediosav.alwaysdata.net;port=3306;username=230400_db;password=W*eH0EBY%7oH;database=sistemamediosav_db;")
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
        conexion = New MySqlConnection("datasource=mysql-sistemamediosav.alwaysdata.net;port=3306;username=230400_db;password=W*eH0EBY%7oH;database=sistemamediosav_db;")
        conexion.Open()
        comando = conexion.CreateCommand

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

            R = "SELECT * FROM CATEGORIA WHERE idCategoria = " & CboFiltroCategoria.SelectedItem.ToString

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                TxtFiltroCategoria.Text = lector(1)
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

            R = "SELECT * FROM CATEGORIA WHERE idCategoria = " & CboFiltroCategoria.SelectedItem.ToString

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                TxtFiltroCategoria.Text = lector(1)
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

            R = "SELECT * FROM CATEGORIA WHERE idCategoria = " & CboFiltroCategoria.SelectedItem.ToString

            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read()
                TxtFiltroCategoria.Text = lector(1)
            End While
            lector.Close()

        End If


    End Sub

    Private Sub UpdateData()
        TxtIdRecurso.Text = DGVRecursos.SelectedRows(0).Cells(0).Value.ToString
        TxtDescripcion.Text = DGVRecursos.SelectedRows(0).Cells(1).Value.ToString
        TxtIdCategoria.Text = DGVRecursos.SelectedRows(0).Cells(2).Value.ToString
        txtConcepto.Text = DGVRecursos.SelectedRows(0).Cells(3).Value.ToString

        conexion = New MySqlConnection("datasource=mysql-sistemamediosav.alwaysdata.net;port=3306;username=230400_db;password=W*eH0EBY%7oH;database=sistemamediosav_db;")
        conexion.Open()
        comando = conexion.CreateCommand

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
        BtnSeleccionar.Enabled = True
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim id As String = DGVRecursos.SelectedRows(0).Cells(0).Value.ToString
        Dim des As String = DGVRecursos.SelectedRows(0).Cells(1).Value.ToString
        Dim idCat As String = DGVRecursos.SelectedRows(0).Cells(2).Value.ToString
        Dim cat As String = DGVRecursos.SelectedRows(0).Cells(3).Value.ToString

        DGVSeleccion.Rows.Add(id, des, idCat, cat)

        BtnDeshacer.Enabled = True
        BtnSeleccionar.Enabled = False
        BtnLimpiarSeleccion.Enabled = True
        BtnGuardar.Enabled = True
    End Sub

    Private Sub BtnDeshacer_Click(sender As Object, e As EventArgs) Handles BtnDeshacer.Click
        DGVSeleccion.Rows.Remove(DGVSeleccion.SelectedRows(0))
        BtnSeleccionar.Enabled = True
    End Sub

    Private Sub BtnLimpiarSeleccion_Click(sender As Object, e As EventArgs) Handles BtnLimpiarSeleccion.Click
        BtnLimpiarSeleccion.Enabled = False
        BtnGuardar.Enabled = False
        DGVSeleccion.Rows.Clear()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        conexion = New MySqlConnection("datasource=mysql-sistemamediosav.alwaysdata.net;port=3306;username=230400_db;password=W*eH0EBY%7oH;database=sistemamediosav_db;")
        conexion.Open()
        comando = conexion.CreateCommand

        Dim R As String

        For i As Integer = 0 To DGVSeleccion.Rows.Count - 1
            If DGVSeleccion.Rows.Item(i).Cells(2).Value.ToString = "1" Then
                R = "UPDATE CAÑON SET Estado = 'Baja' WHERE IdRecurso = " & DGVSeleccion.Rows.Item(i).Cells(0).Value
            ElseIf DGVSeleccion.Rows.Item(i).Cells(2).Value.ToString = "2" Then
                R = "UPDATE COMPUTADORAS SET Estado = 'Baja' WHERE IdRecurso = " & DGVSeleccion.Rows.Item(i).Cells(0).Value
            ElseIf DGVSeleccion.Rows.Item(i).Cells(2).Value.ToString = "3" Then
                R = "UPDATE PANTALLAS SET Estado = 'Baja' WHERE IdRecurso = " & DGVSeleccion.Rows.Item(i).Cells(0).Value
            End If
            comando.CommandText = R
            comando.ExecuteNonQuery()
        Next

        lector.Close()
        DGVSeleccion.Rows.Clear()
        DGVRecursos.Rows.Clear()
        BtnGuardar.Enabled = False
        BtnLimpiarSeleccion.Enabled = False
        BtnDeshacer.Enabled = False
    End Sub

    Private Sub Bajas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conexion.Close()
    End Sub
End Class