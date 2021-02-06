Option Explicit On
Option Strict On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Fortune Cookie
'https://github.com/AftaAnfi/Fortune-Cookie.git
Module FortuneCookie
    ReadOnly wisdoms As String() = New String() {"You will breathe deeply", "Something amazing will occur", "You deserved that cookie", "Give a smile"}

    Dim runProgram As Boolean = True
    Dim readInputString As String
    Dim tempRND As Integer

    Sub Main()

        Randomize(Date.Now.Millisecond)

        While runProgram

            Console.Clear()
            Console.WriteLine("Press enter to recieve a wisdom...or press q to exit")

            'get input and make sure it's not q, but if it is Exit application
            readInputString = Console.ReadLine()
            If readInputString = "q" Or readInputString = "Q" Then
                Console.WriteLine("Have a nice day.")
                System.Threading.Thread.Sleep(1700)
                End

            End If
            Console.Clear()
            Console.WriteLine()

            'get a random number from the wisdoms array
            tempRND = CInt((wisdoms.Length - 1) * Rnd())

            'Give some flair with a ---------- above
            For i = 0 To wisdoms(tempRND).Length + 1
                Console.Write("-")
            Next
            Console.WriteLine()

            'Write fortune
            Console.WriteLine((wisdoms(tempRND).PadLeft(wisdoms(tempRND).Length + 1)))

            'Give the fortune flair with ---------- below
            For i = 0 To wisdoms(tempRND).Length + 1
                Console.Write("-")
            Next
            Console.WriteLine()
            Console.WriteLine()

            Console.WriteLine("Press enter to continue...")
            Console.ReadLine()

        End While

    End Sub

End Module
