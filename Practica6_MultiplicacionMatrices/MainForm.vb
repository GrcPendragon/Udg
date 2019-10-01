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
		
		Cargar(matrizA, txtMatrizA)
		Cargar(matrizB, txtMatrizB)
		Dim longitud As Integer = UBound(matrizA)
		MsgBox(longitud.ToString)
		'ReDim matrizC (matrizA.Length)

	End Sub
	
	Sub Cargar(Matriz(,) As Integer, txt As TextBox)
		Dim filas As Integer = txt.Lines.Length - 1
		Dim col As Integer = txt.Lines(0).Split(Convert.ToChar(",")).Length - 1
		ReDim Matriz (filas, col)
		ReDim matrizC(filas, filas)
		For	i = 0 To filas
			For j = 0 To col
				Matriz(i,j) = Convert.ToInt32(txt.Lines(i).Split(Convert.ToChar(","))(j))
			Next
		Next
	End Sub
End Class
