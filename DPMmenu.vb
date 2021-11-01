Imports System.Windows.Forms

Public Class DPMmenu
	Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.Close()
	End Sub

	Private Sub LogView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LogView.Click, ToolStripButton1.Click
		DPMLogV.Show()
	End Sub

	Private Sub BankList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BankList.Click, ToolStripButton2.Click
		DPMBankL.Show()
	End Sub

	Private Sub DynamicsG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DynamicsG.Click, ToolStripButton3.Click
		DPMDynamics.Show()
	End Sub

	Private Sub SetupPM_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SetupPM.Click, ToolStripButton7.Click
        DPMSettings.Show()
	End Sub

	Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles APPSets.Click

	End Sub

	Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.TileVertical)
	End Sub

	Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		Me.LayoutMdi(MdiLayout.ArrangeIcons)
	End Sub

	Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
		' Close all child forms of the parent.
		For Each ChildForm As Form In Me.MdiChildren
			ChildForm.Close()
		Next
	End Sub

	Private m_ChildFormNumber As Integer

	Private Sub DynamicsPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DynamicsPay.Click, NewToolStripButton.Click
		DPMPagoC.Show()
	End Sub

	Private Sub CustomerPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerPay.Click, OpenToolStripButton.Click
		DPMPagoM.Show()
	End Sub

	Private Sub ExitPMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitPMS.Click
		Me.Close()
	End Sub

	Private Sub MSAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSAccess.Click, MSAccB.Click
		DPMAccess.Show()
	End Sub

	Private Sub MariaDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MariaDB.Click, MariaDBB.Click
		DPMMariaDB.Show()
	End Sub

	Private Sub PostgreSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PostgreSQL.Click
		DPMPostgre.Show()
	End Sub

	Private Sub AcercaPM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaPM.Click, AboutB.Click
		AcercaDe.Show()
	End Sub

    Private Sub DPMmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case Global.PMovilD.My.MySettings.Default.DBType
            Case "MS Access2010/19"
                PMovilDSt.Items("DataBType").Text = "MS-Access 2010/19"
                PMovilDSt.Items("DataBType").Image = Global.PMovilD.My.Resources.DPMAccess
            Case ("MariaDB")
                PMovilDSt.Items("DataBType").Text = "MariaDB 10.3.1"
                PMovilDSt.Items("DataBType").Image = Global.PMovilD.My.Resources.DPMMariaDB
            Case "PostgreSQL"
                PMovilDSt.Items("DataBType").Text = "PostgreSQL 14.1.3"
                PMovilDSt.Items("DataBType").Image = Global.PMovilD.My.Resources.DPMPostgre
        End Select

    End Sub

    Private Sub CuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasToolStripMenuItem.Click
        DPMCatCta.show()
    End Sub

    Private Sub DiarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiarioToolStripMenuItem.Click
        DPMDiario.show()
    End Sub

    Private Sub MayorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MayorToolStripMenuItem.Click
        DPMMayor.Show()
    End Sub
End Class
