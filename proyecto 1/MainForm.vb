'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 16/08/2019
' Time: 07:32 a. m.
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
	
	Sub BtnAdiosClick(sender As Object, e As EventArgs)
		
		Me.Close
		
	End Sub
	
	Sub BtnHolaClick(sender As Object, e As EventArgs)
		MsgBox("Hola Mundo!")
	End Sub
	
	Sub BtnMensajeClick(sender As Object, e As EventArgs)
		
		Dim txt As String
		
		
		txt = txtbTexto.Text
		
		MsgBox(txt, MsgBoxStyle.OkCancel Or MsgBoxStyle.Information Or MsgBoxStyle.DefaultButton2,"Somos panques")
		
	End Sub
End Class
