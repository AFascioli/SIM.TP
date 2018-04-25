<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TP3
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
        Me.txt_B = New System.Windows.Forms.TextBox()
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.txt_muestra1 = New System.Windows.Forms.TextBox()
        Me.lbl_B = New System.Windows.Forms.Label()
        Me.lbl_A = New System.Windows.Forms.Label()
        Me.lbl_muestra = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_lambda2 = New System.Windows.Forms.TextBox()
        Me.txt_media2 = New System.Windows.Forms.TextBox()
        Me.txt_muestra2 = New System.Windows.Forms.TextBox()
        Me.lbl_lambda2 = New System.Windows.Forms.Label()
        Me.lbl_media2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txt_desviacion3 = New System.Windows.Forms.TextBox()
        Me.txt_media3 = New System.Windows.Forms.TextBox()
        Me.txt_muestra3 = New System.Windows.Forms.TextBox()
        Me.lbl_desviacion3 = New System.Windows.Forms.Label()
        Me.lbl_media3 = New System.Windows.Forms.Label()
        Me.lbl_muestra3 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lbl_lambda4 = New System.Windows.Forms.Label()
        Me.txt_lambda4 = New System.Windows.Forms.TextBox()
        Me.txt_muestra4 = New System.Windows.Forms.TextBox()
        Me.lbl_muestra4 = New System.Windows.Forms.Label()
        Me.cmd_generar1 = New System.Windows.Forms.Button()
        Me.cmd_generar2 = New System.Windows.Forms.Button()
        Me.cmd_generar3 = New System.Windows.Forms.Button()
        Me.cmd_generar4 = New System.Windows.Forms.Button()
        Me.Grid1 = New System.Windows.Forms.DataGridView()
        Me.indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(468, 133)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmd_generar1)
        Me.TabPage1.Controls.Add(Me.txt_B)
        Me.TabPage1.Controls.Add(Me.txt_A)
        Me.TabPage1.Controls.Add(Me.txt_muestra1)
        Me.TabPage1.Controls.Add(Me.lbl_B)
        Me.TabPage1.Controls.Add(Me.lbl_A)
        Me.TabPage1.Controls.Add(Me.lbl_muestra)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(460, 107)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Uniforme"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_B
        '
        Me.txt_B.Location = New System.Drawing.Point(141, 68)
        Me.txt_B.Name = "txt_B"
        Me.txt_B.Size = New System.Drawing.Size(100, 20)
        Me.txt_B.TabIndex = 1
        '
        'txt_A
        '
        Me.txt_A.Location = New System.Drawing.Point(141, 42)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(100, 20)
        Me.txt_A.TabIndex = 1
        '
        'txt_muestra1
        '
        Me.txt_muestra1.Location = New System.Drawing.Point(141, 16)
        Me.txt_muestra1.Name = "txt_muestra1"
        Me.txt_muestra1.Size = New System.Drawing.Size(100, 20)
        Me.txt_muestra1.TabIndex = 1
        '
        'lbl_B
        '
        Me.lbl_B.AutoSize = True
        Me.lbl_B.Location = New System.Drawing.Point(23, 71)
        Me.lbl_B.Name = "lbl_B"
        Me.lbl_B.Size = New System.Drawing.Size(76, 13)
        Me.lbl_B.TabIndex = 0
        Me.lbl_B.Text = "Límite superior"
        '
        'lbl_A
        '
        Me.lbl_A.AutoSize = True
        Me.lbl_A.Location = New System.Drawing.Point(23, 45)
        Me.lbl_A.Name = "lbl_A"
        Me.lbl_A.Size = New System.Drawing.Size(70, 13)
        Me.lbl_A.TabIndex = 0
        Me.lbl_A.Text = "Límite inferior"
        '
        'lbl_muestra
        '
        Me.lbl_muestra.AutoSize = True
        Me.lbl_muestra.Location = New System.Drawing.Point(23, 19)
        Me.lbl_muestra.Name = "lbl_muestra"
        Me.lbl_muestra.Size = New System.Drawing.Size(112, 13)
        Me.lbl_muestra.TabIndex = 0
        Me.lbl_muestra.Text = "Tamaño de la muestra"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmd_generar2)
        Me.TabPage2.Controls.Add(Me.txt_lambda2)
        Me.TabPage2.Controls.Add(Me.txt_media2)
        Me.TabPage2.Controls.Add(Me.txt_muestra2)
        Me.TabPage2.Controls.Add(Me.lbl_lambda2)
        Me.TabPage2.Controls.Add(Me.lbl_media2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(460, 107)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Exponencial negativa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_lambda2
        '
        Me.txt_lambda2.Location = New System.Drawing.Point(142, 69)
        Me.txt_lambda2.Name = "txt_lambda2"
        Me.txt_lambda2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lambda2.TabIndex = 5
        '
        'txt_media2
        '
        Me.txt_media2.Location = New System.Drawing.Point(142, 43)
        Me.txt_media2.Name = "txt_media2"
        Me.txt_media2.Size = New System.Drawing.Size(100, 20)
        Me.txt_media2.TabIndex = 6
        '
        'txt_muestra2
        '
        Me.txt_muestra2.Location = New System.Drawing.Point(142, 17)
        Me.txt_muestra2.Name = "txt_muestra2"
        Me.txt_muestra2.Size = New System.Drawing.Size(100, 20)
        Me.txt_muestra2.TabIndex = 7
        '
        'lbl_lambda2
        '
        Me.lbl_lambda2.AutoSize = True
        Me.lbl_lambda2.Location = New System.Drawing.Point(24, 72)
        Me.lbl_lambda2.Name = "lbl_lambda2"
        Me.lbl_lambda2.Size = New System.Drawing.Size(45, 13)
        Me.lbl_lambda2.TabIndex = 2
        Me.lbl_lambda2.Text = "Lambda"
        '
        'lbl_media2
        '
        Me.lbl_media2.AutoSize = True
        Me.lbl_media2.Location = New System.Drawing.Point(24, 46)
        Me.lbl_media2.Name = "lbl_media2"
        Me.lbl_media2.Size = New System.Drawing.Size(36, 13)
        Me.lbl_media2.TabIndex = 3
        Me.lbl_media2.Text = "Media"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tamaño de la muestra"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmd_generar3)
        Me.TabPage3.Controls.Add(Me.txt_desviacion3)
        Me.TabPage3.Controls.Add(Me.txt_media3)
        Me.TabPage3.Controls.Add(Me.txt_muestra3)
        Me.TabPage3.Controls.Add(Me.lbl_desviacion3)
        Me.TabPage3.Controls.Add(Me.lbl_media3)
        Me.TabPage3.Controls.Add(Me.lbl_muestra3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(460, 107)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Normal"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txt_desviacion3
        '
        Me.txt_desviacion3.Location = New System.Drawing.Point(134, 68)
        Me.txt_desviacion3.Name = "txt_desviacion3"
        Me.txt_desviacion3.Size = New System.Drawing.Size(100, 20)
        Me.txt_desviacion3.TabIndex = 11
        '
        'txt_media3
        '
        Me.txt_media3.Location = New System.Drawing.Point(134, 42)
        Me.txt_media3.Name = "txt_media3"
        Me.txt_media3.Size = New System.Drawing.Size(100, 20)
        Me.txt_media3.TabIndex = 12
        '
        'txt_muestra3
        '
        Me.txt_muestra3.Location = New System.Drawing.Point(134, 16)
        Me.txt_muestra3.Name = "txt_muestra3"
        Me.txt_muestra3.Size = New System.Drawing.Size(100, 20)
        Me.txt_muestra3.TabIndex = 13
        '
        'lbl_desviacion3
        '
        Me.lbl_desviacion3.AutoSize = True
        Me.lbl_desviacion3.Location = New System.Drawing.Point(16, 71)
        Me.lbl_desviacion3.Name = "lbl_desviacion3"
        Me.lbl_desviacion3.Size = New System.Drawing.Size(104, 13)
        Me.lbl_desviacion3.TabIndex = 8
        Me.lbl_desviacion3.Text = "Desviación estandar"
        '
        'lbl_media3
        '
        Me.lbl_media3.AutoSize = True
        Me.lbl_media3.Location = New System.Drawing.Point(16, 45)
        Me.lbl_media3.Name = "lbl_media3"
        Me.lbl_media3.Size = New System.Drawing.Size(36, 13)
        Me.lbl_media3.TabIndex = 9
        Me.lbl_media3.Text = "Media"
        '
        'lbl_muestra3
        '
        Me.lbl_muestra3.AutoSize = True
        Me.lbl_muestra3.Location = New System.Drawing.Point(16, 19)
        Me.lbl_muestra3.Name = "lbl_muestra3"
        Me.lbl_muestra3.Size = New System.Drawing.Size(112, 13)
        Me.lbl_muestra3.TabIndex = 10
        Me.lbl_muestra3.Text = "Tamaño de la muestra"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cmd_generar4)
        Me.TabPage4.Controls.Add(Me.lbl_lambda4)
        Me.TabPage4.Controls.Add(Me.txt_lambda4)
        Me.TabPage4.Controls.Add(Me.txt_muestra4)
        Me.TabPage4.Controls.Add(Me.lbl_muestra4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(460, 107)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Poisson"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lbl_lambda4
        '
        Me.lbl_lambda4.AutoSize = True
        Me.lbl_lambda4.Location = New System.Drawing.Point(17, 45)
        Me.lbl_lambda4.Name = "lbl_lambda4"
        Me.lbl_lambda4.Size = New System.Drawing.Size(45, 13)
        Me.lbl_lambda4.TabIndex = 20
        Me.lbl_lambda4.Text = "Lambda"
        '
        'txt_lambda4
        '
        Me.txt_lambda4.Location = New System.Drawing.Point(135, 42)
        Me.txt_lambda4.Name = "txt_lambda4"
        Me.txt_lambda4.Size = New System.Drawing.Size(100, 20)
        Me.txt_lambda4.TabIndex = 18
        '
        'txt_muestra4
        '
        Me.txt_muestra4.Location = New System.Drawing.Point(135, 16)
        Me.txt_muestra4.Name = "txt_muestra4"
        Me.txt_muestra4.Size = New System.Drawing.Size(100, 20)
        Me.txt_muestra4.TabIndex = 19
        '
        'lbl_muestra4
        '
        Me.lbl_muestra4.AutoSize = True
        Me.lbl_muestra4.Location = New System.Drawing.Point(17, 19)
        Me.lbl_muestra4.Name = "lbl_muestra4"
        Me.lbl_muestra4.Size = New System.Drawing.Size(112, 13)
        Me.lbl_muestra4.TabIndex = 16
        Me.lbl_muestra4.Text = "Tamaño de la muestra"
        '
        'cmd_generar1
        '
        Me.cmd_generar1.Location = New System.Drawing.Point(261, 66)
        Me.cmd_generar1.Name = "cmd_generar1"
        Me.cmd_generar1.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generar1.TabIndex = 2
        Me.cmd_generar1.Text = "Generar"
        Me.cmd_generar1.UseVisualStyleBackColor = True
        '
        'cmd_generar2
        '
        Me.cmd_generar2.Location = New System.Drawing.Point(263, 67)
        Me.cmd_generar2.Name = "cmd_generar2"
        Me.cmd_generar2.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generar2.TabIndex = 8
        Me.cmd_generar2.Text = "Generar"
        Me.cmd_generar2.UseVisualStyleBackColor = True
        '
        'cmd_generar3
        '
        Me.cmd_generar3.Location = New System.Drawing.Point(255, 66)
        Me.cmd_generar3.Name = "cmd_generar3"
        Me.cmd_generar3.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generar3.TabIndex = 14
        Me.cmd_generar3.Text = "Generar"
        Me.cmd_generar3.UseVisualStyleBackColor = True
        '
        'cmd_generar4
        '
        Me.cmd_generar4.Location = New System.Drawing.Point(252, 40)
        Me.cmd_generar4.Name = "cmd_generar4"
        Me.cmd_generar4.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generar4.TabIndex = 21
        Me.cmd_generar4.Text = "Generar"
        Me.cmd_generar4.UseVisualStyleBackColor = True
        '
        'Grid1
        '
        Me.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.indice, Me.numero})
        Me.Grid1.Location = New System.Drawing.Point(12, 151)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(208, 321)
        Me.Grid1.TabIndex = 1
        '
        'indice
        '
        Me.indice.HeaderText = "Indice"
        Me.indice.Name = "indice"
        Me.indice.Width = 50
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        '
        'TP3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 484)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "TP3"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txt_B As TextBox
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_muestra1 As TextBox
    Friend WithEvents lbl_B As Label
    Friend WithEvents lbl_A As Label
    Friend WithEvents lbl_muestra As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_lambda2 As TextBox
    Friend WithEvents txt_media2 As TextBox
    Friend WithEvents txt_muestra2 As TextBox
    Friend WithEvents lbl_lambda2 As Label
    Friend WithEvents lbl_media2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txt_desviacion3 As TextBox
    Friend WithEvents txt_media3 As TextBox
    Friend WithEvents txt_muestra3 As TextBox
    Friend WithEvents lbl_desviacion3 As Label
    Friend WithEvents lbl_media3 As Label
    Friend WithEvents lbl_muestra3 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lbl_lambda4 As Label
    Friend WithEvents txt_lambda4 As TextBox
    Friend WithEvents txt_muestra4 As TextBox
    Friend WithEvents lbl_muestra4 As Label
    Friend WithEvents cmd_generar1 As Button
    Friend WithEvents cmd_generar2 As Button
    Friend WithEvents cmd_generar3 As Button
    Friend WithEvents cmd_generar4 As Button
    Friend WithEvents Grid1 As DataGridView
    Friend WithEvents indice As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
End Class
