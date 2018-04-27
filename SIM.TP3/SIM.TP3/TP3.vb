Public Class TP3
    Dim maximo, minimo As Double
    Dim acumChi As Double 'Variable que acumula chi de la grilla
    Dim tamIntervalo As Double

    Enum distribucion
        uniforme
        exponencial
        normal
        poisson
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_intervalos.Items.Add("5")
        cmb_intervalos.Items.Add("10")
        cmb_intervalos.Items.Add("20")
        cmb_intervalos.SelectedIndex = 0
        minimo = Nothing
        maximo = Nothing
    End Sub

    Private Function distUniforme(A As Double, B As Double)
        Dim res As Double

        res = A + localRnd() * (B - A)
        Return res
    End Function

    'Exponencial y Poisson no tienen que generar negativos.

    Private Function distExponencial(lambda As Double)
        Dim res As Double

        res = (-1 / lambda) * Math.Log(1 - localRnd())
        Return res
    End Function

    Private Function distNormal(media As Double, desviacion As Double)
        Dim res(1) As Double
        Dim rnd1 As Double = localRnd()
        Dim rnd2 As Double = localRnd()

        res(0) = (Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2)) * desviacion + media
        res(1) = (Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2)) * desviacion + media
        Return res
    End Function

    Private Function distPoisson(lambda As Double)
        Dim P As Double = 1
        Dim X As Double = -1
        Dim A As Double = Math.Exp(-lambda)

        Do
            P = P * localRnd()
            X += 1
        Loop While (P >= A)

        Return X
    End Function

    Private Sub agregarFilaGrid(index As Integer, rnd As Double)

        If index = 0 Then
            maximo = Math.Ceiling(rnd) ' + 1 'Comento el +1 por problemas con uniforme
            minimo = Math.Floor(rnd)
        End If

        If rnd >= maximo Then
            maximo = Math.Ceiling(rnd) ' + 1
        End If

        If rnd < minimo Then
            minimo = Math.Floor(rnd)
        End If

        Me.Grid1.Rows.Add()
        Me.Grid1.Rows(index).Cells(0).Value = index + 1
        Me.Grid1.Rows(index).Cells(1).Value = rnd

    End Sub

    Private Sub generarRND1()

        For index = 0 To Integer.Parse(Me.txt_muestra1.Text) - 1

            Me.agregarFilaGrid(index, Me.distUniforme(Me.txt_A.Text, Me.txt_B.Text))

        Next

    End Sub

    Private Sub generarRND2()

        If Me.txt_lambda2.Text = "" Then    'Ver de hacerlo bien 
            Me.txt_lambda2.Text = 1 / (Me.txt_media2.Text)
        End If

        For index = 0 To Integer.Parse(txt_muestra2.Text) - 1
            Me.agregarFilaGrid(index, Me.distExponencial(Me.txt_lambda2.Text))
        Next

    End Sub

    Private Sub generarRND3()

        Dim v(Me.txt_muestra3.Text - 1) As Double
        Dim vaux(1) As Double
        Dim contador As Integer = 0
        Dim cantidad As Integer = Math.Ceiling(Me.txt_muestra3.Text / 2) 'parse

        For index = 0 To cantidad - 1
            vaux = Me.distNormal(Me.txt_media3.Text, Me.txt_desviacion3.Text)
            Me.agregarFilaGrid(contador, vaux(0))
            contador += 1

            If contador = Me.txt_muestra3.Text Then
                Exit For
            End If

            Me.agregarFilaGrid(contador, vaux(1))
            contador += 1
        Next

    End Sub

    Private Sub generarRND4()

        For index = 0 To Integer.Parse(txt_muestra4.Text) - 1
            Me.agregarFilaGrid(index, Me.distPoisson(Me.txt_lambda4.Text))
        Next

    End Sub

    Private Sub cargarGrid2(tamMuestra As Integer, dist As distribucion)

        tamIntervalo = (maximo - minimo) / Me.cmb_intervalos.SelectedItem
        'TamIntervalo ahora es var global
        Dim v(Me.cmb_intervalos.SelectedItem - 1) As Integer 'Vector contador de frecuencias por intervalo
        Dim fe, marcaClase As Double
        Dim hayQueAgrupar As Boolean = False

        For index = 0 To tamMuestra - 1

            'Solucionar problema de que se sale del largo del vector.
            If Math.Truncate((Me.Grid1.Rows(index).Cells(1).Value - minimo) / tamIntervalo) >= Me.cmb_intervalos.SelectedItem Then
                v(Me.cmb_intervalos.SelectedItem - 1) += 1
            Else
                v(Math.Truncate((Me.Grid1.Rows(index).Cells(1).Value - minimo) / tamIntervalo)) += 1
            End If

        Next

        For index = 0 To Me.cmb_intervalos.SelectedItem - 1
            Dim inicioIntervalo = minimo + tamIntervalo * index
            Dim finIntervalo = minimo + tamIntervalo * (index + 1)

            Select Case dist
                Case distribucion.uniforme
                    fe = tamMuestra / Me.cmb_intervalos.SelectedItem

                Case distribucion.exponencial
                    'Probabilidad acumulada del intervalo superior menos la del inferior por tamaño de muestra
                    fe = ((1 - Math.Exp(-Me.txt_lambda2.Text * (minimo + tamIntervalo * (index + 1)))) - (1 - Math.Exp(-Me.txt_lambda2.Text * (minimo + tamIntervalo * index)))) * Me.txt_muestra2.Text

                Case distribucion.normal
                    marcaClase = minimo + tamIntervalo * (index + 0.5)
                    Dim desvEstandar As Double = Me.txt_desviacion3.Text
                    Dim media As Double = Me.txt_media3.Text
                    Dim fmc As Double = Math.Exp((-0.5) * ((marcaClase - media) / desvEstandar) ^ 2) / (desvEstandar * Math.Sqrt(Math.PI * 2))

                    fe = fmc * tamIntervalo * tamMuestra

                Case distribucion.poisson
                    Dim lambda As Double = Me.txt_lambda4.Text
                    'Carena, sumó los dos valores
                    Dim p As Double = (lambda ^ inicioIntervalo * Math.Exp(-lambda) / factorial(inicioIntervalo)) + (lambda ^ finIntervalo * Math.Exp(-lambda) / factorial(finIntervalo))
                    fe = Math.Round(p * tamMuestra)
            End Select

            acumChi += ((v(index) - fe) ^ 2) / fe 'Para comparar con chi tabulado

            If fe < 5 Then
                hayQueAgrupar = True
            End If

            Me.Grid2.Rows.Add()
            Me.Grid2.Rows(index).Cells(0).Value = "[" & inicioIntervalo & " ; " & finIntervalo & "]"
            Me.Grid2.Rows(index).Cells(1).Value = v(index)
            Me.Grid2.Rows(index).Cells(2).Value = fe
            Me.Grid2.Rows(index).Cells(3).Value = ((v(index) - fe) ^ 2) / fe
        Next

        If hayQueAgrupar Then
            Me.agruparGrid()
        End If

    End Sub

    Private Sub agruparGrid()
        Dim indexB As Integer = 0
        Dim fe As Double
        Dim lastre(3) As Double
        Dim inicioIntFinal As Double = 0

        'Limpio la acumulacion de los valores de Chi calculados para sumar de vuelta
        acumChi = 0

        For index = 0 To Me.cmb_intervalos.SelectedItem - 1

            Dim inicioIntervalo = minimo + tamIntervalo * index
            Dim finIntervalo = minimo + tamIntervalo * (index + 1)

            If lastre(0) = 0 Then
                lastre(0) = inicioIntervalo
            End If

            fe = Me.Grid2.Rows(index).Cells(2).Value + lastre(3)

            If fe > 5 Then
                Me.Grid3.Rows.Add()
                Me.Grid3.Rows(indexB).Cells(0).Value = "[" & lastre(0) & " ; " & finIntervalo & "]"
                Me.Grid3.Rows(indexB).Cells(1).Value = Me.Grid2.Rows(index).Cells(1).Value + lastre(2)
                Me.Grid3.Rows(indexB).Cells(2).Value = fe
                Me.Grid3.Rows(indexB).Cells(3).Value = ((Me.Grid3.Rows(indexB).Cells(1).Value - Me.Grid3.Rows(indexB).Cells(2).Value) ^ 2) / Me.Grid3.Rows(indexB).Cells(2).Value
                acumChi += Me.Grid3.Rows(indexB).Cells(3).Value
                indexB += 1
                inicioIntFinal = lastre(0)
                lastre(0) = 0

                lastre(1) = 0
                lastre(2) = 0
                lastre(3) = 0

            Else 'Es fe < 5
                'Si es la ultima fila de la grilla sin agrupar perderiamos el lastre por eso lo sumamos al anterior.
                lastre(2) += Me.Grid2.Rows(index).Cells(1).Value
                lastre(3) += Me.Grid2.Rows(index).Cells(2).Value

                If index = Me.cmb_intervalos.SelectedItem - 1 Then
                    Me.Grid3.Rows(indexB - 1).Cells(0).Value = "[" & inicioIntFinal & " ; " & finIntervalo & "]"
                    Me.Grid3.Rows(indexB - 1).Cells(1).Value = Me.Grid3.Rows(indexB - 1).Cells(1).Value + lastre(2)
                    Me.Grid3.Rows(indexB - 1).Cells(2).Value += fe
                    Me.Grid3.Rows(indexB - 1).Cells(3).Value = ((Me.Grid3.Rows(indexB - 1).Cells(1).Value - Me.Grid3.Rows(indexB - 1).Cells(2).Value) ^ 2) / Me.Grid3.Rows(indexB - 1).Cells(2).Value

                    'Esto soluciona que al sumar el ultimo item al penultimo se arruina la suma de acumChi, directamente leemos la columna y sumamos.
                    acumChi = 0
                    For indexx = 0 To Me.Grid3.Rows.Count() - 1
                        acumChi += Me.Grid3.Rows(indexx).Cells(3).Value
                    Next

                End If
            End If
        Next
    End Sub

    Private Sub compararChi(glibertad As Integer)
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

        Me.txt_chiTab.Text = v(glibertad)
        Me.txt_chiCal.Text = acumChi

        If v(glibertad) > acumChi Then

            Me.lbl_resp.Text = "Se acepta la hipótesis"
        Else
            Me.lbl_resp.Text = "Se rechaza la hipótesis"
        End If

    End Sub

    Private Sub cargarGraficoB()
        'El estilo del gráfico se edita en Propiedades, Series en la pestaña de diseño del form
        Me.Chart1.Series("fe").Points.Clear()
        Me.Chart1.Series("fo").Points.Clear()
        Dim aux As Double = 0
        For i = 0 To Me.Grid2.Rows.Count - 2
            Me.Chart1.Series("fe").Points.AddXY(Me.Grid2.Rows(i).Cells(0).Value, Me.Grid2.Rows(i).Cells(2).Value)
            Me.Chart1.Series("fo").Points.AddXY(Me.Grid2.Rows(i).Cells(0).Value, Me.Grid2.Rows(i).Cells(1).Value)
        Next

    End Sub

    Private Sub cmd_generar1_Click(sender As Object, e As EventArgs) Handles cmd_generar1.Click
        Me.cmd_generar1.Enabled = False
        Me.limpiarForm()

        Me.generarRND1()
        Me.cargarGrid2(Me.txt_muestra1.Text, distribucion.uniforme)
        Me.compararChi(Me.cmb_intervalos.SelectedItem() - 1)
        Me.cargarGraficoB()

        Me.cmd_generar1.Enabled = True
    End Sub

    Private Sub cmd_generar2_Click(sender As Object, e As EventArgs) Handles cmd_generar2.Click
        Me.cmd_generar2.Enabled = False
        Me.limpiarForm()

        Me.generarRND2()
        Me.cargarGrid2(Me.txt_muestra2.Text, distribucion.exponencial)
        Me.compararChi(Me.cmb_intervalos.SelectedItem() - 2)
        Me.cargarGraficoB()
        Me.cmd_generar2.Enabled = True
    End Sub

    Private Sub cmd_generar3_Click(sender As Object, e As EventArgs) Handles cmd_generar3.Click
        Me.cmd_generar3.Enabled = False
        Me.limpiarForm()

        Me.generarRND3()
        Me.cargarGrid2(Me.txt_muestra3.Text, distribucion.normal)
        Me.cargarGraficoB()
        Me.compararChi(Me.cmb_intervalos.SelectedItem() - 3)
        Me.cmd_generar3.Enabled = True
    End Sub

    Private Sub cmd_generar4_Click(sender As Object, e As EventArgs) Handles cmd_generar4.Click
        Me.cmd_generar4.Enabled = False
        Me.limpiarForm()

        Me.generarRND4()
        Me.cargarGrid2(Me.txt_muestra4.Text, distribucion.poisson)
        Me.cargarGraficoB()
        Me.compararChi(Me.cmb_intervalos.SelectedItem() - 2)
        Me.cmd_generar4.Enabled = True
    End Sub

    Private Function factorial(n As Integer) As ULong
        Dim ret As ULong = 1
        While n > 1
            ret *= n
            n -= 1
        End While
        Return ret
    End Function

    Private Function localRnd() As Double
        Dim ret As Double = Rnd()
        Me.lst_rnd.Items.Add(ret)
        Return ret
    End Function

    Private Sub limpiarForm()
        Me.Grid1.Rows.Clear()
        Me.Grid2.Rows.Clear()
        Me.Grid3.Rows.Clear()
        Me.lst_rnd.Items.Clear()
        Me.txt_chiCal.Clear()
        Me.txt_chiTab.Clear()
        acumChi = 0
    End Sub

End Class
