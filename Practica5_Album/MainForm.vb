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
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		imgDefault = pcb1.BackgroundImage
		pcb2.BackgroundImage = imgDefault
		pcb3.BackgroundImage = imgDefault
		pcb4.BackgroundImage = imgDefault
	End Sub
	
	Sub Limpiar (Imagen As PictureBox)
		Imagen.BackgroundImage = imgDefault
	End Sub
	
	Sub Cargar (Imagen As PictureBox)
		Dim ruta As String
		Try
			If opfCargar.ShowDialog = vbOK Then
				ruta = opfCargar.FileName
				Imagen.BackgroundImage = Imagen.Image.FromFile(ruta)
				
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
	
	Sub BtnGuardarComoClick(sender As Object, e As EventArgs)
		Dim ruta As String
		Dim puntito As Integer
		Dim formato As String
		
		Try
			If Not IsNothing(pcbPrincipal.BackgroundImage) Then
				If svfGuardarComo.ShowDialog = vbOK Then
					ruta = svfGuardarComo.FileName
					puntito = ruta.LastIndexOf(".")
					formato = ruta.Substring(puntito+1)					
					MsgBox(formato)
					Select Case formato		
						Case "jpg"
							pcbPrincipal.BackgroundImage.Save(ruta,System.Drawing.Imaging.ImageFormat.Jpeg)
							
						Case "gif"
							pcbPrincipal.BackgroundImage.Save(ruta,System.Drawing.Imaging.ImageFormat.Gif)
							
						Case "png"
							pcbPrincipal.BackgroundImage.Save(ruta,System.Drawing.Imaging.ImageFormat.Png)
							
						Case "bmp"
							pcbPrincipal.BackgroundImage.Save(ruta,System.Drawing.Imaging.ImageFormat.Bmp)
						Case Else
							MsgBox("Archivo no soportado")
					End Select	
				End If
			Else
				MsgBox("No se ha visualizado ninguna imagen para guardar.")
			End If
		Catch ex As Runtime.InteropServices.ExternalException
			MsgBox("Error desconodico")
		Catch ex As Exception
			MsgBox("Entró a una exepción: "+ex.ToString)
		End Try
	End Sub
	
	Sub Hover(btn As Label)
		btn.BackColor = Color.DarkCyan
	End Sub
	
	Sub Leave(btn As Label)
		btn.BackColor = Color.Transparent
	End Sub
	
	'Botones Cargar
	Sub BtnCargar1Click(sender As Object, e As EventArgs)
		Cargar(pcb1)
	End Sub
	
	Sub BtnCargar2Click(sender As Object, e As EventArgs)
		Cargar(pcb2)
	End Sub
	
	Sub BtnCargar3Click(sender As Object, e As EventArgs)
		Cargar(pcb3)
	End Sub
	
	Sub BtnCargar4Click(sender As Object, e As EventArgs)
		Cargar(pcb4)
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
		MostrarImagen(pcb1)
	End Sub	
	
	Sub Pcb2Click(sender As Object, e As EventArgs)
		MostrarImagen(pcb2)
	End Sub
	
	Sub Pcb3Click(sender As Object, e As EventArgs)
		MostrarImagen(pcb3)
	End Sub
	
	Sub Pcb4Click(sender As Object, e As EventArgs)
		MostrarImagen(pcb4)
	End Sub
	
	'Cursos sobre botones
	Sub BtnGuardarComoMouseHover(sender As Object, e As EventArgs)
		Hover(btnGuardarComo)
	End Sub
	Sub BtnLimpiarMouseHover(sender As Object, e As EventArgs)
		Hover(btnLimpiar)
	End Sub
	Sub BtnLimpiar1MouseHover(sender As Object, e As EventArgs)
		Hover(btnLimpiar1)
	End Sub
	Sub BtnLimpiar2MouseHover(sender As Object, e As EventArgs)
		Hover(btnLimpiar2)
	End Sub
	Sub BtnLimpiar3MouseHover(sender As Object, e As EventArgs)
		Hover(btnLimpiar3)
	End Sub
	Sub BtnLimpiar4MouseHover(sender As Object, e As EventArgs)
		Hover(btnLimpiar4)
	End Sub
	
	'Cursor abandona botones
	Sub BtnGuardarComoMouseLeave(sender As Object, e As EventArgs)
		Leave(btnGuardarComo)
	End Sub
	Sub BtnLimpiarMouseLeave(sender As Object, e As EventArgs)
		Leave(btnLimpiar)
	End Sub
	Sub BtnLimpiar1MouseLeave(sender As Object, e As EventArgs)
		Leave(btnLimpiar1)
	End Sub
	Sub BtnLimpiar2MouseLeave(sender As Object, e As EventArgs)
		Leave(btnLimpiar2)
	End Sub
	Sub BtnLimpiar3MouseLeave(sender As Object, e As EventArgs)
		Leave(btnLimpiar3)
	End Sub
	Sub BtnLimpiar4MouseLeave(sender As Object, e As EventArgs)
		Leave(btnLimpiar4)
	End Sub
	
End Class
