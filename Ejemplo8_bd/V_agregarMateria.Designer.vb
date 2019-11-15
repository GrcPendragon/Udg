'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 07/11/2019
' Time: 09:27 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class V_agregarMateria
	
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
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.buttonAgregar = New System.Windows.Forms.Button()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.textBoxMateria = New System.Windows.Forms.TextBox()
		Me.textBoxNRC = New System.Windows.Forms.TextBox()
		Me.textBoxClave = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 20)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(52, 20)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Materia"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(12, 55)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(52, 20)
		Me.label2.TabIndex = 1
		Me.label2.Text = "NRC"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(185, 55)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(42, 20)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Clave"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'buttonAgregar
		'
		Me.buttonAgregar.Location = New System.Drawing.Point(159, 112)
		Me.buttonAgregar.Name = "buttonAgregar"
		Me.buttonAgregar.Size = New System.Drawing.Size(75, 23)
		Me.buttonAgregar.TabIndex = 3
		Me.buttonAgregar.Text = "Agregar"
		Me.buttonAgregar.UseVisualStyleBackColor = true
		AddHandler Me.buttonAgregar.Click, AddressOf Me.ButtonAgregarClick
		'
		'buttonCancelar
		'
		Me.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancelar.Location = New System.Drawing.Point(258, 112)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancelar.TabIndex = 4
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = true
		'
		'textBoxMateria
		'
		Me.textBoxMateria.Location = New System.Drawing.Point(70, 20)
		Me.textBoxMateria.Name = "textBoxMateria"
		Me.textBoxMateria.Size = New System.Drawing.Size(263, 20)
		Me.textBoxMateria.TabIndex = 5
		'
		'textBoxNRC
		'
		Me.textBoxNRC.Location = New System.Drawing.Point(70, 55)
		Me.textBoxNRC.Name = "textBoxNRC"
		Me.textBoxNRC.Size = New System.Drawing.Size(100, 20)
		Me.textBoxNRC.TabIndex = 6
		'
		'textBoxClave
		'
		Me.textBoxClave.Location = New System.Drawing.Point(233, 55)
		Me.textBoxClave.Name = "textBoxClave"
		Me.textBoxClave.Size = New System.Drawing.Size(100, 20)
		Me.textBoxClave.TabIndex = 8
		'
		'V_agregarMateria
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(353, 147)
		Me.Controls.Add(Me.textBoxClave)
		Me.Controls.Add(Me.textBoxNRC)
		Me.Controls.Add(Me.textBoxMateria)
		Me.Controls.Add(Me.buttonCancelar)
		Me.Controls.Add(Me.buttonAgregar)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "V_agregarMateria"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Agregar nuevo alumno"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBoxClave As System.Windows.Forms.TextBox
	Private textBoxNRC As System.Windows.Forms.TextBox
	Private textBoxMateria As System.Windows.Forms.TextBox
	Private buttonCancelar As System.Windows.Forms.Button
	Private buttonAgregar As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
