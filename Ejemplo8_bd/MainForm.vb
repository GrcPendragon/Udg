'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 25/10/2019
' Time: 07:35 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'


Public Partial Class MainForm
	
	Dim baseDatos As BD
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		comboBoxCiclo.SelectedIndex = 0
		baseDatos = New BD("base_datos.mdb")
		
		ButtonAlumnoClick(Nothing,Nothing)
		ButtonMateriaClick(Nothing,Nothing)
		ButtonCargarCursoClick(Nothing,Nothing)
	End Sub
	
	Sub ButtonAlumnoClick(sender As Object, e As EventArgs)
		dataGridViewAlumno.DataSource = baseDatos.ConsultaBD( "select id_alumno as ID, nombre as Nomnbre, codigo as Código, carrera as Carrera from alumno")
	End Sub
	
	Sub ButtonMateriaClick(sender As Object, e As EventArgs)		
		dataGridViewMateria.DataSource = baseDatos.ConsultaBD("select id_materia as ID, nombre as Nomnbre, nrc as NRC, clave as Clave from materia" )
	End Sub
	
	Sub ButtonInscribirClick(sender As Object, e As EventArgs)
		Dim id_alumno, id_materia, ciclo, sql As String
		
		id_alumno = dataGridViewAlumno.CurrentRow.Cells(0).Value.ToString
		id_materia = dataGridViewMateria.CurrentRow.Cells(0).Value.ToString
		ciclo = comboBoxCiclo.Text
		If isInscrito(id_alumno,id_materia,ciclo) Then
			sql = "insert into cursa (id_alumno, id_materia, ciclo) values (" + id_alumno + "," + id_materia + ",'" + ciclo + "')"
			baseDatos.InsertarBD(sql)		
			ButtonCargarCursoClick(Nothing, Nothing)
		Else
			MsgBox("El alumno ya esta inscrito.")
		End If
	End Sub
	
	Sub ButtonCargarCursoClick(sender As Object, e As EventArgs)
		dataGridViewCursa.DataSource = baseDatos.ConsultaBD("select cursa.id_cursa as ID, alumno.codigo as Codigo, alumno.nombre as Nombre, materia.nombre as Materia, cursa.Ciclo as Ciclo from alumno, materia, cursa where cursa.id_alumno = alumno.id_alumno and cursa.id_materia = materia.id_materia" )		
	End Sub
	
	Sub ButtonCancelarClick(sender As Object, e As EventArgs)
		Dim sql, id_cursa, codAlumno, nomMateria, ciclo As String
		
		codAlumno = dataGridViewCursa.CurrentRow.Cells(1).Value.ToString
		nomMateria = dataGridViewCursa.CurrentRow.Cells(3).Value.ToString
		ciclo = dataGridViewCursa.CurrentRow.Cells(4).Value.ToString
		
		If MsgBox("Desea cancelar la inscripcion del alumno con el codigo: "+codAlumno+" en la materia: "+nomMateria+" del ciclo: "+ciclo+"?", MsgBoxStyle.OkCancel) = vbOK Then
			
			id_cursa = dataGridViewCursa.CurrentRow.Cells(0).Value.ToString
			sql = "Delete "+id_cursa+" from cursa where cursa.id_cursa = "+id_cursa
			baseDatos.EliminarBD(sql)
			buttonCargarCursoClick(Nothing, Nothing)
			
		End If
	End Sub
	
	Function isInscrito(id_alumno As String, id_materia As String, ciclo As String) As Boolean
		Dim sql As String
		
		sql = "Select * from cursa where id_alumno = "+id_alumno+" and id_materia = "+id_materia+" and Ciclo = '"+ciclo+"'"
		
		If baseDatos.ConsultaBD(sql).Rows.Count > 0 Then
			Return False
		End If
		
		Return True
	End Function
	
	Sub ComboBoxCicloSelectedIndexChanged(sender As Object, e As EventArgs)
		ButtonMateriaClick(Nothing,Nothing)
	End Sub
	
	Sub ButtonAgregarAlmunoClick(sender As Object, e As EventArgs)
		Dim ventana As New V_agregarAlumno
		
		If ventana.ShowDialog = vbOK Then
			
			Dim nombre, codigo, carrera, sql As String
			Dim band As Boolean = False
			
			nombre = ventana.nombre
			codigo = ventana.codigo
			carrera = ventana.carrera
			
			For i As Integer = 0 To dataGridViewAlumno.RowCount -1
				If dataGridViewAlumno.Rows(i).Cells(2).Value.ToString = codigo Then
					band = True
					Exit For
				End If
			Next i
			
			If band Then
				MsgBox("El alumno se encuentra registrado")
			Else
				sql = "Insert into alumno (nombre, codigo, carrera) values ('"+nombre+"','"+codigo+"','"+carrera+"')"
				baseDatos.InsertarBD(sql)
				ButtonAlumnoClick(Nothing, Nothing)				
			End If
		End If
	End Sub
	
	Sub ButtonModificarAlunnoClick(sender As Object, e As EventArgs)
		Dim ventana As V_agregarAlumno
		ventana.nombre = dataGridViewAlumno.CurrentRow.Cells(1).Value.ToString
		ventana.codigo = dataGridViewAlumno.CurrentRow.Cells(2).Value.ToString
		ventana.carrera = dataGridViewAlumno.CurrentRow.Cells(3).Value.ToString
		
	End Sub
End Class
