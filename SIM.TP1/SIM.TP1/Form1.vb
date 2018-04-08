Public Class TrabajoPractico1

    Dim a, c, m, seed As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function congruencialMixto(a As Double, c As Double, m As Double, x As Double)

        Dim r, yi As Double
        Dim res(2) As Double

        yi = (a * x + c) Mod m

        r = yi / m

        res(0) = r
        res(1) = yi

        Return res

    End Function


    Private Sub cargarTabla()
        Dim vector(2) As Double
        Dim r As Double = Me.seed

        For index = 0 To 19
            vector = Me.congruencialMixto(Me.a, Me.c, Me.m, r)
            Me.grid1.Rows.Add()
            Me.grid1.Rows(index).Cells(0).Value = index
            Me.grid1.Rows(index).Cells(1).Value = vector(0)
            r = vector(1)
        Next

    End Sub

    Private Sub cmd_generar_Click(sender As Object, e As EventArgs) Handles cmd_generar.Click
        a = txt_a.Text
        c = txt_c.Text
        m = txt_m.Text
        seed = txt_seed.Text

        cargarTabla()

    End Sub

    Private Sub cmd_siguiente_Click(sender As Object, e As EventArgs) Handles cmd_siguiente.Click

    End Sub
End Class
