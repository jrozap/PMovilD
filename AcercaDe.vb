Public Class AcercaDe

    Private Sub AcercaDe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		UserN.Text = Global.PMovilD.My.MySettings.Default.UserID
		CompanyN.Text = Global.PMovilD.My.MySettings.Default.CiaName
		FecLic.Text = Global.PMovilD.My.MySettings.Default.PMovilDF
		ClvAct.Text = Global.PMovilD.My.MySettings.Default.UserLic
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
		DPMLic.Show()
    End Sub

    Private Sub OKBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBut.Click
        Me.Close()
    End Sub

    Private Sub InfoSysB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoSysB.Click
        DPMInfoSys.Show()
    End Sub
End Class