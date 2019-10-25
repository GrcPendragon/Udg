'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 24/10/2019
' Time: 08:50 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class V_llave
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
		Me.txtLlave = New System.Windows.Forms.TextBox()
		Me.lblCadena = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnAceptar = New System.Windows.Forms.Button()
		Me.btnCancelar = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtLlave
		'
		Me.txtLlave.Location = New System.Drawing.Point(12, 25)
		Me.txtLlave.Name = "txtLlave"
		Me.txtLlave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtLlave.Size = New System.Drawing.Size(177, 20)
		Me.txtLlave.TabIndex = 0
		'
		'lblCadena
		'
		Me.lblCadena.Location = New System.Drawing.Point(12, 9)
		Me.lblCadena.Name = "lblCadena"
		Me.lblCadena.Size = New System.Drawing.Size(100, 13)
		Me.lblCadena.TabIndex = 1
		Me.lblCadena.Text = "Llave"
		'
		'groupBox1
		'
		Me.groupBox1.Location = New System.Drawing.Point(13, 52)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(175, 5)
		Me.groupBox1.TabIndex = 2
		Me.groupBox1.TabStop = false
		'
		'btnAceptar
		'
		Me.btnAceptar.Location = New System.Drawing.Point(12, 71)
		Me.btnAceptar.Name = "btnAceptar"
		Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
		Me.btnAceptar.TabIndex = 3
		Me.btnAceptar.Text = "Aceptar"
		Me.btnAceptar.UseVisualStyleBackColor = true
		AddHandler Me.btnAceptar.Click, AddressOf Me.BtnAceptarClick
		'
		'btnCancelar
		'
		Me.btnCancelar.Location = New System.Drawing.Point(114, 71)
		Me.btnCancelar.Name = "btnCancelar"
		Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
		Me.btnCancelar.TabIndex = 4
		Me.btnCancelar.Text = "Cancel"
		Me.btnCancelar.UseVisualStyleBackColor = true
		AddHandler Me.btnCancelar.Click, AddressOf Me.BtnCancelarClick
		'
		'V_llave
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = true
		Me.ClientSize = New System.Drawing.Size(204, 105)
		Me.ControlBox = false
		Me.Controls.Add(Me.btnCancelar)
		Me.Controls.Add(Me.btnAceptar)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.lblCadena)
		Me.Controls.Add(Me.txtLlave)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "V_llave"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Ingrese la llave"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnCancelar As System.Windows.Forms.Button
	Private btnAceptar As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private lblCadena As System.Windows.Forms.Label
	Private txtLlave As System.Windows.Forms.TextBox
End Class
