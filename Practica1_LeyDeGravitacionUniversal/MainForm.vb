'
' Created by SharpDevelop.
' User: tecis
' Date: 23/08/2019
' Time: 07:53 a. m.
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
	
	
	
	
	Sub BtnCalcularClick(sender As Object, e As EventArgs)
		
		Dim cuerpoA,cuerpoB,distancia,fuerza As Double
		
		Const g As Double = 0.0000000000667
		
		Try
			cuerpoA =Convert.ToDouble(txtbCuerpoA.Text)
			cuerpoB =Convert.ToDouble(txtbCuerpoB.Text)
			distancia =Convert.ToDouble(txtbDistancia.Text)
			
			fuerza = g * (cuerpoA * cuerpoB / Math.Pow(distancia,2))
			
			lblFuerza.Text = fuerza.ToString + " N"
			
		Catch ex As FormatException
			MsgBox(ex.Message)
		Catch ex As Exception
		MsgBox(ex.Message)
		End Try		
		
		
	End Sub
	
	
	Sub BtnSalirClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
End Class
