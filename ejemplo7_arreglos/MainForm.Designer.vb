'
' Created by SharpDevelop.
' User: E-PROFESOR
' Date: 26/09/2019
' Time: 10:14 a. m.
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
		Me.textBoxA = New System.Windows.Forms.TextBox()
		Me.textBoxB = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'textBoxA
		'
		Me.textBoxA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBoxA.Location = New System.Drawing.Point(34, 26)
		Me.textBoxA.Multiline = true
		Me.textBoxA.Name = "textBoxA"
		Me.textBoxA.Size = New System.Drawing.Size(143, 118)
		Me.textBoxA.TabIndex = 0
		'
		'textBoxB
		'
		Me.textBoxB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBoxB.Location = New System.Drawing.Point(204, 26)
		Me.textBoxB.Multiline = true
		Me.textBoxB.Name = "textBoxB"
		Me.textBoxB.Size = New System.Drawing.Size(143, 118)
		Me.textBoxB.TabIndex = 1
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(382, 26)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 2
		Me.button1.Text = "button1"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(479, 163)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.textBoxB)
		Me.Controls.Add(Me.textBoxA)
		Me.Name = "MainForm"
		Me.Text = "ejemplo7_arreglos"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button1 As System.Windows.Forms.Button
	Private textBoxB As System.Windows.Forms.TextBox
	Private textBoxA As System.Windows.Forms.TextBox
End Class
