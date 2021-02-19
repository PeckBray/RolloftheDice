
''' <summary>
''' A collection of useful functions that can be referenced at any time
''' </summary>

Module libBP

    Function SayHello() As String
        Return ("Hello World")
    End Function
    ''' <summary>
    ''' Genereates a Random integer within range
    ''' </summary>
    ''' <param name="maxNumber"></param>
    ''' <returns>Returns random integer value from 0 to maxNumber inclusive</returns>
    Function GetRandomNumber(maxNumber As Integer)
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function
End Module
