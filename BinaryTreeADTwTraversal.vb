Module Module1
    Structure BinaryTree
        Dim LeftPointer As Integer
        Dim Data As String
        Dim RightPointer As Integer
    End Structure
    Dim DSBT(0 To 6) As BinaryTree
    Sub Main()
        Dim r As Integer
        Dim Count As Integer
        Dim ValueBT As String
        r = 0
        For Count = 0 To 6
            DSBT(Count).LeftPointer = 0
            DSBT(Count).Data = ""
            DSBT(Count).RightPointer = 0
        Next
        For Count = 0 To 6
            Console.Write("Enter Name " & Count + 1 & ": ")
            ValueBT = Console.ReadLine()
            insertBT(ValueBT)
        Next
        For Count = 0 To 6
            Console.WriteLine(Count & Space(7) & DSBT(Count).LeftPointer & " " & DSBT(Count).Data & Space(27 - Len(DSBT(Count).Data)) & DSBT(Count).RightPointer)
        Next
        TraverseTree(r)
        Console.ReadKey()
    End Sub
    Sub insertBT(ByVal Value As String)
        Dim CurrentPointer As Integer = 0
        Dim TreePosition As Integer = 0
        While True
            If DSBT(CurrentPointer).Data = "" Then
                DSBT(CurrentPointer).Data = Value
                Exit While
            ElseIf Value > DSBT(CurrentPointer).Data Then
                If DSBT(CurrentPointer).RightPointer = 0 Then
                    TreePosition = CurrentPointer
                    While DSBT(TreePosition).Data <> ""
                        TreePosition = TreePosition + 1
                    End While
                    DSBT(TreePosition).Data = Value
                    DSBT(CurrentPointer).RightPointer = TreePosition
                    Exit While
                Else
                    CurrentPointer = DSBT(CurrentPointer).RightPointer
                End If
            Else
                If DSBT(CurrentPointer).LeftPointer = 0 Then
                    TreePosition = CurrentPointer
                    While DSBT(TreePosition).Data <> ""
                        TreePosition = TreePosition + 1
                    End While
                    DSBT(TreePosition).Data = Value
                    DSBT(CurrentPointer).LeftPointer = TreePosition
                    Exit While
                Else
                    CurrentPointer = DSBT(CurrentPointer).LeftPointer
                End If
            End If
        End While
    End Sub
    Sub TraverseTree(ByVal Root As Integer)
        If dsBT(Root).LeftPointer <> 0 Then

            TraverseTree(dsBT(Root).LeftPointer)
        End If
        Console.WriteLine(dsBT(Root).Data)
        If dsBT(Root).RightPointer <> 0 Then

            TraverseTree(dsBT(Root).RightPointer)
        End If
    End Sub
End Module
