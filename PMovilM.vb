Module PMovilM
    Public Function MesString(ByVal CurrMth As Integer) As String
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: PMovilM     - Modulo VB.net de funciones publicas de PMDynamics                                                                '   
        ' Function MesString  - Obtiene el nombre del mes desde el valor numerico                                                                '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim mString As String

        mString = ""
        Select Case CurrMth
            Case 1
                mString = "Enero"
            Case 2
                mString = "Febrero"
            Case 3
                mString = "Marzo"
            Case 4
                mString = "Abril"
            Case 5
                mString = "Mayo"
            Case 6
                mString = "Junio"
            Case 7
                mString = "Julio"
            Case 8
                mString = "Agosto"
            Case 9
                mString = "Septiembre"
            Case 10
                mString = "Octubre"
            Case 11
                mString = "Noviembre"
            Case 12
                mString = "Diciembre"
        End Select

        MesString = mString
    End Function

    Public Function MesNumber(ByVal CMthStr As String) As Integer
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: PMovilM     - Modulo VB.net de funciones publicas de PMDynamics                                                                '   
        ' Function MesNumber  - Obtiene el numero de mes desde el valor alfabetico                                                               '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        Dim mInt As Integer

        mInt = 0
        Select Case CMthStr
            Case "Enero"
                mInt = 1
            Case "Febrero"
                mInt = 2
            Case "Marzo"
                mInt = 3
            Case "Abril"
                mInt = 4
            Case "Mayo"
                mInt = 5
            Case "Junio"
                mInt = 6
            Case "Julio"
                mInt = 7
            Case "Agosto"
                mInt = 8
            Case "Septiembre"
                mInt = 9
            Case "Octubre"
                mInt = 10
            Case "Noviembre"
                mInt = 11
            Case "Diciembre"
                mInt = 12
        End Select

        MesNumber = mInt
    End Function

    Function DBStruct(ByVal FName As String, ByVal FType As String) As Boolean
        '----------------------------------------------------------------------------------------------------------------------------------------'
        ' JR Sistemas24, Co.                                                                                                                     '
        ' PMovilD - Pago Movil Dynamics - Copyright (C) 2021                                                                                     '
        ' Desarrollado por: Lic. Jaime M. Roza Pedreira                                                                                          '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        '                                                                                                                                        '
        ' Modulo: DPMPagoM - Pago Movil Dynamics                                                                                                 '   
        ' Function DBStruct  - Genera el workarea de Estructuras de BD                                                                           '
        '                                                                                                                                        '
        '----------------------------------------------------------------------------------------------------------------------------------------'
        'Definicion del comando SQL de Insercion de Datos (INSERT)
        Dim ConnSQLTF As New OdbcConnection
        Dim iSQLLog As String
        Dim iresult As Integer

        ConnSQLTF.ConnectionString = Global.PMovilD.My.MySettings.Default.PMDConnect

        iSQLLog = "INSERT INTO MRS_Struct" & _
         "(DBS_Field, DBS_Type)" & _
         " VALUES (?, ?) "

        Dim SQLCmd As New OdbcCommand(iSQLLog, ConnSQLTF)

        'Parametros del comando SQL --> Estructura DB Access
        'Parametros de Estructura BD
        Dim DBFD As New OdbcParameter("DBFD", OdbcType.VarChar, 255)               'Nombre Campo BD
        Dim DBTP As New OdbcParameter("DBTP", OdbcType.VarChar, 255)               'Tipo de Datos

        'Parametros de la Tabla: MRS_Struct
        'Nombre Campo BD
        DBFD.SourceColumn = "DBS_Field"
        SQLCmd.Parameters.Add(DBFD)
        SQLCmd.Parameters("DBFD").Value = FName

        'Tipo Datos Campo BD
        DBTP.SourceColumn = "DBS_Type"
        SQLCmd.Parameters.Add(DBTP)
        SQLCmd.Parameters("DBTP").Value = FType

        ConnSQLTF.Open()
        iresult = SQLCmd.ExecuteNonQuery
        ConnSQLTF.Close()

        DBStruct = True
    End Function
End Module
