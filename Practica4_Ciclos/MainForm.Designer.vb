'
' Created by SharpDevelop.
' User: E19
' Date: 13/09/2019
' Time: 07:43 a. m.
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
		Me.txtSup = New System.Windows.Forms.TextBox()
		Me.txtInf = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.btnCalcular = New System.Windows.Forms.Button()
		Me.lblResultado = New System.Windows.Forms.Label()
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(77, 129)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(181, 205)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pictureBox1.TabIndex = 0
		Me.pictureBox1.TabStop = false
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(77, 79)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(181, 21)
		Me.label1.TabIndex = 1
		Me.label1.Text = "Limite superior"
		'
		'txtSup
		'
		Me.txtSup.Location = New System.Drawing.Point(77, 103)
		Me.txtSup.Name = "txtSup"
		Me.txtSup.Size = New System.Drawing.Size(181, 20)
		Me.txtSup.TabIndex = 2
		Me.txtSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtSup.TextChanged, AddressOf Me.TxtSupTextChanged
		'
		'txtInf
		'
		Me.txtInf.Location = New System.Drawing.Point(77, 354)
		Me.txtInf.Name = "txtInf"
		Me.txtInf.Size = New System.Drawing.Size(181, 20)
		Me.txtInf.TabIndex = 4
		Me.txtInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me.txtInf.TextChanged, AddressOf Me.TxtInfTextChanged
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(77, 337)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(181, 14)
		Me.label2.TabIndex = 3
		Me.label2.Text = "Limite inferior"
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight
		Me.label3.Location = New System.Drawing.Point(270, 199)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(160, 16)
		Me.label3.TabIndex = 5
		Me.label3.Text = "f(x) = 1/x"
		'
		'btnCalcular
		'
		Me.btnCalcular.Location = New System.Drawing.Point(270, 218)
		Me.btnCalcular.Name = "btnCalcular"
		Me.btnCalcular.Size = New System.Drawing.Size(160, 23)
		Me.btnCalcular.TabIndex = 6
		Me.btnCalcular.Text = "Calcular sumatoria"
		Me.btnCalcular.UseVisualStyleBackColor = true
		AddHandler Me.btnCalcular.Click, AddressOf Me.BtnCalcularClick
		'
		'lblResultado
		'
		Me.lblResultado.Location = New System.Drawing.Point(270, 244)
		Me.lblResultado.Name = "lblResultado"
		Me.lblResultado.Size = New System.Drawing.Size(160, 126)
		Me.lblResultado.TabIndex = 7
		Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(507, 501)
		Me.Controls.Add(Me.lblResultado)
		Me.Controls.Add(Me.btnCalcular)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.txtInf)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.txtSup)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.pictureBox1)
		Me.Name = "MainForm"
		Me.Text = "Sumatoria con Ciclos"
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lblResultado As System.Windows.Forms.Label
	Private btnCalcular As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private txtInf As System.Windows.Forms.TextBox
	Private txtSup As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
End Class
