<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMDynamics
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMDynamics))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogoEmp = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DGDynamicsE = New System.Windows.Forms.DataGridView()
        Me.DYNOrgNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNRifNumbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNACodMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNMobilePDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNBankCodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNBankNmeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMovilDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMovilDS = New PMovilD.PMovilDS()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NMovil = New System.Windows.Forms.TextBox()
        Me.CAMovil = New System.Windows.Forms.ComboBox()
        Me.BnkNme = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RIFv = New System.Windows.Forms.TextBox()
        Me.RIFn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ISOBnk = New System.Windows.Forms.TextBox()
        Me.RIFt = New System.Windows.Forms.TextBox()
        Me.EmpNme = New System.Windows.Forms.TextBox()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CancelB = New System.Windows.Forms.Button()
        Me.OkBut = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RIFOrder = New System.Windows.Forms.RadioButton()
        Me.NmeOrder = New System.Windows.Forms.RadioButton()
        Me.IDOrder = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IDSearch = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NmeSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DGDynamicsE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(48, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 44)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ESP_Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label2.Location = New System.Drawing.Point(103, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Empresas Grupo Dynamics (Setup)"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PMovilD.My.Resources.Resources.LDynamics
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 44)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.DynamicsApp
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(5, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 25)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LogoEmp
        '
        Me.LogoEmp.BackgroundImage = Global.PMovilD.My.Resources.Resources.DynamicsApp
        Me.LogoEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoEmp.Location = New System.Drawing.Point(527, 4)
        Me.LogoEmp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.LogoEmp.Name = "LogoEmp"
        Me.LogoEmp.Size = New System.Drawing.Size(82, 30)
        Me.LogoEmp.TabIndex = 3
        Me.LogoEmp.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.DGDynamicsE)
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(614, 162)
        Me.Panel2.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.ForeColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(614, 16)
        Me.Panel7.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(9, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 12)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Listado de Empresas:"
        '
        'DGDynamicsE
        '
        Me.DGDynamicsE.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDynamicsE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGDynamicsE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDynamicsE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DYNOrgNameDataGridViewTextBoxColumn, Me.DYNRifNumbDataGridViewTextBoxColumn, Me.DYNACodMPDataGridViewTextBoxColumn, Me.DYNMobilePDataGridViewTextBoxColumn, Me.DYNBankCodDataGridViewTextBoxColumn, Me.DYNBankNmeDataGridViewTextBoxColumn, Me.Column1})
        Me.DGDynamicsE.DataMember = "MRS_DynamicsE"
        Me.DGDynamicsE.DataSource = Me.PMovilDSBindingSource
        Me.DGDynamicsE.Location = New System.Drawing.Point(0, 15)
        Me.DGDynamicsE.Name = "DGDynamicsE"
        Me.DGDynamicsE.Size = New System.Drawing.Size(614, 147)
        Me.DGDynamicsE.TabIndex = 0
        '
        'DYNOrgNameDataGridViewTextBoxColumn
        '
        Me.DYNOrgNameDataGridViewTextBoxColumn.DataPropertyName = "DYN_OrgName"
        Me.DYNOrgNameDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.DYNOrgNameDataGridViewTextBoxColumn.Name = "DYNOrgNameDataGridViewTextBoxColumn"
        '
        'DYNRifNumbDataGridViewTextBoxColumn
        '
        Me.DYNRifNumbDataGridViewTextBoxColumn.DataPropertyName = "DYN_RifNumb"
        Me.DYNRifNumbDataGridViewTextBoxColumn.HeaderText = "# R.I.F."
        Me.DYNRifNumbDataGridViewTextBoxColumn.Name = "DYNRifNumbDataGridViewTextBoxColumn"
        '
        'DYNACodMPDataGridViewTextBoxColumn
        '
        Me.DYNACodMPDataGridViewTextBoxColumn.DataPropertyName = "DYN_ACodMP"
        Me.DYNACodMPDataGridViewTextBoxColumn.HeaderText = "CA Movil"
        Me.DYNACodMPDataGridViewTextBoxColumn.Name = "DYNACodMPDataGridViewTextBoxColumn"
        '
        'DYNMobilePDataGridViewTextBoxColumn
        '
        Me.DYNMobilePDataGridViewTextBoxColumn.DataPropertyName = "DYN_MobileP"
        Me.DYNMobilePDataGridViewTextBoxColumn.HeaderText = "# Movil"
        Me.DYNMobilePDataGridViewTextBoxColumn.Name = "DYNMobilePDataGridViewTextBoxColumn"
        '
        'DYNBankCodDataGridViewTextBoxColumn
        '
        Me.DYNBankCodDataGridViewTextBoxColumn.DataPropertyName = "DYN_BankCod"
        Me.DYNBankCodDataGridViewTextBoxColumn.HeaderText = "ISO Bank Cod"
        Me.DYNBankCodDataGridViewTextBoxColumn.Name = "DYNBankCodDataGridViewTextBoxColumn"
        '
        'DYNBankNmeDataGridViewTextBoxColumn
        '
        Me.DYNBankNmeDataGridViewTextBoxColumn.DataPropertyName = "DYN_BankNme"
        Me.DYNBankNmeDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.DYNBankNmeDataGridViewTextBoxColumn.Name = "DYNBankNmeDataGridViewTextBoxColumn"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'PMovilDSBindingSource
        '
        Me.PMovilDSBindingSource.DataSource = Me.PMovilDS
        Me.PMovilDSBindingSource.Position = 0
        '
        'PMovilDS
        '
        Me.PMovilDS.DataSetName = "PMovilDS"
        Me.PMovilDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.NMovil)
        Me.Panel3.Controls.Add(Me.CAMovil)
        Me.Panel3.Controls.Add(Me.BnkNme)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.RIFv)
        Me.Panel3.Controls.Add(Me.RIFn)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.ISOBnk)
        Me.Panel3.Controls.Add(Me.RIFt)
        Me.Panel3.Controls.Add(Me.EmpNme)
        Me.Panel3.Controls.Add(Me.LogoEmp)
        Me.Panel3.Location = New System.Drawing.Point(0, 215)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(614, 136)
        Me.Panel3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label7.Location = New System.Drawing.Point(154, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 12)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "# Movil:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label8.Location = New System.Drawing.Point(12, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CA Movil:"
        '
        'NMovil
        '
        Me.NMovil.ForeColor = System.Drawing.Color.SlateBlue
        Me.NMovil.Location = New System.Drawing.Point(225, 105)
        Me.NMovil.Name = "NMovil"
        Me.NMovil.Size = New System.Drawing.Size(101, 19)
        Me.NMovil.TabIndex = 16
        '
        'CAMovil
        '
        Me.CAMovil.ForeColor = System.Drawing.Color.SlateBlue
        Me.CAMovil.FormattingEnabled = True
        Me.CAMovil.Items.AddRange(New Object() {"0412", "0414", "0424", "0416", "0426"})
        Me.CAMovil.Location = New System.Drawing.Point(85, 104)
        Me.CAMovil.Name = "CAMovil"
        Me.CAMovil.Size = New System.Drawing.Size(55, 20)
        Me.CAMovil.TabIndex = 15
        '
        'BnkNme
        '
        Me.BnkNme.ForeColor = System.Drawing.Color.SlateBlue
        Me.BnkNme.Location = New System.Drawing.Point(225, 73)
        Me.BnkNme.Name = "BnkNme"
        Me.BnkNme.Size = New System.Drawing.Size(385, 19)
        Me.BnkNme.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label5.Location = New System.Drawing.Point(154, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 12)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Razon Social:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label6.Location = New System.Drawing.Point(12, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "# R.I.F:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label4.Location = New System.Drawing.Point(12, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "BIN Banco:"
        '
        'RIFv
        '
        Me.RIFv.ForeColor = System.Drawing.Color.SlateBlue
        Me.RIFv.Location = New System.Drawing.Point(194, 42)
        Me.RIFv.Name = "RIFv"
        Me.RIFv.ReadOnly = True
        Me.RIFv.Size = New System.Drawing.Size(25, 19)
        Me.RIFv.TabIndex = 10
        Me.RIFv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RIFn
        '
        Me.RIFn.ForeColor = System.Drawing.Color.SlateBlue
        Me.RIFn.Location = New System.Drawing.Point(116, 42)
        Me.RIFn.Name = "RIFn"
        Me.RIFn.ReadOnly = True
        Me.RIFn.Size = New System.Drawing.Size(72, 19)
        Me.RIFn.TabIndex = 9
        Me.RIFn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-267, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "# R.I.F:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empresa:"
        '
        'ISOBnk
        '
        Me.ISOBnk.ForeColor = System.Drawing.Color.SlateBlue
        Me.ISOBnk.Location = New System.Drawing.Point(85, 73)
        Me.ISOBnk.Name = "ISOBnk"
        Me.ISOBnk.Size = New System.Drawing.Size(55, 19)
        Me.ISOBnk.TabIndex = 6
        '
        'RIFt
        '
        Me.RIFt.ForeColor = System.Drawing.Color.SlateBlue
        Me.RIFt.Location = New System.Drawing.Point(85, 42)
        Me.RIFt.Name = "RIFt"
        Me.RIFt.ReadOnly = True
        Me.RIFt.Size = New System.Drawing.Size(25, 19)
        Me.RIFt.TabIndex = 5
        Me.RIFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpNme
        '
        Me.EmpNme.ForeColor = System.Drawing.Color.SlateBlue
        Me.EmpNme.Location = New System.Drawing.Point(85, 11)
        Me.EmpNme.Name = "EmpNme"
        Me.EmpNme.ReadOnly = True
        Me.EmpNme.Size = New System.Drawing.Size(288, 19)
        Me.EmpNme.TabIndex = 4
        '
        'Panel31
        '
        Me.Panel31.Controls.Add(Me.Button1)
        Me.Panel31.Controls.Add(Me.CancelB)
        Me.Panel31.Controls.Add(Me.OkBut)
        Me.Panel31.Location = New System.Drawing.Point(487, 396)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(127, 40)
        Me.Panel31.TabIndex = 55
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(6, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CancelB
        '
        Me.CancelB.BackgroundImage = CType(resources.GetObject("CancelB.BackgroundImage"), System.Drawing.Image)
        Me.CancelB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelB.Location = New System.Drawing.Point(96, 7)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(25, 25)
        Me.CancelB.TabIndex = 9
        Me.CancelB.UseVisualStyleBackColor = True
        '
        'OkBut
        '
        Me.OkBut.BackgroundImage = CType(resources.GetObject("OkBut.BackgroundImage"), System.Drawing.Image)
        Me.OkBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OkBut.Location = New System.Drawing.Point(51, 7)
        Me.OkBut.Name = "OkBut"
        Me.OkBut.Size = New System.Drawing.Size(25, 25)
        Me.OkBut.TabIndex = 1
        Me.OkBut.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.IDSearch)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.NmeSearch)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(0, 357)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(481, 79)
        Me.Panel4.TabIndex = 56
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RIFOrder)
        Me.Panel5.Controls.Add(Me.NmeOrder)
        Me.Panel5.Controls.Add(Me.IDOrder)
        Me.Panel5.Location = New System.Drawing.Point(350, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(131, 79)
        Me.Panel5.TabIndex = 17
        '
        'RIFOrder
        '
        Me.RIFOrder.AutoSize = True
        Me.RIFOrder.ForeColor = System.Drawing.Color.SlateBlue
        Me.RIFOrder.Location = New System.Drawing.Point(17, 60)
        Me.RIFOrder.Name = "RIFOrder"
        Me.RIFOrder.Size = New System.Drawing.Size(49, 16)
        Me.RIFOrder.TabIndex = 2
        Me.RIFOrder.TabStop = True
        Me.RIFOrder.Text = "# R.I.F."
        Me.RIFOrder.UseVisualStyleBackColor = True
        '
        'NmeOrder
        '
        Me.NmeOrder.AutoSize = True
        Me.NmeOrder.ForeColor = System.Drawing.Color.SlateBlue
        Me.NmeOrder.Location = New System.Drawing.Point(17, 41)
        Me.NmeOrder.Name = "NmeOrder"
        Me.NmeOrder.Size = New System.Drawing.Size(98, 16)
        Me.NmeOrder.TabIndex = 1
        Me.NmeOrder.TabStop = True
        Me.NmeOrder.Text = "Nombre Empresa"
        Me.NmeOrder.UseVisualStyleBackColor = True
        '
        'IDOrder
        '
        Me.IDOrder.AutoSize = True
        Me.IDOrder.ForeColor = System.Drawing.Color.SlateBlue
        Me.IDOrder.Location = New System.Drawing.Point(17, 22)
        Me.IDOrder.Name = "IDOrder"
        Me.IDOrder.Size = New System.Drawing.Size(34, 16)
        Me.IDOrder.TabIndex = 0
        Me.IDOrder.TabStop = True
        Me.IDOrder.Text = "Id."
        Me.IDOrder.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label9.Location = New System.Drawing.Point(48, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Numero RIF:"
        '
        'IDSearch
        '
        Me.IDSearch.ForeColor = System.Drawing.Color.SlateBlue
        Me.IDSearch.Location = New System.Drawing.Point(42, 54)
        Me.IDSearch.Name = "IDSearch"
        Me.IDSearch.Size = New System.Drawing.Size(158, 19)
        Me.IDSearch.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label10.Location = New System.Drawing.Point(5, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Buscar:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label11.Location = New System.Drawing.Point(48, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 12)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Empresa Grupo Dynamics:"
        '
        'NmeSearch
        '
        Me.NmeSearch.ForeColor = System.Drawing.Color.SlateBlue
        Me.NmeSearch.Location = New System.Drawing.Point(42, 17)
        Me.NmeSearch.Name = "NmeSearch"
        Me.NmeSearch.Size = New System.Drawing.Size(227, 19)
        Me.NmeSearch.TabIndex = 12
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.PMovilD.My.Resources.Resources.Search
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(11, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(9, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 12)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Ordenar por:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.ForeColor = System.Drawing.Color.Navy
        Me.Panel6.Location = New System.Drawing.Point(350, 357)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(131, 16)
        Me.Panel6.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(564, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 44)
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'DPMDynamics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 438)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel31)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "DPMDynamics"
        Me.Text = "Empresas Grupo Dynamics"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.DGDynamicsE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel31.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogoEmp As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DGDynamicsE As System.Windows.Forms.DataGridView
    Friend WithEvents PMovilDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PMovilDS As PMovilD.PMovilDS
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NMovil As System.Windows.Forms.TextBox
    Friend WithEvents CAMovil As System.Windows.Forms.ComboBox
    Friend WithEvents BnkNme As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RIFv As System.Windows.Forms.TextBox
    Friend WithEvents RIFn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ISOBnk As System.Windows.Forms.TextBox
    Friend WithEvents RIFt As System.Windows.Forms.TextBox
    Friend WithEvents EmpNme As System.Windows.Forms.TextBox
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents OkBut As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RIFOrder As System.Windows.Forms.RadioButton
    Friend WithEvents NmeOrder As System.Windows.Forms.RadioButton
    Friend WithEvents IDOrder As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IDSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NmeSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents DYNOrgNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNRifNumbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNACodMPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNMobilePDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNBankCodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DYNBankNmeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
