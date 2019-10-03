'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 27/09/2019
' Time: 07:47 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim matrizA(0,0) As Integer
	Dim matrizB(0,0) As Integer
	Dim matrizC(0,0) As Integer
	Dim band As Boolean = True
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Sub BtnCalcularClick(sender As Object, e As EventArgs)
		If Cargar(matrizA, txtMatrizA) Then 
			If Cargar(matrizB, txtMatrizB) Then
				txtMatrizC.Text = ""
				If multiplicarMatriz(matrizA,matrizB,matrizC) Then mostrarResultado(matrizC)
			End If
		End If
	End Sub
	
	Function Cargar(byref matriz(,) As Integer, txt As TextBox) As Boolean
		Try
			Dim filas As Integer = txt.Lines.Length - 1
			Dim col As Integer = txt.Lines(0).Split(Convert.ToChar(",")).Length - 1
			ReDim matriz (filas, col)
			
			For	i = 0 To filas
				For j = 0 To col
					matriz(i,j) = Convert.ToInt32(txt.Lines(i).Split(Convert.ToChar(","))(j))
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
	
	Function multiplicarMatriz(matriz1(,)As Integer,matriz2(,) As Integer,byref matriz3(,) As Integer) As Boolean
		Try
			Dim filaA As Integer = txtMatrizA.Lines.Length - 1
			Dim columnaA As Integer = txtMatrizA.Lines(0).Split(Convert.ToChar(",")).Length-1
			Dim filaB As Integer = txtMatrizB.Lines.Length - 1 
			Dim columnaB As Integer = txtMatrizB.Lines(0).Split(Convert.ToChar(",")).Length-1
			If columnaA = filaB Then
				ReDim matriz3(filaA, columnaB)
				
				
				For x As Integer = 0 To filaA
					For y As Integer = 0 To columnaA
						For z As Integer = 0 To columnaB
							matriz3(x,z) += matriz1(x,y) * matriz2(y,z)
						Next z
					Next y
				Next x
				Return True
			Else
				MsgBox("El número de columnas de la matriz A deben ser iguales al número de filas de la matriz B")
			End If
		Catch e As IndexOutOfRangeException
			MsgBox("Para una correcta multiplicación las matrices deben cumplir lo siguiente: "+vbLf+
				"- El numero de columnas de la matriz A deben ser iguales a las filas de la matriz B.")
		Catch e As Exception
			MsgBox(e.ToString)
		End Try
		Return False
	End Function
	
	Sub mostrarResultado(matriz(,) As Integer)
		Try
			Dim filaA As Integer = txtMatrizA.Lines.Length - 1
			Dim columnaB As Integer = txtMatrizB.Lines(0).Split(Convert.ToChar(",")).Length-1
			
			txtMatrizC.Visible = True
			
			For x As Integer = 0 To filaA
				For y As Integer = 0 To columnaB
					txtMatrizC.Text +="["+ matriz(x,y).ToString + "] "
				Next y
				txtMatrizC.Text += vbCrLf
			Next x
			
		Catch e As IndexOutOfRangeException
			MsgBox("Faltan datos")
		Catch e As Exception
			MsgBox(e.ToString)
		End Try
		
	End Sub	
	
	Sub BtnLimpiarClick(sender As Object, e As EventArgs)
		txtMatrizA.Text = ""
		txtMatrizB.Text = ""
		txtMatrizC.Text = ""
		txtMatrizC.Visible = False
	End Sub
	
	Sub BtnSalirClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
End Class
