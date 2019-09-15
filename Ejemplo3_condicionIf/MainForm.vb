'
' Created by SharpDevelop.
' User: E19
' Date: 29/08/2019
' Time: 09:32 a. m.
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
	
	
	Sub ChbPrimariaCheckedChanged(sender As Object, e As EventArgs)
		If chbPrimaria.Checked = False Then
			chbSecundaria.Checked = False
			chbPrepa.Checked = False
			chbUniversidad.Checked = False
		End If
	End Sub
	
	
	
	Sub ChbSecundariaCheckedChanged(sender As Object, e As EventArgs)
		If chbSecundaria.Checked = True Then
			chbPrimaria.Checked = True
		Else 
			chbPrepa.Checked = False
'			chbUniversidad.Checked = False
		End If
	End Sub
	
	
	Sub ChbPrepaCheckedChanged(sender As Object, e As EventArgs)
		
		If chbPrepa.Checked = True Then
'			chbPrimaria.Checked = True
			chbSecundaria.Checked = True
		Else
			chbUniversidad.Checked = False
		End If
		
		
	End Sub
		
	
	Sub ChbUniversidadCheckedChanged(sender As Object, e As EventArgs)
		If chbUniversidad.Checked = True Then
'			chbPrimaria.Checked = True
'			chbSecundaria.Checked = True
			chbPrepa.Checked = True
		End If
	End Sub
	
	Sub BtnValidarClick(sender As Object, e As EventArgs)
		Dim mensaje As String
		If rdbSoltero.Checked = True And rdbSi.Checked = True Then
			mensaje = "La persona es soltera, trabaja y es feliz!"
		ElseIf rdbSoltero.Checked = True Then ' And rdbNo.Checked = True
			mensaje = "La persona es NINI"
		ElseIf rdbSi.Checked = True Then
			mensaje = "Es una persona responsable"
		Else 
			mensaje = "Es flojo mantenido"
		End If
		
		MsgBox("Tu mensaje es: " + mensaje)
	End Sub
	
	Sub BtnCerrarClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
End Class
