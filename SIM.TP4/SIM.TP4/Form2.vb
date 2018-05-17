Public Class Form2
    ' Vende a $1 cada rosa
    ' Compra a $8 la docena
    ' Rosas no vendidas, se venden a $0.10 c/u

    'Vectores anterior y actual
    ' experimento(0) |stock inicial(1)|rnd tiempo(2)    |soleado?(3)    |rnd demanda(4) |cant. demanda(5)  |
    ' cuanto vende(6)| Merc. faltante (7)  |reembolso(8)    |costo faltante(9)|sum ingreso(10)|sum costo(11)  | sum beneficio(12)|
    Dim anterior(12) As Double
    Dim actual(12) As Double

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_cantidadDocenas.Items.Add("7")
        cmb_cantidadDocenas.Items.Add("8")
        cmb_cantidadDocenas.Items.Add("9")
        cmb_cantidadDocenas.SelectedIndex = 1
        cmb_cantidadDocenasB.Items.Add("7")
        cmb_cantidadDocenasB.Items.Add("8")
        cmb_cantidadDocenasB.Items.Add("9")
        cmb_cantidadDocenasB.SelectedIndex = 1
        cmb_cantidadDocenasC.Items.Add("7")
        cmb_cantidadDocenasC.Items.Add("8")
        cmb_cantidadDocenasC.Items.Add("9")
        cmb_cantidadDocenasC.SelectedIndex = 1
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

    Public Sub cargarPrimeraFila(punto As String) 'Valua el vector con todos los datos necesarios

        Dim rnd1 As Double = VBMath.Rnd()
        Dim rnd2 As Double = VBMath.Rnd()

        Dim clima = climaDia(rnd1)
        Dim demanda As Integer
        Dim stockInicial As Integer
        Dim venta As Integer
        Dim mercFaltante As Integer

        If clima = 1 Then
            demanda = diaSoleado(rnd2)
        Else
            demanda = diaNublado(rnd2)
        End If

        If punto = "A" Then
            If cbx_demandaAnterior.Checked() Then
                stockInicial = 8
            Else
                stockInicial = cmb_cantidadDocenas.SelectedItem()
            End If
        Else
            If punto = "B" Then
                If cbx_demandaAnteriorB.Checked() Then
                    stockInicial = 8
                Else
                    stockInicial = cmb_cantidadDocenasB.SelectedItem()
                End If
            Else
                If cbx_demandaAnteriorC.Checked() Then
                    stockInicial = 8
                Else
                    stockInicial = cmb_cantidadDocenasC.SelectedItem()
                End If
            End If
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

        If punto = "A" Then
            actual(7) = 0
        Else
            If stockInicial - demanda < 1 Then 'Calculo de la mercaderia faltante
                actual(7) = demanda - stockInicial
            End If
        End If

        If punto = "A" Or punto = "B" Then
            actual(8) = (actual(1) - actual(6)) * 1.2   'Reembolso
        Else
            actual(8) = 0
        End If

        If punto = "C" Then
            If actual(7) <> 0 Then
                actual(9) = actual(7) * 1.2  'Costo faltante
            Else
                actual(9) = 0
            End If
        Else
            actual(9) = 0
        End If

        mercFaltante = actual(7) 'Agregamos esta variable porque en el punto F no se utiliza la mercaderia faltante en el calculo de costo
        If punto = "C" Then
            mercFaltante = 0

        End If
        actual(10) = actual(8) + (actual(6) * 12) + mercFaltante * 12    'sumatoria de ingreso

        actual(11) = actual(1) * 8 + (mercFaltante * 11) + actual(9) 'sumatoria de costo
        actual(12) = actual(10) - actual(11)

    End Sub

    Public Sub siguienteVector(punto As String)
        Dim mercFaltante As Integer

        'Carga anterior con actual y se encarga de valuar el vector actual con el proximo experimento
        anterior = actual

        actual(0) = anterior(0) + 1

        If punto = "A" Then                                     'Logica para cargar el sotck inicial
            If cbx_demandaAnterior.Checked() Then
                actual(1) = anterior(5)
            Else
                actual(1) = cmb_cantidadDocenas.SelectedItem()
            End If
        Else
            If punto = "B" Then
                If cbx_demandaAnteriorB.Checked() Then
                    actual(1) = anterior(5)
                Else
                    actual(1) = cmb_cantidadDocenasB.SelectedItem()
                End If
            Else
                If cbx_demandaAnteriorC.Checked() Then
                    actual(1) = anterior(5)
                Else
                    actual(1) = cmb_cantidadDocenasC.SelectedItem()
                End If
            End If
        End If

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

        If punto = "A" Then
            actual(7) = 0 'No se usa en el punto A
        Else
            If actual(1) - actual(5) < 1 Then 'Calculo de la mercaderia faltante
                actual(7) = actual(5) - actual(1)
            End If
        End If

        If punto = "A" Or punto = "B" Then
            actual(8) = (actual(1) - actual(6)) * 1.2   'Reembolso
        Else
            actual(8) = 0
        End If

        If punto = "C" Then
            If actual(7) <> 0 Then
                actual(9) = actual(7) * 1.2  'Costo faltante
            Else
                actual(9) = 0
            End If
        Else
            actual(9) = 0       'Solo se usa en el punto C
        End If

        mercFaltante = actual(7) 'Agregamos esta variable porque en el punto F no se utiliza la mercaderia faltante en el calculo de costo
        If punto = "C" Then
            mercFaltante = 0

        End If
        actual(10) = anterior(10) + (actual(8) + actual(6) * 12) + (mercFaltante * 12) 'Sumatoria de ingreso

        actual(11) = anterior(11) + (actual(1) * 8) + (mercFaltante * 11) + actual(9) 'Sumatoria de costo

        actual(12) = (actual(10) - actual(11)) 'Sumatoria de beneficio

    End Sub

    Public Sub cargarFilaA()
        'Carga el vector actual a una proxima fila de la grilla

        'Agregar que diferencie segun grillas
        Me.GrillaA.Rows.Add()
        Me.GrillaA.Rows(actual(0) - 1).Cells(0).Value = actual(0)
        Me.GrillaA.Rows(actual(0) - 1).Cells(1).Value = actual(1)
        Me.GrillaA.Rows(actual(0) - 1).Cells(2).Value = actual(2)

        If actual(3) = 1 Then 'En valor 1 corresponde dia soleado, si no es dia nublado
            Me.GrillaA.Rows(actual(0) - 1).Cells(3).Value = "Si"
        Else
            Me.GrillaA.Rows(actual(0) - 1).Cells(3).Value = "No"
        End If

        Me.GrillaA.Rows(actual(0) - 1).Cells(4).Value = actual(4)
        Me.GrillaA.Rows(actual(0) - 1).Cells(5).Value = actual(5)
        Me.GrillaA.Rows(actual(0) - 1).Cells(6).Value = actual(6)
        Me.GrillaA.Rows(actual(0) - 1).Cells(7).Value = actual(8) 'No van actual(9)=costo faltante, ni actual(7) merc. faltante
        Me.GrillaA.Rows(actual(0) - 1).Cells(8).Value = actual(10) ' varia si va o no
        Me.GrillaA.Rows(actual(0) - 1).Cells(9).Value = actual(11)
        Me.GrillaA.Rows(actual(0) - 1).Cells(10).Value = actual(12)

    End Sub

    Public Sub cargarTablaA()

        Me.cargarPrimeraFila("A")
        Me.cargarFilaA()

        For index = 1 To Integer.Parse(Me.txt_cantidadDias.Text) - 1
            Me.siguienteVector("A")
            Me.cargarFilaA()
        Next

    End Sub

    Private Sub cmd_generarA_Click(sender As Object, e As EventArgs) Handles cmd_generarA.Click
        Dim ganancia As Double
        For index = 1 To 100
            Me.GrillaA.Rows.Clear()
            Me.cargarTablaA()
            ganancia += Me.obtenerGananciaDiariaPromedio(Me.GrillaA, "A")
        Next
        Me.txt_respA.Text = ganancia / 100
    End Sub

    Public Sub cargarFilaB()
        Me.GrillaB.Rows.Add()
        Me.GrillaB.Rows(actual(0) - 1).Cells(0).Value = actual(0)
        Me.GrillaB.Rows(actual(0) - 1).Cells(1).Value = actual(1)
        Me.GrillaB.Rows(actual(0) - 1).Cells(2).Value = actual(2)

        If actual(3) = 1 Then 'En valor 1 corresponde dia soleado, si no es dia nublado
            Me.GrillaB.Rows(actual(0) - 1).Cells(3).Value = "Si"
        Else
            Me.GrillaB.Rows(actual(0) - 1).Cells(3).Value = "No"
        End If

        Me.GrillaB.Rows(actual(0) - 1).Cells(4).Value = actual(4)
        Me.GrillaB.Rows(actual(0) - 1).Cells(5).Value = actual(5)
        Me.GrillaB.Rows(actual(0) - 1).Cells(6).Value = actual(6)
        Me.GrillaB.Rows(actual(0) - 1).Cells(7).Value = actual(7) 'merc. faltante
        Me.GrillaB.Rows(actual(0) - 1).Cells(8).Value = actual(8) 'Reembolso
        Me.GrillaB.Rows(actual(0) - 1).Cells(9).Value = actual(10)
        Me.GrillaB.Rows(actual(0) - 1).Cells(10).Value = actual(11)
        Me.GrillaB.Rows(actual(0) - 1).Cells(11).Value = actual(12)
    End Sub

    Public Sub cargarTablaB()

        Me.cargarPrimeraFila("B")
        Me.cargarFilaB()

        For index = 1 To Integer.Parse(Me.txt_cantidadDiasB.Text) - 1
            Me.siguienteVector("B")
            Me.cargarFilaB()
        Next

    End Sub

    Private Sub cmd_generarB_Click(sender As Object, e As EventArgs) Handles cmd_generarB.Click
        Me.GrillaB.Rows.Clear()
        Me.cargarTablaB()
    End Sub

    Public Sub cargarFilaC()
        'Carga el vector actual a una proxima fila de la grilla

        'Agregar que diferencie segun grillas
        Me.GrillaC.Rows.Add()
        Me.GrillaC.Rows(actual(0) - 1).Cells(0).Value = actual(0)
        Me.GrillaC.Rows(actual(0) - 1).Cells(1).Value = actual(1)
        Me.GrillaC.Rows(actual(0) - 1).Cells(2).Value = actual(2)

        If actual(3) = 1 Then 'En valor 1 corresponde dia soleado, si no es dia nublado
            Me.GrillaC.Rows(actual(0) - 1).Cells(3).Value = "Si"
        Else
            Me.GrillaC.Rows(actual(0) - 1).Cells(3).Value = "No"
        End If

        Me.GrillaC.Rows(actual(0) - 1).Cells(4).Value = actual(4)
        Me.GrillaC.Rows(actual(0) - 1).Cells(5).Value = actual(5)
        Me.GrillaC.Rows(actual(0) - 1).Cells(6).Value = actual(6)
        Me.GrillaC.Rows(actual(0) - 1).Cells(7).Value = actual(7) 'Merc. Faltante
        Me.GrillaC.Rows(actual(0) - 1).Cells(8).Value = actual(9) 'Costo Faltante
        Me.GrillaC.Rows(actual(0) - 1).Cells(9).Value = actual(10)
        Me.GrillaC.Rows(actual(0) - 1).Cells(10).Value = actual(11)
        Me.GrillaC.Rows(actual(0) - 1).Cells(11).Value = actual(12)

    End Sub

    Public Sub cargarTablaC()

        Me.cargarPrimeraFila("C")
        Me.cargarFilaC()

        For index = 1 To Integer.Parse(Me.txt_cantidadDiasC.Text) - 1
            Me.siguienteVector("C")
            Me.cargarFilaC()
        Next

    End Sub

    Private Sub cmd_generarC_Click(sender As Object, e As EventArgs) Handles cmd_generarC.Click
        Me.GrillaC.Rows.Clear()
        Me.cargarTablaC()
    End Sub

    Public Function obtenerGananciaDiariaPromedio(grilla As DataGridView, punto As String)
        Dim ganancia As Double

        If punto = "A" Then
            ganancia = grilla.Rows(grilla.Rows.Count - 1).Cells(10).Value
        Else
            ganancia = grilla.Rows(grilla.Rows.Count - 1).Cells(11).Value
        End If


        Return ganancia
    End Function

End Class