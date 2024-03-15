Module Module1

    Sub Main()
        Dim notas(,) As Integer = {{100, 50, 30, 100, 80}, {85, 90, 95, 88, 92}, {75, 80, 85, 70, 90}, {95, 88, 92, 85, 90}, {70, 75, 80, 65, 85}}
        Dim nombres() As String = {"Carol", "Verónica", "Diana", "Juan", "Antonio"}
        Dim i, j As Integer
        Dim promedio As Double

        For i = 0 To 4
            Dim acum As Integer = 0
            Console.WriteLine("-------------------")
            Console.WriteLine("Notas de " + nombres(i) + ":")
            For j = 0 To 4
                Console.WriteLine("Nota " + (j + 1).ToString + ": " + notas(i, j).ToString)
                acum += notas(i, j)
            Next
            promedio = acum / 5
            Console.WriteLine("Promedio de " + nombres(i) + ": " + promedio.ToString)
        Next
        Console.WriteLine("-------------------")
        Console.ReadKey()
    End Sub

End Module