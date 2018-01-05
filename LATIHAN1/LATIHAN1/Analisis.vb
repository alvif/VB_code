Module Analisis

    Sub Main()
        Dim keberhasilan As Integer = 0 'banyak keberhasilan
        Dim kegagalan As Integer = 0 'banyak kegagalan
        Dim mahasiswa As Integer = 1 'kounter mahasiswa
        Dim hasil As String ' satu hasil ujian

        'proses 10 hasil ujian; menggunakan loop terkendali kounter
        While mahasiswa <= 10
            Console.Write("Masukkan hasil (L = lulus, G = Gagal): ")
            hasil = Console.ReadLine()

            'struktur kendali bersarang

            If hasil = "l" Then
                keberhasilan += 1 'menambah banyak keberhasilan
            ElseIf hasil = "g" Then
                kegagalan += 1 'menambah nilai kegagalan
            End If

            mahasiswa += 1 'menambah kounter mahasiswa
        End While

        'menampilkan hasil ujian 
        Console.WriteLine("Lulus: {0}{1}Gagal: {2}", keberhasilan, vbCrLf, kegagalan)

        'menaikkan pembayaran
        If keberhasilan > 8 Then
            Console.WriteLine("Naikin biaya kuliahnya :D")
        End If

        Console.ReadLine()
    End Sub
End Module
