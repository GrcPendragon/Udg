'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 25/10/2019
' Time: 07:35 a. m.
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
		Me.dataGridViewAlumno = New System.Windows.Forms.DataGridView()
		Me.buttonAlumno = New System.Windows.Forms.Button()
		Me.buttonMateria = New System.Windows.Forms.Button()
		Me.dataGridViewMateria = New System.Windows.Forms.DataGridView()
		Me.dataGridViewCursa = New System.Windows.Forms.DataGridView()
		Me.buttonInscribir = New System.Windows.Forms.Button()
		Me.comboBoxCiclo = New System.Windows.Forms.ComboBox()
		Me.buttonCargarCurso = New System.Windows.Forms.Button()
		Me.buttonCancelar = New System.Windows.Forms.Button()
		CType(Me.dataGridViewAlumno,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dataGridViewMateria,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dataGridViewCursa,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dataGridViewAlumno
		'
		Me.dataGridViewAlumno.AllowUserToAddRows = false
		Me.dataGridViewAlumno.AllowUserToDeleteRows = false
		Me.dataGridViewAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridViewAlumno.Location = New System.Drawing.Point(12, 12)
		Me.dataGridViewAlumno.MultiSelect = false
		Me.dataGridViewAlumno.Name = "dataGridViewAlumno"
		Me.dataGridViewAlumno.ReadOnly = true
		Me.dataGridViewAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewAlumno.Size = New System.Drawing.Size(495, 130)
		Me.dataGridViewAlumno.TabIndex = 0
		'
		'buttonAlumno
		'
		Me.buttonAlumno.Location = New System.Drawing.Point(513, 12)
		Me.buttonAlumno.Name = "buttonAlumno"
		Me.buttonAlumno.Size = New System.Drawing.Size(157, 40)
		Me.buttonAlumno.TabIndex = 1
		Me.buttonAlumno.Text = "Cargar datos alumno"
		Me.buttonAlumno.UseVisualStyleBackColor = true
		AddHandler Me.buttonAlumno.Click, AddressOf Me.ButtonAlumnoClick
		'
		'buttonMateria
		'
		Me.buttonMateria.Location = New System.Drawing.Point(513, 168)
		Me.buttonMateria.Name = "buttonMateria"
		Me.buttonMateria.Size = New System.Drawing.Size(157, 40)
		Me.buttonMateria.TabIndex = 2
		Me.buttonMateria.Text = "Cargar datos materias"
		Me.buttonMateria.UseVisualStyleBackColor = true
		AddHandler Me.buttonMateria.Click, AddressOf Me.ButtonMateriaClick
		'
		'dataGridViewMateria
		'
		Me.dataGridViewMateria.AllowUserToAddRows = false
		Me.dataGridViewMateria.AllowUserToDeleteRows = false
		Me.dataGridViewMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridViewMateria.Location = New System.Drawing.Point(12, 148)
		Me.dataGridViewMateria.MultiSelect = false
		Me.dataGridViewMateria.Name = "dataGridViewMateria"
		Me.dataGridViewMateria.ReadOnly = true
		Me.dataGridViewMateria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dataGridViewMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewMateria.Size = New System.Drawing.Size(495, 118)
		Me.dataGridViewMateria.TabIndex = 3
		'
		'dataGridViewCursa
		'
		Me.dataGridViewCursa.AllowUserToAddRows = false
		Me.dataGridViewCursa.AllowUserToDeleteRows = false
		Me.dataGridViewCursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridViewCursa.Location = New System.Drawing.Point(12, 272)
		Me.dataGridViewCursa.MultiSelect = false
		Me.dataGridViewCursa.Name = "dataGridViewCursa"
		Me.dataGridViewCursa.ReadOnly = true
		Me.dataGridViewCursa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dataGridViewCursa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewCursa.Size = New System.Drawing.Size(495, 120)
		Me.dataGridViewCursa.TabIndex = 4
		'
		'buttonInscribir
		'
		Me.buttonInscribir.Location = New System.Drawing.Point(513, 325)
		Me.buttonInscribir.Name = "buttonInscribir"
		Me.buttonInscribir.Size = New System.Drawing.Size(157, 20)
		Me.buttonInscribir.TabIndex = 5
		Me.buttonInscribir.Text = "Inscribir a curso"
		Me.buttonInscribir.UseVisualStyleBackColor = true
		AddHandler Me.buttonInscribir.Click, AddressOf Me.ButtonInscribirClick
		'
		'comboBoxCiclo
		'
		Me.comboBoxCiclo.FormattingEnabled = true
		Me.comboBoxCiclo.Items.AddRange(New Object() {"2020A", "2020B", "2021A", "2021B"})
		Me.comboBoxCiclo.Location = New System.Drawing.Point(513, 272)
		Me.comboBoxCiclo.Name = "comboBoxCiclo"
		Me.comboBoxCiclo.Size = New System.Drawing.Size(157, 21)
		Me.comboBoxCiclo.TabIndex = 6
		'
		'buttonCargarCurso
		'
		Me.buttonCargarCurso.Location = New System.Drawing.Point(513, 299)
		Me.buttonCargarCurso.Name = "buttonCargarCurso"
		Me.buttonCargarCurso.Size = New System.Drawing.Size(157, 20)
		Me.buttonCargarCurso.TabIndex = 7
		Me.buttonCargarCurso.Text = "Cargar curso"
		Me.buttonCargarCurso.UseVisualStyleBackColor = true
		AddHandler Me.buttonCargarCurso.Click, AddressOf Me.ButtonCargarCursoClick
		'
		'buttonCancelar
		'
		Me.buttonCancelar.Location = New System.Drawing.Point(513, 351)
		Me.buttonCancelar.Name = "buttonCancelar"
		Me.buttonCancelar.Size = New System.Drawing.Size(157, 20)
		Me.buttonCancelar.TabIndex = 8
		Me.buttonCancelar.Text = "Cancelar inscripción"
		Me.buttonCancelar.UseVisualStyleBackColor = true
		AddHandler Me.buttonCancelar.Click, AddressOf Me.ButtonCancelarClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(682, 406)
		Me.Controls.Add(Me.buttonCancelar)
		Me.Controls.Add(Me.buttonCargarCurso)
		Me.Controls.Add(Me.comboBoxCiclo)
		Me.Controls.Add(Me.buttonInscribir)
		Me.Controls.Add(Me.dataGridViewCursa)
		Me.Controls.Add(Me.dataGridViewMateria)
		Me.Controls.Add(Me.buttonMateria)
		Me.Controls.Add(Me.buttonAlumno)
		Me.Controls.Add(Me.dataGridViewAlumno)
		Me.Name = "MainForm"
		Me.Text = "ejemplo8_bd"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.dataGridViewAlumno,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dataGridViewMateria,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dataGridViewCursa,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private buttonCancelar As System.Windows.Forms.Button
	Private buttonCargarCurso As System.Windows.Forms.Button
	Private comboBoxCiclo As System.Windows.Forms.ComboBox
	Private buttonInscribir As System.Windows.Forms.Button
	Private dataGridViewCursa As System.Windows.Forms.DataGridView
	Private dataGridViewMateria As System.Windows.Forms.DataGridView
	Private buttonMateria As System.Windows.Forms.Button
	Private buttonAlumno As System.Windows.Forms.Button
	Private dataGridViewAlumno As System.Windows.Forms.DataGridView
End Class
