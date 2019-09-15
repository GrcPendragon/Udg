'
' Created by SharpDevelop.
' User: tecis
' Date: 22/08/2019
' Time: 09:13 a. m.
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
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtbValorA = New System.Windows.Forms.TextBox()
		Me.txtbValorB = New System.Windows.Forms.TextBox()
		Me.btnArea = New System.Windows.Forms.Button()
		Me.btnPerimetro = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"),System.Drawing.Image)
		Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pictureBox1.Location = New System.Drawing.Point(76, 12)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(291, 155)
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'txtbValorA
		'
		Me.txtbValorA.Location = New System.Drawing.Point(12, 82)
		Me.txtbValorA.Name = "txtbValorA"
		Me.txtbValorA.Size = New System.Drawing.Size(58, 20)
		Me.txtbValorA.TabIndex = 1
		'
		'txtbValorB
		'
		Me.txtbValorB.Location = New System.Drawing.Point(182, 196)
		Me.txtbValorB.Name = "txtbValorB"
		Me.txtbValorB.Size = New System.Drawing.Size(58, 20)
		Me.txtbValorB.TabIndex = 2
		'
		'btnArea
		'
		Me.btnArea.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnArea.Location = New System.Drawing.Point(445, 12)
		Me.btnArea.Name = "btnArea"
		Me.btnArea.Size = New System.Drawing.Size(167, 66)
		Me.btnArea.TabIndex = 3
		Me.btnArea.Text = "Área"
		Me.btnArea.UseVisualStyleBackColor = true
		AddHandler Me.btnArea.Click, AddressOf Me.BtnAreaClick
		'
		'btnPerimetro
		'
		Me.btnPerimetro.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPerimetro.Location = New System.Drawing.Point(445, 84)
		Me.btnPerimetro.Name = "btnPerimetro"
		Me.btnPerimetro.Size = New System.Drawing.Size(167, 66)
		Me.btnPerimetro.TabIndex = 4
		Me.btnPerimetro.Text = "Perimetro"
		Me.btnPerimetro.UseVisualStyleBackColor = true
		AddHandler Me.btnPerimetro.Click, AddressOf Me.BtnPerimetroClick
		'
		'btnSalir
		'
		Me.btnSalir.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSalir.Location = New System.Drawing.Point(445, 159)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(167, 66)
		Me.btnSalir.TabIndex = 5
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = true
		AddHandler Me.btnSalir.Click, AddressOf Me.BtnSalirClick
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 54)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(58, 23)
		Me.label1.TabIndex = 6
		Me.label1.Text = "Valor A"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(182, 170)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(58, 23)
		Me.label2.TabIndex = 7
		Me.label2.Text = "Valor B"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(624, 237)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnPerimetro)
		Me.Controls.Add(Me.btnArea)
		Me.Controls.Add(Me.txtbValorB)
		Me.Controls.Add(Me.txtbValorA)
		Me.Controls.Add(Me.pictureBox1)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Calculadora Triangulo"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private btnSalir As System.Windows.Forms.Button
	Private btnPerimetro As System.Windows.Forms.Button
	Private btnArea As System.Windows.Forms.Button
	Private txtbValorB As System.Windows.Forms.TextBox
	Private txtbValorA As System.Windows.Forms.TextBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
