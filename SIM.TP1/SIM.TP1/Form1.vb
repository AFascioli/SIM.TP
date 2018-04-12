Public Class TrabajoPractico1
    Enum NroPunto
        b
        c
    End Enum
    Dim a, c, m, seed As Double
    Dim contador As Integer = 0
    Dim numerosChi(), contadorChi()
    Dim numerosChiC()
    Dim contadorChiC As Integer()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_intervalos.Items.Add("5")
        cmb_intervalos.Items.Add("10")
        cmb_intervalos.Items.Add("20")
        cmb_intervalos.SelectedIndex = 0
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

    Private Sub cargarTabla()
        Dim vector(2) As Double
        Dim r As Double = Me.seed

        For index = 0 To 19
            vector = Me.congruencialMixto(Me.a, Me.c, Me.m, r)
            Me.grid1.Rows.Add()
            Me.grid1.Rows(index).Cells(0).Value = index + Me.contador + 1
            Me.grid1.Rows(index).Cells(1).Value = vector(0)
            r = vector(1)
        Next
        Me.seed = r
        Me.contador = 20
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.generadorRandom()
        Me.cargarTabla2()
        Me.cargarGrafico()
    End Sub

    Private Sub cmd_generar_Click(sender As Object, e As EventArgs) Handles cmd_generar.Click
        Me.contador = 0
        Me.grid1.Rows.Clear()
        a = txt_a.Text
        c = txt_c.Text
        m = txt_m.Text
        seed = txt_seed.Text

        cargarTabla()

    End Sub

    Private Sub cmd_siguiente_Click(sender As Object, e As EventArgs) Handles cmd_siguiente.Click

        Dim vector(2) As Double
        vector = Me.congruencialMixto(Me.a, Me.c, Me.m, Me.seed)
        Me.grid1.Rows.Add()
        Me.grid1.Rows(Me.contador).Cells(0).Value = Me.contador + 1
        Me.grid1.Rows(Me.contador).Cells(1).Value = vector(0)
        Me.contador += 1
        Me.seed = vector(1)

    End Sub

    Private Sub generadorRandom()

        Dim numeros(Integer.Parse(Me.txt_cantidadNros.Text) - 1) 'vector para numeros generados por rnd
        Dim contadorInter(Integer.Parse(Me.cmb_intervalos.SelectedItem) - 1) 'vector que cuenta cuantos numeros hay en cada intervalo
        Dim anchoInt = 1 / contadorInter.Length 'ancho del intervalo
        Dim cantEnInterv As Integer

        For index = 0 To numeros.Length - 1

            numeros(index) = Rnd()
            cantEnInterv = Math.Truncate(numeros(index) / anchoInt) 'para saber en que intervalo corresponde ese rnd
            contadorInter(cantEnInterv) += 1

            Me.grid3.Rows.Add() 'para mostrar numeros random generados
            Me.grid3.Rows(index).Cells(0).Value = numeros(index)

        Next

        numerosChi = numeros
        contadorChi = contadorInter


    End Sub

    Private Sub cargarTabla2()
        Me.grid2.Rows.Clear()
        Dim contChi As Double = 0
        For index = 0 To contadorChi.Length - 1

            Dim y = contadorChi(index)
            If IsNothing(y) Then
                y = 0
            End If

            Me.grid2.Rows.Add()
            Me.grid2.Rows(index).Cells(0).Value = index + 1
            Me.grid2.Rows(index).Cells(1).Value = y
            Me.grid2.Rows(index).Cells(2).Value = numerosChi.Length / contadorChi.Length
            Me.grid2.Rows(index).Cells(3).Value = ((contadorChi(index) - numerosChi.Length / contadorChi.Length) ^ 2) / (numerosChi.Length / contadorChi.Length)
            contChi += Me.grid2.Rows(index).Cells(3).Value
        Next


        If Me.grid2.Rows(0).Cells(2).Value < 5 Then
            Me.cargarTabla3()
        Else
            Me.txt_chiCal.Text = contChi
            Me.compararChi(NroPunto.b)
        End If
    End Sub

    Private Sub cargarTabla3()
        Me.grid4.Rows.Clear()

        Dim contadorSaltos = Me.obtenerIntervalos()
        Dim auxiliar = Integer.Parse(Me.cmb_intervalos.SelectedItem) / contadorSaltos 'cantidad de intervalos
        Dim contSaltos As Integer = 0
        Dim contChi As Double = 0
        Dim extra As Integer

        For index = 0 To auxiliar - 1

            Me.grid4.Rows.Add()
            Me.grid4.Rows(index).Cells(0).Value = index + 1

            If index = 0 Then 'solo se hace una vez en la primera vuelta para evitar problemas
                extra = Me.cmb_intervalos.SelectedItem Mod contadorSaltos 'extra son los elementos que sobrarian luego de reagrupar
            End If

            For index2 = 1 To contadorSaltos + extra 'los elementos que sobran, los ponemos en el primer grupo y de ahi nos queda siempre una cantidad justa para agrupar

                Me.grid4.Rows(index).Cells(1).Value += Me.grid2.Rows(contSaltos).Cells(1).Value
                Me.grid4.Rows(index).Cells(2).Value += Me.grid2.Rows(contSaltos).Cells(2).Value
                contSaltos += 1
            Next

            extra = 0 'extra a partir de ahora no sirve entonces vale 0

            Me.grid4.Rows(index).Cells(3).Value = ((Me.grid4.Rows(index).Cells(1).Value - Me.grid4.Rows(index).Cells(2).Value) ^ 2) / Me.grid4.Rows(index).Cells(2).Value
            contChi += Me.grid2.Rows(index).Cells(3).Value

        Next

        Me.txt_chiCal.Text = contChi
        Me.compararChi(NroPunto.b)

    End Sub

    Private Sub cargarGrafico()
        'El estilo del gráfico se edita en Propiedades, Series en la pestaña de diseño del form
        Me.Chart1.Series("fe").Points.Clear()
        Me.Chart1.Series("fo").Points.Clear()
        Dim anchoInt = 1 / contadorChi.Length
        Dim aux As Double = 0
        For i = 0 To contadorChi.Length - 1
            aux += anchoInt
            Me.Chart1.Series("fe").Points.AddXY(aux, Me.grid2.Rows(i).Cells(2).Value)
            Me.Chart1.Series("fo").Points.AddXY(aux, Me.grid2.Rows(i).Cells(1).Value)
        Next

    End Sub

    Private Sub cmd_generarC_Click(sender As Object, e As EventArgs) Handles cmd_generarC.Click
        Me.numerosPuntoC()
        Me.cargarGrid1C()
        Me.cargarGraficoC()
    End Sub

    Private Sub compararChi(punto As NroPunto)
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
            Me.txt_chiTab.Text = v(Me.cmb_intervalos.SelectedItem - 1)

            If v(Me.cmb_intervalos.SelectedItem - 1) > Me.txt_chiCal.Text Then

                Me.lbl_resultado.Text = "Se acepta la hipótesis"
            Else
                Me.lbl_resultado.Text = "Se rechaza la hipótesis"
            End If
        Else
            Me.txt_chiTabC.Text = v(Me.cmb_cantIntC.SelectedItem - 1)

            If v(Me.cmb_cantIntC.SelectedItem - 1) > Me.txt_chiCalcC.Text Then

                Me.lbl_resultadoC.Text = "Se acepta la hipótesis"
            Else
                Me.lbl_resultadoC.Text = "Se rechaza la hipótesis"
            End If
        End If



    End Sub

    Private Function obtenerIntervalos() 'devuelve cuanto agrupar para cumplir con la restriccion de fe
        Dim aux As Double = 0
        Dim contador As Integer = 0

        While aux < 5
            aux += numerosChi.Length / contadorChi.Length
            contador += 1
        End While

        Return contador
    End Function

    Private Function obtenerIntervalosV2(fe As Double, contador As Integer())
        Dim ret As New List(Of Integer())
        Dim inicio As Integer
        Dim acumFo As Integer
        Dim acumFe
        Dim i As Integer
        Dim agregar As Boolean = True
        While i < contador.Length
            acumFo = 0
            acumFe = 0
            inicio = i
            While acumFe < 5
                If i >= (contador.Length - 1) Then
                    agregar = False
                    ret(ret.Count - 1)(1) = i
                    ret(ret.Count - 1)(2) += acumFo + contador(i)
                    i += 1
                    Exit While
                End If
                acumFo += contador(i)
                acumFe += fe
                i += 1
            End While
            If agregar Then
                ret.Add({inicio, i - 1, acumFo})
            End If
        End While

        'Retorna una lista de vectores que contienen el inicio, el fin y la fo de cada intervalo
        Return ret
    End Function

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
            Me.cargarTabla3C()
        Else
            Me.txt_chiCalcC.Text = contChi
            Me.compararChi(NroPunto.c)
        End If

    End Sub

    Private Sub numerosPuntoC()
        Dim numerosC(Me.txt_cantNrosC.Text)
        Dim contadorInterC(Integer.Parse(Me.cmb_cantIntC.SelectedItem) - 1) As Integer
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
        Me.Chart2.Series("fe").Points.Clear()
        Me.Chart2.Series("fo").Points.Clear()
        Dim anchoInt = 1 / contadorChiC.Length
        Dim aux As Double = 0
        For i = 0 To contadorChiC.Length - 1
            aux += anchoInt
            Me.Chart2.Series("fe").Points.AddXY(aux, Me.grid1C.Rows(i).Cells(2).Value)
            Me.Chart2.Series("fo").Points.AddXY(aux, Me.grid1C.Rows(i).Cells(1).Value)
        Next
    End Sub

    Private Sub cargarTabla3C()
        Me.grid3C.Rows.Clear()

        Dim fe = Me.grid1C.Rows(0).Cells(2).Value
        Dim intervalos As List(Of Integer()) = Me.obtenerIntervalosV2(fe, Me.contadorChiC)
        Dim contChi As Integer = 0

        For i = 0 To intervalos.Count - 1
            Dim inicio As Integer = intervalos(i)(0)
            Dim fin As Integer = intervalos(i)(1)
            Dim foAcum As Integer = intervalos(i)(2)
            Me.grid3C.Rows.Add()
            If inicio <> fin Then
                Me.grid3C.Rows(i).Cells(0).Value = (inicio + 1) & " - " & (fin + 1)
            Else
                Me.grid3C.Rows(i).Cells(0).Value = inicio + 1
            End If

            Me.grid3C.Rows(i).Cells(1).Value = foAcum
            Me.grid3C.Rows(i).Cells(2).Value = fe * (fin - inicio + 1)

            Me.grid3C.Rows(i).Cells(3).Value = ((Me.grid3C.Rows(i).Cells(1).Value - Me.grid3C.Rows(i).Cells(2).Value) ^ 2) / Me.grid3C.Rows(i).Cells(2).Value
            contChi += Me.grid3C.Rows(i).Cells(3).Value
        Next


        Me.txt_chiCalcC.Text = contChi
        Me.compararChi(NroPunto.c)

    End Sub


End Class
