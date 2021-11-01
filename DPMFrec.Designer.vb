<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMFrec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMFrec))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SMSend = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmpRB = New System.Windows.Forms.RadioButton()
        Me.ProvRB = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AllRB = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NmeSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BFrecDG = New System.Windows.Forms.DataGridView()
        Me.FREIDCustDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FRECustNmeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_Movil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FREAliasCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FREBankISODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMovilDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMovilDS = New PMovilD.PMovilDS()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BFrecDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.SMSend)
        Me.Panel1.Location = New System.Drawing.Point(444, 489)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(119, 87)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.PMovilD.My.Resources.Resources.CloseApp
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(70, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SMSend
        '
        Me.SMSend.BackgroundImage = Global.PMovilD.My.Resources.Resources.OkIcon
        Me.SMSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SMSend.Location = New System.Drawing.Point(17, 23)
        Me.SMSend.Name = "SMSend"
        Me.SMSend.Size = New System.Drawing.Size(35, 35)
        Me.SMSend.TabIndex = 11
        Me.SMSend.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.IDSearch)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.EmpRB)
        Me.Panel2.Controls.Add(Me.ProvRB)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.AllRB)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NmeSearch)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(2, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 87)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(279, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cedula / RIF:"
        '
        'IDSearch
        '
        Me.IDSearch.Location = New System.Drawing.Point(275, 62)
        Me.IDSearch.Name = "IDSearch"
        Me.IDSearch.Size = New System.Drawing.Size(158, 19)
        Me.IDSearch.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Buscar:"
        '
        'EmpRB
        '
        Me.EmpRB.AutoSize = True
        Me.EmpRB.Location = New System.Drawing.Point(352, 19)
        Me.EmpRB.Name = "EmpRB"
        Me.EmpRB.Size = New System.Drawing.Size(71, 16)
        Me.EmpRB.TabIndex = 7
        Me.EmpRB.TabStop = True
        Me.EmpRB.Text = "Empleados"
        Me.EmpRB.UseVisualStyleBackColor = True
        '
        'ProvRB
        '
        Me.ProvRB.AutoSize = True
        Me.ProvRB.Location = New System.Drawing.Point(191, 19)
        Me.ProvRB.Name = "ProvRB"
        Me.ProvRB.Size = New System.Drawing.Size(79, 16)
        Me.ProvRB.TabIndex = 6
        Me.ProvRB.TabStop = True
        Me.ProvRB.Text = "Proveedores"
        Me.ProvRB.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mostrar Beneficiarios:"
        '
        'AllRB
        '
        Me.AllRB.AutoSize = True
        Me.AllRB.Location = New System.Drawing.Point(35, 19)
        Me.AllRB.Name = "AllRB"
        Me.AllRB.Size = New System.Drawing.Size(49, 16)
        Me.AllRB.TabIndex = 4
        Me.AllRB.TabStop = True
        Me.AllRB.Text = "Todos"
        Me.AllRB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre / Razon Social Beneficiario:"
        '
        'NmeSearch
        '
        Me.NmeSearch.Location = New System.Drawing.Point(28, 62)
        Me.NmeSearch.Name = "NmeSearch"
        Me.NmeSearch.Size = New System.Drawing.Size(241, 19)
        Me.NmeSearch.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PMovilD.My.Resources.Resources.Search
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(4, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BFrecDG)
        Me.Panel3.Location = New System.Drawing.Point(2, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 428)
        Me.Panel3.TabIndex = 2
        '
        'BFrecDG
        '
        Me.BFrecDG.AutoGenerateColumns = False
        Me.BFrecDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BFrecDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FREIDCustDataGridViewTextBoxColumn, Me.FRECustNmeDataGridViewTextBoxColumn, Me.N_Movil, Me.FREAliasCDataGridViewTextBoxColumn, Me.FREBankISODataGridViewTextBoxColumn})
        Me.BFrecDG.DataMember = "MRS_Frecuentes"
        Me.BFrecDG.DataSource = Me.PMovilDSBindingSource
        Me.BFrecDG.Location = New System.Drawing.Point(0, 22)
        Me.BFrecDG.Name = "BFrecDG"
        Me.BFrecDG.Size = New System.Drawing.Size(561, 406)
        Me.BFrecDG.TabIndex = 0
        '
        'FREIDCustDataGridViewTextBoxColumn
        '
        Me.FREIDCustDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FREIDCustDataGridViewTextBoxColumn.DataPropertyName = "FRE_IDCust"
        Me.FREIDCustDataGridViewTextBoxColumn.HeaderText = "Cedula ID / RIF"
        Me.FREIDCustDataGridViewTextBoxColumn.Name = "FREIDCustDataGridViewTextBoxColumn"
        Me.FREIDCustDataGridViewTextBoxColumn.Width = 69
        '
        'FRECustNmeDataGridViewTextBoxColumn
        '
        Me.FRECustNmeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FRECustNmeDataGridViewTextBoxColumn.DataPropertyName = "FRE_CustNme"
        Me.FRECustNmeDataGridViewTextBoxColumn.HeaderText = "Nombre / Razon Social"
        Me.FRECustNmeDataGridViewTextBoxColumn.Name = "FRECustNmeDataGridViewTextBoxColumn"
        Me.FRECustNmeDataGridViewTextBoxColumn.Width = 94
        '
        'N_Movil
        '
        Me.N_Movil.HeaderText = "# Movil"
        Me.N_Movil.Name = "N_Movil"
        '
        'FREAliasCDataGridViewTextBoxColumn
        '
        Me.FREAliasCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FREAliasCDataGridViewTextBoxColumn.DataPropertyName = "FRE_AliasC"
        Me.FREAliasCDataGridViewTextBoxColumn.HeaderText = "Alias"
        Me.FREAliasCDataGridViewTextBoxColumn.Name = "FREAliasCDataGridViewTextBoxColumn"
        Me.FREAliasCDataGridViewTextBoxColumn.Width = 51
        '
        'FREBankISODataGridViewTextBoxColumn
        '
        Me.FREBankISODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FREBankISODataGridViewTextBoxColumn.DataPropertyName = "FRE_BankISO"
        Me.FREBankISODataGridViewTextBoxColumn.HeaderText = "Cod. Bco."
        Me.FREBankISODataGridViewTextBoxColumn.Name = "FREBankISODataGridViewTextBoxColumn"
        Me.FREBankISODataGridViewTextBoxColumn.Width = 65
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(46, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(465, 44)
        Me.Panel4.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ESP_Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(437, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Beneficiarios Pago Movil (Frecuentes)"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDynamics2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 44)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(517, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 44)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Green
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(2, 56)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(561, 25)
        Me.Panel5.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de Beneficiarios (Pago Movil Frecuente)"
        '
        'DPMFrec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 581)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "DPMFrec"
        Me.Text = "Lista de Pagos Frecuentes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.BFrecDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EmpRB As System.Windows.Forms.RadioButton
    Friend WithEvents ProvRB As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AllRB As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NmeSearch As System.Windows.Forms.TextBox
    Friend WithEvents BFrecDG As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SMSend As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IDSearch As System.Windows.Forms.TextBox
    Friend WithEvents PMovilDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PMovilDS As PMovilD.PMovilDS
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FREIDCustDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FRECustNmeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents N_Movil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FREAliasCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FREBankISODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
