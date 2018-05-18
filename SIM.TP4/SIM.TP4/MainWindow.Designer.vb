<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_punto = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.spb_cant_simulaciones = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.spb_diasXsimulacion = New System.Windows.Forms.NumericUpDown()
        Me.cmb_docenas_reposicion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grb_no_stockout = New System.Windows.Forms.GroupBox()
        Me.txt_costo_stockout = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grb_si_stockout = New System.Windows.Forms.GroupBox()
        Me.txt_costo_comprar_docena_stockout = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chb_reponer_stock_out = New System.Windows.Forms.CheckBox()
        Me.txt_reintegroXsobrantes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.spb_reposicion_inicial = New System.Windows.Forms.NumericUpDown()
        Me.spb_cant_filas_visibles = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grb_simulaciones = New System.Windows.Forms.GroupBox()
        Me.txt_ganancia_promedio = New System.Windows.Forms.TextBox()
        Me.grd_simulacion = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_nro_simulacion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_ganancia_promedio_general = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_simular = New System.Windows.Forms.Button()
        CType(Me.spb_cant_simulaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spb_diasXsimulacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grb_no_stockout.SuspendLayout()
        Me.grb_si_stockout.SuspendLayout()
        CType(Me.spb_reposicion_inicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spb_cant_filas_visibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_simulaciones.SuspendLayout()
        CType(Me.grd_simulacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Punto"
        '
        'cmb_punto
        '
        Me.cmb_punto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_punto.FormattingEnabled = True
        Me.cmb_punto.Location = New System.Drawing.Point(194, 27)
        Me.cmb_punto.Name = "cmb_punto"
        Me.cmb_punto.Size = New System.Drawing.Size(121, 21)
        Me.cmb_punto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad de simulaciones"
        '
        'spb_cant_simulaciones
        '
        Me.spb_cant_simulaciones.Location = New System.Drawing.Point(195, 58)
        Me.spb_cant_simulaciones.Maximum = New Decimal(New Integer() {-1981284352, -1966660860, 0, 0})
        Me.spb_cant_simulaciones.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spb_cant_simulaciones.Name = "spb_cant_simulaciones"
        Me.spb_cant_simulaciones.Size = New System.Drawing.Size(120, 20)
        Me.spb_cant_simulaciones.TabIndex = 3
        Me.spb_cant_simulaciones.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Días por simulación"
        '
        'spb_diasXsimulacion
        '
        Me.spb_diasXsimulacion.Location = New System.Drawing.Point(195, 84)
        Me.spb_diasXsimulacion.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.spb_diasXsimulacion.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.spb_diasXsimulacion.Name = "spb_diasXsimulacion"
        Me.spb_diasXsimulacion.Size = New System.Drawing.Size(120, 20)
        Me.spb_diasXsimulacion.TabIndex = 5
        Me.spb_diasXsimulacion.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'cmb_docenas_reposicion
        '
        Me.cmb_docenas_reposicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_docenas_reposicion.FormattingEnabled = True
        Me.cmb_docenas_reposicion.Location = New System.Drawing.Point(194, 110)
        Me.cmb_docenas_reposicion.Name = "cmb_docenas_reposicion"
        Me.cmb_docenas_reposicion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_docenas_reposicion.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Docenas reposición diaria"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grb_no_stockout)
        Me.GroupBox1.Controls.Add(Me.grb_si_stockout)
        Me.GroupBox1.Controls.Add(Me.chb_reponer_stock_out)
        Me.GroupBox1.Location = New System.Drawing.Point(356, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 149)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock-out"
        '
        'grb_no_stockout
        '
        Me.grb_no_stockout.Controls.Add(Me.txt_costo_stockout)
        Me.grb_no_stockout.Controls.Add(Me.Label6)
        Me.grb_no_stockout.Location = New System.Drawing.Point(7, 88)
        Me.grb_no_stockout.Name = "grb_no_stockout"
        Me.grb_no_stockout.Size = New System.Drawing.Size(216, 55)
        Me.grb_no_stockout.TabIndex = 11
        Me.grb_no_stockout.TabStop = False
        Me.grb_no_stockout.Text = "No"
        '
        'txt_costo_stockout
        '
        Me.txt_costo_stockout.Location = New System.Drawing.Point(105, 27)
        Me.txt_costo_stockout.Name = "txt_costo_stockout"
        Me.txt_costo_stockout.Size = New System.Drawing.Size(100, 20)
        Me.txt_costo_stockout.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Costo de unidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "perdida de vender"
        '
        'grb_si_stockout
        '
        Me.grb_si_stockout.Controls.Add(Me.txt_costo_comprar_docena_stockout)
        Me.grb_si_stockout.Controls.Add(Me.Label5)
        Me.grb_si_stockout.Location = New System.Drawing.Point(7, 43)
        Me.grb_si_stockout.Name = "grb_si_stockout"
        Me.grb_si_stockout.Size = New System.Drawing.Size(216, 43)
        Me.grb_si_stockout.TabIndex = 1
        Me.grb_si_stockout.TabStop = False
        Me.grb_si_stockout.Text = "Sí"
        '
        'txt_costo_comprar_docena_stockout
        '
        Me.txt_costo_comprar_docena_stockout.Location = New System.Drawing.Point(105, 19)
        Me.txt_costo_comprar_docena_stockout.Name = "txt_costo_comprar_docena_stockout"
        Me.txt_costo_comprar_docena_stockout.Size = New System.Drawing.Size(100, 20)
        Me.txt_costo_comprar_docena_stockout.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Costo docena"
        '
        'chb_reponer_stock_out
        '
        Me.chb_reponer_stock_out.AutoSize = True
        Me.chb_reponer_stock_out.Location = New System.Drawing.Point(7, 20)
        Me.chb_reponer_stock_out.Name = "chb_reponer_stock_out"
        Me.chb_reponer_stock_out.Size = New System.Drawing.Size(123, 17)
        Me.chb_reponer_stock_out.TabIndex = 0
        Me.chb_reponer_stock_out.Text = "¿Se puede reponer?"
        Me.chb_reponer_stock_out.UseVisualStyleBackColor = True
        '
        'txt_reintegroXsobrantes
        '
        Me.txt_reintegroXsobrantes.Location = New System.Drawing.Point(195, 189)
        Me.txt_reintegroXsobrantes.Name = "txt_reintegroXsobrantes"
        Me.txt_reintegroXsobrantes.Size = New System.Drawing.Size(120, 20)
        Me.txt_reintegroXsobrantes.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Reintegro por unidad sobrante"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Reposición inicial"
        '
        'spb_reposicion_inicial
        '
        Me.spb_reposicion_inicial.Location = New System.Drawing.Point(195, 137)
        Me.spb_reposicion_inicial.Name = "spb_reposicion_inicial"
        Me.spb_reposicion_inicial.Size = New System.Drawing.Size(120, 20)
        Me.spb_reposicion_inicial.TabIndex = 11
        '
        'spb_cant_filas_visibles
        '
        Me.spb_cant_filas_visibles.Location = New System.Drawing.Point(195, 163)
        Me.spb_cant_filas_visibles.Maximum = New Decimal(New Integer() {1874919424, 2328306, 0, 0})
        Me.spb_cant_filas_visibles.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.spb_cant_filas_visibles.Name = "spb_cant_filas_visibles"
        Me.spb_cant_filas_visibles.Size = New System.Drawing.Size(120, 20)
        Me.spb_cant_filas_visibles.TabIndex = 12
        Me.spb_cant_filas_visibles.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cantidad de filas visibles"
        '
        'grb_simulaciones
        '
        Me.grb_simulaciones.Controls.Add(Me.txt_ganancia_promedio)
        Me.grb_simulaciones.Controls.Add(Me.grd_simulacion)
        Me.grb_simulaciones.Controls.Add(Me.Label11)
        Me.grb_simulaciones.Controls.Add(Me.cmb_nro_simulacion)
        Me.grb_simulaciones.Controls.Add(Me.Label10)
        Me.grb_simulaciones.Location = New System.Drawing.Point(13, 221)
        Me.grb_simulaciones.Name = "grb_simulaciones"
        Me.grb_simulaciones.Size = New System.Drawing.Size(1206, 373)
        Me.grb_simulaciones.TabIndex = 14
        Me.grb_simulaciones.TabStop = False
        Me.grb_simulaciones.Text = "Simulaciones"
        '
        'txt_ganancia_promedio
        '
        Me.txt_ganancia_promedio.Location = New System.Drawing.Point(686, 24)
        Me.txt_ganancia_promedio.Name = "txt_ganancia_promedio"
        Me.txt_ganancia_promedio.Size = New System.Drawing.Size(100, 20)
        Me.txt_ganancia_promedio.TabIndex = 12
        '
        'grd_simulacion
        '
        Me.grd_simulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_simulacion.Location = New System.Drawing.Point(7, 59)
        Me.grd_simulacion.Name = "grd_simulacion"
        Me.grd_simulacion.Size = New System.Drawing.Size(1193, 308)
        Me.grd_simulacion.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(553, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Ganancia promedio diaria"
        '
        'cmb_nro_simulacion
        '
        Me.cmb_nro_simulacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nro_simulacion.FormattingEnabled = True
        Me.cmb_nro_simulacion.Location = New System.Drawing.Point(56, 19)
        Me.cmb_nro_simulacion.Name = "cmb_nro_simulacion"
        Me.cmb_nro_simulacion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_nro_simulacion.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Número"
        '
        'txt_ganancia_promedio_general
        '
        Me.txt_ganancia_promedio_general.Location = New System.Drawing.Point(699, 600)
        Me.txt_ganancia_promedio_general.Name = "txt_ganancia_promedio_general"
        Me.txt_ganancia_promedio_general.Size = New System.Drawing.Size(100, 20)
        Me.txt_ganancia_promedio_general.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(528, 603)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Ganancia promedio diaria general"
        '
        'btn_simular
        '
        Me.btn_simular.Location = New System.Drawing.Point(387, 174)
        Me.btn_simular.Name = "btn_simular"
        Me.btn_simular.Size = New System.Drawing.Size(75, 23)
        Me.btn_simular.TabIndex = 13
        Me.btn_simular.Text = "Simular"
        Me.btn_simular.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 716)
        Me.Controls.Add(Me.txt_reintegroXsobrantes)
        Me.Controls.Add(Me.btn_simular)
        Me.Controls.Add(Me.txt_ganancia_promedio_general)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grb_simulaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.spb_cant_filas_visibles)
        Me.Controls.Add(Me.spb_reposicion_inicial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_docenas_reposicion)
        Me.Controls.Add(Me.spb_diasXsimulacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.spb_cant_simulaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_punto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainWindow"
        Me.Text = "SIM TP4"
        CType(Me.spb_cant_simulaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spb_diasXsimulacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grb_no_stockout.ResumeLayout(False)
        Me.grb_no_stockout.PerformLayout()
        Me.grb_si_stockout.ResumeLayout(False)
        Me.grb_si_stockout.PerformLayout()
        CType(Me.spb_reposicion_inicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spb_cant_filas_visibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_simulaciones.ResumeLayout(False)
        Me.grb_simulaciones.PerformLayout()
        CType(Me.grd_simulacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_punto As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents spb_cant_simulaciones As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents spb_diasXsimulacion As NumericUpDown
    Friend WithEvents cmb_docenas_reposicion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grb_si_stockout As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chb_reponer_stock_out As CheckBox
    Friend WithEvents grb_no_stockout As GroupBox
    Friend WithEvents txt_costo_stockout As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_costo_comprar_docena_stockout As TextBox
    Friend WithEvents txt_reintegroXsobrantes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents spb_reposicion_inicial As NumericUpDown
    Friend WithEvents spb_cant_filas_visibles As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents grb_simulaciones As GroupBox
    Friend WithEvents txt_ganancia_promedio As TextBox
    Friend WithEvents grd_simulacion As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_nro_simulacion As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txt_ganancia_promedio_general As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_simular As Button
End Class
