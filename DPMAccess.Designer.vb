<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMAccess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMAccess))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableTree = New System.Windows.Forms.TreeView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FieldDG = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TblData = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PMovilDS = New PMovilD.PMovilDS()
        Me.PMovilDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBSFieldDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBSTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DBSLenFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FieldDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TblData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(54, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 48)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Base de Datos de la Aplicacion Pago Movil Dynamics..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion DB: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(219, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ruta (Path):                           D:\Documentos\PMovilD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Base de Datos:                     PMovilD.accdb"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 18)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estructura de Base de Datos PMovilD  --  Microsoft Access 2010/2019"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableTree)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(326, 177)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tablas de la Base de Datos: PMovilD (MS-Access)"
        '
        'TableTree
        '
        Me.TableTree.BackColor = System.Drawing.SystemColors.Control
        Me.TableTree.Location = New System.Drawing.Point(10, 18)
        Me.TableTree.Name = "TableTree"
        Me.TableTree.Size = New System.Drawing.Size(311, 153)
        Me.TableTree.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FieldDG)
        Me.GroupBox2.Location = New System.Drawing.Point(332, 57)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(402, 177)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Campos de la Tabla:"
        '
        'FieldDG
        '
        Me.FieldDG.AutoGenerateColumns = False
        Me.FieldDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FieldDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DBSFieldDataGridViewTextBoxColumn, Me.DBSTypeDataGridViewTextBoxColumn, Me.DBSLenFDataGridViewTextBoxColumn})
        Me.FieldDG.DataMember = "MRS_Struct"
        Me.FieldDG.DataSource = Me.PMovilDSBindingSource
        Me.FieldDG.Location = New System.Drawing.Point(8, 18)
        Me.FieldDG.Name = "FieldDG"
        Me.FieldDG.Size = New System.Drawing.Size(388, 153)
        Me.FieldDG.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TblData)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 236)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(732, 255)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Tabla:"
        '
        'TblData
        '
        Me.TblData.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TblData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblData.Location = New System.Drawing.Point(7, 23)
        Me.TblData.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TblData.Name = "TblData"
        Me.TblData.Size = New System.Drawing.Size(721, 226)
        Me.TblData.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.DPMAccess
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PMovilD.My.Resources.Resources.OkIcon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(631, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.PMovilD.My.Resources.Resources.CloseApp1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(688, 497)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(684, 3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 48)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PMovilDS
        '
        Me.PMovilDS.DataSetName = "PMovilDS"
        Me.PMovilDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PMovilDSBindingSource
        '
        Me.PMovilDSBindingSource.DataSource = Me.PMovilDS
        Me.PMovilDSBindingSource.Position = 0
        '
        'DBSFieldDataGridViewTextBoxColumn
        '
        Me.DBSFieldDataGridViewTextBoxColumn.DataPropertyName = "DBS_Field"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DBSFieldDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.DBSFieldDataGridViewTextBoxColumn.HeaderText = "DB Field"
        Me.DBSFieldDataGridViewTextBoxColumn.Name = "DBSFieldDataGridViewTextBoxColumn"
        '
        'DBSTypeDataGridViewTextBoxColumn
        '
        Me.DBSTypeDataGridViewTextBoxColumn.DataPropertyName = "DBS_Type"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DBSTypeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DBSTypeDataGridViewTextBoxColumn.HeaderText = "Data Type"
        Me.DBSTypeDataGridViewTextBoxColumn.Name = "DBSTypeDataGridViewTextBoxColumn"
        '
        'DBSLenFDataGridViewTextBoxColumn
        '
        Me.DBSLenFDataGridViewTextBoxColumn.DataPropertyName = "DBS_LenF"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DBSLenFDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DBSLenFDataGridViewTextBoxColumn.HeaderText = "Length"
        Me.DBSLenFDataGridViewTextBoxColumn.Name = "DBSLenFDataGridViewTextBoxColumn"
        '
        'DPMAccess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 541)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "DPMAccess"
        Me.Text = "PMovilD: Base de Datos MS-Access 2010/2019"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.FieldDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TblData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents Panel2 As System.Windows.Forms.Panel
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Friend WithEvents TblData As System.Windows.Forms.DataGridView
	Friend WithEvents TableTree As System.Windows.Forms.TreeView
    Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents FieldDG As System.Windows.Forms.DataGridView
    Friend WithEvents DBSFieldDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBSTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DBSLenFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMovilDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PMovilDS As PMovilD.PMovilDS
End Class
