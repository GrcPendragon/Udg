'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 24/10/2019
' Time: 08:50 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class V_llave
	Public Dim texto As String	
	Public Sub New()
		Me.InitializeComponent()
		
	End Sub
	
	Public Sub New(cadena As String)
		Me.InitializeComponent()
		lblCadena.Text = cadena
	End Sub
	
	'Eventos de botones
	
	Sub BtnAceptarClick(sender As Object, e As EventArgs)
		texto = txtLlave.Text	
		If Len(texto) > 0 Then
			Me.DialogResult = DialogResult.OK
		Else
			MsgBox("La longitud de la llave debe ser mayor a cero")
			
		End If
	End Sub
	
	Sub BtnCancelarClick(sender As Object, e As EventArgs)
		Me.DialogResult = DialogResult.Cancel
	End Sub
End Class
