﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmb_cantidadDocenas = New System.Windows.Forms.ComboBox()
        Me.lbl_cantidadDocenas = New System.Windows.Forms.Label()
        Me.cbx_demandaAnterior = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        Me.TabPage1.Controls.Add(Me.cbx_demandaAnterior)
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
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(741, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmb_cantidadDocenas
        '
        Me.cmb_cantidadDocenas.FormattingEnabled = True
        Me.cmb_cantidadDocenas.Location = New System.Drawing.Point(157, 35)
        Me.cmb_cantidadDocenas.Name = "cmb_cantidadDocenas"
        Me.cmb_cantidadDocenas.Size = New System.Drawing.Size(169, 21)
        Me.cmb_cantidadDocenas.TabIndex = 0
        '
        'lbl_cantidadDocenas
        '
        Me.lbl_cantidadDocenas.AutoSize = True
        Me.lbl_cantidadDocenas.Location = New System.Drawing.Point(22, 38)
        Me.lbl_cantidadDocenas.Name = "lbl_cantidadDocenas"
        Me.lbl_cantidadDocenas.Size = New System.Drawing.Size(108, 13)
        Me.lbl_cantidadDocenas.TabIndex = 1
        Me.lbl_cantidadDocenas.Text = "Cantidad de docenas"
        '
        'cbx_demandaAnterior
        '
        Me.cbx_demandaAnterior.AutoSize = True
        Me.cbx_demandaAnterior.Location = New System.Drawing.Point(157, 62)
        Me.cbx_demandaAnterior.Name = "cbx_demandaAnterior"
        Me.cbx_demandaAnterior.Size = New System.Drawing.Size(169, 17)
        Me.cbx_demandaAnterior.TabIndex = 2
        Me.cbx_demandaAnterior.Text = "Usar demanda del día anterior"
        Me.cbx_demandaAnterior.UseVisualStyleBackColor = True
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cbx_demandaAnterior As CheckBox
    Friend WithEvents lbl_cantidadDocenas As Label
    Friend WithEvents cmb_cantidadDocenas As ComboBox
    Friend WithEvents TabPage2 As TabPage
End Class