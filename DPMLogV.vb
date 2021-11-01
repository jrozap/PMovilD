'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMLogV - Log de Transacciones PMovilD            *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMLogV         | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMLogV
	'Variables Publicas Modulo: DPMBankL
	Public FHoy As Date
	Public ThisMoment As Date

	'Parametros Dataset
	Public MRSDBcon As New OdbcConnection
	Public DBProvider As String
	Public DBSource As String
	Public DBPath As String
	Public DBName As String

    'Dataset: LogTrans (Transacciones PM)
	Public DSetLog As New DataSet
	Public DAdpLog As OdbcDataAdapter
	Public cmdSQLLog As String

	Private Sub DPMLogV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMDiario     - Log de Transacciones PM                                                                                        '   
        ' Sub: DPMLogV_Load     - Carga el Log de Transacciones                                                                                  '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'

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

        'Data del Log de Transacciones del Sistema PMD
		cmdSQLLog = "SELECT * FROM MRS_TLog ORDER BY LG_Id"
		DAdpLog = New OdbcDataAdapter(cmdSQLLog, MRSDBcon)
		DAdpLog.Fill(DSetLog, "TLog")

		LogDPM.DataSource = DSetLog.Tables("TLog")
	End Sub
End Class