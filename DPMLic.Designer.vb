<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DPMLic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMLic))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LicText = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Russo One", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBox1.Location = New System.Drawing.Point(82, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(594, 28)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "PMovilD ® ACUERDO DE LICENCIA DE USUARIO FINAL"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LicText
        '
        Me.LicText.BackColor = System.Drawing.SystemColors.Control
        Me.LicText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LicText.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicText.ForeColor = System.Drawing.Color.DarkBlue
        Me.LicText.Location = New System.Drawing.Point(6, 73)
        Me.LicText.Name = "LicText"
        Me.LicText.ReadOnly = True
        Me.LicText.Size = New System.Drawing.Size(684, 936)
        Me.LicText.TabIndex = 2
        Me.LicText.Text = resources.GetString("LicText.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(14, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 64)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'DPMLic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 581)
        Me.Controls.Add(Me.LicText)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DPMLic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PMovilD ® ACUERDO DE LICENCIA DE USUARIO FINAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
	Friend WithEvents LicText As System.Windows.Forms.RichTextBox
End Class
