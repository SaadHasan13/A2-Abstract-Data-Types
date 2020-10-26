Module Module1
    'Binary Tree ADT Via An Array
    Structure BT
        Dim LeftPointer As Integer
        Dim Data As String
        Dim RightPointer As Integer
    End Structure

    'Array based on Binary Tree ADT
    Dim DSBT(0 To 6) As BT

    Sub Main()
        Dim Count As Integer
        Dim ValueBT As String
        Dim Flag As Boolean = False
        For Count = 0 To 6
            DSBT(Count).LeftPointer = 0
            DSBT(Count).Data = " "
            DSBT(Count).RightPointer = 0
        Next

        For Count = 0 To 6
            Console.Write("Enter City Name " & Count + 1 & ": ")
            ValueBT = Console.ReadLine()
            insertBT(ValueBT)
        Next

        For Count = 0 To 6
            Console.WriteLine(Count & Space(7) & DSBT(Count).LeftPointer & " " & DSBT(Count).Data & Space(27 - Len(DSBT(Count).Data)) & DSBT(Count).RightPointer)
        Next
        Console.ReadKey()
    End Sub
    Sub insertBT(ByVal Value As String)
        Dim CP As Integer = 0 'CP = Current Position
        Dim TP As Integer = 0 'TP = Tree Position
        While True
            If DSBT(CP).Data = " " Then
                DSBT(CP).Data = Value
                Exit While
            ElseIf Value > DSBT(CP).Data Then
                If DSBT(CP).RightPointer = 0 Then
                    TP = CP
                    While DSBT(TP).Data <> " "
                        TP = TP + 1
                    End While
                    DSBT(TP).Data = Value
                    DSBT(CP).RightPointer = TP
                    Exit While
                Else
                    CP = DSBT(CP).RightPointer
                End If
            Else
                If DSBT(CP).LeftPointer = 0 Then
                    TP = CP
                    While DSBT(TP).Data <> " "
                        TP = TP + 1
                    End While
                    DSBT(TP).Data = Value
                    DSBT(CP).LeftPointer = TP
                    Exit While
                Else
                    CP = DSBT(CP).LeftPointer
                End If
            End If
        End While
    End Sub
End Module
