Public Class TrabajoPractico1
    Enum NroPunto
        b
        c
    End Enum
    Dim a, c, m, seed As Double
    Dim contador As Integer = 0
    Dim numerosChiB(), contadorChiB() As Double
    Dim numerosChiC() As Double
    Dim contadorChiC() As Double
    Dim bandera As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_intervalosB.Items.Add("5")
        cmb_intervalosB.Items.Add("10")
        cmb_intervalosB.Items.Add("20")
        cmb_intervalosB.SelectedIndex = 0
        cmb_cantIntC.Items.Add("5")
        cmb_cantIntC.Items.Add("10")
        cmb_cantIntC.Items.Add("20")
        cmb_cantIntC.SelectedIndex = 0

    End Sub

    Private Function congruencialMixto(a As Double, c As Double, m As Double, x As Double)

        Dim r, xi As Double 'r: numero random que genera.  xi: raiz.
        Dim res(1) As Double 'vector de tamaño 2, tiene en (0) y en (1): el siguiente numero para generar.

        xi = (a * x + c) Mod m

        r = xi / m

        res(0) = r
        res(1) = xi

        Return res

    End Function

    Private Sub compararChi(punto As NroPunto, glibertad As Integer)
        Dim v(28) As Double

        v(0) = 3.8415
        v(1) = 5.9915
        v(2) = 7.8147
        v(3) = 9.4877
        v(4) = 11.0705
        v(5) = 12.5916
        v(6) = 14.0671
        v(7) = 15.5073
        v(8) = 16.919
        v(9) = 18.307
        v(10) = 19.6752
        v(11) = 21.0261
        v(12) = 22.362
        v(13) = 23.6848
        v(14) = 24.9958
        v(15) = 26.2962
        v(16) = 27.5871
        v(17) = 28.8693
        v(18) = 30.1435
        v(19) = 31.4104
        v(20) = 32.6706
        v(21) = 33.9245
        v(22) = 35.1725
        v(23) = 36.415
        v(24) = 37.6525
        v(25) = 38.8851
        v(26) = 40.1133
        v(27) = 41.3372
        v(28) = 42.5569

        If punto = NroPunto.b Then
            Me.txt_chiTabB.Text = v(glibertad - 1)

            If v(glibertad - 1) > Me.txt_chiCalB.Text Then

                Me.lbl_resultadoB.Text = "Se acepta la hipótesis"
            Else
                Me.lbl_resultadoB.Text = "Se rechaza la hipótesis"
            End If
        Else
            Me.txt_chiTabC.Text = v(glibertad - 1)

            If v(glibertad - 1) > Me.txt_chiCalcC.Text Then

                Me.lbl_resultadoC.Text = "Se acepta la hipótesis"
            Else
                Me.lbl_resultadoC.Text = "Se rechaza la hipótesis"
            End If
        End If
        Me.bandera = False
    End Sub

    Private Function obtenerIntervalos(numeros() As Double, contadorChi() As Double) 'devuelve cuanto agrupar para cumplir con la restriccion de fe
        Dim aux As Double = 0
        Dim contador As Integer = 0

        While aux < 5
            aux += numeros.Length / contadorChi.Length
            contador += 1
        End While

        Return contador
    End Function

    Private Sub cargarGrid1A()
        Dim vector(2) As Double
        Dim r As Double = Me.seed

        For index = 0 To 19
            vector = Me.congruencialMixto(Me.a, Me.c, Me.m, r)
            Me.grid1A.Rows.Add()
            Me.grid1A.Rows(index).Cells(0).Value = index + Me.contador + 1
            Me.grid1A.Rows(index).Cells(1).Value = vector(0)
            r = vector(1)
        Next
        Me.seed = r
        Me.contador = 20
    End Sub

    Private Sub cmd_generarA_Click(sender As Object, e As EventArgs) Handles cmd_generarA.Click
        Me.contador = 0
        Me.grid1A.Rows.Clear()
        a = txt_aA.Text
        c = txt_cA.Text
        m = txt_mA.Text
        seed = txt_seedA.Text

        cargarGrid1A()

    End Sub

    Private Sub cmd_siguienteA_Click(sender As Object, e As EventArgs) Handles cmd_siguienteA.Click

        Dim vector(2) As Double
        vector = Me.congruencialMixto(Me.a, Me.c, Me.m, Me.seed)
        Me.grid1A.Rows.Add()
        Me.grid1A.Rows(Me.contador).Cells(0).Value = Me.contador + 1
        Me.grid1A.Rows(Me.contador).Cells(1).Value = vector(0)
        Me.contador += 1
        Me.seed = vector(1)

    End Sub

    Private Sub cmd_generarB_Click(sender As Object, e As EventArgs) Handles cmd_generarB.Click
        Me.generadorRandom()
        Me.cargarGrid1B()
        Me.cargarGraficoB()
    End Sub

    Private Sub generadorRandom()

        Dim numeros(Integer.Parse(Me.txt_cantidadNrosB.Text) - 1) As Double 'vector para numeros generados por rnd
        Dim contadorInter(Integer.Parse(Me.cmb_intervalosB.SelectedItem) - 1) As Double 'vector que cuenta cuantos numeros hay en cada intervalo
        Dim anchoInt = 1 / contadorInter.Length 'ancho del intervalo
        Dim cantEnInterv As Integer

        For index = 0 To numeros.Length - 1

            numeros(index) = Rnd()
            cantEnInterv = Math.Truncate(numeros(index) / anchoInt) 'para saber en que intervalo corresponde ese rnd
            contadorInter(cantEnInterv) += 1

            Me.grid2B.Rows.Add() 'para mostrar numeros random generados
            Me.grid2B.Rows(index).Cells(0).Value = numeros(index)

        Next

        numerosChiB = numeros
        contadorChiB = contadorInter


    End Sub

    Private Sub cargarGrid1B()
        Me.grid1B.Rows.Clear()

        Dim contChi As Double = 0

        For index = 0 To contadorChiB.Length - 1

            Dim y = contadorChiB(index)

            If IsNothing(y) Then
                y = 0
            End If

            Me.grid1B.Rows.Add()
            Me.grid1B.Rows(index).Cells(0).Value = index + 1
            Me.grid1B.Rows(index).Cells(1).Value = y
            Me.grid1B.Rows(index).Cells(2).Value = numerosChiB.Length / contadorChiB.Length
            Me.grid1B.Rows(index).Cells(3).Value = ((contadorChiB(index) - numerosChiB.Length / contadorChiB.Length) ^ 2) / (numerosChiB.Length / contadorChiB.Length)

            contChi += Me.grid1B.Rows(index).Cells(3).Value
        Next


        If Me.grid1B.Rows(0).Cells(2).Value < 5 Then
            Me.bandera = True 'bandera para comparar con el chi de la tabla agrupada
            Me.cargarGrid3B()
        Else
            Me.txt_chiCalB.Text = contChi
            Me.compararChi(NroPunto.b, Me.cmb_intervalosB.SelectedItem)
        End If
    End Sub

    Private Sub cargarGrid3B()
        Me.grid3B.Rows.Clear()

        Dim contadorSaltos = Me.obtenerIntervalos(Me.numerosChiB, Me.contadorChiB)
        Dim auxiliar = Integer.Parse(Me.cmb_intervalosB.SelectedItem) / contadorSaltos 'cantidad de intervalos
        Dim contSaltos As Integer = 0
        Dim contChi As Double = 0
        Dim extra As Integer

        For index = 0 To auxiliar - 1

            Me.grid3B.Rows.Add()
            Me.grid3B.Rows(index).Cells(0).Value = index + 1

            If index = 0 Then 'solo se hace una vez en la primera vuelta para evitar problemas
                extra = Me.cmb_intervalosB.SelectedItem Mod contadorSaltos 'extra son los elementos que sobrarian luego de reagrupar
            End If

            For index2 = 1 To contadorSaltos + extra 'los elementos que sobran, los ponemos en el primer grupo y de ahi nos queda siempre una cantidad justa para agrupar

                Me.grid3B.Rows(index).Cells(1).Value += Me.grid1B.Rows(contSaltos).Cells(1).Value
                Me.grid3B.Rows(index).Cells(2).Value += Me.grid1B.Rows(contSaltos).Cells(2).Value
                contSaltos += 1
            Next

            extra = 0 'extra a partir de ahora no sirve entonces vale 0

            Me.grid3B.Rows(index).Cells(3).Value = ((Me.grid3B.Rows(index).Cells(1).Value - Me.grid3B.Rows(index).Cells(2).Value) ^ 2) / Me.grid3B.Rows(index).Cells(2).Value
            contChi += Me.grid3B.Rows(index).Cells(3).Value

        Next

        Me.txt_chiCalB.Text = contChi
        Me.compararChi(NroPunto.b, Me.grid3B.Rows.Count)

    End Sub

    Private Sub cargarGraficoB()
        'El estilo del gráfico se edita en Propiedades, Series en la pestaña de diseño del form
        Me.Chart1B.Series("fe").Points.Clear()
        Me.Chart1B.Series("fo").Points.Clear()
        Dim anchoInt = 1 / contadorChiB.Length
        Dim aux As Double = 0
        For i = 0 To contadorChiB.Length - 1
            aux += anchoInt
            Me.Chart1B.Series("fe").Points.AddXY(aux, Me.grid1B.Rows(i).Cells(2).Value)
            Me.Chart1B.Series("fo").Points.AddXY(aux, Me.grid1B.Rows(i).Cells(1).Value)
        Next

    End Sub

    Private Sub cmd_generarC_Click(sender As Object, e As EventArgs) Handles cmd_generarC.Click
        Me.numerosPuntoC()
        Me.cargarGrid1C()
        Me.cargarGraficoC()
    End Sub

    Private Sub cargarGrid1C()
        Me.grid1C.Rows.Clear()

        Dim contChi As Double = 0
        For index = 0 To contadorChiC.Length - 1

            Dim y = contadorChiC(index)
            If IsNothing(y) Then
                y = 0
            End If

            Me.grid1C.Rows.Add()
            Me.grid1C.Rows(index).Cells(0).Value = index + 1
            Me.grid1C.Rows(index).Cells(1).Value = y
            Me.grid1C.Rows(index).Cells(2).Value = numerosChiC.Length / contadorChiC.Length
            Me.grid1C.Rows(index).Cells(3).Value = ((contadorChiC(index) - numerosChiC.Length / contadorChiC.Length) ^ 2) / (numerosChiC.Length / contadorChiC.Length)
            contChi += Me.grid1C.Rows(index).Cells(3).Value
        Next

        If numerosChiC.Length / contadorChiC.Length < 5 Then
            Me.bandera = True 'bandera para comparar con el chi de la tabla agrupada
            Me.cargarGrid3C()
        Else
            Me.txt_chiCalcC.Text = contChi
            Me.compararChi(NroPunto.c, Me.cmb_intervalosB.SelectedItem)
        End If

    End Sub

    Private Sub cargarGrid3C()
        Me.grid3C.Rows.Clear()

        Dim contadorSaltos = Me.obtenerIntervalos(Me.numerosChiC, Me.contadorChiC)
        Dim auxiliar = Integer.Parse(Me.cmb_cantIntC.SelectedItem) / contadorSaltos 'cantidad de intervalos
        Dim contSaltos As Integer = 0
        Dim contChi As Double = 0
        Dim extra As Integer

        For index = 0 To auxiliar - 1

            Me.grid3C.Rows.Add()
            Me.grid3C.Rows(index).Cells(0).Value = index + 1

            If index = 0 Then 'solo se hace una vez en la primera vuelta para evitar problemas
                extra = Me.cmb_cantIntC.SelectedItem Mod contadorSaltos 'extra son los elementos que sobrarian luego de reagrupar
            End If

            For index2 = 1 To contadorSaltos + extra 'los elementos que sobran, los ponemos en el primer grupo y de ahi nos queda siempre una cantidad justa para agrupar

                Me.grid3C.Rows(index).Cells(1).Value += Me.grid1C.Rows(contSaltos).Cells(1).Value
                Me.grid3C.Rows(index).Cells(2).Value += Me.grid1C.Rows(contSaltos).Cells(2).Value
                contSaltos += 1
            Next

            extra = 0 'extra a partir de ahora no sirve entonces vale 0

            Me.grid3C.Rows(index).Cells(3).Value = ((Me.grid3C.Rows(index).Cells(1).Value - Me.grid3C.Rows(index).Cells(2).Value) ^ 2) / Me.grid3C.Rows(index).Cells(2).Value
            contChi += Me.grid3C.Rows(index).Cells(3).Value

        Next

        Me.txt_chiCalcC.Text = contChi
        Me.compararChi(NroPunto.c, Me.grid3C.Rows.Count)
    End Sub

    Private Sub numerosPuntoC()
        Dim numerosC(Integer.Parse(Me.txt_cantNrosC.Text) - 1) As Double
        Dim contadorInterC(Integer.Parse(Me.cmb_cantIntC.SelectedItem) - 1) As Double
        Dim anchoInt = 1 / contadorInterC.Length
        Dim cantEnInt As Integer
        Dim seedParcial As Integer = Me.txt_seedC.Text
        Dim randomC As Double = 0
        Dim vecAux(1) As Double

        Me.grid2C.Rows.Clear()
        For index = 0 To numerosC.Length - 1
            vecAux = Me.congruencialMixto(Me.txt_aC.Text, Me.txt_cC.Text, Me.txt_mC.Text, seedParcial)
            randomC = vecAux(0)
            seedParcial = vecAux(1)

            numerosC(index) = randomC
            cantEnInt = Math.Truncate(numerosC(index) / anchoInt)
            contadorInterC(cantEnInt) += 1

            Me.grid2C.Rows.Add() 'para mostrar numeros random generados
            Me.grid2C.Rows(index).Cells(0).Value = numerosC(index)
        Next

        numerosChiC = numerosC
        contadorChiC = contadorInterC

    End Sub

    Private Sub cargarGraficoC()
        Me.Chart1C.Series("fe").Points.Clear()
        Me.Chart1C.Series("fo").Points.Clear()
        Dim anchoInt = 1 / contadorChiC.Length
        Dim aux As Double = 0
        For i = 0 To contadorChiC.Length - 1
            aux += anchoInt
            Me.Chart1C.Series("fe").Points.AddXY(aux, Me.grid1C.Rows(i).Cells(2).Value)
            Me.Chart1C.Series("fo").Points.AddXY(aux, Me.grid1C.Rows(i).Cells(1).Value)
        Next
    End Sub

End Class
