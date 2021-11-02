<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLeerGenerarCodigosQR
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLeerGenerarCodigosQR))
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tabGenerar = New System.Windows.Forms.TabPage()
        Me.tabResultadoQR = New System.Windows.Forms.TabControl()
        Me.tabQRConfiguracion = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opForzarUTF = New System.Windows.Forms.CheckBox()
        Me.pColorQR = New System.Windows.Forms.Panel()
        Me.pColorFondo = New System.Windows.Forms.Panel()
        Me.btColorQR = New System.Windows.Forms.Button()
        Me.btColorFondo = New System.Windows.Forms.Button()
        Me.txtEscalaPixel = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsNivelCorreccion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgQR = New System.Windows.Forms.PictureBox()
        Me.btImprimirQR = New System.Windows.Forms.Button()
        Me.btGuardarQR = New System.Windows.Forms.Button()
        Me.btGenerarQR = New System.Windows.Forms.Button()
        Me.tabQRTextoResultante = New System.Windows.Forms.TabPage()
        Me.txtTextoQR = New System.Windows.Forms.TextBox()
        Me.tabFormatoQR = New System.Windows.Forms.TabControl()
        Me.tabQRSMS = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSMSMensaje = New System.Windows.Forms.TextBox()
        Me.txtSMSNumeroTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabQRURL = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.tabQRTexto = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTextoLibre = New System.Windows.Forms.TextBox()
        Me.tabQRNumeroTelefono = New System.Windows.Forms.TabPage()
        Me.txtNumeroTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tabQRVcard = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtVcardURL = New System.Windows.Forms.TextBox()
        Me.txtVcardDireccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtVcardMail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtVcardTelefono = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVcardEmpresa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVcardCargo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVcardNombre = New System.Windows.Forms.TextBox()
        Me.tabQRMAIL = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEMailMensaje = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEMailAsunto = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEMailDestinatario = New System.Windows.Forms.TextBox()
        Me.tabQREvento = New System.Windows.Forms.TabPage()
        Me.txtEventoHastaHora = New System.Windows.Forms.DateTimePicker()
        Me.txtEventoDesdeHora = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEventoDescripcion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEventoUbicacion = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEventoHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEventoDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEventoAsunto = New System.Windows.Forms.TextBox()
        Me.tabQRRedWifi = New System.Windows.Forms.TabPage()
        Me.lsRedWifiTipo = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtRedWifiContrasena = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtRedWifiSSID = New System.Windows.Forms.TextBox()
        Me.tabQRGeolocalizacion = New System.Windows.Forms.TabPage()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtGeoConsulta = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtGeoLongitud = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtGeoLatitud = New System.Windows.Forms.TextBox()
        Me.tabLeerQR = New System.Windows.Forms.TabPage()
        Me.txtLeerQRImagen = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.opLeerForzarUTF8 = New System.Windows.Forms.CheckBox()
        Me.txtLeerQRTexto = New System.Windows.Forms.TextBox()
        Me.btDecodificarImagenQR = New System.Windows.Forms.Button()
        Me.imgQRExistente = New System.Windows.Forms.PictureBox()
        Me.btSelImagenQR = New System.Windows.Forms.Button()
        Me.dlImprimir = New System.Windows.Forms.PrintDialog()
        Me.imprimirDoc = New System.Drawing.Printing.PrintDocument()
        Me.linkURL = New System.Windows.Forms.LinkLabel()
        Me.tab.SuspendLayout()
        Me.tabGenerar.SuspendLayout()
        Me.tabResultadoQR.SuspendLayout()
        Me.tabQRConfiguracion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabQRTextoResultante.SuspendLayout()
        Me.tabFormatoQR.SuspendLayout()
        Me.tabQRSMS.SuspendLayout()
        Me.tabQRURL.SuspendLayout()
        Me.tabQRTexto.SuspendLayout()
        Me.tabQRNumeroTelefono.SuspendLayout()
        Me.tabQRVcard.SuspendLayout()
        Me.tabQRMAIL.SuspendLayout()
        Me.tabQREvento.SuspendLayout()
        Me.tabQRRedWifi.SuspendLayout()
        Me.tabQRGeolocalizacion.SuspendLayout()
        Me.tabLeerQR.SuspendLayout()
        CType(Me.imgQRExistente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab.Controls.Add(Me.tabGenerar)
        Me.tab.Controls.Add(Me.tabLeerQR)
        Me.tab.Location = New System.Drawing.Point(24, 12)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(564, 590)
        Me.tab.TabIndex = 6
        '
        'tabGenerar
        '
        Me.tabGenerar.Controls.Add(Me.tabResultadoQR)
        Me.tabGenerar.Controls.Add(Me.tabFormatoQR)
        Me.tabGenerar.Location = New System.Drawing.Point(4, 22)
        Me.tabGenerar.Name = "tabGenerar"
        Me.tabGenerar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGenerar.Size = New System.Drawing.Size(556, 564)
        Me.tabGenerar.TabIndex = 0
        Me.tabGenerar.Text = "Generar QR"
        Me.tabGenerar.UseVisualStyleBackColor = True
        '
        'tabResultadoQR
        '
        Me.tabResultadoQR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabResultadoQR.Controls.Add(Me.tabQRConfiguracion)
        Me.tabResultadoQR.Controls.Add(Me.tabQRTextoResultante)
        Me.tabResultadoQR.Location = New System.Drawing.Point(9, 154)
        Me.tabResultadoQR.Name = "tabResultadoQR"
        Me.tabResultadoQR.SelectedIndex = 0
        Me.tabResultadoQR.Size = New System.Drawing.Size(535, 404)
        Me.tabResultadoQR.TabIndex = 15
        '
        'tabQRConfiguracion
        '
        Me.tabQRConfiguracion.Controls.Add(Me.GroupBox1)
        Me.tabQRConfiguracion.Controls.Add(Me.imgQR)
        Me.tabQRConfiguracion.Controls.Add(Me.btImprimirQR)
        Me.tabQRConfiguracion.Controls.Add(Me.btGuardarQR)
        Me.tabQRConfiguracion.Controls.Add(Me.btGenerarQR)
        Me.tabQRConfiguracion.Location = New System.Drawing.Point(4, 22)
        Me.tabQRConfiguracion.Name = "tabQRConfiguracion"
        Me.tabQRConfiguracion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRConfiguracion.Size = New System.Drawing.Size(527, 378)
        Me.tabQRConfiguracion.TabIndex = 0
        Me.tabQRConfiguracion.Text = "QR"
        Me.tabQRConfiguracion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.opForzarUTF)
        Me.GroupBox1.Controls.Add(Me.pColorQR)
        Me.GroupBox1.Controls.Add(Me.pColorFondo)
        Me.GroupBox1.Controls.Add(Me.btColorQR)
        Me.GroupBox1.Controls.Add(Me.btColorFondo)
        Me.GroupBox1.Controls.Add(Me.txtEscalaPixel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lsNivelCorreccion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 76)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración QR "
        '
        'opForzarUTF
        '
        Me.opForzarUTF.AutoSize = True
        Me.opForzarUTF.Checked = True
        Me.opForzarUTF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opForzarUTF.Location = New System.Drawing.Point(202, 48)
        Me.opForzarUTF.Name = "opForzarUTF"
        Me.opForzarUTF.Size = New System.Drawing.Size(88, 17)
        Me.opForzarUTF.TabIndex = 35
        Me.opForzarUTF.Text = "Forzar UTF-8"
        Me.opForzarUTF.UseVisualStyleBackColor = True
        '
        'pColorQR
        '
        Me.pColorQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pColorQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pColorQR.Location = New System.Drawing.Point(417, 46)
        Me.pColorQR.Name = "pColorQR"
        Me.pColorQR.Size = New System.Drawing.Size(75, 20)
        Me.pColorQR.TabIndex = 34
        '
        'pColorFondo
        '
        Me.pColorFondo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pColorFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pColorFondo.Location = New System.Drawing.Point(417, 19)
        Me.pColorFondo.Name = "pColorFondo"
        Me.pColorFondo.Size = New System.Drawing.Size(75, 20)
        Me.pColorFondo.TabIndex = 33
        '
        'btColorQR
        '
        Me.btColorQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btColorQR.Location = New System.Drawing.Point(336, 43)
        Me.btColorQR.Name = "btColorQR"
        Me.btColorQR.Size = New System.Drawing.Size(75, 23)
        Me.btColorQR.TabIndex = 32
        Me.btColorQR.Text = "Color QR"
        Me.btColorQR.UseVisualStyleBackColor = True
        '
        'btColorFondo
        '
        Me.btColorFondo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btColorFondo.Location = New System.Drawing.Point(336, 17)
        Me.btColorFondo.Name = "btColorFondo"
        Me.btColorFondo.Size = New System.Drawing.Size(75, 23)
        Me.btColorFondo.TabIndex = 31
        Me.btColorFondo.Text = "Color fondo"
        Me.btColorFondo.UseVisualStyleBackColor = True
        '
        'txtEscalaPixel
        '
        Me.txtEscalaPixel.Location = New System.Drawing.Point(107, 46)
        Me.txtEscalaPixel.Mask = "9"
        Me.txtEscalaPixel.Name = "txtEscalaPixel"
        Me.txtEscalaPixel.Size = New System.Drawing.Size(25, 20)
        Me.txtEscalaPixel.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Escala del pixel"
        '
        'lsNivelCorreccion
        '
        Me.lsNivelCorreccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lsNivelCorreccion.FormattingEnabled = True
        Me.lsNivelCorreccion.Items.AddRange(New Object() {"Bajo (7%)", "Medio (15%)", "Alto (25%)", "Muy alto (30%)"})
        Me.lsNivelCorreccion.Location = New System.Drawing.Point(106, 19)
        Me.lsNivelCorreccion.Name = "lsNivelCorreccion"
        Me.lsNivelCorreccion.Size = New System.Drawing.Size(121, 21)
        Me.lsNivelCorreccion.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nivel de corrección"
        '
        'imgQR
        '
        Me.imgQR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgQR.BackColor = System.Drawing.Color.White
        Me.imgQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgQR.Location = New System.Drawing.Point(6, 131)
        Me.imgQR.Name = "imgQR"
        Me.imgQR.Size = New System.Drawing.Size(513, 241)
        Me.imgQR.TabIndex = 15
        Me.imgQR.TabStop = False
        '
        'btImprimirQR
        '
        Me.btImprimirQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btImprimirQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btImprimirQR.Image = CType(resources.GetObject("btImprimirQR.Image"), System.Drawing.Image)
        Me.btImprimirQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btImprimirQR.Location = New System.Drawing.Point(389, 88)
        Me.btImprimirQR.Name = "btImprimirQR"
        Me.btImprimirQR.Size = New System.Drawing.Size(130, 38)
        Me.btImprimirQR.TabIndex = 16
        Me.btImprimirQR.Text = "&Imprimir QR"
        Me.btImprimirQR.UseVisualStyleBackColor = True
        '
        'btGuardarQR
        '
        Me.btGuardarQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btGuardarQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGuardarQR.Image = CType(resources.GetObject("btGuardarQR.Image"), System.Drawing.Image)
        Me.btGuardarQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGuardarQR.Location = New System.Drawing.Point(214, 88)
        Me.btGuardarQR.Name = "btGuardarQR"
        Me.btGuardarQR.Size = New System.Drawing.Size(126, 38)
        Me.btGuardarQR.TabIndex = 17
        Me.btGuardarQR.Text = "G&uardar QR"
        Me.btGuardarQR.UseVisualStyleBackColor = True
        '
        'btGenerarQR
        '
        Me.btGenerarQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btGenerarQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btGenerarQR.Image = CType(resources.GetObject("btGenerarQR.Image"), System.Drawing.Image)
        Me.btGenerarQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btGenerarQR.Location = New System.Drawing.Point(6, 88)
        Me.btGenerarQR.Name = "btGenerarQR"
        Me.btGenerarQR.Size = New System.Drawing.Size(132, 38)
        Me.btGenerarQR.TabIndex = 14
        Me.btGenerarQR.Text = "&Generar QR"
        Me.btGenerarQR.UseVisualStyleBackColor = True
        '
        'tabQRTextoResultante
        '
        Me.tabQRTextoResultante.Controls.Add(Me.txtTextoQR)
        Me.tabQRTextoResultante.Location = New System.Drawing.Point(4, 22)
        Me.tabQRTextoResultante.Name = "tabQRTextoResultante"
        Me.tabQRTextoResultante.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRTextoResultante.Size = New System.Drawing.Size(527, 378)
        Me.tabQRTextoResultante.TabIndex = 1
        Me.tabQRTextoResultante.Text = "Texto QR"
        Me.tabQRTextoResultante.UseVisualStyleBackColor = True
        '
        'txtTextoQR
        '
        Me.txtTextoQR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextoQR.Location = New System.Drawing.Point(6, 6)
        Me.txtTextoQR.Multiline = True
        Me.txtTextoQR.Name = "txtTextoQR"
        Me.txtTextoQR.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTextoQR.Size = New System.Drawing.Size(515, 366)
        Me.txtTextoQR.TabIndex = 2
        Me.txtTextoQR.Text = "http://www.ajpdsoft.com"
        '
        'tabFormatoQR
        '
        Me.tabFormatoQR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabFormatoQR.Controls.Add(Me.tabQRSMS)
        Me.tabFormatoQR.Controls.Add(Me.tabQRURL)
        Me.tabFormatoQR.Controls.Add(Me.tabQRTexto)
        Me.tabFormatoQR.Controls.Add(Me.tabQRNumeroTelefono)
        Me.tabFormatoQR.Controls.Add(Me.tabQRVcard)
        Me.tabFormatoQR.Controls.Add(Me.tabQRMAIL)
        Me.tabFormatoQR.Controls.Add(Me.tabQREvento)
        Me.tabFormatoQR.Controls.Add(Me.tabQRRedWifi)
        Me.tabFormatoQR.Controls.Add(Me.tabQRGeolocalizacion)
        Me.tabFormatoQR.Location = New System.Drawing.Point(9, 6)
        Me.tabFormatoQR.Name = "tabFormatoQR"
        Me.tabFormatoQR.SelectedIndex = 0
        Me.tabFormatoQR.Size = New System.Drawing.Size(536, 142)
        Me.tabFormatoQR.TabIndex = 14
        '
        'tabQRSMS
        '
        Me.tabQRSMS.Controls.Add(Me.Label4)
        Me.tabQRSMS.Controls.Add(Me.txtSMSMensaje)
        Me.tabQRSMS.Controls.Add(Me.txtSMSNumeroTelefono)
        Me.tabQRSMS.Controls.Add(Me.Label3)
        Me.tabQRSMS.Location = New System.Drawing.Point(4, 22)
        Me.tabQRSMS.Name = "tabQRSMS"
        Me.tabQRSMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRSMS.Size = New System.Drawing.Size(528, 116)
        Me.tabQRSMS.TabIndex = 0
        Me.tabQRSMS.Text = "SMS"
        Me.tabQRSMS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mensaje"
        '
        'txtSMSMensaje
        '
        Me.txtSMSMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSMSMensaje.Location = New System.Drawing.Point(78, 37)
        Me.txtSMSMensaje.MaxLength = 160
        Me.txtSMSMensaje.Multiline = True
        Me.txtSMSMensaje.Name = "txtSMSMensaje"
        Me.txtSMSMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSMSMensaje.Size = New System.Drawing.Size(444, 73)
        Me.txtSMSMensaje.TabIndex = 1
        Me.txtSMSMensaje.Text = "Prueba envío SMS con código QR por AjpdSoft"
        '
        'txtSMSNumeroTelefono
        '
        Me.txtSMSNumeroTelefono.Location = New System.Drawing.Point(78, 11)
        Me.txtSMSNumeroTelefono.Mask = "999999999"
        Me.txtSMSNumeroTelefono.Name = "txtSMSNumeroTelefono"
        Me.txtSMSNumeroTelefono.Size = New System.Drawing.Size(94, 20)
        Me.txtSMSNumeroTelefono.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nº teléfono"
        '
        'tabQRURL
        '
        Me.tabQRURL.Controls.Add(Me.Label5)
        Me.tabQRURL.Controls.Add(Me.txtURL)
        Me.tabQRURL.Location = New System.Drawing.Point(4, 22)
        Me.tabQRURL.Name = "tabQRURL"
        Me.tabQRURL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRURL.Size = New System.Drawing.Size(528, 116)
        Me.tabQRURL.TabIndex = 1
        Me.tabQRURL.Text = "URL"
        Me.tabQRURL.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "URL"
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(50, 22)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtURL.Size = New System.Drawing.Size(472, 20)
        Me.txtURL.TabIndex = 13
        Me.txtURL.Text = "http://www.ajpdsoft.com"
        '
        'tabQRTexto
        '
        Me.tabQRTexto.Controls.Add(Me.Label6)
        Me.tabQRTexto.Controls.Add(Me.txtTextoLibre)
        Me.tabQRTexto.Location = New System.Drawing.Point(4, 22)
        Me.tabQRTexto.Name = "tabQRTexto"
        Me.tabQRTexto.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRTexto.Size = New System.Drawing.Size(528, 116)
        Me.tabQRTexto.TabIndex = 2
        Me.tabQRTexto.Text = "Texto"
        Me.tabQRTexto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(320, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Texto libre, cualquier frase o conjunto de caracteres alfanuméricos"
        '
        'txtTextoLibre
        '
        Me.txtTextoLibre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextoLibre.Location = New System.Drawing.Point(15, 22)
        Me.txtTextoLibre.Multiline = True
        Me.txtTextoLibre.Name = "txtTextoLibre"
        Me.txtTextoLibre.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTextoLibre.Size = New System.Drawing.Size(507, 88)
        Me.txtTextoLibre.TabIndex = 13
        Me.txtTextoLibre.Text = "Aplicación desarrollada por Proyecto AjpdSoft para generar y leer códigos QR."
        '
        'tabQRNumeroTelefono
        '
        Me.tabQRNumeroTelefono.Controls.Add(Me.txtNumeroTelefono)
        Me.tabQRNumeroTelefono.Controls.Add(Me.Label7)
        Me.tabQRNumeroTelefono.Location = New System.Drawing.Point(4, 22)
        Me.tabQRNumeroTelefono.Name = "tabQRNumeroTelefono"
        Me.tabQRNumeroTelefono.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRNumeroTelefono.Size = New System.Drawing.Size(528, 116)
        Me.tabQRNumeroTelefono.TabIndex = 3
        Me.tabQRNumeroTelefono.Text = "Teléfono"
        Me.tabQRNumeroTelefono.UseVisualStyleBackColor = True
        '
        'txtNumeroTelefono
        '
        Me.txtNumeroTelefono.Location = New System.Drawing.Point(74, 9)
        Me.txtNumeroTelefono.Mask = "999999999"
        Me.txtNumeroTelefono.Name = "txtNumeroTelefono"
        Me.txtNumeroTelefono.Size = New System.Drawing.Size(94, 20)
        Me.txtNumeroTelefono.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nº teléfono"
        '
        'tabQRVcard
        '
        Me.tabQRVcard.Controls.Add(Me.Label14)
        Me.tabQRVcard.Controls.Add(Me.txtVcardURL)
        Me.tabQRVcard.Controls.Add(Me.txtVcardDireccion)
        Me.tabQRVcard.Controls.Add(Me.Label13)
        Me.tabQRVcard.Controls.Add(Me.Label12)
        Me.tabQRVcard.Controls.Add(Me.txtVcardMail)
        Me.tabQRVcard.Controls.Add(Me.Label11)
        Me.tabQRVcard.Controls.Add(Me.txtVcardTelefono)
        Me.tabQRVcard.Controls.Add(Me.Label10)
        Me.tabQRVcard.Controls.Add(Me.txtVcardEmpresa)
        Me.tabQRVcard.Controls.Add(Me.Label9)
        Me.tabQRVcard.Controls.Add(Me.txtVcardCargo)
        Me.tabQRVcard.Controls.Add(Me.Label8)
        Me.tabQRVcard.Controls.Add(Me.txtVcardNombre)
        Me.tabQRVcard.Location = New System.Drawing.Point(4, 22)
        Me.tabQRVcard.Name = "tabQRVcard"
        Me.tabQRVcard.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRVcard.Size = New System.Drawing.Size(528, 116)
        Me.tabQRVcard.TabIndex = 4
        Me.tabQRVcard.Text = "Contacto"
        Me.tabQRVcard.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(271, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Web"
        '
        'txtVcardURL
        '
        Me.txtVcardURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVcardURL.Location = New System.Drawing.Point(302, 66)
        Me.txtVcardURL.Name = "txtVcardURL"
        Me.txtVcardURL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVcardURL.Size = New System.Drawing.Size(220, 20)
        Me.txtVcardURL.TabIndex = 4
        '
        'txtVcardDireccion
        '
        Me.txtVcardDireccion.Location = New System.Drawing.Point(57, 66)
        Me.txtVcardDireccion.Name = "txtVcardDireccion"
        Me.txtVcardDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVcardDireccion.Size = New System.Drawing.Size(207, 20)
        Me.txtVcardDireccion.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Dirección"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(179, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Mail"
        '
        'txtVcardMail
        '
        Me.txtVcardMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVcardMail.Location = New System.Drawing.Point(207, 92)
        Me.txtVcardMail.Name = "txtVcardMail"
        Me.txtVcardMail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVcardMail.Size = New System.Drawing.Size(315, 20)
        Me.txtVcardMail.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Nº tlfno."
        '
        'txtVcardTelefono
        '
        Me.txtVcardTelefono.Location = New System.Drawing.Point(57, 92)
        Me.txtVcardTelefono.Name = "txtVcardTelefono"
        Me.txtVcardTelefono.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVcardTelefono.Size = New System.Drawing.Size(112, 20)
        Me.txtVcardTelefono.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Empresa"
        '
        'txtVcardEmpresa
        '
        Me.txtVcardEmpresa.Location = New System.Drawing.Point(57, 40)
        Me.txtVcardEmpresa.Name = "txtVcardEmpresa"
        Me.txtVcardEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVcardEmpresa.Size = New System.Drawing.Size(207, 20)
        Me.txtVcardEmpresa.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(266, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Cargo"
        '
        'txtVcardCargo
        '
        Me.txtVcardCargo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVcardCargo.Location = New System.Drawing.Point(302, 40)
        Me.txtVcardCargo.Name = "txtVcardCargo"
        Me.txtVcardCargo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVcardCargo.Size = New System.Drawing.Size(220, 20)
        Me.txtVcardCargo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nombre"
        '
        'txtVcardNombre
        '
        Me.txtVcardNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVcardNombre.Location = New System.Drawing.Point(57, 14)
        Me.txtVcardNombre.Name = "txtVcardNombre"
        Me.txtVcardNombre.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVcardNombre.Size = New System.Drawing.Size(465, 20)
        Me.txtVcardNombre.TabIndex = 0
        '
        'tabQRMAIL
        '
        Me.tabQRMAIL.Controls.Add(Me.Label17)
        Me.tabQRMAIL.Controls.Add(Me.txtEMailMensaje)
        Me.tabQRMAIL.Controls.Add(Me.Label15)
        Me.tabQRMAIL.Controls.Add(Me.txtEMailAsunto)
        Me.tabQRMAIL.Controls.Add(Me.Label16)
        Me.tabQRMAIL.Controls.Add(Me.txtEMailDestinatario)
        Me.tabQRMAIL.Location = New System.Drawing.Point(4, 22)
        Me.tabQRMAIL.Name = "tabQRMAIL"
        Me.tabQRMAIL.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRMAIL.Size = New System.Drawing.Size(528, 116)
        Me.tabQRMAIL.TabIndex = 5
        Me.tabQRMAIL.Text = "Email"
        Me.tabQRMAIL.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Mensaje"
        '
        'txtEMailMensaje
        '
        Me.txtEMailMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEMailMensaje.Location = New System.Drawing.Point(52, 61)
        Me.txtEMailMensaje.Multiline = True
        Me.txtEMailMensaje.Name = "txtEMailMensaje"
        Me.txtEMailMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEMailMensaje.Size = New System.Drawing.Size(470, 52)
        Me.txtEMailMensaje.TabIndex = 25
        Me.txtEMailMensaje.Text = "Prueba envío de Email con código QR por Proyecto AjpdSoft"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Asunto"
        '
        'txtEMailAsunto
        '
        Me.txtEMailAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEMailAsunto.Location = New System.Drawing.Point(52, 35)
        Me.txtEMailAsunto.Name = "txtEMailAsunto"
        Me.txtEMailAsunto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEMailAsunto.Size = New System.Drawing.Size(470, 20)
        Me.txtEMailAsunto.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Email"
        '
        'txtEMailDestinatario
        '
        Me.txtEMailDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEMailDestinatario.Location = New System.Drawing.Point(52, 6)
        Me.txtEMailDestinatario.Name = "txtEMailDestinatario"
        Me.txtEMailDestinatario.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEMailDestinatario.Size = New System.Drawing.Size(470, 20)
        Me.txtEMailDestinatario.TabIndex = 21
        '
        'tabQREvento
        '
        Me.tabQREvento.Controls.Add(Me.txtEventoHastaHora)
        Me.tabQREvento.Controls.Add(Me.txtEventoDesdeHora)
        Me.tabQREvento.Controls.Add(Me.Label22)
        Me.tabQREvento.Controls.Add(Me.txtEventoDescripcion)
        Me.tabQREvento.Controls.Add(Me.Label21)
        Me.tabQREvento.Controls.Add(Me.txtEventoUbicacion)
        Me.tabQREvento.Controls.Add(Me.Label20)
        Me.tabQREvento.Controls.Add(Me.txtEventoHasta)
        Me.tabQREvento.Controls.Add(Me.Label19)
        Me.tabQREvento.Controls.Add(Me.txtEventoDesde)
        Me.tabQREvento.Controls.Add(Me.Label18)
        Me.tabQREvento.Controls.Add(Me.txtEventoAsunto)
        Me.tabQREvento.Location = New System.Drawing.Point(4, 22)
        Me.tabQREvento.Name = "tabQREvento"
        Me.tabQREvento.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQREvento.Size = New System.Drawing.Size(528, 116)
        Me.tabQREvento.TabIndex = 6
        Me.tabQREvento.Text = "Evento"
        Me.tabQREvento.UseVisualStyleBackColor = True
        '
        'txtEventoHastaHora
        '
        Me.txtEventoHastaHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEventoHastaHora.Checked = False
        Me.txtEventoHastaHora.CustomFormat = "HH:mm"
        Me.txtEventoHastaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtEventoHastaHora.Location = New System.Drawing.Point(474, 32)
        Me.txtEventoHastaHora.Name = "txtEventoHastaHora"
        Me.txtEventoHastaHora.Size = New System.Drawing.Size(49, 20)
        Me.txtEventoHastaHora.TabIndex = 5
        '
        'txtEventoDesdeHora
        '
        Me.txtEventoDesdeHora.CustomFormat = "HH:mm"
        Me.txtEventoDesdeHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtEventoDesdeHora.Location = New System.Drawing.Point(173, 32)
        Me.txtEventoDesdeHora.Name = "txtEventoDesdeHora"
        Me.txtEventoDesdeHora.Size = New System.Drawing.Size(49, 20)
        Me.txtEventoDesdeHora.TabIndex = 3
        Me.txtEventoDesdeHora.Value = New Date(2011, 12, 25, 23, 16, 56, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Descripción"
        '
        'txtEventoDescripcion
        '
        Me.txtEventoDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEventoDescripcion.Location = New System.Drawing.Point(69, 58)
        Me.txtEventoDescripcion.Multiline = True
        Me.txtEventoDescripcion.Name = "txtEventoDescripcion"
        Me.txtEventoDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEventoDescripcion.Size = New System.Drawing.Size(454, 52)
        Me.txtEventoDescripcion.TabIndex = 6
        Me.txtEventoDescripcion.Text = "Prueba evento calendario con código QR por Proyecto AjpdSoft"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(377, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Ubicación"
        '
        'txtEventoUbicacion
        '
        Me.txtEventoUbicacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEventoUbicacion.Location = New System.Drawing.Point(435, 6)
        Me.txtEventoUbicacion.Name = "txtEventoUbicacion"
        Me.txtEventoUbicacion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEventoUbicacion.Size = New System.Drawing.Size(88, 20)
        Me.txtEventoUbicacion.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(335, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "Hasta"
        '
        'txtEventoHasta
        '
        Me.txtEventoHasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEventoHasta.CustomFormat = ""
        Me.txtEventoHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtEventoHasta.Location = New System.Drawing.Point(373, 32)
        Me.txtEventoHasta.Name = "txtEventoHasta"
        Me.txtEventoHasta.Size = New System.Drawing.Size(95, 20)
        Me.txtEventoHasta.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(29, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Desde"
        '
        'txtEventoDesde
        '
        Me.txtEventoDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtEventoDesde.Location = New System.Drawing.Point(69, 32)
        Me.txtEventoDesde.Name = "txtEventoDesde"
        Me.txtEventoDesde.Size = New System.Drawing.Size(95, 20)
        Me.txtEventoDesde.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(27, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Asunto"
        '
        'txtEventoAsunto
        '
        Me.txtEventoAsunto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEventoAsunto.Location = New System.Drawing.Point(69, 6)
        Me.txtEventoAsunto.Name = "txtEventoAsunto"
        Me.txtEventoAsunto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEventoAsunto.Size = New System.Drawing.Size(301, 20)
        Me.txtEventoAsunto.TabIndex = 0
        '
        'tabQRRedWifi
        '
        Me.tabQRRedWifi.Controls.Add(Me.lsRedWifiTipo)
        Me.tabQRRedWifi.Controls.Add(Me.Label25)
        Me.tabQRRedWifi.Controls.Add(Me.Label23)
        Me.tabQRRedWifi.Controls.Add(Me.txtRedWifiContrasena)
        Me.tabQRRedWifi.Controls.Add(Me.Label24)
        Me.tabQRRedWifi.Controls.Add(Me.txtRedWifiSSID)
        Me.tabQRRedWifi.Location = New System.Drawing.Point(4, 22)
        Me.tabQRRedWifi.Name = "tabQRRedWifi"
        Me.tabQRRedWifi.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRRedWifi.Size = New System.Drawing.Size(528, 116)
        Me.tabQRRedWifi.TabIndex = 7
        Me.tabQRRedWifi.Text = "Red Wifi"
        Me.tabQRRedWifi.UseVisualStyleBackColor = True
        '
        'lsRedWifiTipo
        '
        Me.lsRedWifiTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lsRedWifiTipo.FormattingEnabled = True
        Me.lsRedWifiTipo.Items.AddRange(New Object() {"WEP", "WPA/WPA2", "Sin encriptación"})
        Me.lsRedWifiTipo.Location = New System.Drawing.Point(71, 58)
        Me.lsRedWifiTipo.Name = "lsRedWifiTipo"
        Me.lsRedWifiTipo.Size = New System.Drawing.Size(155, 21)
        Me.lsRedWifiTipo.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(39, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(28, 13)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "Tipo"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 35)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Contraseña"
        '
        'txtRedWifiContrasena
        '
        Me.txtRedWifiContrasena.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRedWifiContrasena.Location = New System.Drawing.Point(71, 32)
        Me.txtRedWifiContrasena.Name = "txtRedWifiContrasena"
        Me.txtRedWifiContrasena.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRedWifiContrasena.Size = New System.Drawing.Size(445, 20)
        Me.txtRedWifiContrasena.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(35, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 27
        Me.Label24.Text = "SSID"
        '
        'txtRedWifiSSID
        '
        Me.txtRedWifiSSID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRedWifiSSID.Location = New System.Drawing.Point(71, 6)
        Me.txtRedWifiSSID.Name = "txtRedWifiSSID"
        Me.txtRedWifiSSID.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRedWifiSSID.Size = New System.Drawing.Size(445, 20)
        Me.txtRedWifiSSID.TabIndex = 0
        '
        'tabQRGeolocalizacion
        '
        Me.tabQRGeolocalizacion.Controls.Add(Me.Label28)
        Me.tabQRGeolocalizacion.Controls.Add(Me.txtGeoConsulta)
        Me.tabQRGeolocalizacion.Controls.Add(Me.Label26)
        Me.tabQRGeolocalizacion.Controls.Add(Me.txtGeoLongitud)
        Me.tabQRGeolocalizacion.Controls.Add(Me.Label27)
        Me.tabQRGeolocalizacion.Controls.Add(Me.txtGeoLatitud)
        Me.tabQRGeolocalizacion.Location = New System.Drawing.Point(4, 22)
        Me.tabQRGeolocalizacion.Name = "tabQRGeolocalizacion"
        Me.tabQRGeolocalizacion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQRGeolocalizacion.Size = New System.Drawing.Size(528, 116)
        Me.tabQRGeolocalizacion.TabIndex = 8
        Me.tabQRGeolocalizacion.Text = "Geolocalización"
        Me.tabQRGeolocalizacion.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(22, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 13)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Consulta"
        '
        'txtGeoConsulta
        '
        Me.txtGeoConsulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGeoConsulta.Location = New System.Drawing.Point(77, 61)
        Me.txtGeoConsulta.Name = "txtGeoConsulta"
        Me.txtGeoConsulta.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtGeoConsulta.Size = New System.Drawing.Size(445, 20)
        Me.txtGeoConsulta.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(22, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 13)
        Me.Label26.TabIndex = 32
        Me.Label26.Text = "Longitud"
        '
        'txtGeoLongitud
        '
        Me.txtGeoLongitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGeoLongitud.Location = New System.Drawing.Point(77, 32)
        Me.txtGeoLongitud.Name = "txtGeoLongitud"
        Me.txtGeoLongitud.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtGeoLongitud.Size = New System.Drawing.Size(126, 20)
        Me.txtGeoLongitud.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(31, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 13)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Latitud"
        '
        'txtGeoLatitud
        '
        Me.txtGeoLatitud.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGeoLatitud.Location = New System.Drawing.Point(77, 6)
        Me.txtGeoLatitud.Name = "txtGeoLatitud"
        Me.txtGeoLatitud.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtGeoLatitud.Size = New System.Drawing.Size(126, 20)
        Me.txtGeoLatitud.TabIndex = 0
        '
        'tabLeerQR
        '
        Me.tabLeerQR.Controls.Add(Me.txtLeerQRImagen)
        Me.tabLeerQR.Controls.Add(Me.Label29)
        Me.tabLeerQR.Controls.Add(Me.opLeerForzarUTF8)
        Me.tabLeerQR.Controls.Add(Me.txtLeerQRTexto)
        Me.tabLeerQR.Controls.Add(Me.btDecodificarImagenQR)
        Me.tabLeerQR.Controls.Add(Me.imgQRExistente)
        Me.tabLeerQR.Controls.Add(Me.btSelImagenQR)
        Me.tabLeerQR.Location = New System.Drawing.Point(4, 22)
        Me.tabLeerQR.Name = "tabLeerQR"
        Me.tabLeerQR.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLeerQR.Size = New System.Drawing.Size(556, 564)
        Me.tabLeerQR.TabIndex = 1
        Me.tabLeerQR.Text = "Leer QR"
        Me.tabLeerQR.UseVisualStyleBackColor = True
        '
        'txtLeerQRImagen
        '
        Me.txtLeerQRImagen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeerQRImagen.Location = New System.Drawing.Point(12, 15)
        Me.txtLeerQRImagen.Name = "txtLeerQRImagen"
        Me.txtLeerQRImagen.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLeerQRImagen.Size = New System.Drawing.Size(299, 20)
        Me.txtLeerQRImagen.TabIndex = 29
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(9, 328)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(381, 13)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "Texto resultante de la decodificación del código QR de la imagen seleccionada"
        '
        'opLeerForzarUTF8
        '
        Me.opLeerForzarUTF8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.opLeerForzarUTF8.AutoSize = True
        Me.opLeerForzarUTF8.Checked = True
        Me.opLeerForzarUTF8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.opLeerForzarUTF8.Location = New System.Drawing.Point(370, 18)
        Me.opLeerForzarUTF8.Name = "opLeerForzarUTF8"
        Me.opLeerForzarUTF8.Size = New System.Drawing.Size(88, 17)
        Me.opLeerForzarUTF8.TabIndex = 14
        Me.opLeerForzarUTF8.Text = "Forzar UTF-8"
        Me.opLeerForzarUTF8.UseVisualStyleBackColor = True
        '
        'txtLeerQRTexto
        '
        Me.txtLeerQRTexto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLeerQRTexto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtLeerQRTexto.Location = New System.Drawing.Point(12, 344)
        Me.txtLeerQRTexto.Multiline = True
        Me.txtLeerQRTexto.Name = "txtLeerQRTexto"
        Me.txtLeerQRTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLeerQRTexto.Size = New System.Drawing.Size(531, 205)
        Me.txtLeerQRTexto.TabIndex = 5
        '
        'btDecodificarImagenQR
        '
        Me.btDecodificarImagenQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDecodificarImagenQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btDecodificarImagenQR.Image = CType(resources.GetObject("btDecodificarImagenQR.Image"), System.Drawing.Image)
        Me.btDecodificarImagenQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDecodificarImagenQR.Location = New System.Drawing.Point(464, 10)
        Me.btDecodificarImagenQR.Name = "btDecodificarImagenQR"
        Me.btDecodificarImagenQR.Size = New System.Drawing.Size(79, 35)
        Me.btDecodificarImagenQR.TabIndex = 4
        Me.btDecodificarImagenQR.Text = "&Leer QR"
        Me.btDecodificarImagenQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btDecodificarImagenQR.UseVisualStyleBackColor = True
        '
        'imgQRExistente
        '
        Me.imgQRExistente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgQRExistente.BackColor = System.Drawing.Color.White
        Me.imgQRExistente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgQRExistente.Location = New System.Drawing.Point(12, 51)
        Me.imgQRExistente.Name = "imgQRExistente"
        Me.imgQRExistente.Size = New System.Drawing.Size(531, 261)
        Me.imgQRExistente.TabIndex = 3
        Me.imgQRExistente.TabStop = False
        '
        'btSelImagenQR
        '
        Me.btSelImagenQR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSelImagenQR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSelImagenQR.Image = CType(resources.GetObject("btSelImagenQR.Image"), System.Drawing.Image)
        Me.btSelImagenQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSelImagenQR.Location = New System.Drawing.Point(317, 6)
        Me.btSelImagenQR.Name = "btSelImagenQR"
        Me.btSelImagenQR.Size = New System.Drawing.Size(47, 39)
        Me.btSelImagenQR.TabIndex = 0
        Me.btSelImagenQR.Text = "..."
        Me.btSelImagenQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSelImagenQR.UseVisualStyleBackColor = True
        '
        'dlImprimir
        '
        Me.dlImprimir.UseEXDialog = True
        '
        'imprimirDoc
        '
        Me.imprimirDoc.DocumentName = "codigo_qr"
        '
        'linkURL
        '
        Me.linkURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkURL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.linkURL.LinkVisited = True
        Me.linkURL.Location = New System.Drawing.Point(24, 606)
        Me.linkURL.Name = "linkURL"
        Me.linkURL.Size = New System.Drawing.Size(564, 13)
        Me.linkURL.TabIndex = 16
        Me.linkURL.TabStop = True
        Me.linkURL.Text = "Más aplicaciones y nuevas versiones en www.ajpdsoft.com"
        Me.linkURL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'formLeerGenerarCodigosQR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 625)
        Me.Controls.Add(Me.linkURL)
        Me.Controls.Add(Me.tab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formLeerGenerarCodigosQR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AjpdSoft Generador y Lector códigos QR"
        Me.tab.ResumeLayout(False)
        Me.tabGenerar.ResumeLayout(False)
        Me.tabResultadoQR.ResumeLayout(False)
        Me.tabQRConfiguracion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabQRTextoResultante.ResumeLayout(False)
        Me.tabQRTextoResultante.PerformLayout()
        Me.tabFormatoQR.ResumeLayout(False)
        Me.tabQRSMS.ResumeLayout(False)
        Me.tabQRSMS.PerformLayout()
        Me.tabQRURL.ResumeLayout(False)
        Me.tabQRURL.PerformLayout()
        Me.tabQRTexto.ResumeLayout(False)
        Me.tabQRTexto.PerformLayout()
        Me.tabQRNumeroTelefono.ResumeLayout(False)
        Me.tabQRNumeroTelefono.PerformLayout()
        Me.tabQRVcard.ResumeLayout(False)
        Me.tabQRVcard.PerformLayout()
        Me.tabQRMAIL.ResumeLayout(False)
        Me.tabQRMAIL.PerformLayout()
        Me.tabQREvento.ResumeLayout(False)
        Me.tabQREvento.PerformLayout()
        Me.tabQRRedWifi.ResumeLayout(False)
        Me.tabQRRedWifi.PerformLayout()
        Me.tabQRGeolocalizacion.ResumeLayout(False)
        Me.tabQRGeolocalizacion.PerformLayout()
        Me.tabLeerQR.ResumeLayout(False)
        Me.tabLeerQR.PerformLayout()
        CType(Me.imgQRExistente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab As System.Windows.Forms.TabControl
    Friend WithEvents tabGenerar As System.Windows.Forms.TabPage
    Friend WithEvents tabLeerQR As System.Windows.Forms.TabPage
    Friend WithEvents opLeerForzarUTF8 As System.Windows.Forms.CheckBox
    Friend WithEvents txtLeerQRTexto As System.Windows.Forms.TextBox
    Friend WithEvents btDecodificarImagenQR As System.Windows.Forms.Button
    Friend WithEvents imgQRExistente As System.Windows.Forms.PictureBox
    Friend WithEvents btSelImagenQR As System.Windows.Forms.Button
    Friend WithEvents tabFormatoQR As System.Windows.Forms.TabControl
    Friend WithEvents tabQRSMS As System.Windows.Forms.TabPage
    Friend WithEvents tabQRURL As System.Windows.Forms.TabPage
    Friend WithEvents txtSMSMensaje As System.Windows.Forms.TextBox
    Friend WithEvents txtSMSNumeroTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents tabQRTexto As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTextoLibre As System.Windows.Forms.TextBox
    Friend WithEvents tabQRNumeroTelefono As System.Windows.Forms.TabPage
    Friend WithEvents txtNumeroTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tabQRVcard As System.Windows.Forms.TabPage
    Friend WithEvents txtVcardDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVcardMail As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtVcardTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVcardEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtVcardCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVcardNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtVcardURL As System.Windows.Forms.TextBox
    Friend WithEvents tabQRMAIL As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtEMailMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEMailAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEMailDestinatario As System.Windows.Forms.TextBox
    Friend WithEvents tabQREvento As System.Windows.Forms.TabPage
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEventoDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtEventoUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEventoHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEventoDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEventoAsunto As System.Windows.Forms.TextBox
    Friend WithEvents txtEventoHastaHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEventoDesdeHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents tabQRRedWifi As System.Windows.Forms.TabPage
    Friend WithEvents lsRedWifiTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtRedWifiContrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtRedWifiSSID As System.Windows.Forms.TextBox
    Friend WithEvents tabQRGeolocalizacion As System.Windows.Forms.TabPage
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtGeoConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtGeoLongitud As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtGeoLatitud As System.Windows.Forms.TextBox
    Friend WithEvents tabResultadoQR As System.Windows.Forms.TabControl
    Friend WithEvents tabQRConfiguracion As System.Windows.Forms.TabPage
    Friend WithEvents imgQR As System.Windows.Forms.PictureBox
    Friend WithEvents btImprimirQR As System.Windows.Forms.Button
    Friend WithEvents btGuardarQR As System.Windows.Forms.Button
    Friend WithEvents btGenerarQR As System.Windows.Forms.Button
    Friend WithEvents tabQRTextoResultante As System.Windows.Forms.TabPage
    Friend WithEvents txtTextoQR As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opForzarUTF As System.Windows.Forms.CheckBox
    Friend WithEvents pColorQR As System.Windows.Forms.Panel
    Friend WithEvents pColorFondo As System.Windows.Forms.Panel
    Friend WithEvents btColorQR As System.Windows.Forms.Button
    Friend WithEvents btColorFondo As System.Windows.Forms.Button
    Friend WithEvents txtEscalaPixel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsNivelCorreccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dlImprimir As System.Windows.Forms.PrintDialog
    Friend WithEvents imprimirDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtLeerQRImagen As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents linkURL As System.Windows.Forms.LinkLabel

End Class
