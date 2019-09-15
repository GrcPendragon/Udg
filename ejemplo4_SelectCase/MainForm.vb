'
' Created by SharpDevelop.
' User: E19
' Date: 05/09/2019
' Time: 09:13 a. m.
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
	
	Dim band As Boolean = False
	
	
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		cmbOpc.SelectedIndex = 2
		lstbOpc.SelectedIndex = 3
		lstbOpc.Items.Add("Juan")
		lstbOpc.Items.Insert(2,"Pedro") 
		lstbOpc.Items(2) = "pedrO" 'No diferencia entre mayusculas y minusculas
		band = True
	End Sub
	
	Sub CmbOpcSelectedIndexChanged(sender As Object, e As EventArgs)
		If band Then
			'MsgBox(cmbOpc.Text)
			
			Select Case cmbOpc.Text
					
				Case "a" To "e"
					MsgBox("Has elegido una letra")
				Case "1" To "5"
					MsgBox("Has elegido una nùmero")
				Case Else
					MsgBox("Has elegido un caràcter")			
			End Select
			
		End If
	End Sub
	
	Sub LstbOpcSelectedIndexChanged(sender As Object, e As EventArgs)
		If band Then
			'MsgBox(cmbOpc.Text)
			
			Select Case lstbOpc.Text
				Case "a" To "e"
					MsgBox("Has elegido una letra")
				Case "1" To "5"
					MsgBox("Has elegido una nùmero")
				Case Else
					MsgBox("Has elegido un caràcter")			
			End Select
			
		End If
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		
		Select Case True
			Case radioButton1.Checked
				MsgBox("Seleccionado el Rdb1")
			Case radioButton2.Checked
				MsgBox("Seleccionado el Rdb2")
			Case radioButton3.Checked
				MsgBox("Seleccionado el Rdb3")
			Case radioButton4.Checked
				MsgBox("Seleccionado el Rdb4")
			Case radioButton5.Checked
				MsgBox("Seleccionado el Rdb5")
				
		End Select
		
	End Sub
	
	
End Class
