Option Strict On
Option Explicit On
Module Module1

    Sub Main()
        Dim randomNumbers(10) As Integer
        '"roll" for random numbers between 0 and 10
        For i = 0 To 1000
            randomNumbers(GetRandomNumber(10)) += 1

        Next

        Console.WriteLine("Roll of the Dice")
        Console.WriteLine()

        'create divider between the lines
        Console.WriteLine(StrDup(77, "-"))

        'list the numbers from 2 to 12 and add dividers between numbers
        For i = 2 To 12
            Console.Write(Str(i).PadLeft(6) & "|")
        Next
        Console.WriteLine()

        'create divider between the lines
        Console.WriteLine(StrDup(77, "-"))

        'will write out how many times each number was "rolled" and divides the numbers with lines
        For i = 0 To UBound(randomNumbers)
            Console.Write(Str(randomNumbers(i)).PadLeft(6) & "|")
        Next
        Console.WriteLine()
        'create divider between the lines
        Console.WriteLine(StrDup(77, "-"))

        Console.Read()
    End Sub
    ''' <summary>
    ''' this function will return a random number between 1 and a maximum number that is input
    ''' </summary>
    ''' <param name="maxNumber"></param>
    ''' <returns></returns>
    Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

End Module
