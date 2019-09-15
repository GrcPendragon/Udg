'
' Created by SharpDevelop.
' User: E19
' Date: 05/09/2019
' Time: 09:13 a. m.
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
		Me.cmbOpc = New System.Windows.Forms.ComboBox()
		Me.lstbOpc = New System.Windows.Forms.ListBox()
		Me.radioButton1 = New System.Windows.Forms.RadioButton()
		Me.radioButton2 = New System.Windows.Forms.RadioButton()
		Me.radioButton3 = New System.Windows.Forms.RadioButton()
		Me.radioButton4 = New System.Windows.Forms.RadioButton()
		Me.radioButton5 = New System.Windows.Forms.RadioButton()
		Me.button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'cmbOpc
		'
		Me.cmbOpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbOpc.FormattingEnabled = true
		Me.cmbOpc.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "1", "2", "3", "4", "5", "*", "/", "&", "(", ")"})
		Me.cmbOpc.Location = New System.Drawing.Point(12, 49)
		Me.cmbOpc.Name = "cmbOpc"
		Me.cmbOpc.Size = New System.Drawing.Size(121, 21)
		Me.cmbOpc.TabIndex = 0
		AddHandler Me.cmbOpc.SelectedIndexChanged, AddressOf Me.CmbOpcSelectedIndexChanged
		'
		'lstbOpc
		'
		Me.lstbOpc.FormattingEnabled = true
		Me.lstbOpc.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "1", "2", "3", "4", "5", "*", "/", "&", "(", ")"})
		Me.lstbOpc.Location = New System.Drawing.Point(12, 92)
		Me.lstbOpc.Name = "lstbOpc"
		Me.lstbOpc.Size = New System.Drawing.Size(120, 95)
		Me.lstbOpc.TabIndex = 1
		AddHandler Me.lstbOpc.SelectedIndexChanged, AddressOf Me.LstbOpcSelectedIndexChanged
		'
		'radioButton1
		'
		Me.radioButton1.Checked = true
		Me.radioButton1.Location = New System.Drawing.Point(180, 49)
		Me.radioButton1.Name = "radioButton1"
		Me.radioButton1.Size = New System.Drawing.Size(104, 24)
		Me.radioButton1.TabIndex = 2
		Me.radioButton1.TabStop = true
		Me.radioButton1.Text = "radioButton1"
		Me.radioButton1.UseVisualStyleBackColor = true
		'
		'radioButton2
		'
		Me.radioButton2.Location = New System.Drawing.Point(180, 79)
		Me.radioButton2.Name = "radioButton2"
		Me.radioButton2.Size = New System.Drawing.Size(104, 24)
		Me.radioButton2.TabIndex = 3
		Me.radioButton2.Text = "radioButton2"
		Me.radioButton2.UseVisualStyleBackColor = true
		'
		'radioButton3
		'
		Me.radioButton3.Location = New System.Drawing.Point(180, 139)
		Me.radioButton3.Name = "radioButton3"
		Me.radioButton3.Size = New System.Drawing.Size(104, 24)
		Me.radioButton3.TabIndex = 5
		Me.radioButton3.Text = "radioButton3"
		Me.radioButton3.UseVisualStyleBackColor = true
		'
		'radioButton4
		'
		Me.radioButton4.Location = New System.Drawing.Point(180, 109)
		Me.radioButton4.Name = "radioButton4"
		Me.radioButton4.Size = New System.Drawing.Size(104, 24)
		Me.radioButton4.TabIndex = 4
		Me.radioButton4.Text = "radioButton4"
		Me.radioButton4.UseVisualStyleBackColor = true
		'
		'radioButton5
		'
		Me.radioButton5.Location = New System.Drawing.Point(180, 169)
		Me.radioButton5.Name = "radioButton5"
		Me.radioButton5.Size = New System.Drawing.Size(104, 24)
		Me.radioButton5.TabIndex = 6
		Me.radioButton5.Text = "radioButton5"
		Me.radioButton5.UseVisualStyleBackColor = true
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(180, 199)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 7
		Me.button1.Text = "button1"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(373, 261)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.radioButton5)
		Me.Controls.Add(Me.radioButton3)
		Me.Controls.Add(Me.radioButton4)
		Me.Controls.Add(Me.radioButton2)
		Me.Controls.Add(Me.radioButton1)
		Me.Controls.Add(Me.lstbOpc)
		Me.Controls.Add(Me.cmbOpc)
		Me.Name = "MainForm"
		Me.Text = "ejemplo4_SelectCase"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
	End Sub
	Private button1 As System.Windows.Forms.Button
	Private radioButton5 As System.Windows.Forms.RadioButton
	Private radioButton4 As System.Windows.Forms.RadioButton
	Private radioButton3 As System.Windows.Forms.RadioButton
	Private radioButton2 As System.Windows.Forms.RadioButton
	Private radioButton1 As System.Windows.Forms.RadioButton
	Private lstbOpc As System.Windows.Forms.ListBox
	Private cmbOpc As System.Windows.Forms.ComboBox
End Class
