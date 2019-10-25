'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 24/10/2019
' Time: 08:28 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnDesencriptarTxt = New System.Windows.Forms.Button()
		Me.txtCadena = New System.Windows.Forms.TextBox()
		Me.btnEncriptarTxt = New System.Windows.Forms.Button()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.chbSobreEscribir = New System.Windows.Forms.CheckBox()
		Me.btnCargarArchivo = New System.Windows.Forms.Button()
		Me.txtRuta = New System.Windows.Forms.TextBox()
		Me.btnDesencriptarArchivo = New System.Windows.Forms.Button()
		Me.btnEncriptarArchivo = New System.Windows.Forms.Button()
		Me.opfCargar = New System.Windows.Forms.OpenFileDialog()
		Me.svfGuardar = New System.Windows.Forms.SaveFileDialog()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.btnDesencriptarTxt)
		Me.groupBox1.Controls.Add(Me.txtCadena)
		Me.groupBox1.Controls.Add(Me.btnEncriptarTxt)
		Me.groupBox1.Location = New System.Drawing.Point(12, 12)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(200, 237)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Texto a encriptar/desencriptar"
		'
		'btnDesencriptarTxt
		'
		Me.btnDesencriptarTxt.Location = New System.Drawing.Point(108, 208)
		Me.btnDesencriptarTxt.Name = "btnDesencriptarTxt"
		Me.btnDesencriptarTxt.Size = New System.Drawing.Size(86, 23)
		Me.btnDesencriptarTxt.TabIndex = 2
		Me.btnDesencriptarTxt.Text = "Desencriptar..."
		Me.btnDesencriptarTxt.UseVisualStyleBackColor = true
		AddHandler Me.btnDesencriptarTxt.Click, AddressOf Me.BtnDesencriptarTxtClick
		'
		'txtCadena
		'
		Me.txtCadena.Location = New System.Drawing.Point(6, 20)
		Me.txtCadena.Multiline = true
		Me.txtCadena.Name = "txtCadena"
		Me.txtCadena.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtCadena.Size = New System.Drawing.Size(188, 182)
		Me.txtCadena.TabIndex = 1
		'
		'btnEncriptarTxt
		'
		Me.btnEncriptarTxt.Location = New System.Drawing.Point(6, 208)
		Me.btnEncriptarTxt.Name = "btnEncriptarTxt"
		Me.btnEncriptarTxt.Size = New System.Drawing.Size(75, 23)
		Me.btnEncriptarTxt.TabIndex = 0
		Me.btnEncriptarTxt.Text = "Encriptar..."
		Me.btnEncriptarTxt.UseVisualStyleBackColor = true
		AddHandler Me.btnEncriptarTxt.Click, AddressOf Me.BtnEncriptarTxtClick
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.chbSobreEscribir)
		Me.groupBox2.Controls.Add(Me.btnCargarArchivo)
		Me.groupBox2.Controls.Add(Me.txtRuta)
		Me.groupBox2.Controls.Add(Me.btnDesencriptarArchivo)
		Me.groupBox2.Controls.Add(Me.btnEncriptarArchivo)
		Me.groupBox2.Location = New System.Drawing.Point(258, 12)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(200, 166)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "Archivo a encriptar/desencriptar"
		'
		'chbSobreEscribir
		'
		Me.chbSobreEscribir.Location = New System.Drawing.Point(7, 75)
		Me.chbSobreEscribir.Name = "chbSobreEscribir"
		Me.chbSobreEscribir.Size = New System.Drawing.Size(187, 24)
		Me.chbSobreEscribir.TabIndex = 7
		Me.chbSobreEscribir.Text = "Sobre escribir el archivo"
		Me.chbSobreEscribir.UseVisualStyleBackColor = true
		'
		'btnCargarArchivo
		'
		Me.btnCargarArchivo.Location = New System.Drawing.Point(7, 46)
		Me.btnCargarArchivo.Name = "btnCargarArchivo"
		Me.btnCargarArchivo.Size = New System.Drawing.Size(187, 23)
		Me.btnCargarArchivo.TabIndex = 6
		Me.btnCargarArchivo.Text = "Cargar archivo..."
		Me.btnCargarArchivo.UseVisualStyleBackColor = true
		AddHandler Me.btnCargarArchivo.Click, AddressOf Me.BtnCargarArchivoClick
		'
		'txtRuta
		'
		Me.txtRuta.Enabled = false
		Me.txtRuta.Location = New System.Drawing.Point(6, 19)
		Me.txtRuta.Name = "txtRuta"
		Me.txtRuta.Size = New System.Drawing.Size(188, 20)
		Me.txtRuta.TabIndex = 5
		Me.txtRuta.Text = "C:/"
		'
		'btnDesencriptarArchivo
		'
		Me.btnDesencriptarArchivo.Location = New System.Drawing.Point(110, 137)
		Me.btnDesencriptarArchivo.Name = "btnDesencriptarArchivo"
		Me.btnDesencriptarArchivo.Size = New System.Drawing.Size(84, 23)
		Me.btnDesencriptarArchivo.TabIndex = 4
		Me.btnDesencriptarArchivo.Text = "Desencriptar..."
		Me.btnDesencriptarArchivo.UseVisualStyleBackColor = true
		AddHandler Me.btnDesencriptarArchivo.Click, AddressOf Me.BtnDesencriptarArchivoClick
		'
		'btnEncriptarArchivo
		'
		Me.btnEncriptarArchivo.Location = New System.Drawing.Point(6, 137)
		Me.btnEncriptarArchivo.Name = "btnEncriptarArchivo"
		Me.btnEncriptarArchivo.Size = New System.Drawing.Size(75, 23)
		Me.btnEncriptarArchivo.TabIndex = 3
		Me.btnEncriptarArchivo.Text = "Encriptar..."
		Me.btnEncriptarArchivo.UseVisualStyleBackColor = true
		AddHandler Me.btnEncriptarArchivo.Click, AddressOf Me.BtnEncriptarArchivoClick
		'
		'opfCargar
		'
		Me.opfCargar.FileName = "openFileDialog1"
		'
		'btnSalir
		'
		Me.btnSalir.Location = New System.Drawing.Point(383, 220)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(75, 23)
		Me.btnSalir.TabIndex = 2
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.UseVisualStyleBackColor = true
		AddHandler Me.btnSalir.Click, AddressOf Me.BtnSalirClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(470, 261)
		Me.ControlBox = false
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Encriptador"
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private btnSalir As System.Windows.Forms.Button
	Private chbSobreEscribir As System.Windows.Forms.CheckBox
	Private txtRuta As System.Windows.Forms.TextBox
	Private btnCargarArchivo As System.Windows.Forms.Button
	Private svfGuardar As System.Windows.Forms.SaveFileDialog
	Private opfCargar As System.Windows.Forms.OpenFileDialog
	Private btnEncriptarArchivo As System.Windows.Forms.Button
	Private btnDesencriptarArchivo As System.Windows.Forms.Button
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private btnEncriptarTxt As System.Windows.Forms.Button
	Private txtCadena As System.Windows.Forms.TextBox
	Private btnDesencriptarTxt As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
