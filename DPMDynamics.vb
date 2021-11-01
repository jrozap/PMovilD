'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMDynamics - Setup de Empresas Grupo Dynamics    *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMDynamics     | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMDynamics

    'Variables Publicas del modulo DPMDynamics
    Public allBlank As Boolean
    Public NacIdW As String
    Public CedIdW As String
    Public CustACW As String
    Public CustMPW As String
    Public BankId As String
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
    Public BankIdN As String
    Public CodCtaCE As String
    Public TKReq As Boolean
    Public RefRq As Boolean
    Public actDate As Date
    Public actTime As Date
    Public TipoAsiento As String
    Public TVenta As String
    Public CuentaC As String
    Public TTrans As String
    Public OrderDG As String

    'Parametros Dataset
    Public MRSDBcon As New OdbcConnection
    Public DBProvider As String
    Public DBSource As String
    Public DBPath As String
    Public DBName As String

    'Variables para Datos Empresas Dynamics (Configuracion)
    Public DSetCia As New DataSet
    Public DAdpCia As OdbcDataAdapter
    Public cmdSQLCia As String

    Private Sub DPMDynamics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMDynamics - Setup de las Empresas Grupo Dynamics                                                                             '   
        ' DPMDynamics_Load    - Carga ddel formato DPMDynamics                                                                                   '
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
        OrderDG = "Id"

        'Data de Empresas Dynamics
        cmdSQLCia = "SELECT * FROM MRS_DynamicsE ORDER BY " & OrderDG
        DAdpCia = New OdbcDataAdapter(cmdSQLCia, MRSDBcon)
        DAdpCia.Fill(DSetCia, "EmpDyn")

        DGDynamicsE.DataSource = DSetCia.Tables("EmpDyn")
        DGDynamicsE.Refresh()
    End Sub

    Private Sub DGDynamicsE_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGDynamicsE.CellClick
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMDynamics    - Setup de las Empresas Grupo Dynamics                                                                          '   
        ' DGDynamicsE_CellClick  - Escoge la Empresa a ser modificada                                                                            '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'

        EmpNme.Text = DGDynamicsE.Item(0, e.RowIndex).Value
        RIFt.Text = Mid(DGDynamicsE.Item(1, e.RowIndex).Value, 1, 1)
        RIFn.Text = Mid(DGDynamicsE.Item(1, e.RowIndex).Value, 3, 8)
        RIFv.Text = Mid(DGDynamicsE.Item(1, e.RowIndex).Value, 12, 1)
        ISOBnk.Text = DGDynamicsE.Item(4, e.RowIndex).Value
        BnkNme.Text = DGDynamicsE.Item(5, e.RowIndex).Value
        CAMovil.Text = DGDynamicsE.Item(2, e.RowIndex).Value
        NMovil.Text = DGDynamicsE.Item(3, e.RowIndex).Value
        IdxNac = CInt(DGDynamicsE.Item(6, e.RowIndex).Value)

        Select Case IdxNac
            Case 1
                LogoEmp.BackgroundImage = Global.PMovilD.My.Resources.DynamicsApp
            Case 2
                LogoEmp.BackgroundImage = Global.PMovilD.My.Resources.DDental1
            Case 3
                LogoEmp.BackgroundImage = Global.PMovilD.My.Resources.redvital1
            Case 4
                LogoEmp.BackgroundImage = Global.PMovilD.My.Resources.medifarmaV
            Case 5
                LogoEmp.BackgroundImage = Global.PMovilD.My.Resources.SANEMedServ
        End Select
    End Sub

    Private Sub NmeSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmeSearch.TextChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMDynamics             - Setup de las Empresas Grupo Dynamics Pago Movil                '   
        ' Function NmeSearch_TextChanged  - Busqueda por Nombre de Empresa                                 '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        DSetCia.Clear()
        DGDynamicsE.DataSource = Nothing
        DGDynamicsE.Refresh()

        cmdSQLCia = "SELECT * FROM MRS_DynamicsE WHERE DYN_OrgName LIKE '%" & NmeSearch.Text & "%' ORDER BY " & OrderDG
        DAdpCia = New OdbcDataAdapter(cmdSQLCia, MRSDBcon)
        DAdpCia.Fill(DSetCia, "EmpDyn")

        DGDynamicsE.DataSource = DSetCia.Tables("EmpDyn")
        DGDynamicsE.Refresh()
    End Sub

    Private Sub IDSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDSearch.TextChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMDynamics             - Setup de las Empresas Grupo Dynamics Pago Movil                '   
        ' Function IDSearch_TextChanged   - Busqueda por RIF de Empresa                                    '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        DSetCia.Clear()
        DGDynamicsE.DataSource = Nothing
        DGDynamicsE.Refresh()

        cmdSQLCia = "SELECT * FROM MRS_DynamicsE WHERE DYN_RifNumb LIKE '%" & IDSearch.Text & "%' ORDER BY " & OrderDG
        DAdpCia = New OdbcDataAdapter(cmdSQLCia, MRSDBcon)
        DAdpCia.Fill(DSetCia, "EmpDyn")

        DGDynamicsE.DataSource = DSetCia.Tables("EmpDyn")
        DGDynamicsE.Refresh()
    End Sub

    Private Sub IDOrder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDOrder.CheckedChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMDynamics              - Setup de las Empresas Grupo Dynamics Pago Movil               '   
        ' Function IDOrder_CheckedChanged  - Ordena el Grid de empresas por su Id en la tabla              '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        If IDOrder.Checked = True Then
            NmeOrder.Checked = False
            RIFOrder.Checked = False
        Else
            IDOrder.Checked = False
        End If
        OrderDG = "Id"

        DSetCia.Clear()
        DGDynamicsE.DataSource = Nothing
        DGDynamicsE.Refresh()

        cmdSQLCia = "SELECT * FROM MRS_DynamicsE ORDER BY " & OrderDG
        DAdpCia = New OdbcDataAdapter(cmdSQLCia, MRSDBcon)
        DAdpCia.Fill(DSetCia, "EmpDyn")

        DGDynamicsE.DataSource = DSetCia.Tables("EmpDyn")
        DGDynamicsE.Refresh()
    End Sub

    Private Sub NmeOrder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmeOrder.CheckedChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMDynamics              - Setup de las Empresas Grupo Dynamics Pago Movil               '   
        ' Function NmeOrder_CheckedChanged - Ordena el Grid de empresas por el nombre                      '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        If NmeOrder.Checked = True Then
            IDOrder.Checked = False
            RIFOrder.Checked = False
        Else
            NmeOrder.Checked = False
        End If
        OrderDG = "DYN_OrgName"

        DSetCia.Clear()
        DGDynamicsE.DataSource = Nothing
        DGDynamicsE.Refresh()

        cmdSQLCia = "SELECT * FROM MRS_DynamicsE ORDER BY " & OrderDG
        DAdpCia = New OdbcDataAdapter(cmdSQLCia, MRSDBcon)
        DAdpCia.Fill(DSetCia, "EmpDyn")

        DGDynamicsE.DataSource = DSetCia.Tables("EmpDyn")
        DGDynamicsE.Refresh()
    End Sub

    Private Sub RIFOrder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIFOrder.CheckedChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMDynamics              - Setup de las Empresas Grupo Dynamics Pago Movil               '   
        ' Function RIFOrder_CheckedChanged - Ordena el Grid de empresas por el RIF                         '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        If RIFOrder.Checked = True Then
            IDOrder.Checked = False
            NmeOrder.Checked = False
        Else
            RIFOrder.Checked = False
        End If
        OrderDG = "DYN_RifNumb"

        DSetCia.Clear()
        DGDynamicsE.DataSource = Nothing
        DGDynamicsE.Refresh()

        cmdSQLCia = "SELECT * FROM MRS_DynamicsE ORDER BY " & OrderDG
        DAdpCia = New OdbcDataAdapter(cmdSQLCia, MRSDBcon)
        DAdpCia.Fill(DSetCia, "EmpDyn")

        DGDynamicsE.DataSource = DSetCia.Tables("EmpDyn")
        DGDynamicsE.Refresh()
    End Sub
End Class