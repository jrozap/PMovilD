'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMDiario - Libro de Mayor General (Cont. PM)     *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMDiario       | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMDiario
    'Variables Publicas Modulo: DPMDiario
    Public StrCta As String
    Public NCtas As Integer
    Public FHoy As Date
    Public ThisMoment As Date
    Public indice As Integer
    Public fTime As Boolean
    Public idxCta As Integer
    Public CurrMth As Integer
    Public YearC As String
    Public NRec As Integer

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

    Private Sub DPMDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMDiario - Libro Diario PM                                                                                                    '   
        ' Sub: DPMDiario_Load  - Carga el formato DPMDiario                                                                                      '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim ixd As Integer = 0

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

        LDif.Visible = False
        DifComp.Visible = False

        FHoy = Today
        ThisMoment = Now
        TodayD.Text = FHoy

        CurrMth = CInt(Mid(CStr(FHoy), 4, 2))
        YearC = Mid(CStr(FHoy), 7, 4)
        ProcMth.Text = FHoy

        'Carga Inicial de Movimientos Contables
        cmdSQLMov = "SELECT * FROM MRS_CGPMov WHERE MONTH(RPM_FechaT) = " & CurrMth & " ORDER BY RPM_NAsiento"
        DAdpMov = New OdbcDataAdapter(cmdSQLMov, MRSDBcon)
        DAdpMov.Fill(DSetMov, "MovCta")
        NRec = DSetMov.Tables("MovCta").Rows.Count

        Dim ind As Integer = 0
        Dim CmpStr As String
        CmpStr = ""

        'Se limpia el area del Combobox de Comprobantes Contables
        If CSelect.Items.Count <> 0 Then
            CSelect.Items.Clear()
            CSelect.Refresh()
        End If

        'Combobox de Comprobantes Contables
        Select Case NRec
            Case 0
                MessageT.Text = "No existen comprobantes para el mes de: " & ProcMth.Text & " / " & YearC
            Case Else
                For idxCta = 0 To NRec - 1
                    If CmpStr <> DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_NAsiento") Then
                        CmpStr = DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_NAsiento")
                        CSelect.Items.Insert(ind, CmpStr)
                        ind = ind + 1
                    End If
                Next
        End Select

        CSelect.SelectedIndex = 0
    End Sub

    Private Sub ProcMth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcMth.ValueChanged
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMDiario          - Libro Diario PM                                                                                           '   
        ' Sub: ProcMth_ValueChanged  - Selecciona el mes de proceso                                                                              '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'

        CurrMth = Month(ProcMth.Value)

        'Se eliminan los movimientos contables previos del DataSet
        If fTime = True Then
            fTime = False
        Else
            If DSetMov.Tables(0).Rows.Count <> 0 Then
                DSetMov.Clear()
            End If
        End If

        'Carga de Movimientos Contables del Mes de proceso
        cmdSQLMov = "SELECT * FROM MRS_CGPMov WHERE MONTH(RPM_FechaT) = " & CurrMth & " ORDER BY RPM_NAsiento"
        DAdpMov = New OdbcDataAdapter(cmdSQLMov, MRSDBcon)
        DAdpMov.Fill(DSetMov, "MovCta")
        NRec = DSetMov.Tables("MovCta").Rows.Count

        Dim ind As Integer = 0
        Dim CmpStr As String
        CmpStr = ""

        'Se limpia el area del Combobox de Comprobantes Contables
        If CSelect.Items.Count <> 0 Then
            CSelect.Items.Clear()
            CSelect.Refresh()
        End If

        'Combobox de Comprobantes Contables (Mes a Procesar)
        Select Case NRec
            Case 0
                MessageT.Text = "No existen comprobantes para el mes de: " & ProcMth.Text & " / " & YearC
            Case Else
                For idxCta = 0 To NRec - 1
                    If CmpStr <> DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_NAsiento") Then
                        CmpStr = DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_NAsiento")
                        CSelect.Items.Insert(ind, CmpStr)
                        ind = ind + 1
                    End If
                Next
        End Select

        CSelect.SelectedIndex = 0
    End Sub

    Private Sub CSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSelect.SelectedIndexChanged
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMDiario                  - Libro Diario PM                                                                                   '   
        ' Sub: CSelect_SelectedIndexChanged  - Seleccion Comprobante a Consultar                                                                 '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim TDeb As Double = 0
        Dim THab As Double = 0
        Dim DifC As Double = 0
        Dim asNum As Integer = 0

        asNum = CSelect.SelectedIndex
        CompN.Text = CSelect.Text

        'Se eliminan los movimientos contables previos del DataSet
        If DSetMov.Tables(0).Rows.Count <> 0 Then
            DSetMov.Clear()
        End If

        'Carga de Movimientos Contables del Comprobante seleccionado
        cmdSQLMov = "SELECT * FROM MRS_CGPMov WHERE RPM_NAsiento = '" & CSelect.Text & "' ORDER BY RPM_CtaCble, RPM_FechaT"
        DAdpMov = New OdbcDataAdapter(cmdSQLMov, MRSDBcon)
        DAdpMov.Fill(DSetMov, "MovCta")
        NRec = DSetMov.Tables(0).Rows.Count

        DGDiario.Rows.Clear()
        DGDiario.Refresh()

        'Se muestran los datos del Comprobante Contable
        For idxCta = 0 To NRec - 1
            DGDiario.Rows.Add()
            DGDiario.Item(0, idxCta).Value = DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_FechaT")
            DGDiario.Item(1, idxCta).Value = DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_CtaCble")
            DGDiario.Item(2, idxCta).Value = DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_DescAs")
            Select Case DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_TipoAs")
                Case "D"
                    DGDiario.Item(3, idxCta).Value = DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_MtoTr")
                    TDeb = TDeb + CDbl(DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_MtoTr"))
                Case "H"
                    DGDiario.Item(4, idxCta).Value = DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_MtoTr")
                    THab = THab + CDbl(DSetMov.Tables("MovCta").Rows(idxCta).Item("RPM_MtoTr"))
            End Select
            DifC = TDeb - THab
            TDebe.ForeColor = Color.DarkBlue
            TDebe.Text = TDeb.ToString("#,##0.00;(#,##0.00);0.00")
            THaber.ForeColor = Color.Red
            THaber.Text = THab.ToString("#,##0.00;(#,##0.00);0.00")

            Select Case DifC
                Case 0
                    LDif.Visible = False
                    DifComp.Visible = False
                Case Is < 0
                    LDif.Visible = True
                    DifComp.Visible = True
                    DifComp.ForeColor = Color.Red
                    DifComp.Text = DifC.ToString("#,##0.00;(#,##0.00);0.00")
                Case Is > 0
                    LDif.Visible = True
                    DifComp.Visible = True
                    DifComp.ForeColor = Color.DarkBlue
                    DifComp.Text = DifC.ToString("#,##0.00;(#,##0.00);0.00")
            End Select
        Next
    End Sub
End Class