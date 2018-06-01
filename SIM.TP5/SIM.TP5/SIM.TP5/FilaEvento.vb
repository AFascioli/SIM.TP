Public Class FilaEvento

    Public Enum eventos
        Inicio
        LlegadaConsulta
        LlegadaUrgencia
        FinAtConsulta
        FinAtUrgencia
        EstoNoTendriaQuePasar
    End Enum
    Public evento As eventos
    Public reloj As Date '#reloj
    Public rnd1 As Double
    Public tProxConsulta As Integer
    Public tLlegConsulta As Date '#reloj
    Public rnd2 As Double
    Public tProxUrgencia As Integer
    Public tLlegUrgencia As Date '#reloj
    Public Enum estadosMedico
        Libre
        Atendiendo
    End Enum
    Public estadoMedico As estadosMedico
    Public colaConsulta As List(Of ConsultaEnCola)
    Public colaUrgencia As List(Of UrgenciaEnCola)
    Public consultaEnEspera As Boolean
    Public tFaltanteConsulta As Integer
    Public rnd3 As Double
    Public tAtencionConsulta As Integer
    Public tFinAtencionConsulta As Date '#reloj
    Public rnd4 As Double
    Public tAtencionUrgencia As Integer
    Public tFinAtencionUrgencia As Date '#reloj
    Public sumUrgencias As Integer
    Public sumPacientes As Integer

    Private atendiendoUrgencia As Boolean

    Public Sub New()
        'Constructor para la primera fila de la simulación
        Me.reloj = DateAndTime.TimeOfDay
        Me.rnd1 = Rnd()
        Me.rnd2 = Rnd()
        Me.rnd3 = -1
        Me.rnd4 = -1

        Me.tProxConsulta = obtenerRNDExponencial(1 / 30, rnd1) 'lambda (1 cada 30 minutos)
        Me.tLlegConsulta = Me.reloj.AddMinutes(Me.tProxConsulta)
        Me.tProxUrgencia = obtenerRNDExponencial(1 / 90, rnd2) 'lambda (2 cada 3 horas = 180 minutos)
        Me.tLlegUrgencia = Me.reloj.AddMinutes(Me.tProxUrgencia)

        Me.estadoMedico = estadosMedico.Libre

        Me.colaConsulta = New List(Of ConsultaEnCola)
        Me.colaUrgencia = New List(Of UrgenciaEnCola)
        Me.consultaEnEspera = False
        Me.tFaltanteConsulta = -1
        Me.tAtencionConsulta = -1
        Me.tFinAtencionConsulta = Nothing
        Me.tAtencionUrgencia = -1
        Me.tFinAtencionUrgencia = Nothing
        Me.sumUrgencias = 0
        Me.sumPacientes = 0
        Me.atendiendoUrgencia = False
    End Sub

    Public Sub New(filaAnterior As FilaEvento)

        Me.evento = filaAnterior.proxEvento() 'Determinado por el evento de la fila anterior que tiene el tiempo mas chico
        Me.reloj = filaAnterior.proxReloj() 'Determinado por el evento de la fila anterior que tiene el tiempo mas chico 

        copiarDeFilaAnterior(filaAnterior)

        Select Case evento
            Case eventos.LlegadaConsulta
                completarLlegadaConsulta(filaAnterior)

            Case eventos.LlegadaUrgencia
                completarLlegadaUrgencia(filaAnterior)

            Case eventos.FinAtConsulta
                completarFinAtConsulta(filaAnterior)

            Case eventos.FinAtUrgencia
                completarFinAtUrgencia(filaAnterior)
            Case Else
        End Select

    End Sub

    Private Sub copiarDeFilaAnterior(filaAnterior As FilaEvento)
        Me.rnd1 = -1
        Me.rnd2 = -1
        Me.rnd3 = -1
        Me.rnd4 = -1
        Me.tProxConsulta = -1
        Me.tLlegConsulta = filaAnterior.tLlegConsulta
        Me.tProxUrgencia = -1
        Me.tLlegUrgencia = filaAnterior.tLlegUrgencia
        Me.estadoMedico = filaAnterior.estadoMedico

        Me.colaConsulta = New List(Of ConsultaEnCola)
        For i = 0 To filaAnterior.colaConsulta.Count - 1
            Me.colaConsulta.Add(filaAnterior.colaConsulta(i))
        Next

        Me.colaUrgencia = New List(Of UrgenciaEnCola)
        For i = 0 To filaAnterior.colaUrgencia.Count - 1
            Me.colaUrgencia.Add(filaAnterior.colaUrgencia(i))
        Next

        Me.consultaEnEspera = filaAnterior.consultaEnEspera
        Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta
        Me.tAtencionConsulta = -1
        Me.tFinAtencionConsulta = filaAnterior.tFinAtencionConsulta
        Me.tAtencionUrgencia = -1
        Me.tFinAtencionUrgencia = filaAnterior.tFinAtencionUrgencia
        Me.sumUrgencias = filaAnterior.sumUrgencias
        Me.sumPacientes = filaAnterior.sumPacientes

        Me.atendiendoUrgencia = filaAnterior.atendiendoUrgencia
    End Sub

    Private Sub completarFinAtUrgencia(filaAnterior As FilaEvento)

        If Me.colaUrgencia.Count > 0 Then
            'Pasar a la proxima urgencia
            Me.rnd4 = Rnd()
            Me.colaUrgencia.RemoveAt(0)
            Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, Me.rnd4)
            Me.tFinAtencionUrgencia = Me.reloj.AddMinutes(Me.tAtencionUrgencia)

        Else
            If filaAnterior.consultaEnEspera Then
                ' Reanudar consulta
                Me.consultaEnEspera = False
                Me.tFaltanteConsulta = -1
                Me.tFinAtencionConsulta = Me.reloj.AddMinutes(filaAnterior.tFaltanteConsulta)
                Me.atendiendoUrgencia = False

            ElseIf Me.colaConsulta.Count > 0 Then
                ' Pasar a la proxima Consulta
                Me.colaConsulta.RemoveAt(0)
                Me.rnd3 = Rnd()
                Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
                Me.tFinAtencionConsulta = Me.reloj.AddMinutes(Me.tAtencionConsulta)
                Me.atendiendoUrgencia = False

            Else
                ' Liberar
                estadoMedico = estadosMedico.Libre
            End If
            Me.tAtencionUrgencia = -1
            Me.tFinAtencionUrgencia = Nothing
            Me.atendiendoUrgencia = False
        End If

        Me.sumUrgencias += 1
        Me.sumPacientes += 1
    End Sub

    Private Sub completarFinAtConsulta(filaAnterior As FilaEvento)

        If filaAnterior.colaConsulta.Count > 0 Then
            Me.colaConsulta.RemoveAt(0)
            Me.rnd3 = Rnd()
            Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
            Me.tFinAtencionConsulta = Me.reloj.AddMinutes(Me.tAtencionConsulta)
        Else
            estadoMedico = estadosMedico.Libre
            Me.tAtencionConsulta = -1
            Me.tFinAtencionConsulta = Nothing
        End If

        Me.sumPacientes += 1
    End Sub

    Private Sub completarLlegadaUrgencia(filaAnterior As FilaEvento)
        Me.rnd2 = Rnd()
        Me.tProxUrgencia = obtenerRNDExponencial(1 / 90, rnd2) 'lambda (2 cada 3 horas = 180 minutos)
        Me.tLlegUrgencia = Me.reloj.AddMinutes(Me.tProxUrgencia)

        If filaAnterior.estadoMedico = estadosMedico.Libre Then
            Me.atendiendoUrgencia = True
            Me.rnd4 = Rnd()
            Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, Me.rnd4)
            Me.tFinAtencionUrgencia = Me.reloj.AddMinutes(Me.tAtencionUrgencia)
            Me.estadoMedico = estadosMedico.Atendiendo
        Else
            If filaAnterior.atendiendoUrgencia Then
                'Agregar a la cola
                Me.colaUrgencia.Add(New UrgenciaEnCola(Me.reloj))
            Else
                ' Suspender consulta
                Me.atendiendoUrgencia = True
                Me.rnd4 = Rnd()
                Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, Me.rnd4)
                Me.tFinAtencionUrgencia = Me.reloj.AddMinutes(Me.tAtencionUrgencia)

                Me.consultaEnEspera = True
                Me.tFaltanteConsulta = filaAnterior.tFinAtencionConsulta.Subtract(Me.reloj).Minutes
                Me.tFinAtencionConsulta = Nothing
            End If
        End If
    End Sub

    Private Sub completarLlegadaConsulta(filaAnterior As FilaEvento)
        Me.rnd1 = Rnd()
        Me.tProxConsulta = obtenerRNDExponencial(1 / 30, rnd1) 'lambda (1 cada 30 minutos)
        Me.tLlegConsulta = Me.reloj.AddMinutes(Me.tProxConsulta)
        Me.tProxUrgencia = filaAnterior.tProxUrgencia
        Me.tLlegUrgencia = filaAnterior.tLlegUrgencia

        If filaAnterior.estadoMedico = estadosMedico.Libre Then
            Me.estadoMedico = estadosMedico.Atendiendo
            Me.rnd3 = Rnd()
            Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
            Me.tFinAtencionConsulta = Me.reloj.AddMinutes(Me.tAtencionConsulta)
        Else
            ' Incrementar Cola
            Me.colaConsulta.Add(New ConsultaEnCola(Me.reloj))
        End If

    End Sub

    Public Sub cargarGrids(gridUrgencia As DataGridView, gridConsultas As DataGridView)
        gridConsultas.Rows.Clear()
        For i As Integer = 0 To colaConsulta.Count - 1
            Dim j As Integer = gridConsultas.Rows.Add()
            gridConsultas.Rows(j).Cells(0).Value = i + 1
            gridConsultas.Rows(j).Cells(1).Value = colaConsulta(i).llegada.TimeOfDay
        Next

        gridUrgencia.Rows.Clear()
        For i As Integer = 0 To colaUrgencia.Count - 1
            Dim j As Integer = gridUrgencia.Rows.Add()
            gridUrgencia.Rows(j).Cells(0).Value = i + 1
            gridUrgencia.Rows(j).Cells(1).Value = colaUrgencia(i).llegada.TimeOfDay
        Next

    End Sub

    Public Function obtenerRNDExponencial(lambda As Double, rnd As Double)
        Dim res As Double

        res = (-1 / lambda) * Math.Log(1 - rnd)
        Return res
    End Function

    Private Function obtenerRNDUniforme(A As Double, B As Double, rnd As Double)
        Dim res As Double

        res = A + rnd * (B - A)
        Return res
    End Function

    Private Function proxEvento()

        Dim lista As New List(Of Date) From {
            Me.tLlegConsulta,
            Me.tLlegUrgencia,
            Me.tFinAtencionConsulta,
            Me.tFinAtencionUrgencia
        }

        Dim listaMin As New List(Of Date)

        For Each elemento As Date In lista
            If Not elemento.Equals(Nothing) Then
                listaMin.Add(elemento)
            End If
        Next

        Dim menor As Date = listaMin.First

        For Each ddate As Date In listaMin
            If DateTime.Compare(ddate, menor) < 0 Then
                menor = ddate
            End If
        Next
        Dim index = lista.IndexOf(menor)

        Select Case index
            Case 0
                Return eventos.LlegadaConsulta
            Case 1
                Return eventos.LlegadaUrgencia
            Case 2
                Return eventos.FinAtConsulta
            Case 3
                Return eventos.FinAtUrgencia
            Case Else
                Return -1
        End Select
    End Function

    Private Function proxReloj()
        Dim lista As New List(Of Date) From {
            Me.tLlegConsulta,
            Me.tLlegUrgencia,
            Me.tFinAtencionConsulta,
            Me.tFinAtencionUrgencia
        }

        Dim listaMin As New List(Of Date)

        For Each elemento As Date In lista
            If Not elemento.Equals(Nothing) Then
                listaMin.Add(elemento)
            End If
        Next

        Dim menor As Date = listaMin.First

        For Each ddate As Date In listaMin
            If DateTime.Compare(ddate, menor) < 0 Then
                menor = ddate
            End If
        Next

        Return menor

    End Function

End Class
