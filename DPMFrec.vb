'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMFrec - Seleccion de beneficiarios frecuentes   *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMFrec         | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMFrec

    'Variables Publicas del modulo DPMFrec
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
    Public nRec As Integer
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
    Public Prov As String
    Public DEmp As String
    Public GGen As String
    Public caMov As String
    public NuMov As String

    'Parametros Dataset
    Public MRSDBcon As New OdbcConnection
    Public DBProvider As String
    Public DBSource As String
    Public DBPath As String
    Public DBName As String

    'Variables para Datos Beneficiarios Frecuentes (Medios de Pago)
    Public DSetFrc As New DataSet
    Public DAdpFrc As OdbcDataAdapter
    Public cmdSQLFrc As String

    'Variables para Datos Bancos (Medios de Pago)
    Public DSetBnk As New DataSet
    Public DAdpBnk As OdbcDataAdapter
    Public cmdSQLBnk As String

    Private Sub DPMFrec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMFrec        - Listado de Benficiarios Pago Movil                                      '   
        ' Function DPMFrec_Load  - Carga del formato DFMFrec                                               '
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

        'Data de Bancos
        cmdSQLBnk = "SELECT * FROM MRS_ISOBnk"
        DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
        DAdpBnk.Fill(DSetBnk, "Bancos")

        'Data de Beneficiarios Frecuentes
        cmdSQLFrc = "SELECT * FROM MRS_Frecuentes ORDER BY FRE_CustNme"
        DAdpFrc = New OdbcDataAdapter(cmdSQLFrc, MRSDBcon)
        DAdpFrc.Fill(DSetFrc, "BFrec")
        nRec = DSetFrc.Tables("BFrec").Rows.Count

        BFrecDG.DataSource = DSetFrc.Tables("BFrec")
        BFrecDG.Refresh()

        For idx = 0 To nRec - 1
            caMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustAC")
            NuMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustPh")
            BFrecDG.Item(2, idx).Value = caMov & NuMov
        Next

        Select Case DPMPagoM.TTrans
            Case "PMP"
                ProvRB.Checked = True
            Case "PME"
                EmpRB.Checked = True
            Case "PMD"
                AllRB.Checked = True
            Case "PMG"
                ProvRB.Checked = True
        End Select
    End Sub

    Private Sub AllRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllRB.CheckedChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMFrec                - Listado de Benficiarios Pago Movil                              '   
        ' Function AllRB_CheckedChanged  - Muestra todos los Beneficiarios PM                              '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        DSetFrc.Clear()
        BFrecDG.DataSource = Nothing
        BFrecDG.Refresh()

        'Data de Beneficiarios Frecuentes (Todos los Beneficiarios)
        cmdSQLFrc = "SELECT * FROM MRS_Frecuentes ORDER BY FRE_CustNme"
        DAdpFrc = New OdbcDataAdapter(cmdSQLFrc, MRSDBcon)
        DAdpFrc.Fill(DSetFrc, "BFrec")
        nRec = DSetFrc.Tables("BFrec").Rows.Count

        BFrecDG.DataSource = DSetFrc.Tables("BFrec")
        BFrecDG.Refresh()

        For idx = 0 To nRec - 1
            caMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustAC")
            NuMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustPh")
            BFrecDG.Item(2, idx).Value = caMov & NuMov
        Next
    End Sub

    Private Sub ProvRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProvRB.CheckedChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMFrec                 - Listado de Benficiarios Pago Movil                             '   
        ' Function ProvRB_CheckedChanged  - Selecciona la carga de proveedores para PM                     '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        Prov = "Si"
        DEmp = "No"
        GGen = "No"

        DSetFrc.Clear()
        BFrecDG.DataSource = Nothing
        BFrecDG.Refresh()

        'Data de Beneficiarios Frecuentes (Proveedores)
        cmdSQLFrc = "SELECT * FROM MRS_Frecuentes WHERE FRE_ProvC = '" & Prov & "' ORDER BY FRE_CustNme"
        DAdpFrc = New OdbcDataAdapter(cmdSQLFrc, MRSDBcon)
        DAdpFrc.Fill(DSetFrc, "BFrec")
        nRec = DSetFrc.Tables("BFrec").Rows.Count

        BFrecDG.DataSource = DSetFrc.Tables("BFrec")
        BFrecDG.Refresh()

        For idx = 0 To nRec - 1
            caMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustAC")
            NuMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustPh")
            BFrecDG.Item(2, idx).Value = caMov & NuMov
        Next
    End Sub

    Private Sub EmpRB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpRB.CheckedChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMFrec                - Listado de Benficiarios Pago Movil                              '   
        ' Function EmpRB_CheckedChanged  - Selecciona la carga de empleados para PM                        '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        Prov = "No"
        DEmp = "Si"
        GGen = "No"

        DSetFrc.Clear()
        BFrecDG.DataSource = Nothing
        BFrecDG.Refresh()

        'Data de Beneficiarios Frecuentes (Empleados)
        cmdSQLFrc = "SELECT * FROM MRS_Frecuentes WHERE FRE_Empleado = '" & DEmp & "' ORDER BY FRE_CustNme"
        DAdpFrc = New OdbcDataAdapter(cmdSQLFrc, MRSDBcon)
        DAdpFrc.Fill(DSetFrc, "BFrec")
        nRec = DSetFrc.Tables("BFrec").Rows.Count

        BFrecDG.DataSource = DSetFrc.Tables("BFrec")
        BFrecDG.Refresh()

        For idx = 0 To nRec - 1
            caMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustAC")
            NuMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustPh")
            BFrecDG.Item(2, idx).Value = caMov & NuMov
        Next
    End Sub

    Private Sub NmeSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmeSearch.TextChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMFrec                 - Listado de Benficiarios Pago Movil                          '   
        ' Function NmeSearch_TextChanged  - Busqueda por Nombre Beneficiario / Razon Social                '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        DSetFrc.Clear()
        BFrecDG.DataSource = Nothing
        BFrecDG.Refresh()

        cmdSQLFrc = "SELECT * FROM MRS_Frecuentes WHERE FRE_CustNme LIKE '%" & CStr(NmeSearch.Text) & "%' ORDER BY FRE_CustNme"
        DAdpFrc = New OdbcDataAdapter(cmdSQLFrc, MRSDBcon)
        DAdpFrc.Fill(DSetFrc, "BFrec")
        nRec = DSetFrc.Tables("BFrec").Rows.Count

        BFrecDG.DataSource = DSetFrc.Tables("BFrec")
        BFrecDG.Refresh()

        For idx = 0 To nRec - 1
            caMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustAC")
            NuMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustPh")
            BFrecDG.Item(2, idx).Value = caMov & NuMov
        Next
    End Sub

    Private Sub IDSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDSearch.TextChanged
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMFrec                - Listado de Benficiarios Pago Movil                              '   
        ' Function IDSearch_TextChanged  - Busqueda por Numero de Cedula / RIF                             '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'

        DSetFrc.Clear()
        BFrecDG.DataSource = Nothing
        BFrecDG.Refresh()

        cmdSQLFrc = "SELECT * FROM MRS_Frecuentes WHERE FRE_IDCust LIKE '%" & CStr(IDSearch.Text) & "%' ORDER BY FRE_CustNme"
        DAdpFrc = New OdbcDataAdapter(cmdSQLFrc, MRSDBcon)
        DAdpFrc.Fill(DSetFrc, "BFrec")
        nRec = DSetFrc.Tables("BFrec").Rows.Count

        BFrecDG.DataSource = DSetFrc.Tables("BFrec")
        BFrecDG.Refresh()

        For idx = 0 To nRec - 1
            caMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustAC")
            NuMov = DSetFrc.Tables("BFrec").Rows(idx).Item("FRE_CustPh")
            BFrecDG.Item(2, idx).Value = caMov & NuMov
        Next
    End Sub

    Private Sub BFrecDG_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BFrecDG.CellClick
        '--------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                               '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                               '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                    '
        '--------------------------------------------------------------------------------------------------'
        '                                                                                                  '
        ' Modulo: DPMFrec             - Listado de Benficiarios Pago Movil                                 '   
        ' Function BFrecDG_CellClick  - Procesa los datos para el Pago Movil de Frecuentes                 '
        '                                                                                                  '
        '--------------------------------------------------------------------------------------------------'
        Dim bISOCod As String

        DPMPagoM.NacId.Text = Mid(BFrecDG.Item(0, e.RowIndex).Value, 1, 1)
        Select Case Mid(BFrecDG.Item(0, e.RowIndex).Value, 1, 1)
            Case "V"
                DPMPagoM.CedID.Text = Mid(BFrecDG.Item(0, e.RowIndex).Value, 2, 8)
            Case "E"
                DPMPagoM.CedID.Text = Mid(BFrecDG.Item(0, e.RowIndex).Value, 2, 8)
            Case "J"
                DPMPagoM.CedID.Text = Mid(BFrecDG.Item(0, e.RowIndex).Value, 2, 9)
            Case "G"
                DPMPagoM.CedID.Text = Mid(BFrecDG.Item(0, e.RowIndex).Value, 2, 9)
        End Select
        DPMPagoM.CustAC.Text = Mid(BFrecDG.Item(2, e.RowIndex).Value, 1, 4)
        DPMPagoM.CustMP.Text = Mid(BFrecDG.Item(2, e.RowIndex).Value, 5, 7)
        DPMPagoM.NMobile.Text = BFrecDG.Item(2, e.RowIndex).Value
        bISOCod = BFrecDG.Item(4, e.RowIndex).Value

        DSetBnk.Clear()
        cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + bISOCod + "'"
        DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
        DAdpBnk.Fill(DSetBnk, "Bancos")
        DPMPagoM.BankISOc.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankCode")
        DPMPagoM.BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
        DPMPagoM.CodBankC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankCode")
        DPMPagoM.BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")

        Select Case bISOCod
            Case "0102"
                'Banco de Venezuela
                DPMPagoM.RBPagoM4.Checked = True
            Case "0104"
                'Venezolano de Credito
                DPMPagoM.RBPagoM13.Checked = True
            Case "0105"
                'Mercantil
                DPMPagoM.RBPagoM2.Checked = True
            Case "0108"
                'BBVA Provincial
                DPMPagoM.RBPagoM14.Checked = True
            Case "0114"
                'BanCaribe
                DPMPagoM.RBPagoM6.Checked = True
            Case "0115"
                'Banco Exterior
                DPMPagoM.RBPagoM9.Checked = True
            Case "0116"
                'B.O.D.
                DPMPagoM.RBPagoM8.Checked = True
            Case "0128"
                'Banco Caroni
                DPMPagoM.RBPagoM10.Checked = True
            Case "0134"
                'Banesco
                DPMPagoM.RBPagoM1.Checked = True
            Case "0137"
                'Sofitasa
                DPMPagoM.RBPagoM18.Checked = True
            Case "0138"
                'Banco Plaza
                DPMPagoM.RBPagoM19.Checked = True
            Case "0146"
                'Bangente - Bancaribe
                DPMPagoM.RBPagoM22.Checked = True
            Case "0149"
                'Banco Pueblo Soberano
                DPMPagoM.RBPagoM23.Checked = True
            Case "0151"
                'B.F.C.
                DPMPagoM.RBPagoM11.Checked = True
            Case "0156"
                '100% Banco
                DPMPagoM.RBPagoM16.Checked = True
            Case "0157"
                'DelSur
                DPMPagoM.RBPagoM15.Checked = True
            Case "0163"
                'Banco del Tesoro
                DPMPagoM.RBPagoM7.Checked = True
            Case "0166"
                'Banco Agricola Vzla.
                DPMPagoM.RBPagoM20.Checked = True
            Case "0168"
                'Bancrecer
                DPMPagoM.RBPagoM21.Checked = True
            Case "0169"
                'Mi Banco
                DPMPagoM.RBPagoM24.Checked = True
            Case "0171"
                'Bco. Activo
                DPMPagoM.RBPagoM17.Checked = True
            Case "0172"
                'Bancamiga
                DPMPagoM.RBPagoM5.Checked = True
            Case "0173"
                'Bco. Internacional de Desarrollo
                DPMPagoM.RBPagoM25.Checked = True
            Case "0174"
                'Banplus
                DPMPagoM.RBPagoM26.Checked = True
            Case "0175"
                'Bco. Bicentenario
                DPMPagoM.RBPagoM3.Checked = True
            Case "0177"
                'BFANB
                DPMPagoM.RBPagoM27.Checked = True
            Case "0190"
                'CitiBank
                DPMPagoM.RBPagoM28.Checked = True
            Case "0191"
                'B.N.C.
                DPMPagoM.RBPagoM12.Checked = True
        End Select
        Me.Close()
    End Sub

End Class