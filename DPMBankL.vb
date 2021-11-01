'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMBankL - Lista Bancos con Codigo ISO            *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMBankL        | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*
Public Class DPMBankL

	'Variables Publicas Modulo: DPMBankL
	Public FHoy As Date
	Public ThisMoment As Date

	'Parametros Dataset
	Public MRSDBcon As New OdbcConnection
	Public DBProvider As String
	Public DBSource As String
	Public DBPath As String
	Public DBName As String

	'Variables para Datos Bancos (Medios de Pago)
	Public DSetBnk As New DataSet
	Public DAdpBnk As OdbcDataAdapter
	Public cmdSQLBnk As String

	Private Sub DPMBankL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

		'Data de Codigos de Banca Electronica
		cmdSQLBnk = "SELECT * FROM MRS_ISOBnk ORDER BY Id"
		DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
		DAdpBnk.Fill(DSetBnk, "Bancos")

		CISOBnk.DataSource = DSetBnk.Tables("Bancos")
	End Sub
End Class