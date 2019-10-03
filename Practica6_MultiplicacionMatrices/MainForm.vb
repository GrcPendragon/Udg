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
	Dim band As Boolean = true
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Function MatrizVacia (texto As String) As Boolean
		If texto = "" Then
			Return True
		End If
		Return False
	End Function
	
	Sub TxtMatrizATextChanged(sender As Object, e As EventArgs)
		If Not MatrizVacia(txtMatrizA.Text) Then
			'MsgBox("No esta vacia")
		End If
	End Sub
	
	Sub TxtMatrizBTextChanged(sender As Object, e As EventArgs)
		If Not MatrizVacia(txtMatrizB.Text) Then
			'MsgBox("No esta vacia")
		End If		
	End Sub
	
	Sub BtnCalcularClick(sender As Object, e As EventArgs)
		
		CargarA(txtMatrizA)
		CargarB(txtMatrizB)
		multiplicarMatriz()
		txtMatrizC.Text = ""
		If band Then
			mostrarResultado()
		End If
		

	End Sub
		
	Sub CargarA(txt As TextBox)
		Try
		Dim filas As Integer = txt.Lines.Length - 1
		Dim col As Integer = txt.Lines(0).Split(Convert.ToChar(",")).Length - 1
		ReDim matrizA (filas, col)
		
		For	i = 0 To filas
			For j = 0 To col
				matrizA(i,j) = Convert.ToInt32(txt.Lines(i).Split(Convert.ToChar(","))(j))
			Next
		Next
		Catch e As IndexOutOfRangeException
			MsgBox("Faltan valores por completar en la matriz.")
		Catch e As FormatException
			MsgBox("Ingrese solo valores numericos separador por una coma")
		Catch e As Exception
			MsgBox(e.ToString)	
		End Try
	End Sub
	
	Sub CargarB(txt As TextBox)
		Try
		Dim filas As Integer = txt.Lines.Length - 1
		Dim col As Integer = txt.Lines(0).Split(Convert.ToChar(",")).Length - 1
		ReDim matrizB (filas, col)
		
		For	i = 0 To filas
			For j = 0 To col
				matrizB(i,j) = Convert.ToInt32(txt.Lines(i).Split(Convert.ToChar(","))(j))
			Next
		Next
		Catch e As IndexOutOfRangeException
			MsgBox("Faltan valores por completar en la matriz.")
		Catch e As FormatException
			MsgBox("Ingresar solo numeros")
		Catch e As Exception
			MsgBox(e.ToString)	
		End Try
	End Sub
	
	Sub multiplicarMatriz()
		Try
		Dim filaA As Integer = txtMatrizA.Lines.Length - 1
		Dim columnaA As Integer = txtMatrizA.Lines(0).Split(Convert.ToChar(",")).Length-1
		Dim columnaB As Integer = txtMatrizB.Lines(0).Split(Convert.ToChar(",")).Length-1
		ReDim matrizC(filaA, columnaB)
		
		For x As Integer = 0 To filaA
			For y As Integer = 0 To columnaA
				For z As Integer = 0 To columnaB
					matrizC(x,z) += matrizA(x,y) * matrizB(y,z)
				Next z
			Next y
		Next x
		band = true
		Catch e As IndexOutOfRangeException
			MsgBox("Para una correcta multiplicación las matrices deben cumplir lo siguiente: "+vbLf+
			"- El numero de columnas de la matriz A deben ser iguales a las filas de la matriz B.")
			band = false
		Catch e As Exception
			MsgBox(e.ToString)
		End Try
		
	End Sub
	
	Sub mostrarResultado()
		Try
		Dim filaA As Integer = txtMatrizA.Lines.Length - 1
		Dim columnaB As Integer = txtMatrizB.Lines(0).Split(Convert.ToChar(",")).Length-1
		
		txtMatrizC.Visible = True
		
		For x As Integer = 0 To filaA
			For y As Integer = 0 To columnaB
				txtMatrizC.Text +="["+ matrizC(x,y).ToString + "]"
			Next y
			txtMatrizC.Text += vbCrLf
		Next x
		Catch e As IndexOutOfRangeException
			MsgBox("Faltan datos")
		Catch e As Exception
			MsgBox(e.ToString)
		End Try
		
	End Sub
End Class
