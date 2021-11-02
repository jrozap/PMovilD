Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data

Public Class formLeerGenerarCodigosQR
    Private colorFondoQR As Integer =
        Color.FromArgb(255, 255, 255, 255).ToArgb
    Private colorQR As Integer =
        Color.FromArgb(255, 0, 0, 0).ToArgb

    Private Function AdjustQRVersion(ByVal TextEncode As String,
             ByVal qrCodeErrCorrect As  _
             Codec.QRCodeEncoder.ERROR_CORRECTION) As Integer
        Dim textb() As Byte =
            System.Text.UTF8Encoding.UTF8.GetBytes(TextEncode)
        Dim ibits As Integer = ((textb.Length + 1) * 8) + 8

        Return -1

        Select Case qrCodeErrCorrect
            'Corrección de errores del 7%
            Case QRCodeEncoder.ERROR_CORRECTION.L
                Select Case ibits
                    Case Is <= 152
                        Return 1
                    Case Is <= 272
                        Return 2
                    Case Is <= 440
                        Return 3
                    Case Is <= 640
                        Return 4
                    Case Is <= 864
                        Return 5
                    Case Is <= 1088
                        Return 6
                    Case Is <= 1248
                        Return 7
                    Case Is <= 1552
                        Return 8
                    Case Is <= 1856
                        Return 9
                    Case Is <= 2192
                        Return 10
                    Case Is <= 2592
                        Return 11
                    Case Is <= 2960
                        Return 12
                    Case Is <= 3424
                        Return 13
                    Case Is <= 3688
                        Return 14
                    Case Is <= 4184
                        Return 15
                    Case Is <= 4712
                        Return 16
                    Case Is <= 5176
                        Return 17
                    Case Is <= 5768
                        Return 18
                    Case Is <= 6360
                        Return 19
                    Case Is <= 6888
                        Return 20
                    Case Is <= 7456
                        Return 21
                    Case Is <= 8048
                        Return 22
                    Case Is <= 8752
                        Return 23
                    Case Is <= 9392
                        Return 24
                    Case Is <= 10208
                        Return 25
                    Case Is <= 10960
                        Return 26
                    Case Is <= 11744
                        Return 27
                    Case Is <= 12248
                        Return 28
                    Case Is <= 13048
                        Return 29
                    Case Is <= 13880
                        Return 30
                    Case Is <= 14744
                        Return 31
                    Case Is <= 15640
                        Return 32
                    Case Is <= 16568
                        Return 33
                    Case Is <= 17528
                        Return 34
                    Case Is <= 18448
                        Return 35
                    Case Is <= 19472
                        Return 36
                    Case Is <= 20528
                        Return 37
                    Case Is <= 21616
                        Return 38
                    Case Is <= 22496
                        Return 39
                    Case Is <= 23648
                        Return 40
                    Case Else
                        Return -1
                End Select

                'Corrección de errores del 15%
            Case QRCodeEncoder.ERROR_CORRECTION.M
                Select Case ibits
                    Case Is <= 128
                        Return 1
                    Case Is <= 224
                        Return 2
                    Case Is <= 352
                        Return 3
                    Case Is <= 512
                        Return 4
                    Case Is <= 688
                        Return 5
                    Case Is <= 864
                        Return 6
                    Case Is <= 992
                        Return 7
                    Case Is <= 1232
                        Return 8
                    Case Is <= 1456
                        Return 9
                    Case Is <= 1728
                        Return 10
                    Case Is <= 2032
                        Return 11
                    Case Is <= 2320
                        Return 12
                    Case Is <= 2672
                        Return 13
                    Case Is <= 2920
                        Return 14
                    Case Is <= 3320
                        Return 15
                    Case Is <= 3624
                        Return 16
                    Case Is <= 4056
                        Return 17
                    Case Is <= 4504
                        Return 18
                    Case Is <= 5016
                        Return 19
                    Case Is <= 5352
                        Return 20
                    Case Is <= 5712
                        Return 21
                    Case Is <= 6256
                        Return 22
                    Case Is <= 6880
                        Return 23
                    Case Is <= 7312
                        Return 24
                    Case Is <= 8000
                        Return 25
                    Case Is <= 8496
                        Return 26
                    Case Is <= 9024
                        Return 27
                    Case Is <= 9544
                        Return 28
                    Case Is <= 10136
                        Return 29
                    Case Is <= 10984
                        Return 30
                    Case Is <= 11640
                        Return 31
                    Case Is <= 12328
                        Return 32
                    Case Is <= 13048
                        Return 33
                    Case Is <= 13800
                        Return 34
                    Case Is <= 14496
                        Return 35
                    Case Is <= 15312
                        Return 36
                    Case Is <= 15936
                        Return 37
                    Case Is <= 16816
                        Return 38
                    Case Is <= 17728
                        Return 39
                    Case Is <= 18672
                        Return 40
                    Case Else
                        Return -1
                End Select

                'Corrección de errores del 25%
            Case QRCodeEncoder.ERROR_CORRECTION.Q
                Select Case ibits
                    Case Is <= 104
                        Return 1
                    Case Is <= 176
                        Return 2
                    Case Is <= 272
                        Return 3
                    Case Is <= 384
                        Return 4
                    Case Is <= 496
                        Return 5
                    Case Is <= 608
                        Return 6
                    Case Is <= 704
                        Return 7
                    Case Is <= 880
                        Return 8
                    Case Is <= 1056
                        Return 9
                    Case Is <= 1232
                        Return 10
                    Case Is <= 1440
                        Return 11
                    Case Is <= 1648
                        Return 12
                    Case Is <= 1952
                        Return 13
                    Case Is <= 2088
                        Return 14
                    Case Is <= 2360
                        Return 15
                    Case Is <= 2600
                        Return 16
                    Case Is <= 2936
                        Return 17
                    Case Is <= 3176
                        Return 18
                    Case Is <= 3560
                        Return 19
                    Case Is <= 3880
                        Return 20
                    Case Is <= 4096
                        Return 21
                    Case Is <= 4544
                        Return 22
                    Case Is <= 4912
                        Return 23
                    Case Is <= 5312
                        Return 24
                    Case Is <= 5744
                        Return 25
                    Case Is <= 6032
                        Return 26
                    Case Is <= 6464
                        Return 27
                    Case Is <= 6968
                        Return 28
                    Case Is <= 7288
                        Return 29
                    Case Is <= 7880
                        Return 30
                    Case Is <= 8264
                        Return 31
                    Case Is <= 8920
                        Return 32
                    Case Is <= 9368
                        Return 33
                    Case Is <= 9848
                        Return 34
                    Case Is <= 10288
                        Return 35
                    Case Is <= 10832
                        Return 36
                    Case Is <= 11408
                        Return 37
                    Case Is <= 12016
                        Return 38
                    Case Is <= 12656
                        Return 39
                    Case Is <= 13328
                        Return 40
                    Case Else
                        Return -1
                End Select

                ' Corrección de error del 30%
            Case QRCodeEncoder.ERROR_CORRECTION.H
                Select Case ibits
                    Case Is <= 72
                        Return 1
                    Case Is <= 128
                        Return 2
                    Case Is <= 208
                        Return 3
                    Case Is <= 288
                        Return 4
                    Case Is <= 368
                        Return 5
                    Case Is <= 480
                        Return 6
                    Case Is <= 528
                        Return 7
                    Case Is <= 688
                        Return 8
                    Case Is <= 800
                        Return 9
                    Case Is <= 976
                        Return 10
                    Case Is <= 1120
                        Return 11
                    Case Is <= 1264
                        Return 12
                    Case Is <= 1440
                        Return 13
                    Case Is <= 1576
                        Return 14
                    Case Is <= 1784
                        Return 15
                    Case Is <= 2024
                        Return 16
                    Case Is <= 2264
                        Return 17
                    Case Is <= 2504
                        Return 18
                    Case Is <= 2728
                        Return 19
                    Case Is <= 3080
                        Return 20
                    Case Is <= 3248
                        Return 21
                    Case Is <= 3536
                        Return 22
                    Case Is <= 3712
                        Return 23
                    Case Is <= 4112
                        Return 24
                    Case Is <= 4304
                        Return 25
                    Case Is <= 4768
                        Return 26
                    Case Is <= 5024
                        Return 27
                    Case Is <= 5288
                        Return 28
                    Case Is <= 5608
                        Return 29
                    Case Is <= 5960
                        Return 30
                    Case Is <= 6344
                        Return 31
                    Case Is <= 6760
                        Return 32
                    Case Is <= 7208
                        Return 33
                    Case Is <= 7688
                        Return 34
                    Case Is <= 7888
                        Return 35
                    Case Is <= 8432
                        Return 36
                    Case Is <= 8768
                        Return 37
                    Case Is <= 9136
                        Return 38
                    Case Is <= 9776
                        Return 39
                    Case Is <= 10208
                        Return 40
                    Case Else
                        Return -1
                End Select
        End Select
    End Function

    Private Sub establecerColorFondoQR()
        Dim dlSeleccionColor As New ColorDialog

        dlSeleccionColor.FullOpen = True
        dlSeleccionColor.Color =
            Color.FromArgb(pColorFondo.BackColor.ToArgb)
        If dlSeleccionColor.ShowDialog =
                Windows.Forms.DialogResult.OK Then
            pColorFondo.BackColor = dlSeleccionColor.Color
            colorFondoQR = pColorFondo.BackColor.ToArgb
        End If
        dlSeleccionColor.Dispose()
    End Sub

    Private Sub establecerColorQR()
        Dim dlSeleccionColor As New ColorDialog

        dlSeleccionColor.FullOpen = True
        dlSeleccionColor.Color =
            Color.FromArgb(pColorQR.BackColor.ToArgb)

        If dlSeleccionColor.ShowDialog =
                Windows.Forms.DialogResult.OK Then
            pColorQR.BackColor = dlSeleccionColor.Color
            colorQR = pColorFondo.BackColor.ToArgb
        End If
        dlSeleccionColor.Dispose()
    End Sub

    Private Sub btColorFondo_Click(sender As System.Object,
            e As System.EventArgs) _
            Handles btColorFondo.Click, pColorFondo.Click
        establecerColorFondoQR()
    End Sub

    Private Sub btColorQR_Click(sender As System.Object,
            e As System.EventArgs) _
            Handles btColorQR.Click, pColorQR.Click
        establecerColorQR()
    End Sub

    Private Sub pColorQR_Click(sender As System.Object,
            e As System.EventArgs)
        establecerColorQR()
    End Sub

    Private Sub pColorFondo_Click(sender As System.Object,
            e As System.EventArgs)
        establecerColorFondoQR()
    End Sub

    Private Sub formLeerGenerarCodigosQR_Load(sender As System.Object,
            e As System.EventArgs) Handles MyBase.Load
        lsNivelCorreccion.SelectedIndex = 1
        txtEscalaPixel.Text = 4

        pColorFondo.BackColor = Color.FromArgb(colorFondoQR)
        pColorQR.BackColor = Color.FromArgb(colorQR)

        tabFormatoQR.SelectedTab = tabQRSMS
        txtSMSMensaje_TextChanged(sender, e)
    End Sub

    Private Sub txtSMSMensaje_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtSMSMensaje.TextChanged,
            txtSMSNumeroTelefono.TextChanged
        txtTextoQR.Text = "SMSTO:" + txtSMSNumeroTelefono.Text +
            ":" + txtSMSMensaje.Text
    End Sub

    Private Sub txtURL_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtURL.TextChanged
        txtTextoQR.Text = txtURL.Text
    End Sub

    Private Sub txtTextoLibre_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtTextoLibre.TextChanged
        txtTextoQR.Text = txtTextoLibre.Text
    End Sub

    Private Sub txtNumeroTelefono_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtNumeroTelefono.TextChanged
        txtTextoQR.Text = "TEL:" + txtNumeroTelefono.Text
    End Sub

    Private Sub txtVcardNombre_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtVcardNombre.TextChanged,
            txtVcardURL.TextChanged, txtVcardTelefono.TextChanged,
            txtVcardMail.TextChanged, txtVcardEmpresa.TextChanged,
            txtVcardDireccion.TextChanged, txtVcardCargo.TextChanged
        txtTextoQR.Text = "BEGIN:VCARD" + vbCrLf + "N:" + txtVcardNombre.Text + _
            vbCrLf + "TITLE:" + txtVcardCargo.Text + vbCrLf + "ORG:" + _
            txtVcardEmpresa.Text + vbCrLf + "ADDR:" + txtVcardDireccion.Text + _
            vbCrLf + "TEL:" + txtVcardTelefono.Text + vbCrLf + "EMAIL:" + _
            txtVcardMail.Text + vbCrLf + "URL:" +
            txtVcardURL.Text + vbCrLf + "END:VCARD"
    End Sub

    Private Sub txtEMailDestinatario_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtEMailDestinatario.TextChanged,
            txtEMailMensaje.TextChanged, txtEMailAsunto.TextChanged
        txtTextoQR.Text = "SMTP:" + txtEMailDestinatario.Text + _
            ":" + txtEMailAsunto.Text + ":" + txtEMailMensaje.Text
    End Sub

    Private Sub txtEventoAsunto_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtEventoAsunto.TextChanged,
            txtEventoUbicacion.TextChanged, txtEventoHastaHora.ValueChanged,
            txtEventoHasta.ValueChanged, txtEventoDesdeHora.ValueChanged,
            txtEventoDesde.ValueChanged, txtEventoDescripcion.TextChanged
        txtTextoQR.Text = "BEGIN:VEVENT" + vbCrLf + "SUMMARY:" +
            txtEventoAsunto.Text + vbCrLf +
            "DTSTART:" +
            txtEventoDesde.Value.Year.ToString("0000") +
            txtEventoDesde.Value.Month.ToString("00") +
            txtEventoDesde.Value.Day.ToString("00") +
            "T" + txtEventoDesdeHora.Value.Hour.ToString("00") +
            txtEventoDesdeHora.Value.Minute.ToString("00") +
            "00" + vbCrLf +
            "DTEND:" + txtEventoHasta.Value.Year.ToString("0000") +
            txtEventoHasta.Value.Month.ToString("00") +
            txtEventoHasta.Value.Day.ToString("00") +
            "T" + txtEventoHastaHora.Value.Hour.ToString("00") +
            txtEventoHastaHora.Value.Minute.ToString("00") +
            "00" + vbCrLf +
            "LOCATION:" + txtEventoUbicacion.Text + vbCrLf +
            "DESCRIPTION:" + txtEventoDescripcion.Text +
            vbCrLf + "END:VEVENT"
    End Sub

    Private Sub btGenerarQR_Click(sender As System.Object,
            e As System.EventArgs) Handles btGenerarQR.Click
        If txtEscalaPixel.Text.Trim = "" Then
            MsgBox("Debe indicar la escala de los píxeles del " +
                   "QR que se generará.",
                   MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            txtEscalaPixel.Focus()
        Else

            If Val(txtEscalaPixel.Text) = 0 Then
                txtEscalaPixel.Text = 4
            End If

            Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
            generarCodigoQR.QRCodeEncodeMode =
                Codec.QRCodeEncoder.ENCODE_MODE.BYTE
            generarCodigoQR.QRCodeScale = Int32.Parse(txtEscalaPixel.Text)

            Select Case lsNivelCorreccion.Text
                Case "Bajo (7%)"
                    generarCodigoQR.QRCodeErrorCorrect =
                        Codec.QRCodeEncoder.ERROR_CORRECTION.L
                Case "Medio (15%)"
                    generarCodigoQR.QRCodeErrorCorrect =
                        Codec.QRCodeEncoder.ERROR_CORRECTION.M
                Case "Alto (25%)"
                    generarCodigoQR.QRCodeErrorCorrect =
                        Codec.QRCodeEncoder.ERROR_CORRECTION.Q
                Case "Muy alto (30%)"
                    generarCodigoQR.QRCodeErrorCorrect =
                        Codec.QRCodeEncoder.ERROR_CORRECTION.H
            End Select

            'La versión "0" calcula automáticamente el tamaño
            generarCodigoQR.QRCodeVersion = 0

            '' --------- Forzar una determinada version -----------
            ''En caso de querer forzar una determinada version 
            '(tamaño) el siguiente código devuelve la
            ''versión mínima para el texto que se quiere códificar:
            'Dim iVersion As Integer = 
            '    AdjustQRVersion(TextBox1.Text, QRCodeEncoder.QRCodeErrorCorrect)
            'If iVersion = -1 Then
            '    MessageBox.Show("El texto es demasiado grande o el " +
            '        "Correction Level (ERROR_CORRECTION) no es el apropiado")
            '    Exit Sub
            'Else
            '    qrCodeEncoder.QRCodeVersion = iVersion
            'End If
            '' -----------------------------------------------------

            generarCodigoQR.QRCodeBackgroundColor =
                System.Drawing.Color.FromArgb(colorFondoQR)
            generarCodigoQR.QRCodeForegroundColor =
                System.Drawing.Color.FromArgb(colorQR)

            Try
                If opForzarUTF.Checked Then
                    'Con UTF-8 podremos añadir caracteres como ñ, tildes, etc.
                    imgQR.Image = generarCodigoQR.Encode(txtTextoQR.Text,
                                    System.Text.Encoding.UTF8)
                Else
                    imgQR.Image = generarCodigoQR.Encode(txtTextoQR.Text)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub txtRedWifiSSID_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtRedWifiSSID.TextChanged,
            txtRedWifiContrasena.TextChanged, lsRedWifiTipo.TextChanged
        Dim tipoWifi As String = "nopass"
        If lsRedWifiTipo.Text = "Sin encriptación" Then
            tipoWifi = "nopass"
        End If
        If lsRedWifiTipo.Text = "WPA/WPA2" Then
            tipoWifi = "WPA"
        End If
        If lsRedWifiTipo.Text = "WEP" Then
            tipoWifi = "WEP"
        End If
        txtTextoQR.Text = "WIFI:S:" + txtRedWifiSSID.Text + ";T:" +
            tipoWifi + ";P:" + txtRedWifiContrasena.Text + ";;"
    End Sub

    Private Sub txtGeoLatitud_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtGeoLatitud.TextChanged,
            txtGeoLongitud.TextChanged, txtGeoConsulta.TextChanged
        txtTextoQR.Text = "geo:" + txtGeoLatitud.Text + "," +
            txtGeoLongitud.Text + "?=" + txtGeoConsulta.Text
    End Sub


    Private Sub btGuardarQR_Click(sender As System.Object,
            e As System.EventArgs) Handles btGuardarQR.Click
        Dim dlGuardar As New SaveFileDialog

        If IsNothing(imgQR.Image) Then
            MsgBox("No se ha generado el Código QR. Antes de guardar " +
                   "debe generar un código QR.",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            dlGuardar.Filter = "JPEG|*.jpg|Mapa de Bits|*.bmp|Gif|*.gif|PNG|*.png"
            dlGuardar.Title = "Guardar código QR"
            dlGuardar.FileName = "codigo_qr"
            dlGuardar.ShowDialog()
            If (dlGuardar.FileName <> "") Then
                Select Case dlGuardar.FilterIndex
                    Case 1
                        imgQR.Image.Save(dlGuardar.FileName,
                            System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case 2
                        imgQR.Image.Save(dlGuardar.FileName,
                            System.Drawing.Imaging.ImageFormat.Bmp)
                    Case 3
                        imgQR.Image.Save(dlGuardar.FileName,
                            System.Drawing.Imaging.ImageFormat.Gif)
                    Case 4
                        imgQR.Image.Save(dlGuardar.FileName,
                            System.Drawing.Imaging.ImageFormat.Png)
                End Select
            End If
        End If
    End Sub

    Private Sub btImprimirQR_Click(sender As System.Object,
                e As System.EventArgs) Handles btImprimirQR.Click
        If IsNothing(imgQR.Image) Then
            MsgBox("No se ha generado el Código QR. Antes de " +
                   "imprimir debe generar un código QR.",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            dlImprimir.Document = imprimirDoc
            If dlImprimir.ShowDialog = Windows.Forms.DialogResult.OK Then
                imprimirDoc.Print()
            End If
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As System.Object,
          e As System.Drawing.Printing.PrintPageEventArgs) _
              Handles imprimirDoc.PrintPage
        e.Graphics.DrawImage(imgQR.Image, 0, 0)
    End Sub

    Private Sub btSelImagenQR_Click(sender As System.Object,
            e As System.EventArgs) Handles btSelImagenQR.Click
        Dim dlAbrirImagenQR As New OpenFileDialog

        dlAbrirImagenQR.InitialDirectory =
            My.Computer.FileSystem.SpecialDirectories.MyPictures
        dlAbrirImagenQR.Filter = "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png"
        dlAbrirImagenQR.RestoreDirectory = True
        dlAbrirImagenQR.CheckFileExists = True
        dlAbrirImagenQR.CheckPathExists = True
        If dlAbrirImagenQR.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtLeerQRImagen.Text = dlAbrirImagenQR.FileName
        End If
    End Sub

    Private Sub btDecodificarImagenQR_Click(sender As System.Object,
            e As System.EventArgs) Handles btDecodificarImagenQR.Click
        If IsNothing(imgQRExistente.Image) Then
            MsgBox("Antes de decodificar una imagen QR a su texto " +
                   "correspondiente QR Code debe seleccionar la imagen.",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            btSelImagenQR.Focus()
        Else
            Try
                Dim decoder As QRCodeDecoder = New QRCodeDecoder
                If opLeerForzarUTF8.Checked Then
                    txtLeerQRTexto.Text =
                        decoder.decode(New QRCodeBitmapImage( _
                                       New Bitmap(imgQRExistente.Image)),
                                   System.Text.Encoding.UTF8)
                Else
                    txtLeerQRTexto.Text =
                        decoder.decode(New QRCodeBitmapImage( _
                                       New Bitmap(imgQRExistente.Image)))
                End If
            Catch ex As Exception
                MsgBox(ex.Message,
                       MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub txtLeerQRImagen_TextChanged(sender As System.Object,
            e As System.EventArgs) Handles txtLeerQRImagen.TextChanged
        If System.IO.File.Exists(txtLeerQRImagen.Text) Then
            imgQRExistente.Image = New Bitmap(txtLeerQRImagen.Text)
        End If
    End Sub

    Private Sub tabFormatoQR_SelectedIndexChanged(sender As System.Object, _
               e As System.EventArgs) Handles tabFormatoQR.SelectedIndexChanged
        If tabFormatoQR.SelectedTab Is tabQRSMS Then
            txtSMSMensaje_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQRURL Then
            txtURL_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQRTexto Then
            txtTextoLibre_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQRNumeroTelefono Then
            txtNumeroTelefono_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQRVcard Then
            txtVcardNombre_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQRMAIL Then
            txtEMailDestinatario_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQREvento Then
            txtEventoAsunto_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQRRedWifi Then
            txtRedWifiSSID_TextChanged(sender, e)
        End If

        If tabFormatoQR.SelectedTab Is tabQRGeolocalizacion Then
            txtGeoLatitud_TextChanged(sender, e)
        End If
    End Sub

    Private Sub linkURL_LinkClicked(sender As System.Object, _
                e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) _
                Handles linkURL.LinkClicked
        System.Diagnostics.Process.Start("http://www.ajpdsoft.com")
    End Sub
End Class