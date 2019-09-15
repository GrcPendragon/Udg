'
' Created by SharpDevelop.
' User: tecis
' Date: 16/08/2019
' Time: 07:32 a. m.
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
		Me.btnAdios = New System.Windows.Forms.Button()
		Me.btnHola = New System.Windows.Forms.Button()
		Me.btnMensaje = New System.Windows.Forms.Button()
		Me.txtbTexto = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'btnAdios
		'
		Me.btnAdios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnAdios.Location = New System.Drawing.Point(418, 232)
		Me.btnAdios.Name = "btnAdios"
		Me.btnAdios.Size = New System.Drawing.Size(75, 23)
		Me.btnAdios.TabIndex = 3
		Me.btnAdios.Text = "Adios"
		Me.btnAdios.UseVisualStyleBackColor = true
		AddHandler Me.btnAdios.Click, AddressOf Me.BtnAdiosClick
		'
		'btnHola
		'
		Me.btnHola.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnHola.Location = New System.Drawing.Point(337, 232)
		Me.btnHola.Name = "btnHola"
		Me.btnHola.Size = New System.Drawing.Size(75, 23)
		Me.btnHola.TabIndex = 2
		Me.btnHola.Text = "Hola"
		Me.btnHola.UseVisualStyleBackColor = true
		AddHandler Me.btnHola.Click, AddressOf Me.BtnHolaClick
		'
		'btnMensaje
		'
		Me.btnMensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.btnMensaje.Location = New System.Drawing.Point(12, 232)
		Me.btnMensaje.Name = "btnMensaje"
		Me.btnMensaje.Size = New System.Drawing.Size(75, 23)
		Me.btnMensaje.TabIndex = 1
		Me.btnMensaje.Text = "Mensaje"
		Me.btnMensaje.UseVisualStyleBackColor = true
		AddHandler Me.btnMensaje.Click, AddressOf Me.BtnMensajeClick
		'
		'txtbTexto
		'
		Me.txtbTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.txtbTexto.Location = New System.Drawing.Point(12, 12)
		Me.txtbTexto.Multiline = true
		Me.txtbTexto.Name = "txtbTexto"
		Me.txtbTexto.Size = New System.Drawing.Size(481, 214)
		Me.txtbTexto.TabIndex = 0
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.MediumTurquoise
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ClientSize = New System.Drawing.Size(505, 267)
		Me.Controls.Add(Me.txtbTexto)
		Me.Controls.Add(Me.btnMensaje)
		Me.Controls.Add(Me.btnHola)
		Me.Controls.Add(Me.btnAdios)
		Me.DoubleBuffered = true
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MinimumSize = New System.Drawing.Size(521, 306)
		Me.Name = "MainForm"
		Me.Text = "proyecto 1"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtbTexto As System.Windows.Forms.TextBox
	Private btnMensaje As System.Windows.Forms.Button
	Private btnHola As System.Windows.Forms.Button
	Private btnAdios As System.Windows.Forms.Button
End Class
