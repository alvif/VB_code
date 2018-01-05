'kode 2.5: AkarKuadrat.vb
'menampilkan hasil akar kuadrat ke messagebox

Module AkarKuadrat
    Sub main()

        'hitung akar kuadrat dari 2
        Dim akar As Double
        Dim angka As Integer

        'input angka
        Console.WriteLine("masukkan angka = ")
        angka = Console.Read()

        akar = Math.Sqrt(angka)

        'menampilkan hasil dalam dialog
        MsgBox("akar kuadrat dari 2 adalah " & akar, MsgBoxStyle.Information, "Akar kuadrat dari " & akar)

    End Sub
End Module
