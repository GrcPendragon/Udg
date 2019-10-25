'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 18/10/2019
' Time: 07:46 a. m.
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
		Me.textBoxLlave = New System.Windows.Forms.TextBox()
		Me.labelTexto = New System.Windows.Forms.Label()
		Me.buttonAceptar = New System.Windows.Forms.Button()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.SuspendLayout
		'
		'textBoxLlave
		'
		Me.textBoxLlave.Location = New System.Drawing.Point(12, 41)
		Me.textBoxLlave.Name = "textBoxLlave"
		Me.textBoxLlave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.textBoxLlave.Size = New System.Drawing.Size(198, 20)
		Me.textBoxLlave.TabIndex = 0
		'
		'labelTexto
		'
		Me.labelTexto.AutoSize = true
		Me.labelTexto.Location = New System.Drawing.Point(12, 18)
		Me.labelTexto.Name = "labelTexto"
		Me.labelTexto.Size = New System.Drawing.Size(33, 13)
		Me.labelTexto.TabIndex = 1
		Me.labelTexto.Text = "Llave"
		'
		'buttonAceptar
		'
		Me.buttonAceptar.Location = New System.Drawing.Point(12, 81)
		Me.buttonAceptar.Name = "buttonAceptar"
		Me.buttonAceptar.Size = New System.Drawing.Size(75, 23)
		Me.buttonAceptar.TabIndex = 2
		Me.buttonAceptar.Text = "Aceptar"
		Me.buttonAceptar.UseVisualStyleBackColor = true
		AddHandler Me.buttonAceptar.Click, AddressOf Me.ButtonAceptarClick
		'
		'buttonCancelar
		'
		Me.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancelar.Location = New System.Drawing.Point(135, 81)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancelar.TabIndex = 3
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = true
		AddHandler Me.buttonCancelar.Click, AddressOf Me.ButtonCancelarClick
		'
		'groupBox1
		'
		Me.groupBox1.Location = New System.Drawing.Point(12, 66)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(198, 5)
		Me.groupBox1.TabIndex = 4
		Me.groupBox1.TabStop = false
		'
		'V_llave
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(222, 113)
		Me.ControlBox = false
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.buttonCancelar)
		Me.Controls.Add(Me.buttonAceptar)
		Me.Controls.Add(Me.labelTexto)
		Me.Controls.Add(Me.textBoxLlave)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "V_llave"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Llave"
		AddHandler Load, AddressOf Me.V_llaveLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private labelTexto As System.Windows.Forms.Label
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private buttonCancelar As System.Windows.Forms.Button
	Private buttonAceptar As System.Windows.Forms.Button
	Private textBoxLlave As System.Windows.Forms.TextBox
End Class
