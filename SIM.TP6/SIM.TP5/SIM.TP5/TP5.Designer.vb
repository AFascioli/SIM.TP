<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TP5
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
        Me.lbl_cantidadEventos = New System.Windows.Forms.Label()
        Me.txt_cantidadEventos = New System.Windows.Forms.TextBox()
        Me.GrillaA = New System.Windows.Forms.DataGridView()
        Me.evento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reloj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tProxConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tLlegConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tProxUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tLlegUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estadosMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consultaEnEspera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tFaltanteConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tAtencionConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tFinAtencionConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rnd4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tAtencionUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tFinAtencionUrgencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumUrgencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sumPacientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrillaColaUrgencias = New System.Windows.Forms.DataGridView()
        Me.GrillaColaConsultas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.posicionConsulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaColaUrgencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaColaConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cantidadEventos
        '
        Me.lbl_cantidadEventos.AutoSize = True
        Me.lbl_cantidadEventos.Location = New System.Drawing.Point(12, 27)
        Me.lbl_cantidadEventos.Name = "lbl_cantidadEventos"
        Me.lbl_cantidadEventos.Size = New System.Drawing.Size(149, 13)
        Me.lbl_cantidadEventos.TabIndex = 0
        Me.lbl_cantidadEventos.Text = "Cantidad de eventos a simular"
        '
        'txt_cantidadEventos
        '
        Me.txt_cantidadEventos.Location = New System.Drawing.Point(169, 24)
        Me.txt_cantidadEventos.Name = "txt_cantidadEventos"
        Me.txt_cantidadEventos.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidadEventos.TabIndex = 1
        '
        'GrillaA
        '
        Me.GrillaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.evento, Me.reloj, Me.rnd1, Me.tProxConsulta, Me.tLlegConsulta, Me.rnd2, Me.tProxUrgencia, Me.tLlegUrgencia, Me.estadosMedico, Me.colaConsulta, Me.colaUrgencia, Me.consultaEnEspera, Me.tFaltanteConsulta, Me.rnd3, Me.tAtencionConsulta, Me.tFinAtencionConsulta, Me.rnd4, Me.tAtencionUrgencia, Me.tFinAtencionUrgencia, Me.sumUrgencias, Me.sumPacientes})
        Me.GrillaA.Location = New System.Drawing.Point(12, 212)
        Me.GrillaA.Name = "GrillaA"
        Me.GrillaA.Size = New System.Drawing.Size(1172, 264)
        Me.GrillaA.TabIndex = 2
        '
        'evento
        '
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        Me.evento.Width = 70
        '
        'reloj
        '
        Me.reloj.HeaderText = "Reloj"
        Me.reloj.Name = "reloj"
        Me.reloj.Width = 50
        '
        'rnd1
        '
        Me.rnd1.HeaderText = "RND"
        Me.rnd1.Name = "rnd1"
        Me.rnd1.Width = 50
        '
        'tProxConsulta
        '
        Me.tProxConsulta.HeaderText = "T. hasta prox. consulta"
        Me.tProxConsulta.Name = "tProxConsulta"
        Me.tProxConsulta.Width = 50
        '
        'tLlegConsulta
        '
        Me.tLlegConsulta.HeaderText = "T. de llegada de prox. consulta"
        Me.tLlegConsulta.Name = "tLlegConsulta"
        Me.tLlegConsulta.Width = 50
        '
        'rnd2
        '
        Me.rnd2.HeaderText = "RND"
        Me.rnd2.Name = "rnd2"
        Me.rnd2.Width = 50
        '
        'tProxUrgencia
        '
        Me.tProxUrgencia.HeaderText = "T. hasta prox. urgencia"
        Me.tProxUrgencia.Name = "tProxUrgencia"
        Me.tProxUrgencia.Width = 50
        '
        'tLlegUrgencia
        '
        Me.tLlegUrgencia.HeaderText = "T. llegada de prox. urgencia"
        Me.tLlegUrgencia.Name = "tLlegUrgencia"
        Me.tLlegUrgencia.Width = 50
        '
        'estadosMedico
        '
        Me.estadosMedico.HeaderText = "Estado del médico"
        Me.estadosMedico.Name = "estadosMedico"
        Me.estadosMedico.Width = 60
        '
        'colaConsulta
        '
        Me.colaConsulta.HeaderText = "Cola consulta"
        Me.colaConsulta.Name = "colaConsulta"
        Me.colaConsulta.Width = 50
        '
        'colaUrgencia
        '
        Me.colaUrgencia.HeaderText = "Cola urgencia"
        Me.colaUrgencia.Name = "colaUrgencia"
        Me.colaUrgencia.Width = 50
        '
        'consultaEnEspera
        '
        Me.consultaEnEspera.HeaderText = "Consulta en espera?"
        Me.consultaEnEspera.Name = "consultaEnEspera"
        Me.consultaEnEspera.Width = 50
        '
        'tFaltanteConsulta
        '
        Me.tFaltanteConsulta.HeaderText = "T. faltante de consulta"
        Me.tFaltanteConsulta.Name = "tFaltanteConsulta"
        Me.tFaltanteConsulta.Width = 50
        '
        'rnd3
        '
        Me.rnd3.HeaderText = "RND"
        Me.rnd3.Name = "rnd3"
        Me.rnd3.Width = 50
        '
        'tAtencionConsulta
        '
        Me.tAtencionConsulta.HeaderText = "T. de atención"
        Me.tAtencionConsulta.Name = "tAtencionConsulta"
        Me.tAtencionConsulta.Width = 50
        '
        'tFinAtencionConsulta
        '
        Me.tFinAtencionConsulta.HeaderText = "T. de fin de atención de consulta"
        Me.tFinAtencionConsulta.Name = "tFinAtencionConsulta"
        Me.tFinAtencionConsulta.Width = 50
        '
        'rnd4
        '
        Me.rnd4.HeaderText = "RND"
        Me.rnd4.Name = "rnd4"
        Me.rnd4.Width = 50
        '
        'tAtencionUrgencia
        '
        Me.tAtencionUrgencia.HeaderText = "T. de atención"
        Me.tAtencionUrgencia.Name = "tAtencionUrgencia"
        Me.tAtencionUrgencia.Width = 50
        '
        'tFinAtencionUrgencia
        '
        Me.tFinAtencionUrgencia.HeaderText = "T. de fin de atención urgencia"
        Me.tFinAtencionUrgencia.Name = "tFinAtencionUrgencia"
        Me.tFinAtencionUrgencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tFinAtencionUrgencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tFinAtencionUrgencia.Width = 50
        '
        'sumUrgencias
        '
        Me.sumUrgencias.HeaderText = "Sum. de pacientes de urgencias"
        Me.sumUrgencias.Name = "sumUrgencias"
        Me.sumUrgencias.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sumUrgencias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sumUrgencias.Width = 70
        '
        'sumPacientes
        '
        Me.sumPacientes.HeaderText = "Sum. total de pacientes"
        Me.sumPacientes.Name = "sumPacientes"
        Me.sumPacientes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sumPacientes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sumPacientes.Width = 70
        '
        'GrillaColaUrgencias
        '
        Me.GrillaColaUrgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaColaUrgencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posicion})
        Me.GrillaColaUrgencias.Location = New System.Drawing.Point(911, 49)
        Me.GrillaColaUrgencias.Name = "GrillaColaUrgencias"
        Me.GrillaColaUrgencias.Size = New System.Drawing.Size(273, 142)
        Me.GrillaColaUrgencias.TabIndex = 3
        '
        'GrillaColaConsultas
        '
        Me.GrillaColaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaColaConsultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.posicionConsulta})
        Me.GrillaColaConsultas.Location = New System.Drawing.Point(616, 49)
        Me.GrillaColaConsultas.Name = "GrillaColaConsultas"
        Me.GrillaColaConsultas.Size = New System.Drawing.Size(273, 142)
        Me.GrillaColaConsultas.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(613, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cola de consultas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(908, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cola de urgencias"
        '
        'posicion
        '
        Me.posicion.HeaderText = "Posición en la cola"
        Me.posicion.Name = "posicion"
        '
        'posicionConsulta
        '
        Me.posicionConsulta.HeaderText = "Posición en la cola"
        Me.posicionConsulta.Name = "posicionConsulta"
        '
        'TP5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 488)
        Me.Controls.Add(Me.GrillaColaConsultas)
        Me.Controls.Add(Me.GrillaColaUrgencias)
        Me.Controls.Add(Me.GrillaA)
        Me.Controls.Add(Me.txt_cantidadEventos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_cantidadEventos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TP5"
        Me.Text = "TP5 Ejercicio 67"
        CType(Me.GrillaA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaColaUrgencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaColaConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_cantidadEventos As Label
    Friend WithEvents txt_cantidadEventos As TextBox
    Friend WithEvents GrillaA As DataGridView
    Friend WithEvents evento As DataGridViewTextBoxColumn
    Friend WithEvents reloj As DataGridViewTextBoxColumn
    Friend WithEvents rnd1 As DataGridViewTextBoxColumn
    Friend WithEvents tProxConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tLlegConsulta As DataGridViewTextBoxColumn
    Friend WithEvents rnd2 As DataGridViewTextBoxColumn
    Friend WithEvents tProxUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tLlegUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents estadosMedico As DataGridViewTextBoxColumn
    Friend WithEvents colaConsulta As DataGridViewTextBoxColumn
    Friend WithEvents colaUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents consultaEnEspera As DataGridViewTextBoxColumn
    Friend WithEvents tFaltanteConsulta As DataGridViewTextBoxColumn
    Friend WithEvents rnd3 As DataGridViewTextBoxColumn
    Friend WithEvents tAtencionConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tFinAtencionConsulta As DataGridViewTextBoxColumn
    Friend WithEvents rnd4 As DataGridViewTextBoxColumn
    Friend WithEvents tAtencionUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tFinAtencionUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents sumUrgencias As DataGridViewTextBoxColumn
    Friend WithEvents sumPacientes As DataGridViewTextBoxColumn
    Friend WithEvents GrillaColaUrgencias As DataGridView
    Friend WithEvents posicion As DataGridViewTextBoxColumn
    Friend WithEvents GrillaColaConsultas As DataGridView
    Friend WithEvents posicionConsulta As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
