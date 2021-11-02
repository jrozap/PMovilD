' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
'Copyright (C) Microsoft Corporation.  All rights reserved.
Imports System
Imports System.Security
Imports System.Security.Permissions
Imports System.Runtime.InteropServices

Public Module VBSecurity1
    Public Sub Main()
        'Create File IO Read permission
        Dim FileIOReadPermission As New FileIOPermission(PermissionState.None)
        FileIOReadPermission.AllLocalFiles = FileIOPermissionAccess.Read

        'Create Base Permission Set
        Dim BasePermissionSet = New PermissionSet(PermissionState.None) '  // PermissionState.Unrestricted for full trust
        BasePermissionSet.AddPermission(New SecurityPermission(SecurityPermissionFlag.Execution))

        Dim grantset = BasePermissionSet.Copy
        grantset.AddPermission(FileIOReadPermission)

        'Write Sample source file to read
        System.IO.File.WriteAllText("TEST.TXT", "File Content")

        '-------- Calling Method in Full Trust -------- 
        Try
            Console.WriteLine("App Domain Name: " & AppDomain.CurrentDomain.FriendlyName)
            ReadFileMethod()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        '-------- Create the AppDomain with FileIO Read Permission -------- 
        Dim sandbox = AppDomain.CreateDomain("Sandboxed AppDomain With FileIO.Read permission", AppDomain.CurrentDomain.Evidence, AppDomain.CurrentDomain.SetupInformation, grantset, Nothing)
        Try

            Console.WriteLine("App Domain Name: " & AppDomain.CurrentDomain.FriendlyName)
            sandbox.DoCallBack(New CrossAppDomainDelegate(AddressOf ReadFileMethod))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        '-------- Create the AppDomain without FileIO Read Permission -------- 
        'Expect Security Exception to be thrown

        Dim grantset2 = BasePermissionSet.Copy
        Dim sandbox2 = AppDomain.CreateDomain("Sandboxed AppDomain Without FileIO.Read permission", AppDomain.CurrentDomain.Evidence, AppDomain.CurrentDomain.SetupInformation, grantset2, Nothing)
        Try
            Console.WriteLine("App Domain Name: " & AppDomain.CurrentDomain.FriendlyName)
            sandbox2.DoCallBack(New CrossAppDomainDelegate(AddressOf ReadFileMethod))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.WriteLine("")
        Console.WriteLine("Press any key to end.")
        Console.ReadKey()
    End Sub

    Public Sub ReadFileMethod()
        Dim S As String = System.IO.File.ReadAllText("TEST.TXT")
        Console.WriteLine("File Content: " & S)
        Console.WriteLine("")
    End Sub
End Module