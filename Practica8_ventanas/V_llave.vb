'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 24/10/2019
' Time: 08:28 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class V_llave
	Public texto As String
	
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Public Sub New(cadena As String)
		Me.InitializeComponent()
		labelTexto.Text = cadena		
	End Sub
	
	
	Sub ButtonCancelarClick(sender As Object, e As EventArgs)
			
	End Sub
	
	Sub ButtonAceptarClick(sender As Object, e As EventArgs)
		texto = textBoxLlave.Text	
		If Len(texto) > 0 Then
			Me.DialogResult = DialogResult.OK
		Else
			MsgBox("La longitud de la llave debe ser mayor a cero")			
		End If
	End Sub
	
	Sub V_llaveLoad(sender As Object, e As EventArgs)
		
	End Sub
	
End Class
