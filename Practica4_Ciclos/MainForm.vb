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
		resultado = "El resultado de las sumatorias es: "+vbLf
		
		Try
			
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
		Catch ex As FormatException
			MsgBox("Ingrese solo números")
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	
	'Metodo del CicloFor
	
	Sub cicloFor()
		sumatoria = 0
		For cont As Int32 = lmInf to lmSup 
			If cont = 0 Then
				Continue For
			Else
				sumatoria = sumatoria + (1/cont)
			End If
			
			
		Next
		
		resultado = resultado + "For: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
	
	'Metodo del CicloDoWhile
	
	Sub cicloDoWhileIni()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do While cont <= lmSup
			
			If cont = 0 Then
				cont +=1
				Continue Do
			Else
				sumatoria = sumatoria + (1/cont)
				cont +=1
			End If
			
		Loop
		
		resultado = resultado + "Do while: "+sumatoria.ToString("0.000")+vbLf
	End Sub
	
	'Metodo del CicloDoUntil
	
	Sub cicloDoUntilIni()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do Until cont = lmSup+1
			
			If cont = 0 Then
				cont +=1
				Continue Do
			Else
				sumatoria = sumatoria + (1/cont)
				cont +=1
			End If
			
		Loop
		
		resultado = resultado + "Do Until: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
	
	'Metodo del CicloDo-While
	
	Sub cicloDoWhileFin()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do 
			If cont = 0 Then
				cont +=1
				Continue Do
			Else
				sumatoria = sumatoria + (1/cont)
				cont +=1
			End If
			
		Loop While cont <= lmSup
		
		resultado = resultado + "Do - While: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
	
	'Metodo del CicloDo-Until
	
	Sub cicloDoUntilFin()
		Dim cont As Int32 = lmInf
		sumatoria = 0
		
		Do 
			
			If cont = 0 Then
				cont +=1
				Continue Do
			Else
				sumatoria = sumatoria + (1/cont)
				cont +=1
			End If
			
		Loop Until cont = lmSup + 1
		
		resultado = resultado + "Do - Until: "+sumatoria.ToString("0.000")+vbLf
		
	End Sub
	
	
	'Sustituido por el try catch con FormatException
	
'	Sub TxtSupTextChanged(sender As Object, e As EventArgs)
'		If Not IsNumero(txtSup.Text) Then
'			If txtSup.Text.Length <= 1 Then
'				txtSup.Text = "0"
'				MsgBox("Solo numeros")
'			Else
'				txtSup.Text = txtSup.Text.Remove(txtSup.Text.Length-1)
'				MsgBox("Solo numeros")
'			End If
'		End If
'	End Sub
'	
'	Sub TxtInfTextChanged(sender As Object, e As EventArgs)
'		If Not IsNumero(txtInf.Text) Then
'			If txtInf.Text.Length <= 1 Then
'				txtInf.Text = "0"
'				MsgBox("Solo numeros")
'			Else
'				txtInf.Text = txtInf.Text.Remove(txtInf.Text.Length-1)
'				MsgBox("Solo numeros")
'			End If
'		End If
'	End Sub
	
	'Funciones
	
	Public Function IsNumero(cadena As String) As Boolean
		Dim bandera As Boolean = False
		Dim valorAscii As Integer
		
		For x As Integer = 0 To cadena.Length-1
			valorAscii = Asc(cadena.Chars(x))
			
			Select valorAscii
				Case 48 To 57
					bandera = True	
				Case 45,46
					bandera = True
				Case Else
					bandera = false
			End Select
		Next
		Return bandera
	End Function
	
	
	
End Class
