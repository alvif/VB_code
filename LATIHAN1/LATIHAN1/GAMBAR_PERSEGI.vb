Module GAMBAR_PERSEGI

    Sub main()
        Dim sisi As Integer 'sisi persegi
        Dim baris As Integer = 1 'baris saat ini
        Dim kolom As Integer 'kolom saat ini

        'input sisi dari pengguna
        Console.Write("Masukin panjang sisi persegi (20 ato kurang): ")
        sisi = Console.ReadLine()

        If sisi <= 20 Then

            While baris <= sisi
                kolom = 1

                'loop ini menampilkan satu baris karakter *
                'dan bersarang didalam while di atas 
                While kolom <= sisi
                    Console.Write("# ")
                    kolom += 1
                End While

                Console.WriteLine()
                baris += 1
            End While

        Else
            Console.WriteLine("Sisi terlalu gede :V")
        End If

        Console.ReadLine()

    End Sub

End Module
