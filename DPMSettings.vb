Imports System.Drawing.Printing
'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMSettings - Configuracion PMovilD               *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMSettings     | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMSettings
    'Variables Publicas Modulo: DPMMayor
    Public StrCta As String
    Public NCtas As Integer
    Public FHoy As Date
    Public ThisMoment As Date
    Public indice As Integer
    Public fTime As Boolean
    Public idxCta As Integer
    Public CurrMth As Integer
    Public whoChg As String

    'Parametros Dataset
    Public MRSDBcon As New OdbcConnection
    Public DBProvider As String
    Public DBSource As String

    'Variables para DBCta (Tabla de Cuentas Contables)
    Public DSetCta As New DataSet
    Public DAdpCta As OdbcDataAdapter
    Public cmdSQLCta As String

    Private Sub DPMSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings    - Libro de Mayor                                                                                                '   
        ' Sub: DPMSettings_Load  - Carga el formato DPMSettings                                                                                  '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim ixd As Integer = 0

        fTime = True
        lblMod.Visible = False
        ModBut.Visible = False

        Select Case Global.PMovilD.My.MySettings.Default.DBType
            Case "MS Access2010/19"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
            Case "MariaDB"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
            Case "PostgreSQL"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
        End Select
        MRSDBcon.Open()

        FHoy = Today
        ThisMoment = Now

        DBName.Text = Global.PMovilD.My.MySettings.Default.DBName
        currDSN.Text = Global.PMovilD.My.MySettings.Default.currDSN
        DBType.SelectedIndex = 0
    End Sub

    Private Sub DBType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBType.SelectedIndexChanged
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings               - Libro de Mayor                                                                                                '   
        ' Sub: DBType_SelectedIndexChanged  - Selecciona el tipo de BD                                                                                   '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim ind As Integer = 0

        lblMod.Visible = False
        ModBut.Visible = False

        Select Case DBType.SelectedIndex
            Case 0
                DBName.Text = Global.PMovilD.My.MySettings.Default.DBName
                DBConnect.Text = Global.PMovilD.My.MySettings.Default.MRSDataAcc
                DBPath.Text = Global.PMovilD.My.MySettings.Default.AccPath
                IPAddr.Text = "    --    "
                DSN.Text = Global.PMovilD.My.MySettings.Default.dsnAcc
                UserID.Text = Global.PMovilD.My.MySettings.Default.UserIDAcc
                If Global.PMovilD.My.MySettings.Default.passwdAcc = "" Then
                    Passwd.PasswordChar = ""
                    Passwd.Text = Global.PMovilD.My.MySettings.Default.passwdAcc
                Else
                    Passwd.PasswordChar = "*"
                    Passwd.Text = Global.PMovilD.My.MySettings.Default.passwdAcc
                End If
                GProp.Refresh()
            Case 1
                DBName.Text = Global.PMovilD.My.MySettings.Default.DBName.ToLower
                DBConnect.Text = Global.PMovilD.My.MySettings.Default.MRSDataMDB
                DBPath.Text = "    --    "
                IPAddr.Text = Global.PMovilD.My.MySettings.Default.MDBipV4
                Label7.Location = New System.Drawing.Point(344, 169)
                Label7.Text = "MariaDB 10.3"
                Label7.ForeColor = Color.BurlyWood
                DSN.Text = Global.PMovilD.My.MySettings.Default.dsnMDB
                UserID.Text = Global.PMovilD.My.MySettings.Default.UserIDMDB
                If Global.PMovilD.My.MySettings.Default.passwdMDB = "" Then
                    Passwd.PasswordChar = ""
                    Passwd.Text = Global.PMovilD.My.MySettings.Default.passwdMDB
                Else
                    Passwd.PasswordChar = "*"
                    Passwd.Text = Global.PMovilD.My.MySettings.Default.passwdMDB
                End If
                GProp.Refresh()
            Case 2
                DBName.Text = Global.PMovilD.My.MySettings.Default.DBName
                DBConnect.Text = Global.PMovilD.My.MySettings.Default.MRSDataPG
                DBPath.Text = "    --    "
                IPAddr.Text = Global.PMovilD.My.MySettings.Default.PGipV4
                Label7.Location = New System.Drawing.Point(330, 169)
                Label7.Text = "PostgreSQL 14.3.1"
                Label7.ForeColor = Color.SlateBlue
                DSN.Text = Global.PMovilD.My.MySettings.Default.dsnPG
                UserID.Text = Global.PMovilD.My.MySettings.Default.UserIDPG
                If Global.PMovilD.My.MySettings.Default.passwdPG = "" Then
                    Passwd.PasswordChar = ""
                    Passwd.Text = Global.PMovilD.My.MySettings.Default.passwdPG
                Else
                    Passwd.PasswordChar = "*"
                    Passwd.Text = Global.PMovilD.My.MySettings.Default.passwdPG
                End If
                GProp.Refresh()
        End Select
    End Sub

    Private Sub DBConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBConnect.Click
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DBConnect_Click     - Evento de toma del control DBConnect via Mouse                                                              '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DBConnect
        GProp.Refresh()
    End Sub

    Private Sub DBConnect_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBConnect.GotFocus
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DBConnect_GotFocus  - Evento de toma del control DBConnect                                                                        '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DBConnect
        GProp.Refresh()
    End Sub

    Private Sub DBType_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBType.Click
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DBType_Click     - Evento de toma del control DBType via Mouse                                                                 '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DBType
        GProp.Refresh()
    End Sub

    Private Sub DBType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBType.GotFocus
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DBType_GotFocus  - Evento de toma del control DBType                                                                           '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DBType
        GProp.Refresh()
    End Sub

    Private Sub DBPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBPath.Click
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DBPath_Click     - Evento de toma del control DBConnect via Mouse                                                              '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DBPath
        GProp.Refresh()
    End Sub

    Private Sub DBPath_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBPath.GotFocus
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DBPath_GotFocus  - Evento de toma del control DBConnect                                                                        '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DBPath
        GProp.Refresh()
    End Sub

    Private Sub IPAddr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles IPAddr.Click
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: IPAddr_Click     - Evento de toma del control IPAddr via Mouse                                                                 '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = IPAddr
        GProp.Refresh()
    End Sub

    Private Sub IPAddr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IPAddr.GotFocus
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: IPAddr_GotFocus  - Evento de toma del control IPAddr                                                                           '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = IPAddr
        GProp.Refresh()
    End Sub

    Private Sub DSN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DSN.Click
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DSN_Click     - Evento de toma del control DSN via Mouse                                                                 '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DSN
        GProp.Refresh()
    End Sub

    Private Sub DSN_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DSN.GotFocus
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: DSN_GotFocus  - Evento de toma del control DSN                                                                           '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = DSN
        GProp.Refresh()
    End Sub

    Private Sub UserID_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserID.Click
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: UserID_Click     - Evento de toma del control UserID via Mouse                                                                 '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = UserID
        GProp.Refresh()
    End Sub

    Private Sub UserID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserID.GotFocus
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: UserID_GotFocus  - Evento de toma del control UserID                                                                           '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = UserID
        GProp.Refresh()
    End Sub

    Private Sub Passwd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Passwd.Click
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: Passwd_Click     - Evento de toma del control Passwd via Mouse                                                                 '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = Passwd
        GProp.Refresh()
    End Sub

    Private Sub Passwd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Passwd.GotFocus
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMSettings      - Parametros de PMovilD                                                                                       '   
        ' Sub: Passwd_GotFocus  - Evento de toma del control Passwd                                                                           '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        GProp.SelectedObject = Passwd
        GProp.Refresh()
    End Sub

    Private Sub DBType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBType.TextChanged
        lblMod.Visible = True
        ModBut.Visible = True
        CBut.Visible = True
        whoChg = "DBTy"
    End Sub

    Private Sub CBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBut.Click
        lblMod.Visible = False
        ModBut.Visible = False
        CBut.Visible = False
    End Sub

    Private Sub ModBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModBut.Click
        Select Case whoChg
            Case "DBTy"
                Select Case DBType.SelectedIndex
                    Case 0
                        Global.PMovilD.My.MySettings.Default.DBType = "MS Access2010/19"
                    Case 1
                        Global.PMovilD.My.MySettings.Default.DBType = "MariaDB"
                    Case 2
                        Global.PMovilD.My.MySettings.Default.DBType = "PostgreSQL"
                End Select
            Case "Path"
                Global.PMovilD.My.MySettings.Default.AccPath = DBPath.Text
            Case "IPAd"
                Select Case DBType.SelectedIndex
                    Case 1
                        Global.PMovilD.My.MySettings.Default.MDBipV4 = IPAddr.Text
                    Case 2
                        Global.PMovilD.My.MySettings.Default.PGipV4 = IPAddr.Text
                End Select
            Case "DSN"
                Global.PMovilD.My.MySettings.Default.currDSN = DSN.Text
                currDSN.Text = DSN.Text
            Case "DBid"
                Select Case DBType.SelectedIndex
                    Case 0
                        Global.PMovilD.My.MySettings.Default.UserIDAcc = UserID.Text
                    Case 1
                        Global.PMovilD.My.MySettings.Default.UserIDMDB = UserID.Text
                    Case 2
                        Global.PMovilD.My.MySettings.Default.UserIDPG = UserID.Text
                End Select
            Case "Pswd"
                Select Case DBType.SelectedIndex
                    Case 0
                        Global.PMovilD.My.MySettings.Default.passwdAcc = Passwd.Text
                    Case 1
                        Global.PMovilD.My.MySettings.Default.passwdMDB = Passwd.Text
                    Case 2
                        Global.PMovilD.My.MySettings.Default.passwdPG = Passwd.Text
                End Select
        End Select
    End Sub

    Private Sub Passwd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Passwd.TextChanged
        lblMod.Visible = True
        ModBut.Visible = True
        CBut.Visible = True
        whoChg = "Pswd"
    End Sub

    Private Sub UserID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserID.TextChanged
        lblMod.Visible = True
        ModBut.Visible = True
        CBut.Visible = True
        whoChg = "DBid"
    End Sub

    Private Sub DSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DSN.TextChanged
        lblMod.Visible = True
        ModBut.Visible = True
        CBut.Visible = True
        whoChg = "DSN"
    End Sub

    Private Sub IPAddr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPAddr.TextChanged
        lblMod.Visible = True
        ModBut.Visible = True
        CBut.Visible = True
        whoChg = "IPAd"
    End Sub

    Private Sub DBPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBPath.TextChanged
        lblMod.Visible = True
        ModBut.Visible = True
        CBut.Visible = True
        whoChg = "Path"
    End Sub

    Private Sub UsrSets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsrSets.Click
        lblSets.Text = "Control de Usuarios"
    End Sub

    Private Sub TabParms_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabParms.TabIndexChanged
        Select Case TabParms.TabIndex
            Case 0
                lblSets.Text = "Parametros BD"
            Case 1
                lblSets.Text = "Control de Usuarios"
            Case 2
                lblSets.Text = "Impresoras / Control de Impresion"
        End Select
    End Sub
  
End Class