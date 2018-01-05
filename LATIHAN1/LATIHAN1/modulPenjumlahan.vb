'kode 2.3: modulPenjumlahan.vb
'Program penjumlahan sederhana..

Module modulPenjumlahan
    Sub Main()

        'variabel penampung nilai input
        Dim angkapertama, angkakedua As Integer

        'variabel untuk penjumlahan input
        Dim angka1, angka2, hasilakhir As Integer

        'membaca input integer pertama
        Console.Write("Masukin integer pertama: ")
        angkapertama = Console.ReadLine()

        'membaca input integer kedua
        Console.Write("Masukin integer kedua: ")
        angkakedua = Console.ReadLine()

        'mengkonversi masukkan ke variabel penjumlahan
        angka1 = angkapertama
        angka2 = angkakedua

        'menjumlahkan 2 masukan
        hasilakhir = angka1 + angka2

        'menampilkan hasil penjumlahan
        Console.WriteLine("Hasilnya adalah {0}", hasilakhir)
        Console.Write("Yeeeayy!! Berhasil :D")
        Console.Read()
    End Sub
End Module
