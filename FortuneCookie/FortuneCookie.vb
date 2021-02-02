Option Explicit On
Option Strict On
Module FortuneCookie
    ReadOnly wisdoms As String() = New String() {"You will breathe deeply", "Something amazing will occur", "You deserved that cookie", "Do something kind and kind will be done back"}

    Dim runProgram As Boolean = True

    Sub Main()
        Randomize(Date.Now.Millisecond)
        Console.WriteLine("Press enter to recieve a wisdom...")

        While runProgram




            Console.ReadLine()

            Console.WriteLine(wisdoms(CInt((wisdoms.Length - 1) * Rnd())))



        End While



    End Sub

End Module
