<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMBankL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMBankL))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CISOBnk = New System.Windows.Forms.DataGridView()
        Me.BankCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankNmeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMovilDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMovilDS = New PMovilD.PMovilDS()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.CISOBnk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.CISOBnk)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 574)
        Me.Panel1.TabIndex = 0
        '
        'CISOBnk
        '
        Me.CISOBnk.AutoGenerateColumns = False
        Me.CISOBnk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CISOBnk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BankCodeDataGridViewTextBoxColumn, Me.BankNmeDataGridViewTextBoxColumn, Me.BankTypeDataGridViewTextBoxColumn})
        Me.CISOBnk.DataMember = "MRS_ISOBnk"
        Me.CISOBnk.DataSource = Me.PMovilDSBindingSource
        Me.CISOBnk.Location = New System.Drawing.Point(0, 19)
        Me.CISOBnk.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CISOBnk.Name = "CISOBnk"
        Me.CISOBnk.Size = New System.Drawing.Size(498, 555)
        Me.CISOBnk.TabIndex = 0
        '
        'BankCodeDataGridViewTextBoxColumn
        '
        Me.BankCodeDataGridViewTextBoxColumn.DataPropertyName = "BankCode"
        Me.BankCodeDataGridViewTextBoxColumn.HeaderText = "Codigo ISO"
        Me.BankCodeDataGridViewTextBoxColumn.Name = "BankCodeDataGridViewTextBoxColumn"
        Me.BankCodeDataGridViewTextBoxColumn.Width = 80
        '
        'BankNmeDataGridViewTextBoxColumn
        '
        Me.BankNmeDataGridViewTextBoxColumn.DataPropertyName = "BankNme"
        Me.BankNmeDataGridViewTextBoxColumn.HeaderText = "Nombre Banco"
        Me.BankNmeDataGridViewTextBoxColumn.Name = "BankNmeDataGridViewTextBoxColumn"
        Me.BankNmeDataGridViewTextBoxColumn.Width = 250
        '
        'BankTypeDataGridViewTextBoxColumn
        '
        Me.BankTypeDataGridViewTextBoxColumn.DataPropertyName = "BankType"
        Me.BankTypeDataGridViewTextBoxColumn.HeaderText = "Tipo Banco"
        Me.BankTypeDataGridViewTextBoxColumn.Name = "BankTypeDataGridViewTextBoxColumn"
        Me.BankTypeDataGridViewTextBoxColumn.Width = 110
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(4, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 20)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 4)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de Bancos Nacionales (Codigos ISO para Pago Movil):"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.bcv
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'DPMBankL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 581)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "DPMBankL"
        Me.Text = "Listado de Bancos (Codigos ISO):"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CISOBnk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents CISOBnk As System.Windows.Forms.DataGridView
    Friend WithEvents PMovilDSBindingSource As System.Windows.Forms.BindingSource
	Friend WithEvents PMovilDS As PMovilD.PMovilDS
	Friend WithEvents BankCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents BankNmeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
