<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.colaConsultas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colaUrgencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridUrgencias = New System.Windows.Forms.DataGridView()
        Me.gridConsultas = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_porcentaje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cant_filas = New System.Windows.Forms.TextBox()
        Me.txt_fila_inicial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Llegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosicionU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LlegadaU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridUrgencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.evento, Me.reloj, Me.rndLlegadaConsulta, Me.tProxConsulta, Me.tLlegadaConsulta, Me.rndLlegadaUrgencia, Me.tProxUrgencia, Me.tLlegadaUrgencia, Me.estadoMedico, Me.colaConsultas, Me.colaUrgencias, Me.consultaEnEspera, Me.tFaltanteConsulta, Me.rndTiempoAtConsulta, Me.tAtConsulta, Me.tFinAtConsulta, Me.rndTiempoAtUrgencia, Me.tAtUrgencia, Me.tFinAtUrgencia, Me.sumUrgencias, Me.sumPacientes})
        Me.grid.Location = New System.Drawing.Point(8, 203)
        Me.grid.Margin = New System.Windows.Forms.Padding(2)
        Me.grid.Name = "grid"
        Me.grid.RowTemplate.Height = 28
        Me.grid.Size = New System.Drawing.Size(1336, 431)
        Me.grid.TabIndex = 0
        '
        'evento
        '
        Me.evento.HeaderText = "Evento"
        Me.evento.Name = "evento"
        Me.evento.Width = 90
        '
        'reloj
        '
        Me.reloj.HeaderText = "Reloj"
        Me.reloj.Name = "reloj"
        Me.reloj.Width = 40
        '
        'rndLlegadaConsulta
        '
        Me.rndLlegadaConsulta.HeaderText = "RND Llegada consulta"
        Me.rndLlegadaConsulta.Name = "rndLlegadaConsulta"
        Me.rndLlegadaConsulta.Width = 60
        '
        'tProxConsulta
        '
        Me.tProxConsulta.HeaderText = "Tiempo hasta proxima consulta"
        Me.tProxConsulta.Name = "tProxConsulta"
        Me.tProxConsulta.Width = 60
        '
        'tLlegadaConsulta
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tLlegadaConsulta.DefaultCellStyle = DataGridViewCellStyle9
        Me.tLlegadaConsulta.HeaderText = "Tiempo llegada consulta"
        Me.tLlegadaConsulta.Name = "tLlegadaConsulta"
        Me.tLlegadaConsulta.Width = 60
        '
        'rndLlegadaUrgencia
        '
        Me.rndLlegadaUrgencia.HeaderText = "RND Llegada urgencia"
        Me.rndLlegadaUrgencia.Name = "rndLlegadaUrgencia"
        Me.rndLlegadaUrgencia.Width = 60
        '
        'tProxUrgencia
        '
        Me.tProxUrgencia.HeaderText = "Tiempo hasta proxima urgencia"
        Me.tProxUrgencia.Name = "tProxUrgencia"
        Me.tProxUrgencia.Width = 60
        '
        'tLlegadaUrgencia
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tLlegadaUrgencia.DefaultCellStyle = DataGridViewCellStyle10
        Me.tLlegadaUrgencia.HeaderText = "Tiempo llegada urgencia"
        Me.tLlegadaUrgencia.Name = "tLlegadaUrgencia"
        Me.tLlegadaUrgencia.Width = 60
        '
        'estadoMedico
        '
        Me.estadoMedico.HeaderText = "Estado medico"
        Me.estadoMedico.Name = "estadoMedico"
        Me.estadoMedico.Width = 60
        '
        'colaConsultas
        '
        Me.colaConsultas.HeaderText = "Cola de consultas"
        Me.colaConsultas.Name = "colaConsultas"
        Me.colaConsultas.Width = 60
        '
        'colaUrgencias
        '
        Me.colaUrgencias.HeaderText = "Cola de urgencias"
        Me.colaUrgencias.Name = "colaUrgencias"
        Me.colaUrgencias.Width = 60
        '
        'consultaEnEspera
        '
        Me.consultaEnEspera.HeaderText = "Hay consulta en espera?"
        Me.consultaEnEspera.Name = "consultaEnEspera"
        Me.consultaEnEspera.Width = 60
        '
        'tFaltanteConsulta
        '
        Me.tFaltanteConsulta.HeaderText = "Tiempo faltante consulta"
        Me.tFaltanteConsulta.Name = "tFaltanteConsulta"
        Me.tFaltanteConsulta.Width = 60
        '
        'rndTiempoAtConsulta
        '
        Me.rndTiempoAtConsulta.HeaderText = "RND Tiempo at. consulta"
        Me.rndTiempoAtConsulta.Name = "rndTiempoAtConsulta"
        Me.rndTiempoAtConsulta.Width = 60
        '
        'tAtConsulta
        '
        Me.tAtConsulta.HeaderText = "Tiempo at. consulta"
        Me.tAtConsulta.Name = "tAtConsulta"
        Me.tAtConsulta.Width = 60
        '
        'tFinAtConsulta
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tFinAtConsulta.DefaultCellStyle = DataGridViewCellStyle11
        Me.tFinAtConsulta.HeaderText = "Tiempo fin at. consulta"
        Me.tFinAtConsulta.Name = "tFinAtConsulta"
        Me.tFinAtConsulta.Width = 60
        '
        'rndTiempoAtUrgencia
        '
        Me.rndTiempoAtUrgencia.HeaderText = "RND Tiempo at. urgencia"
        Me.rndTiempoAtUrgencia.Name = "rndTiempoAtUrgencia"
        Me.rndTiempoAtUrgencia.Width = 60
        '
        'tAtUrgencia
        '
        Me.tAtUrgencia.HeaderText = "Tiempo at. urgencia"
        Me.tAtUrgencia.Name = "tAtUrgencia"
        Me.tAtUrgencia.Width = 60
        '
        'tFinAtUrgencia
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tFinAtUrgencia.DefaultCellStyle = DataGridViewCellStyle12
        Me.tFinAtUrgencia.HeaderText = "Tiempo fin at. urgencia"
        Me.tFinAtUrgencia.Name = "tFinAtUrgencia"
        Me.tFinAtUrgencia.Width = 60
        '
        'sumUrgencias
        '
        Me.sumUrgencias.HeaderText = "Sumatoria de urgencias"
        Me.sumUrgencias.Name = "sumUrgencias"
        Me.sumUrgencias.Width = 60
        '
        'sumPacientes
        '
        Me.sumPacientes.HeaderText = "Sumatoria de pacientes"
        Me.sumPacientes.Name = "sumPacientes"
        Me.sumPacientes.Width = 60
        '
        'txt_cantSimulaciones
        '
        Me.txt_cantSimulaciones.Location = New System.Drawing.Point(164, 18)
        Me.txt_cantSimulaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cantSimulaciones.Name = "txt_cantSimulaciones"
        Me.txt_cantSimulaciones.Size = New System.Drawing.Size(62, 20)
        Me.txt_cantSimulaciones.TabIndex = 1
        '
        'lbl_simulaciones
        '
        Me.lbl_simulaciones.AutoSize = True
        Me.lbl_simulaciones.Location = New System.Drawing.Point(11, 21)
        Me.lbl_simulaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_simulaciones.Name = "lbl_simulaciones"
        Me.lbl_simulaciones.Size = New System.Drawing.Size(149, 13)
        Me.lbl_simulaciones.TabIndex = 2
        Me.lbl_simulaciones.Text = "Cantidad de eventos a simular"
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(11, 175)
        Me.cmd_generar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(66, 24)
        Me.cmd_generar.TabIndex = 3
        Me.cmd_generar.Text = "Generar"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(404, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cola de consultas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(876, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cola de urgencias"
        '
        'gridUrgencias
        '
        Me.gridUrgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUrgencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PosicionU, Me.LlegadaU})
        Me.gridUrgencias.Location = New System.Drawing.Point(879, 64)
        Me.gridUrgencias.Name = "gridUrgencias"
        Me.gridUrgencias.Size = New System.Drawing.Size(466, 134)
        Me.gridUrgencias.TabIndex = 4
        '
        'gridConsultas
        '
        Me.gridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridConsultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Posicion, Me.Llegada})
        Me.gridConsultas.Location = New System.Drawing.Point(407, 64)
        Me.gridConsultas.Name = "gridConsultas"
        Me.gridConsultas.Size = New System.Drawing.Size(466, 134)
        Me.gridConsultas.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Porcentaje de urgencias atendidas"
        '
        'txt_porcentaje
        '
        Me.txt_porcentaje.Location = New System.Drawing.Point(188, 144)
        Me.txt_porcentaje.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_porcentaje.Name = "txt_porcentaje"
        Me.txt_porcentaje.Size = New System.Drawing.Size(62, 20)
        Me.txt_porcentaje.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad de filas a mostrar"
        '
        'txt_cant_filas
        '
        Me.txt_cant_filas.Location = New System.Drawing.Point(164, 42)
        Me.txt_cant_filas.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cant_filas.Name = "txt_cant_filas"
        Me.txt_cant_filas.Size = New System.Drawing.Size(62, 20)
        Me.txt_cant_filas.TabIndex = 7
        '
        'txt_fila_inicial
        '
        Me.txt_fila_inicial.Location = New System.Drawing.Point(164, 66)
        Me.txt_fila_inicial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_fila_inicial.Name = "txt_fila_inicial"
        Me.txt_fila_inicial.Size = New System.Drawing.Size(62, 20)
        Me.txt_fila_inicial.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mostrar desde la fila"
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posición"
        Me.Posicion.Name = "Posicion"
        '
        'Llegada
        '
        Me.Llegada.HeaderText = "Momento de llegada"
        Me.Llegada.Name = "Llegada"
        '
        'PosicionU
        '
        Me.PosicionU.HeaderText = "Posición"
        Me.PosicionU.Name = "PosicionU"
        '
        'LlegadaU
        '
        Me.LlegadaU.HeaderText = "Momento de llegada"
        Me.LlegadaU.Name = "LlegadaU"
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 649)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_fila_inicial)
        Me.Controls.Add(Me.txt_cant_filas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gridConsultas)
        Me.Controls.Add(Me.gridUrgencias)
        Me.Controls.Add(Me.cmd_generar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_simulaciones)
        Me.Controls.Add(Me.txt_porcentaje)
        Me.Controls.Add(Me.txt_cantSimulaciones)
        Me.Controls.Add(Me.grid)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Formulario"
        Me.Text = "TP5 Ejercicio 67"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridUrgencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid As DataGridView
    Friend WithEvents txt_cantSimulaciones As TextBox
    Friend WithEvents lbl_simulaciones As Label
    Friend WithEvents cmd_generar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gridUrgencias As DataGridView
    Friend WithEvents gridConsultas As DataGridView
    Friend WithEvents evento As DataGridViewTextBoxColumn
    Friend WithEvents reloj As DataGridViewTextBoxColumn
    Friend WithEvents rndLlegadaConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tProxConsulta As DataGridViewTextBoxColumn
    Friend WithEvents tLlegadaConsulta As DataGridViewTextBoxColumn
    Friend WithEvents rndLlegadaUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tProxUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents tLlegadaUrgencia As DataGridViewTextBoxColumn
    Friend WithEvents estadoMedico As DataGridViewTextBoxColumn
    Friend WithEvents colaConsultas As DataGridViewTextBoxColumn
    Friend WithEvents colaUrgencias As DataGridViewTextBoxColumn
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_porcentaje As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cant_filas As TextBox
    Friend WithEvents txt_fila_inicial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PosicionU As DataGridViewTextBoxColumn
    Friend WithEvents LlegadaU As DataGridViewTextBoxColumn
    Friend WithEvents Posicion As DataGridViewTextBoxColumn
    Friend WithEvents Llegada As DataGridViewTextBoxColumn
End Class
