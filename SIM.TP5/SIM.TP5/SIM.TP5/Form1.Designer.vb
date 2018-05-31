<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reloj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndLlegadaConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tProxConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tLlegadaConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndLlegadaUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tProxUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tLlegadaUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadoMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consultaEnEspera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tFaltanteConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndTiempoAtConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tAtConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tFinAtConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rndTiempoAtUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tAtUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tFinAtUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumUrgencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumPacientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_cantSimulaciones = New System.Windows.Forms.TextBox()
        Me.lbl_simulaciones = New System.Windows.Forms.Label()
        Me.cmd_generar = New System.Windows.Forms.Button()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.evento, Me.reloj, Me.rndLlegadaConsulta, Me.tProxConsulta, Me.tLlegadaConsulta, Me.rndLlegadaUrgencia, Me.tProxUrgencia, Me.tLlegadaUrgencia, Me.estadoMedico, Me.consultaEnEspera, Me.tFaltanteConsulta, Me.rndTiempoAtConsulta, Me.tAtConsulta, Me.tFinAtConsulta, Me.rndTiempoAtUrgencia, Me.tAtUrgencia, Me.tFinAtUrgencia, Me.sumUrgencias, Me.sumPacientes})
        Me.grid.Location = New System.Drawing.Point(12, 124)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 28
        Me.grid.Size = New System.Drawing.Size(1446, 346)
        Me.grid.TabIndex = 0
        '
        'evento
        '
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        '
        'reloj
        '
        Me.reloj.HeaderText = "Reloj"
        Me.reloj.Name = "reloj"
        '
        'rndLlegadaConsulta
        '
        Me.rndLlegadaConsulta.HeaderText = "RND Llegada consulta"
        Me.rndLlegadaConsulta.Name = "rndLlegadaConsulta"
        '
        'tProxConsulta
        '
        Me.tProxConsulta.HeaderText = "Tiempo hasta proxima consulta"
        Me.tProxConsulta.Name = "tProxConsulta"
        '
        'tLlegadaConsulta
        '
        Me.tLlegadaConsulta.HeaderText = "Tiempo llegada consulta"
        Me.tLlegadaConsulta.Name = "tLlegadaConsulta"
        '
        'rndLlegadaUrgencia
        '
        Me.rndLlegadaUrgencia.HeaderText = "RND Llegada urgencia"
        Me.rndLlegadaUrgencia.Name = "rndLlegadaUrgencia"
        '
        'tProxUrgencia
        '
        Me.tProxUrgencia.HeaderText = "Tiempo hasta proxima urgencia"
        Me.tProxUrgencia.Name = "tProxUrgencia"
        '
        'tLlegadaUrgencia
        '
        Me.tLlegadaUrgencia.HeaderText = "Tiempo llegada urgencia"
        Me.tLlegadaUrgencia.Name = "tLlegadaUrgencia"
        '
        'estadoMedico
        '
        Me.estadoMedico.HeaderText = "Estado medico"
        Me.estadoMedico.Name = "estadoMedico"
        '
        'consultaEnEspera
        '
        Me.consultaEnEspera.HeaderText = "Hay consulta en espera?"
        Me.consultaEnEspera.Name = "consultaEnEspera"
        '
        'tFaltanteConsulta
        '
        Me.tFaltanteConsulta.HeaderText = "Tiempo faltante consulta"
        Me.tFaltanteConsulta.Name = "tFaltanteConsulta"
        '
        'rndTiempoAtConsulta
        '
        Me.rndTiempoAtConsulta.HeaderText = "RND Tiempo at. consulta"
        Me.rndTiempoAtConsulta.Name = "rndTiempoAtConsulta"
        '
        'tAtConsulta
        '
        Me.tAtConsulta.HeaderText = "Tiempo at. consulta"
        Me.tAtConsulta.Name = "tAtConsulta"
        '
        'tFinAtConsulta
        '
        Me.tFinAtConsulta.HeaderText = "Tiempo fin at. consulta"
        Me.tFinAtConsulta.Name = "tFinAtConsulta"
        '
        'rndTiempoAtUrgencia
        '
        Me.rndTiempoAtUrgencia.HeaderText = "RND Tiempo at. urgencia"
        Me.rndTiempoAtUrgencia.Name = "rndTiempoAtUrgencia"
        '
        'tAtUrgencia
        '
        Me.tAtUrgencia.HeaderText = "Tiempo at. urgencia"
        Me.tAtUrgencia.Name = "tAtUrgencia"
        '
        'tFinAtUrgencia
        '
        Me.tFinAtUrgencia.HeaderText = "Tiempo fin at. urgencia"
        Me.tFinAtUrgencia.Name = "tFinAtUrgencia"
        '
        'sumUrgencias
        '
        Me.sumUrgencias.HeaderText = "Sumatoria de urgencias"
        Me.sumUrgencias.Name = "sumUrgencias"
        '
        'sumPacientes
        '
        Me.sumPacientes.HeaderText = "Sumatoria de pacientes"
        Me.sumPacientes.Name = "sumPacientes"
        '
        'txt_cantSimulaciones
        '
        Me.txt_cantSimulaciones.Location = New System.Drawing.Point(278, 29)
        Me.txt_cantSimulaciones.Name = "txt_cantSimulaciones"
        Me.txt_cantSimulaciones.Size = New System.Drawing.Size(195, 26)
        Me.txt_cantSimulaciones.TabIndex = 1
        '
        'lbl_simulaciones
        '
        Me.lbl_simulaciones.AutoSize = True
        Me.lbl_simulaciones.Location = New System.Drawing.Point(71, 32)
        Me.lbl_simulaciones.Name = "lbl_simulaciones"
        Me.lbl_simulaciones.Size = New System.Drawing.Size(190, 20)
        Me.lbl_simulaciones.TabIndex = 2
        Me.lbl_simulaciones.Text = "Cantidad de simulaciones"
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(506, 29)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(88, 26)
        Me.cmd_generar.TabIndex = 3
        Me.cmd_generar.Text = "Generar"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1586, 676)
        Me.Controls.Add(Me.cmd_generar)
        Me.Controls.Add(Me.lbl_simulaciones)
        Me.Controls.Add(Me.txt_cantSimulaciones)
        Me.Controls.Add(Me.grid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents evento As DataGridViewTextBoxColumn
    Friend WithEvents reloj As DataGridViewTextBoxColumn
    Friend WithEvents rndLlegadaConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tProxConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tLlegadaConsulta As DataGridViewTextBoxColumn
    Friend WithEvents rndLlegadaUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tProxUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tLlegadaUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents estadoMedico As DataGridViewTextBoxColumn
    Friend WithEvents consultaEnEspera As DataGridViewTextBoxColumn
    Friend WithEvents tFaltanteConsulta As DataGridViewTextBoxColumn
    Friend WithEvents rndTiempoAtConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tAtConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tFinAtConsulta As DataGridViewTextBoxColumn
    Friend WithEvents rndTiempoAtUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tAtUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tFinAtUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents sumUrgencias As DataGridViewTextBoxColumn
    Friend WithEvents sumPacientes As DataGridViewTextBoxColumn
    Friend WithEvents txt_cantSimulaciones As TextBox
    Friend WithEvents lbl_simulaciones As Label
    Friend WithEvents cmd_generar As Button
End Class
