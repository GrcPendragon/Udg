'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 24/10/2019
' Time: 08:28 a. m.
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
	Dim cadena, llave, resultado, ruta As String
	
	'Metodo de Encriptacion
	Public Function Encriptar(Texto As String, Llave As String, Mode As Boolean ) As String 
		'Si Mode es falso, encripta, si es verdadero, desencripta
		
		Dim p As int32, j As int32, NuChr As int32
		Dim letraTexto As String, letraLlave As String, Salida As String = ""
		
		For j = 0 To Len(Texto) - 1
			letraTexto = Texto.Chars(j)
			If p = Len(Llave) - 1 Then 
				p = 0
			End If
			letraLlave = Llave.Chars(p)
			p += 1
			If Mode = False Then 'si es falso, encripta, si es verdadero, desencripta
				NuChr = Asc(letraTexto) + Asc(letraLlave)
				If NuChr > 255 Then
					NuChr = NuChr - 255
				End If
			Else
				NuChr = Asc(letraTexto) - Asc(letraLlave)
				If NuChr < 0 Then
					NuChr = NuChr + 255
				End If
			End If
			Salida &= Chr(NuChr)
		Next
		Return Salida
	End Function
	
	Sub encriptarTxt(mensaje As String, modo As Boolean)
		' Si el modo es falso encriptara y si es verdadero desencriptara
		Try
			Dim ventana = New V_llave("Ingrese la llave para "+mensaje)
			cadena = txtCadena.Text
			
			If Len(cadena) > 0 Then
				If ventana.ShowDialog = vbOK Then
					llave = ventana.texto
					resultado = Encriptar(cadena,llave, modo)
					If svfGuardar.ShowDialog = vbOK Then
						System.IO.File.WriteAllText(svfGuardar.FileName,resultado)
						txtCadena.Text = ""
						MsgBox("El texto se ha "+mensaje+" correctamente")
					End If
				End If
			Else
				MsgBox("No hay texto que "+mensaje)
			End If
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	
	Sub encriptarTxt(mensaje As String, ruta As String,modo As Boolean)
		' Si el modo es falso encriptara y si es verdadero desencriptara
		Try
			Dim ventana = New V_llave("Ingrese la llave para "+mensaje)
			cadena = System.IO.File.ReadAllText(ruta)
			
			If Len(cadena) > 0 Then
				If ventana.ShowDialog = vbOK Then
					llave = ventana.texto
					resultado = Encriptar(cadena,llave, modo)
					If Not chbSobreEscribir.Checked Then
						If svfGuardar.ShowDialog = vbOK Then
							ruta = svfGuardar.FileName
						End If
					End If
					System.IO.File.WriteAllText(ruta,resultado)
					MsgBox("El archivo se ha "+mensaje+" correctamente")
				End If
			Else
				MsgBox("No hay texto que "+mensaje)
			End If
		Catch ex As Exception
			MsgBox(ex.ToString)
		End Try
	End Sub
	
	' Eventos de botones GroupBox de Txt
	
	Sub BtnEncriptarTxtClick(sender As Object, e As EventArgs)
		encriptarTxt("encriptar", False)
	End Sub
	
	Sub BtnDesencriptarTxtClick(sender As Object, e As EventArgs)
		encriptarTxt("desencriptar", True)
	End Sub
	' Eventos de botones GroupBox de archivos
	
	Sub BtnEncriptarArchivoClick(sender As Object, e As EventArgs)
		If Len(ruta) > 0 Then
			encriptarTxt("encriptar", ruta, False)
		Else
			MsgBox("Elija una ruta donde guardar el archivo")
		End If
	End Sub
	
	Sub BtnDesencriptarArchivoClick(sender As Object, e As EventArgs)
		If Len(ruta) > 0 Then
			encriptarTxt("desencriptar", ruta, True)
		Else
			MsgBox("Elija una ruta donde guardar el archivo")
		End If
	End Sub
	
	Sub BtnCargarArchivoClick(sender As Object, e As EventArgs)
		If opfCargar.ShowDialog = vbOK Then
			ruta = opfCargar.FileName
			txtRuta.Text = ruta
		End If
	End Sub
	
	Sub BtnSalirClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
End Class
