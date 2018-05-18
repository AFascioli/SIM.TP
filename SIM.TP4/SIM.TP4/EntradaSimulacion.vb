Public Class EntradaSimulacion
    Public nro As Integer
    Public stockInicial As Integer
    Public rndClima As Double
    Public soleado As Boolean
    Public rndDemanda As Double
    Public demanda As Integer
    Public cantVendida As Integer
    Public reembolso As Integer
    Public stockout As Integer
    Public faltantesComprados As Integer


    Public ingresoReembolso As Double
    Public ingresoVenta As Integer
    Public ingresoTotal As Double
    Public acumIngreso As Double

    Public costoCompra As Integer
    Public costoCompraFaltantes As Integer
    Public costoStockOut As Double
    Public costoTotal As Double
    Public acumCosto As Double

    Public beneficio As Double
    Public acumBeneficio As Double

    Public Sub New(nro As Integer, stockInicial As Integer, rndClima As Double, rndDemanda As Double, reintegroXUnidad As Double, costoStockOut As Double, puedenComprarFaltantes As Boolean, costoCompraFaltantes As Double)
        Me.nro = nro
        Me.stockInicial = stockInicial
        Me.rndClima = rndClima
        Me.soleado = esSoleado()
        Me.rndDemanda = rndDemanda
        Me.demanda = calcDemanda()

        Me.stockout = 0
        Me.reembolso = 0
        Me.faltantesComprados = 0
        If Me.demanda < Me.stockInicial Then
            Me.cantVendida = Me.demanda
            Me.reembolso = Me.stockInicial - Me.demanda
        ElseIf Me.demanda > Me.stockInicial Then
            If puedenComprarFaltantes Then
                Me.cantVendida = Me.demanda
                Me.faltantesComprados = Me.demanda - Me.stockInicial
            ElseIf costoStockOut > 0 Then
                Me.cantVendida = Me.stockInicial
                Me.stockout = Me.demanda - Me.stockInicial
            Else
                Me.cantVendida = Me.stockInicial
            End If
        Else
            Me.cantVendida = Me.stockInicial
        End If

        Me.ingresoReembolso = reintegroXUnidad * Me.reembolso
        Me.ingresoVenta = 12 * Me.cantVendida
        Me.ingresoTotal = Me.ingresoReembolso + Me.ingresoVenta

        Me.costoCompra = 8 * Me.stockInicial
        Me.costoCompraFaltantes = Me.faltantesComprados * costoCompraFaltantes
        Me.costoStockOut = costoStockOut * Me.stockout
        Me.costoTotal = Me.costoCompra + Me.costoStockOut

        Me.beneficio = Me.ingresoTotal - Me.costoTotal

    End Sub

    Public Sub calcAcumulados(ingresoAcumulado As Double, costoAcumulado As Double)
        Me.acumIngreso = ingresoAcumulado + Me.ingresoTotal
        Me.acumCosto = costoAcumulado + Me.costoTotal
        Me.acumBeneficio = Me.acumIngreso - Me.acumCosto
    End Sub

    Private Function esSoleado() As Boolean
        Return rndClima < 0.75
    End Function

    Private Function calcDemanda() As Integer
        If soleado Then
            If rndDemanda < 0.1 Then
                Return 6
            ElseIf rndDemanda < 0.3 Then
                Return 7
            ElseIf rndDemanda < 0.75 Then
                Return 8
            Else
                Return 9
            End If

        Else
            If rndDemanda < 0.05 Then
                Return 3
            ElseIf rndDemanda < 0.2 Then
                Return 4
            ElseIf rndDemanda < 0.6 Then
                Return 5
            ElseIf rndDemanda < 0.85 Then
                Return 6
            Else
                Return 7
            End If
        End If
    End Function

End Class
