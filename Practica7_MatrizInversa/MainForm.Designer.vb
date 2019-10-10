'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 10/10/2019
' Time: 10:09 a. m.
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txtMatriz = New System.Windows.Forms.TextBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtMatrizInversa = New System.Windows.Forms.TextBox()
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txtMatriz)
		Me.groupBox1.Location = New System.Drawing.Point(12, 12)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(256, 274)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Matriz"
		'
		'txtMatriz
		'
		Me.txtMatriz.Location = New System.Drawing.Point(6, 19)
		Me.txtMatriz.Multiline = true
		Me.txtMatriz.Name = "txtMatriz"
		Me.txtMatriz.Size = New System.Drawing.Size(244, 249)
		Me.txtMatriz.TabIndex = 0
		Me.txtMatriz.Text = "1,1,0"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"1,0,1"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"0,1,0"
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.txtMatrizInversa)
		Me.groupBox2.Location = New System.Drawing.Point(346, 12)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(256, 274)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Matriz inversa"
		'
		'txtMatrizInversa
		'
		Me.txtMatrizInversa.Location = New System.Drawing.Point(6, 19)
		Me.txtMatrizInversa.Multiline = true
		Me.txtMatrizInversa.Name = "txtMatrizInversa"
		Me.txtMatrizInversa.Size = New System.Drawing.Size(244, 249)
		Me.txtMatrizInversa.TabIndex = 0
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(274, 200)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(66, 23)
		Me.btnCalcular.TabIndex = 2
		Me.btnCalcular.Text = "Calcular"
		Me.btnCalcular.UseVisualStyleBackColor = true
		AddHandler Me.btnCalcular.Click, AddressOf Me.BtnCalcularClick
		'
		'btnLimpiar
		'
		Me.btnLimpiar.Location = New System.Drawing.Point(274, 229)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(66, 23)
		Me.btnLimpiar.TabIndex = 3
		Me.btnLimpiar.Text = "Limpiar"
		Me.btnLimpiar.UseVisualStyleBackColor = true
		AddHandler Me.btnLimpiar.Click, AddressOf Me.BtnLimpiarClick
		'
		'btnSalir
		'
		Me.btnSalir.Location = New System.Drawing.Point(274, 258)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(66, 23)
		Me.btnSalir.TabIndex = 4
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = true
		AddHandler Me.btnSalir.Click, AddressOf Me.BtnSalirClick
		'
		'pictureBox1
		'
		Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"),System.Drawing.Image)
		Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.pictureBox1.Location = New System.Drawing.Point(274, 102)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(66, 50)
		Me.pictureBox1.TabIndex = 5
		Me.pictureBox1.TabStop = false
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(614, 298)
		Me.Controls.Add(Me.pictureBox1)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnCalcular)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Name = "MainForm"
		Me.Text = "Practica7_MatrizInversa"
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private btnSalir As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private btnCalcular As System.Windows.Forms.Button
	Private txtMatrizInversa As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private txtMatriz As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
