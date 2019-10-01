'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 26/09/2019
' Time: 09:28 a. m.
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
		Me.grbMatrizA00 = New System.Windows.Forms.GroupBox()
		Me.txtA00 = New System.Windows.Forms.TextBox()
		Me.txtA01 = New System.Windows.Forms.TextBox()
		Me.txtA02 = New System.Windows.Forms.TextBox()
		Me.txtA03 = New System.Windows.Forms.TextBox()
		Me.textBox5 = New System.Windows.Forms.TextBox()
		Me.txtA12 = New System.Windows.Forms.TextBox()
		Me.txtA11 = New System.Windows.Forms.TextBox()
		Me.txtA10 = New System.Windows.Forms.TextBox()
		Me.textBox9 = New System.Windows.Forms.TextBox()
		Me.textBox10 = New System.Windows.Forms.TextBox()
		Me.textBox11 = New System.Windows.Forms.TextBox()
		Me.textBox12 = New System.Windows.Forms.TextBox()
		Me.textBox13 = New System.Windows.Forms.TextBox()
		Me.textBox14 = New System.Windows.Forms.TextBox()
		Me.textBox15 = New System.Windows.Forms.TextBox()
		Me.textBox16 = New System.Windows.Forms.TextBox()
		Me.cmbFilasA = New System.Windows.Forms.ComboBox()
		Me.cmbColumnasA = New System.Windows.Forms.ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.grbMatrizB00 = New System.Windows.Forms.GroupBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.cmbColumnasB = New System.Windows.Forms.ComboBox()
		Me.cmbFilasB = New System.Windows.Forms.ComboBox()
		Me.textBox17 = New System.Windows.Forms.TextBox()
		Me.textBox18 = New System.Windows.Forms.TextBox()
		Me.textBox19 = New System.Windows.Forms.TextBox()
		Me.textBox20 = New System.Windows.Forms.TextBox()
		Me.textBox21 = New System.Windows.Forms.TextBox()
		Me.textBox22 = New System.Windows.Forms.TextBox()
		Me.textBox23 = New System.Windows.Forms.TextBox()
		Me.textBox24 = New System.Windows.Forms.TextBox()
		Me.textBox25 = New System.Windows.Forms.TextBox()
		Me.textBox26 = New System.Windows.Forms.TextBox()
		Me.textBox27 = New System.Windows.Forms.TextBox()
		Me.textBox28 = New System.Windows.Forms.TextBox()
		Me.textBox29 = New System.Windows.Forms.TextBox()
		Me.textBox30 = New System.Windows.Forms.TextBox()
		Me.textBox31 = New System.Windows.Forms.TextBox()
		Me.textBox32 = New System.Windows.Forms.TextBox()
		Me.grbMatrizA00.SuspendLayout
		Me.grbMatrizB00.SuspendLayout
		Me.SuspendLayout
		'
		'grbMatrizA00
		'
		Me.grbMatrizA00.Controls.Add(Me.label2)
		Me.grbMatrizA00.Controls.Add(Me.label1)
		Me.grbMatrizA00.Controls.Add(Me.cmbColumnasA)
		Me.grbMatrizA00.Controls.Add(Me.cmbFilasA)
		Me.grbMatrizA00.Controls.Add(Me.textBox9)
		Me.grbMatrizA00.Controls.Add(Me.textBox10)
		Me.grbMatrizA00.Controls.Add(Me.textBox11)
		Me.grbMatrizA00.Controls.Add(Me.textBox12)
		Me.grbMatrizA00.Controls.Add(Me.textBox13)
		Me.grbMatrizA00.Controls.Add(Me.textBox14)
		Me.grbMatrizA00.Controls.Add(Me.textBox15)
		Me.grbMatrizA00.Controls.Add(Me.textBox16)
		Me.grbMatrizA00.Controls.Add(Me.textBox5)
		Me.grbMatrizA00.Controls.Add(Me.txtA12)
		Me.grbMatrizA00.Controls.Add(Me.txtA11)
		Me.grbMatrizA00.Controls.Add(Me.txtA10)
		Me.grbMatrizA00.Controls.Add(Me.txtA03)
		Me.grbMatrizA00.Controls.Add(Me.txtA02)
		Me.grbMatrizA00.Controls.Add(Me.txtA01)
		Me.grbMatrizA00.Controls.Add(Me.txtA00)
		Me.grbMatrizA00.Location = New System.Drawing.Point(12, 106)
		Me.grbMatrizA00.Name = "grbMatrizA00"
		Me.grbMatrizA00.Size = New System.Drawing.Size(220, 197)
		Me.grbMatrizA00.TabIndex = 0
		Me.grbMatrizA00.TabStop = false
		Me.grbMatrizA00.Text = "Matriz A"
		'
		'txtA00
		'
		Me.txtA00.Location = New System.Drawing.Point(6, 19)
		Me.txtA00.Name = "txtA00"
		Me.txtA00.Size = New System.Drawing.Size(47, 20)
		Me.txtA00.TabIndex = 0
		'
		'txtA01
		'
		Me.txtA01.Location = New System.Drawing.Point(59, 19)
		Me.txtA01.Name = "txtA01"
		Me.txtA01.Size = New System.Drawing.Size(47, 20)
		Me.txtA01.TabIndex = 1
		'
		'txtA02
		'
		Me.txtA02.Location = New System.Drawing.Point(112, 19)
		Me.txtA02.Name = "txtA02"
		Me.txtA02.Size = New System.Drawing.Size(47, 20)
		Me.txtA02.TabIndex = 2
		'
		'txtA03
		'
		Me.txtA03.Location = New System.Drawing.Point(165, 19)
		Me.txtA03.Name = "txtA03"
		Me.txtA03.Size = New System.Drawing.Size(47, 20)
		Me.txtA03.TabIndex = 3
		'
		'textBox5
		'
		Me.textBox5.Location = New System.Drawing.Point(165, 45)
		Me.textBox5.Name = "textBox5"
		Me.textBox5.Size = New System.Drawing.Size(47, 20)
		Me.textBox5.TabIndex = 7
		'
		'txtA12
		'
		Me.txtA12.Location = New System.Drawing.Point(112, 45)
		Me.txtA12.Name = "txtA12"
		Me.txtA12.Size = New System.Drawing.Size(47, 20)
		Me.txtA12.TabIndex = 6
		'
		'txtA11
		'
		Me.txtA11.Location = New System.Drawing.Point(59, 45)
		Me.txtA11.Name = "txtA11"
		Me.txtA11.Size = New System.Drawing.Size(47, 20)
		Me.txtA11.TabIndex = 5
		'
		'txtA10
		'
		Me.txtA10.Location = New System.Drawing.Point(6, 45)
		Me.txtA10.Name = "txtA10"
		Me.txtA10.Size = New System.Drawing.Size(47, 20)
		Me.txtA10.TabIndex = 4
		'
		'textBox9
		'
		Me.textBox9.Location = New System.Drawing.Point(165, 97)
		Me.textBox9.Name = "textBox9"
		Me.textBox9.Size = New System.Drawing.Size(47, 20)
		Me.textBox9.TabIndex = 15
		'
		'textBox10
		'
		Me.textBox10.Location = New System.Drawing.Point(112, 97)
		Me.textBox10.Name = "textBox10"
		Me.textBox10.Size = New System.Drawing.Size(47, 20)
		Me.textBox10.TabIndex = 14
		'
		'textBox11
		'
		Me.textBox11.Location = New System.Drawing.Point(59, 97)
		Me.textBox11.Name = "textBox11"
		Me.textBox11.Size = New System.Drawing.Size(47, 20)
		Me.textBox11.TabIndex = 13
		'
		'textBox12
		'
		Me.textBox12.Location = New System.Drawing.Point(6, 97)
		Me.textBox12.Name = "textBox12"
		Me.textBox12.Size = New System.Drawing.Size(47, 20)
		Me.textBox12.TabIndex = 12
		'
		'textBox13
		'
		Me.textBox13.Location = New System.Drawing.Point(165, 71)
		Me.textBox13.Name = "textBox13"
		Me.textBox13.Size = New System.Drawing.Size(47, 20)
		Me.textBox13.TabIndex = 11
		'
		'textBox14
		'
		Me.textBox14.Location = New System.Drawing.Point(112, 71)
		Me.textBox14.Name = "textBox14"
		Me.textBox14.Size = New System.Drawing.Size(47, 20)
		Me.textBox14.TabIndex = 10
		'
		'textBox15
		'
		Me.textBox15.Location = New System.Drawing.Point(59, 71)
		Me.textBox15.Name = "textBox15"
		Me.textBox15.Size = New System.Drawing.Size(47, 20)
		Me.textBox15.TabIndex = 9
		'
		'textBox16
		'
		Me.textBox16.Location = New System.Drawing.Point(6, 71)
		Me.textBox16.Name = "textBox16"
		Me.textBox16.Size = New System.Drawing.Size(47, 20)
		Me.textBox16.TabIndex = 8
		'
		'cmbFilasA
		'
		Me.cmbFilasA.FormattingEnabled = true
		Me.cmbFilasA.Location = New System.Drawing.Point(6, 170)
		Me.cmbFilasA.Name = "cmbFilasA"
		Me.cmbFilasA.Size = New System.Drawing.Size(100, 21)
		Me.cmbFilasA.TabIndex = 16
		'
		'cmbColumnasA
		'
		Me.cmbColumnasA.FormattingEnabled = true
		Me.cmbColumnasA.Location = New System.Drawing.Point(112, 170)
		Me.cmbColumnasA.Name = "cmbColumnasA"
		Me.cmbColumnasA.Size = New System.Drawing.Size(100, 21)
		Me.cmbColumnasA.TabIndex = 17
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 140)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(94, 23)
		Me.label1.TabIndex = 18
		Me.label1.Text = "Filas"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(112, 140)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 19
		Me.label2.Text = "Columnas"
		'
		'grbMatrizB00
		'
		Me.grbMatrizB00.Controls.Add(Me.label3)
		Me.grbMatrizB00.Controls.Add(Me.label4)
		Me.grbMatrizB00.Controls.Add(Me.cmbColumnasB)
		Me.grbMatrizB00.Controls.Add(Me.cmbFilasB)
		Me.grbMatrizB00.Controls.Add(Me.textBox17)
		Me.grbMatrizB00.Controls.Add(Me.textBox18)
		Me.grbMatrizB00.Controls.Add(Me.textBox19)
		Me.grbMatrizB00.Controls.Add(Me.textBox20)
		Me.grbMatrizB00.Controls.Add(Me.textBox21)
		Me.grbMatrizB00.Controls.Add(Me.textBox22)
		Me.grbMatrizB00.Controls.Add(Me.textBox23)
		Me.grbMatrizB00.Controls.Add(Me.textBox24)
		Me.grbMatrizB00.Controls.Add(Me.textBox25)
		Me.grbMatrizB00.Controls.Add(Me.textBox26)
		Me.grbMatrizB00.Controls.Add(Me.textBox27)
		Me.grbMatrizB00.Controls.Add(Me.textBox28)
		Me.grbMatrizB00.Controls.Add(Me.textBox29)
		Me.grbMatrizB00.Controls.Add(Me.textBox30)
		Me.grbMatrizB00.Controls.Add(Me.textBox31)
		Me.grbMatrizB00.Controls.Add(Me.textBox32)
		Me.grbMatrizB00.Location = New System.Drawing.Point(340, 106)
		Me.grbMatrizB00.Name = "grbMatrizB00"
		Me.grbMatrizB00.Size = New System.Drawing.Size(220, 197)
		Me.grbMatrizB00.TabIndex = 20
		Me.grbMatrizB00.TabStop = false
		Me.grbMatrizB00.Text = "Matriz B"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(112, 140)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 19
		Me.label3.Text = "Columnas"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(12, 140)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(94, 23)
		Me.label4.TabIndex = 18
		Me.label4.Text = "Filas"
		'
		'cmbColumnasB
		'
		Me.cmbColumnasB.FormattingEnabled = true
		Me.cmbColumnasB.Location = New System.Drawing.Point(112, 170)
		Me.cmbColumnasB.Name = "cmbColumnasB"
		Me.cmbColumnasB.Size = New System.Drawing.Size(100, 21)
		Me.cmbColumnasB.TabIndex = 17
		'
		'cmbFilasB
		'
		Me.cmbFilasB.FormattingEnabled = true
		Me.cmbFilasB.Location = New System.Drawing.Point(6, 170)
		Me.cmbFilasB.Name = "cmbFilasB"
		Me.cmbFilasB.Size = New System.Drawing.Size(100, 21)
		Me.cmbFilasB.TabIndex = 16
		'
		'textBox17
		'
		Me.textBox17.Location = New System.Drawing.Point(165, 97)
		Me.textBox17.Name = "textBox17"
		Me.textBox17.Size = New System.Drawing.Size(47, 20)
		Me.textBox17.TabIndex = 15
		'
		'textBox18
		'
		Me.textBox18.Location = New System.Drawing.Point(112, 97)
		Me.textBox18.Name = "textBox18"
		Me.textBox18.Size = New System.Drawing.Size(47, 20)
		Me.textBox18.TabIndex = 14
		'
		'textBox19
		'
		Me.textBox19.Location = New System.Drawing.Point(59, 97)
		Me.textBox19.Name = "textBox19"
		Me.textBox19.Size = New System.Drawing.Size(47, 20)
		Me.textBox19.TabIndex = 13
		'
		'textBox20
		'
		Me.textBox20.Location = New System.Drawing.Point(6, 97)
		Me.textBox20.Name = "textBox20"
		Me.textBox20.Size = New System.Drawing.Size(47, 20)
		Me.textBox20.TabIndex = 12
		'
		'textBox21
		'
		Me.textBox21.Location = New System.Drawing.Point(165, 71)
		Me.textBox21.Name = "textBox21"
		Me.textBox21.Size = New System.Drawing.Size(47, 20)
		Me.textBox21.TabIndex = 11
		'
		'textBox22
		'
		Me.textBox22.Location = New System.Drawing.Point(112, 71)
		Me.textBox22.Name = "textBox22"
		Me.textBox22.Size = New System.Drawing.Size(47, 20)
		Me.textBox22.TabIndex = 10
		'
		'textBox23
		'
		Me.textBox23.Location = New System.Drawing.Point(59, 71)
		Me.textBox23.Name = "textBox23"
		Me.textBox23.Size = New System.Drawing.Size(47, 20)
		Me.textBox23.TabIndex = 9
		'
		'textBox24
		'
		Me.textBox24.Location = New System.Drawing.Point(6, 71)
		Me.textBox24.Name = "textBox24"
		Me.textBox24.Size = New System.Drawing.Size(47, 20)
		Me.textBox24.TabIndex = 8
		'
		'textBox25
		'
		Me.textBox25.Location = New System.Drawing.Point(165, 45)
		Me.textBox25.Name = "textBox25"
		Me.textBox25.Size = New System.Drawing.Size(47, 20)
		Me.textBox25.TabIndex = 7
		'
		'textBox26
		'
		Me.textBox26.Location = New System.Drawing.Point(112, 45)
		Me.textBox26.Name = "textBox26"
		Me.textBox26.Size = New System.Drawing.Size(47, 20)
		Me.textBox26.TabIndex = 6
		'
		'textBox27
		'
		Me.textBox27.Location = New System.Drawing.Point(59, 45)
		Me.textBox27.Name = "textBox27"
		Me.textBox27.Size = New System.Drawing.Size(47, 20)
		Me.textBox27.TabIndex = 5
		'
		'textBox28
		'
		Me.textBox28.Location = New System.Drawing.Point(6, 45)
		Me.textBox28.Name = "textBox28"
		Me.textBox28.Size = New System.Drawing.Size(47, 20)
		Me.textBox28.TabIndex = 4
		'
		'textBox29
		'
		Me.textBox29.Location = New System.Drawing.Point(165, 19)
		Me.textBox29.Name = "textBox29"
		Me.textBox29.Size = New System.Drawing.Size(47, 20)
		Me.textBox29.TabIndex = 3
		'
		'textBox30
		'
		Me.textBox30.Location = New System.Drawing.Point(112, 19)
		Me.textBox30.Name = "textBox30"
		Me.textBox30.Size = New System.Drawing.Size(47, 20)
		Me.textBox30.TabIndex = 2
		'
		'textBox31
		'
		Me.textBox31.Location = New System.Drawing.Point(59, 19)
		Me.textBox31.Name = "textBox31"
		Me.textBox31.Size = New System.Drawing.Size(47, 20)
		Me.textBox31.TabIndex = 1
		'
		'textBox32
		'
		Me.textBox32.Location = New System.Drawing.Point(6, 19)
		Me.textBox32.Name = "textBox32"
		Me.textBox32.Size = New System.Drawing.Size(47, 20)
		Me.textBox32.TabIndex = 0
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(847, 485)
		Me.Controls.Add(Me.grbMatrizB00)
		Me.Controls.Add(Me.grbMatrizA00)
		Me.Name = "MainForm"
		Me.Text = "Ejemplo6_Matrices"
		Me.grbMatrizA00.ResumeLayout(false)
		Me.grbMatrizA00.PerformLayout
		Me.grbMatrizB00.ResumeLayout(false)
		Me.grbMatrizB00.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private textBox32 As System.Windows.Forms.TextBox
	Private textBox31 As System.Windows.Forms.TextBox
	Private textBox30 As System.Windows.Forms.TextBox
	Private textBox29 As System.Windows.Forms.TextBox
	Private textBox28 As System.Windows.Forms.TextBox
	Private textBox27 As System.Windows.Forms.TextBox
	Private textBox26 As System.Windows.Forms.TextBox
	Private textBox25 As System.Windows.Forms.TextBox
	Private textBox24 As System.Windows.Forms.TextBox
	Private textBox23 As System.Windows.Forms.TextBox
	Private textBox22 As System.Windows.Forms.TextBox
	Private textBox21 As System.Windows.Forms.TextBox
	Private textBox20 As System.Windows.Forms.TextBox
	Private textBox19 As System.Windows.Forms.TextBox
	Private textBox18 As System.Windows.Forms.TextBox
	Private textBox17 As System.Windows.Forms.TextBox
	Private cmbFilasB As System.Windows.Forms.ComboBox
	Private cmbColumnasB As System.Windows.Forms.ComboBox
	Private label4 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private grbMatrizB00 As System.Windows.Forms.GroupBox
	Private txtA00 As System.Windows.Forms.TextBox
	Private txtA01 As System.Windows.Forms.TextBox
	Private txtA02 As System.Windows.Forms.TextBox
	Private txtA03 As System.Windows.Forms.TextBox
	Private txtA10 As System.Windows.Forms.TextBox
	Private txtA11 As System.Windows.Forms.TextBox
	Private txtA12 As System.Windows.Forms.TextBox
	Private textBox5 As System.Windows.Forms.TextBox
	Private textBox16 As System.Windows.Forms.TextBox
	Private textBox15 As System.Windows.Forms.TextBox
	Private textBox14 As System.Windows.Forms.TextBox
	Private textBox13 As System.Windows.Forms.TextBox
	Private textBox12 As System.Windows.Forms.TextBox
	Private textBox11 As System.Windows.Forms.TextBox
	Private textBox10 As System.Windows.Forms.TextBox
	Private textBox9 As System.Windows.Forms.TextBox
	Private cmbFilasA As System.Windows.Forms.ComboBox
	Private cmbColumnasA As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private grbMatrizA00 As System.Windows.Forms.GroupBox
End Class
