'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 26/09/2019
' Time: 09:27 a. m.
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
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.comboBoxColA = New System.Windows.Forms.ComboBox()
		Me.comboBoxFilasA = New System.Windows.Forms.ComboBox()
		Me.textBoxA33 = New System.Windows.Forms.TextBox()
		Me.textBoxA32 = New System.Windows.Forms.TextBox()
		Me.textBoxA31 = New System.Windows.Forms.TextBox()
		Me.textBoxA30 = New System.Windows.Forms.TextBox()
		Me.textBoxA23 = New System.Windows.Forms.TextBox()
		Me.textBoxA22 = New System.Windows.Forms.TextBox()
		Me.textBoxA21 = New System.Windows.Forms.TextBox()
		Me.textBoxA20 = New System.Windows.Forms.TextBox()
		Me.textBoxA13 = New System.Windows.Forms.TextBox()
		Me.textBoxA12 = New System.Windows.Forms.TextBox()
		Me.textBoxA11 = New System.Windows.Forms.TextBox()
		Me.textBoxA10 = New System.Windows.Forms.TextBox()
		Me.textBoxA03 = New System.Windows.Forms.TextBox()
		Me.textBoxA02 = New System.Windows.Forms.TextBox()
		Me.textBoxA01 = New System.Windows.Forms.TextBox()
		Me.textBoxA00 = New System.Windows.Forms.TextBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.comboBoxColB = New System.Windows.Forms.ComboBox()
		Me.comboBoxFilasB = New System.Windows.Forms.ComboBox()
		Me.textBoxB33 = New System.Windows.Forms.TextBox()
		Me.textBoxB32 = New System.Windows.Forms.TextBox()
		Me.textBoxB31 = New System.Windows.Forms.TextBox()
		Me.textBoxB30 = New System.Windows.Forms.TextBox()
		Me.textBoxB23 = New System.Windows.Forms.TextBox()
		Me.textBoxB22 = New System.Windows.Forms.TextBox()
		Me.textBoxB21 = New System.Windows.Forms.TextBox()
		Me.textBoxB20 = New System.Windows.Forms.TextBox()
		Me.textBoxB13 = New System.Windows.Forms.TextBox()
		Me.textBoxB12 = New System.Windows.Forms.TextBox()
		Me.textBoxB11 = New System.Windows.Forms.TextBox()
		Me.textBoxB10 = New System.Windows.Forms.TextBox()
		Me.textBoxB03 = New System.Windows.Forms.TextBox()
		Me.textBoxB02 = New System.Windows.Forms.TextBox()
		Me.textBoxB01 = New System.Windows.Forms.TextBox()
		Me.textBoxB00 = New System.Windows.Forms.TextBox()
		Me.buttonCalcular = New System.Windows.Forms.Button()
		Me.buttonLimpiar = New System.Windows.Forms.Button()
		Me.buttonSalir = New System.Windows.Forms.Button()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.label2)
		Me.groupBox1.Controls.Add(Me.label1)
		Me.groupBox1.Controls.Add(Me.comboBoxColA)
		Me.groupBox1.Controls.Add(Me.comboBoxFilasA)
		Me.groupBox1.Controls.Add(Me.textBoxA33)
		Me.groupBox1.Controls.Add(Me.textBoxA32)
		Me.groupBox1.Controls.Add(Me.textBoxA31)
		Me.groupBox1.Controls.Add(Me.textBoxA30)
		Me.groupBox1.Controls.Add(Me.textBoxA23)
		Me.groupBox1.Controls.Add(Me.textBoxA22)
		Me.groupBox1.Controls.Add(Me.textBoxA21)
		Me.groupBox1.Controls.Add(Me.textBoxA20)
		Me.groupBox1.Controls.Add(Me.textBoxA13)
		Me.groupBox1.Controls.Add(Me.textBoxA12)
		Me.groupBox1.Controls.Add(Me.textBoxA11)
		Me.groupBox1.Controls.Add(Me.textBoxA10)
		Me.groupBox1.Controls.Add(Me.textBoxA03)
		Me.groupBox1.Controls.Add(Me.textBoxA02)
		Me.groupBox1.Controls.Add(Me.textBoxA01)
		Me.groupBox1.Controls.Add(Me.textBoxA00)
		Me.groupBox1.Location = New System.Drawing.Point(21, 26)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(171, 181)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Matriz A"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(99, 128)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(54, 23)
		Me.label2.TabIndex = 19
		Me.label2.Text = "Columnas"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(15, 128)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(40, 23)
		Me.label1.TabIndex = 18
		Me.label1.Text = "Filas"
		'
		'comboBoxColA
		'
		Me.comboBoxColA.FormattingEnabled = true
		Me.comboBoxColA.Items.AddRange(New Object() {"1", "2", "3", "4"})
		Me.comboBoxColA.Location = New System.Drawing.Point(113, 154)
		Me.comboBoxColA.Name = "comboBoxColA"
		Me.comboBoxColA.Size = New System.Drawing.Size(40, 21)
		Me.comboBoxColA.TabIndex = 17
		AddHandler Me.comboBoxColA.SelectedIndexChanged, AddressOf Me.ComboBoxColASelectedIndexChanged
		'
		'comboBoxFilasA
		'
		Me.comboBoxFilasA.FormattingEnabled = true
		Me.comboBoxFilasA.Items.AddRange(New Object() {"1", "2", "3", "4"})
		Me.comboBoxFilasA.Location = New System.Drawing.Point(15, 154)
		Me.comboBoxFilasA.Name = "comboBoxFilasA"
		Me.comboBoxFilasA.Size = New System.Drawing.Size(40, 21)
		Me.comboBoxFilasA.TabIndex = 16
		AddHandler Me.comboBoxFilasA.SelectedIndexChanged, AddressOf Me.ComboBoxFilasASelectedIndexChanged
		'
		'textBoxA33
		'
		Me.textBoxA33.Location = New System.Drawing.Point(123, 97)
		Me.textBoxA33.Name = "textBoxA33"
		Me.textBoxA33.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA33.TabIndex = 15
		Me.textBoxA33.Visible = false
		'
		'textBoxA32
		'
		Me.textBoxA32.Location = New System.Drawing.Point(87, 97)
		Me.textBoxA32.Name = "textBoxA32"
		Me.textBoxA32.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA32.TabIndex = 14
		Me.textBoxA32.Visible = false
		'
		'textBoxA31
		'
		Me.textBoxA31.Location = New System.Drawing.Point(51, 97)
		Me.textBoxA31.Name = "textBoxA31"
		Me.textBoxA31.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA31.TabIndex = 13
		Me.textBoxA31.Visible = false
		'
		'textBoxA30
		'
		Me.textBoxA30.Location = New System.Drawing.Point(15, 97)
		Me.textBoxA30.Name = "textBoxA30"
		Me.textBoxA30.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA30.TabIndex = 12
		Me.textBoxA30.Visible = false
		'
		'textBoxA23
		'
		Me.textBoxA23.Location = New System.Drawing.Point(123, 71)
		Me.textBoxA23.Name = "textBoxA23"
		Me.textBoxA23.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA23.TabIndex = 11
		Me.textBoxA23.Visible = false
		'
		'textBoxA22
		'
		Me.textBoxA22.Location = New System.Drawing.Point(87, 71)
		Me.textBoxA22.Name = "textBoxA22"
		Me.textBoxA22.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA22.TabIndex = 10
		'
		'textBoxA21
		'
		Me.textBoxA21.Location = New System.Drawing.Point(51, 71)
		Me.textBoxA21.Name = "textBoxA21"
		Me.textBoxA21.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA21.TabIndex = 9
		'
		'textBoxA20
		'
		Me.textBoxA20.Location = New System.Drawing.Point(15, 71)
		Me.textBoxA20.Name = "textBoxA20"
		Me.textBoxA20.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA20.TabIndex = 8
		'
		'textBoxA13
		'
		Me.textBoxA13.Location = New System.Drawing.Point(123, 45)
		Me.textBoxA13.Name = "textBoxA13"
		Me.textBoxA13.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA13.TabIndex = 7
		Me.textBoxA13.Visible = false
		'
		'textBoxA12
		'
		Me.textBoxA12.Location = New System.Drawing.Point(87, 45)
		Me.textBoxA12.Name = "textBoxA12"
		Me.textBoxA12.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA12.TabIndex = 6
		'
		'textBoxA11
		'
		Me.textBoxA11.Location = New System.Drawing.Point(51, 45)
		Me.textBoxA11.Name = "textBoxA11"
		Me.textBoxA11.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA11.TabIndex = 5
		'
		'textBoxA10
		'
		Me.textBoxA10.Location = New System.Drawing.Point(15, 45)
		Me.textBoxA10.Name = "textBoxA10"
		Me.textBoxA10.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA10.TabIndex = 4
		'
		'textBoxA03
		'
		Me.textBoxA03.Location = New System.Drawing.Point(123, 19)
		Me.textBoxA03.Name = "textBoxA03"
		Me.textBoxA03.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA03.TabIndex = 3
		Me.textBoxA03.Visible = false
		'
		'textBoxA02
		'
		Me.textBoxA02.Location = New System.Drawing.Point(87, 19)
		Me.textBoxA02.Name = "textBoxA02"
		Me.textBoxA02.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA02.TabIndex = 2
		'
		'textBoxA01
		'
		Me.textBoxA01.Location = New System.Drawing.Point(51, 19)
		Me.textBoxA01.Name = "textBoxA01"
		Me.textBoxA01.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA01.TabIndex = 1
		'
		'textBoxA00
		'
		Me.textBoxA00.Location = New System.Drawing.Point(15, 19)
		Me.textBoxA00.Name = "textBoxA00"
		Me.textBoxA00.Size = New System.Drawing.Size(30, 20)
		Me.textBoxA00.TabIndex = 0
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.label3)
		Me.groupBox2.Controls.Add(Me.label4)
		Me.groupBox2.Controls.Add(Me.comboBoxColB)
		Me.groupBox2.Controls.Add(Me.comboBoxFilasB)
		Me.groupBox2.Controls.Add(Me.textBoxB33)
		Me.groupBox2.Controls.Add(Me.textBoxB32)
		Me.groupBox2.Controls.Add(Me.textBoxB31)
		Me.groupBox2.Controls.Add(Me.textBoxB30)
		Me.groupBox2.Controls.Add(Me.textBoxB23)
		Me.groupBox2.Controls.Add(Me.textBoxB22)
		Me.groupBox2.Controls.Add(Me.textBoxB21)
		Me.groupBox2.Controls.Add(Me.textBoxB20)
		Me.groupBox2.Controls.Add(Me.textBoxB13)
		Me.groupBox2.Controls.Add(Me.textBoxB12)
		Me.groupBox2.Controls.Add(Me.textBoxB11)
		Me.groupBox2.Controls.Add(Me.textBoxB10)
		Me.groupBox2.Controls.Add(Me.textBoxB03)
		Me.groupBox2.Controls.Add(Me.textBoxB02)
		Me.groupBox2.Controls.Add(Me.textBoxB01)
		Me.groupBox2.Controls.Add(Me.textBoxB00)
		Me.groupBox2.Location = New System.Drawing.Point(221, 26)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(171, 181)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Matriz B"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(99, 128)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(54, 23)
		Me.label3.TabIndex = 19
		Me.label3.Text = "Columnas"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(15, 128)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(40, 23)
		Me.label4.TabIndex = 18
		Me.label4.Text = "Filas"
		'
		'comboBoxColB
		'
		Me.comboBoxColB.FormattingEnabled = true
		Me.comboBoxColB.Items.AddRange(New Object() {"1", "2", "3", "4"})
		Me.comboBoxColB.Location = New System.Drawing.Point(113, 154)
		Me.comboBoxColB.Name = "comboBoxColB"
		Me.comboBoxColB.Size = New System.Drawing.Size(40, 21)
		Me.comboBoxColB.TabIndex = 17
		AddHandler Me.comboBoxColB.SelectedIndexChanged, AddressOf Me.ComboBoxColBSelectedIndexChanged
		'
		'comboBoxFilasB
		'
		Me.comboBoxFilasB.FormattingEnabled = true
		Me.comboBoxFilasB.Items.AddRange(New Object() {"1", "2", "3", "4"})
		Me.comboBoxFilasB.Location = New System.Drawing.Point(15, 154)
		Me.comboBoxFilasB.Name = "comboBoxFilasB"
		Me.comboBoxFilasB.Size = New System.Drawing.Size(40, 21)
		Me.comboBoxFilasB.TabIndex = 16
		AddHandler Me.comboBoxFilasB.SelectedIndexChanged, AddressOf Me.ComboBoxFilasBSelectedIndexChanged
		'
		'textBoxB33
		'
		Me.textBoxB33.Location = New System.Drawing.Point(123, 97)
		Me.textBoxB33.Name = "textBoxB33"
		Me.textBoxB33.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB33.TabIndex = 15
		Me.textBoxB33.Visible = false
		'
		'textBoxB32
		'
		Me.textBoxB32.Location = New System.Drawing.Point(87, 97)
		Me.textBoxB32.Name = "textBoxB32"
		Me.textBoxB32.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB32.TabIndex = 14
		Me.textBoxB32.Visible = false
		'
		'textBoxB31
		'
		Me.textBoxB31.Location = New System.Drawing.Point(51, 97)
		Me.textBoxB31.Name = "textBoxB31"
		Me.textBoxB31.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB31.TabIndex = 13
		Me.textBoxB31.Visible = false
		'
		'textBoxB30
		'
		Me.textBoxB30.Location = New System.Drawing.Point(15, 97)
		Me.textBoxB30.Name = "textBoxB30"
		Me.textBoxB30.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB30.TabIndex = 12
		Me.textBoxB30.Visible = false
		'
		'textBoxB23
		'
		Me.textBoxB23.Location = New System.Drawing.Point(123, 71)
		Me.textBoxB23.Name = "textBoxB23"
		Me.textBoxB23.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB23.TabIndex = 11
		Me.textBoxB23.Visible = false
		'
		'textBoxB22
		'
		Me.textBoxB22.Location = New System.Drawing.Point(87, 71)
		Me.textBoxB22.Name = "textBoxB22"
		Me.textBoxB22.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB22.TabIndex = 10
		'
		'textBoxB21
		'
		Me.textBoxB21.Location = New System.Drawing.Point(51, 71)
		Me.textBoxB21.Name = "textBoxB21"
		Me.textBoxB21.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB21.TabIndex = 9
		'
		'textBoxB20
		'
		Me.textBoxB20.Location = New System.Drawing.Point(15, 71)
		Me.textBoxB20.Name = "textBoxB20"
		Me.textBoxB20.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB20.TabIndex = 8
		'
		'textBoxB13
		'
		Me.textBoxB13.Location = New System.Drawing.Point(123, 45)
		Me.textBoxB13.Name = "textBoxB13"
		Me.textBoxB13.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB13.TabIndex = 7
		Me.textBoxB13.Visible = false
		'
		'textBoxB12
		'
		Me.textBoxB12.Location = New System.Drawing.Point(87, 45)
		Me.textBoxB12.Name = "textBoxB12"
		Me.textBoxB12.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB12.TabIndex = 6
		'
		'textBoxB11
		'
		Me.textBoxB11.Location = New System.Drawing.Point(51, 45)
		Me.textBoxB11.Name = "textBoxB11"
		Me.textBoxB11.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB11.TabIndex = 5
		'
		'textBoxB10
		'
		Me.textBoxB10.Location = New System.Drawing.Point(15, 45)
		Me.textBoxB10.Name = "textBoxB10"
		Me.textBoxB10.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB10.TabIndex = 4
		'
		'textBoxB03
		'
		Me.textBoxB03.Location = New System.Drawing.Point(123, 19)
		Me.textBoxB03.Name = "textBoxB03"
		Me.textBoxB03.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB03.TabIndex = 3
		Me.textBoxB03.Visible = false
		'
		'textBoxB02
		'
		Me.textBoxB02.Location = New System.Drawing.Point(87, 19)
		Me.textBoxB02.Name = "textBoxB02"
		Me.textBoxB02.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB02.TabIndex = 2
		'
		'textBoxB01
		'
		Me.textBoxB01.Location = New System.Drawing.Point(51, 19)
		Me.textBoxB01.Name = "textBoxB01"
		Me.textBoxB01.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB01.TabIndex = 1
		'
		'textBoxB00
		'
		Me.textBoxB00.Location = New System.Drawing.Point(15, 19)
		Me.textBoxB00.Name = "textBoxB00"
		Me.textBoxB00.Size = New System.Drawing.Size(30, 20)
		Me.textBoxB00.TabIndex = 0
		'
		'buttonCalcular
		'
		Me.buttonCalcular.Location = New System.Drawing.Point(410, 31)
		Me.buttonCalcular.Name = "buttonCalcular"
		Me.buttonCalcular.Size = New System.Drawing.Size(75, 23)
		Me.buttonCalcular.TabIndex = 2
		Me.buttonCalcular.Text = "Calcular"
		Me.buttonCalcular.UseVisualStyleBackColor = true
		'
		'buttonLimpiar
		'
		Me.buttonLimpiar.Location = New System.Drawing.Point(410, 149)
		Me.buttonLimpiar.Name = "buttonLimpiar"
		Me.buttonLimpiar.Size = New System.Drawing.Size(75, 23)
		Me.buttonLimpiar.TabIndex = 3
		Me.buttonLimpiar.Text = "Limpiar"
		Me.buttonLimpiar.UseVisualStyleBackColor = true
		'
		'buttonSalir
		'
		Me.buttonSalir.Location = New System.Drawing.Point(410, 184)
		Me.buttonSalir.Name = "buttonSalir"
		Me.buttonSalir.Size = New System.Drawing.Size(75, 23)
		Me.buttonSalir.TabIndex = 4
		Me.buttonSalir.Text = "Salir"
		Me.buttonSalir.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(498, 218)
		Me.Controls.Add(Me.buttonSalir)
		Me.Controls.Add(Me.buttonLimpiar)
		Me.Controls.Add(Me.buttonCalcular)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "ejemplo_6_matrices"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private buttonSalir As System.Windows.Forms.Button
	Private buttonLimpiar As System.Windows.Forms.Button
	Private buttonCalcular As System.Windows.Forms.Button
	Private textBoxB00 As System.Windows.Forms.TextBox
	Private textBoxB01 As System.Windows.Forms.TextBox
	Private textBoxB02 As System.Windows.Forms.TextBox
	Private textBoxB03 As System.Windows.Forms.TextBox
	Private textBoxB10 As System.Windows.Forms.TextBox
	Private textBoxB11 As System.Windows.Forms.TextBox
	Private textBoxB12 As System.Windows.Forms.TextBox
	Private textBoxB13 As System.Windows.Forms.TextBox
	Private textBoxB20 As System.Windows.Forms.TextBox
	Private textBoxB21 As System.Windows.Forms.TextBox
	Private textBoxB22 As System.Windows.Forms.TextBox
	Private textBoxB23 As System.Windows.Forms.TextBox
	Private textBoxB30 As System.Windows.Forms.TextBox
	Private textBoxB31 As System.Windows.Forms.TextBox
	Private textBoxB32 As System.Windows.Forms.TextBox
	Private textBoxB33 As System.Windows.Forms.TextBox
	Private comboBoxFilasB As System.Windows.Forms.ComboBox
	Private comboBoxColB As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private textBoxA00 As System.Windows.Forms.TextBox
	Private textBoxA01 As System.Windows.Forms.TextBox
	Private textBoxA02 As System.Windows.Forms.TextBox
	Private textBoxA03 As System.Windows.Forms.TextBox
	Private textBoxA10 As System.Windows.Forms.TextBox
	Private textBoxA11 As System.Windows.Forms.TextBox
	Private textBoxA12 As System.Windows.Forms.TextBox
	Private textBoxA13 As System.Windows.Forms.TextBox
	Private textBoxA20 As System.Windows.Forms.TextBox
	Private textBoxA21 As System.Windows.Forms.TextBox
	Private textBoxA22 As System.Windows.Forms.TextBox
	Private textBoxA23 As System.Windows.Forms.TextBox
	Private textBoxA30 As System.Windows.Forms.TextBox
	Private textBoxA31 As System.Windows.Forms.TextBox
	Private textBoxA32 As System.Windows.Forms.TextBox
	Private textBoxA33 As System.Windows.Forms.TextBox
	Private comboBoxFilasA As System.Windows.Forms.ComboBox
	Private comboBoxColA As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
