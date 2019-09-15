'
' Created by SharpDevelop.
' User: tecis
' Date: 23/08/2019
' Time: 07:53 a. m.
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
		Me.label1 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtbCuerpoA = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.txtbDistancia = New System.Windows.Forms.TextBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.txtbCuerpoB = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.lblFuerza = New System.Windows.Forms.Label()
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"),System.Drawing.Image)
		Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(329, 156)
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 212)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(53, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Cuerpo A"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(257, 211)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(53, 23)
		Me.label3.TabIndex = 3
		Me.label3.Text = "Cuerpo B"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(146, 212)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(56, 23)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Distancia"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtbCuerpoA
		'
		Me.txtbCuerpoA.Location = New System.Drawing.Point(12, 238)
		Me.txtbCuerpoA.Name = "txtbCuerpoA"
		Me.txtbCuerpoA.Size = New System.Drawing.Size(53, 20)
		Me.txtbCuerpoA.TabIndex = 5
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(71, 238)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(25, 20)
		Me.label4.TabIndex = 6
		Me.label4.Text = "m1"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(205, 238)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(25, 20)
		Me.label5.TabIndex = 8
		Me.label5.Text = "r"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtbDistancia
		'
		Me.txtbDistancia.Location = New System.Drawing.Point(146, 238)
		Me.txtbDistancia.Name = "txtbDistancia"
		Me.txtbDistancia.Size = New System.Drawing.Size(53, 20)
		Me.txtbDistancia.TabIndex = 7
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(316, 237)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(25, 20)
		Me.label6.TabIndex = 10
		Me.label6.Text = "m2"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtbCuerpoB
		'
		Me.txtbCuerpoB.Location = New System.Drawing.Point(257, 237)
		Me.txtbCuerpoB.Name = "txtbCuerpoB"
		Me.txtbCuerpoB.Size = New System.Drawing.Size(53, 20)
		Me.txtbCuerpoB.TabIndex = 9
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(12, 298)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(53, 39)
		Me.label7.TabIndex = 11
		Me.label7.Text = "Fuerza:"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblFuerza
		'
		Me.lblFuerza.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblFuerza.Location = New System.Drawing.Point(71, 298)
		Me.lblFuerza.Name = "lblFuerza"
		Me.lblFuerza.Size = New System.Drawing.Size(270, 39)
		Me.lblFuerza.TabIndex = 12
		Me.lblFuerza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(12, 340)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(187, 47)
		Me.btnCalcular.TabIndex = 13
		Me.btnCalcular.Text = "Calcular Fuerza"
		Me.btnCalcular.UseVisualStyleBackColor = true
		AddHandler Me.btnCalcular.Click, AddressOf Me.BtnCalcularClick
		'
		'btnSalir
		'
		Me.btnSalir.Location = New System.Drawing.Point(205, 340)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(136, 47)
		Me.btnSalir.TabIndex = 14
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = true
		AddHandler Me.btnSalir.Click, AddressOf Me.BtnSalirClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(353, 399)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnCalcular)
		Me.Controls.Add(Me.lblFuerza)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.txtbCuerpoB)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.txtbDistancia)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.txtbCuerpoA)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.pictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Ley De Gravitacion Universal"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnSalir As System.Windows.Forms.Button
	Private btnCalcular As System.Windows.Forms.Button
	Private lblFuerza As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private txtbCuerpoB As System.Windows.Forms.TextBox
	Private label6 As System.Windows.Forms.Label
	Private txtbDistancia As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private txtbCuerpoA As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
