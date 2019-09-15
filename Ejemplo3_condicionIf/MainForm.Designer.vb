'
' Created by SharpDevelop.
' User: E19
' Date: 29/08/2019
' Time: 09:32 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.chbPrimaria = New System.Windows.Forms.CheckBox()
		Me.chbSecundaria = New System.Windows.Forms.CheckBox()
		Me.chbPrepa = New System.Windows.Forms.CheckBox()
		Me.chbUniversidad = New System.Windows.Forms.CheckBox()
		Me.rdbSoltero = New System.Windows.Forms.RadioButton()
		Me.rdbCasado = New System.Windows.Forms.RadioButton()
		Me.rdbSi = New System.Windows.Forms.RadioButton()
		Me.rdbNo = New System.Windows.Forms.RadioButton()
		Me.btnValidar = New System.Windows.Forms.Button()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.SuspendLayout
		'
		'chbPrimaria
		'
		Me.chbPrimaria.Location = New System.Drawing.Point(12, 41)
		Me.chbPrimaria.Name = "chbPrimaria"
		Me.chbPrimaria.Size = New System.Drawing.Size(104, 24)
		Me.chbPrimaria.TabIndex = 0
		Me.chbPrimaria.Text = "Primaria"
		Me.chbPrimaria.UseVisualStyleBackColor = true
		AddHandler Me.chbPrimaria.CheckedChanged, AddressOf Me.ChbPrimariaCheckedChanged
		'
		'chbSecundaria
		'
		Me.chbSecundaria.Location = New System.Drawing.Point(12, 71)
		Me.chbSecundaria.Name = "chbSecundaria"
		Me.chbSecundaria.Size = New System.Drawing.Size(104, 24)
		Me.chbSecundaria.TabIndex = 1
		Me.chbSecundaria.Text = "Secundaria"
		Me.chbSecundaria.UseVisualStyleBackColor = true
		AddHandler Me.chbSecundaria.CheckedChanged, AddressOf Me.ChbSecundariaCheckedChanged
		'
		'chbPrepa
		'
		Me.chbPrepa.Location = New System.Drawing.Point(12, 102)
		Me.chbPrepa.Name = "chbPrepa"
		Me.chbPrepa.Size = New System.Drawing.Size(104, 24)
		Me.chbPrepa.TabIndex = 2
		Me.chbPrepa.Text = "Prepa"
		Me.chbPrepa.UseVisualStyleBackColor = true
		AddHandler Me.chbPrepa.CheckedChanged, AddressOf Me.ChbPrepaCheckedChanged
		'
		'chbUniversidad
		'
		Me.chbUniversidad.Location = New System.Drawing.Point(12, 132)
		Me.chbUniversidad.Name = "chbUniversidad"
		Me.chbUniversidad.Size = New System.Drawing.Size(104, 24)
		Me.chbUniversidad.TabIndex = 3
		Me.chbUniversidad.Text = "Universidad"
		Me.chbUniversidad.UseVisualStyleBackColor = true
		AddHandler Me.chbUniversidad.CheckedChanged, AddressOf Me.ChbUniversidadCheckedChanged
		'
		'rdbSoltero
		'
		Me.rdbSoltero.Checked = true
		Me.rdbSoltero.Location = New System.Drawing.Point(6, 29)
		Me.rdbSoltero.Name = "rdbSoltero"
		Me.rdbSoltero.Size = New System.Drawing.Size(64, 24)
		Me.rdbSoltero.TabIndex = 4
		Me.rdbSoltero.TabStop = true
		Me.rdbSoltero.Text = "Soltero"
		Me.rdbSoltero.UseVisualStyleBackColor = true
		'
		'rdbCasado
		'
		Me.rdbCasado.Location = New System.Drawing.Point(6, 60)
		Me.rdbCasado.Name = "rdbCasado"
		Me.rdbCasado.Size = New System.Drawing.Size(64, 24)
		Me.rdbCasado.TabIndex = 5
		Me.rdbCasado.Text = "Casado"
		Me.rdbCasado.UseVisualStyleBackColor = true
		'
		'rdbSi
		'
		Me.rdbSi.Checked = true
		Me.rdbSi.Location = New System.Drawing.Point(6, 28)
		Me.rdbSi.Name = "rdbSi"
		Me.rdbSi.Size = New System.Drawing.Size(47, 24)
		Me.rdbSi.TabIndex = 6
		Me.rdbSi.TabStop = true
		Me.rdbSi.Text = "Si"
		Me.rdbSi.UseVisualStyleBackColor = true
		'
		'rdbNo
		'
		Me.rdbNo.Location = New System.Drawing.Point(6, 60)
		Me.rdbNo.Name = "rdbNo"
		Me.rdbNo.Size = New System.Drawing.Size(47, 24)
		Me.rdbNo.TabIndex = 7
		Me.rdbNo.Text = "No"
		Me.rdbNo.UseVisualStyleBackColor = true
		'
		'btnValidar
		'
		Me.btnValidar.Location = New System.Drawing.Point(122, 132)
		Me.btnValidar.Name = "btnValidar"
		Me.btnValidar.Size = New System.Drawing.Size(75, 23)
		Me.btnValidar.TabIndex = 8
		Me.btnValidar.Text = "Validar"
		Me.btnValidar.UseVisualStyleBackColor = true
		AddHandler Me.btnValidar.Click, AddressOf Me.BtnValidarClick
		'
		'btnCerrar
		'
		Me.btnCerrar.Location = New System.Drawing.Point(204, 133)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(62, 23)
		Me.btnCerrar.TabIndex = 9
		Me.btnCerrar.Text = "Cerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.rdbSoltero)
		Me.groupBox1.Controls.Add(Me.rdbCasado)
		Me.groupBox1.Location = New System.Drawing.Point(122, 12)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(76, 100)
		Me.groupBox1.TabIndex = 10
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Edo. Civil"
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.rdbSi)
		Me.groupBox2.Controls.Add(Me.rdbNo)
		Me.groupBox2.Location = New System.Drawing.Point(204, 13)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(59, 100)
		Me.groupBox2.TabIndex = 11
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Trabaja"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 16)
		Me.label1.TabIndex = 12
		Me.label1.Text = "Nivel de estudios"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(278, 166)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.btnValidar)
		Me.Controls.Add(Me.chbUniversidad)
		Me.Controls.Add(Me.chbPrepa)
		Me.Controls.Add(Me.chbSecundaria)
		Me.Controls.Add(Me.chbPrimaria)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Ejemplo3_condicionIf"
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		Me.ResumeLayout(false)
	End Sub
	Private label1 As System.Windows.Forms.Label
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private btnCerrar As System.Windows.Forms.Button
	Private btnValidar As System.Windows.Forms.Button
	Private rdbNo As System.Windows.Forms.RadioButton
	Private rdbSi As System.Windows.Forms.RadioButton
	Private rdbCasado As System.Windows.Forms.RadioButton
	Private rdbSoltero As System.Windows.Forms.RadioButton
	Private chbUniversidad As System.Windows.Forms.CheckBox
	Private chbPrepa As System.Windows.Forms.CheckBox
	Private chbSecundaria As System.Windows.Forms.CheckBox
	Private chbPrimaria As System.Windows.Forms.CheckBox
	
	
	
End Class
