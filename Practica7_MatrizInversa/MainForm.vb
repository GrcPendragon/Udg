'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 10/10/2019
' Time: 10:09 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim matriz(2,2) As Double
	Dim matrizId(2,2) As Double
	'Dim matrizInversa(2,2) As Integer
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Function cargar(ByRef mtr(,) As Double,ByRef mtrId(,) As Double, txt As TextBox) As Boolean
		Try
			Dim filas As Integer = txt.Lines.Length-1
			Dim columnas As Integer = txt.Lines(0).Split(Convert.ToChar(",")).Length - 1
			ReDim mtr(filas, columnas)
			ReDim mtrId(filas, columnas)
			
			For	i = 0 To filas
				For j = 0 To columnas
					mtr(i,j) = Convert.ToDouble(txt.Lines(i).Split(Convert.ToChar(","))(j))
					If i = j Then
						mtrId(i,j) = 1
					Else
						mtrId(i,j) = 0
					End If
				Next
			Next
			Return True
		Catch e As FormatException
			MsgBox("Ingresar solo numeros")
		Catch e As IndexOutOfRangeException
			MsgBox("Faltan valores por completar en la matriz.")
		Catch e As Exception
			MsgBox(e.ToString)
			
		End Try
		Return False
	End Function
	
	Sub mostrarResultado(matriz(,) As Double)
		Try
			Dim filas As Integer = txtMatriz.Lines.Length - 1
			Dim columnas As Integer = txtMatriz.Lines(0).Split(Convert.ToChar(",")).Length-1
			
			
			For x As Integer = 0 To filas
				For y As Integer = 0 To columnas
					txtMatrizInversa.Text +="["+ matriz(x,y).ToString("0.00") + "] "
				Next y
				txtMatrizInversa.Text += vbCrLf
			Next x
			
		Catch e As IndexOutOfRangeException
			MsgBox("Faltan datos")
		Catch e As Exception
			MsgBox(e.ToString)
		End Try
		
	End Sub	
	
	Sub calcInversa(matriz(,) As Double, matrizId(,) As Double)
		Try
			Dim filas As Integer = txtMatriz.Lines.Length - 1
			Dim columnas As Integer = txtMatriz.Lines(0).Split(Convert.ToChar(",")).Length-1
			
			
			For y As Integer = 0 To columnas
				Dim pivote As Double
				
				pivote = matriz(y,y)
				If Not pivote = 1 Then
					
					For x As Integer = 0 To filas
						matriz(y,x) /= pivote
						matrizId(y,x) /= pivote
					Next x
					
				End If
				
				For fil As Integer = 0 To filas
					Dim valor As Double = matriz(fil, y)
					If Not fil = y Then
						For col As Integer = 0 To columnas
							
							matriz(fil, col) = (-valor*matriz(y,col))+ matriz(fil,col)
							matrizId(fil, col)= (-valor*matrizId(y,col))+matrizId(fil, col)
							
						Next col
					End If
				Next fil
			Next y
		Catch e As Exception
			MsgBox(e)
		End Try 
	End Sub
	
	Sub BtnCalcularClick(sender As Object, e As EventArgs)
		txtMatrizInversa.Text = ""
		If cargar(matriz, matrizId, txtMatriz) Then
			If matriz(0,0) <> 0 Then
				calcInversa(matriz, matrizId)
				mostrarResultado(matrizId)
			Else
				MsgBox("La matriz no tiene solución")
			End If
		Else
			MsgBox("No se han ingresado datos")
		End If
	End Sub
	
	Sub BtnLimpiarClick(sender As Object, e As EventArgs)
		txtMatriz.Text = ""
		txtMatrizInversa.Text = ""
	End Sub
	
	Sub BtnSalirClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
End Class
