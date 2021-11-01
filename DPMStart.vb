Public NotInheritable Class DPMStart
    Public Time_count As Integer
    Const INTERVALO_EN_MINUTOS As Integer = 60

    Private Sub DPMStart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RegisterU.Text = Global.PMovilD.My.Settings.UserName
        RegisterL.Text = Global.PMovilD.My.Settings.UserLic
        Timer1.Interval = 1500
        Timer1.Enabled = True
        Time_count = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' variable estática para acumular la cantidad de segundos
        Static Temp_Seg As Long
        ' incrementa
        Temp_Seg = Temp_Seg + 1
        Label7.Text = Temp_Seg & "  -  " & CStr(Temp_Seg * 60)
        ' comprueba que los segundos no sea igual a la cantidad de minutos que queremos , en este caso 5 minutos
        If (Temp_Seg * 60) >= 3600 Then
            ' reestablece
            Timer1.Enabled = False
        End If
    End Sub

End Class