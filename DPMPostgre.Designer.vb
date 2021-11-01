<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMPostgre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMPostgre))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TblData = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableTree = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FieldDG = New System.Windows.Forms.DataGridView()
        Me.DBSFieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBSTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBSLenFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMovilDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMovilDS = New PMovilD.PMovilDS()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TblData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FieldDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TblData)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox3.Location = New System.Drawing.Point(2, 249)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(733, 235)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Tabla:"
        '
        'TblData
        '
        Me.TblData.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TblData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblData.Location = New System.Drawing.Point(6, 17)
        Me.TblData.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TblData.Name = "TblData"
        Me.TblData.Size = New System.Drawing.Size(721, 214)
        Me.TblData.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableTree)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(326, 177)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tablas de la Base de Datos: PMovilD (PostgreSQL 14.1.3)"
        '
        'TableTree
        '
        Me.TableTree.BackColor = System.Drawing.SystemColors.Control
        Me.TableTree.Location = New System.Drawing.Point(10, 17)
        Me.TableTree.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TableTree.Name = "TableTree"
        Me.TableTree.Size = New System.Drawing.Size(312, 154)
        Me.TableTree.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(58, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 52)
        Me.Panel1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label5.Location = New System.Drawing.Point(144, 35)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(377, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Base de Datos de la Aplicacion Pago Movil Dynamics / PostgreSQL Ver. 14.1.3 ..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label4.Location = New System.Drawing.Point(10, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion DB: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(373, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Servidor (IP):                        127.0.0.1 (LocalHost)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label2.Location = New System.Drawing.Point(10, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base de Datos:                       PMovilD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 17)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estructua de Base de Datos PMovilD  --  PostgreSQL 14.1.3"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FieldDG)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox2.Location = New System.Drawing.Point(332, 62)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(402, 177)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos de la Tabla:"
        '
        'FieldDG
        '
        Me.FieldDG.AutoGenerateColumns = False
        Me.FieldDG.BackgroundColor = System.Drawing.SystemColors.Control
        Me.FieldDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FieldDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DBSFieldDataGridViewTextBoxColumn, Me.DBSTypeDataGridViewTextBoxColumn, Me.DBSLenFDataGridViewTextBoxColumn})
        Me.FieldDG.DataMember = "MRS_Struct"
        Me.FieldDG.DataSource = Me.PMovilDSBindingSource
        Me.FieldDG.Location = New System.Drawing.Point(4, 17)
        Me.FieldDG.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FieldDG.Name = "FieldDG"
        Me.FieldDG.Size = New System.Drawing.Size(391, 154)
        Me.FieldDG.TabIndex = 1
        '
        'DBSFieldDataGridViewTextBoxColumn
        '
        Me.DBSFieldDataGridViewTextBoxColumn.DataPropertyName = "DBS_Field"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DBSFieldDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DBSFieldDataGridViewTextBoxColumn.HeaderText = "Field Name"
        Me.DBSFieldDataGridViewTextBoxColumn.Name = "DBSFieldDataGridViewTextBoxColumn"
        '
        'DBSTypeDataGridViewTextBoxColumn
        '
        Me.DBSTypeDataGridViewTextBoxColumn.DataPropertyName = "DBS_Type"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DBSTypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DBSTypeDataGridViewTextBoxColumn.HeaderText = "Data Type"
        Me.DBSTypeDataGridViewTextBoxColumn.Name = "DBSTypeDataGridViewTextBoxColumn"
        '
        'DBSLenFDataGridViewTextBoxColumn
        '
        Me.DBSLenFDataGridViewTextBoxColumn.DataPropertyName = "DBS_LenF"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DBSLenFDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DBSLenFDataGridViewTextBoxColumn.HeaderText = "Length"
        Me.DBSLenFDataGridViewTextBoxColumn.Name = "DBSLenFDataGridViewTextBoxColumn"
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.DPMPostgre
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(632, 486)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 37)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.PMovilD.My.Resources.Resources.CloseApp1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(689, 486)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 37)
        Me.Button2.TabIndex = 21
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(682, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'DPMPostgre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 526)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.MediumBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "DPMPostgre"
        Me.Text = "PMovilD: Base de Datos PostgreSQL 14.1.3"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TblData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.FieldDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents TblData As System.Windows.Forms.DataGridView
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents TableTree As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents FieldDG As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DBSFieldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBSTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBSLenFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMovilDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PMovilDS As PMovilD.PMovilDS
End Class
