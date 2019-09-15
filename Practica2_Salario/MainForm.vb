'
' Created by SharpDevelop.
' User: E19
' Date: 30/08/2019
' Time: 07:17 a. m.
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
	
	Sub BtnValidarJubilacionClick(sender As Object, e As EventArgs)
		
		Dim msg As String = ""
		Dim añosFaltantes, edadFaltante, servicio, edad As Int32
		Dim generoH, hijosSi As Boolean
		Try
			servicio = Convert.ToInt32(txtServicio.Text)
			edad = Convert.ToInt32(txtEdad.Text)
			generoH = rdbHombre.Checked
			hijosSi = rdbSiHijos.Checked
			
			If generoH = True Then
				edadFaltante = 65 - edad
				añosFaltantes = 30 - servicio
				If edad >= 65 Then
					If servicio >= 30 Then
						msg = "¡Felicidades!, eres elegible para jubilación."
					Else						
						msg = "Lo sentimos, te faltan " + añosFaltantes.ToString + " de servicio."
					End If
				Elseif servicio >= 30 Then
					msg = "Lo sentimos, te faltan " + edadFaltante.ToString + " de edad."
				Else					
					msg = "Lo sentimos, te faltan " + edadFaltante.ToString + " de edad y " + añosFaltantes.ToString + " de servicio."
				End If
				
			ElseIf hijosSi Then
				añosFaltantes = 20 - servicio
				edadFaltante = 50 - edad
				If edad >= 50 Then
					If servicio >= 20 Then
						msg = "¡Felicidades!, eres elegible para jubilación."
					Else
						msg = "Lo sentimos, te faltan " + añosFaltantes.ToString + " de servicio."
					End If
				ElseIf servicio >= 20 Then
					msg = "Lo sentimos, te faltan " + edadFaltante.ToString + " de edad."
				Else
					msg = "Lo sentimos, te faltan " + edadFaltante.ToString + " de edad y " + añosFaltantes.ToString + " de servicio"
				End If
				
			Else
				añosFaltantes = 25 - servicio
				edadFaltante = 50 - edad
				If edad >= 50 Then
					If servicio >= 25 Then
						msg = "¡Felicidades!, eres elegible para jubilación."
					Else
						msg = "Lo sentimos, te faltan " + añosFaltantes.ToString + " de servicio."
					End If
				ElseIf servicio >= 25 Then
					msg = "Lo sentimos, te faltan " + edadFaltante.ToString + " de edad."
				Else
					msg = "Lo sentimos, te faltan " + edadFaltante.ToString + " de edad y " + añosFaltantes.ToString + " de servicio."		
				End If
			End If
			
		Catch ex As FormatException
			MsgBox("No has escrito numeros")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try	
		
		lblAprobacion.Text = msg
		
	End Sub
	
	Sub BtnCerrarClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
End Class
