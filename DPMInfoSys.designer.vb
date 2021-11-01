' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
' Copyright (c) Microsoft Corporation. All rights reserved.
Partial Public Class DPMInfoSys
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DPMInfoSys))
        Me.pgeSystemInformation = New System.Windows.Forms.TabPage()
        Me.lvwSystemInformation = New System.Windows.Forms.ListView()
        Me.colProperty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabExplore = New System.Windows.Forms.TabControl()
        Me.pgeProperties = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRefreshTickCount = New System.Windows.Forms.Button()
        Me.lblWorkingSet = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblUserDomainName = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblOSVersion = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblMachineName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTickCount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSystemDirectory = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCurrentDirectory = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCommandLine = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CancelB = New System.Windows.Forms.Button()
        Me.OKBut = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LblNombreEquipo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LblSerialDD = New System.Windows.Forms.TextBox()
        Me.LblSerialBoard = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CB32 = New System.Windows.Forms.CheckBox()
        Me.CB64 = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ProcessorN = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.pgeSystemInformation.SuspendLayout()
        Me.tabExplore.SuspendLayout()
        Me.pgeProperties.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pgeSystemInformation
        '
        Me.pgeSystemInformation.Controls.Add(Me.lvwSystemInformation)
        Me.pgeSystemInformation.Location = New System.Drawing.Point(4, 22)
        Me.pgeSystemInformation.Name = "pgeSystemInformation"
        Me.pgeSystemInformation.Size = New System.Drawing.Size(515, 256)
        Me.pgeSystemInformation.TabIndex = 4
        Me.pgeSystemInformation.Text = "Info General"
        Me.pgeSystemInformation.Visible = False
        '
        'lvwSystemInformation
        '
        Me.lvwSystemInformation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProperty, Me.colValue})
        Me.lvwSystemInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSystemInformation.ForeColor = System.Drawing.Color.Blue
        Me.lvwSystemInformation.Location = New System.Drawing.Point(0, 0)
        Me.lvwSystemInformation.Name = "lvwSystemInformation"
        Me.lvwSystemInformation.Size = New System.Drawing.Size(515, 256)
        Me.lvwSystemInformation.TabIndex = 0
        Me.lvwSystemInformation.UseCompatibleStateImageBehavior = False
        Me.lvwSystemInformation.View = System.Windows.Forms.View.Details
        '
        'colProperty
        '
        Me.colProperty.Name = "colProperty"
        Me.colProperty.Text = "Property"
        Me.colProperty.Width = 117
        '
        'colValue
        '
        Me.colValue.Name = "colValue"
        Me.colValue.Text = "Value"
        Me.colValue.Width = 341
        '
        'tabExplore
        '
        Me.tabExplore.Controls.Add(Me.pgeProperties)
        Me.tabExplore.Controls.Add(Me.pgeSystemInformation)
        Me.tabExplore.ItemSize = New System.Drawing.Size(59, 18)
        Me.tabExplore.Location = New System.Drawing.Point(1, 51)
        Me.tabExplore.Name = "tabExplore"
        Me.tabExplore.SelectedIndex = 0
        Me.tabExplore.Size = New System.Drawing.Size(523, 282)
        Me.tabExplore.TabIndex = 0
        '
        'pgeProperties
        '
        Me.pgeProperties.BackColor = System.Drawing.SystemColors.Control
        Me.pgeProperties.Controls.Add(Me.Label10)
        Me.pgeProperties.Controls.Add(Me.Label4)
        Me.pgeProperties.Controls.Add(Me.Label2)
        Me.pgeProperties.Controls.Add(Me.Label8)
        Me.pgeProperties.Controls.Add(Me.PictureBox4)
        Me.pgeProperties.Controls.Add(Me.Label1)
        Me.pgeProperties.Controls.Add(Me.PictureBox3)
        Me.pgeProperties.Controls.Add(Me.Label6)
        Me.pgeProperties.Controls.Add(Me.btnRefreshTickCount)
        Me.pgeProperties.Controls.Add(Me.lblWorkingSet)
        Me.pgeProperties.Controls.Add(Me.Label21)
        Me.pgeProperties.Controls.Add(Me.lblVersion)
        Me.pgeProperties.Controls.Add(Me.Label19)
        Me.pgeProperties.Controls.Add(Me.lblUserName)
        Me.pgeProperties.Controls.Add(Me.Label17)
        Me.pgeProperties.Controls.Add(Me.lblUserDomainName)
        Me.pgeProperties.Controls.Add(Me.Label15)
        Me.pgeProperties.Controls.Add(Me.lblOSVersion)
        Me.pgeProperties.Controls.Add(Me.Label13)
        Me.pgeProperties.Controls.Add(Me.lblMachineName)
        Me.pgeProperties.Controls.Add(Me.Label11)
        Me.pgeProperties.Controls.Add(Me.lblTickCount)
        Me.pgeProperties.Controls.Add(Me.Label9)
        Me.pgeProperties.Controls.Add(Me.lblSystemDirectory)
        Me.pgeProperties.Controls.Add(Me.Label7)
        Me.pgeProperties.Controls.Add(Me.lblCurrentDirectory)
        Me.pgeProperties.Controls.Add(Me.Label5)
        Me.pgeProperties.Controls.Add(Me.lblCommandLine)
        Me.pgeProperties.Controls.Add(Me.Label3)
        Me.pgeProperties.Location = New System.Drawing.Point(4, 22)
        Me.pgeProperties.Name = "pgeProperties"
        Me.pgeProperties.Size = New System.Drawing.Size(515, 256)
        Me.pgeProperties.TabIndex = 2
        Me.pgeProperties.Text = "Windows"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(334, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 12)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Version 4.8.03752 RTMRel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(334, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Version 10.0.30319.1 RTMRel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(334, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "License Key: 01018-532-2002102-70642"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 234)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Microsoft .NET Framework:"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.PMovilD.My.Resources.Resources.VStudio
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(7, 199)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 48)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Microsoft Visual Studio 2010:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.PMovilD.My.Resources.Resources.Win10
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(7, 84)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 41)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Microsoft Visual Basic 2010:"
        '
        'btnRefreshTickCount
        '
        Me.btnRefreshTickCount.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefreshTickCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRefreshTickCount.Location = New System.Drawing.Point(333, 97)
        Me.btnRefreshTickCount.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRefreshTickCount.Name = "btnRefreshTickCount"
        Me.btnRefreshTickCount.Size = New System.Drawing.Size(61, 19)
        Me.btnRefreshTickCount.TabIndex = 12
        Me.btnRefreshTickCount.Text = "&Refresh"
        Me.btnRefreshTickCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWorkingSet
        '
        Me.lblWorkingSet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWorkingSet.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWorkingSet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWorkingSet.Location = New System.Drawing.Point(144, 173)
        Me.lblWorkingSet.Name = "lblWorkingSet"
        Me.lblWorkingSet.Size = New System.Drawing.Size(360, 15)
        Me.lblWorkingSet.TabIndex = 20
        Me.lblWorkingSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(56, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 15)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Ambito Trabajo:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVersion.Location = New System.Drawing.Point(144, 155)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(360, 15)
        Me.lblVersion.TabIndex = 18
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(56, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 15)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Version .NET:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(144, 137)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(360, 15)
        Me.lblUserName.TabIndex = 16
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(56, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 15)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Usuario:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserDomainName
        '
        Me.lblUserDomainName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserDomainName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblUserDomainName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserDomainName.Location = New System.Drawing.Point(144, 119)
        Me.lblUserDomainName.Name = "lblUserDomainName"
        Me.lblUserDomainName.Size = New System.Drawing.Size(360, 15)
        Me.lblUserDomainName.TabIndex = 14
        Me.lblUserDomainName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(55, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 15)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Dominio:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOSVersion
        '
        Me.lblOSVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOSVersion.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblOSVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOSVersion.Location = New System.Drawing.Point(144, 61)
        Me.lblOSVersion.Name = "lblOSVersion"
        Me.lblOSVersion.Size = New System.Drawing.Size(360, 15)
        Me.lblOSVersion.TabIndex = 7
        Me.lblOSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(56, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Version SO:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMachineName
        '
        Me.lblMachineName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMachineName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblMachineName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMachineName.Location = New System.Drawing.Point(144, 43)
        Me.lblMachineName.Name = "lblMachineName"
        Me.lblMachineName.Size = New System.Drawing.Size(360, 15)
        Me.lblMachineName.TabIndex = 5
        Me.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(56, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 15)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Nombre Equipo:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTickCount
        '
        Me.lblTickCount.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTickCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTickCount.Location = New System.Drawing.Point(144, 100)
        Me.lblTickCount.Name = "lblTickCount"
        Me.lblTickCount.Size = New System.Drawing.Size(128, 15)
        Me.lblTickCount.TabIndex = 11
        Me.lblTickCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(56, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Eventos:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSystemDirectory
        '
        Me.lblSystemDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSystemDirectory.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblSystemDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSystemDirectory.Location = New System.Drawing.Point(144, 79)
        Me.lblSystemDirectory.Name = "lblSystemDirectory"
        Me.lblSystemDirectory.Size = New System.Drawing.Size(360, 15)
        Me.lblSystemDirectory.TabIndex = 9
        Me.lblSystemDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(56, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Dir. Sistema:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrentDirectory
        '
        Me.lblCurrentDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentDirectory.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblCurrentDirectory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCurrentDirectory.Location = New System.Drawing.Point(144, 25)
        Me.lblCurrentDirectory.Name = "lblCurrentDirectory"
        Me.lblCurrentDirectory.Size = New System.Drawing.Size(360, 15)
        Me.lblCurrentDirectory.TabIndex = 3
        Me.lblCurrentDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(56, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Directorio Act:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCommandLine
        '
        Me.lblCommandLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommandLine.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblCommandLine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCommandLine.Location = New System.Drawing.Point(144, 7)
        Me.lblCommandLine.Name = "lblCommandLine"
        Me.lblCommandLine.Size = New System.Drawing.Size(360, 15)
        Me.lblCommandLine.TabIndex = 1
        Me.lblCommandLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(56, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Linea Comandos:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(51, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 41)
        Me.Panel1.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("ESP_Italic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(67, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(281, 23)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Informacion del Sistema"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.PMovilD.My.Resources.Resources.C2PDyn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(484, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 41)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PMovilD.My.Resources.Resources.Win10
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 41)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.CancelB)
        Me.Panel5.Controls.Add(Me.OKBut)
        Me.Panel5.Location = New System.Drawing.Point(480, 335)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(44, 77)
        Me.Panel5.TabIndex = 16
        '
        'CancelB
        '
        Me.CancelB.BackgroundImage = Global.PMovilD.My.Resources.Resources.CloseApp
        Me.CancelB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelB.Location = New System.Drawing.Point(6, 41)
        Me.CancelB.Name = "CancelB"
        Me.CancelB.Size = New System.Drawing.Size(32, 32)
        Me.CancelB.TabIndex = 4
        Me.CancelB.UseVisualStyleBackColor = True
        '
        'OKBut
        '
        Me.OKBut.BackgroundImage = Global.PMovilD.My.Resources.Resources.OkIcon
        Me.OKBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OKBut.Location = New System.Drawing.Point(6, 4)
        Me.OKBut.Name = "OKBut"
        Me.OKBut.Size = New System.Drawing.Size(32, 32)
        Me.OKBut.TabIndex = 3
        Me.OKBut.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.ProcessorN)
        Me.Panel3.Controls.Add(Me.CB64)
        Me.Panel3.Controls.Add(Me.CB32)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.LblNombreUsuario)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.LblNombreEquipo)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.LblSerialDD)
        Me.Panel3.Controls.Add(Me.LblSerialBoard)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Panel3.Location = New System.Drawing.Point(5, 335)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(469, 77)
        Me.Panel3.TabIndex = 14
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.PMovilD.My.Resources.Resources.screen1
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(202, 16)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(45, 48)
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(254, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 12)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Usuario:"
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.LblNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblNombreUsuario.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblNombreUsuario.Location = New System.Drawing.Point(341, 33)
        Me.LblNombreUsuario.Multiline = True
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(117, 14)
        Me.LblNombreUsuario.TabIndex = 21
        Me.LblNombreUsuario.Text = "Jaime M Roza Pedreira"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(254, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 12)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Nombre Equipo:"
        '
        'LblNombreEquipo
        '
        Me.LblNombreEquipo.BackColor = System.Drawing.SystemColors.Control
        Me.LblNombreEquipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblNombreEquipo.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblNombreEquipo.Location = New System.Drawing.Point(341, 16)
        Me.LblNombreEquipo.Name = "LblNombreEquipo"
        Me.LblNombreEquipo.Size = New System.Drawing.Size(99, 13)
        Me.LblNombreEquipo.TabIndex = 20
        Me.LblNombreEquipo.Text = "desktop-rof1635"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(57, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 12)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Serial Board:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(57, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 12)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Serial HDD:"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.PMovilD.My.Resources.Resources.devwindows
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(5, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(45, 48)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'LblSerialDD
        '
        Me.LblSerialDD.BackColor = System.Drawing.SystemColors.Control
        Me.LblSerialDD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblSerialDD.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblSerialDD.Location = New System.Drawing.Point(128, 33)
        Me.LblSerialDD.Name = "LblSerialDD"
        Me.LblSerialDD.Size = New System.Drawing.Size(68, 13)
        Me.LblSerialDD.TabIndex = 15
        Me.LblSerialDD.Text = "1526896320"
        '
        'LblSerialBoard
        '
        Me.LblSerialBoard.BackColor = System.Drawing.SystemColors.Control
        Me.LblSerialBoard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LblSerialBoard.ForeColor = System.Drawing.Color.DarkBlue
        Me.LblSerialBoard.Location = New System.Drawing.Point(128, 50)
        Me.LblSerialBoard.Name = "LblSerialBoard"
        Me.LblSerialBoard.Size = New System.Drawing.Size(68, 13)
        Me.LblSerialBoard.TabIndex = 16
        Me.LblSerialBoard.Text = "5289637841"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(254, 50)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 12)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Windows Type:"
        '
        'CB32
        '
        Me.CB32.AutoSize = True
        Me.CB32.ForeColor = System.Drawing.Color.DarkBlue
        Me.CB32.Location = New System.Drawing.Point(341, 50)
        Me.CB32.Name = "CB32"
        Me.CB32.Size = New System.Drawing.Size(53, 16)
        Me.CB32.TabIndex = 26
        Me.CB32.Text = "32-bit"
        Me.CB32.UseVisualStyleBackColor = True
        '
        'CB64
        '
        Me.CB64.AutoSize = True
        Me.CB64.ForeColor = System.Drawing.Color.DarkBlue
        Me.CB64.Location = New System.Drawing.Point(400, 50)
        Me.CB64.Name = "CB64"
        Me.CB64.Size = New System.Drawing.Size(53, 16)
        Me.CB64.TabIndex = 27
        Me.CB64.Text = "64-bit"
        Me.CB64.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(57, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 12)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Procesadores:"
        '
        'ProcessorN
        '
        Me.ProcessorN.BackColor = System.Drawing.SystemColors.Control
        Me.ProcessorN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProcessorN.ForeColor = System.Drawing.Color.DarkBlue
        Me.ProcessorN.Location = New System.Drawing.Point(128, 16)
        Me.ProcessorN.Name = "ProcessorN"
        Me.ProcessorN.Size = New System.Drawing.Size(11, 13)
        Me.ProcessorN.TabIndex = 28
        Me.ProcessorN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(145, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 12)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Cores"
        '
        'DPMInfoSys
        '
        Me.ClientSize = New System.Drawing.Size(528, 424)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tabExplore)
        Me.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DPMInfoSys"
        Me.Text = "Informacion del Sistema"
        Me.pgeSystemInformation.ResumeLayout(False)
        Me.tabExplore.ResumeLayout(False)
        Me.pgeProperties.ResumeLayout(False)
        Me.pgeProperties.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pgeSystemInformation As System.Windows.Forms.TabPage
    Friend WithEvents lvwSystemInformation As System.Windows.Forms.ListView
    Friend WithEvents colProperty As System.Windows.Forms.ColumnHeader
    Friend WithEvents colValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents tabExplore As System.Windows.Forms.TabControl
    Friend WithEvents pgeProperties As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRefreshTickCount As System.Windows.Forms.Button
    Friend WithEvents lblWorkingSet As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblUserDomainName As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblOSVersion As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblMachineName As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTickCount As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSystemDirectory As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentDirectory As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCommandLine As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CancelB As System.Windows.Forms.Button
    Friend WithEvents OKBut As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents LblSerialDD As System.Windows.Forms.TextBox
    Friend WithEvents LblSerialBoard As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LblNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LblNombreEquipo As System.Windows.Forms.TextBox
    Friend WithEvents CB64 As System.Windows.Forms.CheckBox
    Friend WithEvents CB32 As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ProcessorN As System.Windows.Forms.TextBox

End Class
