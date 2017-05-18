
'4.2. Se tiene tres arrays cargados programáticamente con una lista de productos: el primero tiene el
'código, el segundo el nombre y el tercero el precio unitario. Repetitivamente se ingresa un
'código de producto y el programa muestra su descripción y precio, luego el usuario ingresa la
'cantidad con lo que el programa responde calculando el total del producto y el total general
'(acumulando los productos anteriores). Esto sucede hasta que el código sea cero

Module Ej04_02
    Sub main()
        Dim codProd() = New Short() {1, 2, 3}
        Dim nomProd() = New String() {"coca", "fanta", "manaos"}
        Dim precProd() = New Single() {45.4, 32.22, 23.99}
        Dim cod As Short
        cod = leerCodigo("Ingrese el código de producto o cero (0) para terminar")
        Console.WriteLine("El producto es:" & buscarCodigo(cod, codProd))
        Console.ReadKey()
    End Sub

    Private Function leerCodigo(mensaje As String) As Short
        Dim valor As Short
        Do
            Console.WriteLine(mensaje)
            valor = Console.ReadLine
        Loop Until validar(valor)
        Return valor
    End Function

    Private Function validar(valor As Short) As Boolean
        If valor = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function buscarCodigo(codig As Short, CodigoProd() As Short) As Integer
        Dim aux As Integer
        For i = 0 To CodigoProd.Length - 1
            If codig = CodigoProd(i) Then
                Return aux
            End If
        Next

    End Function

End Module
