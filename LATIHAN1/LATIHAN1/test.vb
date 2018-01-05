Module test
    Sub main()
        Dim N As Integer = 1
        Dim nPuluh As Integer
        Dim nRatus As Integer

        Console.Write("masukkan integer: ")
        N = Console.ReadLine()

        Do While N <= 100
            Console.WriteLine("{0}{1}{2}{3}", N, vbCr, nRatus, vbCrLf)
            N += 1

            nPuluh = N * 10
            nRatus = N * 100
        Loop

        'Console.WriteLine("N {1}{2}N*10 {3}{4}N*100 {5}{6}", N, vbCrLf, nPuluh, vbCrLf, nRatus, vbCrLf)
        Console.ReadLine()
    End Sub
End Module
