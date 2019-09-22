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
		Me.pcbAnterior = New System.Windows.Forms.PictureBox()
		Me.pcbSiguiente = New System.Windows.Forms.PictureBox()
		Me.btnCargar1 = New System.Windows.Forms.Button()
		Me.btnCargar2 = New System.Windows.Forms.Button()
		Me.btnLimpiar2 = New System.Windows.Forms.Button()
		Me.btnCargar4 = New System.Windows.Forms.Button()
		Me.btnLimpiar4 = New System.Windows.Forms.Button()
		Me.btnCargar3 = New System.Windows.Forms.Button()
		Me.btnLimpiar3 = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnGuardarComo = New System.Windows.Forms.Button()
		Me.btnLimpiar1 = New System.Windows.Forms.Button()
		CType(Me.pcbPrincipal,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb3,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcb4,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcbAnterior,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pcbSiguiente,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pcbPrincipal
		'
		Me.pcbPrincipal.BackColor = System.Drawing.Color.Transparent
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
		Me.pcb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
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
		Me.pcb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
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
		Me.pcb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
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
		Me.pcb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
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
		'pcbAnterior
		'
		Me.pcbAnterior.BackColor = System.Drawing.Color.Transparent
		Me.pcbAnterior.BackgroundImage = CType(resources.GetObject("pcbAnterior.BackgroundImage"),System.Drawing.Image)
		Me.pcbAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.pcbAnterior.Location = New System.Drawing.Point(12, 21)
		Me.pcbAnterior.Name = "pcbAnterior"
		Me.pcbAnterior.Size = New System.Drawing.Size(100, 233)
		Me.pcbAnterior.TabIndex = 30
		Me.pcbAnterior.TabStop = false
		AddHandler Me.pcbAnterior.Click, AddressOf Me.PcbAnteriorClick
		'
		'pcbSiguiente
		'
		Me.pcbSiguiente.BackColor = System.Drawing.Color.Transparent
		Me.pcbSiguiente.BackgroundImage = CType(resources.GetObject("pcbSiguiente.BackgroundImage"),System.Drawing.Image)
		Me.pcbSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.pcbSiguiente.Location = New System.Drawing.Point(529, 21)
		Me.pcbSiguiente.Name = "pcbSiguiente"
		Me.pcbSiguiente.Size = New System.Drawing.Size(100, 233)
		Me.pcbSiguiente.TabIndex = 31
		Me.pcbSiguiente.TabStop = false
		AddHandler Me.pcbSiguiente.Click, AddressOf Me.PcbSiguienteClick
		'
		'btnCargar1
		'
		Me.btnCargar1.BackColor = System.Drawing.Color.Black
		Me.btnCargar1.ForeColor = System.Drawing.Color.White
		Me.btnCargar1.Location = New System.Drawing.Point(92, 465)
		Me.btnCargar1.Name = "btnCargar1"
		Me.btnCargar1.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar1.TabIndex = 33
		Me.btnCargar1.Text = "Cargar..."
		Me.btnCargar1.UseVisualStyleBackColor = false
		AddHandler Me.btnCargar1.Click, AddressOf Me.BtnCargar1Click
		AddHandler Me.btnCargar1.MouseLeave, AddressOf Me.BtnCargar1MouseLeave
		AddHandler Me.btnCargar1.MouseHover, AddressOf Me.BtnCargar1MouseHover
		'
		'btnCargar2
		'
		Me.btnCargar2.BackColor = System.Drawing.Color.Black
		Me.btnCargar2.ForeColor = System.Drawing.Color.White
		Me.btnCargar2.Location = New System.Drawing.Point(248, 465)
		Me.btnCargar2.Name = "btnCargar2"
		Me.btnCargar2.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar2.TabIndex = 35
		Me.btnCargar2.Text = "Cargar..."
		Me.btnCargar2.UseVisualStyleBackColor = false
		AddHandler Me.btnCargar2.Click, AddressOf Me.BtnCargar2Click
		AddHandler Me.btnCargar2.MouseLeave, AddressOf Me.BtnCargar2MouseLeave
		AddHandler Me.btnCargar2.MouseHover, AddressOf Me.BtnCargar2MouseHover
		'
		'btnLimpiar2
		'
		Me.btnLimpiar2.BackColor = System.Drawing.Color.Black
		Me.btnLimpiar2.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar2.Location = New System.Drawing.Point(168, 465)
		Me.btnLimpiar2.Name = "btnLimpiar2"
		Me.btnLimpiar2.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar2.TabIndex = 34
		Me.btnLimpiar2.Text = "Limpiar"
		Me.btnLimpiar2.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar2.Click, AddressOf Me.BtnLimpiar2Click
		AddHandler Me.btnLimpiar2.MouseLeave, AddressOf Me.BtnLimpiar2MouseLeave
		AddHandler Me.btnLimpiar2.MouseHover, AddressOf Me.BtnLimpiar2MouseHover
		'
		'btnCargar4
		'
		Me.btnCargar4.BackColor = System.Drawing.Color.Black
		Me.btnCargar4.ForeColor = System.Drawing.Color.White
		Me.btnCargar4.Location = New System.Drawing.Point(560, 465)
		Me.btnCargar4.Name = "btnCargar4"
		Me.btnCargar4.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar4.TabIndex = 39
		Me.btnCargar4.Text = "Cargar..."
		Me.btnCargar4.UseVisualStyleBackColor = false
		AddHandler Me.btnCargar4.Click, AddressOf Me.BtnCargar4Click
		AddHandler Me.btnCargar4.MouseLeave, AddressOf Me.BtnCargar4MouseLeave
		AddHandler Me.btnCargar4.MouseHover, AddressOf Me.BtnCargar4MouseHover
		'
		'btnLimpiar4
		'
		Me.btnLimpiar4.BackColor = System.Drawing.Color.Black
		Me.btnLimpiar4.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar4.Location = New System.Drawing.Point(480, 465)
		Me.btnLimpiar4.Name = "btnLimpiar4"
		Me.btnLimpiar4.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar4.TabIndex = 38
		Me.btnLimpiar4.Text = "Limpiar"
		Me.btnLimpiar4.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar4.Click, AddressOf Me.BtnLimpiar4Click
		AddHandler Me.btnLimpiar4.MouseLeave, AddressOf Me.BtnLimpiar4MouseLeave
		AddHandler Me.btnLimpiar4.MouseHover, AddressOf Me.BtnLimpiar4MouseHover
		'
		'btnCargar3
		'
		Me.btnCargar3.BackColor = System.Drawing.Color.Black
		Me.btnCargar3.ForeColor = System.Drawing.Color.White
		Me.btnCargar3.Location = New System.Drawing.Point(404, 465)
		Me.btnCargar3.Name = "btnCargar3"
		Me.btnCargar3.Size = New System.Drawing.Size(70, 23)
		Me.btnCargar3.TabIndex = 37
		Me.btnCargar3.Text = "Cargar..."
		Me.btnCargar3.UseVisualStyleBackColor = false
		AddHandler Me.btnCargar3.Click, AddressOf Me.BtnCargar3Click
		AddHandler Me.btnCargar3.MouseLeave, AddressOf Me.BtnCargar3MouseLeave
		AddHandler Me.btnCargar3.MouseHover, AddressOf Me.BtnCargar3MouseHover
		'
		'btnLimpiar3
		'
		Me.btnLimpiar3.BackColor = System.Drawing.Color.Black
		Me.btnLimpiar3.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar3.Location = New System.Drawing.Point(324, 465)
		Me.btnLimpiar3.Name = "btnLimpiar3"
		Me.btnLimpiar3.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar3.TabIndex = 36
		Me.btnLimpiar3.Text = "Limpiar"
		Me.btnLimpiar3.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar3.Click, AddressOf Me.BtnLimpiar3Click
		AddHandler Me.btnLimpiar3.MouseLeave, AddressOf Me.BtnLimpiar3MouseLeave
		AddHandler Me.btnLimpiar3.MouseHover, AddressOf Me.BtnLimpiar3MouseHover
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.Black
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Location = New System.Drawing.Point(168, 270)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(150, 23)
		Me.btnLimpiar.TabIndex = 40
		Me.btnLimpiar.Text = "Limpiar"
		Me.btnLimpiar.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar.Click, AddressOf Me.BtnLimpiarClick
		AddHandler Me.btnLimpiar.MouseEnter, AddressOf Me.BtnLimpiarMouseHover
		AddHandler Me.btnLimpiar.MouseHover, AddressOf Me.BtnLimpiarMouseLeave
		'
		'btnGuardarComo
		'
		Me.btnGuardarComo.BackColor = System.Drawing.Color.Black
		Me.btnGuardarComo.ForeColor = System.Drawing.Color.White
		Me.btnGuardarComo.Location = New System.Drawing.Point(324, 270)
		Me.btnGuardarComo.Name = "btnGuardarComo"
		Me.btnGuardarComo.Size = New System.Drawing.Size(150, 23)
		Me.btnGuardarComo.TabIndex = 41
		Me.btnGuardarComo.Text = "Guardar como..."
		Me.btnGuardarComo.UseVisualStyleBackColor = false
		AddHandler Me.btnGuardarComo.Click, AddressOf Me.BtnGuardarComoClick
		AddHandler Me.btnGuardarComo.MouseLeave, AddressOf Me.BtnGuardarComoMouseLeave
		AddHandler Me.btnGuardarComo.MouseHover, AddressOf Me.BtnGuardarComoMouseHover
		'
		'btnLimpiar1
		'
		Me.btnLimpiar1.BackColor = System.Drawing.Color.Black
		Me.btnLimpiar1.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar1.Location = New System.Drawing.Point(12, 465)
		Me.btnLimpiar1.Name = "btnLimpiar1"
		Me.btnLimpiar1.Size = New System.Drawing.Size(70, 23)
		Me.btnLimpiar1.TabIndex = 42
		Me.btnLimpiar1.Text = "Limpiar"
		Me.btnLimpiar1.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar1.Click, AddressOf Me.BtnLimpiar1Click
		AddHandler Me.btnLimpiar1.MouseLeave, AddressOf Me.BtnLimpiar1MouseLeave
		AddHandler Me.btnLimpiar1.MouseHover, AddressOf Me.BtnLimpiar1MouseHover
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.ClientSize = New System.Drawing.Size(641, 517)
		Me.Controls.Add(Me.btnLimpiar1)
		Me.Controls.Add(Me.btnGuardarComo)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnCargar4)
		Me.Controls.Add(Me.btnLimpiar4)
		Me.Controls.Add(Me.btnCargar3)
		Me.Controls.Add(Me.btnLimpiar3)
		Me.Controls.Add(Me.btnCargar2)
		Me.Controls.Add(Me.btnLimpiar2)
		Me.Controls.Add(Me.btnCargar1)
		Me.Controls.Add(Me.pcbSiguiente)
		Me.Controls.Add(Me.pcbAnterior)
		Me.Controls.Add(Me.pcb4)
		Me.Controls.Add(Me.pcb3)
		Me.Controls.Add(Me.pcb2)
		Me.Controls.Add(Me.pcb1)
		Me.Controls.Add(Me.pcbPrincipal)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Albúm"
		AddHandler Load, AddressOf Me.MainFormLoad
		CType(Me.pcbPrincipal,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb3,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcb4,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcbAnterior,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pcbSiguiente,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private btnLimpiar1 As System.Windows.Forms.Button
	Private pcbSiguiente As System.Windows.Forms.PictureBox
	Private pcbAnterior As System.Windows.Forms.PictureBox
	Private btnGuardarComo As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private btnLimpiar4 As System.Windows.Forms.Button
	Private btnCargar4 As System.Windows.Forms.Button
	Private btnLimpiar3 As System.Windows.Forms.Button
	Private btnCargar3 As System.Windows.Forms.Button
	Private btnLimpiar2 As System.Windows.Forms.Button
	Private btnCargar2 As System.Windows.Forms.Button
	Private btnCargar1 As System.Windows.Forms.Button
	Private svfGuardarComo As System.Windows.Forms.SaveFileDialog
	Private opfCargar As System.Windows.Forms.OpenFileDialog
	Private pcb4 As System.Windows.Forms.PictureBox
	Private pcb3 As System.Windows.Forms.PictureBox
	Private pcb2 As System.Windows.Forms.PictureBox
	Private pcb1 As System.Windows.Forms.PictureBox
	Private pcbPrincipal As System.Windows.Forms.PictureBox
End Class
