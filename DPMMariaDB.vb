Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.ComponentModel

'*----------------------------------------------------------------------*
'* PMovilD - Pago Movil Dynamics                   R1.V0.M0 (Prerelase) *
'* Desarrollo y Sistemas                           Fecha: 12/02/2021    *
'*----------------------------------------------------------------------*
'* Modulo           : DPMMariaDB - Estructura DB en MariaDB 10.3        *
'* Owner            : JR Sistemas24, Co.                                *
'* Programmed by    : Lic. Jaime Manuel Roza Pedreira                   *
'*----------------------------------------------------------------------*
'*                    Control de Cambios (Codigo Fuente)                *
'*----------------------------------------------------------------------*
'*    Fecha   | Mod. | Descripcion Cambios                 | VSVr | net *
'*------------|------|-------------------------------------|------|-----*
'* 19/02/2021 | 01-1 | Creacion del modulo DPMMariaDB      | 2010 | 4.0 *
'*------------|------|-------------------------------------|------|-----*

Public Class DPMMariaDB
    'Variables Publicas Modulo: DPMMariaDB
    Public FHoy As Date
    Public ThisMoment As Date
    Public indice As Integer
    Public fTime As Boolean

    'Definicion del Arbol de Tablas de PMovilD
    Public Troot As String
    Public TNode As String

    'Parametros Dataset
    Public MRSDBcon As New OdbcConnection
    Public DBProvider As String
    Public DBSource As String
    Public DBPath As String
    Public DBName As String

    'Variables para DB01 (Vista de Datos Tabla 01)
    Public DSetDB01 As New DataSet
    Public DAdpDB01 As OdbcDataAdapter
    Public cmdSQL01 As String

    'Variables para DB02 (Vista de Datos Tabla 02)
    Public DSetDB02 As New DataSet
    Public DAdpDB02 As OdbcDataAdapter
    Public cmdSQL02 As String

    'Variables para DB03 (Vista de Datos Tabla 03)
    Public DSetDB03 As New DataSet
    Public DAdpDB03 As OdbcDataAdapter
    Public cmdSQL03 As String

    'Variables para DB04 (Vista de Datos Tabla 04)
    Public DSetDB04 As New DataSet
    Public DAdpDB04 As OdbcDataAdapter
    Public cmdSQL04 As String

    'Variables para DB05 (Vista de Datos Tabla 05)
    Public DSetDB05 As New DataSet
    Public DAdpDB05 As OdbcDataAdapter
    Public cmdSQL05 As String

    'Variables para DB06 (Vista de Datos Tabla 06)
    Public DSetDB06 As New DataSet
    Public DAdpDB06 As OdbcDataAdapter
    Public cmdSQL06 As String

    'Variables para DB08 (Vista de Datos Tabla 07)
    Public DSetDB07 As New DataSet
    Public DAdpDB07 As OdbcDataAdapter
    Public cmdSQL07 As String

    'Variables para DB08 (Vista de Datos Tabla 08)
    Public DSetDB08 As New DataSet
    Public DAdpDB08 As OdbcDataAdapter
    Public cmdSQL08 As String

    'Variables para DB09 (Vista de Datos Tabla 09)
    Public DSetDB09 As New DataSet
    Public DAdpDB09 As OdbcDataAdapter
    Public cmdSQL09 As String

    'Variables para DBT (Temporal Estructura BD)
    Public DSetDBT As New DataSet
    Public DAdpDBT As OdbcDataAdapter
    Public cmdSQLDBT As String

    Private Sub DPMMariaDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '*-------------------------------------------------------------------------------------------------*
        '* PMovilD - Pago Movil Dynamics                                              R1.V0.M0 (Prerelase) *
        '* JR Sistemas24, Co.                                                         Fecha: 12/02/2021    *
        '*-------------------------------------------------------------------------------------------------*
        '* Modulo           : DPMMariaDB - Revisar estructura de BD: PMovilD - MariaDB 10.3.1              *
        '* Rutina           : DPMMariaDB_Load ---> Carga la forma DPMMariaDB                               *
        '* Owner            : Copyright (C) 2021 - JR Sistemas24, Co.                                      *
        '* Programmed by    : Lic. Jaime Manuel Roza Pedreira                                              *
        '*-------------------------------------------------------------------------------------------------*
        Dim PagoMDT As DataTable
        Dim dr As DataRow

        MRSDBcon.ConnectionString = Global.PMovilD.My.MySettings.Default.MRSDataMDB
        MRSDBcon.Open()

        PagoMDT = MRSDBcon.GetSchema("Tables")

        FHoy = Today
        ThisMoment = Now
        fTime = True

        TableTree.Nodes.Clear()
        Troot = "Estructura de la Base de Datos: PMovilD - (MariaDB 10.3.4)"
        TableTree.Nodes.Add(Troot)

        For Each dr In PagoMDT.Rows
            If (dr("Table_Name")).ToString.StartsWith("mrs") Then
                TNode = (dr("Table_Name")).ToString
                TableTree.Nodes(0).Nodes.Add(TNode)
            End If
        Next
        TableTree.ExpandAll()
    End Sub

    Private Sub TableTree_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TableTree.AfterSelect
        '*-------------------------------------------------------------------------------------------------*
        '* PMovilD - Pago Movil Dynamics                                              R1.V0.M0 (Prerelase) *
        '* JR Sistemas24, Co.                                                         Fecha: 12/02/2021    *
        '*-------------------------------------------------------------------------------------------------*
        '* Modulo           : DPMMariaDB - Revisar estructura de BD: PMovilD - MariaDB 10.3.1              *
        '* Rutina           : TableTree_AfterSelect ---> Seleccionar la tabla a revisar                    *
        '* Owner            : Copyright (C) 2021 - JR Sistemas24, Co.                                      *
        '* Programmed by    : Lic. Jaime Manuel Roza Pedreira                                              *
        '*-------------------------------------------------------------------------------------------------*
        Dim NameDB As String

        indice = e.Node.Index

        NameDB = TableTree.Nodes(0).Nodes(indice).Text.ToLower

        If fTime = False Then
            DSetDBT.Clear()
            DSetDB01.Clear()
            DSetDB02.Clear()
            DSetDB03.Clear()
            DSetDB04.Clear()
            DSetDB05.Clear()
            DSetDB06.Clear()
            DSetDB07.Clear()
            DSetDB08.Clear()
            DSetDB09.Clear()
        Else
            fTime = False
        End If

        cmdSQLDBT = "SELECT * FROM MRS_Struct WHERE DBS_DataBN = '" & NameDB & "' ORDER BY DBS_Id"
        DAdpDBT = New OdbcDataAdapter(cmdSQLDBT, MRSDBcon)
        DAdpDBT.Fill(DSetDBT, "TableS")

        FieldDG.DataSource = DSetDBT.Tables("TableS")
        FieldDG.Refresh()

        Select Case indice
            Case 0
                cmdSQL01 = "SELECT * FROM " + NameDB
                DAdpDB01 = New OdbcDataAdapter(cmdSQL01, MRSDBcon)
                DAdpDB01.Fill(DSetDB01, "Table1")
                TblData.DataSource = DSetDB01.Tables("Table1")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 1
                cmdSQL02 = "SELECT * FROM " + NameDB
                DAdpDB02 = New OdbcDataAdapter(cmdSQL02, MRSDBcon)
                DAdpDB02.Fill(DSetDB02, "Table2")
                TblData.DataSource = DSetDB02.Tables("Table2")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 2
                cmdSQL03 = "SELECT * FROM " + NameDB
                DAdpDB03 = New OdbcDataAdapter(cmdSQL03, MRSDBcon)
                DAdpDB03.Fill(DSetDB03, "Table3")
                TblData.DataSource = DSetDB03.Tables("Table3")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 3
                cmdSQL04 = "SELECT * FROM " + NameDB
                DAdpDB04 = New OdbcDataAdapter(cmdSQL04, MRSDBcon)
                DAdpDB04.Fill(DSetDB04, "Table4")
                TblData.DataSource = DSetDB04.Tables("Table4")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 4
                cmdSQL05 = "SELECT * FROM " + NameDB
                DAdpDB05 = New OdbcDataAdapter(cmdSQL05, MRSDBcon)
                DAdpDB05.Fill(DSetDB05, "Table5")
                TblData.DataSource = DSetDB05.Tables("Table5")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 5
                cmdSQL06 = "SELECT * FROM " + NameDB
                DAdpDB06 = New OdbcDataAdapter(cmdSQL06, MRSDBcon)
                DAdpDB06.Fill(DSetDB06, "Table6")
                TblData.DataSource = DSetDB06.Tables("Table6")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 6
                cmdSQL07 = "SELECT * FROM " + NameDB
                DAdpDB07 = New OdbcDataAdapter(cmdSQL07, MRSDBcon)
                DAdpDB07.Fill(DSetDB07, "Table7")
                TblData.DataSource = DSetDB07.Tables("Table7")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 7
                cmdSQL08 = "SELECT * FROM " + NameDB
                DAdpDB08 = New OdbcDataAdapter(cmdSQL08, MRSDBcon)
                DAdpDB08.Fill(DSetDB08, "Table8")
                TblData.DataSource = DSetDB08.Tables("Table8")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
            Case 8
                cmdSQL09 = "SELECT * FROM " + NameDB
                DAdpDB09 = New OdbcDataAdapter(cmdSQL09, MRSDBcon)
                DAdpDB09.Fill(DSetDB09, "Table9")
                TblData.DataSource = DSetDB09.Tables("Table9")
                TblData.Sort(TblData.Columns(0), ListSortDirection.Ascending)
        End Select
    End Sub
End Class