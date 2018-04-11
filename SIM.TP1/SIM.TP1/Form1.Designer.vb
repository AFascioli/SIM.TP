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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_intervalos = New System.Windows.Forms.ComboBox()
        Me.grid2 = New System.Windows.Forms.DataGridView()
        Me.k = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chiCuadrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_cantidadNros = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nrosAleatorios = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 8)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(861, 621)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(853, 595)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_seed
        '
        Me.txt_seed.Location = New System.Drawing.Point(39, 5)
        Me.txt_seed.Name = "txt_seed"
        Me.txt_seed.Size = New System.Drawing.Size(100, 20)
        Me.txt_seed.TabIndex = 1
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.indice, Me.numero})
        Me.grid1.Location = New System.Drawing.Point(22, 136)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(595, 294)
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
        Me.cmd_siguiente.Location = New System.Drawing.Point(542, 107)
        Me.cmd_siguiente.Name = "cmd_siguiente"
        Me.cmd_siguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_siguiente.TabIndex = 3
        Me.cmd_siguiente.Text = "Siguiente"
        Me.cmd_siguiente.UseVisualStyleBackColor = True
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.Location = New System.Drawing.Point(19, 36)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(13, 13)
        Me.lbl_a.TabIndex = 0
        Me.lbl_a.Text = "a"
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(31, 107)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generar.TabIndex = 3
        Me.cmd_generar.Text = "Generar"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'lbl_c
        '
        Me.lbl_c.AutoSize = True
        Me.lbl_c.Location = New System.Drawing.Point(19, 60)
        Me.lbl_c.Name = "lbl_c"
        Me.lbl_c.Size = New System.Drawing.Size(13, 13)
        Me.lbl_c.TabIndex = 0
        Me.lbl_c.Text = "c"
        '
        'lbl_seed
        '
        Me.lbl_seed.AutoSize = True
        Me.lbl_seed.Location = New System.Drawing.Point(1, 12)
        Me.lbl_seed.Name = "lbl_seed"
        Me.lbl_seed.Size = New System.Drawing.Size(32, 13)
        Me.lbl_seed.TabIndex = 0
        Me.lbl_seed.Text = "Seed"
        '
        'txt_m
        '
        Me.txt_m.Location = New System.Drawing.Point(39, 75)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.Size = New System.Drawing.Size(100, 20)
        Me.txt_m.TabIndex = 1
        '
        'lbl_m
        '
        Me.lbl_m.AutoSize = True
        Me.lbl_m.Location = New System.Drawing.Point(19, 83)
        Me.lbl_m.Name = "lbl_m"
        Me.lbl_m.Size = New System.Drawing.Size(15, 13)
        Me.lbl_m.TabIndex = 0
        Me.lbl_m.Text = "m"
        '
        'txt_c
        '
        Me.txt_c.Location = New System.Drawing.Point(39, 53)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(100, 20)
        Me.txt_c.TabIndex = 1
        '
        'txt_a
        '
        Me.txt_a.Location = New System.Drawing.Point(39, 29)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(100, 20)
        Me.txt_a.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.cmb_intervalos)
        Me.TabPage2.Controls.Add(Me.grid2)
        Me.TabPage2.Controls.Add(Me.txt_cantidadNros)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lbl_nrosAleatorios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(853, 595)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 42)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmb_intervalos
        '
        Me.cmb_intervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_intervalos.FormattingEnabled = True
        Me.cmb_intervalos.Location = New System.Drawing.Point(153, 81)
        Me.cmb_intervalos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_intervalos.Name = "cmb_intervalos"
        Me.cmb_intervalos.Size = New System.Drawing.Size(82, 21)
        Me.cmb_intervalos.TabIndex = 3
        '
        'grid2
        '
        Me.grid2.AllowUserToAddRows = False
        Me.grid2.AllowUserToDeleteRows = False
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.k, Me.fo, Me.fe, Me.chiCuadrado})
        Me.grid2.Location = New System.Drawing.Point(23, 118)
        Me.grid2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grid2.Name = "grid2"
        Me.grid2.ReadOnly = True
        Me.grid2.RowTemplate.Height = 28
        Me.grid2.Size = New System.Drawing.Size(456, 238)
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
        'txt_cantidadNros
        '
        Me.txt_cantidadNros.Location = New System.Drawing.Point(153, 29)
        Me.txt_cantidadNros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_cantidadNros.Name = "txt_cantidadNros"
        Me.txt_cantidadNros.Size = New System.Drawing.Size(68, 20)
        Me.txt_cantidadNros.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese la cantidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "intervalos: "
        '
        'lbl_nrosAleatorios
        '
        Me.lbl_nrosAleatorios.AutoSize = True
        Me.lbl_nrosAleatorios.Location = New System.Drawing.Point(20, 20)
        Me.lbl_nrosAleatorios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_nrosAleatorios.Name = "lbl_nrosAleatorios"
        Me.lbl_nrosAleatorios.Size = New System.Drawing.Size(115, 26)
        Me.lbl_nrosAleatorios.TabIndex = 0
        Me.lbl_nrosAleatorios.Text = "Ingrese la cantidad de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "numeros aleatorios: "
        '
        'Chart1
        '
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 361)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "DrawSideBySide=True, EmptyPointValue=Zero, LabelStyle=Right"
        Series1.Legend = "Legend1"
        Series1.Name = "fo"
        Series2.BorderWidth = 3
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.Name = "fe"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(842, 212)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'TrabajoPractico1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 666)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "TrabajoPractico1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
