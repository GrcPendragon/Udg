'
' Created by SharpDevelop.
' User: tecis
' Date: 22/08/2019
' Time: 09:13 a. m.
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

	
	Sub BtnAreaClick(sender As Object, e As EventArgs)
		Dim a,b As Integer
		Dim area As Single 'float en java
		
		Try
			a = Convert.ToInt32(txtbValorA.Text)
			b = Convert.ToInt32(txtbValorB.Text)
			
			area =Convert.ToSingle( a * b / 2 )
			
		Catch ex As FormatException
			MsgBox(ex.Message)
		Catch ex As Exception
		MsgBox(ex.Message)
		End Try
		MsgBox(area)
	End Sub
	
	Sub BtnPerimetroClick(sender As Object, e As EventArgs)
		Dim a,b As Integer
		Dim perimetro, h As Single 'float en java
		
		Try
			a = Convert.ToInt32(txtbValorA.Text)
			b = Convert.ToInt32(txtbValorB.Text)
			
			h = Convert.ToSingle(Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)))
			
			perimetro = a + b + h
			MsgBox(perimetro.ToString("0.00"))
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
