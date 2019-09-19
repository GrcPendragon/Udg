'
' Created by SharpDevelop.
' User: E19
' Date: 06/09/2019
' Time: 07:31 a. m.
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
		Me.txtEditor = New System.Windows.Forms.TextBox()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.mnArchivo = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnNuevo = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnVentanaNueva = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnAbrir = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnGuardar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnGuardarComo = New System.Windows.Forms.ToolStripMenuItem()
		Me.configurarPáginaToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
		Me.mnConfigurarPagina = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnImprimir = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnSalir = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnEdicion = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnDeshacer = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnCortar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnCopiar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnPegar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnEliminar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnBusquedaBing = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnBuscar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnBuscarSiguiente = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnBuscarAnterior = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnReemplazar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnIrA = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnSeleccionarTodo = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnHoraFecha = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnFormato = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnAjusteLinea = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnFuente = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnVer = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnZoom = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnAcercar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnAlejar = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnZoomPredeterminado = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnBarraEstado = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnAyuda = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnVerAyuda = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnEnviarComentarios = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.mnAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.toolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.opfAbrir = New System.Windows.Forms.OpenFileDialog()
		Me.svdGuardarComo = New System.Windows.Forms.SaveFileDialog()
		Me.menuStrip1.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'txtEditor
		'
		Me.txtEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtEditor.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtEditor.Location = New System.Drawing.Point(12, 27)
		Me.txtEditor.Multiline = true
		Me.txtEditor.Name = "txtEditor"
		Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtEditor.Size = New System.Drawing.Size(638, 326)
		Me.txtEditor.TabIndex = 0
		AddHandler Me.txtEditor.TextChanged, AddressOf Me.TxtEditorTextChanged
		'
		'menuStrip1
		'
		Me.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnArchivo, Me.mnEdicion, Me.mnFormato, Me.mnVer, Me.mnAyuda})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(662, 24)
		Me.menuStrip1.TabIndex = 1
		Me.menuStrip1.Text = "menuStrip1"
		'
		'mnArchivo
		'
		Me.mnArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNuevo, Me.mnVentanaNueva, Me.mnAbrir, Me.mnGuardar, Me.mnGuardarComo, Me.configurarPáginaToolStripMenuItem, Me.mnConfigurarPagina, Me.mnImprimir, Me.toolStripMenuItem1, Me.mnSalir})
		Me.mnArchivo.Name = "mnArchivo"
		Me.mnArchivo.Size = New System.Drawing.Size(60, 20)
		Me.mnArchivo.Text = "Archivo"
		'
		'mnNuevo
		'
		Me.mnNuevo.Name = "mnNuevo"
		Me.mnNuevo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
		Me.mnNuevo.Size = New System.Drawing.Size(231, 22)
		Me.mnNuevo.Text = "Nuevo"
		AddHandler Me.mnNuevo.Click, AddressOf Me.MnNuevoClick
		'
		'mnVentanaNueva
		'
		Me.mnVentanaNueva.Name = "mnVentanaNueva"
		Me.mnVentanaNueva.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
						Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
		Me.mnVentanaNueva.Size = New System.Drawing.Size(231, 22)
		Me.mnVentanaNueva.Text = "Ventana nueva"
		'
		'mnAbrir
		'
		Me.mnAbrir.Name = "mnAbrir"
		Me.mnAbrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A),System.Windows.Forms.Keys)
		Me.mnAbrir.Size = New System.Drawing.Size(231, 22)
		Me.mnAbrir.Text = "Abrir..."
		AddHandler Me.mnAbrir.Click, AddressOf Me.MnAbrirClick
		'
		'mnGuardar
		'
		Me.mnGuardar.Name = "mnGuardar"
		Me.mnGuardar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G),System.Windows.Forms.Keys)
		Me.mnGuardar.Size = New System.Drawing.Size(231, 22)
		Me.mnGuardar.Text = "Guardar"
		AddHandler Me.mnGuardar.Click, AddressOf Me.MnGuardarClick
		'
		'mnGuardarComo
		'
		Me.mnGuardarComo.Name = "mnGuardarComo"
		Me.mnGuardarComo.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift)  _
						Or System.Windows.Forms.Keys.S),System.Windows.Forms.Keys)
		Me.mnGuardarComo.Size = New System.Drawing.Size(231, 22)
		Me.mnGuardarComo.Text = "Guardar como..."
		AddHandler Me.mnGuardarComo.Click, AddressOf Me.MnGuardarComoClick
		'
		'configurarPáginaToolStripMenuItem
		'
		Me.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem"
		Me.configurarPáginaToolStripMenuItem.Size = New System.Drawing.Size(228, 6)
		'
		'mnConfigurarPagina
		'
		Me.mnConfigurarPagina.Name = "mnConfigurarPagina"
		Me.mnConfigurarPagina.Size = New System.Drawing.Size(231, 22)
		Me.mnConfigurarPagina.Text = "Configurar página..."
		'
		'mnImprimir
		'
		Me.mnImprimir.Name = "mnImprimir"
		Me.mnImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P),System.Windows.Forms.Keys)
		Me.mnImprimir.Size = New System.Drawing.Size(231, 22)
		Me.mnImprimir.Text = "Imprimir"
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(228, 6)
		'
		'mnSalir
		'
		Me.mnSalir.Name = "mnSalir"
		Me.mnSalir.Size = New System.Drawing.Size(231, 22)
		Me.mnSalir.Text = "Salir"
		AddHandler Me.mnSalir.Click, AddressOf Me.MnSalirClick
		'
		'mnEdicion
		'
		Me.mnEdicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDeshacer, Me.toolStripSeparator1, Me.mnCortar, Me.mnCopiar, Me.mnPegar, Me.mnEliminar, Me.mnBusquedaBing, Me.mnBuscar, Me.mnBuscarSiguiente, Me.mnBuscarAnterior, Me.mnReemplazar, Me.mnIrA, Me.toolStripSeparator2, Me.mnSeleccionarTodo, Me.mnHoraFecha})
		Me.mnEdicion.Name = "mnEdicion"
		Me.mnEdicion.Size = New System.Drawing.Size(58, 20)
		Me.mnEdicion.Text = "Edición"
		'
		'mnDeshacer
		'
		Me.mnDeshacer.Name = "mnDeshacer"
		Me.mnDeshacer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z),System.Windows.Forms.Keys)
		Me.mnDeshacer.Size = New System.Drawing.Size(225, 22)
		Me.mnDeshacer.Text = "Deshacer"
		'
		'toolStripSeparator1
		'
		Me.toolStripSeparator1.Name = "toolStripSeparator1"
		Me.toolStripSeparator1.Size = New System.Drawing.Size(222, 6)
		'
		'mnCortar
		'
		Me.mnCortar.Name = "mnCortar"
		Me.mnCortar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X),System.Windows.Forms.Keys)
		Me.mnCortar.Size = New System.Drawing.Size(225, 22)
		Me.mnCortar.Text = "Cortar"
		'
		'mnCopiar
		'
		Me.mnCopiar.Name = "mnCopiar"
		Me.mnCopiar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C),System.Windows.Forms.Keys)
		Me.mnCopiar.Size = New System.Drawing.Size(225, 22)
		Me.mnCopiar.Text = "Copiar"
		'
		'mnPegar
		'
		Me.mnPegar.Name = "mnPegar"
		Me.mnPegar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V),System.Windows.Forms.Keys)
		Me.mnPegar.Size = New System.Drawing.Size(225, 22)
		Me.mnPegar.Text = "Pegar"
		'
		'mnEliminar
		'
		Me.mnEliminar.Name = "mnEliminar"
		Me.mnEliminar.ShortcutKeys = System.Windows.Forms.Keys.Delete
		Me.mnEliminar.Size = New System.Drawing.Size(225, 22)
		Me.mnEliminar.Text = "Eliminar"
		'
		'mnBusquedaBing
		'
		Me.mnBusquedaBing.Name = "mnBusquedaBing"
		Me.mnBusquedaBing.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F),System.Windows.Forms.Keys)
		Me.mnBusquedaBing.Size = New System.Drawing.Size(225, 22)
		Me.mnBusquedaBing.Text = "Búsqueda con Bing..."
		'
		'mnBuscar
		'
		Me.mnBuscar.Name = "mnBuscar"
		Me.mnBuscar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B),System.Windows.Forms.Keys)
		Me.mnBuscar.Size = New System.Drawing.Size(225, 22)
		Me.mnBuscar.Text = "Buscar..."
		'
		'mnBuscarSiguiente
		'
		Me.mnBuscarSiguiente.Name = "mnBuscarSiguiente"
		Me.mnBuscarSiguiente.ShortcutKeys = System.Windows.Forms.Keys.F3
		Me.mnBuscarSiguiente.Size = New System.Drawing.Size(225, 22)
		Me.mnBuscarSiguiente.Text = "Buscar siguiente"
		'
		'mnBuscarAnterior
		'
		Me.mnBuscarAnterior.Name = "mnBuscarAnterior"
		Me.mnBuscarAnterior.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F3),System.Windows.Forms.Keys)
		Me.mnBuscarAnterior.Size = New System.Drawing.Size(225, 22)
		Me.mnBuscarAnterior.Text = "Buscar anterior"
		'
		'mnReemplazar
		'
		Me.mnReemplazar.Name = "mnReemplazar"
		Me.mnReemplazar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R),System.Windows.Forms.Keys)
		Me.mnReemplazar.Size = New System.Drawing.Size(225, 22)
		Me.mnReemplazar.Text = "Reemplazar..."
		'
		'mnIrA
		'
		Me.mnIrA.Name = "mnIrA"
		Me.mnIrA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T),System.Windows.Forms.Keys)
		Me.mnIrA.Size = New System.Drawing.Size(225, 22)
		Me.mnIrA.Text = "Ir a..."
		'
		'toolStripSeparator2
		'
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(222, 6)
		'
		'mnSeleccionarTodo
		'
		Me.mnSeleccionarTodo.Name = "mnSeleccionarTodo"
		Me.mnSeleccionarTodo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E),System.Windows.Forms.Keys)
		Me.mnSeleccionarTodo.Size = New System.Drawing.Size(225, 22)
		Me.mnSeleccionarTodo.Text = "Seleccionar todo"
		'
		'mnHoraFecha
		'
		Me.mnHoraFecha.Name = "mnHoraFecha"
		Me.mnHoraFecha.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.mnHoraFecha.Size = New System.Drawing.Size(225, 22)
		Me.mnHoraFecha.Text = "Hora y fehca"
		'
		'mnFormato
		'
		Me.mnFormato.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAjusteLinea, Me.mnFuente})
		Me.mnFormato.Name = "mnFormato"
		Me.mnFormato.Size = New System.Drawing.Size(64, 20)
		Me.mnFormato.Text = "Formato"
		'
		'mnAjusteLinea
		'
		Me.mnAjusteLinea.Name = "mnAjusteLinea"
		Me.mnAjusteLinea.Size = New System.Drawing.Size(151, 22)
		Me.mnAjusteLinea.Text = "Ajuste de línea"
		'
		'mnFuente
		'
		Me.mnFuente.Name = "mnFuente"
		Me.mnFuente.Size = New System.Drawing.Size(151, 22)
		Me.mnFuente.Text = "Fuente..."
		'
		'mnVer
		'
		Me.mnVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnZoom, Me.mnBarraEstado})
		Me.mnVer.Name = "mnVer"
		Me.mnVer.Size = New System.Drawing.Size(35, 20)
		Me.mnVer.Text = "Ver"
		'
		'mnZoom
		'
		Me.mnZoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAcercar, Me.mnAlejar, Me.mnZoomPredeterminado})
		Me.mnZoom.Name = "mnZoom"
		Me.mnZoom.Size = New System.Drawing.Size(155, 22)
		Me.mnZoom.Text = "Zoom"
		'
		'mnAcercar
		'
		Me.mnAcercar.Name = "mnAcercar"
		Me.mnAcercar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus),System.Windows.Forms.Keys)
		Me.mnAcercar.Size = New System.Drawing.Size(295, 22)
		Me.mnAcercar.Text = "Acercar"
		'
		'mnAlejar
		'
		Me.mnAlejar.Name = "mnAlejar"
		Me.mnAlejar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus),System.Windows.Forms.Keys)
		Me.mnAlejar.Size = New System.Drawing.Size(295, 22)
		Me.mnAlejar.Text = "Alejar"
		'
		'mnZoomPredeterminado
		'
		Me.mnZoomPredeterminado.Name = "mnZoomPredeterminado"
		Me.mnZoomPredeterminado.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0),System.Windows.Forms.Keys)
		Me.mnZoomPredeterminado.Size = New System.Drawing.Size(295, 22)
		Me.mnZoomPredeterminado.Text = "Restablecer zoom predeterminado"
		'
		'mnBarraEstado
		'
		Me.mnBarraEstado.Checked = true
		Me.mnBarraEstado.CheckState = System.Windows.Forms.CheckState.Checked
		Me.mnBarraEstado.Name = "mnBarraEstado"
		Me.mnBarraEstado.Size = New System.Drawing.Size(155, 22)
		Me.mnBarraEstado.Text = "Barra de estado"
		'
		'mnAyuda
		'
		Me.mnAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnVerAyuda, Me.mnEnviarComentarios, Me.toolStripSeparator3, Me.mnAcercaDe})
		Me.mnAyuda.Name = "mnAyuda"
		Me.mnAyuda.Size = New System.Drawing.Size(53, 20)
		Me.mnAyuda.Text = "Ayuda"
		'
		'mnVerAyuda
		'
		Me.mnVerAyuda.Name = "mnVerAyuda"
		Me.mnVerAyuda.Size = New System.Drawing.Size(203, 22)
		Me.mnVerAyuda.Text = "Ver la ayuda"
		'
		'mnEnviarComentarios
		'
		Me.mnEnviarComentarios.Name = "mnEnviarComentarios"
		Me.mnEnviarComentarios.Size = New System.Drawing.Size(203, 22)
		Me.mnEnviarComentarios.Text = "Enviar comentarios"
		'
		'toolStripSeparator3
		'
		Me.toolStripSeparator3.Name = "toolStripSeparator3"
		Me.toolStripSeparator3.Size = New System.Drawing.Size(200, 6)
		'
		'mnAcercaDe
		'
		Me.mnAcercaDe.Name = "mnAcercaDe"
		Me.mnAcercaDe.Size = New System.Drawing.Size(203, 22)
		Me.mnAcercaDe.Text = "Acerca del Bloc de notas"
		'
		'statusStrip1
		'
		Me.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
		Me.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2, Me.toolStripStatusLabel3, Me.toolStripStatusLabel4})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 356)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(662, 24)
		Me.statusStrip1.TabIndex = 2
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(75, 19)
		Me.toolStripStatusLabel1.Text = "Line 1, Col 1"
		'
		'toolStripStatusLabel2
		'
		Me.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
		Me.toolStripStatusLabel2.Size = New System.Drawing.Size(39, 19)
		Me.toolStripStatusLabel2.Text = "100%"
		'
		'toolStripStatusLabel3
		'
		Me.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel3.Name = "toolStripStatusLabel3"
		Me.toolStripStatusLabel3.Size = New System.Drawing.Size(95, 19)
		Me.toolStripStatusLabel3.Text = "Windows(CRLF)"
		'
		'toolStripStatusLabel4
		'
		Me.toolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
		Me.toolStripStatusLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Bump
		Me.toolStripStatusLabel4.Name = "toolStripStatusLabel4"
		Me.toolStripStatusLabel4.Size = New System.Drawing.Size(42, 19)
		Me.toolStripStatusLabel4.Text = "UTF-8"
		'
		'opfAbrir
		'
		Me.opfAbrir.DefaultExt = "txt"
		Me.opfAbrir.Filter = "Archivos txt|*.txt|Archivos csv|*.csv|Todos los archivos|*.*"
		Me.opfAbrir.Title = "Abrir archivo"
		'
		'svdGuardarComo
		'
		Me.svdGuardarComo.DefaultExt = "txt"
		Me.svdGuardarComo.Filter = "Archivo de texto|*.txt|Archivos csv|*.csv|Todos los archivos|*.*"
		Me.svdGuardarComo.Title = "Guardar como..."
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(662, 380)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.txtEditor)
		Me.Controls.Add(Me.menuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MainMenuStrip = Me.menuStrip1
		Me.MinimumSize = New System.Drawing.Size(400, 300)
		Me.Name = "MainForm"
		Me.Text = "Sin nombre.txt"
		AddHandler FormClosing, AddressOf Me.MainFormFormClosing
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private svdGuardarComo As System.Windows.Forms.SaveFileDialog
	Private opfAbrir As System.Windows.Forms.OpenFileDialog
	Private mnAcercaDe As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
	Private mnEnviarComentarios As System.Windows.Forms.ToolStripMenuItem
	Private mnVerAyuda As System.Windows.Forms.ToolStripMenuItem
	Private mnAyuda As System.Windows.Forms.ToolStripMenuItem
	Private mnAcercar As System.Windows.Forms.ToolStripMenuItem
	Private mnBarraEstado As System.Windows.Forms.ToolStripMenuItem
	Private mnZoomPredeterminado As System.Windows.Forms.ToolStripMenuItem
	Private mnAlejar As System.Windows.Forms.ToolStripMenuItem
	Private mnZoom As System.Windows.Forms.ToolStripMenuItem
	Private mnVer As System.Windows.Forms.ToolStripMenuItem
	Private mnFuente As System.Windows.Forms.ToolStripMenuItem
	Private mnAjusteLinea As System.Windows.Forms.ToolStripMenuItem
	Private mnFormato As System.Windows.Forms.ToolStripMenuItem
	Private mnHoraFecha As System.Windows.Forms.ToolStripMenuItem
	Private mnSeleccionarTodo As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private mnIrA As System.Windows.Forms.ToolStripMenuItem
	Private mnReemplazar As System.Windows.Forms.ToolStripMenuItem
	Private mnBuscarAnterior As System.Windows.Forms.ToolStripMenuItem
	Private mnBuscarSiguiente As System.Windows.Forms.ToolStripMenuItem
	Private mnBuscar As System.Windows.Forms.ToolStripMenuItem
	Private mnBusquedaBing As System.Windows.Forms.ToolStripMenuItem
	Private mnEliminar As System.Windows.Forms.ToolStripMenuItem
	Private mnPegar As System.Windows.Forms.ToolStripMenuItem
	Private mnCopiar As System.Windows.Forms.ToolStripMenuItem
	Private mnCortar As System.Windows.Forms.ToolStripMenuItem
	Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Private mnDeshacer As System.Windows.Forms.ToolStripMenuItem
	Private mnEdicion As System.Windows.Forms.ToolStripMenuItem
	Private toolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private mnSalir As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
	Private mnImprimir As System.Windows.Forms.ToolStripMenuItem
	Private mnConfigurarPagina As System.Windows.Forms.ToolStripMenuItem
	Private configurarPáginaToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
	Private mnGuardarComo As System.Windows.Forms.ToolStripMenuItem
	Private mnGuardar As System.Windows.Forms.ToolStripMenuItem
	Private mnAbrir As System.Windows.Forms.ToolStripMenuItem
	Private mnVentanaNueva As System.Windows.Forms.ToolStripMenuItem
	Private mnNuevo As System.Windows.Forms.ToolStripMenuItem
	Private mnArchivo As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private txtEditor As System.Windows.Forms.TextBox
End Class
