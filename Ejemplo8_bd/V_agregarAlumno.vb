'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 07/11/2019
' Time: 09:27 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class V_agregarAlumno
	Public nombre, codigo, carrera, boton As String
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub ButtonAgregarClick(sender As Object, e As EventArgs)
		nombre = textBoxNombre.Text
		codigo = textBoxCodigo.Text
		carrera = comboBoxCarrera.Text
		
		If nombre = "" Or codigo = "" Or carrera = "" Then
			MsgBox("Faltan datos por ingresar.")
		Else
			Me.DialogResult =vbOK
		End If
		
	End Sub
	
	
	Sub V_agregarAlumnoLoad(sender As Object, e As EventArgs)
		textBoxNombre = nombre
		textBoxCodigo = codigo
		comboBoxCarrera
	End Sub
End Class
