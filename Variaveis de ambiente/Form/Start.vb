Imports System.Environment
Public Class Start
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbVar.Items.Clear()
        lbVar.Items.Add("Meus Documentos: " & GetFolderPath(SpecialFolder.MyDocuments))
        lbVar.Items.Add("Arquivos de Programas (x86): " & GetFolderPath(SpecialFolder.ProgramFiles))
        lbVar.Items.Add("Pasta System32: " & GetFolderPath(SpecialFolder.System))
        lbVar.Items.Add(GetFolderPath(SpecialFolder.Desktop))
        lbVar.Items.Add("----------------------------")
        lbVar.Items.Add("Drives do Sistema: " & Join(GetLogicalDrives, ", "))
        lbVar.Items.Add("Nome do Computador: " & MachineName)
        lbVar.Items.Add("Versão do Sistema: " & OSVersion.VersionString)
        lbVar.Items.Add("Diretorio Atual: " & CurrentDirectory)
        lbVar.Items.Add("Contador de Processador: " & ProcessorCount)
        lbVar.Items.Add("Diretorio EXE:" & Environment.CommandLine)
        lbVar.Items.Add("Se for True é 64Bits: " & Environment.Is64BitOperatingSystem)
    End Sub
End Class
