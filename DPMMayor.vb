'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMMayor - Libro de Mayor General (Cont. PM)      *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMMayor        | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMMayor
    'Variables Publicas Modulo: DPMMayor
    Public StrCta As String
    Public NCtas As Integer
    Public FHoy As Date
    Public ThisMoment As Date
    Public indice As Integer
    Public fTime As Boolean
    Public idxCta As Integer
    Public CurrMth As Integer

    'Workarea para generar el Mayor
    Public wrkDate As Date
    Public wrkCCta As String
    Public wrkDCta As String
    Public wrkComp As String
    Public wrkDesA As String
    Public wrkDebe As Double
    Public wrkHber As Double
    Public wrkSdoC As Double

    'Parametros Dataset
    Public MRSDBcon As New OdbcConnection
    Public DBProvider As String
    Public DBSource As String
    Public DBPath As String
    Public DBName As String

    'Variables para DBCta (Tabla de Cuentas Contables)
    Public DSetCta As New DataSet
    Public DAdpCta As OdbcDataAdapter
    Public cmdSQLCta As String

    'Variables para DBMov (Tabla de Movimientos Contables)
    Public DSetMov As New DataSet
    Public DAdpMov As OdbcDataAdapter
    Public cmdSQLMov As String

    'Variables para DBWrkA (Tabla de Workarea MG)
    Public DSetWA As New DataSet
    Public DAdpWA As OdbcDataAdapter
    Public cmdSQLWA As String

    Private Sub DPMMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMayor - Libro de Mayor                                                                                                      '   
        ' Sub: DPMMayor_Load  - Carga el formato DPMMayor                                                                                        '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim ixd As Integer

        fTime = True
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
        TodayD.Text = FHoy

        CurrMth = CInt(Mid(CStr(FHoy), 4, 2))
        ProcMth.Text = MesString(CurrMth)
        MonthN.Text = MesString(CurrMth)

        'Carga Inicial de Movimientos Contables
        cmdSQLMov = "SELECT * FROM MRS_CGPMov ORDER BY RPM_FechaT"
        DAdpMov = New OdbcDataAdapter(cmdSQLMov, MRSDBcon)
        DAdpMov.Fill(DSetMov, "MovCta")

        'ComboBox de Cuentas Contables
        cmdSQLCta = "SELECT * FROM MRS_CatCta ORDER BY CG_CodigoCta"
        DAdpCta = New OdbcDataAdapter(cmdSQLCta, MRSDBcon)
        DAdpCta.Fill(DSetCta, "CatCta")
        nCtas = DSetCta.Tables(0).Rows.Count

        ixd = 0
        For idxCia = 0 To NCtas - 1
            Select Case Len(Trim(DSetCta.Tables("CatCta").Rows(idxCia).Item("CG_CodigoCta")))
                Case 3
                    StrCta = DSetCta.Tables("CatCta").Rows(idxCia).Item("CG_CodigoCta")
                    CodC.Items.Insert(ixd, StrCta)
                    ixd = ixd + 1
                Case 7
                    StrCta = DSetCta.Tables("CatCta").Rows(idxCia).Item("CG_CodigoCta")
                    CodC.Items.Insert(ixd, StrCta)
                    ixd = ixd + 1
            End Select
        Next
        CodC.SelectedIndex = 1

    End Sub

    Private Sub CodC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodC.SelectedIndexChanged
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMayor - Libro de Mayor                                                                                                      '   
        ' Sub: CodC_SelectedIndexChanged  - Procesa la Cuenta Contable seleccionada                                                              '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim ixdc As Integer
        Dim CuentaC As String

        idxCta = CodC.SelectedIndex
        MessageT.Text = ""

        DSetCta.Clear()
        cmdSQLCta = "SELECT * FROM MRS_CatCta WHERE CG_CodigoCta = '" & CodC.Text & "'"
        DAdpCta = New OdbcDataAdapter(cmdSQLCta, MRSDBcon)
        DAdpCta.Fill(DSetCta, "CatCta")

        'Datos de la Cuenta Contable
        DesC.Text = DSetCta.Tables("CatCta").Rows(0).Item("CG_DescCta")
        Select Case CurrMth - 1
            Case 0
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo12")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 1
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo01")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 2
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo02")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 3
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo03")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 4
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo04")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 5
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo05")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 6
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo06")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 7
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo07")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 8
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo08")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 9
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo09")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 10
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo10")).ToString("#,##0.00;(#,##0.00);0.00")
            Case 11
                SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo11")).ToString("#,##0.00;(#,##0.00);0.00")
        End Select

        Dim TCuenta As String

        TCuenta = DSetCta.Tables("CatCta").Rows(0).Item("CG_TipoCta")
        Select Case TCuenta
            Case "G"
                MG.Checked = True
                MS.Checked = False
                MC.Checked = False
                SC.Checked = False
            Case "MS"
                MG.Checked = True
                MS.Checked = True
                MC.Checked = False
                SC.Checked = False
            Case "MC"
                MG.Checked = True
                MS.Checked = False
                MC.Checked = True
                SC.Checked = False
            Case "SC"
                MG.Checked = False
                MS.Checked = False
                MC.Checked = False
                SC.Checked = True
        End Select

        wrkSdoC = CDbl(SdoAnt.Text)

        If CDbl(SdoAnt.Text) >= 0 Then
            SdoAnt.ForeColor = Color.SlateBlue
        Else
            SdoAnt.ForeColor = Color.Red
        End If

        TitMayor.Text = "Movimientos Contables de la Cuenta: " & CodC.Text & " - " & DesC.Text & " Mes: " & ProcMth.Text & " al: " & CStr(FHoy)
        DSetMov.Clear()

        MayorDG.DataMember = ""
        MayorDG.Refresh()

        'Movimientos de la Cuenta Seleccionada (del Mes Actual)
        Select Case Len(Trim(CodC.Text))
            Case 3
                cmdSQLMov = "SELECT * FROM MRS_CGPMov WHERE RPM_MayorA ='" & CodC.Text & "' and MONTH(RPM_FechaT) = " & CurrMth & " ORDER BY RPM_FechaT"
            Case 7
                cmdSQLMov = "SELECT * FROM MRS_CGPMov WHERE RPM_CtaCble ='" & CodC.Text & "' and MONTH(RPM_FechaT) = " & CurrMth & " ORDER BY RPM_FechaT"
        End Select
        DAdpMov = New OdbcDataAdapter(cmdSQLMov, MRSDBcon)
        DAdpMov.Fill(DSetMov, "MovCta")
        NCtas = DSetMov.Tables(0).Rows.Count

        DSetWA.Clear()

        DelWorkA()

        cmdSQLWA = "SELECT * FROM MRS_WorkMG"
        DAdpWA = New OdbcDataAdapter(cmdSQLWA, MRSDBcon)
        DAdpWA.Fill(DSetWA, "Mayor")

        MayorDG.DataSource = DSetWA.Tables("Mayor")
        MayorDG.Refresh()

        Select Case NCtas
            Case 0
                MessageT.Text = "No existen Movimientos para la Cuenta: " & CodC.Text & " - " & DesC.Text
            Case Else
                For ixdc = 0 To NCtas - 1
                    CuentaC = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_CtaCble")
                    DSetCta.Clear()
                    cmdSQLCta = "SELECT * FROM MRS_CatCta WHERE CG_CodigoCta = '" & CuentaC & "'"
                    DAdpCta = New OdbcDataAdapter(cmdSQLCta, MRSDBcon)
                    DAdpCta.Fill(DSetCta, "CatCta")

                    wrkCCta = DSetCta.Tables("CatCta").Rows(0).Item("CG_CodigoCta")
                    wrkDCta = DSetCta.Tables("CatCta").Rows(0).Item("CG_DescCta")
                    wrkDate = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_FechaT")
                    wrkComp = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_NAsiento")
                    wrkDesA = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_DescAs")
                    Select Case DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_TipoAs")
                        Case "D"
                            wrkDebe = CDbl(DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_MtoTr"))
                            wrkHber = 0
                        Case "H"
                            wrkHber = CDbl(DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_MtoTr"))
                            wrkDebe = 0
                    End Select
                    wrkSdoC = wrkSdoC + wrkDebe - wrkHber
                    Workarea()
                Next
        End Select

        DSetWA.Clear()

        Dim nMov As Integer = 0
        cmdSQLWA = "SELECT * FROM MRS_WorkMG ORDER BY WRK_Id, WRK_Fecha"
        DAdpWA = New OdbcDataAdapter(cmdSQLWA, MRSDBcon)
        DAdpWA.Fill(DSetWA, "Mayor")
        nMov = DSetWA.Tables(0).Rows.Count

        If nMov = 0 Then
            cmdSQLWA = "SELECT * FROM MRS_WorkMG ORDER BY WRK_Id, WRK_Fecha"
            DAdpWA = New OdbcDataAdapter(cmdSQLWA, MRSDBcon)
            DAdpWA.Fill(DSetWA, "Mayor")
        End If
        MayorDG.DataSource = DSetWA.Tables("Mayor")
        MayorDG.Refresh()

        SdoAct.Text = wrkSdoC.ToString("#,##0.00;(#,##0.00);0.00")
        If wrkSdoC >= 0 Then
            SdoAct.ForeColor = Color.SlateBlue
        Else
            SdoAct.ForeColor = Color.Red
        End If
    End Sub

    Function MesString(ByVal CurrMth) As String
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMayor - Libro de Mayor                                                                                                      '   
        ' Function MesString  - Obtiene el nombre del mes desde el valor numerico                                                                '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim mString As String

        mString = ""
        Select Case CurrMth
            Case 1
                mString = "Enero"
            Case 2
                mString = "Febrero"
            Case 3
                mString = "Marzo"
            Case 4
                mString = "Abril"
            Case 5
                mString = "Mayo"
            Case 6
                mString = "Junio"
            Case 7
                mString = "Julio"
            Case 8
                mString = "Agosto"
            Case 9
                mString = "Septiembre"
            Case 10
                mString = "Octubre"
            Case 11
                mString = "Noviembre"
            Case 12
                mString = "Diciembre"
        End Select

        MesString = mString
    End Function

    Function MesNumber(ByVal CMthStr) As Integer
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMayor - Libro de Mayor                                                                                                      '   
        ' Function MesNumber  - Obtiene el numero de mes desde el valor alfabetico                                                               '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim mInt As Integer

        mInt = 0
        Select Case CMthStr
            Case "Enero"
                mInt = 1
            Case "Febrero"
                mInt = 2
            Case "Marzo"
                mInt = 3
            Case "Abril"
                mInt = 4
            Case "Mayo"
                mInt = 5
            Case "Junio"
                mInt = 6
            Case "Julio"
                mInt = 7
            Case "Agosto"
                mInt = 8
            Case "Septiembre"
                mInt = 9
            Case "Octubre"
                mInt = 10
            Case "Noviembre"
                mInt = 11
            Case "Diciembre"
                mInt = 12
        End Select

        MesNumber = mInt
    End Function

    Private Sub ProcMth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcMth.SelectedIndexChanged
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMayor - Libro de Mayor                                                                                                      '   
        ' Sub: ProcMth_SelectedIndexChanged  - Seleccion del mes a Procesar                                                                      '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim ixdc As Integer
        Dim CuentaC As String

        If fTime = False Then
            CurrMth = MesNumber(ProcMth.Text)
            MonthN.Text = ProcMth.Text
            MessageT.Text = ""

            idxCta = CodC.SelectedIndex

            DSetCta.Clear()
            cmdSQLCta = "SELECT * FROM MRS_CatCta WHERE CG_CodigoCta = '" & CodC.Text & "'"
            DAdpCta = New OdbcDataAdapter(cmdSQLCta, MRSDBcon)
            DAdpCta.Fill(DSetCta, "CatCta")

            'Datos de la Cuenta Contable
            DesC.Text = DSetCta.Tables("CatCta").Rows(0).Item("CG_DescCta")
            Select Case CurrMth - 1
                Case 0
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo12")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 1
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo01")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 2
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo02")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 3
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo03")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 4
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo04")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 5
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo05")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 6
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo06")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 7
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo07")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 8
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo08")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 9
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo09")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 10
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo10")).ToString("#,##0.00;(#,##0.00);0.00")
                Case 11
                    SdoAnt.Text = CDbl(DSetCta.Tables("CatCta").Rows(0).Item("CG_Sdo11")).ToString("#,##0.00;(#,##0.00);0.00")
            End Select

            Dim TCuenta As String

            TCuenta = DSetCta.Tables("CatCta").Rows(0).Item("CG_TipoCta")
            Select Case TCuenta
                Case "G"
                    MG.Checked = True
                    MS.Checked = False
                    MC.Checked = False
                    SC.Checked = False
                Case "MS"
                    MG.Checked = True
                    MS.Checked = True
                    MC.Checked = False
                    SC.Checked = False
                Case "MC"
                    MG.Checked = True
                    MS.Checked = False
                    MC.Checked = True
                    SC.Checked = False
                Case "SC"
                    MG.Checked = False
                    MS.Checked = False
                    MC.Checked = False
                    SC.Checked = True
            End Select

            wrkSdoC = CDbl(SdoAnt.Text)

            If CDbl(SdoAnt.Text) >= 0 Then
                SdoAnt.ForeColor = Color.SlateBlue
            Else
                SdoAnt.ForeColor = Color.Red
            End If

            TitMayor.Text = "Movimientos Contables de la Cuenta: " & CodC.Text & " - " & DesC.Text & " Mes: " & ProcMth.Text & " al: " & CStr(FHoy)
            DSetMov.Clear()

            MayorDG.DataMember = ""
            MayorDG.Refresh()

            'Movimientos de la Cuenta Seleccionada (del Mes Actual)
            Select Case Len(Trim(CodC.Text))
                Case 3
                    cmdSQLMov = "SELECT * FROM MRS_CGPMov WHERE RPM_MayorA ='" & CodC.Text & "' and MONTH(RPM_FechaT) = " & CurrMth & " ORDER BY RPM_FechaT"
                Case 7
                    cmdSQLMov = "SELECT * FROM MRS_CGPMov WHERE RPM_CtaCble ='" & CodC.Text & "' and MONTH(RPM_FechaT) = " & CurrMth & " ORDER BY RPM_FechaT"
            End Select
            DAdpMov = New OdbcDataAdapter(cmdSQLMov, MRSDBcon)
            DAdpMov.Fill(DSetMov, "MovCta")
            NCtas = DSetMov.Tables(0).Rows.Count

            DSetWA.Clear()

            DelWorkA()

            cmdSQLWA = "SELECT * FROM MRS_WorkMG"
            DAdpWA = New OdbcDataAdapter(cmdSQLWA, MRSDBcon)
            DAdpWA.Fill(DSetWA, "Mayor")

            MayorDG.DataSource = DSetWA.Tables("Mayor")
            MayorDG.Refresh()

            Select Case NCtas
                Case 0
                    MessageT.Text = "No existen Movimientos para la Cuenta: " & CodC.Text & " - " & DesC.Text
                Case Else
                    For ixdc = 0 To NCtas - 1
                        CuentaC = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_CtaCble")
                        DSetCta.Clear()
                        cmdSQLCta = "SELECT * FROM MRS_CatCta WHERE CG_CodigoCta = '" & CuentaC & "'"
                        DAdpCta = New OdbcDataAdapter(cmdSQLCta, MRSDBcon)
                        DAdpCta.Fill(DSetCta, "CatCta")

                        wrkCCta = DSetCta.Tables("CatCta").Rows(0).Item("CG_CodigoCta")
                        wrkDCta = DSetCta.Tables("CatCta").Rows(0).Item("CG_DescCta")
                        wrkDate = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_FechaT")
                        wrkComp = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_NAsiento")
                        wrkDesA = DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_DescAs")
                        Select Case DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_TipoAs")
                            Case "D"
                                wrkDebe = CDbl(DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_MtoTr"))
                                wrkHber = 0
                            Case "H"
                                wrkHber = CDbl(DSetMov.Tables("MovCta").Rows(ixdc).Item("RPM_MtoTr"))
                                wrkDebe = 0
                        End Select
                        wrkSdoC = wrkSdoC + wrkDebe - wrkHber
                        Workarea()
                    Next
            End Select

            DSetWA.Clear()

            Dim nMov As Integer = 0
            cmdSQLWA = "SELECT * FROM MRS_WorkMG ORDER BY WRK_Id, WRK_Fecha"
            DAdpWA = New OdbcDataAdapter(cmdSQLWA, MRSDBcon)
            DAdpWA.Fill(DSetWA, "Mayor")
            nMov = DSetWA.Tables(0).Rows.Count

            If nMov = 0 Then
                cmdSQLWA = "SELECT * FROM MRS_WorkMG ORDER BY WRK_Id, WRK_Fecha"
                DAdpWA = New OdbcDataAdapter(cmdSQLWA, MRSDBcon)
                DAdpWA.Fill(DSetWA, "Mayor")
            End If
            MayorDG.DataSource = DSetWA.Tables("Mayor")
            MayorDG.Refresh()

            SdoAct.Text = wrkSdoC.ToString("#,##0.00;(#,##0.00);0.00")
            If wrkSdoC >= 0 Then
                SdoAct.ForeColor = Color.SlateBlue
            Else
                SdoAct.ForeColor = Color.Red
            End If
        Else
            fTime = False
        End If

    End Sub

    Function Workarea() As Boolean
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMayor - Libro de Mayor                                                                                                      '   
        ' Function Workarea  - Genera el  Dataset de trabajo de Mayor General de una cuenta                                                      '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'

        'Definicion del comando SQL de Insercion de Datos (INSERT)
        Dim ConnSQLTF As New OdbcConnection
        Dim iSQLLog As String
        Dim iresult As Integer

        ConnSQLTF.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect

        iSQLLog = "INSERT INTO MRS_WorkMG" & _
         "(WRK_Fecha, WRK_CodCta, WRK_DesCta, WRK_Compr, WRK_DesAs, WRK_Debe, WRK_Haber, WRK_Saldo)" & _
         " VALUES (?, ?, ?, ?, ?, ?, ?, ?) "

        Dim SQLCmd As New OdbcCommand(iSQLLog, ConnSQLTF)

        'Parametros del comando SQL --> Mayor General Cuentas
        'Parametros del Mayor General
        Dim WKFM As New OdbcParameter("WKFM", OdbcType.Date)                       'Fecha Movimiento
        Dim WKCC As New OdbcParameter("WKCC", OdbcType.VarChar, 255)               'Codigo Cuenta
        Dim WKDC As New OdbcParameter("WKDC", OdbcType.VarChar, 255)               'Descr Cuenta
        Dim WKNC As New OdbcParameter("WKNC", OdbcType.VarChar, 255)               'Comprobante
        Dim WKDA As New OdbcParameter("WKDA", OdbcType.VarChar, 255)               'Descr. Asiento
        Dim WKDB As New OdbcParameter("WKDB", OdbcType.Double)                     'Debe
        Dim WKHB As New OdbcParameter("WKHB", OdbcType.Double)                     'Haber
        Dim WKSD As New OdbcParameter("WKSD", OdbcType.Double)                     'Saldo Cuenta

        'Parametros de la Tabla: MRS_WorkMG
        'Fecha Mov.
        WKFM.SourceColumn = "WRK_Fecha"
        SQLCmd.Parameters.Add(WKFM)
        SQLCmd.Parameters("WKFM").Value = CDate(wrkDate)

        'Codigo Cta.
        WKCC.SourceColumn = "WRK_CodCta"
        SQLCmd.Parameters.Add(WKCC)
        SQLCmd.Parameters("WKCC").Value = wrkCCta

        'Descripcion Cta.
        WKDC.SourceColumn = "WRK_DesCta"
        SQLCmd.Parameters.Add(WKDC)
        SQLCmd.Parameters("WKDC").Value = wrkDCta

        'Comprobante
        WKNC.SourceColumn = "WRK_Compr"
        SQLCmd.Parameters.Add(WKNC)
        SQLCmd.Parameters("WKNC").Value = wrkComp

        'Desc. Asiento
        WKDA.SourceColumn = "WRK_DesAs"
        SQLCmd.Parameters.Add(WKDA)
        SQLCmd.Parameters("WKDA").Value = wrkDesA

        'Debe
        WKDB.SourceColumn = "WRK_Debe"
        SQLCmd.Parameters.Add(WKDB)
        SQLCmd.Parameters("WKDB").Value = CDbl(wrkDebe)

        'Haber
        WKHB.SourceColumn = "WRK_Fecha"
        SQLCmd.Parameters.Add(WKHB)
        SQLCmd.Parameters("WKHB").Value = CDbl(wrkHber)

        'Saldo
        WKSD.SourceColumn = "WRK_Saldo"
        SQLCmd.Parameters.Add(WKSD)
        SQLCmd.Parameters("WKSD").Value = CDbl(wrkSdoC)

        ConnSQLTF.Open()
        iresult = SQLCmd.ExecuteNonQuery
        ConnSQLTF.Close()

        Workarea = True
    End Function

    Function DelWorkA() As Boolean
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMayor - Libro de Mayor                                                                                                      '   
        ' Function DelWorkA  - Borra el Dataset de trabajo de Mayor General de una cuenta                                                        '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim ConnSQLTF As New OdbcConnection
        Dim iSQLDel As String
        Dim iresult As Integer

        ConnSQLTF.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect

        iSQLDel = "DELETE FROM MRS_WorkMG"
        Dim SQLCmdD As New OdbcCommand(iSQLDel, ConnSQLTF)

        ConnSQLTF.Open()
        iresult = SQLCmdD.ExecuteNonQuery
        ConnSQLTF.Close()

        DelWorkA = True
    End Function
End Class