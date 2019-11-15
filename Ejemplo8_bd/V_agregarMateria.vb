'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 07/11/2019
' Time: 09:27 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class V_agregarMateria	
	Public materia, nrc, clave As String
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub'ayuda no corre
	
	
	Public Sub New(Titulo As String, TituloBoton As String)
		Me.InitializeComponent()
		Me.Text = Titulo
		buttonAgregar.Text = TituloBoton
	End Sub
	
	Public Sub New(Titulo As String, TituloBoton As String, materia As String, nrc As String, clave As String)
		Me.InitializeComponent()
		Me.Text = Titulo
		textBoxMateria.Text = materia
		textBoxNRC.Text = nrc
		textBoxClave.Text = clave
		buttonAgregar.Text = TituloBoton
	End Sub
	
	
	Sub ButtonAgregarClick(sender As Object, e As EventArgs)
		
		materia = textBoxMateria.Text
		nrc = textBoxNRC.Text
		clave = textBoxClave.Text
		
		If materia = "" Or nrc = "" Or clave = "" Then
			MsgBox("Flatan campos por llenar")
		Else
			Me.DialogResult = DialogResult.OK
		End If
		
	End Sub
	
End Class
