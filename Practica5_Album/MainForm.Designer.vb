'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 20/09/2019
' Time: 07:55 a. m.
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.pcbPrincipal = New System.Windows.Forms.PictureBox()
		Me.pcb1 = New System.Windows.Forms.PictureBox()
		Me.pcb2 = New System.Windows.Forms.PictureBox()
		Me.pcb3 = New System.Windows.Forms.PictureBox()
		Me.pcb4 = New System.Windows.Forms.PictureBox()
		Me.opfCargar = New System.Windows.Forms.OpenFileDialog()
		Me.svfGuardarComo = New System.Windows.Forms.SaveFileDialog()
		Me.lblAnterior = New System.Windows.Forms.Label()
		Me.lblSiguiente = New System.Windows.Forms.Label()
		Me.btnLimpiar1 = New System.Windows.Forms.Label()
		Me.btnCargar1 = New System.Windows.Forms.Label()
		Me.btnCargar2 = New System.Windows.Forms.Label()
		Me.btnLimpiar2 = New System.Windows.Forms.Label()
		Me.btnCargar3 = New System.Windows.Forms.Label()
		Me.btnLimpiar3 = New System.Windows.Forms.Label()
		Me.btnCargar4 = New System.Windows.Forms.Label()
		Me.btnLimpiar4 = New System.Windows.Forms.Label()
		Me.btnLimpiar = New System.Windows.Forms.Label()
		Me.btnGuardarComo = New System.Windows.Forms.Label()
		CType(Me.pcbPrincipal,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb4,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pcbPrincipal
		'
		Me.pcbPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.pcbPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pcbPrincipal.Location = New System.Drawing.Point(118, 12)
		Me.pcbPrincipal.Name = "pcbPrincipal"
		Me.pcbPrincipal.Size = New System.Drawing.Size(406, 252)
		Me.pcbPrincipal.TabIndex = 0
		Me.pcbPrincipal.TabStop = false
		'
		'pcb1
		'
		Me.pcb1.BackgroundImage = CType(resources.GetObject("pcb1.BackgroundImage"),System.Drawing.Image)
		Me.pcb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pcb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pcb1.Location = New System.Drawing.Point(12, 309)
		Me.pcb1.Name = "pcb1"
		Me.pcb1.Size = New System.Drawing.Size(150, 150)
		Me.pcb1.TabIndex = 1
		Me.pcb1.TabStop = false
		AddHandler Me.pcb1.Click, AddressOf Me.Pcb1Click
		'
		'pcb2
		'
		Me.pcb2.BackgroundImage = CType(resources.GetObject("pcb2.BackgroundImage"),System.Drawing.Image)
		Me.pcb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pcb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pcb2.Location = New System.Drawing.Point(168, 309)
		Me.pcb2.Name = "pcb2"
		Me.pcb2.Size = New System.Drawing.Size(150, 150)
		Me.pcb2.TabIndex = 4
		Me.pcb2.TabStop = false
		AddHandler Me.pcb2.Click, AddressOf Me.Pcb2Click
		'
		'pcb3
		'
		Me.pcb3.BackgroundImage = CType(resources.GetObject("pcb3.BackgroundImage"),System.Drawing.Image)
		Me.pcb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pcb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pcb3.Location = New System.Drawing.Point(324, 309)
		Me.pcb3.Name = "pcb3"
		Me.pcb3.Size = New System.Drawing.Size(150, 150)
		Me.pcb3.TabIndex = 5
		Me.pcb3.TabStop = false
		AddHandler Me.pcb3.Click, AddressOf Me.Pcb3Click
		'
		'pcb4
		'
		Me.pcb4.BackgroundImage = CType(resources.GetObject("pcb4.BackgroundImage"),System.Drawing.Image)
		Me.pcb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.pcb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pcb4.Location = New System.Drawing.Point(480, 309)
		Me.pcb4.Name = "pcb4"
		Me.pcb4.Size = New System.Drawing.Size(150, 150)
		Me.pcb4.TabIndex = 6
		Me.pcb4.TabStop = false
		AddHandler Me.pcb4.Click, AddressOf Me.Pcb4Click
		'
		'opfCargar
		'
		Me.opfCargar.DefaultExt = "jpg"
		Me.opfCargar.Filter = "Archivos JPG|*.jpg|Archivos PNG|*.png|Archivos GIF|*.gif|Archivos BMP|*.bmp|Todos"& _ 
		" los archivos|*.*"
		Me.opfCargar.Title = "Cargar imagen"
		'
		'svfGuardarComo
		'
		Me.svfGuardarComo.DefaultExt = "jpg"
		Me.svfGuardarComo.Filter = "Archivos JPG|*.jpg|Archivos PNG|*.png|Archivos GIF|*.gif|Archivos BMP|*.bmp|Todos"& _ 
		" los archivos|*.*"
		Me.svfGuardarComo.Title = "Guardar imagen"
		'
		'lblAnterior
		'
		Me.lblAnterior.ForeColor = System.Drawing.Color.White
		Me.lblAnterior.Location = New System.Drawing.Point(12, 21)
		Me.lblAnterior.Name = "lblAnterior"
		Me.lblAnterior.Size = New System.Drawing.Size(100, 233)
		Me.lblAnterior.TabIndex = 18
		Me.lblAnterior.Text = "Anterior"
		Me.lblAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblSiguiente
		'
		Me.lblSiguiente.ForeColor = System.Drawing.Color.White
		Me.lblSiguiente.Location = New System.Drawing.Point(530, 21)
		Me.lblSiguiente.Name = "lblSiguiente"
		Me.lblSiguiente.Size = New System.Drawing.Size(100, 233)
		Me.lblSiguiente.TabIndex = 19
		Me.lblSiguiente.Text = "Siguiente"
		Me.lblSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnLimpiar1
		'
		Me.btnLimpiar1.BackColor = System.Drawing.Color.Transparent
		Me.btnLimpiar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnLimpiar1.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar1.Location = New System.Drawing.Point(12, 462)
		Me.btnLimpiar1.Name = "btnLimpiar1"
		Me.btnLimpiar1.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar1.TabIndex = 20
		Me.btnLimpiar1.Text = "Limpiar"
		Me.btnLimpiar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnLimpiar1.Click, AddressOf Me.BtnLimpiar1Click
		AddHandler Me.btnLimpiar1.MouseLeave, AddressOf Me.BtnLimpiar1MouseLeave
		AddHandler Me.btnLimpiar1.MouseHover, AddressOf Me.BtnLimpiar1MouseHover
		'
		'btnCargar1
		'
		Me.btnCargar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnCargar1.ForeColor = System.Drawing.Color.White
		Me.btnCargar1.Location = New System.Drawing.Point(92, 462)
		Me.btnCargar1.Name = "btnCargar1"
		Me.btnCargar1.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar1.TabIndex = 21
		Me.btnCargar1.Text = "Cargar..."
		Me.btnCargar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnCargar1.Click, AddressOf Me.BtnCargar1Click
		'
		'btnCargar2
		'
		Me.btnCargar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnCargar2.ForeColor = System.Drawing.Color.White
		Me.btnCargar2.Location = New System.Drawing.Point(248, 462)
		Me.btnCargar2.Name = "btnCargar2"
		Me.btnCargar2.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar2.TabIndex = 23
		Me.btnCargar2.Text = "Cargar..."
		Me.btnCargar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnCargar2.Click, AddressOf Me.BtnCargar2Click
		'
		'btnLimpiar2
		'
		Me.btnLimpiar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnLimpiar2.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar2.Location = New System.Drawing.Point(168, 462)
		Me.btnLimpiar2.Name = "btnLimpiar2"
		Me.btnLimpiar2.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar2.TabIndex = 22
		Me.btnLimpiar2.Text = "Limpiar"
		Me.btnLimpiar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnLimpiar2.Click, AddressOf Me.BtnLimpiar2Click
		AddHandler Me.btnLimpiar2.MouseHover, AddressOf Me.BtnLimpiar2MouseHover
		'
		'btnCargar3
		'
		Me.btnCargar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnCargar3.ForeColor = System.Drawing.Color.White
		Me.btnCargar3.Location = New System.Drawing.Point(404, 462)
		Me.btnCargar3.Name = "btnCargar3"
		Me.btnCargar3.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar3.TabIndex = 25
		Me.btnCargar3.Text = "Cargar..."
		Me.btnCargar3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnCargar3.Click, AddressOf Me.BtnCargar3Click
		'
		'btnLimpiar3
		'
		Me.btnLimpiar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnLimpiar3.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar3.Location = New System.Drawing.Point(324, 462)
		Me.btnLimpiar3.Name = "btnLimpiar3"
		Me.btnLimpiar3.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar3.TabIndex = 24
		Me.btnLimpiar3.Text = "Limpiar"
		Me.btnLimpiar3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnLimpiar3.Click, AddressOf Me.BtnLimpiar3Click
		AddHandler Me.btnLimpiar3.MouseHover, AddressOf Me.BtnLimpiar3MouseHover
		'
		'btnCargar4
		'
		Me.btnCargar4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnCargar4.ForeColor = System.Drawing.Color.White
		Me.btnCargar4.Location = New System.Drawing.Point(560, 462)
		Me.btnCargar4.Name = "btnCargar4"
		Me.btnCargar4.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar4.TabIndex = 27
		Me.btnCargar4.Text = "Cargar..."
		Me.btnCargar4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnCargar4.Click, AddressOf Me.BtnCargar4Click
		'
		'btnLimpiar4
		'
		Me.btnLimpiar4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnLimpiar4.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar4.Location = New System.Drawing.Point(480, 462)
		Me.btnLimpiar4.Name = "btnLimpiar4"
		Me.btnLimpiar4.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar4.TabIndex = 26
		Me.btnLimpiar4.Text = "Limpiar"
		Me.btnLimpiar4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnLimpiar4.Click, AddressOf Me.BtnLimpiar4Click
		AddHandler Me.btnLimpiar4.MouseHover, AddressOf Me.BtnLimpiar4MouseHover
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Location = New System.Drawing.Point(168, 267)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(150, 23)
		Me.btnLimpiar.TabIndex = 28
		Me.btnLimpiar.Text = "Limpiar"
		Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnLimpiar.Click, AddressOf Me.BtnLimpiarClick
		AddHandler Me.btnLimpiar.MouseLeave, AddressOf Me.BtnLimpiarMouseLeave
		AddHandler Me.btnLimpiar.MouseHover, AddressOf Me.BtnLimpiarMouseHover
		'
		'btnGuardarComo
		'
		Me.btnGuardarComo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.btnGuardarComo.ForeColor = System.Drawing.Color.White
		Me.btnGuardarComo.Location = New System.Drawing.Point(324, 267)
		Me.btnGuardarComo.Name = "btnGuardarComo"
		Me.btnGuardarComo.Size = New System.Drawing.Size(150, 23)
		Me.btnGuardarComo.TabIndex = 29
		Me.btnGuardarComo.Text = "Guardar como..."
		Me.btnGuardarComo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.btnGuardarComo.Click, AddressOf Me.BtnGuardarComoClick
		AddHandler Me.btnGuardarComo.MouseLeave, AddressOf Me.BtnGuardarComoMouseLeave
		AddHandler Me.btnGuardarComo.MouseHover, AddressOf Me.BtnGuardarComoMouseHover
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(641, 517)
		Me.Controls.Add(Me.btnGuardarComo)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnCargar4)
		Me.Controls.Add(Me.btnLimpiar4)
		Me.Controls.Add(Me.btnCargar3)
		Me.Controls.Add(Me.btnLimpiar3)
		Me.Controls.Add(Me.btnCargar2)
		Me.Controls.Add(Me.btnLimpiar2)
		Me.Controls.Add(Me.btnCargar1)
		Me.Controls.Add(Me.btnLimpiar1)
		Me.Controls.Add(Me.lblSiguiente)
		Me.Controls.Add(Me.lblAnterior)
		Me.Controls.Add(Me.pcb4)
		Me.Controls.Add(Me.pcb3)
		Me.Controls.Add(Me.pcb2)
		Me.Controls.Add(Me.pcb1)
		Me.Controls.Add(Me.pcbPrincipal)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Albúm"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.pcbPrincipal,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb4,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private btnGuardarComo As System.Windows.Forms.Label
	Private btnLimpiar As System.Windows.Forms.Label
	Private btnLimpiar4 As System.Windows.Forms.Label
	Private btnCargar4 As System.Windows.Forms.Label
	Private btnLimpiar3 As System.Windows.Forms.Label
	Private btnCargar3 As System.Windows.Forms.Label
	Private btnLimpiar2 As System.Windows.Forms.Label
	Private btnCargar2 As System.Windows.Forms.Label
	Private btnCargar1 As System.Windows.Forms.Label
	Private btnLimpiar1 As System.Windows.Forms.Label
	Private lblSiguiente As System.Windows.Forms.Label
	Private lblAnterior As System.Windows.Forms.Label
	Private svfGuardarComo As System.Windows.Forms.SaveFileDialog
	Private opfCargar As System.Windows.Forms.OpenFileDialog
	Private pcb4 As System.Windows.Forms.PictureBox
	Private pcb3 As System.Windows.Forms.PictureBox
	Private pcb2 As System.Windows.Forms.PictureBox
	Private pcb1 As System.Windows.Forms.PictureBox
	Private pcbPrincipal As System.Windows.Forms.PictureBox
End Class
