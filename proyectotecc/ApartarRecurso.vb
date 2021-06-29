Imports MySql.Data.MySqlClient
Public Class ApartarRecurso
    Public conexion As MySqlConnection
    Public comando As MySqlCommand
    Public lector As MySqlDataReader

    Private Sub ApartarRecurso_Load(sender As Object, e As EventArgs) Handles Me.Load
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

        comando.CommandText = "SELECT count(IdApartadoRec) FROM APARTADORECURSO"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdApartado.Text = CInt(lector(0)) + 1

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

        R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto FROM RECURSOS AS R 
                INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria
                WHERE NOT R.idCategoria = 1 AND R.idCategoria = 2 AND R.idCategoria = 3"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DGVRecursos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
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
        Else
            Dim R As String

            R = "SELECT R.idRecursos,R.descripcion,R.idCategoria, C.Concepto, P.Estado FROM RECURSOS AS R 
                            INNER Join CATEGORIA AS C On R.idCategoria = C.idCategoria  
                            WHERE R.idCategoria = " & CboFiltroCategoria.Text

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
        txtCantidad.Text = 1
        If TxtIdCategoria.Text = "1" Then
            Dim R As String

            R = "SELECT CA.INVCAPECE FROM CAÑONES AS CA 
                WHERE CA.IdRecurso = " & TxtIdRecurso.Text

            comando.CommandText = R
            txtINVCA.Text = comando.ExecuteScalar
            lector.Close()
            txtCantidad.Enabled = False
        ElseIf TxtIdCategoria.Text = "2" Then
            Dim R As String

            R = "SELECT COM.INVCAPECE FROM COMPUTADORAS AS COM 
                WHERE COM.IdRecurso = " & TxtIdRecurso.Text

            comando.CommandText = R
            txtINVCA.Text = comando.ExecuteScalar
            lector.Close()

            txtCantidad.Enabled = False
        ElseIf TxtIdCategoria.Text = "3" Then
            Dim R As String

            R = "SELECT P.INVCAPECE FROM PANTALLAS AS P 
                WHERE P.IdRecurso = " & TxtIdRecurso.Text

            comando.CommandText = R
            txtINVCA.Text = comando.ExecuteScalar
            lector.Close()
            txtCantidad.Enabled = False
        Else
            txtINVCA.Text = "No aplica"
            txtCantidad.Enabled = True
        End If

    End Sub

    Private Sub DGVRecursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRecursos.CellClick
        UpdateData()
        BtnAgregar.Enabled = True

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        DataGridViewDetalle.Rows.Add(TxtIdRecurso.Text, TxtDescripcion.Text, TxtIdCategoria.Text, txtConcepto.Text, txtCantidad.Text)
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try

        Catch ex As Exception

        End Try
        Dim R As String
        Dim cat As String
        Dim id As String

        Dim FechaA As Date = dtpFecha.Value
        R = "INSERT INTO APARTADORECURSO (Fecha,Docente,Alumno,Nc,Edificio,Aula) VALUES ('" &
                                                                            FechaA.Year & "-" & FechaA.Month & "-" & FechaA.Day & "','" &
                                                                            TxtDocente.Text.ToString & "','" &
                                                                            TxtAlumno.Text.ToString & "','" &
                                                                            TxtNC.Text.ToString & "','" &
                                                                            TxtEdificio.Text.ToString & "','" &
                                                                            TxtAula.Text.ToString & "')"
        comando.CommandText = R
        comando.ExecuteNonQuery()


        For Each row As DataGridViewRow In DataGridViewDetalle.Rows
            cat = row.Cells(3).Value.ToString
            id = row.Cells(0).Value.ToString
            R = "INSERT INTO DETALLEAPARTADORECURSO (IdApartadoRec,IdRecurso,CantidadPrest) VALUES (" &
                                                                            TxtIdApartado.Text.ToString & "," &
                                                                            id & "," &
                                                                           row.Cells(4).Value.ToString & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()

            If cat = "CAÑON" Then
                R = "UPDATE CAÑONES SET Estado = 'Prestado' WHERE IdRecurso = " & id
            ElseIf cat = "COMPUTADORAS" Then
                R = "UPDATE COMPUTADORAS SET Estado = 'Prestado' WHERE IdRecurso = " & id
            ElseIf cat = "PANTALLAS" Then
                R = "UPDATE PANTALLAS SET Estado = 'Prestado' WHERE IdRecurso = " & id
            End If
            comando.CommandText = R
            comando.ExecuteNonQuery()
        Next

        DGVRecursos.Rows.Clear()
        BtnGrabar.Enabled = False

        LimpiarDatos()
    End Sub

    Private Sub LimpiarDatos()
        TxtEdificio.Text = "A"
        TxtAula.Text = "01"
        TxtDocente.Clear()
        TxtAlumno.Clear()
        TxtNC.Clear()
        TxtDescripcion.Clear()
        TxtIdCategoria.Clear()
        txtConcepto.Clear()
        TxtIdRecurso.Clear()
        txtINVCA.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Close()
        lector.Close()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ConsultaApartadoRecurso.Show()
    End Sub
End Class