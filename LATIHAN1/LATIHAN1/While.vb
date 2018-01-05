'KODE 3.1 While.vb
'belajar menggunakan perulangan while
'Sabtu, 18 November 2017

Module Whileku
    Sub main()
        'mendeklarasikan variabel nilai dan mengisinya
        Dim nilai As Integer = 2

        'ketika hasil kurang atau sama dengan 1000
        While nilai <= 1000
            Console.Write("{0} ", nilai)
            nilai = nilai * 2
        End While

        Console.WriteLine()

        'menampilkan nilai
        Console.WriteLine("pangkat 2 terkecil " & "yang lebih besar dari 1000 adalah {0}", nilai)
        Console.ReadLine()
    End Sub
End Module
