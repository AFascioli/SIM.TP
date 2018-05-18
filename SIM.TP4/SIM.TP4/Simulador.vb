Public Class Simulador
    Private simulaciones As EntradaSimulacion()()
    Private diasXSim As Integer
    Private docenasReposicion As Integer
    Private reintegroXSobrante As Double
    Private reposicionConstante As Boolean
    Private reposicionEnStockOut As Boolean
    Private parametroStockout As Double

    Private indicePrimeraEntrada As Integer

    Public Sub New(cantSim As Integer, diasXSim As Integer, cantFilas As Integer, reposicionConstante As Boolean,
                   docenasReposicion As Integer, reintegroXSobrante As Double, reposicionEnStockOut As Boolean,
                   parametroStockout As Double)
        Me.simulaciones = New EntradaSimulacion(cantSim - 1)() {}
        For i As Integer = 0 To cantSim - 1
            Me.simulaciones(i) = New EntradaSimulacion(cantFilas - 1) {}
        Next

        Me.diasXSim = diasXSim
        Me.docenasReposicion = docenasReposicion
        Me.reintegroXSobrante = 12 * reintegroXSobrante
        Me.reposicionConstante = reposicionConstante
        Me.reposicionEnStockOut = reposicionEnStockOut
        Me.parametroStockout = parametroStockout
        Me.indicePrimeraEntrada = 0
    End Sub

    Private Function getRnd() As Double
        Return Rnd()
    End Function

    Public Sub simular()
        Dim stockInicial As Integer = docenasReposicion
        Dim costoStockOut As Double
        Dim costoCompraFaltantes As Double
        If reposicionEnStockOut Then
            costoCompraFaltantes = parametroStockout
            costoStockOut = 0
        Else
            costoStockOut = parametroStockout * 12
            costoCompraFaltantes = 0
        End If


        For i As Integer = 0 To simulaciones.Length - 1
            Dim entradaPrevia As New EntradaSimulacion(1, stockInicial, getRnd(), getRnd(), reintegroXSobrante, costoStockOut, reposicionEnStockOut, costoCompraFaltantes)
            entradaPrevia.calcAcumulados(0, 0)
            simulaciones(i)(0) = entradaPrevia

            Dim index As Integer = 1
            Dim bandera As Boolean = False
            For j As Integer = 0 To diasXSim - 2
                If Not reposicionConstante Then
                    stockInicial = entradaPrevia.cantVendida
                End If

                Dim entradaActual As New EntradaSimulacion(2 + j, stockInicial, getRnd(), getRnd(), reintegroXSobrante, costoStockOut, reposicionEnStockOut, costoCompraFaltantes)
                entradaActual.calcAcumulados(entradaPrevia.acumIngreso, entradaPrevia.acumCosto)

                If Not reposicionConstante Then
                    stockInicial = docenasReposicion
                End If

                simulaciones(i)(index) = entradaActual

                If index = indicePrimeraEntrada Then
                    bandera = True
                End If
                entradaPrevia = entradaActual
                If index = simulaciones(i).Length - 1 Then
                    index = 0
                Else
                    index += 1
                End If

                If bandera Then
                    indicePrimeraEntrada = index
                    bandera = False
                End If
            Next
        Next
    End Sub


    Public Sub inicializarTabla(tabla As DataGridView)
        tabla.Columns.Clear()
        tabla.ColumnCount = 21
        tabla.Columns(0).Name = "Día"
        tabla.Columns(1).Name = "Stock inicial"
        tabla.Columns(2).Name = "RND clima"
        tabla.Columns(3).Name = "¿Soleado?"
        tabla.Columns(4).Name = "RND demanda"
        tabla.Columns(5).Name = "Demanda"
        tabla.Columns(6).Name = "Venta"
        tabla.Columns(7).Name = "Rembolso"
        tabla.Columns(8).Name = "Stock-out"
        tabla.Columns(9).Name = "Faltantes comprados"
        tabla.Columns(10).Name = "Ingreso ventas"
        tabla.Columns(11).Name = "Ingreso rembolso"
        tabla.Columns(12).Name = "Ingreso total"
        tabla.Columns(13).Name = "Ingreso acum."
        tabla.Columns(14).Name = "Costo compra"
        tabla.Columns(15).Name = "Costo compra faltantes"
        tabla.Columns(16).Name = "Costo stock-out"
        tabla.Columns(17).Name = "Costo total"
        tabla.Columns(18).Name = "Costo acum."
        tabla.Columns(19).Name = "Beneficio"
        tabla.Columns(20).Name = "Beneficio acum."


        If reintegroXSobrante = 0 Then
            tabla.Columns(7).Visible = False
            tabla.Columns(11).Visible = False
        End If


        If reposicionEnStockOut Or parametroStockout = 0 Then
            tabla.Columns(8).Visible = False
            tabla.Columns(16).Visible = False
        End If

        If Not reposicionEnStockOut Or parametroStockout = 0 Then
            tabla.Columns(9).Visible = False
            tabla.Columns(15).Visible = False
        End If



    End Sub

    Public Sub cargarFilasTabla(tabla As DataGridView, numSimulacion As Integer)
        Dim simulacion As EntradaSimulacion() = simulaciones(numSimulacion)

        tabla.Rows.Clear()
        Dim cont As Integer = 0
        Dim i As Integer = indicePrimeraEntrada
        Dim cantFilas As Integer = simulacion.Length
        While cont < cantFilas
            Dim entrada As EntradaSimulacion = simulacion(i)
            Dim row As DataGridViewRow = tabla.Rows(tabla.Rows.Add())
            row.Cells(0).Value = entrada.nro
            row.Cells(1).Value = entrada.stockInicial
            row.Cells(2).Value = entrada.rndClima
            row.Cells(3).Value = entrada.soleado
            row.Cells(4).Value = entrada.rndDemanda
            row.Cells(5).Value = entrada.demanda
            row.Cells(6).Value = entrada.cantVendida
            row.Cells(7).Value = entrada.reembolso
            row.Cells(8).Value = entrada.stockout
            row.Cells(9).Value = entrada.faltantesComprados
            row.Cells(10).Value = entrada.ingresoVenta
            row.Cells(11).Value = entrada.ingresoReembolso
            row.Cells(12).Value = entrada.ingresoTotal
            row.Cells(13).Value = entrada.acumIngreso
            row.Cells(14).Value = entrada.costoCompra
            row.Cells(15).Value = entrada.costoCompraFaltantes
            row.Cells(16).Value = entrada.costoStockOut
            row.Cells(17).Value = entrada.costoTotal
            row.Cells(18).Value = entrada.acumCosto
            row.Cells(19).Value = entrada.beneficio
            row.Cells(20).Value = entrada.acumBeneficio



            If i = (cantFilas - 1) Then
                i = 0
            Else
                i += 1
            End If
            cont += 1
        End While

    End Sub

    Public Function calcGananciaPromedio(index As Integer) As Double
        Dim indiceUltimaEntrada = indicePrimeraEntrada - 1
        Dim entrada As EntradaSimulacion
        If indiceUltimaEntrada < 0 Then
            entrada = simulaciones(index)(simulaciones(index).Length - 1)
        Else
            entrada = simulaciones(index)(indiceUltimaEntrada)
        End If
        Return entrada.acumBeneficio / entrada.nro
    End Function

    Public Function calcGananciaPromedioGeneral() As Double
        Dim acum As Double = 0
        For i As Integer = 0 To simulaciones.Length - 1
            acum += calcGananciaPromedio(i)
        Next
        Return acum / simulaciones.Length
    End Function

End Class
