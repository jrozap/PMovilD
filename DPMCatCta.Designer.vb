<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMCatCta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGCtasC = New System.Windows.Forms.DataGridView()
        Me.CGCodigoCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGTipoCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGDescCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGCodCtaCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CG_MayorA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CG_GrupoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMovilDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMovilDS = New PMovilD.PMovilDS()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Egr = New System.Windows.Forms.CheckBox()
        Me.Ing = New System.Windows.Forms.CheckBox()
        Me.Cap = New System.Windows.Forms.CheckBox()
        Me.Pas = New System.Windows.Forms.CheckBox()
        Me.Act = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GrupoCta = New System.Windows.Forms.TextBox()
        Me.MayorCta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SC = New System.Windows.Forms.RadioButton()
        Me.MC = New System.Windows.Forms.RadioButton()
        Me.MS = New System.Windows.Forms.RadioButton()
        Me.MG = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CtaExport = New System.Windows.Forms.TextBox()
        Me.DescrCta = New System.Windows.Forms.TextBox()
        Me.CodCtaPM = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BCanc = New System.Windows.Forms.Button()
        Me.BPrt = New System.Windows.Forms.Button()
        Me.BOk = New System.Windows.Forms.Button()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGCtasC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox17
        '
        Me.PictureBox17.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDynamics2
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox17.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(37, 44)
        Me.PictureBox17.TabIndex = 15
        Me.PictureBox17.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(577, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 44)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(43, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 42)
        Me.Panel1.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("ESP_Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Location = New System.Drawing.Point(48, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(265, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cuentas Contables PM"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGCtasC)
        Me.Panel2.Location = New System.Drawing.Point(3, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 169)
        Me.Panel2.TabIndex = 18
        '
        'DGCtasC
        '
        Me.DGCtasC.AutoGenerateColumns = False
        Me.DGCtasC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCtasC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CGCodigoCtaDataGridViewTextBoxColumn, Me.CGTipoCtaDataGridViewTextBoxColumn, Me.CGDescCtaDataGridViewTextBoxColumn, Me.CGCodCtaCDataGridViewTextBoxColumn, Me.CG_MayorA, Me.CG_GrupoC})
        Me.DGCtasC.DataMember = "MRS_CatCta"
        Me.DGCtasC.DataSource = Me.PMovilDSBindingSource
        Me.DGCtasC.Location = New System.Drawing.Point(0, 0)
        Me.DGCtasC.Name = "DGCtasC"
        Me.DGCtasC.Size = New System.Drawing.Size(621, 169)
        Me.DGCtasC.TabIndex = 0
        '
        'CGCodigoCtaDataGridViewTextBoxColumn
        '
        Me.CGCodigoCtaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGCodigoCtaDataGridViewTextBoxColumn.DataPropertyName = "CG_CodigoCta"
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.CGCodigoCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CGCodigoCtaDataGridViewTextBoxColumn.HeaderText = "Codigo Cta."
        Me.CGCodigoCtaDataGridViewTextBoxColumn.Name = "CGCodigoCtaDataGridViewTextBoxColumn"
        Me.CGCodigoCtaDataGridViewTextBoxColumn.Width = 78
        '
        'CGTipoCtaDataGridViewTextBoxColumn
        '
        Me.CGTipoCtaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGTipoCtaDataGridViewTextBoxColumn.DataPropertyName = "CG_TipoCta"
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.CGTipoCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CGTipoCtaDataGridViewTextBoxColumn.HeaderText = "Tipo Cuenta"
        Me.CGTipoCtaDataGridViewTextBoxColumn.Name = "CGTipoCtaDataGridViewTextBoxColumn"
        Me.CGTipoCtaDataGridViewTextBoxColumn.Width = 79
        '
        'CGDescCtaDataGridViewTextBoxColumn
        '
        Me.CGDescCtaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGDescCtaDataGridViewTextBoxColumn.DataPropertyName = "CG_DescCta"
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.CGDescCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CGDescCtaDataGridViewTextBoxColumn.HeaderText = "Descripcion Cuenta"
        Me.CGDescCtaDataGridViewTextBoxColumn.Name = "CGDescCtaDataGridViewTextBoxColumn"
        Me.CGDescCtaDataGridViewTextBoxColumn.Width = 109
        '
        'CGCodCtaCDataGridViewTextBoxColumn
        '
        Me.CGCodCtaCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CGCodCtaCDataGridViewTextBoxColumn.DataPropertyName = "CG_CodCtaC"
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.CGCodCtaCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CGCodCtaCDataGridViewTextBoxColumn.HeaderText = "Codigo Cuenta (SAdm)"
        Me.CGCodCtaCDataGridViewTextBoxColumn.Name = "CGCodCtaCDataGridViewTextBoxColumn"
        Me.CGCodCtaCDataGridViewTextBoxColumn.Width = 125
        '
        'CG_MayorA
        '
        Me.CG_MayorA.DataPropertyName = "CG_MayorA"
        Me.CG_MayorA.HeaderText = "CG_MayorA"
        Me.CG_MayorA.Name = "CG_MayorA"
        Me.CG_MayorA.Visible = False
        '
        'CG_GrupoC
        '
        Me.CG_GrupoC.DataPropertyName = "CG_GrupoC"
        Me.CG_GrupoC.HeaderText = "CG_GrupoC"
        Me.CG_GrupoC.Name = "CG_GrupoC"
        Me.CG_GrupoC.Visible = False
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
        Me.Panel3.Controls.Add(Me.Egr)
        Me.Panel3.Controls.Add(Me.Ing)
        Me.Panel3.Controls.Add(Me.Cap)
        Me.Panel3.Controls.Add(Me.Pas)
        Me.Panel3.Controls.Add(Me.Act)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.GrupoCta)
        Me.Panel3.Controls.Add(Me.MayorCta)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.SC)
        Me.Panel3.Controls.Add(Me.MC)
        Me.Panel3.Controls.Add(Me.MS)
        Me.Panel3.Controls.Add(Me.MG)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.CtaExport)
        Me.Panel3.Controls.Add(Me.DescrCta)
        Me.Panel3.Controls.Add(Me.CodCtaPM)
        Me.Panel3.Location = New System.Drawing.Point(3, 226)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(569, 133)
        Me.Panel3.TabIndex = 19
        '
        'Egr
        '
        Me.Egr.AutoSize = True
        Me.Egr.Location = New System.Drawing.Point(536, 20)
        Me.Egr.Name = "Egr"
        Me.Egr.Size = New System.Drawing.Size(29, 16)
        Me.Egr.TabIndex = 26
        Me.Egr.Text = "E"
        Me.Egr.UseVisualStyleBackColor = True
        '
        'Ing
        '
        Me.Ing.AutoSize = True
        Me.Ing.Location = New System.Drawing.Point(506, 20)
        Me.Ing.Name = "Ing"
        Me.Ing.Size = New System.Drawing.Size(27, 16)
        Me.Ing.TabIndex = 25
        Me.Ing.Text = "I"
        Me.Ing.UseVisualStyleBackColor = True
        '
        'Cap
        '
        Me.Cap.AutoSize = True
        Me.Cap.Location = New System.Drawing.Point(475, 20)
        Me.Cap.Name = "Cap"
        Me.Cap.Size = New System.Drawing.Size(30, 16)
        Me.Cap.TabIndex = 24
        Me.Cap.Text = "C"
        Me.Cap.UseVisualStyleBackColor = True
        '
        'Pas
        '
        Me.Pas.AutoSize = True
        Me.Pas.Location = New System.Drawing.Point(444, 20)
        Me.Pas.Name = "Pas"
        Me.Pas.Size = New System.Drawing.Size(30, 16)
        Me.Pas.TabIndex = 23
        Me.Pas.Text = "P"
        Me.Pas.UseVisualStyleBackColor = True
        '
        'Act
        '
        Me.Act.AutoSize = True
        Me.Act.Location = New System.Drawing.Point(412, 20)
        Me.Act.Name = "Act"
        Me.Act.Size = New System.Drawing.Size(31, 16)
        Me.Act.TabIndex = 22
        Me.Act.Text = "A"
        Me.Act.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(410, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 12)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Grupo Contable:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Mayor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 12)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Grupo:"
        '
        'GrupoCta
        '
        Me.GrupoCta.Location = New System.Drawing.Point(244, 15)
        Me.GrupoCta.Name = "GrupoCta"
        Me.GrupoCta.ReadOnly = True
        Me.GrupoCta.Size = New System.Drawing.Size(31, 21)
        Me.GrupoCta.TabIndex = 13
        '
        'MayorCta
        '
        Me.MayorCta.Location = New System.Drawing.Point(323, 15)
        Me.MayorCta.Name = "MayorCta"
        Me.MayorCta.ReadOnly = True
        Me.MayorCta.Size = New System.Drawing.Size(43, 21)
        Me.MayorCta.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipo Cuenta:"
        '
        'SC
        '
        Me.SC.AutoSize = True
        Me.SC.Location = New System.Drawing.Point(413, 110)
        Me.SC.Name = "SC"
        Me.SC.Size = New System.Drawing.Size(72, 16)
        Me.SC.TabIndex = 10
        Me.SC.TabStop = True
        Me.SC.Text = "Subcuenta"
        Me.SC.UseVisualStyleBackColor = True
        '
        'MC
        '
        Me.MC.AutoSize = True
        Me.MC.Location = New System.Drawing.Point(413, 94)
        Me.MC.Name = "MC"
        Me.MC.Size = New System.Drawing.Size(129, 16)
        Me.MC.TabIndex = 9
        Me.MC.TabStop = True
        Me.MC.Text = "Mayor con Subcuentas"
        Me.MC.UseVisualStyleBackColor = True
        '
        'MS
        '
        Me.MS.AutoSize = True
        Me.MS.Location = New System.Drawing.Point(413, 77)
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(125, 16)
        Me.MS.TabIndex = 8
        Me.MS.TabStop = True
        Me.MS.Text = "Mayor sin Subcuentas"
        Me.MS.UseVisualStyleBackColor = True
        '
        'MG
        '
        Me.MG.AutoSize = True
        Me.MG.Location = New System.Drawing.Point(413, 61)
        Me.MG.Name = "MG"
        Me.MG.Size = New System.Drawing.Size(91, 16)
        Me.MG.TabIndex = 7
        Me.MG.TabStop = True
        Me.MG.Text = "Mayor General"
        Me.MG.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(214, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cuenta para enlazar el Catalogo PM al de cualquier Sistema Admnistrativo"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Codigo Cuenta Exportacion:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion Cuenta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo Cuenta:"
        '
        'CtaExport
        '
        Me.CtaExport.Location = New System.Drawing.Point(93, 103)
        Me.CtaExport.Name = "CtaExport"
        Me.CtaExport.Size = New System.Drawing.Size(115, 21)
        Me.CtaExport.TabIndex = 2
        '
        'DescrCta
        '
        Me.DescrCta.Location = New System.Drawing.Point(93, 42)
        Me.DescrCta.Multiline = True
        Me.DescrCta.Name = "DescrCta"
        Me.DescrCta.Size = New System.Drawing.Size(273, 43)
        Me.DescrCta.TabIndex = 1
        '
        'CodCtaPM
        '
        Me.CodCtaPM.Location = New System.Drawing.Point(93, 15)
        Me.CodCtaPM.Name = "CodCtaPM"
        Me.CodCtaPM.Size = New System.Drawing.Size(100, 21)
        Me.CodCtaPM.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BCanc)
        Me.Panel4.Controls.Add(Me.BPrt)
        Me.Panel4.Controls.Add(Me.BOk)
        Me.Panel4.Location = New System.Drawing.Point(577, 226)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(47, 133)
        Me.Panel4.TabIndex = 20
        '
        'BCanc
        '
        Me.BCanc.BackgroundImage = Global.PMovilD.My.Resources.Resources.CloseApp
        Me.BCanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCanc.Location = New System.Drawing.Point(6, 49)
        Me.BCanc.Name = "BCanc"
        Me.BCanc.Size = New System.Drawing.Size(35, 35)
        Me.BCanc.TabIndex = 24
        Me.BCanc.UseVisualStyleBackColor = True
        '
        'BPrt
        '
        Me.BPrt.BackgroundImage = Global.PMovilD.My.Resources.Resources.HPLaser
        Me.BPrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BPrt.Location = New System.Drawing.Point(6, 90)
        Me.BPrt.Name = "BPrt"
        Me.BPrt.Size = New System.Drawing.Size(35, 35)
        Me.BPrt.TabIndex = 23
        Me.BPrt.UseVisualStyleBackColor = True
        '
        'BOk
        '
        Me.BOk.BackgroundImage = Global.PMovilD.My.Resources.Resources.OkIcon
        Me.BOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BOk.Location = New System.Drawing.Point(6, 8)
        Me.BOk.Name = "BOk"
        Me.BOk.Size = New System.Drawing.Size(35, 35)
        Me.BOk.TabIndex = 22
        Me.BOk.UseVisualStyleBackColor = True
        '
        'DPMCatCta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 362)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox17)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.Green
        Me.Name = "DPMCatCta"
        Me.Text = "Catalogo Cuentas Contables PM"
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGCtasC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DGCtasC As System.Windows.Forms.DataGridView
    Friend WithEvents PMovilDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PMovilDS As PMovilD.PMovilDS
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SC As System.Windows.Forms.RadioButton
    Friend WithEvents MC As System.Windows.Forms.RadioButton
    Friend WithEvents MS As System.Windows.Forms.RadioButton
    Friend WithEvents MG As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CtaExport As System.Windows.Forms.TextBox
    Friend WithEvents DescrCta As System.Windows.Forms.TextBox
    Friend WithEvents CodCtaPM As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GrupoCta As System.Windows.Forms.TextBox
    Friend WithEvents MayorCta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BCanc As System.Windows.Forms.Button
    Friend WithEvents BPrt As System.Windows.Forms.Button
    Friend WithEvents BOk As System.Windows.Forms.Button
    Friend WithEvents CGCodigoCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGTipoCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGDescCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGCodCtaCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CG_MayorA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CG_GrupoC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Egr As System.Windows.Forms.CheckBox
    Friend WithEvents Ing As System.Windows.Forms.CheckBox
    Friend WithEvents Cap As System.Windows.Forms.CheckBox
    Friend WithEvents Pas As System.Windows.Forms.CheckBox
    Friend WithEvents Act As System.Windows.Forms.CheckBox
End Class
