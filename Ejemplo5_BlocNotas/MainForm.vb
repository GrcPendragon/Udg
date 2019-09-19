'
' Created by SharpDevelop.
' User: E19
' Date: 06/09/2019
' Time: 07:31 a. m.
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
	
	Dim nombreArchivo As String
	Dim nombreArchivoDefault As String = "Sin nombre.txt"
	Dim textoModificado As Boolean = False
	Dim archivoExiste As Boolean = False
	
	Sub LimpiarTxt()
		txtEditor.Text = ""
		Me.Text = nombreArchivoDefault
		nombreArchivo = nombreArchivoDefault
		textoModificado = False
		archivoExiste = False
	End Sub
	
	Sub MnNuevoClick(sender As Object, e As EventArgs)
		
		Dim resultado As MsgBoxResult
		
		If textoModificado Then
			resultado = MsgBox("¿Deseas guardar los cambios de "+nombreArchivo+"?",MsgBoxStyle.YesNoCancel, "Bloc de notas")
			Select Case resultado
				Case vbYes 'MsgBoxResult.Yes
					If Guardar Then
						LimpiarTxt
					End If
				Case vbNo
					LimpiarTxt
			End Select
		Else
			LimpiarTxt
			
		End If
		
	End Sub
	
	Sub MnSalirClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
	
	Sub TxtEditorTextChanged(sender As Object, e As EventArgs)
		If Not textoModificado Then
			textoModificado = True
			Me.Text = "*" + nombreArchivo
		End If		
	End Sub
	
	Sub MainFormFormClosing(sender As Object, e As FormClosingEventArgs)
		Dim resultado As MsgBoxResult
		If textoModificado Then
			resultado = MsgBox("¿Deseas guardar los cambios de "+nombreArchivo+"?",MsgBoxStyle.YesNoCancel, "Bloc de notas")
			Select Case resultado
				Case vbYes 'MsgBoxResult.Yes
					Guardar
				Case vbCancel
					e.Cancel = True
			End Select
		End If
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		nombreArchivo = nombreArchivoDefault
	End Sub
	
	Sub AbrirArchivo()
		Dim respuesta As DialogResult
		respuesta = opfAbrir.ShowDialog
		
		If respuesta = DialogResult.OK Then
			
			nombreArchivo = opfAbrir.FileName
			txtEditor.Text = System.IO.File.ReadAllText(nombreArchivo)
			textoModificado = False
			
			Me.Text = nombreArchivo
			
		End If
		
	End Sub
	
	Sub MnAbrirClick(sender As Object, e As EventArgs)
		
		Dim resultado As MsgBoxResult
		
		If textoModificado Then
			resultado = MsgBox("¿Deseas guardar los cambios de "+nombreArchivo+"?",MsgBoxStyle.YesNoCancel, "Bloc de notas")
			Select Case resultado
				Case vbYes 'MsgBoxResult.Yes
					If Guardar Then
						AbrirArchivo
					End If
				Case vbNo
					AbrirArchivo
			End Select
		Else
			AbrirArchivo
		End If
		
	End Sub
	
	Function Guardar() As Boolean
		
		svdGuardarComo.FileName = nombreArchivo
		
		If archivoExiste Then
			
			System.IO.File.WriteAllText(nombreArchivo,txtEditor.Text)
			textoModificado = False
			Me.Text = nombreArchivo
			
		Else
			If svdGuardarComo.ShowDialog = vbOK Then
				
				nombreArchivo = svdGuardarComo.FileName
				System.IO.File.WriteAllText(nombreArchivo,txtEditor.Text)				
				textoModificado = False
				Me.Text = nombreArchivo
				archivoExiste = True
			Else
				Return False
			End If
		End If
		Return True
		
	End Function
	
	Sub MnGuardarComoClick(sender As Object, e As EventArgs)
		Dim edo_prev As Boolean
		edo_prev = archivoExiste		
		archivoExiste = False
		If Guardar = False Then
			archivoExiste = edo_prev
		End If
	End Sub
	
	Sub MnGuardarClick(sender As Object, e As EventArgs)
		Guardar
	End Sub
End Class
