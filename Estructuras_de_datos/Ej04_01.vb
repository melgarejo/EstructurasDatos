
'4.1. Elaborar un algoritmo que permita cargar 5 números en un arreglo de 5 elementos; calcular la
'media y luego imprimir cada elemento del arreglo y la desviación que tiene respecto a la media.
'La MEDIA se obtiene la sumatoria de los todos elementos del arreglo y se divide por la cantidad
'de los mismos. La DESVIACION de cada elemento se obtiene restándole al elemento la
'MEDIA

Module Ej04_01

    Sub Main()
        Dim arreglo(4) As Integer
        Dim suma As Decimal
        Dim media As Decimal
        Dim desviacion As Decimal
        For i = 0 To arreglo.Count - 1
            Console.Write("Ingrese el " & i + 1 & "º número: ")
            arreglo(i) = Console.ReadLine()
            suma = suma + arreglo(i)
            media = suma / (i + 1)
            desviacion = arreglo(i) - media
            Console.WriteLine(i + 1 & "º elemento: " & arreglo(i))
            Console.WriteLine("Suma hasta el " & i + 1 & "º elemento: " & suma)
            Console.WriteLine("Media hasta el " & i + 1 & "º elemento: " & media)
            Console.WriteLine("Desviación del " & i + 1 & "º elemento: " & desviacion)
        Next
        Console.ReadKey()
    End Sub
End Module
