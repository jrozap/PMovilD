<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DPMMonitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMMonitor))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TodayD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PayLimits = New System.Windows.Forms.DataGridView()
        Me.PMovilDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PMovilDS = New PMovilD.PMovilDS()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DYNOrgNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNRifNumbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNBankNmeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNLteDPMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNPagosMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DYNRestoPMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdTime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PayLimits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.screen1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 38)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox17.Location = New System.Drawing.Point(540, 2)
        Me.PictureBox17.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox17.TabIndex = 58
        Me.PictureBox17.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TodayD)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(47, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 38)
        Me.Panel1.TabIndex = 57
        '
        'TodayD
        '
        Me.TodayD.BackColor = System.Drawing.SystemColors.Control
        Me.TodayD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TodayD.ForeColor = System.Drawing.Color.Red
        Me.TodayD.Location = New System.Drawing.Point(437, 21)
        Me.TodayD.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TodayD.Name = "TodayD"
        Me.TodayD.Size = New System.Drawing.Size(48, 12)
        Me.TodayD.TabIndex = 5
        Me.TodayD.Text = "28/10/2021"
        Me.TodayD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(445, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("ESP_Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label12.Location = New System.Drawing.Point(3, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(275, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Monitor de Pago Movil..."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PayLimits)
        Me.Panel2.Location = New System.Drawing.Point(2, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 169)
        Me.Panel2.TabIndex = 60
        '
        'PayLimits
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkViolet
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PayLimits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.PayLimits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayLimits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DYNOrgNameDataGridViewTextBoxColumn, Me.DYNRifNumbDataGridViewTextBoxColumn, Me.DYNBankNmeDataGridViewTextBoxColumn, Me.DYNLteDPMDataGridViewTextBoxColumn, Me.DYNPagosMDataGridViewTextBoxColumn, Me.DYNRestoPMDataGridViewTextBoxColumn})
        Me.PayLimits.Location = New System.Drawing.Point(0, 18)
        Me.PayLimits.Name = "PayLimits"
        Me.PayLimits.Size = New System.Drawing.Size(577, 150)
        Me.PayLimits.TabIndex = 59
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
        Me.Panel3.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(2, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(577, 19)
        Me.Panel3.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Limites Pago Movil:"
        '
        'DYNOrgNameDataGridViewTextBoxColumn
        '
        Me.DYNOrgNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DYNOrgNameDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.DYNOrgNameDataGridViewTextBoxColumn.Name = "DYNOrgNameDataGridViewTextBoxColumn"
        Me.DYNOrgNameDataGridViewTextBoxColumn.Width = 67
        '
        'DYNRifNumbDataGridViewTextBoxColumn
        '
        Me.DYNRifNumbDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DYNRifNumbDataGridViewTextBoxColumn.HeaderText = "RIF"
        Me.DYNRifNumbDataGridViewTextBoxColumn.Name = "DYNRifNumbDataGridViewTextBoxColumn"
        Me.DYNRifNumbDataGridViewTextBoxColumn.Width = 44
        '
        'DYNBankNmeDataGridViewTextBoxColumn
        '
        Me.DYNBankNmeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DYNBankNmeDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.DYNBankNmeDataGridViewTextBoxColumn.Name = "DYNBankNmeDataGridViewTextBoxColumn"
        Me.DYNBankNmeDataGridViewTextBoxColumn.Width = 56
        '
        'DYNLteDPMDataGridViewTextBoxColumn
        '
        Me.DYNLteDPMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DYNLteDPMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.DYNLteDPMDataGridViewTextBoxColumn.HeaderText = "Limite (Dia)"
        Me.DYNLteDPMDataGridViewTextBoxColumn.Name = "DYNLteDPMDataGridViewTextBoxColumn"
        Me.DYNLteDPMDataGridViewTextBoxColumn.Width = 81
        '
        'DYNPagosMDataGridViewTextBoxColumn
        '
        Me.DYNPagosMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DYNPagosMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.DYNPagosMDataGridViewTextBoxColumn.HeaderText = "Pagos"
        Me.DYNPagosMDataGridViewTextBoxColumn.Name = "DYNPagosMDataGridViewTextBoxColumn"
        Me.DYNPagosMDataGridViewTextBoxColumn.Width = 57
        '
        'DYNRestoPMDataGridViewTextBoxColumn
        '
        Me.DYNRestoPMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.DYNRestoPMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.DYNRestoPMDataGridViewTextBoxColumn.HeaderText = "Disponible"
        Me.DYNRestoPMDataGridViewTextBoxColumn.Name = "DYNRestoPMDataGridViewTextBoxColumn"
        Me.DYNRestoPMDataGridViewTextBoxColumn.Width = 78
        '
        'UpdTime
        '
        Me.UpdTime.Interval = 200
        '
        'DPMMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 218)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1344, 50)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "DPMMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Monitor de Pago Movil..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PayLimits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PMovilDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PayLimits As DataGridView
    Friend WithEvents PMovilDSBindingSource As BindingSource
    Friend WithEvents PMovilDS As PMovilDS
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TodayD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DYNOrgNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DYNRifNumbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DYNBankNmeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DYNLteDPMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DYNPagosMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DYNRestoPMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdTime As Timer
End Class
