'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 18/10/2019
' Time: 07:44 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub ButtonAbrirClick(sender As Object, e As EventArgs)
		Dim ventana = New V_llave("Cual es la llave para encriptar")
		Dim cadena As String
		
		'cadena = InputBox("Llave para encriptar","Llave")
		
		If ventana.ShowDialog = vbOK Then
			cadena = ventana.texto
			
		Else
			MsgBox("presiono boton cancelar")
		End If
		
	End Sub
End Class
