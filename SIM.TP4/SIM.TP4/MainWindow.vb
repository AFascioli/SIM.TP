Public Class MainWindow
    Dim sim As Simulador

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grb_si_stockout.Enabled = False
        cmb_docenas_reposicion.Items.Add("Venta día anterior")
        cmb_docenas_reposicion.Items.Add("7")
        cmb_docenas_reposicion.Items.Add("8")
        cmb_docenas_reposicion.Items.Add("9")

        cmb_punto.Items.Add("A")
        cmb_punto.Items.Add("B9")
        cmb_punto.Items.Add("B7")
        cmb_punto.Items.Add("C")
        cmb_punto.Items.Add("D")
        cmb_punto.Items.Add("E")
        cmb_punto.Items.Add("F")
        cmb_punto.SelectedIndex = 0
    End Sub

    Private Sub cmb_docenas_reposicion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_docenas_reposicion.SelectedIndexChanged
        spb_reposicion_inicial.Enabled = cmb_docenas_reposicion.SelectedIndex = 0
    End Sub

    Private Sub chb_reponer_stock_out_CheckedChanged(sender As Object, e As EventArgs) Handles chb_reponer_stock_out.CheckedChanged
        Dim si As Boolean = chb_reponer_stock_out.Checked
        grb_no_stockout.Enabled = Not si
        grb_si_stockout.Enabled = si
    End Sub

    Private Sub cmb_punto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_punto.SelectedIndexChanged
        Dim index As Integer = cmb_punto.SelectedIndex


        If 0 <= index And index < 4 Then 'Puntos A, B y C
            cmb_docenas_reposicion.SelectedIndex = {2, 3, 1, 0}(index) 'so vo hardcoding?
            chb_reponer_stock_out.Checked = False
            txt_costo_stockout.Text = 0
            txt_reintegroXsobrantes.Text = 0.1
            spb_diasXsimulacion.Value = 20
            If index = 3 Then
                spb_reposicion_inicial.Value = 8
            End If
        ElseIf index = 4 Then 'Punto D
            chb_reponer_stock_out.Checked = True
            txt_costo_comprar_docena_stockout.Text = 11

        ElseIf index = 5 Then 'Punto E
            spb_cant_simulaciones.Value = 100
            spb_diasXsimulacion.Value = 90
        ElseIf index = 6 Then 'Punto F
            txt_reintegroXsobrantes.Text = 0
            chb_reponer_stock_out.Checked = False
            txt_costo_stockout.Text = 0.1
        End If

    End Sub

    Private Sub btn_simular_Click(sender As Object, e As EventArgs) Handles btn_simular.Click
        Dim parametroStockout As Double
        If chb_reponer_stock_out.Checked Then
            parametroStockout = Double.Parse(txt_costo_comprar_docena_stockout.Text)
        Else
            parametroStockout = Double.Parse(txt_costo_stockout.Text)
        End If

        Dim docenas As Integer
        Dim reposicionConstante As Boolean = cmb_docenas_reposicion.SelectedIndex <> 0
        If Not reposicionConstante Then
            docenas = spb_reposicion_inicial.Value
        Else
            docenas = {7, 8, 9}(cmb_docenas_reposicion.SelectedIndex - 1)
        End If



        sim = New Simulador(spb_cant_simulaciones.Value, spb_diasXsimulacion.Value, spb_cant_filas_visibles.Value,
                               reposicionConstante, docenas, Double.Parse(txt_reintegroXsobrantes.Text),
                               chb_reponer_stock_out.Checked, parametroStockout)
        sim.inicializarTabla(Me.grd_simulacion)
        sim.simular()
        sim.cargarFilasTabla(Me.grd_simulacion, 0)

        cmb_nro_simulacion.Items.Clear()
        cmb_nro_simulacion.SelectedIndex = -1
        For i As Integer = 0 To spb_cant_simulaciones.Value - 1
            cmb_nro_simulacion.Items.Add(i + 1)
        Next
        cmb_nro_simulacion.SelectedIndex = 0
        txt_ganancia_promedio_general.Text = sim.calcGananciaPromedioGeneral()

    End Sub

    Private Sub cmb_nro_simulacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_nro_simulacion.SelectedIndexChanged
        Dim index As Integer = cmb_nro_simulacion.SelectedIndex
        If index >= 0 Then
            txt_ganancia_promedio.Text = sim.calcGananciaPromedio(index)
            sim.cargarFilasTabla(Me.grd_simulacion, index)
        End If

    End Sub
End Class
