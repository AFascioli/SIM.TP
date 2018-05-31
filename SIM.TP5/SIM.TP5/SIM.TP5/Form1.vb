Public Class Form1

    Dim filaAnterior As FilaEvento

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cargarFila(filaEvento As FilaEvento)
        Dim indice = Me.grid.Rows.Count - 1
        Me.grid.Rows.Add()
        Me.grid.Rows(indice).Cells(0).Value = filaEvento.evento
        Me.grid.Rows(indice).Cells(1).Value = filaEvento.reloj
        Me.grid.Rows(indice).Cells(2).Value = filaEvento.rnd1
        Me.grid.Rows(indice).Cells(3).Value = filaEvento.tProxConsulta
        Me.grid.Rows(indice).Cells(4).Value = filaEvento.tLlegConsulta
        Me.grid.Rows(indice).Cells(5).Value = filaEvento.rnd2
        Me.grid.Rows(indice).Cells(6).Value = filaEvento.tProxUrgencia
        Me.grid.Rows(indice).Cells(7).Value = filaEvento.tLlegUrgencia
        Me.grid.Rows(indice).Cells(8).Value = filaEvento.estadoMedico
        Me.grid.Rows(indice).Cells(9).Value = filaEvento.consultaEnEspera
        Me.grid.Rows(indice).Cells(10).Value = filaEvento.tFaltanteConsulta
        Me.grid.Rows(indice).Cells(11).Value = filaEvento.rnd3
        Me.grid.Rows(indice).Cells(12).Value = filaEvento.tAtencionConsulta
        Me.grid.Rows(indice).Cells(13).Value = filaEvento.tFinAtencionConsulta
        Me.grid.Rows(indice).Cells(14).Value = filaEvento.rnd4
        Me.grid.Rows(indice).Cells(15).Value = filaEvento.tAtencionUrgencia
        Me.grid.Rows(indice).Cells(16).Value = filaEvento.tFinAtencionUrgencia
        Me.grid.Rows(indice).Cells(17).Value = filaEvento.sumUrgencias
        Me.grid.Rows(indice).Cells(18).Value = filaEvento.sumPacientes
    End Sub

    Private Sub cargarTabla()
        filaAnterior = New FilaEvento(800, 0, 0, 0, 0)
        cargarFila(filaAnterior)

        For index = 1 To Integer.Parse(Me.txt_cantSimulaciones.Text)
            Dim filaActual = New FilaEvento(filaAnterior)
            cargarFila(filaActual)
            filaAnterior = filaActual
        Next

    End Sub

    Private Sub cmd_generar_Click(sender As Object, e As EventArgs) Handles cmd_generar.Click
        Me.cargarTabla()
    End Sub
End Class
