Imports System

Module Cipher
    Sub Main(args As String())
        Dim s As String = "ThisIsACipherThatIMadeUp"
        Console.WriteLine("Original message: {0}", s)
        Dim message As String = ""
        Dim shift As Integer = 1
        ' loop interating over characters
        For Each c As Char In s
            Dim i As Integer = Asc(c)
            i += shift
            ' overflow control
            If i > Asc("z") Then
                i -= 26
            End If
            Dim character As Char = Chr(i)
            message &= character
        Next

        'printing
        Console.WriteLine("Encrypted message: {0}", message)
        Console.ReadKey()
    End Sub
End Module
