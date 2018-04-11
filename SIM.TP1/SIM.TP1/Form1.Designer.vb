<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrabajoPractico1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_seed = New System.Windows.Forms.TextBox()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_siguiente = New System.Windows.Forms.Button()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.lbl_c = New System.Windows.Forms.Label()
        Me.lbl_seed = New System.Windows.Forms.Label()
        Me.txt_m = New System.Windows.Forms.TextBox()
        Me.lbl_m = New System.Windows.Forms.Label()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_intervalos = New System.Windows.Forms.ComboBox()
        Me.grid3 = New System.Windows.Forms.DataGridView()
        Me.random = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid2 = New System.Windows.Forms.DataGridView()
        Me.k = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chiCuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_chiTab = New System.Windows.Forms.TextBox()
        Me.txt_chiCal = New System.Windows.Forms.TextBox()
        Me.txt_cantidadNros = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nrosAleatorios = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_seedC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_generarC = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_mC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cC = New System.Windows.Forms.TextBox()
        Me.txt_aC = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1673, 955)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_seed)
        Me.TabPage1.Controls.Add(Me.grid1)
        Me.TabPage1.Controls.Add(Me.cmd_siguiente)
        Me.TabPage1.Controls.Add(Me.lbl_a)
        Me.TabPage1.Controls.Add(Me.cmd_generar)
        Me.TabPage1.Controls.Add(Me.lbl_c)
        Me.TabPage1.Controls.Add(Me.lbl_seed)
        Me.TabPage1.Controls.Add(Me.txt_m)
        Me.TabPage1.Controls.Add(Me.lbl_m)
        Me.TabPage1.Controls.Add(Me.txt_c)
        Me.TabPage1.Controls.Add(Me.txt_a)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1665, 922)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Punto a"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_seed
        '
        Me.txt_seed.Location = New System.Drawing.Point(58, 8)
        Me.txt_seed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_seed.Name = "txt_seed"
        Me.txt_seed.Size = New System.Drawing.Size(148, 26)
        Me.txt_seed.TabIndex = 1
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.indice, Me.numero})
        Me.grid1.Location = New System.Drawing.Point(33, 209)
        Me.grid1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(892, 452)
        Me.grid1.TabIndex = 2
        '
        'indice
        '
        Me.indice.HeaderText = "Indice"
        Me.indice.Name = "indice"
        Me.indice.ReadOnly = True
        '
        'numero
        '
        Me.numero.HeaderText = "Numero"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'cmd_siguiente
        '
        Me.cmd_siguiente.Location = New System.Drawing.Point(813, 165)
        Me.cmd_siguiente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_siguiente.Name = "cmd_siguiente"
        Me.cmd_siguiente.Size = New System.Drawing.Size(112, 35)
        Me.cmd_siguiente.TabIndex = 3
        Me.cmd_siguiente.Text = "Siguiente"
        Me.cmd_siguiente.UseVisualStyleBackColor = True
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.Location = New System.Drawing.Point(28, 55)
        Me.lbl_a.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(18, 20)
        Me.lbl_a.TabIndex = 0
        Me.lbl_a.Text = "a"
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(46, 165)
        Me.cmd_generar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(112, 35)
        Me.cmd_generar.TabIndex = 3
        Me.cmd_generar.Text = "Generar"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'lbl_c
        '
        Me.lbl_c.AutoSize = True
        Me.lbl_c.Location = New System.Drawing.Point(28, 92)
        Me.lbl_c.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_c.Name = "lbl_c"
        Me.lbl_c.Size = New System.Drawing.Size(17, 20)
        Me.lbl_c.TabIndex = 0
        Me.lbl_c.Text = "c"
        '
        'lbl_seed
        '
        Me.lbl_seed.AutoSize = True
        Me.lbl_seed.Location = New System.Drawing.Point(2, 18)
        Me.lbl_seed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_seed.Name = "lbl_seed"
        Me.lbl_seed.Size = New System.Drawing.Size(47, 20)
        Me.lbl_seed.TabIndex = 0
        Me.lbl_seed.Text = "Seed"
        '
        'txt_m
        '
        Me.txt_m.Location = New System.Drawing.Point(58, 115)
        Me.txt_m.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.Size = New System.Drawing.Size(148, 26)
        Me.txt_m.TabIndex = 1
        '
        'lbl_m
        '
        Me.lbl_m.AutoSize = True
        Me.lbl_m.Location = New System.Drawing.Point(28, 128)
        Me.lbl_m.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_m.Name = "lbl_m"
        Me.lbl_m.Size = New System.Drawing.Size(22, 20)
        Me.lbl_m.TabIndex = 0
        Me.lbl_m.Text = "m"
        '
        'txt_c
        '
        Me.txt_c.Location = New System.Drawing.Point(58, 82)
        Me.txt_c.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(148, 26)
        Me.txt_c.TabIndex = 1
        '
        'txt_a
        '
        Me.txt_a.Location = New System.Drawing.Point(58, 45)
        Me.txt_a.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(148, 26)
        Me.txt_a.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.cmb_intervalos)
        Me.TabPage2.Controls.Add(Me.grid3)
        Me.TabPage2.Controls.Add(Me.grid4)
        Me.TabPage2.Controls.Add(Me.grid2)
        Me.TabPage2.Controls.Add(Me.txt_chiTab)
        Me.TabPage2.Controls.Add(Me.txt_chiCal)
        Me.TabPage2.Controls.Add(Me.txt_cantidadNros)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.lbl_resultado)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.lbl_nrosAleatorios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1665, 922)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Punto b"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(9, 555)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "DrawSideBySide=True, EmptyPointValue=Zero, LabelStyle=Right"
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "fo"
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Red
        Series2.IsXValueIndexed = True
        Series2.Legend = "Legend1"
        Series2.Name = "fe"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1140, 326)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 51)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_intervalos
        '
        Me.cmb_intervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_intervalos.FormattingEnabled = True
        Me.cmb_intervalos.Location = New System.Drawing.Point(230, 125)
        Me.cmb_intervalos.Name = "cmb_intervalos"
        Me.cmb_intervalos.Size = New System.Drawing.Size(121, 28)
        Me.cmb_intervalos.TabIndex = 3
        '
        'grid3
        '
        Me.grid3.AllowUserToAddRows = False
        Me.grid3.AllowUserToDeleteRows = False
        Me.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.random})
        Me.grid3.Location = New System.Drawing.Point(749, 182)
        Me.grid3.Name = "grid3"
        Me.grid3.ReadOnly = True
        Me.grid3.RowTemplate.Height = 28
        Me.grid3.Size = New System.Drawing.Size(160, 366)
        Me.grid3.TabIndex = 2
        '
        'random
        '
        Me.random.HeaderText = "Random"
        Me.random.Name = "random"
        Me.random.ReadOnly = True
        '
        'grid4
        '
        Me.grid4.AllowUserToAddRows = False
        Me.grid4.AllowUserToDeleteRows = False
        Me.grid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.grid4.Location = New System.Drawing.Point(948, 182)
        Me.grid4.Name = "grid4"
        Me.grid4.ReadOnly = True
        Me.grid4.RowTemplate.Height = 28
        Me.grid4.Size = New System.Drawing.Size(684, 366)
        Me.grid4.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "k"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Frecuencia obeservada"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Frecuencia esperada"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "(fo-fe)2/fe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'grid2
        '
        Me.grid2.AllowUserToAddRows = False
        Me.grid2.AllowUserToDeleteRows = False
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.k, Me.fo, Me.fe, Me.chiCuadrado})
        Me.grid2.Location = New System.Drawing.Point(34, 182)
        Me.grid2.Name = "grid2"
        Me.grid2.ReadOnly = True
        Me.grid2.RowTemplate.Height = 28
        Me.grid2.Size = New System.Drawing.Size(684, 366)
        Me.grid2.TabIndex = 2
        '
        'k
        '
        Me.k.HeaderText = "k"
        Me.k.Name = "k"
        Me.k.ReadOnly = True
        '
        'fo
        '
        Me.fo.HeaderText = "Frecuencia obeservada"
        Me.fo.Name = "fo"
        Me.fo.ReadOnly = True
        '
        'fe
        '
        Me.fe.HeaderText = "Frecuencia esperada"
        Me.fe.Name = "fe"
        Me.fe.ReadOnly = True
        '
        'chiCuadrado
        '
        Me.chiCuadrado.HeaderText = "(fo-fe)2/fe"
        Me.chiCuadrado.Name = "chiCuadrado"
        Me.chiCuadrado.ReadOnly = True
        '
        'txt_chiTab
        '
        Me.txt_chiTab.Location = New System.Drawing.Point(1107, 77)
        Me.txt_chiTab.Name = "txt_chiTab"
        Me.txt_chiTab.Size = New System.Drawing.Size(100, 26)
        Me.txt_chiTab.TabIndex = 1
        '
        'txt_chiCal
        '
        Me.txt_chiCal.Location = New System.Drawing.Point(1107, 45)
        Me.txt_chiCal.Name = "txt_chiCal"
        Me.txt_chiCal.Size = New System.Drawing.Size(100, 26)
        Me.txt_chiCal.TabIndex = 1
        '
        'txt_cantidadNros
        '
        Me.txt_cantidadNros.Location = New System.Drawing.Point(230, 45)
        Me.txt_cantidadNros.Name = "txt_cantidadNros"
        Me.txt_cantidadNros.Size = New System.Drawing.Size(100, 26)
        Me.txt_cantidadNros.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cantidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "intervalos: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(907, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Chi-Cuadrado tabulado"
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(731, 64)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(14, 20)
        Me.lbl_resultado.TabIndex = 0
        Me.lbl_resultado.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(907, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Chi-Cuadrado calculado"
        '
        'lbl_nrosAleatorios
        '
        Me.lbl_nrosAleatorios.AutoSize = True
        Me.lbl_nrosAleatorios.Location = New System.Drawing.Point(30, 31)
        Me.lbl_nrosAleatorios.Name = "lbl_nrosAleatorios"
        Me.lbl_nrosAleatorios.Size = New System.Drawing.Size(170, 40)
        Me.lbl_nrosAleatorios.TabIndex = 0
        Me.lbl_nrosAleatorios.Text = "Ingrese la cantidad de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "numeros aleatorios: "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txt_seedC)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.cmd_generarC)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txt_mC)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.txt_cC)
        Me.TabPage3.Controls.Add(Me.txt_aC)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1665, 922)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Punto c"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_seedC
        '
        Me.txt_seedC.Location = New System.Drawing.Point(84, 21)
        Me.txt_seedC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_seedC.Name = "txt_seedC"
        Me.txt_seedC.Size = New System.Drawing.Size(148, 26)
        Me.txt_seedC.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "a"
        '
        'cmd_generarC
        '
        Me.cmd_generarC.Location = New System.Drawing.Point(72, 178)
        Me.cmd_generarC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmd_generarC.Name = "cmd_generarC"
        Me.cmd_generarC.Size = New System.Drawing.Size(112, 35)
        Me.cmd_generarC.TabIndex = 12
        Me.cmd_generarC.Text = "Generar"
        Me.cmd_generarC.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "c"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Seed"
        '
        'txt_mC
        '
        Me.txt_mC.Location = New System.Drawing.Point(84, 128)
        Me.txt_mC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_mC.Name = "txt_mC"
        Me.txt_mC.Size = New System.Drawing.Size(148, 26)
        Me.txt_mC.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 141)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "m"
        '
        'txt_cC
        '
        Me.txt_cC.Location = New System.Drawing.Point(84, 95)
        Me.txt_cC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cC.Name = "txt_cC"
        Me.txt_cC.Size = New System.Drawing.Size(148, 26)
        Me.txt_cC.TabIndex = 10
        '
        'txt_aC
        '
        Me.txt_aC.Location = New System.Drawing.Point(84, 58)
        Me.txt_aC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_aC.Name = "txt_aC"
        Me.txt_aC.Size = New System.Drawing.Size(148, 26)
        Me.txt_aC.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(780, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 51)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Play"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(569, 153)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.Location = New System.Drawing.Point(373, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(684, 366)
        Me.DataGridView1.TabIndex = 16
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "k"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Frecuencia obeservada"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Frecuencia esperada"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "(fo-fe)2/fe"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(569, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(369, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 40)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Ingrese la cantidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "intervalos: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(369, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 40)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Ingrese la cantidad de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "numeros aleatorios: "
        '
        'TrabajoPractico1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1688, 1025)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TrabajoPractico1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_seed As TextBox
    Friend WithEvents grid1 As DataGridView
    Friend WithEvents indice As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents cmd_siguiente As Button
    Friend WithEvents lbl_a As Label
    Friend WithEvents cmd_generar As Button
    Friend WithEvents lbl_c As Label
    Friend WithEvents lbl_seed As Label
    Friend WithEvents txt_m As TextBox
    Friend WithEvents lbl_m As Label
    Friend WithEvents txt_c As TextBox
    Friend WithEvents txt_a As TextBox
    Friend WithEvents txt_cantidadNros As TextBox
    Friend WithEvents lbl_nrosAleatorios As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grid2 As DataGridView
    Friend WithEvents k As DataGridViewTextBoxColumn
    Friend WithEvents fo As DataGridViewTextBoxColumn
    Friend WithEvents fe As DataGridViewTextBoxColumn
    Friend WithEvents chiCuadrado As DataGridViewTextBoxColumn
    Friend WithEvents cmb_intervalos As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents txt_chiCal As TextBox
    Friend WithEvents grid3 As DataGridView
    Friend WithEvents random As DataGridViewTextBoxColumn
    Friend WithEvents txt_chiTab As TextBox
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grid4 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_seedC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmd_generarC As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_mC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cC As TextBox
    Friend WithEvents txt_aC As TextBox
End Class
