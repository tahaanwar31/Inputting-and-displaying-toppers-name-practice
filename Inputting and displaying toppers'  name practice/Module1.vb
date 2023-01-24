Module Module1

    Sub Main()
        Dim name As String
        Dim count As Integer
        name = ""
        count = 1
        FileOpen(1, My.Application.Info.DirectoryPath & "\BCCPASToppers", OpenMode.Output)
        For count = 1 To 5
            count = count + 1
            Console.WriteLine("Enter the student's name: ")
            name = Console.ReadLine()
            WriteLine(1, name)
        Next
        FileClose(1)
        FileOpen(1, My.Application.Info.DirectoryPath & "\BCCPASToppers", OpenMode.Input)
        Console.WriteLine("Congratulations!Beaconhouse PECHS Campus is proud of you all!")
        While Not EOF(1)
            Input(1, name)
            Console.WriteLine(name)
        End While
        FileClose(1)
        Console.ReadKey()
    End Sub

End Module
