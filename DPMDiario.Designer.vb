<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMDiario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProcMth = New System.Windows.Forms.DateTimePicker()
        Me.CSelect = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CompN = New System.Windows.Forms.TextBox()
        Me.TodayD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CancelB = New System.Windows.Forms.Button()
        Me.OkBut = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGDiario = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LDif = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DifComp = New System.Windows.Forms.TextBox()
        Me.THaber = New System.Windows.Forms.TextBox()
        Me.TDebe = New System.Windows.Forms.TextBox()
        Me.MessageT = New System.Windows.Forms.TextBox()
        Me.FechaAs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesAs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel31.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ProcMth)
        Me.Panel1.Controls.Add(Me.CSelect)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CompN)
        Me.Panel1.Controls.Add(Me.TodayD)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(44, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 49)
        Me.Panel1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Comprobantes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 12)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Mes Proceso:"
        '
        'ProcMth
        '
        Me.ProcMth.CustomFormat = "MMMM"
        Me.ProcMth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ProcMth.Location = New System.Drawing.Point(350, 3)
        Me.ProcMth.Name = "ProcMth"
        Me.ProcMth.Size = New System.Drawing.Size(121, 19)
        Me.ProcMth.TabIndex = 28
        '
        'CSelect
        '
        Me.CSelect.FormattingEnabled = True
        Me.CSelect.Location = New System.Drawing.Point(350, 25)
        Me.CSelect.Name = "CSelect"
        Me.CSelect.Size = New System.Drawing.Size(121, 20)
        Me.CSelect.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(522, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Comprobante"
        '
        'CompN
        '
        Me.CompN.BackColor = System.Drawing.SystemColors.Control
        Me.CompN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CompN.Location = New System.Drawing.Point(592, 27)
        Me.CompN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CompN.Name = "CompN"
        Me.CompN.Size = New System.Drawing.Size(85, 12)
        Me.CompN.TabIndex = 4
        Me.CompN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TodayD
        '
        Me.TodayD.BackColor = System.Drawing.SystemColors.Control
        Me.TodayD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TodayD.Location = New System.Drawing.Point(593, 7)
        Me.TodayD.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TodayD.Name = "TodayD"
        Me.TodayD.Size = New System.Drawing.Size(85, 12)
        Me.TodayD.TabIndex = 3
        Me.TodayD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("ESP_Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Location = New System.Drawing.Point(6, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Libro Diario PM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(734, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 49)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDynamics2
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox17.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox17.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(38, 51)
        Me.PictureBox17.TabIndex = 24
        Me.PictureBox17.TabStop = False
        '
        'Panel31
        '
        Me.Panel31.Controls.Add(Me.Button1)
        Me.Panel31.Controls.Add(Me.CancelB)
        Me.Panel31.Controls.Add(Me.OkBut)
        Me.Panel31.Location = New System.Drawing.Point(654, 517)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(127, 40)
        Me.Panel31.TabIndex = 57
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGDiario)
        Me.Panel2.Location = New System.Drawing.Point(2, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 384)
        Me.Panel2.TabIndex = 58
        '
        'DGDiario
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGDiario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDiario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaAs, Me.CtaC, Me.DesAs, Me.DebeG, Me.HaberG})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGDiario.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGDiario.Location = New System.Drawing.Point(0, 0)
        Me.DGDiario.Name = "DGDiario"
        Me.DGDiario.Size = New System.Drawing.Size(779, 384)
        Me.DGDiario.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LDif)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.DifComp)
        Me.Panel3.Controls.Add(Me.THaber)
        Me.Panel3.Controls.Add(Me.TDebe)
        Me.Panel3.Location = New System.Drawing.Point(466, 450)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(315, 59)
        Me.Panel3.TabIndex = 59
        '
        'LDif
        '
        Me.LDif.AutoSize = True
        Me.LDif.Location = New System.Drawing.Point(7, 36)
        Me.LDif.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LDif.Name = "LDif"
        Me.LDif.Size = New System.Drawing.Size(51, 12)
        Me.LDif.TabIndex = 31
        Me.LDif.Text = "Diferencia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 12)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Total Comprobante:"
        '
        'DifComp
        '
        Me.DifComp.BackColor = System.Drawing.SystemColors.Control
        Me.DifComp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DifComp.Location = New System.Drawing.Point(211, 37)
        Me.DifComp.Name = "DifComp"
        Me.DifComp.Size = New System.Drawing.Size(100, 12)
        Me.DifComp.TabIndex = 2
        Me.DifComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'THaber
        '
        Me.THaber.BackColor = System.Drawing.SystemColors.Control
        Me.THaber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.THaber.Location = New System.Drawing.Point(211, 12)
        Me.THaber.Name = "THaber"
        Me.THaber.Size = New System.Drawing.Size(100, 12)
        Me.THaber.TabIndex = 1
        Me.THaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TDebe
        '
        Me.TDebe.BackColor = System.Drawing.SystemColors.Control
        Me.TDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDebe.Location = New System.Drawing.Point(105, 12)
        Me.TDebe.Name = "TDebe"
        Me.TDebe.Size = New System.Drawing.Size(100, 12)
        Me.TDebe.TabIndex = 0
        Me.TDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MessageT
        '
        Me.MessageT.BackColor = System.Drawing.SystemColors.Control
        Me.MessageT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MessageT.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold)
        Me.MessageT.ForeColor = System.Drawing.Color.Red
        Me.MessageT.Location = New System.Drawing.Point(4, 454)
        Me.MessageT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MessageT.Name = "MessageT"
        Me.MessageT.Size = New System.Drawing.Size(434, 13)
        Me.MessageT.TabIndex = 62
        '
        'FechaAs
        '
        Me.FechaAs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Format = "d"
        Me.FechaAs.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaAs.HeaderText = "Fecha"
        Me.FechaAs.Name = "FechaAs"
        Me.FechaAs.Width = 54
        '
        'CtaC
        '
        Me.CtaC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CtaC.DefaultCellStyle = DataGridViewCellStyle3
        Me.CtaC.HeaderText = "Cuenta"
        Me.CtaC.Name = "CtaC"
        Me.CtaC.Width = 60
        '
        'DesAs
        '
        Me.DesAs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DesAs.HeaderText = "Descripcion Asiento"
        Me.DesAs.Name = "DesAs"
        Me.DesAs.Width = 106
        '
        'DebeG
        '
        Me.DebeG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.DebeG.DefaultCellStyle = DataGridViewCellStyle4
        Me.DebeG.HeaderText = "Debe"
        Me.DebeG.Name = "DebeG"
        Me.DebeG.Width = 53
        '
        'HaberG
        '
        Me.HaberG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.HaberG.DefaultCellStyle = DataGridViewCellStyle5
        Me.HaberG.HeaderText = "Haber"
        Me.HaberG.Name = "HaberG"
        Me.HaberG.Width = 57
        '
        'DPMDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MessageT)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel31)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox17)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "DPMDiario"
        Me.Text = "Libro de Diario (PM)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel31.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CompN As System.Windows.Forms.TextBox
    Friend WithEvents TodayD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProcMth As System.Windows.Forms.DateTimePicker
    Friend WithEvents CSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents OkBut As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LDif As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DifComp As System.Windows.Forms.TextBox
    Friend WithEvents THaber As System.Windows.Forms.TextBox
    Friend WithEvents TDebe As System.Windows.Forms.TextBox
    Friend WithEvents DGDiario As System.Windows.Forms.DataGridView
    Friend WithEvents MessageT As System.Windows.Forms.TextBox
    Friend WithEvents FechaAs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesAs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebeG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaberG As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
