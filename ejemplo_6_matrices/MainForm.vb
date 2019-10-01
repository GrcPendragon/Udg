'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 26/09/2019
' Time: 09:27 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Dim MatrizA(3,3) As TextBox
	Dim MatrizB(3,3) As TextBox
	Dim bandera As Boolean = False
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
	End Sub
	
	
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
		MatrizA(0,0)= textBoxA00
		MatrizA(0,1)= textBoxA01
		MatrizA(0,2)= textBoxA02
		MatrizA(0,3)= textBoxA03
		MatrizA(1,0)= textBoxA10
		MatrizA(1,1)= textBoxA11
		MatrizA(1,2)= textBoxA12
		MatrizA(1,3)= textBoxA13
		MatrizA(2,0)= textBoxA20
		MatrizA(2,1)= textBoxA21
		MatrizA(2,2)= textBoxA22
		MatrizA(2,3)= textBoxA23
		MatrizA(3,0)= textBoxA30
		MatrizA(3,1)= textBoxA31
		MatrizA(3,2)= textBoxA32
		MatrizA(3,3)= textBoxA33
		
		MatrizB(0,0)= textBoxB00
		MatrizB(0,1)= textBoxB01
		MatrizB(0,2)= textBoxB02
		MatrizB(0,3)= textBoxB03
		MatrizB(1,0)= textBoxB10
		MatrizB(1,1)= textBoxB11
		MatrizB(1,2)= textBoxB12
		MatrizB(1,3)= textBoxB13
		MatrizB(2,0)= textBoxB20
		MatrizB(2,1)= textBoxB21
		MatrizB(2,2)= textBoxB22
		MatrizB(2,3)= textBoxB23
		MatrizB(3,0)= textBoxB30
		MatrizB(3,1)= textBoxB31
		MatrizB(3,2)= textBoxB32
		MatrizB(3,3)= textBoxB33
		
		comboBoxColA.SelectedIndex=2
		comboBoxColB.SelectedIndex=2
		comboBoxFilasA.SelectedIndex=2
		comboBoxFilasB.SelectedIndex=2
		
		bandera=True
	End Sub
	
	Sub Ocultar(Matriz(,) As TextBox)
		For i As Integer = 0 To 3
			For j As Integer = 0 To 3
				Matriz(i,j).Visible=False
			Next j
		Next i
	End Sub
	
	Sub Mostrar(Matriz(,) As TextBox, filas As Integer, columnas As Integer)
		Ocultar(Matriz)
		For i As Integer = 0 To filas
			For j As Integer = 0 To columnas
				Matriz(i,j).Visible=true
			Next j
		Next i
	End Sub
	
	Sub MostrarA()
		If bandera = True Then
			Dim filas = Convert.ToInt32(comboBoxFilasA.Text)-1
			Dim columnas = Convert.ToInt32(comboBoxColA.Text)-1
			Mostrar(MatrizA,filas,columnas)
		End if
	End Sub
	
	Sub MostrarB()
		If bandera = True Then
			Dim filas = Convert.ToInt32(comboBoxFilasB.Text)-1
			Dim columnas = Convert.ToInt32(comboBoxColB.Text)-1
			Mostrar(MatrizB,filas,columnas)
		End if
	End Sub
	
	Sub ComboBoxFilasASelectedIndexChanged(sender As Object, e As EventArgs)
		MostrarA	
	End Sub
	
	Sub ComboBoxColASelectedIndexChanged(sender As Object, e As EventArgs)
		MostrarA
	End Sub
	
	Sub ComboBoxFilasBSelectedIndexChanged(sender As Object, e As EventArgs)
		MostrarB
	End Sub
	
	Sub ComboBoxColBSelectedIndexChanged(sender As Object, e As EventArgs)
		MostrarB		
	End Sub
End Class
