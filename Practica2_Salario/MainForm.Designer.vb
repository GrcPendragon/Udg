'
' Created by SharpDevelop.
' User: E19
' Date: 30/08/2019
' Time: 07:17 a. m.
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
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.rdbMujer = New System.Windows.Forms.RadioButton()
		Me.rdbHombre = New System.Windows.Forms.RadioButton()
		Me.label1 = New System.Windows.Forms.Label()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.rdbNoHijos = New System.Windows.Forms.RadioButton()
		Me.rdbSiHijos = New System.Windows.Forms.RadioButton()
		Me.txtEdad = New System.Windows.Forms.TextBox()
		Me.btnValidarJubilacion = New System.Windows.Forms.Button()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtServicio = New System.Windows.Forms.TextBox()
		Me.lblAprobacion = New System.Windows.Forms.Label()
		Me.groupBox1.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.SuspendLayout
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.rdbMujer)
		Me.groupBox1.Controls.Add(Me.rdbHombre)
		resources.ApplyResources(Me.groupBox1, "groupBox1")
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.TabStop = false
		'
		'rdbMujer
		'
		resources.ApplyResources(Me.rdbMujer, "rdbMujer")
		Me.rdbMujer.Name = "rdbMujer"
		Me.rdbMujer.TabStop = true
		Me.rdbMujer.UseVisualStyleBackColor = true
		'
		'rdbHombre
		'
		Me.rdbHombre.Checked = true
		resources.ApplyResources(Me.rdbHombre, "rdbHombre")
		Me.rdbHombre.Name = "rdbHombre"
		Me.rdbHombre.TabStop = true
		Me.rdbHombre.UseVisualStyleBackColor = true
		'
		'label1
		'
		resources.ApplyResources(Me.label1, "label1")
		Me.label1.Name = "label1"
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.rdbNoHijos)
		Me.groupBox3.Controls.Add(Me.rdbSiHijos)
		resources.ApplyResources(Me.groupBox3, "groupBox3")
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.TabStop = false
		'
		'rdbNoHijos
		'
		Me.rdbNoHijos.Checked = true
		resources.ApplyResources(Me.rdbNoHijos, "rdbNoHijos")
		Me.rdbNoHijos.Name = "rdbNoHijos"
		Me.rdbNoHijos.TabStop = true
		Me.rdbNoHijos.UseVisualStyleBackColor = true
		'
		'rdbSiHijos
		'
		resources.ApplyResources(Me.rdbSiHijos, "rdbSiHijos")
		Me.rdbSiHijos.Name = "rdbSiHijos"
		Me.rdbSiHijos.UseVisualStyleBackColor = true
		'
		'txtEdad
		'
		resources.ApplyResources(Me.txtEdad, "txtEdad")
		Me.txtEdad.Name = "txtEdad"
		'
		'btnValidarJubilacion
		'
		resources.ApplyResources(Me.btnValidarJubilacion, "btnValidarJubilacion")
		Me.btnValidarJubilacion.Name = "btnValidarJubilacion"
		Me.btnValidarJubilacion.UseVisualStyleBackColor = true
		AddHandler Me.btnValidarJubilacion.Click, AddressOf Me.BtnValidarJubilacionClick
		'
		'btnCerrar
		'
		resources.ApplyResources(Me.btnCerrar, "btnCerrar")
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.UseVisualStyleBackColor = true
		AddHandler Me.btnCerrar.Click, AddressOf Me.BtnCerrarClick
		'
		'label2
		'
		resources.ApplyResources(Me.label2, "label2")
		Me.label2.Name = "label2"
		'
		'txtServicio
		'
		resources.ApplyResources(Me.txtServicio, "txtServicio")
		Me.txtServicio.Name = "txtServicio"
		'
		'lblAprobacion
		'
		resources.ApplyResources(Me.lblAprobacion, "lblAprobacion")
		Me.lblAprobacion.Name = "lblAprobacion"
		'
		'MainForm
		'
		resources.ApplyResources(Me, "$this")
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.CornflowerBlue
		Me.Controls.Add(Me.lblAprobacion)
		Me.Controls.Add(Me.txtServicio)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.btnCerrar)
		Me.Controls.Add(Me.btnValidarJubilacion)
		Me.Controls.Add(Me.txtEdad)
		Me.Controls.Add(Me.groupBox3)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.groupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "MainForm"
		Me.ShowIcon = false
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox3.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lblAprobacion As System.Windows.Forms.Label
	Private txtServicio As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private btnCerrar As System.Windows.Forms.Button
	Private btnValidarJubilacion As System.Windows.Forms.Button
	Private txtEdad As System.Windows.Forms.TextBox
	Private rdbSiHijos As System.Windows.Forms.RadioButton
	Private rdbNoHijos As System.Windows.Forms.RadioButton
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private label1 As System.Windows.Forms.Label
	Private rdbHombre As System.Windows.Forms.RadioButton
	Private rdbMujer As System.Windows.Forms.RadioButton
	Private groupBox1 As System.Windows.Forms.GroupBox
End Class
