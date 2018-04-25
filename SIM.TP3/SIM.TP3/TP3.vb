Public Class TP3
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_intervalos.Items.Add("5")
        cmb_intervalos.Items.Add("10")
        cmb_intervalos.Items.Add("20")
    End Sub

    Private Function distUniforme(A As Double, B As Double)
        Dim res As Double

        res = A + Rnd() * (B - A)
        Return res
    End Function

    'Exponencial y Poisson no tienen que generar negativos.

    Private Function distExponencial(lambda As Double)
        Dim res As Double

        res = (-1 / lambda) * Math.Log(1 - Rnd())
        Return res
    End Function

    Private Function distNormal(media As Double, desviacion As Double)
        Dim res(1) As Double
        Dim rnd1 As Double = Rnd()
        Dim rnd2 As Double = Rnd()

        res(0) = (Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2)) * desviacion + media
        res(1) = (Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Sin(2 * Math.PI * rnd2)) * desviacion + media
        Return res
    End Function

    Private Function distPoisson(lambda As Double)
        Dim P As Double = 1
        Dim X As Double = -1
        Dim A As Double = Math.Exp(-lambda)

        Do
            P = P * Rnd()
            X += 1
        Loop While (P >= A)

        Return X
    End Function

    Private Sub agregarFilaGrid(index As Integer, rnd As Double)

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

    Private Sub cmd_generar1_Click(sender As Object, e As EventArgs) Handles cmd_generar1.Click
        Me.Grid1.Rows.Clear()
        Me.generarRND1()

        'Me.graficar(1)
        'Me.compararChi(1)
    End Sub

    Private Sub cargarGrid21()

        Dim tamIntervalo As Double = (Me.txt_muestra1.Text) / Me.cmb_intervalos.SelectedValue

        For index = 0 To Me.cmb_intervalos.SelectedValue - 1

        Next

    End Sub

    Private Sub cmd_generar2_Click(sender As Object, e As EventArgs) Handles cmd_generar2.Click
        Me.Grid1.Rows.Clear()
        Me.generarRND2()
    End Sub

    Private Sub cmd_generar3_Click(sender As Object, e As EventArgs) Handles cmd_generar3.Click
        Me.Grid1.Rows.Clear()
        Me.generarRND3()
    End Sub

    Private Sub cmd_generar4_Click(sender As Object, e As EventArgs) Handles cmd_generar4.Click
        Me.Grid1.Rows.Clear()
        Me.generarRND4()
    End Sub
End Class
