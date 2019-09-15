'
' Created by SharpDevelop.
' User: E19
' Date: 13/09/2019
' Time: 07:43 a. m.
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
	Dim lmSup,lmInf As Int32
	Dim sumatoria As Double
	Dim resultado As String = "El resultado de las sumatorias es: "+vbLf
	
	Sub BtnCalcularClick(sender As Object, e As EventArgs)
		
		lmInf = Convert.ToInt32(txtInf.Text)
		lmSup = Convert.ToInt32(txtSup.Text)
		If lmInf <= lmSup Then
			cicloFor
			cicloDoWhileIni
			cicloDoUntilIni
			cicloDoWhileFin
			cicloDoUntilFin
			lblResultado.Text = resultado
		Else
			MsgBox("El limite superior debe ser mayor al limite inferior")
		End If
		
		
		
		
	End Sub
	
	Sub cicloFor()
		sumatoria = 0
		For cont As Int32 = lmInf to lmSup 
			
			sumatoria = sumatoria + (1/cont)
			
		Next
		
		resultado = resultado + "For: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
	
	Sub cicloDoWhileIni()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do While cont <= lmSup
			
			sumatoria = sumatoria + (1/cont)
			cont +=1
			
		Loop
		
		resultado = resultado + "Do while: "+sumatoria.ToString("0.000")+vbLf
	End Sub
	
	Sub cicloDoUntilIni()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do Until cont = lmSup+1
			
			sumatoria = sumatoria + (1/cont)
			cont +=1
			
		Loop
		
		resultado = resultado + "Do Until: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
	
	Sub cicloDoWhileFin()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do 
			sumatoria = sumatoria + (1/cont)
			cont+=1
			
		Loop While cont <= lmSup
		
		resultado = resultado + "Do - While: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
	
	Sub cicloDoUntilFin()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do 
			
			sumatoria = sumatoria + (1/cont)
			cont+=1
			
		Loop Until cont = lmSup + 1
		
		resultado = resultado + "Do - Until: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
End Class
