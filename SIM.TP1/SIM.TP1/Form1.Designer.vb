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
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.txt_a = New System.Windows.Forms.TextBox()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.lbl_c = New System.Windows.Forms.Label()
        Me.lbl_m = New System.Windows.Forms.Label()
        Me.txt_c = New System.Windows.Forms.TextBox()
        Me.txt_m = New System.Windows.Forms.TextBox()
        Me.cmd_siguiente = New System.Windows.Forms.Button()
        Me.lbl_seed = New System.Windows.Forms.Label()
        Me.txt_seed = New System.Windows.Forms.TextBox()
        Me.indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.Location = New System.Drawing.Point(207, 20)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(13, 13)
        Me.lbl_a.TabIndex = 0
        Me.lbl_a.Text = "a"
        '
        'txt_a
        '
        Me.txt_a.Location = New System.Drawing.Point(226, 13)
        Me.txt_a.Name = "txt_a"
        Me.txt_a.Size = New System.Drawing.Size(100, 20)
        Me.txt_a.TabIndex = 1
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.indice, Me.numero})
        Me.grid1.Location = New System.Drawing.Point(12, 125)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(400, 324)
        Me.grid1.TabIndex = 2
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(12, 96)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_generar.TabIndex = 3
        Me.cmd_generar.Text = "Generar"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'lbl_c
        '
        Me.lbl_c.AutoSize = True
        Me.lbl_c.Location = New System.Drawing.Point(207, 44)
        Me.lbl_c.Name = "lbl_c"
        Me.lbl_c.Size = New System.Drawing.Size(13, 13)
        Me.lbl_c.TabIndex = 0
        Me.lbl_c.Text = "c"
        '
        'lbl_m
        '
        Me.lbl_m.AutoSize = True
        Me.lbl_m.Location = New System.Drawing.Point(207, 67)
        Me.lbl_m.Name = "lbl_m"
        Me.lbl_m.Size = New System.Drawing.Size(15, 13)
        Me.lbl_m.TabIndex = 0
        Me.lbl_m.Text = "m"
        '
        'txt_c
        '
        Me.txt_c.Location = New System.Drawing.Point(226, 37)
        Me.txt_c.Name = "txt_c"
        Me.txt_c.Size = New System.Drawing.Size(100, 20)
        Me.txt_c.TabIndex = 1
        '
        'txt_m
        '
        Me.txt_m.Location = New System.Drawing.Point(226, 60)
        Me.txt_m.Name = "txt_m"
        Me.txt_m.Size = New System.Drawing.Size(100, 20)
        Me.txt_m.TabIndex = 1
        '
        'cmd_siguiente
        '
        Me.cmd_siguiente.Location = New System.Drawing.Point(93, 96)
        Me.cmd_siguiente.Name = "cmd_siguiente"
        Me.cmd_siguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmd_siguiente.TabIndex = 3
        Me.cmd_siguiente.Text = "Siguiente"
        Me.cmd_siguiente.UseVisualStyleBackColor = True
        '
        'lbl_seed
        '
        Me.lbl_seed.AutoSize = True
        Me.lbl_seed.Location = New System.Drawing.Point(30, 20)
        Me.lbl_seed.Name = "lbl_seed"
        Me.lbl_seed.Size = New System.Drawing.Size(32, 13)
        Me.lbl_seed.TabIndex = 0
        Me.lbl_seed.Text = "Seed"
        '
        'txt_seed
        '
        Me.txt_seed.Location = New System.Drawing.Point(68, 13)
        Me.txt_seed.Name = "txt_seed"
        Me.txt_seed.Size = New System.Drawing.Size(100, 20)
        Me.txt_seed.TabIndex = 1
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
        'TrabajoPractico1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 461)
        Me.Controls.Add(Me.cmd_siguiente)
        Me.Controls.Add(Me.cmd_generar)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.txt_m)
        Me.Controls.Add(Me.txt_c)
        Me.Controls.Add(Me.txt_seed)
        Me.Controls.Add(Me.txt_a)
        Me.Controls.Add(Me.lbl_m)
        Me.Controls.Add(Me.lbl_seed)
        Me.Controls.Add(Me.lbl_c)
        Me.Controls.Add(Me.lbl_a)
        Me.Name = "TrabajoPractico1"
        Me.Text = "Form1"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_a As Label
    Friend WithEvents txt_a As TextBox
    Friend WithEvents grid1 As DataGridView
    Friend WithEvents indice As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents cmd_generar As Button
    Friend WithEvents lbl_c As Label
    Friend WithEvents lbl_m As Label
    Friend WithEvents txt_c As TextBox
    Friend WithEvents txt_m As TextBox
    Friend WithEvents cmd_siguiente As Button
    Friend WithEvents lbl_seed As Label
    Friend WithEvents txt_seed As TextBox
End Class
