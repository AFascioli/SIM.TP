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

    End Sub

    Private Sub cmd_generar_Click(sender As Object, e As EventArgs) Handles cmd_generar.Click
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

        Next

        numerosChi = numeros
        contadorChi = contadorInter

    End Sub

    Private Sub cargarTabla2()

        For index = 0 To contadorChi.Length - 1

            Dim y = contadorChi(index)
            If IsNothing(y) Then
                y = 0
            End If
            Me.grid2.Rows.Add()
            Me.grid2.Rows(index).Cells(0).Value = index
            Me.grid2.Rows(index).Cells(1).Value = y
            Me.grid2.Rows(index).Cells(2).Value = numerosChi.Length / contadorChi.Length
            Me.grid2.Rows(index).Cells(3).Value = ((numerosChi(index) - numerosChi.Length / contadorChi.Length) ^ 2) / (numerosChi.Length / contadorChi.Length)
        Next

    End Sub


End Class
