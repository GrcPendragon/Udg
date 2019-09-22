'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 20/09/2019
' Time: 07:55 a. m.
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
	
	Dim imgDefault As Image
	Dim posActual As Integer
	Dim rutas(4) As String
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		imgDefault = pcb1.BackgroundImage
		pcb2.BackgroundImage = imgDefault
		pcb3.BackgroundImage = imgDefault
		pcb4.BackgroundImage = imgDefault
	End Sub
	
	Sub Limpiar (Imagen As PictureBox)
		Imagen.BackgroundImage = imgDefault
	End Sub
	
	Sub Cargar (Imagen As PictureBox, posRuta As Integer)
		Dim ruta As String
		Try
			If opfCargar.ShowDialog = vbOK Then
				ruta = opfCargar.FileName
				Imagen.BackgroundImage = Imagen.Image.FromFile(ruta)
				rutas(posRuta) = ruta
			End If
		Catch ex As OutOfMemoryException
			MsgBox("Tipo de archivo no soportado")
		Catch ex As Exception
			MsgBox(ex)			
		End Try
	End Sub
	
	Sub MostrarImagen (Imagen As PictureBox)
		If Not Imagen.BackgroundImage Is imgDefault Then
			pcbPrincipal.BackgroundImage = Imagen.BackgroundImage
		End If
	End Sub
	
	Function InUse(ruta As String) As Boolean
		
		For x As Integer = 0 To rutas.Length
			
			If rutas(x) = ruta Then
				Return True
			End If
			
			Return False
		Next x
		
	End Function
	
	Sub BtnGuardarComoClick(sender As Object, e As EventArgs)
		Dim ruta As String
		
		Try
			If Not IsNothing(pcbPrincipal.BackgroundImage) Then
				If svfGuardarComo.ShowDialog = vbOK Then
					ruta = svfGuardarComo.FileName
					If Not InUse(ruta) Then
						pcbPrincipal.BackgroundImage.Save(ruta)
					Else
						MsgBox("Esta imagen esta siendo usada, no se puede sobreescribir.")
						BtnGuardarComoClick(sender, e)
					End If
				End If
			Else
				MsgBox("No se ha visualizado ninguna imagen para guardar.")
			End If
		Catch ex As Runtime.InteropServices.ExternalException
			MsgBox("Error, no se pudo sobreescribir la imagen.")
		Catch ex As Exception
			MsgBox("Entró a una exepción: "+ex.ToString)
		End Try
	End Sub
	
	Sub Anterior()
		If posActual = 1 Then
			posActual = 4
		Else
			posActual -= 1
		End If
		
		Select Case posActual
			Case 1
				If Not pcb1.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb1)
				Else
					Anterior()
				End If
			Case 2
				If Not pcb2.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb2)
				Else
					Anterior()
				End If
			Case 3
				If Not pcb3.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb3)
				Else
					Anterior()
				End If
			Case 4
				If Not pcb4.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb4)
				Else
					Anterior()
				End If			
		End Select
		
	End Sub
	
	Sub Siguiente()
		If posActual = 4 Then
			posActual = 1
		Else
			posActual += 1
		End If
		
		Select Case posActual
			Case 1
				If Not pcb1.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb1)
				Else
					Siguiente()
				End If
			Case 2
				If Not pcb2.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb2)
				Else
					Siguiente()
				End If
			Case 3
				If Not pcb3.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb3)
				Else
					Siguiente()
				End If
			Case 4
				If Not pcb4.BackgroundImage Is imgDefault Then
					MostrarImagen(pcb4)
				Else
					Siguiente()
				End If			
		End Select
		
	End Sub
	
	'Estilo para botones	
	Sub Mantener(btn As Button)
		btn.BackColor = Color.DarkCyan
	End Sub
	
	Sub Dejar(btn As Button)
		btn.BackColor = Color.Black
	End Sub
	
	'Botones Cargar
	Sub BtnCargar1Click(sender As Object, e As EventArgs)
		Cargar(pcb1, 0)
	End Sub
	
	Sub BtnCargar2Click(sender As Object, e As EventArgs)
		Cargar(pcb2, 1)
	End Sub
	
	Sub BtnCargar3Click(sender As Object, e As EventArgs)
		Cargar(pcb3, 2)
	End Sub
	
	Sub BtnCargar4Click(sender As Object, e As EventArgs)
		Cargar(pcb4, 3)
	End Sub
	
	'Botones Limpiar	
	Sub BtnLimpiarClick(sender As Object, e As EventArgs)
		pcbPrincipal.BackgroundImage = Nothing	
	End Sub
	
	Sub BtnLimpiar1Click(sender As Object, e As EventArgs)
		Limpiar(pcb1)		
	End Sub
	
	Sub BtnLimpiar2Click(sender As Object, e As EventArgs)
		Limpiar(pcb2)		
	End Sub
	
	Sub BtnLimpiar3Click(sender As Object, e As EventArgs)
		Limpiar(pcb3)		
	End Sub
	
	Sub BtnLimpiar4Click(sender As Object, e As EventArgs)
		Limpiar(pcb4)		
	End Sub
	
	'Eventos Asignar a principal
	Sub Pcb1Click(sender As Object, e As EventArgs)
		posActual = 1
		MostrarImagen(pcb1)
	End Sub	
	
	Sub Pcb2Click(sender As Object, e As EventArgs)
		posActual = 2
		MostrarImagen(pcb2)
	End Sub
	
	Sub Pcb3Click(sender As Object, e As EventArgs)
		posActual = 3
		MostrarImagen(pcb3)
	End Sub
	
	Sub Pcb4Click(sender As Object, e As EventArgs)
		posActual = 4
		MostrarImagen(pcb4)
	End Sub
	
	'Cursos sobre botones
	Sub BtnGuardarComoMouseHover(sender As Object, e As EventArgs)
		Mantener(btnGuardarComo)
	End Sub
	Sub BtnLimpiarMouseHover(sender As Object, e As EventArgs)
		Mantener(btnLimpiar)
	End Sub
	Sub BtnLimpiar1MouseHover(sender As Object, e As EventArgs)
		Mantener(btnLimpiar1)
	End Sub
	Sub BtnLimpiar2MouseHover(sender As Object, e As EventArgs)
		Mantener(btnLimpiar2)
	End Sub
	Sub BtnLimpiar3MouseHover(sender As Object, e As EventArgs)
		Mantener(btnLimpiar3)
	End Sub
	Sub BtnLimpiar4MouseHover(sender As Object, e As EventArgs)
		Mantener(btnLimpiar4)
	End Sub
	Sub BtnCargar1MouseHover(sender As Object, e As EventArgs)
		Mantener(btnCargar1)	
	End Sub
	Sub BtnCargar2MouseHover(sender As Object, e As EventArgs)
		Mantener(btnCargar2)	
	End Sub
	Sub BtnCargar3MouseHover(sender As Object, e As EventArgs)
		Mantener(btnCargar3)	
	End Sub
	Sub BtnCargar4MouseHover(sender As Object, e As EventArgs)
		Mantener(btnCargar4)	
	End Sub
	
	'Cursor abandona botones
	Sub BtnGuardarComoMouseLeave(sender As Object, e As EventArgs)
		Dejar(btnGuardarComo)
	End Sub
	Sub BtnLimpiarMouseLeave(sender As Object, e As EventArgs)
		Dejar(btnLimpiar)
	End Sub
	Sub BtnLimpiar1MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnLimpiar1)
	End Sub
	Sub BtnLimpiar2MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnLimpiar2)
	End Sub
	Sub BtnLimpiar3MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnLimpiar3)
	End Sub
	Sub BtnLimpiar4MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnLimpiar4)
	End Sub
	Sub BtnCargar1MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnCargar1)
	End Sub
	Sub BtnCargar2MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnCargar2)
	End Sub
	Sub BtnCargar3MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnCargar3)
	End Sub
	Sub BtnCargar4MouseLeave(sender As Object, e As EventArgs)
		Dejar(btnCargar4)
	End Sub
	
	'Iterar entre imagenes de los pictureBox
	Sub PcbAnteriorClick(sender As Object, e As EventArgs)
		Anterior()
	End Sub
	
	Sub PcbSiguienteClick(sender As Object, e As EventArgs)
		Siguiente()
	End Sub
End Class
