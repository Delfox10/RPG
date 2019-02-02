Module Module1
    Dim areanum As String = 1
    Dim areaname As String
    Dim left As String
    Dim right As String
    Dim forward As String
    Dim back As String
    Dim choice As String
    Dim narrate As String
    Dim areaback As String
    Dim cl, cr, cf, cb As Integer

    Sub Main()
        intro()
    End Sub

    Sub intro()
        Console.WriteLine("You wake up to the sound of " + vbCrLf + "clunky machienes hard at work, you have")
        Console.WriteLine("no idea who you are,where you are and how you got here.")
        Console.WriteLine("You are in a room with only a bed and a toilet, you wonder")
        Console.Read()
        area()
    End Sub

    Sub area()
        Console.Clear()
        surround()
        Console.WriteLine(narrate)
        Console.WriteLine("You are in: " + areaname + ".")
        Console.WriteLine("Ahead of you  " + forward)
        Console.WriteLine("Behind you  " + back)
        Console.WriteLine("To your left  " + left)
        Console.WriteLine("To your right  " + right)
        choice = Console.ReadLine()
        choose()
    End Sub

    Sub surround()
        If areanum = 0 Then
            Console.Clear()
            Console.WriteLine("You Can't go this way.")
            Console.ReadLine()
            areanum = areaback
            area()
        End If
        If areanum = 1 Then
            areaname = "spawn"
            left = "is nothing."
            right = "is nothing."
            forward = "a small shed."
            back = "is nothing."
            cf = 2
            cl = 0
            cr = 0
            cb = 0
        End If
        If areanum = 2 Then
            areaname = "Shed"
            left = "is an edgar."
            right = "is a zakk."
            forward = "is the shed door."
            back = "is spawn."
            cf = 3
            cl = 0
            cr = 0
            cb = 1
        End If
        If areanum = 3 Then
            areaname = "Shop"
            narrate = "under construct"
            left = "is nothing."
            right = "is spawn."
            forward = "is nothing"
            back = "is a creepy dude."
            cf = 0
            cr = 0
            cl = 0
            cb = 2
        End If
    End Sub

    Sub choose()
        '//////////////FORWARDCHOICE/////////////
        If choice = "forward" Then
            areaback = areanum
            areanum = cf
        End If
        '//////////////BACKCHOICE/////////////
        If choice = "back" Then
            areaback = areanum
            areanum = cb
        End If
        '//////////////LEFTCHOICE/////////////
        If choice = "left" Then
            areaback = areanum
            areanum = cl
        End If
        '//////////////RIGHTCHOICE/////////////
        If choice = "right" Then
            areaback = areanum
            areanum = cr
        End If
        area()
    End Sub

End Module
