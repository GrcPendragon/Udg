'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 18/10/2019
' Time: 07:44 a. m.
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
		Me.buttonAbrir = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'buttonAbrir
		'
		Me.buttonAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.buttonAbrir.Location = New System.Drawing.Point(41, 38)
		Me.buttonAbrir.Name = "buttonAbrir"
		Me.buttonAbrir.Size = New System.Drawing.Size(247, 50)
		Me.buttonAbrir.TabIndex = 0
		Me.buttonAbrir.Text = "Abrir ventana secundaria"
		Me.buttonAbrir.UseVisualStyleBackColor = true
		AddHandler Me.buttonAbrir.Click, AddressOf Me.ButtonAbrirClick
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(323, 139)
		Me.Controls.Add(Me.buttonAbrir)
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Encriptar/Desencriptar"
		Me.ResumeLayout(false)
	End Sub
	Private buttonAbrir As System.Windows.Forms.Button
End Class
