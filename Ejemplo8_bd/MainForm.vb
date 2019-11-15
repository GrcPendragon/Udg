'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 25/10/2019
' Time: 07:35 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'


Public Partial Class MainForm
	
	Dim BaseDatos As BD
	Const sqlAlumno As String = "select id_alumno as ID, nombre as Nombre, codigo as Código, carrera as Carrera from alumno"
	Const sqlMateria As String = "select id_materia as ID, nombre as Nombre, nrc as NRC, clave as Clave from materia"
	Const sqlCursa As String = "select cursa.id_cursa as ID, alumno.codigo as Código, alumno.nombre as Nombre, materia.nombre as Materia, cursa.ciclo as Ciclo from cursa, alumno, materia where cursa.id_alumno = alumno.id_alumno and cursa.id_materia = materia.id_materia"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		comboBoxCiclo.SelectedIndex = 0
		BaseDatos = New BD("base_datos.mdb")
		
		cargarTabla(sqlCursa, dataGridViewCursa)
		cargarTabla(sqlMateria, dataGridViewMateria)
		cargarTabla(sqlAlumno, dataGridViewAlumno)
		mostrarBotones()
		
	End Sub
	
	'ALUMNO
	Sub ButtonAlumnoClick(sender As Object, e As EventArgs)
		DataGridViewAlumnoSelectionChanged(Nothing,Nothing)
	End Sub
	
	Sub ButtonAgregarAlumnoClick(sender As Object, e As EventArgs)
		Dim Ventana As New V_agregarAlumno("Agregar nuevo alumno","Agregar")		
		
		
		If Ventana.ShowDialog = DialogResult.OK Then
			Dim Nombre,Codigo, Carrera, SQL As String
			Dim encontrado As Boolean = False
			Nombre = Ventana.Nombre
			Codigo = Ventana.Codigo
			Carrera = Ventana.Carrera
			For i As Integer = 0 To dataGridViewAlumno.RowCount-1
				If dataGridViewAlumno.Rows(i).Cells(2).Value.ToString = Codigo Then
					encontrado = True
					Exit For
				End If
			Next i
			If encontrado Then
				MsgBox("El alumno ya existe")
			Else
				SQL = "insert into Alumno  (nombre,codigo,carrera) values ('" + Nombre +  "','" + Codigo + "','" + Carrera + "')"
				BaseDatos.InsertarBD(SQL)	
				ButtonAlumnoClick(Nothing,Nothing)	
				mostrarBotones()
			End If
		End If
	End Sub
	
	Sub ButtonModificarAlumnoClick(sender As Object, e As EventArgs)
		Dim id,Nombre, Codigo, Carrera, SQL As String
		
		id = dataGridViewAlumno.CurrentRow.Cells(0).Value.ToString
		Nombre = dataGridViewAlumno.CurrentRow.Cells(1).Value.ToString
		Codigo = dataGridViewAlumno.CurrentRow.Cells(2).Value.ToString
		Carrera = dataGridViewAlumno.CurrentRow.Cells(3).Value.ToString
		Dim ventana As New V_agregarAlumno("Modificar alumno","Modificar",Nombre,Codigo,Carrera)
		If ventana.ShowDialog = DialogResult.OK Then
			Dim encontrado As Boolean = False
			Nombre = ventana.Nombre
			Codigo = ventana.Codigo
			Carrera = ventana.Carrera
			For i As Integer = 0 To dataGridViewAlumno.RowCount-1
				If dataGridViewAlumno.Rows(i).Cells(2).Value.ToString = Codigo Then
					encontrado = True
					Exit For
				End If
			Next i
			If encontrado Then
				MsgBox("El código de alumno ya existe")
			Else
				SQL = "update alumno set nombre='"+Nombre+"', codigo='"+Codigo+"', carrera='"+Carrera+"'  where id_alumno = "+id
				BaseDatos.ActualizarBD(SQL)
				ButtonAlumnoClick(Nothing,Nothing)	
				mostrarBotones()
			End If
		End If
	End Sub
	
	
	Sub ButtonEliminarAlumnoClick(sender As Object, e As EventArgs)
		Dim id, sql, nombre As String 	
		
		nombre = dataGridViewAlumno.CurrentRow.Cells(1).Value.ToString
		
		If MsgBox("Desea eliminar al alumno: "+nombre, MsgBoxStyle.OkCancel, "Eliminar alumno") = vbOK Then
			id = dataGridViewAlumno.CurrentRow.Cells(0).Value.ToString
			sql = "delete from alumno where id_alumno = "+id
			BaseDatos.EliminarBD(sql)
			
			sql = "Delete from cursa where id_alumno = "+id
			BaseDatos.EliminarBD(sql)
			
			cargarTabla(sqlAlumno, dataGridViewAlumno)
			cargarTabla(sqlCursa, dataGridViewCursa)
			mostrarBotones()
		End If
	End Sub
	
	Sub DataGridViewAlumnoSelectionChanged(sender As Object, e As EventArgs)
		Dim codigo, materia, ciclo As String
		If dataGridViewMateria.RowCount > 0 Then
			
			cargarTabla(sqlMateria,dataGridViewMateria)
			
			codigo = dataGridViewAlumno.CurrentRow.Cells(2).Value.ToString
			ciclo = comboBoxCiclo.Text
			
			For i As Integer = 0 To dataGridViewCursa.RowCount-1
				If dataGridViewCursa.Rows(i).Cells(1).Value.ToString = codigo Then
					If dataGridViewCursa.Rows(i).Cells(4).Value.ToString = ciclo Then
						materia = dataGridViewCursa.Rows(i).Cells(3).Value.ToString
						Dim j As Integer = 0
						For Each fila As DataGridViewRow In dataGridViewMateria.Rows
							If dataGridViewMateria.Rows(j).Cells(1).Value.ToString = materia Then
								dataGridViewMateria.Rows.Remove(fila)
								
							End If
							j+=1
						Next
					End If
				End If
			Next i
		End If
	End Sub
	
	'MATERIA
	Sub ButtonMateriaClick(sender As Object, e As EventArgs)	
		DataGridViewAlumnoSelectionChanged(Nothing,Nothing)
	End Sub
	
	Sub ButtonAgregarMateriaClick(sender As Object, e As EventArgs)
		Dim Ventana As New V_agregarMateria("Agregar nueva materia","Agregar")		
		
		
		If Ventana.ShowDialog = DialogResult.OK Then
			Dim materia,nrc, clave, SQL As String
			Dim encontrado As Boolean = False
			materia = Ventana.materia
			nrc = Ventana.nrc
			clave = Ventana.clave
			For i As Integer = 0 To dataGridViewAlumno.RowCount-1
				If dataGridViewAlumno.Rows(i).Cells(2).Value.ToString = nrc Then
					encontrado = True
					Exit For
				End If
			Next i
			If encontrado Then
				MsgBox("El alumno ya existe")
			Else
				SQL = "insert into materia  (nombre,nrc,clave) values ('" + materia +  "','" + nrc + "','" + clave + "')"
				BaseDatos.InsertarBD(SQL)	
				DataGridViewAlumnoSelectionChanged(Nothing,Nothing)	
				mostrarBotones()
			End If
		End If
	End Sub
	
	Sub ButtonModificarMateriaClick(sender As Object, e As EventArgs)
		Dim id,materia, nrc, clave, SQL As String
		
		id = dataGridViewMateria.CurrentRow.Cells(0).Value.ToString
		materia = dataGridViewMateria.CurrentRow.Cells(1).Value.ToString
		nrc = dataGridViewMateria.CurrentRow.Cells(2).Value.ToString
		clave = dataGridViewMateria.CurrentRow.Cells(3).Value.ToString
		Dim ventana As New V_agregarMateria("Modificar materia","Modificar",materia,nrc,clave)
		If ventana.ShowDialog = DialogResult.OK Then
			Dim encontrado As Boolean = False
			materia = ventana.materia
			nrc = ventana.nrc
			clave = ventana.clave
			For i As Integer = 0 To dataGridViewAlumno.RowCount-1
				If dataGridViewMateria.Rows(i).Cells(2).Value.ToString = nrc Then
					encontrado = True
					Exit For
				End If
			Next i
			If encontrado Then
				MsgBox("El nrc de la mataria ya existe")
			Else
				SQL = "update materia set nombre='"+materia+"', nrc='"+nrc+"', clave='"+clave+"'  where id_materia = "+id
				BaseDatos.ActualizarBD(SQL)
				DataGridViewAlumnoSelectionChanged(Nothing,Nothing)
				mostrarBotones()
			End If
		End If
	End Sub
	
	Sub ButtonEliminarMateriaClick(sender As Object, e As EventArgs)
		Dim id, sql, materia As String 	
		
		materia = dataGridViewMateria.CurrentRow.Cells(1).Value.ToString
		
		If MsgBox("Desea eliminar la materia: "+materia, MsgBoxStyle.OkCancel, "Eliminar materia") = vbOK Then
			id = dataGridViewMateria.CurrentRow.Cells(0).Value.ToString
			sql = "delete from materia where id_materia = "+id
			BaseDatos.EliminarBD(sql)
			
			sql = "Delete from cursa where id_materia = "+id
			BaseDatos.EliminarBD(sql)
			
			DataGridViewAlumnoSelectionChanged(Nothing,Nothing)
			ButtonCargarCursoClick(Nothing,Nothing)
			mostrarBotones()
		End If
	End Sub
	
	'CURSA
	Sub ButtonCargarCursoClick(sender As Object, e As EventArgs)
		Dim id_alumno,SQL As String
		
		If checkBoxIndividual.Checked Then
			id_alumno = dataGridViewAlumno.CurrentRow.Cells(0).Value.ToString
			SQL = "select cursa.id_cursa as ID, alumno.codigo as Código, alumno.nombre as Nombre, materia.nombre as Materia, cursa.ciclo as Ciclo from cursa, alumno, materia where cursa.id_alumno = alumno.id_alumno and cursa.id_materia = materia.id_materia and cursa.id_alumno = " + id_alumno
		Else
			SQL = "select cursa.id_cursa as ID, alumno.codigo as Código, alumno.nombre as Nombre, materia.nombre as Materia, cursa.ciclo as Ciclo from cursa, alumno, materia where cursa.id_alumno = alumno.id_alumno and cursa.id_materia = materia.id_materia"
		End If
		cargarTabla(SQL,dataGridViewCursa)
		mostrarBotones()
		
	End Sub
	
	Sub ButtonInscribirClick(sender As Object, e As EventArgs)
		Dim id_alumno, id_materia, ciclo, sql As String
		
		id_alumno = dataGridViewAlumno.CurrentRow.Cells(0).Value.ToString
		id_materia = dataGridViewMateria.CurrentRow.Cells(0).Value.ToString
		ciclo = comboBoxCiclo.Text
		sql = "insert into cursa (id_alumno, id_materia, ciclo) values (" + id_alumno + "," + id_materia + ",'" + ciclo + "')"
		BaseDatos.InsertarBD(sql)		
		cargarTabla(sqlCursa, dataGridViewCursa)
		DataGridViewAlumnoSelectionChanged(Nothing,Nothing)
		mostrarBotones()
	End Sub
	
	
	
	Sub ButtoncancelarInscClick(sender As Object, e As EventArgs)
		Dim sql, id_cursa, codigo, materia, ciclo As String
		
		codigo = dataGridViewCursa.CurrentRow.Cells(1).Value.ToString
		materia = dataGridViewCursa.CurrentRow.Cells(3).Value.ToString
		ciclo = dataGridViewCursa.CurrentRow.Cells(4).Value.ToString
		
		If MsgBox("Desea cancelar la inscripcion del alumno con el codigo: "+codigo+" en la materia: "+materia+" del ciclo: "+ciclo+"?", MsgBoxStyle.OkCancel) = vbOK Then
			
			id_cursa = dataGridViewCursa.CurrentRow.Cells(0).Value.ToString
			sql = "Delete "+id_cursa+" from cursa where id_cursa = "+id_cursa
			BaseDatos.EliminarBD(sql)
			cargarTabla(sqlCursa, dataGridViewCursa)
			DataGridViewAlumnoSelectionChanged(Nothing,Nothing)
			mostrarBotones()
		End If
	End Sub
	
	
	'METODOS GENERALES
	Sub mostrarBotones()
		If dataGridViewAlumno.RowCount > 0 Then
			buttonEliminarAlumno.Enabled = True
			buttonModificarAlumno.Enabled = True
		Else
			buttonEliminarAlumno.Enabled = False
			buttonModificarAlumno.Enabled = False
		End If
		If dataGridViewMateria.RowCount > 0 Then
			buttonEliminarMateria.Enabled = True
			buttonModificarMateria.Enabled = True
		Else
			buttonEliminarMateria.Enabled = False
			buttonModificarMateria.Enabled = False
		End If
		If dataGridViewAlumno.RowCount > 0 And dataGridViewMateria.RowCount > 0 Then
			buttonInscribir.Enabled = True	
		Else
			buttonInscribir.Enabled = False
		End If
		If dataGridViewCursa.RowCount > 0 Then
			buttoncancelarInsc.Enabled = True
		Else
			buttoncancelarInsc.Enabled = False
		End If
	End Sub
	
	Sub cargarTabla(sql As String, tabla As DataGridView)
		tabla.DataSource = BaseDatos.ConsultaBD(sql)
	End Sub
	
	Sub ComboBoxCicloSelectedIndexChanged(sender As Object, e As EventArgs)
		DataGridViewAlumnoSelectionChanged(Nothing, Nothing)
	End Sub
	
	Sub CheckBoxIndividualCheckedChanged(sender As Object, e As EventArgs)
		ButtonCargarCursoClick(Nothing, Nothing)
	End Sub
End Class
