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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmbOrganos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDosisFisica = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorConstraint = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEQD2Organo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBEDOrgano = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSesiones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAlphaBeta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEQD2Calculado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBEDCalculado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbOrganos
        '
        Me.cmbOrganos.FormattingEnabled = True
        Me.cmbOrganos.Location = New System.Drawing.Point(162, 57)
        Me.cmbOrganos.Name = "cmbOrganos"
        Me.cmbOrganos.Size = New System.Drawing.Size(155, 21)
        Me.cmbOrganos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ÓRGANO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DOSIS FISICA:"
        '
        'txtDosisFisica
        '
        Me.txtDosisFisica.Location = New System.Drawing.Point(162, 112)
        Me.txtDosisFisica.Name = "txtDosisFisica"
        Me.txtDosisFisica.Size = New System.Drawing.Size(100, 20)
        Me.txtDosisFisica.TabIndex = 3
        Me.txtDosisFisica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CONSTRAINT (Gy)"
        '
        'txtValorConstraint
        '
        Me.txtValorConstraint.Location = New System.Drawing.Point(358, 57)
        Me.txtValorConstraint.Name = "txtValorConstraint"
        Me.txtValorConstraint.Size = New System.Drawing.Size(100, 20)
        Me.txtValorConstraint.TabIndex = 5
        Me.txtValorConstraint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(490, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "EQD2 (Gy)"
        '
        'txtEQD2Organo
        '
        Me.txtEQD2Organo.Location = New System.Drawing.Point(483, 58)
        Me.txtEQD2Organo.Name = "txtEQD2Organo"
        Me.txtEQD2Organo.Size = New System.Drawing.Size(74, 20)
        Me.txtEQD2Organo.TabIndex = 7
        Me.txtEQD2Organo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(598, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "BED (Gy)"
        '
        'txtBEDOrgano
        '
        Me.txtBEDOrgano.Location = New System.Drawing.Point(582, 58)
        Me.txtBEDOrgano.Name = "txtBEDOrgano"
        Me.txtBEDOrgano.Size = New System.Drawing.Size(80, 20)
        Me.txtBEDOrgano.TabIndex = 9
        Me.txtBEDOrgano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(162, 226)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "N° DE FRACCIONES:"
        '
        'txtSesiones
        '
        Me.txtSesiones.Location = New System.Drawing.Point(162, 145)
        Me.txtSesiones.Name = "txtSesiones"
        Me.txtSesiones.Size = New System.Drawing.Size(100, 20)
        Me.txtSesiones.TabIndex = 12
        Me.txtSesiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "ALFA/BETA:"
        '
        'txtAlphaBeta
        '
        Me.txtAlphaBeta.Location = New System.Drawing.Point(162, 181)
        Me.txtAlphaBeta.Name = "txtAlphaBeta"
        Me.txtAlphaBeta.Size = New System.Drawing.Size(100, 20)
        Me.txtAlphaBeta.TabIndex = 14
        Me.txtAlphaBeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(482, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "EQD2 CALC (Gy)"
        '
        'txtEQD2Calculado
        '
        Me.txtEQD2Calculado.Location = New System.Drawing.Point(483, 116)
        Me.txtEQD2Calculado.Name = "txtEQD2Calculado"
        Me.txtEQD2Calculado.Size = New System.Drawing.Size(74, 20)
        Me.txtEQD2Calculado.TabIndex = 16
        Me.txtEQD2Calculado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(590, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "BED CALC (Gy)"
        '
        'txtBEDCalculado
        '
        Me.txtBEDCalculado.Location = New System.Drawing.Point(582, 116)
        Me.txtBEDCalculado.Name = "txtBEDCalculado"
        Me.txtBEDCalculado.Size = New System.Drawing.Size(80, 20)
        Me.txtBEDCalculado.TabIndex = 18
        Me.txtBEDCalculado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 301)
        Me.Controls.Add(Me.txtBEDCalculado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEQD2Calculado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAlphaBeta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSesiones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtBEDOrgano)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEQD2Organo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtValorConstraint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDosisFisica)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbOrganos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Calculadora dosis física a EQD2/BED"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbOrganos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDosisFisica As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValorConstraint As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEQD2Organo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBEDOrgano As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSesiones As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAlphaBeta As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEQD2Calculado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBEDCalculado As TextBox
End Class
