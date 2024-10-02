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
        Me.GBIngresoDatos = New System.Windows.Forms.GroupBox()
        Me.ChkSplit = New System.Windows.Forms.CheckBox()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.LblPais = New System.Windows.Forms.Label()
        Me.TxtFrigorias = New System.Windows.Forms.TextBox()
        Me.LblFrigorias = New System.Windows.Forms.Label()
        Me.RbFrioCalor = New System.Windows.Forms.RadioButton()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.RbFrioSolo = New System.Windows.Forms.RadioButton()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.GBControlEquipo = New System.Windows.Forms.GroupBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.TxtTemperatura = New System.Windows.Forms.TextBox()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnSubir = New System.Windows.Forms.Button()
        Me.BtnBajar = New System.Windows.Forms.Button()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.BtnPower = New System.Windows.Forms.Button()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.GBIngresoDatos.SuspendLayout()
        Me.GBControlEquipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBIngresoDatos
        '
        Me.GBIngresoDatos.BackColor = System.Drawing.Color.Teal
        Me.GBIngresoDatos.Controls.Add(Me.ChkSplit)
        Me.GBIngresoDatos.Controls.Add(Me.TxtPais)
        Me.GBIngresoDatos.Controls.Add(Me.LblPais)
        Me.GBIngresoDatos.Controls.Add(Me.TxtFrigorias)
        Me.GBIngresoDatos.Controls.Add(Me.LblFrigorias)
        Me.GBIngresoDatos.Controls.Add(Me.RbFrioCalor)
        Me.GBIngresoDatos.Controls.Add(Me.BtnAlta)
        Me.GBIngresoDatos.Controls.Add(Me.RbFrioSolo)
        Me.GBIngresoDatos.Controls.Add(Me.TxtMarca)
        Me.GBIngresoDatos.Controls.Add(Me.LblMarca)
        Me.GBIngresoDatos.Location = New System.Drawing.Point(26, 13)
        Me.GBIngresoDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBIngresoDatos.Name = "GBIngresoDatos"
        Me.GBIngresoDatos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBIngresoDatos.Size = New System.Drawing.Size(322, 370)
        Me.GBIngresoDatos.TabIndex = 0
        Me.GBIngresoDatos.TabStop = False
        Me.GBIngresoDatos.Text = "Ingreso de Datos"
        '
        'ChkSplit
        '
        Me.ChkSplit.AutoSize = True
        Me.ChkSplit.Location = New System.Drawing.Point(45, 171)
        Me.ChkSplit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkSplit.Name = "ChkSplit"
        Me.ChkSplit.Size = New System.Drawing.Size(55, 21)
        Me.ChkSplit.TabIndex = 9
        Me.ChkSplit.Text = "Split"
        Me.ChkSplit.UseVisualStyleBackColor = True
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(119, 201)
        Me.TxtPais.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(132, 24)
        Me.TxtPais.TabIndex = 8
        '
        'LblPais
        '
        Me.LblPais.AutoSize = True
        Me.LblPais.Location = New System.Drawing.Point(41, 201)
        Me.LblPais.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPais.Name = "LblPais"
        Me.LblPais.Size = New System.Drawing.Size(37, 17)
        Me.LblPais.TabIndex = 7
        Me.LblPais.Text = "Pais"
        '
        'TxtFrigorias
        '
        Me.TxtFrigorias.Location = New System.Drawing.Point(119, 122)
        Me.TxtFrigorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFrigorias.Name = "TxtFrigorias"
        Me.TxtFrigorias.Size = New System.Drawing.Size(132, 24)
        Me.TxtFrigorias.TabIndex = 6
        '
        'LblFrigorias
        '
        Me.LblFrigorias.AutoSize = True
        Me.LblFrigorias.Location = New System.Drawing.Point(41, 122)
        Me.LblFrigorias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFrigorias.Name = "LblFrigorias"
        Me.LblFrigorias.Size = New System.Drawing.Size(65, 17)
        Me.LblFrigorias.TabIndex = 5
        Me.LblFrigorias.Text = "Frigorias"
        '
        'RbFrioCalor
        '
        Me.RbFrioCalor.AutoSize = True
        Me.RbFrioCalor.Location = New System.Drawing.Point(45, 293)
        Me.RbFrioCalor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RbFrioCalor.Name = "RbFrioCalor"
        Me.RbFrioCalor.Size = New System.Drawing.Size(90, 21)
        Me.RbFrioCalor.TabIndex = 4
        Me.RbFrioCalor.TabStop = True
        Me.RbFrioCalor.Text = "Frio/Calor"
        Me.RbFrioCalor.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.BackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAlta.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnAlta.Location = New System.Drawing.Point(209, 285)
        Me.BtnAlta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(100, 30)
        Me.BtnAlta.TabIndex = 3
        Me.BtnAlta.Text = "Alta"
        Me.BtnAlta.UseVisualStyleBackColor = False
        '
        'RbFrioSolo
        '
        Me.RbFrioSolo.AutoSize = True
        Me.RbFrioSolo.Location = New System.Drawing.Point(45, 251)
        Me.RbFrioSolo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RbFrioSolo.Name = "RbFrioSolo"
        Me.RbFrioSolo.Size = New System.Drawing.Size(84, 21)
        Me.RbFrioSolo.TabIndex = 2
        Me.RbFrioSolo.TabStop = True
        Me.RbFrioSolo.Text = "Frio Solo"
        Me.RbFrioSolo.UseVisualStyleBackColor = True
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(119, 71)
        Me.TxtMarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(132, 24)
        Me.TxtMarca.TabIndex = 1
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(41, 71)
        Me.LblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(48, 17)
        Me.LblMarca.TabIndex = 0
        Me.LblMarca.Text = "Marca"
        '
        'GBControlEquipo
        '
        Me.GBControlEquipo.BackColor = System.Drawing.Color.DarkCyan
        Me.GBControlEquipo.Controls.Add(Me.LblEstado)
        Me.GBControlEquipo.Controls.Add(Me.TxtTemperatura)
        Me.GBControlEquipo.Controls.Add(Me.BtnMax)
        Me.GBControlEquipo.Controls.Add(Me.BtnMin)
        Me.GBControlEquipo.Controls.Add(Me.BtnSubir)
        Me.GBControlEquipo.Controls.Add(Me.BtnBajar)
        Me.GBControlEquipo.Controls.Add(Me.TxtModelo)
        Me.GBControlEquipo.Controls.Add(Me.BtnPower)
        Me.GBControlEquipo.Controls.Add(Me.LblModelo)
        Me.GBControlEquipo.Location = New System.Drawing.Point(392, 13)
        Me.GBControlEquipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBControlEquipo.Name = "GBControlEquipo"
        Me.GBControlEquipo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GBControlEquipo.Size = New System.Drawing.Size(383, 370)
        Me.GBControlEquipo.TabIndex = 1
        Me.GBControlEquipo.TabStop = False
        Me.GBControlEquipo.Text = "Control de Equipo"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.BackColor = System.Drawing.Color.CadetBlue
        Me.LblEstado.Location = New System.Drawing.Point(141, 93)
        Me.LblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(0, 17)
        Me.LblEstado.TabIndex = 17
        '
        'TxtTemperatura
        '
        Me.TxtTemperatura.Location = New System.Drawing.Point(121, 118)
        Me.TxtTemperatura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTemperatura.Multiline = True
        Me.TxtTemperatura.Name = "TxtTemperatura"
        Me.TxtTemperatura.Size = New System.Drawing.Size(132, 71)
        Me.TxtTemperatura.TabIndex = 16
        '
        'BtnMax
        '
        Me.BtnMax.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnMax.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnMax.Location = New System.Drawing.Point(209, 289)
        Me.BtnMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(100, 30)
        Me.BtnMax.TabIndex = 15
        Me.BtnMax.Text = "Max"
        Me.BtnMax.UseVisualStyleBackColor = False
        '
        'BtnMin
        '
        Me.BtnMin.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnMin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnMin.Location = New System.Drawing.Point(71, 293)
        Me.BtnMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(100, 30)
        Me.BtnMin.TabIndex = 14
        Me.BtnMin.Text = "Min"
        Me.BtnMin.UseVisualStyleBackColor = False
        '
        'BtnSubir
        '
        Me.BtnSubir.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnSubir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSubir.Location = New System.Drawing.Point(272, 224)
        Me.BtnSubir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSubir.Name = "BtnSubir"
        Me.BtnSubir.Size = New System.Drawing.Size(77, 30)
        Me.BtnSubir.TabIndex = 12
        Me.BtnSubir.Text = "+"
        Me.BtnSubir.UseVisualStyleBackColor = False
        '
        'BtnBajar
        '
        Me.BtnBajar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnBajar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBajar.Location = New System.Drawing.Point(33, 224)
        Me.BtnBajar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBajar.Name = "BtnBajar"
        Me.BtnBajar.Size = New System.Drawing.Size(71, 30)
        Me.BtnBajar.TabIndex = 11
        Me.BtnBajar.Text = "-"
        Me.BtnBajar.UseVisualStyleBackColor = False
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(108, 44)
        Me.TxtModelo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(177, 24)
        Me.TxtModelo.TabIndex = 10
        '
        'BtnPower
        '
        Me.BtnPower.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnPower.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnPower.Location = New System.Drawing.Point(141, 224)
        Me.BtnPower.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPower.Name = "BtnPower"
        Me.BtnPower.Size = New System.Drawing.Size(100, 30)
        Me.BtnPower.TabIndex = 10
        Me.BtnPower.Text = "POWER"
        Me.BtnPower.UseVisualStyleBackColor = False
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Location = New System.Drawing.Point(48, 48)
        Me.LblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(54, 17)
        Me.LblModelo.TabIndex = 0
        Me.LblModelo.Text = "Modelo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(802, 419)
        Me.Controls.Add(Me.GBControlEquipo)
        Me.Controls.Add(Me.GBIngresoDatos)
        Me.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "AireAcondicionado"
        Me.GBIngresoDatos.ResumeLayout(False)
        Me.GBIngresoDatos.PerformLayout()
        Me.GBControlEquipo.ResumeLayout(False)
        Me.GBControlEquipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBIngresoDatos As GroupBox
    Friend WithEvents ChkSplit As CheckBox
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents LblPais As Label
    Friend WithEvents TxtFrigorias As TextBox
    Friend WithEvents LblFrigorias As Label
    Friend WithEvents RbFrioCalor As RadioButton
    Friend WithEvents BtnAlta As Button
    Friend WithEvents RbFrioSolo As RadioButton
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents LblMarca As Label
    Friend WithEvents GBControlEquipo As GroupBox
    Friend WithEvents TxtTemperatura As TextBox
    Friend WithEvents BtnMax As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnSubir As Button
    Friend WithEvents BtnBajar As Button
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents BtnPower As Button
    Friend WithEvents LblModelo As Label
    Friend WithEvents LblEstado As Label
End Class
