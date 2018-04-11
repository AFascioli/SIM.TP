Public Class TrabajoPractico1

    Dim a, c, m, seed As Double
    Dim contador As Integer = 0
    Dim numerosChi(), contadorChi()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_intervalos.Items.Add("5")
        cmb_intervalos.Items.Add("10")
        cmb_intervalos.Items.Add("20")

    End Sub

    Private Function congruencialMixto(a As Double, c As Double, m As Double, x As Double)

        Dim r, xi As Double 'r: numero random que genera.  xi: raiz.
        Dim res(2) As Double 'vector de tamaño 2, tiene en (0) y en (1): el siguiente numero para generar.

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

        Dim numeros(Integer.Parse(Me.txt_cantidadNros.Text) - 1)
        Dim contadorInter(Integer.Parse(Me.cmb_intervalos.SelectedItem) - 1) 'puede que se cague todo
        Dim anchoInt = 1 / contadorInter.Length
        Dim juancito As Integer

        For index = 0 To numeros.Length - 1

            numeros(index) = Rnd()
            juancito = Math.Truncate(numeros(index) / anchoInt)
            contadorInter(juancito) += 1

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
        Me.txt_chiCal.Text = contChi
        Me.compararChi()
        If Me.grid2.Rows(0).Cells(2).Value < 5 Then
            Me.cargarTabla3()
        End If
    End Sub

    Private Sub cargarTabla3()
        Me.grid4.Rows.Clear()

        Dim contadorSaltos = Me.obtenerIntervalos
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
        Me.compararChi()

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

    Private Sub compararChi()
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

        Me.txt_chiTab.Text = v(Me.cmb_intervalos.SelectedItem - 1)

        If v(Me.cmb_intervalos.SelectedItem - 1) > Me.txt_chiCal.Text Then

            Me.lbl_resultado.Text = "Se acepta la hipótesis"
        Else
            Me.lbl_resultado.Text = "Se rechaza la hipótesis"
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
End Class
