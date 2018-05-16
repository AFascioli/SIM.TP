<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmd_generarA = New System.Windows.Forms.Button()
        Me.txt_cantidadDias = New System.Windows.Forms.TextBox()
        Me.GrillaA = New System.Windows.Forms.DataGridView()
        Me.cbx_demandaAnterior = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_cantidadDocenas = New System.Windows.Forms.Label()
        Me.cmb_cantidadDocenas = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmd_generarB = New System.Windows.Forms.Button()
        Me.txt_cantidadDiasB = New System.Windows.Forms.TextBox()
        Me.GrillaB = New System.Windows.Forms.DataGridView()
        Me.cbx_demandaAnteriorB = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_cantidadDocenasB = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mercFaltante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.experimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndTiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.soleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndDemanda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantDemanda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reembolso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumBeneficio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GrillaA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GrillaB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1173, 474)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmd_generarA)
        Me.TabPage1.Controls.Add(Me.txt_cantidadDias)
        Me.TabPage1.Controls.Add(Me.GrillaA)
        Me.TabPage1.Controls.Add(Me.cbx_demandaAnterior)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lbl_cantidadDocenas)
        Me.TabPage1.Controls.Add(Me.cmb_cantidadDocenas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1165, 448)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmd_generarA
        '
        Me.cmd_generarA.Location = New System.Drawing.Point(332, 91)
        Me.cmd_generarA.Name = "cmd_generarA"
        Me.cmd_generarA.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generarA.TabIndex = 5
        Me.cmd_generarA.Text = "Generar"
        Me.cmd_generarA.UseVisualStyleBackColor = True
        '
        'txt_cantidadDias
        '
        Me.txt_cantidadDias.Location = New System.Drawing.Point(157, 64)
        Me.txt_cantidadDias.Name = "txt_cantidadDias"
        Me.txt_cantidadDias.Size = New System.Drawing.Size(169, 20)
        Me.txt_cantidadDias.TabIndex = 4
        '
        'GrillaA
        '
        Me.GrillaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.experimento, Me.stockInicial, Me.rndTiempo, Me.soleado, Me.rndDemanda, Me.cantDemanda, Me.venta, Me.reembolso, Me.sumIngreso, Me.sumCosto, Me.sumBeneficio})
        Me.GrillaA.Location = New System.Drawing.Point(25, 164)
        Me.GrillaA.Name = "GrillaA"
        Me.GrillaA.Size = New System.Drawing.Size(954, 278)
        Me.GrillaA.TabIndex = 3
        '
        'cbx_demandaAnterior
        '
        Me.cbx_demandaAnterior.AutoSize = True
        Me.cbx_demandaAnterior.Location = New System.Drawing.Point(157, 120)
        Me.cbx_demandaAnterior.Name = "cbx_demandaAnterior"
        Me.cbx_demandaAnterior.Size = New System.Drawing.Size(169, 17)
        Me.cbx_demandaAnterior.TabIndex = 2
        Me.cbx_demandaAnterior.Text = "Usar demanda del día anterior"
        Me.cbx_demandaAnterior.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad de días"
        '
        'lbl_cantidadDocenas
        '
        Me.lbl_cantidadDocenas.AutoSize = True
        Me.lbl_cantidadDocenas.Location = New System.Drawing.Point(22, 96)
        Me.lbl_cantidadDocenas.Name = "lbl_cantidadDocenas"
        Me.lbl_cantidadDocenas.Size = New System.Drawing.Size(108, 13)
        Me.lbl_cantidadDocenas.TabIndex = 1
        Me.lbl_cantidadDocenas.Text = "Cantidad de docenas"
        '
        'cmb_cantidadDocenas
        '
        Me.cmb_cantidadDocenas.FormattingEnabled = True
        Me.cmb_cantidadDocenas.Location = New System.Drawing.Point(157, 93)
        Me.cmb_cantidadDocenas.Name = "cmb_cantidadDocenas"
        Me.cmb_cantidadDocenas.Size = New System.Drawing.Size(169, 21)
        Me.cmb_cantidadDocenas.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmd_generarB)
        Me.TabPage2.Controls.Add(Me.txt_cantidadDiasB)
        Me.TabPage2.Controls.Add(Me.GrillaB)
        Me.TabPage2.Controls.Add(Me.cbx_demandaAnteriorB)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.cmb_cantidadDocenasB)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1165, 448)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmd_generarB
        '
        Me.cmd_generarB.Location = New System.Drawing.Point(322, 91)
        Me.cmd_generarB.Name = "cmd_generarB"
        Me.cmd_generarB.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generarB.TabIndex = 12
        Me.cmd_generarB.Text = "Generar"
        Me.cmd_generarB.UseVisualStyleBackColor = True
        '
        'txt_cantidadDiasB
        '
        Me.txt_cantidadDiasB.Location = New System.Drawing.Point(147, 64)
        Me.txt_cantidadDiasB.Name = "txt_cantidadDiasB"
        Me.txt_cantidadDiasB.Size = New System.Drawing.Size(169, 20)
        Me.txt_cantidadDiasB.TabIndex = 11
        '
        'GrillaB
        '
        Me.GrillaB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.mercFaltante, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.GrillaB.Location = New System.Drawing.Point(15, 164)
        Me.GrillaB.Name = "GrillaB"
        Me.GrillaB.Size = New System.Drawing.Size(954, 278)
        Me.GrillaB.TabIndex = 10
        '
        'cbx_demandaAnteriorB
        '
        Me.cbx_demandaAnteriorB.AutoSize = True
        Me.cbx_demandaAnteriorB.Location = New System.Drawing.Point(147, 120)
        Me.cbx_demandaAnteriorB.Name = "cbx_demandaAnteriorB"
        Me.cbx_demandaAnteriorB.Size = New System.Drawing.Size(169, 17)
        Me.cbx_demandaAnteriorB.TabIndex = 9
        Me.cbx_demandaAnteriorB.Text = "Usar demanda del día anterior"
        Me.cbx_demandaAnteriorB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad de días"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad de docenas"
        '
        'cmb_cantidadDocenasB
        '
        Me.cmb_cantidadDocenasB.FormattingEnabled = True
        Me.cmb_cantidadDocenasB.Location = New System.Drawing.Point(147, 93)
        Me.cmb_cantidadDocenasB.Name = "cmb_cantidadDocenasB"
        Me.cmb_cantidadDocenasB.Size = New System.Drawing.Size(169, 21)
        Me.cmb_cantidadDocenasB.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Exp."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Stock Inicial"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "RND Tiempo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Soleado?"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "RND Demanda"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cant. Demanda"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Venta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'mercFaltante
        '
        Me.mercFaltante.HeaderText = "Merc. Faltante"
        Me.mercFaltante.Name = "mercFaltante"
        Me.mercFaltante.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Reembolso"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Costo Faltante"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Sum. Ingreso"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sum. Costo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Sum. Beneficio"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'experimento
        '
        Me.experimento.HeaderText = "Exp."
        Me.experimento.Name = "experimento"
        Me.experimento.Width = 40
        '
        'stockInicial
        '
        Me.stockInicial.HeaderText = "Stock Inicial"
        Me.stockInicial.Name = "stockInicial"
        Me.stockInicial.Width = 60
        '
        'rndTiempo
        '
        Me.rndTiempo.HeaderText = "RND Tiempo"
        Me.rndTiempo.Name = "rndTiempo"
        Me.rndTiempo.Width = 70
        '
        'soleado
        '
        Me.soleado.HeaderText = "Soleado?"
        Me.soleado.Name = "soleado"
        Me.soleado.Width = 60
        '
        'rndDemanda
        '
        Me.rndDemanda.HeaderText = "RND Demanda"
        Me.rndDemanda.Name = "rndDemanda"
        Me.rndDemanda.Width = 70
        '
        'cantDemanda
        '
        Me.cantDemanda.HeaderText = "Cant. Demanda"
        Me.cantDemanda.Name = "cantDemanda"
        Me.cantDemanda.Width = 60
        '
        'venta
        '
        Me.venta.HeaderText = "Venta"
        Me.venta.Name = "venta"
        Me.venta.Width = 60
        '
        'reembolso
        '
        Me.reembolso.HeaderText = "Reembolso"
        Me.reembolso.Name = "reembolso"
        Me.reembolso.Width = 80
        '
        'sumIngreso
        '
        Me.sumIngreso.HeaderText = "Sum. Ingreso"
        Me.sumIngreso.Name = "sumIngreso"
        '
        'sumCosto
        '
        Me.sumCosto.HeaderText = "Sum. Costo"
        Me.sumCosto.Name = "sumCosto"
        '
        'sumBeneficio
        '
        Me.sumBeneficio.HeaderText = "Sum. Beneficio"
        Me.sumBeneficio.Name = "sumBeneficio"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 488)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GrillaA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GrillaB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cbx_demandaAnterior As CheckBox
    Friend WithEvents lbl_cantidadDocenas As Label
    Friend WithEvents cmb_cantidadDocenas As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_cantidadDias As TextBox
    Friend WithEvents GrillaA As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_generarA As Button
    Friend WithEvents cmd_generarB As Button
    Friend WithEvents txt_cantidadDiasB As TextBox
    Friend WithEvents GrillaB As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents mercFaltante As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents cbx_demandaAnteriorB As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_cantidadDocenasB As ComboBox
    Friend WithEvents experimento As DataGridViewTextBoxColumn
    Friend WithEvents stockInicial As DataGridViewTextBoxColumn
    Friend WithEvents rndTiempo As DataGridViewTextBoxColumn
    Friend WithEvents soleado As DataGridViewTextBoxColumn
    Friend WithEvents rndDemanda As DataGridViewTextBoxColumn
    Friend WithEvents cantDemanda As DataGridViewTextBoxColumn
    Friend WithEvents venta As DataGridViewTextBoxColumn
    Friend WithEvents reembolso As DataGridViewTextBoxColumn
    Friend WithEvents sumIngreso As DataGridViewTextBoxColumn
    Friend WithEvents sumCosto As DataGridViewTextBoxColumn
    Friend WithEvents sumBeneficio As DataGridViewTextBoxColumn
End Class
