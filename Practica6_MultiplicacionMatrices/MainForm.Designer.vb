'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 27/09/2019
' Time: 07:47 a. m.
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
		Me.txtMatrizA = New System.Windows.Forms.TextBox()
		Me.txtMatrizB = New System.Windows.Forms.TextBox()
		Me.txtMatrizC = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.label4 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'txtMatrizA
		'
		Me.txtMatrizA.Location = New System.Drawing.Point(53, 56)
		Me.txtMatrizA.Multiline = true
		Me.txtMatrizA.Name = "txtMatrizA"
		Me.txtMatrizA.Size = New System.Drawing.Size(200, 200)
		Me.txtMatrizA.TabIndex = 0
		Me.txtMatrizA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtMatrizA.TextChanged, AddressOf Me.TxtMatrizATextChanged
		'
		'txtMatrizB
		'
		Me.txtMatrizB.Location = New System.Drawing.Point(322, 56)
		Me.txtMatrizB.Multiline = true
		Me.txtMatrizB.Name = "txtMatrizB"
		Me.txtMatrizB.Size = New System.Drawing.Size(200, 200)
		Me.txtMatrizB.TabIndex = 1
		Me.txtMatrizB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtMatrizB.TextChanged, AddressOf Me.TxtMatrizBTextChanged
		'
		'txtMatrizC
		'
		Me.txtMatrizC.Location = New System.Drawing.Point(322, 285)
		Me.txtMatrizC.Multiline = true
		Me.txtMatrizC.Name = "txtMatrizC"
		Me.txtMatrizC.Size = New System.Drawing.Size(200, 200)
		Me.txtMatrizC.TabIndex = 2
		Me.txtMatrizC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtMatrizC.Visible = false
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(53, 30)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(200, 23)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Imgrese los valores de la ""Matriz A"" separados por comas:"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(322, 30)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(200, 23)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Imgrese los valores de la ""Matriz B"" separados por comas:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(322, 259)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(200, 23)
		Me.label3.TabIndex = 5
		Me.label3.Text = "Matriz resultante"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(53, 285)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(200, 39)
		Me.btnCalcular.TabIndex = 6
		Me.btnCalcular.Text = "Calcular"
		Me.btnCalcular.UseVisualStyleBackColor = true
		AddHandler Me.btnCalcular.Click, AddressOf Me.BtnCalcularClick
		'
		'btnLimpiar
		'
		Me.btnLimpiar.Location = New System.Drawing.Point(53, 330)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(200, 39)
		Me.btnLimpiar.TabIndex = 7
		Me.btnLimpiar.Text = "Limpiar valores"
		Me.btnLimpiar.UseVisualStyleBackColor = true
		'
		'btnSalir
		'
		Me.btnSalir.Location = New System.Drawing.Point(53, 446)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(200, 39)
		Me.btnSalir.TabIndex = 8
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = true
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Wide Latin", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(259, 144)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(56, 50)
		Me.label4.TabIndex = 9
		Me.label4.Text = "X"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = true
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(540, 496)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnCalcular)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.txtMatrizC)
		Me.Controls.Add(Me.txtMatrizB)
		Me.Controls.Add(Me.txtMatrizA)
		Me.Name = "MainForm"
		Me.Padding = New System.Windows.Forms.Padding(50, 30, 50, 30)
		Me.Text = "Multiplicación de matrices"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label4 As System.Windows.Forms.Label
	Private btnSalir As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private btnCalcular As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private txtMatrizC As System.Windows.Forms.TextBox
	Private txtMatrizB As System.Windows.Forms.TextBox
	Private txtMatrizA As System.Windows.Forms.TextBox
End Class
