Imports System.Diagnostics
Imports System.IO

Module Executor

    'Private Const PROGRAM_PATH As String = "C:\windows\system32\notepad.exe"
    Private Const SC4_KEY As String = "SOFTWARE\\Maxis\\SimCity 4"
    Sub Main()
        'Dim childProc As Process = Process.Start(PROGRAM_PATH)
        'childProc.ProcessorAffinity = 1
        'childProc.WaitForExit()
        Dim sc4Key = My.Computer.Registry.LocalMachine.OpenSubKey(SC4_KEY, False)
        If sc4Key Is Nothing Then
            MsgBox("Sim City 4 is not installed!")
            Return
        End If

        Dim instDir As String = sc4Key.GetValue("Install Dir").ToString
        Dim sc4Path As String = instDir + "\Apps\SimCity 4.exe"
        If Not File.Exists(sc4Path) Then
            MsgBox("SimCity is not exists at install path, please run installer again!")
            Return
        End If

        Dim childProc As Process = Process.Start(sc4Path)
        childProc.ProcessorAffinity = 1
        childProc.WaitForExit()
    End Sub

End Module
