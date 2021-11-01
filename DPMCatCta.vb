'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMCatCta - Catalogo de Cuentas Contables         *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMCatCta       | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*
Public Class DPMCatCta

    'Variables Publicas del modulo DPMCatCta
    Public allBlank As Boolean
    Public NacIdW As String
    Public CedIdW As String
    Public CustACW As String
    Public CustMPW As String
    Public BankId As String
    Public BankIdN As String
    Public BankIdD As String
    Public TipoCta As String
    Public SQlOk As Boolean
    Public Country As String
    Public countryC As String
    Public ctryCode As String
    Public IdxMD As Integer
    Public IdxNac As Integer
    Public NacMD As String
    Public CedMD As String
    Public IdxSta As Integer
    Public IdxCty As Integer
    Public IdxCry As Integer
    Public IDFixMD As String
    Public CedIDFix As String
    Public connStr As String
    Public ConsN As Object
    Public firstT As Boolean
    Public idxCia As Integer
    Public nRecords As Integer
    Public nMD As Integer
    Public nSta As Integer
    Public nCty As Integer
    Public nCry As Integer
    Public nUnv As Integer
    Public LoadChk As Boolean
    Public StaStr As String
    Public MDStr As String
    Public SinStr As String
    Public FHoy As Date
    Public DofBMD As Date
    Public ageD As Double
    Public CageMD As Double
    Public ThisMoment As Date
    Public cCtryName As String
    Public cStateN As String
    Public cCityN As String
    Public hCtryName As String
    Public hStateN As String
    Public hCityN As String
    Public UserIDApp As String
    Public iLoad As Boolean
    Public UpdateOn As Boolean
    Public idxSQL As Integer
    Public chgNO As Boolean
    Public fldCount As Integer
    Public RIFDynE As String
    Public MontoPgo As Double
    Public CodCtaCE As String
    Public TKReq As Boolean
    Public RefRq As Boolean
    Public actDate As Date
    Public actTime As Date
    Public TipoAsiento As String
    Public TVenta As String
    Public CuentaC As String

    'Parametros Dataset
    Public MRSDBcon As New OdbcConnection
    Public DBProvider As String
    Public DBSource As String
    Public DBPath As String
    Public DBName As String

    'Variables para Catalogo de Cuentas (Pago Movil)
    Public DSetCta As New DataSet
    Public DAdpCta As OdbcDataAdapter
    Public cmdSQLCta As String

    Private Sub DPMCatCta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMCatCta    - Catalogo Cuentas PM                                                                                             '   
        ' Sub: DPMCatCta_Load  - Carga el formato de Catalogo de Cuentas                                                                         '
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

        'Data Catalogo de Cuentas Contables
        cmdSQLCta = "SELECT * FROM MRS_CatCta ORDER BY CG_CodigoCta"
        DAdpCta = New OdbcDataAdapter(cmdSQLCta, MRSDBcon)
        DAdpCta.Fill(DSetCta, "CatC")

        DGCtasC.DataSource = DSetCta.Tables("CatC")
        DGCtasC.Refresh()
    End Sub

    Private Sub DGCtasC_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGCtasC.CellClick
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMCatCta    - Catalogo Cuentas PM                                                       '   
        ' Function DGCtasC_CellClick  - Procesa los datos de Cuentas Contables                             '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        CodCtaPM.Text = DGCtasC.Item(0, e.RowIndex).Value
        DescrCta.Text = DGCtasC.Item(2, e.RowIndex).Value
        GrupoCta.Text = DGCtasC.Item(5, e.RowIndex).Value
        If (DGCtasC.Item(4, e.RowIndex).Value).Equals(DBNull.Value) Then
            MayorCta.Text = ""
        Else
            MayorCta.Text = DGCtasC.Item(4, e.RowIndex).Value
        End If
        If DGCtasC.Item(3, e.RowIndex).Value.Equals(DBNull.Value) Then
            CtaExport.Text = ""
        Else
            CtaExport.Text = DGCtasC.Item(3, e.RowIndex).Value
        End If

        Select Case GrupoCta.Text
            Case "A"
                Act.Checked = True
                Pas.Checked = False
                Cap.Checked = False
                Ing.Checked = False
                Egr.Checked = False
            Case "P"
                Act.Checked = False
                Pas.Checked = True
                Cap.Checked = False
                Ing.Checked = False
                Egr.Checked = False
            Case "C"
                Act.Checked = False
                Pas.Checked = False
                Cap.Checked = True
                Ing.Checked = False
                Egr.Checked = False
            Case "I"
                Act.Checked = False
                Pas.Checked = False
                Cap.Checked = False
                Ing.Checked = True
                Egr.Checked = False
            Case "E"
                Act.Checked = False
                Pas.Checked = False
                Cap.Checked = False
                Ing.Checked = False
                Egr.Checked = True

        End Select
        Select Case DGCtasC.Item(1, e.RowIndex).Value
            Case "G"
                MG.Checked = True
            Case "MS"
                MS.Checked = True
            Case "MC"
                MC.Checked = True
            Case "SC"
                SC.Checked = True
        End Select
    End Sub
End Class