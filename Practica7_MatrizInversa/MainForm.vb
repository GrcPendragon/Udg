'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 10/10/2019
' Time: 10:09 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim matriz(2,2) As Integer
	Dim matrizId(2,2) As Integer
	Dim matrizInversa(2,2) As Integer
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub cargar(ByRef mtr(,) As Integer,ByRef mtrId(,) As Integer, txt As TextBox)
		Dim filas As Integer = txt.Lines.Length-1
		Dim columnas As Integer = txt.Lines(0).Split(Convert.ToChar(",")).Length - 1
		ReDim mtr(filas, columnas)
		ReDim mtrId(filas, columnas)
		
		For	i = 0 To filas
			For j = 0 To columnas
				mtr(i,j) = Convert.ToInt32(txt.Lines(i).Split(Convert.ToChar(","))(j))
				If i = j Then
					mtrId(i,j) = 1
				Else
					mtrId(i,j) = 0
				End If
			Next
		Next
		
	End Sub
	
	Sub mostrarResultado(matriz(,) As Integer)
		Try
			Dim filaA As Integer = txtMatriz.Lines.Length - 1
			Dim columnaB As Integer = txtMatriz.Lines(0).Split(Convert.ToChar(",")).Length-1
			
			
			For x As Integer = 0 To filaA
				For y As Integer = 0 To columnaB
					txtMatrizInversa.Text +="["+ matriz(x,y).ToString + "] "
				Next y
				txtMatrizInversa.Text += vbCrLf
			Next x
			
		Catch e As IndexOutOfRangeException
			MsgBox("Faltan datos")
		Catch e As Exception
			MsgBox(e.ToString)
		End Try
		
	End Sub	
	
	Sub BtnCalcularClick(sender As Object, e As EventArgs)
		txtMatrizInversa.Text = ""
		cargar(matriz, matrizId, txtMatriz)
		
		mostrarResultado(matrizInversa)
		
	End Sub
	
	Sub BtnLimpiarClick(sender As Object, e As EventArgs)
		txtMatriz.Text = ""
		txtMatrizInversa.Text = ""
	End Sub
	
	Sub BtnSalirClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
End Class
