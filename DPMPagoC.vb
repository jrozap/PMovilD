'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMPagoC - Pago Movil de Compras a Dynamics Group *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMPagoC        | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMPagoC

    'Variables Publicas del modulo DPMPagoC
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
    Public DescAsD As String
    Public DescAsH As String
    Public Flag As Boolean = False

    'Coordenadas Banco del Tesoro
    Public Cordinates As String

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

    Private Sub RBPagoM1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM1.CheckedChanged
        ClearData()
        If RBPagoM1.Checked = True Then
            BankIdN = "0134"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            ClientData.ForeColor = Color.Purple
            LogoPagoM.Size = New System.Drawing.Size(77, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBanesco
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM2.CheckedChanged
        ClearData()
        If RBPagoM2.Checked = True Then
            BankIdN = "0105"
            ClientData.ForeColor = Color.MediumBlue
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
            Label18.Enabled = True
            NacIDM.Enabled = True
            CINumber.Enabled = True
            Label19.Enabled = True
            CAMovil.Enabled = True
            MovilN.Enabled = True
            LogoPagoM.Size = New System.Drawing.Size(77, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.Tpago
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM3.CheckedChanged
        ClearData()
        If RBPagoM3.Checked = True Then
            BankIdN = "0175"
            ClientData.ForeColor = Color.DarkRed
            LogoPagoM.Size = New System.Drawing.Size(60, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBicentenario
            MercantilKA.Enabled = True
            Label18.Enabled = False
            NacIDM.Enabled = False
            CINumber.Enabled = False
            Label19.Enabled = False
            CAMovil.Enabled = False
            MovilN.Enabled = False
            EtiquetaTit.Text = "Cedula Titular Cuenta (BBc):"
            MercantilKA.Text = "Clave Op. Especiales (Bicentenario)"
            MercantilKA.ForeColor = Color.DarkRed
            LabelTemp.ForeColor = Color.DarkRed
            LabelTemp.Text = "Clave Op. Especiales:"
            TempKey.ForeColor = Color.DarkRed
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM4.CheckedChanged
        ClearData()
        If RBPagoM4.Checked = True Then
            BankIdN = "0102"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            ClientData.ForeColor = Color.DarkRed
            LogoPagoM.Size = New System.Drawing.Size(60, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.BdVPM
            EtiquetaTit.Text = "Cedula Titular Cuenta (BDV):"
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM5.CheckedChanged
        ClearData()
        If RBPagoM5.Checked = True Then
            BankIdN = "0172"
            MercantilKA.Enabled = False
            ClientData.ForeColor = Color.Green
            LogoPagoM.Size = New System.Drawing.Size(45, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBancamiga1
            EtiquetaTit.Text = "Cedula Titular Cuenta (Bancamiga):"
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
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM6.CheckedChanged
        ClearData()
        If RBPagoM6.Checked = True Then
            BankIdN = "0114"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(77, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MPBCaribe
            EtiquetaTit.Text = "Cedula Titular Cuenta (BanCaribe):"
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM7.CheckedChanged
        ClearData()
        If RBPagoM7.Checked = True Then
            BankIdN = "0163"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Location = New System.Drawing.Point(452, 10)
            coordTesoro.Location = New System.Drawing.Point(452, 35)
            labelTesoro.Text = "Coordenadas:"
            labelTesoro.Visible = True
            coordTesoro.BorderStyle = BorderStyle.Fixed3D
            coordTesoro.Visible = True
            Cordinates = coordTesoro.Text
            LogoPagoM.Size = New System.Drawing.Size(49, 80)
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM8.CheckedChanged
        ClearData()
        If RBPagoM8.Checked = True Then
            BankIdN = "0116"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(77, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PExpressBOD
            EtiquetaTit.Text = "Cedula Titular Cuenta (BOD):"
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM9.CheckedChanged
        ClearData()
        If RBPagoM9.Checked = True Then
            BankIdN = "0104"
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
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(49, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMVenC
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
            RBPagoM10.Checked = False
            RBPagoM11.Checked = False
            RBPagoM12.Checked = False
            RBPagoM13.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM10.CheckedChanged
        ClearData()
        If RBPagoM10.Checked = True Then
            BankIdN = "0115"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(77, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMExterior
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
            EtiquetaTit.Text = "Cedula Titular Cuenta (BExt):"
            BankId = "BEXT"
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM11.CheckedChanged
        ClearData()
        If RBPagoM11.Checked = True Then
            BankIdN = "0151"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(77, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.BFC2
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM12.CheckedChanged
        ClearData()
        If RBPagoM12.Checked = True Then
            BankIdN = "0177"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(60, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBFanB
            EtiquetaTit.Text = "Cedula Titular Cuenta (BanFANB):"
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
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
            RBPagoM13.Checked = False
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM13.CheckedChanged
        ClearData()
        If RBPagoM13.Checked = True Then
            BankIdN = "0156"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(49, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PM100Bco
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Location = New System.Drawing.Point(452, 10)
            coordTesoro.Location = New System.Drawing.Point(452, 35)
            labelTesoro.Text = "Clave Pago:"
            labelTesoro.Visible = True
            coordTesoro.BorderStyle = BorderStyle.Fixed3D
            coordTesoro.Visible = True
            Cordinates = coordTesoro.Text
            EtiquetaTit.Text = "Cedula Titular Cuenta (100% Banco):"
            BankId = "100B"
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM14.CheckedChanged
        ClearData()
        If RBPagoM14.Checked = True Then
            BankIdN = "0138"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(77, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBPlaza
            AmountPay.Location = New System.Drawing.Point(319, 74)
            EtiquetaTit.Text = "Cedula Titular Cuenta (Bco Plaza):"
            MerLabel.Text = "Tipo Cuenta (Bco Plaza):"
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM15.CheckedChanged
        ClearData()
        If RBPagoM15.Checked = True Then
            BankIdN = "0166"
            ClientData.ForeColor = Color.DarkRed
            LogoPagoM.Size = New System.Drawing.Size(49, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBicentenario
            MercantilKA.Enabled = True
            Label18.Enabled = False
            NacIDM.Enabled = False
            CINumber.Enabled = False
            Label19.Enabled = False
            CAMovil.Enabled = False
            MovilN.Enabled = False
            EtiquetaTit.Text = "Cedula Titular Cuenta (BAgV):"
            MercantilKA.Text = "Clave Op. Especiales (Bco Agricola)"
            MercantilKA.ForeColor = Color.Green
            LabelTemp.ForeColor = Color.Green
            LabelTemp.Text = "Clave Op. Especiales:"
            TempKey.ForeColor = Color.DarkRed
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
            BankId = "BAGV"
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM16.CheckedChanged
        ClearData()
        If RBPagoM16.Checked = True Then
            BankIdN = "0146"
            MerLabel.Enabled = False
            CC1.Enabled = False
            CC2.Enabled = False
            CA1.Enabled = False
            CA2.Enabled = False
            MercantilKA.Enabled = False
            LogoPagoM.Size = New System.Drawing.Size(85, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBGente
            EtiquetaTit.Text = "Cedula Titular Cuenta (BanGente):"
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
            BankId = "BGTE"
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM17.CheckedChanged
        ClearData()
        If RBPagoM17.Checked = True Then
            BankIdN = "0149"
            ClientData.ForeColor = Color.DarkRed
            LogoPagoM.Size = New System.Drawing.Size(60, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBicentenario
            MercantilKA.Enabled = True
            Label18.Enabled = False
            NacIDM.Enabled = False
            CINumber.Enabled = False
            Label19.Enabled = False
            CAMovil.Enabled = False
            MovilN.Enabled = False
            EtiquetaTit.Text = "Cedula Titular Cuenta (BPS):"
            MercantilKA.Text = "Clave Op. Especiales (B. Pbo. Sob.)"
            MercantilKA.ForeColor = Color.DarkRed
            LabelTemp.ForeColor = Color.DarkRed
            LabelTemp.Text = "Clave Op. Especiales:"
            TempKey.ForeColor = Color.DarkRed
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
            BankId = "BPSB"
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub RBPagoM18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPagoM18.CheckedChanged
        ClearData()
        If RBPagoM17.Checked = True Then
            BankIdN = "0169"
            ClientData.ForeColor = Color.DarkRed
            LogoPagoM.Size = New System.Drawing.Size(49, 80)
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMMibanco
            MercantilKA.Enabled = True
            Label18.Enabled = False
            NacIDM.Enabled = False
            CINumber.Enabled = False
            Label19.Enabled = False
            CAMovil.Enabled = False
            MovilN.Enabled = False
            EtiquetaTit.Text = "Cedula Titular Cuenta (MiBanco):"
            MercantilKA.Text = "Clave Op. Especiales (MiBanco)"
            MercantilKA.ForeColor = Color.Green
            LabelTemp.ForeColor = Color.Green
            LabelTemp.Text = "Clave Op. Especiales:"
            TempKey.ForeColor = Color.Green
            AmountPay.Location = New System.Drawing.Point(319, 74)
            labelTesoro.Visible = False
            coordTesoro.Visible = False
            BankId = "MBCO"
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
        Else
            LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.MRSLogo4
        End If
    End Sub

    Private Sub EmpDynamics_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpDynamics.SelectedIndexChanged
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(100, 999)
        Dim facNum1 As Integer
        Dim facNum2 As Integer
        Dim facNum As String
        facNum1 = valorAleatorio * 2
        facNum2 = valorAleatorio * 4
        facNum = CStr(facNum1) + CStr(facNum2)
        FactNum.Text = facNum

        idxCia = EmpDynamics.SelectedIndex
        Select Case EmpDynamics.SelectedIndex
            Case 0
                DynamicsPM.Size = New System.Drawing.Size(91, 26)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.DynamicsApp
                LCompany.BackgroundImage = Global.PMovilD.My.Resources.DynamicsApp
                CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
                RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                TransDate.Text = FHoy
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                CodBankC.Text = BankIdN
                DSetBnk.Clear()
                cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
                DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
                DAdpBnk.Fill(DSetBnk, "Bancos")
                BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
                NMobile.Text = CustAC.Text + "-" + CustMP.Text
                TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
                AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
                AreaCM.ReadOnly = True
                MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
                MobileP.ReadOnly = True
                ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                ISObnk.ReadOnly = True
                BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                BankNme.ReadOnly = True
                RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
            Case 1
                DynamicsPM.Size = New System.Drawing.Size(91, 20)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.DDental1
                LCompany.BackgroundImage = Global.PMovilD.My.Resources.DDental1
                CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
                RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                TransDate.Text = FHoy
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                CodBankC.Text = BankIdN
                DSetBnk.Clear()
                cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
                DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
                DAdpBnk.Fill(DSetBnk, "Bancos")
                BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
                NMobile.Text = CustAC.Text + "-" + CustMP.Text
                TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
                AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
                AreaCM.ReadOnly = True
                MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
                MobileP.ReadOnly = True
                ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                ISObnk.ReadOnly = True
                BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                BankNme.ReadOnly = True
                RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
            Case 2
                DynamicsPM.Size = New System.Drawing.Size(91, 26)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.redvital1
                LCompany.BackgroundImage = Global.PMovilD.My.Resources.redvital1
                CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
                RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                TransDate.Text = FHoy
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                CodBankC.Text = BankIdN
                DSetBnk.Clear()
                cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
                DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
                DAdpBnk.Fill(DSetBnk, "Bancos")
                BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
                NMobile.Text = CustAC.Text + "-" + CustMP.Text
                TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
                AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
                AreaCM.ReadOnly = True
                MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
                MobileP.ReadOnly = True
                ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                ISObnk.ReadOnly = True
                BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                BankNme.ReadOnly = True
                RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
            Case 3
                DynamicsPM.Size = New System.Drawing.Size(91, 26)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.medifarmaV
                LCompany.BackgroundImage = Global.PMovilD.My.Resources.medifarmaV
                CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
                RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                TransDate.Text = FHoy
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                CodBankC.Text = BankIdN
                DSetBnk.Clear()
                cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
                DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
                DAdpBnk.Fill(DSetBnk, "Bancos")
                BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
                NMobile.Text = CustAC.Text + "-" + CustMP.Text
                TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
                AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
                AreaCM.ReadOnly = True
                MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
                MobileP.ReadOnly = True
                ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                ISObnk.ReadOnly = True
                BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                BankNme.ReadOnly = True
                RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
            Case 4
                DynamicsPM.Size = New System.Drawing.Size(91, 26)
                DynamicsPM.BackgroundImage = Global.PMovilD.My.Resources.SANEMedServ
                LCompany.BackgroundImage = Global.PMovilD.My.Resources.SANEMedServ
                CIAName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_OrgName")
                RIFEmp.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                TransDate.Text = FHoy
                BankCode.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                BankName.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                CodBankC.Text = BankIdN
                DSetBnk.Clear()
                cmdSQLBnk = "SELECT * FROM MRS_ISOBnk WHERE BankCode = '" + BankIdN + "'"
                DAdpBnk = New OdbcDataAdapter(cmdSQLBnk, MRSDBcon)
                DAdpBnk.Fill(DSetBnk, "Bancos")
                BankCli.Text = DSetBnk.Tables("Bancos").Rows(0).Item("BankNme")
                NMobile.Text = CustAC.Text + "-" + CustMP.Text
                TransAmt.Text = CDbl(AmountPay.Text).ToString("#,##0.00;(#,##0.00);0.00")
                AreaCM.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_ACodMP")
                AreaCM.ReadOnly = True
                MobileP.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_MobileP")
                MobileP.ReadOnly = True
                ISObnk.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankCod")
                ISObnk.ReadOnly = True
                BankNme.Text = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_BankNme")
                BankNme.ReadOnly = True
                RIFDynE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_RifNumb")
                CodCtaCE = DSetGD.Tables("Empresas").Rows(idxCia).Item("DYN_CodCtaCB")
        End Select
    End Sub

    Private Sub DPMPagoC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Global.PMovilD.My.MySettings.Default.DBType
            Case "MS Access2010/19"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect
            Case "MariaDB"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.MRSDataMDB
            Case "PostgreSQL"
                MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.MRSDataPG
        End Select
        MRSDBcon.Open()

        FHoy = Today
        ThisMoment = Now

        TVenta = "Caja"

        'Data de Log Transacciones
        cmdSQLLog = "SELECT * FROM MRS_TLog ORDER BY LG_Id"
        DAdpLog = New OdbcDataAdapter(cmdSQLLog, MRSDBcon)
        DAdpLog.Fill(DSetLog, "TLogs")

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
        LogoPagoM.Size = New System.Drawing.Size(77, 72)
        LogoPagoM.BackgroundImage = Global.PMovilD.My.Resources.PMBanesco
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

        Aidx = 0
        RefRq = True
        MobilePNumber = CustAC.Text + CustMP.Text
        Select Case BankId
            Case "BAN"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "2846"
                SMSBody = ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CStr(MontoPgo)
            Case "MER"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "24024"
                SMSBody = "TPAGO " + NacId.Text + CedID.Text + " " + TipoCta + " " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CStr(MontoPgo) + " " + TempKey.Text
            Case "BBI"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "7077"
                SMSBody = "BBDPPAGO " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CStr(MontoPgo) + TempKey.Text
            Case "BDV"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "2661"
                SMSBody = "PAGAR " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)")
            Case "BAMG"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "26448"
                SMSBody = "MPAGO " + NacId.Text + CedID.Text + " " + TipoCta + " " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CStr(MontoPgo)
            Case "BCAR"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "22741"
                SMSBody = "MIPAGO " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + ISObnk.Text + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)") + " " + AreaCM.Text + MobileP.Text
            Case "BTRO"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "2383"
                SMSBody = "PAGAR " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + " " + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)") + " " + coordTesoro.Text
                AmountPay.Location = New System.Drawing.Point(319, 91)
                labelTesoro.Visible = False
                coordTesoro.Visible = False
            Case "BOD"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "263"
                SMSBody = "PAGO " + CedID.Text + " " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CStr(MontoPgo)
            Case "BVC"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "2821"
                SMSBody = "PC " + CedID.Text + " " + TipoCta + ISObnk.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + AreaCM.Text + MobileP.Text + " " + CStr(MontoPgo)
            Case "BEXT"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "278"
                SMSBody = "PAGAR " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + " " + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CStr(MontoPgo)
            Case "BFC"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "88232"
                SMSBody = "PAC " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)") + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1)
            Case "BFAN"
                Dim lenP As Integer
                Dim decMto As String
                Dim intMto As String
                Dim mtoPgo As String
                Dim mPgo As Integer

                mPgo = CInt(AmountPay.Text)
                lenP = Len(CStr(MontoPgo))
                decMto = Mid(CStr(MontoPgo), lenP - 2, 2)
                If decMto = ",0" Then
                    decMto = "00"
                    intMto = Mid(CStr(MontoPgo), 1, lenP - 2)
                Else
                    decMto = Mid(CStr(MontoPgo), lenP - 1, 2)
                    intMto = CStr(mPgo)
                End If
                mtoPgo = intMto + decMto
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "326200"
                SMSBody = "BFANFP2C " + NacId.Text + CedID.Text + " " + Mid(AreaCM.Text, 2, 3) + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + ISObnk.Text + " " + mtoPgo
                mtoPgo = intMto + decMto
            Case "100B"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "100102"
                SMSBody = "PAGO " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + " " + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + ISObnk.Text + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)") + coordTesoro.Text
                AmountPay.Location = New System.Drawing.Point(319, 91)
                labelTesoro.Visible = False
                coordTesoro.Visible = False
            Case "BPZA"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "1470"
                SMSBody = "TUDINEROYA " + TipoCta + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + " " + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)")
                AmountPay.Location = New System.Drawing.Point(319, 91)
                labelTesoro.Visible = False
                coordTesoro.Visible = False
            Case "BAGV"
                Dim lenP As Integer
                Dim decMto As String
                Dim intMto As String
                Dim mtoPgo As String
                Dim mPgo As Integer

                mPgo = CInt(AmountPay.Text)
                lenP = Len(CStr(MontoPgo))
                decMto = Mid(CStr(MontoPgo), lenP - 2, 2)
                If decMto = ",0" Then
                    decMto = "00"
                    intMto = Mid(CStr(MontoPgo), 1, lenP - 2)
                Else
                    decMto = Mid(CStr(MontoPgo), lenP - 1, 2)
                    intMto = CStr(mPgo)
                End If
                mtoPgo = intMto + decMto
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "326024"
                SMSBody = "BAVFP2C " + NacId.Text + CedID.Text + " " + Mid(AreaCM.Text, 2, 3) + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + ISObnk.Text + " " + mtoPgo + TempKey.Text
                mtoPgo = intMto + decMto
            Case "BGTE"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "22741"
                SMSBody = "MIPAGO " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + ISObnk.Text + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)") + " " + AreaCM.Text + MobileP.Text
            Case "BPSB"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "7077"
                SMSBody = "BBDPPAGO " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CStr(MontoPgo) + TempKey.Text
            Case "MBCO"
                MobilePNumber = CustAC.Text + CustMP.Text
                BankShortN = "22622"
                SMSBody = "PAGAR " + ISObnk.Text + " " + AreaCM.Text + MobileP.Text + " " + Mid(RIFDynE, 1, 1) + Mid(RIFDynE, 3, 8) + Mid(RIFDynE, 12, 1) + " " + CDbl(AmountPay.Text).ToString("0.00;(0.00)") + TempKey.Text
        End Select

        SendSMS(MobilePNumber, BankShortN, SMSBody)

        LabelTemp.ForeColor = Color.MediumBlue
        LabelTemp.Text = "Clave Temporal:"
        TempKey.ForeColor = Color.MediumBlue
        MercantilKA.Text = "Clave Temporal Mercantil"
        MercantilKA.ForeColor = Color.MediumBlue
        MercantilKA.Enabled = False
        ClientData.ForeColor = Color.MediumBlue
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

        If Flag = False Then
            'Generar Asiento Contable de Venta e Ingreso al Banco
            TabCuadre.SelectedTab = CGView

            Aidx = 0
            AsientosDG.Rows.Clear()

            AsientosDG.Rows.Add()
            AsientosDG.Rows(Aidx).Cells(0).Value() = CDate(FHoy)
            AsientosDG.Rows(Aidx).Cells(1).Value() = CodCtaCE
            CuentaC = CodCtaCE
            AsientosDG.Rows(Aidx).Cells(2).Value() = "PAGO FRA: " + FactNum.Text + " hacia " + EmpDynamics.Text + " via Pago Movil: ID Banco: " + BankCode.Text + " / " + BankName.Text + " - " + " Cliente: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + " Banco Cli: " + CodBankC.Text + " / " + BankCli.Text
            DescAsD = "PAGO FRA: " + FactNum.Text + " hacia " + EmpDynamics.Text + " via Pago Movil: ID Banco: " + BankCode.Text + " / " + BankName.Text + " - " + " Cliente: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + " Banco Cli: " + CodBankC.Text + " / " + BankCli.Text
            AsientosDG.Rows(Aidx).Cells(3).Value() = CDbl(AmountPay.Text)
            Aidx = Aidx + 1
            AsientosDG.Rows.Add()
            AsientosDG.Rows(Aidx).Cells(0).Value() = CDate(FHoy)
            Select Case TVenta
                Case "Web"
                    CuentaC = "411-002"
                Case "Caja"
                    CuentaC = "411-001"
                Case "Mayor"
                    CuentaC = "411-003"
                Case "ServM"
                    CuentaC = "411-004"
            End Select
            AsientosDG.Rows(Aidx).Cells(1).Value() = CuentaC
            AsientosDG.Rows(Aidx).Cells(2).Value() = "Compra Cliente: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + " SEGUN FRA: " + FactNum.Text + " - via Pago Movil: Desde Banco: " + CodBankC.Text + " / " + BankCli.Text
            DescAsH = "Compra Cliente: CI: " + NacId.Text + CedID.Text + " Movil: " + CustAC.Text + CustMP.Text + " SEGUN FRA: " + FactNum.Text + " - via Pago Movil: Desde Banco: " + CodBankC.Text + " / " + BankCli.Text
            AsientosDG.Rows(Aidx).Cells(4).Value() = CDbl(AmountPay.Text)

            'Genera el Asiento de Pago Movil (Debe a Cuenta Bancaria por Ventas)
            TipoAsiento = "D"
            AsientosDGR()

            'Genera el Contrasiento de Pago Movil (Haber a Cuenta de Ingresos por Venta)
            TipoAsiento = "H"
            AsientosDGR()

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

    Sub SendSMS(ByVal FromNumber As String, ByVal ToNumber As String, ByVal SMS As String)
        Dim url As String = "https://rest.clicksend.com/v3/sms/send"
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)

        Flag = False
        request.Method = "POST"

        Dim postData As String = "FromNumber=" & FromNumber

        postData += "&"
        postData += "ToNumber=" & ToNumber
        postData += "&"
        postData += "SMS=" & SMS

        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

        request.ContentType = "application/json"
        request.Headers.Add("Authorization: Basic YXBpLXVzZXJuYW1lOmFwaS1wYXNzd29yZA==")                    'get your new API token at https://rest.clicksend.com/
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
        Catch excp As WebException
            Dim msg As String = excp.Message
            MessageBox.Show("Error en conexion a Internet: " & msg)
            Flag = True
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
                Case "BVC"
                    TipoCta = "CTE"
                    CC2.Checked = False
                    CC2.Enabled = False
                    CA1.Checked = False
                    CA1.Enabled = False
                    CA2.Checked = False
                    CA2.Enabled = False
                Case "BPZA"
                    TipoCta = "CTE"
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
                Case "BVC"
                    CC2.Checked = False
                    CC2.Enabled = True
                Case "BPZA"
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
                Case "BVC"
                    TipoCta = "AHO"
                    CC1.Checked = False
                    CC1.Enabled = False
                    CA1.Checked = False
                    CA1.Enabled = False
                    CA2.Checked = False
                    CA2.Enabled = False
                Case "BPZA"
                    TipoCta = "AHO"
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
                Case "BVC"
                    CC1.Checked = False
                    CC1.Enabled = True
                Case "BPZA"
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

    Private Sub TKSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKSend.Click
        TKReq = True
        MobilePNumber = CustACW + MovilN.Text
        BankShortN = "24024"
        SMSBody = "SCT"

        SendSMS(MobilePNumber, BankShortN, SMSBody)
        TKReq = False
        MercantilKA.Enabled = False
    End Sub

    Private Sub CAMovil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAMovil.SelectedIndexChanged
        CustACW = CAMovil.Text
        CustAC.Text = CAMovil.Text
    End Sub

    Private Sub NacIDM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NacIDM.SelectedIndexChanged
        NacIdW = NacIDM.Text
        NacId.Text = NacIDM.Text
    End Sub

    Private Sub CINumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CINumber.TextChanged
        CedID.Text = CINumber.Text
    End Sub

    Private Sub MovilN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovilN.TextChanged
        CustMP.Text = MovilN.Text
    End Sub

    Private Function ClearData() As Boolean
        NacId.Text = ""
        CedID.Text = ""
        CustAC.Text = ""
        CustMP.Text = ""
        CC1.Checked = False
        CC2.Checked = False
        CA1.Checked = False
        CA2.Checked = False
        AmountPay.Text = ""
        EmpDynamics.Text = ""
        AreaCM.Text = ""
        MobileP.Text = ""
        ISObnk.Text = ""
        BankNme.Text = ""
        NacIDM.Text = ""
        CINumber.Text = ""
        CAMovil.Text = ""
        MovilN.Text = ""
        TempKey.Text = ""
        DynamicsPM.BackgroundImage = Nothing
        LCompany.BackgroundImage = Nothing
        TransDate.Text = ""
        CIAName.Text = ""
        RIFEmp.Text = ""
        FactNum.Text = ""
        RefNum.Text = ""
        BankCode.Text = ""
        BankName.Text = ""
        CodBankC.Text = ""
        BankCli.Text = ""
        NMobile.Text = ""
        BankRef.Text = ""
        TransAmt.Text = ""
        AsientosDG.Rows.Clear()

        ClearData = True
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

        iSQLLog = "INSERT INTO MRS_TLog" &
         "(LG_TransDate, LG_CiaName, LG_RIFCia, LG_CiaBank, LG_CiaMobile, LG_TransAmt, LG_CBankSN, LG_CBankID, LG_CMobile, " &
         "LG_SMSBody, LG_SMSResp, LG_SMSTimeS, LG_UserTrans, LG_FechaTran, LG_HoraTrans)" &
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
        ' Modulo: DPMPago - Pago Movil de Clientes                                                                                               '   
        ' Function AsientosDGR  - Genera la Ristra Contable del Pago Movil                                                                       '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'

        'Definicion del comando SQL de Insercion de Datos (INSERT)
        Dim ConnSQLTF As New OdbcConnection
        Dim iSQLLog As String
        Dim iresult As Integer

        ConnSQLTF.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect

        iSQLLog = "INSERT INTO MRS_CGPMov" &
         "(RPM_TipoTran, RPM_FechaT, RPM_Benefit, RPM_CIBenef, RPM_NMovB, RPM_ISOBankB, RPM_CiaNmeD, RPM_ISOBankD, RPM_RIFCiaD, " &
         "RPM_MovilD, RPM_MtoTr, RPM_Factura, RPM_NRefB, RPM_CtaCble, RPM_MayorA, RPM_DescAs, RPM_NAsiento, RPM_TipoAs, RPM_UIDpm, RPM_FecReg, RPM_HraReg)" &
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
        SQLCmd.Parameters("CGTT").Value = "PMV"

        'Fecha Transaccion
        CGFT.SourceColumn = "RPM_FechaT"
        SQLCmd.Parameters.Add(CGFT)
        SQLCmd.Parameters("CGFT").Value = CDate(ThisMoment)

        'Nombre / Razon Social Beneficiario
        CGBN.SourceColumn = "RPM_Benefit"
        SQLCmd.Parameters.Add(CGBN)
        Select Case TVenta
            Case "Web"
                SQLCmd.Parameters("CGBN").Value = "Venta por Internet - " & EmpDynamics.Text
            Case "Caja"
                SQLCmd.Parameters("CGBN").Value = "Venta por Caja - " & EmpDynamics.Text
            Case "Mayor"
                SQLCmd.Parameters("CGBN").Value = "Venta al Mayor - " & EmpDynamics.Text
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
        SQLCmd.Parameters("CGBB").Value = BankIdN

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
        SQLCmd.Parameters("CGMo").Value = CDbl(AmountPay.Text)

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
                SQLCmd.Parameters("CGCC").Value = CodCtaCE
            Case "H"
                SQLCmd.Parameters("CGCC").Value = CuentaC
        End Select

        'Cuenta de Mayor Asociada
        CGMY.SourceColumn = "RPM_MayorA"
        SQLCmd.Parameters.Add(CGMY)
        Select Case TipoAsiento
            Case "D"
                SQLCmd.Parameters("CGMY").Value = Mid(CodCtaCE, 1, 3)
            Case "H"
                SQLCmd.Parameters("CGMY").Value = Mid(CuentaC, 1, 3)
        End Select

        'Descripcion del Asiento Contable
        CGDA.SourceColumn = "RPM_DescAs"
        SQLCmd.Parameters.Add(CGDA)
        Select Case TipoAsiento
            Case "D"
                SQLCmd.Parameters("CGDA").Value = DescAsD
            Case "H"
                SQLCmd.Parameters("CGDA").Value = DescAsH
        End Select

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

End Class