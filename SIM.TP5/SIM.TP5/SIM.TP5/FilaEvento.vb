Public Class FilaEvento

    Public evento As String
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

    Public Sub New(evento As String, reloj As Integer, tProxConsulta As Integer, tLlegConsulta As Integer, tProxUrgencia As Integer, tLlegUrgencia As Integer, colaConsulta As Integer, colaUrgencia As Integer, consultaEnEspera As Boolean, tFaltanteConsulta As Integer, tAtencionConsulta As Integer, tFinAtencionConsulta As Integer, tAtencionUrgencia As Integer, tFinAtencionUrgencia As Integer, sumUrgencias As Integer, sumPacientes As Integer)
        Me.evento = evento
        Me.reloj = reloj
        Me.rnd1 = Rnd()
        Me.rnd2 = Rnd()
        Me.rnd3 = Rnd()
        Me.rnd4 = Rnd()

        Me.tProxConsulta = obtenerRNDExponencial(30, rnd1) 'lambda (1 cada 30 minutos)
        Me.tLlegConsulta = Me.reloj + Me.tProxConsulta

        Me.tProxUrgencia = obtenerRNDExponencial(90, rnd2) 'lambda (2 cada 3 horas = 180 minutos)
        Me.tLlegUrgencia = Me.reloj + Me.tProxUrgencia

        If Me.consultaEnEspera And Me.colaConsulta = 0 And Me.colaUrgencia = 0 And Me.tLlegConsulta > Me.reloj And Me.tLlegUrgencia > Me.reloj Then
            'Si no hay nadie en las colas, no hay consulta en suspendida y todavia no llego nadie, entonces el medico esta libre
            Me.estadoMedico = estadosMedico.libre
        Else
            Me.estadoMedico = estadosMedico.atendiendo
        End If

        Me.colaConsulta = colaConsulta
        Me.colaUrgencia = colaUrgencia
        Me.consultaEnEspera = consultaEnEspera
        Me.tFaltanteConsulta = tFaltanteConsulta

        Me.tAtencionConsulta = obtenerRNDUniforme(10, 20, rnd3)

        Me.tFinAtencionConsulta = Me.reloj + Me.tAtencionConsulta

        Me.tAtencionUrgencia = obtenerRNDUniforme(15, 30, rnd4)

        Me.tFinAtencionUrgencia = Me.reloj + Me.tAtencionUrgencia

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
End Class
