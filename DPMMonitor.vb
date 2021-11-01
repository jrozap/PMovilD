'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMMonitor - Monitor de Pago Movil                *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMMonitor      | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMMonitor

    'Variables Publicas del modulo DPMMonitor
    Public allBlank As Boolean
    Public NacIdW As String
    Public CedIdW As String
    Public CustACW As String
    Public CustMPW As String
    Public BankId As String
    Public BankIdD As String
    Public TipoCta As String
    Public SQlOk As Boolean
    Public FHoy As Date
    Public ThisMoment As Date
    Public fldCount As Integer
    Public NRecs As Integer
    Public indexT As Integer

    'Parametros Dataset
    Public MRSDBcon As New OdbcConnection
    Public DBProvider As String
    Public DBSource As String
    Public DBPath As String
    Public DBName As String

    'Variables para Datos de Monitoreo de Bancos por Empresa
    Public DSetMon As New DataSet
    Public DAdpMon As OdbcDataAdapter
    Public cSQLMon As String

    Private Sub DPMMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMMonitor        - Monitor de Pago Movil                                                '   
        ' Function DPMMonitor_Load  - Carga del formato DPMMonitor                                         '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        'Conexion a Base de Datos
        Select Case Global.PMovilD.My.MySettings.Default.DBType
            Case "MS Access2010/19"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
            Case "MariaDB"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
            Case "PostgreSQL"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
        End Select
        MRSDBcon.Open()

        'Fecha de Proceso
        FHoy = Today
        ThisMoment = Now

        TodayD.Text = Mid(CStr(FHoy), 1, 10)

        'Data de Montos Pagados y Disponible por c/Banco
        cSQLMon = "SELECT * FROM MRS_DynamicsE ORDER BY Id"
        DAdpMon = New OdbcDataAdapter(cSQLMon, MRSDBcon)
        DAdpMon.Fill(DSetMon, "Monitor")
        NRecs = DSetMon.Tables("Monitor").Rows.Count

        If DSetMon.Tables("Monitor").Rows(0).Item("DYN_FechaU") <> FHoy Then
            DateU()
            DSetMon.Tables(0).Clear()
            cSQLMon = "SELECT * FROM MRS_DynamicsE ORDER BY Id"
            DAdpMon = New OdbcDataAdapter(cSQLMon, MRSDBcon)
            DAdpMon.Fill(DSetMon, "Monitor")
        End If

        For indexT = 0 To NRecs - 1
            PayLimits.Rows.Add()
            PayLimits.Rows(indexT).Cells(0).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_OrgName")
            PayLimits.Rows(indexT).Cells(1).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_RifNumb")
            PayLimits.Rows(indexT).Cells(2).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_BankNme")
            PayLimits.Rows(indexT).Cells(3).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_LteDPM")
            PayLimits.Rows(indexT).Cells(4).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_PagosM")
            PayLimits.Rows(indexT).Cells(5).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_RestoPM")
        Next
    End Sub

    Function DateU()
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMMonitor - Monitor  Dynamics                                                                                                 '   
        ' Function DateU  - Actualiza la Fecha de Proceso y Monto Disponible al limite maximo (1.200,00) al variar la fecha                      '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        'Definicion del comando SQL de Modificacion de Datos (UPDATE)
        Dim ConnSQLTF As New OdbcConnection With {
            .ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
        }

        'Parametros del comando SQL
        'Parametros de actualizacion de Pagos Moviles y Limite Disponible del Banco
        Dim ParmFA As New Odbc.OdbcParameter("Fec", Odbc.OdbcType.Date)
        Dim ParmPG As New Odbc.OdbcParameter("Pgo", Odbc.OdbcType.Double)
        Dim ParmDP As New Odbc.OdbcParameter("Dsp", Odbc.OdbcType.Double)

        Dim sqlupdF As String
        Dim sqlupdL As String
        Dim sqlupdD As String

        For indexT = 0 To NRecs - 1
            'Actualizar Fecha de Proceso
            sqlupdF = "UPDATE MRS_DynamicsE SET DYN_FechaU = ? WHERE Id = " + CStr(indexT)
            Dim sqlUFec As New Odbc.OdbcCommand(sqlupdF, ConnSQLTF)
            ParmFA.SourceColumn = "DYN_FechaU"
            sqlUFec.Parameters.Add(ParmFA)
            sqlUFec.Parameters("Fec").Value = CDate(FHoy)
            ConnSQLTF.Open()
            fldCount = sqlUFec.ExecuteNonQuery
            ConnSQLTF.Close()

            'Monto Total Inicial del Dia en 0,00 Bs.
            sqlupdL = "UPDATE MRS_DynamicsE SET DYN_PagosM = ? WHERE Id = " + CStr(indexT)
            Dim sqlULim As New Odbc.OdbcCommand(sqlupdL, ConnSQLTF)
            ParmPG.SourceColumn = "DYN_PagosM"
            sqlULim.Parameters.Add(ParmPG)
            sqlULim.Parameters("Pgo").Value = 0.00
            ConnSQLTF.Open()
            fldCount = sqlULim.ExecuteNonQuery
            ConnSQLTF.Close()

            'Disponible del Dia a 1.200,00 Bs.
            sqlupdD = "UPDATE MRS_DynamicsE SET DYN_RestoPM = ? WHERE Id = " + CStr(indexT)
            Dim sqlUDsp As New Odbc.OdbcCommand(sqlupdD, ConnSQLTF)
            ParmDP.SourceColumn = "DYN_RestoPM"
            sqlUDsp.Parameters.Add(ParmDP)
            sqlUDsp.Parameters("Dsp").Value = 1200.0
            ConnSQLTF.Open()
            fldCount = sqlUDsp.ExecuteNonQuery
            ConnSQLTF.Close()

            sqlUFec.Parameters.Clear()
            sqlULim.Parameters.Clear()
            sqlUDsp.Parameters.Clear()
        Next
        DateU = True
    End Function

    Private Sub UpdTime_Tick(sender As Object, e As EventArgs) Handles UpdTime.Tick
        UMonitor()
    End Sub

    Function UMonitor() As Boolean
        'Actualiza el Monitor de Pago Movil
        'Data de Montos Pagados y Disponible por c/Banco
        DSetMon.Clear()
        PayLimits.Rows.Clear()

        cSQLMon = "SELECT * FROM MRS_DynamicsE ORDER BY Id"
        DAdpMon = New OdbcDataAdapter(cSQLMon, MRSDBcon)
        DAdpMon.Fill(DSetMon, "Monitor")
        NRecs = DSetMon.Tables("Monitor").Rows.Count

        For indexT = 0 To NRecs - 1
            PayLimits.Rows.Add()
            PayLimits.Rows(indexT).Cells(0).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_OrgName")
            PayLimits.Rows(indexT).Cells(1).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_RifNumb")
            PayLimits.Rows(indexT).Cells(2).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_BankNme")
            PayLimits.Rows(indexT).Cells(3).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_LteDPM")
            PayLimits.Rows(indexT).Cells(4).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_PagosM")
            PayLimits.Rows(indexT).Cells(5).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_RestoPM")
        Next

        UMonitor = True
    End Function
End Class