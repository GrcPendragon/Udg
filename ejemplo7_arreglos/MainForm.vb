
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()

	End Sub
	
	Dim MatrizA(3,3) As Integer
	Dim MatrizB(3,3) As Integer
	
	Sub Cargar(Matriz(,) As Integer, txt As TextBox)
		Dim filas As Integer = txt.Lines.Length - 1
		Dim col As Integer = txt.Lines(0).Split(",").Length - 1

		For	i = 0 To filas
			For j = 0 To col
				Matriz(i,j) = Convert.ToInt32(txt.Lines(i).Split(",")(j))
			Next
		Next
	End Sub
		
	Sub Button1Click(sender As Object, e As EventArgs)
		Cargar(MatrizA,textBoxA)
		Cargar(MatrizB,textBoxB)
		
	End Sub
End Class
