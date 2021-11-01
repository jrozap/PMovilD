'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMPagoM - Pago Movil de Pagos Moviles Dynamics   *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMPagoM        | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMPagoM

	'Variables Publicas del modulo DPMPagoM
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
    Public flag As Boolean
    Public FlagT As String
    Public NRecs As Integer

    'Variables de trabajo para el limite de Pago Movil (Monitor PM)
    Public LimiteD As Double
    Public PagosEf As Double
    Public Disponible As Double

    'Generacion de Numeros Factura Aleatorios
    Public numAleatorio As New Random()
    Public valorAleatorio As Integer = numAleatorio.Next(100, 999)
    Public facNum1 As Integer
    Public facNum2 As Integer
    Public facNum As String

    'Area de Generacion de Asientos Contables
    Public ACDateD As Date
    Public ACCtaCD As String
    Public ACDescD As String
    Public ACDebe As Double
    Public ACDateH As Date
    Public ACCtaCH As String
    Public ACDescH As String
    Public ACHabr As Double
    Public comisionB As Double = 0

    'Variables de construccion del SMS de Pago Movil
    Public MobilePNumber As String
	Public BankShortN As String
	Public SMSBody As String

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

    'Variables para el Log de Transacciones (Medios de Pago)
    Public DSetLog As New DataSet
    Public DAdpLog As OdbcDataAdapter
    Public cmdSQLLog As String

	'Variables para Datos Grupo Dynamics (Medios de Pago)
	Public DSetGD As New DataSet
	Public DataGD As OdbcDataAdapter
    Public cmdSQLGD As String

    'Variables para Datos de Monitoreo de Bancos por Empresa
    Public DSetMon As New DataSet
    Public DAdpMon As OdbcDataAdapter
    Public cSQLMon As String

    Private Sub EmpDynamics_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpDynamics.SelectedIndexChanged

        idxCia = EmpDynamics.SelectedIndex
		Select Case EmpDynamics.SelectedIndex
			Case 0
                DynamicsPM.Size = New System.Drawing.Size(97, 29)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.DynamicsApp
                LCompany.BackgroundImage = Global.PMovilD.My.Resources.DynamicsApp
                CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
                RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                TransDate.Text = FHoy
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                CodBankC.Text = BankIdN
                DSetBnk.Clear()
                cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
				DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
				DAdpBnk.Fill(DSetBnk, "Bancos")
				BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
				NMobile.Text = CustAC.Text + "-" + CustMP.Text
				AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
				AreaCM.ReadOnly = True
				MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
				MobileP.ReadOnly = True
				ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankIdD = ISObnk.Text
				ISObnk.ReadOnly = True
				BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankNme.ReadOnly = True
				RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
                LimiteD = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_LteDPM")
                PagosEf = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_PagosM")
                Disponible = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RestoPM")

                Select Case Disponible
                    Case 0
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case 0.01 To 0.99
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case Else
                        ClientData.Enabled = True
                        VueltoUSD.Enabled = True
                        PGGen.Enabled = True
                        PMEmp.Enabled = True
                        PProv.Enabled = True
                End Select

                Select Case ISObnk.Text
                    Case "0105"
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = True
                        CA2.Enabled = True
                        MercantilKA.Enabled = True
                        Label8.Enabled = True
                        NacIDM.Enabled = True
                        CINumber.Enabled = True
                        Label9.Enabled = True
                        CAMovil.Enabled = True
                        MovilN.Enabled = True
                    Case "0172"
                        MerLabel.Text = "Tipo Cuenta (Bancamiga):"
                        MerLabel.ForeColor = Color.Green
                        CC1.Text = "CC"
                        CC2.Text = "CA"
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = False
                        CA2.Enabled = False
                        CC1.ForeColor = Color.Green
                        CC2.ForeColor = Color.Green
                    Case "0175"
                        MercantilKA.Enabled = True
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                        MercantilKA.Text = "Clave Op. Especiales (Bicentenario)"
                        MercantilKA.ForeColor = Color.DarkRed
                        LabelTemp.ForeColor = Color.DarkRed
                        LabelTemp.Text = "Clave Op. Especiales:"
                        TempKey.ForeColor = Color.DarkRed
                    Case Else
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = False
                        CC1.Enabled = False
                        CC2.Enabled = False
                        CA1.Enabled = False
                        CA2.Enabled = False
                        MercantilKA.Enabled = False
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                End Select
            Case 1
                DynamicsPM.Size = New System.Drawing.Size(97, 22)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.DDental1
				LCompany.BackgroundImage = Global.PMovilD.My.Resources.DDental1
				CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
				RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
				TransDate.Text = FHoy
				BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				CodBankC.Text = BankIdN
				DSetBnk.Clear()
				cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
				DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
				DAdpBnk.Fill(DSetBnk, "Bancos")
				BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
				NMobile.Text = CustAC.Text + "-" + CustMP.Text
				AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
				AreaCM.ReadOnly = True
				MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
				MobileP.ReadOnly = True
				ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankIdD = ISObnk.Text
				ISObnk.ReadOnly = True
				BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankNme.ReadOnly = True
				RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
				CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
                LimiteD = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_LteDPM")
                PagosEf = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_PagosM")
                Disponible = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RestoPM")

                Select Case Disponible
                    Case 0
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case 0.01 To 0.99
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case Else
                        ClientData.Enabled = True
                        VueltoUSD.Enabled = True
                        PGGen.Enabled = True
                        PMEmp.Enabled = True
                        PProv.Enabled = True
                End Select

                Select Case ISObnk.Text
                    Case "0105"
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = True
                        CA2.Enabled = True
                        MercantilKA.Enabled = True
                        Label8.Enabled = True
                        NacIDM.Enabled = True
                        CINumber.Enabled = True
                        Label9.Enabled = True
                        CAMovil.Enabled = True
                        MovilN.Enabled = True
                    Case "0172"
                        MerLabel.Text = "Tipo Cuenta (Bancamiga):"
                        MerLabel.ForeColor = Color.Green
                        CC1.Text = "CC"
                        CC2.Text = "CA"
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = False
                        CA2.Enabled = False
                        CC1.ForeColor = Color.Green
                        CC2.ForeColor = Color.Green
                    Case "0175"
                        MercantilKA.Enabled = True
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                        MercantilKA.Text = "Clave Op. Especiales (Bicentenario)"
                        MercantilKA.ForeColor = Color.DarkRed
                        LabelTemp.ForeColor = Color.DarkRed
                        LabelTemp.Text = "Clave Op. Especiales:"
                        TempKey.ForeColor = Color.DarkRed
                    Case Else
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = False
                        CC1.Enabled = False
                        CC2.Enabled = False
                        CA1.Enabled = False
                        CA2.Enabled = False
                        MercantilKA.Enabled = False
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                End Select
            Case 2
                DynamicsPM.Size = New System.Drawing.Size(97, 25)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.redvital1
                LCompany.BackgroundImage = Global.PMovilD.My.Resources.redvital1
                CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
                RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                TransDate.Text = FHoy
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                CodBankC.Text = BankIdN
                DSetBnk.Clear()
                cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
				DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
				DAdpBnk.Fill(DSetBnk, "Bancos")
				BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
				NMobile.Text = CustAC.Text + "-" + CustMP.Text
				AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
				AreaCM.ReadOnly = True
				MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
				MobileP.ReadOnly = True
				ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankIdD = ISObnk.Text
				ISObnk.ReadOnly = True
				BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankNme.ReadOnly = True
				RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
				CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
                LimiteD = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_LteDPM")
                PagosEf = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_PagosM")
                Disponible = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RestoPM")

                Select Case Disponible
                    Case 0
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case 0.01 To 0.99
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case Else
                        ClientData.Enabled = True
                        VueltoUSD.Enabled = True
                        PGGen.Enabled = True
                        PMEmp.Enabled = True
                        PProv.Enabled = True
                End Select

                Select Case ISObnk.Text
                    Case "0105"
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = True
                        CA2.Enabled = True
                        MercantilKA.Enabled = True
                        Label8.Enabled = True
                        NacIDM.Enabled = True
                        CINumber.Enabled = True
                        Label9.Enabled = True
                        CAMovil.Enabled = True
                        MovilN.Enabled = True
                    Case "0172"
                        MerLabel.Text = "Tipo Cuenta (Bancamiga):"
                        MerLabel.ForeColor = Color.Green
                        CC1.Text = "CC"
                        CC2.Text = "CA"
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = False
                        CA2.Enabled = False
                        CC1.ForeColor = Color.Green
                        CC2.ForeColor = Color.Green
                    Case "0175"
                        MercantilKA.Enabled = True
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                        MercantilKA.Text = "Clave Op. Especiales (Bicentenario)"
                        MercantilKA.ForeColor = Color.DarkRed
                        LabelTemp.ForeColor = Color.DarkRed
                        LabelTemp.Text = "Clave Op. Especiales:"
                        TempKey.ForeColor = Color.DarkRed
                    Case Else
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = False
                        CC1.Enabled = False
                        CC2.Enabled = False
                        CA1.Enabled = False
                        CA2.Enabled = False
                        MercantilKA.Enabled = False
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                End Select
            Case 3
                DynamicsPM.Size = New System.Drawing.Size(97, 25)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.medifarmaV
				LCompany.BackgroundImage = Global.PMovilD.My.Resources.medifarmaV
				CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
				RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
				TransDate.Text = FHoy
				BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				CodBankC.Text = BankIdN
				DSetBnk.Clear()
				cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
				DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
				DAdpBnk.Fill(DSetBnk, "Bancos")
				BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
				NMobile.Text = CustAC.Text + "-" + CustMP.Text
				AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
				AreaCM.ReadOnly = True
				MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
				MobileP.ReadOnly = True
				ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankIdD = ISObnk.Text
				ISObnk.ReadOnly = True
				BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankNme.ReadOnly = True
				RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
				CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
                LimiteD = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_LteDPM")
                PagosEf = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_PagosM")
                Disponible = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RestoPM")

                Select Case Disponible
                    Case 0
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case 0.01 To 0.99
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case Else
                        ClientData.Enabled = True
                        VueltoUSD.Enabled = True
                        PGGen.Enabled = True
                        PMEmp.Enabled = True
                        PProv.Enabled = True
                End Select

                Select Case ISObnk.Text
                    Case "0105"
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = True
                        CA2.Enabled = True
                        MercantilKA.Enabled = True
                        Label8.Enabled = True
                        NacIDM.Enabled = True
                        CINumber.Enabled = True
                        Label9.Enabled = True
                        CAMovil.Enabled = True
                        MovilN.Enabled = True
                    Case "0172"
                        MerLabel.Text = "Tipo Cuenta (Bancamiga):"
                        MerLabel.ForeColor = Color.Green
                        CC1.Text = "CC"
                        CC2.Text = "CA"
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = False
                        CA2.Enabled = False
                        CC1.ForeColor = Color.Green
                        CC2.ForeColor = Color.Green
                    Case "0175"
                        MercantilKA.Enabled = True
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                        MercantilKA.Text = "Clave Op. Especiales (Bicentenario)"
                        MercantilKA.ForeColor = Color.DarkRed
                        LabelTemp.ForeColor = Color.DarkRed
                        LabelTemp.Text = "Clave Op. Especiales:"
                        TempKey.ForeColor = Color.DarkRed
                    Case Else
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = False
                        CC1.Enabled = False
                        CC2.Enabled = False
                        CA1.Enabled = False
                        CA2.Enabled = False
                        MercantilKA.Enabled = False
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                End Select
            Case 4
                DynamicsPM.Size = New System.Drawing.Size(107, 29)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.SANEMedServ
				LCompany.BackgroundImage = Global.PMovilD.My.Resources.SANEMedServ
				CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
				RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
				TransDate.Text = FHoy
				BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				CodBankC.Text = BankIdN
				DSetBnk.Clear()
				cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
				DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
				DAdpBnk.Fill(DSetBnk, "Bancos")
				BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
				NMobile.Text = CustAC.Text + "-" + CustMP.Text
				AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
				AreaCM.ReadOnly = True
				MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
				MobileP.ReadOnly = True
				ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
				BankIdD = ISObnk.Text
				ISObnk.ReadOnly = True
				BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
				BankNme.ReadOnly = True
				RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
				CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
                LimiteD = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_LteDPM")
                PagosEf = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_PagosM")
                Disponible = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RestoPM")

                Select Case Disponible
                    Case 0
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case 0.01 To 0.99
                        MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                        EmpDynamics.Items.Remove(EmpDynamics.SelectedIndex)
                        ClientData.Enabled = False
                        VueltoUSD.Enabled = False
                        PGGen.Enabled = False
                        PMEmp.Enabled = False
                        PProv.Enabled = False
                        Exit Sub
                    Case Else
                        ClientData.Enabled = True
                        VueltoUSD.Enabled = True
                        PGGen.Enabled = True
                        PMEmp.Enabled = True
                        PProv.Enabled = True
                End Select

                Select Case ISObnk.Text
                    Case "0105"
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = True
                        CA2.Enabled = True
                        MercantilKA.Enabled = True
                        Label8.Enabled = True
                        NacIDM.Enabled = True
                        CINumber.Enabled = True
                        Label9.Enabled = True
                        CAMovil.Enabled = True
                        MovilN.Enabled = True
                    Case "0172"
                        MerLabel.Text = "Tipo Cuenta (Bancamiga):"
                        MerLabel.ForeColor = Color.Green
                        CC1.Text = "CC"
                        CC2.Text = "CA"
                        MerLabel.Enabled = True
                        CC1.Enabled = True
                        CC2.Enabled = True
                        CA1.Enabled = False
                        CA2.Enabled = False
                        CC1.ForeColor = Color.Green
                        CC2.ForeColor = Color.Green
                    Case "0175"
                        MercantilKA.Enabled = True
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                        MercantilKA.Text = "Clave Op. Especiales (Bicentenario)"
                        MercantilKA.ForeColor = Color.DarkRed
                        LabelTemp.ForeColor = Color.DarkRed
                        LabelTemp.Text = "Clave Op. Especiales:"
                        TempKey.ForeColor = Color.DarkRed
                    Case Else
                        MerLabel.Text = "Tipo Cuenta (Mercantil):"
                        MerLabel.ForeColor = Color.MediumBlue
                        CC1.Text = "CC1"
                        CC2.Text = "CC2"
                        CA1.Text = "CA1"
                        CA2.Text = "CA2"
                        CC1.ForeColor = Color.MediumBlue
                        CC2.ForeColor = Color.MediumBlue
                        CA1.ForeColor = Color.MediumBlue
                        CA2.ForeColor = Color.MediumBlue
                        MerLabel.Enabled = False
                        CC1.Enabled = False
                        CC2.Enabled = False
                        CA1.Enabled = False
                        CA2.Enabled = False
                        MercantilKA.Enabled = False
                        Label8.Enabled = False
                        NacIDM.Enabled = False
                        CINumber.Enabled = False
                        Label9.Enabled = False
                        CAMovil.Enabled = False
                        MovilN.Enabled = False
                End Select
        End Select
	End Sub

	Sub SendSMS(ByVal FromNumber As String, ByVal ToNumber As String, ByVal SMS As String)
		Dim url As String = "https://rest.clicksend.com/v3/sms/send"
		Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)

		request.Method = "POST"

		Dim postData As String = "FromNumber=" & FromNumber

		postData += "&"
		postData += "ToNumber=" & ToNumber
		postData += "&"
		postData += "SMS=" & SMS

		Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

		request.ContentType = "application/json"
		request.Headers.Add("Authorization: Basic YXBpLXVzZXJuYW1lOmFwaS1wYXNzd29yZA==")					'get your new API token at https://rest.clicksend.com/
		request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
        Catch excp As WebException
            Dim msg As String = excp.Message
            MessageBox.Show("Error en conexion a Internet: " & msg)
            flag = True
        End Try

        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100, 999)
        Dim claveT1 As Integer
        Dim claveT2 As Integer
        Dim claveTelf As String
        Dim refbank1 As Integer
        Dim refbank2 As Integer
        Dim refBank As String

        If TKReq Then
            claveT1 = valorAleatorio * 2
            claveT2 = valorAleatorio * 3
            claveTelf = CStr(claveT1) + CStr(claveT2)
            TempKey.Text = claveTelf
            TKReq = False
        End If

        If RefRq Then
            refbank1 = valorAleatorio * 5
            refbank2 = valorAleatorio * 3
            refBank = CStr(refbank1) + CStr(refbank2)
            RefNum.Text = refBank
            BankRef.Text = refBank
        End If

        'Try
        'Dim dataStream As Stream = request.GetRequestStream()
        'Dim response As WebResponse = request.GetResponse()
        'dataStream = response.GetResponseStream()
        'Dim reader As New StreamReader(dataStream)
        'Dim responseFromServer As String = reader.ReadToEnd()                                               'Log This in DB, SMS's Queue failed, so that they can be sent again when console app runs
        'reader.Close()
        'dataStream.Close()
        'response.Close()
        'Catch ex As Exception
        'flag = True

        'Dim numAleatorio As New Random()
        'Dim valorAleatorio As Integer = numAleatorio.Next(100, 999)
        'Dim claveT1 As Integer
        'Dim claveT2 As Integer
        'Dim claveTelf As String
        'Dim refbank1 As Integer
        'Dim refbank2 As Integer
        'Dim refBank As String

        'If TKReq Then
        'claveT1 = valorAleatorio * 2
        'claveT2 = valorAleatorio * 3
        'claveTelf = CStr(claveT1) + CStr(claveT2)
        'TempKey.Text = claveTelf
        'TKReq = False
        'End If

        'If RefRq Then
        'refbank1 = valorAleatorio * 5
        'refbank2 = valorAleatorio * 3
        'refBank = CStr(refbank1) + CStr(refbank2)
        'RefNum.Text = refBank
        'BankRef.Text = refBank
        'End If

        'End Try

        ThisMoment = Now
    End Sub

	Private Sub DPMPagoM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        DPMMonitor.Show()

        'Data de Codigos de Banca Electronica
        cmdSQLBnk = "SELECT * FROM MRS_ISOBnk ORDER BY Id"
		DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
		DAdpBnk.Fill(DSetBnk, "Bancos")

		'ComboBox de Empresas Dynamics
		cmdSQLGD = "SELECT * FROM MRS_DynamicsE ORDER BY Id"
		DataGD = New OdbcDataAdapter(cmdSQLGD, MRSDBcon)
		DataGD.Fill(DSetGD, "Empresas")
		nSta = DSetGD.Tables(0).Rows.Count

		For idxCia = 0 To nSta - 1
			StaStr = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
			EmpDynamics.Items.Insert(idxCia, StaStr)
		Next

		RBPagoM1.Checked = True
	End Sub

	Private Sub NacId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NacId.SelectedIndexChanged
		NacIdW = NacId.Text
	End Sub

	Private Sub CustAC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustAC.SelectedIndexChanged
		CustACW = CustAC.Text
	End Sub

	Private Sub AmountPay_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AmountPay.LostFocus
		Dim val As Decimal = 0

		If Decimal.TryParse(AmountPay.Text, val) Then
			AmountPay.Text = val.ToString("N2")
		Else
			AmountPay.Text = ""
		End If
		MontoPgo = CDbl(AmountPay.Text)
		EmpDynamics.Focus()
	End Sub

	Private Sub SMSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SMSend.Click
		Dim Aidx As Integer

		RefRq = True
		MobilePNumber = AreaCM.Text + MobileP.Text
		Select Case BankIdD
			Case "0134"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + CStr(MontoPgo)
			Case "0105"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "24024"
				SMSBody = "TPAGO " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + TipoCta + " " + BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + CStr(MontoPgo) + " " + TempKey.Text
			Case "0175"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "7077"
				SMSBody = "BBDPPAGO " + BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + CStr(MontoPgo) + TempKey.Text
			Case "0102"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2661"
				SMSBody = "PAGAR " + BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)")
			Case "0172"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "26448"
				SMSBody = "MPAGO " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + TipoCta + " " + BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + CStr(MontoPgo)
			Case "0114"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "22741"
				SMSBody = "MIPAGO " + NacId.Text + CedID.Text + " " + BankISOc.Text + CDbl(AmountPay.Text).ToString("0.00;(0.00)") + " " + CustAC.Text + CustMP.Text
			Case "0163"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0116"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0115"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0128"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0151"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0191"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0104"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0108"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0157"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0156"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0171"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0137"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0138"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0166"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0168"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0146"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0149"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0169"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0173"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0174"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0177"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
			Case "0190"
				TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
				MobilePNumber = AreaCM.Text + MobileP.Text
				BankShortN = "2846"
				SMSBody = BankISOc.Text + " " + CustAC.Text + CustMP.Text + " " + NacId.Text + CedID.Text + " " + AmountPay.Text
		End Select

        SendSMS(MobilePNumber, BankShortN, SMSBody)


		LabelTemp.ForeColor = Color.MediumBlue
		LabelTemp.Text = "Clave Temporal:"
		TempKey.ForeColor = Color.MediumBlue
		MercantilKA.Text = "Clave Temporal Mercantil"
		MercantilKA.ForeColor = Color.MediumBlue
		MercantilKA.Enabled = False
		DynData.ForeColor = Color.MediumBlue
		MerLabel.Text = "Tipo Cuenta (Mercantil):"
		MerLabel.ForeColor = Color.MediumBlue
		CC1.Text = "CC1"
		CC2.Text = "CC2"
		CC1.ForeColor = Color.MediumBlue
		CC2.ForeColor = Color.MediumBlue
		MerLabel.Enabled = False
		CC1.Enabled = False
		CC2.Enabled = False
		CA1.Enabled = False
		CA2.Enabled = False

        If flag = False Then
            'Generar Asiento Contable de Pago Movil
            TabCuadre.SelectedTab = CGView
            AsientosDG.Rows.Add()
            DataContable()
            AsientosDG.Rows(Aidx).Cells(0).Value() = ACDateD
            AsientosDG.Rows(Aidx).Cells(1).Value() = ACCtaCD
            AsientosDG.Rows(Aidx).Cells(2).Value() = ACDescD
            AsientosDG.Rows(Aidx).Cells(3).Value() = ACDebe
            Aidx = Aidx + 1
            AsientosDG.Rows.Add()
            AsientosDG.Rows(Aidx).Cells(0).Value() = ACDateH
            AsientosDG.Rows(Aidx).Cells(1).Value() = ACCtaCH
            AsientosDG.Rows(Aidx).Cells(2).Value() = ACDescH
            AsientosDG.Rows(Aidx).Cells(4).Value() = ACHabr

            'Genera el Asiento de Pago Movil (Debe a Cuenta Bancaria por Ventas)
            TipoAsiento = "D"
            AsientosDGR()

            'Genera el Contrasiento de Pago Movil (Haber a Cuenta de Ingresos por Venta)
            TipoAsiento = "H"
            AsientosDGR()

            Select Case CDbl(AmountPay.Text)
                Case Is < 1
                    comisionB = 0.01
                Case Is = 1
                    comisionB = (CDbl(AmountPay.Text) * 0.3) / 100
                Case Is > 1
                    comisionB = (CDbl(AmountPay.Text) * 0.3) / 100
            End Select

            TTrans = "PMB"
            PagosEf = PagosEf + CDbl(AmountPay.Text)
            Disponible = LimiteD - PagosEf

            Aidx = Aidx + 1
            AsientosDG.Rows.Add()
            ComisionBco()
            CuentaC = ACCtaCD
            AsientosDG.Rows(Aidx).Cells(0).Value() = ACDateD
            AsientosDG.Rows(Aidx).Cells(1).Value() = ACCtaCD
            AsientosDG.Rows(Aidx).Cells(2).Value() = ACDescD
            AsientosDG.Rows(Aidx).Cells(3).Value() = ACDebe
            Aidx = Aidx + 1
            AsientosDG.Rows.Add()
            AsientosDG.Rows(Aidx).Cells(0).Value() = ACDateH
            AsientosDG.Rows(Aidx).Cells(1).Value() = ACCtaCH
            AsientosDG.Rows(Aidx).Cells(2).Value() = ACDescH
            AsientosDG.Rows(Aidx).Cells(4).Value() = ACHabr

            'Genera el Asiento de Pago Movil (Debe a Gastos de Comisiones Bancarias)
            TipoAsiento = "D"
            AsientosDGR()

            'Genera el Contrasiento de Pago Movil (Haber de la Comision Bancaria de PM)
            TipoAsiento = "H"
            AsientosDGR()

            'Actualiza el saldo de Pagos Moviles basados en el Limite Diario de Transacciones PM (Actualmente: 1.200,00 Bs.)
            Select Case Disponible
                Case 0
                    MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                    UpdateLimit()
                Case 0.01 To 0.99
                    MsgBox("Limite de Pago Movil para el Banco: " + ISObnk.Text + " / " + BankNme.Text + "ya alcanzado (1.200,00 Bs.)", MsgBoxStyle.OkOnly, "Pago Movil no Diponible")
                    UpdateLimit()
                Case Else
                    Disponible = LimiteD - PagosEf
                    UpdateLimit()
            End Select

            'Actualiza el Monitor de Pago Movil
            'Data de Montos Pagados y Disponible por c/Banco
            DSetMon.Clear()
            DPMMonitor.PayLimits.Rows.Clear()

            cSQLMon = "SELECT * FROM MRS_DynamicsE ORDER BY Id"
            DAdpMon = New OdbcDataAdapter(cSQLMon, MRSDBcon)
            DAdpMon.Fill(DSetMon, "Monitor")
            NRecs = DSetMon.Tables("Monitor").Rows.Count

            For indexT = 0 To NRecs - 1
                DPMMonitor.PayLimits.Rows.Add()
                DPMMonitor.PayLimits.Rows(indexT).Cells(0).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_OrgName")
                DPMMonitor.PayLimits.Rows(indexT).Cells(1).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_RifNumb")
                DPMMonitor.PayLimits.Rows(indexT).Cells(2).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_BankNme")
                DPMMonitor.PayLimits.Rows(indexT).Cells(3).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_LteDPM")
                DPMMonitor.PayLimits.Rows(indexT).Cells(4).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_PagosM")
                DPMMonitor.PayLimits.Rows(indexT).Cells(5).Value = DSetMon.Tables("Monitor").Rows(indexT).Item("DYN_RestoPM")
            Next

            'Entrada del Log de Transacciones
            TLogG()

            DSetLog.Clear()
            LogVDG.DataSource = Nothing
            LogVDG.Refresh()
            cmdSQLLog = "SELECT * FROM MRS_TLog ORDER BY LG_Id"
            DAdpLog = New OdbcDataAdapter(cmdSQLLog, MRSDBcon)
            DAdpLog.Fill(DSetLog, "TLogs")

            LogVDG.DataSource = DSetLog.Tables("TLogs")
            LogVDG.Refresh()
        End If
    End Sub

    Private Sub RBPagoM1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM1.CheckedChanged
        If RBPagoM1.Checked = True Then
            BankIdN = "0134"
            BankISOc.Text = "0134"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            ClientData.ForeColor = Color.Purple
            LogoPagoM.Size = New System.Drawing.Size(91, 94)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBanesco
            EtiquetaTit.Text = "Cedula Titular Cuenta (BANESCO):"
            BankId = "BAN"
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM2.CheckedChanged
        If RBPagoM2.Checked = True Then
            BankIdN = "0105"
            BankISOc.Text = "0105"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            ClientData.ForeColor = Color.MediumBlue
            LogoPagoM.Size = New System.Drawing.Size(91, 94)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.Tpago
            EtiquetaTit.Text = "Cedula Titular Cuenta (Mercantil):"
            BankId = "MER"
            RBPagoM1.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM3.CheckedChanged
        If RBPagoM3.Checked = True Then
            BankIdN = "0175"
            BankISOc.Text = "0175"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            ClientData.ForeColor = Color.DarkRed
            LogoPagoM.Size = New System.Drawing.Size(91, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBicentenario
            EtiquetaTit.Text = "Cedula Titular Cuenta (BBc):"
            BankId = "BBI"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM4.CheckedChanged
        If RBPagoM4.Checked = True Then
            BankIdN = "0102"
            BankISOc.Text = "0102"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            ClientData.ForeColor = Color.DarkRed
            LogoPagoM.Size = New System.Drawing.Size(91, 103)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.BdVPM
            EtiquetaTit.Text = "Cedula Titular Cuenta (BDV):"
            BankId = "BDV"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM5.CheckedChanged
        If RBPagoM5.Checked = True Then
            BankIdN = "0172"
            BankISOc.Text = "0172"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            ClientData.ForeColor = Color.Green
            LogoPagoM.Size = New System.Drawing.Size(91, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBancamiga1
            EtiquetaTit.Text = "Cedula Titular Cuenta (Bancamiga):"
            BankId = "BAMG"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM6.CheckedChanged
        If RBPagoM6.Checked = True Then
            BankIdN = "0114"
            BankISOc.Text = "0114"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 72)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MPBCaribe
            EtiquetaTit.Text = "Cedula Titular Cuenta (BanCaribe):"
            BankId = "BCAR"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM7.CheckedChanged
        If RBPagoM7.Checked = True Then
            BankIdN = "0163"
            BankISOc.Text = "0163"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(71, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMTesoro1
            EtiquetaTit.Text = "Cedula Titular Cuenta (Tesoro):"
            BankId = "BTRO"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM8.CheckedChanged
        If RBPagoM8.Checked = True Then
            BankIdN = "0116"
            BankISOc.Text = "0116"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(93, 103)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PExpressBOD
            EtiquetaTit.Text = "Cedula Titular Cuenta (BOD):"
            BankId = "BOD"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM9.CheckedChanged
        If RBPagoM9.Checked = True Then
            BankIdN = "0115"
            BankISOc.Text = "0115"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(93, 88)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMExterior1
            EtiquetaTit.Text = "Cedula Titular Cuenta (BExt):"
            BankId = "BEX"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM10.CheckedChanged
        If RBPagoM10.Checked = True Then
            BankIdN = "0128"
            BankISOc.Text = "0128"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMCaroni
            EtiquetaTit.Text = "Cedula Titular Cuenta (Caroni):"
            BankId = "BCNI"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM11.CheckedChanged
        If RBPagoM11.Checked = True Then
            BankIdN = "0151"
            BankISOc.Text = "0151"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 93)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.BFC2
            EtiquetaTit.Text = "Cedula Titular Cuenta (BFC):"
            BankId = "BFC"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM12.CheckedChanged
        If RBPagoM12.Checked = True Then
            BankIdN = "0191"
            BankISOc.Text = "0191"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(72, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.BNCNet
            EtiquetaTit.Text = "Cedula Titular Cuenta (BNC):"
            BankId = "BNC"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM13.CheckedChanged
        If RBPagoM13.Checked = True Then
            BankIdN = "0104"
            BankISOc.Text = "0104"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(60, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMVenC
            EtiquetaTit.Text = "Cedula Titular Cuenta (BVC):"
            BankId = "BVC"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM14.CheckedChanged
        If RBPagoM14.Checked = True Then
            BankIdN = "0108"
            BankISOc.Text = "0108"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(79, 72)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.DineroRapidoBBVA
            EtiquetaTit.Text = "Cedula Titular Cuenta (BBVA):"
            BankId = "BBVA"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM15.CheckedChanged
        If RBPagoM15.Checked = True Then
            BankIdN = "0157"
            BankISOc.Text = "0157"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 72)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PagoD2
            EtiquetaTit.Text = "Cedula Titular Cuenta (DelSUR):"
            BankId = "DELS"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM16.CheckedChanged
        If RBPagoM16.Checked = True Then
            BankIdN = "0156"
            BankISOc.Text = "0156"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(71, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PM100Bco
            EtiquetaTit.Text = "Cedula Titular Cuenta (100% Bco):"
            BankId = "100%"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM17.CheckedChanged
        If RBPagoM17.Checked = True Then
            BankIdN = "0171"
            BankISOc.Text = "0171"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(71, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBActivo
            EtiquetaTit.Text = "Cedula Titular Cuenta (BActivo):"
            BankId = "BACT"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM18.CheckedChanged
        If RBPagoM18.Checked = True Then
            BankIdN = "0137"
            BankISOc.Text = "0137"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 63)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMSofitasa
            EtiquetaTit.Text = "Cedula Titular Cuenta (Sofitasa):"
            BankId = "BSOF"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM19.CheckedChanged
        If RBPagoM19.Checked = True Then
            BankIdN = "0138"
            BankISOc.Text = "0138"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 94)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBPlaza
            EtiquetaTit.Text = "Cedula Titular Cuenta (Bco. Plaza):"
            BankId = "BPZA"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM20.CheckedChanged
        If RBPagoM20.Checked = True Then
            BankIdN = "0166"
            BankISOc.Text = "0166"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(71, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMAgricola
            EtiquetaTit.Text = "Cedula Titular Cuenta (BAV):"
            BankId = "BAV"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM21_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM21.CheckedChanged
        If RBPagoM21.Checked = True Then
            BankIdN = "0168"
            BankISOc.Text = "0168"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(71, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBcrecer
            EtiquetaTit.Text = "Cedula Titular Cuenta (Bancrecer):"
            BankId = "BCRE"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM22.CheckedChanged
        If RBPagoM22.Checked = True Then
            BankIdN = "0146"
            BankISOc.Text = "0146"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 84)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBGente
            EtiquetaTit.Text = "Cedula Titular Cuenta (Bangente):"
            BankId = "BGEN"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM23.CheckedChanged
        If RBPagoM23.Checked = True Then
            BankIdN = "0149"
            BankISOc.Text = "0149"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBicentenario
            EtiquetaTit.Text = "Cedula Titular Cuenta (BPSB):"
            BankId = "BPSB"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM24.CheckedChanged
        If RBPagoM24.Checked = True Then
            BankIdN = "0169"
            BankISOc.Text = "0169"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(60, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMMibanco
            EtiquetaTit.Text = "Cedula Titular Cuenta (MiBanco):"
            BankId = "MBCO"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM25_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM25.CheckedChanged
        If RBPagoM25.Checked = True Then
            BankIdN = "0173"
            BankISOc.Text = "0173"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(71, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBintD
            EtiquetaTit.Text = "Cedula Titular Cuenta (BID):"
            BankId = "BID"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM26.CheckedChanged
        If RBPagoM26.Checked = True Then
            BankIdN = "0174"
            BankISOc.Text = "0174"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(60, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBanPlus
            EtiquetaTit.Text = "Cedula Titular Cuenta (BPlus):"
            BankId = "BPLU"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM27.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM27_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM27.CheckedChanged
        If RBPagoM27.Checked = True Then
            BankIdN = "0177"
            BankISOc.Text = "0177"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(91, 122)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBFanB
            EtiquetaTit.Text = "Cedula Titular Cuenta (BFANB):"
            BankId = "BFAN"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM28.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub RBPagoM28_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM28.CheckedChanged
        If RBPagoM28.Checked = True Then
            BankIdN = "0190"
            BankISOc.Text = "0190"
            DSetBnk.Clear()
            cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankISOc.Text + "'"
            DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
            DAdpBnk.Fill(DSetBnk, "Bancos")
            BankNC.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
            CodBankC.Text = BankIdN
            BankCli.Text = BankNC.Text
            LogoPagoM.Size = New System.Drawing.Size(80, 72)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMCiti
            EtiquetaTit.Text = "Cedula Titular Cuenta (Citi):"
            BankId = "CITI"
            RBPagoM1.Checked = False
            RBPagoM2.Checked = False
            RBPagoM3.Checked = False
            RBPagoM4.Checked = False
            RBPagoM5.Checked = False
            RBPagoM6.Checked = False
            RBPagoM7.Checked = False
            RBPagoM8.Checked = False
            RBPagoM9.Checked = False
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
            RBPagoM14.Checked = False
            RBPagoM15.Checked = False
            RBPagoM16.Checked = False
            RBPagoM17.Checked = False
            RBPagoM18.Checked = False
            RBPagoM19.Checked = False
            RBPagoM20.Checked = False
            RBPagoM21.Checked = False
            RBPagoM22.Checked = False
            RBPagoM23.Checked = False
            RBPagoM24.Checked = False
            RBPagoM25.Checked = False
            RBPagoM26.Checked = False
            RBPagoM27.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.C2PDynamicsL3
        End If
    End Sub

    Private Sub CC1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CC1.CheckedChanged
        If CC1.Checked Then
            Select Case BankId
                Case "MER"
                    TipoCta = "CC1"
                    CC2.Checked = False
                    CC2.Enabled = False
                    CA1.Checked = False
                    CA1.Enabled = False
                    CA2.Checked = False
                    CA2.Enabled = False
                Case "BAMG"
                    TipoCta = "CC"
                    CC2.Checked = False
                    CC2.Enabled = False
                    CA1.Checked = False
                    CA1.Enabled = False
                    CA2.Checked = False
                    CA2.Enabled = False
            End Select
        Else
            Select Case BankId
                Case "MER"
                    CC2.Checked = False
                    CC2.Enabled = True
                    CA1.Checked = False
                    CA1.Enabled = True
                    CA2.Checked = False
                    CA2.Enabled = True
                Case "BAMG"
                    CC2.Checked = False
                    CC2.Enabled = True
            End Select
        End If
    End Sub

    Private Sub CC2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CC2.CheckedChanged
        If CC2.Checked Then
            Select Case BankId
                Case "MER"
                    TipoCta = "CC2"
                    CC1.Checked = False
                    CC1.Enabled = False
                    CA1.Checked = False
                    CA1.Enabled = False
                    CA2.Checked = False
                    CA2.Enabled = False
                Case "BAMG"
                    TipoCta = "CA"
                    CC1.Checked = False
                    CC1.Enabled = False
                    CA1.Checked = False
                    CA1.Enabled = False
                    CA2.Checked = False
                    CA2.Enabled = False
            End Select
        Else
            Select Case BankId
                Case "MER"
                    CC1.Checked = False
                    CC1.Enabled = True
                    CA1.Checked = False
                    CA1.Enabled = True
                    CA2.Checked = False
                    CA2.Enabled = True
                Case "BAMG"
                    CC1.Checked = False
                    CC1.Enabled = True
            End Select
        End If
    End Sub

    Private Sub CA1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CA1.CheckedChanged
        If CA1.Checked Then
            TipoCta = "CA1"
            CC1.Checked = False
            CC1.Enabled = False
            CC2.Checked = False
            CC2.Enabled = False
            CA2.Checked = False
            CA2.Enabled = False
            MerLabel.Enabled = False
        End If
    End Sub

    Private Sub CA2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CA2.CheckedChanged
        If CA2.Checked Then
            TipoCta = "CA2"
            CC1.Checked = False
            CC1.Enabled = False
            CC2.Checked = False
            CC2.Enabled = False
            CA1.Checked = False
            CA1.Enabled = False
            MerLabel.Enabled = False
        End If
    End Sub

    Private Sub TKSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TKReq = True
        MobilePNumber = CustACW + MovilN.Text
        BankShortN = "24024"
        SMSBody = "SCT"

        SendSMS(MobilePNumber, BankShortN, SMSBody)
        TKReq = False
        MercantilKA.Enabled = False
    End Sub

    Private Sub CAMovil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CustACW = CAMovil.Text
        CustAC.Text = CAMovil.Text
    End Sub

    Private Sub NacIDM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NacIdW = NacIDM.Text
        NacId.Text = NacIDM.Text
    End Sub

    Private Sub CINumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CedID.Text = CINumber.Text
    End Sub

    Private Sub MovilN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CustMP.Text = MovilN.Text
    End Sub

    Private Sub CustMP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustMP.TextChanged
        NMobile.Text = CustAC.Text + CustMP.Text
    End Sub

    Private Sub VueltoUSD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VueltoUSD.CheckedChanged
        If VueltoUSD.Checked Then
            PProv.Checked = False
            PMEmp.Checked = False
            PGGen.Checked = False
            facNum1 = valorAleatorio * 2
            facNum2 = valorAleatorio * 4
            facNum = CStr(facNum1) + CStr(facNum2)
            FactNum.Text = facNum
            TTrans = "PMD"
            CuentaC = "531-001"
            DPMFrec.Show()
        Else
            VueltoUSD.Checked = False
            FactNum.Text = ""
        End If
    End Sub

    Private Sub PProv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PProv.CheckedChanged
        VueltoUSD.Checked = False
        PMEmp.Checked = False
        PGGen.Checked = False
        TTrans = "PMP"
        CuentaC = "521-002"
        DPMFrec.Show()
    End Sub

    Private Sub PMEmp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PMEmp.CheckedChanged
        VueltoUSD.Checked = False
        PProv.Checked = False
        PGGen.Checked = False
        TTrans = "PME"
        CuentaC = "521-003"
        DPMFrec.Show()
    End Sub

    Private Sub PGGen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PGGen.CheckedChanged
        VueltoUSD.Checked = False
        PMEmp.Checked = False
        PMEmp.Checked = False
        TTrans = "PMG"
        CuentaC = "521-001"
        DPMFrec.Show()
    End Sub

    Private Sub AmountPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmountPay.TextChanged
        ACDebe = CDbl(AmountPay.Text)
        ACHabr = CDbl(AmountPay.Text)
    End Sub

    Function DataContable() As Boolean
        If VueltoUSD.Checked Then
            ACDateD = ThisMoment
            ACCtaCD = "531-001"
            ACDescD = "VUELTO EN BS - Pago Movil: " + BankCode.Text + " / " + BankName.Text + " Cliente: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Cli: " + CodBankC.Text + " / " + BankCli.Text
            ACDebe = CDbl(AmountPay.Text)
            ACDateH = ThisMoment
            ACCtaCH = CodCtaCE
            ACDescH = "VUELTO BS via Pago Movil (" + EmpDynamics.Text + "): ID Banco:" + BankCode.Text + " / " + BankName.Text + " Cliente: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Cli: " + CodBankC.Text + " / " + BankCli.Text
            ACHabr = CDbl(AmountPay.Text)
        End If
        If PProv.Checked Then
            ACDateD = ThisMoment
            ACCtaCD = "521-002"
            ACDescD = "PAGO PROVEEDORES - Pago Movil: " + BankCode.Text + " / " + BankName.Text + " Proveedor: RIF: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Prov: " + CodBankC.Text + " / " + BankCli.Text
            ACDebe = CDbl(AmountPay.Text)
            ACDateH = ThisMoment
            ACCtaCH = CodCtaCE
            ACDescH = "PAGO PROVEEDORES via Pago Movil (" + EmpDynamics.Text + "): ID Banco:" + BankCode.Text + " / " + BankName.Text + " Proveedor: RIF: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Prov: " + CodBankC.Text + " / " + BankCli.Text
            ACHabr = CDbl(AmountPay.Text)
        End If
        If PMEmp.Checked Then
            ACDateD = ThisMoment
            ACCtaCD = "521-003"
            ACDescD = "PAGO EMPLEADOS - Pago Movil: " + BankIdD + " Empleado: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Empleado: " + CodBankC.Text + " / " + BankCli.Text
            ACDebe = CDbl(AmountPay.Text)
            ACDateH = ThisMoment
            ACCtaCH = CodCtaCE
            ACDescH = "PAGOS EMPLEADOS via Pago Movil (" + EmpDynamics.Text + "): ID Banco:" + BankIdD + " Empleado: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Empleado: " + CodBankC.Text + " / " + BankCli.Text
            ACHabr = CDbl(AmountPay.Text)
        End If
        If PGGen.Checked Then
            ACDateD = ThisMoment
            ACCtaCD = "521-001"
            ACDescD = "GASTOS GENERALES - Pago Movil: " + BankCode.Text + " / " + BankName.Text + " Razon Social: RIF: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Prov: " + CodBankC.Text + " / " + BankCli.Text
            ACDebe = CDbl(AmountPay.Text)
            ACDateH = ThisMoment
            ACCtaCH = CodCtaCE
            ACDescH = "PAGO GASTOS GENERALES via Pago Movil (" + EmpDynamics.Text + "): ID Banco:" + BankCode.Text + " / " + BankName.Text + " Razon Social: RIF: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + "Banco Prov: " + CodBankC.Text + " / " + BankCli.Text
            ACHabr = CDbl(AmountPay.Text)
        End If
        DataContable = True
    End Function

    Function ComisionBco() As Boolean
        ACDateD = ThisMoment
        ACCtaCD = "521-005"
        ACDescD = "Comision Bancaria - Pago Movil: " + EmpDynamics.Text + " ID Banco:" + BankCode.Text + " / " + BankName.Text
        ACDebe = comisionB
        ACDateH = ThisMoment
        ACCtaCH = CodCtaCE
        ACDescH = "PAGO Comision Bancaria - Pago Movil " + EmpDynamics.Text + " ID Banco:" + BankCode.Text + " / " + BankName.Text
        ACHabr = comisionB
        ComisionBco = True
    End Function

    Function TLogG() As Boolean
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMPago - Pago Movil de Clientes                                                                                               '   
        ' Function TLogG  - Genera entrada al Log de Transacciones                                                                               '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'

        'Definicion del comando SQL de Insercion de Datos (INSERT)
        Dim ConnSQLTF As New OdbcConnection
        Dim iSQLLog As String
        Dim iresult As Integer

        ConnSQLTF.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect

        iSQLLog = "INSERT INTO MRS_TLog" & _
         "(LG_TransDate, LG_CiaName, LG_RIFCia, LG_CiaBank, LG_CiaMobile, LG_TransAmt, LG_CBankSN, LG_CBankID, LG_CMobile, " & _
         "LG_SMSBody, LG_SMSResp, LG_SMSTimeS, LG_UserTrans, LG_FechaTran, LG_HoraTrans)" & _
         " VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) "

        Dim SQLCmd As New OdbcCommand(iSQLLog, ConnSQLTF)

        'Parametros del comando SQL --> Log de Transacciones Financieras
        'Parametros del Log
        Dim PTDate As New OdbcParameter("PDT", OdbcType.VarChar, 255)               'Fecha Trans
        Dim PCiaN As New OdbcParameter("PCN", OdbcType.VarChar, 255)                'Nombre Empresa
        Dim PCiaR As New OdbcParameter("PCR", OdbcType.VarChar, 255)                'RIF Empresa
        Dim PCiaB As New OdbcParameter("PCB", OdbcType.VarChar, 255)                'ISO + Nombre Banco Empresa
        Dim PCiaM As New OdbcParameter("PCM", OdbcType.VarChar, 255)                'Movil Asociado (Empresa)
        Dim PMtoT As New OdbcParameter("PMT", OdbcType.VarChar, 255)                'Monto Transaccion
        Dim PCBSN As New OdbcParameter("PBS", OdbcType.VarChar, 255)                '# Movil Banco (Short Mobile)
        Dim PCBID As New OdbcParameter("PBI", OdbcType.VarChar, 255)                'ISO Bank Cliente + Nombre Banco
        Dim PCMob As New OdbcParameter("PMO", OdbcType.VarChar, 255)                'Movil Cliente
        Dim PSMSb As New OdbcParameter("PSB", OdbcType.VarChar, 255)                'SMS Body
        Dim PSMSr As New OdbcParameter("PSR", OdbcType.VarChar, 255)                'SMS Response
        Dim PSMSt As New OdbcParameter("PST", OdbcType.VarChar, 255)                'SMS Timestamp
        Dim PUsId As New OdbcParameter("PUI", OdbcType.VarChar, 255)                'User ID Transaccion
        Dim PFecT As New OdbcParameter("PFT", OdbcType.VarChar, 255)                'Fecha Transaccion
        Dim PHraT As New OdbcParameter("PHT", OdbcType.VarChar, 255)                'Hora Transaccion

        'Parametros de la Tabla: MRS_TLog
        'Fecha Trans
        PTDate.SourceColumn = "LG_TransDate"
        SQLCmd.Parameters.Add(PTDate)
        SQLCmd.Parameters("PDT").Value = CDate(FHoy)

        'Nombre Empresa
        PCiaN.SourceColumn = "LG_CiaName"
        SQLCmd.Parameters.Add(PCiaN)
        SQLCmd.Parameters("PCN").Value = EmpDynamics.Text

        'RIF Empresa
        PCiaR.SourceColumn = "LG_RIFCia"
        SQLCmd.Parameters.Add(PCiaR)
        SQLCmd.Parameters("PCR").Value = RIFDynE

        'ISO + Nombre Banco Empresa
        PCiaB.SourceColumn = "LG_CiaBank"
        SQLCmd.Parameters.Add(PCiaB)
        SQLCmd.Parameters("PCB").Value = ISObnk.Text + " - " + BankNme.Text

        'Movil Asociado (Empresa)
        PCiaM.SourceColumn = "LG_CiaMobile"
        SQLCmd.Parameters.Add(PCiaM)
        SQLCmd.Parameters("PCM").Value = AreaCM.Text + MobileP.Text

        'Monto Transaccion
        PMtoT.SourceColumn = "LG_TransAmt"
        SQLCmd.Parameters.Add(PMtoT)
        SQLCmd.Parameters("PMT").Value = CDbl(AmountPay.Text)

        '# Movil Banco (Short Mobile)
        PCBSN.SourceColumn = "LG_CBankSN"
        SQLCmd.Parameters.Add(PCBSN)
        SQLCmd.Parameters("PBS").Value = BankShortN

        'ISO Bank Cliente + Nombre Banco
        PCBID.SourceColumn = "LG_CBankID"
        SQLCmd.Parameters.Add(PCBID)
        SQLCmd.Parameters("PBI").Value = CodBankC.Text + " - " + BankCli.Text

        'Movil Cliente
        PCMob.SourceColumn = "LG_CMobile"
        SQLCmd.Parameters.Add(PCMob)
        SQLCmd.Parameters("PMO").Value = NMobile.Text

        'SMS Body
        PSMSb.SourceColumn = "LG_SMSBody"
        SQLCmd.Parameters.Add(PSMSb)
        SQLCmd.Parameters("PSB").Value = SMSBody

        'SMS Response
        PSMSr.SourceColumn = "LG_SMSResp"
        SQLCmd.Parameters.Add(PSMSr)
        SQLCmd.Parameters("PSR").Value = RefNum.Text

        'SMS Timestamp
        PSMSt.SourceColumn = "LG_SMSTimeS"
        SQLCmd.Parameters.Add(PSMSt)
        SQLCmd.Parameters("PST").Value = ThisMoment

        'User ID Transaccion
        PUsId.SourceColumn = "LG_UserTrans"
        SQLCmd.Parameters.Add(PUsId)
        SQLCmd.Parameters("PUI").Value = Global.PMovilD.My.MySettings.Default.UserID

        ThisMoment = Now
        actDate = CDate(Mid(CStr(ThisMoment), 1, 10))
        actTime = CDate(Mid(CStr(ThisMoment), 11, 11))

        'Fecha Transaccion
        PFecT.SourceColumn = "LG_FechaTran"
        SQLCmd.Parameters.Add(PFecT)
        SQLCmd.Parameters("PFT").Value = actDate

        'Hora Transaccion
        PHraT.SourceColumn = "LG_HoraTrans"
        SQLCmd.Parameters.Add(PHraT)
        SQLCmd.Parameters("PHT").Value = actTime

        ConnSQLTF.Open()
        iresult = SQLCmd.ExecuteNonQuery
        ConnSQLTF.Close()

        TLogG = True
    End Function

    Function AsientosDGR() As Boolean
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMPagoM - Pago Movil Dynamics                                                                                                 '   
        ' Function AsientosDGR  - Genera la Ristra Contable del Pago Movil                                                                       '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'

        'Definicion del comando SQL de Insercion de Datos (INSERT)
        Dim ConnSQLTF As New OdbcConnection
        Dim iSQLLog As String
        Dim iresult As Integer

        ConnSQLTF.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect

        iSQLLog = "INSERT INTO MRS_CGPMov" & _
         "(RPM_TipoTran, RPM_FechaT, RPM_Benefit, RPM_CIBenef, RPM_NMovB, RPM_ISOBankB, RPM_CiaNmeD, RPM_ISOBankD, RPM_RIFCiaD, " & _
         "RPM_MovilD, RPM_MtoTr, RPM_Factura, RPM_NRefB, RPM_CtaCble, RPM_MayorA, RPM_DescAs, RPM_NAsiento, RPM_TipoAs, RPM_UIDpm, RPM_FecReg, RPM_HraReg)" & _
         " VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) "

        Dim SQLCmd As New OdbcCommand(iSQLLog, ConnSQLTF)

        'Parametros del comando SQL --> Asiento Contable de la Ristra
        'Parametros del Asiento Contable
        Dim CGTT As New OdbcParameter("CGTT", OdbcType.VarChar, 255)               'Tipo Trans
        Dim CGFT As New OdbcParameter("CGFT", OdbcType.Date)                       'Fecha Trans
        Dim CGBN As New OdbcParameter("CGBN", OdbcType.VarChar, 255)               'Beneficiario PM
        Dim CGID As New OdbcParameter("CGID", OdbcType.VarChar, 255)               'CI / RIF Beneficiario
        Dim CGMB As New OdbcParameter("CGMB", OdbcType.VarChar, 255)               'Movil Beneficiario
        Dim CGBB As New OdbcParameter("CGBB", OdbcType.VarChar, 255)               'Cod ISO Banco Benf.
        Dim CGCD As New OdbcParameter("CGCD", OdbcType.VarChar, 255)               'Compañia - Dynamics Group
        Dim CGBD As New OdbcParameter("CGBD", OdbcType.VarChar, 255)               'ISO Banco - Dynamics
        Dim CGRD As New OdbcParameter("CGRD", OdbcType.VarChar, 255)               'RIF - Dynamics
        Dim CGMD As New OdbcParameter("CGMD", OdbcType.VarChar, 255)               'Movil Asoc. - Dynamics
        Dim CGMo As New OdbcParameter("CGMo", OdbcType.Double)                     'Monto Trans
        Dim CGFc As New OdbcParameter("CGFc", OdbcType.VarChar, 255)               'No. de Factura
        Dim CGRF As New OdbcParameter("CGRF", OdbcType.VarChar, 255)               'Referencia Bancaria (PMovil)
        Dim CGCC As New OdbcParameter("CGCC", OdbcType.VarChar, 255)               'Cuenta Contable
        Dim CGMY As New OdbcParameter("CGMY", OdbcType.VarChar, 255)               'Cuenta de Mayor Asociada
        Dim CGDA As New OdbcParameter("CGDA", OdbcType.VarChar, 255)               'Descripcion del Asiento
        Dim CGNA As New OdbcParameter("CGNA", OdbcType.VarChar, 255)               'Numero Asiento Contable
        Dim CGTA As New OdbcParameter("CGTA", OdbcType.VarChar, 255)               'Tipo de Asiento
        Dim CGUR As New OdbcParameter("CGUR", OdbcType.VarChar, 255)               'User ID Registro
        Dim CGFR As New OdbcParameter("CGFR", OdbcType.VarChar, 255)               'Fecha Registro
        Dim CGHR As New OdbcParameter("CGHR", OdbcType.VarChar, 255)               'Hora Registro

        'Parametros de la Tabla: MRS_CGPMov
        'Tipo Transaccion
        CGTT.SourceColumn = "RPM_TipoTran"
        SQLCmd.Parameters.Add(CGTT)
        SQLCmd.Parameters("CGTT").Value = TTrans

        'Fecha Transaccion
        CGFT.SourceColumn = "RPM_FechaT"
        SQLCmd.Parameters.Add(CGFT)
        SQLCmd.Parameters("CGFT").Value = CDate(ThisMoment)

        'Nombre / Razon Social Beneficiario
        CGBN.SourceColumn = "RPM_Benefit"
        SQLCmd.Parameters.Add(CGBN)
        Select Case TTrans
            Case "PME"
                SQLCmd.Parameters("CGBN").Value = "Pago Movil Empleados - " & EmpDynamics.Text & " C.I: " & NacId.Text & " - " & CedID.Text
            Case "PMP"
                SQLCmd.Parameters("CGBN").Value = "Pago Movil Proveedores - " & EmpDynamics.Text & " RIF: " & NacId.Text & " - " & CedID.Text
            Case "PMG"
                SQLCmd.Parameters("CGBN").Value = "Pago Movil Gastos Generales - " & EmpDynamics.Text & " RIF: " & NacId.Text & " - " & CedID.Text
            Case "PMB"
                SQLCmd.Parameters("CGBN").Value = "Pago Movil Comsion Bancaria - " & EmpDynamics.Text & " Banco: " & ISObnk.Text & " / " & BankNme.Text
        End Select

        'CI / RIF Beneficiario
        CGID.SourceColumn = "RPM_CIBenef"
        SQLCmd.Parameters.Add(CGID)
        SQLCmd.Parameters("CGID").Value = NacId.Text & CedID.Text

        'Movil Beneficiario
        CGMB.SourceColumn = "RPM_NMovB"
        SQLCmd.Parameters.Add(CGMB)
        SQLCmd.Parameters("CGMB").Value = CustAC.Text & CustMP.Text

        'Cod ISO Banco Benf.
        CGBB.SourceColumn = "RPM_ISOBankB"
        SQLCmd.Parameters.Add(CGBB)
        SQLCmd.Parameters("CGBB").Value = CodBankC.Text

        'Compañia - Dynamics Group
        CGCD.SourceColumn = "RPM_CiaNmeD"
        SQLCmd.Parameters.Add(CGCD)
        SQLCmd.Parameters("CGCD").Value = EmpDynamics.Text

        'ISO Banco - Dynamics
        CGBD.SourceColumn = "RPM_ISOBankD"
        SQLCmd.Parameters.Add(CGBD)
        SQLCmd.Parameters("CGBD").Value = ISObnk.Text

        'RIF - Dynamics
        CGRD.SourceColumn = "RPM_RIFCiaD"
        SQLCmd.Parameters.Add(CGRD)
        SQLCmd.Parameters("CGRD").Value = RIFEmp.Text

        'Movil Asoc. - Dynamics
        CGMD.SourceColumn = "RPM_MovilD"
        SQLCmd.Parameters.Add(CGMD)
        SQLCmd.Parameters("CGMD").Value = AreaCM.Text + MobileP.Text

        'Monto Trans
        CGMo.SourceColumn = "RPM_MtoTr"
        SQLCmd.Parameters.Add(CGMo)
        Select Case TTrans
            Case "PMB"
                SQLCmd.Parameters("CGMo").Value = comisionB
            Case Else
                SQLCmd.Parameters("CGMo").Value = CDbl(AmountPay.Text)
        End Select

        'No. de Factura
        CGFc.SourceColumn = "RPM_Factura"
        SQLCmd.Parameters.Add(CGFc)
        SQLCmd.Parameters("CGFc").Value = FactNum.Text

        'Referencia Bancaria  (PMovil - Enviada por el Banco)
        CGRF.SourceColumn = "RPM_NRefB"
        SQLCmd.Parameters.Add(CGRF)
        SQLCmd.Parameters("CGRF").Value = RefNum.Text

        'Cuenta Contable
        CGCC.SourceColumn = "RPM_CtaCble"
        SQLCmd.Parameters.Add(CGCC)
        Select Case TipoAsiento
            Case "D"
                SQLCmd.Parameters("CGCC").Value = CuentaC
            Case "H"
                SQLCmd.Parameters("CGCC").Value = CodCtaCE
        End Select

        'Cuenta de Mayor Asociada
        CGMY.SourceColumn = "RPM_MayorA"
        SQLCmd.Parameters.Add(CGMY)
        Select Case TipoAsiento
            Case "D"
                SQLCmd.Parameters("CGMY").Value = Mid(CuentaC, 1, 3)
            Case "H"
                SQLCmd.Parameters("CGMY").Value = Mid(CodCtaCE, 1, 3)
        End Select

        'Descripcion del Asiento Contable
        CGDA.SourceColumn = "RPM_DescAs"
        SQLCmd.Parameters.Add(CGDA)
        Select Case TipoAsiento
            Case "D"
                SQLCmd.Parameters("CGDA").Value = ACDescD
            Case "H"
                SQLCmd.Parameters("CGDA").Value = ACDescH
        End Select

        'Comprobante Contable - Generado por fecha de cierre diario
        Dim NAsiento As Integer
        Dim NextAs As String = ""

        If Global.PMovilD.My.MySettings.Default.CierreD = CDate(FHoy) Then
            NextAs = Global.PMovilD.My.MySettings.Default.AsientoN
        Else
            NAsiento = CInt(Global.PMovilD.My.MySettings.Default.AsientoN)
            NAsiento = NAsiento + 1
            Select Case Len(CStr(NAsiento))
                Case 1
                    NextAs = "00" + CStr(NAsiento)
                Case 2
                    NextAs = "0" + CStr(NAsiento)
                Case 3
                    NextAs = CStr(NAsiento)
            End Select
            Global.PMovilD.My.MySettings.Default.AsientoN = NextAs
            Global.PMovilD.My.MySettings.Default.CierreD = CDate(FHoy)
        End If

        'Numero Asiento Contable
        CGNA.SourceColumn = "RPM_NAsiento"
        SQLCmd.Parameters.Add(CGNA)
        SQLCmd.Parameters("CGNA").Value = Mid(CStr(FHoy), 7, 4) & Mid(CStr(FHoy), 4, 2) & Mid(CStr(FHoy), 1, 2) + "-" + NextAs

        'Tipo de Asiento
        CGTA.SourceColumn = "RPM_TipoAs"
        SQLCmd.Parameters.Add(CGTA)
        SQLCmd.Parameters("CGTA").Value = TipoAsiento

        'User ID Registro
        CGUR.SourceColumn = "RPM_UIDpm"
        SQLCmd.Parameters.Add(CGUR)
        SQLCmd.Parameters("CGUR").Value = Global.PMovilD.My.MySettings.Default.UserID

        actDate = CDate(Mid(CStr(ThisMoment), 1, 10))
        actTime = CDate(Mid(CStr(ThisMoment), 11, 11))

        'Fecha Registro
        CGFR.SourceColumn = "RPM_FecReg"
        SQLCmd.Parameters.Add(CGFR)
        SQLCmd.Parameters("CGFR").Value = actDate

        'Hora Registro
        CGHR.SourceColumn = "RPM_HraReg"
        SQLCmd.Parameters.Add(CGHR)
        SQLCmd.Parameters("CGHR").Value = actTime

        ConnSQLTF.Open()
        iresult = SQLCmd.ExecuteNonQuery
        ConnSQLTF.Close()

        AsientosDGR = True
    End Function

    Function UpdateLimit()
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMPagoM - Pago Movil Dynamics                                                                                                 '   
        ' Function UpdateLimit  - Actualiza el monto disponible y los pagos efectuados por Pago Movil del Banco Seleccionado                     '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        'Definicion del comando SQL de Modificacion de Datos (UPDATE)
        Dim ConnSQLTF As New OdbcConnection With {
            .ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
        }

        'Parametros del comando SQL
        'Parametros de actualizacion de Pagos Moviles y Limite Disponible del Banco
        Dim ParmPG As New Odbc.OdbcParameter("Pgo", Odbc.OdbcType.Double)
        Dim ParmDP As New Odbc.OdbcParameter("Dsp", Odbc.OdbcType.Double)

        Dim sqlupdL As String
        Dim sqlupdD As String

        'Actualizar Monto Total de Pagos Moviles
        sqlupdL = "UPDATE MRS_DynamicsE SET DYN_PagosM = ? WHERE DYN_OrgName = '" + CIAName.Text + "'"
        Dim sqlULim As New Odbc.OdbcCommand(sqlupdL, ConnSQLTF)
        ParmPG.SourceColumn = "DYN_PagosM"
        sqlULim.Parameters.Add(ParmPG)
        sqlULim.Parameters("Pgo").Value = PagosEf
        ConnSQLTF.Open()
        fldCount = sqlULim.ExecuteNonQuery
        ConnSQLTF.Close()

        'Actualizar Disponible de Pago Movil para el Banco
        sqlupdD = "UPDATE MRS_DynamicsE SET DYN_RestoPM = ? WHERE DYN_OrgName = '" + CIAName.Text + "'"
        Dim sqlUDsp As New Odbc.OdbcCommand(sqlupdD, ConnSQLTF)
        ParmDP.SourceColumn = "DYN_RestoPM"
        sqlUDsp.Parameters.Add(ParmDP)
        sqlUDsp.Parameters("Dsp").Value = Disponible
        ConnSQLTF.Open()
        fldCount = sqlUDsp.ExecuteNonQuery
        ConnSQLTF.Close()

        UpdateLimit = True
    End Function
End Class