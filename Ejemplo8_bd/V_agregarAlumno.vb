'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 07/11/2019
' Time: 09:27 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class V_agregarAlumno
	Public Nombre, Codigo, Carrera As String
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Public Sub New(Titulo As String, TituloBoton As String)
		Me.InitializeComponent()
		Me.Text = Titulo
		buttonAgregar.Text = TituloBoton
	End Sub
	
	Public Sub New(Titulo As String, TituloBoton As String, Nombre As String, Codigo As String, Carrera As String)
		Me.InitializeComponent()
		Me.Text = Titulo
		textBoxNombre.Text = Nombre
		textBoxCodigo.Text = Codigo
		comboBoxCarrera.Text = Carrera
		buttonAgregar.Text = TituloBoton
	End Sub
	
	
	Sub ButtonAgregarClick(sender As Object, e As EventArgs)
		
		Nombre = textBoxNombre.Text
		Codigo = textBoxCodigo.Text
		Carrera = comboBoxCarrera.Text
		
		If Nombre = "" Or Codigo = "" Or Carrera = "" Then
			MsgBox("Flatan campos por llenar")
		Else
			Me.DialogResult = DialogResult.OK
		End If
		
	End Sub
	
	Sub V_agregarAlumnoLoad(sender As Object, e As EventArgs)
		
		
	End Sub
End Class
