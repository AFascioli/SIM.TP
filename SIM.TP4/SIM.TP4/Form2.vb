Public Class Form2
    ' Vende a $1 cada rosa
    ' Compra a $8 la docena
    ' Rosas no vendidas, se venden a $0.10 c/u

    'Vectores anterior y actual
    ' experimento(0) |stock inicial(1)|rnd tiempo(2)    |soleado?(3)    |rnd demanda(4) |cant. demanda(5)  |
    ' cuanto vende(6)|reembolso(7)    |costo faltante(8)|sum ingreso(9)|sum costo(10)  | sum beneficio(11)|
    Dim anterior(12) As Double
    Dim actual(12) As Double

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_cantidadDocenas.Items.Add("7")
        cmb_cantidadDocenas.Items.Add("8")
        cmb_cantidadDocenas.Items.Add("9")
        cmb_cantidadDocenas.SelectedIndex = 0
    End Sub


    Public Function diaSoleado(rnd As Double) 'Toma un random y devuelte la demanda para un dia soleado
        Dim demanda As Integer
        Select Case rnd
            Case 0 To 0.1
                demanda = 6
            Case 0.1 To 0.3
                demanda = 7
            Case 0.3 To 0.75
                demanda = 8
            Case 0.75 To 1
                demanda = 9
            Case Else
                demanda = 0
        End Select
        Return demanda
    End Function

    Public Function diaNublado(rnd As Double) 'Toma un random y devuelve la demanda para un dia nublado
        Dim demanda As Integer
        Select Case rnd
            Case 0 To 0.05
                demanda = 3
            Case 0.05 To 0.2
                demanda = 4
            Case 0.2 To 0.6
                demanda = 5
            Case 0.6 To 0.85
                demanda = 6
            Case 0.85 To 0.99
                demanda = 7
            Case Else
                demanda = 0
        End Select
        Return demanda
    End Function

    Public Function climaDia(rnd As Double)
        '1 es soleado, 0 es nublado
        Dim clima As Integer = 1
        If rnd > 0.75 And rnd < 1 Then
            clima = 0
        End If
        Return clima
    End Function

    Public Sub cargarPrimeraFila()

        Dim rnd1 As Double = VBMath.Rnd()
        Dim rnd2 As Double = VBMath.Rnd()

        Dim clima = climaDia(rnd1)
        Dim demanda As Integer
        Dim stockInicial As Integer
        Dim venta As Integer

        If clima = 1 Then
            demanda = diaSoleado(rnd2)
        Else
            demanda = diaNublado(rnd2)
        End If

        If cbx_demandaAnterior.Checked() Then
            stockInicial = 8
        Else
            stockInicial = cmb_cantidadDocenas.SelectedItem()
        End If

        If demanda > stockInicial Then
            venta = stockInicial
        Else
            venta = demanda
        End If

        'Cargamos el vector actual por primera vez
        actual(0) = 1 'exp
        actual(1) = stockInicial
        actual(2) = rnd1
        actual(3) = clima
        actual(4) = rnd2
        actual(5) = demanda
        actual(6) = venta
        actual(7) = (actual(1) - actual(6)) * 1.2   'reembolso
        ' actual(8) costo faltante
        actual(9) = actual(7) + actual(6) * 12    'sumatoria de ingreso
        actual(10) = actual(1) * 8 'sumatoria de costo
        actual(11) = actual(9) - actual(10)

    End Sub

    Public Sub siguienteVector()
        'Carga anterior con actual y se encarga de valuar el vector actual con el proximo experimento
        anterior = actual

        actual(0) = anterior(0) + 1
        actual(1) = anterior(1) ' En el punto c) hay que poner que sea la demanda del dia anterior anterior(5)
        actual(2) = VBMath.Rnd() 'RND de tiempo
        actual(3) = Me.climaDia(actual(2))
        actual(4) = VBMath.Rnd() 'RND de demanda
        'Segun el valor del clima
        If actual(3) = 1 Then
            actual(5) = Me.diaSoleado(actual(4))
        Else
            actual(5) = Me.diaNublado(actual(4))
        End If
        'Si la demanda es mayor al stock inicial vende todo el stock, si no vende y cubre la demanda
        If actual(5) > actual(1) Then
            actual(6) = actual(1)
        Else
            actual(6) = actual(5)
        End If
        actual(7) = (actual(1) - actual(6)) * 1.2   'Reembolso
        ' actual(8) costo faltante
        actual(9) = anterior(9) + (actual(7) + actual(6) * 12)    'Sumatoria de ingreso
        actual(10) = anterior(10) + (actual(1) * 8) 'Sumatoria de costo
        actual(11) = anterior(11) + (actual(9) - actual(10)) 'Sumatoria de beneficio

    End Sub

    Public Sub cargarFila()
        'Carga el vector actual a una proxima fila de la grilla

        'Agregar que diferencie segun grillas
        Me.GrillaA.Rows.Add()
        Me.GrillaA.Rows(actual(0) - 1).Cells(0).Value = actual(0)
        Me.GrillaA.Rows(actual(0) - 1).Cells(1).Value = actual(1)
        Me.GrillaA.Rows(actual(0) - 1).Cells(2).Value = actual(2)
        Me.GrillaA.Rows(actual(0) - 1).Cells(3).Value = actual(3) 'pasarlo a string
        Me.GrillaA.Rows(actual(0) - 1).Cells(4).Value = actual(4)
        Me.GrillaA.Rows(actual(0) - 1).Cells(5).Value = actual(5)
        Me.GrillaA.Rows(actual(0) - 1).Cells(6).Value = actual(6)
        Me.GrillaA.Rows(actual(0) - 1).Cells(7).Value = actual(7)
        Me.GrillaA.Rows(actual(0) - 1).Cells(8).Value = actual(8) ' varia si va o no
        Me.GrillaA.Rows(actual(0) - 1).Cells(9).Value = actual(9)
        Me.GrillaA.Rows(actual(0) - 1).Cells(10).Value = actual(10)
        Me.GrillaA.Rows(actual(0) - 1).Cells(11).Value = actual(11)

    End Sub

End Class