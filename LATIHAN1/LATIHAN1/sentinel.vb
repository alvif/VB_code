'kode 404 sentinel.vb
'menggunakan struktur repetisi terkendali sentinel
'untuk memproses nilai rerata kelas

Module sentinel
    Sub main()
        Dim jumlah, kounterNilai, nilai As Integer
        Dim rerata As Double
        Dim jawab As String

        'inisialisasi
        jumlah = 0
        kounterNilai = 0

        Console.WriteLine("============================================================")
        Console.WriteLine("============================================================")
        Console.WriteLine("=====>>      Penghitung Rerata Nilai sederhana       <<=====")
        Console.WriteLine("------------------------------------------------------------")
        Console.WriteLine("===========>>   By : Alvif Sandana Mahardika   <<===========")
        Console.WriteLine("============================================================")
        Console.WriteLine("============================================================")
        Console.WriteLine()
        Console.WriteLine()

        'proses
        Console.Write("masukkan nilai ujian, tekan -1 untuk keluar: ")
        nilai = Console.ReadLine()

        'loop terkendali sentinel dengan 0 sebagai sentinel
        While nilai <> -1
            jumlah += nilai
            kounterNilai += 1

            'meminta input kembali 
            Console.Write("masukkan nilai ujian, tekan -1 untuk keluar: ")
            nilai = Console.ReadLine()
        End While

        'terminasi
        If kounterNilai <> 0 Then
            rerata = jumlah / kounterNilai

            'tampilkan rerata nilai 
            Console.WriteLine()
            Console.WriteLine("rerata nilai adalah {0:F}", rerata)
            Console.ReadLine()
        Else
            Console.WriteLine("Tidak ada nilai yang dimasukan.")
            Console.ReadLine()
        End If

        Console.WriteLine("Apakah kamu ingin menghitung lagi? ketik y jika ya, n jika tidak: ")
        jawab = Console.ReadLine()

        'If jawab = "y" Then
        '    jumlah = 0
        '    kounterNilai = 0

        '    Console.WriteLine("============================================================")
        '    Console.WriteLine("============================================================")
        '    Console.WriteLine("=====>>      Penghitung Rerata Nilai sederhana       <<=====")
        '    Console.WriteLine("------------------------------------------------------------")
        '    Console.WriteLine("===========>>   By : Alvif Sandana Mahardika   <<===========")
        '    Console.WriteLine("============================================================")
        '    Console.WriteLine("============================================================")
        '    Console.WriteLine()
        '    Console.WriteLine()

        '    'proses
        '    Console.Write("masukkan nilai ujian, tekan -1 untuk keluar: ")
        '    nilai = Console.ReadLine()

        '    'loop terkendali sentinel dengan 0 sebagai sentinel
        '    While nilai <> -1
        '        jumlah += nilai
        '        kounterNilai += 1

        '        'meminta input kembali 
        '        Console.Write("masukkan nilai ujian, tekan -1 untuk keluar: ")
        '        nilai = Console.ReadLine()
        '    End While

        '    'terminasi
        '    If kounterNilai <> 0 Then
        '        rerata = jumlah / kounterNilai

        '        'tampilkan rerata nilai 
        '        Console.WriteLine()
        '        Console.WriteLine("rerata nilai adalah {0:F}", rerata)
        '        Console.ReadLine()
        '    Else
        '        Console.WriteLine("Tidak ada nilai yang dimasukan.")
        '        Console.ReadLine()
        '    End If

        'Else
        '    End
        'End If

    End Sub
End Module
