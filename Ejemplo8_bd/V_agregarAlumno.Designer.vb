'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 07/11/2019
' Time: 09:27 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class V_agregarAlumno
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
		Me.textBoxNombre = New System.Windows.Forms.TextBox()
		Me.textBoxCodigo = New System.Windows.Forms.TextBox()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		Me.comboBoxCarrera = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(13, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(78, 20)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Nombre: "
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(13, 50)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(78, 23)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Código:"
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(13, 86)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(78, 23)
		Me.label3.TabIndex = 2
		Me.label3.Text = "Carrera:"
		'
		'buttonAgregar
		'
		Me.buttonAgregar.Location = New System.Drawing.Point(105, 123)
		Me.buttonAgregar.Name = "buttonAgregar"
		Me.buttonAgregar.Size = New System.Drawing.Size(75, 23)
		Me.buttonAgregar.TabIndex = 3
		Me.buttonAgregar.Text = "Agregar"
		Me.buttonAgregar.UseVisualStyleBackColor = true
		AddHandler Me.buttonAgregar.Click, AddressOf Me.ButtonAgregarClick
		'
		'textBoxNombre
		'
		Me.textBoxNombre.Location = New System.Drawing.Point(105, 13)
		Me.textBoxNombre.Name = "textBoxNombre"
		Me.textBoxNombre.Size = New System.Drawing.Size(167, 20)
		Me.textBoxNombre.TabIndex = 4
		'
		'textBoxCodigo
		'
		Me.textBoxCodigo.Location = New System.Drawing.Point(105, 53)
		Me.textBoxCodigo.Name = "textBoxCodigo"
		Me.textBoxCodigo.Size = New System.Drawing.Size(167, 20)
		Me.textBoxCodigo.TabIndex = 5
		'
		'buttonCancelar
		'
		Me.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.buttonCancelar.Location = New System.Drawing.Point(197, 123)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(75, 23)
		Me.buttonCancelar.TabIndex = 7
		Me.buttonCancelar.Text = "Cancelar"
		Me.buttonCancelar.UseVisualStyleBackColor = true
		'
		'comboBoxCarrera
		'
		Me.comboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxCarrera.FormattingEnabled = true
		Me.comboBoxCarrera.Location = New System.Drawing.Point(105, 86)
		Me.comboBoxCarrera.Name = "comboBoxCarrera"
		Me.comboBoxCarrera.Size = New System.Drawing.Size(167, 21)
		Me.comboBoxCarrera.TabIndex = 8
		'
		'V_agregarAlumno
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 157)
		Me.Controls.Add(Me.comboBoxCarrera)
		Me.Controls.Add(Me.buttonCancelar)
		Me.Controls.Add(Me.textBoxCodigo)
		Me.Controls.Add(Me.textBoxNombre)
		Me.Controls.Add(Me.buttonAgregar)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "V_agregarAlumno"
		Me.Text = "Agregar nuevo alumno"
		AddHandler Load, AddressOf Me.V_agregarAlumnoLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private comboBoxCarrera As System.Windows.Forms.ComboBox
	Private buttonCancelar As System.Windows.Forms.Button
	Private textBoxCodigo As System.Windows.Forms.TextBox
	Private textBoxNombre As System.Windows.Forms.TextBox
	Private buttonAgregar As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
End Class
