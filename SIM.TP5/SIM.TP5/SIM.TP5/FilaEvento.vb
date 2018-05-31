Public Class FilaEvento

    Public Enum eventos
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
        libre
        atendiendo
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

    Public Sub New(filaAnterior As FilaEvento)

        Me.evento = filaAnterior.proxEvento 'Determinado por el evento de la fila anterior que tiene el tiempo mas chico
        Me.reloj = filaAnterior.proxReloj 'Determinado por el evento de la fila anterior que tiene el tiempo mas chico 

        Me.rnd1 = Rnd()
        Me.rnd2 = Rnd()
        Me.rnd3 = Rnd()
        Me.rnd4 = Rnd()

        Select Case evento
            Case eventos.LlegadaConsulta
                Me.tProxConsulta = obtenerRNDExponencial(1 / 30, rnd1) 'lambda (1 cada 30 minutos)
                Me.tLlegConsulta = Me.reloj + Me.tProxConsulta

                Me.tProxUrgencia = filaAnterior.tProxUrgencia
                Me.tLlegUrgencia = filaAnterior.tLlegUrgencia

                If (filaAnterior.evento = eventos.FinAtConsulta Or filaAnterior.evento = eventos.FinAtUrgencia) And filaAnterior.colaConsulta = 0 And filaAnterior.colaUrgencia = 0 And Not filaAnterior.consultaEnEspera Then
                    Me.estadoMedico = estadosMedico.libre
                Else
                    Me.estadoMedico = estadosMedico.atendiendo
                End If

                If filaAnterior.estadoMedico = estadosMedico.libre Then
                    Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
                    Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta
                Else
                    Me.colaConsulta = filaAnterior.colaConsulta + 1

                End If
                Me.colaUrgencia = filaAnterior.colaUrgencia

                Me.rnd4 = 0
                Me.tAtencionUrgencia = 0
                Me.tFinAtencionUrgencia = 0

                Me.sumUrgencias = filaAnterior.sumUrgencias

                Me.sumPacientes = filaAnterior.sumPacientes

            Case eventos.LlegadaUrgencia
                Me.tProxConsulta = filaAnterior.tProxConsulta
                Me.tLlegConsulta = filaAnterior.tLlegConsulta
                Me.tProxUrgencia = obtenerRNDExponencial(1 / 90, rnd2) 'lambda (2 cada 3 horas = 180 minutos)
                Me.tLlegUrgencia = Me.reloj + Me.tProxUrgencia

                If (filaAnterior.evento = eventos.FinAtConsulta Or filaAnterior.evento = eventos.FinAtUrgencia) And filaAnterior.colaConsulta = 0 And filaAnterior.colaUrgencia = 0 And Not filaAnterior.consultaEnEspera Then
                    Me.estadoMedico = estadosMedico.libre
                Else
                    Me.estadoMedico = estadosMedico.atendiendo
                End If

                Me.colaConsulta = filaAnterior.colaConsulta

                If filaAnterior.tFinAtencionConsulta <> 0 Then
                    Me.consultaEnEspera = True
                    Me.tFaltanteConsulta = filaAnterior.tFinAtencionConsulta - Me.reloj

                ElseIf filaAnterior.tFinAtencionUrgencia <> 0 Then
                    Me.colaUrgencia = Me.colaUrgencia + 1
                    Me.tAtencionUrgencia = filaAnterior.tAtencionUrgencia
                    Me.tFinAtencionUrgencia = filaAnterior.tFinAtencionUrgencia
                End If

                Me.rnd3 = 0
                Me.tAtencionConsulta = 0
                Me.tFinAtencionConsulta = 0

                If filaAnterior.tFinAtencionConsulta <> 0 Or filaAnterior.estadoMedico = estadosMedico.libre Then

                    Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, Me.rnd4)
                    Me.tFinAtencionUrgencia = Me.reloj + Me.tAtencionUrgencia
                End If

                Me.sumUrgencias = filaAnterior.sumUrgencias

                Me.sumPacientes = filaAnterior.sumPacientes

            Case eventos.FinAtConsulta
                Me.tProxConsulta = filaAnterior.tProxConsulta
                Me.tLlegConsulta = filaAnterior.tLlegConsulta

                Me.tProxUrgencia = filaAnterior.tProxUrgencia
                Me.tLlegUrgencia = filaAnterior.tLlegUrgencia

                If filaAnterior.consultaEnEspera Then
                    estadoMedico = estadosMedico.atendiendo
                    Me.colaConsulta = filaAnterior.colaConsulta
                    Me.colaUrgencia = filaAnterior.colaUrgencia

                    Me.consultaEnEspera = False
                    Me.tFaltanteConsulta = 0

                    Me.rnd3 = 0
                    Me.tAtencionConsulta = 0
                    Me.tFinAtencionConsulta = Me.reloj + filaAnterior.tFaltanteConsulta

                    Me.tAtencionUrgencia = 0
                    Me.tFinAtencionUrgencia = 0

                ElseIf colaConsulta <> 0 Then
                    estadoMedico = estadosMedico.atendiendo
                    Me.colaConsulta = filaAnterior.colaConsulta - 1
                    Me.colaUrgencia = filaAnterior.colaUrgencia

                    Me.consultaEnEspera = filaAnterior.consultaEnEspera
                    Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta

                    Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
                    Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta

                    Me.rnd4 = 0
                    Me.tAtencionUrgencia = 0
                    Me.tFinAtencionUrgencia = 0
                Else
                    estadoMedico = estadosMedico.libre
                    Me.colaConsulta = filaAnterior.colaConsulta
                    Me.colaUrgencia = filaAnterior.colaUrgencia

                    Me.consultaEnEspera = filaAnterior.consultaEnEspera
                    Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta

                    Me.rnd3 = 0
                    Me.tAtencionConsulta = 0
                    Me.tFinAtencionConsulta = 0

                    Me.rnd4 = 0
                    Me.tAtencionUrgencia = 0
                    Me.tFinAtencionUrgencia = 0
                End If


                Me.sumUrgencias = filaAnterior.sumUrgencias

                Me.sumPacientes = filaAnterior.sumPacientes + 1

            Case eventos.FinAtUrgencia
                Me.tProxConsulta = filaAnterior.tProxConsulta
                Me.tLlegConsulta = filaAnterior.tLlegConsulta

                Me.tProxUrgencia = filaAnterior.tProxUrgencia
                Me.tLlegUrgencia = filaAnterior.tLlegUrgencia

                If filaAnterior.colaUrgencia <> 0 Then
                    estadoMedico = estadosMedico.atendiendo
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

                    estadoMedico = estadosMedico.atendiendo
                    Me.colaConsulta = filaAnterior.colaConsulta
                    Me.colaUrgencia = filaAnterior.colaUrgencia

                    Me.consultaEnEspera = False
                    Me.tFaltanteConsulta = 0

                    Me.rnd3 = 0
                    Me.tAtencionConsulta = 0
                    Me.tFinAtencionConsulta = Me.reloj + filaAnterior.tFaltanteConsulta

                    Me.tAtencionUrgencia = 0
                    Me.tFinAtencionUrgencia = 0
                ElseIf filaAnterior.colaConsulta <> 0 Then
                    estadoMedico = estadosMedico.atendiendo
                    Me.colaConsulta = filaAnterior.colaConsulta - 1
                    Me.colaUrgencia = filaAnterior.colaUrgencia

                    Me.consultaEnEspera = filaAnterior.consultaEnEspera
                    Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta

                    Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
                    Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta

                    Me.rnd4 = 0
                    Me.tAtencionUrgencia = 0
                    Me.tFinAtencionUrgencia = 0
                Else
                    estadoMedico = estadosMedico.libre
                    Me.colaConsulta = filaAnterior.colaConsulta
                    Me.colaUrgencia = filaAnterior.colaUrgencia

                    Me.consultaEnEspera = filaAnterior.consultaEnEspera
                    Me.tFaltanteConsulta = filaAnterior.tFaltanteConsulta

                    Me.rnd3 = 0
                    Me.tAtencionConsulta = 0
                    Me.tFinAtencionConsulta = 0

                    Me.rnd4 = 0
                    Me.tAtencionUrgencia = 0
                    Me.tFinAtencionUrgencia = 0
                End If
                Me.sumUrgencias = filaAnterior.sumUrgencias + 1

                Me.sumPacientes = filaAnterior.sumPacientes + 1
            Case Else

        End Select


        If Not Me.consultaEnEspera And Me.colaConsulta = 0 And Me.colaUrgencia = 0 And Me.tLlegConsulta > Me.reloj And Me.tLlegUrgencia > Me.reloj Then
            'Si no hay nadie en las colas, no hay consulta en suspendida y todavia no llego nadie, entonces el medico esta libre
            Me.estadoMedico = estadosMedico.libre
        Else
            Me.estadoMedico = estadosMedico.atendiendo
        End If

        If Me.estadoMedico = estadosMedico.atendiendo Then

            If Me.evento = eventos.LlegadaUrgencia Then
                Me.colaUrgencia = colaUrgencia
            ElseIf Me.evento = eventos.LlegadaConsulta Then
                Me.colaConsulta = colaConsulta
            End If
        End If



        If Me.tFinAtencionConsulta > Me.tLlegUrgencia Then  'Para saber si hay que suspender la consulta
        Else
            Me.consultaEnEspera = False
            Me.tFaltanteConsulta = 0
        End If


        Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)
        Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta

        Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, rnd4)

        Me.tFinAtencionUrgencia = Me.reloj + Me.tAtencionUrgencia

        Me.sumUrgencias = sumUrgencias

        Me.sumPacientes = sumPacientes


    End Sub

    Public Sub New(reloj As Integer, colaConsulta As Integer, colaUrgencia As Integer, sumUrgencias As Integer, sumPacientes As Integer)

        Me.reloj = reloj
        Me.rnd1 = Rnd()
        Me.rnd2 = Rnd()
        Me.rnd3 = 0
        Me.rnd4 = 0

        Me.tProxConsulta = obtenerRNDExponencial(1 / 30, rnd1) 'lambda (1 cada 30 minutos)
        Me.tLlegConsulta = Me.reloj + Me.tProxConsulta

        Me.tProxUrgencia = obtenerRNDExponencial(1 / 90, rnd2) 'lambda (2 cada 3 horas = 180 minutos)
        Me.tLlegUrgencia = Me.reloj + Me.tProxUrgencia


        Me.estadoMedico = estadosMedico.libre

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
        Dim array(3) As Integer
        array(0) = Me.tLlegConsulta
        array(1) = Me.tLlegUrgencia
        array(2) = Me.tFinAtencionConsulta
        array(3) = Me.tFinAtencionUrgencia

        Dim menor = array.Min()
        Dim index = array.IndexOf(array, menor)

        Select Case index
            Case 0
                Return Me.eventos.LlegadaConsulta
            Case 1
                Return Me.eventos.LlegadaUrgencia
            Case 2
                Return Me.eventos.FinAtConsulta
            Case 3
                Return Me.eventos.FinAtUrgencia
            Case Else
                Return -1
        End Select

    End Function

    Private Function proxReloj()
        Dim array(3) As Integer
        array(0) = Me.tLlegConsulta
        array(1) = Me.tLlegUrgencia
        array(2) = Me.tFinAtencionConsulta
        array(3) = Me.tFinAtencionUrgencia

        Dim menor = array.Min()
        Return menor

    End Function


End Class
