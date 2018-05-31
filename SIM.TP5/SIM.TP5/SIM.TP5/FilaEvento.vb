Public Class FilaEvento

    Public Enum eventos
        Inicio
        LlegadaConsulta
        LlegadaUrgencia
        FinAtConsulta
        FinAtUrgencia
    End Enum
    Public evento As eventos
    Public reloj As Integer 'FIJARSE BIEN COMO IMPLEMENTAR TIPO DE ATRIBUTO
    Public rnd1 As Double
    Public tProxConsulta As Integer
    Public tLlegConsulta As Integer 'FIJARSE BIEN COMO IMPLEMENTAR TIPO DE ATRIBUTO
    Public rnd2 As Double
    Public tProxUrgencia As Integer
    Public tLlegUrgencia As Integer 'FIJARSE BIEN COMO IMPLEMENTAR TIPO DE ATRIBUTO
    Public Enum estadosMedico
        Libre
        Atendiendo
    End Enum
    Public estadoMedico As estadosMedico
    Public colaConsulta As Integer
    Public colaUrgencia As Integer
    Public consultaEnEspera As Boolean
    Public tFaltanteConsulta As Integer
    Public rnd3 As Double
    Public tAtencionConsulta As Integer
    Public tFinAtencionConsulta As Integer
    Public rnd4 As Double
    Public tAtencionUrgencia As Integer
    Public tFinAtencionUrgencia As Integer
    Public sumUrgencias As Integer
    Public sumPacientes As Integer

    Public Sub New(reloj As Integer, colaConsulta As Integer, colaUrgencia As Integer, sumUrgencias As Integer, sumPacientes As Integer)
        'Constructor para la primera fila de la simulación
        Me.reloj = reloj
        Me.rnd1 = Rnd()
        Me.rnd2 = Rnd()
        Me.rnd3 = 0
        Me.rnd4 = 0

        Me.tProxConsulta = obtenerRNDExponencial(1 / 30, rnd1) 'lambda (1 cada 30 minutos)
        Me.tLlegConsulta = Me.reloj + Me.tProxConsulta

        Me.tProxUrgencia = obtenerRNDExponencial(1 / 90, rnd2) 'lambda (2 cada 3 horas = 180 minutos)
        Me.tLlegUrgencia = Me.reloj + Me.tProxUrgencia


        Me.estadoMedico = estadosMedico.Libre

        Me.colaConsulta = colaConsulta
        Me.colaUrgencia = colaUrgencia
        Me.consultaEnEspera = False
        Me.tFaltanteConsulta = 0

        Me.tAtencionConsulta = 0

        Me.tFinAtencionConsulta = 0

        Me.tAtencionUrgencia = 0

        Me.tFinAtencionUrgencia = 0

        Me.sumUrgencias = sumUrgencias
        Me.sumPacientes = sumPacientes

    End Sub

    Public Sub New(filaAnterior As FilaEvento)

        Me.evento = filaAnterior.proxEvento 'Determinado por el evento de la fila anterior que tiene el tiempo mas chico
        Me.reloj = filaAnterior.proxReloj 'Determinado por el evento de la fila anterior que tiene el tiempo mas chico 

        Me.rnd1 = Rnd()
        Me.rnd2 = Rnd()
        Me.rnd3 = Rnd()
        Me.rnd4 = Rnd()

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

        'Asignacion del estado del médico
        If Not Me.consultaEnEspera And Me.colaConsulta = 0 And Me.colaUrgencia = 0 And Me.tLlegConsulta > Me.reloj And Me.tLlegUrgencia > Me.reloj Then
            'Si no hay nadie en las colas, no hay consulta en suspendida y todavia no llego nadie, entonces el medico esta libre
            Me.estadoMedico = estadosMedico.Libre
        Else
            Me.estadoMedico = estadosMedico.Atendiendo
        End If

    End Sub

    Private Sub completarFinAtUrgencia(filaAnterior As FilaEvento)
        Me.tProxConsulta = filaAnterior.tProxConsulta
        Me.tLlegConsulta = filaAnterior.tLlegConsulta
        Me.tProxUrgencia = filaAnterior.tProxUrgencia
        Me.tLlegUrgencia = filaAnterior.tLlegUrgencia
        Me.rnd1 = 0
        Me.rnd2 = 0

        If filaAnterior.colaUrgencia <> 0 Then
            estadoMedico = estadosMedico.Atendiendo
            Me.colaConsulta = filaAnterior.colaConsulta
            Me.colaUrgencia = filaAnterior.colaUrgencia - 1

            Me.consultaEnEspera = filaAnterior.consultaEnEspera
            Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta

            Me.rnd3 = 0
            Me.tAtencionConsulta = 0
            Me.tFinAtencionConsulta = 0

            Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, Me.rnd4)
            Me.tFinAtencionUrgencia = Me.reloj + Me.tAtencionUrgencia
        ElseIf filaAnterior.consultaEnEspera Then

            estadoMedico = estadosMedico.Atendiendo
            Me.colaConsulta = filaAnterior.colaConsulta
            Me.colaUrgencia = filaAnterior.colaUrgencia

            Me.consultaEnEspera = False
            Me.tFaltanteConsulta = 0

            Me.rnd3 = 0
            Me.tAtencionConsulta = filaAnterior.tFaltanteConsulta
            Me.tFinAtencionConsulta = Me.reloj + filaAnterior.tFaltanteConsulta

            Me.rnd4 = 0
            Me.tAtencionUrgencia = 0
            Me.tFinAtencionUrgencia = 0

        ElseIf filaAnterior.colaConsulta <> 0 Then
            estadoMedico = estadosMedico.Atendiendo
            Me.colaConsulta = filaAnterior.colaConsulta - 1
            Me.colaUrgencia = filaAnterior.colaUrgencia

            Me.consultaEnEspera = filaAnterior.consultaEnEspera 'Es false
            Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta 'Es 0

            Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
            Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta

            Me.rnd4 = 0
            Me.tAtencionUrgencia = 0
            Me.tFinAtencionUrgencia = 0
        Else
            estadoMedico = estadosMedico.Libre
            Me.colaConsulta = filaAnterior.colaConsulta 'Es 0
            Me.colaUrgencia = filaAnterior.colaUrgencia

            Me.consultaEnEspera = filaAnterior.consultaEnEspera 'Es false
            Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta 'Es 0

            Me.rnd3 = 0
            Me.tAtencionConsulta = 0
            Me.tFinAtencionConsulta = 0

            Me.rnd4 = 0
            Me.tAtencionUrgencia = 0
            Me.tFinAtencionUrgencia = 0
        End If
        Me.sumUrgencias = filaAnterior.sumUrgencias + 1
        Me.sumPacientes = filaAnterior.sumPacientes + 1
    End Sub

    Private Sub completarFinAtConsulta(filaAnterior As FilaEvento)
        Me.tProxConsulta = filaAnterior.tProxConsulta
        Me.tLlegConsulta = filaAnterior.tLlegConsulta
        Me.tProxUrgencia = filaAnterior.tProxUrgencia
        Me.tLlegUrgencia = filaAnterior.tLlegUrgencia
        Me.rnd1 = 0
        Me.rnd2 = 0

        If filaAnterior.colaConsulta <> 0 Then
            estadoMedico = estadosMedico.Atendiendo
            Me.colaConsulta = filaAnterior.colaConsulta - 1 'Actualizar la grilla de la cola de consultas

            Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
            Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta
        Else
            estadoMedico = estadosMedico.Libre 'Deberia ser la unica asignacion a estado Libre
            Me.colaConsulta = filaAnterior.colaConsulta 'Es 0

            Me.rnd3 = 0
            Me.tAtencionConsulta = 0
            Me.tFinAtencionConsulta = 0
        End If

        Me.consultaEnEspera = filaAnterior.consultaEnEspera 'Es false
        Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta 'Es 0
        Me.rnd4 = 0
        Me.tAtencionUrgencia = 0
        Me.tFinAtencionUrgencia = 0
        Me.colaUrgencia = filaAnterior.colaUrgencia
        Me.sumUrgencias = filaAnterior.sumUrgencias
        Me.sumPacientes = filaAnterior.sumPacientes + 1
    End Sub

    Private Sub completarLlegadaUrgencia(filaAnterior As FilaEvento)
        Me.tProxConsulta = filaAnterior.tProxConsulta
        Me.tLlegConsulta = filaAnterior.tLlegConsulta
        Me.tProxUrgencia = obtenerRNDExponencial(1 / 90, rnd2) 'lambda (2 cada 3 horas = 180 minutos)
        Me.tLlegUrgencia = Me.reloj + Me.tProxUrgencia
        Me.rnd1 = 0

        If filaAnterior.evento = eventos.LlegadaConsulta Or filaAnterior.evento = eventos.LlegadaUrgencia Or filaAnterior.colaConsulta <> 0 Or filaAnterior.colaUrgencia <> 0 Or filaAnterior.consultaEnEspera Then
            Me.estadoMedico = estadosMedico.Atendiendo
        Else
            Me.estadoMedico = estadosMedico.Libre
        End If

        Me.colaConsulta = filaAnterior.colaConsulta

        If filaAnterior.tFinAtencionConsulta <> 0 Then
            Me.consultaEnEspera = True
            Me.tFaltanteConsulta = filaAnterior.tFinAtencionConsulta - Me.reloj
        End If

        If filaAnterior.tFinAtencionUrgencia <> 0 Then
            Me.colaUrgencia = Me.colaUrgencia + 1
            Me.tAtencionUrgencia = filaAnterior.tAtencionUrgencia
            Me.tFinAtencionUrgencia = filaAnterior.tFinAtencionUrgencia
        Else
            Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, Me.rnd4)
            Me.tFinAtencionUrgencia = Me.reloj + Me.tAtencionUrgencia
        End If

        Me.rnd3 = 0
        Me.tAtencionConsulta = 0
        Me.tFinAtencionConsulta = 0
        Me.sumUrgencias = filaAnterior.sumUrgencias
        Me.sumPacientes = filaAnterior.sumPacientes
    End Sub

    Private Sub completarLlegadaConsulta(filaAnterior As FilaEvento)
        Me.tProxConsulta = obtenerRNDExponencial(1 / 30, rnd1) 'lambda (1 cada 30 minutos)
        Me.tLlegConsulta = Me.reloj + Me.tProxConsulta
        Me.tProxUrgencia = filaAnterior.tProxUrgencia
        Me.tLlegUrgencia = filaAnterior.tLlegUrgencia
        Me.rnd2 = 0

        If filaAnterior.evento = eventos.LlegadaConsulta Or filaAnterior.evento = eventos.LlegadaUrgencia Or filaAnterior.colaConsulta <> 0 Or filaAnterior.colaUrgencia <> 0 Or filaAnterior.consultaEnEspera Then
            Me.estadoMedico = estadosMedico.Atendiendo
        Else
            Me.estadoMedico = estadosMedico.Libre
        End If

        If filaAnterior.evento = eventos.FinAtConsulta Or filaAnterior.evento = eventos.FinAtUrgencia Or filaAnterior.evento = eventos.Inicio Then
            Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
            Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta
            Me.colaConsulta = filaAnterior.colaConsulta
        Else
            Me.colaConsulta = filaAnterior.colaConsulta + 1
            Me.tAtencionConsulta = filaAnterior.tAtencionConsulta
            Me.tFinAtencionConsulta = filaAnterior.tFinAtencionConsulta
            Me.rnd3 = 0 'AGREGAGOOOOOOOOOOOOOOOOOO
        End If

        Me.consultaEnEspera = filaAnterior.consultaEnEspera
        Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta
        Me.colaUrgencia = filaAnterior.colaUrgencia

        Me.rnd4 = 0
        Me.tAtencionUrgencia = filaAnterior.tAtencionUrgencia
        Me.tFinAtencionUrgencia = filaAnterior.tFinAtencionUrgencia

        Me.sumUrgencias = filaAnterior.sumUrgencias
        Me.sumPacientes = filaAnterior.sumPacientes
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

        Dim lista As New List(Of Integer) From {
            Me.tLlegConsulta,
            Me.tLlegUrgencia,
            Me.tFinAtencionConsulta,
            Me.tFinAtencionUrgencia
        }

        Dim listaMin As New List(Of Integer)

        For Each elemento As Integer In lista
            If (elemento <> 0) Then
                listaMin.Add(elemento)
            End If
        Next

        Dim menor = listaMin.Min()
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
        Dim lista As New List(Of Integer) From {
            Me.tLlegConsulta,
            Me.tLlegUrgencia,
            Me.tFinAtencionConsulta,
            Me.tFinAtencionUrgencia
        }

        Dim listaMin As New List(Of Integer)

        For Each elemento As Integer In lista
            If (elemento <> 0) Then
                listaMin.Add(elemento)
            End If
        Next

        Dim menor = listaMin.Min()

        Return menor

    End Function


End Class
