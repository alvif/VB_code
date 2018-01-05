'kode 2.4: Perbandingan
'modPerbandingan.vb
'mempelajari program perbandingan angka sederhana

Module modPerbandingan
    Sub Main()
        'mendeklarasikan variabel input sebagai integer
        Dim angkapertama, angkakedua As Integer

        'membaca input angka pertama
        Console.Write("Masukkin angka pertama: ")
        angkapertama = Console.ReadLine()

        'membaca input angka kedua
        Console.Write("Masukkin angka kedua: ")
        angkakedua = Console.ReadLine()

        If angkapertama = angkakedua Then
            Console.WriteLine("{0} = {1}", angkapertama, angkakedua)
        End If
        If angkapertama <> angkakedua Then
            Console.WriteLine("{0} <> {1}", angkapertama, angkakedua)
        End If
        If angkapertama > angkakedua Then
            Console.WriteLine("{0} > {1}", angkapertama, angkakedua)
        End If
        If angkapertama < angkakedua Then
            Console.WriteLine("{0} < {1}", angkapertama, angkakedua)
        End If
        If angkapertama <= angkakedua Then
            Console.WriteLine("{0} <= {1}", angkapertama, angkakedua)
        End If
        If angkapertama >= angkakedua Then
            Console.WriteLine("{0} >= {1}", angkapertama, angkakedua)
        End If

        Console.WriteLine()
        Console.Write("SUKSES 404 !!!")

        Console.Read()
    End Sub
End Module
