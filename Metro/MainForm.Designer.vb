'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 15/11/2019
' Time: 08:20 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MetroFramework.Forms

Partial Class MainForm
	Inherits MetroForm
	
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
		Me.metroButton1 = New MetroFramework.Controls.MetroButton()
		Me.SuspendLayout
		'
		'metroButton1
		'
		Me.metroButton1.Location = New System.Drawing.Point(171, 138)
		Me.metroButton1.Name = "metroButton1"
		Me.metroButton1.Size = New System.Drawing.Size(196, 98)
		Me.metroButton1.TabIndex = 0
		Me.metroButton1.Text = "metroButton1"
		Me.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
		Me.metroButton1.UseSelectable = true
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(427, 300)
		Me.Controls.Add(Me.metroButton1)
		Me.Name = "MainForm"
		Me.Style = MetroFramework.MetroColorStyle.Red
		Me.Text = "UNIVERSIDAD DE GUADALAJARA"
		Me.ResumeLayout(false)
	End Sub
	Private metroButton1 As MetroFramework.Controls.MetroButton
End Class
