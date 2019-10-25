'
' Created by SharpDevelop.
' User: Fausto Garcia
' Date: 24/10/2019
' Time: 08:28 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.MainForm
		End Sub
	End Class
End Namespace
