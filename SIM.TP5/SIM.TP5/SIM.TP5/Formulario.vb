Public Class Formulario
    Dim filas As FilaEvento()
    Dim filaAnterior As FilaEvento

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_cantSimulaciones.Text = 10
        Me.txt_cant_filas.Text = 10
        Me.txt_fila_inicial.Text = 1
    End Sub

    Private Sub cargarFila(indice As Integer, filaEvento As FilaEvento)
        Me.grid.Rows.Add()

        If filaEvento.evento >= 0 Then
            Me.grid.Rows(indice).Cells(0).Value = filaEvento.evento
        End If
        If filaEvento.reloj >= 0 Then
            Me.grid.Rows(indice).Cells(1).Value = filaEvento.reloj
        End If
        If filaEvento.rnd1 >= 0 Then
            Me.grid.Rows(indice).Cells(2).Value = filaEvento.rnd1
        End If
        If filaEvento.tProxConsulta >= 0 Then
            Me.grid.Rows(indice).Cells(3).Value = filaEvento.tProxConsulta
        End If
        If filaEvento.tLlegConsulta >= 0 Then
            Me.grid.Rows(indice).Cells(4).Value = filaEvento.tLlegConsulta
        End If
        If filaEvento.rnd2 >= 0 Then
            Me.grid.Rows(indice).Cells(5).Value = filaEvento.rnd2
        End If
        If filaEvento.tProxUrgencia >= 0 Then
            Me.grid.Rows(indice).Cells(6).Value = filaEvento.tProxUrgencia
        End If
        If filaEvento.tLlegUrgencia >= 0 Then
            Me.grid.Rows(indice).Cells(7).Value = filaEvento.tLlegUrgencia
        End If
        Me.grid.Rows(indice).Cells(8).Value = filaEvento.estadoMedico
        Me.grid.Rows(indice).Cells(9).Value = filaEvento.colaConsulta.Count
        Me.grid.Rows(indice).Cells(10).Value = filaEvento.colaUrgencia.Count
        Me.grid.Rows(indice).Cells(11).Value = filaEvento.consultaEnEspera
        If filaEvento.tFaltanteConsulta >= 0 Then
            Me.grid.Rows(indice).Cells(12).Value = filaEvento.tFaltanteConsulta
        End If
        If filaEvento.rnd3 >= 0 Then
            Me.grid.Rows(indice).Cells(13).Value = filaEvento.rnd3
        End If
        If filaEvento.tAtencionConsulta >= 0 Then
            Me.grid.Rows(indice).Cells(14).Value = filaEvento.tAtencionConsulta
        End If
        If filaEvento.tFinAtencionConsulta >= 0 Then
            Me.grid.Rows(indice).Cells(15).Value = filaEvento.tFinAtencionConsulta
        End If
        If filaEvento.rnd4 >= 0 Then
            Me.grid.Rows(indice).Cells(16).Value = filaEvento.rnd4
        End If
        If filaEvento.tAtencionUrgencia >= 0 Then
            Me.grid.Rows(indice).Cells(17).Value = filaEvento.tAtencionUrgencia
        End If
        If filaEvento.tFinAtencionUrgencia >= 0 Then
            Me.grid.Rows(indice).Cells(18).Value = filaEvento.tFinAtencionUrgencia
        End If
        Me.grid.Rows(indice).Cells(19).Value = filaEvento.sumUrgencias
        Me.grid.Rows(indice).Cells(20).Value = filaEvento.sumPacientes
    End Sub

    Private Sub cargarTabla()
        Dim filaInicial As Integer = Integer.Parse(Me.txt_fila_inicial.Text)
        Dim cantFilas As Integer = Integer.Parse(Me.txt_cant_filas.Text) - 1
        Dim cantTotalFilas As Integer = Integer.Parse(Me.txt_cantSimulaciones.Text)
        Dim j As Integer = 0

        Dim cborrar As Integer = 0

        grid.Rows.Clear()
        filas = New FilaEvento(cantFilas) {}
        filaAnterior = New FilaEvento(800) '#reloj
        If filaInicial = 1 Then
            cborrar += 1
            cargarFila(0, filaAnterior)
            filas(0) = filaAnterior
            j += 1
        End If

        For index = 1 To cantTotalFilas
            Dim filaActual = New FilaEvento(filaAnterior)
            cborrar += 1
            filaAnterior = filaActual
            If filaInicial < index And j <= cantFilas Then

                Console.WriteLine("Filas que mostramos " & cborrar)
                cargarFila(j, filaActual)
                filas(j) = filaAnterior
                j += 1
            End If
        Next

        txt_porcentaje.Text = Math.Round(((filaAnterior.sumUrgencias / filaAnterior.sumPacientes) * 100), 2)

    End Sub

    Private Sub cmd_generar_Click(sender As Object, e As EventArgs) Handles cmd_generar.Click
        Me.cargarTabla()
    End Sub

    Private Sub grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Dim i As Integer = Me.grid.SelectedCells(0).RowIndex
        filas(i).cargarGrids(gridUrgencias, gridConsultas)
    End Sub

End Class
