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
		Me.buttoncancelarInsc = New System.Windows.Forms.Button()
		Me.buttonAgregarAlumno = New System.Windows.Forms.Button()
		Me.buttonModificarAlumno = New System.Windows.Forms.Button()
		Me.buttonEliminarAlumno = New System.Windows.Forms.Button()
		Me.buttonAgregarMateria = New System.Windows.Forms.Button()
		Me.buttonEliminarMateria = New System.Windows.Forms.Button()
		Me.buttonModificarMateria = New System.Windows.Forms.Button()
		Me.checkBoxIndividual = New System.Windows.Forms.CheckBox()
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
		Me.dataGridViewAlumno.Size = New System.Drawing.Size(495, 146)
		Me.dataGridViewAlumno.TabIndex = 0
		AddHandler Me.dataGridViewAlumno.SelectionChanged, AddressOf Me.DataGridViewAlumnoSelectionChanged
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
		Me.buttonMateria.Location = New System.Drawing.Point(513, 148)
		Me.buttonMateria.Name = "buttonMateria"
		Me.buttonMateria.Size = New System.Drawing.Size(157, 37)
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
		Me.dataGridViewMateria.Location = New System.Drawing.Point(12, 164)
		Me.dataGridViewMateria.MultiSelect = false
		Me.dataGridViewMateria.Name = "dataGridViewMateria"
		Me.dataGridViewMateria.ReadOnly = true
		Me.dataGridViewMateria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dataGridViewMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewMateria.Size = New System.Drawing.Size(495, 134)
		Me.dataGridViewMateria.TabIndex = 3
		'
		'dataGridViewCursa
		'
		Me.dataGridViewCursa.AllowUserToAddRows = false
		Me.dataGridViewCursa.AllowUserToDeleteRows = false
		Me.dataGridViewCursa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridViewCursa.Location = New System.Drawing.Point(12, 304)
		Me.dataGridViewCursa.MultiSelect = false
		Me.dataGridViewCursa.Name = "dataGridViewCursa"
		Me.dataGridViewCursa.ReadOnly = true
		Me.dataGridViewCursa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.dataGridViewCursa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewCursa.Size = New System.Drawing.Size(495, 136)
		Me.dataGridViewCursa.TabIndex = 4
		'
		'buttonInscribir
		'
		Me.buttonInscribir.Location = New System.Drawing.Point(513, 389)
		Me.buttonInscribir.Name = "buttonInscribir"
		Me.buttonInscribir.Size = New System.Drawing.Size(157, 22)
		Me.buttonInscribir.TabIndex = 5
		Me.buttonInscribir.Text = "Inscribir a curso"
		Me.buttonInscribir.UseVisualStyleBackColor = true
		AddHandler Me.buttonInscribir.Click, AddressOf Me.ButtonInscribirClick
		'
		'comboBoxCiclo
		'
		Me.comboBoxCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxCiclo.FormattingEnabled = true
		Me.comboBoxCiclo.Items.AddRange(New Object() {"2020A", "2020B", "2021A", "2021B"})
		Me.comboBoxCiclo.Location = New System.Drawing.Point(513, 304)
		Me.comboBoxCiclo.Name = "comboBoxCiclo"
		Me.comboBoxCiclo.Size = New System.Drawing.Size(157, 21)
		Me.comboBoxCiclo.TabIndex = 6
		AddHandler Me.comboBoxCiclo.SelectedIndexChanged, AddressOf Me.ComboBoxCicloSelectedIndexChanged
		'
		'buttonCargarCurso
		'
		Me.buttonCargarCurso.Location = New System.Drawing.Point(513, 360)
		Me.buttonCargarCurso.Name = "buttonCargarCurso"
		Me.buttonCargarCurso.Size = New System.Drawing.Size(157, 23)
		Me.buttonCargarCurso.TabIndex = 7
		Me.buttonCargarCurso.Text = "Cargar curso"
		Me.buttonCargarCurso.UseVisualStyleBackColor = true
		AddHandler Me.buttonCargarCurso.Click, AddressOf Me.ButtonCargarCursoClick
		'
		'buttoncancelarInsc
		'
		Me.buttoncancelarInsc.Location = New System.Drawing.Point(513, 417)
		Me.buttoncancelarInsc.Name = "buttoncancelarInsc"
		Me.buttoncancelarInsc.Size = New System.Drawing.Size(157, 22)
		Me.buttoncancelarInsc.TabIndex = 8
		Me.buttoncancelarInsc.Text = "Cancelar inscripción"
		Me.buttoncancelarInsc.UseVisualStyleBackColor = true
		AddHandler Me.buttoncancelarInsc.Click, AddressOf Me.ButtoncancelarInscClick
		'
		'buttonAgregarAlumno
		'
		Me.buttonAgregarAlumno.Location = New System.Drawing.Point(513, 56)
		Me.buttonAgregarAlumno.Name = "buttonAgregarAlumno"
		Me.buttonAgregarAlumno.Size = New System.Drawing.Size(157, 40)
		Me.buttonAgregarAlumno.TabIndex = 9
		Me.buttonAgregarAlumno.Text = "Agregar alumno"
		Me.buttonAgregarAlumno.UseVisualStyleBackColor = true
		AddHandler Me.buttonAgregarAlumno.Click, AddressOf Me.ButtonAgregarAlumnoClick
		'
		'buttonModificarAlumno
		'
		Me.buttonModificarAlumno.Location = New System.Drawing.Point(513, 102)
		Me.buttonModificarAlumno.Name = "buttonModificarAlumno"
		Me.buttonModificarAlumno.Size = New System.Drawing.Size(69, 40)
		Me.buttonModificarAlumno.TabIndex = 10
		Me.buttonModificarAlumno.Text = "Modificar alumno"
		Me.buttonModificarAlumno.UseVisualStyleBackColor = true
		AddHandler Me.buttonModificarAlumno.Click, AddressOf Me.ButtonModificarAlumnoClick
		'
		'buttonEliminarAlumno
		'
		Me.buttonEliminarAlumno.Location = New System.Drawing.Point(600, 102)
		Me.buttonEliminarAlumno.Name = "buttonEliminarAlumno"
		Me.buttonEliminarAlumno.Size = New System.Drawing.Size(70, 40)
		Me.buttonEliminarAlumno.TabIndex = 11
		Me.buttonEliminarAlumno.Text = "Eliminar alumno"
		Me.buttonEliminarAlumno.UseVisualStyleBackColor = true
		AddHandler Me.buttonEliminarAlumno.Click, AddressOf Me.ButtonEliminarAlumnoClick
		'
		'buttonAgregarMateria
		'
		Me.buttonAgregarMateria.Location = New System.Drawing.Point(513, 191)
		Me.buttonAgregarMateria.Name = "buttonAgregarMateria"
		Me.buttonAgregarMateria.Size = New System.Drawing.Size(157, 29)
		Me.buttonAgregarMateria.TabIndex = 12
		Me.buttonAgregarMateria.Text = "Agregar materia"
		Me.buttonAgregarMateria.UseVisualStyleBackColor = true
		AddHandler Me.buttonAgregarMateria.Click, AddressOf Me.ButtonAgregarMateriaClick
		'
		'buttonEliminarMateria
		'
		Me.buttonEliminarMateria.Location = New System.Drawing.Point(600, 226)
		Me.buttonEliminarMateria.Name = "buttonEliminarMateria"
		Me.buttonEliminarMateria.Size = New System.Drawing.Size(70, 40)
		Me.buttonEliminarMateria.TabIndex = 14
		Me.buttonEliminarMateria.Text = "Eliminar materia"
		Me.buttonEliminarMateria.UseVisualStyleBackColor = true
		AddHandler Me.buttonEliminarMateria.Click, AddressOf Me.ButtonEliminarMateriaClick
		'
		'buttonModificarMateria
		'
		Me.buttonModificarMateria.Location = New System.Drawing.Point(513, 226)
		Me.buttonModificarMateria.Name = "buttonModificarMateria"
		Me.buttonModificarMateria.Size = New System.Drawing.Size(69, 40)
		Me.buttonModificarMateria.TabIndex = 13
		Me.buttonModificarMateria.Text = "Modificar materia"
		Me.buttonModificarMateria.UseVisualStyleBackColor = true
		AddHandler Me.buttonModificarMateria.Click, AddressOf Me.ButtonModificarMateriaClick
		'
		'checkBoxIndividual
		'
		Me.checkBoxIndividual.Location = New System.Drawing.Point(513, 331)
		Me.checkBoxIndividual.Name = "checkBoxIndividual"
		Me.checkBoxIndividual.Size = New System.Drawing.Size(157, 23)
		Me.checkBoxIndividual.TabIndex = 15
		Me.checkBoxIndividual.Text = "Filtrar individual"
		Me.checkBoxIndividual.UseVisualStyleBackColor = true
		AddHandler Me.checkBoxIndividual.CheckedChanged, AddressOf Me.CheckBoxIndividualCheckedChanged
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(682, 451)
		Me.Controls.Add(Me.checkBoxIndividual)
		Me.Controls.Add(Me.buttonEliminarMateria)
		Me.Controls.Add(Me.buttonModificarMateria)
		Me.Controls.Add(Me.buttonAgregarMateria)
		Me.Controls.Add(Me.buttonEliminarAlumno)
		Me.Controls.Add(Me.buttonModificarAlumno)
		Me.Controls.Add(Me.buttonAgregarAlumno)
		Me.Controls.Add(Me.buttoncancelarInsc)
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
	Private checkBoxIndividual As System.Windows.Forms.CheckBox
	Private buttonModificarMateria As System.Windows.Forms.Button
	Private buttonEliminarMateria As System.Windows.Forms.Button
	Private buttonAgregarMateria As System.Windows.Forms.Button
	Private buttonEliminarAlumno As System.Windows.Forms.Button
	Private buttonModificarAlumno As System.Windows.Forms.Button
	Private buttonAgregarAlumno As System.Windows.Forms.Button
	Private buttoncancelarInsc As System.Windows.Forms.Button
	Private buttonCargarCurso As System.Windows.Forms.Button
	Private comboBoxCiclo As System.Windows.Forms.ComboBox
	Private buttonInscribir As System.Windows.Forms.Button
	Private dataGridViewCursa As System.Windows.Forms.DataGridView
	Private dataGridViewMateria As System.Windows.Forms.DataGridView
	Private buttonMateria As System.Windows.Forms.Button
	Private buttonAlumno As System.Windows.Forms.Button
	Private dataGridViewAlumno As System.Windows.Forms.DataGridView
End Class
